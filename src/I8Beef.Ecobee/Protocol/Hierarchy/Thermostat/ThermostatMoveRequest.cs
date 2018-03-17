using System;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Thermostat
{
    /// <summary>
    /// Ecobee API thermostat move request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ThermostatMoveRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/hierarchy/thermostat"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.POST; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(Response); } }

        /// <summary>
        /// The type of request. Always "move".
        /// </summary>
        [JsonProperty(PropertyName = "operation", Required = Required.Always)]
        public string Operation { get { return "move"; } }

        /// <summary>
        /// The set path the thermostats are being moved from.
        /// </summary>
        [JsonProperty(PropertyName = "setPath", Required = Required.Always)]
        public string SetPath { get; set; }

        /// <summary>
        /// The set path the thermostats are being moved to.
        /// </summary>
        [JsonProperty(PropertyName = "toPath", Required = Required.Always)]
        public string ToPath { get; set; }

        /// <summary>
        /// Comma separated list of thermostat identifiers. The thermostats must reside in the
        /// from set. If this property is not provided, all thermostats will be moved which
        /// reside in the from set.
        /// </summary>
        [JsonProperty(PropertyName = "thermostats")]
        public string Thermostats { get; set; }
    }
}
