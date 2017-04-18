using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Page
    {
        /// <summary>
        /// The page retrieved or, in the case of a request parameter, 
        /// the specific page requested.
        /// </summary>
        [JsonProperty(PropertyName = "page")]
        public int CurrentPage { get; set; }

        /// <summary>
        /// The total pages available.
        /// </summary>
        [JsonProperty(PropertyName = "totalPages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// The number of objects on this page.
        /// </summary>
        [JsonProperty(PropertyName = "pageSize")]
        public int PageSize { get; set; }

        /// <summary>
        /// The total number of objects available.
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }
    }
}
