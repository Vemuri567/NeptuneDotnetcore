using Neptune360UIAutomation.RewriteTests.Pages;
using Neptune360UIAutomation.SeleniumLibraries;
using NUnit.Framework;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation.RewriteTests
{
    [TestFixture]
    [Parallelizable]
    public class LoginPageTest : Hooks
    {
        LoginPage loginPage = null;
        public LoginPageTest() : base(BrowerType.Chrome)
        {

        }

        [OneTimeSetUp]
        public void Initialized()
        {
            loginPage = new LoginPage(Driver);
        }

        [Test]
        public void Should_Login_Successfully()
        {
            loginPage.Login();
        }

        [Test]
        public void Should_LogOut_Successfully()
        {
            loginPage.LogOff(); ;
        }
    }
}
