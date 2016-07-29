using I8Beef.Ecobee.Protocol.Objects;
using System;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Report
{
    [DataContract]
    public class MeterReportRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/meterReport"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.GET; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(MeterReportResponse); } }

        /// <summary>
        /// The Selection Object. Must be selectionType = 'thermostats' and selectionMatch = a CSV of 
        /// thermostat identifiers.
        /// </summary>
        [DataMember(Name = "selection")]
        public Selection Selection { get; set; }

        /// <summary>
        /// The UTC report start date.
        /// </summary>
        [DataMember(Name = "startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The 5 minute interval to begin the report on. The interval can be determined by multiplying the 
        /// interval by 5. Range: 0-287 Default: 0
        /// </summary>
        [DataMember(Name = "startInterval")]
        public int StartInterval { get; set; }

        /// <summary>
        /// The UTC report end date.
        /// </summary>
        [DataMember(Name = "endDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The 5 minute interval to end the report on. The interval can be determined by multiplying the 
        /// interval by 5. Range: 0-287 Default: 287
        /// </summary>
        [DataMember(Name = "endInterval")]
        public int EndInterval { get; set; }

        /// <summary>
        /// A CSV string of meter types. See Meter Types
        /// </summary>
        [DataMember(Name = "meters")]
        public string Meters { get; set; }

    }
}
