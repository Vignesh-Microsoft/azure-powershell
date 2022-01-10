// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Extensions;

    /// <summary>A header to add to the WebTest.</summary>
    public partial class HeaderField :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IHeaderField,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IHeaderFieldInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the header.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>The value of the header.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="HeaderField" /> instance.</summary>
        public HeaderField()
        {

        }
    }
    /// A header to add to the WebTest.
    public partial interface IHeaderField :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IJsonSerializable
    {
        /// <summary>The name of the header.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the header.",
        SerializedName = @"key",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The value of the header.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of the header.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// A header to add to the WebTest.
    internal partial interface IHeaderFieldInternal

    {
        /// <summary>The name of the header.</summary>
        string Name { get; set; }
        /// <summary>The value of the header.</summary>
        string Value { get; set; }

    }
}