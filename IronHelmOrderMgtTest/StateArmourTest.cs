using Iron_helm_order_mgt.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class StateArmourTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            StateArmour target = new StateArmour();
            Assert.IsNotNull(target);
        }
    }
}
