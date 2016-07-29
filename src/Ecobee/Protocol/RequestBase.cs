using System;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol
{
    [DataContract]
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
