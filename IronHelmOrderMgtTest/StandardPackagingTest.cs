using Iron_helm_order_mgt.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class StandardPackagingTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            StandardPackaging target = new StandardPackaging();
            Assert.IsNotNull(target);
        }
    }
}
