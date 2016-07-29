using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class Selection
    {
        /// <summary>
        /// The type of match data supplied: Values: none, thermostats, user, managementSet.
        /// </summary>
        [DataMember(Name = "selectionType")]
        public string SelectionType { get; set; }

        /// <summary>
        /// The match data based on selectionType(e.g.a list of thermostat idendifiers in the case of a selectionType of thermostats)
        /// </summary>
        [DataMember(Name = "selectionMatch")]
        public string SelectionMatch { get; set; }

        /// <summary>
        /// Include the thermostat runtime object. If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeRuntime")]
        public bool IncludeRuntime { get; set; }

        /// <summary>
        /// Include the extended thermostat runtime object. If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeExtendedRuntime")]
        public bool IncludeExtendedRuntime { get; set; }

        /// <summary>
        /// Include the electricity readings object. If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeElectricity")]
        public bool IncludeElectricity { get; set; }

        /// <summary>
        /// Include the thermostat settings object. If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeSettings")]
        public bool IncludeSettings { get; set; }

        /// <summary>
        /// Include the thermostat location object. If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeLocation")]
        public bool IncludeLocation { get; set; }

        /// <summary>
        /// Include the thermostat program object. If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeProgram")]
        public bool IncludeProgram { get; set; }

        /// <summary>
        /// Include the thermostat calendar events objects.If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeEvents")]
        public bool IncludeEvents { get; set; }

        /// <summary>
        /// Include the thermostat device configuration objects. If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeDevice")]
        public bool IncludeDevice { get; set; }

        /// <summary>
        /// Include the thermostat technician object. If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeTechnician")]
        public bool IncludeTechnician { get; set; }

        /// <summary>
        /// Include the thermostat utility company object. If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeUtility")]
        public bool IncludeUtility { get; set; }

        /// <summary>
        /// Include the thermostat management company object. If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeManagement")]
        public bool IncludeManagement { get; set; }

        /// <summary>
        /// Include the thermostat's unacknowledged alert objects. If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeAlerts")]
        public bool IncludeAlerts { get; set; }

        /// <summary>
        /// Include the current thermostat weather forecast object. If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeWeather")]
        public bool IncludeWeather { get; set; }

        /// <summary>
        /// Include the current thermostat house details object. If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeHouseDetails")]
        public bool IncludeHouseDetails { get; set; }

        /// <summary>
        /// Include the current thermostat OemCfg object. If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeOemCfg")]
        public bool IncludeOemCfg { get; set; }

        /// <summary>
        /// Include the current thermostat equipment status information.If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeEquipmentStatus")]
        public bool IncludeEquipmentStatus { get; set; }

        /// <summary>
        /// Include the current thermostat alert and reminders settings. If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeNotificationSettings")]
        public bool IncludeNotificationSettings { get; set; }

        /// <summary>
        /// Include the current thermostat privacy settings. Note: access to this object is restricted to 
        /// callers with implict authentication, setting this value to true without proper credentials will 
        /// result in an authentication exception.
        /// </summary>
        [DataMember(Name = "includePrivacy")]
        public bool IncludePrivacy { get; set; }

        /// <summary>
        /// Include the current firmware version the Thermostat is running.If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeVersion")]
        public bool IncludeVersion { get; set; }

        /// <summary>
        /// Include the current securitySettings object for the selected Thermostat(s). If not specified, defaults to false.
        /// </summary>
        [DataMember(Name = "includeSecuritySettings")]
        public bool IncludeSecuritySettings { get; set; }

        /// <summary>
        /// Include the list of current thermostatRemoteSensor objects for the selected Thermostat(s). If not specified, 
        /// defaults to false.
        /// </summary>
        [DataMember(Name = "includeSensors")]
        public bool IncludeSensors { get; set; }
    }
}
