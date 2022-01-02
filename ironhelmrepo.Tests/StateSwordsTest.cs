using System;
using Iron_helm_order_mgt.Factory;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Factory.Tests
{
    /// <summary>This class contains parameterized unit tests for StateSwords</summary>
    [TestClass]
    [PexClass(typeof(StateSwords))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StateSwordsTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public StateSwords ConstructorTest()
        {
            StateSwords target = new StateSwords();
            return target;
            // TODO: add assertions to method StateSwordsTest.ConstructorTest()
        }
    }
}
