// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.TrafficManager
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// HeatMapOperations operations.
    /// </summary>
    public partial interface IHeatMapOperations
    {
        /// <summary>
        /// Gets latest heatmap for Traffic Manager profile.
        /// </summary>
        /// <remarks>
        /// Gets latest heatmap for Traffic Manager profile.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='profileName'>
        /// The name of the Traffic Manager profile.
        /// </param>
        /// <param name='topLeft'>
        /// The top left latitude,longitude pair of the rectangular viewport to query for.
        /// </param>
        /// <param name='botRight'>
        /// The bottom right latitude,longitude pair of the rectangular viewport to query for.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<HeatMapModel>> GetWithHttpMessagesAsync(string resourceGroupName, string profileName, System.Collections.Generic.IList<double?> topLeft = default(System.Collections.Generic.IList<double?>), System.Collections.Generic.IList<double?> botRight = default(System.Collections.Generic.IList<double?>), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}