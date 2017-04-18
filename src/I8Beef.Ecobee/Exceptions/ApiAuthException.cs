using I8Beef.Ecobee.Messages;
using System;

namespace I8Beef.Ecobee.Exceptions
{
    public class ApiAuthException : Exception
    {
        public ApiError Error { get; set; }

        public ApiAuthException(ApiError error)
            : base(error.ErrorDescription)
        {
            Error = error;
        }
    }
}
