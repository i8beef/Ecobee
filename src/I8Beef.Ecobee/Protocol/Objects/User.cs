using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API user.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class User
    {
        /// <summary>
        /// The User login userName. Usually a valid email address.
        /// </summary>
        [JsonProperty(PropertyName = "userName", Required = Required.Always)]
        public string UserName { get; set; }

        /// <summary>
        /// The User display name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The User first name.
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The User last name.
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The User title such as Mr. or Mrs.
        /// </summary>
        [JsonProperty(PropertyName = "honorific")]
        public string Honorific { get; set; }

        /// <summary>
        /// The User date of registration.
        /// </summary>
        [JsonProperty(PropertyName = "registerDate")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// The User time of registration.
        /// </summary>
        [JsonProperty(PropertyName = "registerTime")]
        public string RegisterTime { get; set; }

        /// <summary>
        /// The Thermostat identifier this User is associated with.
        /// </summary>
        [JsonProperty(PropertyName = "defaultThermostatIdentifier")]
        public string DefaultThermostatIdentifier { get; set; }

        /// <summary>
        /// The User management reference.
        /// </summary>
        [JsonProperty(PropertyName = "managementRef")]
        public string ManagementRef { get; set; }

        /// <summary>
        /// The User utility reference.
        /// </summary>
        [JsonProperty(PropertyName = "utilityRef")]
        public string UtilityRef { get; set; }

        /// <summary>
        /// The User support reference.
        /// </summary>
        [JsonProperty(PropertyName = "supportRef")]
        public string SupportRef { get; set; }

        /// <summary>
        /// The User phone Number.
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Whether this user has a residential role.
        /// </summary>
        [JsonProperty(PropertyName = "isResidential")]
        public bool? IsResidential { get; set; }

        /// <summary>
        /// Whether this user has a developer role.
        /// </summary>
        [JsonProperty(PropertyName = "isDeveloper")]
        public bool? IsDeveloper { get; set; }

        /// <summary>
        /// Whether this user has a management role.
        /// </summary>
        [JsonProperty(PropertyName = "isManagement")]
        public bool? IsManagement { get; set; }

        /// <summary>
        /// Whether this user has a utility role.
        /// </summary>
        [JsonProperty(PropertyName = "isUtility")]
        public bool? IsUtility { get; set; }

        /// <summary>
        /// Whether this user has a contractor role.
        /// </summary>
        [JsonProperty(PropertyName = "isContractor")]
        public bool? IsContractor { get; set; }
    }
}
