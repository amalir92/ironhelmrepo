using Iron_helm_order_mgt;
using Iron_helm_order_mgt.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Customer target = new Customer();
            Assert.IsNotNull(target);
        }

        [DataTestMethod]
        [DataRow("001C")]
        public void ConstructorTest01(string clientId)
        {
            Customer target = new Customer(clientId);
            Assert.IsNotNull(target);
        }

        [DataTestMethod]
        [DataRow("001C","Gateshead", CustomerSource.ENTERTAINMENT,"468841236565")]
        public void ConstructorTest02(
            string clientId,
            string clientAddress,
            CustomerSource customerSource,
            string clientPhoneNumber
        )
        {
            Customer target = new Customer(clientId, clientAddress, customerSource, clientPhoneNumber);
            Assert.IsNotNull(target);
        }


    }
}
