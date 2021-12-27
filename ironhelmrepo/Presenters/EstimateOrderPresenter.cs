using Iron_helm_order_mgt;
using Iron_helm_order_mgt.Service;
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
        private OrderService orderService;
        private OrderLineItemService orderLineItemService;

        public EstimateOrderPresenter(IEstimateOrderView view)
        {
            this.view = view;
            orderService = new OrderService();
            orderLineItemService = new OrderLineItemService();
        }
        public List<OrderLineItem> getOrderLines()
        {
            return orderLineItemService.getOrderLinesById(view.orderId);
        }

        public string estimateOrder()
        {
            return orderService.estimateOrder(view.orderStatus, view.orderId);
        }

        public void updateOrder() 
        {
             orderService.updateOrder(view.orderId,view.estimatedDate,view.totalCost);
        }

        public double calculateTotalCost()
        {
            double tcost = 0;
            return tcost;
        }
    }
}
