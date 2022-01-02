using Iron_helm_order_mgt;
using System;
using Iron_helm_order_mgt.Forms;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Forms.Tests
{
    /// <summary>This class contains parameterized unit tests for Order_Progress_Form</summary>
    [TestClass]
    [PexClass(typeof(Order_Progress_Form))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Order_Progress_FormTest
    {

        /// <summary>Test stub for .ctor(Order)</summary>
        [PexMethod]
        public Order_Progress_Form ConstructorTest(Order order)
        {
            Order_Progress_Form target = new Order_Progress_Form(order);
            return target;
            // TODO: add assertions to method Order_Progress_FormTest.ConstructorTest(Order)
        }

        /// <summary>Test stub for order_process()</summary>
        [PexMethod]
        public void order_processTest([PexAssumeUnderTest] Order_Progress_Form target)
        {
            target.order_process();
            // TODO: add assertions to method Order_Progress_FormTest.order_processTest(Order_Progress_Form)
        }
    }
}
