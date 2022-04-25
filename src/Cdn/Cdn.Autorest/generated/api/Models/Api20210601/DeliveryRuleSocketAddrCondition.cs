// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Defines the SocketAddress condition for the delivery rule.</summary>
    public partial class DeliveryRuleSocketAddrCondition :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleSocketAddrCondition,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleSocketAddrConditionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleCondition"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleCondition __deliveryRuleCondition = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DeliveryRuleCondition();

        /// <summary>Internal Acessors for Parameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISocketAddrMatchConditionParameters Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleSocketAddrConditionInternal.Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.SocketAddrMatchConditionParameters()); set { {_parameter = value;} } }

        /// <summary>Internal Acessors for ParameterTypeName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleSocketAddrConditionInternal.ParameterTypeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISocketAddrMatchConditionParametersInternal)Parameter).TypeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISocketAddrMatchConditionParametersInternal)Parameter).TypeName = value; }

        /// <summary>The name of the condition for the delivery rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchVariable Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleConditionInternal)__deliveryRuleCondition).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleConditionInternal)__deliveryRuleCondition).Name = value ; }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISocketAddrMatchConditionParameters _parameter;

        /// <summary>Defines the parameters for the condition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISocketAddrMatchConditionParameters Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.SocketAddrMatchConditionParameters()); set => this._parameter = value; }

        /// <summary>The match value for the condition of the delivery rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string[] ParameterMatchValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISocketAddrMatchConditionParametersInternal)Parameter).MatchValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISocketAddrMatchConditionParametersInternal)Parameter).MatchValue = value ?? null /* arrayOf */; }

        /// <summary>Describes if this is negate condition or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public bool? ParameterNegateCondition { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISocketAddrMatchConditionParametersInternal)Parameter).NegateCondition; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISocketAddrMatchConditionParametersInternal)Parameter).NegateCondition = value ?? default(bool); }

        /// <summary>Describes operator to be matched</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SocketAddrOperator ParameterOperator { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISocketAddrMatchConditionParametersInternal)Parameter).Operator; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISocketAddrMatchConditionParametersInternal)Parameter).Operator = value ; }

        /// <summary>List of transforms</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform[] ParameterTransform { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISocketAddrMatchConditionParametersInternal)Parameter).Transform; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISocketAddrMatchConditionParametersInternal)Parameter).Transform = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ParameterTypeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISocketAddrMatchConditionParametersInternal)Parameter).TypeName; }

        /// <summary>Creates an new <see cref="DeliveryRuleSocketAddrCondition" /> instance.</summary>
        public DeliveryRuleSocketAddrCondition()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__deliveryRuleCondition), __deliveryRuleCondition);
            await eventListener.AssertObjectIsValid(nameof(__deliveryRuleCondition), __deliveryRuleCondition);
        }
    }
    /// Defines the SocketAddress condition for the delivery rule.
    public partial interface IDeliveryRuleSocketAddrCondition :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleCondition
    {
        /// <summary>The match value for the condition of the delivery rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The match value for the condition of the delivery rule",
        SerializedName = @"matchValues",
        PossibleTypes = new [] { typeof(string) })]
        string[] ParameterMatchValue { get; set; }
        /// <summary>Describes if this is negate condition or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Describes if this is negate condition or not",
        SerializedName = @"negateCondition",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ParameterNegateCondition { get; set; }
        /// <summary>Describes operator to be matched</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Describes operator to be matched",
        SerializedName = @"operator",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SocketAddrOperator) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SocketAddrOperator ParameterOperator { get; set; }
        /// <summary>List of transforms</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of transforms",
        SerializedName = @"transforms",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform[] ParameterTransform { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"typeName",
        PossibleTypes = new [] { typeof(string) })]
        string ParameterTypeName { get;  }

    }
    /// Defines the SocketAddress condition for the delivery rule.
    internal partial interface IDeliveryRuleSocketAddrConditionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleConditionInternal
    {
        /// <summary>Defines the parameters for the condition.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISocketAddrMatchConditionParameters Parameter { get; set; }
        /// <summary>The match value for the condition of the delivery rule</summary>
        string[] ParameterMatchValue { get; set; }
        /// <summary>Describes if this is negate condition or not</summary>
        bool? ParameterNegateCondition { get; set; }
        /// <summary>Describes operator to be matched</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SocketAddrOperator ParameterOperator { get; set; }
        /// <summary>List of transforms</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform[] ParameterTransform { get; set; }

        string ParameterTypeName { get; set; }

    }
}