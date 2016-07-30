using I8Beef.Ecobee.Protocol.Objects;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions
{
    [DataContract]
    [KnownType(typeof(SendMessageParams))]
    public class SendMessageFunction : Function
    {
        public SendMessageFunction()
        {
            Params = new SendMessageParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get { return "sendMessage"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See 
        /// individual function documentation for the properties.
        /// </summary>
        [DataMember(Name = "params")]
        public override FunctionParams Params { get; set; }
    }

    [DataContract]
    public class SendMessageParams : FunctionParams
    {
        /// <summary>
        /// The message text to send. Text will be truncated to 500 characters if longer.
        /// </summary>
        [DataMember(Name = "text")]
        public string Text { get; set; }
    }
}
