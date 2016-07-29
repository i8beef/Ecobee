using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class Group
    {
        public Group()
        {
            Thermostats = new List<string>();
        }

        /// <summary>
        /// The unique reference Id for the Group. If not supplied in the POST call, and new 
        /// groupRef will be generated.
        /// </summary>
        [DataMember(Name = "groupRef")]
        public string GroupRef { get; set; }

        /// <summary>
        /// The name for the Group.
        /// </summary>
        [DataMember(Name = "groupName")]
        public string GroupName { get; set; }

        /// <summary>
        /// Flag for whether to synchronize Thermostat Alerts with all other Thermostats in 
        /// the Group. Default is false.
        /// </summary>
        [DataMember(Name = "synchronizeAlerts")]
        public bool SynchronizeAlerts { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat mode with all other Thermostats in 
        /// the Group. Default is false.
        /// </summary>
        [DataMember(Name = "synchronizeSystemMode")]
        public bool SynchronizeSystemMode { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat schedule/Program details with all 
        /// other Thermostats in the Group. Default is false.
        /// </summary>
        [DataMember(Name = "synchronizeSchedule")]
        public bool SynchronizeSchedule { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat quick save settings with all other 
        /// Thermostats in the Group. Default is false.
        /// </summary>
        [DataMember(Name = "synchronizeQuickSave")]
        public bool SynchronizeQuickSave { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat reminders with all other Thermostats 
        /// in the Group. Default is false.
        /// </summary>
        [DataMember(Name = "synchronizeReminders")]
        public bool SynchronizeReminders { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat Technician/Contractor Information with 
        /// all other Thermostats in the Group. Default is false.
        /// </summary>
        [DataMember(Name = "synchronizeContractorInfo")]
        public bool SynchronizeContractorInfo { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat user preferences with all other Thermostats 
        /// in the Group. Default is false.
        /// </summary>
        [DataMember(Name = "synchronizeUserPreferences")]
        public bool SynchronizeUserPreferences { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat utility information with all other 
        /// Thermostats in the Group. Default is false.
        /// </summary>
        [DataMember(Name = "synchronizeUtilityInfo")]
        public bool SynchronizeUtilityInfo { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat Location with all other Thermostats in 
        /// the Group. Default is false.
        /// </summary>
        [DataMember(Name = "synchronizeLocation")]
        public bool SynchronizeLocation { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat reset with all other Thermostats in the 
        /// Group. Default is false.
        /// </summary>
        [DataMember(Name = "synchronizeReset")]
        public bool SynchronizeReset { get; set; }

        /// <summary>
        /// Flag for whether to synchronize the Thermostat vacation Program with all other Thermostats 
        /// in the Group. Default is false.
        /// </summary>
        [DataMember(Name = "synchronizeVacation")]
        public bool SynchronizeVacation { get; set; }

        /// <summary>
        /// The list of Thermostat identifiers which belong to the group. If an empty list is sent the 
        /// Group will be deleted.
        /// </summary>
        [DataMember(Name = "thermostats")]
        public IList<string> Thermostats { get; set; }
    }
}
