using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API runtime.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Runtime
    {
        /// <summary>
        /// The current runtime revision. Equivalent in meaning to the runtime revision number
        /// in the thermostat summary call.
        /// </summary>
        [JsonProperty(PropertyName = "runtimeRev")]
        public string RuntimeRev { get; set; }

        /// <summary>
        /// Whether the thermostat is currently connected to the server.
        /// </summary>
        [JsonProperty(PropertyName = "connected")]
        public bool? Connected { get; set; }

        /// <summary>
        /// The UTC date/time stamp of when the thermostat first connected to the ecobee server.
        /// </summary>
        [JsonProperty(PropertyName = "firstConnected")]
        public string FirstConnected { get; set; }

        /// <summary>
        /// The last recorded connection date and time.
        /// </summary>
        [JsonProperty(PropertyName = "connectDateTime")]
        public string ConnectDateTime { get; set; }

        /// <summary>
        /// The last recorded disconnection date and time.
        /// </summary>
        [JsonProperty(PropertyName = "disconnectDateTime")]
        public string DisconnectDateTime { get; set; }

        /// <summary>
        /// The UTC date/time stamp of when the thermostat was updated. Format: YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonProperty(PropertyName = "lastModified")]
        public string LastModified { get; set; }

        /// <summary>
        /// The UTC date/time stamp of when the thermostat last posted its runtime information.
        /// Format: YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonProperty(PropertyName = "lastStatusModified")]
        public string LastStatusModified { get; set; }

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
        public int? RuntimeInterval { get; set; }

        /// <summary>
        /// The current temperature displayed on the thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "actualTemperature")]
        public int? ActualTemperature { get; set; }

        /// <summary>
        /// The current humidity % shown on the thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "actualHumidity")]
        public int? ActualHumidity { get; set; }

        /// <summary>
        /// The desired heat temperature as per the current running program or active event.
        /// </summary>
        [JsonProperty(PropertyName = "desiredHeat")]
        public int? DesiredHeat { get; set; }

        /// <summary>
        /// The desired cool temperature as per the current running program or active event.
        /// </summary>
        [JsonProperty(PropertyName = "desiredCool")]
        public int? DesiredCool { get; set; }

        /// <summary>
        /// The desired humidity set point.
        /// </summary>
        [JsonProperty(PropertyName = "desiredHumidity")]
        public int? DesiredHumidity { get; set; }

        /// <summary>
        /// The desired dehumidification set point.
        /// </summary>
        [JsonProperty(PropertyName = "desiredDehumidity")]
        public int? DesiredDehumidity { get; set; }

        /// <summary>
        /// The desired fan mode. Values: auto, on or null if the HVAC system is off and the thermostat
        /// is not controlling a fan independently.
        /// </summary>
        [JsonProperty(PropertyName = "desiredFanMode")]
        public string DesiredFanMode { get; set; }

        /// <summary>
        /// This field provides the possible valid range for which a desiredHeat setpoint? can be set to.
        /// This value takes into account the thermostat heat temperature limits as well the running
        /// program or active events. Values are returned as an Integer array representing the canonical
        /// minimum and maximim, e.g. [450,790].
        /// </summary>
        [JsonProperty(PropertyName = "desiredHeatRange")]
        public IList<int> DesiredHeatRange { get; set; }

        /// <summary>
        /// This field provides the possible valid range for which a desiredCool setpoint? can be set to.
        /// This value takes into account the thermostat cool temperature limits as well the running program
        /// or active events. Values are returned as an Integer array representing the canonical minimum and
        /// maximim, e.g. [650,920].
        /// </summary>
        [JsonProperty(PropertyName = "desiredCoolRange")]
        public IList<int> DesiredCoolRange { get; set; }
    }
}
