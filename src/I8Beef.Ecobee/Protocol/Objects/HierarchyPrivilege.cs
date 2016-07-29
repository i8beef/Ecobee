using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class HierarchyPrivilege
    {
        /// <summary>
        /// The path of the management set.
        /// </summary>
        [DataMember(Name = "setPath")]
        public string SetPath { get; set; }

        /// <summary>
        /// The name of the managment set.
        /// </summary>
        [DataMember(Name = "setName")]
        public string SetName { get; set; }

        /// <summary>
        /// The user name of the user associated with this privilege.
        /// </summary>
        [DataMember(Name = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// The user is permitted all privileges on the set.
        /// </summary>
        [DataMember(Name = "allowAll")]
        public bool AllowAll { get; set; }

        /// <summary>
        /// The user is denied any privilege and may not view the set.
        /// </summary>
        [DataMember(Name = "allowNone")]
        public bool AllowNone { get; set; }

        /// <summary>
        /// The user is only permitted to view the set and its contents.
        /// </summary>
        [DataMember(Name = "allowView")]
        public bool AllowView { get; set; }

        /// <summary>
        /// The user is permitted to make program changes.
        /// </summary>
        [DataMember(Name = "allowProgram")]
        public bool AllowProgram { get; set; }

        /// <summary>
        /// The user is permitted to create and edit vacation events.
        /// </summary>
        [DataMember(Name = "allowVacation")]
        public bool AllowVacation { get; set; }

        /// <summary>
        /// The user is permitted to edit thermostat settings.
        /// </summary>
        [DataMember(Name = "allowSettings")]
        public bool AllowSettings { get; set; }

        /// <summary>
        /// The user is permitted to access thermostat details such as desired temperature, HVAC mode and humidity settings.
        /// </summary>
        [DataMember(Name = "allowDetails")]
        public bool AllowDetails { get; set; }

        /// <summary>
        /// The user is permitted to view thermostat reports.
        /// </summary>
        [DataMember(Name = "allowReport")]
        public bool AllowReport { get; set; }

        /// <summary>
        /// The user is permitted to manage user security.
        /// </summary>
        [DataMember(Name = "allowSecurity")]
        public bool AllowSecurity { get; set; }

        /// <summary>
        /// The user is permitted to manage management sets.
        /// </summary>
        [DataMember(Name = "allowHierarchy")]
        public bool AllowHierarchy { get; set; }

        /// <summary>
        /// The user is permitted to manage alerts.
        /// </summary>
        [DataMember(Name = "allowAlerts")]
        public bool AllowAlerts { get; set; }

        /// <summary>
        /// The user is permitted to manage account information and register/unregister new users.
        /// </summary>
        [DataMember(Name = "allowManageAccount")]
        public bool AllowManageAccount { get; set; }
    }
}
