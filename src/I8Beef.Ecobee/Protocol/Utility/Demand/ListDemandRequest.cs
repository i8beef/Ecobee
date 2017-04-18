using Newtonsoft.Json;
using System;

namespace I8Beef.Ecobee.Protocol.Utility.Demand
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ListDemandRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/demandResponse"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.GET; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(ListDemandResponse); } }

        /// <summary>
        /// The type of request. Always "list".
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get { return "list"; } }
    }
}
