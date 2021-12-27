using Iron_helm_order_mgt.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt
{
    public class IronHelmDBContextInitializer:DropCreateDatabaseIfModelChanges<IronHelmDbContext>
    {
        protected override void Seed(IronHelmDbContext context)
        {
            base.Seed(context);
            context.Users.AddRange(new[]
            {
                new User {userId="001C",userType="Client",password="1234"},
                new User {userId="002C",userType="Client",password="1234"},
                new User {userId="003C",userType="Client",password="1234"},
                new User {userId="001A", userType="Admin", password="1234"}
            });

            context.ProductCatalogs.AddRange(new[]
            {
                new ProductCatalog {productId="001P",productName="sword",productDescription="sword"},
                new ProductCatalog {productId="002P",productName="armour",productDescription="armour"},
                new ProductCatalog {productId="003P",productName="custom",productDescription="custom order"}
            });

            context.Customers.AddRange(new[]
           {
                new Customer {clientId="001C",clientAddress="no 9 durham",customerSource=CustomerSource.ENTERTAINMENT},
                new Customer {clientId="002C",clientAddress="no 9 durham",customerSource=CustomerSource.STATE},
                new Customer {clientId="003C",clientAddress="no 9 durham",customerSource=CustomerSource.INDIVIDUAL}
            });


            context.SaveChanges();
        }
    }
}
