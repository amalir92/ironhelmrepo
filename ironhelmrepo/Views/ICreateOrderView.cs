using Iron_helm_order_mgt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.Views
{
    public interface ICreateOrderView
    {
        string clientId { get; set; } 

        DateTime expectedOrderCompletionDate { get; set; }

        List<OrderLineItem> orderLines { get; set; }

    }
}
