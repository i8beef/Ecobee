using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Set
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SetListResponse : Response
    {
        public SetListResponse()
        {
            Sets = new List<Objects.HierarchySet>();
        }

        /// <summary>
        /// list of hierarchy management sets.
        /// </summary>
        [JsonProperty(PropertyName = "sets")]
        public IList<Objects.HierarchySet> Sets { get; set; }
    }
}
