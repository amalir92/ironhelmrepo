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

        public double TotalOrderPrice { get; set; }

    }
}
