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
        /// The list of thermostats returned by the request.
        /// </summary>
        [JsonProperty(PropertyName = "thermostatList")]
        public IList<Objects.Thermostat> ThermostatList { get; set; }
    }
}
