
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
Create an in-memory object for EligibleApprover.
.Description
Create an in-memory object for EligibleApprover.
.Example
PS C:\>  New-AzManagedServicesEligibleApproverObject -PrincipalId "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" -PrincipalIdDisplayName "Approvers group"

PrincipalId                          PrincipalIdDisplayName
-----------                          ----------------------
xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx Approvers group

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.EligibleApprover
.Link
https://docs.microsoft.com/powershell/module/az.ManagedServices/new-AzManagedServicesEligibleApproverObject
#>
function New-AzManagedServicesEligibleApproverObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.EligibleApprover])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Category('Body')]
    [System.String]
    # The identifier of the Azure Active Directory principal.
    ${PrincipalId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Category('Body')]
    [System.String]
    # The display name of the Azure Active Directory principal.
    ${PrincipalIdDisplayName}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            __AllParameterSets = 'Az.ManagedServices.custom\New-AzManagedServicesEligibleApproverObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
