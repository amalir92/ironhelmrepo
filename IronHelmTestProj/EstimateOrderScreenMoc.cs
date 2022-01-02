using ironhelmrepo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmTestProj 
{
    class EstimateOrderScreenMoc : IEstimateOrderView
    {
        public int orderId { get; set; }
        public string clientId { get; set; }
        public string orderStatus { get; set; }
        public DateTime estimatedDate { get; set; }
        public double packageCost { get; set; }
        public double deliveryCost { get; set; }
        public double totalCost { get; set; }
        public int hours { get; set; }
        public double costPerHour { get; set; }
        public string productCode { get; set; }
        public int quantity { get; set; }

    }
}
