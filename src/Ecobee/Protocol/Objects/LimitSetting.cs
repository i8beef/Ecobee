using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class LimitSetting
    {
        /// <summary>
        /// The value of the limit to set. For temperatures the value is expressed as degrees 
        /// Fahrenheit, multipled by 10. For humidity values are expressed as a percentage 
        /// from 5 to 95. See here for more information.
        /// </summary>
        [DataMember(Name = "limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Boolean value representing whether or not alerts/reminders are enabled for this 
        /// notification type or not.
        /// </summary>
        [DataMember(Name = "enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The type of notification. Possible values are: lowTemp, highTemp, lowHumidity, 
        /// highHumidity, auxHeat, auxOutdoor
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Boolean value representing whether or not alerts/reminders should be sent to the 
        /// technician/contractor associated with the thermostat.
        /// </summary>
        [DataMember(Name = "remindTechnician")]
        public bool RemindTechnician { get; set; }
    }
}
