using System;
using Iron_helm_order_mgt.Controls;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Controls.Tests
{
    /// <summary>This class contains parameterized unit tests for ApplicationState</summary>
    [TestClass]
    [PexClass(typeof(ApplicationState))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ApplicationStateTest
    {

        /// <summary>Test stub for getState()</summary>
        [PexMethod]
        public ApplicationState getStateTest()
        {
            ApplicationState result = ApplicationState.getState();
            return result;
            // TODO: add assertions to method ApplicationStateTest.getStateTest()
        }
    }
}
