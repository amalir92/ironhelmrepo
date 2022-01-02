using Iron_helm_order_mgt;
using ironhelmrepo.Presenters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace IronHelmTestProj
{
    [TestClass]
    public class OrderLinesPresenterTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            OrderLIneViewscreenMoc moc = new OrderLIneViewscreenMoc();
            OrderLineItem item = new OrderLineItem();
            Order or = new Order();
            or.orderId = 7;
            item.OrderId = or;
            OrderLinesPresenter presenter = new OrderLinesPresenter(moc,item);
            moc.clientId = "001C";
            moc.orderId = 7;
            DataTable dt = presenter.getOrderLines();
            Assert.IsTrue(dt.Rows.Count>0);
    }
    }
}
