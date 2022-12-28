// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101
{
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.PowerShell;

    /// <summary>Azure Traffic Collector resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureTrafficCollectorTypeConverter))]
    public partial class AzureTrafficCollector
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.AzureTrafficCollector"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureTrafficCollector(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorPropertiesFormat) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.AzureTrafficCollectorPropertiesFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("VirtualHub"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).VirtualHub = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IResourceReference) content.GetValueForProperty("VirtualHub",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).VirtualHub, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("CollectorPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).CollectorPolicy = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IResourceReference[]) content.GetValueForProperty("CollectorPolicy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).CollectorPolicy, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IResourceReference>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ResourceReferenceTypeConverter.ConvertFrom));
            }
            if (content.Contains("VirtualHubId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).VirtualHubId = (string) content.GetValueForProperty("VirtualHubId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).VirtualHubId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.AzureTrafficCollector"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureTrafficCollector(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorPropertiesFormat) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.AzureTrafficCollectorPropertiesFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("VirtualHub"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).VirtualHub = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IResourceReference) content.GetValueForProperty("VirtualHub",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).VirtualHub, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("CollectorPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).CollectorPolicy = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IResourceReference[]) content.GetValueForProperty("CollectorPolicy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).CollectorPolicy, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IResourceReference>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.ResourceReferenceTypeConverter.ConvertFrom));
            }
            if (content.Contains("VirtualHubId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).VirtualHubId = (string) content.GetValueForProperty("VirtualHubId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollectorInternal)this).VirtualHubId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.AzureTrafficCollector"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollector"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollector DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureTrafficCollector(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.AzureTrafficCollector"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollector"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollector DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureTrafficCollector(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureTrafficCollector" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AzureTrafficCollector" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20221101.IAzureTrafficCollector FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Azure Traffic Collector resource.
    [System.ComponentModel.TypeConverter(typeof(AzureTrafficCollectorTypeConverter))]
    public partial interface IAzureTrafficCollector

    {

    }
}