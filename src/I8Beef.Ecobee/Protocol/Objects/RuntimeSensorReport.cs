using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API runtime sensor report.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class RuntimeSensorReport
    {
        /// <summary>
        /// The thermostat identifier for the report.
        /// </summary>
        [JsonProperty(PropertyName = "thermostatIdentifier")]
        public string ThermostatIdentifier { get; set; }

        /// <summary>
        /// The list of sensor metadata configured in the thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "sensors")]
        public IList<RuntimeSensorMetadata> Sensors { get; set; }

        /// <summary>
        /// The list of column names returned in the data property. The sensor data column names
        /// match the sensorId within the sensor metadata. The first two columns are the date and
        /// time, the following are the defined sensorIds.
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public IList<string> Columns { get; set; }

        /// <summary>
        /// The list of CSV rows containing the column data as defined in the columns property.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<string> Data { get; set; }
    }
}
