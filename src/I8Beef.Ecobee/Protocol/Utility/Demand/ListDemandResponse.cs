using I8Beef.Ecobee.Protocol.Objects;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Utility.Demand
{
    [DataContract]
    public class ListDemandResponse : Response
    {
        public ListDemandResponse()
        {
            DrList = new List<DemandResponse>();
        }

        /// <summary>
        /// list of demand responses which have not yet expired.
        /// </summary>
        [DataMember(Name = "drList")]
        public IList<DemandResponse> DrList { get; set; }
    }
}
