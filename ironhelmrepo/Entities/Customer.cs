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

        public Customer()
        {

        }
        public Customer (string clientId,string clientAddress,CustomerSource customerSource,string clientPhoneNumber)
        {
            this.clientId = clientId;
            this.clientAddress = clientAddress;
            this.customerSource = customerSource;
            this.clientPhoneNumber = clientPhoneNumber;
        }

        public Customer addNewCustomer(string clientId, string clientAddress, CustomerSource customerSource, string clientPhoneNumber)
        {
            return new Customer(clientId, clientAddress, customerSource, clientPhoneNumber);
        }

        public void updateCustomer(Customer customer)
        {
            this.clientAddress = customer.clientAddress;
            this.clientPhoneNumber = customer.clientPhoneNumber;
        }
    }
}
