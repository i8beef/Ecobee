using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API set hold params.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SetHoldParams : FunctionParams
    {
        /// <summary>
        /// The temperature to set the cool hold at.
        /// </summary>
        [JsonProperty(PropertyName = "coolHoldTemp")]
        public int CoolHoldTemp { get; set; }

        /// <summary>
        /// The temperature to set the heat hold at.
        /// </summary>
        [JsonProperty(PropertyName = "heatHoldTemp")]
        public int HeatHoldTemp { get; set; }

        /// <summary>
        /// The Climate to use as reference for setting the coolHoldTemp, heatHoldTemp and fan
        /// settings for this hold. If this value is passed the coolHoldTemp and heatHoldTemp
        /// are not required.
        /// </summary>
        [JsonProperty(PropertyName = "holdClimateRef")]
        public string HoldClimateRef { get; set; }

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
        /// The hold duration type. Valid values: dateTime, nextTransition, indefinite,
        /// holdHours.
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
