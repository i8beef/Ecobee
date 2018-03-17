using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API VoiceEngine.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class VoiceEngine
    {
        /// <summary>
        /// The name of the voice engine.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// True if the voice engine is currently enabled (paired) for the ecobee account of
        /// selected thermostat. You can change the flag value by using UnlinkVoiceEngine
        /// thermostat function.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }
    }
}
