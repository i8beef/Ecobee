using I8Beef.Ecobee.Protocol.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Group
{
    [DataContract]
    public class GroupUpdateRequest : RequestBase
    {
        public GroupUpdateRequest()
        {
            Groups = new List<dynamic>();
        }

        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/group"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.POST; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(GroupUpdateResponse); } }

        /// <summary>
        /// The selection criteria for the request.
        /// </summary>
        [DataMember(Name = "selection")]
        public Selection Selection { get; set; }

        /// <summary>
        /// The list of Groups to update.
        /// </summary>
        [DataMember(Name = "Groups")]
        public IList<dynamic> Groups { get; set; }
    }
}
