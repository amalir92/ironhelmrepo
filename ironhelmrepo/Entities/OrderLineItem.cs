using Iron_helm_order_mgt.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt
{
    public class OrderLineItem
    {
        private OrderLineItemDAL orderLineItemDAL;
        public OrderLineItem()
        {
            orderLineItemDAL = new OrderLineItemDAL();
        }
       
        public OrderLineItem(int orderLineItemId, Order orderId, string productCode, int quantity, int labourHoursPerItem, double costPerHour)
        {
            this.orderLineItemId = orderLineItemId;
            OrderId = orderId;
            this.productCode = productCode;
            this.quantity = quantity;
            this.labourHoursPerItem = labourHoursPerItem;
            this.costPerHour = costPerHour;
        }
        public OrderLineItem(string productCode, int quantity)
        {
            this.productCode = productCode;
            this.quantity = quantity;
        }

        [Key]
        public int orderLineItemId { get; set; }

        
        public virtual Order OrderId { get; set; }

       
        public string productCode { get; set; }

        public int quantity { get; set; }

        public int labourHoursPerItem { get; set; }

        public double costPerHour { get; set; }

        public double costperLineProduction { get; set; }

        public double calculateCostPerItemProduction()
        {
           
            this.costperLineProduction= quantity * labourHoursPerItem * costPerHour;
            return costperLineProduction;
        }

        public List<OrderLineItem> getOrderLinesByOrderId(int orderId)
        {
            return orderLineItemDAL.getOrderLinesById(orderId);
        }
        public DataTable getOrderLinesTableByOrderId(int orderId)
        {
            return orderLineItemDAL.getOrderLinesByOrderId(orderId);
        }

        public void updateOrderLine()
        {
            orderLineItemDAL.updateOrderLineItem(this);
        }
    }
}
