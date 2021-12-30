using Iron_helm_order_mgt;
using Iron_helm_order_mgt.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace IronHelmTest
{
    [TestClass]
    public class OrderLineItemDALTests
    {
        [TestMethod]
        public void create_order_line_validData()
        {
            IronHelmDbContext context = new IronHelmDbContext();
            var maxOrderId = 1;
            if (context.orderLineItems.Count() != 0)
            {
                maxOrderId = context.Orders.Max(table => table.orderId);
            }
            int orderNo = maxOrderId;
            String productId = "001P";
            int quantity = 10;
            var maxId = 1;
            OrderLineItemDAL orderLineItemDAL = new OrderLineItemDAL();
            orderLineItemDAL.createOrderLine(orderNo, productId, quantity,120,10.0);
            if (context.orderLineItems.Count() != 0)
            {
                maxId = context.orderLineItems.Max(table => table.orderLineItemId);
            }
            OrderLineItem orderLine =  context.orderLineItems.Single(o => o.orderLineItemId == maxId);
           Order order = orderLine.OrderId;
            Assert.AreEqual(orderNo, order.orderId);
        }

        [TestMethod]
        public void getOrderLinesById_DetailsNotInDb()
        {
            int orderId = 0009;
 
            OrderLineItemDAL order = new OrderLineItemDAL();
            List<OrderLineItem> orderItems = order.getOrderLinesById(orderId);
            Assert.IsNull(orderItems);
        }

        [TestMethod]
        public void getOrderLinesById_DetailsInDb()
        {
            int newOrderLineId = 1;
            IronHelmDbContext context = new IronHelmDbContext();
            if (context.orderLineItems.Count() != 0)
            {
                newOrderLineId = context.orderLineItems.Max(table => table.orderLineItemId);
            }
            OrderLineItemDAL order = new OrderLineItemDAL();
            List<OrderLineItem> orderItems = order.getOrderLinesById(newOrderLineId);
            Assert.IsTrue(orderItems.Count > 0);
        }

        [TestMethod]
        public void getOrderLinesByOrderId_DetailsNotInDb()
        {
            int orderId = 0009;

            OrderLineItemDAL order = new OrderLineItemDAL();
            DataTable dt = order.getOrderLinesByOrderId(orderId);
            Assert.IsTrue(dt.Rows.Count==0);
        }

        [TestMethod]
        public void getOrderLinesByOrderId_DetailsInDb()
        {
            int newOrderLineId = 1;
            IronHelmDbContext context = new IronHelmDbContext();
            if (context.orderLineItems.Count() != 0)
            {
                newOrderLineId = context.orderLineItems.Max(table => table.orderLineItemId);
            }
            OrderLineItemDAL order = new OrderLineItemDAL();
            DataTable dt = order.getOrderLinesByOrderId(newOrderLineId);
            Assert.IsTrue(dt.Rows.Count>0);
        }
    }
}
