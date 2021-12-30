using Iron_helm_order_mgt.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt
{
    public class User
    {
        private UserDAL userDal;
        public User() {
  
        }

        
        public User(string userId, string password)
        {
            this.userId = userId;
            this.password = password;
            userDal = new UserDAL();
        }

        [Key]
        public String userId { get; set; }

        public String userType { get; set; }

        public String password { get; set; }

        public DataTable getUserByLoginId()
        {
            DataTable dt = userDal.loginByUserNameAndPassword(this);
            return dt;
        }

    }

}
