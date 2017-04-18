using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Action
    {
        /// <summary>
        /// Values: activateRelay, adjustTemp, doNothing, shutdownAC, shutdownAuxHeat, 
        /// shutdownSystem, shutdownCompression, switchToOccupied, switchToUnoccupied, 
        /// turnOffDehumidifer, turnOffHumidifier, turnOnCool, turnOnDehumidifier, 
        /// turnOnFan, turnOnHeat, turnOnHumidifier.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Flag to enable an alert to be generated when the state is triggered.
        /// </summary>
        [JsonProperty(PropertyName = "sendAlert")]
        public bool SendAlert { get; set; }

        /// <summary>
        /// Whether to send an update message.
        /// </summary>
        [JsonProperty(PropertyName = "sendUpdate")]
        public bool SendUpdate { get; set; }

        /// <summary>
        /// Delay in seconds before the action is triggered by the state change.
        /// </summary>
        [JsonProperty(PropertyName = "activationDelay")]
        public int ActivationDelay { get; set; }

        /// <summary>
        /// The amount of time to wait before deactivating this state after the state has been cleared.
        /// </summary>
        [JsonProperty(PropertyName = "deactivationDelay")]
        public int DeactivationDelay { get; set; }

        /// <summary>
        /// The minimum length of time to maintain action after sensor has been deactivated.
        /// </summary>
        [JsonProperty(PropertyName = "minActionDuration")]
        public int MinActionDuration { get; set; }

        /// <summary>
        /// The amount to increase/decrease current setpoint if the type = adjustTemp.
        /// </summary>
        [JsonProperty(PropertyName = "heatAdjustTemp")]
        public int HeatAdjustTemp { get; set; }

        /// <summary>
        /// The amount to increase/decrease current setpoint if the type = adjustTemp.
        /// </summary>
        [JsonProperty(PropertyName = "coolAdjustTemp")]
        public int CoolAdjustTemp { get; set; }

        /// <summary>
        /// The user defined relay to be activated, only used for type == activateRelay.
        /// </summary>
        [JsonProperty(PropertyName = "activateRelay")]
        public string ActivateRelay { get; set; }

        /// <summary>
        /// Select if relay is to be open or closed when activated, only used for type == activateRelay.
        /// </summary>
        [JsonProperty(PropertyName = "activateRelayOpen")]
        public bool ActivateRelayOpen { get; set; }
    }
}
