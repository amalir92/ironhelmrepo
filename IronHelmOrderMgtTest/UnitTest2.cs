using Iron_helm_order_mgt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace IronHelmOrderMgtTest
{
    [TestClass]
    public partial class UserTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            User target = new User();
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void ConstructorTest01(string username, string password)
        {
            User target = new User("001C", "1234");
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void encryptPasswordTest(User target, string password)
        {
            string result = target.encryptPassword(password);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void getUserByLoginIdTest(
            User target,
            string username,
            string password
        )
        {
            DataTable result = target.getUserByLoginId(username, password);
            Assert.IsNotNull(result);
        }
    }
}
 