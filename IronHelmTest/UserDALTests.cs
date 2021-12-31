using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Iron_helm_order_mgt.DAL;
using System.Data;
using Iron_helm_order_mgt;

namespace IronHelmTest
{
    [TestClass]
    public class UserDALTests
    {
        [TestMethod]
        public void loginByUserNameAndPassword_NoUserNamePassword()
        {
            String username = "";
            String password = "";
            User user = new User();
            user.userId = username;
            user.password = password ;
            UserDAL userDAL = new UserDAL();
            DataTable dt = userDAL.loginByUserNameAndPassword(user);
            Assert.IsNull(dt.DataSet);
        }

        [TestMethod]
        public void loginByUserNameAndPassword_NoUserNameInDB()
        {
            String username = "User1";
            String password = "1234";
            User user = new User();
            user.userId = username;
            user.password = password;
            UserDAL userDAL = new UserDAL();
            DataTable dt = userDAL.loginByUserNameAndPassword(user);
            Assert.IsNull(dt.DataSet);
        }

        [TestMethod]
        public void loginByUserNameAndPassword_IncorrectPassword()
        {
            String username = "001C";
            String password = "pass1";
            User user = new User();
            user.userId = username;
            user.password = password;
            UserDAL userDAL = new UserDAL();
            DataTable dt = userDAL.loginByUserNameAndPassword(user);
            Assert.IsNull(dt.DataSet);
        }

        [TestMethod]
        public void loginByUserNameAndPassword_correctcredentials()
        {
            String username = "001C";
            String password = "1234";
            User user = new User();
            user.userId = username;
            user.password = password;
            UserDAL userDAL = new UserDAL();
            DataTable dt = userDAL.loginByUserNameAndPassword(user);
            Assert.IsNotNull(dt);
        }
    }
}
