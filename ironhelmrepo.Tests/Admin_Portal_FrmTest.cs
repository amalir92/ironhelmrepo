using System;
using Iron_helm_order_mgt;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Tests
{
    /// <summary>This class contains parameterized unit tests for Admin_Portal_Frm</summary>
    [TestClass]
    [PexClass(typeof(Admin_Portal_Frm))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Admin_Portal_FrmTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public Admin_Portal_Frm ConstructorTest()
        {
            Admin_Portal_Frm target = new Admin_Portal_Frm();
            return target;
            // TODO: add assertions to method Admin_Portal_FrmTest.ConstructorTest()
        }

        /// <summary>Test stub for get_clientId()</summary>
        [PexMethod]
        public string clientIdGetTest([PexAssumeUnderTest] Admin_Portal_Frm target)
        {
            string result = target.clientId;
            return result;
            // TODO: add assertions to method Admin_Portal_FrmTest.clientIdGetTest(Admin_Portal_Frm)
        }

        /// <summary>Test stub for get_orderId()</summary>
        [PexMethod]
        public int orderIdGetTest([PexAssumeUnderTest] Admin_Portal_Frm target)
        {
            int result = target.orderId;
            return result;
            // TODO: add assertions to method Admin_Portal_FrmTest.orderIdGetTest(Admin_Portal_Frm)
        }

        /// <summary>Test stub for get_orderStatus()</summary>
        [PexMethod]
        public string orderStatusGetTest([PexAssumeUnderTest] Admin_Portal_Frm target)
        {
            string result = target.orderStatus;
            return result;
            // TODO: add assertions to method Admin_Portal_FrmTest.orderStatusGetTest(Admin_Portal_Frm)
        }

        /// <summary>Test stub for set_clientId(String)</summary>
        [PexMethod]
        public void clientIdSetTest([PexAssumeUnderTest] Admin_Portal_Frm target, string value)
        {
            target.clientId = value;
            // TODO: add assertions to method Admin_Portal_FrmTest.clientIdSetTest(Admin_Portal_Frm, String)
        }

        /// <summary>Test stub for set_orderId(Int32)</summary>
        [PexMethod]
        public void orderIdSetTest([PexAssumeUnderTest] Admin_Portal_Frm target, int value)
        {
            target.orderId = value;
            // TODO: add assertions to method Admin_Portal_FrmTest.orderIdSetTest(Admin_Portal_Frm, Int32)
        }

        /// <summary>Test stub for set_orderStatus(String)</summary>
        [PexMethod]
        public void orderStatusSetTest([PexAssumeUnderTest] Admin_Portal_Frm target, string value)
        {
            target.orderStatus = value;
            // TODO: add assertions to method Admin_Portal_FrmTest.orderStatusSetTest(Admin_Portal_Frm, String)
        }
    }
}
