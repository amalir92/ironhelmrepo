using Iron_helm_order_mgt;
using Iron_helm_order_mgt.DAL;
using ironhelmrepo.IModels;
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
        private IOrder order;
        private IOrderLineItem orderLineItem;
        public EstimateOrderPresenter(IEstimateOrderView view,IOrder order,IOrderLineItem orderLineItem)
        {
            this.view = view;
            this.order = order;
            this.orderLineItem = orderLineItem;
        }
        public List<OrderLineItem> getOrderLines()
        {
            
            return orderLineItem.getOrderLinesByOrderId(view.orderId, view.clientId);
        }

        public string estimateOrder()
        {
            //order = new Order(view.orderId,view.clientId);
            order = order.getOrderById(view.orderId, view.clientId);
            return order.validateOrderStatusChange(OrderStatus.ESTIMATED);
        }

        public void updateOrderLines() 
        {
             List<OrderLineItem> orderlines = getOrderLines();
             foreach(OrderLineItem line in orderlines)
            {
                if (line.productCode.Equals(view.productCode))
                {
                    line.labourHoursPerItem = view.hours;
                    line.costPerHour = view.costPerHour;
                    line.calculateCostPerItemProduction();
                    line.updateOrderLine();
                }
            }
             
        }

        public void updateOrder()
        {
            order = order.getOrderById(view.orderId, view.clientId);
            List<OrderLineItem> orderlines = getOrderLines();
            order.updateOrder(view.packageCost, view.deliveryCost, orderlines, order.calculateTotalCost(orderlines),"ESTIMATED",view.estimatedDate);
            
        }

    }
}
