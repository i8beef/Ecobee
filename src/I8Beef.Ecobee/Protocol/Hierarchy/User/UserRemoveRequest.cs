using System;
using System.Collections.Generic;
using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Hierarchy.User
{
    /// <summary>
    /// Ecobee API user remove request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class UserRemoveRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/hierarchy/user"; } }

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
        [JsonProperty(PropertyName = "operation", Required = Required.Always)]
        public string Operation { get { return "remove"; } }

        /// <summary>
        /// The path to the set to remove user privileges from.
        /// </summary>
        [JsonProperty(PropertyName = "setPath", Required = Required.Always)]
        public string SetPath { get; set; }

        /// <summary>
        /// The users whose privileges to remove from the set.
        /// </summary>
        [JsonProperty(PropertyName = "users", Required = Required.Always)]
        public IList<HierarchyUser> Users { get; set; }
    }
}
