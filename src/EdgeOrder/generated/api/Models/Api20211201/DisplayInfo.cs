// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>Describes product display information</summary>
    public partial class DisplayInfo :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDisplayInfo,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDisplayInfoInternal
    {

        /// <summary>Backing field for <see cref="ConfigurationDisplayName" /> property.</summary>
        private string _configurationDisplayName;

        /// <summary>Configuration display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string ConfigurationDisplayName { get => this._configurationDisplayName; }

        /// <summary>Internal Acessors for ConfigurationDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDisplayInfoInternal.ConfigurationDisplayName { get => this._configurationDisplayName; set { {_configurationDisplayName = value;} } }

        /// <summary>Internal Acessors for ProductFamilyDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDisplayInfoInternal.ProductFamilyDisplayName { get => this._productFamilyDisplayName; set { {_productFamilyDisplayName = value;} } }

        /// <summary>Backing field for <see cref="ProductFamilyDisplayName" /> property.</summary>
        private string _productFamilyDisplayName;

        /// <summary>Product family display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string ProductFamilyDisplayName { get => this._productFamilyDisplayName; }

        /// <summary>Creates an new <see cref="DisplayInfo" /> instance.</summary>
        public DisplayInfo()
        {

        }
    }
    /// Describes product display information
    public partial interface IDisplayInfo :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable
    {
        /// <summary>Configuration display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Configuration display name",
        SerializedName = @"configurationDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string ConfigurationDisplayName { get;  }
        /// <summary>Product family display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Product family display name",
        SerializedName = @"productFamilyDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string ProductFamilyDisplayName { get;  }

    }
    /// Describes product display information
    internal partial interface IDisplayInfoInternal

    {
        /// <summary>Configuration display name</summary>
        string ConfigurationDisplayName { get; set; }
        /// <summary>Product family display name</summary>
        string ProductFamilyDisplayName { get; set; }

    }
}