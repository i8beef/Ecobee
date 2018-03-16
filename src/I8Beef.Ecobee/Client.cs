using System;
using System.Net.Http;
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
        /// <returns>A <see cref="Pin"/>.</returns>
        public static async Task<Pin> GetPinAsync(string appKey)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_baseUri + "authorize?response_type=ecobeePin&client_id=" + appKey + "&scope=smartWrite");
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new ApiAuthException(JsonSerializer<ApiError>.Deserialize(responseString));

                return JsonSerializer<Pin>.Deserialize(responseString);
            }
        }

        /// <summary>
        /// Get an access token.
        /// </summary>
        /// <param name="appKey">Ecobee application key.</param>
        /// <param name="authToken">Original authorization token.</param>
        /// <returns>A <see cref="AuthToken"/>.</returns>
        public static async Task<AuthToken> GetAccessTokenAsync(string appKey, string authToken)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(_baseUri + "token?grant_type=ecobeePin&code=" + authToken + "&client_id=" + appKey, null);
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new ApiAuthException(JsonSerializer<ApiError>.Deserialize(responseString));

                return JsonSerializer<AuthToken>.Deserialize(responseString);
            }
        }

        /// <summary>
        /// Peforms a GET operation against the Ecobee API.
        /// </summary>
        /// <typeparam name="TRequest">The type of request to send to the Ecobee API.</typeparam>
        /// <typeparam name="TResponse">The type of response from the Ecobee API.</typeparam>
        /// <param name="request">The request to send to the Ecobee API.</param>
        /// <returns>The response from the Ecobee API.</returns>
        public async Task<TResponse> GetAsync<TRequest, TResponse>(TRequest request)
            where TRequest : RequestBase
            where TResponse : Response
        {
            if (DateTime.Compare(DateTime.Now, _tokenExpiration) >= 0)
                await GetRefreshTokenAsync();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _authToken);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

                var message = JsonSerializer<TRequest>.Serialize(request);
                var response = await client.GetAsync(_baseUri + _version + request.Uri + "?json=" + message);
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new ApiException(JsonSerializer<Response>.Deserialize(responseString));

                return JsonSerializer<TResponse>.Deserialize(responseString);
            }
        }

        /// <summary>
        /// Peforms a POST operation against the Ecobee API.
        /// </summary>
        /// <typeparam name="TRequest">The type of request to send to the Ecobee API.</typeparam>
        /// <typeparam name="TResponse">The type of response from the Ecobee API.</typeparam>
        /// <param name="request">The request to send to the Ecobee API.</param>
        /// <returns>The response from the Ecobee API.</returns>
        public async Task<TResponse> PostAsync<TRequest, TResponse>(TRequest request)
            where TRequest : RequestBase
            where TResponse : Response
        {
            if (DateTime.Compare(DateTime.Now, _tokenExpiration) >= 0)
                await GetRefreshTokenAsync();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _authToken);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var message = JsonSerializer<TRequest>.Serialize(request);
                var content = new StringContent(message, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(_baseUri + _version + request.Uri + "?format=json", content);
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new ApiException(JsonSerializer<Response>.Deserialize(responseString));

                return JsonSerializer<TResponse>.Deserialize(responseString);
            }
        }

        /// <summary>
        /// Requests a refresh token from the Ecobee API.
        /// </summary>
        /// <returns>A <see cref="Task"/>.</returns>
        private async Task GetRefreshTokenAsync()
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(_baseUri + "token?grant_type=refresh_token&refresh_token=" + _refreshToken + "&client_id=" + _appKey, null);
                var responseString = await response.Content.ReadAsStringAsync();
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
}
