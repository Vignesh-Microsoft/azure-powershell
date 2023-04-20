// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401
{
    using Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.PowerShell;

    /// <summary>Gets or sets the SQL server provider properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(MSSqlServerProviderInstancePropertiesTypeConverter))]
    public partial class MSSqlServerProviderInstanceProperties
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.MSSqlServerProviderInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstanceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstanceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MSSqlServerProviderInstanceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.MSSqlServerProviderInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstanceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstanceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MSSqlServerProviderInstanceProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MSSqlServerProviderInstanceProperties" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="MSSqlServerProviderInstanceProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstanceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.MSSqlServerProviderInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MSSqlServerProviderInstanceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Hostname"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).Hostname, global::System.Convert.ToString);
            }
            if (content.Contains("DbPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).DbPort = (string) content.GetValueForProperty("DbPort",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).DbPort, global::System.Convert.ToString);
            }
            if (content.Contains("DbUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).DbUsername = (string) content.GetValueForProperty("DbUsername",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).DbUsername, global::System.Convert.ToString);
            }
            if (content.Contains("DbPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).DbPassword = (string) content.GetValueForProperty("DbPassword",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).DbPassword, global::System.Convert.ToString);
            }
            if (content.Contains("DbPasswordUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).DbPasswordUri = (string) content.GetValueForProperty("DbPasswordUri",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).DbPasswordUri, global::System.Convert.ToString);
            }
            if (content.Contains("SapSid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).SapSid = (string) content.GetValueForProperty("SapSid",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).SapSid, global::System.Convert.ToString);
            }
            if (content.Contains("SslPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).SslPreference = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SslPreference?) content.GetValueForProperty("SslPreference",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).SslPreference, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SslPreference.CreateFrom);
            }
            if (content.Contains("SslCertificateUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).SslCertificateUri = (string) content.GetValueForProperty("SslCertificateUri",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).SslCertificateUri, global::System.Convert.ToString);
            }
            if (content.Contains("ProviderType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderSpecificPropertiesInternal)this).ProviderType = (string) content.GetValueForProperty("ProviderType",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderSpecificPropertiesInternal)this).ProviderType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.MSSqlServerProviderInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MSSqlServerProviderInstanceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Hostname"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).Hostname, global::System.Convert.ToString);
            }
            if (content.Contains("DbPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).DbPort = (string) content.GetValueForProperty("DbPort",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).DbPort, global::System.Convert.ToString);
            }
            if (content.Contains("DbUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).DbUsername = (string) content.GetValueForProperty("DbUsername",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).DbUsername, global::System.Convert.ToString);
            }
            if (content.Contains("DbPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).DbPassword = (string) content.GetValueForProperty("DbPassword",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).DbPassword, global::System.Convert.ToString);
            }
            if (content.Contains("DbPasswordUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).DbPasswordUri = (string) content.GetValueForProperty("DbPasswordUri",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).DbPasswordUri, global::System.Convert.ToString);
            }
            if (content.Contains("SapSid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).SapSid = (string) content.GetValueForProperty("SapSid",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).SapSid, global::System.Convert.ToString);
            }
            if (content.Contains("SslPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).SslPreference = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SslPreference?) content.GetValueForProperty("SslPreference",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).SslPreference, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SslPreference.CreateFrom);
            }
            if (content.Contains("SslCertificateUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).SslCertificateUri = (string) content.GetValueForProperty("SslCertificateUri",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMSSqlServerProviderInstancePropertiesInternal)this).SslCertificateUri, global::System.Convert.ToString);
            }
            if (content.Contains("ProviderType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderSpecificPropertiesInternal)this).ProviderType = (string) content.GetValueForProperty("ProviderType",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderSpecificPropertiesInternal)this).ProviderType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Gets or sets the SQL server provider properties.
    [System.ComponentModel.TypeConverter(typeof(MSSqlServerProviderInstancePropertiesTypeConverter))]
    public partial interface IMSSqlServerProviderInstanceProperties

    {

    }
}