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
            Order order = orderDAL.getOrderById(view.orderId);
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
                    orderLineItemDAL.updateOrderLineItem(line);
                }
            }
             
        }

        public void updateOrder()
        {
            Order order = orderDAL.getOrderById(view.orderId);
            order.packageCost = view.packageCost;
            order.deliveryCost = view.deliveryCost;
            List<OrderLineItem> orderlines = getOrderLines();
            
            order.TotalOrderPrice= order.calculateTotalCost(orderlines);
            order.updateOrder(order);
            orderDAL.updateOrder(order);
        }

    }
}
