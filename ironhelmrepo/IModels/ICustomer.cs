using Iron_helm_order_mgt;
using Iron_helm_order_mgt.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.IModels
{
    public interface ICustomer
    {
        Customer addNewCustomer(string clientId, string clientAddress, CustomerSource customerSource, string clientPhoneNumber);

        void updateCustomer(Customer customer);

        DataTable getCustomerDetailsById(string clientId);

        Customer getCustomerById(string clientId);

    }
}
