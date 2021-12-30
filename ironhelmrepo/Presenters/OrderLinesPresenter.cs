using Iron_helm_order_mgt;
using Iron_helm_order_mgt.DAL;
using ironhelmrepo.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.Presenters
{
    public class OrderLinesPresenter
    {
        private readonly IOrderLinesView view;
        private OrderLineItem orderLineItem;
        public OrderLinesPresenter(IOrderLinesView view)
        {
            this.view = view;
        }

        public DataTable getOrderLines()
        {
            orderLineItem = new OrderLineItem(new Order(view.orderId,view.clientId));
            return orderLineItem.getOrderLinesTableByOrderId();

        }
    }
}
