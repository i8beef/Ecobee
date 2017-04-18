using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class MeterReportData
    {
        public MeterReportData()
        {
            Data = new List<string>();
        }

        /// <summary>
        /// The type of meter the data is for.
        /// </summary>
        [JsonProperty(PropertyName = "meterType")]
        public string MeterType { get; set; }

        /// <summary>
        /// The columns provided in the data.
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public string Columns { get; set; }

        /// <summary>
        /// A list of rows of CSV data matching the columns property.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<string> Data { get; set; }
    }
}
