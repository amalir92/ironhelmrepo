using Iron_helm_order_mgt.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt.Service
{
    public class OrderLineItemService
    {
        private OrderLineItemDAL orderLineItemDAL;

        public OrderLineItemService()
        {
            orderLineItemDAL = new OrderLineItemDAL();
        }

        public void createOrderLine(int orderId,String productId, int quantity)
        {
            orderLineItemDAL.create_order_line(orderId, productId, quantity);
        }

        public DataTable getOrderLinesByOrderId(int orderId)
        {
            return orderLineItemDAL.getOrderLinesByOrderId(orderId);
            //return new DataTable();
        }

        public List<OrderLineItem> getOrderLinesById(int orderId)
        {
            return orderLineItemDAL.getOrderLinesById(orderId);
        }
        }
}
