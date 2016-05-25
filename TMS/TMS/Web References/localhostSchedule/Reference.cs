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

namespace TMS.localhostSchedule {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ScheduleWebserviceSoapBinding", Namespace="http://webservice_layer")]
    public partial class ScheduleWebserviceService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback createScheduleOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteScheduleOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateScheduleOperationCompleted;
        
        private System.Threading.SendOrPostCallback findScheduleOperationCompleted;
        
        private System.Threading.SendOrPostCallback findScheduleArrayOperationCompleted;
        
        private System.Threading.SendOrPostCallback findScheduleArrayByEmployeeDateOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ScheduleWebserviceService() {
            this.Url = global::TMS.Properties.Settings.Default.TMS_localhostSchedule_ScheduleWebserviceService;
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
        public event createScheduleCompletedEventHandler createScheduleCompleted;
        
        /// <remarks/>
        public event deleteScheduleCompletedEventHandler deleteScheduleCompleted;
        
        /// <remarks/>
        public event updateScheduleCompletedEventHandler updateScheduleCompleted;
        
        /// <remarks/>
        public event findScheduleCompletedEventHandler findScheduleCompleted;
        
        /// <remarks/>
        public event findScheduleArrayCompletedEventHandler findScheduleArrayCompleted;
        
        /// <remarks/>
        public event findScheduleArrayByEmployeeDateCompletedEventHandler findScheduleArrayByEmployeeDateCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void createSchedule(Schedule schedule) {
            this.Invoke("createSchedule", new object[] {
                        schedule});
        }
        
        /// <remarks/>
        public void createScheduleAsync(Schedule schedule) {
            this.createScheduleAsync(schedule, null);
        }
        
        /// <remarks/>
        public void createScheduleAsync(Schedule schedule, object userState) {
            if ((this.createScheduleOperationCompleted == null)) {
                this.createScheduleOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateScheduleOperationCompleted);
            }
            this.InvokeAsync("createSchedule", new object[] {
                        schedule}, this.createScheduleOperationCompleted, userState);
        }
        
