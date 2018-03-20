﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scada.Agent.Ctrl.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.AgentSvc")]
    public interface AgentSvc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/Sum", ReplyAction="http://tempuri.org/AgentSvc/SumResponse")]
        double Sum(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/Sum", ReplyAction="http://tempuri.org/AgentSvc/SumResponse")]
        System.Threading.Tasks.Task<double> SumAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/GetSessionID", ReplyAction="http://tempuri.org/AgentSvc/GetSessionIDResponse")]
        long GetSessionID();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/GetSessionID", ReplyAction="http://tempuri.org/AgentSvc/GetSessionIDResponse")]
        System.Threading.Tasks.Task<long> GetSessionIDAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/Login", ReplyAction="http://tempuri.org/AgentSvc/LoginResponse")]
        bool Login(long sessionID, string username, string encryptedPassword, string scadaInstanceName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/Login", ReplyAction="http://tempuri.org/AgentSvc/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(long sessionID, string username, string encryptedPassword, string scadaInstanceName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/ServiceCommand", ReplyAction="http://tempuri.org/AgentSvc/ServiceCommandResponse")]
        void ServiceCommand(long sessionID, Scada.Agent.ServiceCommand command, int service);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/ServiceCommand", ReplyAction="http://tempuri.org/AgentSvc/ServiceCommandResponse")]
        System.Threading.Tasks.Task ServiceCommandAsync(long sessionID, Scada.Agent.ServiceCommand command, int service);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AgentSvcChannel : Scada.Agent.Ctrl.ServiceReference1.AgentSvc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AgentSvcClient : System.ServiceModel.ClientBase<Scada.Agent.Ctrl.ServiceReference1.AgentSvc>, Scada.Agent.Ctrl.ServiceReference1.AgentSvc {
        
        public AgentSvcClient() {
        }
        
        public AgentSvcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AgentSvcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AgentSvcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AgentSvcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Sum(double a, double b) {
            return base.Channel.Sum(a, b);
        }
        
        public System.Threading.Tasks.Task<double> SumAsync(double a, double b) {
            return base.Channel.SumAsync(a, b);
        }
        
        public long GetSessionID() {
            return base.Channel.GetSessionID();
        }
        
        public System.Threading.Tasks.Task<long> GetSessionIDAsync() {
            return base.Channel.GetSessionIDAsync();
        }
        
        public bool Login(long sessionID, string username, string encryptedPassword, string scadaInstanceName) {
            return base.Channel.Login(sessionID, username, encryptedPassword, scadaInstanceName);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(long sessionID, string username, string encryptedPassword, string scadaInstanceName) {
            return base.Channel.LoginAsync(sessionID, username, encryptedPassword, scadaInstanceName);
        }
        
        public void ServiceCommand(long sessionID, Scada.Agent.ServiceCommand command, int service) {
            base.Channel.ServiceCommand(sessionID, command, service);
        }
        
        public System.Threading.Tasks.Task ServiceCommandAsync(long sessionID, Scada.Agent.ServiceCommand command, int service) {
            return base.Channel.ServiceCommandAsync(sessionID, command, service);
        }
    }
}
