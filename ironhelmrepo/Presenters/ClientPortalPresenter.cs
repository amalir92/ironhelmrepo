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
    public class ClientPortalPresenter
    {
        private readonly IPortalView portalview;
        private Order order;

        public ClientPortalPresenter(IPortalView portalview)
        {
            this.portalview = portalview;           
        }
        public DataTable DisplayClientOrderData()
        {
            order = new Order(portalview.clientId);
            return order.getCustomerOrdersById();
        }

        public string AcceptOrder()
        {
            Order order = new Order(portalview.orderId, portalview.clientId);
            order=order.getOrderById();
            return order.validateOrderStatusChange(OrderStatus.ACCEPTED);
        }
        public string CancelOrder()
        {
            Order order = new Order(portalview.orderId, portalview.clientId);
            order = order.getOrderById();
            return order.validateOrderStatusChange(OrderStatus.CANCELLED);
        }

    }
}
