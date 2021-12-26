using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt.Factory
{
    public class ClientOrder
    {
        private Order order;
        private Packaging packaging;
        private Delivery delivery;
        private Swords swords;
        private Armour armour;

        public ClientOrder(IProductionFactory factory,List<ProductCatalog> products)
        {
            packaging = factory.createPackaging();
            delivery = factory.createDelivery();
            foreach (ProductCatalog product in products){
                if (product.productName=="sword")
                {
                    swords = factory.manufactureSwords();
                }
                if (product.productName == "armour")
                {
                    armour = factory.manufactureArmour();
                }
            }
            
            
        }

        public Packaging clientPackaging
        {
            get { return packaging; }
        }

        public Delivery clientDelivery
        {
            get { return delivery; }
        }

        public Swords clientSwords
        {
            get { return swords; }
        }
        
        public Armour clientArmour
        {
            get { return armour; }
        }
    }
}
