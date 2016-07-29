using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Thermostat
{
    [DataContract]
    public class ThermostatResponse : PagedResponse
    {
        public ThermostatResponse()
        {
            ThermostatList = new List<Objects.Thermostat>();
        }

        /// <summary>
        /// The list of thermostats returned by the request.
        /// </summary>
        [DataMember(Name = "thermostatList")]
        public IList<Objects.Thermostat> ThermostatList { get; set; }
    }
}
