using System;
using Iron_helm_order_mgt;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Tests
{
    /// <summary>This class contains parameterized unit tests for COrganization</summary>
    [TestClass]
    [PexClass(typeof(COrganization))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class COrganizationTest
    {

        /// <summary>Test stub for .ctor(String, String, String, String)</summary>
        [PexMethod]
        public COrganization ConstructorTest(
            string companyName,
            string industryType,
            string contactPersonName,
            string corpAccDetails
        )
        {
            COrganization target
               = new COrganization(companyName, industryType, contactPersonName, corpAccDetails);
            return target;
            // TODO: add assertions to method COrganizationTest.ConstructorTest(String, String, String, String)
        }
    }
}
