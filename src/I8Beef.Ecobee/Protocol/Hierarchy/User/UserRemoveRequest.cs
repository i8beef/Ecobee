using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Hierarchy.User
{
    [JsonObject(MemberSerialization.OptIn)]
    public class UserRemoveRequest : RequestBase
    {
        public UserRemoveRequest()
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
        /// The type of request. Always "remove".
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get { return "remove"; } }

        /// <summary>
        /// The path to the set to remove user privileges from.
        /// </summary>
        [JsonProperty(PropertyName = "setPath")]
        public string SetPath { get; set; }

        /// <summary>
        /// The users whose privileges to remove from the set.
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<HierarchyUser> Users { get; set; }
    }
}