        private void OncreateScheduleOperationCompleted(object arg) {
            if ((this.createScheduleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.createScheduleCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("deleteScheduleReturn")]
        public string deleteSchedule(Schedule schedule) {
            object[] results = this.Invoke("deleteSchedule", new object[] {
                        schedule});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void deleteScheduleAsync(Schedule schedule) {
            this.deleteScheduleAsync(schedule, null);
        }
        
        /// <remarks/>
        public void deleteScheduleAsync(Schedule schedule, object userState) {
            if ((this.deleteScheduleOperationCompleted == null)) {
                this.deleteScheduleOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteScheduleOperationCompleted);
            }
            this.InvokeAsync("deleteSchedule", new object[] {
                        schedule}, this.deleteScheduleOperationCompleted, userState);
        }
        
        private void OndeleteScheduleOperationCompleted(object arg) {
            if ((this.deleteScheduleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteScheduleCompleted(this, new deleteScheduleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("updateScheduleReturn")]
        public string updateSchedule(Schedule schedule) {
            object[] results = this.Invoke("updateSchedule", new object[] {
                        schedule});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void updateScheduleAsync(Schedule schedule) {
            this.updateScheduleAsync(schedule, null);
        }
        
        /// <remarks/>
        public void updateScheduleAsync(Schedule schedule, object userState) {
            if ((this.updateScheduleOperationCompleted == null)) {
                this.updateScheduleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateScheduleOperationCompleted);
            }
            this.InvokeAsync("updateSchedule", new object[] {
                        schedule}, this.updateScheduleOperationCompleted, userState);
        }
        
        private void OnupdateScheduleOperationCompleted(object arg) {
            if ((this.updateScheduleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateScheduleCompleted(this, new updateScheduleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("findScheduleReturn")]
        public Schedule findSchedule(int scheduleId) {
            object[] results = this.Invoke("findSchedule", new object[] {
                        scheduleId});
            return ((Schedule)(results[0]));
        }
        
        /// <remarks/>
        public void findScheduleAsync(int scheduleId) {
            this.findScheduleAsync(scheduleId, null);
        }
        
        /// <remarks/>
        public void findScheduleAsync(int scheduleId, object userState) {
            if ((this.findScheduleOperationCompleted == null)) {
                this.findScheduleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindScheduleOperationCompleted);
            }
            this.InvokeAsync("findSchedule", new object[] {
                        scheduleId}, this.findScheduleOperationCompleted, userState);
        }
        
        private void OnfindScheduleOperationCompleted(object arg) {
            if ((this.findScheduleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findScheduleCompleted(this, new findScheduleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("findScheduleArrayReturn")]
        public Schedule[] findScheduleArray() {
            object[] results = this.Invoke("findScheduleArray", new object[0]);
            return ((Schedule[])(results[0]));
        }
        
        /// <remarks/>
        public void findScheduleArrayAsync() {
            this.findScheduleArrayAsync(null);
        }
        
        /// <remarks/>
        public void findScheduleArrayAsync(object userState) {
            if ((this.findScheduleArrayOperationCompleted == null)) {
                this.findScheduleArrayOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindScheduleArrayOperationCompleted);
            }
            this.InvokeAsync("findScheduleArray", new object[0], this.findScheduleArrayOperationCompleted, userState);
        }
        
        private void OnfindScheduleArrayOperationCompleted(object arg) {
            if ((this.findScheduleArrayCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findScheduleArrayCompleted(this, new findScheduleArrayCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("findScheduleArrayByEmployeeDateReturn")]
        public Schedule[] findScheduleArrayByEmployeeDate(int employeeId, System.DateTime startTimeDate) {
            object[] results = this.Invoke("findScheduleArrayByEmployeeDate", new object[] {
                        employeeId,
                        startTimeDate});
            return ((Schedule[])(results[0]));
        }
        
        /// <remarks/>
        public void findScheduleArrayByEmployeeDateAsync(int employeeId, System.DateTime startTimeDate) {
            this.findScheduleArrayByEmployeeDateAsync(employeeId, startTimeDate, null);
        }
        
        /// <remarks/>
        public void findScheduleArrayByEmployeeDateAsync(int employeeId, System.DateTime startTimeDate, object userState) {
            if ((this.findScheduleArrayByEmployeeDateOperationCompleted == null)) {
                this.findScheduleArrayByEmployeeDateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindScheduleArrayByEmployeeDateOperationCompleted);
            }
            this.InvokeAsync("findScheduleArrayByEmployeeDate", new object[] {
                        employeeId,
                        startTimeDate}, this.findScheduleArrayByEmployeeDateOperationCompleted, userState);
        }
        
        private void OnfindScheduleArrayByEmployeeDateOperationCompleted(object arg) {
            if ((this.findScheduleArrayByEmployeeDateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findScheduleArrayByEmployeeDateCompleted(this, new findScheduleArrayByEmployeeDateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class Schedule {
        
        private Competency competencyField;
        
        private System.Nullable<System.DateTime> durationField;
        
        private Employee employeeField;
        
        private int idField;
        
        private Item itemField;
        
        private Job jobField;
        
        private System.Nullable<System.DateTime> startTimeDateField;
        
        private string startTimeDateStringField;
        
        private string startTimeStringField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Competency competency {
            get {
                return this.competencyField;
            }
            set {
                this.competencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> duration {
            get {
                return this.durationField;
            }
            set {
                this.durationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Employee employee {
            get {
                return this.employeeField;
            }
            set {
                this.employeeField = value;
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
        public Item item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Job job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> startTimeDate {
            get {
                return this.startTimeDateField;
            }
            set {
                this.startTimeDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string startTimeDateString {
            get {
                return this.startTimeDateStringField;
            }
            set {
                this.startTimeDateStringField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string startTimeString {
            get {
                return this.startTimeStringField;
            }
            set {
                this.startTimeStringField = value;
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
    public partial class Job {
        
        private string addressField;
        
        private Competency[] arrayOFCompetencyField;
        
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
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Competency[] arrayOFCompetency {
            get {
                return this.arrayOFCompetencyField;
            }
            set {
                this.arrayOFCompetencyField = value;
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
    public partial class Product {
        
        private int idField;
        
        private string productField;
        
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
        public string product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice_layer")]
    public partial class Item {
        
        private int idField;
        
        private Product productField;
        
        private string qantityField;
        
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
        public Product product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string qantity {
            get {
                return this.qantityField;
            }
            set {
                this.qantityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice_layer")]
    public partial class Employee {
        
        private string addressField;
        
        private string birthdateField;
        
        private string emailField;
        
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
        public string birthdate {
            get {
                return this.birthdateField;
            }
            set {
                this.birthdateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void createScheduleCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void deleteScheduleCompletedEventHandler(object sender, deleteScheduleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteScheduleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteScheduleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void updateScheduleCompletedEventHandler(object sender, updateScheduleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updateScheduleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal updateScheduleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void findScheduleCompletedEventHandler(object sender, findScheduleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findScheduleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findScheduleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Schedule Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Schedule)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void findScheduleArrayCompletedEventHandler(object sender, findScheduleArrayCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findScheduleArrayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findScheduleArrayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Schedule[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Schedule[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void findScheduleArrayByEmployeeDateCompletedEventHandler(object sender, findScheduleArrayByEmployeeDateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findScheduleArrayByEmployeeDateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findScheduleArrayByEmployeeDateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Schedule[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Schedule[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591