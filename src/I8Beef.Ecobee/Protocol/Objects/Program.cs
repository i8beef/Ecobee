using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Program
    {
        public Program()
        {
            Schedule = new List<string[]>();
            Climates = new List<Climate>();
        }

        /// <summary>
        /// The Schedule object defining the program schedule.
        /// </summary>
        [JsonProperty(PropertyName = "schedule")]
        public IList<string[]> Schedule { get; set; }

        /// <summary>
        /// The list of Climate objects defining all the climates in the program schedule.
        /// </summary>
        [JsonProperty(PropertyName = "climates")]
        public IList<Climate> Climates { get; set; }

        /// <summary>
        /// The currently active climate, identified by its ClimateRef.
        /// </summary>
        [JsonProperty(PropertyName = "currentClimateRef")]
        public string CurrentClimateRef { get; set; }
    }
}
