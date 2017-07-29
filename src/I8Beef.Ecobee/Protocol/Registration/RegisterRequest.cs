using System;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Registration
{
    /// <summary>
    /// Ecobee API Register request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class RegisterRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/registerAccount"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.POST; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(RegisterResponse); } }

        /// <summary>
        /// The registration code obtained from the thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// The new account login and email address. Must be a valid email address.
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// The password for the account. The password must be at least 8 characters.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// When 'true', confirmation that the user accepted the ecobee terms of use
        /// and privacy policy. If 'false' or not provided, the request will fail.
        /// </summary>
        [JsonProperty(PropertyName = "acceptTerms")]
        public bool AcceptTerms { get; set; }

        /// <summary>
        /// The User's first name. Cannot be longer than 40 characters
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The User's last name (surname). Cannot be longer than 40 characters
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }
    }
}
