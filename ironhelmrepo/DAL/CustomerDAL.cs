﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt.DAL
{
    public class CustomerDAL
    {
        IronHelmDbContext context;
        public CustomerDAL()
        {
            this.context = new IronHelmDbContext();
        }

        public DataTable getCustomerDetailsById(string customerId)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Customer Id", typeof(string));
            dt.Columns.Add("Customer Source", typeof(string));
            var query = from o in context.Customers.AsEnumerable()
                        where o.clientId == customerId
                        select dt.LoadDataRow(new object[] {
                            o.clientId,
                            o.customerSource
                            }, false);
          //  if (query != null && query.Any())
          //  {
            query?.CopyToDataTable();
         //   }
            return dt;
        }

        public Customer getCustomerById(Customer c)
        {
            Customer customer = context.Customers.Single(o => o.clientId == c.clientId);
            return customer;
        }
    }
}
