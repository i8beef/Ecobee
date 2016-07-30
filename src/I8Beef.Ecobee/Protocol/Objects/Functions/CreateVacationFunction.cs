using I8Beef.Ecobee.Protocol.Objects;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions
{
    [DataContract]
    [KnownType(typeof(CreateVacationParams))]
    public class CreateVacationFunction : Function
    {
        public CreateVacationFunction()
        {
            Params = new CreateVacationParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get { return "createVacation"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See 
        /// individual function documentation for the properties.
        /// </summary>
        [DataMember(Name = "params")]
        public override FunctionParams Params { get; set; }
    }

    [DataContract]
    public class CreateVacationParams : FunctionParams
    {
        /// <summary>
        /// The vacation event name. It must be unique.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The temperature to set the cool vacation hold at.
        /// </summary>
        [DataMember(Name = "coolHoldTemp")]
        public int CoolHoldTemp { get; set; }

        /// <summary>
        /// The temperature to set the heat vacation hold at.
        /// </summary>
        [DataMember(Name = "heatHoldTemp")]
        public int HeatHoldTemp { get; set; }

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
        /// The fan mode during the vacation. Values: auto, on Default: auto
        /// </summary>
        [DataMember(Name = "fan")]
        public string Fan { get; set; }

        /// <summary>
        /// The minimum number of minutes to run the fan each hour. Range: 0-60, Default: 0
        /// </summary>
        [DataMember(Name = "fanMinOnTime")]
        public string FanMinOnTime { get; set; }
    }
}
