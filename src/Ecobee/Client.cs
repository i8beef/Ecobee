using Ecobee.Exceptions;
using Ecobee.Messages;
using Ecobee.Protocol;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ecobee
{
    public class Client
    {
        private const string _baseUri = "https://api.ecobee.com/";
        private const int _version = 1;
        private TimeSpan _timeout = TimeSpan.FromSeconds(30);

        private string _appKey;
        private string _authToken;
        private string _refreshToken;
        private DateTime _tokenExpiration;

        public event EventHandler<AuthToken> AuthTokenUpdated;

        public Client(string appKey, string authToken, string refreshToken, DateTime tokenExpiration)
        {
            _appKey = appKey;
            _authToken = authToken;
            _refreshToken = refreshToken;
            _tokenExpiration = tokenExpiration;
        }

        public static async Task<Pin> GetPin(string appKey)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_baseUri + "authorize?response_type=ecobeePin&client_id=" + appKey + "&scope=smartWrite");
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new ApiException(JsonSerializer<ApiError>.Deserialize(responseString));

                return JsonSerializer<Pin>.Deserialize(responseString);
            }
        }

        public static async Task<AuthToken> GetAccessToken(string appKey, string authToken)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(_baseUri + "token?grant_type=ecobeePin&code=" + authToken + "&client_id=" + appKey, null);
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new ApiException(JsonSerializer<ApiError>.Deserialize(responseString));

                return JsonSerializer<AuthToken>.Deserialize(responseString);
            }
        }

        public async Task<TResponse> Get<TRequest, TResponse>(TRequest request)
            where TRequest : RequestBase
            where TResponse : Response
        {
            if (DateTime.Compare(DateTime.Now, _tokenExpiration) >= 0)
                await GetRefreshToken();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _authToken);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

                var message = JsonSerializer<TRequest>.Serialize(request);
                var response = await client.GetAsync(_baseUri + _version + request.Uri + "?json=" + message);
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new ApiException(JsonSerializer<ApiError>.Deserialize(responseString));

                return JsonSerializer<TResponse>.Deserialize(responseString);
            }
        }

        public async Task<TResponse> Post<TRequest, TResponse>(TRequest request)
            where TRequest : RequestBase
            where TResponse : Response
        {
            if (DateTime.Compare(DateTime.Now, _tokenExpiration) >= 0)
                await GetRefreshToken();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _authToken);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var message = JsonSerializer<TRequest>.Serialize(request);
                var content = new StringContent(message, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(_baseUri + _version + request.Uri + "?format=json", content);
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new ApiException(JsonSerializer<ApiError>.Deserialize(responseString));

                return JsonSerializer<TResponse>.Deserialize(responseString);
            }
        }

        private async Task GetRefreshToken()
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(_baseUri + "token?grant_type=refresh_token&refresh_token=" + _refreshToken + "&client_id=" + _appKey, null);
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new ApiException(JsonSerializer<ApiError>.Deserialize(responseString));

                var authToken = JsonSerializer<AuthToken>.Deserialize(responseString);
                _authToken = authToken.AccessToken;
                _refreshToken = authToken.RefreshToken;
                _tokenExpiration = DateTime.Now.AddSeconds(authToken.ExpiresIn);

                // Raise event for callers to persist new auth tokens
                AuthTokenUpdated?.Invoke(this, authToken);
            }
        }
    }
}
