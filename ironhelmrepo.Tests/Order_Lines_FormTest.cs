using System;
using Iron_helm_order_mgt.Forms;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Forms.Tests
{
    /// <summary>This class contains parameterized unit tests for Order_Lines_Form</summary>
    [TestClass]
    [PexClass(typeof(Order_Lines_Form))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Order_Lines_FormTest
    {

        /// <summary>Test stub for .ctor(Int32, String)</summary>
        [PexMethod]
        public Order_Lines_Form ConstructorTest(int orderId, string clientId)
        {
            Order_Lines_Form target = new Order_Lines_Form(orderId, clientId);
            return target;
            // TODO: add assertions to method Order_Lines_FormTest.ConstructorTest(Int32, String)
        }

        /// <summary>Test stub for get_clientId()</summary>
        [PexMethod]
        public string clientIdGetTest([PexAssumeUnderTest] Order_Lines_Form target)
        {
            string result = target.clientId;
            return result;
            // TODO: add assertions to method Order_Lines_FormTest.clientIdGetTest(Order_Lines_Form)
        }

        /// <summary>Test stub for get_orderId()</summary>
        [PexMethod]
        public int orderIdGetTest([PexAssumeUnderTest] Order_Lines_Form target)
        {
            int result = target.orderId;
            return result;
            // TODO: add assertions to method Order_Lines_FormTest.orderIdGetTest(Order_Lines_Form)
        }

        /// <summary>Test stub for set_clientId(String)</summary>
        [PexMethod]
        public void clientIdSetTest([PexAssumeUnderTest] Order_Lines_Form target, string value)
        {
            target.clientId = value;
            // TODO: add assertions to method Order_Lines_FormTest.clientIdSetTest(Order_Lines_Form, String)
        }

        /// <summary>Test stub for set_orderId(Int32)</summary>
        [PexMethod]
        public void orderIdSetTest([PexAssumeUnderTest] Order_Lines_Form target, int value)
        {
            target.orderId = value;
            // TODO: add assertions to method Order_Lines_FormTest.orderIdSetTest(Order_Lines_Form, Int32)
        }
    }
}
