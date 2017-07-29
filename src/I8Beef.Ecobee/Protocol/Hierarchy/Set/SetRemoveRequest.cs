using System;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Set
{
    /// <summary>
    /// Ecobee API set remove request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SetRemoveRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/hierarchy/set"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.POST; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(Response); } }

        /// <summary>
        /// The type of request. Always "remove".
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get { return "remove"; } }

        /// <summary>
        /// The path of the set to delete.
        /// </summary>
        [JsonProperty(PropertyName = "setPath")]
        public string SetPath { get; set; }
    }
}
