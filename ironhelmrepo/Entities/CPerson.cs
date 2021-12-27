using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt
{
    public class CPerson : Customer
    {

        //public virtual User userId { get; set; }

        public String personName { get; set; }
        public String bankName { get; set; }

        public String swiftCode { get; set; } 
    }
}
