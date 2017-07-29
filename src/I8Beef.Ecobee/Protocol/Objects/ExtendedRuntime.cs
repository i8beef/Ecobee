using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API extended runtime.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ExtendedRuntime
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedRuntime"/> class.
        /// </summary>
        public ExtendedRuntime()
        {
            ActualTemperature = new List<int>();
            ActualHumidity = new List<int>();
            DesiredHeat = new List<int>();
            DesiredCool = new List<int>();
            DesiredHumidity = new List<int>();
            DesiredDehumidity = new List<int>();
            DmOffset = new List<int>();
            HvacMode = new List<string>();
            HeatPump1 = new List<int>();
            HeatPump2 = new List<int>();
            AuxHeat1 = new List<int>();
            AuxHeat2 = new List<int>();
            AuxHeat3 = new List<int>();
            Cool1 = new List<int>();
            Cool2 = new List<int>();
            Fan = new List<int>();
            Humidifier = new List<int>();
            Dehumidifier = new List<int>();
            Economizer = new List<int>();
            Ventilator = new List<int>();
        }

        /// <summary>
        /// The UTC timestamp of the last value read. This timestamp is updated at a 15 min interval
        /// by the thermostat. For the 1st value, it is timestamp - 10 mins, for the 2nd value it
        /// is timestamp - 5 mins. Consider day boundaries being straddled when using these values.
        /// </summary>
        [JsonProperty(PropertyName = "lastReadingTimestamp")]
        public string LastReadingTimestamp { get; set; }

        /// <summary>
        /// The UTC date of the last runtime reading. Format: YYYY-MM-DD
        /// </summary>
        [JsonProperty(PropertyName = "runtimeDate")]
        public string RuntimeDate { get; set; }

        /// <summary>
        /// The last 5 minute interval which was updated by the thermostat telemetry update. Subtract 2
        /// from this interval to obtain the beginning interval for the last 3 readings. Multiply by 5
        /// mins to obtain the minutes of the day. Range: 0-287
        /// </summary>
        [JsonProperty(PropertyName = "runtimeInterval")]
        public int RuntimeInterval { get; set; }

        /// <summary>
        /// The last three 5 minute actual temperature readings
        /// </summary>
        [JsonProperty(PropertyName = "actualTemperature")]
        public IList<int> ActualTemperature { get; set; }

        /// <summary>
        /// The last three 5 minute actual humidity readings.
        /// </summary>
        [JsonProperty(PropertyName = "actualHumidity")]
        public IList<int> ActualHumidity { get; set; }

        /// <summary>
        /// The last three 5 minute desired heat temperature readings.
        /// </summary>
        [JsonProperty(PropertyName = "desiredHeat")]
        public IList<int> DesiredHeat { get; set; }

        /// <summary>
        /// The last three 5 minute desired cool temperature readings.
        /// </summary>
        [JsonProperty(PropertyName = "desiredCool")]
        public IList<int> DesiredCool { get; set; }

        /// <summary>
        /// The last three 5 minute desired humidity readings.
        /// </summary>
        [JsonProperty(PropertyName = "desiredHumidity")]
        public IList<int> DesiredHumidity { get; set; }

        /// <summary>
        /// The last three 5 minute desired de-humidification readings.
        /// </summary>
        [JsonProperty(PropertyName = "desiredDehumidity")]
        public IList<int> DesiredDehumidity { get; set; }

        /// <summary>
        /// The last three 5 minute desired Demand Management temeprature offsets. This value is Demand
        /// Management adjustment value which was applied by the thermostat. If the thermostat decided
        /// not to honour the adjustment, it will send 0 for the interval. Compare these values with the
        /// values sent in the DM message to determine whether the thermostat applied the adjustment.
        /// </summary>
        [JsonProperty(PropertyName = "dmOffset")]
        public IList<int> DmOffset { get; set; }

        /// <summary>
        /// The last three 5 minute HVAC Mode reading. These values indicate which stage was energized
        /// in the 5 minute interval. Values: heatStage10n, heatStage20n, heatStage30n, heatOff,
        /// compressorCoolStage10n, compressorCoolStage20n, compressorCoolOff, compressorHeatStage10n,
        /// compressorHeatStage20n, compressorHeatOff, economyCycle.
        /// </summary>
        [JsonProperty(PropertyName = "hvacMode")]
        public IList<string> HvacMode { get; set; }

        /// <summary>
        /// The last three 5 minute HVAC Runtime values in seconds (0-300 seconds) per interval. This
        /// value corresponds to the heat pump stage 1 runtime.
        /// </summary>
        [JsonProperty(PropertyName = "heatPump1")]
        public IList<int> HeatPump1 { get; set; }

        /// <summary>
        /// The last three 5 minute HVAC Runtime values in seconds (0-300 seconds) per interval. This
        /// value corresponds to the heat pump stage 2 runtime.
        /// </summary>
        [JsonProperty(PropertyName = "heatPump2")]
        public IList<int> HeatPump2 { get; set; }

        /// <summary>
        /// The last three 5 minute HVAC Runtime values in seconds (0-300 seconds) per interval. This
        /// value corresponds to the auxiliary heat stage 1. If the thermostat does not have a heat
        /// pump, this is heat stage 1.
        /// </summary>
        [JsonProperty(PropertyName = "auxHeat1")]
        public IList<int> AuxHeat1 { get; set; }

        /// <summary>
        /// The last three 5 minute HVAC Runtime values in seconds (0-300 seconds) per interval. This
        /// value corresponds to the auxiliary heat stage 2. If the thermostat does not have a heat
        /// pump, this is heat stage 2.
        /// </summary>
        [JsonProperty(PropertyName = "auxHeat2")]
        public IList<int> AuxHeat2 { get; set; }

        /// <summary>
        /// The last three 5 minute HVAC Runtime values in seconds (0-300 seconds) per interval. This
        /// value corresponds to the heat stage 3 if the thermostat does not have a heat pump. Auxiliary
        /// stage 3 is not supported.
        /// </summary>
        [JsonProperty(PropertyName = "auxHeat3")]
        public IList<int> AuxHeat3 { get; set; }

        /// <summary>
        /// The last three 5 minute HVAC Runtime values in seconds (0-300 seconds) per interval. This
        /// value corresponds to the cooling stage 1.
        /// </summary>
        [JsonProperty(PropertyName = "cool1")]
        public IList<int> Cool1 { get; set; }

        /// <summary>
        /// The last three 5 minute HVAC Runtime values in seconds (0-300 seconds) per interval. This
        /// value corresponds to the cooling stage 2.
        /// </summary>
        [JsonProperty(PropertyName = "cool2")]
        public IList<int> Cool2 { get; set; }

        /// <summary>
        /// The last three 5 minute fan Runtime values in seconds (0-300 seconds) per interval.
        /// </summary>
        [JsonProperty(PropertyName = "fan")]
        public IList<int> Fan { get; set; }

        /// <summary>
        /// The last three 5 minute humidifier Runtime values in seconds (0-300 seconds) per interval.
        /// </summary>
        [JsonProperty(PropertyName = "humidifier")]
        public IList<int> Humidifier { get; set; }

        /// <summary>
        /// The last three 5 minute de-humidifier Runtime values in seconds (0-300 seconds) per interval.
        /// </summary>
        [JsonProperty(PropertyName = "dehumidifier")]
        public IList<int> Dehumidifier { get; set; }

        /// <summary>
        /// The last three 5 minute economizer Runtime values in seconds (0-300 seconds) per interval.
        /// </summary>
        [JsonProperty(PropertyName = "economizer")]
        public IList<int> Economizer { get; set; }

        /// <summary>
        /// The last three 5 minute ventilator Runtime values in seconds (0-300 seconds) per interval.
        /// </summary>
        [JsonProperty(PropertyName = "ventilator")]
        public IList<int> Ventilator { get; set; }

        /// <summary>
        /// The latest value of the current electricity bill as interpolated from the thermostat's
        /// readings from a paired electricity meter.
        /// </summary>
        [JsonProperty(PropertyName = "currentElectricityBill")]
        public int CurrentElectricityBill { get; set; }

        /// <summary>
        /// The latest estimate of the projected electricity bill as interpolated from the thermostat's
        /// readings from a paired electricity meter.
        /// </summary>
        [JsonProperty(PropertyName = "projectedElectricityBill")]
        public int ProjectedElectricityBill { get; set; }
    }
}
