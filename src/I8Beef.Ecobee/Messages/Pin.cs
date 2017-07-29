using Newtonsoft.Json;

namespace I8Beef.Ecobee.Messages
{
    /// <summary>
    /// Ecobee authorization pin.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Pin
    {
        /// <summary>
        /// Ecobee pin.
        /// </summary>
        [JsonProperty(PropertyName = "ecobeePin")]
        public string EcobeePin { get; set; }

        /// <summary>
        /// Pin code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Scope of pin.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Time until expiration.
        /// </summary>
        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Pin interval.
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public int Interval { get; set; }
    }
}
