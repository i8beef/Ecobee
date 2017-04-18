using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Thermostat
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ThermostatResponse : PagedResponse
    {
        public ThermostatResponse()
        {
            ThermostatList = new List<Objects.Thermostat>();
        }

        /// <summary>
        /// The list of thermostats returned by the request.
        /// </summary>
        [JsonProperty(PropertyName = "thermostatList")]
        public IList<Objects.Thermostat> ThermostatList { get; set; }
    }
}
