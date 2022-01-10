// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001
{
    using Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.PowerShell;

    /// <summary>A class represent managed identities used for request and response</summary>
    [System.ComponentModel.TypeConverter(typeof(ManagedIdentityTypeConverter))]
    public partial class ManagedIdentity
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ManagedIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ManagedIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ManagedIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ManagedIdentity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ManagedIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentity FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ManagedIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ManagedIdentity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.ManagedIdentityType?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.ManagedIdentityType.CreateFrom);
            }
            if (content.Contains("UserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityInternal)this).UserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityUserAssignedIdentities) content.GetValueForProperty("UserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityInternal)this).UserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ManagedIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityInternal)this).PrincipalId = (string) content.GetValueForProperty("PrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityInternal)this).PrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityInternal)this).TenantId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ManagedIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ManagedIdentity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.ManagedIdentityType?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.ManagedIdentityType.CreateFrom);
            }
            if (content.Contains("UserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityInternal)this).UserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityUserAssignedIdentities) content.GetValueForProperty("UserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityInternal)this).UserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ManagedIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityInternal)this).PrincipalId = (string) content.GetValueForProperty("PrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityInternal)this).PrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IManagedIdentityInternal)this).TenantId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// A class represent managed identities used for request and response
    [System.ComponentModel.TypeConverter(typeof(ManagedIdentityTypeConverter))]
    public partial interface IManagedIdentity

    {

    }
}