using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API function params base class.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class FunctionParams
    {
    }
}
