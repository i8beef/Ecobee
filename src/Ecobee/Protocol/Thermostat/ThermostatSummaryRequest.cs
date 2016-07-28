using Ecobee.Protocol.Objects;
using System.Runtime.Serialization;

namespace Ecobee.Protocol.Thermostat
{
    [DataContract]
    public class ThermostatSummaryRequest : RequestBase
    {
        /// <summary>
        /// The selection criteria for update.
        /// </summary>
        [DataMember(Name = "selection")]
        public Selection Selection { get; set; }
    }
}
