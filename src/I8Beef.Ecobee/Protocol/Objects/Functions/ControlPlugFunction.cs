using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ControlPlugFunction : Function
    {
        public ControlPlugFunction()
        {
            Params = new ControlPlugParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public override string Type { get { return "controlPlug"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See 
        /// individual function documentation for the properties.
        /// </summary>
        [JsonProperty(PropertyName = "params")]
        public override FunctionParams Params { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class ControlPlugParams : FunctionParams
    {
        /// <summary>
        /// The name of the plug. Ensure each plug has a unique name.
        /// </summary>
        [JsonProperty(PropertyName = "plugName")]
        public string PlugName { get; set; }

        /// <summary>
        /// The state to put the plug into. Valid values: on, off, resume.
        /// </summary>
        [JsonProperty(PropertyName = "plugState")]
        public string PlugState { get; set; }

        /// <summary>
        /// The start date in thermostat time.
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public string StartDate { get; set; }

        /// <summary>
        /// The start time in thermostat time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// The end date in thermostat time.
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public string EndDate { get; set; }

        /// <summary>
        /// The end time in thermostat time.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// The hold duration type. Valid values: dateTime, nextTransition, indefinite, holdHours.
        /// </summary>
        [JsonProperty(PropertyName = "holdType")]
        public string HoldType { get; set; }

        /// <summary>
        /// The number of hours to hold for, used and required if holdType='holdHours'.
        /// </summary>
        [JsonProperty(PropertyName = "holdHours")]
        public int HoldHours { get; set; }
    }
}
