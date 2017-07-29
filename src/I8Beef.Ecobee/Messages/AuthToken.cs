using Newtonsoft.Json;

namespace I8Beef.Ecobee.Messages
{
    /// <summary>
    /// Ecobee authorization token.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AuthToken
    {
        /// <summary>
        /// Access token.
        /// </summary>
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Type of token.
        /// </summary>
        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// Time until expiration.
        /// </summary>
        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Refresh token.
        /// </summary>
        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Scope of token.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }
    }
}
