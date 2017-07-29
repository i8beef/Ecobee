using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API State.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class State
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="State"/> class.
        /// </summary>
        public State()
        {
            Actions = new List<Action>();
        }

        /// <summary>
        /// The maximum value the sensor can generate.
        /// </summary>
        [JsonProperty(PropertyName = "maxValue")]
        public int MaxValue { get; set; }

        /// <summary>
        /// The minimum value the sensor can generate.
        /// </summary>
        [JsonProperty(PropertyName = "minValue")]
        public int MinValue { get; set; }

        /// <summary>
        /// Values: coolHigh, coolLow, heatHigh, heatLow, high, low, transitionCount, normal.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The list of StateAction objects associated with the sensor.
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public IList<Action> Actions { get; set; }
    }
}