using System.Runtime.Serialization;

namespace Ecobee.Protocol.Registration
{
    [DataContract]
    public class RegisterResponse : Response
    {
        /// <summary>
        /// thermostat identifier which was registered with the new account. Only returned 
        /// if the userName/password/acceptTerms were provided in the request.
        /// </summary>
        [DataMember(Name = "thermostatIdentifier")]
        public string ThermostatIdentifier { get; set; }
    }
}
