// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Helpers.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The service endpoint properties.
    /// </summary>
    public partial class ServiceEndpointPropertiesFormat
    {
        /// <summary>
        /// Initializes a new instance of the ServiceEndpointPropertiesFormat
        /// class.
        /// </summary>
        public ServiceEndpointPropertiesFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceEndpointPropertiesFormat
        /// class.
        /// </summary>
        /// <param name="service">The type of the endpoint service.</param>
        /// <param name="locations">A list of locations.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// service endpoint resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        public ServiceEndpointPropertiesFormat(string service = default(string), IList<string> locations = default(IList<string>), string provisioningState = default(string))
        {
            Service = service;
            Locations = locations;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of the endpoint service.
        /// </summary>
        [JsonProperty(PropertyName = "service")]
        public string Service { get; set; }

        /// <summary>
        /// Gets or sets a list of locations.
        /// </summary>
        [JsonProperty(PropertyName = "locations")]
        public IList<string> Locations { get; set; }

        /// <summary>
        /// Gets the provisioning state of the service endpoint resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
