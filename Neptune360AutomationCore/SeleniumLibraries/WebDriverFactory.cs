using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
//using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
namespace Neptune360UIAutomation
{
    /// <summary>
    /// @Author - Pavan Parmar
    /// </summary>
    public class WebDriverFactory
    {
        private static IWebDriver uniqueInstanceWebDriver = null;

        /// <summary>
        /// Prevents a default instance of the <see cref="WebDriverFactory"/> class from being created.
        /// </summary>
        private WebDriverFactory()
        {
        }

        /// <summary>
        /// Gets the web driver.
        /// </summary>
        /// <param name="browser">The browser.</param>
        /// <returns></returns>
        public static IWebDriver getWebDriver(string browser)
        {
            lock (typeof(IWebDriver))
            {
                if (uniqueInstanceWebDriver == null)
                {
                    //Console.WriteLine(String.Format("Current Directory - {0}", System.IO.Directory.GetCurrentDirectory()));
                    string r450dbtesting = Utilities.ReadConfigFile("R450DBTesting");
                    if (r450dbtesting.ToUpper() == "YES")
                    {
                        return null;
                    }
                    switch (browser.ToLower())
                    {
                        case ("chrome"):
                            string appdatapath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                            appdatapath = appdatapath.Replace("Roaming", "");

                            ChromeOptions options = new ChromeOptions();
                            options.AddArguments("--no-sandbox");
                            options.AddArguments("--disabled-dev-shm-usage");
                            options.AddArguments("--headless");
                            options.AcceptInsecureCertificates = true;
                            options.AddArgument("--ignore-ssl-errors=yes");
                            options.AddArgument("--ignore-certificate-errors");
                            options.AddArgument(string.Format("user-data-dir={0}", appdatapath + "Google\\Chrome\\User Data"));
                            options.AddUserProfilePreference("download.prompt_for_download", true);
                            options.AddArguments("--disable-extensions");
                            //uniqueInstanceWebDriver = new ChromeDriver(ChromeDriverService.CreateDefaultService(),options);

                            ////zalenium changes -start
                            //ChromeOptions options = new ChromeOptions();
                            //options.AcceptInsecureCertificates = true;
                            //options.AddArgument("--ignore-ssl-errors=yes");
                            //options.AddArgument("--ignore-certificate-errors");
                            //options.AddArgument(string.Format("user-data-dir={0}", appdatapath + "Google\\Chrome\\User Data"));
                            //options.AddUserProfilePreference("download.prompt_for_download", true);
                            //options.AddArguments("--disable-extensions");
                            uniqueInstanceWebDriver = new RemoteWebDriver(new Uri("http://44.209.11.137:80"), options);
                            ////zalenium changes -end
                            uniqueInstanceWebDriver.Manage().Window.Maximize();
                            break;


                        case ("ie"):
                            var ieOptions = new InternetExplorerOptions
                            {
                                //UnexpectedAlertBehavior = InternetExplorerUnexpectedAlertBehavior.Accept,
                                IgnoreZoomLevel = true,
                                EnableNativeEvents = false,
                                InitialBrowserUrl = "about:blank",
                                IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                                EnablePersistentHover = true
                            };
                            uniqueInstanceWebDriver = new InternetExplorerDriver(System.IO.Directory.GetCurrentDirectory(), ieOptions);
                            //int implicitWaitTime = 120;
                            //uniqueInstanceWebDriver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(implicitWaitTime));
                            //uniqueInstanceWebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(implicitWaitTime));
                            break;
                        case ("phantomjs"):
                            //uniqueInstanceWebDriver = new PhantomJSDriver();
                            break;
                        case ("edge"):
                            uniqueInstanceWebDriver = new EdgeDriver(@"C:\Users\Naveen Kumar\OneDrive - QualiZeal\Documents\Esge");
                            uniqueInstanceWebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                            //string serverPath = "Microsoft Web Driver";
                            //// location for MicrosoftWebDriver.exe
                            //if (System.Environment.Is64BitOperatingSystem)
                            //{
                            //    serverPath = System.IO.Path.Combine(System.Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%"), serverPath);
                            //}
                            //else
                            //{
                            //    serverPath = System.IO.Path.Combine(System.Environment.ExpandEnvironmentVariables("%ProgramFiles%"), serverPath);
                            //}
                            //EdgeOptions edgeOptions = new EdgeOptions();                            
                            //edgeOptions.PageLoadStrategy = EdgePageLoadStrategy.Eager;
                            //uniqueInstanceWebDriver = new EdgeDriver(serverPath, edgeOptions);
                            //uniqueInstanceWebDriver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(10));
                            break;
                        case ("firefox"):
                            FirefoxOptions firefoxOptions = new FirefoxOptions();
                            // firefoxOptions.AddAdditionalCapability(CapabilityType.BrowserName, "firefox");
                            //add Firefox Options 
                            uniqueInstanceWebDriver = new FirefoxDriver(firefoxOptions);
                            break;
                    }
                    uniqueInstanceWebDriver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(60));
                    uniqueInstanceWebDriver.Manage().Window.Maximize();
                }

                return uniqueInstanceWebDriver;
            }
        }

        /// <summary>
        /// Gets the web driver.
        /// </summary>
        /// <returns></returns>
        public static IWebDriver getWebDriver()
        {
            //if (uniqueInstanceWebDriver == null)
            //{
            //    //Console.WriteLine("It comes here");
            //}
            //else
            //    Console.WriteLine("It comes here with initalize");
            return uniqueInstanceWebDriver;
        }

        /// <summary>
        /// Frees this instance.
        /// </summary>
        public static void Free()
        {
            uniqueInstanceWebDriver = null;

        }
    }
}
