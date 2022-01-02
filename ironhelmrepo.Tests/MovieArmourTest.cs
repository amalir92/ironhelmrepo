using System;
using Iron_helm_order_mgt.Factory;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Factory.Tests
{
    /// <summary>This class contains parameterized unit tests for MovieArmour</summary>
    [TestClass]
    [PexClass(typeof(MovieArmour))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MovieArmourTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public MovieArmour ConstructorTest()
        {
            MovieArmour target = new MovieArmour();
            return target;
            // TODO: add assertions to method MovieArmourTest.ConstructorTest()
        }
    }
}
