using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class Location
    {
        /// <summary>
        /// The timezone offset in minutes from UTC.
        /// </summary>
        [DataMember(Name = "timeZoneOffsetMinutes")]
        public int TimeZoneOffsetMinutes { get; set; }

        /// <summary>
        /// The Olson timezone the thermostat resides in (e.g America/Toronto).
        /// </summary>
        [DataMember(Name = "timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Whether the thermostat should factor in daylight savings when displaying the date and time.
        /// </summary>
        [DataMember(Name = "isDaylightSaving")]
        public bool IsDaylightSaving { get; set; }

        /// <summary>
        /// The thermostat location street address.
        /// </summary>
        [DataMember(Name = "streetAddress")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// The thermostat location city.
        /// </summary>
        [DataMember(Name = "city")]
        public string City { get; set; }

        /// <summary>
        /// The thermostat location State or Province.
        /// </summary>
        [DataMember(Name = "provinceState")]
        public string ProvinceState { get; set; }

        /// <summary>
        /// The thermostat location country.
        /// </summary>
        [DataMember(Name = "country")]
        public string Country { get; set; }

        /// <summary>
        /// The thermostat location ZIP or Postal code.
        /// </summary>
        [DataMember(Name = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The thermostat owner's phone number
        /// </summary>
        [DataMember(Name = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The lat/long geographic coordinates of the thermostat location.
        /// </summary>
        [DataMember(Name = "mapCoordinates")]
        public string MapCoordinates { get; set; }
    }
}
