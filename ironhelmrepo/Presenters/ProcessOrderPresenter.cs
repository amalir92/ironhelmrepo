
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
        private OrderDAL orderDAL;
        private Order order;
        private CustomerDAL customerDAL;
        private Customer customer;
        private OrderLineItem orderLineItem;
        private ProductCatalogDAL productCatalogDAL;

        public ProcessOrderPresenter(IProcessOrderView view)
        {
            this.view = view;
            this.orderDAL = new OrderDAL();
            order = new Order();
            this.orderLineItem = new OrderLineItem();
            this.productCatalogDAL = new ProductCatalogDAL();
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
            return orderLineItem.getOrderLinesByOrderId(view.order.orderId);
        }

        public string initiateProduction() 
        {
            List<OrderLineItem> lines = getOrderLinesByOrderId();
            Customer customer = getCustomerById();
            List<ProductCatalog> products = new List<ProductCatalog>();
            foreach (OrderLineItem l in lines)
            {
                products.Add(productCatalogDAL.getProductById(l.productCode));
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
