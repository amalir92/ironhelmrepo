using Iron_helm_order_mgt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.Views
{
    public interface IEstimateOrderView
    {
        int orderId { get; set; }

        string clientId { get; set; }
        string orderStatus { get; set; }

        DateTime estimatedDate { get; set; }

        double packageCost { get; set; }

        double deliveryCost { get; set; }
        double totalCost { get; set; }

        int hours { get; set; }

        double costPerHour { get; set; }

        string productCode { get; set; }

        int quantity { get; set; }
    }
}
