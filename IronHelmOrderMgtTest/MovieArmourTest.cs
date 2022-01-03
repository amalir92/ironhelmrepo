using Iron_helm_order_mgt.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class MovieArmourTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            MovieArmour target = new MovieArmour();
            Assert.IsNotNull(target);
        }
    }
}
