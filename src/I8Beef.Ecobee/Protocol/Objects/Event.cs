using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API event.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Event
    {
        /// <summary>
        /// The type of event. Values: hold, demandResponse, sensor, switchOccupancy, vacation, quickSave, today, autoAway, autoHome
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The unique event name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Whether the event is currently active or not.
        /// </summary>
        [JsonProperty(PropertyName = "running")]
        public bool Running { get; set; }

        /// <summary>
        /// The event start date in thermostat local time.
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public string StartDate { get; set; }

        /// <summary>
        /// The event start time in thermostat local time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// The event end date in thermostat local time.
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public string EndDate { get; set; }

        /// <summary>
        /// The event end time in thermostat local time.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// Whether there are persons occupying the property during the event.
        /// </summary>
        [JsonProperty(PropertyName = "isOccupied")]
        public bool IsOccupied { get; set; }

        /// <summary>
        /// Whether cooling will be turned off during the event.
        /// </summary>
        [JsonProperty(PropertyName = "isCoolOff")]
        public bool IsCoolOff { get; set; }

        /// <summary>
        /// Whether heating will be turned off during the event.
        /// </summary>
        [JsonProperty(PropertyName = "isHeatOff")]
        public bool IsHeatOff { get; set; }

        /// <summary>
        /// The cooling absolute temperature to set.
        /// </summary>
        [JsonProperty(PropertyName = "coolHoldTemp")]
        public int CoolHoldTemp { get; set; }

        /// <summary>
        /// The heating absolute temperature to set.
        /// </summary>
        [JsonProperty(PropertyName = "heatHoldTemp")]
        public int HeatHoldTemp { get; set; }

        /// <summary>
        /// The fan mode during the event. Values: auto, on Default: based on current climate and hvac mode.
        /// </summary>
        [JsonProperty(PropertyName = "fan")]
        public string Fan { get; set; }

        /// <summary>
        /// The ventilator mode during the vent. Values: auto, minontime, on, off.
        /// </summary>
        [JsonProperty(PropertyName = "vent")]
        public string Vent { get; set; }

        /// <summary>
        /// The minimum amount of time the ventilator equipment must stay on on each duty cycle.
        /// </summary>
        [JsonProperty(PropertyName = "ventilatorMinOnTime")]
        public int VentilatorMinOnTime { get; set; }

        /// <summary>
        /// Whether this event is mandatory or the end user can cancel it.
        /// </summary>
        [JsonProperty(PropertyName = "isOptional")]
        public bool IsOptional { get; set; }

        /// <summary>
        /// Whether the event is using a relative temperature setting to the currently active program climate.See the Note at the bottom of this page for more information.
        /// </summary>
        [JsonProperty(PropertyName = "isTemperatureRelative")]
        public bool IsTemperatureRelative { get; set; }

        /// <summary>
        /// The relative cool temperature adjustment.
        /// </summary>
        [JsonProperty(PropertyName = "coolRelativeTemp")]
        public int CoolRelativeTemp { get; set; }

        /// <summary>
        /// The relative heat temperature adjustment.
        /// </summary>
        [JsonProperty(PropertyName = "heatRelativeTemp")]
        public int HeatRelativeTemp { get; set; }

        /// <summary>
        /// Whether the event uses absolute temperatures to set the values.Default: true for DRs.See the Note at the bottom of this page for more information.
        /// </summary>
        [JsonProperty(PropertyName = "isTemperatureAbsolute")]
        public bool IsTemperatureAbsolute { get; set; }

        /// <summary>
        /// Indicates the % scheduled runtime during a Demand Response event. Valid range is 0 - 100%. Default = 100, indicates no change to schedule.
        /// </summary>
        [JsonProperty(PropertyName = "dutyCyclePercentage")]
        public int DutyCyclePercentage { get; set; }

        /// <summary>
        /// The minimum number of minutes to run the fan each hour.Range: 0-60, Default: 0
        /// </summary>
        [JsonProperty(PropertyName = "fanMinOnTime")]
        public int FanMinOnTime { get; set; }

        /// <summary>
        /// True if this calendar event was created because of the occupied sensor.
        /// </summary>
        [JsonProperty(PropertyName = "occupiedSensorActive")]
        public bool OccupiedSensorActive { get; set; }

        /// <summary>
        /// True if this calendar event was created because of the unoccupied sensor
        /// </summary>
        [JsonProperty(PropertyName = "unoccupiedSensorActive")]
        public bool UnoccupiedSensorActive { get; set; }

        /// <summary>
        /// Unsupported. Future feature.
        /// </summary>
        [JsonProperty(PropertyName = "drRampUpTemp")]
        public int DrRampUpTemp { get; set; }

        /// <summary>
        /// Unsupported.Future feature.
        /// </summary>
        [JsonProperty(PropertyName = "drRampUpTime")]
        public int DrRampUpTime { get; set; }

        /// <summary>
        /// Unique identifier set by the server to link one or more events and alerts together.
        /// </summary>
        [JsonProperty(PropertyName = "linkRef")]
        public string LinkRef { get; set; }

        /// <summary>
        /// Used for display purposes to indicate what climate (if any) is being used for the hold.
        /// </summary>
        [JsonProperty(PropertyName = "holdClimateRef")]
        public string HoldClimateRef { get; set; }
    }
}