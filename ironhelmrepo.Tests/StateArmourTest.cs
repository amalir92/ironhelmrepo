using System;
using Iron_helm_order_mgt.Factory;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Factory.Tests
{
    /// <summary>This class contains parameterized unit tests for StateArmour</summary>
    [TestClass]
    [PexClass(typeof(StateArmour))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StateArmourTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public StateArmour ConstructorTest()
        {
            StateArmour target = new StateArmour();
            return target;
            // TODO: add assertions to method StateArmourTest.ConstructorTest()
        }
    }
}
