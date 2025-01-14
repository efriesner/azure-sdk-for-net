// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="OnlineEndpointResource" /> and their operations.
    /// Each <see cref="OnlineEndpointResource" /> in the collection will belong to the same instance of <see cref="MachineLearningWorkspaceResource" />.
    /// To get an <see cref="OnlineEndpointCollection" /> instance call the GetOnlineEndpoints method from an instance of <see cref="MachineLearningWorkspaceResource" />.
    /// </summary>
    public partial class OnlineEndpointCollection : ArmCollection, IEnumerable<OnlineEndpointResource>, IAsyncEnumerable<OnlineEndpointResource>
    {
        private readonly ClientDiagnostics _onlineEndpointClientDiagnostics;
        private readonly OnlineEndpointsRestOperations _onlineEndpointRestClient;

        /// <summary> Initializes a new instance of the <see cref="OnlineEndpointCollection"/> class for mocking. </summary>
        protected OnlineEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OnlineEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OnlineEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _onlineEndpointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", OnlineEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(OnlineEndpointResource.ResourceType, out string onlineEndpointApiVersion);
            _onlineEndpointRestClient = new OnlineEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, onlineEndpointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update Online Endpoint (asynchronous).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/onlineEndpoints/{endpointName}
        /// Operation Id: OnlineEndpoints_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="endpointName"> Online Endpoint name. </param>
        /// <param name="data"> Online Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<OnlineEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string endpointName, OnlineEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _onlineEndpointClientDiagnostics.CreateScope("OnlineEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _onlineEndpointRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<OnlineEndpointResource>(new OnlineEndpointOperationSource(Client), _onlineEndpointClientDiagnostics, Pipeline, _onlineEndpointRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update Online Endpoint (asynchronous).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/onlineEndpoints/{endpointName}
        /// Operation Id: OnlineEndpoints_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="endpointName"> Online Endpoint name. </param>
        /// <param name="data"> Online Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<OnlineEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string endpointName, OnlineEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _onlineEndpointClientDiagnostics.CreateScope("OnlineEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _onlineEndpointRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data, cancellationToken);
                var operation = new MachineLearningArmOperation<OnlineEndpointResource>(new OnlineEndpointOperationSource(Client), _onlineEndpointClientDiagnostics, Pipeline, _onlineEndpointRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Online Endpoint.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/onlineEndpoints/{endpointName}
        /// Operation Id: OnlineEndpoints_Get
        /// </summary>
        /// <param name="endpointName"> Online Endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<Response<OnlineEndpointResource>> GetAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _onlineEndpointClientDiagnostics.CreateScope("OnlineEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _onlineEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OnlineEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Online Endpoint.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/onlineEndpoints/{endpointName}
        /// Operation Id: OnlineEndpoints_Get
        /// </summary>
        /// <param name="endpointName"> Online Endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<OnlineEndpointResource> Get(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _onlineEndpointClientDiagnostics.CreateScope("OnlineEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _onlineEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OnlineEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Online Endpoints.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/onlineEndpoints
        /// Operation Id: OnlineEndpoints_List
        /// </summary>
        /// <param name="name"> Name of the endpoint. </param>
        /// <param name="count"> Number of endpoints to be retrieved in a page of results. </param>
        /// <param name="computeType"> EndpointComputeType to be filtered by. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="tags"> A set of tags with which to filter the returned models. It is a comma separated string of tags key or tags key=value. Example: tagKey1,tagKey2,tagKey3=value3 . </param>
        /// <param name="properties"> A set of properties with which to filter the returned models. It is a comma separated string of properties key and/or properties key=value Example: propKey1,propKey2,propKey3=value3 . </param>
        /// <param name="orderBy"> The option to order the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OnlineEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OnlineEndpointResource> GetAllAsync(string name = null, int? count = null, EndpointComputeType? computeType = null, string skip = null, string tags = null, string properties = null, OrderString? orderBy = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<OnlineEndpointResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _onlineEndpointClientDiagnostics.CreateScope("OnlineEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _onlineEndpointRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, count, computeType, skip, tags, properties, orderBy, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OnlineEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OnlineEndpointResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _onlineEndpointClientDiagnostics.CreateScope("OnlineEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _onlineEndpointRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, count, computeType, skip, tags, properties, orderBy, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OnlineEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List Online Endpoints.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/onlineEndpoints
        /// Operation Id: OnlineEndpoints_List
        /// </summary>
        /// <param name="name"> Name of the endpoint. </param>
        /// <param name="count"> Number of endpoints to be retrieved in a page of results. </param>
        /// <param name="computeType"> EndpointComputeType to be filtered by. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="tags"> A set of tags with which to filter the returned models. It is a comma separated string of tags key or tags key=value. Example: tagKey1,tagKey2,tagKey3=value3 . </param>
        /// <param name="properties"> A set of properties with which to filter the returned models. It is a comma separated string of properties key and/or properties key=value Example: propKey1,propKey2,propKey3=value3 . </param>
        /// <param name="orderBy"> The option to order the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OnlineEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OnlineEndpointResource> GetAll(string name = null, int? count = null, EndpointComputeType? computeType = null, string skip = null, string tags = null, string properties = null, OrderString? orderBy = null, CancellationToken cancellationToken = default)
        {
            Page<OnlineEndpointResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _onlineEndpointClientDiagnostics.CreateScope("OnlineEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _onlineEndpointRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, count, computeType, skip, tags, properties, orderBy, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OnlineEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OnlineEndpointResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _onlineEndpointClientDiagnostics.CreateScope("OnlineEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _onlineEndpointRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, count, computeType, skip, tags, properties, orderBy, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OnlineEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/onlineEndpoints/{endpointName}
        /// Operation Id: OnlineEndpoints_Get
        /// </summary>
        /// <param name="endpointName"> Online Endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _onlineEndpointClientDiagnostics.CreateScope("OnlineEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _onlineEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/onlineEndpoints/{endpointName}
        /// Operation Id: OnlineEndpoints_Get
        /// </summary>
        /// <param name="endpointName"> Online Endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _onlineEndpointClientDiagnostics.CreateScope("OnlineEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _onlineEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OnlineEndpointResource> IEnumerable<OnlineEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OnlineEndpointResource> IAsyncEnumerable<OnlineEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
