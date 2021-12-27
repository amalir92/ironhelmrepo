using Iron_helm_order_mgt.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt.Service
{
    public class ProductService
    {
        private ProductCatalogDAL productCatalogDAL;

        public ProductService()
        {
            productCatalogDAL = new ProductCatalogDAL();
        }

        public DataTable getAllProducts()
        {
            return productCatalogDAL.getAllPoducts();
        }

        public ProductCatalog getProductById(string productId)
        {
            return productCatalogDAL.getProductById(productId);
        }
    }
}
