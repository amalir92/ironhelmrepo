using Iron_helm_order_mgt.Controls;
using Iron_helm_order_mgt.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt
{
    public class Order
    {
        private OrderDAL dal;
        private ApplicationState state = null;

        [Key]

        public int orderId { get; set; }

        public ICollection<OrderLineItem> OrderLineItems { get; set; }

        [Required]
        public String ClientId { get; set; }

        public String orderStatus { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime orderStatusChangedDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime estimatedCompletionDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime expectedOrderDate { get; set; }

        public double deliveryCost { get; set; }

        public double packageCost { get; set; }

        public double TotalOrderPrice { get; set; }

        public Order(int orderId, ICollection<OrderLineItem> orderLineItems, string clientId, string orderStatus, DateTime orderStatusChangedDate, DateTime estimatedCompletionDate, DateTime expectedOrderDate, double packageCost, double deliveryCost, double totalOrderPrice)
        {
            this.orderId = orderId;
            this.OrderLineItems = orderLineItems;
            this.ClientId = clientId;
            this.orderStatus = orderStatus;
            this.orderStatusChangedDate = orderStatusChangedDate;
            this.estimatedCompletionDate = estimatedCompletionDate;
            this.expectedOrderDate = expectedOrderDate;
            this.packageCost = packageCost;
            this.deliveryCost = deliveryCost;
            TotalOrderPrice = totalOrderPrice;
        }

        public Order(int orderId, string clientId, string orderStatus, DateTime orderStatusChangedDate, DateTime estimatedCompletionDate, DateTime expectedOrderDate, double packageCost, double deliveryCost, double totalOrderPrice)
        {
            this.orderId = orderId;
            this.ClientId = clientId;
            this.orderStatus = orderStatus;
            this.orderStatusChangedDate = orderStatusChangedDate;
            this.estimatedCompletionDate = estimatedCompletionDate;
            this.expectedOrderDate = expectedOrderDate;
            this.packageCost = packageCost;
            this.deliveryCost = deliveryCost;
            TotalOrderPrice = totalOrderPrice;
        }
        public Order(List<OrderLineItem> lines, string clientId, string orderStatus, DateTime orderStatusChangedDate, DateTime estimatedCompletionDate, DateTime expectedOrderDate, double packageCost, double deliveryCost, double totalOrderPrice)
        {
            this.OrderLineItems = lines;
            this.ClientId = clientId;
            this.orderStatus = orderStatus;
            this.orderStatusChangedDate = orderStatusChangedDate;
            this.estimatedCompletionDate = estimatedCompletionDate;
            this.expectedOrderDate = expectedOrderDate;
            this.packageCost = packageCost;
            this.deliveryCost = deliveryCost;
            TotalOrderPrice = totalOrderPrice;
        }

        public Order()
        {
            dal = new OrderDAL();
        }
        public Order(List<OrderLineItem> lines, string clientId, DateTime expectedDate)
        {
            this.OrderLineItems = lines;
            this.ClientId = clientId;
            this.expectedOrderDate = expectedDate;
            this.state = ApplicationState.getState();
            dal = new OrderDAL();
        }

        public int createOrder()
        {
            this.orderStatus = "NEW";
            this.orderStatusChangedDate = DateTime.Now;
            this.estimatedCompletionDate = DateTime.Now;
            int orderId = dal.createOrder(this);
            state.orderStatuses.Add(orderId, "NEW");
            return orderId;
        }

        public void updateOrder(Order order)
        {
            this.orderStatus = order.orderStatus;
            this.orderStatusChangedDate = order.orderStatusChangedDate;
            this.estimatedCompletionDate = order.estimatedCompletionDate;
            TotalOrderPrice = order.TotalOrderPrice;
            dal.updateOrder(order);

        }

        public double calculateTotalCost(List<OrderLineItem> lines)
        {
            double tcost = 0;
            foreach (OrderLineItem item in lines)
            {
                tcost = tcost + item.calculateCostPerItemProduction();
            }
            tcost = tcost + packageCost + deliveryCost;
            this.TotalOrderPrice = tcost;
            return this.TotalOrderPrice;
        }

        public string validateOrderStatusChange(OrderStatus targetOrderStatus)
        {
            this.state = ApplicationState.getState();
            if (targetOrderStatus.Equals(OrderStatus.ACCEPTED))
            {
                if (this.orderStatus != null && this.orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.ESTIMATED)))
                {
                    this.orderStatus = (Enum.GetName(typeof(OrderStatus), OrderStatus.ACCEPTED));
                    dal.setOrderStatus(this.orderId, OrderStatus.ACCEPTED);
                    state.orderStatuses.Add(orderId, "ACCEPTED");
                    return "SUCCESS";
                }
                else
                {
                    return "ERROR";
                }
            }
            if (targetOrderStatus.Equals(OrderStatus.CANCELLED))
            {
                if (this.orderStatus != null && this.orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.NEW)))
                {
                    this.orderStatus = (Enum.GetName(typeof(OrderStatus), OrderStatus.CANCELLED));
                    dal.setOrderStatus(this.orderId, OrderStatus.CANCELLED);
                    state.orderStatuses.Add(orderId, "CANCELLED");
                    return "SUCCESS";
                }
                else
                {
                    return "ERROR";
                }
            }
            if (targetOrderStatus.Equals(OrderStatus.ESTIMATED))
            {
                if (this.orderStatus != null && this.orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.NEW)))
                {
                    this.orderStatus = (Enum.GetName(typeof(OrderStatus), OrderStatus.ESTIMATED));
                    dal.setOrderStatus(this.orderId, OrderStatus.ESTIMATED);
                    state.orderStatuses.Add(orderId, "ESTIMATED");
                    return "SUCCESS";
                }
                else
                {
                    return "ERROR";
                }
            }
            if (targetOrderStatus.Equals(OrderStatus.SCHEDULED))
            {
                if (this.orderStatus != null && this.orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.ACCEPTED)))
                {
                    this.orderStatus = (Enum.GetName(typeof(OrderStatus), OrderStatus.SCHEDULED));
                    dal.setOrderStatus(this.orderId, OrderStatus.SCHEDULED);
                    state.orderStatuses.Add(orderId, "SCHEDULED");
                    return "SUCCESS";
                }
                else
                {
                    return "ERROR";
                }
            }
            if (targetOrderStatus.Equals(OrderStatus.PROGRESSING))
            {
                if (this.orderStatus != null && this.orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.SCHEDULED)))
                {
                    this.orderStatus = (Enum.GetName(typeof(OrderStatus), OrderStatus.PROGRESSING));
                    dal.setOrderStatus(this.orderId, OrderStatus.PROGRESSING);
                    state.orderStatuses.Add(orderId, "PROGRESSING");
                    return "SUCCESS";
                }
                else
                {
                    return "ERROR";
                }
            }
            if (targetOrderStatus.Equals(OrderStatus.COMPLETED))
            {
                if (this.orderStatus != null && this.orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.PROGRESSING)) || this.orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.SCHEDULED)))
                {
                    this.orderStatus = (Enum.GetName(typeof(OrderStatus), OrderStatus.COMPLETED));
                    dal.setOrderStatus(this.orderId, OrderStatus.COMPLETED);
                    state.orderStatuses.Add(orderId, "COMPLETED");
                    return "SUCCESS";
                }
                else
                {
                    return "ERROR";
                }
            }
            return "";
        }

        public DataTable getCustomerOrdersById(string clientId)
        {
            this.ClientId = clientId;
            DataTable dt = dal.getCustomerById(clientId);
            return dt;
        }

        public DataTable getAllOrders()
        {
            DataTable dt = dal.getOrders();
            return dt;
        }

        public Order getOrderById(int orderId)
        {
            return dal.getOrderById(orderId);
        }
    }
}
