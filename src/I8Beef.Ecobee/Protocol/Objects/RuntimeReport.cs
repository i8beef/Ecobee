using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class RuntimeReport
    {
        public RuntimeReport()
        {
            RowList = new List<string>();
        }

        /// <summary>
        /// The thermostat identifier for the report.
        /// </summary>
        [DataMember(Name = "thermostatIdentifier")]
        public string ThermostatIdentifier { get; set; }

        /// <summary>
        /// The number of report rows in this report
        /// </summary>
        [DataMember(Name = "rowCount")]
        public int RowCount { get; set; }

        /// <summary>
        /// A list of CSV report strings based on the columns requested.
        /// </summary>
        [DataMember(Name = "rowList")]
        public IList<string> RowList { get; set; }
    }
}
