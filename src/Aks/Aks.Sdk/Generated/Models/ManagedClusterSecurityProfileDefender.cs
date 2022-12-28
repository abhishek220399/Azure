// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft Defender settings for the security profile.
    /// </summary>
    public partial class ManagedClusterSecurityProfileDefender
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterSecurityProfileDefender class.
        /// </summary>
        public ManagedClusterSecurityProfileDefender()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterSecurityProfileDefender class.
        /// </summary>
        /// <param name="logAnalyticsWorkspaceResourceId">Resource ID of the
        /// Log Analytics workspace to be associated with Microsoft Defender.
        /// When Microsoft Defender is enabled, this field is required and must
        /// be a valid workspace resource ID. When Microsoft Defender is
        /// disabled, leave the field empty.</param>
        /// <param name="securityMonitoring">Microsoft Defender threat
        /// detection for Cloud settings for the security profile.</param>
        public ManagedClusterSecurityProfileDefender(string logAnalyticsWorkspaceResourceId = default(string), ManagedClusterSecurityProfileDefenderSecurityMonitoring securityMonitoring = default(ManagedClusterSecurityProfileDefenderSecurityMonitoring))
        {
            LogAnalyticsWorkspaceResourceId = logAnalyticsWorkspaceResourceId;
            SecurityMonitoring = securityMonitoring;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource ID of the Log Analytics workspace to be
        /// associated with Microsoft Defender. When Microsoft Defender is
        /// enabled, this field is required and must be a valid workspace
        /// resource ID. When Microsoft Defender is disabled, leave the field
        /// empty.
        /// </summary>
        [JsonProperty(PropertyName = "logAnalyticsWorkspaceResourceId")]
        public string LogAnalyticsWorkspaceResourceId { get; set; }

        /// <summary>
        /// Gets or sets microsoft Defender threat detection for Cloud settings
        /// for the security profile.
        /// </summary>
        [JsonProperty(PropertyName = "securityMonitoring")]
        public ManagedClusterSecurityProfileDefenderSecurityMonitoring SecurityMonitoring { get; set; }

    }
}
