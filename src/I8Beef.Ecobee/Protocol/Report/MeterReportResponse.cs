using I8Beef.Ecobee.Protocol.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Report
{
    [DataContract]
    public class MeterReportResponse : Response
    {
        public MeterReportResponse()
        {
            ReportList = new List<MeterReport>();
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
        /// CSV list of meter types from the request.
        /// </summary>
        [DataMember(Name = "meters")]
        public string Meters { get; set; }

        /// <summary>
        /// A list of thermostat meter reports.
        /// </summary>
        [DataMember(Name = "reportList")]
        public IList<MeterReport> ReportList { get; set; }
    }
}
