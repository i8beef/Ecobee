using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// The capabilities object represents the set of capabilities the thermostat has. For example, this can include the fan capabilities of the thermostat.
    /// </summary>
    public class Capabilities
    {
        /// <summary>
        /// The fan capabilities of the given thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "fanCapabilities")]
        public FanCapabilities FanCapabilities { get; set; }
    }
}
