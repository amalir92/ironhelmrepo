using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ironhelmrepo.Factory;

namespace ironhelmrepo.Factory.Tests
{
    /// <summary>This class contains parameterized unit tests for CustomSword</summary>
    [TestClass]
    [PexClass(typeof(CustomSword))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CustomSwordTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public CustomSword ConstructorTest()
        {
            CustomSword target = new CustomSword();
            return target;
            // TODO: add assertions to method CustomSwordTest.ConstructorTest()
        }
    }
}
