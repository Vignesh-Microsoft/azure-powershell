
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
Creates a new workspace.
.Description
Creates a new workspace.
.Example
New-AzDatabricksWorkspace -Name workspace3miaeb -ResourceGroupName databricks-rg-rqb2yo -Location eastus -ManagedResourceGroupName databricks-group -Sku standard
.Example
$dlg = New-AzDelegation -Name dbrdl -ServiceName "Microsoft.Databricks/workspaces"
$rdpRule = New-AzNetworkSecurityRuleConfig -Name rdp-rule -Description "Allow RDP" -Access Allow -Protocol Tcp -Direction Inbound -Priority 100 -SourceAddressPrefix Internet -SourcePortRange * -DestinationAddressPrefix * -DestinationPortRange 3389
$networkSecurityGroup = New-AzNetworkSecurityGroup -ResourceGroupName databricks-rg-rqb2yo -Location eastus -Name nsg-test -SecurityRules $rdpRule
$privSubnet = New-AzVirtualNetworkSubnetConfig -Name priv-sub -AddressPrefix "10.0.1.0/24" -NetworkSecurityGroup $networkSecurityGroup -Delegation $dlg
$pubSubnet = New-AzVirtualNetworkSubnetConfig -Name pub-sub  -AddressPrefix "10.0.2.0/24" -NetworkSecurityGroup $networkSecurityGroup -Delegation $dlg
$testVN = New-AzVirtualNetwork -Name testvn -ResourceGroupName databricks-rg-rqb2yo -Location eastus -AddressPrefix "10.0.0.0/16" -Subnet $privSubnet,$pubSubnet
New-AzDatabricksWorkspace -Name workspace3miaeb-with-custom-vn -ResourceGroupName databricks-rg-rqb2yo -Location eastus -VirtualNetworkId $testVN.Id -PrivateSubnetName $privSubnet.Name -PublicSubnetName $pubSubnet.Name -Sku standard
.Example
New-AzDatabricksWorkspace -Name workspace3miaeb -ResourceGroupName databricks-rg-rqb2yo -PrepareEncryption -Location "East US 2 EUAP" -Sku premium

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IWorkspace
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.IDatabricksIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IWorkspace
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

AUTHORIZATION <IWorkspaceProviderAuthorization[]>: The workspace provider authorizations.
  PrincipalId <String>: The provider's principal identifier. This is the identity that the provider will use to call ARM to manage the workspace resources.
  RoleDefinitionId <String>: The provider's role definition identifier. This role will define all the permissions that the provider must have on the workspace's container resource group. This role definition cannot have permission to delete the resource group.

INPUTOBJECT <IDatabricksIdentity>: Identity Parameter
  [ConnectorName <String>]: The name of the azure databricks accessConnector.
  [GroupId <String>]: The name of the private link resource
  [Id <String>]: Resource identity path
  [PeeringName <String>]: The name of the workspace vNet peering.
  [PrivateEndpointConnectionName <String>]: The name of the private endpoint connection
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SubscriptionId <String>]: The ID of the target subscription.
  [WorkspaceName <String>]: The name of the workspace.

PARAMETER <IWorkspace>: Information about workspace.
  Location <String>: The geo-location where the resource lives
  ManagedResourceGroupId <String>: The managed resource group Id.
  [Tag <ITrackedResourceTags>]: Resource tags.
    [(Any) <String>]: This indicates any property can be added to this object.
  [AmlWorkspaceIdValue <String>]: The value which should be used for this field.
  [Authorization <IWorkspaceProviderAuthorization[]>]: The workspace provider authorizations.
    PrincipalId <String>: The provider's principal identifier. This is the identity that the provider will use to call ARM to manage the workspace resources.
    RoleDefinitionId <String>: The provider's role definition identifier. This role will define all the permissions that the provider must have on the workspace's container resource group. This role definition cannot have permission to delete the resource group.
  [CustomPrivateSubnetNameValue <String>]: The value which should be used for this field.
  [CustomPublicSubnetNameValue <String>]: The value which should be used for this field.
  [CustomVirtualNetworkIdValue <String>]: The value which should be used for this field.
  [EnableNoPublicIP <Boolean?>]: The value which should be used for this field.
  [EncryptionKeyName <String>]: The name of KeyVault key.
  [EncryptionKeySource <KeySource?>]: The encryption keySource (provider). Possible values (case-insensitive):  Default, Microsoft.Keyvault
  [EncryptionKeyVaultUri <String>]: The Uri of KeyVault.
  [EncryptionKeyVersion <String>]: The version of KeyVault key.
  [KeyVaultPropertyKeyName <String>]: The name of KeyVault key.
  [KeyVaultPropertyKeyVaultUri <String>]: The Uri of KeyVault.
  [KeyVaultPropertyKeyVersion <String>]: The version of KeyVault key.
  [LoadBalancerBackendPoolNameValue <String>]: The value which should be used for this field.
  [LoadBalancerIdValue <String>]: The value which should be used for this field.
  [NatGatewayNameValue <String>]: The value which should be used for this field.
  [PrepareEncryption <Boolean?>]: The value which should be used for this field.
  [PublicIPNameValue <String>]: The value which should be used for this field.
  [PublicNetworkAccess <PublicNetworkAccess?>]: The network access type for accessing workspace. Set value to disabled to access workspace only via private link.
  [RequireInfrastructureEncryption <Boolean?>]: The value which should be used for this field.
  [RequiredNsgRule <RequiredNsgRules?>]: Gets or sets a value indicating whether data plane (clusters) to control plane communication happen over private endpoint. Supported values are 'AllRules' and 'NoAzureDatabricksRules'. 'NoAzureServiceRules' value is for internal use only.
  [ResourceTagValue <IAny>]: The value which should be used for this field.
  [SkuName <String>]: The SKU name.
  [SkuTier <String>]: The SKU tier.
  [StorageAccountNameValue <String>]: The value which should be used for this field.
  [StorageAccountSkuNameValue <String>]: The value which should be used for this field.
  [SystemDataCreatedAt <DateTime?>]: The timestamp of resource creation (UTC).
  [SystemDataCreatedBy <String>]: The identity that created the resource.
  [SystemDataCreatedByType <CreatedByType?>]: The type of identity that created the resource.
  [SystemDataLastModifiedAt <DateTime?>]: The timestamp of resource last modification (UTC)
  [SystemDataLastModifiedBy <String>]: The identity that last modified the resource.
  [SystemDataLastModifiedByType <CreatedByType?>]: The type of identity that last modified the resource.
  [UiDefinitionUri <String>]: The blob URI where the UI definition file is located.
  [VnetAddressPrefixValue <String>]: The value which should be used for this field.
