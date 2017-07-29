using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Group
{
    /// <summary>
    /// Ecobee API group response.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GroupResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupResponse"/> class.
        /// </summary>
        public GroupResponse()
        {
            Groups = new List<Objects.Group>();
        }

        /// <summary>
        /// The list of Groups returned by the request.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<Objects.Group> Groups { get; set; }
    }
}
