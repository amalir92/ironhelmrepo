using System;
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
        [Key]
        public int orderLineItemId { get; set; }

        
        public virtual Order OrderId { get; set; }

       
        public string productCode { get; set; }

        public int quantity { get; set; }

        public double pricePerItem { get; set; }
    }
}
