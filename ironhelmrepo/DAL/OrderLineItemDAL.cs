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

        OrderDAL orderDal;
        ProductCatalogDAL productCatalogDAL;

        public OrderLineItemDAL()
        {
                orderDal = new OrderDAL();
                productCatalogDAL = new ProductCatalogDAL();

        }

        
        public DataTable getOrderLinesByOrderId(int orderId)
        {

            DataTable dt = new DataTable();
            try
            {
                dt.Columns.Add("Product Code", typeof(string));
                dt.Columns.Add("Quantity", typeof(int));
                using (var context = new IronHelmDbContext())
                {
                    var query = from o in context.orderLineItems.AsEnumerable().ToList()
                                where o.OrderId.orderId == orderId
                                orderby o.orderLineItemId descending
                                select dt.LoadDataRow(new object[] {
                            o.productCode,
                            o.quantity
                            }, false);

                    //if(query != null && query.Any()) { 
                    query.CopyToDataTable();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
            return dt;
        }

        public List<OrderLineItem> getOrderLinesById(int orderId)
        {

            List<OrderLineItem> orderLine = new List<OrderLineItem>();
            try
            {
                using (var context = new IronHelmDbContext())
                {
                    orderLine = context.orderLineItems.Where(o => o.OrderId.orderId == orderId).ToList();
                }
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            return orderLine;

        }

        public void updateOrderLineItem(OrderLineItem line)
        {
            using (var context = new IronHelmDbContext())
            {
                OrderLineItem orderLine = context.orderLineItems.Single(o=> o.orderLineItemId == line.orderLineItemId);
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
}
