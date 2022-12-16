// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Support
{

    /// <summary>The drive's current state.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Support.DriveStateTypeConverter))]
    public partial struct DriveState :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Specified".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Specified'", "Specified", global::System.Management.Automation.CompletionResultType.ParameterValue, "Specified");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Received".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Received'", "Received", global::System.Management.Automation.CompletionResultType.ParameterValue, "Received");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "NeverReceived".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'NeverReceived'", "NeverReceived", global::System.Management.Automation.CompletionResultType.ParameterValue, "NeverReceived");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Transferring".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Transferring'", "Transferring", global::System.Management.Automation.CompletionResultType.ParameterValue, "Transferring");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Completed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Completed'", "Completed", global::System.Management.Automation.CompletionResultType.ParameterValue, "Completed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "CompletedMoreInfo".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'CompletedMoreInfo'", "CompletedMoreInfo", global::System.Management.Automation.CompletionResultType.ParameterValue, "CompletedMoreInfo");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ShippedBack".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ShippedBack'", "ShippedBack", global::System.Management.Automation.CompletionResultType.ParameterValue, "ShippedBack");
            }
        }
    }
}