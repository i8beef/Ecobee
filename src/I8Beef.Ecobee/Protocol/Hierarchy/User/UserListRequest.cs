using Newtonsoft.Json;
using System;

namespace I8Beef.Ecobee.Protocol.Hierarchy.User
{
    [JsonObject(MemberSerialization.OptIn)]
    public class UserListRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/hierarchy/user"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.GET; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(UserListResponse); } }

        /// <summary>
        /// The type of request. Always "list".
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get { return "list"; } }

        /// <summary>
        /// The management set path.
        /// </summary>
        [JsonProperty(PropertyName = "setPath")]
        public string SetPath { get; set; }

        /// <summary>
        /// Whether to include the user privileges.
        /// </summary>
        [JsonProperty(PropertyName = "includePrivileges")]
        public bool IncludePrivileges { get; set; }

        /// <summary>
        /// Whether to also return the children of the children, recursively. Default: false
        /// </summary>
        [JsonProperty(PropertyName = "recursive")]
        public bool Recursive { get; set; }
    }
}
