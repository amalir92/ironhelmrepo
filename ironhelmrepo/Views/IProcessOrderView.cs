using Iron_helm_order_mgt;
using ironhelmrepo.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.Views
{
    public interface IProcessOrderView
    {
        IOrder order { get; set; }
    }
}
