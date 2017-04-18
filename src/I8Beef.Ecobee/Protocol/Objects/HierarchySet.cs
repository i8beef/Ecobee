using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class HierarchySet
    {
        public HierarchySet()
        {
            Children = new List<HierarchySet>();
            Privileges = new List<HierarchyPrivilege>();
            Thermostats = new List<string>();
        }

        /// <summary>
        /// The name of the hierarchy set.
        /// </summary>
        [JsonProperty(PropertyName = "setName")]
        public string SetName { get; set; }

        /// <summary>
        /// The full path from the root to the hierarchy set.
        /// </summary>
        [JsonProperty(PropertyName = "setPath")]
        public string SetPath { get; set; }

        /// <summary>
        /// The list of child hierarchy sets.
        /// </summary>
        [JsonProperty(PropertyName = "children")]
        public IList<HierarchySet> Children { get; set; }

        /// <summary>
        /// The list of hierarchy privileges assigned to this hierarchy set.
        /// </summary>
        [JsonProperty(PropertyName = "privileges")]
        public IList<HierarchyPrivilege> Privileges { get; set; }

        /// <summary>
        /// The list of thermostats assigned to this hierarchy set.
        /// </summary>
        [JsonProperty(PropertyName = "thermostats")]
        public IList<string> Thermostats { get; set; }

    }
}
