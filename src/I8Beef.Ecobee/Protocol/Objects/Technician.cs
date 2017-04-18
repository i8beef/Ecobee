using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Technician
    {
        /// <summary>
        /// The internal ecobee unique identifier for this contractor.
        /// </summary>
        [JsonProperty(PropertyName = "contractorRef")]
        public string ContractorRef { get; set; }

        /// <summary>
        /// The company name of the technician.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The technician's contact phone number.
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The technician's street address.
        /// </summary>
        [JsonProperty(PropertyName = "streetAddress")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// The technician's city.
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// The technician's State or Province.
        /// </summary>
        [JsonProperty(PropertyName = "provinceState")]
        public string ProvinceState { get; set; }

        /// <summary>
        /// The technician's country.
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// The technician's ZIP or Postal Code.
        /// </summary>
        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The technician's email address.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// The technician's web site.
        /// </summary>
        [JsonProperty(PropertyName = "web")]
        public string Web { get; set; }
    }
}
