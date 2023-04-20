// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.PowerShell;

    /// <summary>Static Site Build ARM resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(StaticSiteBuildArmResourceTypeConverter))]
    public partial class StaticSiteBuildArmResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.StaticSiteBuildArmResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new StaticSiteBuildArmResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.StaticSiteBuildArmResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new StaticSiteBuildArmResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="StaticSiteBuildArmResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="StaticSiteBuildArmResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.StaticSiteBuildArmResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal StaticSiteBuildArmResource(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.StaticSiteBuildArmResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("BuildId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).BuildId = (string) content.GetValueForProperty("BuildId",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).BuildId, global::System.Convert.ToString);
            }
            if (content.Contains("SourceBranch"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).SourceBranch = (string) content.GetValueForProperty("SourceBranch",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).SourceBranch, global::System.Convert.ToString);
            }
            if (content.Contains("PullRequestTitle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).PullRequestTitle = (string) content.GetValueForProperty("PullRequestTitle",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).PullRequestTitle, global::System.Convert.ToString);
            }
            if (content.Contains("Hostname"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).Hostname, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).CreatedTimeUtc = (global::System.DateTime?) content.GetValueForProperty("CreatedTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).CreatedTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastUpdatedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).LastUpdatedOn = (global::System.DateTime?) content.GetValueForProperty("LastUpdatedOn",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).LastUpdatedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BuildStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BuildStatus.CreateFrom);
            }
            if (content.Contains("UserProvidedFunctionApp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).UserProvidedFunctionApp = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserProvidedFunctionApp[]) content.GetValueForProperty("UserProvidedFunctionApp",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).UserProvidedFunctionApp, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserProvidedFunctionApp>(__y, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.StaticSiteUserProvidedFunctionAppTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.StaticSiteBuildArmResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal StaticSiteBuildArmResource(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.StaticSiteBuildArmResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("BuildId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).BuildId = (string) content.GetValueForProperty("BuildId",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).BuildId, global::System.Convert.ToString);
            }
            if (content.Contains("SourceBranch"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).SourceBranch = (string) content.GetValueForProperty("SourceBranch",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).SourceBranch, global::System.Convert.ToString);
            }
            if (content.Contains("PullRequestTitle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).PullRequestTitle = (string) content.GetValueForProperty("PullRequestTitle",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).PullRequestTitle, global::System.Convert.ToString);
            }
            if (content.Contains("Hostname"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).Hostname, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).CreatedTimeUtc = (global::System.DateTime?) content.GetValueForProperty("CreatedTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).CreatedTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastUpdatedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).LastUpdatedOn = (global::System.DateTime?) content.GetValueForProperty("LastUpdatedOn",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).LastUpdatedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BuildStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BuildStatus.CreateFrom);
            }
            if (content.Contains("UserProvidedFunctionApp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).UserProvidedFunctionApp = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserProvidedFunctionApp[]) content.GetValueForProperty("UserProvidedFunctionApp",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteBuildArmResourceInternal)this).UserProvidedFunctionApp, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserProvidedFunctionApp>(__y, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.StaticSiteUserProvidedFunctionAppTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

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
    /// Static Site Build ARM resource.
    [System.ComponentModel.TypeConverter(typeof(StaticSiteBuildArmResourceTypeConverter))]
    public partial interface IStaticSiteBuildArmResource

    {

    }
}