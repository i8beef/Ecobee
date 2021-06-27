using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API demand response.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DemandResponse
    {
        /// <summary>
        /// The user defined name of the Demand Response event.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// A system generated ID to uniquely identify the event.
        /// </summary>
        [JsonProperty(PropertyName = "demandResponseRef")]
        public string DemandResponseRef { get; set; }

        /// <summary>
        /// User (event creator) comments regarding the event.
        /// </summary>
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }

        /// <summary>
        /// The text message to send to the user (recipient of the event).
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// The date the demand response is deferred to.
        /// </summary>
        [JsonProperty(PropertyName = "deferredDate")]
        public string DeferredDate { get; set; }

        /// <summary>
        /// The time the demand response has been deferred to.
        /// </summary>
        [JsonProperty(PropertyName = "deferredTime")]
        public string DeferredTime { get; set; }

        /// <summary>
        /// Whether to show the event message on the thermostat. Default: true
        /// </summary>
        [JsonProperty(PropertyName = "showIdt")]
        public bool? ShowIdt { get; set; }

        /// <summary>
        /// Whether to show the event message on the web portal. Default: true
        /// </summary>
        [JsonProperty(PropertyName = "showWeb")]
        public bool? ShowWeb { get; set; }

        /// <summary>
        /// Whether to send the event message as an email to the user. Default: true
        /// </summary>
        [JsonProperty(PropertyName = "sendEmail")]
        public bool? SendEmail { get; set; }

        /// <summary>
        /// Whether to randomize the start time of the event for each thermostat in order
        /// to mitigate severe electric grid load drops when the event starts. Default: false
        /// </summary>
        [JsonProperty(PropertyName = "randomizeStartTime")]
        public bool? RandomizeStartTime { get; set; }

        /// <summary>
        /// The number of seconds between 0 and the value to randomize the start time with. Default: 1800
        /// </summary>
        [JsonProperty(PropertyName = "randomStartTimeSeconds")]
        public bool? RandomStartTimeSeconds { get; set; }

        /// <summary>
        /// Whether to randomize the end time of the event for each thermostat in order to mitigate
        /// electric grid load spikes when the event ends and thermostats resume normal program
        /// operation. Default: false
        /// </summary>
        [JsonProperty(PropertyName = "randomizeEndTime")]
        public bool? RandomizeEndTime { get; set; }

        /// <summary>
        /// The number of seconds between 0 and the value to randomize the end time with. Default: 1800
        /// </summary>
        [JsonProperty(PropertyName = "randomEndTimeSeconds")]
        public int? RandomEndTimeSeconds { get; set; }

        /// <summary>
        /// The Event Object whose properties to use when creating the DR event.
        /// </summary>
        [JsonProperty(PropertyName = "event")]
        public Event Event { get; set; }

        /// <summary>
        /// The list of thermostats associated with this DR. Populated by the server when listing DRs.
        /// </summary>
        [JsonProperty(PropertyName = "thermostats")]
        public IList<string> Thermostats { get; set; }

        /// <summary>
        /// External ref.
        /// </summary>
        [JsonProperty(PropertyName = "externalRef")]
        public string ExternalRef { get; set; }

        /// <summary>
        /// External ref type.
        /// </summary>
        [JsonProperty(PropertyName = "externalRefType")]
        public string ExternalRefType { get; set; }

        /// <summary>
        /// The priority of the demand.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public long Priority { get; set; }
    }
}