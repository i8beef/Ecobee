using System;

namespace I8Beef.Ecobee
{
    /// <summary>
    /// Ecobee authorization token data that needs to be stored.
    /// </summary>
    public class StoredAuthToken
    {
        /// <summary>
        /// Ecobee access token.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Ecobee refresh token.
        /// </summary>
        public string RefreshToken { get; set; }

        /// <summary>
        /// Ecobee token expiration time.
        /// </summary>
        public DateTime TokenExpiration { get; set; }
    }
}
