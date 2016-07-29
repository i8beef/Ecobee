using Ecobee.Protocol.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ecobee.Protocol.Hierarchy.User
{
    [DataContract]
    public class UserUpdateRequest : RequestBase
    {
        public UserUpdateRequest()
        {
            Users = new List<HierarchyUser>();
            Privileges = new List<HierarchyPrivilege>();
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
        /// The type of request. Always "update".
        /// </summary>
        [DataMember(Name = "operation")]
        public string Operation { get { return "update"; } }

        /// <summary>
        /// The list of users to update.
        /// </summary>
        [DataMember(Name = "users")]
        public IList<HierarchyUser> Users { get; set; }

        /// <summary>
        /// The privileges to update or add.
        /// </summary>
        [DataMember(Name = "privileges")]
        public IList<HierarchyPrivilege> Privileges { get; set; }
    }
}
