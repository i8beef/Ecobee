using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class State
    {
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