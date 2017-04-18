using Newtonsoft.Json;

namespace I8Beef.Ecobee.Messages
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ApiError
    {
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        [JsonProperty(PropertyName = "error_description")]
        public string ErrorDescription { get; set; }

        [JsonProperty(PropertyName = "error_uri")]
        public string ErrorUri { get; set; }

    }
}
