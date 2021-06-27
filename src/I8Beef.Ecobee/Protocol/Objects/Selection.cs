using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API selection.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Selection
    {
        /// <summary>
        /// The type of match data supplied: Values: none, thermostats, user, managementSet.
        /// </summary>
        [JsonProperty(PropertyName = "selectionType", Required = Required.Always)]
        public string SelectionType { get; set; }

        /// <summary>
        /// The match data based on selectionType(e.g.a list of thermostat idendifiers in the case of a selectionType of thermostats)
        /// </summary>
        [JsonProperty(PropertyName = "selectionMatch", Required = Required.Always)]
        public string SelectionMatch { get; set; }

        /// <summary>
        /// Include the thermostat runtime object. If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeRuntime")]
        public bool? IncludeRuntime { get; set; }

        /// <summary>
        /// Include the extended thermostat runtime object. If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeExtendedRuntime")]
        public bool? IncludeExtendedRuntime { get; set; }

        /// <summary>
        /// Include the electricity readings object. If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeElectricity")]
        public bool? IncludeElectricity { get; set; }

        /// <summary>
        /// Include the thermostat settings object. If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeSettings")]
        public bool? IncludeSettings { get; set; }

        /// <summary>
        /// Include the thermostat location object. If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeLocation")]
        public bool? IncludeLocation { get; set; }

        /// <summary>
        /// Include the thermostat program object. If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeProgram")]
        public bool? IncludeProgram { get; set; }

        /// <summary>
        /// Include the thermostat calendar events objects.If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeEvents")]
        public bool? IncludeEvents { get; set; }

        /// <summary>
        /// Include the thermostat device configuration objects. If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeDevice")]
        public bool? IncludeDevice { get; set; }

        /// <summary>
        /// Include the thermostat technician object. If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeTechnician")]
        public bool? IncludeTechnician { get; set; }

        /// <summary>
        /// Include the thermostat utility company object. If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeUtility")]
        public bool? IncludeUtility { get; set; }

        /// <summary>
        /// Include the thermostat management company object. If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeManagement")]
        public bool? IncludeManagement { get; set; }

        /// <summary>
        /// Include the thermostat's unacknowledged alert objects. If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeAlerts")]
        public bool? IncludeAlerts { get; set; }

        /// <summary>
        /// Include the current thermostat weather forecast object. If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeWeather")]
        public bool? IncludeWeather { get; set; }

        /// <summary>
        /// Include the current thermostat house details object. If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeHouseDetails")]
        public bool? IncludeHouseDetails { get; set; }

        /// <summary>
        /// Include the current thermostat OemCfg object. If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeOemCfg")]
        public bool? IncludeOemCfg { get; set; }

        /// <summary>
        /// Include the current thermostat equipment status information.If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeEquipmentStatus")]
        public bool? IncludeEquipmentStatus { get; set; }

        /// <summary>
        /// Include the current thermostat alert and reminders settings. If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeNotificationSettings")]
        public bool? IncludeNotificationSettings { get; set; }

        /// <summary>
        /// Include the current thermostat privacy settings. Note: access to this object is restricted to
        /// callers with implict authentication, setting this value to true without proper credentials will
        /// result in an authentication exception.
        /// </summary>
        [JsonProperty(PropertyName = "includePrivacy")]
        public bool? IncludePrivacy { get; set; }

        /// <summary>
        /// Include the current firmware version the Thermostat is running.If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeVersion")]
        public bool? IncludeVersion { get; set; }

        /// <summary>
        /// Include the current securitySettings object for the selected Thermostat(s). If not specified, defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeSecuritySettings")]
        public bool? IncludeSecuritySettings { get; set; }

        /// <summary>
        /// Include the list of current thermostatRemoteSensor objects for the selected Thermostat(s). If not specified,
        /// defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "includeSensors")]
        public bool? IncludeSensors { get; set; }
    }
}
