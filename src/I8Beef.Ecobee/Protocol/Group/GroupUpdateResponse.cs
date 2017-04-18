using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Group
{
    [JsonObject(MemberSerialization.OptIn)]
    public class GroupUpdateResponse : Response
    {
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
