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
        [Key]
        public String productId { get; set; }

        [Required]
        public String productName { get; set; }

        public String productDescription { get; set; }

    }
}
