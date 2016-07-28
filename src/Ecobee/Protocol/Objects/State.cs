using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class State
    {
        public State()
        {
            Actions = new List<Action>();
        }

        /// <summary>
        /// The maximum value the sensor can generate.
        /// </summary>
        [DataMember(Name = "maxValue")]
        public int MaxValue { get; set; }

        /// <summary>
        /// The minimum value the sensor can generate.
        /// </summary>
        [DataMember(Name = "minValue")]
        public int MinValue { get; set; }

        /// <summary>
        /// Values: coolHigh, coolLow, heatHigh, heatLow, high, low, transitionCount, normal.
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The list of StateAction objects associated with the sensor.
        /// </summary>
        [DataMember(Name = "actions")]
        public IList<Action> Actions { get; set; }

    }
}