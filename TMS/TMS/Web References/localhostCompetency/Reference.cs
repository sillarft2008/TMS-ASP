﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace TMS.localhostCompetency {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CompetencyWebserviceSoapBinding", Namespace="http://webservice_layer")]
    public partial class CompetencyWebserviceService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getAllCompetenciesOperationCompleted;
        
        private System.Threading.SendOrPostCallback findCompetencyOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateCompetencyOperationCompleted;
        
        private System.Threading.SendOrPostCallback createCompetencyOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteCompetencyOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CompetencyWebserviceService() {
            this.Url = global::TMS.Properties.Settings.Default.TMS_localhostCompetency_CompetencyWebserviceService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getAllCompetenciesCompletedEventHandler getAllCompetenciesCompleted;
        
        /// <remarks/>
        public event findCompetencyCompletedEventHandler findCompetencyCompleted;
        
        /// <remarks/>
        public event updateCompetencyCompletedEventHandler updateCompetencyCompleted;
        
        /// <remarks/>
        public event createCompetencyCompletedEventHandler createCompetencyCompleted;
        
        /// <remarks/>
        public event deleteCompetencyCompletedEventHandler deleteCompetencyCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getAllCompetenciesReturn")]
        public Competency[] getAllCompetencies() {
            object[] results = this.Invoke("getAllCompetencies", new object[0]);
            return ((Competency[])(results[0]));
        }
        
        /// <remarks/>
        public void getAllCompetenciesAsync() {
            this.getAllCompetenciesAsync(null);
        }
        
        /// <remarks/>
        public void getAllCompetenciesAsync(object userState) {
            if ((this.getAllCompetenciesOperationCompleted == null)) {
                this.getAllCompetenciesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllCompetenciesOperationCompleted);
            }
            this.InvokeAsync("getAllCompetencies", new object[0], this.getAllCompetenciesOperationCompleted, userState);
        }
        
        private void OngetAllCompetenciesOperationCompleted(object arg) {
            if ((this.getAllCompetenciesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllCompetenciesCompleted(this, new getAllCompetenciesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("findCompetencyReturn")]
        public Competency findCompetency(int Id) {
            object[] results = this.Invoke("findCompetency", new object[] {
                        Id});
            return ((Competency)(results[0]));
        }
        
        /// <remarks/>
        public void findCompetencyAsync(int Id) {
            this.findCompetencyAsync(Id, null);
        }
        
        /// <remarks/>
        public void findCompetencyAsync(int Id, object userState) {
            if ((this.findCompetencyOperationCompleted == null)) {
                this.findCompetencyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindCompetencyOperationCompleted);
            }
            this.InvokeAsync("findCompetency", new object[] {
                        Id}, this.findCompetencyOperationCompleted, userState);
        }
        
        private void OnfindCompetencyOperationCompleted(object arg) {
            if ((this.findCompetencyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findCompetencyCompleted(this, new findCompetencyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("updateCompetencyReturn")]
        public string updateCompetency(Competency competency) {
            object[] results = this.Invoke("updateCompetency", new object[] {
                        competency});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void updateCompetencyAsync(Competency competency) {
            this.updateCompetencyAsync(competency, null);
        }
        
        /// <remarks/>
        public void updateCompetencyAsync(Competency competency, object userState) {
            if ((this.updateCompetencyOperationCompleted == null)) {
                this.updateCompetencyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateCompetencyOperationCompleted);
            }
            this.InvokeAsync("updateCompetency", new object[] {
                        competency}, this.updateCompetencyOperationCompleted, userState);
        }
        
        private void OnupdateCompetencyOperationCompleted(object arg) {
            if ((this.updateCompetencyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateCompetencyCompleted(this, new updateCompetencyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("createCompetencyReturn")]
        public string createCompetency(Competency competency) {
            object[] results = this.Invoke("createCompetency", new object[] {
                        competency});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void createCompetencyAsync(Competency competency) {
            this.createCompetencyAsync(competency, null);
        }
        
        /// <remarks/>
        public void createCompetencyAsync(Competency competency, object userState) {
            if ((this.createCompetencyOperationCompleted == null)) {
                this.createCompetencyOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateCompetencyOperationCompleted);
            }
            this.InvokeAsync("createCompetency", new object[] {
                        competency}, this.createCompetencyOperationCompleted, userState);
        }
        
        private void OncreateCompetencyOperationCompleted(object arg) {
            if ((this.createCompetencyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.createCompetencyCompleted(this, new createCompetencyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("deleteCompetencyReturn")]
        public string deleteCompetency(Competency competency) {
            object[] results = this.Invoke("deleteCompetency", new object[] {
                        competency});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void deleteCompetencyAsync(Competency competency) {
            this.deleteCompetencyAsync(competency, null);
        }
        
        /// <remarks/>
        public void deleteCompetencyAsync(Competency competency, object userState) {
            if ((this.deleteCompetencyOperationCompleted == null)) {
                this.deleteCompetencyOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteCompetencyOperationCompleted);
            }
            this.InvokeAsync("deleteCompetency", new object[] {
                        competency}, this.deleteCompetencyOperationCompleted, userState);
        }
        
        private void OndeleteCompetencyOperationCompleted(object arg) {
            if ((this.deleteCompetencyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteCompetencyCompleted(this, new deleteCompetencyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice_layer")]
    public partial class Competency {
        
        private string competencyField;
        
        private int idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string competency {
            get {
                return this.competencyField;
            }
            set {
                this.competencyField = value;
            }
        }
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void getAllCompetenciesCompletedEventHandler(object sender, getAllCompetenciesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllCompetenciesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllCompetenciesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Competency[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Competency[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void findCompetencyCompletedEventHandler(object sender, findCompetencyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findCompetencyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findCompetencyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Competency Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Competency)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void updateCompetencyCompletedEventHandler(object sender, updateCompetencyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updateCompetencyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal updateCompetencyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void createCompetencyCompletedEventHandler(object sender, createCompetencyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class createCompetencyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal createCompetencyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void deleteCompetencyCompletedEventHandler(object sender, deleteCompetencyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteCompetencyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteCompetencyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591