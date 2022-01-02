using Iron_helm_order_mgt;
using ironhelmrepo.Presenters;
using ironhelmrepo.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace IronHelmTest
{
    [TestClass]
    public class ClientPortalPresenterTests
    { 
        [TestMethod]
        public void TestMethod1()
        {
            ClientPortalPresenterScreenMoc moc = new ClientPortalPresenterScreenMoc();
            Order order = new Order();
            moc.clientId = "001C";
            ClientPortalPresenter presenter = new ClientPortalPresenter(moc,order);
            DataTable dt = presenter.DisplayClientOrderData();
            Assert.IsTrue(dt.Rows.Count>2);
            
        }
    }
}
