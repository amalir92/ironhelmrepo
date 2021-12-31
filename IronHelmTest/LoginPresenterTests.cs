using ironhelmrepo.Presenters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace IronHelmTest
{
    [TestClass]
    public class LoginPresenterTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            LoginScreenMoc loginScreenMoc = new LoginScreenMoc();
            loginScreenMoc.username = "001C";
            loginScreenMoc.password = "1234";
            LoginPresenter presenter = new LoginPresenter(loginScreenMoc);
            DataTable dt = presenter.getUserByLoginId();
            Assert.AreEqual(dt.Rows[0][0], loginScreenMoc.username);
            Assert.AreEqual(dt.Rows[0][2], loginScreenMoc.password);
        }
    }
}
