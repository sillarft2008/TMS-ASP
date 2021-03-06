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

namespace TMS.localhostUser {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="UserWebserviceSoapBinding", Namespace="http://webservice_layer")]
    public partial class UserWebserviceService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback deleteUserRolesOperationCompleted;
        
        private System.Threading.SendOrPostCallback createUserRoleOperationCompleted;
        
        private System.Threading.SendOrPostCallback addRoleOperationCompleted;
        
        private System.Threading.SendOrPostCallback createUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback findRoleByUserIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAllRolesOperationCompleted;
        
        private System.Threading.SendOrPostCallback findUserArrayOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback selectUserByNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback selectUserByIdOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;

        protected override System.Net.WebRequest GetWebRequest(Uri uri)
        {
            System.Net.WebRequest request = base.GetWebRequest(uri) as System.Net.HttpWebRequest;
            if (request is System.Net.HttpWebRequest)
            {
                ((System.Net.HttpWebRequest)request).ProtocolVersion = System.Net.HttpVersion.Version10;
            }
            return request;
        }

        /// <remarks/>
        public UserWebserviceService() {
            this.Url = global::TMS.Properties.Settings.Default.TMS_localhostUser_UserWebserviceService;
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
        public event deleteUserRolesCompletedEventHandler deleteUserRolesCompleted;
        
        /// <remarks/>
        public event createUserRoleCompletedEventHandler createUserRoleCompleted;
        
        /// <remarks/>
        public event addRoleCompletedEventHandler addRoleCompleted;
        
        /// <remarks/>
        public event createUserCompletedEventHandler createUserCompleted;
        
        /// <remarks/>
        public event findRoleByUserIdCompletedEventHandler findRoleByUserIdCompleted;
        
        /// <remarks/>
        public event getAllRolesCompletedEventHandler getAllRolesCompleted;
        
        /// <remarks/>
        public event findUserArrayCompletedEventHandler findUserArrayCompleted;
        
        /// <remarks/>
        public event deleteUserCompletedEventHandler deleteUserCompleted;
        
        /// <remarks/>
        public event updateUserCompletedEventHandler updateUserCompleted;
        
        /// <remarks/>
        public event selectUserByNameCompletedEventHandler selectUserByNameCompleted;
        
        /// <remarks/>
        public event selectUserByIdCompletedEventHandler selectUserByIdCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("deleteUserRolesReturn")]
        public string deleteUserRoles(string userId) {
            object[] results = this.Invoke("deleteUserRoles", new object[] {
                        userId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void deleteUserRolesAsync(string userId) {
            this.deleteUserRolesAsync(userId, null);
        }
        
        /// <remarks/>
        public void deleteUserRolesAsync(string userId, object userState) {
            if ((this.deleteUserRolesOperationCompleted == null)) {
                this.deleteUserRolesOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteUserRolesOperationCompleted);
            }
            this.InvokeAsync("deleteUserRoles", new object[] {
                        userId}, this.deleteUserRolesOperationCompleted, userState);
        }
        
        private void OndeleteUserRolesOperationCompleted(object arg) {
            if ((this.deleteUserRolesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteUserRolesCompleted(this, new deleteUserRolesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("createUserRoleReturn")]
        public string createUserRole(UserRole ur) {
            object[] results = this.Invoke("createUserRole", new object[] {
                        ur});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void createUserRoleAsync(UserRole ur) {
            this.createUserRoleAsync(ur, null);
        }
        
        /// <remarks/>
        public void createUserRoleAsync(UserRole ur, object userState) {
            if ((this.createUserRoleOperationCompleted == null)) {
                this.createUserRoleOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateUserRoleOperationCompleted);
            }
            this.InvokeAsync("createUserRole", new object[] {
                        ur}, this.createUserRoleOperationCompleted, userState);
        }
        
        private void OncreateUserRoleOperationCompleted(object arg) {
            if ((this.createUserRoleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.createUserRoleCompleted(this, new createUserRoleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void addRole(UserRole ur) {
            this.Invoke("addRole", new object[] {
                        ur});
        }
        
        /// <remarks/>
        public void addRoleAsync(UserRole ur) {
            this.addRoleAsync(ur, null);
        }
        
        /// <remarks/>
        public void addRoleAsync(UserRole ur, object userState) {
            if ((this.addRoleOperationCompleted == null)) {
                this.addRoleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddRoleOperationCompleted);
            }
            this.InvokeAsync("addRole", new object[] {
                        ur}, this.addRoleOperationCompleted, userState);
        }
        
        private void OnaddRoleOperationCompleted(object arg) {
            if ((this.addRoleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addRoleCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("createUserReturn")]
        public string createUser(User user) {
            object[] results = this.Invoke("createUser", new object[] {
                        user});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void createUserAsync(User user) {
            this.createUserAsync(user, null);
        }
        
        /// <remarks/>
        public void createUserAsync(User user, object userState) {
            if ((this.createUserOperationCompleted == null)) {
                this.createUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateUserOperationCompleted);
            }
            this.InvokeAsync("createUser", new object[] {
                        user}, this.createUserOperationCompleted, userState);
        }
        
        private void OncreateUserOperationCompleted(object arg) {
            if ((this.createUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.createUserCompleted(this, new createUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("findRoleByUserIdReturn")]
        public Role[] findRoleByUserId(string userId) {
            object[] results = this.Invoke("findRoleByUserId", new object[] {
                        userId});
            return ((Role[])(results[0]));
        }
        
        /// <remarks/>
        public void findRoleByUserIdAsync(string userId) {
            this.findRoleByUserIdAsync(userId, null);
        }
        
        /// <remarks/>
        public void findRoleByUserIdAsync(string userId, object userState) {
            if ((this.findRoleByUserIdOperationCompleted == null)) {
                this.findRoleByUserIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindRoleByUserIdOperationCompleted);
            }
            this.InvokeAsync("findRoleByUserId", new object[] {
                        userId}, this.findRoleByUserIdOperationCompleted, userState);
        }
        
        private void OnfindRoleByUserIdOperationCompleted(object arg) {
            if ((this.findRoleByUserIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findRoleByUserIdCompleted(this, new findRoleByUserIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getAllRolesReturn")]
        public Role[] getAllRoles() {
            object[] results = this.Invoke("getAllRoles", new object[0]);
            return ((Role[])(results[0]));
        }
        
        /// <remarks/>
        public void getAllRolesAsync() {
            this.getAllRolesAsync(null);
        }
        
        /// <remarks/>
        public void getAllRolesAsync(object userState) {
            if ((this.getAllRolesOperationCompleted == null)) {
                this.getAllRolesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllRolesOperationCompleted);
            }
            this.InvokeAsync("getAllRoles", new object[0], this.getAllRolesOperationCompleted, userState);
        }
        
        private void OngetAllRolesOperationCompleted(object arg) {
            if ((this.getAllRolesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllRolesCompleted(this, new getAllRolesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("findUserArrayReturn")]
        public User[] findUserArray() {
            object[] results = this.Invoke("findUserArray", new object[0]);
            return ((User[])(results[0]));
        }
        
        /// <remarks/>
        public void findUserArrayAsync() {
            this.findUserArrayAsync(null);
        }
        
        /// <remarks/>
        public void findUserArrayAsync(object userState) {
            if ((this.findUserArrayOperationCompleted == null)) {
                this.findUserArrayOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindUserArrayOperationCompleted);
            }
            this.InvokeAsync("findUserArray", new object[0], this.findUserArrayOperationCompleted, userState);
        }
        
        private void OnfindUserArrayOperationCompleted(object arg) {
            if ((this.findUserArrayCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findUserArrayCompleted(this, new findUserArrayCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("deleteUserReturn")]
        public string deleteUser(string id) {
            object[] results = this.Invoke("deleteUser", new object[] {
                        id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void deleteUserAsync(string id) {
            this.deleteUserAsync(id, null);
        }
        
        /// <remarks/>
        public void deleteUserAsync(string id, object userState) {
            if ((this.deleteUserOperationCompleted == null)) {
                this.deleteUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteUserOperationCompleted);
            }
            this.InvokeAsync("deleteUser", new object[] {
                        id}, this.deleteUserOperationCompleted, userState);
        }
        
        private void OndeleteUserOperationCompleted(object arg) {
            if ((this.deleteUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteUserCompleted(this, new deleteUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("updateUserReturn")]
        public string updateUser(User user) {
            object[] results = this.Invoke("updateUser", new object[] {
                        user});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void updateUserAsync(User user) {
            this.updateUserAsync(user, null);
        }
        
        /// <remarks/>
        public void updateUserAsync(User user, object userState) {
            if ((this.updateUserOperationCompleted == null)) {
                this.updateUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateUserOperationCompleted);
            }
            this.InvokeAsync("updateUser", new object[] {
                        user}, this.updateUserOperationCompleted, userState);
        }
        
        private void OnupdateUserOperationCompleted(object arg) {
            if ((this.updateUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateUserCompleted(this, new updateUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("selectUserByNameReturn")]
        public User selectUserByName(string name) {
            object[] results = this.Invoke("selectUserByName", new object[] {
                        name});
            return ((User)(results[0]));
        }
        
        /// <remarks/>
        public void selectUserByNameAsync(string name) {
            this.selectUserByNameAsync(name, null);
        }
        
        /// <remarks/>
        public void selectUserByNameAsync(string name, object userState) {
            if ((this.selectUserByNameOperationCompleted == null)) {
                this.selectUserByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnselectUserByNameOperationCompleted);
            }
            this.InvokeAsync("selectUserByName", new object[] {
                        name}, this.selectUserByNameOperationCompleted, userState);
        }
        
        private void OnselectUserByNameOperationCompleted(object arg) {
            if ((this.selectUserByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.selectUserByNameCompleted(this, new selectUserByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("selectUserByIdReturn")]
        public User selectUserById(string id) {
            object[] results = this.Invoke("selectUserById", new object[] {
                        id});
            return ((User)(results[0]));
        }
        
        /// <remarks/>
        public void selectUserByIdAsync(string id) {
            this.selectUserByIdAsync(id, null);
        }
        
        /// <remarks/>
        public void selectUserByIdAsync(string id, object userState) {
            if ((this.selectUserByIdOperationCompleted == null)) {
                this.selectUserByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnselectUserByIdOperationCompleted);
            }
            this.InvokeAsync("selectUserById", new object[] {
                        id}, this.selectUserByIdOperationCompleted, userState);
        }
        
        private void OnselectUserByIdOperationCompleted(object arg) {
            if ((this.selectUserByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.selectUserByIdCompleted(this, new selectUserByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class UserRole {
        
        private string roleIdField;
        
        private string userIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string roleId {
            get {
                return this.roleIdField;
            }
            set {
                this.roleIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string userId {
            get {
                return this.userIdField;
            }
            set {
                this.userIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice_layer")]
    public partial class Role {
        
        private string idField;
        
        private string role_nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string role_name {
            get {
                return this.role_nameField;
            }
            set {
                this.role_nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice_layer")]
    public partial class User {
        
        private string idField;
        
        private string passwordField;
        
        private string securityStampField;
        
        private string usernameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string securityStamp {
            get {
                return this.securityStampField;
            }
            set {
                this.securityStampField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void deleteUserRolesCompletedEventHandler(object sender, deleteUserRolesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteUserRolesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteUserRolesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void createUserRoleCompletedEventHandler(object sender, createUserRoleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class createUserRoleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal createUserRoleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void addRoleCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void createUserCompletedEventHandler(object sender, createUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class createUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal createUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void findRoleByUserIdCompletedEventHandler(object sender, findRoleByUserIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findRoleByUserIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findRoleByUserIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Role[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Role[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void getAllRolesCompletedEventHandler(object sender, getAllRolesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllRolesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllRolesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Role[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Role[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void findUserArrayCompletedEventHandler(object sender, findUserArrayCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findUserArrayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findUserArrayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public User[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((User[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void deleteUserCompletedEventHandler(object sender, deleteUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void updateUserCompletedEventHandler(object sender, updateUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updateUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal updateUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void selectUserByNameCompletedEventHandler(object sender, selectUserByNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class selectUserByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal selectUserByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public User Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((User)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void selectUserByIdCompletedEventHandler(object sender, selectUserByIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class selectUserByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal selectUserByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public User Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((User)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591