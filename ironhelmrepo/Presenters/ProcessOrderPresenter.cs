
using Iron_helm_order_mgt;
using Iron_helm_order_mgt.Entities;
using Iron_helm_order_mgt.Factory;
using Iron_helm_order_mgt.DAL;
using ironhelmrepo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.Presenters
{
    public class ProcessOrderPresenter
    {
        private readonly IProcessOrderView view;
        private Order order;
        private Customer customer;
        private OrderLineItem orderLineItem;

        public ProcessOrderPresenter(IProcessOrderView view)
        {
            this.view = view;
        }

        public string scheduleOrder()
        {
            Order order = view.order;
            return order.validateOrderStatusChange(OrderStatus.SCHEDULED);
        }

        public string progressOrder()
        {
            Order order = view.order;
            return order.validateOrderStatusChange(OrderStatus.PROGRESSING);
        }
        

        public string completeOrder()
        {
            Order order = view.order;
            return order.validateOrderStatusChange(OrderStatus.COMPLETED);
            
        }

        public Customer getCustomerById()
        {
            customer = new Customer(view.order.ClientId);
            return customer.getCustomerById();
        }

        public List<OrderLineItem> getOrderLinesByOrderId()
        {
            this.orderLineItem = new OrderLineItem(view.order);
            return orderLineItem.getOrderLinesByOrderId();
        }

        public string initiateProduction() 
        {
            List<OrderLineItem> lines = getOrderLinesByOrderId();
            Customer customer = getCustomerById();
            List<ProductCatalog> products = new List<ProductCatalog>();
            foreach (OrderLineItem l in lines)
            {
                ProductCatalog p = new ProductCatalog(l.productCode);
                products.Add(p.getProductById());
            }

            string customerSource = Enum.GetName(typeof(CustomerSource), customer.customerSource);
            if (customerSource == "STATE")
            {
                IProductionFactory factory = new GovernmentItemProductionFactory();
                OrderProduction storder = new OrderProduction(factory, products,view.order);
                return "GovernmentItemProductionFactory";
            }
            if (customerSource == "ENTERTAINMENT")
            {
                IProductionFactory factory = new MovieItemProductionFactory();
                OrderProduction mvorder = new OrderProduction(factory, products,view.order);
                return "MovieItemProductionFactory";
            }
            return "";
        }
    }
}
