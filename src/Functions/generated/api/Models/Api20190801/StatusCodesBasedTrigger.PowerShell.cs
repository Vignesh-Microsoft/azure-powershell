namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>Trigger based on status code.</summary>
    [System.ComponentModel.TypeConverter(typeof(StatusCodesBasedTriggerTypeConverter))]
    public partial class StatusCodesBasedTrigger
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.StatusCodesBasedTrigger"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTrigger" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTrigger DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new StatusCodesBasedTrigger(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.StatusCodesBasedTrigger"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTrigger" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTrigger DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new StatusCodesBasedTrigger(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="StatusCodesBasedTrigger" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTrigger FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.StatusCodesBasedTrigger"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal StatusCodesBasedTrigger(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).Status = (int?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).Status, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).SubStatus = (int?) content.GetValueForProperty("SubStatus",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).SubStatus, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).Win32Status = (int?) content.GetValueForProperty("Win32Status",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).Win32Status, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).Count = (int?) content.GetValueForProperty("Count",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).Count, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).TimeInterval = (string) content.GetValueForProperty("TimeInterval",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).TimeInterval, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.StatusCodesBasedTrigger"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal StatusCodesBasedTrigger(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).Status = (int?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).Status, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).SubStatus = (int?) content.GetValueForProperty("SubStatus",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).SubStatus, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).Win32Status = (int?) content.GetValueForProperty("Win32Status",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).Win32Status, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).Count = (int?) content.GetValueForProperty("Count",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).Count, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).TimeInterval = (string) content.GetValueForProperty("TimeInterval",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStatusCodesBasedTriggerInternal)this).TimeInterval, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Trigger based on status code.
    [System.ComponentModel.TypeConverter(typeof(StatusCodesBasedTriggerTypeConverter))]
    public partial interface IStatusCodesBasedTrigger

    {

    }
}