using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Alert
    {
        [JsonProperty(PropertyName = "acknowledgeRef")]
        public string AcknowledgeRef { get; set; }

        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        [JsonProperty(PropertyName = "severity")]
        public string Severity { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "alertNumber")]
        public int AlertNumber { get; set; }

        [JsonProperty(PropertyName = "alertType")]
        public string AlertType { get; set; }

        [JsonProperty(PropertyName = "isOperatorAlert")]
        public bool IsOperatorAlert { get; set; }

        [JsonProperty(PropertyName = "reminder")]
        public string Reminder { get; set; }

        [JsonProperty(PropertyName = "showIdt")]
        public bool ShowIdt { get; set; }

        [JsonProperty(PropertyName = "showWeb")]
        public bool ShowWeb { get; set; }

        [JsonProperty(PropertyName = "sendEmail")]
        public bool SendEmail { get; set; }

        [JsonProperty(PropertyName = "acknowledgement")]
        public string Acknowledgement { get; set; }

        [JsonProperty(PropertyName = "remindMeLater")]
        public bool RemindMeLater { get; set; }

        [JsonProperty(PropertyName = "thermostatIdentifier")]
        public string ThermostatIdentifier { get; set; }

        [JsonProperty(PropertyName = "notificationType")]
        public string NotificationType { get; set; }
    }
}