.Link
https://learn.microsoft.com/powershell/module/az.databricks/new-azdatabricksworkspace
#>
function New-AzDatabricksWorkspace {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IWorkspace])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Alias('WorkspaceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${Name},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.IDatabricksIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The managed resource group Id.
    ${ManagedResourceGroupId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The value which should be used for this field.
    ${AmlWorkspaceId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IWorkspaceProviderAuthorization[]]
    # The workspace provider authorizations.
    # To construct, see NOTES section for AUTHORIZATION properties and create a hash table.
    ${Authorization},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # The value which should be used for this field.
    ${EnableNoPublicIP},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The name of KeyVault key.
    ${EncryptionKeyName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.KeySource])]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.KeySource]
    # The encryption keySource (provider).
    # Possible values (case-insensitive): Default, Microsoft.Keyvault
    ${EncryptionKeySource},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The Uri of KeyVault.
    ${EncryptionKeyVaultUri},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The version of KeyVault key.
    ${EncryptionKeyVersion},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The name of KeyVault key.
    ${KeyVaultKeyName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The version of KeyVault key.
    ${KeyVaultKeyVersion},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The Uri of KeyVault.
    ${KeyVaultUri},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The value which should be used for this field.
    ${LoadBalancerBackendPoolName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The value which should be used for this field.
    ${LoadBalancerId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The value which should be used for this field.
    ${NatGatewayName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # The value which should be used for this field.
    ${PrepareEncryption},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The value which should be used for this field.
    ${PrivateSubnetName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The value which should be used for this field.
    ${PublicIPName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PublicNetworkAccess])]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PublicNetworkAccess]
    # The network access type for accessing workspace.
    # Set value to disabled to access workspace only via private link.
    ${PublicNetworkAccess},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The value which should be used for this field.
    ${PublicSubnetName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # The value which should be used for this field.
    ${RequireInfrastructureEncryption},

    [Parameter(ParameterSetName='CreateExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.RequiredNsgRules])]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.RequiredNsgRules]
    # Gets or sets a value indicating whether data plane (clusters) to control plane communication happen over private endpoint.
    # Supported values are 'AllRules' and 'NoAzureDatabricksRules'.
    # 'NoAzureServiceRules' value is for internal use only.
    ${RequiredNsgRule},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The SKU name.
    ${Sku},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The SKU tier.
    ${SkuTier},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The value which should be used for this field.
    ${StorageAccountName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The value which should be used for this field.
    ${StorageAccountSku},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The blob URI where the UI definition file is located.
    ${UiDefinitionUri},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The value which should be used for this field.
    ${VirtualNetworkId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [System.String]
    # The value which should be used for this field.
    ${VnetAddressPrefix},

    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IWorkspace]
    # Information about workspace.
    # To construct, see NOTES section for PARAMETER properties and create a hash table.
    ${Parameter},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Category('Runtime')]
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
            CreateExpanded = 'Az.Databricks.private\New-AzDatabricksWorkspace_CreateExpanded';
            CreateViaIdentity = 'Az.Databricks.private\New-AzDatabricksWorkspace_CreateViaIdentity';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
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
