using Ecobee.Messages;
using System;

namespace Ecobee.Exceptions
{
    public class ApiException : Exception
    {
        public ApiError Error { get; set; }

        public ApiException(ApiError error)
            : base(error.ErrorDescription)
        {
            Error = error;
        }
    }
}
