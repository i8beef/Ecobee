using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class MeterReportData
    {
        public MeterReportData()
        {
            Data = new List<string>();
        }

        /// <summary>
        /// The type of meter the data is for.
        /// </summary>
        [DataMember(Name = "meterType")]
        public string MeterType { get; set; }

        /// <summary>
        /// The columns provided in the data.
        /// </summary>
        [DataMember(Name = "columns")]
        public string Columns { get; set; }

        /// <summary>
        /// A list of rows of CSV data matching the columns property.
        /// </summary>
        [DataMember(Name = "data")]
        public IList<string> Data { get; set; }
    }
}
