using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using I8Beef.Ecobee.Messages;

namespace I8Beef.Ecobee.Exceptions
{
    /// <summary>
    /// Ecobee API Authorization exception.
    /// </summary>
    [Serializable]
    public class ApiAuthException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAuthException"/> class.
        /// </summary>
        /// <param name="error">The error that occurred.</param>
        public ApiAuthException(ApiError error)
            : base(error.ErrorDescription)
        {
            Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAuthException"/> class.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        protected ApiAuthException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }

        /// <summary>
        /// The error that occurred.
        /// </summary>
        public ApiError Error { get; private set; }

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
