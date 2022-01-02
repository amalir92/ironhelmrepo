using System.Data;
using System.Collections.Generic;
using System;
using Iron_helm_order_mgt;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Tests
{
    /// <summary>This class contains parameterized unit tests for Order</summary>
    [TestClass]
    [PexClass(typeof(Order))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class OrderTest
    {

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        public Order ConstructorTest(string clientId)
        {
            Order target = new Order(clientId);
            return target;
            // TODO: add assertions to method OrderTest.ConstructorTest(String)
        }

        /// <summary>Test stub for .ctor(Int32, String)</summary>
        [PexMethod]
        public Order ConstructorTest01(int orderId, string clientId)
        {
            Order target = new Order(orderId, clientId);
            return target;
            // TODO: add assertions to method OrderTest.ConstructorTest01(Int32, String)
        }

        /// <summary>Test stub for .ctor(Int32, ICollection`1&lt;OrderLineItem&gt;, String, String, DateTime, DateTime, DateTime, Double, Double, Double)</summary>
        [PexMethod]
        public Order ConstructorTest02(
            int orderId,
            ICollection<OrderLineItem> orderLineItems,
            string clientId,
            string orderStatus,
            DateTime orderStatusChangedDate,
            DateTime estimatedCompletionDate,
            DateTime expectedOrderDate,
            double packageCost,
            double deliveryCost,
            double totalOrderPrice
        )
        {
            Order target = new Order(orderId, orderLineItems, clientId, orderStatus, orderStatusChangedDate,
                                     estimatedCompletionDate, expectedOrderDate, packageCost, deliveryCost, totalOrderPrice);
            return target;
            // TODO: add assertions to method OrderTest.ConstructorTest02(Int32, ICollection`1<OrderLineItem>, String, String, DateTime, DateTime, DateTime, Double, Double, Double)
        }

        /// <summary>Test stub for .ctor(Int32, String, String, DateTime, DateTime, DateTime, Double, Double, Double)</summary>
        [PexMethod]
        public Order ConstructorTest03(
            int orderId,
            string clientId,
            string orderStatus,
            DateTime orderStatusChangedDate,
            DateTime estimatedCompletionDate,
            DateTime expectedOrderDate,
            double packageCost,
            double deliveryCost,
            double totalOrderPrice
        )
        {
            Order target = new Order(orderId, clientId, orderStatus, orderStatusChangedDate,
                                     estimatedCompletionDate, expectedOrderDate, packageCost, deliveryCost, totalOrderPrice);
            return target;
            // TODO: add assertions to method OrderTest.ConstructorTest03(Int32, String, String, DateTime, DateTime, DateTime, Double, Double, Double)
        }

        /// <summary>Test stub for .ctor(List`1&lt;OrderLineItem&gt;, String, String, DateTime, DateTime, DateTime, Double, Double, Double)</summary>
        [PexMethod]
        public Order ConstructorTest04(
            List<OrderLineItem> lines,
            string clientId,
            string orderStatus,
            DateTime orderStatusChangedDate,
            DateTime estimatedCompletionDate,
            DateTime expectedOrderDate,
            double packageCost,
            double deliveryCost,
            double totalOrderPrice
        )
        {
            Order target = new Order(lines, clientId, orderStatus, orderStatusChangedDate,
                                     estimatedCompletionDate, expectedOrderDate, packageCost, deliveryCost, totalOrderPrice);
            return target;
            // TODO: add assertions to method OrderTest.ConstructorTest04(List`1<OrderLineItem>, String, String, DateTime, DateTime, DateTime, Double, Double, Double)
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public Order ConstructorTest05()
        {
            Order target = new Order();
            return target;
            // TODO: add assertions to method OrderTest.ConstructorTest05()
        }

        /// <summary>Test stub for .ctor(List`1&lt;OrderLineItem&gt;, String, DateTime)</summary>
        [PexMethod]
        public Order ConstructorTest06(
            List<OrderLineItem> lines,
            string clientId,
            DateTime expectedDate
        )
        {
            Order target = new Order(lines, clientId, expectedDate);
            return target;
            // TODO: add assertions to method OrderTest.ConstructorTest06(List`1<OrderLineItem>, String, DateTime)
        }

        /// <summary>Test stub for calculateTotalCost(List`1&lt;OrderLineItem&gt;)</summary>
        [PexMethod]
        public double calculateTotalCostTest([PexAssumeUnderTest] Order target, List<OrderLineItem> lines)
        {
            double result = target.calculateTotalCost(lines);
            return result;
            // TODO: add assertions to method OrderTest.calculateTotalCostTest(Order, List`1<OrderLineItem>)
        }

        /// <summary>Test stub for createOrder(List`1&lt;OrderLineItem&gt;, String, DateTime)</summary>
        [PexMethod]
        public int createOrderTest(
            [PexAssumeUnderTest] Order target,
            List<OrderLineItem> lines,
            string clientId,
            DateTime expectedDate
        )
        {
            int result = target.createOrder(lines, clientId, expectedDate);
            return result;
            // TODO: add assertions to method OrderTest.createOrderTest(Order, List`1<OrderLineItem>, String, DateTime)
        }

        /// <summary>Test stub for getAllOrders()</summary>
        [PexMethod]
        public DataTable getAllOrdersTest([PexAssumeUnderTest] Order target)
        {
            DataTable result = target.getAllOrders();
            return result;
            // TODO: add assertions to method OrderTest.getAllOrdersTest(Order)
        }

        /// <summary>Test stub for getCustomerOrdersById(String)</summary>
        [PexMethod]
        public DataTable getCustomerOrdersByIdTest([PexAssumeUnderTest] Order target, string clientId)
        {
            DataTable result = target.getCustomerOrdersById(clientId);
            return result;
            // TODO: add assertions to method OrderTest.getCustomerOrdersByIdTest(Order, String)
        }

        /// <summary>Test stub for getOrderById(Int32, String)</summary>
        [PexMethod]
        public Order getOrderByIdTest(
            [PexAssumeUnderTest] Order target,
            int orderId,
            string clientId
        )
        {
            Order result = target.getOrderById(orderId, clientId);
            return result;
            // TODO: add assertions to method OrderTest.getOrderByIdTest(Order, Int32, String)
        }

        /// <summary>Test stub for updateOrder(Double, Double, List`1&lt;OrderLineItem&gt;, Double, String, DateTime)</summary>
        [PexMethod]
        public void updateOrderTest(
            [PexAssumeUnderTest] Order target,
            double packageCost,
            double deliveryCost,
            List<OrderLineItem> lines,
            double totalCost,
            string status,
            DateTime estimatedCompletionDate
        )
        {
            target.updateOrder(packageCost, deliveryCost, lines, totalCost, status, estimatedCompletionDate);
            // TODO: add assertions to method OrderTest.updateOrderTest(Order, Double, Double, List`1<OrderLineItem>, Double, String, DateTime)
        }

        /// <summary>Test stub for validateOrderStatusChange(OrderStatus)</summary>
        [PexMethod]
        public string validateOrderStatusChangeTest([PexAssumeUnderTest] Order target, OrderStatus targetOrderStatus)
        {
            string result = target.validateOrderStatusChange(targetOrderStatus);
            return result;
            // TODO: add assertions to method OrderTest.validateOrderStatusChangeTest(Order, OrderStatus)
        }
    }
}
