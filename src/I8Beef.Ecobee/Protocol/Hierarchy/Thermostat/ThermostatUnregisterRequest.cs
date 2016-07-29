using System;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Thermostat
{
    [DataContract]
    public class ThermostatUnregisterRequest : RequestBase
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
        /// The type of request. Always "unregister".
        /// </summary>
        [DataMember(Name = "operation")]
        public string Operation { get { return "unregister"; } }

        /// <summary>
        /// Comma separated list of thermostat identifiers.
        /// </summary>
        [DataMember(Name = "thermostats")]
        public string Thermostats { get; set; }
    }
}
