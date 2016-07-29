using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class WeatherForecast
    {
        /// <summary>
        /// The Integer value used to map to a weatherSymbol. See list of mappings above.
        /// </summary>
        [DataMember(Name = "weatherSymbol")]
        public int WeatherSymbol { get; set; }

        /// <summary>
        /// The time stamp of the weather forecast.
        /// </summary>
        [DataMember(Name = "dateTime")]
        public string DateTime { get; set; }

        /// <summary>
        /// A text value representing the current weather condition.
        /// </summary>
        [DataMember(Name = "condition")]
        public string Condition { get; set; }

        /// <summary>
        /// The current temperature.
        /// </summary>
        [DataMember(Name = "temperature")]
        public int Temperature { get; set; }

        /// <summary>
        /// The current barometric pressure.
        /// </summary>
        [DataMember(Name = "pressure")]
        public int Pressure { get; set; }

        /// <summary>
        /// The current humidity.
        /// </summary>
        [DataMember(Name = "relativeHumidity")]
        public int RelativeHumidity { get; set; }

        /// <summary>
        /// The dewpoint.
        /// </summary>
        [DataMember(Name = "dewpoint")]
        public int Dewpoint { get; set; }

        /// <summary>
        /// The visibility in meters; 0 - 70,000.
        /// </summary>
        [DataMember(Name = "visibility")]
        public int Visibility { get; set; }

        /// <summary>
        /// The wind speed as an integer in mph * 1000.
        /// </summary>
        [DataMember(Name = "windSpeed")]
        public int WindSpeed { get; set; }

        /// <summary>
        /// The wind gust speed.
        /// </summary>
        [DataMember(Name = "windGust")]
        public int WindGust { get; set; }

        /// <summary>
        /// The wind direction.
        /// </summary>
        [DataMember(Name = "windDirection")]
        public string WindDirection { get; set; }

        /// <summary>
        /// The wind bearing.
        /// </summary>
        [DataMember(Name = "windBearing")]
        public int WindBearing { get; set; }

        /// <summary>
        /// Probability of precipitation.
        /// </summary>
        [DataMember(Name = "pop")]
        public int Pop { get; set; }

        /// <summary>
        /// The predicted high temperature for the day.
        /// </summary>
        [DataMember(Name = "tempHigh")]
        public int TempHigh { get; set; }

        /// <summary>
        /// The predicted low temperature for the day.
        /// </summary>
        [DataMember(Name = "tempLow")]
        public int TempLow { get; set; }

        /// <summary>
        /// The cloud cover condition.
        /// </summary>
        [DataMember(Name = "sky")]
        public int Sky { get; set; }
    }
}
