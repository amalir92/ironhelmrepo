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
        private OrderLineItemDAL orderLineItemDAL;
        public OrderLinesPresenter(IOrderLinesView view)
        {
            this.view = view;
            orderLineItemDAL = new OrderLineItemDAL();

        }

        public DataTable getOrderLines()
        {
            return orderLineItemDAL.getOrderLinesByOrderId(view.orderId);

        }
    }
}
