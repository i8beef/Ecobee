using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ElectricityDevice
    {
        public ElectricityDevice()
        {
            Tiers = new List<ElectricityTier>();
        }

        /// <summary>
        /// The name of the device
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The list of Electricity Tiers containing the break down of daily 
        /// electricity consumption of the device for the day, broken down per pricing tier.
        /// </summary>
        [JsonProperty(PropertyName = "tiers")]
        public IList<ElectricityTier> Tiers { get; set; }

        /// <summary>
        /// The last date/time the reading was updated in UTC time.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdate")]
        public string LastUpdate { get; set; }

        /// <summary>
        /// The last three daily electricity cost reads from the device in 
        /// cents with a three decimal place precision.
        /// </summary>
        [JsonProperty(PropertyName = "cost")]
        public string Cost { get; set; }

        /// <summary>
        /// The last three daily electricity consumption reads from the 
        /// device in KWh with a three decimal place precision.
        /// </summary>
        [JsonProperty(PropertyName = "consumption")]
        public string Consumption { get; set; }
    }
}