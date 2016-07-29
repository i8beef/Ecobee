using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class RemoteSensor
    {
        public RemoteSensor()
        {
            Capability = new List<RemoteSensorCapability>();
        }

        /// <summary>
        /// The unique sensor identifier. It is composed of deviceName + deviceId separated 
        /// by colons, for example: rs:100
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The user assigned sensor name.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of sensor. Values: thermostat, ecobee3_remote_sensor, monitor_sensor, 
        /// control_sensor.
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The unique 4-digit alphanumeric sensor code. For ecobee3 remote sensors this 
        /// corresponds to the code found on the back of the physical sensor.
        /// </summary>
        [DataMember(Name = "code")]
        public string Code { get; set; }

        /// <summary>
        /// This flag indicates whether the remote sensor is currently in use by a comfort 
        /// setting. See Climate for more information.
        /// </summary>
        [DataMember(Name = "inUse")]
        public bool InUse { get; set; }

        /// <summary>
        /// The list of remoteSensorCapability objects for the remote sensor.
        /// </summary>
        [DataMember(Name = "capability")]
        public IList<RemoteSensorCapability> Capability { get; set; }
    }
}
