using Iron_helm_order_mgt.Controls;
using Iron_helm_order_mgt.DAL;
using ironhelmrepo.IModels;
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
    public class Order: IOrder
    {
        private OrderDAL dal;
        private ApplicationState state = null;

        [Key]

        public int orderId { get; set; }

        public ICollection<OrderLineItem> OrderLineItems { get; set; }

        [Required]
        public String clientId { get; set; }

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

        public Order(string clientId)
        {
            dal = new OrderDAL();
            clientId = clientId;
        }
        public Order(int orderId, string clientId)
        {
            dal = new OrderDAL();
            this.orderId = orderId;
            clientId = clientId;
        }

        public Order(int orderId, ICollection<OrderLineItem> orderLineItems, string clientId, string orderStatus, DateTime orderStatusChangedDate, DateTime estimatedCompletionDate, DateTime expectedOrderDate, double packageCost, double deliveryCost, double totalOrderPrice)
        {
            dal = new OrderDAL();
            this.orderId = orderId;
            this.OrderLineItems = orderLineItems;
            this.clientId = clientId;
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
            dal = new OrderDAL();
            this.orderId = orderId;
            this.clientId = clientId;
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
            dal = new OrderDAL();
            this.OrderLineItems = lines;
            this.clientId = clientId;
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
            this.clientId = clientId;
            this.expectedOrderDate = expectedDate;
            dal = new OrderDAL();
        }

        public int createOrder(List<OrderLineItem> lines, string clientId, DateTime expectedDate)
        {
            this.OrderLineItems = lines;
            this.clientId = clientId;
            this.expectedOrderDate = expectedDate;
            this.orderStatus = "NEW";
            this.orderStatusChangedDate = DateTime.Now;
            this.estimatedCompletionDate = DateTime.Now;
            int orderId = dal.createOrder(this);
            this.state = ApplicationState.getState();
            state.orderStatuses[orderId] = this;
            return orderId;
        }

        public void updateOrder(double packageCost, double deliveryCost, List<OrderLineItem> lines, double totalCost, string status,DateTime estimatedCompletionDate)
        {
            this.packageCost = packageCost;
            this.deliveryCost = deliveryCost;
            this.OrderLineItems = lines;
            this.orderStatus = status;
            this.orderStatusChangedDate = DateTime.Now;
            this.estimatedCompletionDate = estimatedCompletionDate;
            this.TotalOrderPrice = totalCost;
            dal.updateOrder(this);
            this.state = ApplicationState.getState();
            state.orderStatuses[this.orderId]=this;

        }

        public double calculateTotalCost(List<OrderLineItem> lines, double packageCost, double deliveryCost)
        {
            double tcost = 0;
            //List<OrderLineItem> lines = this.OrderLineItems.ToList();
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
                    this.orderStatusChangedDate = DateTime.Now;
                    dal.setOrderStatus(this);
                    state.orderStatuses[orderId]=this;
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
                    this.orderStatusChangedDate = DateTime.Now;
                    dal.setOrderStatus(this);
                    state.orderStatuses[orderId] = this;
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
                    this.orderStatusChangedDate = DateTime.Now;
                    dal.setOrderStatus(this);
                    state.orderStatuses[orderId]=this;
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
                    this.orderStatusChangedDate = DateTime.Now;
                    dal.setOrderStatus(this);
                    state.orderStatuses[orderId] = this;
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
                    this.orderStatusChangedDate = DateTime.Now;
                    dal.setOrderStatus(this);
                    state.orderStatuses[orderId] = this;
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
                    this.orderStatusChangedDate = DateTime.Now;
                    dal.setOrderStatus(this);
                    state.orderStatuses[orderId] = this;
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
            DataTable dt = dal.getCustomerById(clientId);
            return dt;
        }

        public DataTable getAllOrders()
        {
            DataTable dt = dal.getOrders();
            return dt;
        }

        public Order getOrderById(int orderId, string clientId)
        {
            this.orderId = orderId;
            this.clientId = clientId;
            return dal.getOrderById(this);
        }
    }
}
