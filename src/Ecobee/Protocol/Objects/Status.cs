using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [DataContract]
    public class Status
    {
        /// <summary>
        /// The status code for this status.
        /// </summary>
        [DataMember(Name = "code")]
        public int Code { get; set; }

        /// <summary>
        /// The detailed message for this status.
        /// </summary>
        [DataMember(Name = "message")]
        public string Message { get; set; }
    }
}
