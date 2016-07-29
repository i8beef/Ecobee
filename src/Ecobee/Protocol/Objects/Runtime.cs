using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class Runtime
    {
        public Runtime()
        {
            DesiredHeatRange = new List<int>();
            DesiredCoolRange = new List<int>();
        }

        /// <summary>
        /// The current runtime revision. Equivalent in meaning to the runtime revision number 
        /// in the thermostat summary call.
        /// </summary>
        [DataMember(Name = "runtimeRev")]
        public string RuntimeRev { get; set; }

        /// <summary>
        /// Whether the thermostat is currently connected to the server.
        /// </summary>
        [DataMember(Name = "connected")]
        public bool Connected { get; set; }

        /// <summary>
        /// The UTC date/time stamp of when the thermostat first connected to the ecobee server.
        /// </summary>
        [DataMember(Name = "firstConnected")]
        public string FirstConnected { get; set; }

        /// <summary>
        /// The last recorded connection date and time.
        /// </summary>
        [DataMember(Name = "connectDateTime")]
        public string ConnectDateTime { get; set; }

        /// <summary>
        /// The last recorded disconnection date and time.
        /// </summary>
        [DataMember(Name = "disconnectDateTime")]
        public string DisconnectDateTime { get; set; }

        /// <summary>
        /// The UTC date/time stamp of when the thermostat was updated. Format: YYYY-MM-DD HH:MM:SS
        /// </summary>
        [DataMember(Name = "lastModified")]
        public string LastModified { get; set; }

        /// <summary>
        /// The UTC date/time stamp of when the thermostat last posted its runtime information. 
        /// Format: YYYY-MM-DD HH:MM:SS
        /// </summary>
        [DataMember(Name = "lastStatusModified")]
        public string LastStatusModified { get; set; }

        /// <summary>
        /// The UTC date of the last runtime reading. Format: YYYY-MM-DD
        /// </summary>
        [DataMember(Name = "runtimeDate")]
        public string RuntimeDate { get; set; }

        /// <summary>
        /// The last 5 minute interval which was updated by the thermostat telemetry update. Subtract 2 
        /// from this interval to obtain the beginning interval for the last 3 readings. Multiply by 5 
        /// mins to obtain the minutes of the day. Range: 0-287
        /// </summary>
        [DataMember(Name = "runtimeInterval")]
        public int RuntimeInterval { get; set; }

        /// <summary>
        /// The current temperature displayed on the thermostat.
        /// </summary>
        [DataMember(Name = "actualTemperature")]
        public int ActualTemperature { get; set; }

        /// <summary>
        /// The current humidity % shown on the thermostat.
        /// </summary>
        [DataMember(Name = "actualHumidity")]
        public int ActualHumidity { get; set; }

        /// <summary>
        /// The desired heat temperature as per the current running program or active event.
        /// </summary>
        [DataMember(Name = "desiredHeat")]
        public int DesiredHeat { get; set; }

        /// <summary>
        /// The desired cool temperature as per the current running program or active event.
        /// </summary>
        [DataMember(Name = "desiredCool")]
        public int DesiredCool { get; set; }

        /// <summary>
        /// The desired humidity set point.
        /// </summary>
        [DataMember(Name = "desiredHumidity")]
        public int DesiredHumidity { get; set; }

        /// <summary>
        /// The desired dehumidification set point.
        /// </summary>
        [DataMember(Name = "desiredDehumidity")]
        public int DesiredDehumidity { get; set; }

        /// <summary>
        /// The desired fan mode. Values: auto, on or null if the HVAC system is off and the thermostat 
        /// is not controlling a fan independently.
        /// </summary>
        [DataMember(Name = "desiredFanMode")]
        public string DesiredFanMode { get; set; }

        /// <summary>
        /// This field provides the possible valid range for which a desiredHeat setpoint can be set to. 
        /// This value takes into account the thermostat heat temperature limits as well the running
        /// program or active events. Values are returned as an Integer array representing the canonical
        /// minimum and maximim, e.g. [450,790].
        /// </summary>
        [DataMember(Name = "desiredHeatRange")]
        public IList<int> DesiredHeatRange { get; set; }

        /// <summary>
        /// This field provides the possible valid range for which a desiredCool setpoint can be set to. 
        /// This value takes into account the thermostat cool temperature limits as well the running program
        /// or active events. Values are returned as an Integer array representing the canonical minimum and
        /// maximim, e.g. [650,920].
        /// </summary>
        [DataMember(Name = "desiredCoolRange")]
        public IList<int> DesiredCoolRange { get; set; }
    }
}
