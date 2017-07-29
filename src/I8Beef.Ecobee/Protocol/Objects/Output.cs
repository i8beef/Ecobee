using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API output.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Output
    {
        /// <summary>
        /// The name of the outpute
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The thermostat zone the output is associated with
        /// </summary>
        [JsonProperty(PropertyName = "zone")]
        public int Zone { get; set; }

        /// <summary>
        /// The unique output identifier number.
        /// </summary>
        [JsonProperty(PropertyName = "outputId")]
        public int OutputId { get; set; }

        /// <summary>
        /// The type of output. Values: compressor1, compressor2, dehumidifier, economizer, fan, heat1, heat2,
        /// heat3, heatPumpReversal, humidifer, none, occupancy, userDefined, ventilator, zoneCool, zoneFan,
        /// zoneHeat.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Whether to send an update message.
        /// </summary>
        [JsonProperty(PropertyName = "sendUpdate")]
        public bool SendUpdate { get; set; }

        /// <summary>
        /// If true, when this output is activated it will close the relay. Otherwise, activating the relay will
        /// open the relay.
        /// </summary>
        [JsonProperty(PropertyName = "activeClosed")]
        public bool ActiveClosed { get; set; }

        /// <summary>
        /// Time to activate relay - in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "activationTime")]
        public int ActivationTime { get; set; }

        /// <summary>
        /// Time to deactivate relay - in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "deactivationTime")]
        public int DeactivationTime { get; set; }
    }
}
