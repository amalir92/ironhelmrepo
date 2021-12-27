
using Iron_helm_order_mgt;
using Iron_helm_order_mgt.Entities;
using Iron_helm_order_mgt.Factory;
using Iron_helm_order_mgt.Service;
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
        private OrderService orderService;
        private CustomerService customerService;
        private OrderLineItemService orderLineItemService;
        private ProductService productService;

        public ProcessOrderPresenter(IProcessOrderView view)
        {
            this.view = view;
            this.orderService = new OrderService();
            this.customerService = new CustomerService();
            this.orderLineItemService = new OrderLineItemService();
            this.productService = new ProductService();
        }

        public string scheduleOrder()
        {
            return orderService.scheduleOrder(view.order.orderStatus, view.order.orderId);
        }

        public string progressOrder()
        {
            return orderService.progressOrder(view.order.orderStatus, view.order.orderId);
        }

        public string completeOrder()
        {
            return orderService.completeOrder(view.order.orderStatus, view.order.orderId);
        }

        public Customer getCustomerById()
        {
            return customerService.getCustomerById(view.order.ClientId);
        }

        public List<OrderLineItem> getOrderLinesByOrderId()
        {
            return orderLineItemService.getOrderLinesById(view.order.orderId);
        }

        public string initiateProduction() 
        {
            List<OrderLineItem> lines = getOrderLinesByOrderId();
            Customer customer = getCustomerById();
            List<ProductCatalog> products = new List<ProductCatalog>();
            foreach (OrderLineItem l in lines)
            {
                products.Add(productService.getProductById(l.productCode));
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
