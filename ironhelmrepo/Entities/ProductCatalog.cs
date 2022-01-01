using Iron_helm_order_mgt.DAL;
using ironhelmrepo.IModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt
{
    public class ProductCatalog: IProduct
    {
        private ProductCatalogDAL productCatalogDAL;
        public ProductCatalog()
        {
            productCatalogDAL = new ProductCatalogDAL();
        }
        [Key]
        public String productId { get; set; }

        [Required]
        public String productName { get; set; }

        public String productDescription { get; set; }

        public ProductCatalog(string productId,string productName, string productDescription)
        {
            productCatalogDAL = new ProductCatalogDAL();
            this.productId = productId;
            this.productName = productName;
            this.productDescription = productDescription;
        }

        public ProductCatalog(string productId)
        {
            productCatalogDAL = new ProductCatalogDAL();
            this.productId = productId;
        }

        public ProductCatalog createNewProduct(string productId,string productName,string productDescription)
        {
            return new ProductCatalog(productId, productName, productDescription);
        }

        public DataTable getAllProducts()
        {
            return productCatalogDAL.getAllPoducts(); 
        }

        public ProductCatalog getProductById()
        {
            return productCatalogDAL.getProductById(this.productId);
        }


    }
}
