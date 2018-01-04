﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BBS.UI.BbsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BbsService.IBbsService")]
    public interface IBbsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/GetUsers", ReplyAction="http://tempuri.org/IBbsService/GetUsersResponse")]
        System.Collections.Generic.List<BBS.Domain.User> GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/GetUsers", ReplyAction="http://tempuri.org/IBbsService/GetUsersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BBS.Domain.User>> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/FindUser", ReplyAction="http://tempuri.org/IBbsService/FindUserResponse")]
        BBS.Domain.User FindUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/FindUser", ReplyAction="http://tempuri.org/IBbsService/FindUserResponse")]
        System.Threading.Tasks.Task<BBS.Domain.User> FindUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/CreateUser", ReplyAction="http://tempuri.org/IBbsService/CreateUserResponse")]
        BBS.Domain.User CreateUser(BBS.Domain.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/CreateUser", ReplyAction="http://tempuri.org/IBbsService/CreateUserResponse")]
        System.Threading.Tasks.Task<BBS.Domain.User> CreateUserAsync(BBS.Domain.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/UpdateUser", ReplyAction="http://tempuri.org/IBbsService/UpdateUserResponse")]
        BBS.Domain.User UpdateUser(BBS.Domain.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/UpdateUser", ReplyAction="http://tempuri.org/IBbsService/UpdateUserResponse")]
        System.Threading.Tasks.Task<BBS.Domain.User> UpdateUserAsync(BBS.Domain.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/DeleteUser", ReplyAction="http://tempuri.org/IBbsService/DeleteUserResponse")]
        bool DeleteUser(int d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/DeleteUser", ReplyAction="http://tempuri.org/IBbsService/DeleteUserResponse")]
        System.Threading.Tasks.Task<bool> DeleteUserAsync(int d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/GetRoles", ReplyAction="http://tempuri.org/IBbsService/GetRolesResponse")]
        System.Collections.Generic.List<BBS.Domain.Role> GetRoles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/GetRoles", ReplyAction="http://tempuri.org/IBbsService/GetRolesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BBS.Domain.Role>> GetRolesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/GetGenders", ReplyAction="http://tempuri.org/IBbsService/GetGendersResponse")]
        System.Collections.Generic.List<BBS.Domain.Gender> GetGenders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBbsService/GetGenders", ReplyAction="http://tempuri.org/IBbsService/GetGendersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BBS.Domain.Gender>> GetGendersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBbsServiceChannel : BBS.UI.BbsService.IBbsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BbsServiceClient : System.ServiceModel.ClientBase<BBS.UI.BbsService.IBbsService>, BBS.UI.BbsService.IBbsService {
        
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
        
        public System.Collections.Generic.List<BBS.Domain.User> GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BBS.Domain.User>> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public BBS.Domain.User FindUser(int id) {
            return base.Channel.FindUser(id);
        }
        
        public System.Threading.Tasks.Task<BBS.Domain.User> FindUserAsync(int id) {
            return base.Channel.FindUserAsync(id);
        }
        
        public BBS.Domain.User CreateUser(BBS.Domain.User user) {
            return base.Channel.CreateUser(user);
        }
        
        public System.Threading.Tasks.Task<BBS.Domain.User> CreateUserAsync(BBS.Domain.User user) {
            return base.Channel.CreateUserAsync(user);
        }
        
        public BBS.Domain.User UpdateUser(BBS.Domain.User user) {
            return base.Channel.UpdateUser(user);
        }
        
        public System.Threading.Tasks.Task<BBS.Domain.User> UpdateUserAsync(BBS.Domain.User user) {
            return base.Channel.UpdateUserAsync(user);
        }
        
        public bool DeleteUser(int d) {
            return base.Channel.DeleteUser(d);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteUserAsync(int d) {
            return base.Channel.DeleteUserAsync(d);
        }
        
        public System.Collections.Generic.List<BBS.Domain.Role> GetRoles() {
            return base.Channel.GetRoles();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BBS.Domain.Role>> GetRolesAsync() {
            return base.Channel.GetRolesAsync();
        }
        
        public System.Collections.Generic.List<BBS.Domain.Gender> GetGenders() {
            return base.Channel.GetGenders();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BBS.Domain.Gender>> GetGendersAsync() {
            return base.Channel.GetGendersAsync();
        }
    }
}