using Microsoft.VisualStudio.TestTools.UnitTesting;
using Juggernaut.Authentication.Common;

namespace UnitTests._00_Common
{
    [TestClass]
    public class PasswordProtectorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string hash = PasswordProtector.PasswordToHash("thisIsMyPassowrd");
            Assert.IsTrue(hash.Length > 0, "Hashed password has no length");
        }

        [TestMethod]
        public void TestMethod2()
        {
            string password = "ThisIsMyPassword";
            Assert.AreNotEqual(
                PasswordProtector.PasswordToHash(password), password, "Hash is same as raw password");
        }

        [TestMethod]
        public void TestMethod3()
        {
            string password = "ThisIsMyPassword";
            string hashedPassword = PasswordProtector.PasswordToHash(password);
            Assert.IsTrue(
                PasswordProtector.VerifyPassword(password, hashedPassword), "Password not verified");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsFalse(
                PasswordProtector.VerifyPassword("passwor", PasswordProtector.PasswordToHash("password")),
                "Passwords should not have verified");
        }
    }
}
