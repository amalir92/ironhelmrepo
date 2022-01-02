using Iron_helm_order_mgt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.IModels
{
    public interface IProduct
    {
        ProductCatalog createNewProduct(string productId, string productName, string productDescription);

        DataTable getAllProducts();

        ProductCatalog getProductById();
    }
}
