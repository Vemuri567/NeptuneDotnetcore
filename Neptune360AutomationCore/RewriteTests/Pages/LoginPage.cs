using Neptune360UIAutomation.SeleniumLibraries;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using PageFactoryCore;

namespace Neptune360UIAutomation.RewriteTests.Pages
{
    [TestFixture]
    public class LoginPage
    {

        [FindsBy(How = How.Id, Using = "Username")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Login']")]
        public IWebElement ButtonLogin { get; set; }



        [FindsBy(How = How.XPath, Using = "//button[@class='k-button']")]
        public IWebElement DropDownListProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Logout']")]
        public IWebElement ButtonLogOut { get; set; }

        //public By drpProfileLogOut = By.XPath("//button[@class='k-button']");
        //public By btnLogOut = By.XPath("//span[text()='Logout']");


        IWebDriver _driver = null;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory page = new PageFactory(_driver);
        }

        public void Login()
        {
            _driver.Navigate().GoToUrl(@"http://www.qa.neptune360.com");
            _driver.sleepTime(5000);
            UserName.SendKeys("ethao@neptunetg.com");
            Password.SendKeys("Neptune123");
            ButtonLogin.Click();
        }

        public void LogOff()
        {
            DropDownListProfile.Click();
            ButtonLogOut.Click();
        }
    }
}
