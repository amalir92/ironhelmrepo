using System;
using Iron_helm_order_mgt;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Tests
{
    /// <summary>This class contains parameterized unit tests for ClientPortal_Frm</summary>
    [TestClass]
    [PexClass(typeof(ClientPortal_Frm))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ClientPortal_FrmTest
    {

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        public ClientPortal_Frm ConstructorTest(string clientId)
        {
            ClientPortal_Frm target = new ClientPortal_Frm(clientId);
            return target;
            // TODO: add assertions to method ClientPortal_FrmTest.ConstructorTest(String)
        }

        /// <summary>Test stub for get_clientId()</summary>
        [PexMethod]
        public string clientIdGetTest([PexAssumeUnderTest] ClientPortal_Frm target)
        {
            string result = target.clientId;
            return result;
            // TODO: add assertions to method ClientPortal_FrmTest.clientIdGetTest(ClientPortal_Frm)
        }

        /// <summary>Test stub for get_orderId()</summary>
        [PexMethod]
        public int orderIdGetTest([PexAssumeUnderTest] ClientPortal_Frm target)
        {
            int result = target.orderId;
            return result;
            // TODO: add assertions to method ClientPortal_FrmTest.orderIdGetTest(ClientPortal_Frm)
        }

        /// <summary>Test stub for get_orderStatus()</summary>
        [PexMethod]
        public string orderStatusGetTest([PexAssumeUnderTest] ClientPortal_Frm target)
        {
            string result = target.orderStatus;
            return result;
            // TODO: add assertions to method ClientPortal_FrmTest.orderStatusGetTest(ClientPortal_Frm)
        }

        /// <summary>Test stub for set_clientId(String)</summary>
        [PexMethod]
        public void clientIdSetTest([PexAssumeUnderTest] ClientPortal_Frm target, string value)
        {
            target.clientId = value;
            // TODO: add assertions to method ClientPortal_FrmTest.clientIdSetTest(ClientPortal_Frm, String)
        }

        /// <summary>Test stub for set_orderId(Int32)</summary>
        [PexMethod]
        public void orderIdSetTest([PexAssumeUnderTest] ClientPortal_Frm target, int value)
        {
            target.orderId = value;
            // TODO: add assertions to method ClientPortal_FrmTest.orderIdSetTest(ClientPortal_Frm, Int32)
        }

        /// <summary>Test stub for set_orderStatus(String)</summary>
        [PexMethod]
        public void orderStatusSetTest([PexAssumeUnderTest] ClientPortal_Frm target, string value)
        {
            target.orderStatus = value;
            // TODO: add assertions to method ClientPortal_FrmTest.orderStatusSetTest(ClientPortal_Frm, String)
        }
    }
}
