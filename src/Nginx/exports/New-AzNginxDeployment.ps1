
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
Create or update the Nginx deployment
.Description
Create or update the Nginx deployment
.Example
New-AzNginxDeployment -Name nginx-test -ResourceGroupName nginx-test-rg -Location westcentralus -NetworkProfile $networkProfile -SkuName preview_Monthly_gmz7xq9ge3py

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxDeployment
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

NETWORKPROFILE <INginxNetworkProfile>: .
  [FrontEndIPConfiguration <INginxFrontendIPConfiguration>]: 
    [PrivateIPAddress <INginxPrivateIPAddress[]>]: 
      [PrivateIPAddress <String>]: 
      [PrivateIPAllocationMethod <NginxPrivateIPAllocationMethod?>]: 
      [SubnetId <String>]: 
    [PublicIPAddress <INginxPublicIPAddress[]>]: 
      [Id <String>]: 
  [NetworkInterfaceConfiguration <INginxNetworkInterfaceConfiguration>]: 
    [SubnetId <String>]: 
.Link
https://learn.microsoft.com/powershell/module/az.nginx/new-aznginxdeployment
#>
function New-AzNginxDeployment {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxDeployment])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('DeploymentName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Path')]
    [System.String]
    # The name of targeted Nginx deployment
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Body')]
    [System.String]
    # .
    ${Location},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxNetworkProfile]
    # .
    # To construct, see NOTES section for NETWORKPROFILE properties and create a hash table.
    ${NetworkProfile},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Body')]
    [System.String]
    # Name of the SKU.
    ${SkuName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${EnableDiagnosticsSupport},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Nginx.Support.IdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Support.IdentityType]
    # .
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.IIdentityPropertiesUserAssignedIdentities]))]
    [System.Collections.Hashtable]
    # Dictionary of <UserIdentityProperties>
    ${IdentityUserAssignedIdentity},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Body')]
    [System.String]
    # The managed resource group to deploy VNet injection related network resources.
    ${ManagedResourceGroup},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Body')]
    [System.String]
    # .
    ${StorageAccountContainerName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Body')]
    [System.String]
    # .
    ${StorageAccountName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20220801.INginxDeploymentTags]))]
    [System.Collections.Hashtable]
    # Dictionary of <string>
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Category('Runtime')]
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
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $Host.Version.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.Nginx.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            CreateExpanded = 'Az.Nginx.private\New-AzNginxDeployment_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [Microsoft.Azure.PowerShell.Cmdlets.Nginx.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
