// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(PostgreSqlIdentityTypeConverter))]
    public partial class PostgreSqlIdentity
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.PostgreSqlIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PostgreSqlIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.PostgreSqlIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PostgreSqlIdentity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PostgreSqlIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PostgreSqlIdentity" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentity FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.PostgreSqlIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PostgreSqlIdentity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("ServerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).ServerName = (string) content.GetValueForProperty("ServerName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).ServerName, global::System.Convert.ToString);
            }
            if (content.Contains("FirewallRuleName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).FirewallRuleName = (string) content.GetValueForProperty("FirewallRuleName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).FirewallRuleName, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualNetworkRuleName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).VirtualNetworkRuleName = (string) content.GetValueForProperty("VirtualNetworkRuleName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).VirtualNetworkRuleName, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).DatabaseName = (string) content.GetValueForProperty("DatabaseName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).DatabaseName, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).ConfigurationName = (string) content.GetValueForProperty("ConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).ConfigurationName, global::System.Convert.ToString);
            }
            if (content.Contains("LocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).LocationName = (string) content.GetValueForProperty("LocationName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).LocationName, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityAlertPolicyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).SecurityAlertPolicyName = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SecurityAlertPolicyName?) content.GetValueForProperty("SecurityAlertPolicyName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).SecurityAlertPolicyName, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SecurityAlertPolicyName.CreateFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).Id, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.PostgreSqlIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PostgreSqlIdentity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("ServerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).ServerName = (string) content.GetValueForProperty("ServerName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).ServerName, global::System.Convert.ToString);
            }
            if (content.Contains("FirewallRuleName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).FirewallRuleName = (string) content.GetValueForProperty("FirewallRuleName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).FirewallRuleName, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualNetworkRuleName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).VirtualNetworkRuleName = (string) content.GetValueForProperty("VirtualNetworkRuleName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).VirtualNetworkRuleName, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).DatabaseName = (string) content.GetValueForProperty("DatabaseName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).DatabaseName, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).ConfigurationName = (string) content.GetValueForProperty("ConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).ConfigurationName, global::System.Convert.ToString);
            }
            if (content.Contains("LocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).LocationName = (string) content.GetValueForProperty("LocationName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).LocationName, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityAlertPolicyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).SecurityAlertPolicyName = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SecurityAlertPolicyName?) content.GetValueForProperty("SecurityAlertPolicyName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).SecurityAlertPolicyName, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SecurityAlertPolicyName.CreateFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentityInternal)this).Id, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(PostgreSqlIdentityTypeConverter))]
    public partial interface IPostgreSqlIdentity

    {

    }
}