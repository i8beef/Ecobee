using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Utility.Demand
{
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
