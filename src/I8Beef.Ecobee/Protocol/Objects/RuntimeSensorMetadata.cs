using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API runtime sensor metadata.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class RuntimeSensorMetadata
    {
        /// <summary>
        /// The unique sensor identifier. It is composed of deviceName + deviceId + sensorId
        /// (from thermostat.device[].sensor[]) separated by colons. This value corresponds to
        /// the column name for the sensor reading values.
        /// </summary>
        [JsonProperty(PropertyName = "sensorId")]
        public string SensorId { get; set; }

        /// <summary>
        /// The user assigned sensor name.
        /// </summary>
        [JsonProperty(PropertyName = "sensorName")]
        public string SensorName { get; set; }

        /// <summary>
        /// The type of sensor. See Sensor Types. Values: co2, ctclamp, dryContact, humidity,
        /// plug, temperature
        /// </summary>
        [JsonProperty(PropertyName = "sensorType")]
        public string SensorType { get; set; }

        /// <summary>
        /// The usage configured for the sensor. Values: dischargeAir, indoor, monitor, outdoor
        /// </summary>
        [JsonProperty(PropertyName = "sensorUsage")]
        public string SensorUsage { get; set; }
    }
}
