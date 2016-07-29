using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class GeneralSetting
    {
        /// <summary>
        /// Boolean value representing whether or not alerts/reminders are enabled for 
        /// this notification type or not.
        /// </summary>
        [DataMember(Name = "enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The type of notification. Possible values are: temp
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Boolean value representing whether or not alerts/reminders should be sent 
        /// to the technician/contractor assoicated with the thermostat.
        /// </summary>
        [DataMember(Name = "remindTechnician")]
        public bool RemindTechnician { get; set; }
    }
}
