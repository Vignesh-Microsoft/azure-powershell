
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
Create or update private store collection
.Description
Create or update private store collection
.Example
PS C:\> New-AzMarketplacePrivateStoreCollection -CollectionName test -CollectionId fdb889a1-cf3e-49f0-95b8-2bb012fa01f1 -PrivateStoreId 3ac32d8c-e888-4dc6-b4ff-be4d755af13a -SubscriptionsList 7f5402e4-e8f4-46bd-9bd1-8d27866a606b

Name                                 SystemDataCreatedAt    SystemDataCreatedBy SystemDataCreatedByType SystemDataLastModifiedAt SystemDataLastModifiedBy SystemDataLastModifiedByType
----                                 -------------------    ------------------- ----------------------- ------------------------ ------------------------ ----------------------------
fdb889a1-cf3e-49f0-95b8-2bb012fa01f1 12/13/2021 11:12:27 AM                     User                    12/13/2021 11:12:27 AM                            User

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.ICollection
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IMarketplaceIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.ICollection
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IMarketplaceIdentity>: Identity Parameter
  [AdminRequestApprovalId <String>]: The admin request approval ID to get create or update
  [CollectionId <String>]: The collection ID
  [Id <String>]: Resource identity path
  [OfferId <String>]: The offer ID to update or delete
  [PrivateStoreId <String>]: The store ID - must use the tenant ID
  [RequestApprovalId <String>]: The request approval ID to get create or update

PAYLOAD <ICollection>: The Collection data structure.
  [SystemDataCreatedAt <DateTime?>]: The timestamp of resource creation (UTC)
  [SystemDataCreatedBy <String>]: The identity that created the resource.
  [SystemDataCreatedByType <IdentityType?>]: The type of identity that created the resource
  [SystemDataLastModifiedAt <DateTime?>]: The timestamp of resource last modification (UTC)
  [SystemDataLastModifiedBy <String>]: The identity that last modified the resource.
  [SystemDataLastModifiedByType <IdentityType?>]: The type of identity that last modified the resource
  [AllSubscription <Boolean?>]: Indicating whether all subscriptions are selected (=true) or not (=false).
  [Claim <String>]: Gets or sets the association with Commercial's Billing Account.
  [CollectionName <String>]: Gets or sets collection name.
  [Enabled <Boolean?>]: Indicating whether the collection is enabled or disabled.
  [SubscriptionsList <String[]>]: Gets or sets subscription ids list. Empty list indicates all subscriptions are selected, null indicates no update is done, explicit list indicates the explicit selected subscriptions. On insert, null is considered as bad request
.Link
https://learn.microsoft.com/powershell/module/az.marketplace/new-azmarketplaceprivatestorecollection
#>
function New-AzMarketplacePrivateStoreCollection {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.ICollection])]
[CmdletBinding(DefaultParameterSetName='CreateViaIdentity', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IMarketplaceIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.ICollection]
    # The Collection data structure.
    # To construct, see NOTES section for PAYLOAD properties and create a hash table.
    ${Payload},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
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
            CreateViaIdentity = 'Az.Marketplace.private\New-AzMarketplacePrivateStoreCollection_CreateViaIdentity';
        }

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
