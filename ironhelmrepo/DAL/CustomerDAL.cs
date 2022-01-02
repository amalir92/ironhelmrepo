using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt.DAL
{
    public class CustomerDAL
    {
      
        public DataTable getCustomerDetailsById(string customerId)
        {

            DataTable dt = new DataTable();
            try
            {
                dt = new DataTable();
                dt.Columns.Add("Customer Id", typeof(string));
                dt.Columns.Add("Customer Source", typeof(string));
                using (var context = new IronHelmDbContext())
                {
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
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;

        }

        public Customer getCustomerById(Customer c)
        {

           
            
            Customer customer;
            try
            {
                using (var context = new IronHelmDbContext()) { 
                    customer = context.Customers.Single(o => o.clientId == c.clientId);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return customer;

        }
    }
}
