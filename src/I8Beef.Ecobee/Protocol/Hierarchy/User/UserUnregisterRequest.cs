using System;
using System.Collections.Generic;
using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Hierarchy.User
{
    /// <summary>
    /// Ecobee API user unregister request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class UserUnregisterRequest : RequestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUnregisterRequest"/> class.
        /// </summary>
        public UserUnregisterRequest()
        {
            Users = new List<HierarchyUser>();
        }

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
        /// The type of request. Always "unregister".
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get { return "unregister"; } }

        /// <summary>
        /// The users whose privileges to unregister.
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<HierarchyUser> Users { get; set; }
    }
}
