using Iron_helm_order_mgt.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_helm_order_mgt.Service
{
    public class UserService
    {
        private UserDAL userDAL;

        /// <constructor>
        /// Constructor UserBUS
        /// </constructor>
        public UserService()
        {
            userDAL = new UserDAL();
        }
        public DataTable getloginByUserNameAndPassword(string username, string password)
        {
            return userDAL.loginByUserNameAndPassword(username, password);

        }
    }
}
