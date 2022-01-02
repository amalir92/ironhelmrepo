// <copyright file="UserTest.cs">Copyright ©  2021</copyright>
using System;
using System.Data;
using Iron_helm_order_mgt;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Tests
{
    /// <summary>This class contains parameterized unit tests for User</summary>
    [PexClass(typeof(User))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class UserTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public User ConstructorTest()
        {
            User target = new User();
            return target;
            // TODO: add assertions to method UserTest.ConstructorTest()
        }

        /// <summary>Test stub for .ctor(String, String)</summary>
        [PexMethod]
        public User ConstructorTest01(string username, string password)
        {
            User target = new User(username, password);
            return target;
            // TODO: add assertions to method UserTest.ConstructorTest01(String, String)
        }

        /// <summary>Test stub for encryptPassword(String)</summary>
        [PexMethod]
        public string encryptPasswordTest([PexAssumeUnderTest]User target, string password)
        {
            string result = target.encryptPassword(password);
            return result;
            // TODO: add assertions to method UserTest.encryptPasswordTest(User, String)
        }

        /// <summary>Test stub for getUserByLoginId(String, String)</summary>
        [PexMethod]
        public DataTable getUserByLoginIdTest(
            [PexAssumeUnderTest]User target,
            string username,
            string password
        )
        {
            DataTable result = target.getUserByLoginId(username, password);
            return result;
            // TODO: add assertions to method UserTest.getUserByLoginIdTest(User, String, String)
        }
    }
}
