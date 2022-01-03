using Iron_helm_order_mgt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void ConstructorTest05()
        {
            Order target = new Order();
            Assert.IsNotNull(target);
        }

        [DataTestMethod]
        [DataRow("001C")]
        public void ConstructorTest(string clientId)
        {
            Order target = new Order(clientId);
            Assert.IsNotNull(target);
        }

        [DataTestMethod]
        [DataRow(100, "001C")]
        public void ConstructorTest01(int orderId, string clientId)
        {
            Order target = new Order(orderId, clientId);
            Assert.IsNotNull(target);
        }

        [DataTestMethod]
        [DataRow(100, "001C","NEW",null, null,null,10,10,10)]
        public void ConstructorTest03(
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
            Assert.IsNotNull(target);
        }



    }
}
