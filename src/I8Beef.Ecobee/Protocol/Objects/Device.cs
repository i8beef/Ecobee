using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Device
    {
        public Device()
        {
            Sensors = new List<Sensor>();
            Outputs = new List<Output>();
        }

        /// <summary>
        /// A unique ID for the device
        /// </summary>
        [JsonProperty(PropertyName = "deviceId")]
        public int DeviceId { get; set; }

        /// <summary>
        /// The user supplied device name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The list of Sensor Objects associated with the device.
        /// </summary>
        [JsonProperty(PropertyName = "sensors")]
        public IList<Sensor> Sensors { get; set; }

        /// <summary>
        /// The list of Output Objects associated with the device
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public IList<Output> Outputs { get; set; }
    }
}
