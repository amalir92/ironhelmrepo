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
        private Order order;
        private OrderLineItem orderLineItem;
        private OrderLineItemDAL orderLineItemDAL;

        public EstimateOrderPresenter(IEstimateOrderView view)
        {
            this.view = view;
            orderDAL = new OrderDAL();
            order = new Order();
            orderLineItem = new OrderLineItem();
            
            orderLineItemDAL = new OrderLineItemDAL();
        }
        public List<OrderLineItem> getOrderLines()
        {
            return orderLineItem.getOrderLinesByOrderId(view.orderId);
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
                    line.updateOrderLine();
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
            
        }

    }
}
