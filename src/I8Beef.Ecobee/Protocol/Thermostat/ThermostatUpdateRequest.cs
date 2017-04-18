using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Thermostat
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ThermostatUpdateRequest : RequestBase
    {
        public ThermostatUpdateRequest()
        {
            Functions = new List<Function>();
        }

        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/thermostat"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.POST; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(Response); } }

        /// <summary>
        /// The selection criteria for update.
        /// </summary>
        [JsonProperty(PropertyName = "selection")]
        public Selection Selection { get; set; }

        /// <summary>
        /// The thermostat object with properties to update.
        /// </summary>
        [JsonProperty(PropertyName = "thermostat")]
        public dynamic Thermostat { get; set; }

        /// <summary>
        /// The list of functions to perform on all selected thermostats.
        /// </summary>
        [JsonProperty(PropertyName = "functions")]
        public IList<Function> Functions { get; set; }
    }
}
