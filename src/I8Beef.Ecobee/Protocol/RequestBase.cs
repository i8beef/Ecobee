using Newtonsoft.Json;
using System;

namespace I8Beef.Ecobee.Protocol
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public abstract string Uri { get; }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public abstract RequestType RequestType { get; }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public abstract Type ResponseType { get; }
    }
}
