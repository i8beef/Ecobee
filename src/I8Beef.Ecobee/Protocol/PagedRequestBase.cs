using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol
{
    /// <summary>
    /// Base class for paged Ecobee API requests.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class PagedRequestBase : RequestBase
    {
        /// <summary>
        /// The Page object is optional and will only appear for responses which can be paged.
        /// It will not appear for responses which do not contain pageable content.
        /// </summary>
        [JsonProperty(PropertyName = "page")]
        public Page Page { get; set; }
    }
}
