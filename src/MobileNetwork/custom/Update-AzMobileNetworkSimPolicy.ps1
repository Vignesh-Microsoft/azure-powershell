
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
Updates SIM policy.
.Description
Updates SIM policy.
.Example
Update-AzMobileNetworkSimPolicy -MobileNetworkName azps-mn -SimPolicyName azps-mn-simpolicy -ResourceGroupName azps_test_group -Tag @{"abc"="123"}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IMobileNetworkIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimPolicy
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IMobileNetworkIdentity>: Identity Parameter
  [AttachedDataNetworkName <String>]: The name of the attached data network.
  [DataNetworkName <String>]: The name of the data network.
  [Id <String>]: Resource identity path
  [MobileNetworkName <String>]: The name of the mobile network.
  [PacketCoreControlPlaneName <String>]: The name of the packet core control plane.
  [PacketCoreDataPlaneName <String>]: The name of the packet core data plane.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ServiceName <String>]: The name of the service. You must not use any of the following reserved strings - 'default', 'requested' or 'service'
  [SimGroupName <String>]: The name of the SIM Group.
  [SimName <String>]: The name of the SIM.
  [SimPolicyName <String>]: The name of the SIM policy.
  [SiteName <String>]: The name of the mobile network site.
  [SliceName <String>]: The name of the network slice.
  [SubscriptionId <String>]: The ID of the target subscription.
  [VersionName <String>]: The name of the packet core control plane version.
.Link
https://learn.microsoft.com/powershell/module/az.mobilenetwork/update-azmobilenetworksimpolicy
#>
function Update-AzMobileNetworkSimPolicy {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimPolicy])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
    [System.String]
    # The name of the mobile network.
    ${MobileNetworkName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
    [System.String]
    # The name of the SIM policy.
    ${SimPolicyName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # Slice resource ID.
    ${DefaultSliceId},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISliceConfiguration[]]
    # The allowed slices and the settings to use for them.
    # The list must not contain duplicate items and must contain at least one item.
    # To construct, see NOTES section for SLICECONFIGURATION properties and create a hash table.
    ${SliceConfiguration},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # Downlink bit rate.
    ${UeAmbrDownlink},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # Uplink bit rate.
    ${UeAmbrUplink},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.Int32]
    # Interval for the UE periodic registration update procedure, in seconds.
    ${RegistrationTimer},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.Int32]
    # RAT/Frequency Selection Priority Index, defined in 3GPP TS 36.413.
    # This is an optional setting and by default is unspecified.
    ${RfspIndex},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ITagsObjectTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

    process {
        try {
            $simPolicy = Get-AzMobileNetworkSimPolicy -MobileNetworkName $PSBoundParameters.MobileNetworkName -ResourceGroupName $PSBoundParameters.ResourceGroupName -Name $PSBoundParameters.SimPolicyName
            $PSBoundParameters.Add('Location', $simPolicy.Location)

            # README.md file Line 142 ReNamed DefaultSlouseId -> DefaultSliceId
            if (!$PSBoundParameters.ContainsKey('DefaultSliceId') -and $simPolicy.DefaultSlouseId) {
                $PSBoundParameters.DefaultSliceId = $simPolicy.DefaultSlouseId
            }
            if (!$PSBoundParameters.ContainsKey('SliceConfiguration') -and $simPolicy.SliceConfiguration) {
                $PSBoundParameters.SliceConfiguration = $simPolicy.SliceConfiguration
            }
            if (!$PSBoundParameters.ContainsKey('UeAmbrDownlink') -and $simPolicy.UeAmbrDownlink) {
                $PSBoundParameters.UeAmbrDownlink = $simPolicy.UeAmbrDownlink
            }
            if (!$PSBoundParameters.ContainsKey('UeAmbrUplink') -and $simPolicy.UeAmbrUplink) {
                $PSBoundParameters.UeAmbrUplink = $simPolicy.UeAmbrUplink
            }
            if (!$PSBoundParameters.ContainsKey('RegistrationTimer') -and "$simPolicy.RegistrationTimer") {
                $PSBoundParameters.RegistrationTimer = $simPolicy.RegistrationTimer
            }
            if (!$PSBoundParameters.ContainsKey('RfspIndex') -and $simPolicy.RfspIndex) {
                $PSBoundParameters.RfspIndex = $simPolicy.RfspIndex
            }

            if (!$PSBoundParameters.ContainsKey('Tag')) {
                $PSBoundParameters.Tag = $simPolicy.Tag
            }

            Az.MobileNetwork.private\New-AzMobileNetworkSimPolicy_CreateExpanded @PSBoundParameters
        }
        catch {
            throw
        }
    }
}
