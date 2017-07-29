using System;
using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Thermostat
{
    /// <summary>
    /// Ecobee API thermostat summary request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ThermostatSummaryRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/thermostatSummary"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.GET; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(ThermostatSummaryResponse); } }

        /// <summary>
        /// The selection criteria for update.
        /// </summary>
        [JsonProperty(PropertyName = "selection")]
        public Selection Selection { get; set; }
    }
}
