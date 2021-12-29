using Iron_helm_order_mgt;
using Iron_helm_order_mgt.DAL;
using ironhelmrepo.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.Presenters
{
    public class ClientDetailsPresenter
    {
        private readonly ICustomerDetailsView view;
        private CustomerDAL customerDAL;
        private Customer customer;

        public ClientDetailsPresenter(ICustomerDetailsView view)
        {
            this.view = view;
            customerDAL = new CustomerDAL();
            customer = new Customer(view.clientId);
        }

        public DataTable getCustomerDetailsById()
        {
            return customer.getCustomerDetailsById();
        }
    }
}
