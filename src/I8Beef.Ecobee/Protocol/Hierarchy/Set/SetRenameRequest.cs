using System;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Set
{
    /// <summary>
    /// Ecobee API set rename request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SetRenameRequest : RequestBase
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
        /// The type of request. Always "rename".
        /// </summary>
        [JsonProperty(PropertyName = "operation", Required = Required.Always)]
        public string Operation { get { return "rename"; } }

        /// <summary>
        /// The path of the set to rename.
        /// </summary>
        [JsonProperty(PropertyName = "setPath", Required = Required.Always)]
        public string SetPath { get; set; }

        /// <summary>
        /// The new name to assign. Must be unique to that parent.
        /// </summary>
        [JsonProperty(PropertyName = "newName", Required = Required.Always)]
        public string NewName { get; set; }
    }
}
