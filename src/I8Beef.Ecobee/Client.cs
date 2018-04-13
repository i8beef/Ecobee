using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using I8Beef.Ecobee.Exceptions;
using I8Beef.Ecobee.Messages;
using I8Beef.Ecobee.Protocol;

namespace I8Beef.Ecobee
{
    /// <summary>
    /// Ecobee client implementation.
    /// </summary>
    public class Client
    {
        private const string _baseUri = "https://api.ecobee.com/";
        private const int _version = 1;
        private static HttpClient _httpClient = new HttpClient { Timeout = Timeout.InfiniteTimeSpan };
        private TimeSpan _timeout;

        private string _appKey;
        private Func<CancellationToken, Task<StoredAuthToken>> _getStoredAuthTokenFunc;
        private Func<StoredAuthToken, CancellationToken, Task> _setStoredAuthTokenFunc;

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="appKey">Ecobee application key.</param>
        /// <param name="getStoredAuthTokenFunc">Lambda function responsible for retrieving current Ecobee auth token data from permanent storage.</param>
        /// <param name="setStoredAuthTokenFunc">Lambda function responsible for saving current Ecobee auth token data to permanent storage.</param>
        public Client(
            string appKey,
            Func<CancellationToken, Task<StoredAuthToken>> getStoredAuthTokenFunc,
            Func<StoredAuthToken, CancellationToken, Task> setStoredAuthTokenFunc)
            : this(appKey, getStoredAuthTokenFunc, setStoredAuthTokenFunc, TimeSpan.FromSeconds(100))
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="appKey">Ecobee application key.</param>
        /// <param name="getStoredAuthTokenFunc">Lambda function responsible for retrieving current Ecobee auth token data from permanent storage.</param>
        /// <param name="setStoredAuthTokenFunc">Lambda function responsible for saving current Ecobee auth token data to permanent storage.</param>
        /// <param name="timeout">Timeout for all HTTP calls.</param>
        public Client(
            string appKey,
            Func<CancellationToken, Task<StoredAuthToken>> getStoredAuthTokenFunc,
            Func<StoredAuthToken, CancellationToken, Task> setStoredAuthTokenFunc,
            TimeSpan timeout)
        {
            _getStoredAuthTokenFunc = getStoredAuthTokenFunc ?? throw new ArgumentNullException(nameof(getStoredAuthTokenFunc));
            _setStoredAuthTokenFunc = setStoredAuthTokenFunc ?? throw new ArgumentNullException(nameof(setStoredAuthTokenFunc));

            _appKey = appKey;
            _timeout = timeout;
        }

        /// <summary>
        /// Executes HttpClient.SendAsync() with a timeout extension.
        /// </summary>
        /// <param name="requestMessage">Same as parameters in HttpClient.SendAsync()</param>
        /// <param name="cancellationToken">Same as parameters in HttpClient.SendAsync()</param>
        /// <returns>The <see cref="HttpResponseMessage"/>.</returns>
        /// <remarks>
        /// The HttpClient has a Timout feature that has been poorly implemented in that it raises an ambiguous exception on timeout.
        /// This wraps the HttpClient.SendAsync() and adds a proper timeout option.
        /// </remarks>
        private async Task<HttpResponseMessage> SendAsyncWithTimeout(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default(CancellationToken))
        {
            var timoutCts = new CancellationTokenSource(_timeout);
            var aggregateCts = CancellationTokenSource.CreateLinkedTokenSource(timoutCts.Token, cancellationToken);

            try
            {
                return await _httpClient.SendAsync(requestMessage, aggregateCts.Token)
                    .ConfigureAwait(false);
            }
            catch (TaskCanceledException) when (timoutCts.IsCancellationRequested)
            {
                throw new TimeoutException("HTTP request to Ecobee API servers timed out.");
            }
        }

        /// <summary>
        /// Get a pin from Ecobee API for pairing.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A <see cref="Pin"/>.</returns>
        public async Task<Pin> GetPinAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, _baseUri + "authorize?response_type=ecobeePin&client_id=" + _appKey + "&scope=smartWrite");
            requestMessage.Headers.ExpectContinue = false;

            var response = await SendAsyncWithTimeout(requestMessage, cancellationToken)
                .ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                throw new ApiAuthException(JsonSerializer<ApiError>.Deserialize(responseString));

