// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    /// <summary>List Restore Ranges Request</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureBackupFindRestorableTimeRangesRequestResourceTypeConverter))]
    public partial class AzureBackupFindRestorableTimeRangesRequestResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.AzureBackupFindRestorableTimeRangesRequestResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureBackupFindRestorableTimeRangesRequestResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Content"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResourceInternal)this).Content = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequest) content.GetValueForProperty("Content",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResourceInternal)this).Content, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.AzureBackupFindRestorableTimeRangesRequestTypeConverter.ConvertFrom);
            }
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("Uri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).Uri, global::System.Convert.ToString);
            }
            if (content.Contains("Header"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).Header = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestHeaders) content.GetValueForProperty("Header",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).Header, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.DppWorkerRequestHeadersTypeConverter.ConvertFrom);
            }
            if (content.Contains("SupportedGroupVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).SupportedGroupVersion = (string[]) content.GetValueForProperty("SupportedGroupVersion",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).SupportedGroupVersion, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CultureInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).CultureInfo = (string) content.GetValueForProperty("CultureInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).CultureInfo, global::System.Convert.ToString);
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.DppWorkerRequestParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("HttpMethod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).HttpMethod = (string) content.GetValueForProperty("HttpMethod",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).HttpMethod, global::System.Convert.ToString);
            }
            if (content.Contains("ContentSourceDataStoreType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResourceInternal)this).ContentSourceDataStoreType = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType) content.GetValueForProperty("ContentSourceDataStoreType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResourceInternal)this).ContentSourceDataStoreType, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType.CreateFrom);
            }
            if (content.Contains("ContentStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResourceInternal)this).ContentStartTime = (string) content.GetValueForProperty("ContentStartTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResourceInternal)this).ContentStartTime, global::System.Convert.ToString);
            }
            if (content.Contains("ContentEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResourceInternal)this).ContentEndTime = (string) content.GetValueForProperty("ContentEndTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResourceInternal)this).ContentEndTime, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.AzureBackupFindRestorableTimeRangesRequestResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureBackupFindRestorableTimeRangesRequestResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Content"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResourceInternal)this).Content = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequest) content.GetValueForProperty("Content",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResourceInternal)this).Content, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.AzureBackupFindRestorableTimeRangesRequestTypeConverter.ConvertFrom);
            }
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("Uri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).Uri, global::System.Convert.ToString);
            }
            if (content.Contains("Header"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).Header = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestHeaders) content.GetValueForProperty("Header",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).Header, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.DppWorkerRequestHeadersTypeConverter.ConvertFrom);
            }
            if (content.Contains("SupportedGroupVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).SupportedGroupVersion = (string[]) content.GetValueForProperty("SupportedGroupVersion",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).SupportedGroupVersion, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CultureInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).CultureInfo = (string) content.GetValueForProperty("CultureInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).CultureInfo, global::System.Convert.ToString);
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.DppWorkerRequestParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("HttpMethod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).HttpMethod = (string) content.GetValueForProperty("HttpMethod",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IDppWorkerRequestInternal)this).HttpMethod, global::System.Convert.ToString);
            }
            if (content.Contains("ContentSourceDataStoreType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResourceInternal)this).ContentSourceDataStoreType = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType) content.GetValueForProperty("ContentSourceDataStoreType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResourceInternal)this).ContentSourceDataStoreType, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType.CreateFrom);
            }
            if (content.Contains("ContentStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResourceInternal)this).ContentStartTime = (string) content.GetValueForProperty("ContentStartTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResourceInternal)this).ContentStartTime, global::System.Convert.ToString);
            }
            if (content.Contains("ContentEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResourceInternal)this).ContentEndTime = (string) content.GetValueForProperty("ContentEndTime",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResourceInternal)this).ContentEndTime, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.AzureBackupFindRestorableTimeRangesRequestResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureBackupFindRestorableTimeRangesRequestResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.AzureBackupFindRestorableTimeRangesRequestResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureBackupFindRestorableTimeRangesRequestResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureBackupFindRestorableTimeRangesRequestResource" />, deserializing the content
        /// from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="AzureBackupFindRestorableTimeRangesRequestResource" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureBackupFindRestorableTimeRangesRequestResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// List Restore Ranges Request
    [System.ComponentModel.TypeConverter(typeof(AzureBackupFindRestorableTimeRangesRequestResourceTypeConverter))]
    public partial interface IAzureBackupFindRestorableTimeRangesRequestResource

    {

    }
}