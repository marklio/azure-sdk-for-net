// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.FluidRelay.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.FluidRelay
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.FluidRelay. </summary>
    public static partial class FluidRelayExtensions
    {
        private static TenantResourceExtensionClient GetExtensionClient(TenantResource tenantResource)
        {
            return tenantResource.GetCachedClient((client) =>
            {
                return new TenantResourceExtensionClient(client, tenantResource.Id);
            }
            );
        }

        /// <summary>
        /// List all operations provided by Microsoft.FluidRelay.
        /// Request Path: /providers/Microsoft.FluidRelay/operations
        /// Operation Id: FluidRelayOperations_List
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OperationResult" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OperationResult> GetFluidRelayOperationsAsync(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(tenantResource).GetFluidRelayOperationsAsync(cancellationToken);
        }

        /// <summary>
        /// List all operations provided by Microsoft.FluidRelay.
        /// Request Path: /providers/Microsoft.FluidRelay/operations
        /// Operation Id: FluidRelayOperations_List
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OperationResult" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OperationResult> GetFluidRelayOperations(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(tenantResource).GetFluidRelayOperations(cancellationToken);
        }

        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// List all Fluid Relay servers in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.FluidRelay/fluidRelayServers
        /// Operation Id: FluidRelayServers_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FluidRelayServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<FluidRelayServerResource> GetFluidRelayServersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetFluidRelayServersAsync(cancellationToken);
        }

        /// <summary>
        /// List all Fluid Relay servers in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.FluidRelay/fluidRelayServers
        /// Operation Id: FluidRelayServers_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FluidRelayServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<FluidRelayServerResource> GetFluidRelayServers(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetFluidRelayServers(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of FluidRelayServerResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of FluidRelayServerResources and their operations over a FluidRelayServerResource. </returns>
        public static FluidRelayServerCollection GetFluidRelayServers(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetFluidRelayServers();
        }

        /// <summary>
        /// Get a Fluid Relay server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}
        /// Operation Id: FluidRelayServers_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="fluidRelayServerName"> The Fluid Relay server resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluidRelayServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluidRelayServerName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<FluidRelayServerResource>> GetFluidRelayServerAsync(this ResourceGroupResource resourceGroupResource, string fluidRelayServerName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetFluidRelayServers().GetAsync(fluidRelayServerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Fluid Relay server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}
        /// Operation Id: FluidRelayServers_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="fluidRelayServerName"> The Fluid Relay server resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluidRelayServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluidRelayServerName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<FluidRelayServerResource> GetFluidRelayServer(this ResourceGroupResource resourceGroupResource, string fluidRelayServerName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetFluidRelayServers().Get(fluidRelayServerName, cancellationToken);
        }

        #region FluidRelayServerResource
        /// <summary>
        /// Gets an object representing a <see cref="FluidRelayServerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FluidRelayServerResource.CreateResourceIdentifier" /> to create a <see cref="FluidRelayServerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FluidRelayServerResource" /> object. </returns>
        public static FluidRelayServerResource GetFluidRelayServerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FluidRelayServerResource.ValidateResourceId(id);
                return new FluidRelayServerResource(client, id);
            }
            );
        }
        #endregion

        #region FluidRelayContainerResource
        /// <summary>
        /// Gets an object representing a <see cref="FluidRelayContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FluidRelayContainerResource.CreateResourceIdentifier" /> to create a <see cref="FluidRelayContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FluidRelayContainerResource" /> object. </returns>
        public static FluidRelayContainerResource GetFluidRelayContainerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FluidRelayContainerResource.ValidateResourceId(id);
                return new FluidRelayContainerResource(client, id);
            }
            );
        }
        #endregion
    }
}
