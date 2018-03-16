using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API program.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Program
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Program"/> class.
        /// </summary>
        public Program()
        {
            Schedule = new List<string[]>();
            Climates = new List<Climate>();
        }

        /// <summary>
        /// The Schedule object defining the program schedule.
        /// </summary>
        [JsonProperty(PropertyName = "schedule", Required = Required.Always)]
        public IList<string[]> Schedule { get; set; }

        /// <summary>
        /// The list of Climate objects defining all the climates in the program schedule.
        /// </summary>
        [JsonProperty(PropertyName = "climates", Required = Required.Always)]
        public IList<Climate> Climates { get; set; }

        /// <summary>
        /// The currently active climate, identified by its ClimateRef.
        /// </summary>
        [JsonProperty(PropertyName = "currentClimateRef")]
        public string CurrentClimateRef { get; set; }
    }
}
