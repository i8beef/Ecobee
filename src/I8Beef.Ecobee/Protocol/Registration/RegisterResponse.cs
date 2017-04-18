using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Registration
{
    [JsonObject(MemberSerialization.OptIn)]
    public class RegisterResponse : Response
    {
        /// <summary>
        /// thermostat identifier which was registered with the new account. Only returned 
        /// if the userName/password/acceptTerms were provided in the request.
        /// </summary>
        [JsonProperty(PropertyName = "thermostatIdentifier")]
        public string ThermostatIdentifier { get; set; }
    }
}
