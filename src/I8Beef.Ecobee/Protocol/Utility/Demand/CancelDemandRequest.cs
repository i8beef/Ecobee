using System;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Utility.Demand
{
    /// <summary>
    /// Ecobee API cancel demand request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CancelDemandRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/demandResponse"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.POST; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(Response); } }

        /// <summary>
        /// The type of request. Always "cancel".
        /// </summary>
        [JsonProperty(PropertyName = "operation", Required = Required.Always)]
        public string Operation { get; set; }

        /// <summary>
        /// The system generated ID of the DR.
        /// </summary>
        [JsonProperty(PropertyName = "demandResponseRef", Required = Required.Always)]
        public string DemandResponseRef { get; set; }
    }
}
