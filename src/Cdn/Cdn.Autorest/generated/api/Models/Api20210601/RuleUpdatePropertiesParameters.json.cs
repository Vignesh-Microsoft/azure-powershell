// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object that contains the properties of the rule to update.</summary>
    public partial class RuleUpdatePropertiesParameters
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleUpdatePropertiesParameters.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleUpdatePropertiesParameters.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleUpdatePropertiesParameters FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json ? new RuleUpdatePropertiesParameters(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject into a new instance of <see cref="RuleUpdatePropertiesParameters" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal RuleUpdatePropertiesParameters(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_ruleSetName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString>("ruleSetName"), out var __jsonRuleSetName) ? (string)__jsonRuleSetName : (string)RuleSetName;}
            {_order = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNumber>("order"), out var __jsonOrder) ? (int?)__jsonOrder : Order;}
            {_condition = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonArray>("conditions"), out var __jsonConditions) ? If( __jsonConditions as Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleCondition[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleCondition) (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DeliveryRuleCondition.FromJson(__u) )) ))() : null : Condition;}
            {_action = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonArray>("actions"), out var __jsonActions) ? If( __jsonActions as Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleAction1[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleAction1) (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DeliveryRuleAction1.FromJson(__p) )) ))() : null : Action;}
            {_matchProcessingBehavior = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString>("matchProcessingBehavior"), out var __jsonMatchProcessingBehavior) ? (string)__jsonMatchProcessingBehavior : (string)MatchProcessingBehavior;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="RuleUpdatePropertiesParameters" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RuleUpdatePropertiesParameters" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._ruleSetName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString(this._ruleSetName.ToString()) : null, "ruleSetName" ,container.Add );
            }
            AddIf( null != this._order ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNumber((int)this._order) : null, "order" ,container.Add );
            if (null != this._condition)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.XNodeArray();
                foreach( var __x in this._condition )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("conditions",__w);
            }
            if (null != this._action)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.XNodeArray();
                foreach( var __s in this._action )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("actions",__r);
            }
            AddIf( null != (((object)this._matchProcessingBehavior)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString(this._matchProcessingBehavior.ToString()) : null, "matchProcessingBehavior" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}