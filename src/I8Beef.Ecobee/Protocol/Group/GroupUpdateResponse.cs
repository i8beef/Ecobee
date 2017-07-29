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
        /// Initializes a new instance of the <see cref="GroupUpdateResponse"/> class.
        /// </summary>
        public GroupUpdateResponse()
        {
            Groups = new List<Objects.Group>();
        }

        /// <summary>
        /// The list of Groups updated by the request.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<Objects.Group> Groups { get; set; }
    }
}
