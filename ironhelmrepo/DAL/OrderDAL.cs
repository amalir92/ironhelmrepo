using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt.DAL
{
    public class OrderDAL
    {

        IronHelmDbContext context;

        public OrderDAL()
        {
            this.context = new IronHelmDbContext();

        }

        public DataTable getCustomerById(String clientId)
        {
            DataTable dt = new DataTable();
            try
            {
                    dt = new DataTable();
                    dt.Columns.Add("Order Id", typeof(int));
                    dt.Columns.Add("Order Status", typeof(string));
                    dt.Columns.Add("Order Status Changed Date", typeof(DateTime));
                    dt.Columns.Add("Expected Order Completion Changed Date", typeof(DateTime));
                    dt.Columns.Add("Estimated Order Completion Date", typeof(DateTime));
                    dt.Columns.Add("Total Cost", typeof(Double));
                    var query = from o in context.Orders.AsEnumerable()
                                where o.clientId == clientId
                                orderby o.orderStatusChangedDate descending
                                select dt.LoadDataRow(new object[] {
                                    o.orderId,
                                    o.orderStatus,
                                    o.orderStatusChangedDate,
                                    o.expectedOrderDate,
                                    o.estimatedCompletionDate,
                                    o.TotalOrderPrice
                                    }, false);
                // if (query.Count()>0){
                query.AsEnumerable().GroupBy(row => row.Field<int>("Order Id")).Select(group => group.First()).CopyToDataTable();
            //  }
            }catch(Exception e){
                throw new Exception(e.Message);
            }
                return dt;
            }

        public Order getOrderById(Order order_)
        {
            Order order = new Order();
            try
            {
                order = context.Orders.Single(o => o.orderId == order_.orderId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return order;

        }

        public void setOrderStatus(Order order_)
        {
            using (var context = new IronHelmDbContext())
            {
                Order order = context.Orders.Single(o => o.orderId == order_.orderId);
                order.orderStatus = order_.orderStatus;
                order.orderStatusChangedDate = order_.orderStatusChangedDate;
                try
                {
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine("error " + e);
                }
            }
}

        public int createOrder(Order newOrder)
        {
            using (var context = new IronHelmDbContext())
            {

                var newId = 1;
                if (context.Orders.Count() != 0)
                {
                    var maxId = context.Orders.Max(table => table.orderId);
                    newId = maxId + 1;
                }
                newOrder.orderId = newId;
                try
                {
                    context.Orders.Add(newOrder);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                return newId;

               

            }
        }

        public void updateOrder(Order order_)
        {
            try
            {
                using (var context = new IronHelmDbContext()) { 
                    Order order = context.Orders.Single(o => o.orderId == order_.orderId);
                    order.estimatedCompletionDate = order_.estimatedCompletionDate;
                    order.TotalOrderPrice = order_.TotalOrderPrice;

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
        }

        public DataTable getOrders()
        {
            using (var context = new IronHelmDbContext())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Order Id", typeof(string));
                dt.Columns.Add("Client Id", typeof(string));
                dt.Columns.Add("Order Status", typeof(string));
                dt.Columns.Add("Order Status Changed Date", typeof(DateTime));
                dt.Columns.Add("Expected Order Completion Changed Date", typeof(DateTime));
                dt.Columns.Add("Estimated Order Completion Date", typeof(DateTime));
                dt.Columns.Add("Total Cost", typeof(Double));
                var query = from o in context.Orders.AsEnumerable().ToList()
                            orderby o.orderStatusChangedDate descending
                            select dt.LoadDataRow(new object[] {
                            o.orderId,
                            o.clientId,
                            o.orderStatus,
                            o.orderStatusChangedDate,
                            o.expectedOrderDate,
                            o.estimatedCompletionDate,
                            o.TotalOrderPrice
                            }, false);
                //if (query!=null&&query.Any())
                //{
                query?.CopyToDataTable();
                //  }
                return dt;
            }
        }
    }
}
