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
        private readonly IClientPortalView portalview;
        private OrderDAL orderDAL;
        private OrderLineItemDAL orderLineItemDAL;

        public ClientPortalPresenter(IClientPortalView portalview)
        {
            this.portalview = portalview;
            orderDAL = new OrderDAL();
            orderLineItemDAL = new OrderLineItemDAL();

        }
        public DataTable DisplayClientOrderData()
        {
            DataTable dt = orderDAL.getCustomerById(portalview.clientId);
            return dt;
        }

        public string AcceptOrder()
        {
            if (portalview.orderStatus != null && portalview.orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.ESTIMATED)))
            {
                orderDAL.setOrderStatus(portalview.orderId, OrderStatus.ACCEPTED);
                return "SUCCESS";
            }
            else
            {
                return "ERROR";
            }
        }
            public string CancelOrder()
            {
            if (portalview.orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.NEW)))
            {
                orderDAL.setOrderStatus(portalview.orderId, OrderStatus.CANCELLED);
                return "SUCCESS";
            }
            else
            {
                return "ERROR";
            }
        }

    }
}
