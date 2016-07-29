using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class Weather
    {
        public Weather()
        {
            Forecasts = new List<WeatherForecast>();
        }

        /// <summary>
        /// The time stamp in UTC of the weather forecast.
        /// </summary>
        [DataMember(Name = "timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// The weather station identifier.
        /// </summary>
        [DataMember(Name = "weatherStation")]
        public string WeatherStation { get; set; }

        /// <summary>
        /// The list of latest weather station forecasts.
        /// </summary>
        [DataMember(Name = "forecasts")]
        public IList<WeatherForecast> Forecasts { get; set; }
    }
}
