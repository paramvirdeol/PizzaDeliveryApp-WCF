﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaDelivery.Client.PizzaServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PizzaServices.IPizzaService")]
    public interface IPizzaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/GetProducts", ReplyAction="http://tempuri.org/IPizzaService/GetProductsResponse")]
        System.Collections.ObjectModel.ObservableCollection<PizzaDelivery.Entities.Product> GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/GetProducts", ReplyAction="http://tempuri.org/IPizzaService/GetProductsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<PizzaDelivery.Entities.Product>> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/GetCustomers", ReplyAction="http://tempuri.org/IPizzaService/GetCustomersResponse")]
        System.Collections.ObjectModel.ObservableCollection<PizzaDelivery.Entities.Customer> GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/GetCustomers", ReplyAction="http://tempuri.org/IPizzaService/GetCustomersResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<PizzaDelivery.Entities.Customer>> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/SubmitOrder", ReplyAction="http://tempuri.org/IPizzaService/SubmitOrderResponse")]
        void SubmitOrder(PizzaDelivery.Entities.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/SubmitOrder", ReplyAction="http://tempuri.org/IPizzaService/SubmitOrderResponse")]
        System.Threading.Tasks.Task SubmitOrderAsync(PizzaDelivery.Entities.Order order);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPizzaServiceChannel : PizzaDelivery.Client.PizzaServices.IPizzaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PizzaServiceClient : System.ServiceModel.ClientBase<PizzaDelivery.Client.PizzaServices.IPizzaService>, PizzaDelivery.Client.PizzaServices.IPizzaService {
        
        public PizzaServiceClient() {
        }
        
        public PizzaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PizzaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PizzaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PizzaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.ObjectModel.ObservableCollection<PizzaDelivery.Entities.Product> GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<PizzaDelivery.Entities.Product>> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public System.Collections.ObjectModel.ObservableCollection<PizzaDelivery.Entities.Customer> GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<PizzaDelivery.Entities.Customer>> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public void SubmitOrder(PizzaDelivery.Entities.Order order) {
            base.Channel.SubmitOrder(order);
        }
        
        public System.Threading.Tasks.Task SubmitOrderAsync(PizzaDelivery.Entities.Order order) {
            return base.Channel.SubmitOrderAsync(order);
        }
    }
}
