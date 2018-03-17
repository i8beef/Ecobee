using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API group.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Group
    {
        /// <summary>
        /// The unique reference Id for the Group. If not supplied in the POST call, and new
        /// groupRef will be generated.
        /// </summary>
        [JsonProperty(PropertyName = "groupRef")]
        public string GroupRef { get; set; }

        /// <summary>
        /// The name for the Group.
        /// </summary>
        [JsonProperty(PropertyName = "groupName", Required = Required.Always)]
        public string GroupName { get; set; }

        /// <summary>
        /// Flag for whether to synchronize Thermostat Alerts with all other Thermostats in
        /// the Group. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "synchronizeAlerts")]
        public bool SynchronizeAlerts { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat mode with all other Thermostats in
        /// the Group. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "synchronizeSystemMode")]
        public bool SynchronizeSystemMode { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat schedule/Program details with all
        /// other Thermostats in the Group. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "synchronizeSchedule")]
        public bool SynchronizeSchedule { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat quick save settings with all other
        /// Thermostats in the Group. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "synchronizeQuickSave")]
        public bool SynchronizeQuickSave { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat reminders with all other Thermostats
        /// in the Group. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "synchronizeReminders")]
        public bool SynchronizeReminders { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat Technician/Contractor Information with
        /// all other Thermostats in the Group. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "synchronizeContractorInfo")]
        public bool SynchronizeContractorInfo { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat user preferences with all other Thermostats
        /// in the Group. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "synchronizeUserPreferences")]
        public bool SynchronizeUserPreferences { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat utility information with all other
        /// Thermostats in the Group. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "synchronizeUtilityInfo")]
        public bool SynchronizeUtilityInfo { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat Location with all other Thermostats in
        /// the Group. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "synchronizeLocation")]
        public bool SynchronizeLocation { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat reset with all other Thermostats in the
        /// Group. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "synchronizeReset")]
        public bool SynchronizeReset { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat vacation Program with all other Thermostats
        /// in the Group. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "synchronizeVacation")]
        public bool SynchronizeVacation { get; set; }

        /// <summary>
        /// The list of Thermostat identifiers which belong to the group. If an empty list is sent the
        /// Group will be deleted.
        /// </summary>
        [JsonProperty(PropertyName = "thermostats")]
        public IList<string> Thermostats { get; set; }
    }
}
