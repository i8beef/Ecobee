using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class RuntimeSensorMetadata
    {
        /// <summary>
        /// The unique sensor identifier. It is composed of deviceName + deviceId + sensorId 
        /// (from thermostat.device[].sensor[]) separated by colons. This value corresponds to 
        /// the column name for the sensor reading values.
        /// </summary>
        [DataMember(Name = "sensorId")]
        public string SensorId { get; set; }

        /// <summary>
        /// The user assigned sensor name.
        /// </summary>
        [DataMember(Name = "sensorName")]
        public string SensorName { get; set; }

        /// <summary>
        /// The type of sensor. See Sensor Types. Values: co2, ctclamp, dryContact, humidity, 
        /// plug, temperature
        /// </summary>
        [DataMember(Name = "sensorType")]
        public string SensorType { get; set; }

        /// <summary>
        /// The usage configured for the sensor. Values: dischargeAir, indoor, monitor, outdoor
        /// </summary>
        [DataMember(Name = "sensorUsage")]
        public string SensorUsage { get; set; }
    }
}
