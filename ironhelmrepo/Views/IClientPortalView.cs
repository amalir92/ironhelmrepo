using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironhelmrepo.Views
{
    public interface IClientPortalView
    {
      string clientId { get; set; }
      string orderStatus { get; set; }
      
      int orderId { get; set; }

    }
}
