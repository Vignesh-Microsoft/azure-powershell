// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Extensions;

    /// <summary>Profile of network configuration.</summary>
    public partial class ContainerServiceNetworkProfile
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject into a new instance of <see cref="ContainerServiceNetworkProfile" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ContainerServiceNetworkProfile(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_loadBalancerProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("loadBalancerProfile"), out var __jsonLoadBalancerProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterLoadBalancerProfile.FromJson(__jsonLoadBalancerProfile) : LoadBalancerProfile;}
            {_natGatewayProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("natGatewayProfile"), out var __jsonNatGatewayProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterNatGatewayProfile.FromJson(__jsonNatGatewayProfile) : NatGatewayProfile;}
            {_networkPlugin = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("networkPlugin"), out var __jsonNetworkPlugin) ? (string)__jsonNetworkPlugin : (string)NetworkPlugin;}
            {_networkPluginMode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("networkPluginMode"), out var __jsonNetworkPluginMode) ? (string)__jsonNetworkPluginMode : (string)NetworkPluginMode;}
            {_networkPolicy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("networkPolicy"), out var __jsonNetworkPolicy) ? (string)__jsonNetworkPolicy : (string)NetworkPolicy;}
            {_networkMode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("networkMode"), out var __jsonNetworkMode) ? (string)__jsonNetworkMode : (string)NetworkMode;}
            {_networkDataplane = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("networkDataplane"), out var __jsonNetworkDataplane) ? (string)__jsonNetworkDataplane : (string)NetworkDataplane;}
            {_podCidr = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("podCidr"), out var __jsonPodCidr) ? (string)__jsonPodCidr : (string)PodCidr;}
            {_serviceCidr = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("serviceCidr"), out var __jsonServiceCidr) ? (string)__jsonServiceCidr : (string)ServiceCidr;}
            {_dnsServiceIP = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("dnsServiceIP"), out var __jsonDnsServiceIP) ? (string)__jsonDnsServiceIP : (string)DnsServiceIP;}
            {_dockerBridgeCidr = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("dockerBridgeCidr"), out var __jsonDockerBridgeCidr) ? (string)__jsonDockerBridgeCidr : (string)DockerBridgeCidr;}
            {_outboundType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("outboundType"), out var __jsonOutboundType) ? (string)__jsonOutboundType : (string)OutboundType;}
            {_loadBalancerSku = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("loadBalancerSku"), out var __jsonLoadBalancerSku) ? (string)__jsonLoadBalancerSku : (string)LoadBalancerSku;}
            {_podCidrs = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonArray>("podCidrs"), out var __jsonPodCidrs) ? If( __jsonPodCidrs as Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : PodCidrs;}
            {_serviceCidrs = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonArray>("serviceCidrs"), out var __jsonServiceCidrs) ? If( __jsonServiceCidrs as Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : ServiceCidrs;}
            {_iPFamily = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonArray>("ipFamilies"), out var __jsonIPFamilies) ? If( __jsonIPFamilies as Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.IPFamily[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.IPFamily) (__k is Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString __j ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.IPFamily)(__j.ToString()) : ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.IPFamily)""))) ))() : null : IPFamily;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IContainerServiceNetworkProfile.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IContainerServiceNetworkProfile.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IContainerServiceNetworkProfile FromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject json ? new ContainerServiceNetworkProfile(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ContainerServiceNetworkProfile" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ContainerServiceNetworkProfile" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._loadBalancerProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._loadBalancerProfile.ToJson(null,serializationMode) : null, "loadBalancerProfile" ,container.Add );
            AddIf( null != this._natGatewayProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._natGatewayProfile.ToJson(null,serializationMode) : null, "natGatewayProfile" ,container.Add );
            AddIf( null != (((object)this._networkPlugin)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._networkPlugin.ToString()) : null, "networkPlugin" ,container.Add );
            AddIf( null != (((object)this._networkPluginMode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._networkPluginMode.ToString()) : null, "networkPluginMode" ,container.Add );
            AddIf( null != (((object)this._networkPolicy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._networkPolicy.ToString()) : null, "networkPolicy" ,container.Add );
            AddIf( null != (((object)this._networkMode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._networkMode.ToString()) : null, "networkMode" ,container.Add );
            AddIf( null != (((object)this._networkDataplane)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._networkDataplane.ToString()) : null, "networkDataplane" ,container.Add );
            AddIf( null != (((object)this._podCidr)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._podCidr.ToString()) : null, "podCidr" ,container.Add );
            AddIf( null != (((object)this._serviceCidr)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._serviceCidr.ToString()) : null, "serviceCidr" ,container.Add );
            AddIf( null != (((object)this._dnsServiceIP)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._dnsServiceIP.ToString()) : null, "dnsServiceIP" ,container.Add );
            AddIf( null != (((object)this._dockerBridgeCidr)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._dockerBridgeCidr.ToString()) : null, "dockerBridgeCidr" ,container.Add );
            AddIf( null != (((object)this._outboundType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._outboundType.ToString()) : null, "outboundType" ,container.Add );
            AddIf( null != (((object)this._loadBalancerSku)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._loadBalancerSku.ToString()) : null, "loadBalancerSku" ,container.Add );
            if (null != this._podCidrs)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.XNodeArray();
                foreach( var __x in this._podCidrs )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("podCidrs",__w);
            }
            if (null != this._serviceCidrs)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.XNodeArray();
                foreach( var __s in this._serviceCidrs )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("serviceCidrs",__r);
            }
            if (null != this._iPFamily)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.XNodeArray();
                foreach( var __n in this._iPFamily )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("ipFamilies",__m);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}