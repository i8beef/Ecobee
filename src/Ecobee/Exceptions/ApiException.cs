using I8Beef.Ecobee.Messages;
using System;

namespace I8Beef.Ecobee.Exceptions
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
