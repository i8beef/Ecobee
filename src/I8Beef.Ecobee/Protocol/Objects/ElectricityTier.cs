using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API electricity tier.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ElectricityTier
    {
        /// <summary>
        /// The tier name as defined by the Utility. May be an empty string if the tier is
        /// undefined or the usage falls outside the defined tiers.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The last daily consumption reading collected. The reading format and precision
        /// is to three decimal places in kWh.
        /// </summary>
        [JsonProperty(PropertyName = "consumption")]
        public string Consumption { get; set; }

        /// <summary>
        /// The daily cumulative tier cost in dollars if defined by the Utility. May be an
        /// empty string if undefined.
        /// </summary>
        [JsonProperty(PropertyName = "cost")]
        public string Cost { get; set; }
    }
}