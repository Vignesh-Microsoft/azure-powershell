
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
Return a reservation.
.Description
Return a reservation.
.Example
$orderId = "50000000-aaaa-bbbb-cccc-100000000003"
$fullyQualifiedId = "/providers/microsoft.capacity/reservationOrders/50000000-aaaa-bbbb-cccc-100000000003/reservations/30000000-aaaa-bbbb-cccc-100000000003"
$fullyQualifiedOrderId = "/providers/microsoft.capacity/reservationOrders/50000000-aaaa-bbbb-cccc-100000000003"

Invoke-AzReservationCalculateRefund -ReservationOrderId $orderId -ReservationToReturnQuantity 1 -ReservationToReturnReservationId $fullyQualifiedId  -Id $fullyQualifiedOrderId -Scope "Reservation"

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IRefundRequest
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IRefundResponse
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IRefundRequest>: .
  [ReservationToReturnQuantity <Int32?>]: Quantity to be returned. Must be greater than zero.
  [ReservationToReturnReservationId <String>]: Fully qualified identifier of the Reservation being returned
  [ReturnReason <String>]: The reason of returning the reservation
  [Scope <String>]: The scope of the refund, e.g. Reservation
  [SessionId <String>]: SessionId that was returned by CalculateRefund API.

INPUTOBJECT <IReservationsIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [ReservationId <String>]: Id of the Reservation Item
  [ReservationOrderId <String>]: Order Id of the reservation
  [SubscriptionId <String>]: Id of the subscription
.Link
https://learn.microsoft.com/powershell/module/az.reservations/invoke-azreservationreturn
#>
function Invoke-AzReservationReturn {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IRefundResponse])]
[CmdletBinding(DefaultParameterSetName='PostExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Post', Mandatory)]
    [Parameter(ParameterSetName='PostExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Path')]
    [System.String]
    # Order Id of the reservation
    ${ReservationOrderId},

    [Parameter(ParameterSetName='PostViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PostViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Post', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PostViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IRefundRequest]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.Int32]
    # Quantity to be returned.
    # Must be greater than zero.
    ${ReservationToReturnQuantity},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Fully qualified identifier of the Reservation being returned
    ${ReservationToReturnReservationId},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # The reason of returning the reservation
    ${ReturnReason},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # The scope of the refund, e.g.
    # Reservation
    ${Scope},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # SessionId that was returned by CalculateRefund API.
    ${SessionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
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
            [Microsoft.Azure.PowerShell.Cmdlets.Reservations.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            Post = 'Az.Reservations.private\Invoke-AzReservationReturn_Post';
            PostExpanded = 'Az.Reservations.private\Invoke-AzReservationReturn_PostExpanded';
            PostViaIdentity = 'Az.Reservations.private\Invoke-AzReservationReturn_PostViaIdentity';
            PostViaIdentityExpanded = 'Az.Reservations.private\Invoke-AzReservationReturn_PostViaIdentityExpanded';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [Microsoft.Azure.PowerShell.Cmdlets.Reservations.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
