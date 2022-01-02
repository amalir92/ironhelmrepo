using System.Collections.Generic;
using Iron_helm_order_mgt;
using System;
using Iron_helm_order_mgt.Factory;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Factory.Tests
{
    /// <summary>This class contains parameterized unit tests for OrderProduction</summary>
    [TestClass]
    [PexClass(typeof(OrderProduction))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class OrderProductionTest
    {

        /// <summary>Test stub for .ctor(IProductionFactory, List`1&lt;ProductCatalog&gt;)</summary>
        [PexMethod]
        public OrderProduction ConstructorTest(IProductionFactory factory, List<ProductCatalog> products)
        {
            OrderProduction target = new OrderProduction(factory, products);
            return target;
            // TODO: add assertions to method OrderProductionTest.ConstructorTest(IProductionFactory, List`1<ProductCatalog>)
        }

        /// <summary>Test stub for get_clientArmour()</summary>
        [PexMethod]
        public Armour clientArmourGetTest([PexAssumeUnderTest] OrderProduction target)
        {
            Armour result = target.clientArmour;
            return result;
            // TODO: add assertions to method OrderProductionTest.clientArmourGetTest(OrderProduction)
        }

        /// <summary>Test stub for get_clientDelivery()</summary>
        [PexMethod]
        public Delivery clientDeliveryGetTest([PexAssumeUnderTest] OrderProduction target)
        {
            Delivery result = target.clientDelivery;
            return result;
            // TODO: add assertions to method OrderProductionTest.clientDeliveryGetTest(OrderProduction)
        }

        /// <summary>Test stub for get_clientOrder()</summary>
        [PexMethod]
        public Order clientOrderGetTest([PexAssumeUnderTest] OrderProduction target)
        {
            Order result = target.clientOrder;
            return result;
            // TODO: add assertions to method OrderProductionTest.clientOrderGetTest(OrderProduction)
        }

        /// <summary>Test stub for get_clientPackaging()</summary>
        [PexMethod]
        public Packaging clientPackagingGetTest([PexAssumeUnderTest] OrderProduction target)
        {
            Packaging result = target.clientPackaging;
            return result;
            // TODO: add assertions to method OrderProductionTest.clientPackagingGetTest(OrderProduction)
        }

        /// <summary>Test stub for get_clientSwords()</summary>
        [PexMethod]
        public Swords clientSwordsGetTest([PexAssumeUnderTest] OrderProduction target)
        {
            Swords result = target.clientSwords;
            return result;
            // TODO: add assertions to method OrderProductionTest.clientSwordsGetTest(OrderProduction)
        }
    }
}
