using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class Action
    {
        /// <summary>
        /// Values: activateRelay, adjustTemp, doNothing, shutdownAC, shutdownAuxHeat, 
        /// shutdownSystem, shutdownCompression, switchToOccupied, switchToUnoccupied, 
        /// turnOffDehumidifer, turnOffHumidifier, turnOnCool, turnOnDehumidifier, 
        /// turnOnFan, turnOnHeat, turnOnHumidifier.
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Flag to enable an alert to be generated when the state is triggered.
        /// </summary>
        [DataMember(Name = "sendAlert")]
        public bool SendAlert { get; set; }

        /// <summary>
        /// Whether to send an update message.
        /// </summary>
        [DataMember(Name = "sendUpdate")]
        public bool SendUpdate { get; set; }

        /// <summary>
        /// Delay in seconds before the action is triggered by the state change.
        /// </summary>
        [DataMember(Name = "activationDelay")]
        public int ActivationDelay { get; set; }

        /// <summary>
        /// The amount of time to wait before deactivating this state after the state has been cleared.
        /// </summary>
        [DataMember(Name = "deactivationDelay")]
        public int DeactivationDelay { get; set; }

        /// <summary>
        /// The minimum length of time to maintain action after sensor has been deactivated.
        /// </summary>
        [DataMember(Name = "minActionDuration")]
        public int MinActionDuration { get; set; }

        /// <summary>
        /// The amount to increase/decrease current setpoint if the type = adjustTemp.
        /// </summary>
        [DataMember(Name = "heatAdjustTemp")]
        public int HeatAdjustTemp { get; set; }

        /// <summary>
        /// The amount to increase/decrease current setpoint if the type = adjustTemp.
        /// </summary>
        [DataMember(Name = "coolAdjustTemp")]
        public int CoolAdjustTemp { get; set; }

        /// <summary>
        /// The user defined relay to be activated, only used for type == activateRelay.
        /// </summary>
        [DataMember(Name = "activateRelay")]
        public string ActivateRelay { get; set; }

        /// <summary>
        /// Select if relay is to be open or closed when activated, only used for type == activateRelay.
        /// </summary>
        [DataMember(Name = "activateRelayOpen")]
        public bool ActivateRelayOpen { get; set; }
    }
}
