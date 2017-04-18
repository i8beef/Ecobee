using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class RuntimeReport
    {
        public RuntimeReport()
        {
            RowList = new List<string>();
        }

        /// <summary>
        /// The thermostat identifier for the report.
        /// </summary>
        [JsonProperty(PropertyName = "thermostatIdentifier")]
        public string ThermostatIdentifier { get; set; }

        /// <summary>
        /// The number of report rows in this report
        /// </summary>
        [JsonProperty(PropertyName = "rowCount")]
        public int RowCount { get; set; }

        /// <summary>
        /// A list of CSV report strings based on the columns requested.
        /// </summary>
        [JsonProperty(PropertyName = "rowList")]
        public IList<string> RowList { get; set; }
    }
}
