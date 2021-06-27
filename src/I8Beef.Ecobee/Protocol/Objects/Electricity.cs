using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API electricity.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Electricity
    {
        /// <summary>
        /// The list of ElectricityDevice objects associated with the thermostat, each
        /// representing a device such as an electric meter or remote load control.
        /// </summary>
        [JsonProperty(PropertyName = "devices")]
        public IList<ElectricityDevice> Devices { get; set; }
    }
}
