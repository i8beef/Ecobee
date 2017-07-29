using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Hierarchy.User
{
    /// <summary>
    /// Ecobee API user list response.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class UserListResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserListResponse"/> class.
        /// </summary>
        public UserListResponse()
        {
            Users = new List<Objects.HierarchyUser>();
            Privileges = new List<Objects.HierarchyPrivilege>();
        }

        /// <summary>
        /// list of users in the company.
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<Objects.HierarchyUser> Users { get; set; }

        /// <summary>
        /// of hierarchy privileges if requested.
        /// </summary>
        [JsonProperty(PropertyName = "privileges")]
        public IList<Objects.HierarchyPrivilege> Privileges { get; set; }
    }
}
