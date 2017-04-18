using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Utility.Demand
{
    [JsonObject(MemberSerialization.OptIn)]
    public class IssueDemandManagementRequest : RequestBase
    {
        public IssueDemandManagementRequest()
        {
            DmList = new List<DemandManagement>();
        }

        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/demandManagement"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.POST; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(Response); } }

        /// <summary>
        /// The selection criteria for update.
        /// </summary>
        [JsonProperty(PropertyName = "selection")]
        public Selection Selection { get; set; }

        /// <summary>
        /// A list of demand management objects.
        /// </summary>
        [JsonProperty(PropertyName = "dmList")]
        public IList<DemandManagement> DmList { get; set; }
    }
}
