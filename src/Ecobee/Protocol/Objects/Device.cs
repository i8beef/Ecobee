using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class Device
    {
        /// <summary>
        /// A unique ID for the device
        /// </summary>
        [DataMember(Name = "deviceId")]
        public int DeviceId { get; set; }

        /// <summary>
        /// The user supplied device name
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The list of Sensor Objects associated with the device.
        /// </summary>
        [DataMember(Name = "sensors")]
        public Sensor Sensors { get; set; }

        /// <summary>
        /// The list of Output Objects associated with the device
        /// </summary>
        [DataMember(Name = "outputs")]
        public Output Outputs { get; set; }
    }
}
