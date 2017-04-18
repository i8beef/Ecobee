using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Weather
    {
        public Weather()
        {
            Forecasts = new List<WeatherForecast>();
        }

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
