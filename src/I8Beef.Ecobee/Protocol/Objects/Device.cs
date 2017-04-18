using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Device
    {
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
        public Sensor Sensors { get; set; }

        /// <summary>
        /// The list of Output Objects associated with the device
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public Output Outputs { get; set; }
    }
}
