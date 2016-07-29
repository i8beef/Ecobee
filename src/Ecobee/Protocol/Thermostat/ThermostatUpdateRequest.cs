using I8Beef.Ecobee.Protocol.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Thermostat
{
    [DataContract]
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
        [DataMember(Name = "selection")]
        public Selection Selection { get; set; }

        /// <summary>
        /// The thermostat object with properties to update.
        /// </summary>
        [DataMember(Name = "thermostat")]
        public Objects.Thermostat Thermostat { get; set; }

        /// <summary>
        /// The list of functions to perform on all selected thermostats.
        /// </summary>
        [DataMember(Name = "functions")]
        public IList<Function> Functions { get; set; }
    }
}
