// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object that contains the properties of the domain to create.</summary>
    public partial class AfdDomainProperties
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
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject into a new instance of <see cref="AfdDomainProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AfdDomainProperties(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __afdDomainUpdatePropertiesParameters = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdDomainUpdatePropertiesParameters(json);
            __afdStateProperties = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdStateProperties(json);
            {_validationProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject>("validationProperties"), out var __jsonValidationProperties) ? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DomainValidationProperties.FromJson(__jsonValidationProperties) : ValidationProperty;}
            {_domainValidationState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString>("domainValidationState"), out var __jsonDomainValidationState) ? (string)__jsonDomainValidationState : (string)DomainValidationState;}
            {_hostName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString>("hostName"), out var __jsonHostName) ? (string)__jsonHostName : (string)HostName;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json ? new AfdDomainProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AfdDomainProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AfdDomainProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode" />.
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
            __afdDomainUpdatePropertiesParameters?.ToJson(container, serializationMode);
            __afdStateProperties?.ToJson(container, serializationMode);
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._validationProperty ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) this._validationProperty.ToJson(null,serializationMode) : null, "validationProperties" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._domainValidationState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString(this._domainValidationState.ToString()) : null, "domainValidationState" ,container.Add );
            }
            AddIf( null != (((object)this._hostName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString(this._hostName.ToString()) : null, "hostName" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}