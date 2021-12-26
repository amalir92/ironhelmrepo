using Iron_helm_order_mgt.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt
{
   public  class Customer
    {
        [Key]
        public String clientId { get; set; }

        public String clientAddress { get; set; }
        public String clientPhoneNumber { get; set; }

        public CustomerSource customerSource { get; set; }

        public string remarks { get; set; }

        public void create_order()
        {

        }

        public void cancel_order()
        {

        }

        public void accept_or_decline_order()
        {

        }
    }
}
