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
        private SqlConnection conn;
        private SqlDataAdapter sda;
        private SqlCommand cmd;
        IronHelmDbContext context;

        public ProductCatalogDAL()
        {
            this.context = new IronHelmDbContext();
            conn = new SqlConnection(ironhelmrepo.Properties.Settings.Default.dbconnection);
        }

        public ProductCatalog getProductById(string productId)
        {
            ProductCatalog product = context.ProductCatalogs.Single(p => p.productId == productId);
            return product;
        }

        public DataTable getAllPoducts()
        {

            SqlConnection connection = new SqlConnection(ironhelmrepo.Properties.Settings.Default.dbconnection);
            string sql = "select * from productCatalog";
            connection.Open();
            sda = new SqlDataAdapter(sql, conn);

            DataTable da = new DataTable();
            sda.Fill(da);
            return da;
        }


    }
}
