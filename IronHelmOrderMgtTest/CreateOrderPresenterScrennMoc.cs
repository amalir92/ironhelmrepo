using Iron_helm_order_mgt;
using ironhelmrepo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmOrderMgtTest
{
    class CreateOrderPresenterScrennMoc : ICreateOrderView
    {
        public string clientId { get ; set; }
        public DateTime expectedOrderCompletionDate { get; set; }
        public List<OrderLineItem> orderLines { get; set; }
    }
}
