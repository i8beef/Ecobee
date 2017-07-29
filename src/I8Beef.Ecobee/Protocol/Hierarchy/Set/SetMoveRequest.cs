using System;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Set
{
    /// <summary>
    /// Ecobee API set move request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SetMoveRequest : RequestBase
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
        /// The type of request. Always "move".
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get { return "move"; } }

        /// <summary>
        /// The path of the set to move.
        /// </summary>
        [JsonProperty(PropertyName = "setPath")]
        public string SetPath { get; set; }

        /// <summary>
        /// The path of the new parent to move to.
        /// </summary>
        [JsonProperty(PropertyName = "toPath")]
        public string ToPath { get; set; }
    }
}
