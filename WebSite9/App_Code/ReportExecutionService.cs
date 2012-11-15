﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using SSRS.Common;
namespace SSRS
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "ReportExecutionServiceSoap", Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParameterValueOrFieldReference))]
    public partial class ReportExecutionService : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private TrustedUserHeader trustedUserHeaderValueField;

        private ServerInfoHeader serverInfoHeaderValueField;

        private System.Threading.SendOrPostCallback ListSecureMethodsOperationCompleted;

        private ExecutionHeader executionHeaderValueField;

        private System.Threading.SendOrPostCallback LoadReportOperationCompleted;

        private System.Threading.SendOrPostCallback LoadReport2OperationCompleted;

        private System.Threading.SendOrPostCallback LoadReportDefinitionOperationCompleted;

        private System.Threading.SendOrPostCallback LoadReportDefinition2OperationCompleted;

        private System.Threading.SendOrPostCallback SetExecutionCredentialsOperationCompleted;

        private System.Threading.SendOrPostCallback SetExecutionCredentials2OperationCompleted;

        private System.Threading.SendOrPostCallback SetExecutionParametersOperationCompleted;

        private System.Threading.SendOrPostCallback SetExecutionParameters2OperationCompleted;

        private System.Threading.SendOrPostCallback ResetExecutionOperationCompleted;

        private System.Threading.SendOrPostCallback ResetExecution2OperationCompleted;

        private System.Threading.SendOrPostCallback RenderOperationCompleted;

        private System.Threading.SendOrPostCallback Render2OperationCompleted;

        private System.Threading.SendOrPostCallback RenderStreamOperationCompleted;

        private System.Threading.SendOrPostCallback GetExecutionInfoOperationCompleted;

        private System.Threading.SendOrPostCallback GetExecutionInfo2OperationCompleted;

        private System.Threading.SendOrPostCallback GetDocumentMapOperationCompleted;

        private System.Threading.SendOrPostCallback LoadDrillthroughTargetOperationCompleted;

        private System.Threading.SendOrPostCallback LoadDrillthroughTarget2OperationCompleted;

        private System.Threading.SendOrPostCallback ToggleItemOperationCompleted;

        private System.Threading.SendOrPostCallback NavigateDocumentMapOperationCompleted;

        private System.Threading.SendOrPostCallback NavigateBookmarkOperationCompleted;

        private System.Threading.SendOrPostCallback FindStringOperationCompleted;

        private System.Threading.SendOrPostCallback SortOperationCompleted;

        private System.Threading.SendOrPostCallback Sort2OperationCompleted;

        private System.Threading.SendOrPostCallback GetRenderResourceOperationCompleted;

        private System.Threading.SendOrPostCallback ListRenderingExtensionsOperationCompleted;

        private System.Threading.SendOrPostCallback LogonUserOperationCompleted;

        private System.Threading.SendOrPostCallback LogoffOperationCompleted;

        /// <remarks/>
        public ReportExecutionService()
        {
            this.Url = System.Configuration.ConfigurationManager.AppSettings["SSRSSite2005"];

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

        public ExecutionHeader ExecutionHeaderValue
        {
            get
            {
                return this.executionHeaderValueField;
            }
            set
            {
                this.executionHeaderValueField = value;
            }
        }

        /// <remarks/>
        public event ListSecureMethodsCompletedEventHandler ListSecureMethodsCompleted;

        /// <remarks/>
        public event LoadReportCompletedEventHandler LoadReportCompleted;

        /// <remarks/>
        public event LoadReport2CompletedEventHandler LoadReport2Completed;

        /// <remarks/>
        public event LoadReportDefinitionCompletedEventHandler LoadReportDefinitionCompleted;

        /// <remarks/>
        public event LoadReportDefinition2CompletedEventHandler LoadReportDefinition2Completed;

        /// <remarks/>
        public event SetExecutionCredentialsCompletedEventHandler SetExecutionCredentialsCompleted;

        /// <remarks/>
        public event SetExecutionCredentials2CompletedEventHandler SetExecutionCredentials2Completed;

        /// <remarks/>
        public event SetExecutionParametersCompletedEventHandler SetExecutionParametersCompleted;

        /// <remarks/>
        public event SetExecutionParameters2CompletedEventHandler SetExecutionParameters2Completed;

        /// <remarks/>
        public event ResetExecutionCompletedEventHandler ResetExecutionCompleted;

        /// <remarks/>
        public event ResetExecution2CompletedEventHandler ResetExecution2Completed;

        /// <remarks/>
        public event RenderCompletedEventHandler RenderCompleted;

        /// <remarks/>
        public event Render2CompletedEventHandler Render2Completed;

        /// <remarks/>
        public event RenderStreamCompletedEventHandler RenderStreamCompleted;

        /// <remarks/>
        public event GetExecutionInfoCompletedEventHandler GetExecutionInfoCompleted;

        /// <remarks/>
        public event GetExecutionInfo2CompletedEventHandler GetExecutionInfo2Completed;

        /// <remarks/>
        public event GetDocumentMapCompletedEventHandler GetDocumentMapCompleted;

        /// <remarks/>
        public event LoadDrillthroughTargetCompletedEventHandler LoadDrillthroughTargetCompleted;

        /// <remarks/>
        public event LoadDrillthroughTarget2CompletedEventHandler LoadDrillthroughTarget2Completed;

        /// <remarks/>
        public event ToggleItemCompletedEventHandler ToggleItemCompleted;

        /// <remarks/>
        public event NavigateDocumentMapCompletedEventHandler NavigateDocumentMapCompleted;

        /// <remarks/>
        public event NavigateBookmarkCompletedEventHandler NavigateBookmarkCompleted;

        /// <remarks/>
        public event FindStringCompletedEventHandler FindStringCompleted;

        /// <remarks/>
        public event SortCompletedEventHandler SortCompleted;

        /// <remarks/>
        public event Sort2CompletedEventHandler Sort2Completed;

        /// <remarks/>
        public event GetRenderResourceCompletedEventHandler GetRenderResourceCompleted;

        /// <remarks/>
        public event ListRenderingExtensionsCompletedEventHandler ListRenderingExtensionsCompleted;

        /// <remarks/>
        public event LogonUserCompletedEventHandler LogonUserCompleted;

        /// <remarks/>
        public event LogoffCompletedEventHandler LogoffCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" +
            "tSecureMethods", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] ListSecureMethods()
        {
            object[] results = this.Invoke("ListSecureMethods", new object[0]);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListSecureMethods(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListSecureMethods", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public string[] EndListSecureMethods(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void ListSecureMethodsAsync()
        {
            this.ListSecureMethodsAsync(null);
        }

        /// <remarks/>
        public void ListSecureMethodsAsync(object userState)
        {
            if ((this.ListSecureMethodsOperationCompleted == null))
            {
                this.ListSecureMethodsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListSecureMethodsOperationCompleted);
            }
            this.InvokeAsync("ListSecureMethods", new object[0], this.ListSecureMethodsOperationCompleted, userState);
        }

        private void OnListSecureMethodsOperationCompleted(object arg)
        {
            if ((this.ListSecureMethodsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListSecureMethodsCompleted(this, new ListSecureMethodsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Loa" +
            "dReport", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("executionInfo")]
        public ExecutionInfo LoadReport(string Report, string HistoryID)
        {
            object[] results = this.Invoke("LoadReport", new object[] {
                    Report,
                    HistoryID});
            return ((ExecutionInfo)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginLoadReport(string Report, string HistoryID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("LoadReport", new object[] {
                    Report,
                    HistoryID}, callback, asyncState);
        }

        /// <remarks/>
        public ExecutionInfo EndLoadReport(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ExecutionInfo)(results[0]));
        }

        /// <remarks/>
        public void LoadReportAsync(string Report, string HistoryID)
        {
            this.LoadReportAsync(Report, HistoryID, null);
        }

        /// <remarks/>
        public void LoadReportAsync(string Report, string HistoryID, object userState)
        {
            if ((this.LoadReportOperationCompleted == null))
            {
                this.LoadReportOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoadReportOperationCompleted);
            }
            this.InvokeAsync("LoadReport", new object[] {
                    Report,
                    HistoryID}, this.LoadReportOperationCompleted, userState);
        }

        private void OnLoadReportOperationCompleted(object arg)
        {
            if ((this.LoadReportCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoadReportCompleted(this, new LoadReportCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Loa" +
            "dReport2", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("executionInfo")]
        public ExecutionInfo2 LoadReport2(string Report, string HistoryID)
        {
            object[] results = this.Invoke("LoadReport2", new object[] {
                    Report,
                    HistoryID});
            return ((ExecutionInfo2)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginLoadReport2(string Report, string HistoryID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("LoadReport2", new object[] {
                    Report,
                    HistoryID}, callback, asyncState);
        }

        /// <remarks/>
        public ExecutionInfo2 EndLoadReport2(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ExecutionInfo2)(results[0]));
        }

        /// <remarks/>
        public void LoadReport2Async(string Report, string HistoryID)
        {
            this.LoadReport2Async(Report, HistoryID, null);
        }

        /// <remarks/>
        public void LoadReport2Async(string Report, string HistoryID, object userState)
        {
            if ((this.LoadReport2OperationCompleted == null))
            {
                this.LoadReport2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoadReport2OperationCompleted);
            }
            this.InvokeAsync("LoadReport2", new object[] {
                    Report,
                    HistoryID}, this.LoadReport2OperationCompleted, userState);
        }

        private void OnLoadReport2OperationCompleted(object arg)
        {
            if ((this.LoadReport2Completed != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoadReport2Completed(this, new LoadReport2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Loa" +
            "dReportDefinition", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("executionInfo")]
        public ExecutionInfo LoadReportDefinition([System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")] byte[] Definition, out Warning[] warnings)
        {
            object[] results = this.Invoke("LoadReportDefinition", new object[] {
                    Definition});
            warnings = ((Warning[])(results[1]));
            return ((ExecutionInfo)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginLoadReportDefinition(byte[] Definition, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("LoadReportDefinition", new object[] {
                    Definition}, callback, asyncState);
        }

        /// <remarks/>
        public ExecutionInfo EndLoadReportDefinition(System.IAsyncResult asyncResult, out Warning[] warnings)
        {
            object[] results = this.EndInvoke(asyncResult);
            warnings = ((Warning[])(results[1]));
            return ((ExecutionInfo)(results[0]));
        }

        /// <remarks/>
        public void LoadReportDefinitionAsync(byte[] Definition)
        {
            this.LoadReportDefinitionAsync(Definition, null);
        }

        /// <remarks/>
        public void LoadReportDefinitionAsync(byte[] Definition, object userState)
        {
            if ((this.LoadReportDefinitionOperationCompleted == null))
            {
                this.LoadReportDefinitionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoadReportDefinitionOperationCompleted);
            }
            this.InvokeAsync("LoadReportDefinition", new object[] {
                    Definition}, this.LoadReportDefinitionOperationCompleted, userState);
        }

        private void OnLoadReportDefinitionOperationCompleted(object arg)
        {
            if ((this.LoadReportDefinitionCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoadReportDefinitionCompleted(this, new LoadReportDefinitionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Loa" +
            "dReportDefinition2", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("executionInfo")]
        public ExecutionInfo2 LoadReportDefinition2([System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")] byte[] Definition, out Warning[] warnings)
        {
            object[] results = this.Invoke("LoadReportDefinition2", new object[] {
                    Definition});
            warnings = ((Warning[])(results[1]));
            return ((ExecutionInfo2)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginLoadReportDefinition2(byte[] Definition, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("LoadReportDefinition2", new object[] {
                    Definition}, callback, asyncState);
        }

        /// <remarks/>
        public ExecutionInfo2 EndLoadReportDefinition2(System.IAsyncResult asyncResult, out Warning[] warnings)
        {
            object[] results = this.EndInvoke(asyncResult);
            warnings = ((Warning[])(results[1]));
            return ((ExecutionInfo2)(results[0]));
        }

        /// <remarks/>
        public void LoadReportDefinition2Async(byte[] Definition)
        {
            this.LoadReportDefinition2Async(Definition, null);
        }

        /// <remarks/>
        public void LoadReportDefinition2Async(byte[] Definition, object userState)
        {
            if ((this.LoadReportDefinition2OperationCompleted == null))
            {
                this.LoadReportDefinition2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoadReportDefinition2OperationCompleted);
            }
            this.InvokeAsync("LoadReportDefinition2", new object[] {
                    Definition}, this.LoadReportDefinition2OperationCompleted, userState);
        }

        private void OnLoadReportDefinition2OperationCompleted(object arg)
        {
            if ((this.LoadReportDefinition2Completed != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoadReportDefinition2Completed(this, new LoadReportDefinition2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" +
            "ExecutionCredentials", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("executionInfo")]
        public ExecutionInfo SetExecutionCredentials(DataSourceCredentials[] Credentials)
        {
            object[] results = this.Invoke("SetExecutionCredentials", new object[] {
                    Credentials});
            return ((ExecutionInfo)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetExecutionCredentials(DataSourceCredentials[] Credentials, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetExecutionCredentials", new object[] {
                    Credentials}, callback, asyncState);
        }

        /// <remarks/>
        public ExecutionInfo EndSetExecutionCredentials(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ExecutionInfo)(results[0]));
        }

        /// <remarks/>
        public void SetExecutionCredentialsAsync(DataSourceCredentials[] Credentials)
        {
            this.SetExecutionCredentialsAsync(Credentials, null);
        }

        /// <remarks/>
        public void SetExecutionCredentialsAsync(DataSourceCredentials[] Credentials, object userState)
        {
            if ((this.SetExecutionCredentialsOperationCompleted == null))
            {
                this.SetExecutionCredentialsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetExecutionCredentialsOperationCompleted);
            }
            this.InvokeAsync("SetExecutionCredentials", new object[] {
                    Credentials}, this.SetExecutionCredentialsOperationCompleted, userState);
        }

        private void OnSetExecutionCredentialsOperationCompleted(object arg)
        {
            if ((this.SetExecutionCredentialsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetExecutionCredentialsCompleted(this, new SetExecutionCredentialsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" +
            "ExecutionCredentials2", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("executionInfo")]
        public ExecutionInfo2 SetExecutionCredentials2(DataSourceCredentials[] Credentials)
        {
            object[] results = this.Invoke("SetExecutionCredentials2", new object[] {
                    Credentials});
            return ((ExecutionInfo2)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetExecutionCredentials2(DataSourceCredentials[] Credentials, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetExecutionCredentials2", new object[] {
                    Credentials}, callback, asyncState);
        }

        /// <remarks/>
        public ExecutionInfo2 EndSetExecutionCredentials2(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ExecutionInfo2)(results[0]));
        }

        /// <remarks/>
        public void SetExecutionCredentials2Async(DataSourceCredentials[] Credentials)
        {
            this.SetExecutionCredentials2Async(Credentials, null);
        }

        /// <remarks/>
        public void SetExecutionCredentials2Async(DataSourceCredentials[] Credentials, object userState)
        {
            if ((this.SetExecutionCredentials2OperationCompleted == null))
            {
                this.SetExecutionCredentials2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetExecutionCredentials2OperationCompleted);
            }
            this.InvokeAsync("SetExecutionCredentials2", new object[] {
                    Credentials}, this.SetExecutionCredentials2OperationCompleted, userState);
        }

        private void OnSetExecutionCredentials2OperationCompleted(object arg)
        {
            if ((this.SetExecutionCredentials2Completed != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetExecutionCredentials2Completed(this, new SetExecutionCredentials2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" +
            "ExecutionParameters", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("executionInfo")]
        public ExecutionInfo SetExecutionParameters(ParameterValue[] Parameters, string ParameterLanguage)
        {
            object[] results = this.Invoke("SetExecutionParameters", new object[] {
                    Parameters,
                    ParameterLanguage});
            return ((ExecutionInfo)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetExecutionParameters(ParameterValue[] Parameters, string ParameterLanguage, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetExecutionParameters", new object[] {
                    Parameters,
                    ParameterLanguage}, callback, asyncState);
        }

        /// <remarks/>
        public ExecutionInfo EndSetExecutionParameters(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ExecutionInfo)(results[0]));
        }

        /// <remarks/>
        public void SetExecutionParametersAsync(ParameterValue[] Parameters, string ParameterLanguage)
        {
            this.SetExecutionParametersAsync(Parameters, ParameterLanguage, null);
        }

        /// <remarks/>
        public void SetExecutionParametersAsync(ParameterValue[] Parameters, string ParameterLanguage, object userState)
        {
            if ((this.SetExecutionParametersOperationCompleted == null))
            {
                this.SetExecutionParametersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetExecutionParametersOperationCompleted);
            }
            this.InvokeAsync("SetExecutionParameters", new object[] {
                    Parameters,
                    ParameterLanguage}, this.SetExecutionParametersOperationCompleted, userState);
        }

        private void OnSetExecutionParametersOperationCompleted(object arg)
        {
            if ((this.SetExecutionParametersCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetExecutionParametersCompleted(this, new SetExecutionParametersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" +
            "ExecutionParameters2", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("executionInfo")]
        public ExecutionInfo2 SetExecutionParameters2(ParameterValue[] Parameters, string ParameterLanguage)
        {
            object[] results = this.Invoke("SetExecutionParameters2", new object[] {
                    Parameters,
                    ParameterLanguage});
            return ((ExecutionInfo2)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetExecutionParameters2(ParameterValue[] Parameters, string ParameterLanguage, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetExecutionParameters2", new object[] {
                    Parameters,
                    ParameterLanguage}, callback, asyncState);
        }

        /// <remarks/>
        public ExecutionInfo2 EndSetExecutionParameters2(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ExecutionInfo2)(results[0]));
        }

        /// <remarks/>
        public void SetExecutionParameters2Async(ParameterValue[] Parameters, string ParameterLanguage)
        {
            this.SetExecutionParameters2Async(Parameters, ParameterLanguage, null);
        }

        /// <remarks/>
        public void SetExecutionParameters2Async(ParameterValue[] Parameters, string ParameterLanguage, object userState)
        {
            if ((this.SetExecutionParameters2OperationCompleted == null))
            {
                this.SetExecutionParameters2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetExecutionParameters2OperationCompleted);
            }
            this.InvokeAsync("SetExecutionParameters2", new object[] {
                    Parameters,
                    ParameterLanguage}, this.SetExecutionParameters2OperationCompleted, userState);
        }

        private void OnSetExecutionParameters2OperationCompleted(object arg)
        {
            if ((this.SetExecutionParameters2Completed != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetExecutionParameters2Completed(this, new SetExecutionParameters2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Res" +
            "etExecution", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("executionInfo")]
        public ExecutionInfo ResetExecution()
        {
            object[] results = this.Invoke("ResetExecution", new object[0]);
            return ((ExecutionInfo)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginResetExecution(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ResetExecution", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public ExecutionInfo EndResetExecution(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ExecutionInfo)(results[0]));
        }

        /// <remarks/>
        public void ResetExecutionAsync()
        {
            this.ResetExecutionAsync(null);
        }

        /// <remarks/>
        public void ResetExecutionAsync(object userState)
        {
            if ((this.ResetExecutionOperationCompleted == null))
            {
                this.ResetExecutionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnResetExecutionOperationCompleted);
            }
            this.InvokeAsync("ResetExecution", new object[0], this.ResetExecutionOperationCompleted, userState);
        }

        private void OnResetExecutionOperationCompleted(object arg)
        {
            if ((this.ResetExecutionCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ResetExecutionCompleted(this, new ResetExecutionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Res" +
            "etExecution2", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("executionInfo")]
        public ExecutionInfo2 ResetExecution2()
        {
            object[] results = this.Invoke("ResetExecution2", new object[0]);
            return ((ExecutionInfo2)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginResetExecution2(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ResetExecution2", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public ExecutionInfo2 EndResetExecution2(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ExecutionInfo2)(results[0]));
        }

        /// <remarks/>
        public void ResetExecution2Async()
        {
            this.ResetExecution2Async(null);
        }

        /// <remarks/>
        public void ResetExecution2Async(object userState)
        {
            if ((this.ResetExecution2OperationCompleted == null))
            {
                this.ResetExecution2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnResetExecution2OperationCompleted);
            }
            this.InvokeAsync("ResetExecution2", new object[0], this.ResetExecution2OperationCompleted, userState);
        }

        private void OnResetExecution2OperationCompleted(object arg)
        {
            if ((this.ResetExecution2Completed != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ResetExecution2Completed(this, new ResetExecution2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Ren" +
            "der", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Result", DataType = "base64Binary")]
        public byte[] Render(string Format, string DeviceInfo, out string Extension, out string MimeType, out string Encoding, out Warning[] Warnings, out string[] StreamIds)
        {
            object[] results = this.Invoke("Render", new object[] {
                    Format,
                    DeviceInfo});
            Extension = ((string)(results[1]));
            MimeType = ((string)(results[2]));
            Encoding = ((string)(results[3]));
            Warnings = ((Warning[])(results[4]));
            StreamIds = ((string[])(results[5]));
            return ((byte[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginRender(string Format, string DeviceInfo, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("Render", new object[] {
                    Format,
                    DeviceInfo}, callback, asyncState);
        }

        /// <remarks/>
        public byte[] EndRender(System.IAsyncResult asyncResult, out string Extension, out string MimeType, out string Encoding, out Warning[] Warnings, out string[] StreamIds)
        {
            object[] results = this.EndInvoke(asyncResult);
            Extension = ((string)(results[1]));
            MimeType = ((string)(results[2]));
            Encoding = ((string)(results[3]));
            Warnings = ((Warning[])(results[4]));
            StreamIds = ((string[])(results[5]));
            return ((byte[])(results[0]));
        }

        /// <remarks/>
        public void RenderAsync(string Format, string DeviceInfo)
        {
            this.RenderAsync(Format, DeviceInfo, null);
        }

        /// <remarks/>
        public void RenderAsync(string Format, string DeviceInfo, object userState)
        {
            if ((this.RenderOperationCompleted == null))
            {
                this.RenderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRenderOperationCompleted);
            }
            this.InvokeAsync("Render", new object[] {
                    Format,
                    DeviceInfo}, this.RenderOperationCompleted, userState);
        }

        private void OnRenderOperationCompleted(object arg)
        {
            if ((this.RenderCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RenderCompleted(this, new RenderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Ren" +
            "der2", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Result", DataType = "base64Binary")]
        public byte[] Render2(string Format, string DeviceInfo, PageCountMode PaginationMode, out string Extension, out string MimeType, out string Encoding, out Warning[] Warnings, out string[] StreamIds)
        {
            object[] results = this.Invoke("Render2", new object[] {
                    Format,
                    DeviceInfo,
                    PaginationMode});
            Extension = ((string)(results[1]));
            MimeType = ((string)(results[2]));
            Encoding = ((string)(results[3]));
            Warnings = ((Warning[])(results[4]));
            StreamIds = ((string[])(results[5]));
            return ((byte[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginRender2(string Format, string DeviceInfo, PageCountMode PaginationMode, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("Render2", new object[] {
                    Format,
                    DeviceInfo,
                    PaginationMode}, callback, asyncState);
        }

        /// <remarks/>
        public byte[] EndRender2(System.IAsyncResult asyncResult, out string Extension, out string MimeType, out string Encoding, out Warning[] Warnings, out string[] StreamIds)
        {
            object[] results = this.EndInvoke(asyncResult);
            Extension = ((string)(results[1]));
            MimeType = ((string)(results[2]));
            Encoding = ((string)(results[3]));
            Warnings = ((Warning[])(results[4]));
            StreamIds = ((string[])(results[5]));
            return ((byte[])(results[0]));
        }

        /// <remarks/>
        public void Render2Async(string Format, string DeviceInfo, PageCountMode PaginationMode)
        {
            this.Render2Async(Format, DeviceInfo, PaginationMode, null);
        }

        /// <remarks/>
        public void Render2Async(string Format, string DeviceInfo, PageCountMode PaginationMode, object userState)
        {
            if ((this.Render2OperationCompleted == null))
            {
                this.Render2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnRender2OperationCompleted);
            }
            this.InvokeAsync("Render2", new object[] {
                    Format,
                    DeviceInfo,
                    PaginationMode}, this.Render2OperationCompleted, userState);
        }

        private void OnRender2OperationCompleted(object arg)
        {
            if ((this.Render2Completed != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Render2Completed(this, new Render2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Ren" +
            "derStream", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Result", DataType = "base64Binary")]
        public byte[] RenderStream(string Format, string StreamID, string DeviceInfo, out string Encoding, out string MimeType)
        {
            object[] results = this.Invoke("RenderStream", new object[] {
                    Format,
                    StreamID,
                    DeviceInfo});
            Encoding = ((string)(results[1]));
            MimeType = ((string)(results[2]));
            return ((byte[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginRenderStream(string Format, string StreamID, string DeviceInfo, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("RenderStream", new object[] {
                    Format,
                    StreamID,
                    DeviceInfo}, callback, asyncState);
        }

        /// <remarks/>
        public byte[] EndRenderStream(System.IAsyncResult asyncResult, out string Encoding, out string MimeType)
        {
            object[] results = this.EndInvoke(asyncResult);
            Encoding = ((string)(results[1]));
            MimeType = ((string)(results[2]));
            return ((byte[])(results[0]));
        }

        /// <remarks/>
        public void RenderStreamAsync(string Format, string StreamID, string DeviceInfo)
        {
            this.RenderStreamAsync(Format, StreamID, DeviceInfo, null);
        }

        /// <remarks/>
        public void RenderStreamAsync(string Format, string StreamID, string DeviceInfo, object userState)
        {
            if ((this.RenderStreamOperationCompleted == null))
            {
                this.RenderStreamOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRenderStreamOperationCompleted);
            }
            this.InvokeAsync("RenderStream", new object[] {
                    Format,
                    StreamID,
                    DeviceInfo}, this.RenderStreamOperationCompleted, userState);
        }

        private void OnRenderStreamOperationCompleted(object arg)
        {
            if ((this.RenderStreamCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RenderStreamCompleted(this, new RenderStreamCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" +
            "ExecutionInfo", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("executionInfo")]
        public ExecutionInfo GetExecutionInfo()
        {
            object[] results = this.Invoke("GetExecutionInfo", new object[0]);
            return ((ExecutionInfo)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetExecutionInfo(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetExecutionInfo", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public ExecutionInfo EndGetExecutionInfo(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ExecutionInfo)(results[0]));
        }

        /// <remarks/>
        public void GetExecutionInfoAsync()
        {
            this.GetExecutionInfoAsync(null);
        }

        /// <remarks/>
        public void GetExecutionInfoAsync(object userState)
        {
            if ((this.GetExecutionInfoOperationCompleted == null))
            {
                this.GetExecutionInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetExecutionInfoOperationCompleted);
            }
            this.InvokeAsync("GetExecutionInfo", new object[0], this.GetExecutionInfoOperationCompleted, userState);
        }

        private void OnGetExecutionInfoOperationCompleted(object arg)
        {
            if ((this.GetExecutionInfoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetExecutionInfoCompleted(this, new GetExecutionInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" +
            "ExecutionInfo2", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("executionInfo")]
        public ExecutionInfo2 GetExecutionInfo2()
        {
            object[] results = this.Invoke("GetExecutionInfo2", new object[0]);
            return ((ExecutionInfo2)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetExecutionInfo2(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetExecutionInfo2", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public ExecutionInfo2 EndGetExecutionInfo2(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ExecutionInfo2)(results[0]));
        }

        /// <remarks/>
        public void GetExecutionInfo2Async()
        {
            this.GetExecutionInfo2Async(null);
        }

        /// <remarks/>
        public void GetExecutionInfo2Async(object userState)
        {
            if ((this.GetExecutionInfo2OperationCompleted == null))
            {
                this.GetExecutionInfo2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetExecutionInfo2OperationCompleted);
            }
            this.InvokeAsync("GetExecutionInfo2", new object[0], this.GetExecutionInfo2OperationCompleted, userState);
        }

        private void OnGetExecutionInfo2OperationCompleted(object arg)
        {
            if ((this.GetExecutionInfo2Completed != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetExecutionInfo2Completed(this, new GetExecutionInfo2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" +
            "DocumentMap", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("result")]
        public DocumentMapNode GetDocumentMap()
        {
            object[] results = this.Invoke("GetDocumentMap", new object[0]);
            return ((DocumentMapNode)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetDocumentMap(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetDocumentMap", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public DocumentMapNode EndGetDocumentMap(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((DocumentMapNode)(results[0]));
        }

        /// <remarks/>
        public void GetDocumentMapAsync()
        {
            this.GetDocumentMapAsync(null);
        }

        /// <remarks/>
        public void GetDocumentMapAsync(object userState)
        {
            if ((this.GetDocumentMapOperationCompleted == null))
            {
                this.GetDocumentMapOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocumentMapOperationCompleted);
            }
            this.InvokeAsync("GetDocumentMap", new object[0], this.GetDocumentMapOperationCompleted, userState);
        }

        private void OnGetDocumentMapOperationCompleted(object arg)
        {
            if ((this.GetDocumentMapCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocumentMapCompleted(this, new GetDocumentMapCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.InOut)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Loa" +
            "dDrillthroughTarget", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ExecutionInfo")]
        public ExecutionInfo LoadDrillthroughTarget(string DrillthroughID)
        {
            object[] results = this.Invoke("LoadDrillthroughTarget", new object[] {
                    DrillthroughID});
            return ((ExecutionInfo)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginLoadDrillthroughTarget(string DrillthroughID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("LoadDrillthroughTarget", new object[] {
                    DrillthroughID}, callback, asyncState);
        }

        /// <remarks/>
        public ExecutionInfo EndLoadDrillthroughTarget(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ExecutionInfo)(results[0]));
        }

        /// <remarks/>
        public void LoadDrillthroughTargetAsync(string DrillthroughID)
        {
            this.LoadDrillthroughTargetAsync(DrillthroughID, null);
        }

        /// <remarks/>
        public void LoadDrillthroughTargetAsync(string DrillthroughID, object userState)
        {
            if ((this.LoadDrillthroughTargetOperationCompleted == null))
            {
                this.LoadDrillthroughTargetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoadDrillthroughTargetOperationCompleted);
            }
            this.InvokeAsync("LoadDrillthroughTarget", new object[] {
                    DrillthroughID}, this.LoadDrillthroughTargetOperationCompleted, userState);
        }

        private void OnLoadDrillthroughTargetOperationCompleted(object arg)
        {
            if ((this.LoadDrillthroughTargetCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoadDrillthroughTargetCompleted(this, new LoadDrillthroughTargetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.InOut)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Loa" +
            "dDrillthroughTarget2", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ExecutionInfo")]
        public ExecutionInfo2 LoadDrillthroughTarget2(string DrillthroughID)
        {
            object[] results = this.Invoke("LoadDrillthroughTarget2", new object[] {
                    DrillthroughID});
            return ((ExecutionInfo2)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginLoadDrillthroughTarget2(string DrillthroughID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("LoadDrillthroughTarget2", new object[] {
                    DrillthroughID}, callback, asyncState);
        }

        /// <remarks/>
        public ExecutionInfo2 EndLoadDrillthroughTarget2(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ExecutionInfo2)(results[0]));
        }

        /// <remarks/>
        public void LoadDrillthroughTarget2Async(string DrillthroughID)
        {
            this.LoadDrillthroughTarget2Async(DrillthroughID, null);
        }

        /// <remarks/>
        public void LoadDrillthroughTarget2Async(string DrillthroughID, object userState)
        {
            if ((this.LoadDrillthroughTarget2OperationCompleted == null))
            {
                this.LoadDrillthroughTarget2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoadDrillthroughTarget2OperationCompleted);
            }
            this.InvokeAsync("LoadDrillthroughTarget2", new object[] {
                    DrillthroughID}, this.LoadDrillthroughTarget2OperationCompleted, userState);
        }

        private void OnLoadDrillthroughTarget2OperationCompleted(object arg)
        {
            if ((this.LoadDrillthroughTarget2Completed != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoadDrillthroughTarget2Completed(this, new LoadDrillthroughTarget2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Tog" +
            "gleItem", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Found")]
        public bool ToggleItem(string ToggleID)
        {
            object[] results = this.Invoke("ToggleItem", new object[] {
                    ToggleID});
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginToggleItem(string ToggleID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ToggleItem", new object[] {
                    ToggleID}, callback, asyncState);
        }

        /// <remarks/>
        public bool EndToggleItem(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public void ToggleItemAsync(string ToggleID)
        {
            this.ToggleItemAsync(ToggleID, null);
        }

        /// <remarks/>
        public void ToggleItemAsync(string ToggleID, object userState)
        {
            if ((this.ToggleItemOperationCompleted == null))
            {
                this.ToggleItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnToggleItemOperationCompleted);
            }
            this.InvokeAsync("ToggleItem", new object[] {
                    ToggleID}, this.ToggleItemOperationCompleted, userState);
        }

        private void OnToggleItemOperationCompleted(object arg)
        {
            if ((this.ToggleItemCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ToggleItemCompleted(this, new ToggleItemCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Nav" +
            "igateDocumentMap", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("PageNumber")]
        public int NavigateDocumentMap(string DocMapID)
        {
            object[] results = this.Invoke("NavigateDocumentMap", new object[] {
                    DocMapID});
            return ((int)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginNavigateDocumentMap(string DocMapID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("NavigateDocumentMap", new object[] {
                    DocMapID}, callback, asyncState);
        }

        /// <remarks/>
        public int EndNavigateDocumentMap(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }

        /// <remarks/>
        public void NavigateDocumentMapAsync(string DocMapID)
        {
            this.NavigateDocumentMapAsync(DocMapID, null);
        }

        /// <remarks/>
        public void NavigateDocumentMapAsync(string DocMapID, object userState)
        {
            if ((this.NavigateDocumentMapOperationCompleted == null))
            {
                this.NavigateDocumentMapOperationCompleted = new System.Threading.SendOrPostCallback(this.OnNavigateDocumentMapOperationCompleted);
            }
            this.InvokeAsync("NavigateDocumentMap", new object[] {
                    DocMapID}, this.NavigateDocumentMapOperationCompleted, userState);
        }

        private void OnNavigateDocumentMapOperationCompleted(object arg)
        {
            if ((this.NavigateDocumentMapCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.NavigateDocumentMapCompleted(this, new NavigateDocumentMapCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Nav" +
            "igateBookmark", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("PageNumber")]
        public int NavigateBookmark(string BookmarkID, out string UniqueName)
        {
            object[] results = this.Invoke("NavigateBookmark", new object[] {
                    BookmarkID});
            UniqueName = ((string)(results[1]));
            return ((int)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginNavigateBookmark(string BookmarkID, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("NavigateBookmark", new object[] {
                    BookmarkID}, callback, asyncState);
        }

        /// <remarks/>
        public int EndNavigateBookmark(System.IAsyncResult asyncResult, out string UniqueName)
        {
            object[] results = this.EndInvoke(asyncResult);
            UniqueName = ((string)(results[1]));
            return ((int)(results[0]));
        }

        /// <remarks/>
        public void NavigateBookmarkAsync(string BookmarkID)
        {
            this.NavigateBookmarkAsync(BookmarkID, null);
        }

        /// <remarks/>
        public void NavigateBookmarkAsync(string BookmarkID, object userState)
        {
            if ((this.NavigateBookmarkOperationCompleted == null))
            {
                this.NavigateBookmarkOperationCompleted = new System.Threading.SendOrPostCallback(this.OnNavigateBookmarkOperationCompleted);
            }
            this.InvokeAsync("NavigateBookmark", new object[] {
                    BookmarkID}, this.NavigateBookmarkOperationCompleted, userState);
        }

        private void OnNavigateBookmarkOperationCompleted(object arg)
        {
            if ((this.NavigateBookmarkCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.NavigateBookmarkCompleted(this, new NavigateBookmarkCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Fin" +
            "dString", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("PageNumber")]
        public int FindString(int StartPage, int EndPage, string FindValue)
        {
            object[] results = this.Invoke("FindString", new object[] {
                    StartPage,
                    EndPage,
                    FindValue});
            return ((int)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginFindString(int StartPage, int EndPage, string FindValue, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("FindString", new object[] {
                    StartPage,
                    EndPage,
                    FindValue}, callback, asyncState);
        }

        /// <remarks/>
        public int EndFindString(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }

        /// <remarks/>
        public void FindStringAsync(int StartPage, int EndPage, string FindValue)
        {
            this.FindStringAsync(StartPage, EndPage, FindValue, null);
        }

        /// <remarks/>
        public void FindStringAsync(int StartPage, int EndPage, string FindValue, object userState)
        {
            if ((this.FindStringOperationCompleted == null))
            {
                this.FindStringOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindStringOperationCompleted);
            }
            this.InvokeAsync("FindString", new object[] {
                    StartPage,
                    EndPage,
                    FindValue}, this.FindStringOperationCompleted, userState);
        }

        private void OnFindStringOperationCompleted(object arg)
        {
            if ((this.FindStringCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindStringCompleted(this, new FindStringCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Sor" +
            "t", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("PageNumber")]
        public int Sort(string SortItem, SortDirectionEnum Direction, bool Clear, out string ReportItem, out int NumPages)
        {
            object[] results = this.Invoke("Sort", new object[] {
                    SortItem,
                    Direction,
                    Clear});
            ReportItem = ((string)(results[1]));
            NumPages = ((int)(results[2]));
            return ((int)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginSort(string SortItem, SortDirectionEnum Direction, bool Clear, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("Sort", new object[] {
                    SortItem,
                    Direction,
                    Clear}, callback, asyncState);
        }

        /// <remarks/>
        public int EndSort(System.IAsyncResult asyncResult, out string ReportItem, out int NumPages)
        {
            object[] results = this.EndInvoke(asyncResult);
            ReportItem = ((string)(results[1]));
            NumPages = ((int)(results[2]));
            return ((int)(results[0]));
        }

        /// <remarks/>
        public void SortAsync(string SortItem, SortDirectionEnum Direction, bool Clear)
        {
            this.SortAsync(SortItem, Direction, Clear, null);
        }

        /// <remarks/>
        public void SortAsync(string SortItem, SortDirectionEnum Direction, bool Clear, object userState)
        {
            if ((this.SortOperationCompleted == null))
            {
                this.SortOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSortOperationCompleted);
            }
            this.InvokeAsync("Sort", new object[] {
                    SortItem,
                    Direction,
                    Clear}, this.SortOperationCompleted, userState);
        }

        private void OnSortOperationCompleted(object arg)
        {
            if ((this.SortCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SortCompleted(this, new SortCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ExecutionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Sor" +
            "t2", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("PageNumber")]
        public int Sort2(string SortItem, SortDirectionEnum Direction, bool Clear, PageCountMode PaginationMode, out string ReportItem, out ExecutionInfo2 ExecutionInfo)
        {
            object[] results = this.Invoke("Sort2", new object[] {
                    SortItem,
                    Direction,
                    Clear,
                    PaginationMode});
            ReportItem = ((string)(results[1]));
            ExecutionInfo = ((ExecutionInfo2)(results[2]));
            return ((int)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginSort2(string SortItem, SortDirectionEnum Direction, bool Clear, PageCountMode PaginationMode, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("Sort2", new object[] {
                    SortItem,
                    Direction,
                    Clear,
                    PaginationMode}, callback, asyncState);
        }

        /// <remarks/>
        public int EndSort2(System.IAsyncResult asyncResult, out string ReportItem, out ExecutionInfo2 ExecutionInfo)
        {
            object[] results = this.EndInvoke(asyncResult);
            ReportItem = ((string)(results[1]));
            ExecutionInfo = ((ExecutionInfo2)(results[2]));
            return ((int)(results[0]));
        }

        /// <remarks/>
        public void Sort2Async(string SortItem, SortDirectionEnum Direction, bool Clear, PageCountMode PaginationMode)
        {
            this.Sort2Async(SortItem, Direction, Clear, PaginationMode, null);
        }

        /// <remarks/>
        public void Sort2Async(string SortItem, SortDirectionEnum Direction, bool Clear, PageCountMode PaginationMode, object userState)
        {
            if ((this.Sort2OperationCompleted == null))
            {
                this.Sort2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnSort2OperationCompleted);
            }
            this.InvokeAsync("Sort2", new object[] {
                    SortItem,
                    Direction,
                    Clear,
                    PaginationMode}, this.Sort2OperationCompleted, userState);
        }

        private void OnSort2OperationCompleted(object arg)
        {
            if ((this.Sort2Completed != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Sort2Completed(this, new Sort2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" +
            "RenderResource", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Result", DataType = "base64Binary")]
        public byte[] GetRenderResource(string Format, string DeviceInfo, out string MimeType)
        {
            object[] results = this.Invoke("GetRenderResource", new object[] {
                    Format,
                    DeviceInfo});
            MimeType = ((string)(results[1]));
            return ((byte[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetRenderResource(string Format, string DeviceInfo, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetRenderResource", new object[] {
                    Format,
                    DeviceInfo}, callback, asyncState);
        }

        /// <remarks/>
        public byte[] EndGetRenderResource(System.IAsyncResult asyncResult, out string MimeType)
        {
            object[] results = this.EndInvoke(asyncResult);
            MimeType = ((string)(results[1]));
            return ((byte[])(results[0]));
        }

        /// <remarks/>
        public void GetRenderResourceAsync(string Format, string DeviceInfo)
        {
            this.GetRenderResourceAsync(Format, DeviceInfo, null);
        }

        /// <remarks/>
        public void GetRenderResourceAsync(string Format, string DeviceInfo, object userState)
        {
            if ((this.GetRenderResourceOperationCompleted == null))
            {
                this.GetRenderResourceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRenderResourceOperationCompleted);
            }
            this.InvokeAsync("GetRenderResource", new object[] {
                    Format,
                    DeviceInfo}, this.GetRenderResourceOperationCompleted, userState);
        }

        private void OnGetRenderResourceOperationCompleted(object arg)
        {
            if ((this.GetRenderResourceCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRenderResourceCompleted(this, new GetRenderResourceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("TrustedUserHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" +
            "tRenderingExtensions", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Extensions")]
        public Extension[] ListRenderingExtensions()
        {
            object[] results = this.Invoke("ListRenderingExtensions", new object[0]);
            return ((Extension[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginListRenderingExtensions(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ListRenderingExtensions", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public Extension[] EndListRenderingExtensions(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((Extension[])(results[0]));
        }

        /// <remarks/>
        public void ListRenderingExtensionsAsync()
        {
            this.ListRenderingExtensionsAsync(null);
        }

        /// <remarks/>
        public void ListRenderingExtensionsAsync(object userState)
        {
            if ((this.ListRenderingExtensionsOperationCompleted == null))
            {
                this.ListRenderingExtensionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListRenderingExtensionsOperationCompleted);
            }
            this.InvokeAsync("ListRenderingExtensions", new object[0], this.ListRenderingExtensionsOperationCompleted, userState);
        }

        private void OnListRenderingExtensionsOperationCompleted(object arg)
        {
            if ((this.ListRenderingExtensionsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListRenderingExtensionsCompleted(this, new ListRenderingExtensionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Log" +
            "onUser", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
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
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServerInfoHeaderValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Log" +
            "off", RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", IsNullable = false)]
    public partial class ExecutionHeader : System.Web.Services.Protocols.SoapHeader
    {

        private string executionIDField;

        private System.Xml.XmlAttribute[] anyAttrField;

        /// <remarks/>
        public string ExecutionID
        {
            get
            {
                return this.executionIDField;
            }
            set
            {
                this.executionIDField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class Extension
    {

        private ExtensionTypeEnum extensionTypeField;

        private string nameField;

        private string localizedNameField;

        private bool visibleField;

        private bool isModelGenerationSupportedField;

        /// <remarks/>
        public ExtensionTypeEnum ExtensionType
        {
            get
            {
                return this.extensionTypeField;
            }
            set
            {
                this.extensionTypeField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum ExtensionTypeEnum
    {

        /// <remarks/>
        Delivery,

        /// <remarks/>
        Render,

        /// <remarks/>
        Data,

        /// <remarks/>
        All,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class DocumentMapNode
    {

        private string labelField;

        private string uniqueNameField;

        private DocumentMapNode[] childrenField;

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
        public string UniqueName
        {
            get
            {
                return this.uniqueNameField;
            }
            set
            {
                this.uniqueNameField = value;
            }
        }

        /// <remarks/>
        public DocumentMapNode[] Children
        {
            get
            {
                return this.childrenField;
            }
            set
            {
                this.childrenField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParameterValue))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ParameterValueOrFieldReference
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ReportMargins
    {

        private double topField;

        private double bottomField;

        private double leftField;

        private double rightField;

        /// <remarks/>
        public double Top
        {
            get
            {
                return this.topField;
            }
            set
            {
                this.topField = value;
            }
        }

        /// <remarks/>
        public double Bottom
        {
            get
            {
                return this.bottomField;
            }
            set
            {
                this.bottomField = value;
            }
        }

        /// <remarks/>
        public double Left
        {
            get
            {
                return this.leftField;
            }
            set
            {
                this.leftField = value;
            }
        }

        /// <remarks/>
        public double Right
        {
            get
            {
                return this.rightField;
            }
            set
            {
                this.rightField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ReportPaperSize
    {

        private double heightField;

        private double widthField;

        /// <remarks/>
        public double Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public double Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class PageSettings
    {

        private ReportPaperSize paperSizeField;

        private ReportMargins marginsField;

        /// <remarks/>
        public ReportPaperSize PaperSize
        {
            get
            {
                return this.paperSizeField;
            }
            set
            {
                this.paperSizeField = value;
            }
        }

        /// <remarks/>
        public ReportMargins Margins
        {
            get
            {
                return this.marginsField;
            }
            set
            {
                this.marginsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ReportParameter
    {

        private string nameField;

        private ParameterTypeEnum typeField;

        private bool typeFieldSpecified;

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

        private ParameterStateEnum stateField;

        private bool stateFieldSpecified;

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
        public ParameterTypeEnum Type
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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
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
        public ParameterStateEnum State
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StateSpecified
        {
            get
            {
                return this.stateFieldSpecified;
            }
            set
            {
                this.stateFieldSpecified = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum ParameterTypeEnum
    {

        /// <remarks/>
        Boolean,

        /// <remarks/>
        DateTime,

        /// <remarks/>
        Integer,

        /// <remarks/>
        Float,

        /// <remarks/>
        String,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum ParameterStateEnum
    {

        /// <remarks/>
        HasValidValue,

        /// <remarks/>
        MissingValidValue,

        /// <remarks/>
        HasOutstandingDependencies,

        /// <remarks/>
        DynamicValuesUnavailable,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExecutionInfo2))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ExecutionInfo
    {

        private bool hasSnapshotField;

        private bool needsProcessingField;

        private bool allowQueryExecutionField;

        private bool credentialsRequiredField;

        private bool parametersRequiredField;

        private System.DateTime expirationDateTimeField;

        private System.DateTime executionDateTimeField;

        private int numPagesField;

        private ReportParameter[] parametersField;

        private DataSourcePrompt[] dataSourcePromptsField;

        private bool hasDocumentMapField;

        private string executionIDField;

        private string reportPathField;

        private string historyIDField;

        private PageSettings reportPageSettingsField;

        private int autoRefreshIntervalField;

        /// <remarks/>
        public bool HasSnapshot
        {
            get
            {
                return this.hasSnapshotField;
            }
            set
            {
                this.hasSnapshotField = value;
            }
        }

        /// <remarks/>
        public bool NeedsProcessing
        {
            get
            {
                return this.needsProcessingField;
            }
            set
            {
                this.needsProcessingField = value;
            }
        }

        /// <remarks/>
        public bool AllowQueryExecution
        {
            get
            {
                return this.allowQueryExecutionField;
            }
            set
            {
                this.allowQueryExecutionField = value;
            }
        }

        /// <remarks/>
        public bool CredentialsRequired
        {
            get
            {
                return this.credentialsRequiredField;
            }
            set
            {
                this.credentialsRequiredField = value;
            }
        }

        /// <remarks/>
        public bool ParametersRequired
        {
            get
            {
                return this.parametersRequiredField;
            }
            set
            {
                this.parametersRequiredField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ExpirationDateTime
        {
            get
            {
                return this.expirationDateTimeField;
            }
            set
            {
                this.expirationDateTimeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ExecutionDateTime
        {
            get
            {
                return this.executionDateTimeField;
            }
            set
            {
                this.executionDateTimeField = value;
            }
        }

        /// <remarks/>
        public int NumPages
        {
            get
            {
                return this.numPagesField;
            }
            set
            {
                this.numPagesField = value;
            }
        }

        /// <remarks/>
        public ReportParameter[] Parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        public DataSourcePrompt[] DataSourcePrompts
        {
            get
            {
                return this.dataSourcePromptsField;
            }
            set
            {
                this.dataSourcePromptsField = value;
            }
        }

        /// <remarks/>
        public bool HasDocumentMap
        {
            get
            {
                return this.hasDocumentMapField;
            }
            set
            {
                this.hasDocumentMapField = value;
            }
        }

        /// <remarks/>
        public string ExecutionID
        {
            get
            {
                return this.executionIDField;
            }
            set
            {
                this.executionIDField = value;
            }
        }

        /// <remarks/>
        public string ReportPath
        {
            get
            {
                return this.reportPathField;
            }
            set
            {
                this.reportPathField = value;
            }
        }

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
        public PageSettings ReportPageSettings
        {
            get
            {
                return this.reportPageSettingsField;
            }
            set
            {
                this.reportPageSettingsField = value;
            }
        }

        /// <remarks/>
        public int AutoRefreshInterval
        {
            get
            {
                return this.autoRefreshIntervalField;
            }
            set
            {
                this.autoRefreshIntervalField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ExecutionInfo2 : ExecutionInfo
    {

        private PageCountMode pageCountModeField;

        /// <remarks/>
        public PageCountMode PageCountMode
        {
            get
            {
                return this.pageCountModeField;
            }
            set
            {
                this.pageCountModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum PageCountMode
    {

        /// <remarks/>
        Actual,

        /// <remarks/>
        Estimate,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", IsNullable = false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", IsNullable = false)]
    public partial class ServerInfoHeader : System.Web.Services.Protocols.SoapHeader
    {

        private string reportServerVersionNumberField;

        private string reportServerEditionField;

        private string reportServerVersionField;

        private string reportServerDateTimeField;

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum SortDirectionEnum
    {

        /// <remarks/>
        None,

        /// <remarks/>
        Ascending,

        /// <remarks/>
        Descending,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ListSecureMethodsCompletedEventHandler(object sender, ListSecureMethodsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListSecureMethodsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListSecureMethodsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void LoadReportCompletedEventHandler(object sender, LoadReportCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadReportCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal LoadReportCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ExecutionInfo Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExecutionInfo)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void LoadReport2CompletedEventHandler(object sender, LoadReport2CompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadReport2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal LoadReport2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ExecutionInfo2 Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExecutionInfo2)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void LoadReportDefinitionCompletedEventHandler(object sender, LoadReportDefinitionCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadReportDefinitionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal LoadReportDefinitionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ExecutionInfo Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExecutionInfo)(this.results[0]));
            }
        }

        /// <remarks/>
        public Warning[] warnings
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
    public delegate void LoadReportDefinition2CompletedEventHandler(object sender, LoadReportDefinition2CompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadReportDefinition2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal LoadReportDefinition2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ExecutionInfo2 Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExecutionInfo2)(this.results[0]));
            }
        }

        /// <remarks/>
        public Warning[] warnings
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
    public delegate void SetExecutionCredentialsCompletedEventHandler(object sender, SetExecutionCredentialsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetExecutionCredentialsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SetExecutionCredentialsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ExecutionInfo Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExecutionInfo)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetExecutionCredentials2CompletedEventHandler(object sender, SetExecutionCredentials2CompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetExecutionCredentials2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SetExecutionCredentials2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ExecutionInfo2 Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExecutionInfo2)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetExecutionParametersCompletedEventHandler(object sender, SetExecutionParametersCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetExecutionParametersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SetExecutionParametersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ExecutionInfo Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExecutionInfo)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SetExecutionParameters2CompletedEventHandler(object sender, SetExecutionParameters2CompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetExecutionParameters2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SetExecutionParameters2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ExecutionInfo2 Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExecutionInfo2)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ResetExecutionCompletedEventHandler(object sender, ResetExecutionCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ResetExecutionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ResetExecutionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ExecutionInfo Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExecutionInfo)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ResetExecution2CompletedEventHandler(object sender, ResetExecution2CompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ResetExecution2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ResetExecution2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ExecutionInfo2 Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExecutionInfo2)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void RenderCompletedEventHandler(object sender, RenderCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RenderCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal RenderCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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

        /// <remarks/>
        public string Extension
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }

        /// <remarks/>
        public string MimeType
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }

        /// <remarks/>
        public string Encoding
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[3]));
            }
        }

        /// <remarks/>
        public Warning[] Warnings
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Warning[])(this.results[4]));
            }
        }

        /// <remarks/>
        public string[] StreamIds
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[5]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void Render2CompletedEventHandler(object sender, Render2CompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Render2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal Render2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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

        /// <remarks/>
        public string Extension
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }

        /// <remarks/>
        public string MimeType
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }

        /// <remarks/>
        public string Encoding
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[3]));
            }
        }

        /// <remarks/>
        public Warning[] Warnings
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((Warning[])(this.results[4]));
            }
        }

        /// <remarks/>
        public string[] StreamIds
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[5]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void RenderStreamCompletedEventHandler(object sender, RenderStreamCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RenderStreamCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal RenderStreamCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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

        /// <remarks/>
        public string Encoding
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }

        /// <remarks/>
        public string MimeType
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetExecutionInfoCompletedEventHandler(object sender, GetExecutionInfoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetExecutionInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetExecutionInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ExecutionInfo Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExecutionInfo)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetExecutionInfo2CompletedEventHandler(object sender, GetExecutionInfo2CompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetExecutionInfo2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetExecutionInfo2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ExecutionInfo2 Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExecutionInfo2)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetDocumentMapCompletedEventHandler(object sender, GetDocumentMapCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDocumentMapCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetDocumentMapCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public DocumentMapNode Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((DocumentMapNode)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void LoadDrillthroughTargetCompletedEventHandler(object sender, LoadDrillthroughTargetCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadDrillthroughTargetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal LoadDrillthroughTargetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ExecutionInfo Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExecutionInfo)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void LoadDrillthroughTarget2CompletedEventHandler(object sender, LoadDrillthroughTarget2CompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadDrillthroughTarget2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal LoadDrillthroughTarget2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ExecutionInfo2 Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExecutionInfo2)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void ToggleItemCompletedEventHandler(object sender, ToggleItemCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ToggleItemCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ToggleItemCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void NavigateDocumentMapCompletedEventHandler(object sender, NavigateDocumentMapCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class NavigateDocumentMapCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal NavigateDocumentMapCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void NavigateBookmarkCompletedEventHandler(object sender, NavigateBookmarkCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class NavigateBookmarkCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal NavigateBookmarkCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
        public string UniqueName
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
    public delegate void FindStringCompletedEventHandler(object sender, FindStringCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal FindStringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SortCompletedEventHandler(object sender, SortCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SortCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SortCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
        public string ReportItem
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }

        /// <remarks/>
        public int NumPages
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
    public delegate void Sort2CompletedEventHandler(object sender, Sort2CompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Sort2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal Sort2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
        public string ReportItem
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }

        /// <remarks/>
        public ExecutionInfo2 ExecutionInfo
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ExecutionInfo2)(this.results[2]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void GetRenderResourceCompletedEventHandler(object sender, GetRenderResourceCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRenderResourceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetRenderResourceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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

        /// <remarks/>
        public string MimeType
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
    public delegate void ListRenderingExtensionsCompletedEventHandler(object sender, ListRenderingExtensionsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListRenderingExtensionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ListRenderingExtensionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
    public delegate void LogonUserCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void LogoffCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}