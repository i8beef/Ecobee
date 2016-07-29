using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class Alert
    {
        [DataMember(Name = "acknowledgeRef")]
        public string AcknowledgeRef { get; set; }

        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "time")]
        public string Time { get; set; }

        [DataMember(Name = "severity")]
        public string Severity { get; set; }

        [DataMember(Name = "text")]
        public string Text { get; set; }

        [DataMember(Name = "alertNumber")]
        public int AlertNumber { get; set; }

        [DataMember(Name = "alertType")]
        public string AlertType { get; set; }

        [DataMember(Name = "isOperatorAlert")]
        public bool IsOperatorAlert { get; set; }

        [DataMember(Name = "reminder")]
        public string Reminder { get; set; }

        [DataMember(Name = "showIdt")]
        public bool ShowIdt { get; set; }

        [DataMember(Name = "showWeb")]
        public bool ShowWeb { get; set; }

        [DataMember(Name = "sendEmail")]
        public bool SendEmail { get; set; }

        [DataMember(Name = "acknowledgement")]
        public string Acknowledgement { get; set; }

        [DataMember(Name = "remindMeLater")]
        public bool RemindMeLater { get; set; }

        [DataMember(Name = "thermostatIdentifier")]
        public string ThermostatIdentifier { get; set; }

        [DataMember(Name = "notificationType")]
        public string NotificationType { get; set; }
    }
}
