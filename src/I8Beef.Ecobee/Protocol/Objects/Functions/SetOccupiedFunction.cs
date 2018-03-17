using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API set occupied function.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public sealed class SetOccupiedFunction : Function
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetOccupiedFunction"/> class.
        /// </summary>
        public SetOccupiedFunction()
        {
            Params = new SetOccupiedParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type { get { return "setOccupied"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See
        /// individual function documentation for the properties.
        /// </summary>
        [JsonProperty(PropertyName = "params", Required = Required.Always)]
        public override FunctionParams Params { get; set; }
    }
}
