using System;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Set
{
    [DataContract]
    public class SetRenameRequest : RequestBase
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
        /// The type of request. Always "rename".
        /// </summary>
        [DataMember(Name = "operation")]
        public string Operation { get { return "rename"; } }

        /// <summary>
        /// The path of the set to rename.
        /// </summary>
        [DataMember(Name = "setPath")]
        public string SetPath { get; set; }

        /// <summary>
        /// The new name to assign. Must be unique to that parent.
        /// </summary>
        [DataMember(Name = "newName")]
        public string NewName { get; set; }
    }
}
