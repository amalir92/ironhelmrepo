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
    public class ClientPortalPresenter
    {
        private readonly IClientPortalView portalview;
        private OrderService orderService;
        private OrderLineItemService orderLineItemService;

        public ClientPortalPresenter(IClientPortalView portalview)
        {
            this.portalview = portalview;
            orderService = new OrderService();
            orderLineItemService = new OrderLineItemService();

        }
        public DataTable DisplayClientOrderData()
        {
            DataTable dt = orderService.getCustomerByUseId(portalview.clientId);
            return dt;
        }

        public string AcceptOrder()
        {
            return  orderService.acceptOrder(portalview.orderStatus, portalview.orderId);
        }

        public string CancelOrder()
        {
            return orderService.cancelOrder(portalview.orderStatus, portalview.orderId);
        }

    }
}
