using System;
using Iron_helm_order_mgt.Factory;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Factory.Tests
{
    /// <summary>This class contains parameterized unit tests for StandardDelivery</summary>
    [TestClass]
    [PexClass(typeof(StandardDelivery))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StandardDeliveryTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public StandardDelivery ConstructorTest()
        {
            StandardDelivery target = new StandardDelivery();
            return target;
            // TODO: add assertions to method StandardDeliveryTest.ConstructorTest()
        }
    }
}
