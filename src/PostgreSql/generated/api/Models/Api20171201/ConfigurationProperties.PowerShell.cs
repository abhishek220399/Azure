// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201
{
    using Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.PowerShell;

    /// <summary>The properties of a configuration.</summary>
    [System.ComponentModel.TypeConverter(typeof(ConfigurationPropertiesTypeConverter))]
    public partial class ConfigurationProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ConfigurationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ConfigurationProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Value"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).Value = (string) content.GetValueForProperty("Value",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).Value, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).DefaultValue = (string) content.GetValueForProperty("DefaultValue",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).DefaultValue, global::System.Convert.ToString);
            }
            if (content.Contains("DataType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).DataType = (string) content.GetValueForProperty("DataType",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).DataType, global::System.Convert.ToString);
            }
            if (content.Contains("AllowedValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).AllowedValue = (string) content.GetValueForProperty("AllowedValue",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).AllowedValue, global::System.Convert.ToString);
            }
            if (content.Contains("Source"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).Source = (string) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).Source, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ConfigurationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ConfigurationProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Value"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).Value = (string) content.GetValueForProperty("Value",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).Value, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).DefaultValue = (string) content.GetValueForProperty("DefaultValue",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).DefaultValue, global::System.Convert.ToString);
            }
            if (content.Contains("DataType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).DataType = (string) content.GetValueForProperty("DataType",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).DataType, global::System.Convert.ToString);
            }
            if (content.Contains("AllowedValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).AllowedValue = (string) content.GetValueForProperty("AllowedValue",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).AllowedValue, global::System.Convert.ToString);
            }
            if (content.Contains("Source"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).Source = (string) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationPropertiesInternal)this).Source, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ConfigurationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ConfigurationProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ConfigurationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ConfigurationProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConfigurationProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ConfigurationProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IConfigurationProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The properties of a configuration.
    [System.ComponentModel.TypeConverter(typeof(ConfigurationPropertiesTypeConverter))]
    public partial interface IConfigurationProperties

    {

    }
}