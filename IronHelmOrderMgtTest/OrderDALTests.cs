using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Iron_helm_order_mgt.DAL;
using Iron_helm_order_mgt;
using System.Linq;
using System.Collections.Generic;
using System.Data;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class OrderDALTests
    {
        [TestMethod]
        public void getCustomerById_NoData()
        {
            String customerId = "user1";
            OrderDAL order = new OrderDAL();
            Assert.ThrowsException<Exception>(() => order.getCustomerById(customerId));
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
            Order ord = new Order();
            ord.orderId = 1111;
            OrderDAL orderDAL = new OrderDAL();
            Assert.ThrowsException<Exception>(() => orderDAL.getOrderById(ord));
        }

        [TestMethod]
        public void getOrderById_ValidData()
        {
            Order ord = new Order();
            ord.orderId = 1;
            OrderDAL orderDAL = new OrderDAL();
            Order order = orderDAL.getOrderById(ord);
            Assert.IsNotNull(ord);
        }

        [TestMethod]
        public void setOrderStatus_validData()
        {
            Order ord = new Order();
            ord.orderId = 1;
            ord.orderStatus = OrderStatus.NEW.ToString();
            String expectedOrderStatus = "";
            OrderDAL order = new OrderDAL();
            order.setOrderStatus(ord);

            using (var context = new IronHelmDbContext())
            {
                Order or = context.Orders.Single(o => o.orderId == 1);
                expectedOrderStatus = or.orderStatus;
            }
            Assert.AreEqual(expectedOrderStatus, OrderStatus.NEW.ToString());
        }

        [TestMethod]
        public void setOrderStatus_invalidData()
        {
            Order ord = new Order();
            ord.orderId = 111;
            ord.orderStatus = OrderStatus.NEW.ToString();
            
            OrderDAL order = new OrderDAL();
            
            Assert.ThrowsException<InvalidOperationException>(() => order.setOrderStatus(ord));
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
            //order.orderId = newId;
            orderLineItem.orderLineItemId = newOrderLineId;
            //orderLineItem.OrderId = order;
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
        public void getOrders_validDataInDB()
        {
            IronHelmDbContext context = new IronHelmDbContext();
            
            OrderDAL order = new OrderDAL();
            DataTable dt = order.getOrders();
            Assert.IsTrue(dt.Rows.Count>0);
        }       
    }
}
