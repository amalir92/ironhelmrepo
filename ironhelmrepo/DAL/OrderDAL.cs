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
            dt.Columns.Add("Order Id", typeof(int));
            dt.Columns.Add("Order Status", typeof(string));
            dt.Columns.Add("Order Status Changed Date", typeof(DateTime));
            dt.Columns.Add("Expected Order Completion Changed Date", typeof(DateTime));
            dt.Columns.Add("Estimated Order Completion Changed Date", typeof(DateTime));
            dt.Columns.Add("Total Cost", typeof(Double));
            var query = from o in context.Orders.AsEnumerable()
                        where o.ClientId == clientId
                        orderby o.orderStatusChangedDate descending
                        select dt.LoadDataRow(new object[] {
                            o.orderId,
                            o.orderStatus,
                            o.orderStatusChangedDate,
                            o.expectedOrderDate,
                            o.estimatedCompletionDate,
                            o.TotalOrderPrice
                            }, false);
          if (query.Count()>0){
                query.AsEnumerable().GroupBy(row => row.Field<int>("Order Id")).Select(group => group.First()).CopyToDataTable();
            }
            return dt;
        }

        public Order getOrderById(int orderId)
        {
            Order order = context.Orders.Single(o => o.orderId == orderId);
            return order;
        }

        public void setOrderStatus(int orderId,OrderStatus status)
        {
            Order order = context.Orders.Single(o => o.orderId == orderId);
            order.orderStatus = Enum.GetName(typeof(OrderStatus), status);
            order.orderStatusChangedDate = DateTime.Now;
            try 
            {
                context.SaveChanges();
             }
            catch (Exception e)
            {
                Console.WriteLine("error " + e);
            }
}

        public int createOrder(Order newOrder)
        {
            
            var newId = 1;
            if (this.context.Orders.Count() != 0) { 
                var maxId = this.context.Orders.Max(table => table.orderId);
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
                Console.WriteLine("error " + e);
            }
            return newId;
        }

        public void updateOrder(Order order_)
        {

            Order order = context.Orders.Single(o => o.orderId == order_.orderId);
            order.estimatedCompletionDate = order_.estimatedCompletionDate;
            order.TotalOrderPrice = order_.TotalOrderPrice;       
            try
            {
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e);
            }
        }

        public DataTable getOrders()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Order Id", typeof(string));
            dt.Columns.Add("Client Id", typeof(string));
            dt.Columns.Add("Order Status", typeof(string));
            dt.Columns.Add("Order Status Changed Date", typeof(DateTime));
            dt.Columns.Add("Expected Order Completion Changed Date", typeof(DateTime));
            dt.Columns.Add("Estimated Order Completion Changed Date", typeof(DateTime));
            dt.Columns.Add("Total Cost", typeof(Double));
            var query = from o in context.Orders.AsEnumerable()
                        orderby o.orderStatusChangedDate descending
                        select dt.LoadDataRow(new object[] {
                            o.orderId,
                            o.ClientId,
                            o.orderStatus,
                            o.orderStatusChangedDate,
                            o.expectedOrderDate,
                            o.estimatedCompletionDate,
                            o.TotalOrderPrice
                            }, false);

            if (query!=null&&query.Any())
            {
                query?.CopyToDataTable();
            }
            return dt;
        }
    }
}
