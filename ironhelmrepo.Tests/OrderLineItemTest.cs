using System.Data;
using System.Collections.Generic;
using System;
using Iron_helm_order_mgt;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Tests
{
    /// <summary>This class contains parameterized unit tests for OrderLineItem</summary>
    [TestClass]
    [PexClass(typeof(OrderLineItem))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class OrderLineItemTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public OrderLineItem ConstructorTest()
        {
            OrderLineItem target = new OrderLineItem();
            return target;
            // TODO: add assertions to method OrderLineItemTest.ConstructorTest()
        }

        /// <summary>Test stub for .ctor(Order)</summary>
        [PexMethod]
        public OrderLineItem ConstructorTest01(Order orderId)
        {
            OrderLineItem target = new OrderLineItem(orderId);
            return target;
            // TODO: add assertions to method OrderLineItemTest.ConstructorTest01(Order)
        }

        /// <summary>Test stub for .ctor(Int32, Order, String, Int32, Int32, Double)</summary>
        [PexMethod]
        public OrderLineItem ConstructorTest02(
            int orderLineItemId,
            Order orderId,
            string productCode,
            int quantity,
            int labourHoursPerItem,
            double costPerHour
        )
        {
            OrderLineItem target = new OrderLineItem
                                       (orderLineItemId, orderId, productCode, quantity, labourHoursPerItem, costPerHour);
            return target;
            // TODO: add assertions to method OrderLineItemTest.ConstructorTest02(Int32, Order, String, Int32, Int32, Double)
        }

        /// <summary>Test stub for .ctor(String, Int32)</summary>
        [PexMethod]
        public OrderLineItem ConstructorTest03(string productCode, int quantity)
        {
            OrderLineItem target = new OrderLineItem(productCode, quantity);
            return target;
            // TODO: add assertions to method OrderLineItemTest.ConstructorTest03(String, Int32)
        }

        /// <summary>Test stub for calculateCostPerItemProduction()</summary>
        [PexMethod]
        public double calculateCostPerItemProductionTest([PexAssumeUnderTest] OrderLineItem target)
        {
            double result = target.calculateCostPerItemProduction();
            return result;
            // TODO: add assertions to method OrderLineItemTest.calculateCostPerItemProductionTest(OrderLineItem)
        }

        /// <summary>Test stub for getOrderLinesByOrderId(Int32, String)</summary>
        [PexMethod]
        public List<OrderLineItem> getOrderLinesByOrderIdTest(
            [PexAssumeUnderTest] OrderLineItem target,
            int orderId,
            string clientId
        )
        {
            List<OrderLineItem> result = target.getOrderLinesByOrderId(orderId, clientId);
            return result;
            // TODO: add assertions to method OrderLineItemTest.getOrderLinesByOrderIdTest(OrderLineItem, Int32, String)
        }

        /// <summary>Test stub for getOrderLinesTableByOrderId(Int32, String)</summary>
        [PexMethod]
        public DataTable getOrderLinesTableByOrderIdTest(
            [PexAssumeUnderTest] OrderLineItem target,
            int orderId,
            string clientId
        )
        {
            DataTable result = target.getOrderLinesTableByOrderId(orderId, clientId);
            return result;
            // TODO: add assertions to method OrderLineItemTest.getOrderLinesTableByOrderIdTest(OrderLineItem, Int32, String)
        }

        /// <summary>Test stub for updateOrderLine()</summary>
        [PexMethod]
        public void updateOrderLineTest([PexAssumeUnderTest] OrderLineItem target)
        {
            target.updateOrderLine();
            // TODO: add assertions to method OrderLineItemTest.updateOrderLineTest(OrderLineItem)
        }
    }
}
