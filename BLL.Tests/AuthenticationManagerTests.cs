using NUnit.Framework;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.BLL.Concrete;
using DAL.Concrete;

namespace BLL.Tests
{
    [TestFixture]
    public class AuthenticationManagerTests
    {
        private Mock<UserDAL> userDAL;
        private AuthenticationManager manager;

        [SetUp]
        public void Setup()
        {
            userDAL = new Mock<UserDAL>(MockBehavior.Strict);
            manager = new AuthenticationManager(userDAL.Object);
        }

        [Test]
        public void LoginUserTest_ValidCredentials()
        {
            string login = "login";
            string password = "password";

            userDAL.Setup(d => d.Login(login, password)).Returns(true);
            var result = manager.Login(login, password);

            Assert.IsTrue(result);
        }

        [Test]
        public void LoginUserTest_InvalidLogin()
        {
            string login = "";
            string password = "password";

            userDAL.Setup(d => d.Login(login, password)).Returns(false);
            var result = manager.Login(login, password);

            Assert.IsFalse(result);
        }

        [Test]
        public void LoginUserTest_InvalidPassword()
        {
            string login = "login";
            string password = "password";

            userDAL.Setup(d => d.Login(login, password)).Returns(false);
            var result = manager.Login(login, password);

            Assert.IsFalse(result);
        }

        //cases: wrond password, absent username and/or password
    }
}
