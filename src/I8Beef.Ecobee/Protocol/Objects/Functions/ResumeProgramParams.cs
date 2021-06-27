using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API resume program params.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ResumeProgramParams : FunctionParams
    {
        /// <summary>
        /// Should the thermostat be resumed to next event (false) or to it's program (true).
        /// </summary>
        [JsonProperty(PropertyName = "resumeAll")]
        public bool? ResumeAll { get; set; }
    }
}
