using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;
using System;

namespace I8Beef.Ecobee.Protocol.Group
{
    [JsonObject(MemberSerialization.OptIn)]
    public class GroupRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/group"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.GET; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(GroupResponse); } }

        /// <summary>
        /// The selection criteria for the request.
        /// </summary>
        [JsonProperty(PropertyName = "selection")]
        public Selection Selection { get; set; }
    }
}
