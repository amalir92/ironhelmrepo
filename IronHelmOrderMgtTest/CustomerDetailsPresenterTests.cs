using Iron_helm_order_mgt;
using ironhelmrepo.Presenters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class CustomerDetailsPresenterTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            CustomerDetailsScreenMoc moc = new CustomerDetailsScreenMoc();
            Customer customer = new Customer();
            moc.clientId = "001C";
            ClientDetailsPresenter presenter = new ClientDetailsPresenter(moc,customer);
            DataTable dt = presenter.getCustomerDetailsById();
            Assert.AreEqual(dt.Rows[0][0], customer.clientId);
        }
    }
}
