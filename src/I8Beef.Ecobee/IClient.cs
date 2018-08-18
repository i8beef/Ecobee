using System.Threading;
using System.Threading.Tasks;
using I8Beef.Ecobee.Messages;
using I8Beef.Ecobee.Protocol;

namespace I8Beef.Ecobee
{
    /// <summary>
    /// Ecobee client implementation.
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// Get an access token using the specified auth code.
        /// </summary>
        /// <param name="authCode">Code previously provided by Ecobee.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        Task GetAccessTokenAsync(string authCode, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Peforms a GET operation against the Ecobee API.
        /// </summary>
        /// <typeparam name="TRequest">The type of request to send to the Ecobee API.</typeparam>
        /// <typeparam name="TResponse">The type of response from the Ecobee API.</typeparam>
        /// <param name="request">The request to send to the Ecobee API.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response from the Ecobee API.</returns>
        Task<TResponse> GetAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken = default(CancellationToken))
            where TRequest : RequestBase
            where TResponse : Response;

        /// <summary>
        /// Get a pin from Ecobee API for pairing.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A <see cref="Pin"/>.</returns>
        Task<Pin> GetPinAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Peforms a POST operation against the Ecobee API.
        /// </summary>
        /// <typeparam name="TRequest">The type of request to send to the Ecobee API.</typeparam>
        /// <typeparam name="TResponse">The type of response from the Ecobee API.</typeparam>
        /// <param name="request">The request to send to the Ecobee API.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The response from the Ecobee API.</returns>
        Task<TResponse> PostAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken = default(CancellationToken))
            where TRequest : RequestBase
            where TResponse : Response;
    }
}
