
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
Get a filter
.Description
Get a filter
.Example
PS C:\> Get-AzPurviewFilter -Endpoint 'https://brs-2.purview.azure.com/' -DataSourceName 'DataScanTestData' -ScanName 'Scan1ForDemo'

ExcludeUriPrefix  : {https://foo.file.core.windows.net/share1/user/temp}
Id                : datasources/DataScanTestData/scans/Scan1ForDemo/filters/custom
IncludeUriPrefix  : {https://foo.file.core.windows.net/share1/user,
                    https://foo.file.core.windows.net/share1/aggregated}
Name              : custom

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IFilter
.Link
https://docs.microsoft.com/powershell/module/az.purview/get-azpurviewfilter
#>
function Get-AzPurviewFilter {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IFilter])]
[CmdletBinding(DefaultParameterSetName='Get', PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Uri')]
    [System.String]
    # The scanning endpoint of your purview account.
    # Example: https://{accountName}.purview.azure.com
    ${Endpoint},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Path')]
    [System.String]
    # .
    ${DataSourceName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Path')]
    [System.String]
    # .
    ${ScanName},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Runtime')]
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
        $mapping = @{
            Get = 'Az.Purviewdata.private\Get-AzPurviewFilter_Get';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
