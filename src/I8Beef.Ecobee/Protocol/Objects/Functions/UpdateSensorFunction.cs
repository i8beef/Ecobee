using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    [JsonObject(MemberSerialization.OptIn)]
    public class UpdateSensorFunction : Function
    {
        public UpdateSensorFunction()
        {
            Params = new UpdateSensorParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public override string Type { get { return "updateSensor"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See 
        /// individual function documentation for the properties.
        /// </summary>
        [JsonProperty(PropertyName = "params")]
        public override FunctionParams Params { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class UpdateSensorParams : FunctionParams
    {
        /// <summary>
        /// The updated name to give the sensor. Has a max length of 32, but shorter is recommended.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The deviceId for the sensor, typically this indicates the enclosure and corresponds to the ThermostatRemoteSensor.id field. For example: rs:100
        /// </summary>
        [JsonProperty(PropertyName = "deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// The idendifier for the sensor within the enclosure. Corresponds to the RemoteSensorCapability.id. For example: 1
        /// </summary>
        [JsonProperty(PropertyName = "sensorId")]
        public string SensorId { get; set; }
    }
}
