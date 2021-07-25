using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API Thermostat.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Thermostat
    {
        /// <summary>
        /// The unique thermostat serial number.
        /// </summary>
        [JsonProperty(PropertyName = "identifier", Required = Required.Always)]
        public string Identifier { get; set; }

        /// <summary>
        /// A user defined name for a thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The current thermostat configuration revision.
        /// </summary>
        [JsonProperty(PropertyName = "thermostatRev")]
        public string ThermostatRev { get; set; }

        /// <summary>
        /// Whether the user registered the thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "isRegistered")]
        public bool? IsRegistered { get; set; }

        /// <summary>
        /// The thermostat model number.
        ///
        /// Values: apolloSmart, apolloEms, idtSmart, idtEms, siSmart, siEms, athenaSmart, athenaEms, corSmart, nikeSmart, nikeEms
        /// </summary>
        [JsonProperty(PropertyName = "modelNumber")]
        public string ModelNumber { get; set; }

        /// <summary>
        /// The thermostat brand.
        /// </summary>
        [JsonProperty(PropertyName = "brand")]
        public string Brand { get; set; }

        /// <summary>
        /// The comma-separated list of the thermostat's additional features, if any.
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public string Features { get; set; }

        /// <summary>
        /// The last modified date time for the thermostat configuration.
        /// </summary>
        [JsonProperty(PropertyName = "lastModified")]
        public string LastModified { get; set; }

        /// <summary>
        /// The current time in the thermostat's time zone
        /// </summary>
        [JsonProperty(PropertyName = "thermostatTime")]
        public string ThermostatTime { get; set; }

        /// <summary>
        /// The current time in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "utcTime")]
        public string UtcTime { get; set; }

        /// <summary>
        /// The thermostat audio configuration
        /// </summary>
        [JsonProperty(PropertyName = "audio")]
        public Audio Audio { get; set; }

        /// <summary>
        /// The list of Alert objects tied to the thermostat
        /// </summary>
        [JsonProperty(PropertyName = "alerts")]
        public IList<Alert> Alerts { get; set; }

        /// <summary>
        /// The thermostat Setting object linked to the thermostat
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        public Settings Settings { get; set; }

        /// <summary>
        /// The Runtime state object for the thermostat
        /// </summary>
        [JsonProperty(PropertyName = "runtime")]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// The ExtendedRuntime object for the thermostat
        /// </summary>
        [JsonProperty(PropertyName = "extendedRuntime")]
        public ExtendedRuntime ExtendedRuntime { get; set; }

        /// <summary>
        /// The Electricity object for the thermostat
        /// </summary>
        [JsonProperty(PropertyName = "electricity")]
        public Electricity Electricity { get; set; }

        /// <summary>
        /// The list of Device objects linked to the thermostat
        /// </summary>
        [JsonProperty(PropertyName = "devices")]
        public IList<Device> Devices { get; set; }

        /// <summary>
        /// The Location object for the thermostat
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public Location Location { get; set; }

        /// <summary>
        /// The Technician object associated with the thermostat containing the technician contact
        /// information
        /// </summary>
        [JsonProperty(PropertyName = "technician")]
        public Technician Technician { get; set; }

        /// <summary>
        /// The Utility object associated with the thermostat containing the utility company
        /// information
        /// </summary>
        [JsonProperty(PropertyName = "utility")]
        public Utility Utility { get; set; }

        /// <summary>
        /// The Management object associated with the thermostat containing the management company
        /// information
        /// </summary>
        [JsonProperty(PropertyName = "management")]
        public Management Management { get; set; }

        /// <summary>
        /// The Weather object linked to the thermostat representing the current weather on
        /// the thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "weather")]
        public Weather Weather { get; set; }

        /// <summary>
        /// The list of Event objects linked to the thermostat representing any events that are
        /// active or scheduled.
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IList<Event> Events { get; set; }

        /// <summary>
        /// The Program object for the thermostat
        /// </summary>
        [JsonProperty(PropertyName = "program")]
        public Program Program { get; set; }

        /// <summary>
        /// The houseDetails object contains contains the information about the house the
        /// thermostat is installed in.
        /// </summary>
        [JsonProperty(PropertyName = "houseDetails")]
        public HouseDetails HouseDetails { get; set; }

        /// <summary>
        /// The OemCfg object contains information about the OEM specific thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "oemCfg")]
        public ThermostatOemCfg OemCfg { get; set; }

        /// <summary>
        /// The status of all equipment controlled by this Thermostat. Only running equipment
        /// is listed in the CSV String.
        ///
        /// Values: heatPump, heatPump2, heatPump3, compCool1, compCool2, auxHeat1, auxHeat2,
        /// auxHeat3, fan, humidifier, dehumidifier, ventilator, economizer, compHotWater, auxHotWater.
        ///
        /// Note: If no equipment is currently running an empty String is returned.If Settings.hasHeatPump
        /// is true, heatPump value will be returned for heating, compCool for cooling, and auxHeat for
        /// aux heat. If Settings.hasForcedAir or Settings.hasBoiler is true, auxHeat value will be
        /// returned for heating and compCool for cooling (heatPump will not show up for heating).
        /// </summary>
        [JsonProperty(PropertyName = "equipmentStatus")]
        public string EquipmentStatus { get; set; }

        /// <summary>
        /// The NotificationSettings object containing the configuration for Alert and Reminders
        /// for the Thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "notificationSettings")]
        public NotificationSettings NotificationSettings { get; set; }

        /// <summary>
        /// The Privacy object containing the privacy settings for the Thermostat. Note: access
        /// to this object is restricted to callers with implict authentication.
        /// </summary>
        [JsonProperty(PropertyName = "privacy")]
        public ThermostatPrivacy Privacy { get; set; }

        /// <summary>
        /// The Version object containing the firmware version information for the Thermostat.
        /// For example: "3.5.0.3957".
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public Version Version { get; set; }

        /// <summary>
        /// The SecuritySettings object containing the security settings for the Thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "securitySettings")]
        public SecuritySettings SecuritySettings { get; set; }

        /// <summary>
        /// The list of RemoteSensor objects for the Thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "remoteSensors")]
        public IList<RemoteSensor> RemoteSensors { get; set; }

        /// <summary>
        /// The capabilities the given thermostat has.
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public Capabilities Capabilities { get; set; }
    }
}
