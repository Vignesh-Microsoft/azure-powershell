// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Extensions;

    /// <summary>Gets or sets the PrometheusHaCluster provider properties.</summary>
    public partial class PrometheusHaClusterProviderInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IPrometheusHaClusterProviderInstanceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IPrometheusHaClusterProviderInstancePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderSpecificProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderSpecificProperties __providerSpecificProperties = new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ProviderSpecificProperties();

        /// <summary>Backing field for <see cref="ClusterName" /> property.</summary>
        private string _clusterName;

        /// <summary>Gets or sets the clusterName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string ClusterName { get => this._clusterName; set => this._clusterName = value; }

        /// <summary>Backing field for <see cref="Hostname" /> property.</summary>
        private string _hostname;

        /// <summary>Gets or sets the target machine name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string Hostname { get => this._hostname; set => this._hostname = value; }

        /// <summary>Backing field for <see cref="PrometheusUrl" /> property.</summary>
        private string _prometheusUrl;

        /// <summary>URL of the Node Exporter endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string PrometheusUrl { get => this._prometheusUrl; set => this._prometheusUrl = value; }

        /// <summary>The provider type. For example, the value can be SapHana.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inherited)]
        public string ProviderType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderSpecificPropertiesInternal)__providerSpecificProperties).ProviderType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderSpecificPropertiesInternal)__providerSpecificProperties).ProviderType = value ; }

        /// <summary>Backing field for <see cref="Sid" /> property.</summary>
        private string _sid;

        /// <summary>Gets or sets the cluster sid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string Sid { get => this._sid; set => this._sid = value; }

        /// <summary>Backing field for <see cref="SslCertificateUri" /> property.</summary>
        private string _sslCertificateUri;

        /// <summary>Gets or sets the blob URI to SSL certificate for the HA cluster exporter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string SslCertificateUri { get => this._sslCertificateUri; set => this._sslCertificateUri = value; }

        /// <summary>Backing field for <see cref="SslPreference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SslPreference? _sslPreference;

        /// <summary>Gets or sets certificate preference if secure communication is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SslPreference? SslPreference { get => this._sslPreference; set => this._sslPreference = value; }

        /// <summary>
        /// Creates an new <see cref="PrometheusHaClusterProviderInstanceProperties" /> instance.
        /// </summary>
        public PrometheusHaClusterProviderInstanceProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__providerSpecificProperties), __providerSpecificProperties);
            await eventListener.AssertObjectIsValid(nameof(__providerSpecificProperties), __providerSpecificProperties);
        }
    }
    /// Gets or sets the PrometheusHaCluster provider properties.
    public partial interface IPrometheusHaClusterProviderInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderSpecificProperties
    {
        /// <summary>Gets or sets the clusterName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the clusterName.",
        SerializedName = @"clusterName",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterName { get; set; }
        /// <summary>Gets or sets the target machine name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the target machine name.",
        SerializedName = @"hostname",
        PossibleTypes = new [] { typeof(string) })]
        string Hostname { get; set; }
        /// <summary>URL of the Node Exporter endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URL of the Node Exporter endpoint.",
        SerializedName = @"prometheusUrl",
        PossibleTypes = new [] { typeof(string) })]
        string PrometheusUrl { get; set; }
        /// <summary>Gets or sets the cluster sid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the cluster sid.",
        SerializedName = @"sid",
        PossibleTypes = new [] { typeof(string) })]
        string Sid { get; set; }
        /// <summary>Gets or sets the blob URI to SSL certificate for the HA cluster exporter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the blob URI to SSL certificate for the HA cluster exporter.",
        SerializedName = @"sslCertificateUri",
        PossibleTypes = new [] { typeof(string) })]
        string SslCertificateUri { get; set; }
        /// <summary>Gets or sets certificate preference if secure communication is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets certificate preference if secure communication is enabled.",
        SerializedName = @"sslPreference",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SslPreference) })]
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SslPreference? SslPreference { get; set; }

    }
    /// Gets or sets the PrometheusHaCluster provider properties.
    internal partial interface IPrometheusHaClusterProviderInstancePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderSpecificPropertiesInternal
    {
        /// <summary>Gets or sets the clusterName.</summary>
        string ClusterName { get; set; }
        /// <summary>Gets or sets the target machine name.</summary>
        string Hostname { get; set; }
        /// <summary>URL of the Node Exporter endpoint.</summary>
        string PrometheusUrl { get; set; }
        /// <summary>Gets or sets the cluster sid.</summary>
        string Sid { get; set; }
        /// <summary>Gets or sets the blob URI to SSL certificate for the HA cluster exporter.</summary>
        string SslCertificateUri { get; set; }
        /// <summary>Gets or sets certificate preference if secure communication is enabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SslPreference? SslPreference { get; set; }

    }
}