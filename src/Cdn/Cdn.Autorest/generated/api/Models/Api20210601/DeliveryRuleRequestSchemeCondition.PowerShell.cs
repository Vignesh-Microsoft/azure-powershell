// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.PowerShell;

    /// <summary>Defines the RequestScheme condition for the delivery rule.</summary>
    [System.ComponentModel.TypeConverter(typeof(DeliveryRuleRequestSchemeConditionTypeConverter))]
    public partial class DeliveryRuleRequestSchemeCondition
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DeliveryRuleRequestSchemeCondition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DeliveryRuleRequestSchemeCondition(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRequestSchemeMatchConditionParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.RequestSchemeMatchConditionParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleConditionInternal)this).Name = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchVariable) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleConditionInternal)this).Name, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchVariable.CreateFrom);
            }
            if (content.Contains("ParameterTypeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterTypeName = (string) content.GetValueForProperty("ParameterTypeName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterTypeName, global::System.Convert.ToString);
            }
            if (content.Contains("ParameterOperator"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterOperator = (string) content.GetValueForProperty("ParameterOperator",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterOperator, global::System.Convert.ToString);
            }
            if (content.Contains("ParameterNegateCondition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterNegateCondition = (bool?) content.GetValueForProperty("ParameterNegateCondition",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterNegateCondition, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ParameterTransform"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterTransform = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform[]) content.GetValueForProperty("ParameterTransform",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterTransform, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform>(__y, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform.CreateFrom));
            }
            if (content.Contains("ParameterMatchValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterMatchValue = (string[]) content.GetValueForProperty("ParameterMatchValue",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterMatchValue, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DeliveryRuleRequestSchemeCondition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DeliveryRuleRequestSchemeCondition(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRequestSchemeMatchConditionParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.RequestSchemeMatchConditionParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleConditionInternal)this).Name = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchVariable) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleConditionInternal)this).Name, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchVariable.CreateFrom);
            }
            if (content.Contains("ParameterTypeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterTypeName = (string) content.GetValueForProperty("ParameterTypeName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterTypeName, global::System.Convert.ToString);
            }
            if (content.Contains("ParameterOperator"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterOperator = (string) content.GetValueForProperty("ParameterOperator",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterOperator, global::System.Convert.ToString);
            }
            if (content.Contains("ParameterNegateCondition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterNegateCondition = (bool?) content.GetValueForProperty("ParameterNegateCondition",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterNegateCondition, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ParameterTransform"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterTransform = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform[]) content.GetValueForProperty("ParameterTransform",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterTransform, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform>(__y, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform.CreateFrom));
            }
            if (content.Contains("ParameterMatchValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterMatchValue = (string[]) content.GetValueForProperty("ParameterMatchValue",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeConditionInternal)this).ParameterMatchValue, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DeliveryRuleRequestSchemeCondition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeCondition"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeCondition DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DeliveryRuleRequestSchemeCondition(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DeliveryRuleRequestSchemeCondition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeCondition"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeCondition DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DeliveryRuleRequestSchemeCondition(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DeliveryRuleRequestSchemeCondition" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleRequestSchemeCondition FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Defines the RequestScheme condition for the delivery rule.
    [System.ComponentModel.TypeConverter(typeof(DeliveryRuleRequestSchemeConditionTypeConverter))]
    public partial interface IDeliveryRuleRequestSchemeCondition

    {

    }
}