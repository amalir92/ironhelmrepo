using Iron_helm_order_mgt.Service;
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
        private OrderLineItemService orderLineItemService;
        public OrderLinesPresenter(IOrderLinesView view)
        {
            this.view = view;
            orderLineItemService = new OrderLineItemService();

        }

        public DataTable getOrderLines()
        {
            return orderLineItemService.getOrderLinesByOrderId(view.orderId);

        }
    }
}
