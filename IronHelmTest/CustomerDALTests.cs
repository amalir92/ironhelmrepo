using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Iron_helm_order_mgt.DAL;
using Iron_helm_order_mgt;
using System.Linq;
using System.Data;

namespace IronHelmTest
{
    [TestClass]
    public class CustomerDALTests
    {
        CustomerDAL customerDAL = new CustomerDAL();
        [TestMethod]
        public void getCustomerDetailsById_customerIdNull()
        {
            String custoerId = "";
            Assert.ThrowsException<Exception>(() => customerDAL.getCustomerDetailsById(custoerId));

        }

        [TestMethod]
        public void getCustomerDetailsById_customerIdNotInDb()
        {
            String custoerId = "testId";
            Assert.ThrowsException<Exception>(() => customerDAL.getCustomerDetailsById(custoerId));
        }

        [TestMethod]
        public void getCustomerDetailsById_validCustomerId()
        {
            String custoerId = "001C";
            DataTable  dt = null;
            dt = customerDAL.getCustomerDetailsById(custoerId);
            Assert.IsTrue(dt.Rows.Count>=1);
        }

        [TestMethod]
        public void getCustomerById_customerIdNull()
        {
            String custoerId = "";
            Assert.ThrowsException<Exception>(() => customerDAL.getCustomerById(custoerId));

        }

        [TestMethod]
        public void getCustomerById_customerIdNull_customerIdNotInDb()
        {
            String custoerId = "testId";
            Assert.ThrowsException<Exception>(() => customerDAL.getCustomerById(custoerId));
        }


        [TestMethod]
        public void getCustomerById_validCustomerId()
        {
            String custoerId = "001C";
            Customer customer = null;
            customer = customerDAL.getCustomerById(custoerId);
            Assert.IsNotNull(customer);
        }
    }
}
