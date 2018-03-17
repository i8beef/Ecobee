using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API unlink voice engine params.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class UnlinkVoiceEngineParams : FunctionParams
    {
        /// <summary>
        /// The name of the engine to unlink.
        /// </summary>
        [JsonProperty(PropertyName = "engineName", Required = Required.Always)]
        public string EngineName { get; set; }
    }
}
