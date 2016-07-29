using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class HierarchyUser
    {
        /// <summary>
        /// The user name and login ID. It must be a valid email address.
        /// </summary>
        [DataMember(Name = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// The first name.
        /// </summary>
        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name.
        /// </summary>
        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The timestamp of the last user login into the web portal. Format: YYYY-MM-DD HH:MM:SS
        /// </summary>
        [DataMember(Name = "lastLogin")]
        public string LastLogin { get; set; }

        /// <summary>
        /// Whether the user is active and permitted to access to the system.
        /// </summary>
        [DataMember(Name = "active")]
        public bool Active { get; set; }

        /// <summary>
        /// Whether the user will receive alerts in email.
        /// </summary>
        [DataMember(Name = "emailAlerts")]
        public bool EmailAlerts { get; set; }
    }
}
