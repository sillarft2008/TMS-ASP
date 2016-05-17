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

namespace TMS.jobWS {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="JobWebserviceSoapBinding", Namespace="http://webservice_layer")]
    public partial class JobWebserviceService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback createJobOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateJobOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteJobOperationCompleted;
        
        private System.Threading.SendOrPostCallback addCompetencyOperationCompleted;
        
        private System.Threading.SendOrPostCallback findJobArrayOperationCompleted;
        
        private System.Threading.SendOrPostCallback findJobOperationCompleted;
        
        private System.Threading.SendOrPostCallback findCustomerJobArrayOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public JobWebserviceService() {
            this.Url = global::TMS.Properties.Settings.Default.TMS_jobWS_JobWebserviceService;
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
        public event createJobCompletedEventHandler createJobCompleted;
        
        /// <remarks/>
        public event updateJobCompletedEventHandler updateJobCompleted;
        
        /// <remarks/>
        public event deleteJobCompletedEventHandler deleteJobCompleted;
        
        /// <remarks/>
        public event addCompetencyCompletedEventHandler addCompetencyCompleted;
        
        /// <remarks/>
        public event findJobArrayCompletedEventHandler findJobArrayCompleted;
        
        /// <remarks/>
        public event findJobCompletedEventHandler findJobCompleted;
        
        /// <remarks/>
        public event findCustomerJobArrayCompletedEventHandler findCustomerJobArrayCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void createJob(Job job) {
            this.Invoke("createJob", new object[] {
                        job});
        }
        
        /// <remarks/>
        public void createJobAsync(Job job) {
            this.createJobAsync(job, null);
        }
        
        /// <remarks/>
        public void createJobAsync(Job job, object userState) {
            if ((this.createJobOperationCompleted == null)) {
                this.createJobOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateJobOperationCompleted);
            }
            this.InvokeAsync("createJob", new object[] {
                        job}, this.createJobOperationCompleted, userState);
        }
        
        private void OncreateJobOperationCompleted(object arg) {
            if ((this.createJobCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.createJobCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("updateJobReturn")]
        public string updateJob(Job job) {
            object[] results = this.Invoke("updateJob", new object[] {
                        job});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void updateJobAsync(Job job) {
            this.updateJobAsync(job, null);
        }
        
        /// <remarks/>
        public void updateJobAsync(Job job, object userState) {
            if ((this.updateJobOperationCompleted == null)) {
                this.updateJobOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateJobOperationCompleted);
            }
            this.InvokeAsync("updateJob", new object[] {
                        job}, this.updateJobOperationCompleted, userState);
        }
        
        private void OnupdateJobOperationCompleted(object arg) {
            if ((this.updateJobCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateJobCompleted(this, new updateJobCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("deleteJobReturn")]
        public string deleteJob(Job job) {
            object[] results = this.Invoke("deleteJob", new object[] {
                        job});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void deleteJobAsync(Job job) {
            this.deleteJobAsync(job, null);
        }
        
        /// <remarks/>
        public void deleteJobAsync(Job job, object userState) {
            if ((this.deleteJobOperationCompleted == null)) {
                this.deleteJobOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteJobOperationCompleted);
            }
            this.InvokeAsync("deleteJob", new object[] {
                        job}, this.deleteJobOperationCompleted, userState);
        }
        
        private void OndeleteJobOperationCompleted(object arg) {
            if ((this.deleteJobCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteJobCompleted(this, new deleteJobCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void addCompetency(Job job, Competency competency) {
            this.Invoke("addCompetency", new object[] {
                        job,
                        competency});
        }
        
        /// <remarks/>
        public void addCompetencyAsync(Job job, Competency competency) {
            this.addCompetencyAsync(job, competency, null);
        }
        
        /// <remarks/>
        public void addCompetencyAsync(Job job, Competency competency, object userState) {
            if ((this.addCompetencyOperationCompleted == null)) {
                this.addCompetencyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddCompetencyOperationCompleted);
            }
            this.InvokeAsync("addCompetency", new object[] {
                        job,
                        competency}, this.addCompetencyOperationCompleted, userState);
        }
        
        private void OnaddCompetencyOperationCompleted(object arg) {
            if ((this.addCompetencyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addCompetencyCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("findJobArrayReturn")]
        public Job[] findJobArray() {
            object[] results = this.Invoke("findJobArray", new object[0]);
            return ((Job[])(results[0]));
        }
        
        /// <remarks/>
        public void findJobArrayAsync() {
            this.findJobArrayAsync(null);
        }
        
        /// <remarks/>
        public void findJobArrayAsync(object userState) {
            if ((this.findJobArrayOperationCompleted == null)) {
                this.findJobArrayOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindJobArrayOperationCompleted);
            }
            this.InvokeAsync("findJobArray", new object[0], this.findJobArrayOperationCompleted, userState);
        }
        
        private void OnfindJobArrayOperationCompleted(object arg) {
            if ((this.findJobArrayCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findJobArrayCompleted(this, new findJobArrayCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("findJobReturn")]
        public Job findJob(int jobId) {
            object[] results = this.Invoke("findJob", new object[] {
                        jobId});
            return ((Job)(results[0]));
        }
        
        /// <remarks/>
        public void findJobAsync(int jobId) {
            this.findJobAsync(jobId, null);
        }
        
        /// <remarks/>
        public void findJobAsync(int jobId, object userState) {
            if ((this.findJobOperationCompleted == null)) {
                this.findJobOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindJobOperationCompleted);
            }
            this.InvokeAsync("findJob", new object[] {
                        jobId}, this.findJobOperationCompleted, userState);
        }
        
        private void OnfindJobOperationCompleted(object arg) {
            if ((this.findJobCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findJobCompleted(this, new findJobCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("findCustomerJobArrayReturn")]
        public Job[] findCustomerJobArray(int customerId) {
            object[] results = this.Invoke("findCustomerJobArray", new object[] {
                        customerId});
            return ((Job[])(results[0]));
        }
        
        /// <remarks/>
        public void findCustomerJobArrayAsync(int customerId) {
            this.findCustomerJobArrayAsync(customerId, null);
        }
        
        /// <remarks/>
        public void findCustomerJobArrayAsync(int customerId, object userState) {
            if ((this.findCustomerJobArrayOperationCompleted == null)) {
                this.findCustomerJobArrayOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindCustomerJobArrayOperationCompleted);
            }
            this.InvokeAsync("findCustomerJobArray", new object[] {
                        customerId}, this.findCustomerJobArrayOperationCompleted, userState);
        }
        
        private void OnfindCustomerJobArrayOperationCompleted(object arg) {
            if ((this.findCustomerJobArrayCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findCustomerJobArrayCompleted(this, new findCustomerJobArrayCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class Job {
        
        private string addressField;
        
        private Customer customerField;
        
        private System.Nullable<System.DateTime> endDateField;
        
        private int idField;
        
        private System.Nullable<System.DateTime> startDateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Customer customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice_layer")]
    public partial class Customer {
        
        private string addressField;
        
        private string companyNameField;
        
        private int cvrField;
        
        private string firstNameField;
        
        private int idField;
        
        private string lastNameField;
        
        private string telefoneField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string companyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        public int cvr {
            get {
                return this.cvrField;
            }
            set {
                this.cvrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string telefone {
            get {
                return this.telefoneField;
            }
            set {
                this.telefoneField = value;
            }
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
    public delegate void createJobCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void updateJobCompletedEventHandler(object sender, updateJobCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updateJobCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal updateJobCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void deleteJobCompletedEventHandler(object sender, deleteJobCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteJobCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteJobCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void addCompetencyCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void findJobArrayCompletedEventHandler(object sender, findJobArrayCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findJobArrayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findJobArrayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Job[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Job[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void findJobCompletedEventHandler(object sender, findJobCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findJobCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findJobCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Job Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Job)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void findCustomerJobArrayCompletedEventHandler(object sender, findCustomerJobArrayCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findCustomerJobArrayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findCustomerJobArrayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Job[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Job[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591