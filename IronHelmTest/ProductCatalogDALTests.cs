using Iron_helm_order_mgt;
using Iron_helm_order_mgt.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Linq;

namespace IronHelmTest
{
    [TestClass]
    public class ProductCatalogDALTests
    {
        [TestMethod]
        public void getProductById_productNotInDB()
        {
            string productId = "111";

            ProductCatalogDAL productCatalogDAL = new ProductCatalogDAL();
            ProductCatalog productCatalog = productCatalogDAL.getProductById(productId);
            Assert.IsNull(productCatalog);
        }

        [TestMethod]
        public void getProductById_productInDB()
        {
            String productId = "";
            IronHelmDbContext context = new IronHelmDbContext();
            if (context.orderLineItems.Count() != 0)
            {
                productId = context.ProductCatalogs.Max(table => table.productId);
            }

            ProductCatalogDAL productCatalogDAL = new ProductCatalogDAL();
            ProductCatalog productCatalog = productCatalogDAL.getProductById(productId);
            Assert.IsNotNull(productCatalog);
        }

        [TestMethod]
        public void getAllPoducts_productsInDB()
        {
            String productId = "";
            IronHelmDbContext context = new IronHelmDbContext();
            if (context.orderLineItems.Count() != 0)
            {
                productId = context.ProductCatalogs.Max(table => table.productId);
            }

            ProductCatalogDAL productCatalogDAL = new ProductCatalogDAL();
            DataTable dataTable = productCatalogDAL.getAllPoducts();
            Assert.IsTrue(dataTable.Rows.Count>0);
        }

        [TestMethod]
        public void getAllPoducts_productsNotInDB()
        {
            String productId = "";
            IronHelmDbContext context = new IronHelmDbContext();
            if (context.orderLineItems.Count() != 0)
            {
                productId = context.ProductCatalogs.Max(table => table.productId);
            }

            ProductCatalogDAL productCatalogDAL = new ProductCatalogDAL();
            DataTable dataTable = productCatalogDAL.getAllPoducts();
            Assert.IsTrue(dataTable.Rows.Count==0);
        }
    }
}
