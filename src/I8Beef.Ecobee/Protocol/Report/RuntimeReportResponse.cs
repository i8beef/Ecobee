using I8Beef.Ecobee.Protocol.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Report
{
    [DataContract]
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
        [DataMember(Name = "startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// report start interval.
        /// </summary>
        [DataMember(Name = "startInterval")]
        public int StartInterval { get; set; }

        /// <summary>
        /// report UTC end date.
        /// </summary>
        [DataMember(Name = "endDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// report end interval.
        /// </summary>
        [DataMember(Name = "endInterval")]
        public int EndInterval { get; set; }

        /// <summary>
        /// CSV list of column names from the request.
        /// </summary>
        [DataMember(Name = "columns")]
        public string Columns { get; set; }

        /// <summary>
        /// A list of runtime reports.
        /// </summary>
        [DataMember(Name = "reportList")]
        public IList<RuntimeReport> ReportList { get; set; }

        /// <summary>
        /// A list of runtime sensor reports. Will be empty unless requested.
        /// </summary>
        [DataMember(Name = "sensorList")]
        public IList<RuntimeSensorReport> SensorList { get; set; }
    }
}
