using I8Beef.Ecobee.Protocol.Objects;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions
{
    [DataContract]
    [KnownType(typeof(AcknowledgeParams))]
    public class AcknowledgeFunction : Function
    {
        public AcknowledgeFunction()
        {
            Params = new AcknowledgeParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get { return "acknowledge"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See 
        /// individual function documentation for the properties.
        /// </summary>
        [DataMember(Name = "params")]
        public override FunctionParams Params { get; set; }
    }

    [DataContract]
    public class AcknowledgeParams : FunctionParams
    {
        /// <summary>
        /// The thermostat identifier to acknowledge the alert for.
        /// </summary>
        [DataMember(Name = "thermostatIdentifier")]
        public string ThermostatIdentifier { get; set; }

        /// <summary>
        /// The acknowledge ref of alert.
        /// </summary>
        [DataMember(Name = "ackRef")]
        public string AckRef { get; set; }

        /// <summary>
        /// The type of acknowledgement. Valid values: accept, decline, defer, unacknowledged.
        /// </summary>
        [DataMember(Name = "ackType")]
        public string AckType { get; set; }

        /// <summary>
        /// Whether to remind at a later date, if this is a defer acknowledgement.
        /// </summary>
        [DataMember(Name = "remindMeLater")]
        public bool RemindMeLater { get; set; }
    }
}
