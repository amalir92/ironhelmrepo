using Iron_helm_order_mgt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.IModels
{
    public interface IOrder
    {
        int orderId { get; set; }

        string clientId { get; set; }
        string orderStatus { get; set; }
        int createOrder(List<OrderLineItem> lines, string clientId, DateTime expectedDate);

        void updateOrder(double packageCost, double deliveryCost, List<OrderLineItem> lines, double totalCost, string status, DateTime estimatedCompletionDate);


        double calculateTotalCost(List<OrderLineItem> lines);

        string validateOrderStatusChange(OrderStatus targetOrderStatus);

        DataTable getCustomerOrdersById(string clientId);

        DataTable getAllOrders();

        Order getOrderById(int orderId, string clientId);

    }
}
