using System.Runtime.Serialization;

namespace Ecobee.Protocol.Objects
{
    [DataContract]
    public class Page
    {
        /// <summary>
        /// The page retrieved or, in the case of a request parameter, 
        /// the specific page requested.
        /// </summary>
        [DataMember(Name = "page")]
        public int CurrentPage { get; set; }

        /// <summary>
        /// The total pages available.
        /// </summary>
        [DataMember(Name = "totalPages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// The number of objects on this page.
        /// </summary>
        [DataMember(Name = "pageSize")]
        public int PageSize { get; set; }

        /// <summary>
        /// The total number of objects available.
        /// </summary>
        [DataMember(Name = "total")]
        public int Total { get; set; }
    }
}
