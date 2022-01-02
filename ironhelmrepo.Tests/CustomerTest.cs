using System.Data;
using Iron_helm_order_mgt.Entities;
using System;
using Iron_helm_order_mgt;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Tests
{
    /// <summary>This class contains parameterized unit tests for Customer</summary>
    [TestClass]
    [PexClass(typeof(Customer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CustomerTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public Customer ConstructorTest()
        {
            Customer target = new Customer();
            return target;
            // TODO: add assertions to method CustomerTest.ConstructorTest()
        }

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        public Customer ConstructorTest01(string clientId)
        {
            Customer target = new Customer(clientId);
            return target;
            // TODO: add assertions to method CustomerTest.ConstructorTest01(String)
        }

        /// <summary>Test stub for .ctor(String, String, CustomerSource, String)</summary>
        [PexMethod]
        public Customer ConstructorTest02(
            string clientId,
            string clientAddress,
            CustomerSource customerSource,
            string clientPhoneNumber
        )
        {
            Customer target = new Customer(clientId, clientAddress, customerSource, clientPhoneNumber);
            return target;
            // TODO: add assertions to method CustomerTest.ConstructorTest02(String, String, CustomerSource, String)
        }

        /// <summary>Test stub for addNewCustomer(String, String, CustomerSource, String)</summary>
        [PexMethod]
        public Customer addNewCustomerTest(
            [PexAssumeUnderTest] Customer target,
            string clientId,
            string clientAddress,
            CustomerSource customerSource,
            string clientPhoneNumber
        )
        {
            Customer result = target.addNewCustomer(clientId, clientAddress, customerSource, clientPhoneNumber);
            return result;
            // TODO: add assertions to method CustomerTest.addNewCustomerTest(Customer, String, String, CustomerSource, String)
        }

        /// <summary>Test stub for getCustomerById(String)</summary>
        [PexMethod]
        public Customer getCustomerByIdTest([PexAssumeUnderTest] Customer target, string clientId)
        {
            Customer result = target.getCustomerById(clientId);
            return result;
            // TODO: add assertions to method CustomerTest.getCustomerByIdTest(Customer, String)
        }

        /// <summary>Test stub for getCustomerDetailsById(String)</summary>
        [PexMethod]
        public DataTable getCustomerDetailsByIdTest([PexAssumeUnderTest] Customer target, string clientId)
        {
            DataTable result = target.getCustomerDetailsById(clientId);
            return result;
            // TODO: add assertions to method CustomerTest.getCustomerDetailsByIdTest(Customer, String)
        }

        /// <summary>Test stub for updateCustomer(Customer)</summary>
        [PexMethod]
        public void updateCustomerTest([PexAssumeUnderTest] Customer target, Customer customer)
        {
            target.updateCustomer(customer);
            // TODO: add assertions to method CustomerTest.updateCustomerTest(Customer, Customer)
        }
    }
}
