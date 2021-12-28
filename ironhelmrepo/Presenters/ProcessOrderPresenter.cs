
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
        private CustomerDAL customerDAL;
        private OrderLineItemDAL orderLineItemDAL;
        private ProductCatalogDAL productCatalogDAL;

        public ProcessOrderPresenter(IProcessOrderView view)
        {
            this.view = view;
            this.orderDAL = new OrderDAL();
            this.customerDAL = new CustomerDAL();
            this.orderLineItemDAL = new OrderLineItemDAL();
            this.productCatalogDAL = new ProductCatalogDAL();
        }

        public string scheduleOrder()
        {
            Order order = orderDAL.getOrderById(view.order.orderId);
            return order.validateOrderStatusChange(OrderStatus.SCHEDULED);
        }

        public string progressOrder()
        {
            Order order = orderDAL.getOrderById(view.order.orderId);
            return order.validateOrderStatusChange(OrderStatus.PROGRESSING);
        }
        

        public string completeOrder()
        {
            Order order = orderDAL.getOrderById(view.order.orderId);
            return order.validateOrderStatusChange(OrderStatus.COMPLETED);
            
        }

        public Customer getCustomerById()
        {
            return customerDAL.getCustomerById(view.order.ClientId);
        }

        public List<OrderLineItem> getOrderLinesByOrderId()
        {
            return orderLineItemDAL.getOrderLinesById(view.order.orderId);
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
                ClientOrder storder = new ClientOrder(factory, products);
                return "GovernmentItemProductionFactory";
            }
            if (customerSource == "ENTERTAINMENT")
            {
                IProductionFactory factory = new MovieItemProductionFactory();
                ClientOrder mvorder = new ClientOrder(factory, products);
                return "MovieItemProductionFactory";
            }
            return "";
        }
    }
}
