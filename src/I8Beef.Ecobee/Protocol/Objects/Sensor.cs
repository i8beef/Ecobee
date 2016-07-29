using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class Sensor
    {
        public Sensor()
        {
            States = new List<State>();
        }

        /// <summary>
        /// The sensor name.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The sensor manufacturer.
        /// </summary>
        [DataMember(Name = "manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// The sensor model.
        /// </summary>
        [DataMember(Name = "model")]
        public string Model { get; set; }

        /// <summary>
        /// The thermostat zone the sensor is associated with.
        /// </summary>
        [DataMember(Name = "zone")]
        public int Zone { get; set; }

        /// <summary>
        /// The unique sensor identifier.
        /// </summary>
        [DataMember(Name = "sensorId")]
        public int SensorId { get; set; }

        /// <summary>
        /// The type of sensor.Values: adc, co2, dryCOntact, humidity, temperature, unknown.
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The sensor usage type. Values: dischargeAir, indoor, monitor, outdoor.
        /// </summary>
        [DataMember(Name = "usage")]
        public string Usage { get; set; }

        /// <summary>
        /// The number of bits the adc has been configured to use.
        /// </summary>
        [DataMember(Name = "numberOfBits")]
        public int NumberOfBits { get; set; }

        /// <summary>
        /// Value of the bconstant value used in temperature sensors.
        /// </summary>
        [DataMember(Name = "bconstant")]
        public int BConstant { get; set; }

        /// <summary>
        /// The sensor thermistor value, ie. 10K thermistor = 10000, 2.5K thermistor = 2500.
        /// </summary>
        [DataMember(Name = "thermistorSize")]
        public int ThermistorSize { get; set; }

        /// <summary>
        /// The user adjustable temperature compensation applied to the temperature reading.
        /// </summary>
        [DataMember(Name = "tempCorrection")]
        public int TempCorrection { get; set; }

        /// <summary>
        /// The sensor thermistor gain value.
        /// </summary>
        [DataMember(Name = "gain")]
        public int Gain { get; set; }

        /// <summary>
        /// The sensor thermistor max voltage in Volts, 5=5V, 10=10V.
        /// </summary>
        [DataMember(Name = "maxVoltage")]
        public int MaxVoltage { get; set; }

        /// <summary>
        /// The multiplier value used in sensors (1000x value).
        /// </summary>
        [DataMember(Name = "multiplier")]
        public int Multiplier { get; set; }

        /// <summary>
        /// A list of SensorState objects.
        /// </summary>
        [DataMember(Name = "states")]
        public IList<State> States { get; set; }
    }
}