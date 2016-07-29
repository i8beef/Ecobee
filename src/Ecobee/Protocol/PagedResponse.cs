using Ecobee.Protocol.Objects;
using System.Runtime.Serialization;

namespace Ecobee.Protocol
{
    [DataContract]
    public class PagedResponse : Response
    {
        /// <summary>
        /// The Page object is optional and will only appear for responses which can be paged.
        /// It will not appear for responses which do not contain pageable content.
        /// </summary>
        [DataMember(Name = "page")]
        public Page Page { get; set; }
    }
}
