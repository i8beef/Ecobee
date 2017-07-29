using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using I8Beef.Ecobee.Protocol;

namespace I8Beef.Ecobee.Exceptions
{
    /// <summary>
    /// Ecobee API general exception.
    /// </summary>
    [Serializable]
    public class ApiException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="response">The API response.</param>
        public ApiException(Response response)
            : base(response.Status.Code + ": " + response.Status.Message)
        {
            Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        protected ApiException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }

        /// <summary>
        /// The API response.
        /// </summary>
        public Response Response { get; private set; }

        /// <summary>
        /// GetObjectData performs a custom serialization.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
