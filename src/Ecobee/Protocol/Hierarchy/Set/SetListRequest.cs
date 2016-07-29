using System;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Set
{
    [DataContract]
    public class SetListRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/hierarchy/set"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.GET; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(SetListResponse); } }

        /// <summary>
        /// The type of request. Always "list".
        /// </summary>
        [DataMember(Name = "operation")]
        public string Operation { get { return "list"; } }

        /// <summary>
        /// The management set path.
        /// </summary>
        [DataMember(Name = "setPath")]
        public string SetPath { get; set; }

        /// <summary>
        /// Whether to also return the children of the children, recursively. Default: false
        /// </summary>
        [DataMember(Name = "recursive")]
        public bool Recursive { get; set; }

        /// <summary>
        /// Whether to include the privileges with each set. Default: false
        /// </summary>
        [DataMember(Name = "includePrivileges")]
        public bool IncludePrivileges { get; set; }

        /// <summary>
        /// Whether to include a list of all thermostat identifiers assigned to each set. Default: false
        /// </summary>
        [DataMember(Name = "includeThermostats")]
        public bool IncludeThermostats { get; set; }
    }
}
