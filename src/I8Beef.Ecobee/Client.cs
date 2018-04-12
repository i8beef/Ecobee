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
        private static HttpClient _httpClient = new HttpClient() { Timeout = System.Threading.Timeout.InfiniteTimeSpan }; // InfiniteTimeSpan in effect disables the native HttpClient Timout since we implemented our own

        private string _appKey;
        private StoredAuthToken _storedAuthToken;
        private Func<CancellationToken, Task<StoredAuthToken>> _getStoredAuthTokenFunc;
        private Func<StoredAuthToken, CancellationToken, Task> _setStoredAuthTokenFunc;

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="appKey">Ecobee application key.</param>
        /// <param name="storedAuthToken">Ecobee authorization token data.</param>
        /// <param name="setStoredAuthTokenFunc">Lambda function responsible for saving current Ecobee auth token data to permanent storage.</param>
        /// <remarks>For single tenant Ecobee token storage. Auth tokens are stored per instance.</remarks>
        public Client(string appKey, StoredAuthToken storedAuthToken, Func<StoredAuthToken, CancellationToken, Task> setStoredAuthTokenFunc)
        {
            _appKey = appKey;
            _storedAuthToken = storedAuthToken;
            _setStoredAuthTokenFunc = setStoredAuthTokenFunc;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="appKey">Ecobee application key.</param>
        /// <param name="getStoredAuthTokenFunc">Lambda function responsible for retrieving current Ecobee auth token data from permanent storage.</param>
        /// <param name="setStoredAuthTokenFunc">Lambda function responsible for saving current Ecobee auth token data to permanent storage.</param>
        /// <remarks>
        /// For multi-tenant Ecobee token storage. For example when multiple client instances (i.e. separate devices), but same user, need to share the same
        /// token data. In this case tokens must be retrieved on demand from a common data repository (e.g. database).
        /// </remarks>
        public Client(string appKey, Func<CancellationToken, Task<StoredAuthToken>> getStoredAuthTokenFunc, Func<StoredAuthToken, CancellationToken, Task> setStoredAuthTokenFunc)
        {
            _appKey = appKey;
            _getStoredAuthTokenFunc = getStoredAuthTokenFunc;
            _setStoredAuthTokenFunc = setStoredAuthTokenFunc;
        }

        /// <summary>
        /// Timeout for all HTTP requests. Default is 100 seconds.
        /// </summary>
        public static TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(100);

        /// <summary>
        /// Get a pin from Ecobee API for pairing.
        /// </summary>
        /// <param name="appKey">Ecobee application key.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A <see cref="Pin"/>.</returns>
        public static async Task<Pin> GetPinAsync(string appKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, _baseUri + "authorize?response_type=ecobeePin&client_id=" + appKey + "&scope=smartWrite");
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
        /// Get an access token.
        /// </summary>
        /// <param name="appKey">Ecobee application key.</param>
        /// <param name="authCode">Code previously provided by Ecobee.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A <see cref="StoredAuthToken"/>.</returns>
        public static async Task<StoredAuthToken> GetAccessTokenAsync(string appKey, string authCode, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, _baseUri + "token?grant_type=ecobeePin&code=" + authCode + "&client_id=" + appKey);
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

            return storedAuthToken;
        }

        /// <summary>
        /// Adds custom timout feature to HttpClient.SendAsync()
        /// </summary>
        /// <param name="requestMessage">Same as parameters in HttpClient.SendAsync()</param>
        /// <param name="cancellationToken">Same as parameters in HttpClient.SendAsync()</param>
        /// <returns>
        /// The HttpClient has a Timout feature that has been poorly implemented in that it raises an ambiguous exception on timeout.
        /// This wraps the HttpClient.SendAsync() and adds a proper timeout option.
        /// </returns>
        private static async Task<HttpResponseMessage> SendAsyncWithTimeout(HttpRequestMessage requestMessage, CancellationToken cancellationToken)
        {
            var timoutCts = new CancellationTokenSource(Timeout);
            var aggregateCts = CancellationTokenSource.CreateLinkedTokenSource(timoutCts.Token, cancellationToken);

            HttpResponseMessage responseMessage;
            try
            {
                responseMessage = await _httpClient.SendAsync(requestMessage, aggregateCts.Token)
                    .ConfigureAwait(false);
            }
            catch (TaskCanceledException) when (timoutCts.IsCancellationRequested)
            {
                throw new TimeoutException("HTTP request to Ecobee API servers timed out.");
            }

            return responseMessage;
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
            if (_getStoredAuthTokenFunc != null)
            {
                _storedAuthToken = await _getStoredAuthTokenFunc.Invoke(cancellationToken)
                    .ConfigureAwait(false);
            }

            if (DateTime.Compare(DateTime.Now, _storedAuthToken.TokenExpiration) >= 0)
            {
                await GetRefreshTokenAsync(cancellationToken)
                    .ConfigureAwait(false);
            }

            var message = JsonSerializer<TRequest>.Serialize(request);
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, _baseUri + _version + request.Uri + "?json=" + message);
            requestMessage.Headers.ExpectContinue = false;
            requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _storedAuthToken.AccessToken);
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
            if (_getStoredAuthTokenFunc != null)
            {
                _storedAuthToken = await _getStoredAuthTokenFunc.Invoke(cancellationToken)
                    .ConfigureAwait(false);
            }

            if (DateTime.Compare(DateTime.Now, _storedAuthToken.TokenExpiration) >= 0)
            {
                await GetRefreshTokenAsync(cancellationToken)
                   .ConfigureAwait(false);
            }

            var message = JsonSerializer<TRequest>.Serialize(request);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, _baseUri + _version + request.Uri + "?format=json");
            requestMessage.Headers.ExpectContinue = false;
            requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _storedAuthToken.AccessToken);
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
        /// Requests a refresh token from the Ecobee API.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        private async Task GetRefreshTokenAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, _baseUri + "token?grant_type=refresh_token&refresh_token=" + _storedAuthToken.RefreshToken + "&client_id=" + _appKey);
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
            _storedAuthToken = storedAuthToken;
            if (_setStoredAuthTokenFunc != null)
            {
                await _setStoredAuthTokenFunc.Invoke(storedAuthToken, cancellationToken)
                    .ConfigureAwait(false);
            }
        }
    }
}
