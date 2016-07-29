using System.Runtime.Serialization;

namespace Ecobee.Protocol.Utility.Demand
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
