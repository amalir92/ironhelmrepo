// <copyright file="ProductCatalogTest.cs">Copyright ©  2021</copyright>
using System;
using System.Data;
using Iron_helm_order_mgt;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Tests
{
    /// <summary>This class contains parameterized unit tests for ProductCatalog</summary>
    [PexClass(typeof(ProductCatalog))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProductCatalogTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public ProductCatalog ConstructorTest()
        {
            ProductCatalog target = new ProductCatalog();
            return target;
            // TODO: add assertions to method ProductCatalogTest.ConstructorTest()
        }

        /// <summary>Test stub for .ctor(String, String, String)</summary>
        [PexMethod]
        public ProductCatalog ConstructorTest01(
            string productId,
            string productName,
            string productDescription
        )
        {
            ProductCatalog target
               = new ProductCatalog(productId, productName, productDescription);
            return target;
            // TODO: add assertions to method ProductCatalogTest.ConstructorTest01(String, String, String)
        }

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        public ProductCatalog ConstructorTest02(string productId)
        {
            ProductCatalog target = new ProductCatalog(productId);
            return target;
            // TODO: add assertions to method ProductCatalogTest.ConstructorTest02(String)
        }

        /// <summary>Test stub for createNewProduct(String, String, String)</summary>
        [PexMethod]
        public ProductCatalog createNewProductTest(
            [PexAssumeUnderTest]ProductCatalog target,
            string productId,
            string productName,
            string productDescription
        )
        {
            ProductCatalog result
               = target.createNewProduct(productId, productName, productDescription);
            return result;
            // TODO: add assertions to method ProductCatalogTest.createNewProductTest(ProductCatalog, String, String, String)
        }

        /// <summary>Test stub for getAllProducts()</summary>
        [PexMethod]
        public DataTable getAllProductsTest([PexAssumeUnderTest]ProductCatalog target)
        {
            DataTable result = target.getAllProducts();
            return result;
            // TODO: add assertions to method ProductCatalogTest.getAllProductsTest(ProductCatalog)
        }

        /// <summary>Test stub for getProductById()</summary>
        [PexMethod]
        public ProductCatalog getProductByIdTest([PexAssumeUnderTest]ProductCatalog target)
        {
            ProductCatalog result = target.getProductById();
            return result;
            // TODO: add assertions to method ProductCatalogTest.getProductByIdTest(ProductCatalog)
        }
    }
}
