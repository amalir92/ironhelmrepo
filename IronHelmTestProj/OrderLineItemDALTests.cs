using Iron_helm_order_mgt;
using Iron_helm_order_mgt.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace IronHelmTest
{
    [TestClass]
    public class OrderLineItemDALTests
    {

        [TestMethod]
        public void getOrderLinesById_DetailsNotInDb()
        {
            int orderId = 15698;
 
            OrderLineItemDAL order = new OrderLineItemDAL();
            Assert.IsTrue(order.getOrderLinesById(orderId).Count==0);
            
        }

        [TestMethod]
        public void getOrderLinesById_DetailsInDb()
        {
            int newOrderId = 0;
            IronHelmDbContext context = new IronHelmDbContext();
            if (context.Orders.Count() != 0)
            {
                newOrderId = context.Orders.Max(table => table.orderId);
            }
            if(newOrderId != 0) 
            {
                OrderLineItemDAL order = new OrderLineItemDAL();
                List<OrderLineItem> orderItems = order.getOrderLinesById(newOrderId);
                Assert.IsTrue(orderItems.Count > 0);
            }
            
        }

        [TestMethod]
        public void getOrderLinesByOrderId_DetailsNotInDb()
        {
            int orderId = 1698;

            OrderLineItemDAL order = new OrderLineItemDAL();
            Assert.ThrowsException<Exception>(() => order.getOrderLinesByOrderId(orderId));
        }

        [TestMethod]
        public void getOrderLinesByOrderId_DetailsInDb()
        {
            int newOrderId = 1;
            IronHelmDbContext context = new IronHelmDbContext();
            if (context.Orders.Count() != 0)
            {
                newOrderId = context.Orders.Max(table => table.orderId);
            }
            OrderLineItemDAL order = new OrderLineItemDAL();
            DataTable dt = order.getOrderLinesByOrderId(newOrderId);
            Assert.IsTrue(dt.Rows.Count>0);
        }
    }
}
