using Iron_helm_order_mgt;
using Iron_helm_order_mgt.DAL;
using ironhelmrepo.IModels;
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
        private IOrder order;
        private IProduct product;
        private ProductCatalog productCatalog;

        public CreateOrderPresenter(ICreateOrderView view,IOrder order,IProduct product)
        {
            this.view = view;
            this.order = order;
            this.product = product;
        }

        public DataTable getAllProducts()
        {
            return product.getAllProducts();
        }

        public int createOrder()
        {
            
            return order.createOrder(view.orderLines, view.clientId, view.expectedOrderCompletionDate);
             

        }
    }
}
