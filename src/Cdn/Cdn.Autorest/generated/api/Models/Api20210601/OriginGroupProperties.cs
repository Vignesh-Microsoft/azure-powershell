// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object that contains the properties of the origin group.</summary>
    public partial class OriginGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupUpdatePropertiesParameters"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupUpdatePropertiesParameters __originGroupUpdatePropertiesParameters = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.OriginGroupUpdatePropertiesParameters();

        /// <summary>
        /// Health probe settings to the origin that is used to determine the health of the origin.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IHealthProbeParameters HealthProbeSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupUpdatePropertiesParametersInternal)__originGroupUpdatePropertiesParameters).HealthProbeSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupUpdatePropertiesParametersInternal)__originGroupUpdatePropertiesParameters).HealthProbeSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ResourceState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OriginGroupResourceState? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupPropertiesInternal.ResourceState { get => this._resourceState; set { {_resourceState = value;} } }

        /// <summary>The source of the content being delivered via CDN within given origin group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference[] Origin { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupUpdatePropertiesParametersInternal)__originGroupUpdatePropertiesParameters).Origin; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupUpdatePropertiesParametersInternal)__originGroupUpdatePropertiesParameters).Origin = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning status of the origin group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ResourceState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OriginGroupResourceState? _resourceState;

        /// <summary>Resource status of the origin group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OriginGroupResourceState? ResourceState { get => this._resourceState; }

        /// <summary>
        /// The JSON object that contains the properties to determine origin health using real requests/responses. This property is
        /// currently not supported.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResponseBasedOriginErrorDetectionParameters ResponseBasedOriginErrorDetectionSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupUpdatePropertiesParametersInternal)__originGroupUpdatePropertiesParameters).ResponseBasedOriginErrorDetectionSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupUpdatePropertiesParametersInternal)__originGroupUpdatePropertiesParameters).ResponseBasedOriginErrorDetectionSetting = value ?? null /* model class */; }

        /// <summary>
        /// Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint
        /// is added. Default is 10 mins. This property is currently not supported.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupUpdatePropertiesParametersInternal)__originGroupUpdatePropertiesParameters).TrafficRestorationTimeToHealedOrNewEndpointsInMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupUpdatePropertiesParametersInternal)__originGroupUpdatePropertiesParameters).TrafficRestorationTimeToHealedOrNewEndpointsInMinute = value ?? default(int); }

        /// <summary>Creates an new <see cref="OriginGroupProperties" /> instance.</summary>
        public OriginGroupProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__originGroupUpdatePropertiesParameters), __originGroupUpdatePropertiesParameters);
            await eventListener.AssertObjectIsValid(nameof(__originGroupUpdatePropertiesParameters), __originGroupUpdatePropertiesParameters);
        }
    }
    /// The JSON object that contains the properties of the origin group.
    public partial interface IOriginGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupUpdatePropertiesParameters
    {
        /// <summary>Provisioning status of the origin group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning status of the origin group.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>Resource status of the origin group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource status of the origin group.",
        SerializedName = @"resourceState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OriginGroupResourceState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OriginGroupResourceState? ResourceState { get;  }

    }
    /// The JSON object that contains the properties of the origin group.
    internal partial interface IOriginGroupPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupUpdatePropertiesParametersInternal
    {
        /// <summary>Provisioning status of the origin group.</summary>
        string ProvisioningState { get; set; }
        /// <summary>Resource status of the origin group.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OriginGroupResourceState? ResourceState { get; set; }

    }
}