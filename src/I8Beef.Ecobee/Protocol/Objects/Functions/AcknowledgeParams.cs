using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API acknowledge params.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AcknowledgeParams : FunctionParams
    {
        /// <summary>
        /// The thermostat identifier to acknowledge the alert for.
        /// </summary>
        [JsonProperty(PropertyName = "thermostatIdentifier")]
        public string ThermostatIdentifier { get; set; }

        /// <summary>
        /// The acknowledge ref of alert.
        /// </summary>
        [JsonProperty(PropertyName = "ackRef")]
        public string AckRef { get; set; }

        /// <summary>
        /// The type of acknowledgement. Valid values: accept, decline, defer, unacknowledged.
        /// </summary>
        [JsonProperty(PropertyName = "ackType")]
        public string AckType { get; set; }

        /// <summary>
        /// Whether to remind at a later date, if this is a defer acknowledgement.
        /// </summary>
        [JsonProperty(PropertyName = "remindMeLater")]
        public bool RemindMeLater { get; set; }
    }
}
