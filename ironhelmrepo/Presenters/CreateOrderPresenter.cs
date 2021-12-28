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
        private OrderDAL orderDAL;
        private OrderLineItemDAL orderLineItemDAL;
        private ProductCatalogDAL productCatalogDAL;

        public CreateOrderPresenter(ICreateOrderView view)
        {
            this.view = view;
            orderDAL = new OrderDAL();
            orderLineItemDAL = new OrderLineItemDAL();
            productCatalogDAL = new ProductCatalogDAL();
        }

        public DataTable getAllProducts()
        {
            return productCatalogDAL.getAllPoducts(); ;
        }

        public int createOrder()
        {
            return orderDAL.createOrder(view.clientId, view.expectedOrderCompletionDate, view.orderLines);
        }
    }
}
