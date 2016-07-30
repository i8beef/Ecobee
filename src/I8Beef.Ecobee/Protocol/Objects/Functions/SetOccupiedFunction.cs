using I8Beef.Ecobee.Protocol.Objects;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions
{
    [DataContract]
    [KnownType(typeof(SetOccupiedParams))]
    public class SetOccupiedFunction : Function
    {
        public SetOccupiedFunction()
        {
            Params = new SetOccupiedParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get { return "setOccupied"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See 
        /// individual function documentation for the properties.
        /// </summary>
        [DataMember(Name = "params")]
        public override FunctionParams Params { get; set; }
    }

    [DataContract]
    public class SetOccupiedParams : FunctionParams
    {
        /// <summary>
        /// The climate to use for the temperature, occupied (true) or unoccupied (false).
        /// </summary>
        [DataMember(Name = "occupied")]
        public bool Occupied { get; set; }

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
        /// The hold duration type. Valid values: dateTime, nextTransition, indefinite, holdHours.
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
