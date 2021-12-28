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
        public User()
        {

        }
        public User(string userId, string userType, string password)
        {
            this.userId = userId;
            this.userType = userType;
            this.password = password;
        }

        [Key]
        public String userId { get; set; }

        public String userType { get; set; }

        public String password { get; set; }

    }

}
