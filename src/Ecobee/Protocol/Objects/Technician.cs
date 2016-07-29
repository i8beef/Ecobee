using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class Technician
    {
        /// <summary>
        /// The internal ecobee unique identifier for this contractor.
        /// </summary>
        [DataMember(Name = "contractorRef")]
        public string ContractorRef { get; set; }

        /// <summary>
        /// The company name of the technician.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The technician's contact phone number.
        /// </summary>
        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The technician's street address.
        /// </summary>
        [DataMember(Name = "streetAddress")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// The technician's city.
        /// </summary>
        [DataMember(Name = "city")]
        public string City { get; set; }

        /// <summary>
        /// The technician's State or Province.
        /// </summary>
        [DataMember(Name = "provinceState")]
        public string ProvinceState { get; set; }

        /// <summary>
        /// The technician's country.
        /// </summary>
        [DataMember(Name = "country")]
        public string Country { get; set; }

        /// <summary>
        /// The technician's ZIP or Postal Code.
        /// </summary>
        [DataMember(Name = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The technician's email address.
        /// </summary>
        [DataMember(Name = "email")]
        public string Email { get; set; }

        /// <summary>
        /// The technician's web site.
        /// </summary>
        [DataMember(Name = "web")]
        public string Web { get; set; }
    }
}
