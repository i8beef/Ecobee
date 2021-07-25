using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// The fan capabilities object represents the set of fan capabilities the thermostat has. For example, this can include the available fan speed options.
    /// </summary>
    public class FanCapabilities
    {
        /// <summary>
        /// The list of speed options that the thermostat is wired to support. Options include: LOW, MEDIUM, HIGH and OPTIMIZED
        /// </summary>
        [JsonProperty(PropertyName = "speedOptions")]
        public string SpeedOptions { get; set; }
    }
}
