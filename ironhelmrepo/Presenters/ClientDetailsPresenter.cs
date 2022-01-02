using Iron_helm_order_mgt;
using Iron_helm_order_mgt.DAL;
using ironhelmrepo.IModels;
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
        private ICustomer customer;

        public ClientDetailsPresenter(ICustomerDetailsView view,ICustomer customer)
        {
            this.view = view;
            this.customer = customer;
        }

        public DataTable getCustomerDetailsById()
        {
            return customer.getCustomerDetailsById(view.clientId);
        }
    }
}
