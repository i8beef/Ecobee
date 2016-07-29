using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class User
    {
        /// <summary>
        /// The User login userName. Usually a valid email address.
        /// </summary>
        [DataMember(Name = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// The User display name.
        /// </summary>
        [DataMember(Name = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The User first name.
        /// </summary>
        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The User last name.
        /// </summary>
        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The User title such as Mr. or Mrs.
        /// </summary>
        [DataMember(Name = "honorific")]
        public string Honorific { get; set; }

        /// <summary>
        /// The User date of registration.
        /// </summary>
        [DataMember(Name = "registerDate")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// The User time of registration.
        /// </summary>
        [DataMember(Name = "registerTime")]
        public string RegisterTime { get; set; }

        /// <summary>
        /// The Thermostat identifier this User is associated with.
        /// </summary>
        [DataMember(Name = "defaultThermostatIdentifier")]
        public string DefaultThermostatIdentifier { get; set; }

        /// <summary>
        /// The User management reference.
        /// </summary>
        [DataMember(Name = "managementRef")]
        public string ManagementRef { get; set; }

        /// <summary>
        /// The User utility reference.
        /// </summary>
        [DataMember(Name = "utilityRef")]
        public string UtilityRef { get; set; }

        /// <summary>
        /// The User support reference.
        /// </summary>
        [DataMember(Name = "supportRef")]
        public string SupportRef { get; set; }

        /// <summary>
        /// The User phone Number.
        /// </summary>
        [DataMember(Name = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "isResidential")]
        public bool IsResidential { get; set; }

        /// <summary>
        /// Whether this user has a developer role.
        /// </summary>
        [DataMember(Name = "isDeveloper")]
        public bool IsDeveloper { get; set; }

        /// <summary>
        /// Whether this user has a management role.
        /// </summary>
        [DataMember(Name = "isManagement")]
        public bool IsManagement { get; set; }

        /// <summary>
        /// Whether this user has a utility role.
        /// </summary>
        [DataMember(Name = "isUtility")]
        public bool IsUtility { get; set; }

        /// <summary>
        /// Whether this user has a contractor role.
        /// </summary>
        [DataMember(Name = "isContractor")]
        public bool IsContractor { get; set; }
    }
}
