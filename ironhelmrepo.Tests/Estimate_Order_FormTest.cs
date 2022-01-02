using Iron_helm_order_mgt;
using System;
using Iron_helm_order_mgt.Forms;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Forms.Tests
{
    /// <summary>This class contains parameterized unit tests for Estimate_Order_Form</summary>
    [TestClass]
    [PexClass(typeof(Estimate_Order_Form))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Estimate_Order_FormTest
    {

        /// <summary>Test stub for .ctor(Order)</summary>
        [PexMethod]
        public Estimate_Order_Form ConstructorTest(Order order)
        {
            Estimate_Order_Form target = new Estimate_Order_Form(order);
            return target;
            // TODO: add assertions to method Estimate_Order_FormTest.ConstructorTest(Order)
        }

        /// <summary>Test stub for get_clientId()</summary>
        [PexMethod]
        public string clientIdGetTest([PexAssumeUnderTest] Estimate_Order_Form target)
        {
            string result = target.clientId;
            return result;
            // TODO: add assertions to method Estimate_Order_FormTest.clientIdGetTest(Estimate_Order_Form)
        }

        /// <summary>Test stub for get_costPerHour()</summary>
        [PexMethod]
        public double costPerHourGetTest([PexAssumeUnderTest] Estimate_Order_Form target)
        {
            double result = target.costPerHour;
            return result;
            // TODO: add assertions to method Estimate_Order_FormTest.costPerHourGetTest(Estimate_Order_Form)
        }

        /// <summary>Test stub for get_deliveryCost()</summary>
        [PexMethod]
        public double deliveryCostGetTest([PexAssumeUnderTest] Estimate_Order_Form target)
        {
            double result = target.deliveryCost;
            return result;
            // TODO: add assertions to method Estimate_Order_FormTest.deliveryCostGetTest(Estimate_Order_Form)
        }

        /// <summary>Test stub for get_estimatedDate()</summary>
        [PexMethod]
        public DateTime estimatedDateGetTest([PexAssumeUnderTest] Estimate_Order_Form target)
        {
            DateTime result = target.estimatedDate;
            return result;
            // TODO: add assertions to method Estimate_Order_FormTest.estimatedDateGetTest(Estimate_Order_Form)
        }

        /// <summary>Test stub for get_hours()</summary>
        [PexMethod]
        public int hoursGetTest([PexAssumeUnderTest] Estimate_Order_Form target)
        {
            int result = target.hours;
            return result;
            // TODO: add assertions to method Estimate_Order_FormTest.hoursGetTest(Estimate_Order_Form)
        }

        /// <summary>Test stub for get_orderId()</summary>
        [PexMethod]
        public int orderIdGetTest([PexAssumeUnderTest] Estimate_Order_Form target)
        {
            int result = target.orderId;
            return result;
            // TODO: add assertions to method Estimate_Order_FormTest.orderIdGetTest(Estimate_Order_Form)
        }

        /// <summary>Test stub for get_orderStatus()</summary>
        [PexMethod]
        public string orderStatusGetTest([PexAssumeUnderTest] Estimate_Order_Form target)
        {
            string result = target.orderStatus;
            return result;
            // TODO: add assertions to method Estimate_Order_FormTest.orderStatusGetTest(Estimate_Order_Form)
        }

        /// <summary>Test stub for get_packageCost()</summary>
        [PexMethod]
        public double packageCostGetTest([PexAssumeUnderTest] Estimate_Order_Form target)
        {
            double result = target.packageCost;
            return result;
            // TODO: add assertions to method Estimate_Order_FormTest.packageCostGetTest(Estimate_Order_Form)
        }

        /// <summary>Test stub for get_productCode()</summary>
        [PexMethod]
        public string productCodeGetTest([PexAssumeUnderTest] Estimate_Order_Form target)
        {
            string result = target.productCode;
            return result;
            // TODO: add assertions to method Estimate_Order_FormTest.productCodeGetTest(Estimate_Order_Form)
        }

        /// <summary>Test stub for get_quantity()</summary>
        [PexMethod]
        public int quantityGetTest([PexAssumeUnderTest] Estimate_Order_Form target)
        {
            int result = target.quantity;
            return result;
            // TODO: add assertions to method Estimate_Order_FormTest.quantityGetTest(Estimate_Order_Form)
        }

        /// <summary>Test stub for get_totalCost()</summary>
        [PexMethod]
        public double totalCostGetTest([PexAssumeUnderTest] Estimate_Order_Form target)
        {
            double result = target.totalCost;
            return result;
            // TODO: add assertions to method Estimate_Order_FormTest.totalCostGetTest(Estimate_Order_Form)
        }

        /// <summary>Test stub for set_clientId(String)</summary>
        [PexMethod]
        public void clientIdSetTest([PexAssumeUnderTest] Estimate_Order_Form target, string value)
        {
            target.clientId = value;
            // TODO: add assertions to method Estimate_Order_FormTest.clientIdSetTest(Estimate_Order_Form, String)
        }

        /// <summary>Test stub for set_costPerHour(Double)</summary>
        [PexMethod]
        public void costPerHourSetTest([PexAssumeUnderTest] Estimate_Order_Form target, double value)
        {
            target.costPerHour = value;
            // TODO: add assertions to method Estimate_Order_FormTest.costPerHourSetTest(Estimate_Order_Form, Double)
        }

        /// <summary>Test stub for set_deliveryCost(Double)</summary>
        [PexMethod]
        public void deliveryCostSetTest([PexAssumeUnderTest] Estimate_Order_Form target, double value)
        {
            target.deliveryCost = value;
            // TODO: add assertions to method Estimate_Order_FormTest.deliveryCostSetTest(Estimate_Order_Form, Double)
        }

        /// <summary>Test stub for set_estimatedDate(DateTime)</summary>
        [PexMethod]
        public void estimatedDateSetTest([PexAssumeUnderTest] Estimate_Order_Form target, DateTime value)
        {
            target.estimatedDate = value;
            // TODO: add assertions to method Estimate_Order_FormTest.estimatedDateSetTest(Estimate_Order_Form, DateTime)
        }

        /// <summary>Test stub for set_hours(Int32)</summary>
        [PexMethod]
        public void hoursSetTest([PexAssumeUnderTest] Estimate_Order_Form target, int value)
        {
            target.hours = value;
            // TODO: add assertions to method Estimate_Order_FormTest.hoursSetTest(Estimate_Order_Form, Int32)
        }

        /// <summary>Test stub for set_orderId(Int32)</summary>
        [PexMethod]
        public void orderIdSetTest([PexAssumeUnderTest] Estimate_Order_Form target, int value)
        {
            target.orderId = value;
            // TODO: add assertions to method Estimate_Order_FormTest.orderIdSetTest(Estimate_Order_Form, Int32)
        }

        /// <summary>Test stub for set_orderStatus(String)</summary>
        [PexMethod]
        public void orderStatusSetTest([PexAssumeUnderTest] Estimate_Order_Form target, string value)
        {
            target.orderStatus = value;
            // TODO: add assertions to method Estimate_Order_FormTest.orderStatusSetTest(Estimate_Order_Form, String)
        }

        /// <summary>Test stub for set_packageCost(Double)</summary>
        [PexMethod]
        public void packageCostSetTest([PexAssumeUnderTest] Estimate_Order_Form target, double value)
        {
            target.packageCost = value;
            // TODO: add assertions to method Estimate_Order_FormTest.packageCostSetTest(Estimate_Order_Form, Double)
        }

        /// <summary>Test stub for set_productCode(String)</summary>
        [PexMethod]
        public void productCodeSetTest([PexAssumeUnderTest] Estimate_Order_Form target, string value)
        {
            target.productCode = value;
            // TODO: add assertions to method Estimate_Order_FormTest.productCodeSetTest(Estimate_Order_Form, String)
        }

        /// <summary>Test stub for set_quantity(Int32)</summary>
        [PexMethod]
        public void quantitySetTest([PexAssumeUnderTest] Estimate_Order_Form target, int value)
        {
            target.quantity = value;
            // TODO: add assertions to method Estimate_Order_FormTest.quantitySetTest(Estimate_Order_Form, Int32)
        }

        /// <summary>Test stub for set_totalCost(Double)</summary>
        [PexMethod]
        public void totalCostSetTest([PexAssumeUnderTest] Estimate_Order_Form target, double value)
        {
            target.totalCost = value;
            // TODO: add assertions to method Estimate_Order_FormTest.totalCostSetTest(Estimate_Order_Form, Double)
        }
    }
}
