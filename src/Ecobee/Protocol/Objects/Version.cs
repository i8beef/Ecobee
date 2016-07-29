using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class Version
    {
        /// <summary>
        /// The thermostat firmware version number.
        /// </summary>
        [DataMember(Name = "thermostatFirmwareVersion")]
        public string ThermostatFirmwareVersion { get; set; }
    }
}
