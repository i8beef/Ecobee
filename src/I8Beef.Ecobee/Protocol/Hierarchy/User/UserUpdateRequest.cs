using System;
using System.Collections.Generic;
using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Hierarchy.User
{
    /// <summary>
    /// Ecobee API user update request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class UserUpdateRequest : RequestBase
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
        /// The type of request. Always "update".
        /// </summary>
        [JsonProperty(PropertyName = "operation", Required = Required.Always)]
        public string Operation { get { return "update"; } }

        /// <summary>
        /// The list of users to update.
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<HierarchyUser> Users { get; set; }

        /// <summary>
        /// The privileges to update or add.
        /// </summary>
        [JsonProperty(PropertyName = "privileges")]
        public IList<HierarchyPrivilege> Privileges { get; set; }
    }
}
