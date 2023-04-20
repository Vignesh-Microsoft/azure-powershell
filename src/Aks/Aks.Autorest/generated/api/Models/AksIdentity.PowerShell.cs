// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(AksIdentityTypeConverter))]
    public partial class AksIdentity
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.AksIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AksIdentity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).ResourceName = (string) content.GetValueForProperty("ResourceName",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).ResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("RoleName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).RoleName = (string) content.GetValueForProperty("RoleName",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).RoleName, global::System.Convert.ToString);
            }
            if (content.Contains("CommandId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).CommandId = (string) content.GetValueForProperty("CommandId",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).CommandId, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).ConfigName = (string) content.GetValueForProperty("ConfigName",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).ConfigName, global::System.Convert.ToString);
            }
            if (content.Contains("AgentPoolName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).AgentPoolName = (string) content.GetValueForProperty("AgentPoolName",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).AgentPoolName, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointConnectionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).PrivateEndpointConnectionName = (string) content.GetValueForProperty("PrivateEndpointConnectionName",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).PrivateEndpointConnectionName, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).Id, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.AksIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AksIdentity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).ResourceName = (string) content.GetValueForProperty("ResourceName",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).ResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("RoleName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).RoleName = (string) content.GetValueForProperty("RoleName",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).RoleName, global::System.Convert.ToString);
            }
            if (content.Contains("CommandId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).CommandId = (string) content.GetValueForProperty("CommandId",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).CommandId, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).ConfigName = (string) content.GetValueForProperty("ConfigName",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).ConfigName, global::System.Convert.ToString);
            }
            if (content.Contains("AgentPoolName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).AgentPoolName = (string) content.GetValueForProperty("AgentPoolName",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).AgentPoolName, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointConnectionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).PrivateEndpointConnectionName = (string) content.GetValueForProperty("PrivateEndpointConnectionName",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).PrivateEndpointConnectionName, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentityInternal)this).Id, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.AksIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AksIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.AksIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AksIdentity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AksIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AksIdentity" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IAksIdentity FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(AksIdentityTypeConverter))]
    public partial interface IAksIdentity

    {

    }
}