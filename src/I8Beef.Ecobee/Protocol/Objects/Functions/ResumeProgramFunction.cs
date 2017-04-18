using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ResumeProgramFunction : Function
    {
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

    [JsonObject(MemberSerialization.OptIn)]
    public class ResumeProgramParams : FunctionParams
    {
        /// <summary>
        /// Should the thermostat be resumed to next event (false) or to it's program (true).
        /// </summary>
        [JsonProperty(PropertyName = "resumeAll")]
        public bool ResumeAll { get; set; }
    }
}
