using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class Output
    {
        /// <summary>
        /// The name of the outpute
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The thermostat zone the output is associated with
        /// </summary>
        [DataMember(Name = "zone")]
        public int Zone { get; set; }

        /// <summary>
        /// The unique output identifier number.
        /// </summary>
        [DataMember(Name = "outputId")]
        public int OutputId { get; set; }

        /// <summary>
        /// The type of output. Values: compressor1, compressor2, dehumidifier, economizer, fan, heat1, heat2, 
        /// heat3, heatPumpReversal, humidifer, none, occupancy, userDefined, ventilator, zoneCool, zoneFan, 
        /// zoneHeat.
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Whether to send an update message.
        /// </summary>
        [DataMember(Name = "sendUpdate")]
        public bool SendUpdate { get; set; }

        /// <summary>
        /// If true, when this output is activated it will close the relay. Otherwise, activating the relay will 
        /// open the relay.
        /// </summary>
        [DataMember(Name = "activeClosed")]
        public bool ActiveClosed { get; set; }

        /// <summary>
        /// Time to activate relay - in seconds.
        /// </summary>
        [DataMember(Name = "activationTime")]
        public int ActivationTime { get; set; }

        /// <summary>
        /// Time to deactivate relay - in seconds.
        /// </summary>
        [DataMember(Name = "deactivationTime")]
        public int DeactivationTime { get; set; }
    }
}
