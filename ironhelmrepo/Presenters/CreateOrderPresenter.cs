using Iron_helm_order_mgt;
using Iron_helm_order_mgt.DAL;
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
        private Order order;
        private ProductCatalog productCatalog;

        public CreateOrderPresenter(ICreateOrderView view)
        {
            this.view = view;
            productCatalog = new ProductCatalog();
        }

        public DataTable getAllProducts()
        {
           return productCatalog.getAllProducts();
        }

        public int createOrder()
        {
            order = new Order(view.orderLines, view.clientId, view.expectedOrderCompletionDate);
            return order.createOrder();
             

        }
    }
}
