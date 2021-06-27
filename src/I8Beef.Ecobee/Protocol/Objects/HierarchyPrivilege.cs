using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API hierarchy privilege.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class HierarchyPrivilege
    {
        /// <summary>
        /// The path of the management set.
        /// </summary>
        [JsonProperty(PropertyName = "setPath", Required = Required.Always)]
        public string SetPath { get; set; }

        /// <summary>
        /// The name of the managment set.
        /// </summary>
        [JsonProperty(PropertyName = "setName")]
        public string SetName { get; set; }

        /// <summary>
        /// The user name of the user associated with this privilege.
        /// </summary>
        [JsonProperty(PropertyName = "userName", Required = Required.Always)]
        public string UserName { get; set; }

        /// <summary>
        /// The user is permitted all privileges on the set.
        /// </summary>
        [JsonProperty(PropertyName = "allowAll")]
        public bool? AllowAll { get; set; }

        /// <summary>
        /// The user is denied any privilege and may not view the set.
        /// </summary>
        [JsonProperty(PropertyName = "allowNone")]
        public bool? AllowNone { get; set; }

        /// <summary>
        /// The user is only permitted to view the set and its contents.
        /// </summary>
        [JsonProperty(PropertyName = "allowView")]
        public bool? AllowView { get; set; }

        /// <summary>
        /// The user is permitted to make program changes.
        /// </summary>
        [JsonProperty(PropertyName = "allowProgram")]
        public bool? AllowProgram { get; set; }

        /// <summary>
        /// The user is permitted to create and edit vacation events.
        /// </summary>
        [JsonProperty(PropertyName = "allowVacation")]
        public bool? AllowVacation { get; set; }

        /// <summary>
        /// The user is permitted to edit thermostat settings.
        /// </summary>
        [JsonProperty(PropertyName = "allowSettings")]
        public bool? AllowSettings { get; set; }

        /// <summary>
        /// The user is permitted to access thermostat details such as desired temperature, HVAC mode and humidity settings.
        /// </summary>
        [JsonProperty(PropertyName = "allowDetails")]
        public bool? AllowDetails { get; set; }

        /// <summary>
        /// The user is permitted to view thermostat reports.
        /// </summary>
        [JsonProperty(PropertyName = "allowReport")]
        public bool? AllowReport { get; set; }

        /// <summary>
        /// The user is permitted to manage user security.
        /// </summary>
        [JsonProperty(PropertyName = "allowSecurity")]
        public bool? AllowSecurity { get; set; }

        /// <summary>
        /// The user is permitted to manage management sets.
        /// </summary>
        [JsonProperty(PropertyName = "allowHierarchy")]
        public bool? AllowHierarchy { get; set; }

        /// <summary>
        /// The user is permitted to manage alerts.
        /// </summary>
        [JsonProperty(PropertyName = "allowAlerts")]
        public bool? AllowAlerts { get; set; }

        /// <summary>
        /// The user is permitted to manage account information and register/unregister new users.
        /// </summary>
        [JsonProperty(PropertyName = "allowManageAccount")]
        public bool? AllowManageAccount { get; set; }
    }
}
