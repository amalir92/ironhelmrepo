using Iron_helm_order_mgt;
using Iron_helm_order_mgt.DAL;
using ironhelmrepo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.Presenters
{
    public class EstimateOrderPresenter
    {
        private readonly IEstimateOrderView view;
        private OrderDAL orderDAL;
        private OrderLineItemDAL orderLineItemDAL;

        public EstimateOrderPresenter(IEstimateOrderView view)
        {
            this.view = view;
            orderDAL = new OrderDAL();
            orderLineItemDAL = new OrderLineItemDAL();
        }
        public List<OrderLineItem> getOrderLines()
        {
            return orderLineItemDAL.getOrderLinesById(view.orderId);
        }

        public string estimateOrder()
        {
            if (view.orderStatus != null && view.orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.NEW)))
            {
                orderDAL.setOrderStatus(view.orderId, OrderStatus.ESTIMATED);
                return "SUCCESS";
            }
            else
            {
                return "ERROR";
            }
        }

        public void updateOrder() 
        {
             orderDAL.updateOrder(view.orderId,view.estimatedDate,view.totalCost);
        }

    }
}
