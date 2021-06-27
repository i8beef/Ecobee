using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API hierarchy user.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class HierarchyUser
    {
        /// <summary>
        /// The user name and login ID. It must be a valid email address.
        /// </summary>
        [JsonProperty(PropertyName = "userName", Required = Required.Always)]
        public string UserName { get; set; }

        /// <summary>
        /// The first name.
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name.
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The timestamp of the last user login into the web portal. Format: YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonProperty(PropertyName = "lastLogin")]
        public string LastLogin { get; set; }

        /// <summary>
        /// Whether the user is active and permitted to access to the system.
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Whether the user will receive alerts in email.
        /// </summary>
        [JsonProperty(PropertyName = "emailAlerts")]
        public bool? EmailAlerts { get; set; }
    }
}
