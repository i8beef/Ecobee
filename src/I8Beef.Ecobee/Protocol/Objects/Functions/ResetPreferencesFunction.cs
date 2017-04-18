using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ResetPreferencesFunction : Function
    {
        public ResetPreferencesFunction()
        {
            Params = new ResetPreferencesParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public override string Type { get { return "resetPreferences"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See 
        /// individual function documentation for the properties.
        /// </summary>
        [JsonProperty(PropertyName = "params")]
        public override FunctionParams Params { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class ResetPreferencesParams : FunctionParams
    {
    }
}
