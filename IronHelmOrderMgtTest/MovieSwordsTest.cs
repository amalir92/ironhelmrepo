using Iron_helm_order_mgt.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class MovieSwordsTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            MovieSwords target = new MovieSwords();
            Assert.IsNotNull(target);
            
        }
    }
}
