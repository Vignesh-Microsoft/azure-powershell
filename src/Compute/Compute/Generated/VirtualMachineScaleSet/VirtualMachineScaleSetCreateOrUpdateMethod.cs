//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.Common.Strategies;
using Microsoft.Azure.Commands.Compute.Strategies;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.Azure.Commands.Compute.Common;
using AutoMapper;
using Microsoft.Azure.Commands.Compute.Strategies.ComputeRp;
using System.Linq;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [GenericBreakingChange("Starting on 10/12/2022 the \"New-AzVmss\" cmdlet will deploy with the Trusted Launch configuration by default. To know more about Trusted Launch, please visit https://docs.microsoft.com/en-us/azure/virtual-machines/trusted-launch")]
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "Vmss", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [OutputType(typeof(PSVirtualMachineScaleSet))]
    public partial class NewAzureRmVmss : ComputeAutomationBaseCmdlet
    {
        public const string SimpleParameterSet = "SimpleParameterSet", DefaultParameter = "DefaultParameter";
        public const int vmssFlexibleOrchestrationModeNetworkAPIVersionMinimumInt = 20201101;
        public const string vmssFlexibleOrchestrationModeNetworkAPIVersionMinimum = "2020-11-01";

        public override void ExecuteCmdlet()
        {
            if (this.IsParameterBound(c => c.UserData))
            {
                if (!ValidateBase64EncodedString.ValidateStringIsBase64Encoded(this.UserData))
                {
                    this.UserData = ValidateBase64EncodedString.EncodeStringToBase64(this.UserData);
                    this.WriteInformation(ValidateBase64EncodedString.UserDataEncodeNotification, new string[] { "PSHOST" });
                }
            }

            base.ExecuteCmdlet();
            switch (ParameterSetName)
            {
                case SimpleParameterSet:
                    this.StartAndWait(SimpleParameterSetExecuteCmdlet);
                    break;
                default:
                    ExecuteClientAction(() =>
                    {
                        if (ShouldProcess(this.VMScaleSetName, VerbsCommon.New))
                        {
                            string resourceGroupName = this.ResourceGroupName;
                            string vmScaleSetName = this.VMScaleSetName;
                            VirtualMachineScaleSet parameters = new VirtualMachineScaleSet();
                            ComputeAutomationAutoMapperProfile.Mapper.Map<PSVirtualMachineScaleSet, VirtualMachineScaleSet>(this.VirtualMachineScaleSet, parameters);
                            if (parameters?.VirtualMachineProfile?.StorageProfile?.ImageReference?.Version?.ToLower() != "latest")
                            {
                                WriteWarning("You are deploying VMSS pinned to a specific image version from Azure Marketplace. \n" +
                                    "Consider using \"latest\" as the image version. This allows VMSS to auto upgrade when a newer version is available.");
                            }

                            if (parameters?.OrchestrationMode == "Flexible")
                            {
                                if (parameters?.VirtualMachineProfile?.NetworkProfile?.NetworkInterfaceConfigurations != null)
                                {
                                    foreach (var nicConfig in parameters.VirtualMachineProfile.NetworkProfile.NetworkInterfaceConfigurations)
                                    {
                                        if (nicConfig.IpConfigurations != null)
                                        {
                                            foreach (var ipConfig in nicConfig.IpConfigurations)
                                            {
                                                ipConfig.LoadBalancerInboundNatPools = null;
                                            }
                                        }
                                    }
                                }

                                parameters.UpgradePolicy = null;

                                flexibleOrchestrationModeDefaultParameters(parameters);
                                checkFlexibleOrchestrationModeParamsDefaultParamSet(parameters);
                            }

                            if (parameters.VirtualMachineProfile.SecurityProfile.SecurityType == "TrustedLaunch" || parameters.VirtualMachineProfile.SecurityProfile.SecurityType =="ConfidentialVM")
                            {
                                if (parameters.VirtualMachineProfile.SecurityProfile.UefiSettings != null)
                                {
                                    parameters.VirtualMachineProfile.SecurityProfile.UefiSettings.SecureBootEnabled = parameters.VirtualMachineProfile.SecurityProfile.UefiSettings.SecureBootEnabled != null ? parameters.VirtualMachineProfile.SecurityProfile.UefiSettings.SecureBootEnabled : true;
                                    parameters.VirtualMachineProfile.SecurityProfile.UefiSettings.VTpmEnabled = parameters.VirtualMachineProfile.SecurityProfile.UefiSettings.VTpmEnabled != null ? parameters.VirtualMachineProfile.SecurityProfile.UefiSettings.VTpmEnabled : true;

                                }
                                else
                                {
                                    parameters.VirtualMachineProfile.SecurityProfile.UefiSettings = new UefiSettings(true, true);
                                }
                            }

                            // For Cross-tenant RBAC sharing
                            Dictionary<string, List<string>> auxAuthHeader = null;
                            if (!string.IsNullOrEmpty(parameters.VirtualMachineProfile?.StorageProfile?.ImageReference?.Id))
                            {
                                var resourceId = ResourceId.TryParse(parameters.VirtualMachineProfile?.StorageProfile.ImageReference.Id);

                                if (string.Equals(ComputeStrategy.Namespace, resourceId?.ResourceType?.Namespace, StringComparison.OrdinalIgnoreCase)
                                 && string.Equals("galleries", resourceId?.ResourceType?.Provider, StringComparison.OrdinalIgnoreCase)
                                 && !string.Equals(this.ComputeClient?.ComputeManagementClient?.SubscriptionId, resourceId?.SubscriptionId, StringComparison.OrdinalIgnoreCase))
                                {
                                    List<string> resourceIds = new List<string>();
                                    resourceIds.Add(parameters.VirtualMachineProfile?.StorageProfile.ImageReference.Id);
                                    var auxHeaderDictionary = GetAuxilaryAuthHeaderFromResourceIds(resourceIds);
                                    if (auxHeaderDictionary != null && auxHeaderDictionary.Count > 0)
                                    {
                                        auxAuthHeader = new Dictionary<string, List<string>>(auxHeaderDictionary);
                                    }
                                }
                            }
                            // END: For Cross-tenant RBAC sharing
                            // GuestAttestation install scenario
                            if (shouldGuestAttestationExtBeInstalled(parameters) &&
                               parameters.Identity == null)
                            {
                                parameters.Identity = new VirtualMachineScaleSetIdentity(null, null, Microsoft.Azure.Management.Compute.Models.ResourceIdentityType.SystemAssigned, null);
                            }

                            VirtualMachineScaleSet result;
                            if (auxAuthHeader != null)
                            {
                                var res = VirtualMachineScaleSetsClient.CreateOrUpdateWithHttpMessagesAsync(
                                        resourceGroupName,
                                        vmScaleSetName,
                                        parameters,
                                        auxAuthHeader).GetAwaiter().GetResult();

                                result = res.Body;
                            }
                            else
                            {
                                result = VirtualMachineScaleSetsClient.CreateOrUpdate(resourceGroupName, vmScaleSetName, parameters);
                            }


                            //Guest Attestation extension defaulting behavior check.
                            if (shouldGuestAttestationExtBeInstalled(parameters))
                            {
                                var extensionDirect = new VirtualMachineScaleSetExtension();

                                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                                {
                                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                                }

                                // ExtensionProfile
                                if (this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile == null)
                                {
                                    this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile = new PSVirtualMachineScaleSetExtensionProfile();
                                }

                                // Extensions
                                if (this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile.Extensions == null)
                                {
                                    this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile.Extensions = new List<PSVirtualMachineScaleSetExtension>();
                                }

                                if (parameters.VirtualMachineProfile.OsProfile != null)
                                {
                                    if (parameters.VirtualMachineProfile.OsProfile.LinuxConfiguration != null)
                                    {

                                        extensionDirect.Name = "GuestAttestation";
                                        extensionDirect.Publisher = "Microsoft.Azure.Security.LinuxAttestation";
                                        extensionDirect.Type1 = "GuestAttestation";
                                        extensionDirect.TypeHandlerVersion = "1.0";
                                    }
                                    else
                                    {

                                        extensionDirect.Name = "GuestAttestation";
                                        extensionDirect.Publisher = "Microsoft.Azure.Security.WindowsAttestation";
                                        extensionDirect.Type1 = "GuestAttestation";
                                        extensionDirect.TypeHandlerVersion = "1.0";
                                    }
                                }

                                VirtualMachineScaleSetUpdate parametersupdate = new VirtualMachineScaleSetUpdate();
                                parametersupdate.VirtualMachineProfile = new VirtualMachineScaleSetUpdateVMProfile();
                                parametersupdate.VirtualMachineProfile.ExtensionProfile = new VirtualMachineScaleSetExtensionProfile();
                                parametersupdate.VirtualMachineProfile.ExtensionProfile.Extensions = new List<VirtualMachineScaleSetExtension>();
                                parametersupdate.VirtualMachineProfile.ExtensionProfile.Extensions.Add(extensionDirect);
                                result = VirtualMachineScaleSetsClient.Update(resourceGroupName, vmScaleSetName, parametersupdate);

                                var vmssVmExtParams = new VirtualMachineScaleSetVMExtension();
                                var resultVmssVm = VirtualMachineScaleSetVMsClient.List(resourceGroupName, vmScaleSetName);
                                var resultList = resultVmssVm.ToList();
                                var nextPageLink = resultVmssVm.NextPageLink;
                                while (!string.IsNullOrEmpty(nextPageLink))
                                {
                                    var pageResult = VirtualMachineScaleSetVMsClient.ListNext(nextPageLink);
                                    foreach (var pageItem in pageResult)
                                    {
                                        resultList.Add(pageItem);
                                    }
                                    nextPageLink = pageResult.NextPageLink;
                                }

                                foreach (var currentVmssVm in resultList)
                                {
                                    if (currentVmssVm.StorageProfile != null &&
                                        currentVmssVm.StorageProfile.OsDisk != null)
                                    {
                                        if (currentVmssVm.StorageProfile.OsDisk.OsType == OperatingSystemTypes.Linux)
                                        {
                                            vmssVmExtParams = new VirtualMachineScaleSetVMExtension
                                            {
                                                Publisher = "Microsoft.Azure.Security.LinuxAttestation",
                                                Type1 = "GuestAttestation",
                                                TypeHandlerVersion = "1.0"
                                            };
                                        }
                                        else
                                        {

                                            vmssVmExtParams = new VirtualMachineScaleSetVMExtension
                                            {
                                                Publisher = "Microsoft.Azure.Security.WindowsAttestation",
                                                Type1 = "GuestAttestation",
                                                TypeHandlerVersion = "1.0"
                                            };
                                        }
                                        string extensionNameGA = "GuestAttestation";
                                        var opt = this.VirtualMachineScaleSetVMExtensionsClient.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, currentVmssVm.InstanceId, extensionNameGA, vmssVmExtParams);
                                    }

                                }
                            }




                            var psObject = new PSVirtualMachineScaleSet();
                            ComputeAutomationAutoMapperProfile.Mapper.Map<VirtualMachineScaleSet, PSVirtualMachineScaleSet>(result, psObject);
                            WriteObject(psObject);
                        }
                    });
                    break;
            }
        }

        /// <summary>
        /// Check to see if the Guest Attestation extension should be installed and Identity set to SystemAssigned.
        /// Requirements for this scenario to be true:
        /// 1) DisableIntegrityMonitoring is not true.
        /// 2) SecurityType is TrustedLaunch.
        /// 3) SecureBootEnabled is true.
        /// 4) VTpmEnabled is true.
        /// </summary>
        /// <param name="vmssParameters"></param>
        /// <returns></returns>
        private bool shouldGuestAttestationExtBeInstalled(VirtualMachineScaleSet vmssParameters)
        {
            if (this.DisableIntegrityMonitoring != true &&
                    vmssParameters != null &&
                    vmssParameters.VirtualMachineProfile != null &&
                    vmssParameters.VirtualMachineProfile.SecurityProfile != null &&
                    vmssParameters.VirtualMachineProfile.SecurityProfile.SecurityType == "TrustedLaunch" &&
                    vmssParameters.VirtualMachineProfile.SecurityProfile.UefiSettings != null &&
                    vmssParameters.VirtualMachineProfile.SecurityProfile.UefiSettings.SecureBootEnabled == true &&
                    vmssParameters.VirtualMachineProfile.SecurityProfile.UefiSettings.VTpmEnabled == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// This somewhat contradicts with the above behavior that sets UpgradePolicy to null.
        /// There is some concern with the above behavior being correct or not, and requires additional testing before changing.
        private void checkFlexibleOrchestrationModeParamsDefaultParamSet(VirtualMachineScaleSet parameters)
        {
            if (parameters?.UpgradePolicy != null)
            {
                throw new Exception("UpgradePolicy is not currently supported for a VMSS with OrchestrationMode set to Flexible.");
            }
            else if (parameters?.VirtualMachineProfile?.NetworkProfile?.NetworkApiVersion != null
                && convertAPIVersionToInt(parameters?.VirtualMachineProfile?.NetworkProfile?.NetworkApiVersion) < vmssFlexibleOrchestrationModeNetworkAPIVersionMinimumInt)
            {
                throw new Exception("The value for NetworkApiVersion is not valid for a VMSS with OrchestrationMode set to Flexible. You must use a valid Network API Version equal to or greater than " + vmssFlexibleOrchestrationModeNetworkAPIVersionMinimum);
            }
            //else if (convertAPIVersionToInt(parameters?.VirtualMachineProfile?.NetworkProfile?.NetworkApiVersion) < vmssFlexibleOrchestrationModeNetworkAPIVersionMinimumInt)
            //{
            //    throw new Exception("The value for NetworkApiVersion is not valid for a VMSS with OrchestrationMode set to Flexible. You must use a valid Network API Version equal to or greater than " + vmssFlexibleOrchestrationModeNetworkAPIVersionMinimum);
            //}
        }

        private void flexibleOrchestrationModeDefaultParameters(VirtualMachineScaleSet parameters)
        {
            if (parameters?.VirtualMachineProfile?.NetworkProfile != null &&
                parameters?.VirtualMachineProfile?.NetworkProfile.NetworkApiVersion == null)
            {
                parameters.VirtualMachineProfile.NetworkProfile.NetworkApiVersion = vmssFlexibleOrchestrationModeNetworkAPIVersionMinimum;
            }
            /*if (parameters?.VirtualMachineProfile?.NetworkProfile?.NetworkApiVersion == null)
            {
                parameters.VirtualMachineProfile.NetworkProfile.NetworkApiVersion = vmssFlexibleOrchestrationModeNetworkAPIVersionMinimum;
            }*/
            if (parameters?.PlatformFaultDomainCount == null)
            {
                parameters.PlatformFaultDomainCount = 1;
            }
        }

        private int convertAPIVersionToInt(string networkAPIVersion)
        {
            string networkAPIVersionString = String.Join("", networkAPIVersion.Split('-'));
            int apiversionInt = Convert.ToInt32(networkAPIVersionString);

            return apiversionInt;
        }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [Parameter(
            ParameterSetName = SimpleParameterSet,
            Mandatory = false)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = DefaultParameter,
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [Parameter(
            ParameterSetName = SimpleParameterSet,
            Mandatory = true)]
        [Alias("Name")]
        public string VMScaleSetName { get; set; }

        [Parameter(
            ParameterSetName = DefaultParameter,
            Position = 2,
            Mandatory = true,
            ValueFromPipeline = true)]
        public PSVirtualMachineScaleSet VirtualMachineScaleSet { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        [Parameter(
            Mandatory = false,
            ParameterSetName = SimpleParameterSet,
            HelpMessage = "UserData for the Vmss, which will be Base64 encoded. Customer should not pass any secrets in here.",
            ValueFromPipelineByPropertyName = true)]
        public string UserData { get; set; }

        [Parameter(
           Mandatory = false,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = "This flag disables the default behavior to install the Guest Attestation extension to the virtual machine if: 1) SecurityType is TrustedLaunch, 2) SecureBootEnabled on the SecurityProfile is true, 3) VTpmEnabled on the SecurityProfile is true.")]
        public SwitchParameter DisableIntegrityMonitoring { get; set; }
    }
}