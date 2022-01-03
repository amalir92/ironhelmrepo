using Iron_helm_order_mgt.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class StandardDeliveryTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            StandardDelivery target = new StandardDelivery();
            Assert.IsNotNull(target);
        }
    }
}
