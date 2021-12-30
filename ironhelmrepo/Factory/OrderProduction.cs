using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt.Factory
{
    public class OrderProduction
    {

        private Packaging packaging;
        private Delivery delivery;
        private Swords swords;
        private Armour armour;
        private Order order;

        public OrderProduction(IProductionFactory factory,List<ProductCatalog> products,Order order)
        {
            this.order = order;
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
        public Order clientOrder
        {
            get { return order; }
        }
    }
}
