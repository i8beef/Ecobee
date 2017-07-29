using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API send message params.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SendMessageParams : FunctionParams
    {
        /// <summary>
        /// The message text to send. Text will be truncated to 500 characters if longer.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
    }
}
