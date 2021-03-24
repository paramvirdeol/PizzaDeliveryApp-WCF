using PizzaDelivery.Data;
using PizzaDelivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery.Services
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerCall)]
    public class PizzaService : IPizzaService, IDisposable
    {
        readonly PizzaDeliveryDbContext _context = new PizzaDeliveryDbContext();

        public void Dispose()
        {
            _context.Dispose();
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void SubmitOrder(Order order)
        {
            _context.Orders.Add(order);
            order.OrderItems.ForEach(item => _context.OrderItems.Add(item));
            _context.SaveChanges();
            
        }
    }
}
