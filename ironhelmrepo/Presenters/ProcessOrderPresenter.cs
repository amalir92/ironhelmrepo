
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
using ironhelmrepo.IModels;
using ironhelmrepo.Factory;

namespace ironhelmrepo.Presenters
{
    public class ProcessOrderPresenter
    {
        private readonly IProcessOrderView view;
        private IOrder order;
        private ICustomer customer;
        private IOrderLineItem orderLineItem;

        public ProcessOrderPresenter(IProcessOrderView view,IOrder order,ICustomer customer,IOrderLineItem orderLineItem)
        {
            this.view = view;
            this.order = order;
            this.customer = customer;
            this.orderLineItem = orderLineItem;
        }

        public string scheduleOrder()
        {
            order = view.order;
            return order.validateOrderStatusChange(OrderStatus.SCHEDULED);
        }

        public string progressOrder()
        {
            order = view.order;
            return order.validateOrderStatusChange(OrderStatus.PROGRESSING);
        }
        

        public string completeOrder()
        {
            order = view.order;
            return order.validateOrderStatusChange(OrderStatus.COMPLETED);
            
        }

        public Customer getCustomerById()
        {
            //customer = new Customer(view.order.clientId);
            return customer.getCustomerById(view.order.clientId);
        }

        public List<OrderLineItem> getOrderLinesByOrderId()
        {
           // this.orderLineItem = new OrderLineItem(view.order);
            return orderLineItem.getOrderLinesByOrderId(view.order.orderId,view.order.clientId);
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
                OrderProduction storder = new OrderProduction(factory, products);
                return "GovernmentItemProductionFactory";
            }
            if (customerSource == "ENTERTAINMENT")
            {
                IProductionFactory factory = new MovieItemProductionFactory();
                OrderProduction mvorder = new OrderProduction(factory, products);
                return "MovieItemProductionFactory";
            }
            if (customerSource == "INDIVIDUAL")
            {
                IProductionFactory factory = new CustomItemProductionFactory();
                OrderProduction csorder = new OrderProduction(factory, products);
                return "CustomItemProductionFactory";
            }
            return "";
        }
    }
}
