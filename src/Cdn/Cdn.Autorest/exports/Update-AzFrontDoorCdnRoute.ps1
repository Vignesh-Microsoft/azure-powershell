
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Updates an existing route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint.
.Description
Updates an existing route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICdnIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRoute
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

CUSTOMDOMAIN <IActivatedResourceReference[]>: Domains referenced by this endpoint.
  [Id <String>]: Resource ID.

INPUTOBJECT <ICdnIdentity>: Identity Parameter
  [CustomDomainName <String>]: Name of the domain under the profile which is unique globally.
  [EndpointName <String>]: Name of the endpoint under the profile which is unique globally.
  [Id <String>]: Resource identity path
  [OriginGroupName <String>]: Name of the origin group which is unique within the endpoint.
  [OriginName <String>]: Name of the origin which is unique within the profile.
  [PolicyName <String>]: The name of the CdnWebApplicationFirewallPolicy.
  [ProfileName <String>]: Name of the Azure Front Door Standard or Azure Front Door Premium or CDN profile which is unique within the resource group.
  [ResourceGroupName <String>]: Name of the Resource group within the Azure subscription.
  [RouteName <String>]: Name of the routing rule.
  [RuleName <String>]: Name of the delivery rule which is unique within the endpoint.
  [RuleSetName <String>]: Name of the rule set under the profile which is unique globally.
  [SecretName <String>]: Name of the Secret under the profile.
  [SecurityPolicyName <String>]: Name of the security policy under the profile.
  [SubscriptionId <String>]: Azure Subscription ID.

RULESET <IResourceReference[]>: rule sets referenced by this endpoint.
  [Id <String>]: Resource ID.
.Link
https://docs.microsoft.com/powershell/module/az.cdn/update-azfrontdoorcdnroute
#>
function Update-AzFrontDoorCdnRoute {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRoute])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
    [System.String]
    # Name of the endpoint under the profile which is unique globally.
    ${EndpointName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('RouteName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
    [System.String]
    # Name of the routing rule.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
    [System.String]
    # Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group.
    ${ProfileName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
    [System.String]
    # Name of the Resource group within the Azure subscription.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Azure Subscription ID.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICdnIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.String]
    # query parameters to include or exclude (comma separated).
    ${CacheConfigurationQueryParameter},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdQueryStringCachingBehavior])]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdQueryStringCachingBehavior]
    # Defines how Frontdoor caches requests that include query strings.
    # You can ignore any query strings when caching, ignore specific query strings, cache every request with a unique URL, or cache specific query strings.
    ${CacheConfigurationQueryStringCachingBehavior},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.String[]]
    # List of content types on which compression applies.
    # The value should be a valid MIME type.
    ${CompressionSettingContentTypesToCompress},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether content compression is enabled on AzureFrontDoor.
    # Default value is false.
    # If compression is enabled, content will be served as compressed if user requests for a compressed version.
    # Content won't be compressed on AzureFrontDoor when requested content is smaller than 1 byte or larger than 1 MB.
    ${CompressionSettingIsCompressionEnabled},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IActivatedResourceReference[]]
    # Domains referenced by this endpoint.
    # To construct, see NOTES section for CUSTOMDOMAIN properties and create a hash table.
    ${CustomDomain},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState])]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState]
    # Whether to enable use of this rule.
    # Permitted values are 'Enabled' or 'Disabled'
    ${EnabledState},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ForwardingProtocol])]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ForwardingProtocol]
    # Protocol this rule will use when forwarding traffic to backends.
    ${ForwardingProtocol},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HttpsRedirect])]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HttpsRedirect]
    # Whether to automatically redirect HTTP traffic to HTTPS traffic.
    # Note that this is a easy way to set up this rule and it will be the first rule that gets executed.
    ${HttpsRedirect},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LinkToDefaultDomain])]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.LinkToDefaultDomain]
    # whether this route will be linked to the default endpoint domain.
    ${LinkToDefaultDomain},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.String]
    # Resource ID.
    ${OriginGroupId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.String]
    # A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g.
    # contoso.cloudapp.net/originpath.
    ${OriginPath},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.String[]]
    # The route patterns of the rule.
    ${PatternsToMatch},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference[]]
    # rule sets referenced by this endpoint.
    # To construct, see NOTES section for RULESET properties and create a hash table.
    ${RuleSet},

    [Parameter()]
    [AllowEmptyCollection()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdEndpointProtocols])]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdEndpointProtocols[]]
    # List of supported protocols for this route.
    ${SupportedProtocol},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $Host.Runspace.Version.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.Cdn.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            UpdateExpanded = 'Az.Cdn.private\Update-AzFrontDoorCdnRoute_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.Cdn.private\Update-AzFrontDoorCdnRoute_UpdateViaIdentityExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.Cdn.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
