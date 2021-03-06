// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Ring
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SessionOperations.
    /// </summary>
    public static partial class SessionOperationsExtensions
    {
            /// <summary>
            /// Start Session
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='apiVersion'>
            /// Possible values include: '9'
            /// </param>
            /// <param name='deviceos'>
            /// Possible values include: 'ios'
            /// </param>
            /// <param name='devicehardwareId'>
            /// Possible values include: 'test'
            /// </param>
            public static Session Start(this ISessionOperations operations, string apiVersion = default(string), string deviceos = default(string), string devicehardwareId = default(string))
            {
                return operations.StartAsync(apiVersion, deviceos, devicehardwareId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Start Session
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='apiVersion'>
            /// Possible values include: '9'
            /// </param>
            /// <param name='deviceos'>
            /// Possible values include: 'ios'
            /// </param>
            /// <param name='devicehardwareId'>
            /// Possible values include: 'test'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Session> StartAsync(this ISessionOperations operations, string apiVersion = default(string), string deviceos = default(string), string devicehardwareId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StartWithHttpMessagesAsync(apiVersion, deviceos, devicehardwareId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
