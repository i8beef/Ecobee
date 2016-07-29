using System;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Set
{
    [DataContract]
    public class SetMoveRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/hierarchy/set"; } }

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
        [DataMember(Name = "operation")]
        public string Operation { get { return "move"; } }

        /// <summary>
        /// The path of the set to move.
        /// </summary>
        [DataMember(Name = "setPath")]
        public string SetPath { get; set; }

        /// <summary>
        /// The path of the new parent to move to.
        /// </summary>
        [DataMember(Name = "toPath")]
        public string ToPath { get; set; }
    }
}
