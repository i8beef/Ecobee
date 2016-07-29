using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Utility.Demand
{
    [DataContract]
    public class IssueDemandResponse : Response
    {
        /// <summary>
        /// unique demand response reference ID.
        /// </summary>
        [DataMember(Name = "demandResponseRef")]
        public string DemandResponseRef { get; set; }
    }
}
