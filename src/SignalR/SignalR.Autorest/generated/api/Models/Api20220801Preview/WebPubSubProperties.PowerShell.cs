// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.PowerShell;

    /// <summary>A class that describes the properties of the resource</summary>
    [System.ComponentModel.TypeConverter(typeof(WebPubSubPropertiesTypeConverter))]
    public partial class WebPubSubProperties
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.WebPubSubProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new WebPubSubProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.WebPubSubProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new WebPubSubProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="WebPubSubProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="WebPubSubProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.WebPubSubProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal WebPubSubProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Tl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).Tl = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubTlsSettings) content.GetValueForProperty("Tl",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).Tl, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.WebPubSubTlsSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LiveTraceConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).LiveTraceConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ILiveTraceConfiguration) content.GetValueForProperty("LiveTraceConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).LiveTraceConfiguration, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.LiveTraceConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceLogConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ResourceLogConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IResourceLogConfiguration) content.GetValueForProperty("ResourceLogConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ResourceLogConfiguration, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ResourceLogConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkAcL"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).NetworkAcL = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubNetworkAcLs) content.GetValueForProperty("NetworkAcL",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).NetworkAcL, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.WebPubSubNetworkAcLsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("ExternalIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ExternalIP = (string) content.GetValueForProperty("ExternalIP",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ExternalIP, global::System.Convert.ToString);
            }
            if (content.Contains("HostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).HostName, global::System.Convert.ToString);
            }
            if (content.Contains("PublicPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PublicPort = (int?) content.GetValueForProperty("PublicPort",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PublicPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ServerPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ServerPort = (int?) content.GetValueForProperty("ServerPort",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ServerPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).Version, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PrivateEndpointConnection = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IPrivateEndpointConnection[]) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("SharedPrivateLinkResource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).SharedPrivateLinkResource = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISharedPrivateLinkResource[]) content.GetValueForProperty("SharedPrivateLinkResource",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).SharedPrivateLinkResource, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISharedPrivateLinkResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.SharedPrivateLinkResourceTypeConverter.ConvertFrom));
            }
            if (content.Contains("HostNamePrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).HostNamePrefix = (string) content.GetValueForProperty("HostNamePrefix",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).HostNamePrefix, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("DisableLocalAuth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).DisableLocalAuth = (bool?) content.GetValueForProperty("DisableLocalAuth",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).DisableLocalAuth, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DisableAadAuth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).DisableAadAuth = (bool?) content.GetValueForProperty("DisableAadAuth",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).DisableAadAuth, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LiveTraceConfigurationEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).LiveTraceConfigurationEnabled = (string) content.GetValueForProperty("LiveTraceConfigurationEnabled",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).LiveTraceConfigurationEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("LiveTraceConfigurationCategory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).LiveTraceConfigurationCategory = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ILiveTraceCategory[]) content.GetValueForProperty("LiveTraceConfigurationCategory",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).LiveTraceConfigurationCategory, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ILiveTraceCategory>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.LiveTraceCategoryTypeConverter.ConvertFrom));
            }
            if (content.Contains("ResourceLogConfigurationCategory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ResourceLogConfigurationCategory = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IResourceLogCategory[]) content.GetValueForProperty("ResourceLogConfigurationCategory",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ResourceLogConfigurationCategory, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IResourceLogCategory>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ResourceLogCategoryTypeConverter.ConvertFrom));
            }
            if (content.Contains("TlClientCertEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).TlClientCertEnabled = (bool?) content.GetValueForProperty("TlClientCertEnabled",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).TlClientCertEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("NetworkAcLPublicNetwork"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).NetworkAcLPublicNetwork = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.INetworkAcl) content.GetValueForProperty("NetworkAcLPublicNetwork",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).NetworkAcLPublicNetwork, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.NetworkAclTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkAcLDefaultAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).NetworkAcLDefaultAction = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.AclAction?) content.GetValueForProperty("NetworkAcLDefaultAction",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).NetworkAcLDefaultAction, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.AclAction.CreateFrom);
            }
            if (content.Contains("NetworkAcLPrivateEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).NetworkAcLPrivateEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IPrivateEndpointAcl[]) content.GetValueForProperty("NetworkAcLPrivateEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).NetworkAcLPrivateEndpoint, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IPrivateEndpointAcl>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.PrivateEndpointAclTypeConverter.ConvertFrom));
            }
            if (content.Contains("PublicNetworkAllow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PublicNetworkAllow = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType[]) content.GetValueForProperty("PublicNetworkAllow",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PublicNetworkAllow, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType.CreateFrom));
            }
            if (content.Contains("PublicNetworkDeny"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PublicNetworkDeny = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType[]) content.GetValueForProperty("PublicNetworkDeny",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PublicNetworkDeny, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType.CreateFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.WebPubSubProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal WebPubSubProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Tl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).Tl = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubTlsSettings) content.GetValueForProperty("Tl",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).Tl, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.WebPubSubTlsSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LiveTraceConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).LiveTraceConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ILiveTraceConfiguration) content.GetValueForProperty("LiveTraceConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).LiveTraceConfiguration, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.LiveTraceConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceLogConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ResourceLogConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IResourceLogConfiguration) content.GetValueForProperty("ResourceLogConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ResourceLogConfiguration, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ResourceLogConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkAcL"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).NetworkAcL = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubNetworkAcLs) content.GetValueForProperty("NetworkAcL",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).NetworkAcL, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.WebPubSubNetworkAcLsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("ExternalIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ExternalIP = (string) content.GetValueForProperty("ExternalIP",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ExternalIP, global::System.Convert.ToString);
            }
            if (content.Contains("HostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).HostName, global::System.Convert.ToString);
            }
            if (content.Contains("PublicPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PublicPort = (int?) content.GetValueForProperty("PublicPort",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PublicPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ServerPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ServerPort = (int?) content.GetValueForProperty("ServerPort",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ServerPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).Version, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PrivateEndpointConnection = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IPrivateEndpointConnection[]) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("SharedPrivateLinkResource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).SharedPrivateLinkResource = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISharedPrivateLinkResource[]) content.GetValueForProperty("SharedPrivateLinkResource",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).SharedPrivateLinkResource, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISharedPrivateLinkResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.SharedPrivateLinkResourceTypeConverter.ConvertFrom));
            }
            if (content.Contains("HostNamePrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).HostNamePrefix = (string) content.GetValueForProperty("HostNamePrefix",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).HostNamePrefix, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("DisableLocalAuth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).DisableLocalAuth = (bool?) content.GetValueForProperty("DisableLocalAuth",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).DisableLocalAuth, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DisableAadAuth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).DisableAadAuth = (bool?) content.GetValueForProperty("DisableAadAuth",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).DisableAadAuth, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LiveTraceConfigurationEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).LiveTraceConfigurationEnabled = (string) content.GetValueForProperty("LiveTraceConfigurationEnabled",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).LiveTraceConfigurationEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("LiveTraceConfigurationCategory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).LiveTraceConfigurationCategory = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ILiveTraceCategory[]) content.GetValueForProperty("LiveTraceConfigurationCategory",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).LiveTraceConfigurationCategory, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ILiveTraceCategory>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.LiveTraceCategoryTypeConverter.ConvertFrom));
            }
            if (content.Contains("ResourceLogConfigurationCategory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ResourceLogConfigurationCategory = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IResourceLogCategory[]) content.GetValueForProperty("ResourceLogConfigurationCategory",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).ResourceLogConfigurationCategory, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IResourceLogCategory>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ResourceLogCategoryTypeConverter.ConvertFrom));
            }
            if (content.Contains("TlClientCertEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).TlClientCertEnabled = (bool?) content.GetValueForProperty("TlClientCertEnabled",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).TlClientCertEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("NetworkAcLPublicNetwork"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).NetworkAcLPublicNetwork = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.INetworkAcl) content.GetValueForProperty("NetworkAcLPublicNetwork",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).NetworkAcLPublicNetwork, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.NetworkAclTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkAcLDefaultAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).NetworkAcLDefaultAction = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.AclAction?) content.GetValueForProperty("NetworkAcLDefaultAction",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).NetworkAcLDefaultAction, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.AclAction.CreateFrom);
            }
            if (content.Contains("NetworkAcLPrivateEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).NetworkAcLPrivateEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IPrivateEndpointAcl[]) content.GetValueForProperty("NetworkAcLPrivateEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).NetworkAcLPrivateEndpoint, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IPrivateEndpointAcl>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.PrivateEndpointAclTypeConverter.ConvertFrom));
            }
            if (content.Contains("PublicNetworkAllow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PublicNetworkAllow = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType[]) content.GetValueForProperty("PublicNetworkAllow",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PublicNetworkAllow, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType.CreateFrom));
            }
            if (content.Contains("PublicNetworkDeny"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PublicNetworkDeny = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType[]) content.GetValueForProperty("PublicNetworkDeny",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IWebPubSubPropertiesInternal)this).PublicNetworkDeny, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType>(__y, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType.CreateFrom));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// A class that describes the properties of the resource
    [System.ComponentModel.TypeConverter(typeof(WebPubSubPropertiesTypeConverter))]
    public partial interface IWebPubSubProperties

    {

    }
}