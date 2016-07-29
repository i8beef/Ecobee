using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class ElectricityTier
    {
        /// <summary>
        /// The tier name as defined by the Utility. May be an empty string if the tier is 
        /// undefined or the usage falls outside the defined tiers.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The last daily consumption reading collected. The reading format and precision 
        /// is to three decimal places in kWh.
        /// </summary>
        [DataMember(Name = "consumption")]
        public string Consumption { get; set; }

        /// <summary>
        /// The daily cumulative tier cost in dollars if defined by the Utility. May be an 
        /// empty string if undefined.
        /// </summary>
        [DataMember(Name = "cost")]
        public string Cost { get; set; }
    }
}