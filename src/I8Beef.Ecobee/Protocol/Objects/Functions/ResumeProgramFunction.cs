using I8Beef.Ecobee.Protocol.Objects;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions
{
    [DataContract]
    [KnownType(typeof(ResumeProgramParams))]
    public class ResumeProgramFunction : Function
    {
        public ResumeProgramFunction()
        {
            Params = new ResumeProgramParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get { return "resumeProgram"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See 
        /// individual function documentation for the properties.
        /// </summary>
        [DataMember(Name = "params")]
        public override FunctionParams Params { get; set; }
    }

    [DataContract]
    public class ResumeProgramParams : FunctionParams
    {
        /// <summary>
        /// Should the thermostat be resumed to next event (false) or to it's program (true).
        /// </summary>
        [DataMember(Name = "resumeAll")]
        public bool ResumeAll { get; set; }
    }
}
