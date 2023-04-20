// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Extensions;

    /// <summary>
    /// Specifies the Linux operating system settings on the virtual machine. <br><br>For a list of supported Linux distributions,
    /// see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    /// </summary>
    public partial class LinuxConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ILinuxConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ILinuxConfigurationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSConfiguration"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSConfiguration __osConfiguration = new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.OSConfiguration();

        /// <summary>Backing field for <see cref="DisablePasswordAuthentication" /> property.</summary>
        private bool? _disablePasswordAuthentication;

        /// <summary>Specifies whether password authentication should be disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public bool? DisablePasswordAuthentication { get => this._disablePasswordAuthentication; set => this._disablePasswordAuthentication = value; }

        /// <summary>Internal Acessors for Ssh</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshConfiguration Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ILinuxConfigurationInternal.Ssh { get => (this._ssh = this._ssh ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.SshConfiguration()); set { {_ssh = value;} } }

        /// <summary>Internal Acessors for SshKeyPair</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshKeyPair Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ILinuxConfigurationInternal.SshKeyPair { get => (this._sshKeyPair = this._sshKeyPair ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.SshKeyPair()); set { {_sshKeyPair = value;} } }

        /// <summary>The OS Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.OSType OSType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSConfigurationInternal)__osConfiguration).OSType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSConfigurationInternal)__osConfiguration).OSType = value ; }

        /// <summary>Backing field for <see cref="Ssh" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshConfiguration _ssh;

        /// <summary>
        /// Specifies the ssh key configuration for a Linux OS. (This property is deprecated, please use 'sshKeyPair' instead)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshConfiguration Ssh { get => (this._ssh = this._ssh ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.SshConfiguration()); set => this._ssh = value; }

        /// <summary>Backing field for <see cref="SshKeyPair" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshKeyPair _sshKeyPair;

        /// <summary>The SSH Key-pair used to authenticate with the VM's.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshKeyPair SshKeyPair { get => (this._sshKeyPair = this._sshKeyPair ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.SshKeyPair()); set => this._sshKeyPair = value; }

        /// <summary>SSH private key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inlined)]
        public string SshKeyPairPrivateKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshKeyPairInternal)SshKeyPair).PrivateKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshKeyPairInternal)SshKeyPair).PrivateKey = value ?? null; }

        /// <summary>SSH public key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inlined)]
        public string SshKeyPairPublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshKeyPairInternal)SshKeyPair).PublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshKeyPairInternal)SshKeyPair).PublicKey = value ?? null; }

        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshPublicKey[] SshPublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshConfigurationInternal)Ssh).PublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshConfigurationInternal)Ssh).PublicKey = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="LinuxConfiguration" /> instance.</summary>
        public LinuxConfiguration()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__osConfiguration), __osConfiguration);
            await eventListener.AssertObjectIsValid(nameof(__osConfiguration), __osConfiguration);
        }
    }
    /// Specifies the Linux operating system settings on the virtual machine. <br><br>For a list of supported Linux distributions,
    /// see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    public partial interface ILinuxConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSConfiguration
    {
        /// <summary>Specifies whether password authentication should be disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies whether password authentication should be disabled.",
        SerializedName = @"disablePasswordAuthentication",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DisablePasswordAuthentication { get; set; }
        /// <summary>SSH private key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SSH private key.",
        SerializedName = @"privateKey",
        PossibleTypes = new [] { typeof(string) })]
        string SshKeyPairPrivateKey { get; set; }
        /// <summary>SSH public key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SSH public key",
        SerializedName = @"publicKey",
        PossibleTypes = new [] { typeof(string) })]
        string SshKeyPairPublicKey { get; set; }
        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of SSH public keys used to authenticate with linux based VMs.",
        SerializedName = @"publicKeys",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshPublicKey) })]
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshPublicKey[] SshPublicKey { get; set; }

    }
    /// Specifies the Linux operating system settings on the virtual machine. <br><br>For a list of supported Linux distributions,
    /// see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    internal partial interface ILinuxConfigurationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSConfigurationInternal
    {
        /// <summary>Specifies whether password authentication should be disabled.</summary>
        bool? DisablePasswordAuthentication { get; set; }
        /// <summary>
        /// Specifies the ssh key configuration for a Linux OS. (This property is deprecated, please use 'sshKeyPair' instead)
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshConfiguration Ssh { get; set; }
        /// <summary>The SSH Key-pair used to authenticate with the VM's.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshKeyPair SshKeyPair { get; set; }
        /// <summary>SSH private key.</summary>
        string SshKeyPairPrivateKey { get; set; }
        /// <summary>SSH public key</summary>
        string SshKeyPairPublicKey { get; set; }
        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISshPublicKey[] SshPublicKey { get; set; }

    }
}