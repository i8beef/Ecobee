using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace I8Beef.Ecobee
{
    /// <summary>
    /// JSON serialization helper.
    /// </summary>
    /// <typeparam name="TType">Type of object to serialize / deserialize to.</typeparam>
    public static class JsonSerializer<TType>
        where TType : class
    {
        /// <summary>
        /// Serializes an object to JSON
        /// </summary>
        /// <param name="instance">The object to serialize.</param>
        /// <returns>Serialized string.</returns>
        public static string Serialize(TType instance)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DateFormatString = "yyyy-MM-dd"
            };

            return JsonConvert.SerializeObject(instance, settings);
        }

        /// <summary>
        /// DeSerializes an object from JSON
        /// </summary>
        /// <param name="json">The JSON string to deserialize.</param>
        /// <returns>Deserialized object.</returns>
        public static TType Deserialize(string json)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DateFormatString = "yyyy-MM-dd"
            };

            return JsonConvert.DeserializeObject<TType>(json, settings);
        }
    }
}
