using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Utility.Demand
{
    /// <summary>
    /// Ecobee API issue demand response.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class IssueDemandResponse : Response
    {
        /// <summary>
        /// unique demand response reference ID.
        /// </summary>
        [JsonProperty(PropertyName = "demandResponseRef")]
        public string DemandResponseRef { get; set; }
    }
}
