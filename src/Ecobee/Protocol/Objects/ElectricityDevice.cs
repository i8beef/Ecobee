using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class ElectricityDevice
    {
        public ElectricityDevice()
        {
            Tiers = new List<ElectricityTier>();
        }

        /// <summary>
        /// The name of the device
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// []	yes	no	The list of Electricity Tiers containing the break down of daily 
        /// electricity consumption of the device for the day, broken down per pricing tier.
        /// </summary>
        [DataMember(Name = "tiers")]
        public IList<ElectricityTier> Tiers { get; set; }

        /// <summary>
        /// The last date/time the reading was updated in UTC time.
        /// </summary>
        [DataMember(Name = "lastUpdate")]
        public string LastUpdate { get; set; }

        /// <summary>
        /// []	yes	no	The last three daily electricity cost reads from the device in 
        /// cents with a three decimal place precision.
        /// </summary>
        [DataMember(Name = "cost")]
        public string Cost { get; set; }

        /// <summary>
        /// []	yes	no	The last three daily electricity consumption reads from the 
        /// device in KWh with a three decimal place precision.
        /// </summary>
        [DataMember(Name = "consumption")]
        public string Consumption { get; set; }
    }
}