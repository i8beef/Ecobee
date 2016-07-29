using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class Management
    {
        /// <summary>
        /// The administrative contact name.
        /// </summary>
        [DataMember(Name = "administrativeContact")]
        public string AdministrativeContact { get; set; }

        /// <summary>
        /// The billing contact name.
        /// </summary>
        [DataMember(Name = "billingContact")]
        public string BillingContact { get; set; }

        /// <summary>
        /// The company name.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The contact email address.
        /// </summary>
        [DataMember(Name = "email")]
        public string Email { get; set; }

        /// <summary>
        /// The company web site.
        /// </summary>
        [DataMember(Name = "web")]
        public string Web { get; set; }

        /// <summary>
        /// Whether to show management alerts on the thermostat.
        /// </summary>
        [DataMember(Name = "showAlertIdt")]
        public bool ShowAlertIdt { get; set; }

        /// <summary>
        /// Whether to show management alerts in the web portal.
        /// </summary>
        [DataMember(Name = "showAlertWeb")]
        public bool ShowAlertWeb { get; set; }
    }
}
