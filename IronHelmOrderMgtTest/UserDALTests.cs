using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Iron_helm_order_mgt.DAL;
using System.Data;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public class UserDALTests
    {
        [TestMethod]
        public void loginByUserNameAndPassword_NoUserNamePassword()
        {
            String username = "";
            String password = "";
            UserDAL userDAL = new UserDAL();
            DataTable dt = userDAL.loginByUserNameAndPassword(username, password);
            Assert.IsNull(dt.DataSet);
        }

        [TestMethod]
        public void loginByUserNameAndPassword_NoUserNameInDB()
        {
            String username = "User1";
            String password = "1234";
            UserDAL userDAL = new UserDAL();
            DataTable dt = userDAL.loginByUserNameAndPassword(username, password);
            Assert.IsNull(dt.DataSet);
        }

        [TestMethod]
        public void loginByUserNameAndPassword_IncorrectPassword()
        {
            String username = "001C";
            String password = "pass1";
            UserDAL userDAL = new UserDAL();
            DataTable dt = userDAL.loginByUserNameAndPassword(username, password);
            Assert.IsNull(dt.DataSet);
        }

        [TestMethod]
        public void loginByUserNameAndPassword_correctcredentials()
        {
            String username = "001C";
            String password = "1234";
            UserDAL userDAL = new UserDAL();
            DataTable dt = userDAL.loginByUserNameAndPassword(username, password);
            Assert.IsNotNull(dt);
        }
    }
}
