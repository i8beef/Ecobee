using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
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
        [DataMember(Name = "schedule")]
        public IList<string[]> Schedule { get; set; }

        /// <summary>
        /// The list of Climate objects defining all the climates in the program schedule.
        /// </summary>
        [DataMember(Name = "climates")]
        public IList<Climate> Climates { get; set; }

        /// <summary>
        /// The currently active climate, identified by its ClimateRef.
        /// </summary>
        [DataMember(Name = "currentClimateRef")]
        public string CurrentClimateRef { get; set; }
    }
}
