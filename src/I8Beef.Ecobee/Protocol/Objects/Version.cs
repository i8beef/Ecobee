using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Version
    {
        /// <summary>
        /// The thermostat firmware version number.
        /// </summary>
        [JsonProperty(PropertyName = "thermostatFirmwareVersion")]
        public string ThermostatFirmwareVersion { get; set; }
    }
}
