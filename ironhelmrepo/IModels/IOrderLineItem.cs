using Iron_helm_order_mgt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.IModels
{
    public interface IOrderLineItem
    {
        double calculateCostPerItemProduction();

        List<OrderLineItem> getOrderLinesByOrderId(int orderId, string clientId);

        DataTable getOrderLinesTableByOrderId(int orderId,string clientId);

        void updateOrderLine();

    }
}
