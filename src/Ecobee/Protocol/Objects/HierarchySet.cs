using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
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
        [DataMember(Name = "setName")]
        public string SetName { get; set; }

        /// <summary>
        /// The full path from the root to the hierarchy set.
        /// </summary>
        [DataMember(Name = "setPath")]
        public string SetPath { get; set; }

        /// <summary>
        /// The list of child hierarchy sets.
        /// </summary>
        [DataMember(Name = "children")]
        public IList<HierarchySet> Children { get; set; }

        /// <summary>
        /// The list of hierarchy privileges assigned to this hierarchy set.
        /// </summary>
        [DataMember(Name = "privileges")]
        public IList<HierarchyPrivilege> Privileges { get; set; }

        /// <summary>
        /// The list of thermostats assigned to this hierarchy set.
        /// </summary>
        [DataMember(Name = "thermostats")]
        public IList<string> Thermostats { get; set; }

    }
}
