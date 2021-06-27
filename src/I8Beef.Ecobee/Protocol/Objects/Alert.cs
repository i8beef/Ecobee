using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API alert.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Alert
    {
        /// <summary>
        /// The acknowledge ref of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "acknowledgeRef")]
        public string AcknowledgeRef { get; set; }

        /// <summary>
        /// The date of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        /// <summary>
        /// The time of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        /// <summary>
        /// The saverity of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string Severity { get; set; }

        /// <summary>
        /// The text of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "text", Required = Required.Always)]
        public string Text { get; set; }

        /// <summary>
        /// The number of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "alertNumber")]
        public int? AlertNumber { get; set; }

        /// <summary>
        /// The type of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "alertType")]
        public string AlertType { get; set; }

        /// <summary>
        /// Whether alert is an operator alert.
        /// </summary>
        [JsonProperty(PropertyName = "isOperatorAlert")]
        public bool? IsOperatorAlert { get; set; }

        /// <summary>
        /// The reminder of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "reminder")]
        public string Reminder { get; set; }

        /// <summary>
        /// Whether to show the alert in Idt.
        /// </summary>
        [JsonProperty(PropertyName = "showIdt")]
        public bool? ShowIdt { get; set; }

        /// <summary>
        /// Whether to show the alert on the web.
        /// </summary>
        [JsonProperty(PropertyName = "showWeb")]
        public bool? ShowWeb { get; set; }

        /// <summary>
        /// Whether to send and email for the alert.
        /// </summary>
        [JsonProperty(PropertyName = "sendEmail")]
        public bool? SendEmail { get; set; }

        /// <summary>
        /// Acknowledgement of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "acknowledgement")]
        public string Acknowledgement { get; set; }

        /// <summary>
        /// Whether to remind about the alert later.
        /// </summary>
        [JsonProperty(PropertyName = "remindMeLater")]
        public bool? RemindMeLater { get; set; }

        /// <summary>
        /// The thermostat identifier.
        /// </summary>
        [JsonProperty(PropertyName = "thermostatIdentifier")]
        public string ThermostatIdentifier { get; set; }

        /// <summary>
        /// The notification type of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "notificationType")]
        public string NotificationType { get; set; }
    }
}
