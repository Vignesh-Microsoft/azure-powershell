// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.PowerShell;

    /// <summary>The domain JSON object required for domain creation or update.</summary>
    [System.ComponentModel.TypeConverter(typeof(AfdDomainUpdateParametersTypeConverter))]
    public partial class AfdDomainUpdateParameters
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdDomainUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AfdDomainUpdateParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParameters) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdDomainUpdatePropertiesParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureDnsZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).AzureDnsZone = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference) content.GetValueForProperty("AzureDnsZone",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).AzureDnsZone, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("PropertiesPreValidatedCustomDomainResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).PropertiesPreValidatedCustomDomainResourceId = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference) content.GetValueForProperty("PropertiesPreValidatedCustomDomainResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).PropertiesPreValidatedCustomDomainResourceId, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProfileName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).ProfileName = (string) content.GetValueForProperty("ProfileName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).ProfileName, global::System.Convert.ToString);
            }
            if (content.Contains("TlsSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).TlsSetting = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainHttpsParameters) content.GetValueForProperty("TlsSetting",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).TlsSetting, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdDomainHttpsParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureDnsZoneId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).AzureDnsZoneId = (string) content.GetValueForProperty("AzureDnsZoneId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).AzureDnsZoneId, global::System.Convert.ToString);
            }
            if (content.Contains("PropertiesPreValidatedCustomDomainResourceIdId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).PropertiesPreValidatedCustomDomainResourceIdId = (string) content.GetValueForProperty("PropertiesPreValidatedCustomDomainResourceIdId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).PropertiesPreValidatedCustomDomainResourceIdId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdDomainUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AfdDomainUpdateParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParameters) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdDomainUpdatePropertiesParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureDnsZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).AzureDnsZone = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference) content.GetValueForProperty("AzureDnsZone",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).AzureDnsZone, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("PropertiesPreValidatedCustomDomainResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).PropertiesPreValidatedCustomDomainResourceId = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference) content.GetValueForProperty("PropertiesPreValidatedCustomDomainResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).PropertiesPreValidatedCustomDomainResourceId, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProfileName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).ProfileName = (string) content.GetValueForProperty("ProfileName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).ProfileName, global::System.Convert.ToString);
            }
            if (content.Contains("TlsSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).TlsSetting = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainHttpsParameters) content.GetValueForProperty("TlsSetting",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).TlsSetting, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdDomainHttpsParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureDnsZoneId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).AzureDnsZoneId = (string) content.GetValueForProperty("AzureDnsZoneId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).AzureDnsZoneId, global::System.Convert.ToString);
            }
            if (content.Contains("PropertiesPreValidatedCustomDomainResourceIdId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).PropertiesPreValidatedCustomDomainResourceIdId = (string) content.GetValueForProperty("PropertiesPreValidatedCustomDomainResourceIdId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParametersInternal)this).PropertiesPreValidatedCustomDomainResourceIdId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdDomainUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParameters" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AfdDomainUpdateParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdDomainUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParameters" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AfdDomainUpdateParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AfdDomainUpdateParameters" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdateParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The domain JSON object required for domain creation or update.
    [System.ComponentModel.TypeConverter(typeof(AfdDomainUpdateParametersTypeConverter))]
    public partial interface IAfdDomainUpdateParameters

    {

    }
}