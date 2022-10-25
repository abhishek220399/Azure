// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Extensions;

    public partial class CostManagementIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ICostManagementIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ICostManagementIdentityInternal
    {

        /// <summary>Backing field for <see cref="AlertId" /> property.</summary>
        private string _alertId;

        /// <summary>Alert ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public string AlertId { get => this._alertId; set => this._alertId = value; }

        /// <summary>Backing field for <see cref="BillingAccountId" /> property.</summary>
        private string _billingAccountId;

        /// <summary>Enrollment ID (Legacy BillingAccount ID)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public string BillingAccountId { get => this._billingAccountId; set => this._billingAccountId = value; }

        /// <summary>Backing field for <see cref="BillingProfileId" /> property.</summary>
        private string _billingProfileId;

        /// <summary>BillingProfile ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public string BillingProfileId { get => this._billingProfileId; set => this._billingProfileId = value; }

        /// <summary>Backing field for <see cref="ExportName" /> property.</summary>
        private string _exportName;

        /// <summary>Export Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public string ExportName { get => this._exportName; set => this._exportName = value; }

        /// <summary>Backing field for <see cref="ExternalCloudProviderId" /> property.</summary>
        private string _externalCloudProviderId;

        /// <summary>
        /// This can be '{externalSubscriptionId}' for linked account or '{externalBillingAccountId}' for consolidated account used
        /// with dimension/query operations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public string ExternalCloudProviderId { get => this._externalCloudProviderId; set => this._externalCloudProviderId = value; }

        /// <summary>Backing field for <see cref="ExternalCloudProviderType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExternalCloudProviderType? _externalCloudProviderType;

        /// <summary>
        /// The external cloud provider type associated with dimension/query operations. This includes 'externalSubscriptions' for
        /// linked account and 'externalBillingAccounts' for consolidated account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExternalCloudProviderType? ExternalCloudProviderType { get => this._externalCloudProviderType; set => this._externalCloudProviderType = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="OperationId" /> property.</summary>
        private string _operationId;

        /// <summary>The target operation Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public string OperationId { get => this._operationId; set => this._operationId = value; }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private string _scope;

        /// <summary>
        /// The scope associated with view operations. This includes 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}'
        /// for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
        /// for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
        /// for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
        /// for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}'
        /// for InvoiceSection scope, 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for Management Group scope,
        /// 'providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for External Billing Account
        /// scope and 'providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for External Subscription
        /// scope.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public string Scope { get => this._scope; set => this._scope = value; }

        /// <summary>Backing field for <see cref="ViewName" /> property.</summary>
        private string _viewName;

        /// <summary>View name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public string ViewName { get => this._viewName; set => this._viewName = value; }

        /// <summary>Creates an new <see cref="CostManagementIdentity" /> instance.</summary>
        public CostManagementIdentity()
        {

        }
    }
    public partial interface ICostManagementIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.IJsonSerializable
    {
        /// <summary>Alert ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Alert ID",
        SerializedName = @"alertId",
        PossibleTypes = new [] { typeof(string) })]
        string AlertId { get; set; }
        /// <summary>Enrollment ID (Legacy BillingAccount ID)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enrollment ID (Legacy BillingAccount ID)",
        SerializedName = @"billingAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string BillingAccountId { get; set; }
        /// <summary>BillingProfile ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"BillingProfile ID",
        SerializedName = @"billingProfileId",
        PossibleTypes = new [] { typeof(string) })]
        string BillingProfileId { get; set; }
        /// <summary>Export Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Export Name.",
        SerializedName = @"exportName",
        PossibleTypes = new [] { typeof(string) })]
        string ExportName { get; set; }
        /// <summary>
        /// This can be '{externalSubscriptionId}' for linked account or '{externalBillingAccountId}' for consolidated account used
        /// with dimension/query operations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This can be '{externalSubscriptionId}' for linked account or '{externalBillingAccountId}' for consolidated account used with dimension/query operations.",
        SerializedName = @"externalCloudProviderId",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalCloudProviderId { get; set; }
        /// <summary>
        /// The external cloud provider type associated with dimension/query operations. This includes 'externalSubscriptions' for
        /// linked account and 'externalBillingAccounts' for consolidated account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The external cloud provider type associated with dimension/query operations. This includes 'externalSubscriptions' for linked account and 'externalBillingAccounts' for consolidated account.",
        SerializedName = @"externalCloudProviderType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExternalCloudProviderType) })]
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExternalCloudProviderType? ExternalCloudProviderType { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The target operation Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target operation Id.",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string OperationId { get; set; }
        /// <summary>
        /// The scope associated with view operations. This includes 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}'
        /// for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
        /// for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
        /// for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
        /// for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}'
        /// for InvoiceSection scope, 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for Management Group scope,
        /// 'providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for External Billing Account
        /// scope and 'providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for External Subscription
        /// scope.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The scope associated with view operations. This includes 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}' for InvoiceSection scope, 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for Management Group scope, 'providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for External Billing Account scope and 'providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for External Subscription scope.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string Scope { get; set; }
        /// <summary>View name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"View name",
        SerializedName = @"viewName",
        PossibleTypes = new [] { typeof(string) })]
        string ViewName { get; set; }

    }
    public partial interface ICostManagementIdentityInternal

    {
        /// <summary>Alert ID</summary>
        string AlertId { get; set; }
        /// <summary>Enrollment ID (Legacy BillingAccount ID)</summary>
        string BillingAccountId { get; set; }
        /// <summary>BillingProfile ID</summary>
        string BillingProfileId { get; set; }
        /// <summary>Export Name.</summary>
        string ExportName { get; set; }
        /// <summary>
        /// This can be '{externalSubscriptionId}' for linked account or '{externalBillingAccountId}' for consolidated account used
        /// with dimension/query operations.
        /// </summary>
        string ExternalCloudProviderId { get; set; }
        /// <summary>
        /// The external cloud provider type associated with dimension/query operations. This includes 'externalSubscriptions' for
        /// linked account and 'externalBillingAccounts' for consolidated account.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ExternalCloudProviderType? ExternalCloudProviderType { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The target operation Id.</summary>
        string OperationId { get; set; }
        /// <summary>
        /// The scope associated with view operations. This includes 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}'
        /// for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
        /// for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
        /// for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
        /// for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}'
        /// for InvoiceSection scope, 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for Management Group scope,
        /// 'providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for External Billing Account
        /// scope and 'providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for External Subscription
        /// scope.
        /// </summary>
        string Scope { get; set; }
        /// <summary>View name</summary>
        string ViewName { get; set; }

    }
}