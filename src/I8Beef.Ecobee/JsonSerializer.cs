using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;

namespace I8Beef.Ecobee
{
    public static class JsonSerializer<TType> where TType : class
    {
        /// <summary>
        /// Serializes an object to JSON
        /// </summary>
        public static string Serialize(TType instance)
        {
            var serializer = new DataContractJsonSerializer(typeof(TType), new DataContractJsonSerializerSettings { DateTimeFormat = new DateTimeFormat("yyyy-MM-dd") });
            using (var stream = new MemoryStream())
            {
                serializer.WriteObject(stream, instance);
                var json = Encoding.Default.GetString(stream.ToArray());

                // Deal with any __type clutter from KnownType attributes (see: Functions)
                return Regex.Replace(json, @"""__type"":""[a-zA-Z0-9\.:#]*"",", "");
            }
        }

        /// <summary>
        /// DeSerializes an object from JSON
        /// </summary>
        public static TType Deserialize(string json)
        {
            using (var stream = new MemoryStream(Encoding.Default.GetBytes(json)))
            {
                var serializer = new DataContractJsonSerializer(typeof(TType), new DataContractJsonSerializerSettings { DateTimeFormat = new DateTimeFormat("yyyy-MM-dd") });
                return serializer.ReadObject(stream) as TType;
            }
        }
    }
}
