using I8Beef.Ecobee.Protocol.Objects;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions
{
    [DataContract]
    [KnownType(typeof(SetHoldParams))]
    public class SetHoldFunction : Function
    {
        public SetHoldFunction()
        {
            Params = new SetHoldParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get { return "setHold"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See 
        /// individual function documentation for the properties.
        /// </summary>
        [DataMember(Name = "params")]
        public override FunctionParams Params { get; set; }
    }

    [DataContract]
    public class SetHoldParams : FunctionParams
    {
        /// <summary>
        /// The temperature to set the cool hold at.
        /// </summary>
        [DataMember(Name = "coolHoldTemp")]
        public int CoolHoldTemp { get; set; }

        /// <summary>
        /// The temperature to set the heat hold at.
        /// </summary>
        [DataMember(Name = "heatHoldTemp")]
        public int HeatHoldTemp { get; set; }

        /// <summary>
        /// The Climate to use as reference for setting the coolHoldTemp, heatHoldTemp and fan 
        /// settings for this hold. If this value is passed the coolHoldTemp and heatHoldTemp 
        /// are not required.
        /// </summary>
        [DataMember(Name = "holdClimateRef")]
        public string HoldClimateRef { get; set; }

        /// <summary>
        /// The start date in thermostat time.
        /// </summary>
        [DataMember(Name = "startDate")]
        public string StartDate { get; set; }

        /// <summary>
        /// The start time in thermostat time.
        /// </summary>
        [DataMember(Name = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// The end date in thermostat time.
        /// </summary>
        [DataMember(Name = "endDate")]
        public string EndDate { get; set; }

        /// <summary>
        /// The end time in thermostat time.
        /// </summary>
        [DataMember(Name = "endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// The hold duration type. Valid values: dateTime, nextTransition, indefinite, 
        /// holdHours.
        /// </summary>
        [DataMember(Name = "holdType")]
        public string HoldType { get; set; }

        /// <summary>
        /// The number of hours to hold for, used and required if holdType='holdHours'.
        /// </summary>
        [DataMember(Name = "holdHours")]
        public int HoldHours { get; set; }
    }
}
