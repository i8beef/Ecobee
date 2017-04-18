using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Utility.Demand
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ListDemandResponse : Response
    {
        public ListDemandResponse()
        {
            DrList = new List<DemandResponse>();
        }

        /// <summary>
        /// list of demand responses which have not yet expired.
        /// </summary>
        [JsonProperty(PropertyName = "drList")]
        public IList<DemandResponse> DrList { get; set; }
    }
}
