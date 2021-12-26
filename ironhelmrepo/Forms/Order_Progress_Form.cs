using Iron_helm_order_mgt.Entities;
using Iron_helm_order_mgt.Factory;
using Iron_helm_order_mgt.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron_helm_order_mgt.Forms
{
    public partial class Order_Progress_Form : Form
    {
        private Order order;
        private CustomerService customerService;
        private OrderService orderService;
        private OrderLineItemService orderLineItemService;
        private ProductService productService;
        public Order_Progress_Form(Order order)
        {
            InitializeComponent();
            this.order = order;
            customerService = new CustomerService();
            orderService = new OrderService();
            orderLineItemService = new OrderLineItemService();
            productService = new ProductService();
        }

        public void order_process()
        {
            Customer customer = customerService.getCustomerById(order.ClientId);
            List< OrderLineItem> lines= orderLineItemService.getOrderLinesById(order.orderId);
            List<ProductCatalog> products = new List<ProductCatalog>();
            foreach(OrderLineItem l in lines)
            {
                products.Add(productService.getProductById(l.productCode));
            }

            string customerSource = Enum.GetName(typeof(CustomerSource),customer.customerSource);
            if (customerSource == "STATE")
            {
                IProductionFactory factory = new GovernmentItemProductionFactory();
                ClientOrder storder = new ClientOrder(factory, products);
            }
            if (customerSource == "ENTERTAINMENT")
            {
                IProductionFactory factory = new MovieItemProductionFactory();
                ClientOrder mvorder = new ClientOrder(factory, products);
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Production Started!");
            orderService.progressOrder(order.orderStatus, order.orderId);
            progressBar1.Value = 3;
            order_process();
            progressBar1.Value = 100;
            
            orderService.completeOrder(order.orderStatus, order.orderId);
            MessageBox.Show("Order completed!");
        }

        private void finish_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
