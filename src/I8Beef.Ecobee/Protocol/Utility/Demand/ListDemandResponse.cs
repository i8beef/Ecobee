using System.Collections.Generic;
using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Utility.Demand
{
    /// <summary>
    /// Ecobee API list demand response.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ListDemandResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListDemandResponse"/> class.
        /// </summary>
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
