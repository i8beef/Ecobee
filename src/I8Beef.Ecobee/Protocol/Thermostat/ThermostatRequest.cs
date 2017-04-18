using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;
using System;

namespace I8Beef.Ecobee.Protocol.Thermostat
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ThermostatRequest : PagedRequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/thermostat"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.GET; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(ThermostatResponse); } }

        /// <summary>
        /// The selection criteria for update.
        /// </summary>
        [JsonProperty(PropertyName = "selection")]
        public Selection Selection { get; set; }
    }
}
