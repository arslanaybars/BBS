﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestConsole.BbsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/BBS.Domain")]
    [System.SerializableAttribute()]
    public partial class User : TestConsole.BbsService.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GenderIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RoleIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GenderId {
            get {
                return this.GenderIdField;
            }
            set {
                if ((this.GenderIdField.Equals(value) != true)) {
                    this.GenderIdField = value;
                    this.RaisePropertyChanged("GenderId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RoleId {
            get {
                return this.RoleIdField;
            }
            set {
                if ((this.RoleIdField.Equals(value) != true)) {
                    this.RoleIdField = value;
                    this.RaisePropertyChanged("RoleId");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseEntity", Namespace="http://schemas.datacontract.org/2004/07/BBS.Domain")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TestConsole.BbsService.Role))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TestConsole.BbsService.Gender))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TestConsole.BbsService.User))]
    public partial class BaseEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Role", Namespace="http://schemas.datacontract.org/2004/07/BBS.Domain")]
    [System.SerializableAttribute()]
    public partial class Role : TestConsole.BbsService.BaseEntity {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Gender", Namespace="http://schemas.datacontract.org/2004/07/BBS.Domain")]
    [System.SerializableAttribute()]
    public partial class Gender : TestConsole.BbsService.BaseEntity {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BbsService.IBbsService")]
    public interface IBbsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/GetUsers", ReplyAction="http://tempuri.org/IBbsService/GetUsersResponse")]
        System.Collections.Generic.List<TestConsole.BbsService.User> GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/GetUsers", ReplyAction="http://tempuri.org/IBbsService/GetUsersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<TestConsole.BbsService.User>> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/FindUser", ReplyAction="http://tempuri.org/IBbsService/FindUserResponse")]
        TestConsole.BbsService.User FindUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/FindUser", ReplyAction="http://tempuri.org/IBbsService/FindUserResponse")]
        System.Threading.Tasks.Task<TestConsole.BbsService.User> FindUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/CreateUser", ReplyAction="http://tempuri.org/IBbsService/CreateUserResponse")]
        TestConsole.BbsService.User CreateUser(TestConsole.BbsService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/CreateUser", ReplyAction="http://tempuri.org/IBbsService/CreateUserResponse")]
        System.Threading.Tasks.Task<TestConsole.BbsService.User> CreateUserAsync(TestConsole.BbsService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/UpdateUser", ReplyAction="http://tempuri.org/IBbsService/UpdateUserResponse")]
        TestConsole.BbsService.User UpdateUser(TestConsole.BbsService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/UpdateUser", ReplyAction="http://tempuri.org/IBbsService/UpdateUserResponse")]
        System.Threading.Tasks.Task<TestConsole.BbsService.User> UpdateUserAsync(TestConsole.BbsService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/DeleteUser", ReplyAction="http://tempuri.org/IBbsService/DeleteUserResponse")]
        bool DeleteUser(int d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/DeleteUser", ReplyAction="http://tempuri.org/IBbsService/DeleteUserResponse")]
        System.Threading.Tasks.Task<bool> DeleteUserAsync(int d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/GetRoles", ReplyAction="http://tempuri.org/IBbsService/GetRolesResponse")]
        System.Collections.Generic.List<TestConsole.BbsService.Role> GetRoles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/GetRoles", ReplyAction="http://tempuri.org/IBbsService/GetRolesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<TestConsole.BbsService.Role>> GetRolesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/GetGenders", ReplyAction="http://tempuri.org/IBbsService/GetGendersResponse")]
        System.Collections.Generic.List<TestConsole.BbsService.Gender> GetGenders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/GetGenders", ReplyAction="http://tempuri.org/IBbsService/GetGendersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<TestConsole.BbsService.Gender>> GetGendersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBbsServiceChannel : TestConsole.BbsService.IBbsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BbsServiceClient : System.ServiceModel.ClientBase<TestConsole.BbsService.IBbsService>, TestConsole.BbsService.IBbsService {
        
        public BbsServiceClient() {
        }
        
        public BbsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BbsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BbsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BbsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<TestConsole.BbsService.User> GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<TestConsole.BbsService.User>> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public TestConsole.BbsService.User FindUser(int id) {
            return base.Channel.FindUser(id);
        }
        
        public System.Threading.Tasks.Task<TestConsole.BbsService.User> FindUserAsync(int id) {
            return base.Channel.FindUserAsync(id);
        }
        
        public TestConsole.BbsService.User CreateUser(TestConsole.BbsService.User user) {
            return base.Channel.CreateUser(user);
        }
        
        public System.Threading.Tasks.Task<TestConsole.BbsService.User> CreateUserAsync(TestConsole.BbsService.User user) {
            return base.Channel.CreateUserAsync(user);
        }
        
        public TestConsole.BbsService.User UpdateUser(TestConsole.BbsService.User user) {
            return base.Channel.UpdateUser(user);
        }
        
        public System.Threading.Tasks.Task<TestConsole.BbsService.User> UpdateUserAsync(TestConsole.BbsService.User user) {
            return base.Channel.UpdateUserAsync(user);
        }
        
        public bool DeleteUser(int d) {
            return base.Channel.DeleteUser(d);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteUserAsync(int d) {
            return base.Channel.DeleteUserAsync(d);
        }
        
        public System.Collections.Generic.List<TestConsole.BbsService.Role> GetRoles() {
            return base.Channel.GetRoles();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<TestConsole.BbsService.Role>> GetRolesAsync() {
            return base.Channel.GetRolesAsync();
        }
        
        public System.Collections.Generic.List<TestConsole.BbsService.Gender> GetGenders() {
            return base.Channel.GetGenders();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<TestConsole.BbsService.Gender>> GetGendersAsync() {
            return base.Channel.GetGendersAsync();
        }
    }
}
