using ironhelmrepo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmOrderMgtTest
{
    class ClientPortalPresenterScreenMoc : IPortalView
    {
        public int orderId { get; set; }
        public string clientId { get; set; }
        public string orderStatus { get; set; }

    }
}
