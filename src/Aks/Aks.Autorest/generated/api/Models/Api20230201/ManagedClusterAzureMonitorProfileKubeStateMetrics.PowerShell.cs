// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.PowerShell;

    /// <summary>
    /// Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the kube-state-metrics
    /// pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for details.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ManagedClusterAzureMonitorProfileKubeStateMetricsTypeConverter))]
    public partial class ManagedClusterAzureMonitorProfileKubeStateMetrics
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterAzureMonitorProfileKubeStateMetrics"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterAzureMonitorProfileKubeStateMetrics"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterAzureMonitorProfileKubeStateMetrics DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ManagedClusterAzureMonitorProfileKubeStateMetrics(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterAzureMonitorProfileKubeStateMetrics"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterAzureMonitorProfileKubeStateMetrics"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterAzureMonitorProfileKubeStateMetrics DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ManagedClusterAzureMonitorProfileKubeStateMetrics(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ManagedClusterAzureMonitorProfileKubeStateMetrics" />, deserializing the content
        /// from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="ManagedClusterAzureMonitorProfileKubeStateMetrics" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterAzureMonitorProfileKubeStateMetrics FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterAzureMonitorProfileKubeStateMetrics"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ManagedClusterAzureMonitorProfileKubeStateMetrics(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MetricLabelsAllowlist"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterAzureMonitorProfileKubeStateMetricsInternal)this).MetricLabelsAllowlist = (string) content.GetValueForProperty("MetricLabelsAllowlist",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterAzureMonitorProfileKubeStateMetricsInternal)this).MetricLabelsAllowlist, global::System.Convert.ToString);
            }
            if (content.Contains("MetricAnnotationsAllowList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterAzureMonitorProfileKubeStateMetricsInternal)this).MetricAnnotationsAllowList = (string) content.GetValueForProperty("MetricAnnotationsAllowList",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterAzureMonitorProfileKubeStateMetricsInternal)this).MetricAnnotationsAllowList, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterAzureMonitorProfileKubeStateMetrics"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ManagedClusterAzureMonitorProfileKubeStateMetrics(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MetricLabelsAllowlist"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterAzureMonitorProfileKubeStateMetricsInternal)this).MetricLabelsAllowlist = (string) content.GetValueForProperty("MetricLabelsAllowlist",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterAzureMonitorProfileKubeStateMetricsInternal)this).MetricLabelsAllowlist, global::System.Convert.ToString);
            }
            if (content.Contains("MetricAnnotationsAllowList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterAzureMonitorProfileKubeStateMetricsInternal)this).MetricAnnotationsAllowList = (string) content.GetValueForProperty("MetricAnnotationsAllowList",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterAzureMonitorProfileKubeStateMetricsInternal)this).MetricAnnotationsAllowList, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the kube-state-metrics
    /// pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for details.
    [System.ComponentModel.TypeConverter(typeof(ManagedClusterAzureMonitorProfileKubeStateMetricsTypeConverter))]
    public partial interface IManagedClusterAzureMonitorProfileKubeStateMetrics

    {

    }
}