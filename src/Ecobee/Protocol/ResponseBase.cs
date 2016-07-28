using Ecobee.Protocol.Objects;
using System.Runtime.Serialization;

namespace Ecobee.Protocol
{
    [DataContract]
    public abstract class ResponseBase
    {
        /// <summary>
        /// The Status object contains the response code for the request. It will also 
        /// contain an appropriate message when an error occurs. The status is always 
        /// returned from all GET and POST calls. A non-zero code means that an error 
        /// occurred. Refer to the Response Codes section for details of each error which 
        /// may be returned.
        /// </summary>
        [DataMember(Name = "status")]
        public Status Status { get; set; }
    }
}
