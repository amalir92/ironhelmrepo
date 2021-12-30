using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Iron_helm_order_mgt.DAL;
using System.Data;
using Iron_helm_order_mgt;
using System.Linq;
using System.Collections.Generic;

namespace IronHelmTest
{
    [TestClass]
    public class OrderDALTests
    {
        [TestMethod]
        public void getCustomerById_NoData()
        {
            String customerId = "user1";
            OrderDAL order = new OrderDAL();
            DataTable dt = order.getCustomerById(customerId);
            Assert.IsNull(dt);
        }

        [TestMethod]
        public void getCustomerById_ValidData()
        {
            String customerId = "001C";
            OrderDAL order = new OrderDAL();
            DataTable dt = order.getCustomerById(customerId);
            Assert.IsNotNull(dt);
        }

        [TestMethod]
        public void getOrderById_NoData()
        {
            int orderId = 1111;
            OrderDAL order = new OrderDAL();
            Order ord = order.getOrderById(orderId);
            Assert.IsNull(ord);
        }

        [TestMethod]
        public void getOrderById_ValidData()
        {
            int orderId = 1;
            OrderDAL order = new OrderDAL();
            Order ord = order.getOrderById(orderId);
            Assert.IsNotNull(ord);
        }

        [TestMethod]
        public void setOrderStatus_validData()
        {
            int orderId = 1;
            OrderStatus status = OrderStatus.NEW;
            String expectedOrderStatus = "";
            OrderDAL order = new OrderDAL();
            order.setOrderStatus(orderId, status);

            using (var context = new IronHelmDbContext())
            {
                Order or = context.Orders.Single(o => o.orderId == orderId);
                expectedOrderStatus = or.orderStatus;
            }
            Assert.AreEqual(expectedOrderStatus, status);
        }

        [TestMethod]
        public void setOrderStatus_invalidData()
        {
            int orderId = 1111;
            OrderStatus status = OrderStatus.NEW;
            OrderDAL order = new OrderDAL();
            
            Assert.ThrowsException<Exception>(() => order.setOrderStatus(orderId, status));
        }

        [TestMethod]
        public void createOrder_validData()
        {
            
            String clientId = "001C";
            DateTime expectedDate = DateTime.Now;
            List<OrderLineItem> lines = new List<OrderLineItem>();
            OrderLineItem orderLineItem = new OrderLineItem();
            IronHelmDbContext context = new IronHelmDbContext();
            int newId = 1;
            int newOrderLineId = 1;
            if (context.Orders.Count() != 0)
            {
                var maxId = context.Orders.Max(table => table.orderId);
                newId = maxId + 1;
            }
            if (context.orderLineItems.Count() != 0)
            {
                var maxId = context.orderLineItems.Max(table => table.orderLineItemId);
                newOrderLineId = maxId + 1;
            }
            Order order = new Order();
            order.orderId = newId;
            orderLineItem.orderLineItemId = newOrderLineId;
            orderLineItem.OrderId = order;
            orderLineItem.productCode = "001P";
            orderLineItem.quantity = 5;
            orderLineItem. costPerHour= 7;
            lines.Add(orderLineItem);
            Order newOrder = new Order(lines, clientId,OrderStatus.NEW.ToString(),DateTime.Now, DateTime.Now, expectedDate,10.0,10.0,20.0);
     
            OrderDAL orderDAL = new OrderDAL();
            int ExpectedId = orderDAL.createOrder(newOrder);
            Assert.AreEqual(ExpectedId, newId);
        }

