using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation.SeleniumLibraries
{
    public enum BrowerType
    {
        Chrome,
        Firefox,
        IE
    }


    //Fixture for class
    [TestFixture]
    public class Hooks : Base
    {
        public BrowerType _browserType;


        public Hooks(BrowerType browser)
        {
            _browserType = browser;
        }


        [OneTimeSetUp]
        public void InitializeTest()
        {
            ChooseDriverInstance(_browserType);
        }

        public void ChooseDriverInstance(BrowerType browserType)
        {
            //var driverDir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembl‌​y().Location);



            if (browserType == BrowerType.Chrome)
            {

                ChromeOptions options = new ChromeOptions();


                options.AddUserProfilePreference("download.prompt_for_download", true);
                options.AddArguments("--disable-extensions");
                Driver = new RemoteWebDriver(new Uri("http://zalenium.qa.neptune360.com/wd/hub"), options);
                //Driver = new ChromeDriver(options);
                Driver.Manage().Window.Maximize();

            }

            else if (browserType == BrowerType.Firefox)
            {
                ChromeOptions options = new ChromeOptions();
                Driver = new RemoteWebDriver(new Uri("http://zalenium.qa.neptune360.com/wd/hub"), options);

            }
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }


    }
}
