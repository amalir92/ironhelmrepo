using Iron_helm_order_mgt;
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
    public class AdminPortalPresenter
    {
        private readonly IAdminPortalView view;
        private OrderService orderService;

        public AdminPortalPresenter(IAdminPortalView portalview)
        {
            this.view = portalview;
            orderService = new OrderService();
        }
        public DataTable DisplayAllOrderData()
        {
            DataTable dt = orderService.getOrders();
            return dt;
        }
        public Order getOrderById()
        {
           return orderService.getOrderById(view.orderId);
        }
    }
}
