using System;
using Iron_helm_order_mgt;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Tests
{
    /// <summary>This class contains parameterized unit tests for Login_frm</summary>
    [TestClass]
    [PexClass(typeof(Login_frm))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Login_frmTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public Login_frm ConstructorTest()
        {
            Login_frm target = new Login_frm();
            return target;
            // TODO: add assertions to method Login_frmTest.ConstructorTest()
        }
    }
}
