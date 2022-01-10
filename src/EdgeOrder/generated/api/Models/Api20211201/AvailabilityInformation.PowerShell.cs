// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.PowerShell;

    /// <summary>Availability information of a product system.</summary>
    [System.ComponentModel.TypeConverter(typeof(AvailabilityInformationTypeConverter))]
    public partial class AvailabilityInformation
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AvailabilityInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AvailabilityInformation(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AvailabilityStage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformationInternal)this).AvailabilityStage = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage?) content.GetValueForProperty("AvailabilityStage",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformationInternal)this).AvailabilityStage, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage.CreateFrom);
            }
            if (content.Contains("DisabledReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformationInternal)this).DisabledReason = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason?) content.GetValueForProperty("DisabledReason",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformationInternal)this).DisabledReason, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason.CreateFrom);
            }
            if (content.Contains("DisabledReasonMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformationInternal)this).DisabledReasonMessage = (string) content.GetValueForProperty("DisabledReasonMessage",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformationInternal)this).DisabledReasonMessage, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AvailabilityInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AvailabilityInformation(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AvailabilityStage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformationInternal)this).AvailabilityStage = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage?) content.GetValueForProperty("AvailabilityStage",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformationInternal)this).AvailabilityStage, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage.CreateFrom);
            }
            if (content.Contains("DisabledReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformationInternal)this).DisabledReason = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason?) content.GetValueForProperty("DisabledReason",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformationInternal)this).DisabledReason, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason.CreateFrom);
            }
            if (content.Contains("DisabledReasonMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformationInternal)this).DisabledReasonMessage = (string) content.GetValueForProperty("DisabledReasonMessage",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformationInternal)this).DisabledReasonMessage, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AvailabilityInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformation" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformation DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AvailabilityInformation(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AvailabilityInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformation" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformation DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AvailabilityInformation(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AvailabilityInformation" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformation FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Availability information of a product system.
    [System.ComponentModel.TypeConverter(typeof(AvailabilityInformationTypeConverter))]
    public partial interface IAvailabilityInformation

    {

    }
}