using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API update sensor params.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class UpdateSensorParams : FunctionParams
    {
        /// <summary>
        /// The updated name to give the sensor. Has a max length of 32, but shorter is recommended.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }

        /// <summary>
        /// The deviceId for the sensor, typically this indicates the enclosure and corresponds to the ThermostatRemoteSensor.id field. For example: rs:100
        /// </summary>
        [JsonProperty(PropertyName = "deviceId", Required = Required.Always)]
        public string DeviceId { get; set; }

        /// <summary>
        /// The idendifier for the sensor within the enclosure. Corresponds to the RemoteSensorCapability.id. For example: 1
        /// </summary>
        [JsonProperty(PropertyName = "sensorId", Required = Required.Always)]
        public string SensorId { get; set; }
    }
}
