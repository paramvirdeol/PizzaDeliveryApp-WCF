using PizzaDelivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery.Services
{
    [ServiceContract]
    public interface IPizzaService
    {
        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        List<Customer> GetCustomers();

        [OperationContract]
        void SubmitOrder(Order order);
    }
}
