// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// NetApp account resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NetAppAccount : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the NetAppAccount class.
        /// </summary>
        public NetAppAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetAppAccount class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="provisioningState">Azure lifecycle management</param>
        /// <param name="activeDirectories">Active Directories</param>
        /// <param name="encryption">Encryption settings</param>
        /// <param name="disableShowmount">Shows the status of disableShowmount
        /// for all volumes under the subscription, null equals false</param>
        /// <param name="identity">The identity used for the resource.</param>
        public NetAppAccount(string location, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), string provisioningState = default(string), IList<ActiveDirectory> activeDirectories = default(IList<ActiveDirectory>), AccountEncryption encryption = default(AccountEncryption), bool? disableShowmount = default(bool?), ManagedServiceIdentity identity = default(ManagedServiceIdentity))
            : base(location, id, name, type, systemData, tags)
        {
            Etag = etag;
            ProvisioningState = provisioningState;
            ActiveDirectories = activeDirectories;
            Encryption = encryption;
            DisableShowmount = disableShowmount;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets azure lifecycle management
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets active Directories
        /// </summary>
        [JsonProperty(PropertyName = "properties.activeDirectories")]
        public IList<ActiveDirectory> ActiveDirectories { get; set; }

        /// <summary>
        /// Gets or sets encryption settings
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public AccountEncryption Encryption { get; set; }

        /// <summary>
        /// Gets shows the status of disableShowmount for all volumes under the
        /// subscription, null equals false
        /// </summary>
        [JsonProperty(PropertyName = "properties.disableShowmount")]
        public bool? DisableShowmount { get; private set; }

        /// <summary>
        /// Gets or sets the identity used for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ManagedServiceIdentity Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (ActiveDirectories != null)
            {
                foreach (var element in ActiveDirectories)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Encryption != null)
            {
                Encryption.Validate();
            }
            if (Identity != null)
            {
                Identity.Validate();
            }
        }
    }
}
