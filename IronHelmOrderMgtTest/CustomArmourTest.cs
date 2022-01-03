using ironhelmrepo.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class CustomArmourTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            CustomArmour target = new CustomArmour();
            Assert.IsNotNull(target);
        }
    }
}
