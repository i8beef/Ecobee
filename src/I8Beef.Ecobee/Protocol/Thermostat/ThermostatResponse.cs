using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Thermostat
{
    /// <summary>
    /// Ecobee API thermostat response.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ThermostatResponse : PagedResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThermostatResponse"/> class.
        /// </summary>
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
