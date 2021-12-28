using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt
{
    public class ProductCatalog
    {
        public ProductCatalog()
        {

        }
        [Key]
        public String productId { get; set; }

        [Required]
        public String productName { get; set; }

        public String productDescription { get; set; }

        public ProductCatalog(string productId,string productName, string productDescription)
        {
            this.productId = productId;
            this.productName = productName;
            this.productDescription = productDescription;
        }

        public ProductCatalog createNewProduct(string productId,string productName,string productDescription)
        {
            return new ProductCatalog(productId, productName, productDescription);
        }

    }
}
