using Iron_helm_order_mgt.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt
{
    public class Order
    {
        private OrderDAL dal;

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

        public double deliveryCost { get; set;  }

        public double packageCost { get; set; }

        public double TotalOrderPrice { get; set; }
        
        public Order(int orderId, ICollection<OrderLineItem> orderLineItems, string clientId, string orderStatus, DateTime orderStatusChangedDate, DateTime estimatedCompletionDate, DateTime expectedOrderDate, double packageCost, double deliveryCost,double totalOrderPrice)
        {
            this.orderId = orderId;
            OrderLineItems = orderLineItems;
            ClientId = clientId;
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
            ClientId = clientId;
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

        public Order updateOrder(Order order)
        {
            this.orderStatus = order.orderStatus;
            this.orderStatusChangedDate = order.orderStatusChangedDate;
            this.estimatedCompletionDate = order.estimatedCompletionDate;
            TotalOrderPrice = order.TotalOrderPrice;
            return this;
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
            if (targetOrderStatus.Equals(OrderStatus.ACCEPTED))
            {
                if (this.orderStatus != null && this.orderStatus.Equals(Enum.GetName(typeof(OrderStatus), OrderStatus.ESTIMATED)))
                {
                    this.orderStatus= (Enum.GetName(typeof(OrderStatus), OrderStatus.ACCEPTED));
                    dal.setOrderStatus(orderId, OrderStatus.ACCEPTED);
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
                    dal.setOrderStatus(orderId, OrderStatus.CANCELLED);
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
                    this.orderStatus=(Enum.GetName(typeof(OrderStatus), OrderStatus.ESTIMATED));
                    dal.setOrderStatus(orderId, OrderStatus.ESTIMATED);
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
                    dal.setOrderStatus(orderId, OrderStatus.SCHEDULED);
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
                    dal.setOrderStatus(orderId, OrderStatus.PROGRESSING);
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
                    dal.setOrderStatus(orderId, OrderStatus.COMPLETED);
                    return "SUCCESS";
                }
                else
                {
                    return "ERROR";
                }
            }
            return "";
        }
    }
}
