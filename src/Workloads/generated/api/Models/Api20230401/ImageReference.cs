// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Extensions;

    /// <summary>
    /// Specifies information about the image to use. You can specify information about platform images, marketplace images, or
    /// virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual
    /// machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set
    /// when you create the scale set.
    /// </summary>
    public partial class ImageReference :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IImageReference,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IImageReferenceInternal
    {

        /// <summary>Backing field for <see cref="Offer" /> property.</summary>
        private string _offer;

        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string Offer { get => this._offer; set => this._offer = value; }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private string _publisher;

        /// <summary>The image publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string Publisher { get => this._publisher; set => this._publisher = value; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private string _sku;

        /// <summary>The image SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string Sku { get => this._sku; set => this._sku = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats
        /// are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version
        /// of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="ImageReference" /> instance.</summary>
        public ImageReference()
        {

        }
    }
    /// Specifies information about the image to use. You can specify information about platform images, marketplace images, or
    /// virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual
    /// machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set
    /// when you create the scale set.
    public partial interface IImageReference :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the offer of the platform image or marketplace image used to create the virtual machine.",
        SerializedName = @"offer",
        PossibleTypes = new [] { typeof(string) })]
        string Offer { get; set; }
        /// <summary>The image publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The image publisher.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }
        /// <summary>The image SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The image SKU.",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        string Sku { get; set; }
        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats
        /// are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version
        /// of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy time even if a new version becomes available.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Specifies information about the image to use. You can specify information about platform images, marketplace images, or
    /// virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual
    /// machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set
    /// when you create the scale set.
    internal partial interface IImageReferenceInternal

    {
        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create the virtual machine.
        /// </summary>
        string Offer { get; set; }
        /// <summary>The image publisher.</summary>
        string Publisher { get; set; }
        /// <summary>The image SKU.</summary>
        string Sku { get; set; }
        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create the virtual machine. The allowed formats
        /// are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version
        /// of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy
        /// time even if a new version becomes available.
        /// </summary>
        string Version { get; set; }

    }
}