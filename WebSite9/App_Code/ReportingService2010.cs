﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using SSRS.Common;

namespace SSRS_ext
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "ReportingService2010Soap", Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExpirationDefinition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecurrencePattern))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScheduleDefinitionOrReference))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataSourceDefinitionOrReference))]
    public partial class ReportingService2010 : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private TrustedUserHeader trustedUserHeaderValueField;

        private ServerInfoHeader serverInfoHeaderValueField;

        private System.Threading.SendOrPostCallback CreateCatalogItemOperationCompleted;

        private System.Threading.SendOrPostCallback SetItemDefinitionOperationCompleted;

        private System.Threading.SendOrPostCallback GetItemDefinitionOperationCompleted;

        private System.Threading.SendOrPostCallback GetItemTypeOperationCompleted;

        private System.Threading.SendOrPostCallback DeleteItemOperationCompleted;

        private System.Threading.SendOrPostCallback MoveItemOperationCompleted;

        private System.Threading.SendOrPostCallback InheritParentSecurityOperationCompleted;

        private System.Threading.SendOrPostCallback ListItemHistoryOperationCompleted;

        private System.Threading.SendOrPostCallback ListChildrenOperationCompleted;

        private System.Threading.SendOrPostCallback ListDependentItemsOperationCompleted;

        private System.Threading.SendOrPostCallback FindItemsOperationCompleted;

        private System.Threading.SendOrPostCallback ListParentsOperationCompleted;

        private System.Threading.SendOrPostCallback CreateFolderOperationCompleted;

        private System.Threading.SendOrPostCallback SetPropertiesOperationCompleted;

        private ItemNamespaceHeader itemNamespaceHeaderValueField;

        private System.Threading.SendOrPostCallback GetPropertiesOperationCompleted;

        private System.Threading.SendOrPostCallback SetItemReferencesOperationCompleted;

        private System.Threading.SendOrPostCallback GetItemReferencesOperationCompleted;

        private System.Threading.SendOrPostCallback ListItemTypesOperationCompleted;

        private System.Threading.SendOrPostCallback SetSubscriptionPropertiesOperationCompleted;

        private System.Threading.SendOrPostCallback GetSubscriptionPropertiesOperationCompleted;

        private System.Threading.SendOrPostCallback SetDataDrivenSubscriptionPropertiesOperationCompleted;

        private System.Threading.SendOrPostCallback GetDataDrivenSubscriptionPropertiesOperationCompleted;

        private System.Threading.SendOrPostCallback DeleteSubscriptionOperationCompleted;

        private System.Threading.SendOrPostCallback CreateSubscriptionOperationCompleted;

        private System.Threading.SendOrPostCallback CreateDataDrivenSubscriptionOperationCompleted;

        private System.Threading.SendOrPostCallback GetExtensionSettingsOperationCompleted;

        private System.Threading.SendOrPostCallback ValidateExtensionSettingsOperationCompleted;

        private System.Threading.SendOrPostCallback ListSubscriptionsOperationCompleted;

        private System.Threading.SendOrPostCallback ListMySubscriptionsOperationCompleted;

        private System.Threading.SendOrPostCallback ListSubscriptionsUsingDataSourceOperationCompleted;

        private System.Threading.SendOrPostCallback ChangeSubscriptionOwnerOperationCompleted;

        private System.Threading.SendOrPostCallback CreateDataSourceOperationCompleted;

        private System.Threading.SendOrPostCallback PrepareQueryOperationCompleted;

        private System.Threading.SendOrPostCallback EnableDataSourceOperationCompleted;

        private System.Threading.SendOrPostCallback DisableDataSourceOperationCompleted;

        private System.Threading.SendOrPostCallback SetDataSourceContentsOperationCompleted;

        private System.Threading.SendOrPostCallback GetDataSourceContentsOperationCompleted;

        private System.Threading.SendOrPostCallback ListDatabaseCredentialRetrievalOptionsOperationCompleted;

        private System.Threading.SendOrPostCallback SetItemDataSourcesOperationCompleted;

        private System.Threading.SendOrPostCallback GetItemDataSourcesOperationCompleted;

        private System.Threading.SendOrPostCallback TestConnectForDataSourceDefinitionOperationCompleted;

        private System.Threading.SendOrPostCallback TestConnectForItemDataSourceOperationCompleted;

        private System.Threading.SendOrPostCallback CreateRoleOperationCompleted;

        private System.Threading.SendOrPostCallback SetRolePropertiesOperationCompleted;

        private System.Threading.SendOrPostCallback GetRolePropertiesOperationCompleted;

        private System.Threading.SendOrPostCallback DeleteRoleOperationCompleted;

        private System.Threading.SendOrPostCallback ListRolesOperationCompleted;

        private System.Threading.SendOrPostCallback ListTasksOperationCompleted;

        private System.Threading.SendOrPostCallback SetPoliciesOperationCompleted;

        private System.Threading.SendOrPostCallback GetPoliciesOperationCompleted;

        private System.Threading.SendOrPostCallback GetItemDataSourcePromptsOperationCompleted;

        private System.Threading.SendOrPostCallback GenerateModelOperationCompleted;

        private System.Threading.SendOrPostCallback GetModelItemPermissionsOperationCompleted;

        private System.Threading.SendOrPostCallback SetModelItemPoliciesOperationCompleted;

        private System.Threading.SendOrPostCallback GetModelItemPoliciesOperationCompleted;

        private System.Threading.SendOrPostCallback GetUserModelOperationCompleted;

        private System.Threading.SendOrPostCallback InheritModelItemParentSecurityOperationCompleted;

        private System.Threading.SendOrPostCallback SetModelDrillthroughReportsOperationCompleted;

        private System.Threading.SendOrPostCallback ListModelDrillthroughReportsOperationCompleted;

        private System.Threading.SendOrPostCallback ListModelItemChildrenOperationCompleted;

        private System.Threading.SendOrPostCallback ListModelItemTypesOperationCompleted;

        private System.Threading.SendOrPostCallback ListModelPerspectivesOperationCompleted;

        private System.Threading.SendOrPostCallback RegenerateModelOperationCompleted;

        private System.Threading.SendOrPostCallback RemoveAllModelItemPoliciesOperationCompleted;

        private System.Threading.SendOrPostCallback CreateScheduleOperationCompleted;

        private System.Threading.SendOrPostCallback DeleteScheduleOperationCompleted;

        private System.Threading.SendOrPostCallback ListSchedulesOperationCompleted;

        private System.Threading.SendOrPostCallback GetSchedulePropertiesOperationCompleted;

        private System.Threading.SendOrPostCallback ListScheduleStatesOperationCompleted;

        private System.Threading.SendOrPostCallback PauseScheduleOperationCompleted;

        private System.Threading.SendOrPostCallback ResumeScheduleOperationCompleted;

        private System.Threading.SendOrPostCallback SetSchedulePropertiesOperationCompleted;

        private System.Threading.SendOrPostCallback ListScheduledItemsOperationCompleted;

        private System.Threading.SendOrPostCallback SetItemParametersOperationCompleted;

        private System.Threading.SendOrPostCallback GetItemParametersOperationCompleted;

        private System.Threading.SendOrPostCallback ListParameterTypesOperationCompleted;

        private System.Threading.SendOrPostCallback ListParameterStatesOperationCompleted;

        private System.Threading.SendOrPostCallback CreateReportEditSessionOperationCompleted;

        private System.Threading.SendOrPostCallback CreateLinkedItemOperationCompleted;

        private System.Threading.SendOrPostCallback SetItemLinkOperationCompleted;

        private System.Threading.SendOrPostCallback GetItemLinkOperationCompleted;

        private System.Threading.SendOrPostCallback ListExecutionSettingsOperationCompleted;

        private System.Threading.SendOrPostCallback SetExecutionOptionsOperationCompleted;

        private System.Threading.SendOrPostCallback GetExecutionOptionsOperationCompleted;

        private System.Threading.SendOrPostCallback UpdateItemExecutionSnapshotOperationCompleted;

        private System.Threading.SendOrPostCallback SetCacheOptionsOperationCompleted;

        private System.Threading.SendOrPostCallback GetCacheOptionsOperationCompleted;

        private System.Threading.SendOrPostCallback FlushCacheOperationCompleted;

        private System.Threading.SendOrPostCallback CreateItemHistorySnapshotOperationCompleted;

        private System.Threading.SendOrPostCallback DeleteItemHistorySnapshotOperationCompleted;

        private System.Threading.SendOrPostCallback SetItemHistoryLimitOperationCompleted;

        private System.Threading.SendOrPostCallback GetItemHistoryLimitOperationCompleted;

        private System.Threading.SendOrPostCallback SetItemHistoryOptionsOperationCompleted;

        private System.Threading.SendOrPostCallback GetItemHistoryOptionsOperationCompleted;

        private System.Threading.SendOrPostCallback GetReportServerConfigInfoOperationCompleted;

        private System.Threading.SendOrPostCallback IsSSLRequiredOperationCompleted;

        private System.Threading.SendOrPostCallback SetSystemPropertiesOperationCompleted;

        private System.Threading.SendOrPostCallback GetSystemPropertiesOperationCompleted;

        private System.Threading.SendOrPostCallback SetSystemPoliciesOperationCompleted;

        private System.Threading.SendOrPostCallback GetSystemPoliciesOperationCompleted;

        private System.Threading.SendOrPostCallback ListExtensionsOperationCompleted;

        private System.Threading.SendOrPostCallback ListExtensionTypesOperationCompleted;

        private System.Threading.SendOrPostCallback ListEventsOperationCompleted;

        private System.Threading.SendOrPostCallback FireEventOperationCompleted;

        private System.Threading.SendOrPostCallback ListJobsOperationCompleted;

        private System.Threading.SendOrPostCallback ListJobTypesOperationCompleted;

        private System.Threading.SendOrPostCallback ListJobActionsOperationCompleted;

        private System.Threading.SendOrPostCallback ListJobStatesOperationCompleted;

        private System.Threading.SendOrPostCallback CancelJobOperationCompleted;

        private System.Threading.SendOrPostCallback CreateCacheRefreshPlanOperationCompleted;

        private System.Threading.SendOrPostCallback SetCacheRefreshPlanPropertiesOperationCompleted;

        private System.Threading.SendOrPostCallback GetCacheRefreshPlanPropertiesOperationCompleted;

        private System.Threading.SendOrPostCallback DeleteCacheRefreshPlanOperationCompleted;

        private System.Threading.SendOrPostCallback ListCacheRefreshPlansOperationCompleted;

        private System.Threading.SendOrPostCallback LogonUserOperationCompleted;

        private System.Threading.SendOrPostCallback LogoffOperationCompleted;

        private System.Threading.SendOrPostCallback GetPermissionsOperationCompleted;

        private System.Threading.SendOrPostCallback GetSystemPermissionsOperationCompleted;

        private System.Threading.SendOrPostCallback ListSecurityScopesOperationCompleted;

        /// <remarks/>
        public ReportingService2010()
        {
           this.Url = System.Configuration.ConfigurationManager.AppSettings["SSRSSite2010"];
        }

        public TrustedUserHeader TrustedUserHeaderValue
        {
            get
            {
                return this.trustedUserHeaderValueField;
            }
            set
            {
                this.trustedUserHeaderValueField = value;
            }
        }

        public ServerInfoHeader ServerInfoHeaderValue
        {
            get
            {
                return this.serverInfoHeaderValueField;
            }
            set
            {
                this.serverInfoHeaderValueField = value;
            }
        }

        public ItemNamespaceHeader ItemNamespaceHeaderValue
        {
            get
            {
                return this.itemNamespaceHeaderValueField;
            }
            set
            {
                this.itemNamespaceHeaderValueField = value;
            }
        }

        /// <remarks/>
        public event CreateCatalogItemCompletedEventHandler CreateCatalogItemCompleted;

        /// <remarks/>
        public event SetItemDefinitionCompletedEventHandler SetItemDefinitionCompleted;

        /// <remarks/>
        public event GetItemDefinitionCompletedEventHandler GetItemDefinitionCompleted;

        /// <remarks/>
        public event GetItemTypeCompletedEventHandler GetItemTypeCompleted;

        /// <remarks/>
        public event DeleteItemCompletedEventHandler DeleteItemCompleted;

        /// <remarks/>
        public event MoveItemCompletedEventHandler MoveItemCompleted;

        /// <remarks/>
        public event InheritParentSecurityCompletedEventHandler InheritParentSecurityCompleted;

        /// <remarks/>
        public event ListItemHistoryCompletedEventHandler ListItemHistoryCompleted;

        /// <remarks/>
        public event ListChildrenCompletedEventHandler ListChildrenCompleted;

        /// <remarks/>
        public event ListDependentItemsCompletedEventHandler ListDependentItemsCompleted;

        /// <remarks/>
        public event FindItemsCompletedEventHandler FindItemsCompleted;

        /// <remarks/>
        public event ListParentsCompletedEventHandler ListParentsCompleted;

        /// <remarks/>
        public event CreateFolderCompletedEventHandler CreateFolderCompleted;

        /// <remarks/>
        public event SetPropertiesCompletedEventHandler SetPropertiesCompleted;

        /// <remarks/>
        public event GetPropertiesCompletedEventHandler GetPropertiesCompleted;

        /// <remarks/>
        public event SetItemReferencesCompletedEventHandler SetItemReferencesCompleted;

        /// <remarks/>
        public event GetItemReferencesCompletedEventHandler GetItemReferencesCompleted;

        /// <remarks/>
        public event ListItemTypesCompletedEventHandler ListItemTypesCompleted;

        /// <remarks/>
        public event SetSubscriptionPropertiesCompletedEventHandler SetSubscriptionPropertiesCompleted;

        /// <remarks/>
        public event GetSubscriptionPropertiesCompletedEventHandler GetSubscriptionPropertiesCompleted;

        /// <remarks/>
        public event SetDataDrivenSubscriptionPropertiesCompletedEventHandler SetDataDrivenSubscriptionPropertiesCompleted;

        /// <remarks/>
        public event GetDataDrivenSubscriptionPropertiesCompletedEventHandler GetDataDrivenSubscriptionPropertiesCompleted;

        /// <remarks/>
        public event DeleteSubscriptionCompletedEventHandler DeleteSubscriptionCompleted;

        /// <remarks/>
        public event CreateSubscriptionCompletedEventHandler CreateSubscriptionCompleted;

        /// <remarks/>
        public event CreateDataDrivenSubscriptionCompletedEventHandler CreateDataDrivenSubscriptionCompleted;

        /// <remarks/>
        public event GetExtensionSettingsCompletedEventHandler GetExtensionSettingsCompleted;

        /// <remarks/>
        public event ValidateExtensionSettingsCompletedEventHandler ValidateExtensionSettingsCompleted;

        /// <remarks/>
        public event ListSubscriptionsCompletedEventHandler ListSubscriptionsCompleted;

        /// <remarks/>
        public event ListMySubscriptionsCompletedEventHandler ListMySubscriptionsCompleted;

        /// <remarks/>
        public event ListSubscriptionsUsingDataSourceCompletedEventHandler ListSubscriptionsUsingDataSourceCompleted;

        /// <remarks/>
        public event ChangeSubscriptionOwnerCompletedEventHandler ChangeSubscriptionOwnerCompleted;

        /// <remarks/>
        public event CreateDataSourceCompletedEventHandler CreateDataSourceCompleted;

        /// <remarks/>
        public event PrepareQueryCompletedEventHandler PrepareQueryCompleted;

        /// <remarks/>
        public event EnableDataSourceCompletedEventHandler EnableDataSourceCompleted;

        /// <remarks/>
        public event DisableDataSourceCompletedEventHandler DisableDataSourceCompleted;

        /// <remarks/>
        public event SetDataSourceContentsCompletedEventHandler SetDataSourceContentsCompleted;

        /// <remarks/>
        public event GetDataSourceContentsCompletedEventHandler GetDataSourceContentsCompleted;

        /// <remarks/>
        public event ListDatabaseCredentialRetrievalOptionsCompletedEventHandler ListDatabaseCredentialRetrievalOptionsCompleted;

        /// <remarks/>
        public event SetItemDataSourcesCompletedEventHandler SetItemDataSourcesCompleted;

        /// <remarks/>
        public event GetItemDataSourcesCompletedEventHandler GetItemDataSourcesCompleted;

        /// <remarks/>
        public event TestConnectForDataSourceDefinitionCompletedEventHandler TestConnectForDataSourceDefinitionCompleted;

        /// <remarks/>
        public event TestConnectForItemDataSourceCompletedEventHandler TestConnectForItemDataSourceCompleted;

        /// <remarks/>
        public event CreateRoleCompletedEventHandler CreateRoleCompleted;

        /// <remarks/>
        public event SetRolePropertiesCompletedEventHandler SetRolePropertiesCompleted;

        /// <remarks/>
        public event GetRolePropertiesCompletedEventHandler GetRolePropertiesCompleted;

        /// <remarks/>
        public event DeleteRoleCompletedEventHandler DeleteRoleCompleted;

        /// <remarks/>
        public event ListRolesCompletedEventHandler ListRolesCompleted;

        /// <remarks/>
        public event ListTasksCompletedEventHandler ListTasksCompleted;

        /// <remarks/>
        public event SetPoliciesCompletedEventHandler SetPoliciesCompleted;

        /// <remarks/>
        public event GetPoliciesCompletedEventHandler GetPoliciesCompleted;

        /// <remarks/>
        public event GetItemDataSourcePromptsCompletedEventHandler GetItemDataSourcePromptsCompleted;

        /// <remarks/>
        public event GenerateModelCompletedEventHandler GenerateModelCompleted;

        /// <remarks/>
        public event GetModelItemPermissionsCompletedEventHandler GetModelItemPermissionsCompleted;

        /// <remarks/>
        public event SetModelItemPoliciesCompletedEventHandler SetModelItemPoliciesCompleted;

        /// <remarks/>
        public event GetModelItemPoliciesCompletedEventHandler GetModelItemPoliciesCompleted;

        /// <remarks/>
        public event GetUserModelCompletedEventHandler GetUserModelCompleted;

        /// <remarks/>
        public event InheritModelItemParentSecurityCompletedEventHandler InheritModelItemParentSecurityCompleted;

        /// <remarks/>
        public event SetModelDrillthroughReportsCompletedEventHandler SetModelDrillthroughReportsCompleted;

        /// <remarks/>
        public event ListModelDrillthroughReportsCompletedEventHandler ListModelDrillthroughReportsCompleted;

        /// <remarks/>
        public event ListModelItemChildrenCompletedEventHandler ListModelItemChildrenCompleted;

        /// <remarks/>
        public event ListModelItemTypesCompletedEventHandler ListModelItemTypesCompleted;

        /// <remarks/>
        public event ListModelPerspectivesCompletedEventHandler ListModelPerspectivesCompleted;

        /// <remarks/>
        public event RegenerateModelCompletedEventHandler RegenerateModelCompleted;

        /// <remarks/>
        public event RemoveAllModelItemPoliciesCompletedEventHandler RemoveAllModelItemPoliciesCompleted;

        /// <remarks/>
        public event CreateScheduleCompletedEventHandler CreateScheduleCompleted;

        /// <remarks/>
        public event DeleteScheduleCompletedEventHandler DeleteScheduleCompleted;

        /// <remarks/>
        public event ListSchedulesCompletedEventHandler ListSchedulesCompleted;

        /// <remarks/>
        public event GetSchedulePropertiesCompletedEventHandler GetSchedulePropertiesCompleted;

        /// <remarks/>
        public event ListScheduleStatesCompletedEventHandler ListScheduleStatesCompleted;

        /// <remarks/>
        public event PauseScheduleCompletedEventHandler PauseScheduleCompleted;

        /// <remarks/>
        public event ResumeScheduleCompletedEventHandler ResumeScheduleCompleted;

        /// <remarks/>
        public event SetSchedulePropertiesCompletedEventHandler SetSchedulePropertiesCompleted;

        /// <remarks/>
        public event ListScheduledItemsCompletedEventHandler ListScheduledItemsCompleted;

        /// <remarks/>
        public event SetItemParametersCompletedEventHandler SetItemParametersCompleted;

        /// <remarks/>
        public event GetItemParametersCompletedEventHandler GetItemParametersCompleted;

        /// <remarks/>
        public event ListParameterTypesCompletedEventHandler ListParameterTypesCompleted;

        /// <remarks/>
        public event ListParameterStatesCompletedEventHandler ListParameterStatesCompleted;

        /// <remarks/>
        public event CreateReportEditSessionCompletedEventHandler CreateReportEditSessionCompleted;

        /// <remarks/>
        public event CreateLinkedItemCompletedEventHandler CreateLinkedItemCompleted;

        /// <remarks/>
        public event SetItemLinkCompletedEventHandler SetItemLinkCompleted;

        /// <remarks/>
        public event GetItemLinkCompletedEventHandler GetItemLinkCompleted;

        /// <remarks/>
        public event ListExecutionSettingsCompletedEventHandler ListExecutionSettingsCompleted;

        /// <remarks/>
        public event SetExecutionOptionsCompletedEventHandler SetExecutionOptionsCompleted;

        /// <remarks/>
        public event GetExecutionOptionsCompletedEventHandler GetExecutionOptionsCompleted;

        /// <remarks/>
        public event UpdateItemExecutionSnapshotCompletedEventHandler UpdateItemExecutionSnapshotCompleted;

        /// <remarks/>
        public event SetCacheOptionsCompletedEventHandler SetCacheOptionsCompleted;

        /// <remarks/>
        public event GetCacheOptionsCompletedEventHandler GetCacheOptionsCompleted;

        /// <remarks/>
        public event FlushCacheCompletedEventHandler FlushCacheCompleted;

        /// <remarks/>
        public event CreateItemHistorySnapshotCompletedEventHandler CreateItemHistorySnapshotCompleted;

        /// <remarks/>
        public event DeleteItemHistorySnapshotCompletedEventHandler DeleteItemHistorySnapshotCompleted;

        /// <remarks/>
        public event SetItemHistoryLimitCompletedEventHandler SetItemHistoryLimitCompleted;

        /// <remarks/>
        public event GetItemHistoryLimitCompletedEventHandler GetItemHistoryLimitCompleted;

        /// <remarks/>
        public event SetItemHistoryOptionsCompletedEventHandler SetItemHistoryOptionsCompleted;

        /// <remarks/>
        public event GetItemHistoryOptionsCompletedEventHandler GetItemHistoryOptionsCompleted;

        /// <remarks/>
        public event GetReportServerConfigInfoCompletedEventHandler GetReportServerConfigInfoCompleted;

        /// <remarks/>
        public event IsSSLRequiredCompletedEventHandler IsSSLRequiredCompleted;

        /// <remarks/>
        public event SetSystemPropertiesCompletedEventHandler SetSystemPropertiesCompleted;

        /// <remarks/>
        public event GetSystemPropertiesCompletedEventHandler GetSystemPropertiesCompleted;

        /// <remarks/>
        public event SetSystemPoliciesCompletedEventHandler SetSystemPoliciesCompleted;

        /// <remarks/>
        public event GetSystemPoliciesCompletedEventHandler GetSystemPoliciesCompleted;

        /// <remarks/>
        public event ListExtensionsCompletedEventHandler ListExtensionsCompleted;

        /// <remarks/>
        public event ListExtensionTypesCompletedEventHandler ListExtensionTypesCompleted;

        /// <remarks/>
        public event ListEventsCompletedEventHandler ListEventsCompleted;

        /// <remarks/>
        public event FireEventCompletedEventHandler FireEventCompleted;

        /// <remarks/>
        public event ListJobsCompletedEventHandler ListJobsCompleted;

        /// <remarks/>
        public event ListJobTypesCompletedEventHandler ListJobTypesCompleted;

        /// <remarks/>
        public event ListJobActionsCompletedEventHandler ListJobActionsCompleted;

        /// <remarks/>
        public event ListJobStatesCompletedEventHandler ListJobStatesCompleted;

        /// <remarks/>
        public event CancelJobCompletedEventHandler CancelJobCompleted;

        /// <remarks/>
        public event CreateCacheRefreshPlanCompletedEventHandler CreateCacheRefreshPlanCompleted;

        /// <remarks/>
        public event SetCacheRefreshPlanPropertiesCompletedEventHandler SetCacheRefreshPlanPropertiesCompleted;

        /// <remarks/>
        public event GetCacheRefreshPlanPropertiesCompletedEventHandler GetCacheRefreshPlanPropertiesCompleted;

        /// <remarks/>
        public event DeleteCacheRefreshPlanCompletedEventHandler DeleteCacheRefreshPlanCompleted;

        /// <remarks/>
        public event ListCacheRefreshPlansCompletedEventHandler ListCacheRefreshPlansCompleted;

        /// <remarks/>
        public event LogonUserCompletedEventHandler LogonUserCompleted;

        /// <remarks/>
        public event LogoffCompletedEventHandler LogoffCompleted;

        /// <remarks/>
        public event GetPermissionsCompletedEventHandler GetPermissionsCompleted;

        /// <remarks/>
        public event GetSystemPermissionsCompletedEventHandler GetSystemPermissionsCompleted;

        /// <remarks/>
        public event ListSecurityScopesCompletedEventHandler ListSecurityScopesCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateCa" +
            "talogItem", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ItemInfo")]
        public CatalogItem CreateCatalogItem(string ItemType, string Name, string Parent, bool Overwrite, [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")] byte[] Definition, Property[] Properties, out Warning[] Warnings)
        {
            object[] results = this.Invoke("CreateCatalogItem", new object[] {
                    ItemType,
                    Name,
                    Parent,
                    Overwrite,
                    Definition,
                    Properties});
            Warnings = ((Warning[])(results[1]));
            return ((CatalogItem)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginCreateCatalogItem(string ItemType, string Name, string Parent, bool Overwrite, byte[] Definition, Property[] Properties, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("CreateCatalogItem", new object[] {
                    ItemType,
                    Name,
                    Parent,
                    Overwrite,
                    Definition,
                    Properties}, callback, asyncState);
        }

        /// <remarks/>
        public CatalogItem EndCreateCatalogItem(System.IAsyncResult asyncResult, out Warning[] Warnings)
        {
            object[] results = this.EndInvoke(asyncResult);
            Warnings = ((Warning[])(results[1]));
            return ((CatalogItem)(results[0]));
        }

        /// <remarks/>
        public void CreateCatalogItemAsync(string ItemType, string Name, string Parent, bool Overwrite, byte[] Definition, Property[] Properties)
        {
            this.CreateCatalogItemAsync(ItemType, Name, Parent, Overwrite, Definition, Properties, null);
        }

        /// <remarks/>
        public void CreateCatalogItemAsync(string ItemType, string Name, string Parent, bool Overwrite, byte[] Definition, Property[] Properties, object userState)
        {
            if ((this.CreateCatalogItemOperationCompleted == null))
            {
                this.CreateCatalogItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateCatalogItemOperationCompleted);
            }
            this.InvokeAsync("CreateCatalogItem", new object[] {
                    ItemType,
                    Name,
                    Parent,
                    Overwrite,
                    Definition,
                    Properties}, this.CreateCatalogItemOperationCompleted, userState);
        }

        private void OnCreateCatalogItemOperationCompleted(object arg)
        {
            if ((this.CreateCatalogItemCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateCatalogItemCompleted(this, new CreateCatalogItemCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemD" +
            "efinition", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Warnings")]
        public Warning[] SetItemDefinition(string ItemPath, [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")] byte[] Definition, Property[] Properties)
        {
            object[] results = this.Invoke("SetItemDefinition", new object[] {
                    ItemPath,
                    Definition,
                    Properties});
            return ((Warning[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetItemDefinition(string ItemPath, byte[] Definition, Property[] Properties, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetItemDefinition", new object[] {
                    ItemPath,
                    Definition,
                    Properties}, callback, asyncState);
        }

        /// <remarks/>
        public Warning[] EndSetItemDefinition(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((Warning[])(results[0]));
        }

        /// <remarks/>
        public void SetItemDefinitionAsync(string ItemPath, byte[] Definition, Property[] Properties)
        {
            this.SetItemDefinitionAsync(ItemPath, Definition, Properties, null);
        }

        /// <remarks/>
        public void SetItemDefinitionAsync(string ItemPath, byte[] Definition, Property[] Properties, object userState)
        {
            if ((this.SetItemDefinitionOperationCompleted == null))
            {
                this.SetItemDefinitionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetItemDefinitionOperationCompleted);
            }
            this.InvokeAsync("SetItemDefinition", new object[] {
                    ItemPath,
                    Definition,
                    Properties}, this.SetItemDefinitionOperationCompleted, userState);
        }

        private void OnSetItemDefinitionOperationCompleted(object arg)
        {
            if ((this.SetItemDefinitionCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetItemDefinitionCompleted(this, new SetItemDefinitionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemD" +
            "efinition", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Definition", DataType = "base64Binary")]
        public byte[] GetItemDefinition(string ItemPath)
        {
            object[] results = this.Invoke("GetItemDefinition", new object[] {
                    ItemPath});
            return ((byte[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetItemDefinition(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetItemDefinition", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public byte[] EndGetItemDefinition(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((byte[])(results[0]));
        }

        /// <remarks/>
        public void GetItemDefinitionAsync(string ItemPath)
        {
            this.GetItemDefinitionAsync(ItemPath, null);
        }

        /// <remarks/>
        public void GetItemDefinitionAsync(string ItemPath, object userState)
        {
            if ((this.GetItemDefinitionOperationCompleted == null))
            {
                this.GetItemDefinitionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetItemDefinitionOperationCompleted);
            }
            this.InvokeAsync("GetItemDefinition", new object[] {
                    ItemPath}, this.GetItemDefinitionOperationCompleted, userState);
        }

        private void OnGetItemDefinitionOperationCompleted(object arg)
        {
            if ((this.GetItemDefinitionCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetItemDefinitionCompleted(this, new GetItemDefinitionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemT" +
            "ype", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Type")]
        public string GetItemType(string ItemPath)
        {
            object[] results = this.Invoke("GetItemType", new object[] {
                    ItemPath});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetItemType(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetItemType", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public string EndGetItemType(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void GetItemTypeAsync(string ItemPath)
        {
            this.GetItemTypeAsync(ItemPath, null);
        }

        /// <remarks/>
        public void GetItemTypeAsync(string ItemPath, object userState)
        {
            if ((this.GetItemTypeOperationCompleted == null))
            {
                this.GetItemTypeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetItemTypeOperationCompleted);
            }
            this.InvokeAsync("GetItemType", new object[] {
                    ItemPath}, this.GetItemTypeOperationCompleted, userState);
        }

        private void OnGetItemTypeOperationCompleted(object arg)
        {
            if ((this.GetItemTypeCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetItemTypeCompleted(this, new GetItemTypeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteIt" +
            "em", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteItem(string ItemPath)
        {
            this.Invoke("DeleteItem", new object[] {
                    ItemPath});
        }

        /// <remarks/>
        public System.IAsyncResult BeginDeleteItem(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("DeleteItem", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public void EndDeleteItem(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void DeleteItemAsync(string ItemPath)
        {
            this.DeleteItemAsync(ItemPath, null);
        }

        /// <remarks/>
        public void DeleteItemAsync(string ItemPath, object userState)
        {
            if ((this.DeleteItemOperationCompleted == null))
            {
                this.DeleteItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteItemOperationCompleted);
            }
            this.InvokeAsync("DeleteItem", new object[] {
                    ItemPath}, this.DeleteItemOperationCompleted, userState);
        }

        private void OnDeleteItemOperationCompleted(object arg)
        {
            if ((this.DeleteItemCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteItemCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/MoveItem" +
            "", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void MoveItem(string ItemPath, string Target)
        {
            this.Invoke("MoveItem", new object[] {
                    ItemPath,
                    Target});
        }

        /// <remarks/>
        public System.IAsyncResult BeginMoveItem(string ItemPath, string Target, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("MoveItem", new object[] {
                    ItemPath,
                    Target}, callback, asyncState);
        }

        /// <remarks/>
        public void EndMoveItem(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void MoveItemAsync(string ItemPath, string Target)
        {
            this.MoveItemAsync(ItemPath, Target, null);
        }

        /// <remarks/>
        public void MoveItemAsync(string ItemPath, string Target, object userState)
        {
            if ((this.MoveItemOperationCompleted == null))
            {
                this.MoveItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMoveItemOperationCompleted);
            }
            this.InvokeAsync("MoveItem", new object[] {
                    ItemPath,
                    Target}, this.MoveItemOperationCompleted, userState);
        }

        private void OnMoveItemOperationCompleted(object arg)
        {
            if ((this.MoveItemCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MoveItemCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/InheritP" +
            "arentSecurity", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void InheritParentSecurity(string ItemPath)
        {
            this.Invoke("InheritParentSecurity", new object[] {
                    ItemPath});
        }

        /// <remarks/>
        public System.IAsyncResult BeginInheritParentSecurity(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("InheritParentSecurity", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public void EndInheritParentSecurity(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void InheritParentSecurityAsync(string ItemPath)
        {
            this.InheritParentSecurityAsync(ItemPath, null);
        }

        /// <remarks/>
        public void InheritParentSecurityAsync(string ItemPath, object userState)
        {
            if ((this.InheritParentSecurityOperationCompleted == null))
            {
                this.InheritParentSecurityOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInheritParentSecurityOperationCompleted);
            }
            this.InvokeAsync("InheritParentSecurity", new object[] {
                    ItemPath}, this.InheritParentSecurityOperationCompleted, userState);
        }

        private void OnInheritParentSecurityOperationCompleted(object arg)
        {
            if ((this.InheritParentSecurityCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InheritParentSecurityCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListItem" +
            "History", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("ItemHistory")]
        public ItemHistorySnapshot[] ListItemHistory(string ItemPath)
        {
            object[] results = this.Invoke("ListItemHistory", new object[] {
                    ItemPath});
            return ((ItemHistorySnapshot[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListItemHistory(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListItemHistory", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public ItemHistorySnapshot[] EndListItemHistory(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ItemHistorySnapshot[])(results[0]));
        }

        /// <remarks/>
        public void ListItemHistoryAsync(string ItemPath)
        {
            this.ListItemHistoryAsync(ItemPath, null);
        }

        /// <remarks/>
        public void ListItemHistoryAsync(string ItemPath, object userState)
        {
            if ((this.ListItemHistoryOperationCompleted == null))
            {
                this.ListItemHistoryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListItemHistoryOperationCompleted);
            }
            this.InvokeAsync("ListItemHistory", new object[] {
                    ItemPath}, this.ListItemHistoryOperationCompleted, userState);
        }

        private void OnListItemHistoryOperationCompleted(object arg)
        {
            if ((this.ListItemHistoryCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListItemHistoryCompleted(this, new ListItemHistoryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListChil" +
            "dren", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("CatalogItems")]
        public CatalogItem[] ListChildren(string ItemPath, bool Recursive)
        {
            object[] results = this.Invoke("ListChildren", new object[] {
                    ItemPath,
                    Recursive});
            return ((CatalogItem[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListChildren(string ItemPath, bool Recursive, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListChildren", new object[] {
                    ItemPath,
                    Recursive}, callback, asyncState);
        }

        /// <remarks/>
        public CatalogItem[] EndListChildren(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((CatalogItem[])(results[0]));
        }

        /// <remarks/>
        public void ListChildrenAsync(string ItemPath, bool Recursive)
        {
            this.ListChildrenAsync(ItemPath, Recursive, null);
        }

        /// <remarks/>
        public void ListChildrenAsync(string ItemPath, bool Recursive, object userState)
        {
            if ((this.ListChildrenOperationCompleted == null))
            {
                this.ListChildrenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListChildrenOperationCompleted);
            }
            this.InvokeAsync("ListChildren", new object[] {
                    ItemPath,
                    Recursive}, this.ListChildrenOperationCompleted, userState);
        }

        private void OnListChildrenOperationCompleted(object arg)
        {
            if ((this.ListChildrenCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListChildrenCompleted(this, new ListChildrenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListDepe" +
            "ndentItems", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("CatalogItems")]
        public CatalogItem[] ListDependentItems(string ItemPath)
        {
            object[] results = this.Invoke("ListDependentItems", new object[] {
                    ItemPath});
            return ((CatalogItem[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListDependentItems(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListDependentItems", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public CatalogItem[] EndListDependentItems(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((CatalogItem[])(results[0]));
        }

        /// <remarks/>
        public void ListDependentItemsAsync(string ItemPath)
        {
            this.ListDependentItemsAsync(ItemPath, null);
        }

        /// <remarks/>
        public void ListDependentItemsAsync(string ItemPath, object userState)
        {
            if ((this.ListDependentItemsOperationCompleted == null))
            {
                this.ListDependentItemsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListDependentItemsOperationCompleted);
            }
            this.InvokeAsync("ListDependentItems", new object[] {
                    ItemPath}, this.ListDependentItemsOperationCompleted, userState);
        }

        private void OnListDependentItemsOperationCompleted(object arg)
        {
            if ((this.ListDependentItemsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListDependentItemsCompleted(this, new ListDependentItemsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/FindItem" +
            "s", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Items")]
        public CatalogItem[] FindItems(string Folder, BooleanOperatorEnum BooleanOperator, Property[] SearchOptions, SearchCondition[] SearchConditions)
        {
            object[] results = this.Invoke("FindItems", new object[] {
                    Folder,
                    BooleanOperator,
                    SearchOptions,
                    SearchConditions});
            return ((CatalogItem[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginFindItems(string Folder, BooleanOperatorEnum BooleanOperator, Property[] SearchOptions, SearchCondition[] SearchConditions, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("FindItems", new object[] {
                    Folder,
                    BooleanOperator,
                    SearchOptions,
                    SearchConditions}, callback, asyncState);
        }

        /// <remarks/>
        public CatalogItem[] EndFindItems(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((CatalogItem[])(results[0]));
        }

        /// <remarks/>
        public void FindItemsAsync(string Folder, BooleanOperatorEnum BooleanOperator, Property[] SearchOptions, SearchCondition[] SearchConditions)
        {
            this.FindItemsAsync(Folder, BooleanOperator, SearchOptions, SearchConditions, null);
        }

        /// <remarks/>
        public void FindItemsAsync(string Folder, BooleanOperatorEnum BooleanOperator, Property[] SearchOptions, SearchCondition[] SearchConditions, object userState)
        {
            if ((this.FindItemsOperationCompleted == null))
            {
                this.FindItemsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindItemsOperationCompleted);
            }
            this.InvokeAsync("FindItems", new object[] {
                    Folder,
                    BooleanOperator,
                    SearchOptions,
                    SearchConditions}, this.FindItemsOperationCompleted, userState);
        }

        private void OnFindItemsOperationCompleted(object arg)
        {
            if ((this.FindItemsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindItemsCompleted(this, new FindItemsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListPare" +
            "nts", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CatalogItem[] ListParents(string ItemPath)
        {
            object[] results = this.Invoke("ListParents", new object[] {
                    ItemPath});
            return ((CatalogItem[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListParents(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListParents", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public CatalogItem[] EndListParents(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((CatalogItem[])(results[0]));
        }

        /// <remarks/>
        public void ListParentsAsync(string ItemPath)
        {
            this.ListParentsAsync(ItemPath, null);
        }

        /// <remarks/>
        public void ListParentsAsync(string ItemPath, object userState)
        {
            if ((this.ListParentsOperationCompleted == null))
            {
                this.ListParentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListParentsOperationCompleted);
            }
            this.InvokeAsync("ListParents", new object[] {
                    ItemPath}, this.ListParentsOperationCompleted, userState);
        }

        private void OnListParentsOperationCompleted(object arg)
        {
            if ((this.ListParentsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListParentsCompleted(this, new ListParentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateFo" +
            "lder", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ItemInfo")]
        public CatalogItem CreateFolder(string Folder, string Parent, Property[] Properties)
        {
            object[] results = this.Invoke("CreateFolder", new object[] {
                    Folder,
                    Parent,
                    Properties});
            return ((CatalogItem)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginCreateFolder(string Folder, string Parent, Property[] Properties, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("CreateFolder", new object[] {
                    Folder,
                    Parent,
                    Properties}, callback, asyncState);
        }

        /// <remarks/>
        public CatalogItem EndCreateFolder(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((CatalogItem)(results[0]));
        }

        /// <remarks/>
        public void CreateFolderAsync(string Folder, string Parent, Property[] Properties)
        {
            this.CreateFolderAsync(Folder, Parent, Properties, null);
        }

        /// <remarks/>
        public void CreateFolderAsync(string Folder, string Parent, Property[] Properties, object userState)
        {
            if ((this.CreateFolderOperationCompleted == null))
            {
                this.CreateFolderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateFolderOperationCompleted);
            }
            this.InvokeAsync("CreateFolder", new object[] {
                    Folder,
                    Parent,
                    Properties}, this.CreateFolderOperationCompleted, userState);
        }

        private void OnCreateFolderOperationCompleted(object arg)
        {
            if ((this.CreateFolderCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateFolderCompleted(this, new CreateFolderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetPrope" +
            "rties", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetProperties(string ItemPath, Property[] Properties)
        {
            this.Invoke("SetProperties", new object[] {
                    ItemPath,
                    Properties});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetProperties(string ItemPath, Property[] Properties, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetProperties", new object[] {
                    ItemPath,
                    Properties}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetProperties(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetPropertiesAsync(string ItemPath, Property[] Properties)
        {
            this.SetPropertiesAsync(ItemPath, Properties, null);
        }

        /// <remarks/>
        public void SetPropertiesAsync(string ItemPath, Property[] Properties, object userState)
        {
            if ((this.SetPropertiesOperationCompleted == null))
            {
                this.SetPropertiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetPropertiesOperationCompleted);
            }
            this.InvokeAsync("SetProperties", new object[] {
                    ItemPath,
                    Properties}, this.SetPropertiesOperationCompleted, userState);
        }

        private void OnSetPropertiesOperationCompleted(object arg)
        {
            if ((this.SetPropertiesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetPropertiesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ItemNamespaceHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetPrope" +
            "rties", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Values")]
        public Property[] GetProperties(string ItemPath, Property[] Properties)
        {
            object[] results = this.Invoke("GetProperties", new object[] {
                    ItemPath,
                    Properties});
            return ((Property[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetProperties(string ItemPath, Property[] Properties, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetProperties", new object[] {
                    ItemPath,
                    Properties}, callback, asyncState);
        }

        /// <remarks/>
        public Property[] EndGetProperties(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((Property[])(results[0]));
        }

        /// <remarks/>
        public void GetPropertiesAsync(string ItemPath, Property[] Properties)
        {
            this.GetPropertiesAsync(ItemPath, Properties, null);
        }

        /// <remarks/>
        public void GetPropertiesAsync(string ItemPath, Property[] Properties, object userState)
        {
            if ((this.GetPropertiesOperationCompleted == null))
            {
                this.GetPropertiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPropertiesOperationCompleted);
            }
            this.InvokeAsync("GetProperties", new object[] {
                    ItemPath,
                    Properties}, this.GetPropertiesOperationCompleted, userState);
        }

        private void OnGetPropertiesOperationCompleted(object arg)
        {
            if ((this.GetPropertiesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPropertiesCompleted(this, new GetPropertiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemR" +
            "eferences", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetItemReferences(string ItemPath, ItemReference[] ItemReferences)
        {
            this.Invoke("SetItemReferences", new object[] {
                    ItemPath,
                    ItemReferences});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetItemReferences(string ItemPath, ItemReference[] ItemReferences, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetItemReferences", new object[] {
                    ItemPath,
                    ItemReferences}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetItemReferences(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetItemReferencesAsync(string ItemPath, ItemReference[] ItemReferences)
        {
            this.SetItemReferencesAsync(ItemPath, ItemReferences, null);
        }

        /// <remarks/>
        public void SetItemReferencesAsync(string ItemPath, ItemReference[] ItemReferences, object userState)
        {
            if ((this.SetItemReferencesOperationCompleted == null))
            {
                this.SetItemReferencesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetItemReferencesOperationCompleted);
            }
            this.InvokeAsync("SetItemReferences", new object[] {
                    ItemPath,
                    ItemReferences}, this.SetItemReferencesOperationCompleted, userState);
        }

        private void OnSetItemReferencesOperationCompleted(object arg)
        {
            if ((this.SetItemReferencesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetItemReferencesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemR" +
            "eferences", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("ItemReferences")]
        public ItemReferenceData[] GetItemReferences(string ItemPath, string ReferenceItemType)
        {
            object[] results = this.Invoke("GetItemReferences", new object[] {
                    ItemPath,
                    ReferenceItemType});
            return ((ItemReferenceData[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetItemReferences(string ItemPath, string ReferenceItemType, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetItemReferences", new object[] {
                    ItemPath,
                    ReferenceItemType}, callback, asyncState);
        }

        /// <remarks/>
        public ItemReferenceData[] EndGetItemReferences(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ItemReferenceData[])(results[0]));
        }

        /// <remarks/>
        public void GetItemReferencesAsync(string ItemPath, string ReferenceItemType)
        {
            this.GetItemReferencesAsync(ItemPath, ReferenceItemType, null);
        }

        /// <remarks/>
        public void GetItemReferencesAsync(string ItemPath, string ReferenceItemType, object userState)
        {
            if ((this.GetItemReferencesOperationCompleted == null))
            {
                this.GetItemReferencesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetItemReferencesOperationCompleted);
            }
            this.InvokeAsync("GetItemReferences", new object[] {
                    ItemPath,
                    ReferenceItemType}, this.GetItemReferencesOperationCompleted, userState);
        }

        private void OnGetItemReferencesOperationCompleted(object arg)
        {
            if ((this.GetItemReferencesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetItemReferencesCompleted(this, new GetItemReferencesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListItem" +
            "Types", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] ListItemTypes()
        {
            object[] results = this.Invoke("ListItemTypes", new object[0]);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListItemTypes(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListItemTypes", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public string[] EndListItemTypes(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void ListItemTypesAsync()
        {
            this.ListItemTypesAsync(null);
        }

        /// <remarks/>
        public void ListItemTypesAsync(object userState)
        {
            if ((this.ListItemTypesOperationCompleted == null))
            {
                this.ListItemTypesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListItemTypesOperationCompleted);
            }
            this.InvokeAsync("ListItemTypes", new object[0], this.ListItemTypesOperationCompleted, userState);
        }

        private void OnListItemTypesOperationCompleted(object arg)
        {
            if ((this.ListItemTypesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListItemTypesCompleted(this, new ListItemTypesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetSubsc" +
            "riptionProperties", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetSubscriptionProperties(string SubscriptionID, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
        {
            this.Invoke("SetSubscriptionProperties", new object[] {
                    SubscriptionID,
                    ExtensionSettings,
                    Description,
                    EventType,
                    MatchData,
                    Parameters});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetSubscriptionProperties(string SubscriptionID, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetSubscriptionProperties", new object[] {
                    SubscriptionID,
                    ExtensionSettings,
                    Description,
                    EventType,
                    MatchData,
                    Parameters}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetSubscriptionProperties(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetSubscriptionPropertiesAsync(string SubscriptionID, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
        {
            this.SetSubscriptionPropertiesAsync(SubscriptionID, ExtensionSettings, Description, EventType, MatchData, Parameters, null);
        }

        /// <remarks/>
        public void SetSubscriptionPropertiesAsync(string SubscriptionID, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters, object userState)
        {
            if ((this.SetSubscriptionPropertiesOperationCompleted == null))
            {
                this.SetSubscriptionPropertiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetSubscriptionPropertiesOperationCompleted);
            }
            this.InvokeAsync("SetSubscriptionProperties", new object[] {
                    SubscriptionID,
                    ExtensionSettings,
                    Description,
                    EventType,
                    MatchData,
                    Parameters}, this.SetSubscriptionPropertiesOperationCompleted, userState);
        }

        private void OnSetSubscriptionPropertiesOperationCompleted(object arg)
        {
            if ((this.SetSubscriptionPropertiesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetSubscriptionPropertiesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSubsc" +
            "riptionProperties", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Owner")]
        public string GetSubscriptionProperties(string SubscriptionID, out ExtensionSettings ExtensionSettings, out string Description, out ActiveState Active, out string Status, out string EventType, out string MatchData, out ParameterValue[] Parameters)
        {
            object[] results = this.Invoke("GetSubscriptionProperties", new object[] {
                    SubscriptionID});
            ExtensionSettings = ((ExtensionSettings)(results[1]));
            Description = ((string)(results[2]));
            Active = ((ActiveState)(results[3]));
            Status = ((string)(results[4]));
            EventType = ((string)(results[5]));
            MatchData = ((string)(results[6]));
            Parameters = ((ParameterValue[])(results[7]));
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetSubscriptionProperties(string SubscriptionID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetSubscriptionProperties", new object[] {
                    SubscriptionID}, callback, asyncState);
        }

        /// <remarks/>
        public string EndGetSubscriptionProperties(System.IAsyncResult asyncResult, out ExtensionSettings ExtensionSettings, out string Description, out ActiveState Active, out string Status, out string EventType, out string MatchData, out ParameterValue[] Parameters)
        {
            object[] results = this.EndInvoke(asyncResult);
            ExtensionSettings = ((ExtensionSettings)(results[1]));
            Description = ((string)(results[2]));
            Active = ((ActiveState)(results[3]));
            Status = ((string)(results[4]));
            EventType = ((string)(results[5]));
            MatchData = ((string)(results[6]));
            Parameters = ((ParameterValue[])(results[7]));
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void GetSubscriptionPropertiesAsync(string SubscriptionID)
        {
            this.GetSubscriptionPropertiesAsync(SubscriptionID, null);
        }

        /// <remarks/>
        public void GetSubscriptionPropertiesAsync(string SubscriptionID, object userState)
        {
            if ((this.GetSubscriptionPropertiesOperationCompleted == null))
            {
                this.GetSubscriptionPropertiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSubscriptionPropertiesOperationCompleted);
            }
            this.InvokeAsync("GetSubscriptionProperties", new object[] {
                    SubscriptionID}, this.GetSubscriptionPropertiesOperationCompleted, userState);
        }

        private void OnGetSubscriptionPropertiesOperationCompleted(object arg)
        {
            if ((this.GetSubscriptionPropertiesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSubscriptionPropertiesCompleted(this, new GetSubscriptionPropertiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetDataD" +
            "rivenSubscriptionProperties", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetDataDrivenSubscriptionProperties(string DataDrivenSubscriptionID, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters)
        {
            this.Invoke("SetDataDrivenSubscriptionProperties", new object[] {
                    DataDrivenSubscriptionID,
                    ExtensionSettings,
                    DataRetrievalPlan,
                    Description,
                    EventType,
                    MatchData,
                    Parameters});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetDataDrivenSubscriptionProperties(string DataDrivenSubscriptionID, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetDataDrivenSubscriptionProperties", new object[] {
                    DataDrivenSubscriptionID,
                    ExtensionSettings,
                    DataRetrievalPlan,
                    Description,
                    EventType,
                    MatchData,
                    Parameters}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetDataDrivenSubscriptionProperties(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetDataDrivenSubscriptionPropertiesAsync(string DataDrivenSubscriptionID, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters)
        {
            this.SetDataDrivenSubscriptionPropertiesAsync(DataDrivenSubscriptionID, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters, null);
        }

        /// <remarks/>
        public void SetDataDrivenSubscriptionPropertiesAsync(string DataDrivenSubscriptionID, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters, object userState)
        {
            if ((this.SetDataDrivenSubscriptionPropertiesOperationCompleted == null))
            {
                this.SetDataDrivenSubscriptionPropertiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetDataDrivenSubscriptionPropertiesOperationCompleted);
            }
            this.InvokeAsync("SetDataDrivenSubscriptionProperties", new object[] {
                    DataDrivenSubscriptionID,
                    ExtensionSettings,
                    DataRetrievalPlan,
                    Description,
                    EventType,
                    MatchData,
                    Parameters}, this.SetDataDrivenSubscriptionPropertiesOperationCompleted, userState);
        }

        private void OnSetDataDrivenSubscriptionPropertiesOperationCompleted(object arg)
        {
            if ((this.SetDataDrivenSubscriptionPropertiesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetDataDrivenSubscriptionPropertiesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetDataD" +
            "rivenSubscriptionProperties", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Owner")]
        public string GetDataDrivenSubscriptionProperties(string DataDrivenSubscriptionID, out ExtensionSettings ExtensionSettings, out DataRetrievalPlan DataRetrievalPlan, out string Description, out ActiveState Active, out string Status, out string EventType, out string MatchData, out ParameterValueOrFieldReference[] Parameters)
        {
            object[] results = this.Invoke("GetDataDrivenSubscriptionProperties", new object[] {
                    DataDrivenSubscriptionID});
            ExtensionSettings = ((ExtensionSettings)(results[1]));
            DataRetrievalPlan = ((DataRetrievalPlan)(results[2]));
            Description = ((string)(results[3]));
            Active = ((ActiveState)(results[4]));
            Status = ((string)(results[5]));
            EventType = ((string)(results[6]));
            MatchData = ((string)(results[7]));
            Parameters = ((ParameterValueOrFieldReference[])(results[8]));
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetDataDrivenSubscriptionProperties(string DataDrivenSubscriptionID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetDataDrivenSubscriptionProperties", new object[] {
                    DataDrivenSubscriptionID}, callback, asyncState);
        }

        /// <remarks/>
        public string EndGetDataDrivenSubscriptionProperties(System.IAsyncResult asyncResult, out ExtensionSettings ExtensionSettings, out DataRetrievalPlan DataRetrievalPlan, out string Description, out ActiveState Active, out string Status, out string EventType, out string MatchData, out ParameterValueOrFieldReference[] Parameters)
        {
            object[] results = this.EndInvoke(asyncResult);
            ExtensionSettings = ((ExtensionSettings)(results[1]));
            DataRetrievalPlan = ((DataRetrievalPlan)(results[2]));
            Description = ((string)(results[3]));
            Active = ((ActiveState)(results[4]));
            Status = ((string)(results[5]));
            EventType = ((string)(results[6]));
            MatchData = ((string)(results[7]));
            Parameters = ((ParameterValueOrFieldReference[])(results[8]));
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void GetDataDrivenSubscriptionPropertiesAsync(string DataDrivenSubscriptionID)
        {
            this.GetDataDrivenSubscriptionPropertiesAsync(DataDrivenSubscriptionID, null);
        }

        /// <remarks/>
        public void GetDataDrivenSubscriptionPropertiesAsync(string DataDrivenSubscriptionID, object userState)
        {
            if ((this.GetDataDrivenSubscriptionPropertiesOperationCompleted == null))
            {
                this.GetDataDrivenSubscriptionPropertiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataDrivenSubscriptionPropertiesOperationCompleted);
            }
            this.InvokeAsync("GetDataDrivenSubscriptionProperties", new object[] {
                    DataDrivenSubscriptionID}, this.GetDataDrivenSubscriptionPropertiesOperationCompleted, userState);
        }

        private void OnGetDataDrivenSubscriptionPropertiesOperationCompleted(object arg)
        {
            if ((this.GetDataDrivenSubscriptionPropertiesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataDrivenSubscriptionPropertiesCompleted(this, new GetDataDrivenSubscriptionPropertiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteSu" +
            "bscription", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteSubscription(string SubscriptionID)
        {
            this.Invoke("DeleteSubscription", new object[] {
                    SubscriptionID});
        }

        /// <remarks/>
        public System.IAsyncResult BeginDeleteSubscription(string SubscriptionID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("DeleteSubscription", new object[] {
                    SubscriptionID}, callback, asyncState);
        }

        /// <remarks/>
        public void EndDeleteSubscription(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void DeleteSubscriptionAsync(string SubscriptionID)
        {
            this.DeleteSubscriptionAsync(SubscriptionID, null);
        }

        /// <remarks/>
        public void DeleteSubscriptionAsync(string SubscriptionID, object userState)
        {
            if ((this.DeleteSubscriptionOperationCompleted == null))
            {
                this.DeleteSubscriptionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteSubscriptionOperationCompleted);
            }
            this.InvokeAsync("DeleteSubscription", new object[] {
                    SubscriptionID}, this.DeleteSubscriptionOperationCompleted, userState);
        }

        private void OnDeleteSubscriptionOperationCompleted(object arg)
        {
            if ((this.DeleteSubscriptionCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteSubscriptionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateSu" +
            "bscription", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("SubscriptionID")]
        public string CreateSubscription(string ItemPath, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
        {
            object[] results = this.Invoke("CreateSubscription", new object[] {
                    ItemPath,
                    ExtensionSettings,
                    Description,
                    EventType,
                    MatchData,
                    Parameters});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginCreateSubscription(string ItemPath, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("CreateSubscription", new object[] {
                    ItemPath,
                    ExtensionSettings,
                    Description,
                    EventType,
                    MatchData,
                    Parameters}, callback, asyncState);
        }

        /// <remarks/>
        public string EndCreateSubscription(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void CreateSubscriptionAsync(string ItemPath, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
        {
            this.CreateSubscriptionAsync(ItemPath, ExtensionSettings, Description, EventType, MatchData, Parameters, null);
        }

        /// <remarks/>
        public void CreateSubscriptionAsync(string ItemPath, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters, object userState)
        {
            if ((this.CreateSubscriptionOperationCompleted == null))
            {
                this.CreateSubscriptionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateSubscriptionOperationCompleted);
            }
            this.InvokeAsync("CreateSubscription", new object[] {
                    ItemPath,
                    ExtensionSettings,
                    Description,
                    EventType,
                    MatchData,
                    Parameters}, this.CreateSubscriptionOperationCompleted, userState);
        }

        private void OnCreateSubscriptionOperationCompleted(object arg)
        {
            if ((this.CreateSubscriptionCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateSubscriptionCompleted(this, new CreateSubscriptionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateDa" +
            "taDrivenSubscription", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("SubscriptionID")]
        public string CreateDataDrivenSubscription(string ItemPath, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters)
        {
            object[] results = this.Invoke("CreateDataDrivenSubscription", new object[] {
                    ItemPath,
                    ExtensionSettings,
                    DataRetrievalPlan,
                    Description,
                    EventType,
                    MatchData,
                    Parameters});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginCreateDataDrivenSubscription(string ItemPath, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("CreateDataDrivenSubscription", new object[] {
                    ItemPath,
                    ExtensionSettings,
                    DataRetrievalPlan,
                    Description,
                    EventType,
                    MatchData,
                    Parameters}, callback, asyncState);
        }

        /// <remarks/>
        public string EndCreateDataDrivenSubscription(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void CreateDataDrivenSubscriptionAsync(string ItemPath, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters)
        {
            this.CreateDataDrivenSubscriptionAsync(ItemPath, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters, null);
        }

        /// <remarks/>
        public void CreateDataDrivenSubscriptionAsync(string ItemPath, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters, object userState)
        {
            if ((this.CreateDataDrivenSubscriptionOperationCompleted == null))
            {
                this.CreateDataDrivenSubscriptionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateDataDrivenSubscriptionOperationCompleted);
            }
            this.InvokeAsync("CreateDataDrivenSubscription", new object[] {
                    ItemPath,
                    ExtensionSettings,
                    DataRetrievalPlan,
                    Description,
                    EventType,
                    MatchData,
                    Parameters}, this.CreateDataDrivenSubscriptionOperationCompleted, userState);
        }

        private void OnCreateDataDrivenSubscriptionOperationCompleted(object arg)
        {
            if ((this.CreateDataDrivenSubscriptionCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateDataDrivenSubscriptionCompleted(this, new CreateDataDrivenSubscriptionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetExten" +
            "sionSettings", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("ExtensionParameters")]
        public ExtensionParameter[] GetExtensionSettings(string Extension)
        {
            object[] results = this.Invoke("GetExtensionSettings", new object[] {
                    Extension});
            return ((ExtensionParameter[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetExtensionSettings(string Extension, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetExtensionSettings", new object[] {
                    Extension}, callback, asyncState);
        }

        /// <remarks/>
        public ExtensionParameter[] EndGetExtensionSettings(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ExtensionParameter[])(results[0]));
        }

        /// <remarks/>
        public void GetExtensionSettingsAsync(string Extension)
        {
            this.GetExtensionSettingsAsync(Extension, null);
        }

        /// <remarks/>
        public void GetExtensionSettingsAsync(string Extension, object userState)
        {
            if ((this.GetExtensionSettingsOperationCompleted == null))
            {
                this.GetExtensionSettingsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetExtensionSettingsOperationCompleted);
            }
            this.InvokeAsync("GetExtensionSettings", new object[] {
                    Extension}, this.GetExtensionSettingsOperationCompleted, userState);
        }

        private void OnGetExtensionSettingsOperationCompleted(object arg)
        {
            if ((this.GetExtensionSettingsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetExtensionSettingsCompleted(this, new GetExtensionSettingsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/Validate" +
            "ExtensionSettings", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("ParameterErrors")]
        public ExtensionParameter[] ValidateExtensionSettings(string Extension, ParameterValueOrFieldReference[] ParameterValues, string SiteUrl)
        {
            object[] results = this.Invoke("ValidateExtensionSettings", new object[] {
                    Extension,
                    ParameterValues,
                    SiteUrl});
            return ((ExtensionParameter[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginValidateExtensionSettings(string Extension, ParameterValueOrFieldReference[] ParameterValues, string SiteUrl, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ValidateExtensionSettings", new object[] {
                    Extension,
                    ParameterValues,
                    SiteUrl}, callback, asyncState);
        }

        /// <remarks/>
        public ExtensionParameter[] EndValidateExtensionSettings(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ExtensionParameter[])(results[0]));
        }

        /// <remarks/>
        public void ValidateExtensionSettingsAsync(string Extension, ParameterValueOrFieldReference[] ParameterValues, string SiteUrl)
        {
            this.ValidateExtensionSettingsAsync(Extension, ParameterValues, SiteUrl, null);
        }

        /// <remarks/>
        public void ValidateExtensionSettingsAsync(string Extension, ParameterValueOrFieldReference[] ParameterValues, string SiteUrl, object userState)
        {
            if ((this.ValidateExtensionSettingsOperationCompleted == null))
            {
                this.ValidateExtensionSettingsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidateExtensionSettingsOperationCompleted);
            }
            this.InvokeAsync("ValidateExtensionSettings", new object[] {
                    Extension,
                    ParameterValues,
                    SiteUrl}, this.ValidateExtensionSettingsOperationCompleted, userState);
        }

        private void OnValidateExtensionSettingsOperationCompleted(object arg)
        {
            if ((this.ValidateExtensionSettingsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidateExtensionSettingsCompleted(this, new ValidateExtensionSettingsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSubs" +
            "criptions", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("SubscriptionItems")]
        public Subscription[] ListSubscriptions(string ItemPathOrSiteURL)
        {
            object[] results = this.Invoke("ListSubscriptions", new object[] {
                    ItemPathOrSiteURL});
            return ((Subscription[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListSubscriptions(string ItemPathOrSiteURL, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListSubscriptions", new object[] {
                    ItemPathOrSiteURL}, callback, asyncState);
        }

        /// <remarks/>
        public Subscription[] EndListSubscriptions(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((Subscription[])(results[0]));
        }

        /// <remarks/>
        public void ListSubscriptionsAsync(string ItemPathOrSiteURL)
        {
            this.ListSubscriptionsAsync(ItemPathOrSiteURL, null);
        }

        /// <remarks/>
        public void ListSubscriptionsAsync(string ItemPathOrSiteURL, object userState)
        {
            if ((this.ListSubscriptionsOperationCompleted == null))
            {
                this.ListSubscriptionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListSubscriptionsOperationCompleted);
            }
            this.InvokeAsync("ListSubscriptions", new object[] {
                    ItemPathOrSiteURL}, this.ListSubscriptionsOperationCompleted, userState);
        }

        private void OnListSubscriptionsOperationCompleted(object arg)
        {
            if ((this.ListSubscriptionsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListSubscriptionsCompleted(this, new ListSubscriptionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListMySu" +
            "bscriptions", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("SubscriptionItems")]
        public Subscription[] ListMySubscriptions(string ItemPathOrSiteURL)
        {
            object[] results = this.Invoke("ListMySubscriptions", new object[] {
                    ItemPathOrSiteURL});
            return ((Subscription[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListMySubscriptions(string ItemPathOrSiteURL, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListMySubscriptions", new object[] {
                    ItemPathOrSiteURL}, callback, asyncState);
        }

        /// <remarks/>
        public Subscription[] EndListMySubscriptions(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((Subscription[])(results[0]));
        }

        /// <remarks/>
        public void ListMySubscriptionsAsync(string ItemPathOrSiteURL)
        {
            this.ListMySubscriptionsAsync(ItemPathOrSiteURL, null);
        }

        /// <remarks/>
        public void ListMySubscriptionsAsync(string ItemPathOrSiteURL, object userState)
        {
            if ((this.ListMySubscriptionsOperationCompleted == null))
            {
                this.ListMySubscriptionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListMySubscriptionsOperationCompleted);
            }
            this.InvokeAsync("ListMySubscriptions", new object[] {
                    ItemPathOrSiteURL}, this.ListMySubscriptionsOperationCompleted, userState);
        }

        private void OnListMySubscriptionsOperationCompleted(object arg)
        {
            if ((this.ListMySubscriptionsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListMySubscriptionsCompleted(this, new ListMySubscriptionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSubs" +
            "criptionsUsingDataSource", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("SubscriptionItems")]
        public Subscription[] ListSubscriptionsUsingDataSource(string DataSource)
        {
            object[] results = this.Invoke("ListSubscriptionsUsingDataSource", new object[] {
                    DataSource});
            return ((Subscription[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListSubscriptionsUsingDataSource(string DataSource, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListSubscriptionsUsingDataSource", new object[] {
                    DataSource}, callback, asyncState);
        }

        /// <remarks/>
        public Subscription[] EndListSubscriptionsUsingDataSource(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((Subscription[])(results[0]));
        }

        /// <remarks/>
        public void ListSubscriptionsUsingDataSourceAsync(string DataSource)
        {
            this.ListSubscriptionsUsingDataSourceAsync(DataSource, null);
        }

        /// <remarks/>
        public void ListSubscriptionsUsingDataSourceAsync(string DataSource, object userState)
        {
            if ((this.ListSubscriptionsUsingDataSourceOperationCompleted == null))
            {
                this.ListSubscriptionsUsingDataSourceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListSubscriptionsUsingDataSourceOperationCompleted);
            }
            this.InvokeAsync("ListSubscriptionsUsingDataSource", new object[] {
                    DataSource}, this.ListSubscriptionsUsingDataSourceOperationCompleted, userState);
        }

        private void OnListSubscriptionsUsingDataSourceOperationCompleted(object arg)
        {
            if ((this.ListSubscriptionsUsingDataSourceCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListSubscriptionsUsingDataSourceCompleted(this, new ListSubscriptionsUsingDataSourceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ChangeSu" +
            "bscriptionOwner", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ChangeSubscriptionOwner(string SubscriptionID, string NewOwner)
        {
            this.Invoke("ChangeSubscriptionOwner", new object[] {
                    SubscriptionID,
                    NewOwner});
        }

        /// <remarks/>
        public System.IAsyncResult BeginChangeSubscriptionOwner(string SubscriptionID, string NewOwner, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ChangeSubscriptionOwner", new object[] {
                    SubscriptionID,
                    NewOwner}, callback, asyncState);
        }

        /// <remarks/>
        public void EndChangeSubscriptionOwner(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void ChangeSubscriptionOwnerAsync(string SubscriptionID, string NewOwner)
        {
            this.ChangeSubscriptionOwnerAsync(SubscriptionID, NewOwner, null);
        }

        /// <remarks/>
        public void ChangeSubscriptionOwnerAsync(string SubscriptionID, string NewOwner, object userState)
        {
            if ((this.ChangeSubscriptionOwnerOperationCompleted == null))
            {
                this.ChangeSubscriptionOwnerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnChangeSubscriptionOwnerOperationCompleted);
            }
            this.InvokeAsync("ChangeSubscriptionOwner", new object[] {
                    SubscriptionID,
                    NewOwner}, this.ChangeSubscriptionOwnerOperationCompleted, userState);
        }

        private void OnChangeSubscriptionOwnerOperationCompleted(object arg)
        {
            if ((this.ChangeSubscriptionOwnerCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ChangeSubscriptionOwnerCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateDa" +
            "taSource", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ItemInfo")]
        public CatalogItem CreateDataSource(string DataSource, string Parent, bool Overwrite, DataSourceDefinition Definition, Property[] Properties)
        {
            object[] results = this.Invoke("CreateDataSource", new object[] {
                    DataSource,
                    Parent,
                    Overwrite,
                    Definition,
                    Properties});
            return ((CatalogItem)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginCreateDataSource(string DataSource, string Parent, bool Overwrite, DataSourceDefinition Definition, Property[] Properties, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("CreateDataSource", new object[] {
                    DataSource,
                    Parent,
                    Overwrite,
                    Definition,
                    Properties}, callback, asyncState);
        }

        /// <remarks/>
        public CatalogItem EndCreateDataSource(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((CatalogItem)(results[0]));
        }

        /// <remarks/>
        public void CreateDataSourceAsync(string DataSource, string Parent, bool Overwrite, DataSourceDefinition Definition, Property[] Properties)
        {
            this.CreateDataSourceAsync(DataSource, Parent, Overwrite, Definition, Properties, null);
        }

        /// <remarks/>
        public void CreateDataSourceAsync(string DataSource, string Parent, bool Overwrite, DataSourceDefinition Definition, Property[] Properties, object userState)
        {
            if ((this.CreateDataSourceOperationCompleted == null))
            {
                this.CreateDataSourceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateDataSourceOperationCompleted);
            }
            this.InvokeAsync("CreateDataSource", new object[] {
                    DataSource,
                    Parent,
                    Overwrite,
                    Definition,
                    Properties}, this.CreateDataSourceOperationCompleted, userState);
        }

        private void OnCreateDataSourceOperationCompleted(object arg)
        {
            if ((this.CreateDataSourceCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateDataSourceCompleted(this, new CreateDataSourceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/PrepareQ" +
            "uery", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("DataSettings")]
        public DataSetDefinition PrepareQuery(DataSource DataSource, DataSetDefinition DataSet, out bool Changed, out string[] ParameterNames)
        {
            object[] results = this.Invoke("PrepareQuery", new object[] {
                    DataSource,
                    DataSet});
            Changed = ((bool)(results[1]));
            ParameterNames = ((string[])(results[2]));
            return ((DataSetDefinition)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginPrepareQuery(DataSource DataSource, DataSetDefinition DataSet, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("PrepareQuery", new object[] {
                    DataSource,
                    DataSet}, callback, asyncState);
        }

        /// <remarks/>
        public DataSetDefinition EndPrepareQuery(System.IAsyncResult asyncResult, out bool Changed, out string[] ParameterNames)
        {
            object[] results = this.EndInvoke(asyncResult);
            Changed = ((bool)(results[1]));
            ParameterNames = ((string[])(results[2]));
            return ((DataSetDefinition)(results[0]));
        }

        /// <remarks/>
        public void PrepareQueryAsync(DataSource DataSource, DataSetDefinition DataSet)
        {
            this.PrepareQueryAsync(DataSource, DataSet, null);
        }

        /// <remarks/>
        public void PrepareQueryAsync(DataSource DataSource, DataSetDefinition DataSet, object userState)
        {
            if ((this.PrepareQueryOperationCompleted == null))
            {
                this.PrepareQueryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPrepareQueryOperationCompleted);
            }
            this.InvokeAsync("PrepareQuery", new object[] {
                    DataSource,
                    DataSet}, this.PrepareQueryOperationCompleted, userState);
        }

        private void OnPrepareQueryOperationCompleted(object arg)
        {
            if ((this.PrepareQueryCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PrepareQueryCompleted(this, new PrepareQueryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/EnableDa" +
            "taSource", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void EnableDataSource(string DataSource)
        {
            this.Invoke("EnableDataSource", new object[] {
                    DataSource});
        }

        /// <remarks/>
        public System.IAsyncResult BeginEnableDataSource(string DataSource, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("EnableDataSource", new object[] {
                    DataSource}, callback, asyncState);
        }

        /// <remarks/>
        public void EndEnableDataSource(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void EnableDataSourceAsync(string DataSource)
        {
            this.EnableDataSourceAsync(DataSource, null);
        }

        /// <remarks/>
        public void EnableDataSourceAsync(string DataSource, object userState)
        {
            if ((this.EnableDataSourceOperationCompleted == null))
            {
                this.EnableDataSourceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEnableDataSourceOperationCompleted);
            }
            this.InvokeAsync("EnableDataSource", new object[] {
                    DataSource}, this.EnableDataSourceOperationCompleted, userState);
        }

        private void OnEnableDataSourceOperationCompleted(object arg)
        {
            if ((this.EnableDataSourceCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EnableDataSourceCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DisableD" +
            "ataSource", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DisableDataSource(string DataSource)
        {
            this.Invoke("DisableDataSource", new object[] {
                    DataSource});
        }

        /// <remarks/>
        public System.IAsyncResult BeginDisableDataSource(string DataSource, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("DisableDataSource", new object[] {
                    DataSource}, callback, asyncState);
        }

        /// <remarks/>
        public void EndDisableDataSource(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void DisableDataSourceAsync(string DataSource)
        {
            this.DisableDataSourceAsync(DataSource, null);
        }

        /// <remarks/>
        public void DisableDataSourceAsync(string DataSource, object userState)
        {
            if ((this.DisableDataSourceOperationCompleted == null))
            {
                this.DisableDataSourceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDisableDataSourceOperationCompleted);
            }
            this.InvokeAsync("DisableDataSource", new object[] {
                    DataSource}, this.DisableDataSourceOperationCompleted, userState);
        }

        private void OnDisableDataSourceOperationCompleted(object arg)
        {
            if ((this.DisableDataSourceCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DisableDataSourceCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetDataS" +
            "ourceContents", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetDataSourceContents(string DataSource, DataSourceDefinition Definition)
        {
            this.Invoke("SetDataSourceContents", new object[] {
                    DataSource,
                    Definition});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetDataSourceContents(string DataSource, DataSourceDefinition Definition, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetDataSourceContents", new object[] {
                    DataSource,
                    Definition}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetDataSourceContents(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetDataSourceContentsAsync(string DataSource, DataSourceDefinition Definition)
        {
            this.SetDataSourceContentsAsync(DataSource, Definition, null);
        }

        /// <remarks/>
        public void SetDataSourceContentsAsync(string DataSource, DataSourceDefinition Definition, object userState)
        {
            if ((this.SetDataSourceContentsOperationCompleted == null))
            {
                this.SetDataSourceContentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetDataSourceContentsOperationCompleted);
            }
            this.InvokeAsync("SetDataSourceContents", new object[] {
                    DataSource,
                    Definition}, this.SetDataSourceContentsOperationCompleted, userState);
        }

        private void OnSetDataSourceContentsOperationCompleted(object arg)
        {
            if ((this.SetDataSourceContentsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetDataSourceContentsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetDataS" +
            "ourceContents", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Definition")]
        public DataSourceDefinition GetDataSourceContents(string DataSource)
        {
            object[] results = this.Invoke("GetDataSourceContents", new object[] {
                    DataSource});
            return ((DataSourceDefinition)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetDataSourceContents(string DataSource, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetDataSourceContents", new object[] {
                    DataSource}, callback, asyncState);
        }

        /// <remarks/>
        public DataSourceDefinition EndGetDataSourceContents(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((DataSourceDefinition)(results[0]));
        }

        /// <remarks/>
        public void GetDataSourceContentsAsync(string DataSource)
        {
            this.GetDataSourceContentsAsync(DataSource, null);
        }

        /// <remarks/>
        public void GetDataSourceContentsAsync(string DataSource, object userState)
        {
            if ((this.GetDataSourceContentsOperationCompleted == null))
            {
                this.GetDataSourceContentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataSourceContentsOperationCompleted);
            }
            this.InvokeAsync("GetDataSourceContents", new object[] {
                    DataSource}, this.GetDataSourceContentsOperationCompleted, userState);
        }

        private void OnGetDataSourceContentsOperationCompleted(object arg)
        {
            if ((this.GetDataSourceContentsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataSourceContentsCompleted(this, new GetDataSourceContentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListData" +
            "baseCredentialRetrievalOptions", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] ListDatabaseCredentialRetrievalOptions()
        {
            object[] results = this.Invoke("ListDatabaseCredentialRetrievalOptions", new object[0]);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListDatabaseCredentialRetrievalOptions(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListDatabaseCredentialRetrievalOptions", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public string[] EndListDatabaseCredentialRetrievalOptions(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void ListDatabaseCredentialRetrievalOptionsAsync()
        {
            this.ListDatabaseCredentialRetrievalOptionsAsync(null);
        }

        /// <remarks/>
        public void ListDatabaseCredentialRetrievalOptionsAsync(object userState)
        {
            if ((this.ListDatabaseCredentialRetrievalOptionsOperationCompleted == null))
            {
                this.ListDatabaseCredentialRetrievalOptionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListDatabaseCredentialRetrievalOptionsOperationCompleted);
            }
            this.InvokeAsync("ListDatabaseCredentialRetrievalOptions", new object[0], this.ListDatabaseCredentialRetrievalOptionsOperationCompleted, userState);
        }

        private void OnListDatabaseCredentialRetrievalOptionsOperationCompleted(object arg)
        {
            if ((this.ListDatabaseCredentialRetrievalOptionsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListDatabaseCredentialRetrievalOptionsCompleted(this, new ListDatabaseCredentialRetrievalOptionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemD" +
            "ataSources", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetItemDataSources(string ItemPath, DataSource[] DataSources)
        {
            this.Invoke("SetItemDataSources", new object[] {
                    ItemPath,
                    DataSources});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetItemDataSources(string ItemPath, DataSource[] DataSources, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetItemDataSources", new object[] {
                    ItemPath,
                    DataSources}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetItemDataSources(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetItemDataSourcesAsync(string ItemPath, DataSource[] DataSources)
        {
            this.SetItemDataSourcesAsync(ItemPath, DataSources, null);
        }

        /// <remarks/>
        public void SetItemDataSourcesAsync(string ItemPath, DataSource[] DataSources, object userState)
        {
            if ((this.SetItemDataSourcesOperationCompleted == null))
            {
                this.SetItemDataSourcesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetItemDataSourcesOperationCompleted);
            }
            this.InvokeAsync("SetItemDataSources", new object[] {
                    ItemPath,
                    DataSources}, this.SetItemDataSourcesOperationCompleted, userState);
        }

        private void OnSetItemDataSourcesOperationCompleted(object arg)
        {
            if ((this.SetItemDataSourcesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetItemDataSourcesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemD" +
            "ataSources", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("DataSources")]
        public DataSource[] GetItemDataSources(string ItemPath)
        {
            object[] results = this.Invoke("GetItemDataSources", new object[] {
                    ItemPath});
            return ((DataSource[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetItemDataSources(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetItemDataSources", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public DataSource[] EndGetItemDataSources(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((DataSource[])(results[0]));
        }

        /// <remarks/>
        public void GetItemDataSourcesAsync(string ItemPath)
        {
            this.GetItemDataSourcesAsync(ItemPath, null);
        }

        /// <remarks/>
        public void GetItemDataSourcesAsync(string ItemPath, object userState)
        {
            if ((this.GetItemDataSourcesOperationCompleted == null))
            {
                this.GetItemDataSourcesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetItemDataSourcesOperationCompleted);
            }
            this.InvokeAsync("GetItemDataSources", new object[] {
                    ItemPath}, this.GetItemDataSourcesOperationCompleted, userState);
        }

        private void OnGetItemDataSourcesOperationCompleted(object arg)
        {
            if ((this.GetItemDataSourcesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetItemDataSourcesCompleted(this, new GetItemDataSourcesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/TestConn" +
            "ectForDataSourceDefinition", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool TestConnectForDataSourceDefinition(DataSourceDefinition DataSourceDefinition, string UserName, string Password, out string ConnectError)
        {
            object[] results = this.Invoke("TestConnectForDataSourceDefinition", new object[] {
                    DataSourceDefinition,
                    UserName,
                    Password});
            ConnectError = ((string)(results[1]));
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginTestConnectForDataSourceDefinition(DataSourceDefinition DataSourceDefinition, string UserName, string Password, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("TestConnectForDataSourceDefinition", new object[] {
                    DataSourceDefinition,
                    UserName,
                    Password}, callback, asyncState);
        }

        /// <remarks/>
        public bool EndTestConnectForDataSourceDefinition(System.IAsyncResult asyncResult, out string ConnectError)
        {
            object[] results = this.EndInvoke(asyncResult);
            ConnectError = ((string)(results[1]));
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public void TestConnectForDataSourceDefinitionAsync(DataSourceDefinition DataSourceDefinition, string UserName, string Password)
        {
            this.TestConnectForDataSourceDefinitionAsync(DataSourceDefinition, UserName, Password, null);
        }

        /// <remarks/>
        public void TestConnectForDataSourceDefinitionAsync(DataSourceDefinition DataSourceDefinition, string UserName, string Password, object userState)
        {
            if ((this.TestConnectForDataSourceDefinitionOperationCompleted == null))
            {
                this.TestConnectForDataSourceDefinitionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTestConnectForDataSourceDefinitionOperationCompleted);
            }
            this.InvokeAsync("TestConnectForDataSourceDefinition", new object[] {
                    DataSourceDefinition,
                    UserName,
                    Password}, this.TestConnectForDataSourceDefinitionOperationCompleted, userState);
        }

        private void OnTestConnectForDataSourceDefinitionOperationCompleted(object arg)
        {
            if ((this.TestConnectForDataSourceDefinitionCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TestConnectForDataSourceDefinitionCompleted(this, new TestConnectForDataSourceDefinitionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/TestConn" +
            "ectForItemDataSource", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool TestConnectForItemDataSource(string ItemPath, string DataSourceName, string UserName, string Password, out string ConnectError)
        {
            object[] results = this.Invoke("TestConnectForItemDataSource", new object[] {
                    ItemPath,
                    DataSourceName,
                    UserName,
                    Password});
            ConnectError = ((string)(results[1]));
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginTestConnectForItemDataSource(string ItemPath, string DataSourceName, string UserName, string Password, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("TestConnectForItemDataSource", new object[] {
                    ItemPath,
                    DataSourceName,
                    UserName,
                    Password}, callback, asyncState);
        }

        /// <remarks/>
        public bool EndTestConnectForItemDataSource(System.IAsyncResult asyncResult, out string ConnectError)
        {
            object[] results = this.EndInvoke(asyncResult);
            ConnectError = ((string)(results[1]));
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public void TestConnectForItemDataSourceAsync(string ItemPath, string DataSourceName, string UserName, string Password)
        {
            this.TestConnectForItemDataSourceAsync(ItemPath, DataSourceName, UserName, Password, null);
        }

        /// <remarks/>
        public void TestConnectForItemDataSourceAsync(string ItemPath, string DataSourceName, string UserName, string Password, object userState)
        {
            if ((this.TestConnectForItemDataSourceOperationCompleted == null))
            {
                this.TestConnectForItemDataSourceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTestConnectForItemDataSourceOperationCompleted);
            }
            this.InvokeAsync("TestConnectForItemDataSource", new object[] {
                    ItemPath,
                    DataSourceName,
                    UserName,
                    Password}, this.TestConnectForItemDataSourceOperationCompleted, userState);
        }

        private void OnTestConnectForItemDataSourceOperationCompleted(object arg)
        {
            if ((this.TestConnectForItemDataSourceCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TestConnectForItemDataSourceCompleted(this, new TestConnectForItemDataSourceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateRo" +
            "le", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateRole(string Name, string Description, string[] TaskIDs)
        {
            this.Invoke("CreateRole", new object[] {
                    Name,
                    Description,
                    TaskIDs});
        }

        /// <remarks/>
        public System.IAsyncResult BeginCreateRole(string Name, string Description, string[] TaskIDs, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("CreateRole", new object[] {
                    Name,
                    Description,
                    TaskIDs}, callback, asyncState);
        }

        /// <remarks/>
        public void EndCreateRole(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void CreateRoleAsync(string Name, string Description, string[] TaskIDs)
        {
            this.CreateRoleAsync(Name, Description, TaskIDs, null);
        }

        /// <remarks/>
        public void CreateRoleAsync(string Name, string Description, string[] TaskIDs, object userState)
        {
            if ((this.CreateRoleOperationCompleted == null))
            {
                this.CreateRoleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateRoleOperationCompleted);
            }
            this.InvokeAsync("CreateRole", new object[] {
                    Name,
                    Description,
                    TaskIDs}, this.CreateRoleOperationCompleted, userState);
        }

        private void OnCreateRoleOperationCompleted(object arg)
        {
            if ((this.CreateRoleCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateRoleCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetRoleP" +
            "roperties", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetRoleProperties(string Name, string Description, string[] TaskIDs)
        {
            this.Invoke("SetRoleProperties", new object[] {
                    Name,
                    Description,
                    TaskIDs});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetRoleProperties(string Name, string Description, string[] TaskIDs, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetRoleProperties", new object[] {
                    Name,
                    Description,
                    TaskIDs}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetRoleProperties(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetRolePropertiesAsync(string Name, string Description, string[] TaskIDs)
        {
            this.SetRolePropertiesAsync(Name, Description, TaskIDs, null);
        }

        /// <remarks/>
        public void SetRolePropertiesAsync(string Name, string Description, string[] TaskIDs, object userState)
        {
            if ((this.SetRolePropertiesOperationCompleted == null))
            {
                this.SetRolePropertiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetRolePropertiesOperationCompleted);
            }
            this.InvokeAsync("SetRoleProperties", new object[] {
                    Name,
                    Description,
                    TaskIDs}, this.SetRolePropertiesOperationCompleted, userState);
        }

        private void OnSetRolePropertiesOperationCompleted(object arg)
        {
            if ((this.SetRolePropertiesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetRolePropertiesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetRoleP" +
            "roperties", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("TaskIDs")]
        public string[] GetRoleProperties(string Name, string SiteUrl, out string Description)
        {
            object[] results = this.Invoke("GetRoleProperties", new object[] {
                    Name,
                    SiteUrl});
            Description = ((string)(results[1]));
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetRoleProperties(string Name, string SiteUrl, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetRoleProperties", new object[] {
                    Name,
                    SiteUrl}, callback, asyncState);
        }

        /// <remarks/>
        public string[] EndGetRoleProperties(System.IAsyncResult asyncResult, out string Description)
        {
            object[] results = this.EndInvoke(asyncResult);
            Description = ((string)(results[1]));
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void GetRolePropertiesAsync(string Name, string SiteUrl)
        {
            this.GetRolePropertiesAsync(Name, SiteUrl, null);
        }

        /// <remarks/>
        public void GetRolePropertiesAsync(string Name, string SiteUrl, object userState)
        {
            if ((this.GetRolePropertiesOperationCompleted == null))
            {
                this.GetRolePropertiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRolePropertiesOperationCompleted);
            }
            this.InvokeAsync("GetRoleProperties", new object[] {
                    Name,
                    SiteUrl}, this.GetRolePropertiesOperationCompleted, userState);
        }

        private void OnGetRolePropertiesOperationCompleted(object arg)
        {
            if ((this.GetRolePropertiesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRolePropertiesCompleted(this, new GetRolePropertiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteRo" +
            "le", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteRole(string Name)
        {
            this.Invoke("DeleteRole", new object[] {
                    Name});
        }

        /// <remarks/>
        public System.IAsyncResult BeginDeleteRole(string Name, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("DeleteRole", new object[] {
                    Name}, callback, asyncState);
        }

        /// <remarks/>
        public void EndDeleteRole(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void DeleteRoleAsync(string Name)
        {
            this.DeleteRoleAsync(Name, null);
        }

        /// <remarks/>
        public void DeleteRoleAsync(string Name, object userState)
        {
            if ((this.DeleteRoleOperationCompleted == null))
            {
                this.DeleteRoleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteRoleOperationCompleted);
            }
            this.InvokeAsync("DeleteRole", new object[] {
                    Name}, this.DeleteRoleOperationCompleted, userState);
        }

        private void OnDeleteRoleOperationCompleted(object arg)
        {
            if ((this.DeleteRoleCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteRoleCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListRole" +
            "s", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Roles")]
        public Role[] ListRoles(string SecurityScope, string SiteUrl)
        {
            object[] results = this.Invoke("ListRoles", new object[] {
                    SecurityScope,
                    SiteUrl});
            return ((Role[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListRoles(string SecurityScope, string SiteUrl, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListRoles", new object[] {
                    SecurityScope,
                    SiteUrl}, callback, asyncState);
        }

        /// <remarks/>
        public Role[] EndListRoles(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((Role[])(results[0]));
        }

        /// <remarks/>
        public void ListRolesAsync(string SecurityScope, string SiteUrl)
        {
            this.ListRolesAsync(SecurityScope, SiteUrl, null);
        }

        /// <remarks/>
        public void ListRolesAsync(string SecurityScope, string SiteUrl, object userState)
        {
            if ((this.ListRolesOperationCompleted == null))
            {
                this.ListRolesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListRolesOperationCompleted);
            }
            this.InvokeAsync("ListRoles", new object[] {
                    SecurityScope,
                    SiteUrl}, this.ListRolesOperationCompleted, userState);
        }

        private void OnListRolesOperationCompleted(object arg)
        {
            if ((this.ListRolesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListRolesCompleted(this, new ListRolesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListTask" +
            "s", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Tasks")]
        public Task[] ListTasks(string SecurityScope)
        {
            object[] results = this.Invoke("ListTasks", new object[] {
                    SecurityScope});
            return ((Task[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListTasks(string SecurityScope, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListTasks", new object[] {
                    SecurityScope}, callback, asyncState);
        }

        /// <remarks/>
        public Task[] EndListTasks(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((Task[])(results[0]));
        }

        /// <remarks/>
        public void ListTasksAsync(string SecurityScope)
        {
            this.ListTasksAsync(SecurityScope, null);
        }

        /// <remarks/>
        public void ListTasksAsync(string SecurityScope, object userState)
        {
            if ((this.ListTasksOperationCompleted == null))
            {
                this.ListTasksOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListTasksOperationCompleted);
            }
            this.InvokeAsync("ListTasks", new object[] {
                    SecurityScope}, this.ListTasksOperationCompleted, userState);
        }

        private void OnListTasksOperationCompleted(object arg)
        {
            if ((this.ListTasksCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListTasksCompleted(this, new ListTasksCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetPolic" +
            "ies", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetPolicies(string ItemPath, Policy[] Policies)
        {
            this.Invoke("SetPolicies", new object[] {
                    ItemPath,
                    Policies});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetPolicies(string ItemPath, Policy[] Policies, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetPolicies", new object[] {
                    ItemPath,
                    Policies}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetPolicies(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetPoliciesAsync(string ItemPath, Policy[] Policies)
        {
            this.SetPoliciesAsync(ItemPath, Policies, null);
        }

        /// <remarks/>
        public void SetPoliciesAsync(string ItemPath, Policy[] Policies, object userState)
        {
            if ((this.SetPoliciesOperationCompleted == null))
            {
                this.SetPoliciesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetPoliciesOperationCompleted);
            }
            this.InvokeAsync("SetPolicies", new object[] {
                    ItemPath,
                    Policies}, this.SetPoliciesOperationCompleted, userState);
        }

        private void OnSetPoliciesOperationCompleted(object arg)
        {
            if ((this.SetPoliciesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetPoliciesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetPolic" +
            "ies", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Policies")]
        public Policy[] GetPolicies(string ItemPath, out bool InheritParent)
        {
            object[] results = this.Invoke("GetPolicies", new object[] {
                    ItemPath});
            InheritParent = ((bool)(results[1]));
            return ((Policy[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetPolicies(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetPolicies", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public Policy[] EndGetPolicies(System.IAsyncResult asyncResult, out bool InheritParent)
        {
            object[] results = this.EndInvoke(asyncResult);
            InheritParent = ((bool)(results[1]));
            return ((Policy[])(results[0]));
        }

        /// <remarks/>
        public void GetPoliciesAsync(string ItemPath)
        {
            this.GetPoliciesAsync(ItemPath, null);
        }

        /// <remarks/>
        public void GetPoliciesAsync(string ItemPath, object userState)
        {
            if ((this.GetPoliciesOperationCompleted == null))
            {
                this.GetPoliciesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPoliciesOperationCompleted);
            }
            this.InvokeAsync("GetPolicies", new object[] {
                    ItemPath}, this.GetPoliciesOperationCompleted, userState);
        }

        private void OnGetPoliciesOperationCompleted(object arg)
        {
            if ((this.GetPoliciesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPoliciesCompleted(this, new GetPoliciesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemD" +
            "ataSourcePrompts", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("DataSourcePrompts")]
        public DataSourcePrompt[] GetItemDataSourcePrompts(string ItemPath)
        {
            object[] results = this.Invoke("GetItemDataSourcePrompts", new object[] {
                    ItemPath});
            return ((DataSourcePrompt[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetItemDataSourcePrompts(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetItemDataSourcePrompts", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public DataSourcePrompt[] EndGetItemDataSourcePrompts(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((DataSourcePrompt[])(results[0]));
        }

        /// <remarks/>
        public void GetItemDataSourcePromptsAsync(string ItemPath)
        {
            this.GetItemDataSourcePromptsAsync(ItemPath, null);
        }

        /// <remarks/>
        public void GetItemDataSourcePromptsAsync(string ItemPath, object userState)
        {
            if ((this.GetItemDataSourcePromptsOperationCompleted == null))
            {
                this.GetItemDataSourcePromptsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetItemDataSourcePromptsOperationCompleted);
            }
            this.InvokeAsync("GetItemDataSourcePrompts", new object[] {
                    ItemPath}, this.GetItemDataSourcePromptsOperationCompleted, userState);
        }

        private void OnGetItemDataSourcePromptsOperationCompleted(object arg)
        {
            if ((this.GetItemDataSourcePromptsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetItemDataSourcePromptsCompleted(this, new GetItemDataSourcePromptsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/Generate" +
            "Model", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ItemInfo")]
        public CatalogItem GenerateModel(string DataSource, string Model, string Parent, Property[] Properties, out Warning[] Warnings)
        {
            object[] results = this.Invoke("GenerateModel", new object[] {
                    DataSource,
                    Model,
                    Parent,
                    Properties});
            Warnings = ((Warning[])(results[1]));
            return ((CatalogItem)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGenerateModel(string DataSource, string Model, string Parent, Property[] Properties, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GenerateModel", new object[] {
                    DataSource,
                    Model,
                    Parent,
                    Properties}, callback, asyncState);
        }

        /// <remarks/>
        public CatalogItem EndGenerateModel(System.IAsyncResult asyncResult, out Warning[] Warnings)
        {
            object[] results = this.EndInvoke(asyncResult);
            Warnings = ((Warning[])(results[1]));
            return ((CatalogItem)(results[0]));
        }

        /// <remarks/>
        public void GenerateModelAsync(string DataSource, string Model, string Parent, Property[] Properties)
        {
            this.GenerateModelAsync(DataSource, Model, Parent, Properties, null);
        }

        /// <remarks/>
        public void GenerateModelAsync(string DataSource, string Model, string Parent, Property[] Properties, object userState)
        {
            if ((this.GenerateModelOperationCompleted == null))
            {
                this.GenerateModelOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGenerateModelOperationCompleted);
            }
            this.InvokeAsync("GenerateModel", new object[] {
                    DataSource,
                    Model,
                    Parent,
                    Properties}, this.GenerateModelOperationCompleted, userState);
        }

        private void OnGenerateModelOperationCompleted(object arg)
        {
            if ((this.GenerateModelCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GenerateModelCompleted(this, new GenerateModelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetModel" +
            "ItemPermissions", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Permissions")]
        public string[] GetModelItemPermissions(string Model, string ModelItemID)
        {
            object[] results = this.Invoke("GetModelItemPermissions", new object[] {
                    Model,
                    ModelItemID});
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetModelItemPermissions(string Model, string ModelItemID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetModelItemPermissions", new object[] {
                    Model,
                    ModelItemID}, callback, asyncState);
        }

        /// <remarks/>
        public string[] EndGetModelItemPermissions(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void GetModelItemPermissionsAsync(string Model, string ModelItemID)
        {
            this.GetModelItemPermissionsAsync(Model, ModelItemID, null);
        }

        /// <remarks/>
        public void GetModelItemPermissionsAsync(string Model, string ModelItemID, object userState)
        {
            if ((this.GetModelItemPermissionsOperationCompleted == null))
            {
                this.GetModelItemPermissionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetModelItemPermissionsOperationCompleted);
            }
            this.InvokeAsync("GetModelItemPermissions", new object[] {
                    Model,
                    ModelItemID}, this.GetModelItemPermissionsOperationCompleted, userState);
        }

        private void OnGetModelItemPermissionsOperationCompleted(object arg)
        {
            if ((this.GetModelItemPermissionsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetModelItemPermissionsCompleted(this, new GetModelItemPermissionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetModel" +
            "ItemPolicies", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetModelItemPolicies(string Model, string ModelItemID, Policy[] Policies)
        {
            this.Invoke("SetModelItemPolicies", new object[] {
                    Model,
                    ModelItemID,
                    Policies});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetModelItemPolicies(string Model, string ModelItemID, Policy[] Policies, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetModelItemPolicies", new object[] {
                    Model,
                    ModelItemID,
                    Policies}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetModelItemPolicies(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetModelItemPoliciesAsync(string Model, string ModelItemID, Policy[] Policies)
        {
            this.SetModelItemPoliciesAsync(Model, ModelItemID, Policies, null);
        }

        /// <remarks/>
        public void SetModelItemPoliciesAsync(string Model, string ModelItemID, Policy[] Policies, object userState)
        {
            if ((this.SetModelItemPoliciesOperationCompleted == null))
            {
                this.SetModelItemPoliciesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetModelItemPoliciesOperationCompleted);
            }
            this.InvokeAsync("SetModelItemPolicies", new object[] {
                    Model,
                    ModelItemID,
                    Policies}, this.SetModelItemPoliciesOperationCompleted, userState);
        }

        private void OnSetModelItemPoliciesOperationCompleted(object arg)
        {
            if ((this.SetModelItemPoliciesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetModelItemPoliciesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetModel" +
            "ItemPolicies", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Policies")]
        public Policy[] GetModelItemPolicies(string Model, string ModelItemID, out bool InheritParent)
        {
            object[] results = this.Invoke("GetModelItemPolicies", new object[] {
                    Model,
                    ModelItemID});
            InheritParent = ((bool)(results[1]));
            return ((Policy[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetModelItemPolicies(string Model, string ModelItemID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetModelItemPolicies", new object[] {
                    Model,
                    ModelItemID}, callback, asyncState);
        }

        /// <remarks/>
        public Policy[] EndGetModelItemPolicies(System.IAsyncResult asyncResult, out bool InheritParent)
        {
            object[] results = this.EndInvoke(asyncResult);
            InheritParent = ((bool)(results[1]));
            return ((Policy[])(results[0]));
        }

        /// <remarks/>
        public void GetModelItemPoliciesAsync(string Model, string ModelItemID)
        {
            this.GetModelItemPoliciesAsync(Model, ModelItemID, null);
        }

        /// <remarks/>
        public void GetModelItemPoliciesAsync(string Model, string ModelItemID, object userState)
        {
            if ((this.GetModelItemPoliciesOperationCompleted == null))
            {
                this.GetModelItemPoliciesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetModelItemPoliciesOperationCompleted);
            }
            this.InvokeAsync("GetModelItemPolicies", new object[] {
                    Model,
                    ModelItemID}, this.GetModelItemPoliciesOperationCompleted, userState);
        }

        private void OnGetModelItemPoliciesOperationCompleted(object arg)
        {
            if ((this.GetModelItemPoliciesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetModelItemPoliciesCompleted(this, new GetModelItemPoliciesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetUserM" +
            "odel", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Definition", DataType = "base64Binary")]
        public byte[] GetUserModel(string Model, string Perspective)
        {
            object[] results = this.Invoke("GetUserModel", new object[] {
                    Model,
                    Perspective});
            return ((byte[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetUserModel(string Model, string Perspective, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetUserModel", new object[] {
                    Model,
                    Perspective}, callback, asyncState);
        }

        /// <remarks/>
        public byte[] EndGetUserModel(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((byte[])(results[0]));
        }

        /// <remarks/>
        public void GetUserModelAsync(string Model, string Perspective)
        {
            this.GetUserModelAsync(Model, Perspective, null);
        }

        /// <remarks/>
        public void GetUserModelAsync(string Model, string Perspective, object userState)
        {
            if ((this.GetUserModelOperationCompleted == null))
            {
                this.GetUserModelOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUserModelOperationCompleted);
            }
            this.InvokeAsync("GetUserModel", new object[] {
                    Model,
                    Perspective}, this.GetUserModelOperationCompleted, userState);
        }

        private void OnGetUserModelOperationCompleted(object arg)
        {
            if ((this.GetUserModelCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUserModelCompleted(this, new GetUserModelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/InheritM" +
            "odelItemParentSecurity", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void InheritModelItemParentSecurity(string Model, string ModelItemID)
        {
            this.Invoke("InheritModelItemParentSecurity", new object[] {
                    Model,
                    ModelItemID});
        }

        /// <remarks/>
        public System.IAsyncResult BeginInheritModelItemParentSecurity(string Model, string ModelItemID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("InheritModelItemParentSecurity", new object[] {
                    Model,
                    ModelItemID}, callback, asyncState);
        }

        /// <remarks/>
        public void EndInheritModelItemParentSecurity(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void InheritModelItemParentSecurityAsync(string Model, string ModelItemID)
        {
            this.InheritModelItemParentSecurityAsync(Model, ModelItemID, null);
        }

        /// <remarks/>
        public void InheritModelItemParentSecurityAsync(string Model, string ModelItemID, object userState)
        {
            if ((this.InheritModelItemParentSecurityOperationCompleted == null))
            {
                this.InheritModelItemParentSecurityOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInheritModelItemParentSecurityOperationCompleted);
            }
            this.InvokeAsync("InheritModelItemParentSecurity", new object[] {
                    Model,
                    ModelItemID}, this.InheritModelItemParentSecurityOperationCompleted, userState);
        }

        private void OnInheritModelItemParentSecurityOperationCompleted(object arg)
        {
            if ((this.InheritModelItemParentSecurityCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InheritModelItemParentSecurityCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetModel" +
            "DrillthroughReports", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetModelDrillthroughReports(string Model, string ModelItemID, ModelDrillthroughReport[] Reports)
        {
            this.Invoke("SetModelDrillthroughReports", new object[] {
                    Model,
                    ModelItemID,
                    Reports});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetModelDrillthroughReports(string Model, string ModelItemID, ModelDrillthroughReport[] Reports, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetModelDrillthroughReports", new object[] {
                    Model,
                    ModelItemID,
                    Reports}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetModelDrillthroughReports(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetModelDrillthroughReportsAsync(string Model, string ModelItemID, ModelDrillthroughReport[] Reports)
        {
            this.SetModelDrillthroughReportsAsync(Model, ModelItemID, Reports, null);
        }

        /// <remarks/>
        public void SetModelDrillthroughReportsAsync(string Model, string ModelItemID, ModelDrillthroughReport[] Reports, object userState)
        {
            if ((this.SetModelDrillthroughReportsOperationCompleted == null))
            {
                this.SetModelDrillthroughReportsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetModelDrillthroughReportsOperationCompleted);
            }
            this.InvokeAsync("SetModelDrillthroughReports", new object[] {
                    Model,
                    ModelItemID,
                    Reports}, this.SetModelDrillthroughReportsOperationCompleted, userState);
        }

        private void OnSetModelDrillthroughReportsOperationCompleted(object arg)
        {
            if ((this.SetModelDrillthroughReportsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetModelDrillthroughReportsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListMode" +
            "lDrillthroughReports", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Reports")]
        public ModelDrillthroughReport[] ListModelDrillthroughReports(string Model, string ModelItemID)
        {
            object[] results = this.Invoke("ListModelDrillthroughReports", new object[] {
                    Model,
                    ModelItemID});
            return ((ModelDrillthroughReport[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListModelDrillthroughReports(string Model, string ModelItemID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListModelDrillthroughReports", new object[] {
                    Model,
                    ModelItemID}, callback, asyncState);
        }

        /// <remarks/>
        public ModelDrillthroughReport[] EndListModelDrillthroughReports(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ModelDrillthroughReport[])(results[0]));
        }

        /// <remarks/>
        public void ListModelDrillthroughReportsAsync(string Model, string ModelItemID)
        {
            this.ListModelDrillthroughReportsAsync(Model, ModelItemID, null);
        }

        /// <remarks/>
        public void ListModelDrillthroughReportsAsync(string Model, string ModelItemID, object userState)
        {
            if ((this.ListModelDrillthroughReportsOperationCompleted == null))
            {
                this.ListModelDrillthroughReportsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListModelDrillthroughReportsOperationCompleted);
            }
            this.InvokeAsync("ListModelDrillthroughReports", new object[] {
                    Model,
                    ModelItemID}, this.ListModelDrillthroughReportsOperationCompleted, userState);
        }

        private void OnListModelDrillthroughReportsOperationCompleted(object arg)
        {
            if ((this.ListModelDrillthroughReportsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListModelDrillthroughReportsCompleted(this, new ListModelDrillthroughReportsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListMode" +
            "lItemChildren", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("ModelItems")]
        public ModelItem[] ListModelItemChildren(string Model, string ModelItemID, bool Recursive)
        {
            object[] results = this.Invoke("ListModelItemChildren", new object[] {
                    Model,
                    ModelItemID,
                    Recursive});
            return ((ModelItem[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListModelItemChildren(string Model, string ModelItemID, bool Recursive, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListModelItemChildren", new object[] {
                    Model,
                    ModelItemID,
                    Recursive}, callback, asyncState);
        }

        /// <remarks/>
        public ModelItem[] EndListModelItemChildren(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ModelItem[])(results[0]));
        }

        /// <remarks/>
        public void ListModelItemChildrenAsync(string Model, string ModelItemID, bool Recursive)
        {
            this.ListModelItemChildrenAsync(Model, ModelItemID, Recursive, null);
        }

        /// <remarks/>
        public void ListModelItemChildrenAsync(string Model, string ModelItemID, bool Recursive, object userState)
        {
            if ((this.ListModelItemChildrenOperationCompleted == null))
            {
                this.ListModelItemChildrenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListModelItemChildrenOperationCompleted);
            }
            this.InvokeAsync("ListModelItemChildren", new object[] {
                    Model,
                    ModelItemID,
                    Recursive}, this.ListModelItemChildrenOperationCompleted, userState);
        }

        private void OnListModelItemChildrenOperationCompleted(object arg)
        {
            if ((this.ListModelItemChildrenCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListModelItemChildrenCompleted(this, new ListModelItemChildrenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListMode" +
            "lItemTypes", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] ListModelItemTypes()
        {
            object[] results = this.Invoke("ListModelItemTypes", new object[0]);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListModelItemTypes(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListModelItemTypes", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public string[] EndListModelItemTypes(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void ListModelItemTypesAsync()
        {
            this.ListModelItemTypesAsync(null);
        }

        /// <remarks/>
        public void ListModelItemTypesAsync(object userState)
        {
            if ((this.ListModelItemTypesOperationCompleted == null))
            {
                this.ListModelItemTypesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListModelItemTypesOperationCompleted);
            }
            this.InvokeAsync("ListModelItemTypes", new object[0], this.ListModelItemTypesOperationCompleted, userState);
        }

        private void OnListModelItemTypesOperationCompleted(object arg)
        {
            if ((this.ListModelItemTypesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListModelItemTypesCompleted(this, new ListModelItemTypesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListMode" +
            "lPerspectives", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("ModelCatalogItems")]
        public ModelCatalogItem[] ListModelPerspectives(string Model)
        {
            object[] results = this.Invoke("ListModelPerspectives", new object[] {
                    Model});
            return ((ModelCatalogItem[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListModelPerspectives(string Model, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListModelPerspectives", new object[] {
                    Model}, callback, asyncState);
        }

        /// <remarks/>
        public ModelCatalogItem[] EndListModelPerspectives(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ModelCatalogItem[])(results[0]));
        }

        /// <remarks/>
        public void ListModelPerspectivesAsync(string Model)
        {
            this.ListModelPerspectivesAsync(Model, null);
        }

        /// <remarks/>
        public void ListModelPerspectivesAsync(string Model, object userState)
        {
            if ((this.ListModelPerspectivesOperationCompleted == null))
            {
                this.ListModelPerspectivesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListModelPerspectivesOperationCompleted);
            }
            this.InvokeAsync("ListModelPerspectives", new object[] {
                    Model}, this.ListModelPerspectivesOperationCompleted, userState);
        }

        private void OnListModelPerspectivesOperationCompleted(object arg)
        {
            if ((this.ListModelPerspectivesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListModelPerspectivesCompleted(this, new ListModelPerspectivesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/Regenera" +
            "teModel", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Warnings")]
        public Warning[] RegenerateModel(string Model)
        {
            object[] results = this.Invoke("RegenerateModel", new object[] {
                    Model});
            return ((Warning[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginRegenerateModel(string Model, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("RegenerateModel", new object[] {
                    Model}, callback, asyncState);
        }

        /// <remarks/>
        public Warning[] EndRegenerateModel(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((Warning[])(results[0]));
        }

        /// <remarks/>
        public void RegenerateModelAsync(string Model)
        {
            this.RegenerateModelAsync(Model, null);
        }

        /// <remarks/>
        public void RegenerateModelAsync(string Model, object userState)
        {
            if ((this.RegenerateModelOperationCompleted == null))
            {
                this.RegenerateModelOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegenerateModelOperationCompleted);
            }
            this.InvokeAsync("RegenerateModel", new object[] {
                    Model}, this.RegenerateModelOperationCompleted, userState);
        }

        private void OnRegenerateModelOperationCompleted(object arg)
        {
            if ((this.RegenerateModelCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegenerateModelCompleted(this, new RegenerateModelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/RemoveAl" +
            "lModelItemPolicies", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void RemoveAllModelItemPolicies(string Model)
        {
            this.Invoke("RemoveAllModelItemPolicies", new object[] {
                    Model});
        }

        /// <remarks/>
        public System.IAsyncResult BeginRemoveAllModelItemPolicies(string Model, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("RemoveAllModelItemPolicies", new object[] {
                    Model}, callback, asyncState);
        }

        /// <remarks/>
        public void EndRemoveAllModelItemPolicies(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void RemoveAllModelItemPoliciesAsync(string Model)
        {
            this.RemoveAllModelItemPoliciesAsync(Model, null);
        }

        /// <remarks/>
        public void RemoveAllModelItemPoliciesAsync(string Model, object userState)
        {
            if ((this.RemoveAllModelItemPoliciesOperationCompleted == null))
            {
                this.RemoveAllModelItemPoliciesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRemoveAllModelItemPoliciesOperationCompleted);
            }
            this.InvokeAsync("RemoveAllModelItemPolicies", new object[] {
                    Model}, this.RemoveAllModelItemPoliciesOperationCompleted, userState);
        }

        private void OnRemoveAllModelItemPoliciesOperationCompleted(object arg)
        {
            if ((this.RemoveAllModelItemPoliciesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RemoveAllModelItemPoliciesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateSc" +
            "hedule", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ScheduleID")]
        public string CreateSchedule(string Name, ScheduleDefinition ScheduleDefinition, string SiteUrl)
        {
            object[] results = this.Invoke("CreateSchedule", new object[] {
                    Name,
                    ScheduleDefinition,
                    SiteUrl});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginCreateSchedule(string Name, ScheduleDefinition ScheduleDefinition, string SiteUrl, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("CreateSchedule", new object[] {
                    Name,
                    ScheduleDefinition,
                    SiteUrl}, callback, asyncState);
        }

        /// <remarks/>
        public string EndCreateSchedule(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void CreateScheduleAsync(string Name, ScheduleDefinition ScheduleDefinition, string SiteUrl)
        {
            this.CreateScheduleAsync(Name, ScheduleDefinition, SiteUrl, null);
        }

        /// <remarks/>
        public void CreateScheduleAsync(string Name, ScheduleDefinition ScheduleDefinition, string SiteUrl, object userState)
        {
            if ((this.CreateScheduleOperationCompleted == null))
            {
                this.CreateScheduleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateScheduleOperationCompleted);
            }
            this.InvokeAsync("CreateSchedule", new object[] {
                    Name,
                    ScheduleDefinition,
                    SiteUrl}, this.CreateScheduleOperationCompleted, userState);
        }

        private void OnCreateScheduleOperationCompleted(object arg)
        {
            if ((this.CreateScheduleCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateScheduleCompleted(this, new CreateScheduleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteSc" +
            "hedule", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteSchedule(string ScheduleID)
        {
            this.Invoke("DeleteSchedule", new object[] {
                    ScheduleID});
        }

        /// <remarks/>
        public System.IAsyncResult BeginDeleteSchedule(string ScheduleID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("DeleteSchedule", new object[] {
                    ScheduleID}, callback, asyncState);
        }

        /// <remarks/>
        public void EndDeleteSchedule(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void DeleteScheduleAsync(string ScheduleID)
        {
            this.DeleteScheduleAsync(ScheduleID, null);
        }

        /// <remarks/>
        public void DeleteScheduleAsync(string ScheduleID, object userState)
        {
            if ((this.DeleteScheduleOperationCompleted == null))
            {
                this.DeleteScheduleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteScheduleOperationCompleted);
            }
            this.InvokeAsync("DeleteSchedule", new object[] {
                    ScheduleID}, this.DeleteScheduleOperationCompleted, userState);
        }

        private void OnDeleteScheduleOperationCompleted(object arg)
        {
            if ((this.DeleteScheduleCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteScheduleCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSche" +
            "dules", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Schedules")]
        public Schedule[] ListSchedules(string SiteUrl)
        {
            object[] results = this.Invoke("ListSchedules", new object[] {
                    SiteUrl});
            return ((Schedule[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListSchedules(string SiteUrl, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListSchedules", new object[] {
                    SiteUrl}, callback, asyncState);
        }

        /// <remarks/>
        public Schedule[] EndListSchedules(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((Schedule[])(results[0]));
        }

        /// <remarks/>
        public void ListSchedulesAsync(string SiteUrl)
        {
            this.ListSchedulesAsync(SiteUrl, null);
        }

        /// <remarks/>
        public void ListSchedulesAsync(string SiteUrl, object userState)
        {
            if ((this.ListSchedulesOperationCompleted == null))
            {
                this.ListSchedulesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListSchedulesOperationCompleted);
            }
            this.InvokeAsync("ListSchedules", new object[] {
                    SiteUrl}, this.ListSchedulesOperationCompleted, userState);
        }

        private void OnListSchedulesOperationCompleted(object arg)
        {
            if ((this.ListSchedulesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListSchedulesCompleted(this, new ListSchedulesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSched" +
            "uleProperties", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Schedule")]
        public Schedule GetScheduleProperties(string ScheduleID)
        {
            object[] results = this.Invoke("GetScheduleProperties", new object[] {
                    ScheduleID});
            return ((Schedule)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetScheduleProperties(string ScheduleID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetScheduleProperties", new object[] {
                    ScheduleID}, callback, asyncState);
        }

        /// <remarks/>
        public Schedule EndGetScheduleProperties(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((Schedule)(results[0]));
        }

        /// <remarks/>
        public void GetSchedulePropertiesAsync(string ScheduleID)
        {
            this.GetSchedulePropertiesAsync(ScheduleID, null);
        }

        /// <remarks/>
        public void GetSchedulePropertiesAsync(string ScheduleID, object userState)
        {
            if ((this.GetSchedulePropertiesOperationCompleted == null))
            {
                this.GetSchedulePropertiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSchedulePropertiesOperationCompleted);
            }
            this.InvokeAsync("GetScheduleProperties", new object[] {
                    ScheduleID}, this.GetSchedulePropertiesOperationCompleted, userState);
        }

        private void OnGetSchedulePropertiesOperationCompleted(object arg)
        {
            if ((this.GetSchedulePropertiesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSchedulePropertiesCompleted(this, new GetSchedulePropertiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSche" +
            "duleStates", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] ListScheduleStates()
        {
            object[] results = this.Invoke("ListScheduleStates", new object[0]);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListScheduleStates(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListScheduleStates", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public string[] EndListScheduleStates(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void ListScheduleStatesAsync()
        {
            this.ListScheduleStatesAsync(null);
        }

        /// <remarks/>
        public void ListScheduleStatesAsync(object userState)
        {
            if ((this.ListScheduleStatesOperationCompleted == null))
            {
                this.ListScheduleStatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListScheduleStatesOperationCompleted);
            }
            this.InvokeAsync("ListScheduleStates", new object[0], this.ListScheduleStatesOperationCompleted, userState);
        }

        private void OnListScheduleStatesOperationCompleted(object arg)
        {
            if ((this.ListScheduleStatesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListScheduleStatesCompleted(this, new ListScheduleStatesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/PauseSch" +
            "edule", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void PauseSchedule(string ScheduleID)
        {
            this.Invoke("PauseSchedule", new object[] {
                    ScheduleID});
        }

        /// <remarks/>
        public System.IAsyncResult BeginPauseSchedule(string ScheduleID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("PauseSchedule", new object[] {
                    ScheduleID}, callback, asyncState);
        }

        /// <remarks/>
        public void EndPauseSchedule(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void PauseScheduleAsync(string ScheduleID)
        {
            this.PauseScheduleAsync(ScheduleID, null);
        }

        /// <remarks/>
        public void PauseScheduleAsync(string ScheduleID, object userState)
        {
            if ((this.PauseScheduleOperationCompleted == null))
            {
                this.PauseScheduleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPauseScheduleOperationCompleted);
            }
            this.InvokeAsync("PauseSchedule", new object[] {
                    ScheduleID}, this.PauseScheduleOperationCompleted, userState);
        }

        private void OnPauseScheduleOperationCompleted(object arg)
        {
            if ((this.PauseScheduleCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PauseScheduleCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ResumeSc" +
            "hedule", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ResumeSchedule(string ScheduleID)
        {
            this.Invoke("ResumeSchedule", new object[] {
                    ScheduleID});
        }

        /// <remarks/>
        public System.IAsyncResult BeginResumeSchedule(string ScheduleID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ResumeSchedule", new object[] {
                    ScheduleID}, callback, asyncState);
        }

        /// <remarks/>
        public void EndResumeSchedule(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void ResumeScheduleAsync(string ScheduleID)
        {
            this.ResumeScheduleAsync(ScheduleID, null);
        }

        /// <remarks/>
        public void ResumeScheduleAsync(string ScheduleID, object userState)
        {
            if ((this.ResumeScheduleOperationCompleted == null))
            {
                this.ResumeScheduleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnResumeScheduleOperationCompleted);
            }
            this.InvokeAsync("ResumeSchedule", new object[] {
                    ScheduleID}, this.ResumeScheduleOperationCompleted, userState);
        }

        private void OnResumeScheduleOperationCompleted(object arg)
        {
            if ((this.ResumeScheduleCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ResumeScheduleCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetSched" +
            "uleProperties", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetScheduleProperties(string Name, string ScheduleID, ScheduleDefinition ScheduleDefinition)
        {
            this.Invoke("SetScheduleProperties", new object[] {
                    Name,
                    ScheduleID,
                    ScheduleDefinition});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetScheduleProperties(string Name, string ScheduleID, ScheduleDefinition ScheduleDefinition, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetScheduleProperties", new object[] {
                    Name,
                    ScheduleID,
                    ScheduleDefinition}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetScheduleProperties(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetSchedulePropertiesAsync(string Name, string ScheduleID, ScheduleDefinition ScheduleDefinition)
        {
            this.SetSchedulePropertiesAsync(Name, ScheduleID, ScheduleDefinition, null);
        }

        /// <remarks/>
        public void SetSchedulePropertiesAsync(string Name, string ScheduleID, ScheduleDefinition ScheduleDefinition, object userState)
        {
            if ((this.SetSchedulePropertiesOperationCompleted == null))
            {
                this.SetSchedulePropertiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetSchedulePropertiesOperationCompleted);
            }
            this.InvokeAsync("SetScheduleProperties", new object[] {
                    Name,
                    ScheduleID,
                    ScheduleDefinition}, this.SetSchedulePropertiesOperationCompleted, userState);
        }

        private void OnSetSchedulePropertiesOperationCompleted(object arg)
        {
            if ((this.SetSchedulePropertiesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetSchedulePropertiesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSche" +
            "duledItems", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Items")]
        public CatalogItem[] ListScheduledItems(string ScheduleID)
        {
            object[] results = this.Invoke("ListScheduledItems", new object[] {
                    ScheduleID});
            return ((CatalogItem[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListScheduledItems(string ScheduleID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListScheduledItems", new object[] {
                    ScheduleID}, callback, asyncState);
        }

        /// <remarks/>
        public CatalogItem[] EndListScheduledItems(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((CatalogItem[])(results[0]));
        }

        /// <remarks/>
        public void ListScheduledItemsAsync(string ScheduleID)
        {
            this.ListScheduledItemsAsync(ScheduleID, null);
        }

        /// <remarks/>
        public void ListScheduledItemsAsync(string ScheduleID, object userState)
        {
            if ((this.ListScheduledItemsOperationCompleted == null))
            {
                this.ListScheduledItemsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListScheduledItemsOperationCompleted);
            }
            this.InvokeAsync("ListScheduledItems", new object[] {
                    ScheduleID}, this.ListScheduledItemsOperationCompleted, userState);
        }

        private void OnListScheduledItemsOperationCompleted(object arg)
        {
            if ((this.ListScheduledItemsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListScheduledItemsCompleted(this, new ListScheduledItemsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemP" +
            "arameters", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetItemParameters(string ItemPath, ItemParameter[] Parameters)
        {
            this.Invoke("SetItemParameters", new object[] {
                    ItemPath,
                    Parameters});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetItemParameters(string ItemPath, ItemParameter[] Parameters, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetItemParameters", new object[] {
                    ItemPath,
                    Parameters}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetItemParameters(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetItemParametersAsync(string ItemPath, ItemParameter[] Parameters)
        {
            this.SetItemParametersAsync(ItemPath, Parameters, null);
        }

        /// <remarks/>
        public void SetItemParametersAsync(string ItemPath, ItemParameter[] Parameters, object userState)
        {
            if ((this.SetItemParametersOperationCompleted == null))
            {
                this.SetItemParametersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetItemParametersOperationCompleted);
            }
            this.InvokeAsync("SetItemParameters", new object[] {
                    ItemPath,
                    Parameters}, this.SetItemParametersOperationCompleted, userState);
        }

        private void OnSetItemParametersOperationCompleted(object arg)
        {
            if ((this.SetItemParametersCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetItemParametersCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemP" +
            "arameters", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Parameters")]
        public ItemParameter[] GetItemParameters(string ItemPath, string HistoryID, bool ForRendering, ParameterValue[] Values, DataSourceCredentials[] Credentials)
        {
            object[] results = this.Invoke("GetItemParameters", new object[] {
                    ItemPath,
                    HistoryID,
                    ForRendering,
                    Values,
                    Credentials});
            return ((ItemParameter[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetItemParameters(string ItemPath, string HistoryID, bool ForRendering, ParameterValue[] Values, DataSourceCredentials[] Credentials, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetItemParameters", new object[] {
                    ItemPath,
                    HistoryID,
                    ForRendering,
                    Values,
                    Credentials}, callback, asyncState);
        }

        /// <remarks/>
        public ItemParameter[] EndGetItemParameters(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ItemParameter[])(results[0]));
        }

        /// <remarks/>
        public void GetItemParametersAsync(string ItemPath, string HistoryID, bool ForRendering, ParameterValue[] Values, DataSourceCredentials[] Credentials)
        {
            this.GetItemParametersAsync(ItemPath, HistoryID, ForRendering, Values, Credentials, null);
        }

        /// <remarks/>
        public void GetItemParametersAsync(string ItemPath, string HistoryID, bool ForRendering, ParameterValue[] Values, DataSourceCredentials[] Credentials, object userState)
        {
            if ((this.GetItemParametersOperationCompleted == null))
            {
                this.GetItemParametersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetItemParametersOperationCompleted);
            }
            this.InvokeAsync("GetItemParameters", new object[] {
                    ItemPath,
                    HistoryID,
                    ForRendering,
                    Values,
                    Credentials}, this.GetItemParametersOperationCompleted, userState);
        }

        private void OnGetItemParametersOperationCompleted(object arg)
        {
            if ((this.GetItemParametersCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetItemParametersCompleted(this, new GetItemParametersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListPara" +
            "meterTypes", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] ListParameterTypes()
        {
            object[] results = this.Invoke("ListParameterTypes", new object[0]);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListParameterTypes(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListParameterTypes", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public string[] EndListParameterTypes(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void ListParameterTypesAsync()
        {
            this.ListParameterTypesAsync(null);
        }

        /// <remarks/>
        public void ListParameterTypesAsync(object userState)
        {
            if ((this.ListParameterTypesOperationCompleted == null))
            {
                this.ListParameterTypesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListParameterTypesOperationCompleted);
            }
            this.InvokeAsync("ListParameterTypes", new object[0], this.ListParameterTypesOperationCompleted, userState);
        }

        private void OnListParameterTypesOperationCompleted(object arg)
        {
            if ((this.ListParameterTypesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListParameterTypesCompleted(this, new ListParameterTypesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListPara" +
            "meterStates", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] ListParameterStates()
        {
            object[] results = this.Invoke("ListParameterStates", new object[0]);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListParameterStates(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListParameterStates", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public string[] EndListParameterStates(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void ListParameterStatesAsync()
        {
            this.ListParameterStatesAsync(null);
        }

        /// <remarks/>
        public void ListParameterStatesAsync(object userState)
        {
            if ((this.ListParameterStatesOperationCompleted == null))
            {
                this.ListParameterStatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListParameterStatesOperationCompleted);
            }
            this.InvokeAsync("ListParameterStates", new object[0], this.ListParameterStatesOperationCompleted, userState);
        }

        private void OnListParameterStatesOperationCompleted(object arg)
        {
            if ((this.ListParameterStatesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListParameterStatesCompleted(this, new ListParameterStatesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateRe" +
            "portEditSession", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("EditSessionID")]
        public string CreateReportEditSession(string Report, string Parent, [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")] byte[] Definition, out Warning[] Warnings)
        {
            object[] results = this.Invoke("CreateReportEditSession", new object[] {
                    Report,
                    Parent,
                    Definition});
            Warnings = ((Warning[])(results[1]));
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginCreateReportEditSession(string Report, string Parent, byte[] Definition, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("CreateReportEditSession", new object[] {
                    Report,
                    Parent,
                    Definition}, callback, asyncState);
        }

        /// <remarks/>
        public string EndCreateReportEditSession(System.IAsyncResult asyncResult, out Warning[] Warnings)
        {
            object[] results = this.EndInvoke(asyncResult);
            Warnings = ((Warning[])(results[1]));
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void CreateReportEditSessionAsync(string Report, string Parent, byte[] Definition)
        {
            this.CreateReportEditSessionAsync(Report, Parent, Definition, null);
        }

        /// <remarks/>
        public void CreateReportEditSessionAsync(string Report, string Parent, byte[] Definition, object userState)
        {
            if ((this.CreateReportEditSessionOperationCompleted == null))
            {
                this.CreateReportEditSessionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateReportEditSessionOperationCompleted);
            }
            this.InvokeAsync("CreateReportEditSession", new object[] {
                    Report,
                    Parent,
                    Definition}, this.CreateReportEditSessionOperationCompleted, userState);
        }

        private void OnCreateReportEditSessionOperationCompleted(object arg)
        {
            if ((this.CreateReportEditSessionCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateReportEditSessionCompleted(this, new CreateReportEditSessionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateLi" +
            "nkedItem", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateLinkedItem(string ItemPath, string Parent, string Link, Property[] Properties)
        {
            this.Invoke("CreateLinkedItem", new object[] {
                    ItemPath,
                    Parent,
                    Link,
                    Properties});
        }

        /// <remarks/>
        public System.IAsyncResult BeginCreateLinkedItem(string ItemPath, string Parent, string Link, Property[] Properties, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("CreateLinkedItem", new object[] {
                    ItemPath,
                    Parent,
                    Link,
                    Properties}, callback, asyncState);
        }

        /// <remarks/>
        public void EndCreateLinkedItem(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void CreateLinkedItemAsync(string ItemPath, string Parent, string Link, Property[] Properties)
        {
            this.CreateLinkedItemAsync(ItemPath, Parent, Link, Properties, null);
        }

        /// <remarks/>
        public void CreateLinkedItemAsync(string ItemPath, string Parent, string Link, Property[] Properties, object userState)
        {
            if ((this.CreateLinkedItemOperationCompleted == null))
            {
                this.CreateLinkedItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateLinkedItemOperationCompleted);
            }
            this.InvokeAsync("CreateLinkedItem", new object[] {
                    ItemPath,
                    Parent,
                    Link,
                    Properties}, this.CreateLinkedItemOperationCompleted, userState);
        }

        private void OnCreateLinkedItemOperationCompleted(object arg)
        {
            if ((this.CreateLinkedItemCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateLinkedItemCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemL" +
            "ink", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetItemLink(string ItemPath, string Link)
        {
            this.Invoke("SetItemLink", new object[] {
                    ItemPath,
                    Link});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetItemLink(string ItemPath, string Link, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetItemLink", new object[] {
                    ItemPath,
                    Link}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetItemLink(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetItemLinkAsync(string ItemPath, string Link)
        {
            this.SetItemLinkAsync(ItemPath, Link, null);
        }

        /// <remarks/>
        public void SetItemLinkAsync(string ItemPath, string Link, object userState)
        {
            if ((this.SetItemLinkOperationCompleted == null))
            {
                this.SetItemLinkOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetItemLinkOperationCompleted);
            }
            this.InvokeAsync("SetItemLink", new object[] {
                    ItemPath,
                    Link}, this.SetItemLinkOperationCompleted, userState);
        }

        private void OnSetItemLinkOperationCompleted(object arg)
        {
            if ((this.SetItemLinkCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetItemLinkCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemL" +
            "ink", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Link")]
        public string GetItemLink(string ItemPath)
        {
            object[] results = this.Invoke("GetItemLink", new object[] {
                    ItemPath});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetItemLink(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetItemLink", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public string EndGetItemLink(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void GetItemLinkAsync(string ItemPath)
        {
            this.GetItemLinkAsync(ItemPath, null);
        }

        /// <remarks/>
        public void GetItemLinkAsync(string ItemPath, object userState)
        {
            if ((this.GetItemLinkOperationCompleted == null))
            {
                this.GetItemLinkOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetItemLinkOperationCompleted);
            }
            this.InvokeAsync("GetItemLink", new object[] {
                    ItemPath}, this.GetItemLinkOperationCompleted, userState);
        }

        private void OnGetItemLinkOperationCompleted(object arg)
        {
            if ((this.GetItemLinkCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetItemLinkCompleted(this, new GetItemLinkCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListExec" +
            "utionSettings", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] ListExecutionSettings()
        {
            object[] results = this.Invoke("ListExecutionSettings", new object[0]);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListExecutionSettings(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListExecutionSettings", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public string[] EndListExecutionSettings(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void ListExecutionSettingsAsync()
        {
            this.ListExecutionSettingsAsync(null);
        }

        /// <remarks/>
        public void ListExecutionSettingsAsync(object userState)
        {
            if ((this.ListExecutionSettingsOperationCompleted == null))
            {
                this.ListExecutionSettingsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListExecutionSettingsOperationCompleted);
            }
            this.InvokeAsync("ListExecutionSettings", new object[0], this.ListExecutionSettingsOperationCompleted, userState);
        }

        private void OnListExecutionSettingsOperationCompleted(object arg)
        {
            if ((this.ListExecutionSettingsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListExecutionSettingsCompleted(this, new ListExecutionSettingsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetExecu" +
            "tionOptions", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetExecutionOptions(string ItemPath, string ExecutionSetting, [System.Xml.Serialization.XmlElementAttribute("NoSchedule", typeof(NoSchedule))] [System.Xml.Serialization.XmlElementAttribute("ScheduleDefinition", typeof(ScheduleDefinition))] [System.Xml.Serialization.XmlElementAttribute("ScheduleReference", typeof(ScheduleReference))] ScheduleDefinitionOrReference Item)
        {
            this.Invoke("SetExecutionOptions", new object[] {
                    ItemPath,
                    ExecutionSetting,
                    Item});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetExecutionOptions(string ItemPath, string ExecutionSetting, ScheduleDefinitionOrReference Item, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetExecutionOptions", new object[] {
                    ItemPath,
                    ExecutionSetting,
                    Item}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetExecutionOptions(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetExecutionOptionsAsync(string ItemPath, string ExecutionSetting, ScheduleDefinitionOrReference Item)
        {
            this.SetExecutionOptionsAsync(ItemPath, ExecutionSetting, Item, null);
        }

        /// <remarks/>
        public void SetExecutionOptionsAsync(string ItemPath, string ExecutionSetting, ScheduleDefinitionOrReference Item, object userState)
        {
            if ((this.SetExecutionOptionsOperationCompleted == null))
            {
                this.SetExecutionOptionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetExecutionOptionsOperationCompleted);
            }
            this.InvokeAsync("SetExecutionOptions", new object[] {
                    ItemPath,
                    ExecutionSetting,
                    Item}, this.SetExecutionOptionsOperationCompleted, userState);
        }

        private void OnSetExecutionOptionsOperationCompleted(object arg)
        {
            if ((this.SetExecutionOptionsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetExecutionOptionsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetExecu" +
            "tionOptions", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ExecutionSetting")]
        public string GetExecutionOptions(string ItemPath, [System.Xml.Serialization.XmlElementAttribute("NoSchedule", typeof(NoSchedule))] [System.Xml.Serialization.XmlElementAttribute("ScheduleDefinition", typeof(ScheduleDefinition))] [System.Xml.Serialization.XmlElementAttribute("ScheduleReference", typeof(ScheduleReference))] out ScheduleDefinitionOrReference Item)
        {
            object[] results = this.Invoke("GetExecutionOptions", new object[] {
                    ItemPath});
            Item = ((ScheduleDefinitionOrReference)(results[1]));
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetExecutionOptions(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetExecutionOptions", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public string EndGetExecutionOptions(System.IAsyncResult asyncResult, out ScheduleDefinitionOrReference Item)
        {
            object[] results = this.EndInvoke(asyncResult);
            Item = ((ScheduleDefinitionOrReference)(results[1]));
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void GetExecutionOptionsAsync(string ItemPath)
        {
            this.GetExecutionOptionsAsync(ItemPath, null);
        }

        /// <remarks/>
        public void GetExecutionOptionsAsync(string ItemPath, object userState)
        {
            if ((this.GetExecutionOptionsOperationCompleted == null))
            {
                this.GetExecutionOptionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetExecutionOptionsOperationCompleted);
            }
            this.InvokeAsync("GetExecutionOptions", new object[] {
                    ItemPath}, this.GetExecutionOptionsOperationCompleted, userState);
        }

        private void OnGetExecutionOptionsOperationCompleted(object arg)
        {
            if ((this.GetExecutionOptionsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetExecutionOptionsCompleted(this, new GetExecutionOptionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/UpdateIt" +
            "emExecutionSnapshot", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateItemExecutionSnapshot(string ItemPath)
        {
            this.Invoke("UpdateItemExecutionSnapshot", new object[] {
                    ItemPath});
        }

        /// <remarks/>
        public System.IAsyncResult BeginUpdateItemExecutionSnapshot(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("UpdateItemExecutionSnapshot", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public void EndUpdateItemExecutionSnapshot(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void UpdateItemExecutionSnapshotAsync(string ItemPath)
        {
            this.UpdateItemExecutionSnapshotAsync(ItemPath, null);
        }

        /// <remarks/>
        public void UpdateItemExecutionSnapshotAsync(string ItemPath, object userState)
        {
            if ((this.UpdateItemExecutionSnapshotOperationCompleted == null))
            {
                this.UpdateItemExecutionSnapshotOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateItemExecutionSnapshotOperationCompleted);
            }
            this.InvokeAsync("UpdateItemExecutionSnapshot", new object[] {
                    ItemPath}, this.UpdateItemExecutionSnapshotOperationCompleted, userState);
        }

        private void OnUpdateItemExecutionSnapshotOperationCompleted(object arg)
        {
            if ((this.UpdateItemExecutionSnapshotCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateItemExecutionSnapshotCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetCache" +
            "Options", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetCacheOptions(string ItemPath, bool CacheItem, [System.Xml.Serialization.XmlElementAttribute("ScheduleExpiration", typeof(ScheduleExpiration))] [System.Xml.Serialization.XmlElementAttribute("TimeExpiration", typeof(TimeExpiration))] ExpirationDefinition Item)
        {
            this.Invoke("SetCacheOptions", new object[] {
                    ItemPath,
                    CacheItem,
                    Item});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetCacheOptions(string ItemPath, bool CacheItem, ExpirationDefinition Item, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetCacheOptions", new object[] {
                    ItemPath,
                    CacheItem,
                    Item}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetCacheOptions(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetCacheOptionsAsync(string ItemPath, bool CacheItem, ExpirationDefinition Item)
        {
            this.SetCacheOptionsAsync(ItemPath, CacheItem, Item, null);
        }

        /// <remarks/>
        public void SetCacheOptionsAsync(string ItemPath, bool CacheItem, ExpirationDefinition Item, object userState)
        {
            if ((this.SetCacheOptionsOperationCompleted == null))
            {
                this.SetCacheOptionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetCacheOptionsOperationCompleted);
            }
            this.InvokeAsync("SetCacheOptions", new object[] {
                    ItemPath,
                    CacheItem,
                    Item}, this.SetCacheOptionsOperationCompleted, userState);
        }

        private void OnSetCacheOptionsOperationCompleted(object arg)
        {
            if ((this.SetCacheOptionsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetCacheOptionsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetCache" +
            "Options", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("CacheItem")]
        public bool GetCacheOptions(string ItemPath, [System.Xml.Serialization.XmlElementAttribute("ScheduleExpiration", typeof(ScheduleExpiration))] [System.Xml.Serialization.XmlElementAttribute("TimeExpiration", typeof(TimeExpiration))] out ExpirationDefinition Item)
        {
            object[] results = this.Invoke("GetCacheOptions", new object[] {
                    ItemPath});
            Item = ((ExpirationDefinition)(results[1]));
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetCacheOptions(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetCacheOptions", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public bool EndGetCacheOptions(System.IAsyncResult asyncResult, out ExpirationDefinition Item)
        {
            object[] results = this.EndInvoke(asyncResult);
            Item = ((ExpirationDefinition)(results[1]));
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public void GetCacheOptionsAsync(string ItemPath)
        {
            this.GetCacheOptionsAsync(ItemPath, null);
        }

        /// <remarks/>
        public void GetCacheOptionsAsync(string ItemPath, object userState)
        {
            if ((this.GetCacheOptionsOperationCompleted == null))
            {
                this.GetCacheOptionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCacheOptionsOperationCompleted);
            }
            this.InvokeAsync("GetCacheOptions", new object[] {
                    ItemPath}, this.GetCacheOptionsOperationCompleted, userState);
        }

        private void OnGetCacheOptionsOperationCompleted(object arg)
        {
            if ((this.GetCacheOptionsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCacheOptionsCompleted(this, new GetCacheOptionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/FlushCac" +
            "he", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void FlushCache(string ItemPath)
        {
            this.Invoke("FlushCache", new object[] {
                    ItemPath});
        }

        /// <remarks/>
        public System.IAsyncResult BeginFlushCache(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("FlushCache", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public void EndFlushCache(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void FlushCacheAsync(string ItemPath)
        {
            this.FlushCacheAsync(ItemPath, null);
        }

        /// <remarks/>
        public void FlushCacheAsync(string ItemPath, object userState)
        {
            if ((this.FlushCacheOperationCompleted == null))
            {
                this.FlushCacheOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFlushCacheOperationCompleted);
            }
            this.InvokeAsync("FlushCache", new object[] {
                    ItemPath}, this.FlushCacheOperationCompleted, userState);
        }

        private void OnFlushCacheOperationCompleted(object arg)
        {
            if ((this.FlushCacheCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FlushCacheCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateIt" +
            "emHistorySnapshot", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("HistoryID")]
        public string CreateItemHistorySnapshot(string ItemPath, out Warning[] Warnings)
        {
            object[] results = this.Invoke("CreateItemHistorySnapshot", new object[] {
                    ItemPath});
            Warnings = ((Warning[])(results[1]));
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginCreateItemHistorySnapshot(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("CreateItemHistorySnapshot", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public string EndCreateItemHistorySnapshot(System.IAsyncResult asyncResult, out Warning[] Warnings)
        {
            object[] results = this.EndInvoke(asyncResult);
            Warnings = ((Warning[])(results[1]));
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void CreateItemHistorySnapshotAsync(string ItemPath)
        {
            this.CreateItemHistorySnapshotAsync(ItemPath, null);
        }

        /// <remarks/>
        public void CreateItemHistorySnapshotAsync(string ItemPath, object userState)
        {
            if ((this.CreateItemHistorySnapshotOperationCompleted == null))
            {
                this.CreateItemHistorySnapshotOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateItemHistorySnapshotOperationCompleted);
            }
            this.InvokeAsync("CreateItemHistorySnapshot", new object[] {
                    ItemPath}, this.CreateItemHistorySnapshotOperationCompleted, userState);
        }

        private void OnCreateItemHistorySnapshotOperationCompleted(object arg)
        {
            if ((this.CreateItemHistorySnapshotCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateItemHistorySnapshotCompleted(this, new CreateItemHistorySnapshotCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteIt" +
            "emHistorySnapshot", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteItemHistorySnapshot(string ItemPath, string HistoryID)
        {
            this.Invoke("DeleteItemHistorySnapshot", new object[] {
                    ItemPath,
                    HistoryID});
        }

        /// <remarks/>
        public System.IAsyncResult BeginDeleteItemHistorySnapshot(string ItemPath, string HistoryID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("DeleteItemHistorySnapshot", new object[] {
                    ItemPath,
                    HistoryID}, callback, asyncState);
        }

        /// <remarks/>
        public void EndDeleteItemHistorySnapshot(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void DeleteItemHistorySnapshotAsync(string ItemPath, string HistoryID)
        {
            this.DeleteItemHistorySnapshotAsync(ItemPath, HistoryID, null);
        }

        /// <remarks/>
        public void DeleteItemHistorySnapshotAsync(string ItemPath, string HistoryID, object userState)
        {
            if ((this.DeleteItemHistorySnapshotOperationCompleted == null))
            {
                this.DeleteItemHistorySnapshotOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteItemHistorySnapshotOperationCompleted);
            }
            this.InvokeAsync("DeleteItemHistorySnapshot", new object[] {
                    ItemPath,
                    HistoryID}, this.DeleteItemHistorySnapshotOperationCompleted, userState);
        }

        private void OnDeleteItemHistorySnapshotOperationCompleted(object arg)
        {
            if ((this.DeleteItemHistorySnapshotCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteItemHistorySnapshotCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemH" +
            "istoryLimit", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetItemHistoryLimit(string ItemPath, bool UseSystem, int HistoryLimit)
        {
            this.Invoke("SetItemHistoryLimit", new object[] {
                    ItemPath,
                    UseSystem,
                    HistoryLimit});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetItemHistoryLimit(string ItemPath, bool UseSystem, int HistoryLimit, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetItemHistoryLimit", new object[] {
                    ItemPath,
                    UseSystem,
                    HistoryLimit}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetItemHistoryLimit(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetItemHistoryLimitAsync(string ItemPath, bool UseSystem, int HistoryLimit)
        {
            this.SetItemHistoryLimitAsync(ItemPath, UseSystem, HistoryLimit, null);
        }

        /// <remarks/>
        public void SetItemHistoryLimitAsync(string ItemPath, bool UseSystem, int HistoryLimit, object userState)
        {
            if ((this.SetItemHistoryLimitOperationCompleted == null))
            {
                this.SetItemHistoryLimitOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetItemHistoryLimitOperationCompleted);
            }
            this.InvokeAsync("SetItemHistoryLimit", new object[] {
                    ItemPath,
                    UseSystem,
                    HistoryLimit}, this.SetItemHistoryLimitOperationCompleted, userState);
        }

        private void OnSetItemHistoryLimitOperationCompleted(object arg)
        {
            if ((this.SetItemHistoryLimitCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetItemHistoryLimitCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemH" +
            "istoryLimit", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("HistoryLimit")]
        public int GetItemHistoryLimit(string ItemPath, out bool IsSystem, out int SystemLimit)
        {
            object[] results = this.Invoke("GetItemHistoryLimit", new object[] {
                    ItemPath});
            IsSystem = ((bool)(results[1]));
            SystemLimit = ((int)(results[2]));
            return ((int)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetItemHistoryLimit(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetItemHistoryLimit", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public int EndGetItemHistoryLimit(System.IAsyncResult asyncResult, out bool IsSystem, out int SystemLimit)
        {
            object[] results = this.EndInvoke(asyncResult);
            IsSystem = ((bool)(results[1]));
            SystemLimit = ((int)(results[2]));
            return ((int)(results[0]));
        }

        /// <remarks/>
        public void GetItemHistoryLimitAsync(string ItemPath)
        {
            this.GetItemHistoryLimitAsync(ItemPath, null);
        }

        /// <remarks/>
        public void GetItemHistoryLimitAsync(string ItemPath, object userState)
        {
            if ((this.GetItemHistoryLimitOperationCompleted == null))
            {
                this.GetItemHistoryLimitOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetItemHistoryLimitOperationCompleted);
            }
            this.InvokeAsync("GetItemHistoryLimit", new object[] {
                    ItemPath}, this.GetItemHistoryLimitOperationCompleted, userState);
        }

        private void OnGetItemHistoryLimitOperationCompleted(object arg)
        {
            if ((this.GetItemHistoryLimitCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetItemHistoryLimitCompleted(this, new GetItemHistoryLimitCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemH" +
            "istoryOptions", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetItemHistoryOptions(string ItemPath, bool EnableManualSnapshotCreation, bool KeepExecutionSnapshots, [System.Xml.Serialization.XmlElementAttribute("NoSchedule", typeof(NoSchedule))] [System.Xml.Serialization.XmlElementAttribute("ScheduleDefinition", typeof(ScheduleDefinition))] [System.Xml.Serialization.XmlElementAttribute("ScheduleReference", typeof(ScheduleReference))] ScheduleDefinitionOrReference Item)
        {
            this.Invoke("SetItemHistoryOptions", new object[] {
                    ItemPath,
                    EnableManualSnapshotCreation,
                    KeepExecutionSnapshots,
                    Item});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetItemHistoryOptions(string ItemPath, bool EnableManualSnapshotCreation, bool KeepExecutionSnapshots, ScheduleDefinitionOrReference Item, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetItemHistoryOptions", new object[] {
                    ItemPath,
                    EnableManualSnapshotCreation,
                    KeepExecutionSnapshots,
                    Item}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetItemHistoryOptions(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetItemHistoryOptionsAsync(string ItemPath, bool EnableManualSnapshotCreation, bool KeepExecutionSnapshots, ScheduleDefinitionOrReference Item)
        {
            this.SetItemHistoryOptionsAsync(ItemPath, EnableManualSnapshotCreation, KeepExecutionSnapshots, Item, null);
        }

        /// <remarks/>
        public void SetItemHistoryOptionsAsync(string ItemPath, bool EnableManualSnapshotCreation, bool KeepExecutionSnapshots, ScheduleDefinitionOrReference Item, object userState)
        {
            if ((this.SetItemHistoryOptionsOperationCompleted == null))
            {
                this.SetItemHistoryOptionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetItemHistoryOptionsOperationCompleted);
            }
            this.InvokeAsync("SetItemHistoryOptions", new object[] {
                    ItemPath,
                    EnableManualSnapshotCreation,
                    KeepExecutionSnapshots,
                    Item}, this.SetItemHistoryOptionsOperationCompleted, userState);
        }

        private void OnSetItemHistoryOptionsOperationCompleted(object arg)
        {
            if ((this.SetItemHistoryOptionsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetItemHistoryOptionsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemH" +
            "istoryOptions", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("EnableManualSnapshotCreation")]
        public bool GetItemHistoryOptions(string ItemPath, out bool KeepExecutionSnapshots, [System.Xml.Serialization.XmlElementAttribute("NoSchedule", typeof(NoSchedule))] [System.Xml.Serialization.XmlElementAttribute("ScheduleDefinition", typeof(ScheduleDefinition))] [System.Xml.Serialization.XmlElementAttribute("ScheduleReference", typeof(ScheduleReference))] out ScheduleDefinitionOrReference Item)
        {
            object[] results = this.Invoke("GetItemHistoryOptions", new object[] {
                    ItemPath});
            KeepExecutionSnapshots = ((bool)(results[1]));
            Item = ((ScheduleDefinitionOrReference)(results[2]));
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetItemHistoryOptions(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetItemHistoryOptions", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public bool EndGetItemHistoryOptions(System.IAsyncResult asyncResult, out bool KeepExecutionSnapshots, out ScheduleDefinitionOrReference Item)
        {
            object[] results = this.EndInvoke(asyncResult);
            KeepExecutionSnapshots = ((bool)(results[1]));
            Item = ((ScheduleDefinitionOrReference)(results[2]));
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public void GetItemHistoryOptionsAsync(string ItemPath)
        {
            this.GetItemHistoryOptionsAsync(ItemPath, null);
        }

        /// <remarks/>
        public void GetItemHistoryOptionsAsync(string ItemPath, object userState)
        {
            if ((this.GetItemHistoryOptionsOperationCompleted == null))
            {
                this.GetItemHistoryOptionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetItemHistoryOptionsOperationCompleted);
            }
            this.InvokeAsync("GetItemHistoryOptions", new object[] {
                    ItemPath}, this.GetItemHistoryOptionsOperationCompleted, userState);
        }

        private void OnGetItemHistoryOptionsOperationCompleted(object arg)
        {
            if ((this.GetItemHistoryOptionsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetItemHistoryOptionsCompleted(this, new GetItemHistoryOptionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetRepor" +
            "tServerConfigInfo", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ServerConfigInfo")]
        public string GetReportServerConfigInfo(bool ScaleOut)
        {
            object[] results = this.Invoke("GetReportServerConfigInfo", new object[] {
                    ScaleOut});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetReportServerConfigInfo(bool ScaleOut, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetReportServerConfigInfo", new object[] {
                    ScaleOut}, callback, asyncState);
        }

        /// <remarks/>
        public string EndGetReportServerConfigInfo(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void GetReportServerConfigInfoAsync(bool ScaleOut)
        {
            this.GetReportServerConfigInfoAsync(ScaleOut, null);
        }

        /// <remarks/>
        public void GetReportServerConfigInfoAsync(bool ScaleOut, object userState)
        {
            if ((this.GetReportServerConfigInfoOperationCompleted == null))
            {
                this.GetReportServerConfigInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetReportServerConfigInfoOperationCompleted);
            }
            this.InvokeAsync("GetReportServerConfigInfo", new object[] {
                    ScaleOut}, this.GetReportServerConfigInfoOperationCompleted, userState);
        }

        private void OnGetReportServerConfigInfoOperationCompleted(object arg)
        {
            if ((this.GetReportServerConfigInfoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetReportServerConfigInfoCompleted(this, new GetReportServerConfigInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/IsSSLReq" +
            "uired", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool IsSSLRequired()
        {
            object[] results = this.Invoke("IsSSLRequired", new object[0]);
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginIsSSLRequired(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("IsSSLRequired", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public bool EndIsSSLRequired(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public void IsSSLRequiredAsync()
        {
            this.IsSSLRequiredAsync(null);
        }

        /// <remarks/>
        public void IsSSLRequiredAsync(object userState)
        {
            if ((this.IsSSLRequiredOperationCompleted == null))
            {
                this.IsSSLRequiredOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsSSLRequiredOperationCompleted);
            }
            this.InvokeAsync("IsSSLRequired", new object[0], this.IsSSLRequiredOperationCompleted, userState);
        }

        private void OnIsSSLRequiredOperationCompleted(object arg)
        {
            if ((this.IsSSLRequiredCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsSSLRequiredCompleted(this, new IsSSLRequiredCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetSyste" +
            "mProperties", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetSystemProperties(Property[] Properties)
        {
            this.Invoke("SetSystemProperties", new object[] {
                    Properties});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetSystemProperties(Property[] Properties, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetSystemProperties", new object[] {
                    Properties}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetSystemProperties(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetSystemPropertiesAsync(Property[] Properties)
        {
            this.SetSystemPropertiesAsync(Properties, null);
        }

        /// <remarks/>
        public void SetSystemPropertiesAsync(Property[] Properties, object userState)
        {
            if ((this.SetSystemPropertiesOperationCompleted == null))
            {
                this.SetSystemPropertiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetSystemPropertiesOperationCompleted);
            }
            this.InvokeAsync("SetSystemProperties", new object[] {
                    Properties}, this.SetSystemPropertiesOperationCompleted, userState);
        }

        private void OnSetSystemPropertiesOperationCompleted(object arg)
        {
            if ((this.SetSystemPropertiesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetSystemPropertiesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSyste" +
            "mProperties", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Values")]
        public Property[] GetSystemProperties(Property[] Properties)
        {
            object[] results = this.Invoke("GetSystemProperties", new object[] {
                    Properties});
            return ((Property[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetSystemProperties(Property[] Properties, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetSystemProperties", new object[] {
                    Properties}, callback, asyncState);
        }

        /// <remarks/>
        public Property[] EndGetSystemProperties(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((Property[])(results[0]));
        }

        /// <remarks/>
        public void GetSystemPropertiesAsync(Property[] Properties)
        {
            this.GetSystemPropertiesAsync(Properties, null);
        }

        /// <remarks/>
        public void GetSystemPropertiesAsync(Property[] Properties, object userState)
        {
            if ((this.GetSystemPropertiesOperationCompleted == null))
            {
                this.GetSystemPropertiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSystemPropertiesOperationCompleted);
            }
            this.InvokeAsync("GetSystemProperties", new object[] {
                    Properties}, this.GetSystemPropertiesOperationCompleted, userState);
        }

        private void OnGetSystemPropertiesOperationCompleted(object arg)
        {
            if ((this.GetSystemPropertiesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSystemPropertiesCompleted(this, new GetSystemPropertiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetSyste" +
            "mPolicies", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetSystemPolicies(Policy[] Policies)
        {
            this.Invoke("SetSystemPolicies", new object[] {
                    Policies});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetSystemPolicies(Policy[] Policies, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetSystemPolicies", new object[] {
                    Policies}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetSystemPolicies(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetSystemPoliciesAsync(Policy[] Policies)
        {
            this.SetSystemPoliciesAsync(Policies, null);
        }

        /// <remarks/>
        public void SetSystemPoliciesAsync(Policy[] Policies, object userState)
        {
            if ((this.SetSystemPoliciesOperationCompleted == null))
            {
                this.SetSystemPoliciesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetSystemPoliciesOperationCompleted);
            }
            this.InvokeAsync("SetSystemPolicies", new object[] {
                    Policies}, this.SetSystemPoliciesOperationCompleted, userState);
        }

        private void OnSetSystemPoliciesOperationCompleted(object arg)
        {
            if ((this.SetSystemPoliciesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetSystemPoliciesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSyste" +
            "mPolicies", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Policies")]
        public Policy[] GetSystemPolicies()
        {
            object[] results = this.Invoke("GetSystemPolicies", new object[0]);
            return ((Policy[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetSystemPolicies(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetSystemPolicies", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public Policy[] EndGetSystemPolicies(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((Policy[])(results[0]));
        }

        /// <remarks/>
        public void GetSystemPoliciesAsync()
        {
            this.GetSystemPoliciesAsync(null);
        }

        /// <remarks/>
        public void GetSystemPoliciesAsync(object userState)
        {
            if ((this.GetSystemPoliciesOperationCompleted == null))
            {
                this.GetSystemPoliciesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSystemPoliciesOperationCompleted);
            }
            this.InvokeAsync("GetSystemPolicies", new object[0], this.GetSystemPoliciesOperationCompleted, userState);
        }

        private void OnGetSystemPoliciesOperationCompleted(object arg)
        {
            if ((this.GetSystemPoliciesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSystemPoliciesCompleted(this, new GetSystemPoliciesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListExte" +
            "nsions", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Extensions")]
        public Extension[] ListExtensions(string ExtensionType)
        {
            object[] results = this.Invoke("ListExtensions", new object[] {
                    ExtensionType});
            return ((Extension[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListExtensions(string ExtensionType, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListExtensions", new object[] {
                    ExtensionType}, callback, asyncState);
        }

        /// <remarks/>
        public Extension[] EndListExtensions(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((Extension[])(results[0]));
        }

        /// <remarks/>
        public void ListExtensionsAsync(string ExtensionType)
        {
            this.ListExtensionsAsync(ExtensionType, null);
        }

        /// <remarks/>
        public void ListExtensionsAsync(string ExtensionType, object userState)
        {
            if ((this.ListExtensionsOperationCompleted == null))
            {
                this.ListExtensionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListExtensionsOperationCompleted);
            }
            this.InvokeAsync("ListExtensions", new object[] {
                    ExtensionType}, this.ListExtensionsOperationCompleted, userState);
        }

        private void OnListExtensionsOperationCompleted(object arg)
        {
            if ((this.ListExtensionsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListExtensionsCompleted(this, new ListExtensionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListExte" +
            "nsionTypes", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] ListExtensionTypes()
        {
            object[] results = this.Invoke("ListExtensionTypes", new object[0]);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListExtensionTypes(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListExtensionTypes", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public string[] EndListExtensionTypes(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void ListExtensionTypesAsync()
        {
            this.ListExtensionTypesAsync(null);
        }

        /// <remarks/>
        public void ListExtensionTypesAsync(object userState)
        {
            if ((this.ListExtensionTypesOperationCompleted == null))
            {
                this.ListExtensionTypesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListExtensionTypesOperationCompleted);
            }
            this.InvokeAsync("ListExtensionTypes", new object[0], this.ListExtensionTypesOperationCompleted, userState);
        }

        private void OnListExtensionTypesOperationCompleted(object arg)
        {
            if ((this.ListExtensionTypesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListExtensionTypesCompleted(this, new ListExtensionTypesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListEven" +
            "ts", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Events")]
        public Event[] ListEvents()
        {
            object[] results = this.Invoke("ListEvents", new object[0]);
            return ((Event[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListEvents(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListEvents", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public Event[] EndListEvents(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((Event[])(results[0]));
        }

        /// <remarks/>
        public void ListEventsAsync()
        {
            this.ListEventsAsync(null);
        }

        /// <remarks/>
        public void ListEventsAsync(object userState)
        {
            if ((this.ListEventsOperationCompleted == null))
            {
                this.ListEventsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListEventsOperationCompleted);
            }
            this.InvokeAsync("ListEvents", new object[0], this.ListEventsOperationCompleted, userState);
        }

        private void OnListEventsOperationCompleted(object arg)
        {
            if ((this.ListEventsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListEventsCompleted(this, new ListEventsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/FireEven" +
            "t", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void FireEvent(string EventType, string EventData, string SiteUrl)
        {
            this.Invoke("FireEvent", new object[] {
                    EventType,
                    EventData,
                    SiteUrl});
        }

        /// <remarks/>
        public System.IAsyncResult BeginFireEvent(string EventType, string EventData, string SiteUrl, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("FireEvent", new object[] {
                    EventType,
                    EventData,
                    SiteUrl}, callback, asyncState);
        }

        /// <remarks/>
        public void EndFireEvent(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void FireEventAsync(string EventType, string EventData, string SiteUrl)
        {
            this.FireEventAsync(EventType, EventData, SiteUrl, null);
        }

        /// <remarks/>
        public void FireEventAsync(string EventType, string EventData, string SiteUrl, object userState)
        {
            if ((this.FireEventOperationCompleted == null))
            {
                this.FireEventOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFireEventOperationCompleted);
            }
            this.InvokeAsync("FireEvent", new object[] {
                    EventType,
                    EventData,
                    SiteUrl}, this.FireEventOperationCompleted, userState);
        }

        private void OnFireEventOperationCompleted(object arg)
        {
            if ((this.FireEventCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FireEventCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListJobs" +
            "", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Jobs")]
        public Job[] ListJobs()
        {
            object[] results = this.Invoke("ListJobs", new object[0]);
            return ((Job[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListJobs(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListJobs", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public Job[] EndListJobs(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((Job[])(results[0]));
        }

        /// <remarks/>
        public void ListJobsAsync()
        {
            this.ListJobsAsync(null);
        }

        /// <remarks/>
        public void ListJobsAsync(object userState)
        {
            if ((this.ListJobsOperationCompleted == null))
            {
                this.ListJobsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListJobsOperationCompleted);
            }
            this.InvokeAsync("ListJobs", new object[0], this.ListJobsOperationCompleted, userState);
        }

        private void OnListJobsOperationCompleted(object arg)
        {
            if ((this.ListJobsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListJobsCompleted(this, new ListJobsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListJobT" +
            "ypes", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] ListJobTypes()
        {
            object[] results = this.Invoke("ListJobTypes", new object[0]);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListJobTypes(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListJobTypes", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public string[] EndListJobTypes(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void ListJobTypesAsync()
        {
            this.ListJobTypesAsync(null);
        }

        /// <remarks/>
        public void ListJobTypesAsync(object userState)
        {
            if ((this.ListJobTypesOperationCompleted == null))
            {
                this.ListJobTypesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListJobTypesOperationCompleted);
            }
            this.InvokeAsync("ListJobTypes", new object[0], this.ListJobTypesOperationCompleted, userState);
        }

        private void OnListJobTypesOperationCompleted(object arg)
        {
            if ((this.ListJobTypesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListJobTypesCompleted(this, new ListJobTypesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListJobA" +
            "ctions", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] ListJobActions()
        {
            object[] results = this.Invoke("ListJobActions", new object[0]);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListJobActions(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListJobActions", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public string[] EndListJobActions(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void ListJobActionsAsync()
        {
            this.ListJobActionsAsync(null);
        }

        /// <remarks/>
        public void ListJobActionsAsync(object userState)
        {
            if ((this.ListJobActionsOperationCompleted == null))
            {
                this.ListJobActionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListJobActionsOperationCompleted);
            }
            this.InvokeAsync("ListJobActions", new object[0], this.ListJobActionsOperationCompleted, userState);
        }

        private void OnListJobActionsOperationCompleted(object arg)
        {
            if ((this.ListJobActionsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListJobActionsCompleted(this, new ListJobActionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListJobS" +
            "tates", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] ListJobStates()
        {
            object[] results = this.Invoke("ListJobStates", new object[0]);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListJobStates(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListJobStates", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public string[] EndListJobStates(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void ListJobStatesAsync()
        {
            this.ListJobStatesAsync(null);
        }

        /// <remarks/>
        public void ListJobStatesAsync(object userState)
        {
            if ((this.ListJobStatesOperationCompleted == null))
            {
                this.ListJobStatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListJobStatesOperationCompleted);
            }
            this.InvokeAsync("ListJobStates", new object[0], this.ListJobStatesOperationCompleted, userState);
        }

        private void OnListJobStatesOperationCompleted(object arg)
        {
            if ((this.ListJobStatesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListJobStatesCompleted(this, new ListJobStatesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CancelJo" +
            "b", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CancelJob(string JobID)
        {
            object[] results = this.Invoke("CancelJob", new object[] {
                    JobID});
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginCancelJob(string JobID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("CancelJob", new object[] {
                    JobID}, callback, asyncState);
        }

        /// <remarks/>
        public bool EndCancelJob(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public void CancelJobAsync(string JobID)
        {
            this.CancelJobAsync(JobID, null);
        }

        /// <remarks/>
        public void CancelJobAsync(string JobID, object userState)
        {
            if ((this.CancelJobOperationCompleted == null))
            {
                this.CancelJobOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCancelJobOperationCompleted);
            }
            this.InvokeAsync("CancelJob", new object[] {
                    JobID}, this.CancelJobOperationCompleted, userState);
        }

        private void OnCancelJobOperationCompleted(object arg)
        {
            if ((this.CancelJobCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CancelJobCompleted(this, new CancelJobCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateCa" +
            "cheRefreshPlan", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("CacheRefreshPlanID")]
        public string CreateCacheRefreshPlan(string ItemPath, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
        {
            object[] results = this.Invoke("CreateCacheRefreshPlan", new object[] {
                    ItemPath,
                    Description,
                    EventType,
                    MatchData,
                    Parameters});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginCreateCacheRefreshPlan(string ItemPath, string Description, string EventType, string MatchData, ParameterValue[] Parameters, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("CreateCacheRefreshPlan", new object[] {
                    ItemPath,
                    Description,
                    EventType,
                    MatchData,
                    Parameters}, callback, asyncState);
        }

        /// <remarks/>
        public string EndCreateCacheRefreshPlan(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void CreateCacheRefreshPlanAsync(string ItemPath, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
        {
            this.CreateCacheRefreshPlanAsync(ItemPath, Description, EventType, MatchData, Parameters, null);
        }

        /// <remarks/>
        public void CreateCacheRefreshPlanAsync(string ItemPath, string Description, string EventType, string MatchData, ParameterValue[] Parameters, object userState)
        {
            if ((this.CreateCacheRefreshPlanOperationCompleted == null))
            {
                this.CreateCacheRefreshPlanOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateCacheRefreshPlanOperationCompleted);
            }
            this.InvokeAsync("CreateCacheRefreshPlan", new object[] {
                    ItemPath,
                    Description,
                    EventType,
                    MatchData,
                    Parameters}, this.CreateCacheRefreshPlanOperationCompleted, userState);
        }

        private void OnCreateCacheRefreshPlanOperationCompleted(object arg)
        {
            if ((this.CreateCacheRefreshPlanCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateCacheRefreshPlanCompleted(this, new CreateCacheRefreshPlanCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetCache" +
            "RefreshPlanProperties", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetCacheRefreshPlanProperties(string CacheRefreshPlanID, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
        {
            this.Invoke("SetCacheRefreshPlanProperties", new object[] {
                    CacheRefreshPlanID,
                    Description,
                    EventType,
                    MatchData,
                    Parameters});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetCacheRefreshPlanProperties(string CacheRefreshPlanID, string Description, string EventType, string MatchData, ParameterValue[] Parameters, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetCacheRefreshPlanProperties", new object[] {
                    CacheRefreshPlanID,
                    Description,
                    EventType,
                    MatchData,
                    Parameters}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetCacheRefreshPlanProperties(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetCacheRefreshPlanPropertiesAsync(string CacheRefreshPlanID, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
        {
            this.SetCacheRefreshPlanPropertiesAsync(CacheRefreshPlanID, Description, EventType, MatchData, Parameters, null);
        }

        /// <remarks/>
        public void SetCacheRefreshPlanPropertiesAsync(string CacheRefreshPlanID, string Description, string EventType, string MatchData, ParameterValue[] Parameters, object userState)
        {
            if ((this.SetCacheRefreshPlanPropertiesOperationCompleted == null))
            {
                this.SetCacheRefreshPlanPropertiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetCacheRefreshPlanPropertiesOperationCompleted);
            }
            this.InvokeAsync("SetCacheRefreshPlanProperties", new object[] {
                    CacheRefreshPlanID,
                    Description,
                    EventType,
                    MatchData,
                    Parameters}, this.SetCacheRefreshPlanPropertiesOperationCompleted, userState);
        }

        private void OnSetCacheRefreshPlanPropertiesOperationCompleted(object arg)
        {
            if ((this.SetCacheRefreshPlanPropertiesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetCacheRefreshPlanPropertiesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetCache" +
            "RefreshPlanProperties", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Description")]
        public string GetCacheRefreshPlanProperties(string CacheRefreshPlanID, out string LastRunStatus, out CacheRefreshPlanState State, out string EventType, out string MatchData, out ParameterValue[] Parameters)
        {
            object[] results = this.Invoke("GetCacheRefreshPlanProperties", new object[] {
                    CacheRefreshPlanID});
            LastRunStatus = ((string)(results[1]));
            State = ((CacheRefreshPlanState)(results[2]));
            EventType = ((string)(results[3]));
            MatchData = ((string)(results[4]));
            Parameters = ((ParameterValue[])(results[5]));
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetCacheRefreshPlanProperties(string CacheRefreshPlanID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetCacheRefreshPlanProperties", new object[] {
                    CacheRefreshPlanID}, callback, asyncState);
        }

        /// <remarks/>
        public string EndGetCacheRefreshPlanProperties(System.IAsyncResult asyncResult, out string LastRunStatus, out CacheRefreshPlanState State, out string EventType, out string MatchData, out ParameterValue[] Parameters)
        {
            object[] results = this.EndInvoke(asyncResult);
            LastRunStatus = ((string)(results[1]));
            State = ((CacheRefreshPlanState)(results[2]));
            EventType = ((string)(results[3]));
            MatchData = ((string)(results[4]));
            Parameters = ((ParameterValue[])(results[5]));
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void GetCacheRefreshPlanPropertiesAsync(string CacheRefreshPlanID)
        {
            this.GetCacheRefreshPlanPropertiesAsync(CacheRefreshPlanID, null);
        }

        /// <remarks/>
        public void GetCacheRefreshPlanPropertiesAsync(string CacheRefreshPlanID, object userState)
        {
            if ((this.GetCacheRefreshPlanPropertiesOperationCompleted == null))
            {
                this.GetCacheRefreshPlanPropertiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCacheRefreshPlanPropertiesOperationCompleted);
            }
            this.InvokeAsync("GetCacheRefreshPlanProperties", new object[] {
                    CacheRefreshPlanID}, this.GetCacheRefreshPlanPropertiesOperationCompleted, userState);
        }

        private void OnGetCacheRefreshPlanPropertiesOperationCompleted(object arg)
        {
            if ((this.GetCacheRefreshPlanPropertiesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCacheRefreshPlanPropertiesCompleted(this, new GetCacheRefreshPlanPropertiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteCa" +
            "cheRefreshPlan", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteCacheRefreshPlan(string CacheRefreshPlanID)
        {
            this.Invoke("DeleteCacheRefreshPlan", new object[] {
                    CacheRefreshPlanID});
        }

        /// <remarks/>
        public System.IAsyncResult BeginDeleteCacheRefreshPlan(string CacheRefreshPlanID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("DeleteCacheRefreshPlan", new object[] {
                    CacheRefreshPlanID}, callback, asyncState);
        }

        /// <remarks/>
        public void EndDeleteCacheRefreshPlan(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void DeleteCacheRefreshPlanAsync(string CacheRefreshPlanID)
        {
            this.DeleteCacheRefreshPlanAsync(CacheRefreshPlanID, null);
        }

        /// <remarks/>
        public void DeleteCacheRefreshPlanAsync(string CacheRefreshPlanID, object userState)
        {
            if ((this.DeleteCacheRefreshPlanOperationCompleted == null))
            {
                this.DeleteCacheRefreshPlanOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteCacheRefreshPlanOperationCompleted);
            }
            this.InvokeAsync("DeleteCacheRefreshPlan", new object[] {
                    CacheRefreshPlanID}, this.DeleteCacheRefreshPlanOperationCompleted, userState);
        }

        private void OnDeleteCacheRefreshPlanOperationCompleted(object arg)
        {
            if ((this.DeleteCacheRefreshPlanCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteCacheRefreshPlanCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListCach" +
            "eRefreshPlans", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("CacheRefreshPlans")]
        public CacheRefreshPlan[] ListCacheRefreshPlans(string ItemPath)
        {
            object[] results = this.Invoke("ListCacheRefreshPlans", new object[] {
                    ItemPath});
            return ((CacheRefreshPlan[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListCacheRefreshPlans(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListCacheRefreshPlans", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public CacheRefreshPlan[] EndListCacheRefreshPlans(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((CacheRefreshPlan[])(results[0]));
        }

        /// <remarks/>
        public void ListCacheRefreshPlansAsync(string ItemPath)
        {
            this.ListCacheRefreshPlansAsync(ItemPath, null);
        }

        /// <remarks/>
        public void ListCacheRefreshPlansAsync(string ItemPath, object userState)
        {
            if ((this.ListCacheRefreshPlansOperationCompleted == null))
            {
                this.ListCacheRefreshPlansOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListCacheRefreshPlansOperationCompleted);
            }
            this.InvokeAsync("ListCacheRefreshPlans", new object[] {
                    ItemPath}, this.ListCacheRefreshPlansOperationCompleted, userState);
        }

        private void OnListCacheRefreshPlansOperationCompleted(object arg)
        {
            if ((this.ListCacheRefreshPlansCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListCacheRefreshPlansCompleted(this, new ListCacheRefreshPlansCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/LogonUse" +
            "r", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void LogonUser(string userName, string password, string authority)
        {
            this.Invoke("LogonUser", new object[] {
                    userName,
                    password,
                    authority});
        }

        /// <remarks/>
        public System.IAsyncResult BeginLogonUser(string userName, string password, string authority, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("LogonUser", new object[] {
                    userName,
                    password,
                    authority}, callback, asyncState);
        }

        /// <remarks/>
        public void EndLogonUser(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void LogonUserAsync(string userName, string password, string authority)
        {
            this.LogonUserAsync(userName, password, authority, null);
        }

        /// <remarks/>
        public void LogonUserAsync(string userName, string password, string authority, object userState)
        {
            if ((this.LogonUserOperationCompleted == null))
            {
                this.LogonUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLogonUserOperationCompleted);
            }
            this.InvokeAsync("LogonUser", new object[] {
                    userName,
                    password,
                    authority}, this.LogonUserOperationCompleted, userState);
        }

        private void OnLogonUserOperationCompleted(object arg)
        {
            if ((this.LogonUserCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LogonUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/Logoff", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Logoff()
        {
            this.Invoke("Logoff", new object[0]);
        }

        /// <remarks/>
        public System.IAsyncResult BeginLogoff(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("Logoff", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public void EndLogoff(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void LogoffAsync()
        {
            this.LogoffAsync(null);
        }

        /// <remarks/>
        public void LogoffAsync(object userState)
        {
            if ((this.LogoffOperationCompleted == null))
            {
                this.LogoffOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLogoffOperationCompleted);
            }
            this.InvokeAsync("Logoff", new object[0], this.LogoffOperationCompleted, userState);
        }

        private void OnLogoffOperationCompleted(object arg)
        {
            if ((this.LogoffCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LogoffCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetPermi" +
            "ssions", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Permissions")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("Operation")]
        public string[] GetPermissions(string ItemPath)
        {
            object[] results = this.Invoke("GetPermissions", new object[] {
                    ItemPath});
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetPermissions(string ItemPath, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetPermissions", new object[] {
                    ItemPath}, callback, asyncState);
        }

        /// <remarks/>
        public string[] EndGetPermissions(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void GetPermissionsAsync(string ItemPath)
        {
            this.GetPermissionsAsync(ItemPath, null);
        }

        /// <remarks/>
        public void GetPermissionsAsync(string ItemPath, object userState)
        {
            if ((this.GetPermissionsOperationCompleted == null))
            {
                this.GetPermissionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPermissionsOperationCompleted);
            }
            this.InvokeAsync("GetPermissions", new object[] {
                    ItemPath}, this.GetPermissionsOperationCompleted, userState);
        }

        private void OnGetPermissionsOperationCompleted(object arg)
        {
            if ((this.GetPermissionsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPermissionsCompleted(this, new GetPermissionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSyste" +
            "mPermissions", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Permissions")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("Operation")]
        public string[] GetSystemPermissions()
        {
            object[] results = this.Invoke("GetSystemPermissions", new object[0]);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetSystemPermissions(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetSystemPermissions", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public string[] EndGetSystemPermissions(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void GetSystemPermissionsAsync()
        {
            this.GetSystemPermissionsAsync(null);
        }

        /// <remarks/>
        public void GetSystemPermissionsAsync(object userState)
        {
            if ((this.GetSystemPermissionsOperationCompleted == null))
            {
                this.GetSystemPermissionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSystemPermissionsOperationCompleted);
            }
            this.InvokeAsync("GetSystemPermissions", new object[0], this.GetSystemPermissionsOperationCompleted, userState);
        }

        private void OnGetSystemPermissionsOperationCompleted(object arg)
        {
            if ((this.GetSystemPermissionsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSystemPermissionsCompleted(this, new GetSystemPermissionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSecu" +
            "rityScopes", RequestNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] ListSecurityScopes()
        {
            object[] results = this.Invoke("ListSecurityScopes", new object[0]);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListSecurityScopes(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListSecurityScopes", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public string[] EndListSecurityScopes(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void ListSecurityScopesAsync()
        {
            this.ListSecurityScopesAsync(null);
        }

        /// <remarks/>
        public void ListSecurityScopesAsync(object userState)
        {
            if ((this.ListSecurityScopesOperationCompleted == null))
            {
                this.ListSecurityScopesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListSecurityScopesOperationCompleted);
            }
            this.InvokeAsync("ListSecurityScopes", new object[0], this.ListSecurityScopesOperationCompleted, userState);
        }

        private void OnListSecurityScopesOperationCompleted(object arg)
        {
            if ((this.ListSecurityScopesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListSecurityScopesCompleted(this, new ListSecurityScopesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsNullable = false)]
    public partial class ItemNamespaceHeader : System.Web.Services.Protocols.SoapHeader
    {

        private ItemNamespaceEnum itemNamespaceField;

        private System.Xml.XmlAttribute[] anyAttrField;

        /// <remarks/>
        public ItemNamespaceEnum ItemNamespace
        {
            get
            {
                return this.itemNamespaceField;
            }
            set
            {
                this.itemNamespaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public enum ItemNamespaceEnum
    {

        /// <remarks/>
        PathBased,

        /// <remarks/>
        GUIDBased,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class CacheRefreshPlan
    {

        private string cacheRefreshPlanIDField;

        private string itemPathField;

        private string descriptionField;

        private CacheRefreshPlanState stateField;

        private System.DateTime lastExecutedField;

        private System.DateTime modifiedDateField;

        private string modifiedByField;

        private string lastRunStatusField;

        /// <remarks/>
        public string CacheRefreshPlanID
        {
            get
            {
                return this.cacheRefreshPlanIDField;
            }
            set
            {
                this.cacheRefreshPlanIDField = value;
            }
        }

        /// <remarks/>
        public string ItemPath
        {
            get
            {
                return this.itemPathField;
            }
            set
            {
                this.itemPathField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public CacheRefreshPlanState State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public System.DateTime LastExecuted
        {
            get
            {
                return this.lastExecutedField;
            }
            set
            {
                this.lastExecutedField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ModifiedDate
        {
            get
            {
                return this.modifiedDateField;
            }
            set
            {
                this.modifiedDateField = value;
            }
        }

        /// <remarks/>
        public string ModifiedBy
        {
            get
            {
                return this.modifiedByField;
            }
            set
            {
                this.modifiedByField = value;
            }
        }

        /// <remarks/>
        public string LastRunStatus
        {
            get
            {
                return this.lastRunStatusField;
            }
            set
            {
                this.lastRunStatusField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class CacheRefreshPlanState
    {

        private bool missingParameterValueField;

        private bool invalidParameterValueField;

        private bool unknownItemParameterField;

        private bool cachingNotEnabledOnItemField;

        /// <remarks/>
        public bool MissingParameterValue
        {
            get
            {
                return this.missingParameterValueField;
            }
            set
            {
                this.missingParameterValueField = value;
            }
        }

        /// <remarks/>
        public bool InvalidParameterValue
        {
            get
            {
                return this.invalidParameterValueField;
            }
            set
            {
                this.invalidParameterValueField = value;
            }
        }

        /// <remarks/>
        public bool UnknownItemParameter
        {
            get
            {
                return this.unknownItemParameterField;
            }
            set
            {
                this.unknownItemParameterField = value;
            }
        }

        /// <remarks/>
        public bool CachingNotEnabledOnItem
        {
            get
            {
                return this.cachingNotEnabledOnItemField;
            }
            set
            {
                this.cachingNotEnabledOnItemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Job
    {

        private string jobIDField;

        private string nameField;

        private string pathField;

        private string descriptionField;

        private string machineField;

        private string userField;

        private System.DateTime startDateTimeField;

        private string jobActionNameField;

        private string jobTypeNameField;

        private string jobStatusNameField;

        /// <remarks/>
        public string JobID
        {
            get
            {
                return this.jobIDField;
            }
            set
            {
                this.jobIDField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string Machine
        {
            get
            {
                return this.machineField;
            }
            set
            {
                this.machineField = value;
            }
        }

        /// <remarks/>
        public string User
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }

        /// <remarks/>
        public System.DateTime StartDateTime
        {
            get
            {
                return this.startDateTimeField;
            }
            set
            {
                this.startDateTimeField = value;
            }
        }

        /// <remarks/>
        public string JobActionName
        {
            get
            {
                return this.jobActionNameField;
            }
            set
            {
                this.jobActionNameField = value;
            }
        }

        /// <remarks/>
        public string JobTypeName
        {
            get
            {
                return this.jobTypeNameField;
            }
            set
            {
                this.jobTypeNameField = value;
            }
        }

        /// <remarks/>
        public string JobStatusName
        {
            get
            {
                return this.jobStatusNameField;
            }
            set
            {
                this.jobStatusNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Event
    {

        private string typeField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Extension
    {

        private string extensionTypeNameField;

        private string nameField;

        private string localizedNameField;

        private bool visibleField;

        private bool isModelGenerationSupportedField;

        /// <remarks/>
        public string ExtensionTypeName
        {
            get
            {
                return this.extensionTypeNameField;
            }
            set
            {
                this.extensionTypeNameField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string LocalizedName
        {
            get
            {
                return this.localizedNameField;
            }
            set
            {
                this.localizedNameField = value;
            }
        }

        /// <remarks/>
        public bool Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }

        /// <remarks/>
        public bool IsModelGenerationSupported
        {
            get
            {
                return this.isModelGenerationSupportedField;
            }
            set
            {
                this.isModelGenerationSupportedField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScheduleExpiration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeExpiration))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ExpirationDefinition
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ScheduleExpiration : ExpirationDefinition
    {

        private ScheduleDefinitionOrReference itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScheduleDefinition", typeof(ScheduleDefinition))]
        [System.Xml.Serialization.XmlElementAttribute("ScheduleReference", typeof(ScheduleReference))]
        public ScheduleDefinitionOrReference Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ScheduleDefinition : ScheduleDefinitionOrReference
    {

        private System.DateTime startDateTimeField;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private RecurrencePattern itemField;

        /// <remarks/>
        public System.DateTime StartDateTime
        {
            get
            {
                return this.startDateTimeField;
            }
            set
            {
                this.startDateTimeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndDateSpecified
        {
            get
            {
                return this.endDateFieldSpecified;
            }
            set
            {
                this.endDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DailyRecurrence", typeof(DailyRecurrence))]
        [System.Xml.Serialization.XmlElementAttribute("MinuteRecurrence", typeof(MinuteRecurrence))]
        [System.Xml.Serialization.XmlElementAttribute("MonthlyDOWRecurrence", typeof(MonthlyDOWRecurrence))]
        [System.Xml.Serialization.XmlElementAttribute("MonthlyRecurrence", typeof(MonthlyRecurrence))]
        [System.Xml.Serialization.XmlElementAttribute("WeeklyRecurrence", typeof(WeeklyRecurrence))]
        public RecurrencePattern Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DailyRecurrence : RecurrencePattern
    {

        private int daysIntervalField;

        /// <remarks/>
        public int DaysInterval
        {
            get
            {
                return this.daysIntervalField;
            }
            set
            {
                this.daysIntervalField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MinuteRecurrence))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DailyRecurrence))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeeklyRecurrence))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MonthlyDOWRecurrence))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MonthlyRecurrence))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class RecurrencePattern
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class MinuteRecurrence : RecurrencePattern
    {

        private int minutesIntervalField;

        /// <remarks/>
        public int MinutesInterval
        {
            get
            {
                return this.minutesIntervalField;
            }
            set
            {
                this.minutesIntervalField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class WeeklyRecurrence : RecurrencePattern
    {

        private int weeksIntervalField;

        private bool weeksIntervalFieldSpecified;

        private DaysOfWeekSelector daysOfWeekField;

        /// <remarks/>
        public int WeeksInterval
        {
            get
            {
                return this.weeksIntervalField;
            }
            set
            {
                this.weeksIntervalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WeeksIntervalSpecified
        {
            get
            {
                return this.weeksIntervalFieldSpecified;
            }
            set
            {
                this.weeksIntervalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DaysOfWeekSelector DaysOfWeek
        {
            get
            {
                return this.daysOfWeekField;
            }
            set
            {
                this.daysOfWeekField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DaysOfWeekSelector
    {

        private bool sundayField;

        private bool mondayField;

        private bool tuesdayField;

        private bool wednesdayField;

        private bool thursdayField;

        private bool fridayField;

        private bool saturdayField;

        /// <remarks/>
        public bool Sunday
        {
            get
            {
                return this.sundayField;
            }
            set
            {
                this.sundayField = value;
            }
        }

        /// <remarks/>
        public bool Monday
        {
            get
            {
                return this.mondayField;
            }
            set
            {
                this.mondayField = value;
            }
        }

        /// <remarks/>
        public bool Tuesday
        {
            get
            {
                return this.tuesdayField;
            }
            set
            {
                this.tuesdayField = value;
            }
        }

        /// <remarks/>
        public bool Wednesday
        {
            get
            {
                return this.wednesdayField;
            }
            set
            {
                this.wednesdayField = value;
            }
        }

        /// <remarks/>
        public bool Thursday
        {
            get
            {
                return this.thursdayField;
            }
            set
            {
                this.thursdayField = value;
            }
        }

        /// <remarks/>
        public bool Friday
        {
            get
            {
                return this.fridayField;
            }
            set
            {
                this.fridayField = value;
            }
        }

        /// <remarks/>
        public bool Saturday
        {
            get
            {
                return this.saturdayField;
            }
            set
            {
                this.saturdayField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class MonthlyDOWRecurrence : RecurrencePattern
    {

        private WeekNumberEnum whichWeekField;

        private bool whichWeekFieldSpecified;

        private DaysOfWeekSelector daysOfWeekField;

        private MonthsOfYearSelector monthsOfYearField;

        /// <remarks/>
        public WeekNumberEnum WhichWeek
        {
            get
            {
                return this.whichWeekField;
            }
            set
            {
                this.whichWeekField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WhichWeekSpecified
        {
            get
            {
                return this.whichWeekFieldSpecified;
            }
            set
            {
                this.whichWeekFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DaysOfWeekSelector DaysOfWeek
        {
            get
            {
                return this.daysOfWeekField;
            }
            set
            {
                this.daysOfWeekField = value;
            }
        }

        /// <remarks/>
        public MonthsOfYearSelector MonthsOfYear
        {
            get
            {
                return this.monthsOfYearField;
            }
            set
            {
                this.monthsOfYearField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public enum WeekNumberEnum
    {

        /// <remarks/>
        FirstWeek,

        /// <remarks/>
        SecondWeek,

        /// <remarks/>
        ThirdWeek,

        /// <remarks/>
        FourthWeek,

        /// <remarks/>
        LastWeek,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class MonthsOfYearSelector
    {

        private bool januaryField;

        private bool februaryField;

        private bool marchField;

        private bool aprilField;

        private bool mayField;

        private bool juneField;

        private bool julyField;

        private bool augustField;

        private bool septemberField;

        private bool octoberField;

        private bool novemberField;

        private bool decemberField;

        /// <remarks/>
        public bool January
        {
            get
            {
                return this.januaryField;
            }
            set
            {
                this.januaryField = value;
            }
        }

        /// <remarks/>
        public bool February
        {
            get
            {
                return this.februaryField;
            }
            set
            {
                this.februaryField = value;
            }
        }

        /// <remarks/>
        public bool March
        {
            get
            {
                return this.marchField;
            }
            set
            {
                this.marchField = value;
            }
        }

        /// <remarks/>
        public bool April
        {
            get
            {
                return this.aprilField;
            }
            set
            {
                this.aprilField = value;
            }
        }

        /// <remarks/>
        public bool May
        {
            get
            {
                return this.mayField;
            }
            set
            {
                this.mayField = value;
            }
        }

        /// <remarks/>
        public bool June
        {
            get
            {
                return this.juneField;
            }
            set
            {
                this.juneField = value;
            }
        }

        /// <remarks/>
        public bool July
        {
            get
            {
                return this.julyField;
            }
            set
            {
                this.julyField = value;
            }
        }

        /// <remarks/>
        public bool August
        {
            get
            {
                return this.augustField;
            }
            set
            {
                this.augustField = value;
            }
        }

        /// <remarks/>
        public bool September
        {
            get
            {
                return this.septemberField;
            }
            set
            {
                this.septemberField = value;
            }
        }

        /// <remarks/>
        public bool October
        {
            get
            {
                return this.octoberField;
            }
            set
            {
                this.octoberField = value;
            }
        }

        /// <remarks/>
        public bool November
        {
            get
            {
                return this.novemberField;
            }
            set
            {
                this.novemberField = value;
            }
        }

        /// <remarks/>
        public bool December
        {
            get
            {
                return this.decemberField;
            }
            set
            {
                this.decemberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class MonthlyRecurrence : RecurrencePattern
    {

        private string daysField;

        private MonthsOfYearSelector monthsOfYearField;

        /// <remarks/>
        public string Days
        {
            get
            {
                return this.daysField;
            }
            set
            {
                this.daysField = value;
            }
        }

        /// <remarks/>
        public MonthsOfYearSelector MonthsOfYear
        {
            get
            {
                return this.monthsOfYearField;
            }
            set
            {
                this.monthsOfYearField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScheduleReference))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NoSchedule))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScheduleDefinition))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ScheduleDefinitionOrReference
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ScheduleReference : ScheduleDefinitionOrReference
    {

        private string scheduleIDField;

        private ScheduleDefinition definitionField;

        /// <remarks/>
        public string ScheduleID
        {
            get
            {
                return this.scheduleIDField;
            }
            set
            {
                this.scheduleIDField = value;
            }
        }

        /// <remarks/>
        public ScheduleDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class NoSchedule : ScheduleDefinitionOrReference
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class TimeExpiration : ExpirationDefinition
    {

        private int minutesField;

        /// <remarks/>
        public int Minutes
        {
            get
            {
                return this.minutesField;
            }
            set
            {
                this.minutesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DataSourceCredentials
    {

        private string dataSourceNameField;

        private string userNameField;

        private string passwordField;

        /// <remarks/>
        public string DataSourceName
        {
            get
            {
                return this.dataSourceNameField;
            }
            set
            {
                this.dataSourceNameField = value;
            }
        }

        /// <remarks/>
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        /// <remarks/>
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ItemParameter
    {

        private string nameField;

        private string parameterTypeNameField;

        private bool nullableField;

        private bool nullableFieldSpecified;

        private bool allowBlankField;

        private bool allowBlankFieldSpecified;

        private bool multiValueField;

        private bool multiValueFieldSpecified;

        private bool queryParameterField;

        private bool queryParameterFieldSpecified;

        private string promptField;

        private bool promptUserField;

        private bool promptUserFieldSpecified;

        private string[] dependenciesField;

        private bool validValuesQueryBasedField;

        private bool validValuesQueryBasedFieldSpecified;

        private ValidValue[] validValuesField;

        private bool defaultValuesQueryBasedField;

        private bool defaultValuesQueryBasedFieldSpecified;

        private string[] defaultValuesField;

        private string parameterStateNameField;

        private string errorMessageField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string ParameterTypeName
        {
            get
            {
                return this.parameterTypeNameField;
            }
            set
            {
                this.parameterTypeNameField = value;
            }
        }

        /// <remarks/>
        public bool Nullable
        {
            get
            {
                return this.nullableField;
            }
            set
            {
                this.nullableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NullableSpecified
        {
            get
            {
                return this.nullableFieldSpecified;
            }
            set
            {
                this.nullableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool AllowBlank
        {
            get
            {
                return this.allowBlankField;
            }
            set
            {
                this.allowBlankField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllowBlankSpecified
        {
            get
            {
                return this.allowBlankFieldSpecified;
            }
            set
            {
                this.allowBlankFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool MultiValue
        {
            get
            {
                return this.multiValueField;
            }
            set
            {
                this.multiValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MultiValueSpecified
        {
            get
            {
                return this.multiValueFieldSpecified;
            }
            set
            {
                this.multiValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool QueryParameter
        {
            get
            {
                return this.queryParameterField;
            }
            set
            {
                this.queryParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QueryParameterSpecified
        {
            get
            {
                return this.queryParameterFieldSpecified;
            }
            set
            {
                this.queryParameterFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Prompt
        {
            get
            {
                return this.promptField;
            }
            set
            {
                this.promptField = value;
            }
        }

        /// <remarks/>
        public bool PromptUser
        {
            get
            {
                return this.promptUserField;
            }
            set
            {
                this.promptUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PromptUserSpecified
        {
            get
            {
                return this.promptUserFieldSpecified;
            }
            set
            {
                this.promptUserFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Dependency")]
        public string[] Dependencies
        {
            get
            {
                return this.dependenciesField;
            }
            set
            {
                this.dependenciesField = value;
            }
        }

        /// <remarks/>
        public bool ValidValuesQueryBased
        {
            get
            {
                return this.validValuesQueryBasedField;
            }
            set
            {
                this.validValuesQueryBasedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidValuesQueryBasedSpecified
        {
            get
            {
                return this.validValuesQueryBasedFieldSpecified;
            }
            set
            {
                this.validValuesQueryBasedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ValidValue[] ValidValues
        {
            get
            {
                return this.validValuesField;
            }
            set
            {
                this.validValuesField = value;
            }
        }

        /// <remarks/>
        public bool DefaultValuesQueryBased
        {
            get
            {
                return this.defaultValuesQueryBasedField;
            }
            set
            {
                this.defaultValuesQueryBasedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DefaultValuesQueryBasedSpecified
        {
            get
            {
                return this.defaultValuesQueryBasedFieldSpecified;
            }
            set
            {
                this.defaultValuesQueryBasedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Value")]
        public string[] DefaultValues
        {
            get
            {
                return this.defaultValuesField;
            }
            set
            {
                this.defaultValuesField = value;
            }
        }

        /// <remarks/>
        public string ParameterStateName
        {
            get
            {
                return this.parameterStateNameField;
            }
            set
            {
                this.parameterStateNameField = value;
            }
        }

        /// <remarks/>
        public string ErrorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ValidValue
    {

        private string labelField;

        private string valueField;

        /// <remarks/>
        public string Label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }

        /// <remarks/>
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Schedule
    {

        private string scheduleIDField;

        private string nameField;

        private ScheduleDefinition definitionField;

        private string descriptionField;

        private string creatorField;

        private System.DateTime nextRunTimeField;

        private bool nextRunTimeFieldSpecified;

        private System.DateTime lastRunTimeField;

        private bool lastRunTimeFieldSpecified;

        private bool referencesPresentField;

        private string scheduleStateNameField;

        /// <remarks/>
        public string ScheduleID
        {
            get
            {
                return this.scheduleIDField;
            }
            set
            {
                this.scheduleIDField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ScheduleDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string Creator
        {
            get
            {
                return this.creatorField;
            }
            set
            {
                this.creatorField = value;
            }
        }

        /// <remarks/>
        public System.DateTime NextRunTime
        {
            get
            {
                return this.nextRunTimeField;
            }
            set
            {
                this.nextRunTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NextRunTimeSpecified
        {
            get
            {
                return this.nextRunTimeFieldSpecified;
            }
            set
            {
                this.nextRunTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime LastRunTime
        {
            get
            {
                return this.lastRunTimeField;
            }
            set
            {
                this.lastRunTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastRunTimeSpecified
        {
            get
            {
                return this.lastRunTimeFieldSpecified;
            }
            set
            {
                this.lastRunTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool ReferencesPresent
        {
            get
            {
                return this.referencesPresentField;
            }
            set
            {
                this.referencesPresentField = value;
            }
        }

        /// <remarks/>
        public string ScheduleStateName
        {
            get
            {
                return this.scheduleStateNameField;
            }
            set
            {
                this.scheduleStateNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ModelPerspective
    {

        private string idField;

        private string nameField;

        private string descriptionField;

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ModelCatalogItem
    {

        private string modelField;

        private string descriptionField;

        private ModelPerspective[] perspectivesField;

        /// <remarks/>
        public string Model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public ModelPerspective[] Perspectives
        {
            get
            {
                return this.perspectivesField;
            }
            set
            {
                this.perspectivesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ModelItem
    {

        private string idField;

        private string nameField;

        private string modelItemTypeNameField;

        private string descriptionField;

        private ModelItem[] modelItemsField;

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string ModelItemTypeName
        {
            get
            {
                return this.modelItemTypeNameField;
            }
            set
            {
                this.modelItemTypeNameField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public ModelItem[] ModelItems
        {
            get
            {
                return this.modelItemsField;
            }
            set
            {
                this.modelItemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ModelDrillthroughReport
    {

        private string pathField;

        private DrillthroughType typeField;

        /// <remarks/>
        public string Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        public DrillthroughType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public enum DrillthroughType
    {

        /// <remarks/>
        Detail,

        /// <remarks/>
        List,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DataSourcePrompt
    {

        private string nameField;

        private string dataSourceIDField;

        private string promptField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string DataSourceID
        {
            get
            {
                return this.dataSourceIDField;
            }
            set
            {
                this.dataSourceIDField = value;
            }
        }

        /// <remarks/>
        public string Prompt
        {
            get
            {
                return this.promptField;
            }
            set
            {
                this.promptField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Policy
    {

        private string groupUserNameField;

        private Role[] rolesField;

        /// <remarks/>
        public string GroupUserName
        {
            get
            {
                return this.groupUserNameField;
            }
            set
            {
                this.groupUserNameField = value;
            }
        }

        /// <remarks/>
        public Role[] Roles
        {
            get
            {
                return this.rolesField;
            }
            set
            {
                this.rolesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Role
    {

        private string nameField;

        private string descriptionField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Task
    {

        private string taskIDField;

        private string nameField;

        private string descriptionField;

        /// <remarks/>
        public string TaskID
        {
            get
            {
                return this.taskIDField;
            }
            set
            {
                this.taskIDField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DataSource
    {

        private string nameField;

        private DataSourceDefinitionOrReference itemField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataSourceDefinition", typeof(DataSourceDefinition))]
        [System.Xml.Serialization.XmlElementAttribute("DataSourceReference", typeof(DataSourceReference))]
        [System.Xml.Serialization.XmlElementAttribute("InvalidDataSourceReference", typeof(InvalidDataSourceReference))]
        public DataSourceDefinitionOrReference Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DataSourceDefinition : DataSourceDefinitionOrReference
    {

        private string extensionField;

        private string connectStringField;

        private bool useOriginalConnectStringField;

        private bool originalConnectStringExpressionBasedField;

        private CredentialRetrievalEnum credentialRetrievalField;

        private bool windowsCredentialsField;

        private bool impersonateUserField;

        private bool impersonateUserFieldSpecified;

        private string promptField;

        private string userNameField;

        private string passwordField;

        private bool enabledField;

        private bool enabledFieldSpecified;

        /// <remarks/>
        public string Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }

        /// <remarks/>
        public string ConnectString
        {
            get
            {
                return this.connectStringField;
            }
            set
            {
                this.connectStringField = value;
            }
        }

        /// <remarks/>
        public bool UseOriginalConnectString
        {
            get
            {
                return this.useOriginalConnectStringField;
            }
            set
            {
                this.useOriginalConnectStringField = value;
            }
        }

        /// <remarks/>
        public bool OriginalConnectStringExpressionBased
        {
            get
            {
                return this.originalConnectStringExpressionBasedField;
            }
            set
            {
                this.originalConnectStringExpressionBasedField = value;
            }
        }

        /// <remarks/>
        public CredentialRetrievalEnum CredentialRetrieval
        {
            get
            {
                return this.credentialRetrievalField;
            }
            set
            {
                this.credentialRetrievalField = value;
            }
        }

        /// <remarks/>
        public bool WindowsCredentials
        {
            get
            {
                return this.windowsCredentialsField;
            }
            set
            {
                this.windowsCredentialsField = value;
            }
        }

        /// <remarks/>
        public bool ImpersonateUser
        {
            get
            {
                return this.impersonateUserField;
            }
            set
            {
                this.impersonateUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImpersonateUserSpecified
        {
            get
            {
                return this.impersonateUserFieldSpecified;
            }
            set
            {
                this.impersonateUserFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Prompt
        {
            get
            {
                return this.promptField;
            }
            set
            {
                this.promptField = value;
            }
        }

        /// <remarks/>
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        /// <remarks/>
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnabledSpecified
        {
            get
            {
                return this.enabledFieldSpecified;
            }
            set
            {
                this.enabledFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public enum CredentialRetrievalEnum
    {

        /// <remarks/>
        Prompt,

        /// <remarks/>
        Store,

        /// <remarks/>
        Integrated,

        /// <remarks/>
        None,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataSourceReference))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvalidDataSourceReference))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataSourceDefinition))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DataSourceDefinitionOrReference
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DataSourceReference : DataSourceDefinitionOrReference
    {

        private string referenceField;

        /// <remarks/>
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class InvalidDataSourceReference : DataSourceDefinitionOrReference
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Subscription
    {

        private string subscriptionIDField;

        private string ownerField;

        private string pathField;

        private string virtualPathField;

        private string reportField;

        private ExtensionSettings deliverySettingsField;

        private string descriptionField;

        private string statusField;

        private ActiveState activeField;

        private System.DateTime lastExecutedField;

        private bool lastExecutedFieldSpecified;

        private string modifiedByField;

        private System.DateTime modifiedDateField;

        private string eventTypeField;

        private bool isDataDrivenField;

        /// <remarks/>
        public string SubscriptionID
        {
            get
            {
                return this.subscriptionIDField;
            }
            set
            {
                this.subscriptionIDField = value;
            }
        }

        /// <remarks/>
        public string Owner
        {
            get
            {
                return this.ownerField;
            }
            set
            {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        public string Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        public string VirtualPath
        {
            get
            {
                return this.virtualPathField;
            }
            set
            {
                this.virtualPathField = value;
            }
        }

        /// <remarks/>
        public string Report
        {
            get
            {
                return this.reportField;
            }
            set
            {
                this.reportField = value;
            }
        }

        /// <remarks/>
        public ExtensionSettings DeliverySettings
        {
            get
            {
                return this.deliverySettingsField;
            }
            set
            {
                this.deliverySettingsField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public ActiveState Active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime LastExecuted
        {
            get
            {
                return this.lastExecutedField;
            }
            set
            {
                this.lastExecutedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastExecutedSpecified
        {
            get
            {
                return this.lastExecutedFieldSpecified;
            }
            set
            {
                this.lastExecutedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string ModifiedBy
        {
            get
            {
                return this.modifiedByField;
            }
            set
            {
                this.modifiedByField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ModifiedDate
        {
            get
            {
                return this.modifiedDateField;
            }
            set
            {
                this.modifiedDateField = value;
            }
        }

        /// <remarks/>
        public string EventType
        {
            get
            {
                return this.eventTypeField;
            }
            set
            {
                this.eventTypeField = value;
            }
        }

        /// <remarks/>
        public bool IsDataDriven
        {
            get
            {
                return this.isDataDrivenField;
            }
            set
            {
                this.isDataDrivenField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ExtensionSettings
    {

        private string extensionField;

        private ParameterValueOrFieldReference[] parameterValuesField;

        /// <remarks/>
        public string Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(ParameterFieldReference))]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(ParameterValue))]
        public ParameterValueOrFieldReference[] ParameterValues
        {
            get
            {
                return this.parameterValuesField;
            }
            set
            {
                this.parameterValuesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ParameterFieldReference : ParameterValueOrFieldReference
    {

        private string parameterNameField;

        private string fieldAliasField;

        /// <remarks/>
        public string ParameterName
        {
            get
            {
                return this.parameterNameField;
            }
            set
            {
                this.parameterNameField = value;
            }
        }

        /// <remarks/>
        public string FieldAlias
        {
            get
            {
                return this.fieldAliasField;
            }
            set
            {
                this.fieldAliasField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParameterFieldReference))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParameterValue))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ParameterValueOrFieldReference
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ParameterValue : ParameterValueOrFieldReference
    {

        private string nameField;

        private string valueField;

        private string labelField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        public string Label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ActiveState
    {

        private bool deliveryExtensionRemovedField;

        private bool deliveryExtensionRemovedFieldSpecified;

        private bool sharedDataSourceRemovedField;

        private bool sharedDataSourceRemovedFieldSpecified;

        private bool missingParameterValueField;

        private bool missingParameterValueFieldSpecified;

        private bool invalidParameterValueField;

        private bool invalidParameterValueFieldSpecified;

        private bool unknownReportParameterField;

        private bool unknownReportParameterFieldSpecified;

        /// <remarks/>
        public bool DeliveryExtensionRemoved
        {
            get
            {
                return this.deliveryExtensionRemovedField;
            }
            set
            {
                this.deliveryExtensionRemovedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryExtensionRemovedSpecified
        {
            get
            {
                return this.deliveryExtensionRemovedFieldSpecified;
            }
            set
            {
                this.deliveryExtensionRemovedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool SharedDataSourceRemoved
        {
            get
            {
                return this.sharedDataSourceRemovedField;
            }
            set
            {
                this.sharedDataSourceRemovedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SharedDataSourceRemovedSpecified
        {
            get
            {
                return this.sharedDataSourceRemovedFieldSpecified;
            }
            set
            {
                this.sharedDataSourceRemovedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool MissingParameterValue
        {
            get
            {
                return this.missingParameterValueField;
            }
            set
            {
                this.missingParameterValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MissingParameterValueSpecified
        {
            get
            {
                return this.missingParameterValueFieldSpecified;
            }
            set
            {
                this.missingParameterValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool InvalidParameterValue
        {
            get
            {
                return this.invalidParameterValueField;
            }
            set
            {
                this.invalidParameterValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InvalidParameterValueSpecified
        {
            get
            {
                return this.invalidParameterValueFieldSpecified;
            }
            set
            {
                this.invalidParameterValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool UnknownReportParameter
        {
            get
            {
                return this.unknownReportParameterField;
            }
            set
            {
                this.unknownReportParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnknownReportParameterSpecified
        {
            get
            {
                return this.unknownReportParameterFieldSpecified;
            }
            set
            {
                this.unknownReportParameterFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ExtensionParameter
    {

        private string nameField;

        private string displayNameField;

        private bool requiredField;

        private bool requiredFieldSpecified;

        private bool readOnlyField;

        private string valueField;

        private string errorField;

        private bool encryptedField;

        private bool isPasswordField;

        private ValidValue[] validValuesField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        public bool Required
        {
            get
            {
                return this.requiredField;
            }
            set
            {
                this.requiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequiredSpecified
        {
            get
            {
                return this.requiredFieldSpecified;
            }
            set
            {
                this.requiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool ReadOnly
        {
            get
            {
                return this.readOnlyField;
            }
            set
            {
                this.readOnlyField = value;
            }
        }

        /// <remarks/>
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        public string Error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }

        /// <remarks/>
        public bool Encrypted
        {
            get
            {
                return this.encryptedField;
            }
            set
            {
                this.encryptedField = value;
            }
        }

        /// <remarks/>
        public bool IsPassword
        {
            get
            {
                return this.isPasswordField;
            }
            set
            {
                this.isPasswordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Value")]
        public ValidValue[] ValidValues
        {
            get
            {
                return this.validValuesField;
            }
            set
            {
                this.validValuesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class QueryDefinition
    {

        private string commandTypeField;

        private string commandTextField;

        private int timeoutField;

        private bool timeoutFieldSpecified;

        /// <remarks/>
        public string CommandType
        {
            get
            {
                return this.commandTypeField;
            }
            set
            {
                this.commandTypeField = value;
            }
        }

        /// <remarks/>
        public string CommandText
        {
            get
            {
                return this.commandTextField;
            }
            set
            {
                this.commandTextField = value;
            }
        }

        /// <remarks/>
        public int Timeout
        {
            get
            {
                return this.timeoutField;
            }
            set
            {
                this.timeoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeoutSpecified
        {
            get
            {
                return this.timeoutFieldSpecified;
            }
            set
            {
                this.timeoutFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Field
    {

        private string aliasField;

        private string nameField;

        /// <remarks/>
        public string Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DataSetDefinition
    {

        private Field[] fieldsField;

        private QueryDefinition queryField;

        private SensitivityEnum caseSensitivityField;

        private bool caseSensitivityFieldSpecified;

        private string collationField;

        private SensitivityEnum accentSensitivityField;

        private bool accentSensitivityFieldSpecified;

        private SensitivityEnum kanatypeSensitivityField;

        private bool kanatypeSensitivityFieldSpecified;

        private SensitivityEnum widthSensitivityField;

        private bool widthSensitivityFieldSpecified;

        private string nameField;

        /// <remarks/>
        public Field[] Fields
        {
            get
            {
                return this.fieldsField;
            }
            set
            {
                this.fieldsField = value;
            }
        }

        /// <remarks/>
        public QueryDefinition Query
        {
            get
            {
                return this.queryField;
            }
            set
            {
                this.queryField = value;
            }
        }

        /// <remarks/>
        public SensitivityEnum CaseSensitivity
        {
            get
            {
                return this.caseSensitivityField;
            }
            set
            {
                this.caseSensitivityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CaseSensitivitySpecified
        {
            get
            {
                return this.caseSensitivityFieldSpecified;
            }
            set
            {
                this.caseSensitivityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Collation
        {
            get
            {
                return this.collationField;
            }
            set
            {
                this.collationField = value;
            }
        }

        /// <remarks/>
        public SensitivityEnum AccentSensitivity
        {
            get
            {
                return this.accentSensitivityField;
            }
            set
            {
                this.accentSensitivityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccentSensitivitySpecified
        {
            get
            {
                return this.accentSensitivityFieldSpecified;
            }
            set
            {
                this.accentSensitivityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SensitivityEnum KanatypeSensitivity
        {
            get
            {
                return this.kanatypeSensitivityField;
            }
            set
            {
                this.kanatypeSensitivityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KanatypeSensitivitySpecified
        {
            get
            {
                return this.kanatypeSensitivityFieldSpecified;
            }
            set
            {
                this.kanatypeSensitivityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SensitivityEnum WidthSensitivity
        {
            get
            {
                return this.widthSensitivityField;
            }
            set
            {
                this.widthSensitivityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WidthSensitivitySpecified
        {
            get
            {
                return this.widthSensitivityFieldSpecified;
            }
            set
            {
                this.widthSensitivityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public enum SensitivityEnum
    {

        /// <remarks/>
        True,

        /// <remarks/>
        False,

        /// <remarks/>
        Auto,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DataRetrievalPlan
    {

        private DataSourceDefinitionOrReference itemField;

        private DataSetDefinition dataSetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataSourceDefinition", typeof(DataSourceDefinition))]
        [System.Xml.Serialization.XmlElementAttribute("DataSourceReference", typeof(DataSourceReference))]
        [System.Xml.Serialization.XmlElementAttribute("InvalidDataSourceReference", typeof(InvalidDataSourceReference))]
        public DataSourceDefinitionOrReference Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public DataSetDefinition DataSet
        {
            get
            {
                return this.dataSetField;
            }
            set
            {
                this.dataSetField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ItemReferenceData
    {

        private string nameField;

        private string referenceField;

        private string referenceTypeField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        public string ReferenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ItemReference
    {

        private string nameField;

        private string referenceField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class SearchCondition
    {

        private ConditionEnum conditionField;

        private bool conditionFieldSpecified;

        private string[] valuesField;

        private string nameField;

        /// <remarks/>
        public ConditionEnum Condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConditionSpecified
        {
            get
            {
                return this.conditionFieldSpecified;
            }
            set
            {
                this.conditionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Value")]
        public string[] Values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public enum ConditionEnum
    {

        /// <remarks/>
        Contains,

        /// <remarks/>
        Equals,

        /// <remarks/>
        In,

        /// <remarks/>
        Between,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ItemHistorySnapshot
    {

        private string historyIDField;

        private System.DateTime creationDateField;

        private int sizeField;

        /// <remarks/>
        public string HistoryID
        {
            get
            {
                return this.historyIDField;
            }
            set
            {
                this.historyIDField = value;
            }
        }

        /// <remarks/>
        public System.DateTime CreationDate
        {
            get
            {
                return this.creationDateField;
            }
            set
            {
                this.creationDateField = value;
            }
        }

        /// <remarks/>
        public int Size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Warning
    {

        private string codeField;

        private string severityField;

        private string objectNameField;

        private string objectTypeField;

        private string messageField;

        /// <remarks/>
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string Severity
        {
            get
            {
                return this.severityField;
            }
            set
            {
                this.severityField = value;
            }
        }

        /// <remarks/>
        public string ObjectName
        {
            get
            {
                return this.objectNameField;
            }
            set
            {
                this.objectNameField = value;
            }
        }

        /// <remarks/>
        public string ObjectType
        {
            get
            {
                return this.objectTypeField;
            }
            set
            {
                this.objectTypeField = value;
            }
        }

        /// <remarks/>
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class CatalogItem
    {

        private string idField;

        private string nameField;

        private string pathField;

        private string virtualPathField;

        private string typeNameField;

        private int sizeField;

        private bool sizeFieldSpecified;

        private string descriptionField;

        private bool hiddenField;

        private bool hiddenFieldSpecified;

        private System.DateTime creationDateField;

        private bool creationDateFieldSpecified;

        private System.DateTime modifiedDateField;

        private bool modifiedDateFieldSpecified;

        private string createdByField;

        private string modifiedByField;

        private Property[] itemMetadataField;

        /// <remarks/>
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        public string VirtualPath
        {
            get
            {
                return this.virtualPathField;
            }
            set
            {
                this.virtualPathField = value;
            }
        }

        /// <remarks/>
        public string TypeName
        {
            get
            {
                return this.typeNameField;
            }
            set
            {
                this.typeNameField = value;
            }
        }

        /// <remarks/>
        public int Size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SizeSpecified
        {
            get
            {
                return this.sizeFieldSpecified;
            }
            set
            {
                this.sizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public bool Hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HiddenSpecified
        {
            get
            {
                return this.hiddenFieldSpecified;
            }
            set
            {
                this.hiddenFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime CreationDate
        {
            get
            {
                return this.creationDateField;
            }
            set
            {
                this.creationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreationDateSpecified
        {
            get
            {
                return this.creationDateFieldSpecified;
            }
            set
            {
                this.creationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime ModifiedDate
        {
            get
            {
                return this.modifiedDateField;
            }
            set
            {
                this.modifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifiedDateSpecified
        {
            get
            {
                return this.modifiedDateFieldSpecified;
            }
            set
            {
                this.modifiedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CreatedBy
        {
            get
            {
                return this.createdByField;
            }
            set
            {
                this.createdByField = value;
            }
        }

        /// <remarks/>
        public string ModifiedBy
        {
            get
            {
                return this.modifiedByField;
            }
            set
            {
                this.modifiedByField = value;
            }
        }

        /// <remarks/>
        public Property[] ItemMetadata
        {
            get
            {
                return this.itemMetadataField;
            }
            set
            {
                this.itemMetadataField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Property
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class SYSTEMTIME
    {

        private short yearField;

        private short monthField;

        private short dayOfWeekField;

        private short dayField;

        private short hourField;

        private short minuteField;

        private short secondField;

        private short millisecondsField;

        /// <remarks/>
        public short year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        /// <remarks/>
        public short month
        {
            get
            {
                return this.monthField;
            }
            set
            {
                this.monthField = value;
            }
        }

        /// <remarks/>
        public short dayOfWeek
        {
            get
            {
                return this.dayOfWeekField;
            }
            set
            {
                this.dayOfWeekField = value;
            }
        }

        /// <remarks/>
        public short day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }

        /// <remarks/>
        public short hour
        {
            get
            {
                return this.hourField;
            }
            set
            {
                this.hourField = value;
            }
        }

        /// <remarks/>
        public short minute
        {
            get
            {
                return this.minuteField;
            }
            set
            {
                this.minuteField = value;
            }
        }

        /// <remarks/>
        public short second
        {
            get
            {
                return this.secondField;
            }
            set
            {
                this.secondField = value;
            }
        }

        /// <remarks/>
        public short milliseconds
        {
            get
            {
                return this.millisecondsField;
            }
            set
            {
                this.millisecondsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class TimeZoneInformation
    {

        private int biasField;

        private int standardBiasField;

        private SYSTEMTIME standardDateField;

        private int daylightBiasField;

        private SYSTEMTIME daylightDateField;

        /// <remarks/>
        public int Bias
        {
            get
            {
                return this.biasField;
            }
            set
            {
                this.biasField = value;
            }
        }

        /// <remarks/>
        public int StandardBias
        {
            get
            {
                return this.standardBiasField;
            }
            set
            {
                this.standardBiasField = value;
            }
        }

        /// <remarks/>
        public SYSTEMTIME StandardDate
        {
            get
            {
                return this.standardDateField;
            }
            set
            {
                this.standardDateField = value;
            }
        }

        /// <remarks/>
        public int DaylightBias
        {
            get
            {
                return this.daylightBiasField;
            }
            set
            {
                this.daylightBiasField = value;
            }
        }

        /// <remarks/>
        public SYSTEMTIME DaylightDate
        {
            get
            {
                return this.daylightDateField;
            }
            set
            {
                this.daylightDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsNullable = false)]
    public partial class TrustedUserHeader : System.Web.Services.Protocols.SoapHeader
    {

        private string userNameField;

        private byte[] userTokenField;

        private System.Xml.XmlAttribute[] anyAttrField;

        /// <remarks/>
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] UserToken
        {
            get
            {
                return this.userTokenField;
            }
            set
            {
                this.userTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsNullable = false)]
    public partial class ServerInfoHeader : System.Web.Services.Protocols.SoapHeader
    {

        private string reportServerVersionNumberField;

        private string reportServerEditionField;

        private string reportServerVersionField;

        private string reportServerDateTimeField;

        private TimeZoneInformation reportServerTimeZoneInfoField;

        private System.Xml.XmlAttribute[] anyAttrField;

        /// <remarks/>
        public string ReportServerVersionNumber
        {
            get
            {
                return this.reportServerVersionNumberField;
            }
            set
            {
                this.reportServerVersionNumberField = value;
            }
        }

        /// <remarks/>
        public string ReportServerEdition
        {
            get
            {
                return this.reportServerEditionField;
            }
            set
            {
                this.reportServerEditionField = value;
            }
        }

        /// <remarks/>
        public string ReportServerVersion
        {
            get
            {
                return this.reportServerVersionField;
            }
            set
            {
                this.reportServerVersionField = value;
            }
        }

        /// <remarks/>
        public string ReportServerDateTime
        {
            get
            {
                return this.reportServerDateTimeField;
            }
            set
            {
                this.reportServerDateTimeField = value;
            }
        }

        /// <remarks/>
        public TimeZoneInformation ReportServerTimeZoneInfo
        {
            get
            {
                return this.reportServerTimeZoneInfoField;
            }
            set
            {
                this.reportServerTimeZoneInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public enum BooleanOperatorEnum
    {

        /// <remarks/>
        And,

        /// <remarks/>
        Or,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void CreateCatalogItemCompletedEventHandler(object sender, CreateCatalogItemCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateCatalogItemCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CreateCatalogItemCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public CatalogItem Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CatalogItem)(this.results[0]));
            }
        }

        /// <remarks/>
        public Warning[] Warnings
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Warning[])(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetItemDefinitionCompletedEventHandler(object sender, SetItemDefinitionCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetItemDefinitionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SetItemDefinitionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Warning[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Warning[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetItemDefinitionCompletedEventHandler(object sender, GetItemDefinitionCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetItemDefinitionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetItemDefinitionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public byte[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetItemTypeCompletedEventHandler(object sender, GetItemTypeCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetItemTypeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetItemTypeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void DeleteItemCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void MoveItemCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void InheritParentSecurityCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListItemHistoryCompletedEventHandler(object sender, ListItemHistoryCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListItemHistoryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListItemHistoryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ItemHistorySnapshot[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ItemHistorySnapshot[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListChildrenCompletedEventHandler(object sender, ListChildrenCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListChildrenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListChildrenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public CatalogItem[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CatalogItem[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListDependentItemsCompletedEventHandler(object sender, ListDependentItemsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListDependentItemsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListDependentItemsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public CatalogItem[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CatalogItem[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void FindItemsCompletedEventHandler(object sender, FindItemsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindItemsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal FindItemsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public CatalogItem[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CatalogItem[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListParentsCompletedEventHandler(object sender, ListParentsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListParentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListParentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public CatalogItem[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CatalogItem[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void CreateFolderCompletedEventHandler(object sender, CreateFolderCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateFolderCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CreateFolderCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public CatalogItem Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CatalogItem)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetPropertiesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetPropertiesCompletedEventHandler(object sender, GetPropertiesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPropertiesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetPropertiesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Property[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Property[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetItemReferencesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetItemReferencesCompletedEventHandler(object sender, GetItemReferencesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetItemReferencesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetItemReferencesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ItemReferenceData[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ItemReferenceData[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListItemTypesCompletedEventHandler(object sender, ListItemTypesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListItemTypesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListItemTypesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetSubscriptionPropertiesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetSubscriptionPropertiesCompletedEventHandler(object sender, GetSubscriptionPropertiesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSubscriptionPropertiesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetSubscriptionPropertiesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }

        /// <remarks/>
        public ExtensionSettings ExtensionSettings
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExtensionSettings)(this.results[1]));
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }

        /// <remarks/>
        public ActiveState Active
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ActiveState)(this.results[3]));
            }
        }

        /// <remarks/>
        public string Status
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[4]));
            }
        }

        /// <remarks/>
        public string EventType
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[5]));
            }
        }

        /// <remarks/>
        public string MatchData
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[6]));
            }
        }

        /// <remarks/>
        public ParameterValue[] Parameters
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ParameterValue[])(this.results[7]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetDataDrivenSubscriptionPropertiesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetDataDrivenSubscriptionPropertiesCompletedEventHandler(object sender, GetDataDrivenSubscriptionPropertiesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataDrivenSubscriptionPropertiesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetDataDrivenSubscriptionPropertiesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }

        /// <remarks/>
        public ExtensionSettings ExtensionSettings
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExtensionSettings)(this.results[1]));
            }
        }

        /// <remarks/>
        public DataRetrievalPlan DataRetrievalPlan
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((DataRetrievalPlan)(this.results[2]));
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[3]));
            }
        }

        /// <remarks/>
        public ActiveState Active
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ActiveState)(this.results[4]));
            }
        }

        /// <remarks/>
        public string Status
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[5]));
            }
        }

        /// <remarks/>
        public string EventType
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[6]));
            }
        }

        /// <remarks/>
        public string MatchData
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[7]));
            }
        }

        /// <remarks/>
        public ParameterValueOrFieldReference[] Parameters
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ParameterValueOrFieldReference[])(this.results[8]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void DeleteSubscriptionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void CreateSubscriptionCompletedEventHandler(object sender, CreateSubscriptionCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateSubscriptionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CreateSubscriptionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void CreateDataDrivenSubscriptionCompletedEventHandler(object sender, CreateDataDrivenSubscriptionCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateDataDrivenSubscriptionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CreateDataDrivenSubscriptionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetExtensionSettingsCompletedEventHandler(object sender, GetExtensionSettingsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetExtensionSettingsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetExtensionSettingsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ExtensionParameter[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExtensionParameter[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ValidateExtensionSettingsCompletedEventHandler(object sender, ValidateExtensionSettingsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidateExtensionSettingsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ValidateExtensionSettingsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ExtensionParameter[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExtensionParameter[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListSubscriptionsCompletedEventHandler(object sender, ListSubscriptionsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListSubscriptionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListSubscriptionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Subscription[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Subscription[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListMySubscriptionsCompletedEventHandler(object sender, ListMySubscriptionsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListMySubscriptionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListMySubscriptionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Subscription[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Subscription[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListSubscriptionsUsingDataSourceCompletedEventHandler(object sender, ListSubscriptionsUsingDataSourceCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListSubscriptionsUsingDataSourceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListSubscriptionsUsingDataSourceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Subscription[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Subscription[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ChangeSubscriptionOwnerCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void CreateDataSourceCompletedEventHandler(object sender, CreateDataSourceCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateDataSourceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CreateDataSourceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public CatalogItem Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CatalogItem)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void PrepareQueryCompletedEventHandler(object sender, PrepareQueryCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PrepareQueryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal PrepareQueryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public DataSetDefinition Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((DataSetDefinition)(this.results[0]));
            }
        }

        /// <remarks/>
        public bool Changed
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }

        /// <remarks/>
        public string[] ParameterNames
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[2]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void EnableDataSourceCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void DisableDataSourceCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetDataSourceContentsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetDataSourceContentsCompletedEventHandler(object sender, GetDataSourceContentsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataSourceContentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetDataSourceContentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public DataSourceDefinition Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((DataSourceDefinition)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListDatabaseCredentialRetrievalOptionsCompletedEventHandler(object sender, ListDatabaseCredentialRetrievalOptionsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListDatabaseCredentialRetrievalOptionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListDatabaseCredentialRetrievalOptionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetItemDataSourcesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetItemDataSourcesCompletedEventHandler(object sender, GetItemDataSourcesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetItemDataSourcesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetItemDataSourcesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public DataSource[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((DataSource[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void TestConnectForDataSourceDefinitionCompletedEventHandler(object sender, TestConnectForDataSourceDefinitionCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestConnectForDataSourceDefinitionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal TestConnectForDataSourceDefinitionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public bool Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }

        /// <remarks/>
        public string ConnectError
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void TestConnectForItemDataSourceCompletedEventHandler(object sender, TestConnectForItemDataSourceCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestConnectForItemDataSourceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal TestConnectForItemDataSourceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public bool Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }

        /// <remarks/>
        public string ConnectError
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void CreateRoleCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetRolePropertiesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetRolePropertiesCompletedEventHandler(object sender, GetRolePropertiesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRolePropertiesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetRolePropertiesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void DeleteRoleCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListRolesCompletedEventHandler(object sender, ListRolesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListRolesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListRolesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Role[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Role[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListTasksCompletedEventHandler(object sender, ListTasksCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListTasksCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListTasksCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Task[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Task[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetPoliciesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetPoliciesCompletedEventHandler(object sender, GetPoliciesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPoliciesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetPoliciesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Policy[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Policy[])(this.results[0]));
            }
        }

        /// <remarks/>
        public bool InheritParent
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetItemDataSourcePromptsCompletedEventHandler(object sender, GetItemDataSourcePromptsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetItemDataSourcePromptsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetItemDataSourcePromptsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public DataSourcePrompt[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((DataSourcePrompt[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GenerateModelCompletedEventHandler(object sender, GenerateModelCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GenerateModelCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GenerateModelCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public CatalogItem Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CatalogItem)(this.results[0]));
            }
        }

        /// <remarks/>
        public Warning[] Warnings
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Warning[])(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetModelItemPermissionsCompletedEventHandler(object sender, GetModelItemPermissionsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetModelItemPermissionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetModelItemPermissionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetModelItemPoliciesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetModelItemPoliciesCompletedEventHandler(object sender, GetModelItemPoliciesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetModelItemPoliciesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetModelItemPoliciesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Policy[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Policy[])(this.results[0]));
            }
        }

        /// <remarks/>
        public bool InheritParent
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetUserModelCompletedEventHandler(object sender, GetUserModelCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUserModelCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetUserModelCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public byte[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void InheritModelItemParentSecurityCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetModelDrillthroughReportsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListModelDrillthroughReportsCompletedEventHandler(object sender, ListModelDrillthroughReportsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListModelDrillthroughReportsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListModelDrillthroughReportsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ModelDrillthroughReport[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ModelDrillthroughReport[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListModelItemChildrenCompletedEventHandler(object sender, ListModelItemChildrenCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListModelItemChildrenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListModelItemChildrenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ModelItem[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ModelItem[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListModelItemTypesCompletedEventHandler(object sender, ListModelItemTypesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListModelItemTypesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListModelItemTypesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListModelPerspectivesCompletedEventHandler(object sender, ListModelPerspectivesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListModelPerspectivesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListModelPerspectivesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ModelCatalogItem[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ModelCatalogItem[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void RegenerateModelCompletedEventHandler(object sender, RegenerateModelCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RegenerateModelCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal RegenerateModelCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Warning[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Warning[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void RemoveAllModelItemPoliciesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void CreateScheduleCompletedEventHandler(object sender, CreateScheduleCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateScheduleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CreateScheduleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void DeleteScheduleCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListSchedulesCompletedEventHandler(object sender, ListSchedulesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListSchedulesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListSchedulesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Schedule[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Schedule[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetSchedulePropertiesCompletedEventHandler(object sender, GetSchedulePropertiesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSchedulePropertiesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetSchedulePropertiesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Schedule Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Schedule)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListScheduleStatesCompletedEventHandler(object sender, ListScheduleStatesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListScheduleStatesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListScheduleStatesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void PauseScheduleCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ResumeScheduleCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetSchedulePropertiesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListScheduledItemsCompletedEventHandler(object sender, ListScheduledItemsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListScheduledItemsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListScheduledItemsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public CatalogItem[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CatalogItem[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetItemParametersCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetItemParametersCompletedEventHandler(object sender, GetItemParametersCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetItemParametersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetItemParametersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ItemParameter[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ItemParameter[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListParameterTypesCompletedEventHandler(object sender, ListParameterTypesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListParameterTypesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListParameterTypesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListParameterStatesCompletedEventHandler(object sender, ListParameterStatesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListParameterStatesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListParameterStatesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void CreateReportEditSessionCompletedEventHandler(object sender, CreateReportEditSessionCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateReportEditSessionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CreateReportEditSessionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }

        /// <remarks/>
        public Warning[] Warnings
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Warning[])(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void CreateLinkedItemCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetItemLinkCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetItemLinkCompletedEventHandler(object sender, GetItemLinkCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetItemLinkCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetItemLinkCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListExecutionSettingsCompletedEventHandler(object sender, ListExecutionSettingsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListExecutionSettingsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListExecutionSettingsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetExecutionOptionsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetExecutionOptionsCompletedEventHandler(object sender, GetExecutionOptionsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetExecutionOptionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetExecutionOptionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }

        /// <remarks/>
        public ScheduleDefinitionOrReference Item
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ScheduleDefinitionOrReference)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void UpdateItemExecutionSnapshotCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetCacheOptionsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetCacheOptionsCompletedEventHandler(object sender, GetCacheOptionsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCacheOptionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetCacheOptionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public bool Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }

        /// <remarks/>
        public ExpirationDefinition Item
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExpirationDefinition)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void FlushCacheCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void CreateItemHistorySnapshotCompletedEventHandler(object sender, CreateItemHistorySnapshotCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateItemHistorySnapshotCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CreateItemHistorySnapshotCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }

        /// <remarks/>
        public Warning[] Warnings
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Warning[])(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void DeleteItemHistorySnapshotCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetItemHistoryLimitCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetItemHistoryLimitCompletedEventHandler(object sender, GetItemHistoryLimitCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetItemHistoryLimitCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetItemHistoryLimitCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public int Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }

        /// <remarks/>
        public bool IsSystem
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }

        /// <remarks/>
        public int SystemLimit
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[2]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetItemHistoryOptionsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetItemHistoryOptionsCompletedEventHandler(object sender, GetItemHistoryOptionsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetItemHistoryOptionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetItemHistoryOptionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public bool Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }

        /// <remarks/>
        public bool KeepExecutionSnapshots
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }

        /// <remarks/>
        public ScheduleDefinitionOrReference Item
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ScheduleDefinitionOrReference)(this.results[2]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetReportServerConfigInfoCompletedEventHandler(object sender, GetReportServerConfigInfoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetReportServerConfigInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetReportServerConfigInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void IsSSLRequiredCompletedEventHandler(object sender, IsSSLRequiredCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsSSLRequiredCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal IsSSLRequiredCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public bool Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetSystemPropertiesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetSystemPropertiesCompletedEventHandler(object sender, GetSystemPropertiesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSystemPropertiesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetSystemPropertiesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Property[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Property[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetSystemPoliciesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetSystemPoliciesCompletedEventHandler(object sender, GetSystemPoliciesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSystemPoliciesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetSystemPoliciesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Policy[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Policy[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListExtensionsCompletedEventHandler(object sender, ListExtensionsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListExtensionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListExtensionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Extension[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Extension[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListExtensionTypesCompletedEventHandler(object sender, ListExtensionTypesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListExtensionTypesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListExtensionTypesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListEventsCompletedEventHandler(object sender, ListEventsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListEventsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListEventsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Event[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Event[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void FireEventCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListJobsCompletedEventHandler(object sender, ListJobsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListJobsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListJobsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public Job[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Job[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListJobTypesCompletedEventHandler(object sender, ListJobTypesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListJobTypesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListJobTypesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListJobActionsCompletedEventHandler(object sender, ListJobActionsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListJobActionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListJobActionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListJobStatesCompletedEventHandler(object sender, ListJobStatesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListJobStatesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListJobStatesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void CancelJobCompletedEventHandler(object sender, CancelJobCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CancelJobCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CancelJobCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public bool Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void CreateCacheRefreshPlanCompletedEventHandler(object sender, CreateCacheRefreshPlanCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateCacheRefreshPlanCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CreateCacheRefreshPlanCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetCacheRefreshPlanPropertiesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetCacheRefreshPlanPropertiesCompletedEventHandler(object sender, GetCacheRefreshPlanPropertiesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCacheRefreshPlanPropertiesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetCacheRefreshPlanPropertiesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }

        /// <remarks/>
        public string LastRunStatus
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }

        /// <remarks/>
        public CacheRefreshPlanState State
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CacheRefreshPlanState)(this.results[2]));
            }
        }

        /// <remarks/>
        public string EventType
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[3]));
            }
        }

        /// <remarks/>
        public string MatchData
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[4]));
            }
        }

        /// <remarks/>
        public ParameterValue[] Parameters
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ParameterValue[])(this.results[5]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void DeleteCacheRefreshPlanCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListCacheRefreshPlansCompletedEventHandler(object sender, ListCacheRefreshPlansCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListCacheRefreshPlansCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListCacheRefreshPlansCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public CacheRefreshPlan[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CacheRefreshPlan[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void LogonUserCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void LogoffCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetPermissionsCompletedEventHandler(object sender, GetPermissionsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPermissionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetPermissionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetSystemPermissionsCompletedEventHandler(object sender, GetSystemPermissionsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSystemPermissionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetSystemPermissionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListSecurityScopesCompletedEventHandler(object sender, ListSecurityScopesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListSecurityScopesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListSecurityScopesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
}