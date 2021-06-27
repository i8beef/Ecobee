using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API Weather.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Weather
    {
        /// <summary>
        /// The time stamp in UTC of the weather forecast.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// The weather station identifier.
        /// </summary>
        [JsonProperty(PropertyName = "weatherStation")]
        public string WeatherStation { get; set; }

        /// <summary>
        /// The list of latest weather station forecasts.
        /// </summary>
        [JsonProperty(PropertyName = "forecasts")]
        public IList<WeatherForecast> Forecasts { get; set; }
    }
}
