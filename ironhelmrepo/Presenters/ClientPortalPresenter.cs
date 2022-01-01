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
    public class ClientPortalPresenter
    {
        private readonly IPortalView portalview;
        private IOrder order;

        public ClientPortalPresenter(IPortalView portalview,IOrder order)
        {
            this.portalview = portalview;
            this.order = order;
        }
        public DataTable DisplayClientOrderData()
        {
            return order.getCustomerOrdersById(portalview.clientId);
        }

        public string AcceptOrder()
        {
            Order order = new Order(portalview.orderId, portalview.clientId);
            order=order.getOrderById(portalview.orderId, portalview.clientId);
            return order.validateOrderStatusChange(OrderStatus.ACCEPTED);
        }
        public string CancelOrder()
        {
            Order order = new Order(portalview.orderId, portalview.clientId);
            order = order.getOrderById(portalview.orderId, portalview.clientId);
            return order.validateOrderStatusChange(OrderStatus.CANCELLED);
        }

    }
}
