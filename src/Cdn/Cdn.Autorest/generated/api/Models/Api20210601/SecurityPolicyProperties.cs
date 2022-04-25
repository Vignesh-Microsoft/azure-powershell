// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The json object that contains properties required to create a security policy</summary>
    public partial class SecurityPolicyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStateProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStateProperties __afdStateProperties = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdStateProperties();

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus? DeploymentStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)__afdStateProperties).DeploymentStatus; }

        /// <summary>Internal Acessors for DeploymentStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal.DeploymentStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)__afdStateProperties).DeploymentStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)__afdStateProperties).DeploymentStatus = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)__afdStateProperties).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)__afdStateProperties).ProvisioningState = value; }

        /// <summary>Internal Acessors for ProfileName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyPropertiesInternal.ProfileName { get => this._profileName; set { {_profileName = value;} } }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyPropertiesParameters _parameter;

        /// <summary>object which contains security policy parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyPropertiesParameters Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.SecurityPolicyPropertiesParameters()); set => this._parameter = value; }

        /// <summary>Backing field for <see cref="ProfileName" /> property.</summary>
        private string _profileName;

        /// <summary>The name of the profile which holds the security policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string ProfileName { get => this._profileName; }

        /// <summary>Provisioning status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)__afdStateProperties).ProvisioningState; }

        /// <summary>Creates an new <see cref="SecurityPolicyProperties" /> instance.</summary>
        public SecurityPolicyProperties()
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
            await eventListener.AssertNotNull(nameof(__afdStateProperties), __afdStateProperties);
            await eventListener.AssertObjectIsValid(nameof(__afdStateProperties), __afdStateProperties);
        }
    }
    /// The json object that contains properties required to create a security policy
    public partial interface ISecurityPolicyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStateProperties
    {
        /// <summary>object which contains security policy parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"object which contains security policy parameters",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyPropertiesParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyPropertiesParameters Parameter { get; set; }
        /// <summary>The name of the profile which holds the security policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the profile which holds the security policy.",
        SerializedName = @"profileName",
        PossibleTypes = new [] { typeof(string) })]
        string ProfileName { get;  }

    }
    /// The json object that contains properties required to create a security policy
    internal partial interface ISecurityPolicyPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal
    {
        /// <summary>object which contains security policy parameters</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyPropertiesParameters Parameter { get; set; }
        /// <summary>The name of the profile which holds the security policy.</summary>
        string ProfileName { get; set; }

    }
}