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
        private SqlConnection conn;
        private SqlDataAdapter sda;
        private SqlCommand cmd;
        IronHelmDbContext context;

        public OrderDAL()
        {
            this.context = new IronHelmDbContext();
            conn = new SqlConnection(ironhelmrepo.Properties.Settings.Default.dbconnection);
        }

        public DataTable getCustomerById(String clientId)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Order Id", typeof(string));
            dt.Columns.Add("Order Status", typeof(string));
            dt.Columns.Add("Order Status Changed Date", typeof(DateTime));
            dt.Columns.Add("Expected Order Completion Changed Date", typeof(DateTime));
            dt.Columns.Add("Total Cost", typeof(Double));
            var query = from o in context.Orders.AsEnumerable()
                        where o.ClientId == clientId
                        orderby o.orderStatusChangedDate descending
                        select dt.LoadDataRow(new object[] {
                            o.orderId,
                            o.orderStatus,
                            o.orderStatusChangedDate,
                            o.expectedOrderDate,
                            o.TotalOrderPrice
                            }, false);
            //if (query != null && query.Count()!=0)
            //{
           if (query.Any()){
                query.CopyToDataTable();
            }
            //}
            return dt;
        }

        //public void cancelOrder(int orderId)
        //{
        //    Order order= context.Orders.Single(o => o.orderId == orderId);
        //    order.orderStatus = Enum.GetName(typeof(OrderStatus), OrderStatus.CANCELLED);
        //    order.orderStatusChangedDate = DateTime.Now;
        //    context.SaveChanges();
        //}

        public Order getOrderById(int orderId)
        {
            Order order = context.Orders.Single(o => o.orderId == orderId);
            return order;
        }

        //public void acceptOrder(int orderId)
        //{
        //    Order order = context.Orders.Single(o => o.orderId == orderId);
        //    order.orderStatus = Enum.GetName(typeof(OrderStatus), OrderStatus.ACCEPTED);
        //    order.orderStatusChangedDate = DateTime.Now;
        //    context.SaveChanges();
        //}

        public void setOrderStatus(int orderId,OrderStatus status)
        {
            Order order = context.Orders.Single(o => o.orderId == orderId);
            order.orderStatus = Enum.GetName(typeof(OrderStatus), status);
            order.orderStatusChangedDate = DateTime.Now;
            context.SaveChanges();
        }

        public int createOrder(String clientId,DateTime expectedDate,List<OrderLineItem> lines)
        {
            
            var newId = 1;
            if (this.context.Orders.Count() != 0) { 
                var maxId = this.context.Orders.Max(table => table.orderId);
                newId = maxId + 1;
            }
            Order newOrder = new Order();
            newOrder.orderId = newId;
            newOrder.ClientId = clientId;
            newOrder.orderStatusChangedDate = DateTime.Now;
            newOrder.orderStatus = "NEW";
            newOrder.estimatedCompletionDate = DateTime.Now;
            newOrder.expectedOrderDate = expectedDate;
            newOrder.OrderLineItems = new List<OrderLineItem>();
            foreach (OrderLineItem o in lines)
            {
                newOrder.OrderLineItems.Add(o);
            }
            

          // try
          // {
                context.Orders.Add(newOrder);
                context.SaveChanges();
          // }
          //  catch (Exception e)
          //  {
          //      throw e;
          //  }
            return newId;
        }

        public void updateOrder(int orderId, DateTime estimatedDate,Double cost)
        {

            Order order = context.Orders.Single(o => o.orderId == orderId);
            order.estimatedCompletionDate= estimatedDate;
            order.TotalOrderPrice = cost;
            context.SaveChanges();
        }

        public DataTable getOrders()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Order Id", typeof(string));
            dt.Columns.Add("Client Id", typeof(string));
            dt.Columns.Add("Order Status", typeof(string));
            dt.Columns.Add("Order Status Changed Date", typeof(DateTime));
            dt.Columns.Add("Expected Order Completion Changed Date", typeof(DateTime));
            dt.Columns.Add("Total Cost", typeof(Double));
            var query = from o in context.Orders.AsEnumerable()
                        orderby o.orderStatusChangedDate descending
                        select dt.LoadDataRow(new object[] {
                            o.orderId,
                            o.ClientId,
                            o.orderStatus,
                            o.orderStatusChangedDate,
                            o.expectedOrderDate,
                            o.TotalOrderPrice
                            }, false);
            //if (query != null && query.Count()!=0)
            //{
            if (query.Any())
            {
                query.CopyToDataTable();
            }
            //}
            return dt;
        }
    }
}