            return JsonSerializer<Pin>.Deserialize(responseString);
        }

        /// <summary>
        /// Get an access token using the specified auth code.
        /// </summary>
        /// <param name="authCode">Code previously provided by Ecobee.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        public async Task GetAccessTokenAsync(string authCode, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, _baseUri + "token?grant_type=ecobeePin&code=" + authCode + "&client_id=" + _appKey);
            requestMessage.Headers.ExpectContinue = false;

            var response = await SendAsyncWithTimeout(requestMessage, cancellationToken)
                .ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                throw new ApiAuthException(JsonSerializer<ApiError>.Deserialize(responseString));

            var authToken = JsonSerializer<AuthToken>.Deserialize(responseString);
            var storedAuthToken = new StoredAuthToken
            {
                AccessToken = authToken.AccessToken,
                RefreshToken = authToken.RefreshToken,
                TokenExpiration = DateTime.Now.AddSeconds(authToken.ExpiresIn)
            };

            await _setStoredAuthTokenFunc(storedAuthToken, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Peforms a GET operation against the Ecobee API.
        /// </summary>
        /// <typeparam name="TRequest">The type of request to send to the Ecobee API.</typeparam>
        /// <typeparam name="TResponse">The type of response from the Ecobee API.</typeparam>
        /// <param name="request">The request to send to the Ecobee API.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response from the Ecobee API.</returns>
        public async Task<TResponse> GetAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken = default(CancellationToken))
            where TRequest : RequestBase
            where TResponse : Response
        {
            var storedAuthToken = await GetCurrentAuthTokenAsync(cancellationToken)
                .ConfigureAwait(false);

            var message = JsonSerializer<TRequest>.Serialize(request);
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, _baseUri + _version + request.Uri + "?json=" + message);
            requestMessage.Headers.ExpectContinue = false;
            requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", storedAuthToken.AccessToken);
            requestMessage.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            requestMessage.Headers.TryAddWithoutValidation("Content-Type", "application/json");

            var response = await SendAsyncWithTimeout(requestMessage, cancellationToken)
                .ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                throw new ApiException(JsonSerializer<Response>.Deserialize(responseString));

            return JsonSerializer<TResponse>.Deserialize(responseString);
        }

        /// <summary>
        /// Peforms a POST operation against the Ecobee API.
        /// </summary>
        /// <typeparam name="TRequest">The type of request to send to the Ecobee API.</typeparam>
        /// <typeparam name="TResponse">The type of response from the Ecobee API.</typeparam>
        /// <param name="request">The request to send to the Ecobee API.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response from the Ecobee API.</returns>
        public async Task<TResponse> PostAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken = default(CancellationToken))
            where TRequest : RequestBase
            where TResponse : Response
        {
            var storedAuthToken = await GetCurrentAuthTokenAsync(cancellationToken)
                .ConfigureAwait(false);

            var message = JsonSerializer<TRequest>.Serialize(request);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, _baseUri + _version + request.Uri + "?format=json");
            requestMessage.Headers.ExpectContinue = false;
            requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", storedAuthToken.AccessToken);
            requestMessage.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            requestMessage.Content = new StringContent(message, System.Text.Encoding.UTF8, "application/json");

            var response = await SendAsyncWithTimeout(requestMessage, cancellationToken)
                .ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                throw new ApiException(JsonSerializer<Response>.Deserialize(responseString));

            return JsonSerializer<TResponse>.Deserialize(responseString);
        }

        /// <summary>
        /// Gets current auth token and handles refresh.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A <see cref="StoredAuthToken"/>.</returns>
        private async Task<StoredAuthToken> GetCurrentAuthTokenAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var storedAuthToken = await _getStoredAuthTokenFunc(cancellationToken)
               .ConfigureAwait(false);

            if (storedAuthToken == null)
            {
                throw new NullReferenceException("Auth token storage delegate failed to provide token.");
            }

            if (DateTime.Compare(DateTime.Now, storedAuthToken.TokenExpiration) >= 0)
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Post, _baseUri + "token?grant_type=refresh_token&refresh_token=" + storedAuthToken.RefreshToken + "&client_id=" + _appKey);
                requestMessage.Headers.ExpectContinue = false;

                var response = await SendAsyncWithTimeout(requestMessage, cancellationToken)
                    .ConfigureAwait(false);
                var responseString = await response.Content.ReadAsStringAsync()
                    .ConfigureAwait(false);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new ApiAuthException(JsonSerializer<ApiError>.Deserialize(responseString));

                var authToken = JsonSerializer<AuthToken>.Deserialize(responseString);
                storedAuthToken = new StoredAuthToken
                {
                    AccessToken = authToken.AccessToken,
                    RefreshToken = authToken.RefreshToken,
                    TokenExpiration = DateTime.Now.AddSeconds(authToken.ExpiresIn)
                };

                await _setStoredAuthTokenFunc(storedAuthToken, cancellationToken)
                    .ConfigureAwait(false);
            }

            return storedAuthToken;
        }
    }
}
