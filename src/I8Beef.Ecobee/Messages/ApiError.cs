using Newtonsoft.Json;

namespace I8Beef.Ecobee.Messages
{
    /// <summary>
    /// Ecobee API Error.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ApiError
    {
        /// <summary>
        /// Error code.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        /// <summary>
        /// Error description.
        /// </summary>
        [JsonProperty(PropertyName = "error_description")]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Error URI.
        /// </summary>
        [JsonProperty(PropertyName = "error_uri")]
        public string ErrorUri { get; set; }
    }
}
