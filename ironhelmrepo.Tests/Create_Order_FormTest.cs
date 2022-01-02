using System.Collections.Generic;
using System;
using Iron_helm_order_mgt;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Tests
{
    /// <summary>This class contains parameterized unit tests for Create_Order_Form</summary>
    [TestClass]
    [PexClass(typeof(Create_Order_Form))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Create_Order_FormTest
    {

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        public Create_Order_Form ConstructorTest(string clientId)
        {
            Create_Order_Form target = new Create_Order_Form(clientId);
            return target;
            // TODO: add assertions to method Create_Order_FormTest.ConstructorTest(String)
        }

        /// <summary>Test stub for get_expectedOrderCompletionDate()</summary>
        [PexMethod]
        public DateTime expectedOrderCompletionDateGetTest([PexAssumeUnderTest] Create_Order_Form target)
        {
            DateTime result = target.expectedOrderCompletionDate;
            return result;
            // TODO: add assertions to method Create_Order_FormTest.expectedOrderCompletionDateGetTest(Create_Order_Form)
        }

        /// <summary>Test stub for get_orderLines()</summary>
        [PexMethod]
        public List<OrderLineItem> orderLinesGetTest([PexAssumeUnderTest] Create_Order_Form target)
        {
            List<OrderLineItem> result = target.orderLines;
            return result;
            // TODO: add assertions to method Create_Order_FormTest.orderLinesGetTest(Create_Order_Form)
        }

        /// <summary>Test stub for set_expectedOrderCompletionDate(DateTime)</summary>
        [PexMethod]
        public void expectedOrderCompletionDateSetTest([PexAssumeUnderTest] Create_Order_Form target, DateTime value)
        {
            target.expectedOrderCompletionDate = value;
            // TODO: add assertions to method Create_Order_FormTest.expectedOrderCompletionDateSetTest(Create_Order_Form, DateTime)
        }

        /// <summary>Test stub for set_orderLines(List`1&lt;OrderLineItem&gt;)</summary>
        [PexMethod]
        public void orderLinesSetTest([PexAssumeUnderTest] Create_Order_Form target, List<OrderLineItem> value)
        {
            target.orderLines = value;
            // TODO: add assertions to method Create_Order_FormTest.orderLinesSetTest(Create_Order_Form, List`1<OrderLineItem>)
        }
    }
}
