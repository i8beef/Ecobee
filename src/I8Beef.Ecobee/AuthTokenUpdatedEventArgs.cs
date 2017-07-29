using System;
using I8Beef.Ecobee.Messages;

namespace I8Beef.Ecobee
{
    /// <summary>
    /// Auth token updated event args.
    /// </summary>
    public class AuthTokenUpdatedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokenUpdatedEventArgs"/> class.
        /// </summary>
        /// <param name="authToken">The updated auth token.</param>
        public AuthTokenUpdatedEventArgs(AuthToken authToken)
        {
            AuthToken = authToken;
        }

        /// <summary>
        /// Updated auth token.
        /// </summary>
        public AuthToken AuthToken { get; set; }
    }
}
