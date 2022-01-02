using System;
using Iron_helm_order_mgt.Factory;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Factory.Tests
{
    /// <summary>This class contains parameterized unit tests for GovernmentItemProductionFactory</summary>
    [TestClass]
    [PexClass(typeof(GovernmentItemProductionFactory))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GovernmentItemProductionFactoryTest
    {

        /// <summary>Test stub for createDelivery()</summary>
        [PexMethod]
        public Delivery createDeliveryTest([PexAssumeUnderTest] GovernmentItemProductionFactory target)
        {
            Delivery result = target.createDelivery();
            return result;
            // TODO: add assertions to method GovernmentItemProductionFactoryTest.createDeliveryTest(GovernmentItemProductionFactory)
        }

        /// <summary>Test stub for createPackaging()</summary>
        [PexMethod]
        public Packaging createPackagingTest([PexAssumeUnderTest] GovernmentItemProductionFactory target)
        {
            Packaging result = target.createPackaging();
            return result;
            // TODO: add assertions to method GovernmentItemProductionFactoryTest.createPackagingTest(GovernmentItemProductionFactory)
        }

        /// <summary>Test stub for manufactureArmour()</summary>
        [PexMethod]
        public Armour manufactureArmourTest([PexAssumeUnderTest] GovernmentItemProductionFactory target)
        {
            Armour result = target.manufactureArmour();
            return result;
            // TODO: add assertions to method GovernmentItemProductionFactoryTest.manufactureArmourTest(GovernmentItemProductionFactory)
        }

        /// <summary>Test stub for manufactureSwords()</summary>
        [PexMethod]
        public Swords manufactureSwordsTest([PexAssumeUnderTest] GovernmentItemProductionFactory target)
        {
            Swords result = target.manufactureSwords();
            return result;
            // TODO: add assertions to method GovernmentItemProductionFactoryTest.manufactureSwordsTest(GovernmentItemProductionFactory)
        }
    }
}
