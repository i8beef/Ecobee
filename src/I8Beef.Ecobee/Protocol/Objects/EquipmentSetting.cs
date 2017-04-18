using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class EquipmentSetting
    {
        /// <summary>
        /// The date the filter was last changed for this equipment. string format: YYYY-MM-DD
        /// </summary>
        [JsonProperty(PropertyName = "filterLastChanged")]
        public string FilterLastChanged { get; set; }

        /// <summary>
        /// The value representing the life of the filter. This value is expressed in month or 
        /// hour, which is specified in the the filterLifeUnits property.
        /// </summary>
        [JsonProperty(PropertyName = "filterLife")]
        public int FilterLife { get; set; }

        /// <summary>
        /// The units the filterLife field is measured in. Possible values are: month, hour. 
        /// month has a range of 1 - 12. hour has a range of 100 - 10000.
        /// </summary>
        [JsonProperty(PropertyName = "filterLifeUnits")]
        public string FilterLifeUnits { get; set; }

        /// <summary>
        /// The date the reminder will be triggered. This is a read-only field and cannot be
        /// modified through the API. The value is calculated and set by the thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "remindMeDate")]
        public string RemindMeDate { get; set; }

        /// <summary>
        /// bool value representing whether or not alerts/reminders are enabled for this 
        /// notification type or not.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The type of notification. Possible values are: hvac, furnaceFilter, humidifierFilter, 
        /// dehumidifierFilter, ventilator, ac, airFilter, airCleaner, uvLamp
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// bool value representing whether or not alerts/reminders should be sent to the 
        /// technician/contractor assoicated with the thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "remindTechnician")]
        public bool RemindTechnician { get; set; }
    }
}
