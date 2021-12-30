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
        private Order order;
        private OrderLineItem orderLineItem;
        public EstimateOrderPresenter(IEstimateOrderView view)
        {
            this.view = view;
        }
        public List<OrderLineItem> getOrderLines()
        {
            orderLineItem = new OrderLineItem(new Order(view.orderId,view.clientId));
            return orderLineItem.getOrderLinesByOrderId();
        }

        public string estimateOrder()
        {
            order = new Order(view.orderId,view.clientId);
            order = order.getOrderById();
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
            order = new Order(view.orderId, view.clientId);
            order = order.getOrderById();
            order.packageCost = view.packageCost;
            order.deliveryCost = view.deliveryCost;
            List<OrderLineItem> orderlines = getOrderLines();
            order.OrderLineItems = orderlines;
            order.TotalOrderPrice= order.calculateTotalCost();
            order.orderStatus = "ESTIMATED";
            order.updateOrder(order);
            
        }

    }
}
