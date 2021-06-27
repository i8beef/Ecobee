using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API general setting.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GeneralSetting
    {
        /// <summary>
        /// Boolean value representing whether or not alerts/reminders are enabled for
        /// this notification type or not.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The type of notification. Possible values are: temp
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public string Type { get; set; }

        /// <summary>
        /// Boolean value representing whether or not alerts/reminders should be sent
        /// to the technician/contractor assoicated with the thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "remindTechnician")]
        public bool? RemindTechnician { get; set; }
    }
}
