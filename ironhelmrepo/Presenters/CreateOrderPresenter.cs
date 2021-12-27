using Iron_helm_order_mgt.Service;
using ironhelmrepo.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.Presenters
{
    public class CreateOrderPresenter
    {
        private readonly ICreateOrderView view;
        private OrderService orderService;
        private OrderLineItemService orderLineItemService;
        private ProductService productService;

        public CreateOrderPresenter(ICreateOrderView view)
        {
            this.view = view;
            orderService = new OrderService();
            orderLineItemService = new OrderLineItemService();
            productService = new ProductService();
        }

        public DataTable getAllProducts()
        {
            return productService.getAllProducts(); ;
        }

        public int createOrder()
        {
            return orderService.createOrder(view.clientId, view.expectedOrderCompletionDate, view.orderLines);
        }
    }
}
