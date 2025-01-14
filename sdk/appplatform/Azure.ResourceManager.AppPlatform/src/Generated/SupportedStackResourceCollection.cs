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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="SupportedStackResource" /> and their operations.
    /// Each <see cref="SupportedStackResource" /> in the collection will belong to the same instance of <see cref="AppBuildServiceResource" />.
    /// To get a <see cref="SupportedStackResourceCollection" /> instance call the GetSupportedStackResources method from an instance of <see cref="AppBuildServiceResource" />.
    /// </summary>
    public partial class SupportedStackResourceCollection : ArmCollection, IEnumerable<SupportedStackResource>, IAsyncEnumerable<SupportedStackResource>
    {
        private readonly ClientDiagnostics _supportedStackResourceBuildServiceClientDiagnostics;
        private readonly BuildServiceRestOperations _supportedStackResourceBuildServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="SupportedStackResourceCollection"/> class for mocking. </summary>
        protected SupportedStackResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SupportedStackResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SupportedStackResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _supportedStackResourceBuildServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", SupportedStackResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SupportedStackResource.ResourceType, out string supportedStackResourceBuildServiceApiVersion);
            _supportedStackResourceBuildServiceRestClient = new BuildServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, supportedStackResourceBuildServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppBuildServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppBuildServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the supported stack resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks/{stackName}
        /// Operation Id: BuildService_GetSupportedStack
        /// </summary>
        /// <param name="stackName"> The name of the stack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stackName"/> is null. </exception>
        public virtual async Task<Response<SupportedStackResource>> GetAsync(string stackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stackName, nameof(stackName));

            using var scope = _supportedStackResourceBuildServiceClientDiagnostics.CreateScope("SupportedStackResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _supportedStackResourceBuildServiceRestClient.GetSupportedStackAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, stackName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportedStackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the supported stack resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks/{stackName}
        /// Operation Id: BuildService_GetSupportedStack
        /// </summary>
        /// <param name="stackName"> The name of the stack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stackName"/> is null. </exception>
        public virtual Response<SupportedStackResource> Get(string stackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stackName, nameof(stackName));

            using var scope = _supportedStackResourceBuildServiceClientDiagnostics.CreateScope("SupportedStackResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _supportedStackResourceBuildServiceRestClient.GetSupportedStack(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, stackName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportedStackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all supported stacks.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks
        /// Operation Id: BuildService_ListSupportedStacks
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SupportedStackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SupportedStackResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SupportedStackResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _supportedStackResourceBuildServiceClientDiagnostics.CreateScope("SupportedStackResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _supportedStackResourceBuildServiceRestClient.ListSupportedStacksAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SupportedStackResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get all supported stacks.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks
        /// Operation Id: BuildService_ListSupportedStacks
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SupportedStackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SupportedStackResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SupportedStackResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _supportedStackResourceBuildServiceClientDiagnostics.CreateScope("SupportedStackResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _supportedStackResourceBuildServiceRestClient.ListSupportedStacks(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SupportedStackResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks/{stackName}
        /// Operation Id: BuildService_GetSupportedStack
        /// </summary>
        /// <param name="stackName"> The name of the stack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stackName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string stackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stackName, nameof(stackName));

            using var scope = _supportedStackResourceBuildServiceClientDiagnostics.CreateScope("SupportedStackResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _supportedStackResourceBuildServiceRestClient.GetSupportedStackAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, stackName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks/{stackName}
        /// Operation Id: BuildService_GetSupportedStack
        /// </summary>
        /// <param name="stackName"> The name of the stack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stackName"/> is null. </exception>
        public virtual Response<bool> Exists(string stackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stackName, nameof(stackName));

            using var scope = _supportedStackResourceBuildServiceClientDiagnostics.CreateScope("SupportedStackResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _supportedStackResourceBuildServiceRestClient.GetSupportedStack(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, stackName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SupportedStackResource> IEnumerable<SupportedStackResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SupportedStackResource> IAsyncEnumerable<SupportedStackResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
