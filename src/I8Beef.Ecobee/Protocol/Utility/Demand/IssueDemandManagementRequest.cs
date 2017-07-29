using System;
using System.Collections.Generic;
using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Utility.Demand
{
    /// <summary>
    /// Ecobee API issue demand management request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class IssueDemandManagementRequest : RequestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueDemandManagementRequest"/> class.
        /// </summary>
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
