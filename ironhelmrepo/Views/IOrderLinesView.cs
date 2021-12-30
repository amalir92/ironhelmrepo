using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.Views
{
    public interface IOrderLinesView
    {
        int orderId { get; set; }

        string clientId { get; set; }
    }
}
