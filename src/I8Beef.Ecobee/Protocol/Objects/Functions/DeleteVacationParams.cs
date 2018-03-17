using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API delete vacation params.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DeleteVacationParams : FunctionParams
    {
        /// <summary>
        /// The vacation event name. It must be unique.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }
    }
}
