using System;

namespace I8Beef.Ecobee.Protocol.Thermostat
{
    /// <summary>
    /// Ecobee API thermostat summary revision.
    /// </summary>
    public class ThermostatSummaryRevision
    {
        /// <summary>
        /// The thermostat identifier.
        /// </summary>
        public string ThermostatIdentifier { get; set; }

        /// <summary>
        /// The thermostat name, otherwise an empty field if one is not set.
        /// </summary>
        public string ThermostatName { get; set; }

        /// <summary>
        /// Whether the thermostat is currently connected to the ecobee servers.
        /// </summary>
        public bool Connected { get; set; }

        /// <summary>
        /// Current thermostat revision. This revision is incremented whenever the thermostat
        /// program, hvac mode, settings or configuration change. Changes to the following
        /// objects will update the thermostat revision: Settings, Program, Event, Device.
        /// </summary>
        public string ThermostatRevision { get; set; }

        /// <summary>
        /// Current revision of the thermostat alerts. This revision is incremented whenever a
        /// new Alert is issued or an Alert is modified (acknowledged or deferred).
        /// </summary>
        public string AlertsRevision { get; set; }

        /// <summary>
        /// The current revision of the thermostat runtime settings. This revision is
        /// incremented whenever the thermostat transmits a new status message, or updates
        /// the equipment state or Remote Sensor readings. The shortest interval this revision
        /// may change is 3 minutes.
        /// </summary>
        public string RuntimeRevision { get; set; }

        /// <summary>
        /// The current revision of the thermostat interval runtime settings. This revision is
        /// incremented whenever the thermostat transmits a new status message in the form of
        /// a Runtime object. The thermostat updates this on a 15 minute interval.
        /// </summary>
        public string IntervalRevision { get; set; }

        /// <summary>
        /// Creates a new ThermostatSummaryRevision from a string containing 7 parts segmented by a ':'.
        /// </summary>
        /// <param name="csvString">The Revision CSV string.</param>
        /// <returns>A ThermostatSummaryRevision object.</returns>
        public static ThermostatSummaryRevision Parse(string csvString)
        {
            var parts = csvString.Split(':');
            if (parts.Length != 7)
                throw new ArgumentException("Revision CSV string does not contain 7 parts");

            return new ThermostatSummaryRevision
            {
                ThermostatIdentifier = parts[0],
                ThermostatName = parts[1],
                Connected = bool.Parse(parts[2]),
                ThermostatRevision = parts[3],
                AlertsRevision = parts[4],
                RuntimeRevision = parts[5],
                IntervalRevision = parts[6]
            };
        }
    }
}
