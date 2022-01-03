using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt.Factory
{
    public class GovernmentItemProductionFactory:IProductionFactory
    {
        public Delivery createDelivery()
        {
            return new StandardDelivery();
        }

        public Packaging createPackaging()
        {
            return new StandardPackaging();
        }

        public Armour manufactureArmour()
        {
            return new StateArmour();
        }

        public Swords manufactureSwords()
        {
            return new StateSwords();
        }
        public Custom manufactureCustom()
        {
            return new CustomItem();
        }
    }
}
