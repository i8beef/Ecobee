using Ecobee.Protocol.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ecobee.Protocol.Hierarchy.User
{
    [DataContract]
    public class UserUnregisterRequest : RequestBase
    {
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
        [DataMember(Name = "operation")]
        public string Operation { get { return "unregister"; } }

        /// <summary>
        /// The users whose privileges to unregister.
        /// </summary>
        [DataMember(Name = "users")]
        public IList<HierarchyUser> Users { get; set; }
    }
}
