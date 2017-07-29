using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Set
{
    /// <summary>
    /// Ecobee API set list response.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SetListResponse : Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetListResponse"/> class.
        /// </summary>
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
