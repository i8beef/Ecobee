using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API resume program function.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public sealed class ResumeProgramFunction : Function
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeProgramFunction"/> class.
        /// </summary>
        public ResumeProgramFunction()
        {
            Params = new ResumeProgramParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public override string Type { get { return "resumeProgram"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See
        /// individual function documentation for the properties.
        /// </summary>
        [JsonProperty(PropertyName = "params")]
        public override FunctionParams Params { get; set; }
    }
}
