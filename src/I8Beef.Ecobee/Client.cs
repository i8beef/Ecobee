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
        private static HttpClient _httpClient = new HttpClient();
        private TimeSpan _timeout = TimeSpan.FromSeconds(30);

        private string _appKey;
        private string _authToken;
        private string _refreshToken;
        private DateTime _tokenExpiration;

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="appKey">Ecobee application key.</param>
        /// <param name="authToken">Ecobee authorization token.</param>
        /// <param name="refreshToken">Ecobee refresh token.</param>
        /// <param name="tokenExpiration">Ecobee token expiration time.</param>
        public Client(string appKey, string authToken, string refreshToken, DateTime tokenExpiration)
        {
            _appKey = appKey;
            _authToken = authToken;
            _refreshToken = refreshToken;
            _tokenExpiration = tokenExpiration;
        }

        /// <summary>
        /// Event evoked when authorization token is updated.
        /// </summary>
        public event EventHandler<AuthTokenUpdatedEventArgs> AuthTokenUpdated;

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

            var response = await _httpClient.SendAsync(requestMessage, cancellationToken)
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
        /// <param name="authToken">Original authorization token.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A <see cref="AuthToken"/>.</returns>
        public static async Task<AuthToken> GetAccessTokenAsync(string appKey, string authToken, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, _baseUri + "token?grant_type=ecobeePin&code=" + authToken + "&client_id=" + appKey);
            requestMessage.Headers.ExpectContinue = false;

            var response = await _httpClient.SendAsync(requestMessage, cancellationToken)
                .ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                throw new ApiAuthException(JsonSerializer<ApiError>.Deserialize(responseString));

            return JsonSerializer<AuthToken>.Deserialize(responseString);
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
            if (DateTime.Compare(DateTime.Now, _tokenExpiration) >= 0)
            {
                await GetRefreshTokenAsync(cancellationToken)
                    .ConfigureAwait(false);
            }

            var message = JsonSerializer<TRequest>.Serialize(request);
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, _baseUri + _version + request.Uri + "?json=" + message);
            requestMessage.Headers.ExpectContinue = false;
            requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _authToken);
            requestMessage.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            requestMessage.Headers.TryAddWithoutValidation("Content-Type", "application/json");

            var response = await _httpClient.SendAsync(requestMessage, cancellationToken)
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
            if (DateTime.Compare(DateTime.Now, _tokenExpiration) >= 0)
            {
                await GetRefreshTokenAsync(cancellationToken)
                   .ConfigureAwait(false);
            }

            var message = JsonSerializer<TRequest>.Serialize(request);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, _baseUri + _version + request.Uri + "?format=json");
            requestMessage.Headers.ExpectContinue = false;
            requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _authToken);
            requestMessage.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            requestMessage.Content = new StringContent(message, System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.SendAsync(requestMessage, cancellationToken)
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
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, _baseUri + "token?grant_type=refresh_token&refresh_token=" + _refreshToken + "&client_id=" + _appKey);
            requestMessage.Headers.ExpectContinue = false;

            var response = await _httpClient.SendAsync(requestMessage, cancellationToken)
                .ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                throw new ApiAuthException(JsonSerializer<ApiError>.Deserialize(responseString));

            var authToken = JsonSerializer<AuthToken>.Deserialize(responseString);
            _authToken = authToken.AccessToken;
            _refreshToken = authToken.RefreshToken;
            _tokenExpiration = DateTime.Now.AddSeconds(authToken.ExpiresIn);

            // Raise event for callers to persist new auth tokens
            AuthTokenUpdated?.Invoke(this, new AuthTokenUpdatedEventArgs(authToken));
        }
    }
}
