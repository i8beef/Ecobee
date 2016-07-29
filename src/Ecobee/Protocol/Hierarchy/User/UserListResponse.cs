using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.User
{
    [DataContract]
    public class UserListResponse : Response
    {
        public UserListResponse()
        {
            Users = new List<Objects.HierarchyUser>();
            Privileges = new List<Objects.HierarchyPrivilege>();
        }

        /// <summary>
        /// list of users in the company.
        /// </summary>
        [DataMember(Name = "users")]
        public IList<Objects.HierarchyUser> Users { get; set; }

        /// <summary>
        /// of hierarchy privileges if requested.
        /// </summary>
        [DataMember(Name = "privileges")]
        public IList<Objects.HierarchyPrivilege> Privileges { get; set; }
    }
}
