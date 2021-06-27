using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API meter report.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class MeterReport
    {
        /// <summary>
        /// The thermostat identifier this report is for.
        /// </summary>
        [JsonProperty(PropertyName = "thermostatIdentifier")]
        public string ThermostatIdentifier { get; set; }

        /// <summary>
        /// The list of meter data for the meters requested. If the thermostat has no
        /// meter, the object for that meter will not be included in the list. A
        /// thermostat with no meters will have this list empty.
        /// </summary>
        [JsonProperty(PropertyName = "meterList")]
        public IList<MeterReportData> MeterList { get; set; }
    }
}
