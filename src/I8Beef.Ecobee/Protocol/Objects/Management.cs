using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Management
    {
        /// <summary>
        /// The administrative contact name.
        /// </summary>
        [JsonProperty(PropertyName = "administrativeContact")]
        public string AdministrativeContact { get; set; }

        /// <summary>
        /// The billing contact name.
        /// </summary>
        [JsonProperty(PropertyName = "billingContact")]
        public string BillingContact { get; set; }

        /// <summary>
        /// The company name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The contact email address.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// The company web site.
        /// </summary>
        [JsonProperty(PropertyName = "web")]
        public string Web { get; set; }

        /// <summary>
        /// Whether to show management alerts on the thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "showAlertIdt")]
        public bool ShowAlertIdt { get; set; }

        /// <summary>
        /// Whether to show management alerts in the web portal.
        /// </summary>
        [JsonProperty(PropertyName = "showAlertWeb")]
        public bool ShowAlertWeb { get; set; }
    }
}
