using System;
using Iron_helm_order_mgt.Factory;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Factory.Tests
{
    /// <summary>This class contains parameterized unit tests for StandardPackaging</summary>
    [TestClass]
    [PexClass(typeof(StandardPackaging))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StandardPackagingTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public StandardPackaging ConstructorTest()
        {
            StandardPackaging target = new StandardPackaging();
            return target;
            // TODO: add assertions to method StandardPackagingTest.ConstructorTest()
        }
    }
}
