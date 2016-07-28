using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class Function
    {
        public Function()
        {
            Params = new Dictionary<string, string>();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See 
        /// individual function documentation for the properties.
        /// </summary>
        [DataMember(Name = "params")]
        public IDictionary<string, string> Params { get; set; }
    }
}
