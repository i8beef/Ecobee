using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class NotificationSettings
    {
        public NotificationSettings()
        {
            EmailAddresses = new List<string>();
            Equipment = new List<EquipmentSetting>();
            General = new List<GeneralSetting>();
            Limit = new List<LimitSetting>();
        }

        /// <summary>
        /// The list of email addresses alerts and reminders will be sent to. The full 
        /// list of email addresses must be sent in any update request. If any are missing 
        /// from that list they will be deleted. If an empty list is sent, any email addresses 
        /// will be deleted.
        /// </summary>
        [DataMember(Name = "emailAddresses")]
        public IList<string> EmailAddresses { get; set; }

        /// <summary>
        /// Boolean values representing whether or not alerts and reminders will be sent 
        /// to the email addresses listed above when triggered.
        /// </summary>
        [DataMember(Name = "emailNotificationsEnabled")]
        public bool EmailNotificationsEnabled { get; set; }

        /// <summary>
        /// The list of equipment specific alert and reminder settings.
        /// </summary>
        [DataMember(Name = "equipment")]
        public IList<EquipmentSetting> Equipment { get; set; }

        /// <summary>
        /// The list of general alert and reminder settings.
        /// </summary>
        [DataMember(Name = "general")]
        public IList<GeneralSetting> General { get; set; }

        /// <summary>
        /// The list of limit specific alert and reminder settings.
        /// </summary>
        [DataMember(Name = "limit")]
        public IList<LimitSetting> Limit { get; set; }
    }
}
