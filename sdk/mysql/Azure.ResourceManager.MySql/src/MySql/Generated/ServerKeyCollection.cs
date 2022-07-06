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

namespace Azure.ResourceManager.MySql
{
    /// <summary>
    /// A class representing a collection of <see cref="ServerKeyResource" /> and their operations.
    /// Each <see cref="ServerKeyResource" /> in the collection will belong to the same instance of <see cref="ServerResource" />.
    /// To get a <see cref="ServerKeyCollection" /> instance call the GetServerKeys method from an instance of <see cref="ServerResource" />.
    /// </summary>
    public partial class ServerKeyCollection : ArmCollection, IEnumerable<ServerKeyResource>, IAsyncEnumerable<ServerKeyResource>
    {
        private readonly ClientDiagnostics _serverKeyClientDiagnostics;
        private readonly ServerKeysRestOperations _serverKeyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerKeyCollection"/> class for mocking. </summary>
        protected ServerKeyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerKeyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerKeyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverKeyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql", ServerKeyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServerKeyResource.ResourceType, out string serverKeyApiVersion);
            _serverKeyRestClient = new ServerKeysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverKeyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a MySQL Server key.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys/{keyName}
        /// Operation Id: ServerKeys_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="keyName"> The name of the MySQL Server key to be operated on (updated or created). </param>
        /// <param name="data"> The requested MySQL Server key resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServerKeyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string keyName, ServerKeyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serverKeyClientDiagnostics.CreateScope("ServerKeyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverKeyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MySqlArmOperation<ServerKeyResource>(new ServerKeyOperationSource(Client), _serverKeyClientDiagnostics, Pipeline, _serverKeyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a MySQL Server key.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys/{keyName}
        /// Operation Id: ServerKeys_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="keyName"> The name of the MySQL Server key to be operated on (updated or created). </param>
        /// <param name="data"> The requested MySQL Server key resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServerKeyResource> CreateOrUpdate(WaitUntil waitUntil, string keyName, ServerKeyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serverKeyClientDiagnostics.CreateScope("ServerKeyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverKeyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, data, cancellationToken);
                var operation = new MySqlArmOperation<ServerKeyResource>(new ServerKeyOperationSource(Client), _serverKeyClientDiagnostics, Pipeline, _serverKeyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a MySQL Server key.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys/{keyName}
        /// Operation Id: ServerKeys_Get
        /// </summary>
        /// <param name="keyName"> The name of the MySQL Server key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual async Task<Response<ServerKeyResource>> GetAsync(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _serverKeyClientDiagnostics.CreateScope("ServerKeyCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverKeyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a MySQL Server key.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys/{keyName}
        /// Operation Id: ServerKeys_Get
        /// </summary>
        /// <param name="keyName"> The name of the MySQL Server key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual Response<ServerKeyResource> Get(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _serverKeyClientDiagnostics.CreateScope("ServerKeyCollection.Get");
            scope.Start();
            try
            {
                var response = _serverKeyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of  Server keys.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys
        /// Operation Id: ServerKeys_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerKeyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerKeyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerKeyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverKeyClientDiagnostics.CreateScope("ServerKeyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverKeyRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerKeyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerKeyResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverKeyClientDiagnostics.CreateScope("ServerKeyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverKeyRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerKeyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of  Server keys.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys
        /// Operation Id: ServerKeys_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerKeyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerKeyResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerKeyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverKeyClientDiagnostics.CreateScope("ServerKeyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverKeyRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerKeyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerKeyResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverKeyClientDiagnostics.CreateScope("ServerKeyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverKeyRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerKeyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys/{keyName}
        /// Operation Id: ServerKeys_Get
        /// </summary>
        /// <param name="keyName"> The name of the MySQL Server key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _serverKeyClientDiagnostics.CreateScope("ServerKeyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serverKeyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/keys/{keyName}
        /// Operation Id: ServerKeys_Get
        /// </summary>
        /// <param name="keyName"> The name of the MySQL Server key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual Response<bool> Exists(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _serverKeyClientDiagnostics.CreateScope("ServerKeyCollection.Exists");
            scope.Start();
            try
            {
                var response = _serverKeyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerKeyResource> IEnumerable<ServerKeyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerKeyResource> IAsyncEnumerable<ServerKeyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
