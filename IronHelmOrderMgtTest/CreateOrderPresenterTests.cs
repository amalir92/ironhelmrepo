using Iron_helm_order_mgt;
using ironhelmrepo.Presenters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class CreateOrderPresenterTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            CreateOrderPresenterScrennMoc moc = new CreateOrderPresenterScrennMoc();
            moc.clientId = "001C";
            List<OrderLineItem> lineItem = new List<OrderLineItem>();
            lineItem.Add(new OrderLineItem());
            moc.orderLines = lineItem;
            Order order = new Order();
            ProductCatalog product = new ProductCatalog();
            CreateOrderPresenter presenter = new CreateOrderPresenter(moc, order,product);
            int orderId = presenter.createOrder();
            Assert.AreEqual(orderId, order.orderId);
        }
    }
}
