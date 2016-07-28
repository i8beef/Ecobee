using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class Climate
    {
        public Climate()
        {
            Sensors = new List<Sensor>();
        }

        /// <summary>
        /// The unique climate name.The name may be changed without affecting the program integrity so long as uniqueness is maintained.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The unique climate identifier. Changing the identifier is not possible and it is generated on the server for each climate. 
        /// If this value is not supplied a new climate will be created.For the default climates and existing user created climates the 
        /// climateRef should be supplied.
        /// </summary>
        [DataMember(Name = "climateRef")]
        public string ClimateRef { get; set; }

        /// <summary>
        /// A flag indicating whether the property is occupied by persons during this climate.
        /// </summary>
        [DataMember(Name = "isOccupied")]
        public bool IsOccupied { get; set; }

        /// <summary>
        /// A flag indicating whether ecobee optimized climate settings are used by this climate.
        /// </summary>
        [DataMember(Name = "isOptimized")]
        public bool IsOptimizedame { get; set; }

        /// <summary>
        /// The cooling fan mode. Default: on.Values: auto, on.
        /// </summary>
        [DataMember(Name = "coolFan")]
        public string CoolFan { get; set; }

        /// <summary>
        /// The heating fan mode. Default: on.Values: auto, on.
        /// </summary>
        [DataMember(Name = "heatFan")]
        public string HeatFan { get; set; }

        /// <summary>
        /// The ventilator mode.Default: off.Values: auto, minontime, on, off.
        /// </summary>
        [DataMember(Name = "vent")]
        public string Vent { get; set; }

        /// <summary>
        /// The minimum time, in minutes, to run the ventilator each hour.
        /// </summary>
        [DataMember(Name = "ventilatorMinOnTime")]
        public int VentilatorMinOnTime { get; set; }

        /// <summary>
        /// The climate owner.Default: system.Values: adHoc, demandResponse, quickSave, sensorAction, switchOccupancy, system, template, user.
        /// </summary>
        [DataMember(Name = "owner")]
        public string Owner { get; set; }

        /// <summary>
        /// The type of climate. Default: program.Values: calendarEvent, program.
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The integer conversion of the HEX color value used to display this climate on the thermostat and on the web portal.
        /// </summary>
        [DataMember(Name = "colour")]
        public string Colour { get; set; }

        /// <summary>
        /// The cool temperature for this climate.
        /// </summary>
        [DataMember(Name = "coolTemp")]
        public int CoolTemp { get; set; }

        /// <summary>
        /// The heat temperature for this climate.
        /// </summary>
        [DataMember(Name = "heatTemp")]
        public int HeatTemp { get; set; }

        /// <summary>
        /// The list of sensors in use for the specific climate.The sensors listed here are used for temperature 
        /// averaging within that climate.Only the sensorId and name are listed in the climate.
        /// </summary>
        [DataMember(Name = "sensors")]
        public IList<Sensor> Sensors { get; set; }
    }
}