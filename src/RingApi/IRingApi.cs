// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Ring
{
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public partial interface IRingApi : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// Gets the ISessionOperations.
        /// </summary>
        ISessionOperations Session { get; }

        /// <summary>
        /// Gets the IDevices.
        /// </summary>
        IDevices Devices { get; }

        /// <summary>
        /// Gets the IDings.
        /// </summary>
        IDings Dings { get; }

        /// <summary>
        /// Gets the IHistory.
        /// </summary>
        IHistory History { get; }

    }
}
