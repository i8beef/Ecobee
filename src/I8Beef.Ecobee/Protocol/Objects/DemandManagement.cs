using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API demand management.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DemandManagement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DemandManagement"/> class.
        /// </summary>
        public DemandManagement()
        {
            TempOffsets = new List<int>();
        }

        /// <summary>
        /// The date(UTC) for the beginning of this day's demand management series.
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        /// <summary>
        /// The hour in the day this series begins at.Range: 0-23
        /// </summary>
        [JsonProperty(PropertyName = "hour")]
        public int Hour { get; set; }

        /// <summary>
        /// The series of 12, 5 minute interval temperature adjustments in the hour.
        /// Valid integer values are required for each interval. See Temperature values.
        /// </summary>
        [JsonProperty(PropertyName = "tempOffsets")]
        public IList<int> TempOffsets { get; set; }
    }
}