using I8Beef.Ecobee.Protocol.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.User
{
    [DataContract]
    public class UserAddRequest : RequestBase
    {
        public UserAddRequest()
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
        /// The type of request. Always "add".
        /// </summary>
        [DataMember(Name = "operation")]
        public string Operation { get { return "add"; } }

        /// <summary>
        /// The list of users to add.
        /// </summary>
        [DataMember(Name = "users")]
        public IList<HierarchyUser> Users { get; set; }

        /// <summary>
        /// The privileges to assign to the new users.
        /// </summary>
        [DataMember(Name = "privileges")]
        public IList<HierarchyPrivilege> Privileges { get; set; }
    }
}
