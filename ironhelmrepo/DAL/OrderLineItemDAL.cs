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
        IronHelmDbContext context;
        OrderDAL orderDal;
        ProductCatalogDAL productCatalogDAL;

        public OrderLineItemDAL()
        {
            orderDal = new OrderDAL();
            productCatalogDAL = new ProductCatalogDAL();
            this.context = new IronHelmDbContext();
            
        }

        public void createOrderLine(int orderNo, String productId, int quantity, int labourHours, double costPerHour)
        {
            var newId = 1;
            if (this.context.orderLineItems.Count() != 0)
            {
                var maxId = this.context.orderLineItems.Max(table => table.orderLineItemId);
                newId = maxId + 1;
            }
            OrderLineItem newOrderLine = new OrderLineItem(newId, orderDal.getOrderById(orderNo),productId,quantity,labourHours,costPerHour);

            try
            {
                context.orderLineItems.Add(newOrderLine);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

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
            try
            {
                //if(query != null && query.Any()) { 
                query.CopyToDataTable();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error "+e);
            }
            // }
            return dt;
        }

        public List<OrderLineItem> getOrderLinesById(int orderId)
        {
            List<OrderLineItem> orderLine = context.orderLineItems.Where(o => o.OrderId.orderId == orderId).ToList();
            return orderLine;
        }

        public void updateOrderLineItem(OrderLineItem line)
        {

            OrderLineItem orderLine = context.orderLineItems.Single(o => o.OrderId.orderId == line.OrderId.orderId && o.orderLineItemId==line.orderLineItemId);
            orderLine.labourHoursPerItem = line.labourHoursPerItem;
            orderLine.costPerHour = line.costPerHour;
            orderLine.costperLineProduction = line.costperLineProduction;
            
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
}
