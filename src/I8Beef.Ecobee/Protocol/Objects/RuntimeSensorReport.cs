using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class RuntimeSensorReport
    {
        public RuntimeSensorReport()
        {
            Sensors = new List<RuntimeSensorMetadata>();
            Columns = new List<string>();
            Data = new List<string>();
        }

        /// <summary>
        /// The thermostat identifier for the report.
        /// </summary>
        [DataMember(Name = "thermostatIdentifier")]
        public string ThermostatIdentifier { get; set; }

        /// <summary>
        /// The list of sensor metadata configured in the thermostat.
        /// </summary>
        [DataMember(Name = "sensors")]
        public IList<RuntimeSensorMetadata> Sensors { get; set; }

        /// <summary>
        /// The list of column names returned in the data property. The sensor data column names 
        /// match the sensorId within the sensor metadata. The first two columns are the date and 
        /// time, the following are the defined sensorIds.
        /// </summary>
        [DataMember(Name = "columns")]
        public IList<string> Columns { get; set; }

        /// <summary>
        /// The list of CSV rows containing the column data as defined in the columns property.
        /// </summary>
        [DataMember(Name = "data")]
        public IList<string> Data { get; set; }
    }
}
