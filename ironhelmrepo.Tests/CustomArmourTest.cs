using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ironhelmrepo.Factory;

namespace ironhelmrepo.Factory.Tests
{
    /// <summary>This class contains parameterized unit tests for CustomArmour</summary>
    [TestClass]
    [PexClass(typeof(CustomArmour))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CustomArmourTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public CustomArmour ConstructorTest()
        {
            CustomArmour target = new CustomArmour();
            return target;
            // TODO: add assertions to method CustomArmourTest.ConstructorTest()
        }
    }
}
