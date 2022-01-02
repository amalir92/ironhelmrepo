using System;
using Iron_helm_order_mgt.Forms;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Forms.Tests
{
    /// <summary>This class contains parameterized unit tests for Customer_Details_Form</summary>
    [TestClass]
    [PexClass(typeof(Customer_Details_Form))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Customer_Details_FormTest
    {

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        public Customer_Details_Form ConstructorTest(string clientId)
        {
            Customer_Details_Form target = new Customer_Details_Form(clientId);
            return target;
            // TODO: add assertions to method Customer_Details_FormTest.ConstructorTest(String)
        }
    }
}
