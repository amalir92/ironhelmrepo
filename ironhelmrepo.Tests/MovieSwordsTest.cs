using System;
using Iron_helm_order_mgt.Factory;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Factory.Tests
{
    /// <summary>This class contains parameterized unit tests for MovieSwords</summary>
    [TestClass]
    [PexClass(typeof(MovieSwords))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MovieSwordsTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public MovieSwords ConstructorTest()
        {
            MovieSwords target = new MovieSwords();
            return target;
            // TODO: add assertions to method MovieSwordsTest.ConstructorTest()
        }
    }
}
