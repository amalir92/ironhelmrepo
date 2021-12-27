using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt
{
    public class User
    {
        [Key]
        public String userId { get; set; }

        public String userType { get; set; }

        public String password { get; set; }

    }

}
