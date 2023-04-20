// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Extensions;

    /// <summary>
    /// The full resource names object for database layer resources. The number of entries in this list should be equal to the
    /// number VMs to be created for database layer.
    /// </summary>
    public partial class DatabaseServerFullResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IDatabaseServerFullResourceNames,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IDatabaseServerFullResourceNamesInternal
    {

        /// <summary>Backing field for <see cref="AvailabilitySetName" /> property.</summary>
        private string _availabilitySetName;

        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-DB-AvSet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string AvailabilitySetName { get => this._availabilitySetName; set => this._availabilitySetName = value; }

        /// <summary>Backing field for <see cref="LoadBalancer" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ILoadBalancerResourceNames _loadBalancer;

        /// <summary>The resource names object for load balancer and related resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ILoadBalancerResourceNames LoadBalancer { get => (this._loadBalancer = this._loadBalancer ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.LoadBalancerResourceNames()); set => this._loadBalancer = value; }

        /// <summary>
        /// The list of backend pool names. Currently, ACSS deploys only one backend pool and hence, size of this list should be 1
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inlined)]
        public string[] LoadBalancerBackendPoolName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ILoadBalancerResourceNamesInternal)LoadBalancer).BackendPoolName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ILoadBalancerResourceNamesInternal)LoadBalancer).BackendPoolName = value ?? null /* arrayOf */; }

        /// <summary>
        /// The list of frontend IP configuration names. If provided as input, size of this list should be 2 for cs layer and should
        /// be 1 for database layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inlined)]
        public string[] LoadBalancerFrontendIPConfigurationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ILoadBalancerResourceNamesInternal)LoadBalancer).FrontendIPConfigurationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ILoadBalancerResourceNamesInternal)LoadBalancer).FrontendIPConfigurationName = value ?? null /* arrayOf */; }

        /// <summary>
        /// The list of health probe names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database
        /// layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inlined)]
        public string[] LoadBalancerHealthProbeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ILoadBalancerResourceNamesInternal)LoadBalancer).HealthProbeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ILoadBalancerResourceNamesInternal)LoadBalancer).HealthProbeName = value ?? null /* arrayOf */; }

        /// <summary>
        /// The full resource name for load balancer. If this value is not provided, load balancer will be name as {ASCS/DB}-loadBalancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inlined)]
        public string LoadBalancerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ILoadBalancerResourceNamesInternal)LoadBalancer).LoadBalancerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ILoadBalancerResourceNamesInternal)LoadBalancer).LoadBalancerName = value ?? null; }

        /// <summary>Internal Acessors for LoadBalancer</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ILoadBalancerResourceNames Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IDatabaseServerFullResourceNamesInternal.LoadBalancer { get => (this._loadBalancer = this._loadBalancer ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.LoadBalancerResourceNames()); set { {_loadBalancer = value;} } }

        /// <summary>Backing field for <see cref="VirtualMachine" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IVirtualMachineResourceNames[] _virtualMachine;

        /// <summary>The list of virtual machine naming details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IVirtualMachineResourceNames[] VirtualMachine { get => this._virtualMachine; set => this._virtualMachine = value; }

        /// <summary>Creates an new <see cref="DatabaseServerFullResourceNames" /> instance.</summary>
        public DatabaseServerFullResourceNames()
        {

        }
    }
    /// The full resource names object for database layer resources. The number of entries in this list should be equal to the
    /// number VMs to be created for database layer.
    public partial interface IDatabaseServerFullResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-DB-AvSet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The full name for availability set. In case name is not provided, it will be defaulted to {SID}-DB-AvSet.",
        SerializedName = @"availabilitySetName",
        PossibleTypes = new [] { typeof(string) })]
        string AvailabilitySetName { get; set; }
        /// <summary>
        /// The list of backend pool names. Currently, ACSS deploys only one backend pool and hence, size of this list should be 1
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of backend pool names. Currently, ACSS deploys only one backend pool and hence, size of this list should be 1",
        SerializedName = @"backendPoolNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] LoadBalancerBackendPoolName { get; set; }
        /// <summary>
        /// The list of frontend IP configuration names. If provided as input, size of this list should be 2 for cs layer and should
        /// be 1 for database layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of frontend IP configuration names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database layer.",
        SerializedName = @"frontendIpConfigurationNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] LoadBalancerFrontendIPConfigurationName { get; set; }
        /// <summary>
        /// The list of health probe names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database
        /// layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of health probe names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database layer.",
        SerializedName = @"healthProbeNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] LoadBalancerHealthProbeName { get; set; }
        /// <summary>
        /// The full resource name for load balancer. If this value is not provided, load balancer will be name as {ASCS/DB}-loadBalancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The full resource name for load balancer. If this value is not provided, load balancer will be name as {ASCS/DB}-loadBalancer.",
        SerializedName = @"loadBalancerName",
        PossibleTypes = new [] { typeof(string) })]
        string LoadBalancerName { get; set; }
        /// <summary>The list of virtual machine naming details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of virtual machine naming details.",
        SerializedName = @"virtualMachines",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IVirtualMachineResourceNames) })]
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IVirtualMachineResourceNames[] VirtualMachine { get; set; }

    }
    /// The full resource names object for database layer resources. The number of entries in this list should be equal to the
    /// number VMs to be created for database layer.
    internal partial interface IDatabaseServerFullResourceNamesInternal

    {
        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-DB-AvSet.
        /// </summary>
        string AvailabilitySetName { get; set; }
        /// <summary>The resource names object for load balancer and related resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ILoadBalancerResourceNames LoadBalancer { get; set; }
        /// <summary>
        /// The list of backend pool names. Currently, ACSS deploys only one backend pool and hence, size of this list should be 1
        /// </summary>
        string[] LoadBalancerBackendPoolName { get; set; }
        /// <summary>
        /// The list of frontend IP configuration names. If provided as input, size of this list should be 2 for cs layer and should
        /// be 1 for database layer.
        /// </summary>
        string[] LoadBalancerFrontendIPConfigurationName { get; set; }
        /// <summary>
        /// The list of health probe names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database
        /// layer.
        /// </summary>
        string[] LoadBalancerHealthProbeName { get; set; }
        /// <summary>
        /// The full resource name for load balancer. If this value is not provided, load balancer will be name as {ASCS/DB}-loadBalancer.
        /// </summary>
        string LoadBalancerName { get; set; }
        /// <summary>The list of virtual machine naming details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IVirtualMachineResourceNames[] VirtualMachine { get; set; }

    }
}