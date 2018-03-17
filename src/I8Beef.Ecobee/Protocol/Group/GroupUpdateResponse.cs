using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Group
{
    /// <summary>
    /// Ecobee API group update response.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GroupUpdateResponse : Response
    {
        /// <summary>
        /// The list of Groups updated by the request.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<Objects.Group> Groups { get; set; }
    }
}
