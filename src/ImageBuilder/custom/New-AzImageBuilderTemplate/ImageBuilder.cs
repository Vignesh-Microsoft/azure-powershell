// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Extensions;

    /// <summary>
    /// Low-level API implementation for the ImageBuilder service.
    /// Virtual Machine Image Template
    /// </summary>
    public partial class ImageBuilder
    {
        /// <summary>Create or update a virtual machine image template</summary>
        /// <param name="subscriptionId">Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription
        /// Id forms part of the URI for every service call.</param>
        /// <param name="resourceGroupName">The name of the resource group.</param>
        /// <param name="imageTemplateName">The name of the image Template</param>
        /// <param name="jsonString">Json string supplied to the CreateImageTemplate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task VirtualMachineImageTemplatesCreateOrUpdateViaJsonString(string subscriptionId, string resourceGroupName, string imageTemplateName, string jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220701.IImageTemplate>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220701.ICloudError>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2022-07-01";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.VirtualMachineImages/imageTemplates/"
                        + global::System.Uri.EscapeDataString(imageTemplateName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.VirtualMachineImageTemplatesCreateOrUpdate_Call(request,onOk,onDefault,eventListener,sender);
            }
        }
    }
}