using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Hierarchy.Set
{
    [DataContract]
    public class SetListResponse : Response
    {
        public SetListResponse()
        {
            Sets = new List<Objects.HierarchySet>();
        }

        /// <summary>
        /// list of hierarchy management sets.
        /// </summary>
        [DataMember(Name = "sets")]
        public IList<Objects.HierarchySet> Sets { get; set; }
    }
}
