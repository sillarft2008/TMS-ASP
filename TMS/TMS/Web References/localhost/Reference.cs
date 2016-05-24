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

namespace TMS.localhost {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="CustomerWebserviceSoapBinding", Namespace="http://webservice_layer")]
    public partial class CustomerWebserviceService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback findCustomerOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateCustomerOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteCustomerOperationCompleted;
        
        private System.Threading.SendOrPostCallback createCustomerOperationCompleted;
        
        private System.Threading.SendOrPostCallback findCustomerArrayOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CustomerWebserviceService() {
            this.Url = global::TMS.Properties.Settings.Default.TMS_localhost_CustomerWebserviceService;
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
        public event findCustomerCompletedEventHandler findCustomerCompleted;
        
        /// <remarks/>
        public event updateCustomerCompletedEventHandler updateCustomerCompleted;
        
        /// <remarks/>
        public event deleteCustomerCompletedEventHandler deleteCustomerCompleted;
        
        /// <remarks/>
        public event createCustomerCompletedEventHandler createCustomerCompleted;
        
        /// <remarks/>
        public event findCustomerArrayCompletedEventHandler findCustomerArrayCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("findCustomerReturn")]
        public Customer findCustomer(int customerNo) {
            object[] results = this.Invoke("findCustomer", new object[] {
                        customerNo});
            return ((Customer)(results[0]));
        }
        
        /// <remarks/>
        public void findCustomerAsync(int customerNo) {
            this.findCustomerAsync(customerNo, null);
        }
        
        /// <remarks/>
        public void findCustomerAsync(int customerNo, object userState) {
            if ((this.findCustomerOperationCompleted == null)) {
                this.findCustomerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindCustomerOperationCompleted);
            }
            this.InvokeAsync("findCustomer", new object[] {
                        customerNo}, this.findCustomerOperationCompleted, userState);
        }
        
        private void OnfindCustomerOperationCompleted(object arg) {
            if ((this.findCustomerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findCustomerCompleted(this, new findCustomerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("updateCustomerReturn")]
        public string updateCustomer(Customer cust) {
            object[] results = this.Invoke("updateCustomer", new object[] {
                        cust});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void updateCustomerAsync(Customer cust) {
            this.updateCustomerAsync(cust, null);
        }
        
        /// <remarks/>
        public void updateCustomerAsync(Customer cust, object userState) {
            if ((this.updateCustomerOperationCompleted == null)) {
                this.updateCustomerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateCustomerOperationCompleted);
            }
            this.InvokeAsync("updateCustomer", new object[] {
                        cust}, this.updateCustomerOperationCompleted, userState);
        }
        
        private void OnupdateCustomerOperationCompleted(object arg) {
            if ((this.updateCustomerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateCustomerCompleted(this, new updateCustomerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("deleteCustomerReturn")]
        public string deleteCustomer(Customer cust) {
            object[] results = this.Invoke("deleteCustomer", new object[] {
                        cust});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void deleteCustomerAsync(Customer cust) {
            this.deleteCustomerAsync(cust, null);
        }
        
        /// <remarks/>
        public void deleteCustomerAsync(Customer cust, object userState) {
            if ((this.deleteCustomerOperationCompleted == null)) {
                this.deleteCustomerOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteCustomerOperationCompleted);
            }
            this.InvokeAsync("deleteCustomer", new object[] {
                        cust}, this.deleteCustomerOperationCompleted, userState);
        }
        
        private void OndeleteCustomerOperationCompleted(object arg) {
            if ((this.deleteCustomerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteCustomerCompleted(this, new deleteCustomerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("createCustomerReturn")]
        public string createCustomer(Customer cust) {
            object[] results = this.Invoke("createCustomer", new object[] {
                        cust});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void createCustomerAsync(Customer cust) {
            this.createCustomerAsync(cust, null);
        }
        
        /// <remarks/>
        public void createCustomerAsync(Customer cust, object userState) {
            if ((this.createCustomerOperationCompleted == null)) {
                this.createCustomerOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateCustomerOperationCompleted);
            }
            this.InvokeAsync("createCustomer", new object[] {
                        cust}, this.createCustomerOperationCompleted, userState);
        }
        
        private void OncreateCustomerOperationCompleted(object arg) {
            if ((this.createCustomerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.createCustomerCompleted(this, new createCustomerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("findCustomerArrayReturn")]
        public Customer[] findCustomerArray() {
            object[] results = this.Invoke("findCustomerArray", new object[0]);
            return ((Customer[])(results[0]));
        }
        
        /// <remarks/>
        public void findCustomerArrayAsync() {
            this.findCustomerArrayAsync(null);
        }
        
        /// <remarks/>
        public void findCustomerArrayAsync(object userState) {
            if ((this.findCustomerArrayOperationCompleted == null)) {
                this.findCustomerArrayOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindCustomerArrayOperationCompleted);
            }
            this.InvokeAsync("findCustomerArray", new object[0], this.findCustomerArrayOperationCompleted, userState);
        }
        
        private void OnfindCustomerArrayOperationCompleted(object arg) {
            if ((this.findCustomerArrayCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findCustomerArrayCompleted(this, new findCustomerArrayCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void findCustomerCompletedEventHandler(object sender, findCustomerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findCustomerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findCustomerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Customer Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Customer)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void updateCustomerCompletedEventHandler(object sender, updateCustomerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updateCustomerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal updateCustomerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void deleteCustomerCompletedEventHandler(object sender, deleteCustomerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteCustomerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteCustomerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void createCustomerCompletedEventHandler(object sender, createCustomerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class createCustomerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal createCustomerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void findCustomerArrayCompletedEventHandler(object sender, findCustomerArrayCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findCustomerArrayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findCustomerArrayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Customer[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Customer[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591