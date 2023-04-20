// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Extensions;

    /// <summary>Gets or sets the mapping for SID to Environment/Applications.</summary>
    public partial class SapLandscapeMonitorSidMapping :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapLandscapeMonitorSidMapping,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapLandscapeMonitorSidMappingInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Gets or sets the name of the grouping.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="TopSid" /> property.</summary>
        private string[] _topSid;

        /// <summary>Gets or sets the list of SID's.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string[] TopSid { get => this._topSid; set => this._topSid = value; }

        /// <summary>Creates an new <see cref="SapLandscapeMonitorSidMapping" /> instance.</summary>
        public SapLandscapeMonitorSidMapping()
        {

        }
    }
    /// Gets or sets the mapping for SID to Environment/Applications.
    public partial interface ISapLandscapeMonitorSidMapping :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the name of the grouping.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the name of the grouping.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Gets or sets the list of SID's.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the list of SID's.",
        SerializedName = @"topSid",
        PossibleTypes = new [] { typeof(string) })]
        string[] TopSid { get; set; }

    }
    /// Gets or sets the mapping for SID to Environment/Applications.
    internal partial interface ISapLandscapeMonitorSidMappingInternal

    {
        /// <summary>Gets or sets the name of the grouping.</summary>
        string Name { get; set; }
        /// <summary>Gets or sets the list of SID's.</summary>
        string[] TopSid { get; set; }

    }
}