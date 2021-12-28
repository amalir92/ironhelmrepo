﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt
{
    public class OrderLineItem
    { 
        public OrderLineItem()
        {

        }
        public OrderLineItem(int orderLineItemId, Order orderId, string productCode, int quantity, int labourHoursPerItem, double costPerHour)
        {
            this.orderLineItemId = orderLineItemId;
            OrderId = orderId;
            this.productCode = productCode;
            this.quantity = quantity;
            this.labourHoursPerItem = labourHoursPerItem;
            this.costPerHour = costPerHour;
        }
        public OrderLineItem(string productCode, int quantity)
        {
            this.productCode = productCode;
            this.quantity = quantity;
        }

        [Key]
        public int orderLineItemId { get; set; }

        
        public virtual Order OrderId { get; set; }

       
        public string productCode { get; set; }

        public int quantity { get; set; }

        public int labourHoursPerItem { get; set; }

        public double costPerHour { get; set; }

        public double costperLineProduction { get; set; }

        public double calculateCostPerItemProduction()
        {
           
            this.costperLineProduction= quantity * labourHoursPerItem * costPerHour;
            return costperLineProduction;
        }

    }
}
