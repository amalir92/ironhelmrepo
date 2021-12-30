using Iron_helm_order_mgt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.Views
{
    public interface IAdminPortalView
    {
        int orderId { get; set; }
        int clientId { get; set; }

        string orderStatus { get; set; }
    }
}
