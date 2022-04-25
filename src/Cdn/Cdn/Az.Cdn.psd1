#
# Module manifest for module 'Az.Cdn'
#
# Generated by: Microsoft Corporation
#
# Generated on: 4/25/2022
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '0.1.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'accceef6-8113-453a-a31c-4f2ce57893d6'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell: Cdn cmdlets'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
# RequiredModules = @()

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = 'Cdn.Autorest\bin\Az.Cdn.private.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = 'Cdn.Autorest\Az.Cdn.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('Cdn.Autorest\Az.Cdn.psm1')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = 'Clear-AzCdnEndpointContent', 'Clear-AzFrontDoorCdnEndpointContent', 
               'Disable-AzCdnCustomDomainCustomHttps', 
               'Enable-AzCdnCustomDomainCustomHttps', 'Get-AzCdnCustomDomain', 
               'Get-AzCdnEdgeNode', 'Get-AzCdnEndpoint', 
               'Get-AzCdnEndpointResourceUsage', 'Get-AzCdnOrigin', 
               'Get-AzCdnOriginGroup', 'Get-AzCdnProfile', 
               'Get-AzCdnProfileResourceUsage', 
               'Get-AzCdnProfileSupportedOptimizationType', 
               'Get-AzCdnSubscriptionResourceUsage', 
               'Get-AzFrontDoorCdnCustomDomain', 'Get-AzFrontDoorCdnEndpoint', 
               'Get-AzFrontDoorCdnEndpointResourceUsage', 
               'Get-AzFrontDoorCdnOrigin', 'Get-AzFrontDoorCdnOriginGroup', 
               'Get-AzFrontDoorCdnOriginGroupResourceUsage', 
               'Get-AzFrontDoorCdnProfile', 
               'Get-AzFrontDoorCdnProfileResourceUsage', 'Get-AzFrontDoorCdnRoute', 
               'Get-AzFrontDoorCdnRule', 'Get-AzFrontDoorCdnRuleSet', 
               'Get-AzFrontDoorCdnRuleSetResourceUsage', 
               'Get-AzFrontDoorCdnSecret', 'Get-AzFrontDoorCdnSecurityPolicy', 
               'Import-AzCdnEndpointContent', 'New-AzCdnCustomDomain', 
               'New-AzCdnDeliveryRuleCookiesConditionObject', 
               'New-AzCdnDeliveryRuleHttpVersionConditionObject', 
               'New-AzCdnDeliveryRuleIsDeviceConditionObject', 
               'New-AzCdnDeliveryRuleObject', 
               'New-AzCdnDeliveryRulePostArgsConditionObject', 
               'New-AzCdnDeliveryRuleQueryStringConditionObject', 
               'New-AzCdnDeliveryRuleRemoteAddressConditionObject', 
               'New-AzCdnDeliveryRuleRequestBodyConditionObject', 
               'New-AzCdnDeliveryRuleRequestHeaderActionObject', 
               'New-AzCdnDeliveryRuleRequestHeaderConditionObject', 
               'New-AzCdnDeliveryRuleRequestMethodConditionObject', 
               'New-AzCdnDeliveryRuleRequestSchemeConditionObject', 
               'New-AzCdnDeliveryRuleRequestUriConditionObject', 
               'New-AzCdnDeliveryRuleResponseHeaderActionObject', 
               'New-AzCdnDeliveryRuleUrlFileExtensionConditionObject', 
               'New-AzCdnDeliveryRuleUrlFileNameConditionObject', 
               'New-AzCdnDeliveryRuleUrlPathConditionObject', 'New-AzCdnEndpoint', 
               'New-AzCdnHealthProbeParametersObject', 
               'New-AzCdnManagedHttpsParametersObject', 'New-AzCdnOrigin', 
               'New-AzCdnOriginGroup', 'New-AzCdnProfile', 
               'New-AzCdnResourceReferenceObject', 
               'New-AzCdnResponseBasedOriginErrorDetectionParametersObject', 
               'New-AzCdnUrlRedirectActionObject', 
               'New-AzCdnUrlRewriteActionObject', 
               'New-AzCdnUrlSigningActionObject', 
               'New-AzCdnUserManagedHttpsParametersObject', 
               'New-AzFrontDoorCdnCustomDomain', 
               'New-AzFrontDoorCdnCustomDomainTlsSettingParametersObject', 
               'New-AzFrontDoorCdnEndpoint', 'New-AzFrontDoorCdnOrigin', 
               'New-AzFrontDoorCdnOriginGroup', 
               'New-AzFrontDoorCdnOriginGroupHealthProbeSettingObject', 
               'New-AzFrontDoorCdnOriginGroupLoadBalancingSettingObject', 
               'New-AzFrontDoorCdnProfile', 
               'New-AzFrontDoorCdnResourceReferenceObject', 
               'New-AzFrontDoorCdnRoute', 'New-AzFrontDoorCdnRule', 
               'New-AzFrontDoorCdnRuleClientPortConditionObject', 
               'New-AzFrontDoorCdnRuleCookiesConditionObject', 
               'New-AzFrontDoorCdnRuleHostNameConditionObject', 
               'New-AzFrontDoorCdnRuleHttpVersionConditionObject', 
               'New-AzFrontDoorCdnRuleIsDeviceConditionObject', 
               'New-AzFrontDoorCdnRulePostArgsConditionObject', 
               'New-AzFrontDoorCdnRuleQueryStringConditionObject', 
               'New-AzFrontDoorCdnRuleRemoteAddressConditionObject', 
               'New-AzFrontDoorCdnRuleRequestBodyConditionObject', 
               'New-AzFrontDoorCdnRuleRequestHeaderActionObject', 
               'New-AzFrontDoorCdnRuleRequestHeaderConditionObject', 
               'New-AzFrontDoorCdnRuleRequestMethodConditionObject', 
               'New-AzFrontDoorCdnRuleRequestSchemeConditionObject', 
               'New-AzFrontDoorCdnRuleRequestUriConditionObject', 
               'New-AzFrontDoorCdnRuleResponseHeaderActionObject', 
               'New-AzFrontDoorCdnRuleRouteConfigurationOverrideActionObject', 
               'New-AzFrontDoorCdnRuleServerPortConditionObject', 
               'New-AzFrontDoorCdnRuleSet', 
               'New-AzFrontDoorCdnRuleSocketAddrConditionObject', 
               'New-AzFrontDoorCdnRuleSslProtocolConditionObject', 
               'New-AzFrontDoorCdnRuleUrlFileExtensionConditionObject', 
               'New-AzFrontDoorCdnRuleUrlFileNameConditionObject', 
               'New-AzFrontDoorCdnRuleUrlPathConditionObject', 
               'New-AzFrontDoorCdnRuleUrlRedirectActionObject', 
               'New-AzFrontDoorCdnRuleUrlRewriteActionObject', 
               'New-AzFrontDoorCdnRuleUrlSigningActionObject', 
               'New-AzFrontDoorCdnSecret', 
               'New-AzFrontDoorCdnSecretCustomerCertificateParametersObject', 
               'New-AzFrontDoorCdnSecretFirstPartyManagedCertificateParametersObject', 
               'New-AzFrontDoorCdnSecretManagedCertificateParametersObject', 
               'New-AzFrontDoorCdnSecretUrlSigningKeyParametersObject', 
               'New-AzFrontDoorCdnSecurityPolicy', 
               'New-AzFrontDoorCdnSecurityPolicyWebApplicationFirewallAssociationObject', 
               'New-AzFrontDoorCdnSecurityPolicyWebApplicationFirewallParametersObject', 
               'Remove-AzCdnCustomDomain', 'Remove-AzCdnEndpoint', 
               'Remove-AzCdnOrigin', 'Remove-AzCdnOriginGroup', 
               'Remove-AzCdnProfile', 'Remove-AzFrontDoorCdnCustomDomain', 
               'Remove-AzFrontDoorCdnEndpoint', 'Remove-AzFrontDoorCdnOrigin', 
               'Remove-AzFrontDoorCdnOriginGroup', 'Remove-AzFrontDoorCdnProfile', 
               'Remove-AzFrontDoorCdnRoute', 'Remove-AzFrontDoorCdnRule', 
               'Remove-AzFrontDoorCdnRuleSet', 'Remove-AzFrontDoorCdnSecret', 
               'Remove-AzFrontDoorCdnSecurityPolicy', 'Start-AzCdnEndpoint', 
               'Stop-AzCdnEndpoint', 'Test-AzCdnEndpointCustomDomain', 
               'Test-AzCdnNameAvailability', 'Test-AzCdnProbe', 
               'Test-AzFrontDoorCdnEndpointCustomDomain', 
               'Test-AzFrontDoorCdnEndpointNameAvailability', 
               'Test-AzFrontDoorCdnProfileHostNameAvailability', 
               'Update-AzCdnEndpoint', 'Update-AzCdnOrigin', 
               'Update-AzCdnOriginGroup', 'Update-AzCdnProfile', 
               'Update-AzFrontDoorCdnCustomDomain', 
               'Update-AzFrontDoorCdnCustomDomainValidationToken', 
               'Update-AzFrontDoorCdnEndpoint', 'Update-AzFrontDoorCdnOrigin', 
               'Update-AzFrontDoorCdnOriginGroup', 'Update-AzFrontDoorCdnProfile', 
               'Update-AzFrontDoorCdnRoute', 'Update-AzFrontDoorCdnRule', 
               'Update-AzFrontDoorCdnSecurityPolicy'

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
VariablesToExport = '*'

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = '*'

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
        Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'Cdn'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        # ReleaseNotes = ''

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

