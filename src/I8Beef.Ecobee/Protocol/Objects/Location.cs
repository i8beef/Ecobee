using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Location
    {
        /// <summary>
        /// The timezone offset in minutes from UTC.
        /// </summary>
        [JsonProperty(PropertyName = "timeZoneOffsetMinutes")]
        public int TimeZoneOffsetMinutes { get; set; }

        /// <summary>
        /// The Olson timezone the thermostat resides in (e.g America/Toronto).
        /// </summary>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Whether the thermostat should factor in daylight savings when displaying the date and time.
        /// </summary>
        [JsonProperty(PropertyName = "isDaylightSaving")]
        public bool IsDaylightSaving { get; set; }

        /// <summary>
        /// The thermostat location street address.
        /// </summary>
        [JsonProperty(PropertyName = "streetAddress")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// The thermostat location city.
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// The thermostat location State or Province.
        /// </summary>
        [JsonProperty(PropertyName = "provinceState")]
        public string ProvinceState { get; set; }

        /// <summary>
        /// The thermostat location country.
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// The thermostat location ZIP or Postal code.
        /// </summary>
        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The thermostat owner's phone number
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The lat/long geographic coordinates of the thermostat location.
        /// </summary>
        [JsonProperty(PropertyName = "mapCoordinates")]
        public string MapCoordinates { get; set; }
    }
}
