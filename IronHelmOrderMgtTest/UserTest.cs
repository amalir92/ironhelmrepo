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

        [DataTestMethod]
        [DataRow ("001C", "1234")]
        public void ConstructorTest01(string username, string password)
        {
            User target = new User(username, password);
            Assert.IsNotNull(target);
        }

        
    }
}
 