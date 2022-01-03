using ironhelmrepo.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class CustomSwordTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            CustomSword target = new CustomSword();
            Assert.IsNotNull(target);
        }
    }
}
