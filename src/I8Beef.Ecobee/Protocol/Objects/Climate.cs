using Newtonsoft.Json;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Climate
    {
        public Climate()
        {
            Sensors = new List<Sensor>();
        }

        /// <summary>
        /// The unique climate name.The name may be changed without affecting the program integrity so long as uniqueness is maintained.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The unique climate identifier. Changing the identifier is not possible and it is generated on the server for each climate. 
        /// If this value is not supplied a new climate will be created.For the default climates and existing user created climates the 
        /// climateRef should be supplied.
        /// </summary>
        [JsonProperty(PropertyName = "climateRef")]
        public string ClimateRef { get; set; }

        /// <summary>
        /// A flag indicating whether the property is occupied by persons during this climate.
        /// </summary>
        [JsonProperty(PropertyName = "isOccupied")]
        public bool IsOccupied { get; set; }

        /// <summary>
        /// A flag indicating whether ecobee optimized climate settings are used by this climate.
        /// </summary>
        [JsonProperty(PropertyName = "isOptimized")]
        public bool IsOptimizedame { get; set; }

        /// <summary>
        /// The cooling fan mode. Default: on.Values: auto, on.
        /// </summary>
        [JsonProperty(PropertyName = "coolFan")]
        public string CoolFan { get; set; }

        /// <summary>
        /// The heating fan mode. Default: on.Values: auto, on.
        /// </summary>
        [JsonProperty(PropertyName = "heatFan")]
        public string HeatFan { get; set; }

        /// <summary>
        /// The ventilator mode.Default: off.Values: auto, minontime, on, off.
        /// </summary>
        [JsonProperty(PropertyName = "vent")]
        public string Vent { get; set; }

        /// <summary>
        /// The minimum time, in minutes, to run the ventilator each hour.
        /// </summary>
        [JsonProperty(PropertyName = "ventilatorMinOnTime")]
        public int VentilatorMinOnTime { get; set; }

        /// <summary>
        /// The climate owner.Default: system.Values: adHoc, demandResponse, quickSave, sensorAction, switchOccupancy, system, template, user.
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }

        /// <summary>
        /// The type of climate. Default: program.Values: calendarEvent, program.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The integer conversion of the HEX color value used to display this climate on the thermostat and on the web portal.
        /// </summary>
        [JsonProperty(PropertyName = "colour")]
        public string Colour { get; set; }

        /// <summary>
        /// The cool temperature for this climate.
        /// </summary>
        [JsonProperty(PropertyName = "coolTemp")]
        public int CoolTemp { get; set; }

        /// <summary>
        /// The heat temperature for this climate.
        /// </summary>
        [JsonProperty(PropertyName = "heatTemp")]
        public int HeatTemp { get; set; }

        /// <summary>
        /// The list of sensors in use for the specific climate.The sensors listed here are used for temperature 
        /// averaging within that climate.Only the sensorId and name are listed in the climate.
        /// </summary>
        [JsonProperty(PropertyName = "sensors")]
        public IList<Sensor> Sensors { get; set; }
    }
}