using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class DemandResponse
    {
        public DemandResponse()
        {
            Thermostats = new List<string>();
        }

        /// <summary>
        /// The user defined name of the Demand Response event.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// A system generated ID to uniquely identify the event.
        /// </summary>
        [DataMember(Name = "demandResponseRef")]
        public string DemandResponseRef { get; set; }

        /// <summary>
        /// User (event creator) comments regarding the event.
        /// </summary>
        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        /// <summary>
        /// The text message to send to the user (recipient of the event).
        /// </summary>
        [DataMember(Name = "message")]
        public string Message { get; set; }

        /// <summary>
        /// The date the demand response is deferred to.
        /// </summary>
        [DataMember(Name = "deferredDate")]
        public string DeferredDate { get; set; }

        /// <summary>
        /// The time the demand response has been deferred to.
        /// </summary>
        [DataMember(Name = "deferredTime")]
        public string DeferredTime { get; set; }

        /// <summary>
        /// Whether to show the event message on the thermostat. Default: true
        /// </summary>
        [DataMember(Name = "showIdt")]
        public bool ShowIdt { get; set; }

        /// <summary>
        /// Whether to show the event message on the web portal. Default: true
        /// </summary>
        [DataMember(Name = "showWeb")]
        public bool ShowWeb { get; set; }

        /// <summary>
        /// Whether to send the event message as an email to the user. Default: true
        /// </summary>
        [DataMember(Name = "sendEmail")]
        public bool SendEmail { get; set; }

        /// <summary>
        /// Whether to randomize the start time of the event for each thermostat in order 
        /// to mitigate severe electric grid load drops when the event starts. Default: false
        /// </summary>
        [DataMember(Name = "randomizeStartTime")]
        public bool RandomizeStartTime { get; set; }

        /// <summary>
        /// The number of seconds between 0 and the value to randomize the start time with. Default: 1800
        /// </summary>
        [DataMember(Name = "randomStartTimeSeconds")]
        public bool RandomStartTimeSeconds { get; set; }

        /// <summary>
        /// Whether to randomize the end time of the event for each thermostat in order to mitigate 
        /// electric grid load spikes when the event ends and thermostats resume normal program 
        /// operation. Default: false
        /// </summary>
        [DataMember(Name = "randomizeEndTime")]
        public bool RandomizeEndTime { get; set; }

        /// <summary>
        /// The number of seconds between 0 and the value to randomize the end time with. Default: 1800
        /// </summary>
        [DataMember(Name = "randomEndTimeSeconds")]
        public int RandomEndTimeSeconds { get; set; }

        /// <summary>
        /// The Event Object whose properties to use when creating the DR event.
        /// </summary>
        [DataMember(Name = "event")]
        public Event Event { get; set; }

        /// <summary>
        /// The list of thermostats associated with this DR. Populated by the server when listing DRs.
        /// </summary>
        [DataMember(Name = "thermostats")]
        public IList<string> Thermostats { get; set; }

        /// <summary>
        /// </summary>
        [DataMember(Name = "externalRef")]
        public string ExternalRef { get; set; }

        /// <summary>
        /// </summary>
        [DataMember(Name = "externalRefType")]
        public string ExternalRefType { get; set; }

        /// <summary>
        /// </summary>
        [DataMember(Name = "priority")]
        public long Priority { get; set; }
    }
}