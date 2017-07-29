using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Thermostat
{
    /// <summary>
    /// Ecobee API thermostat summary response.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ThermostatSummaryResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThermostatSummaryResponse"/> class.
        /// </summary>
        public ThermostatSummaryResponse()
        {
            RevisionList = new List<string>();
            StatusList = new List<string>();
        }

        /// <summary>
        /// The list of CSV revision values.
        /// </summary>
        [JsonProperty(PropertyName = "revisionList")]
        public IList<string> RevisionList { get; set; }

        /// <summary>
        /// Integer Number of thermostats listed in the Revision List.
        /// </summary>
        [JsonProperty(PropertyName = "thermostatCount")]
        public int ThermostatCount { get; set; }

        /// <summary>
        /// CSV[] The list of CSV status values.
        /// </summary>
        [JsonProperty(PropertyName = "statusList")]
        public IList<string> StatusList { get; set; }
    }
}
