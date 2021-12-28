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
        private readonly IAdminPortalView view;
        private OrderDAL orderDAL;

        public AdminPortalPresenter(IAdminPortalView portalview)
        {
            this.view = portalview;
            orderDAL = new OrderDAL();
        }
        public DataTable DisplayAllOrderData()
        {
            DataTable dt = orderDAL.getOrders();
            return dt;
        }
        public Order getOrderById()
        {
           return orderDAL.getOrderById(view.orderId);
        }
    }
}
