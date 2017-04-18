using I8Beef.Ecobee.Protocol;
using System;

namespace I8Beef.Ecobee.Exceptions
{
    public class ApiException : Exception
    {
        public Response Response { get; set; }

        public ApiException(Response response)
            : base(response.Status.Code + ": " + response.Status.Message)
        {
            Response = response;
        }
    }
}
