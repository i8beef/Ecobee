using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class WeatherForecast
    {
        /// <summary>
        /// The Integer value used to map to a weatherSymbol. See list of mappings above.
        /// </summary>
        [JsonProperty(PropertyName = "weatherSymbol")]
        public int WeatherSymbol { get; set; }

        /// <summary>
        /// The time stamp of the weather forecast.
        /// </summary>
        [JsonProperty(PropertyName = "dateTime")]
        public string DateTime { get; set; }

        /// <summary>
        /// A text value representing the current weather condition.
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }

        /// <summary>
        /// The current temperature.
        /// </summary>
        [JsonProperty(PropertyName = "temperature")]
        public int Temperature { get; set; }

        /// <summary>
        /// The current barometric pressure.
        /// </summary>
        [JsonProperty(PropertyName = "pressure")]
        public int Pressure { get; set; }

        /// <summary>
        /// The current humidity.
        /// </summary>
        [JsonProperty(PropertyName = "relativeHumidity")]
        public int RelativeHumidity { get; set; }

        /// <summary>
        /// The dewpoint.
        /// </summary>
        [JsonProperty(PropertyName = "dewpoint")]
        public int Dewpoint { get; set; }

        /// <summary>
        /// The visibility in meters; 0 - 70,000.
        /// </summary>
        [JsonProperty(PropertyName = "visibility")]
        public int Visibility { get; set; }

        /// <summary>
        /// The wind speed as an integer in mph * 1000.
        /// </summary>
        [JsonProperty(PropertyName = "windSpeed")]
        public int WindSpeed { get; set; }

        /// <summary>
        /// The wind gust speed.
        /// </summary>
        [JsonProperty(PropertyName = "windGust")]
        public int WindGust { get; set; }

        /// <summary>
        /// The wind direction.
        /// </summary>
        [JsonProperty(PropertyName = "windDirection")]
        public string WindDirection { get; set; }

        /// <summary>
        /// The wind bearing.
        /// </summary>
        [JsonProperty(PropertyName = "windBearing")]
        public int WindBearing { get; set; }

        /// <summary>
        /// Probability of precipitation.
        /// </summary>
        [JsonProperty(PropertyName = "pop")]
        public int Pop { get; set; }

        /// <summary>
        /// The predicted high temperature for the day.
        /// </summary>
        [JsonProperty(PropertyName = "tempHigh")]
        public int TempHigh { get; set; }

        /// <summary>
        /// The predicted low temperature for the day.
        /// </summary>
        [JsonProperty(PropertyName = "tempLow")]
        public int TempLow { get; set; }

        /// <summary>
        /// The cloud cover condition.
        /// </summary>
        [JsonProperty(PropertyName = "sky")]
        public int Sky { get; set; }
    }
}
