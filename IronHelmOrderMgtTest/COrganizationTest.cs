using Iron_helm_order_mgt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class COrganizationTest
    {
        [DataTestMethod]
        [DataRow("test1","test","test","168854123")]
        public void ConstructorTest(
            string companyName,
            string industryType,
            string contactPersonName,
            string corpAccDetails
        )
        {
            COrganization target
               = new COrganization(companyName, industryType, contactPersonName, corpAccDetails);
            Assert.IsNotNull(target);
        }
    }
}
