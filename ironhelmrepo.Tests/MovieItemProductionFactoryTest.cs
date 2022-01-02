using System;
using Iron_helm_order_mgt.Factory;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Factory.Tests
{
    /// <summary>This class contains parameterized unit tests for MovieItemProductionFactory</summary>
    [TestClass]
    [PexClass(typeof(MovieItemProductionFactory))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MovieItemProductionFactoryTest
    {

        /// <summary>Test stub for createDelivery()</summary>
        [PexMethod]
        public Delivery createDeliveryTest([PexAssumeUnderTest] MovieItemProductionFactory target)
        {
            Delivery result = target.createDelivery();
            return result;
            // TODO: add assertions to method MovieItemProductionFactoryTest.createDeliveryTest(MovieItemProductionFactory)
        }

        /// <summary>Test stub for createPackaging()</summary>
        [PexMethod]
        public Packaging createPackagingTest([PexAssumeUnderTest] MovieItemProductionFactory target)
        {
            Packaging result = target.createPackaging();
            return result;
            // TODO: add assertions to method MovieItemProductionFactoryTest.createPackagingTest(MovieItemProductionFactory)
        }

        /// <summary>Test stub for manufactureArmour()</summary>
        [PexMethod]
        public Armour manufactureArmourTest([PexAssumeUnderTest] MovieItemProductionFactory target)
        {
            Armour result = target.manufactureArmour();
            return result;
            // TODO: add assertions to method MovieItemProductionFactoryTest.manufactureArmourTest(MovieItemProductionFactory)
        }

        /// <summary>Test stub for manufactureSwords()</summary>
        [PexMethod]
        public Swords manufactureSwordsTest([PexAssumeUnderTest] MovieItemProductionFactory target)
        {
            Swords result = target.manufactureSwords();
            return result;
            // TODO: add assertions to method MovieItemProductionFactoryTest.manufactureSwordsTest(MovieItemProductionFactory)
        }
    }
}
