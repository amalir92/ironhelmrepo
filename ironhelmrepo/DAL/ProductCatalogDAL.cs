using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt.DAL
{
    public class ProductCatalogDAL
    {

        public ProductCatalog getProductById(string productId)
        {
            using (var context = new IronHelmDbContext())
            {
                ProductCatalog product = context.ProductCatalogs.Single(p => p.productId == productId);
                return product;
            }
        }

        public DataTable getAllPoducts()
        {
            //DataTable da;
            using (var context = new IronHelmDbContext())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("productId", typeof(string));
                dt.Columns.Add("productName", typeof(string));
               var query = from p in context.ProductCatalogs.AsEnumerable().ToList()
                           select dt.LoadDataRow(new object[] {
                            p.productId,
                            p.productName
                            }, false);
                query.CopyToDataTable();
                return dt;
            }
            
        }


    }
}
