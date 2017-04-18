using Newtonsoft.Json;

namespace I8Beef.Ecobee.Messages
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Pin
    {
        [JsonProperty(PropertyName = "ecobeePin")]
        public string EcobeePin { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty(PropertyName = "interval")]
        public int Interval { get; set; }
    }
}
