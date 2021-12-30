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
    public class AdminPortalPresenter
    {
        private readonly IPortalView view;
        private Order order;

        public AdminPortalPresenter(IPortalView portalview)
        {
            this.view = portalview;
           
        }
        public DataTable DisplayAllOrderData()
        {
            order = new Order();
            return order.getAllOrders();
        }
        public Order getOrderById()
        {
            order = new Order(view.orderId, view.clientId);
            return order.getOrderById();
        }
    }
}