        [TestMethod]
        public void createOrder_ExceptionInsertingToDB()
        {

            String clientId = "";
            DateTime expectedDate = DateTime.Now;
            List<OrderLineItem> lines = new List<OrderLineItem>();
            OrderLineItem orderLineItem = new OrderLineItem();
            orderLineItem.orderLineItemId = 1;
            IronHelmDbContext context = new IronHelmDbContext();
            int newId = 1;
            int newOrderLineId = 1;
            if (context.Orders.Count() != 0)
            {
                var maxId = context.Orders.Max(table => table.orderId);
                newId = maxId + 1;
            }
            if (context.orderLineItems.Count() != 0)
            {
                newOrderLineId = context.orderLineItems.Max(table => table.orderLineItemId);
            }
            Order order = new Order();
            order.orderId = newId;
            orderLineItem.orderLineItemId = newOrderLineId;
            orderLineItem.OrderId = order;
            orderLineItem.productCode = "001P";
            orderLineItem.quantity = 5;
            orderLineItem.costPerHour = 7;
            lines.Add(orderLineItem);
            Order newOrder = new Order(lines, null, OrderStatus.NEW.ToString(), DateTime.Now, DateTime.Now, expectedDate, 10.0, 10.0, 20.0);
            OrderDAL orderDAL = new OrderDAL();
            Assert.ThrowsException<Exception>(() => orderDAL.createOrder(newOrder));
        }

        [TestMethod]
        public void updateOrder_validData()
        {

            IronHelmDbContext context = new IronHelmDbContext();
            int orderId = 1;
            if (context.Orders.Count() != 0)
            {
                orderId = context.Orders.Max(table => table.orderId);
            }
            OrderDAL order = new OrderDAL();
            Order newOrder = new Order();
            newOrder.orderId = orderId;
            newOrder.estimatedCompletionDate = DateTime.Now;
            newOrder.TotalOrderPrice = 90.0;
            order.updateOrder(newOrder);
            DateTime actualExpectedDate = DateTime.Now;
            Double actualCost = 0;
            using (context)
            {
                Order or = context.Orders.Single(o => o.orderId == orderId);
                actualExpectedDate = or.expectedOrderDate;
                actualCost = or.TotalOrderPrice;
            }

            Assert.AreEqual(90.0, actualCost);
        }

        [TestMethod]
        public void updateOrder_orderNotInDB()
        {
            DateTime estimatedDate = DateTime.Now;
            Double cost = 120.00;
            IronHelmDbContext context = new IronHelmDbContext();
            int newOrderId = 1;
            if (context.Orders.Count() != 0)
            {
               int orderId = context.Orders.Max(table => table.orderId);
               newOrderId = orderId + 10;

            }
            Order newOrder = new Order();
            newOrder.orderId = newOrderId;
            OrderDAL order = new OrderDAL();
            Assert.ThrowsException<Exception>(() => order.updateOrder(newOrder));
        }

        [TestMethod]
        public void getOrders_noOrdersInDB()
        {
            IronHelmDbContext context = new IronHelmDbContext();
            using (context)
            {
                context.Database.ExecuteSqlCommand("Delete from Order");
            }
            
            OrderDAL order = new OrderDAL();
            DataTable dt = order.getOrders();
            Assert.AreEqual(dt.Rows.Count,0);
        }

        [TestMethod]
        public void getOrders_oneOrderInDB()
        {
            IronHelmDbContext context = new IronHelmDbContext();
            using (context)
            {
                context.Database.ExecuteSqlCommand("Delete from Order");
            }

            Order newOrder = new Order();
            newOrder.orderId = 1;
            newOrder.ClientId = "001C";
            newOrder.orderStatusChangedDate = DateTime.Now;
            newOrder.orderStatus = "NEW";
            newOrder.estimatedCompletionDate = DateTime.Now;
            newOrder.expectedOrderDate = DateTime.Now;
            newOrder.OrderLineItems = new List<OrderLineItem>();
            OrderLineItem newOrderLine = new OrderLineItem();
            newOrderLine.OrderId = newOrder; 
            var newId = 1;
            if (context.orderLineItems.Count() != 0)
            {
                var maxId = context.orderLineItems.Max(table => table.orderLineItemId);
                newId = maxId + 1;
            }
            newOrderLine.orderLineItemId = newId;
            newOrderLine.productCode = "001P";
            newOrderLine.quantity = 10;
            newOrder.OrderLineItems.Add(newOrderLine);

            OrderDAL order = new OrderDAL();
            DataTable dt = order.getOrders();
            Assert.AreEqual(dt.Rows.Count, 1);
        }

        
    }
}
