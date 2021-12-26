using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt.DAL
{
    public class OrderLineItemDAL
    {
        private SqlConnection conn;
        private SqlDataAdapter sda;
        private SqlCommand cmd;
        IronHelmDbContext context;
        OrderDAL orderDal;
        ProductCatalogDAL productCatalogDAL;

        public OrderLineItemDAL()
        {
            orderDal = new OrderDAL();
            productCatalogDAL = new ProductCatalogDAL();
            this.context = new IronHelmDbContext();
            conn = new SqlConnection(ironhelmrepo.Properties.Settings.Default.dbconnection);
        }

        public void create_order_line(int orderNo, String productId, int quantity)
        {
            var newId = 1;
            if (this.context.orderLineItems.Count() != 0)
            {
                var maxId = this.context.orderLineItems.Max(table => table.orderLineItemId);
                newId = maxId + 1;
            }
            OrderLineItem newOrderLine = new OrderLineItem();
            newOrderLine.OrderId = orderDal.getOrderById(orderNo);
            newOrderLine.orderLineItemId = newId;
            newOrderLine.productCode = productId;
            newOrderLine.quantity = quantity;

            //try
            //{
            context.orderLineItems.Add(newOrderLine);
            context.SaveChanges();
            

        }

        public DataTable getOrderLinesByOrderId(int orderId)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Product Code", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
           
            var query = from o in context.orderLineItems.AsEnumerable()
                        where o.OrderId.orderId == orderId
                        orderby o.orderLineItemId descending
                        select dt.LoadDataRow(new object[] {
                            o.productCode,
                            o.quantity
                            }, false);
            //if (query != null && query.Count()!=0)
            //{
            //if (query.Any())
                query.CopyToDataTable();
            //}
            return dt;
        }

        public List<OrderLineItem> getOrderLinesById(int orderId)
        {
            List<OrderLineItem> orderLine = context.orderLineItems.Where(o => o.OrderId.orderId == orderId).ToList();
            return orderLine;
        }

    }
}
