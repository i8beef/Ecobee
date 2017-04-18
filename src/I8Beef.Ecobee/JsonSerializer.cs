using Newtonsoft.Json;

namespace I8Beef.Ecobee
{
    public static class JsonSerializer<TType> where TType : class
    {
        /// <summary>
        /// Serializes an object to JSON
        /// </summary>
        public static string Serialize(TType instance)
        {
            var settings = new JsonSerializerSettings
            {
                DateFormatString = "yyyy-MM-dd"
            };
    
            return JsonConvert.SerializeObject(instance, settings);
        }

        /// <summary>
        /// DeSerializes an object from JSON
        /// </summary>
        public static TType Deserialize(string json)
        {
            var settings = new JsonSerializerSettings
            {
                DateFormatString = "yyyy-MM-dd"
            };

            return JsonConvert.DeserializeObject<TType>(json, settings);
        }
    }
}
