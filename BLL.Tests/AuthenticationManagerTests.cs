using NUnit.Framework;
using Moq;
using TradingCompany.BLL.Concrete;
using DAL.Interfaces;

namespace BLL.Tests
{
    [TestFixture]
    public class AuthenticationManagerTests
    {
        private Mock<IUserDAL> userDAL;
        private AuthenticationManager manager;

        [SetUp]
        public void Setup()
        {
            userDAL = new Mock<IUserDAL>(MockBehavior.Strict);
            manager = new AuthenticationManager(userDAL.Object);
        }

        [Test]
        public void LoginUserTest_ValidCredentials()
        {
            string login = "Login1";
            string password = "Password1";

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
    }
}
