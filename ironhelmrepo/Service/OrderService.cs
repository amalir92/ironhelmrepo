using Iron_helm_order_mgt.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt.Service
{
    public class OrderService
    {
        private OrderDAL orderDAL;
        private OrderLineItemService orderLineItemService;

        public OrderService()
        {
            orderDAL = new OrderDAL();
        }

        public DataTable getCustomerByUseId(String clientId)
        {
            return orderDAL.getCustomerById(clientId);
        }

        public string cancelOrder(string orderStatus, int orderId)
        {
            if (orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.NEW)))
            {
                orderDAL.setOrderStatus(orderId, OrderStatus.CANCELLED);
                return "SUCCESS";
            }
            else
            {
                return "ERROR";
            }
        }

        public string acceptOrder(string orderStatus, int orderId)
        {
            if (orderStatus != null && orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.ESTIMATED)))
            {
                orderDAL.setOrderStatus(orderId,OrderStatus.ACCEPTED);
                return "SUCCESS";
            }
            else
            {
                return "ERROR";
            }
        }

        public string estimateOrder(string orderStatus, int orderId)
        {
            if (orderStatus != null && orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.NEW)))
            {
                orderDAL.setOrderStatus(orderId, OrderStatus.ESTIMATED);
                return "SUCCESS";
            }
            else
            {
                return "ERROR";
            }
        }

        public string scheduleOrder(string orderStatus, int orderId)
        {
            if (orderStatus != null && orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.ACCEPTED)))
            {
                orderDAL.setOrderStatus(orderId, OrderStatus.SCHEDULED);
                return "SUCCESS";
            }
            else
            {
                return "ERROR";
            }
        }

        public string rejectOrder(string orderStatus, int orderId)
        {
            if (orderStatus != null && orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.SCHEDULED)))
            {
                orderDAL.setOrderStatus(orderId, OrderStatus.REJECTED);
                return "SUCCESS";
            }
            else
            {
                return "ERROR";
            }
        }

        public string progressOrder(string orderStatus, int orderId)
        {
            if (orderStatus != null && orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.SCHEDULED)))
            {
                orderDAL.setOrderStatus(orderId, OrderStatus.PROGRESSING);
                return "SUCCESS";
            }
            else
            {
                return "ERROR";
            }
        }

        public string completeOrder(string orderStatus, int orderId)
        {
            if (orderStatus != null && orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.PROGRESSING))|| orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.SCHEDULED)))
            {
                orderDAL.setOrderStatus(orderId, OrderStatus.COMPLETED);
                return "SUCCESS";
            }
            else
            {
                return "ERROR";
            }
        }

        public int createOrder(String clientId, DateTime expectedDate,List<OrderLineItem> lines)
        {
            int orderNo = 0;
            if (clientId != null)
            {
                orderNo = orderDAL.createOrder(clientId, expectedDate,lines);
            }
            return orderNo;
        }

        public DataTable getOrders()
        {
            DataTable dt = orderDAL.getOrders();
            return dt;
        }

        public Order getOrderById(int orderId)
        {
            return orderDAL.getOrderById(orderId);
        }

        public void updateOrder(int orderId, DateTime estimatedDate, Double cost)
        {
            orderDAL.updateOrder(orderId, estimatedDate, cost);
        }
        }
}