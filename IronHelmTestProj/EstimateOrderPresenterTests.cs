using Iron_helm_order_mgt;
using ironhelmrepo.Presenters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace IronHelmTestProj
{
    [TestClass]
    public class EstimateOrderPresenterTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            EstimateOrderScreenMoc moc = new EstimateOrderScreenMoc();

            OrderLineItem lineItem = new OrderLineItem();
            List<OrderLineItem> lines = new List<OrderLineItem>();
            lines.Add(lineItem);
            Order newOrder = new Order();
            int newOrderID = newOrder.createOrder(lines, "001C", DateTime.Now);
            moc.orderId = newOrderID;
            Order order = new Order();
            order.orderId = newOrderID;
            EstimateOrderPresenter presenter = new EstimateOrderPresenter(moc, order, lineItem);
            String status = presenter.estimateOrder();
            Assert.AreEqual("SUCCESS", status);
        }


    }
}
