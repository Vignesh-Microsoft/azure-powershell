﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Common.Authentication;


namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation
{
    using Commands.Common.Authentication.Abstractions;
    using Common;
    using Microsoft.Azure.Commands.ResourceManager.Cmdlets.Components;
    using Microsoft.Azure.Commands.ResourceManager.Cmdlets.Entities.Resources;
    using Microsoft.Azure.Commands.ResourceManager.Cmdlets.Extensions;
    using Microsoft.Azure.Commands.ResourceManager.Cmdlets.RestClients;
    using Microsoft.Azure.Commands.ResourceManager.Cmdlets.SdkClient;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Management.Automation;
    using System.Runtime.ExceptionServices;
    using System.Threading;

    /// <summary>
    /// The base class for resource manager cmdlets.
    /// </summary>
    public abstract class ResourceManagerCmdletBase : AzureRMCmdlet
    {
        /// <summary>
        /// The cancellation source.
        /// </summary>
        private CancellationTokenSource cancellationSource;

        /// <summary>
        /// Gets the cancellation source.
        /// </summary>
        protected CancellationToken? CancellationToken
        {
            get
            {
                return this.cancellationSource == null ? null : (CancellationToken?)this.cancellationSource.Token;
            }
        }

        /// <summary>
        /// Field that holds the resource client instance
        /// </summary>
        private ResourceManagerSdkClient resourceManagerSdkClient;

        /// <summary>
        /// Field that holds the resource client instance with newer APIVersion
        /// </summary>
        private NewResourceManagerSdkClient newResourceManagerSdkClient;

        /// <summary>
        /// Field that holds the subscriptions client instance
        /// </summary>
        private SubscriptionSdkClient subscriptionSdkClient;

        /// <summary>
        /// Gets or sets the switch that indicates if pre-release API version should be considered.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "When set, indicates that the cmdlet should use pre-release API versions when automatically determining which version to use.")]
        public SwitchParameter Pre { get; set; }

        /// <summary>
        /// The <c>BeginProcessing</c> method.
        /// </summary>
        protected override void BeginProcessing()
        {
            try
            {
                if (this.cancellationSource == null)
                {
                    this.cancellationSource = new CancellationTokenSource();
                }

                base.BeginProcessing();
                this.OnBeginProcessing();
            }
            catch (Exception ex)
            {
                if (ex.IsFatal())
                {
                    throw;
                }

                var capturedException = ExceptionDispatchInfo.Capture(ex);
                this.HandleException(capturedException: capturedException);
            }
        }

        /// <summary>
        /// The <c>StopProcessing</c> method.
        /// </summary>
        protected override void StopProcessing()
        {
            try
            {
                if (this.cancellationSource != null && !this.cancellationSource.IsCancellationRequested)
                {
                    this.cancellationSource.Cancel();
                }

                this.OnStopProcessing();
                base.StopProcessing();
            }
            catch (Exception ex)
            {
                if (ex.IsFatal())
                {
                    throw;
                }

                var capturedException = ExceptionDispatchInfo.Capture(ex);
                this.HandleException(capturedException: capturedException);
            }
            finally
            {
                this.DisposeOfCancellationSource();
            }
        }

        /// <summary>
        /// The <c>EndProcessing</c> method.
        /// </summary>
        protected override void EndProcessing()
        {
            try
            {
                this.OnEndProcessing();
                base.EndProcessing();
            }
            catch (Exception ex)
            {
                if (ex.IsFatal())
                {
                    throw;
                }

                var capturedException = ExceptionDispatchInfo.Capture(ex);
                this.HandleException(capturedException: capturedException);
            }
            finally
            {
                this.DisposeOfCancellationSource();
            }
        }

        /// <summary>
        /// The <c>ProcessRecord</c> method.
        /// </summary>
        public sealed override void ExecuteCmdlet()
        {
            try
            {
                if (this.cancellationSource == null)
                {
                    this.cancellationSource = new CancellationTokenSource();
                }

                base.ExecuteCmdlet();
                this.OnProcessRecord();
            }
            catch (Exception ex)
            {
                if (ex.IsFatal())
                {
                    throw;
                }

                var capturedException = ExceptionDispatchInfo.Capture(ex);
                this.HandleException(capturedException: capturedException);
            }
        }

        /// <summary>
        /// When overridden, allows child classes to be called when the <c>ProcessRecord</c> method is invoked.
        /// </summary>
        protected virtual void OnProcessRecord()
        {
            // no-op
        }

        /// <summary>
        /// When overridden, allows child classes to be called when the <c>EndProcessing</c> method is invoked.
        /// </summary>
        protected virtual void OnEndProcessing()
        {
            // no-op
        }

        /// <summary>
        /// When overridden, allows child classes to be called when the <c>BeginProcessing</c> method is invoked.
        /// </summary>
        protected virtual void OnBeginProcessing()
        {
            // no-op
        }

        /// <summary>
        /// When overridden, allows child classes to be called when the <c>StopProcessing</c> method is invoked.
        /// </summary>
        protected virtual void OnStopProcessing()
        {
            // no-op
        }

        /// <summary>
        /// Gets a new instance of the <see cref="ResourceManagerRestRestClient"/>.
        /// </summary>
        public ResourceManagerRestRestClient GetResourcesClient()
        {
            var endpoint = DefaultContext.Environment.GetEndpoint(AzureEnvironment.Endpoint.ResourceManager);

            if (string.IsNullOrWhiteSpace(endpoint))
            {
                throw new ApplicationException(
                    "The endpoint for the Azure Resource Manager service is not set. Please report this issue via GitHub or contact Microsoft customer support.");
            }

            var endpointUri = new Uri(endpoint, UriKind.Absolute);

            return new ResourceManagerRestRestClient(
                endpointUri: endpointUri,
                httpClientHelper: HttpClientHelperFactory.Instance
                .CreateHttpClientHelper(
                        credentials: AzureSession.Instance.AuthenticationFactory
                                                 .GetServiceClientCredentials(
                                                    DefaultContext,
                                                    AzureEnvironment.Endpoint.ResourceManager),
                        headerValues: AzureSession.Instance.ClientFactory.UserAgents,
                        cmdletHeaderValues: this.GetCmdletHeaders()));
        }

        /// <summary>
        /// Gets or sets the resource manager sdk client
        /// </summary>
        public ResourceManagerSdkClient ResourceManagerSdkClient
        {
            get
            {
                if (this.resourceManagerSdkClient == null)
                {
                    this.resourceManagerSdkClient = new ResourceManagerSdkClient(DefaultContext);
                }

                this.resourceManagerSdkClient.VerboseLogger = WriteVerboseWithTimestamp;
                this.resourceManagerSdkClient.ErrorLogger = WriteErrorWithTimestamp;
                this.resourceManagerSdkClient.WarningLogger = WriteWarningWithTimestamp;

                return this.resourceManagerSdkClient;
            }

            set { this.resourceManagerSdkClient = value; }
        }

        /// <summary>
        /// Gets or sets the resource manager sdk client
        /// </summary>
        public NewResourceManagerSdkClient NewResourceManagerSdkClient
        {
            get
            {
                if (this.newResourceManagerSdkClient == null)
                {
                    this.newResourceManagerSdkClient = new NewResourceManagerSdkClient(DefaultContext);
                }

                this.newResourceManagerSdkClient.VerboseLogger = WriteVerboseWithTimestamp;
                this.newResourceManagerSdkClient.ErrorLogger = WriteErrorWithTimestamp;
                this.newResourceManagerSdkClient.WarningLogger = WriteWarningWithTimestamp;

                return this.newResourceManagerSdkClient;
            }

            set { this.newResourceManagerSdkClient = value; }
        }

        /// <summary>
        /// Gets or sets the subscription sdk client
        /// </summary>
        public SubscriptionSdkClient SubscriptionSdkClient
        {
            get
            {
                if (this.subscriptionSdkClient == null)
                {
                    this.subscriptionSdkClient = new SubscriptionSdkClient(DefaultContext)
                    {
                        VerboseLogger = WriteVerboseWithTimestamp,
                        ErrorLogger = WriteErrorWithTimestamp,
                        WarningLogger = WriteWarningWithTimestamp
                    };
                }
                return this.subscriptionSdkClient;
            }

            set { this.subscriptionSdkClient = value; }
        }

        private Dictionary<string, string> GetCmdletHeaders()
        {
            return new Dictionary<string, string>
            {
                {"ParameterSetName", this.ParameterSetName },
                {"CommandName", this.CommandRuntime.ToString() }
            };
        }

        /// <summary>
        /// Writes the object
        /// </summary>
        /// <param name="resultString">The result as a string</param>
        protected void TryConvertAndWriteObject(string resultString)
        {
            JToken resultJToken;
            if (resultString.TryConvertTo<JToken>(out resultJToken))
            {
                this.WriteObject(resultJToken);
            }
            else
            {
                this.WriteObject(resultString);
            }
        }

        /// <summary>
        /// Writes the object
        /// </summary>
        /// <param name="resultString">The result as a string</param>
        protected void TryConvertToResourceAndWriteObject(string resultString)
        {
            Resource<JToken> resultResource;
            if (resultString.TryConvertTo<Resource<JToken>>(out resultResource))
            {
                this.WriteObject(resultResource.ToPsObject());
            }
            else
            {
                this.WriteObject(resultString);
            }
        }

        /// <summary>
        /// Writes a <see cref="JToken"/> object as a <see cref="PSObject"/>.
        /// </summary>
        /// <param name="result">The result of the action.</param>
        protected void WriteObject(JToken result)
        {
            this.WriteObject(sendToPipeline: result.ToPsObject(), enumerateCollection: true);
        }

        /// <summary>
        /// Gets a new instance of the long running operation helper.
        /// </summary>
        /// <param name="activityName">The name of the action.</param>
        /// <param name="isResourceCreateOrUpdate">When set to true, indicates that the tracker will be used to track a resource creation request.</param>
        internal LongRunningOperationHelper GetLongRunningOperationTracker(string activityName, bool isResourceCreateOrUpdate)
        {
            return new LongRunningOperationHelper(
                activityName: activityName,
                resourcesClientFactory: () => this.GetResourcesClient(),
                writeProgressAction: progress => this.WriteProgress(progress),
                cancellationToken: this.CancellationToken.Value,
                isResourceCreateOrUpdate: isResourceCreateOrUpdate);
        }

        /// <summary>
        /// Disposes of the <see cref="CancellationTokenSource"/>.
        /// </summary>
        private void DisposeOfCancellationSource()
        {
            if (this.cancellationSource != null)
            {
                if (!this.cancellationSource.IsCancellationRequested)
                {
                    this.cancellationSource.Cancel();
                }

                this.cancellationSource.Dispose();
                this.cancellationSource = null;
            }
        }

        /// <summary>
        /// Gets the source exception from a captured exception.
        /// </summary>
        /// <param name="capturedException">The captured exception</param>
        private static Exception GetSourceException(ExceptionDispatchInfo capturedException)
        {
            if (capturedException.SourceException is AggregateException aggregateException)
            {
                var innerException = aggregateException.InnerExceptions?.SingleOrDefault();

                if (innerException != null) 
                {
                    return innerException;
                }
            }

            return capturedException.SourceException;
        }

        /// <summary>
        /// Provides specialized exception handling.
        /// </summary>
        /// <param name="capturedException">The captured exception</param>
        private void HandleException(ExceptionDispatchInfo capturedException)
        {
            try
            {
                var sourceException = GetSourceException(capturedException);

                if (sourceException is CloudException cloudException)
                {
                    throw new ResourceManagerCloudException(cloudException);
                }

                throw sourceException;
            }
            finally
            {
                this.DisposeOfCancellationSource();
            }
        }

        /// <summary>
        /// Determines the parameter set name.
        /// </summary>
        public virtual string DetermineParameterSetName()
        {
            return this.ParameterSetName;
        }
    }
}