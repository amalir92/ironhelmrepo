using Iron_helm_order_mgt.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class StateSwordsTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            StateSwords target = new StateSwords();
            Assert.IsNotNull(target);
        }
    }
}
