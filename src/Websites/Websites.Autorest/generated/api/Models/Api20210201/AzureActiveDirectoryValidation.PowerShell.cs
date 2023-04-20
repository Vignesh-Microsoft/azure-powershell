// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.PowerShell;

    /// <summary>The configuration settings of the Azure Active Directory token validation flow.</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureActiveDirectoryValidationTypeConverter))]
    public partial class AzureActiveDirectoryValidation
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.AzureActiveDirectoryValidation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureActiveDirectoryValidation(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("JwtClaimCheck"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).JwtClaimCheck = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IJwtClaimChecks) content.GetValueForProperty("JwtClaimCheck",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).JwtClaimCheck, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.JwtClaimChecksTypeConverter.ConvertFrom);
            }
            if (content.Contains("DefaultAuthorizationPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).DefaultAuthorizationPolicy = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDefaultAuthorizationPolicy) content.GetValueForProperty("DefaultAuthorizationPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).DefaultAuthorizationPolicy, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.DefaultAuthorizationPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("AllowedAudience"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).AllowedAudience = (string[]) content.GetValueForProperty("AllowedAudience",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).AllowedAudience, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("JwtClaimCheckAllowedGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).JwtClaimCheckAllowedGroup = (string[]) content.GetValueForProperty("JwtClaimCheckAllowedGroup",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).JwtClaimCheckAllowedGroup, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DefaultAuthorizationPolicyAllowedPrincipal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).DefaultAuthorizationPolicyAllowedPrincipal = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAllowedPrincipals) content.GetValueForProperty("DefaultAuthorizationPolicyAllowedPrincipal",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).DefaultAuthorizationPolicyAllowedPrincipal, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.AllowedPrincipalsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DefaultAuthorizationPolicyAllowedApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).DefaultAuthorizationPolicyAllowedApplication = (string[]) content.GetValueForProperty("DefaultAuthorizationPolicyAllowedApplication",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).DefaultAuthorizationPolicyAllowedApplication, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("JwtClaimCheckAllowedClientApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).JwtClaimCheckAllowedClientApplication = (string[]) content.GetValueForProperty("JwtClaimCheckAllowedClientApplication",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).JwtClaimCheckAllowedClientApplication, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AllowedPrincipalGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).AllowedPrincipalGroup = (string[]) content.GetValueForProperty("AllowedPrincipalGroup",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).AllowedPrincipalGroup, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AllowedPrincipalIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).AllowedPrincipalIdentity = (string[]) content.GetValueForProperty("AllowedPrincipalIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).AllowedPrincipalIdentity, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.AzureActiveDirectoryValidation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureActiveDirectoryValidation(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("JwtClaimCheck"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).JwtClaimCheck = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IJwtClaimChecks) content.GetValueForProperty("JwtClaimCheck",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).JwtClaimCheck, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.JwtClaimChecksTypeConverter.ConvertFrom);
            }
            if (content.Contains("DefaultAuthorizationPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).DefaultAuthorizationPolicy = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDefaultAuthorizationPolicy) content.GetValueForProperty("DefaultAuthorizationPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).DefaultAuthorizationPolicy, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.DefaultAuthorizationPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("AllowedAudience"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).AllowedAudience = (string[]) content.GetValueForProperty("AllowedAudience",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).AllowedAudience, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("JwtClaimCheckAllowedGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).JwtClaimCheckAllowedGroup = (string[]) content.GetValueForProperty("JwtClaimCheckAllowedGroup",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).JwtClaimCheckAllowedGroup, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DefaultAuthorizationPolicyAllowedPrincipal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).DefaultAuthorizationPolicyAllowedPrincipal = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAllowedPrincipals) content.GetValueForProperty("DefaultAuthorizationPolicyAllowedPrincipal",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).DefaultAuthorizationPolicyAllowedPrincipal, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.AllowedPrincipalsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DefaultAuthorizationPolicyAllowedApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).DefaultAuthorizationPolicyAllowedApplication = (string[]) content.GetValueForProperty("DefaultAuthorizationPolicyAllowedApplication",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).DefaultAuthorizationPolicyAllowedApplication, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("JwtClaimCheckAllowedClientApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).JwtClaimCheckAllowedClientApplication = (string[]) content.GetValueForProperty("JwtClaimCheckAllowedClientApplication",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).JwtClaimCheckAllowedClientApplication, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AllowedPrincipalGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).AllowedPrincipalGroup = (string[]) content.GetValueForProperty("AllowedPrincipalGroup",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).AllowedPrincipalGroup, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AllowedPrincipalIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).AllowedPrincipalIdentity = (string[]) content.GetValueForProperty("AllowedPrincipalIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidationInternal)this).AllowedPrincipalIdentity, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.AzureActiveDirectoryValidation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidation"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidation DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureActiveDirectoryValidation(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.AzureActiveDirectoryValidation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidation"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidation DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureActiveDirectoryValidation(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureActiveDirectoryValidation" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AzureActiveDirectoryValidation" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryValidation FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The configuration settings of the Azure Active Directory token validation flow.
    [System.ComponentModel.TypeConverter(typeof(AzureActiveDirectoryValidationTypeConverter))]
    public partial interface IAzureActiveDirectoryValidation

    {

    }
}