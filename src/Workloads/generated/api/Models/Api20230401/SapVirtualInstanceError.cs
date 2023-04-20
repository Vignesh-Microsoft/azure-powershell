// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Extensions;

    /// <summary>An error response from the Virtual Instance for SAP Workload service.</summary>
    public partial class SapVirtualInstanceError :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapVirtualInstanceError,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapVirtualInstanceErrorInternal
    {

        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinitionInternal)Property).Code; }

        /// <summary>Internal error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinition[] Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinitionInternal)Property).Detail; }

        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinitionInternal)Property).Message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapVirtualInstanceErrorInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinitionInternal)Property).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinitionInternal)Property).Code = value; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinition[] Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapVirtualInstanceErrorInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinitionInternal)Property).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinitionInternal)Property).Detail = value; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapVirtualInstanceErrorInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinitionInternal)Property).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinitionInternal)Property).Message = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinition Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapVirtualInstanceErrorInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ErrorDefinition()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinition _property;

        /// <summary>The Virtual Instance for SAP error body.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinition Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ErrorDefinition()); set => this._property = value; }

        /// <summary>Creates an new <see cref="SapVirtualInstanceError" /> instance.</summary>
        public SapVirtualInstanceError()
        {

        }
    }
    /// An error response from the Virtual Instance for SAP Workload service.
    public partial interface ISapVirtualInstanceError :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Service specific error code which serves as the substatus for the HTTP error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>Internal error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Internal error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinition) })]
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinition[] Detail { get;  }
        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Description of the error.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }

    }
    /// An error response from the Virtual Instance for SAP Workload service.
    internal partial interface ISapVirtualInstanceErrorInternal

    {
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        string Code { get; set; }
        /// <summary>Internal error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinition[] Detail { get; set; }
        /// <summary>Description of the error.</summary>
        string Message { get; set; }
        /// <summary>The Virtual Instance for SAP error body.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorDefinition Property { get; set; }

    }
}