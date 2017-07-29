using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol
{
    /// <summary>
    /// General Ecobee API response.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Response
    {
        /// <summary>
        /// The Status object contains the response code for the request. It will also
        /// contain an appropriate message when an error occurs. The status is always
        /// returned from all GET and POST calls. A non-zero code means that an error
        /// occurred. Refer to the Response Codes section for details of each error which
        /// may be returned.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Status Status { get; set; }
    }
}
