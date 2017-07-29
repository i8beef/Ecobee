using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Functions
{
    /// <summary>
    /// Ecobee API reset preferences params.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ResetPreferencesParams : FunctionParams
    {
    }
}
