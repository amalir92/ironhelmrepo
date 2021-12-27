using Iron_helm_order_mgt.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt.Service
{
    public class CustomerService
    {
        private CustomerDAL customerDAL;

        public CustomerService()
        {
            this.customerDAL = new CustomerDAL();
        }

        public DataTable getCustomerDetailsById(string clientId)
        {
            return customerDAL.getCustomerDetailsById(clientId);
        }

        public Customer getCustomerById(string id)
        {
            return customerDAL.getCustomerById(id);
        }
    }
}
