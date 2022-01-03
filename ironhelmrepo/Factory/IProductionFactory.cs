using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt.Factory
{
    public interface IProductionFactory
    {
        Armour manufactureArmour();
        Swords manufactureSwords();
        Custom manufactureCustom();
        Packaging createPackaging();
        Delivery createDelivery();

    }
}
