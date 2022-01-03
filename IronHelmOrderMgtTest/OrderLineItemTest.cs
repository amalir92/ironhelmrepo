using Iron_helm_order_mgt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class OrderLineItemTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            OrderLineItem target = new OrderLineItem();
            Assert.IsNotNull(target);
        }

        [DataTestMethod]
        [DataRow("001P", 10)]
        public void ConstructorTest03(string productCode, int quantity)
        {
            OrderLineItem target = new OrderLineItem(productCode, quantity);
            Assert.IsNotNull(target);
        }
    }
}
