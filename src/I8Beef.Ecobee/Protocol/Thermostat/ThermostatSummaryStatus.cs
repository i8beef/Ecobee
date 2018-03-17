using System;
using System.Collections.Generic;

namespace I8Beef.Ecobee.Protocol.Thermostat
{
    /// <summary>
    /// Ecobee API thermostat summary status.
    /// </summary>
    public class ThermostatSummaryStatus
    {
        /// <summary>
        /// The thermostat identifier.
        /// </summary>
        public string ThermostatIdentifier { get; set; }

        /// <summary>
        /// If no equipment is currently running no data is returned. Possible values are: heatPump,
        /// heatPump2, heatPump3, compCool1, compCool2, auxHeat1, auxHeat2, auxHeat3, fan, humidifier,
        /// dehumidifier, ventilator, economizer, compHotWater, auxHotWater.
        /// </summary>
        public IList<string> EquipmentStatus { get; set; }

        /// <summary>
        /// Creates a new ThermostatSummaryStatus from a string containing 2 parts segmented by a ':'.
        /// </summary>
        /// <param name="csvString">The Revision CSV string.</param>
        /// <returns>A ThermostatSummaryRevision object.</returns>
        public static ThermostatSummaryStatus Parse(string csvString)
        {
            var parts = csvString.Split(':');
            if (parts.Length != 2)
                throw new ArgumentException("Status CSV string does not contain 2 parts");

            return new ThermostatSummaryStatus
            {
                ThermostatIdentifier = parts[0],
                EquipmentStatus = parts[1].Split(',')
            };
        }
    }
}
