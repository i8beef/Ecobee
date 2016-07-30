using I8Beef.Ecobee.Protocol.Objects;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions
{
    [DataContract]
    [KnownType(typeof(ResetPreferencesParams))]
    public class ResetPreferencesFunction : Function
    {
        public ResetPreferencesFunction()
        {
            Params = new ResetPreferencesParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get { return "resetPreferences"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See 
        /// individual function documentation for the properties.
        /// </summary>
        [DataMember(Name = "params")]
        public override FunctionParams Params { get; set; }
    }

    [DataContract]
    public class ResetPreferencesParams : FunctionParams
    {
    }
}
