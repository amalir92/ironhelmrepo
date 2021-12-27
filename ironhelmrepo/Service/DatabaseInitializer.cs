using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt.Service
{
    public class DatabaseInitializer
    {
        public static void databaseInitialize()
        {
            using (var context = new IronHelmDbContext())
            {
                var userList = context.Users.ToList<User>();
                var productCatalog = context.ProductCatalogs.ToList<ProductCatalog>();
                var orderList = context.Orders.ToList<Order>();
                var customerList = context.Customers.ToList<Customer>();
                var orderLinesList = context.orderLineItems.ToList<OrderLineItem>();
                //var personList=context.Persons.
                context.SaveChanges();

            }
        }
    }
}
