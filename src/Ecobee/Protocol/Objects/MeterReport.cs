using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class MeterReport
    {
        public MeterReport()
        {
            MeterList = new List<MeterReportData>();
        }

        /// <summary>
        /// The thermostat identifier this report is for.
        /// </summary>
        [DataMember(Name = "thermostatIdentifier")]
        public string ThermostatIdentifier { get; set; }

        /// <summary>
        /// The list of meter data for the meters requested. If the thermostat has no 
        /// meter, the object for that meter will not be included in the list. A 
        /// thermostat with no meters will have this list empty.
        /// </summary>
        [DataMember(Name = "meterList")]
        public IList<MeterReportData> MeterList { get; set; }
    }
}
