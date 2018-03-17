using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API reset preferences function.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public sealed class ResetPreferencesFunction : Function
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetPreferencesFunction"/> class.
        /// </summary>
        public ResetPreferencesFunction()
        {
            Params = new ResetPreferencesParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type { get { return "resetPreferences"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See
        /// individual function documentation for the properties.
        /// </summary>
        [JsonProperty(PropertyName = "params")]
        public override FunctionParams Params { get; set; }
    }
}
