using Iron_helm_order_mgt;
using Iron_helm_order_mgt.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class ProductCatalogTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            ProductCatalog target = new ProductCatalog();
            Assert.IsNotNull(target);
        }

        [DataTestMethod]
        [DataRow("001P", "sword", "sword")]
        public void ConstructorTest01(
            string productId,
            string productName,
            string productDescription
        )
        {
            ProductCatalog target
               = new ProductCatalog(productId, productName, productDescription);
            Assert.IsNotNull(target);
        }

        [DataTestMethod]
        [DataRow("001P")]
        public void ConstructorTest02(string productId)
        {
            ProductCatalog target = new ProductCatalog(productId);
            Assert.IsNotNull(target);
        }

    }
}
