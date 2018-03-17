using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API delete vacation function.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public sealed class DeleteVacationFunction : Function
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVacationFunction"/> class.
        /// </summary>
        public DeleteVacationFunction()
        {
            Params = new DeleteVacationParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type { get { return "deleteVacation"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See
        /// individual function documentation for the properties.
        /// </summary>
        [JsonProperty(PropertyName = "params", Required = Required.Always)]
        public override FunctionParams Params { get; set; }
    }
}
