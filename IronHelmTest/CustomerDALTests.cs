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
            DataTable dt = customerDAL.getCustomerDetailsById(custoerId);
            Assert.IsTrue(dt.Rows.Count==0);

        }

        [TestMethod]
        public void getCustomerDetailsById_customerIdNotInDb()
        {
            String custoerId = "testId";
            DataTable dt = customerDAL.getCustomerDetailsById(custoerId);
            Assert.IsTrue(dt.Rows.Count == 0);
        }

        [TestMethod]
        public void getCustomerDetailsById_validCustomerId()
        {
            String custoerId = "001";
            DataTable  dt = null;
            dt = customerDAL.getCustomerDetailsById(custoerId);
            Assert.IsTrue(dt.Rows.Count>=1);
        }

        [TestMethod]
        public void getCustomerById_customerIdNull()
        {
            String custoerId = "";
            DataTable dt = customerDAL.getCustomerDetailsById(custoerId);
            Assert.IsTrue(dt.Rows.Count == 0);

        }

        [TestMethod]
        public void getCustomerById_customerIdNull_customerIdNotInDb()
        {
            String custoerId = "testId";
            DataTable dt = customerDAL.getCustomerDetailsById(custoerId);
            Assert.IsTrue(dt.Rows.Count == 0);
        }


        [TestMethod]
        public void getCustomerById_validCustomerId()
        {
            String custoerId = "001C";
            Customer customer = customerDAL.getCustomerById(custoerId);
            Assert.IsNotNull(customer);
        }
    }
}
