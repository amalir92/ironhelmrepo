using Iron_helm_order_mgt;
using ironhelmrepo.Presenters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace IronHelmTestProj
{
    [TestClass]
    public class ProcessOrderPresenterTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            ProcessOrderViewScreenMoc moc = new ProcessOrderViewScreenMoc();
            int orderId = 1;
            Order or = new Order();
            or.orderId = orderId;
            moc.order = or;
            Customer customer = new Customer();
            OrderLineItem lineItem = new OrderLineItem();
            lineItem.OrderId = or;
            ProcessOrderPresenter presenter = new ProcessOrderPresenter(moc,or,customer,lineItem);
            List<OrderLineItem>  lines = presenter.getOrderLinesByOrderId();
            Assert.IsNotNull(lines);
        }
    }
}
