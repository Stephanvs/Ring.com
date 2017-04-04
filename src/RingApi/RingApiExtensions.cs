// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace RingApi
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RingApi.
    /// </summary>
    public static partial class RingApiExtensions
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
            public static void GetSession(this IRingApi operations, string apiVersion = default(string), string deviceos = default(string), string devicehardwareId = default(string))
            {
                operations.GetSessionAsync(apiVersion, deviceos, devicehardwareId).GetAwaiter().GetResult();
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
            public static async Task GetSessionAsync(this IRingApi operations, string apiVersion = default(string), string deviceos = default(string), string devicehardwareId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetSessionWithHttpMessagesAsync(apiVersion, deviceos, devicehardwareId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Devices
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='authToken'>
            /// </param>
            public static void GetDevices(this IRingApi operations, string authToken = "")
            {
                operations.GetDevicesAsync(authToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Devices
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='authToken'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetDevicesAsync(this IRingApi operations, string authToken = "", CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetDevicesWithHttpMessagesAsync(authToken, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Dings
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='authToken'>
            /// </param>
            public static void GetDings(this IRingApi operations, string authToken = default(string))
            {
                operations.GetDingsAsync(authToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Dings
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='authToken'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetDingsAsync(this IRingApi operations, string authToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetDingsWithHttpMessagesAsync(authToken, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// History
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='authToken'>
            /// </param>
            public static void GetHistory(this IRingApi operations, string authToken = default(string))
            {
                operations.GetHistoryAsync(authToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// History
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='authToken'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetHistoryAsync(this IRingApi operations, string authToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetHistoryWithHttpMessagesAsync(authToken, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Last Recording
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseBodyPath'>
            /// </param>
            /// <param name='authToken'>
            /// </param>
            public static void GetLastRecording(this IRingApi operations, string responseBodyPath, string authToken = default(string))
            {
                operations.GetLastRecordingAsync(responseBodyPath, authToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Last Recording
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseBodyPath'>
            /// </param>
            /// <param name='authToken'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetLastRecordingAsync(this IRingApi operations, string responseBodyPath, string authToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetLastRecordingWithHttpMessagesAsync(responseBodyPath, authToken, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}