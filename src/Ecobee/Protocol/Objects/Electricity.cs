using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
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
        [DataMember(Name = "devices")]
        public IList<ElectricityDevice> Devices { get; set; }
    }
}
