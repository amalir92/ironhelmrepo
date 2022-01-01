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
    public class AdminPortalPresenter
    {
        private readonly IPortalView view;
        private IOrder order;

        public AdminPortalPresenter(IPortalView portalview, IOrder order)
        {
            this.view = portalview;
            this.order = order;
        }
        public DataTable DisplayAllOrderData()
        {
            return order.getAllOrders();
        }
        public Order getOrderById()
        {
            return order.getOrderById(view.orderId, view.clientId);
        }
    }
}
