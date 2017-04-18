using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Sensor
    {
        public Sensor()
        {
            States = new List<State>();
        }

        /// <summary>
        /// The sensor name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The sensor manufacturer.
        /// </summary>
        [JsonProperty(PropertyName = "manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// The sensor model.
        /// </summary>
        [JsonProperty(PropertyName = "model")]
        public string Model { get; set; }

        /// <summary>
        /// The thermostat zone the sensor is associated with.
        /// </summary>
        [JsonProperty(PropertyName = "zone")]
        public int Zone { get; set; }

        /// <summary>
        /// The unique sensor identifier.
        /// </summary>
        [JsonProperty(PropertyName = "sensorId")]
        public int SensorId { get; set; }

        /// <summary>
        /// The type of sensor.Values: adc, co2, dryCOntact, humidity, temperature, unknown.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The sensor usage type. Values: dischargeAir, indoor, monitor, outdoor.
        /// </summary>
        [JsonProperty(PropertyName = "usage")]
        public string Usage { get; set; }

        /// <summary>
        /// The number of bits the adc has been configured to use.
        /// </summary>
        [JsonProperty(PropertyName = "numberOfBits")]
        public int NumberOfBits { get; set; }

        /// <summary>
        /// Value of the bconstant value used in temperature sensors.
        /// </summary>
        [JsonProperty(PropertyName = "bconstant")]
        public int BConstant { get; set; }

        /// <summary>
        /// The sensor thermistor value, ie. 10K thermistor = 10000, 2.5K thermistor = 2500.
        /// </summary>
        [JsonProperty(PropertyName = "thermistorSize")]
        public int ThermistorSize { get; set; }

        /// <summary>
        /// The user adjustable temperature compensation applied to the temperature reading.
        /// </summary>
        [JsonProperty(PropertyName = "tempCorrection")]
        public int TempCorrection { get; set; }

        /// <summary>
        /// The sensor thermistor gain value.
        /// </summary>
        [JsonProperty(PropertyName = "gain")]
        public int Gain { get; set; }

        /// <summary>
        /// The sensor thermistor max voltage in Volts, 5=5V, 10=10V.
        /// </summary>
        [JsonProperty(PropertyName = "maxVoltage")]
        public int MaxVoltage { get; set; }

        /// <summary>
        /// The multiplier value used in sensors (1000x value).
        /// </summary>
        [JsonProperty(PropertyName = "multiplier")]
        public int Multiplier { get; set; }

        /// <summary>
        /// A list of SensorState objects.
        /// </summary>
        [JsonProperty(PropertyName = "states")]
        public IList<State> States { get; set; }
    }
}