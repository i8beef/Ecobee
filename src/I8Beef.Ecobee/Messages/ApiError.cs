using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Messages
{
    [DataContract]
    public class ApiError
    {
        [DataMember(Name = "error")]
        public string Error { get; set; }

        [DataMember(Name = "error_description")]
        public string ErrorDescription { get; set; }

        [DataMember(Name = "error_uri")]
        public string ErrorUri { get; set; }

    }
}
