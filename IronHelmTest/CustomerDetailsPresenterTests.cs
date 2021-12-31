using ironhelmrepo.Presenters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace IronHelmTest
{
    [TestClass]
    public class CustomerDetailsPresenterTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            CustomerDetailsScreenMoc moc = new CustomerDetailsScreenMoc();
            moc.clientId = "001C";
            ClientDetailsPresenter presenter = new ClientDetailsPresenter(moc);
            DataTable dt = presenter.getCustomerDetailsById();
            Assert.AreEqual(dt.Rows[0][0],"001C");
            Assert.AreEqual(dt.Rows[0][3],0);
        }
    }
}
