// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>Msi identity details of the resource</summary>
    public partial class ResourceIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceIdentityInternal
    {

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceIdentityInternal.PrincipalId { get => this._principalId; set { {_principalId = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceIdentityInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>Service Principal Id backing the Msi</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>Home Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Identity type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ResourceIdentity" /> instance.</summary>
        public ResourceIdentity()
        {

        }
    }
    /// Msi identity details of the resource
    public partial interface IResourceIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable
    {
        /// <summary>Service Principal Id backing the Msi</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Service Principal Id backing the Msi",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }
        /// <summary>Home Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Home Tenant Id",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }
        /// <summary>Identity type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity type",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Msi identity details of the resource
    internal partial interface IResourceIdentityInternal

    {
        /// <summary>Service Principal Id backing the Msi</summary>
        string PrincipalId { get; set; }
        /// <summary>Home Tenant Id</summary>
        string TenantId { get; set; }
        /// <summary>Identity type</summary>
        string Type { get; set; }

    }
}