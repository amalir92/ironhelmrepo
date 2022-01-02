using Iron_helm_order_mgt;
using System;
using Iron_helm_order_mgt.Forms;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Forms.Tests
{
    /// <summary>This class contains parameterized unit tests for Schedule_Order_Form</summary>
    [TestClass]
    [PexClass(typeof(Schedule_Order_Form))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Schedule_Order_FormTest
    {

        /// <summary>Test stub for .ctor(Order)</summary>
        [PexMethod]
        public Schedule_Order_Form ConstructorTest(Order order)
        {
            Schedule_Order_Form target = new Schedule_Order_Form(order);
            return target;
            // TODO: add assertions to method Schedule_Order_FormTest.ConstructorTest(Order)
        }
    }
}
