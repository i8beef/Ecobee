using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Report
{
    [JsonObject(MemberSerialization.OptIn)]
    public class RuntimeReportResponse : Response
    {
        public RuntimeReportResponse()
        {
            ReportList = new List<RuntimeReport>();
            SensorList = new List<RuntimeSensorReport>();
        }

        /// <summary>
        /// report UTC start date.
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// report start interval.
        /// </summary>
        [JsonProperty(PropertyName = "startInterval")]
        public int StartInterval { get; set; }

        /// <summary>
        /// report UTC end date.
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// report end interval.
        /// </summary>
        [JsonProperty(PropertyName = "endInterval")]
        public int EndInterval { get; set; }

        /// <summary>
        /// CSV list of column names from the request.
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public string Columns { get; set; }

        /// <summary>
        /// A list of runtime reports.
        /// </summary>
        [JsonProperty(PropertyName = "reportList")]
        public IList<RuntimeReport> ReportList { get; set; }

        /// <summary>
        /// A list of runtime sensor reports. Will be empty unless requested.
        /// </summary>
        [JsonProperty(PropertyName = "sensorList")]
        public IList<RuntimeSensorReport> SensorList { get; set; }
    }
}
