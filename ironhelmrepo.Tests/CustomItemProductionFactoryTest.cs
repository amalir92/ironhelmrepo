using Iron_helm_order_mgt.Factory;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ironhelmrepo.Factory;

namespace ironhelmrepo.Factory.Tests
{
    /// <summary>This class contains parameterized unit tests for CustomItemProductionFactory</summary>
    [TestClass]
    [PexClass(typeof(CustomItemProductionFactory))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CustomItemProductionFactoryTest
    {

        /// <summary>Test stub for createDelivery()</summary>
        [PexMethod]
        public Delivery createDeliveryTest([PexAssumeUnderTest] CustomItemProductionFactory target)
        {
            Delivery result = target.createDelivery();
            return result;
            // TODO: add assertions to method CustomItemProductionFactoryTest.createDeliveryTest(CustomItemProductionFactory)
        }

        /// <summary>Test stub for createPackaging()</summary>
        [PexMethod]
        public Packaging createPackagingTest([PexAssumeUnderTest] CustomItemProductionFactory target)
        {
            Packaging result = target.createPackaging();
            return result;
            // TODO: add assertions to method CustomItemProductionFactoryTest.createPackagingTest(CustomItemProductionFactory)
        }

        /// <summary>Test stub for manufactureArmour()</summary>
        [PexMethod]
        public Armour manufactureArmourTest([PexAssumeUnderTest] CustomItemProductionFactory target)
        {
            Armour result = target.manufactureArmour();
            return result;
            // TODO: add assertions to method CustomItemProductionFactoryTest.manufactureArmourTest(CustomItemProductionFactory)
        }

        /// <summary>Test stub for manufactureSwords()</summary>
        [PexMethod]
        public Swords manufactureSwordsTest([PexAssumeUnderTest] CustomItemProductionFactory target)
        {
            Swords result = target.manufactureSwords();
            return result;
            // TODO: add assertions to method CustomItemProductionFactoryTest.manufactureSwordsTest(CustomItemProductionFactory)
        }
    }
}
