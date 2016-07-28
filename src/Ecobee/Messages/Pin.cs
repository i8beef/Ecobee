using System.Runtime.Serialization;

namespace Ecobee.Messages
{
    [DataContract]
    public class Pin
    {
        [DataMember(Name = "ecobeePin")]
        public string EcobeePin { get; set; }

        [DataMember(Name = "code")]
        public string Code { get; set; }

        [DataMember(Name = "scope")]
        public string Scope { get; set; }

        [DataMember(Name = "expires_in")]
        public int ExpiresIn { get; set; }

        [DataMember(Name = "interval")]
        public int Interval { get; set; }
    }
}
