using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Thermostat
{
    [DataContract]
    public class ThermostatSummaryResponse : Response
    {
        public ThermostatSummaryResponse()
        {
            RevisionList = new List<string>();
            StatusList = new List<string>();
        }

        /// <summary>
        /// The list of CSV revision values.
        /// </summary>
        [DataMember(Name = "revisionList")]
        public IList<string> RevisionList { get; set; }

        /// <summary>
        /// Integer Number of thermostats listed in the Revision List.
        /// </summary>
        [DataMember(Name = "thermostatCount")]
        public int ThermostatCount { get; set; }

        /// <summary>
        /// CSV[] The list of CSV status values.
        /// </summary>
        [DataMember(Name = "statusList")]
        public IList<string> StatusList { get; set; }
    }
}
