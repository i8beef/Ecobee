using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Electricity
    {
        public Electricity()
        {
            Devices = new List<ElectricityDevice>();
        }

        /// <summary>
        /// The list of ElectricityDevice objects associated with the thermostat, each 
        /// representing a device such as an electric meter or remote load control.
        /// </summary>
        [JsonProperty(PropertyName = "devices")]
        public IList<ElectricityDevice> Devices { get; set; }
    }
}
