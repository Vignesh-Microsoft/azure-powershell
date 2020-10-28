#
# Module manifest for module 'Az'
#
# Generated by: Microsoft Corporation
#
# Generated on: 10/23/2020
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '5.0.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'd48d710e-85cb-46a1-990f-22dae76f6b5f'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Cmdlets to manage resources in Azure. This module is compatible with WindowsPowerShell and PowerShell Core.
For more information about the Az module, please visit the following: https://docs.microsoft.com/en-us/powershell/azure/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.Advisor'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.Aks'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.AnalysisServices'; RequiredVersion = '1.1.4'; }, 
               @{ModuleName = 'Az.ApiManagement'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.ApplicationInsights'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Automation'; RequiredVersion = '1.4.0'; }, 
               @{ModuleName = 'Az.Batch'; RequiredVersion = '3.1.0'; }, 
               @{ModuleName = 'Az.Billing'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Cdn'; RequiredVersion = '1.6.0'; }, 
               @{ModuleName = 'Az.CognitiveServices'; RequiredVersion = '1.8.0'; }, 
               @{ModuleName = 'Az.Compute'; RequiredVersion = '4.6.0'; }, 
               @{ModuleName = 'Az.ContainerInstance'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.ContainerRegistry'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.DataBoxEdge'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Databricks'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.DataFactory'; RequiredVersion = '1.11.0'; }, 
               @{ModuleName = 'Az.DataLakeAnalytics'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.DataLakeStore'; RequiredVersion = '1.2.8'; }, 
               @{ModuleName = 'Az.DataShare'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.DesktopVirtualization'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.DeploymentManager'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.DevTestLabs'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Dns'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.EventGrid'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.EventHub'; RequiredVersion = '1.7.0'; }, 
               @{ModuleName = 'Az.FrontDoor'; RequiredVersion = '1.6.1'; }, 
               @{ModuleName = 'Az.Functions'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.HDInsight'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'Az.HealthcareApis'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.IotHub'; RequiredVersion = '2.6.0'; }, 
               @{ModuleName = 'Az.KeyVault'; RequiredVersion = '3.0.0'; }, 
               @{ModuleName = 'Az.Kusto'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.LogicApp'; RequiredVersion = '1.3.2'; }, 
               @{ModuleName = 'Az.MachineLearning'; RequiredVersion = '1.1.3'; }, 
               @{ModuleName = 'Az.Maintenance'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.ManagedServices'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.MarketplaceOrdering'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Media'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.Monitor'; RequiredVersion = '2.2.0'; }, 
               @{ModuleName = 'Az.Network'; RequiredVersion = '4.1.0'; }, 
               @{ModuleName = 'Az.NotificationHubs'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.OperationalInsights'; RequiredVersion = '2.3.0'; }, 
               @{ModuleName = 'Az.PolicyInsights'; RequiredVersion = '1.3.1'; }, 
               @{ModuleName = 'Az.PowerBIEmbedded'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.PrivateDns'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.RecoveryServices'; RequiredVersion = '3.0.0'; }, 
               @{ModuleName = 'Az.RedisCache'; RequiredVersion = '1.4.0'; }, 
               @{ModuleName = 'Az.Relay'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.Resources'; RequiredVersion = '3.0.0'; }, 
               @{ModuleName = 'Az.ServiceBus'; RequiredVersion = '1.4.1'; }, 
               @{ModuleName = 'Az.ServiceFabric'; RequiredVersion = '2.2.0'; }, 
               @{ModuleName = 'Az.SignalR'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.Sql'; RequiredVersion = '2.11.1'; }, 
               @{ModuleName = 'Az.SqlVirtualMachine'; RequiredVersion = '1.1.0'; }, 
#               @{ModuleName = 'Az.Storage'; RequiredVersion = '3.0.0'; },  # Storage removed to support preview
               @{ModuleName = 'Az.StorageSync'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.StreamAnalytics'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.Support'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.TrafficManager'; RequiredVersion = '1.0.4'; }, 
               @{ModuleName = 'Az.Websites'; RequiredVersion = '2.0.0'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ARM','ResourceManager','Linux','AzureAutomationNotSupported'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '5.0.0 - October 2020
Az.Accounts
* [Breaking Change] Removed ''Get-AzProfile'' and ''Select-AzProfile''
* Replaced Azure Directory Authentication Library with Microsoft Authentication Library(MSAL)

Az.Aks
* [Breaking Change] Removed parameter alias ''ClientIdAndSecret'' in ''New-AzAksCluster'' and ''Set-AzAksCluster''.
* [Breaking Change] Changed the default value of ''NodeVmSetType'' in ''New-AzAksCluster'' from ''AvailabilitySet'' to ''VirtualMachineScaleSets''.
* [Breaking Change] Changed the default value of ''NetworkPlugin'' in ''New-AzAksCluster'' from ''None'' to ''azure''.
* [Breaking Change] Removed parameter ''NodeOsType'' in ''New-AzAksCluster'' as it supports only one value Linux.

Az.Billing
* Added ''Get-AzBillingAccount'' cmdlet
* Added ''Get-AzBillingProfile'' cmdlet
* Added ''Get-AzInvoiceSection'' cmdlet
* Added new parameters in ''Get-AzBillingInvoice'' cmdlet
* Removed properties DownloadUrlExpiry, Type, BillingPeriodNames from the response of Get-AzBillingInvoice cmdlet

Az.Cdn
* Added cmdlets to support multi-origin and private link functionality 

Az.CognitiveServices
* Updated SDK to 7.4.0-preview.

Az.Compute
* Added ''-VmssId'' parameter to ''New-AzVm''
* Added ''PlatformFaultDomainCount'' parameter to the ''New-AzVmss'' cmdlet.
* New cmdlet ''Get-AzDiskEncryptionSetAssociatedResource''
* Added ''Tier'' and ''LogicalSectorSize'' optional parameters to the New-AzDiskConfig cmdlet. 
* Added ''Tier'', ''MaxSharesCount'', ''DiskIOPSReadOnly'', and ''DiskMBpsReadOnly'' optional parameters to the ''New-AzDiskUpdateConfig'' cmdlet. 

Az.ContainerRegistry
* [Breaking Change] Updates API version to 2020-05-01
* [Breaking Change] Removed SKU ''Classic'' and parameter ''StorageAccountName'' from ''New-AzContainerRegistry''
* Added New cmdlets: ''Connect-AzContainerRegistry'', ''Import-AzContainerRegistry'', ''Get-AzContainerRegistryUsage'', ''New-AzContainerRegistryNetworkRule'', ''Set-AzContainerRegistryNetworkRule''
* Added new parameter ''NetworkRuleSet'' to ''Update-AzContainerRegistry''

Az.Databricks
* Fixed a bug that may cause updating databricks workspace without `-EncryptionKeyVersion` to fail.

Az.DataFactory
* Updated ADF .Net SDK version to 4.12.0
* Updated ADF encryption client SDK version to 4.14.7587.7
* Added ''Stop-AzDataFactoryV2TriggerRun'' and ''Invoke-AzDataFactoryV2TriggerRun'' commands

Az.DesktopVirtualization
* Require Location property for creating top level arm objects.
        * Made `ApplicationGroupType` required for `New-AzWvdApplicationGroup`.
        * Made `HostPoolArmPath` required for `New-AzWvdApplicationGroup`.
        * Added `PreferredAppGroupType` for `New-AzWvdHostPool`.

Az.Functions
* [Breaking Change] Removed ''IncludeSlot'' switch parameter from all but one parameter set of ''Get-AzFunctionApp''. The cmdlet now supports retrieving deployment slots in the results when ''-IncludeSlot'' is specified. 
* Updated ''New-AzFunctionApp'':
  - Fixed -DisableApplicationInsights so that no application insights project is created when this option is specified. [#12728]
  - [Breaking Change] Removed support to create PowerShell 6.2 function apps.
  - [Breaking Change] Changed the default runtime version in Functions version 3 on Windows for PowerShell function apps from 6.2 to 7.0 when the RuntimeVersion parameter is not specified.
  - [Breaking Change] Changed the default runtime version in Functions version 3 on Windows and Linux for Node function apps from 10 to 12 when the RuntimeVersion parameter is not specified.
  - [Breaking Change] Changed the default runtime version in Functions version 3 on Linux for Python function apps from 3.7 to 3.8 when the RuntimeVersion parameter is not specified.

Az.HDInsight
 * For New-AzHDInsightCluster cmdlet:
     - Replaced parameter ''DefaultStorageAccountName'' with ''StorageAccountResourceId''
     - Replaced parameter ''DefaultStorageAccountKey'' with ''StorageAccountKey''
     - Replaced parameter ''DefaultStorageAccountType'' with ''StorageAccountType''
     - Removed parameter ''PublicNetworkAccessType''
     - Removed parameter ''OutboundPublicNetworkAccessType''
     - Added new parameters: ''StorageFileSystem'' and ''StorageAccountManagedIdentity'' to support ADLSGen2
     - Added new parameter ''EnableIDBroker'' to Support HDInsight ID Broker
     - Added new parameters: ''KafkaClientGroupId'', ''KafkaClientGroupName'' and ''KafkaManagementNodeSize'' to support Kafka Rest Proxy
 * For New-AzHDInsightClusterConfig cmdlet:
     - Replaced parameter ''DefaultStorageAccountName'' with ''StorageAccountResourceId''
     - Replaced parameter ''DefaultStorageAccountKey'' with ''StorageAccountKey''
     - Replaced parameter ''DefaultStorageAccountType'' with ''StorageAccountType''
     - Removed parameter ''PublicNetworkAccessType''
     - Removed parameter ''OutboundPublicNetworkAccessType''
* For Set-AzHDInsightDefaultStorage cmdlet:
    - Replaced parameter ''StorageAccountName'' with ''StorageAccountResourceId''
* For Add-AzHDInsightSecurityProfile cmdlet:
    - Replaced parameter ''Domain'' with ''DomainResourceId''
    - Removed the mandatory requirement for parameter ''OrganizationalUnitDN''

Az.KeyVault
* [Breaking Change] Deprecated parameter DisableSoftDelete in ''New-AzKeyVault'' and EnableSoftDelete in ''Update-AzKeyVault''
* [Breaking Change] Removed attribute SecretValueText to avoid displaying SecretValue directly [#12266]
* Supported new resource type: managed HSM
    - CRUD of managed HSM and cmdlets to operate keys on managed HSM
    - Full HSM backup/restore, AES key creation, security domain backup/restore, RBAC

Az.ManagedServices
* [Breaking Change] Updated parameters naming conventions and associated examples

Az.Network
* [Breaking Change] Removed parameter ''HostedSubnet'' and added ''Subnet'' instead
* Added new cmdlets for Virtual Router Peer Routes
    - ''Get-AzVirtualRouterPeerLearnedRoute''
    - ''Get-AzVirtualRouterPeerAdvertisedRoute''
* Updated New-AzFirewall cmdlet:
    - Added parameter ''-SkuTier''
    - Added parameter ''-SkuName'' and made Sku as Alias for this
    - Removed parameter ''-Sku''
* [Breaking Change] Made ''Connectionlink'' argument mandatory in ''Start-AzVpnConnectionPacketCapture'' and ''Stop-AzVpnConnectionPacketCapture''
* [Breaking Change] Updated ''New-AzNetworkWatcherConnectionMonitorEndPointObject'' to remove parameter ''-Filter''
* [Breaking Change] Replaced ''New-AzNetworkWatcherConnectionMonitorEndpointFilterItemObject'' cmdlet with ''New-AzNetworkWatcherConnectionMonitorEndpointScopeItemObject''
* Updated ''New-AzNetworkWatcherConnectionMonitorEndPointObject'' cmdlet:
	- Added parameter ''-Type''
	- Added parameter ''-CoverageLevel''
	- Added parameter ''-Scope''
* Updated ''New-AzNetworkWatcherConnectionMonitorProtocolConfigurationObject'' cmdlet with new parameter ''-DestinationPortBehavior''

Az.RecoveryServices
* Fixing Workload Restore for contributor permissions.
* Added new parameter sets and validations for Restore-AzRecoveryServicesBackupItem cmdlet.

Az.Resources
* Fixed parsing bug
* Updated ARM template What-If cmdlets to remove preview message from results
* Fixed an issue where template deployment cmdlets crash if ''-WhatIf'' is set at a higher scope [#13038]
* Fixed an issue where template deployment cmdlets does not preserve case for template parameters
* Added a default API version to be used in ''Export-AzResourceGroup'' cmdlet
* Added cmdlets for Template Specs (''Get-AzTemplateSpec'', ''Set-AzTemplateSpec'', ''New-AzTemplateSpec'', ''Remove-AzTemplateSpec'', ''Export-AzTemplateSpec'')
* Added support for deploying Template Specs using existing deployment cmdlets (via the new -TemplateSpecId parameter) 
* Updated ''Get-AzResourceGroupDeploymentOperation'' to use the SDK.
* Removed ''-ApiVersion'' parameter from ''*-AzDeployment'' cmdlets.

Az.Sql
* Added DiffBackupIntervalInHours to ''Set-AzSqlDatabaseBackupShortTermRetentionPolicy'' 
* Fixed issue where New-AzSqlDatabaseExport fails if networkIsolation not specified [#13097]
* Fixed issue where New-AzSqlDatabaseExport and New-AzSqlDatabaseImport were not returning OperationStatusLink in the result object [#13097]
* Update Azure Paired Regions URL in Backup Storage Redundancy Warnings 

Az.Storage
* Removed obsolete property RestorePolicy.LastEnabledTime
* Change Type of DaysAfterModificationGreaterThan from int to int?
* Supported create/update file share with access tier
* Supported set/update/remove Acl recursively on Datalake Gen2 item 
* Supported Container access policy with new permission x,t
* Changed the output of get/set Container access policy cmdlet, by change the child property Permission type from enum to String
* Fixed a sample script issue of set management policy with json

Az.Websites
* Added support for Premium V3 pricing tier
* Updated the WebSites SDK to 3.1.0
'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

