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

        public ClientDetailsPresenter(ICustomerDetailsView view)
        {
            this.view = view;
            customerDAL = new CustomerDAL();
        }

        public DataTable getCustomerDetailsById()
        {
            return customerDAL.getCustomerDetailsById(view.clientId);
        }
    }
}
