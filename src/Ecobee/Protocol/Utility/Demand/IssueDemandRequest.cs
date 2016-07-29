using I8Beef.Ecobee.Protocol.Objects;
using System;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Utility.Demand
{
    [DataContract]
    public class IssueDemandRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/demandResponse"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.POST; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(IssueDemandResponse); } }

        /// <summary>
        /// The selection criteria for update.
        /// </summary>
        [DataMember(Name = "selection")]
        public Selection Selection { get; set; }

        /// <summary>
        /// The type of request. Always "create".
        /// </summary>
        [DataMember(Name = "operation")]
        public String Operation { get; set; }

        /// <summary>
        /// The demand response object to create.
        /// </summary>
        [DataMember(Name = "demandResponse")]
        public DemandResponse DemandResponse { get; set; }
    }
}
