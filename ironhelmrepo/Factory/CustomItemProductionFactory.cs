using Iron_helm_order_mgt.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.Factory
{
   public class CustomItemProductionFactory : IProductionFactory
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
                return new CustomArmour();
            }

            public Swords manufactureSwords()
            {
                return new CustomSword();
            }
            public Custom manufactureCustom()
            {
                return new CustomItem();
            }
    }
    }

