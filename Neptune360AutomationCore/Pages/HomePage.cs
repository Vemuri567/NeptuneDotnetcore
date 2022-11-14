using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Neptune360UIAutomation
{
    public class HomePage : AbstractTemplatePage
    {
        #region UI Object Repository
        private By UserName = By.Id("Username");
        private By Password = By.Id("password");
        private By btnLogin = By.XPath("//button[text()='Login']");
        private By closeMenu = By.XPath("//li[@class='closeMenu']");
        private By dashboardLeftNavigation = By.XPath("//li//span[text()='DASHBOARD']");
        private By btnUserManagemet = By.XPath("//img[contains(@src,'UserManagement')]");
        private By btnDashBoard = By.XPath("//img[contains(@src,'Dashboard.3D')]");
        private By btnCustomerInquiry = By.XPath("//img[contains(@src,'CustomerInquiry.3D')]");
        private By btnBillingServices = By.XPath("//img[contains(@src,'BillingServices.3D')]");
        private By btnNotifications = By.XPath("//img[contains(@src,'Notifications.3D')]");
        private By btnUtilityManagement = By.XPath("//img[contains(@src,'UtilityManagement.3D')]");
        private By btnRouteManagement = By.XPath("//img[contains(@src,'RouteManagement.icon.svg')]");
        private By btnReports = By.XPath("//img[contains(@src,'Reports.icon')]");
        private By drpProfileLogOut = By.XPath("//i[2]");
        private By btnLogOut = By.XPath("//span[text()='Logout']");
        private By btnProfile = By.XPath("//span[text()='Profile']");
        private By lftNavPlatformManagement = By.XPath("//span[text()='PLATFORM MANAGEMENT']");
        private By lftNavMobileMMR = By.XPath("//span[text()='MOBILE MMR']");
        private By lftNavUserManagement = By.XPath("//span[text() = 'USER MANAGEMENT']");
        private By lblLandingPageWel = By.XPath("//span[text()='WELCOME ']");
        private By lftNavRoleManagement = By.XPath("//span[text() = 'ROLE MANAGEMENT ']");
        private By txtSearchAccounts = By.Id("txtAccountSearch");
        private By lftNavReports = By.XPath("//span[text()=' REPORTS']");
        private By LeftNavigationPane = By.XPath("//nav[@class='navbar navbar-opened']");
        private By lftNavDashboard = By.XPath("//span[text()='DASHBOARD']");
        private By lftNavCustomerInquiry = By.XPath("//span[text()='CUSTOMER INQUIRY']");
        private By lftNavBillingServices = By.XPath("//span[text()='BILLING SERVICES']");
        private By lftNavUtilityManagement = By.XPath("//span[text()='UTILITY MANAGEMENT']");
        private By lftNavAPIDeployment = By.XPath("//span[text()='API DEPLOYMENT']");
        private By lftNavPartnerManagement = By.XPath("//span[text()='PARTNER MANAGEMENT']");
        private By lftNavSDKAccess = By.XPath("//span[text()='SDK ACCESS']");
        private By lftNavDeviceManagement = By.XPath("//span[text()='DEVICE MANAGEMENT']");
        private By lftNavHandheldManagement = By.XPath("//span[text()='HANDHELD MANAGEMENT']");
        private By lftNavHandhelds = By.XPath("//span[text()='HANDHELDS']");
        private By lftNavHandheldSettings = By.XPath("//span[text()='HANDHELD SETTINGS']");
        private By lftNavSettings = By.XPath("//span[text()='SETTINGS']");
        private By lftNavDeviceActivations = By.XPath("//span[text()='DEVICE ACTIVATIONS']");
        private By lftNavAlertNotification=By.XPath("//span[text()='ALERT NOTIFICATIONS']");
        private By lftNavEmailNotifications = By.XPath("//span[text()='EMAIL NOTIFICATION']");
        private By lftNavRolesAndPermissions = By.XPath("//span[text()='ROLE MANAGEMENT ']");
        private By topNavigationPane = By.XPath("//sd-toolbar[@class = 'pull-left']/..");
        private By btnHome = By.ClassName("pull-left");
        private By profileScreen = By.ClassName("content-wrapper");
        private By OptChooseUtilities = By.XPath("//sd-menu/ul/li");
        private By chooseUtilitiesScreen = By.XPath("//span[text()='Choose Utilities']");
        private By btnChooseUtilitesCancel = By.XPath("//a[@role='button']");
        private By headerTitle = By.XPath("//span[text()='User Management']");
        private By lftNavImport = By.XPath("//span[text()='IMPORT FILES']");
        private By lftNavExport = By.XPath("//span[text()='EXPORT FILES']");
        private By billingServicesSettings = By.XPath("//span[text()='BILLING SERVICES SETTINGS']");
        private By fileMapper = By.XPath("//span[text()='FILE MAPPER']");
        private By lftNavExportHistory = By.XPath("//span[text()='EXPORT HISTORY']");
        private By lftRouteManagement = By.XPath("//span[text()='ROUTE MANAGEMENT']");
        private By screenDashboard = By.XPath("//span[text()='Dashboard']");
        private By screenCustomerInquiry = By.XPath("//h2[text()='Customer Inquiry']");
        private By screenImport = By.XPath("//h2[text()='Import Files']");
        private By screenNotifications = By.XPath("//h2[text()='Email Notification Editor']");
        private By screenUserManagement = By.XPath("//h2[text()='User Management']");
        private By screenUtilityManagement = By.XPath("//h2[text()='Utility Management']");
        private By screenRouteAssignments = By.XPath("//h2[text()='Route Assignments']");
        private By groups = By.XPath("//span[text()='GROUPS']");
        private By groupManagement = By.XPath("//span[text()='GROUP MANAGEMENT']");
        private By searchEndpoints = By.XPath("//span[text()='SEARCH ENDPOINTS']");
        private By btnAlert = By.XPath("//span[text()='Alert Notifications']"); 
        private By lftNavUsagePlan = By.XPath("//span[text()='USAGE PLANS']");
        private By lnkChooseUtilities = By.XPath("//sd-menu/ul/li");
        private By utilitySearch = By.Id("utilitySearchTextBox");
        private By btnChooseUtilitiesOk = By.Id("deactUtilityYesButton");
        private By tblChooseUtilities = By.XPath("//span[text()='Choose Utilities']//../../..//table[@class='k-grid-table']//span");


        #endregion

        #region Public Methods

        #region Navigate to Neptune360 Home page
        /// <summary>        
        /// Method to navigate to home page
        /// </summary>
        /// <param name="url"></param>
        /// <param name="testReport"></param>
        public void NavigateToHome(string url, string userName, string password, bool redirectToUrl=true)
        {
            try
            {
                if (redirectToUrl)
                {
                    driver.Navigate().GoToUrl(url);
                    driver.WaitForPageLoad(TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));
                    //driver.sleepTime(2000);                
                    testReport.Pass("Navigated to url: <mark>" + url + "</mark> successfully");
                }
                driver.WaitForElement(UserName, TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));
                driver.SendKeysToElement(UserName, userName, "UserName");
                driver.SendKeysToElement(Password, password, "Password");
                driver.ClickElement(btnLogin, "Login");

                DateTime eta = DateTime.Now.AddMinutes(1);
                bool isPageLoaded = false;
                while(!isPageLoaded && eta>DateTime.Now)
                {
                    if(driver.WaitForElement(closeMenu, TimeSpan.FromSeconds(10)))
                    {
                        isPageLoaded=true;
                        testReport.Debug("Close Menu displayed.");
                        break;
                    }
                    else
                    {
                        testReport.Debug("Refresh the page");
                        driver.Navigate().Refresh();
                    }
                }
                if(!isPageLoaded)
                {
                    ReporterFactory.LogFailure("Failed to navigate to url:");
                }
                //driver.Navigate().Refresh();
                //driver.RefreshPage();

            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to url:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
            //try
            //{
            //    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(150);
            //    try
            //    {
            //        driver.Navigate().GoToUrl(url);
            //    }
            //    catch
            //    {
            //        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(300);
            //        //driver.Navigate().GoToUrl(url);
            //        //driver.sleepTime(5000);
            //    }
            //    driver.WaitForPageLoad(TimeSpan.FromSeconds(120));
            //    driver.sleepTime(10000);
            //    if (driver.VerifyDoesnotExists(By.Id("Username"), "username"))
            //    {
            //        driver.Navigate().Refresh();
            //        driver.sleepTime(8000);
            //    }
            //    testReport.Pass("Navigated to url: <mark>" + url + "</mark> successfully");
            //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(300));
            //    wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("Username")));
            //    testReport.Pass("Navigated to url: <mark>" + url + "</mark> successfully");
            //    if (!driver.CheckElementDisplayed(By.Id("Username"), "Username"))
            //    {
            //        driver.Navigate().GoToUrl(url);
            //        driver.WaitForPageLoad(TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));
            //        //driver.sleepTime(2000);                
            //        testReport.Pass("Navigated to url: <mark>" + url + "</mark> successfully");
            //        WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(300));
            //        wait1.Until(ExpectedConditions.ElementToBeClickable(By.Id("Username")));
            //    }
            //    driver.WaitForElement(UserName, TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));

            //    driver.SendKeysToElement(UserName, userName, "UserName");                
            //    driver.SendKeysToElement(Password, password, "Password");
            //    driver.ClickElement(btnLogin, "Login");

            //    driver.WaitForElement(closeMenu, TimeSpan.FromSeconds(120));
            //    //driver.Navigate().Refresh();
            //    //driver.RefreshPage();

            //}
            //catch (Exception ex)
            //{
            //    ReporterFactory.LogFailure("Failed to navigate to url:" + url + "Error: <mark>" + ex.Message + "</mark>");
            //}
        }
        #endregion



        #region Navigate to Left Navigation Utility Management Page
        /// <summary>
        /// Method to Navigate to Utility Management Screen
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftUtilityDeviceManagement(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(lftNavUtilityManagement, "Utility Management");
                driver.ClickElement(lftNavDeviceManagement, "Device Management");
                //driver.sleepTime(5000);
                //driver.WaitForPageLoad(TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));

            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Utility Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        public void NavigateToLftUtilityDeviceManagement()
        {
            try
            {
                
                driver.ClickElement(lftNavUtilityManagement, "Utility Management");
                driver.ClickElement(lftNavDeviceManagement, "Device Management");
                //driver.sleepTime(5000);
                //driver.WaitForPageLoad(TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));

            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Utility Management Screen:" + " " + "Error: <mark>" + ex.Message + "</mark>");
            }
        }

        #endregion

        #region Navigate to Left Navigation Utility Management Settings Page
        /// <summary>
        /// Method to Navigate to Utility Management Screen
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftUtilitySettings(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(lftNavUtilityManagement, "Utility Management");
                driver.ClickElement(lftNavSettings, "Settings");
                ////driver.sleepTime(5000);
                //driver.WaitForPageLoad(TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));

            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Utility Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region Navigate to Groups
        /// <summary>
        /// Method to Navigate to Utility Management Screen
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftNavGroupManagement(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(groups, "Groups");
                driver.ClickElement(groupManagement, "Group Management");
                //driver.sleepTime(5000);
                //driver.WaitForPageLoad(TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));

            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Utility Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region Navigate to Groups
        /// <summary>
        /// Method to Navigate to Utility Management Screen
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftNavSearchEndpoints(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(groups, "Groups");
                driver.ClickElement(searchEndpoints, "Search Endpoints");
                //driver.sleepTime(5000);
                //driver.WaitForPageLoad(TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));

            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Utility Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region Navigate to Left Navigation Alert Configuration Page
        /// <summary>
        /// Method to Navigate to Utility Management Screen
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftAlertConfiguration(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(lftNavUtilityManagement, "Utility Management");
                driver.ClickElement(lftNavAlertNotification, "Alert Notification");
                //driver.sleepTime(5000);
                //driver.WaitForPageLoad(TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));

            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Utility Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region Navigate to Left Navigation API Deployment Page
        /// <summary>
        /// Method to Navigate to API Deployment Screen
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftAPIDeployment(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(lftNavPlatformManagement, "Platform Management");
                driver.ClickElement(lftNavAPIDeployment, "API Deployment");
                //driver.sleepTime(5000);
                //driver.WaitForPageLoad(TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));

            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Utility Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region Navigate to Left Navigation Partner Management Page
        /// <summary>
        /// Method to Navigate to Partner Management Page
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftPartnerManagement(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(lftNavPlatformManagement, "Platform Management");
                driver.ClickElement(lftNavPartnerManagement, "Partner Management");
                //driver.sleepTime(5000);
                //driver.WaitForPageLoad(TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));

            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Utility Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region Navigate to Online Help Page
        /// <summary>
        /// Method to Navigate to Partner Management Page
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToOnlineHelp(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                //driver.ClickElement(lftNavPlatformManagement, "Platform Management");
                //driver.ClickElement(lftNavPartnerManagement, "Partner Management");
                //driver.sleepTime(5000);
                //driver.WaitForPageLoad(TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));
                
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Utility Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region Navigate to Left Navigation Alert Notification Page
        /// <summary>
        /// Method to Navigate to Alert Notification Screen
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftAlertNotification(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
                driver.ClickElement(btnAlert, "Alert Notifications");
                //driver.sleepTime(5000);
                //driver.WaitForPageLoad(TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));

            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Utility Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion


        #region Navigate to Left Navigation SDK Access Page
        /// <summary>
        /// Method to Navigate to Utility Management Screen
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToSDKAccess(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(lftNavSDKAccess, "Utility Management");
                //driver.sleepTime(5000);
                driver.WaitForPageLoad(TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));

            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Utility Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion



        #region Navigate to Left Navigation Customer Inquiry Page
        /// <summary>
        /// Method to Navigate to Customer Inquiry Screen
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftCustomerInquiry(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.sleepTime(4000);
                driver.Navigate().Refresh();
                ValidateLftNavCustomerInquiryExists();
                driver.ClickElement(lftNavCustomerInquiry, "Customer Inquiry");
                driver.sleepTime(5000);
                //driver.WaitForPageLoad(TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Utility Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region Navigate to Left Navigation User Management Page
        /// <summary>
        /// Method to Left Navigate User Management
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftUserManagement(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(lftNavPlatformManagement, "Platform Management");
                driver.ClickElement(lftNavUserManagement, "User Management");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to User Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        public void NavigateToLftUserManagement()
        {
            try
            {
                driver.ClickElement(lftNavPlatformManagement, "Platform Management");
                driver.ClickElement(lftNavUserManagement, "User Management");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to User Management Screen:Error: <mark>" + ex.Message + "</mark>");
            }
        }

        #endregion

        #region Navigate to Left Navigation Device Management Page
        /// <summary>
        /// Method to Left Navigate User Management
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftDeviceActivations(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(lftNavPlatformManagement, "Platform Management");
                driver.ClickElement(lftNavDeviceActivations, "Device Activations");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to User Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion



        #region Navigate to Left Navigation Notifications Page
        /// <summary>
        /// Method to Left Navigate Email Notifications
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftEmailNotifications(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(lftNavPlatformManagement, "Platform Management");
                driver.ClickElement(lftNavEmailNotifications, "Email Notifications");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to User Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region Navigate to Left Navigation Roles and Permissions Page
        /// <summary>
        /// Method to Left Navigate Roles and Permissions
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftNavRolesPermissions(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(lftNavPlatformManagement, "Platform Management");
                driver.ClickElement(lftNavRolesAndPermissions, "Roles and Permissions");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Roles and Permissions Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region Navigate to Left Navigation Reports
        /// <summary>
        /// Method to Left Navigate Reports
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftNavReports(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.WaitForElement(lnkChooseUtilities, TimeSpan.FromSeconds(20));
                driver.sleepTime(3000);
                //UtilityManagementPage utilityManagement = new UtilityManagementPage();
                //utilityManagement.ValidateSearchUtilityNameOrId("50222");
                //driver.ClickElement(lnkChooseUtilities, "Utilities Dropdown");
                //driver.SendKeysToElementAndPressEnter(utilitySearch, "Montgomery", "Utility");
                //driver.ClickElement(tblChooseUtilities, "Select");
                //driver.ClickElement(btnChooseUtilitiesOk, "OK");
                driver.ClickElement(lftNavReports, "Reports");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Roles and Permissions Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }

        public void NavigateToLftNavReports()
        {
            try
            {               
                driver.WaitForElement(lnkChooseUtilities, TimeSpan.FromSeconds(20));

                driver.ClickElement(lftNavReports, "Reports");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Roles and Permissions Screen:Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region Navigate to Left Navigation Import Management Page
        /// <summary>
        /// Method to Left Navigate Import Management Page
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftNavImportManagement(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(lftNavBillingServices, "Billing Services");
                driver.ClickElement(lftNavImport, "Import Management");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Import Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion


        #region Navigate to Left Navigation Export Management Page
        /// <summary>
        /// Method to Left Navigate Export Management Page
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftNavExportManagement(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(lftNavBillingServices, "Billing Services");
                driver.ClickElement(lftNavExport, "Export Management");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Export Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region Navigate to Left Navigation Billing Services Settings Page
        /// <summary>
        /// Method to Left Navigate Export Management Page
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftNavBillingServicesSettings(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(lftNavBillingServices, "Billing Services");
                driver.ClickElement(billingServicesSettings, "Billing Services Settings");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Billing Services Settings Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region Navigate to Left Navigation File Mapper Page
        /// <summary>
        /// Method to Left Navigate Export Management Page
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftNavFileMapper(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(lftNavBillingServices, "Billing Services");
                driver.ClickElement(fileMapper, "File Mapper");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Billing Services Settings Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region Navigate to Left Navigation Export History Page
        /// <summary>
        /// Method to Left Navigate Export History Page
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateToLftNavExportHistory(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(lftNavBillingServices, "Billing Services");
                driver.ClickElement(lftNavExportHistory, "Export History");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Export Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region  Navigate to Landing Page User Management
        /// <summary>
        /// Method to Navigate to Landing Page User Management
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateLanPageUserManagement(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.sleepTime(3000);
                driver.ClickElement(btnUserManagemet, "User Management");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to User Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region Navigate to Landing Page Customer Inquiry Page
        /// <summary>
        /// Method to Navigate to Landing Page Customer Inquiry Page
        /// </summary>
        /// <param name="testCaseId"></param>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateLanPageCustomerInquiry(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.sleepTime(3000);
                try
                {
                    if(driver.FindElement(lftNavCustomerInquiry).Displayed == true)
                    {

                    }
                    else
                    {
                        driver.Navigate().Refresh();
                    }
                }
                catch(Exception e)
                {
                    driver.Navigate().Refresh();
                }
                driver.WaitForElement(lftNavCustomerInquiry, TimeSpan.FromSeconds(30));
                driver.ClickElement(btnCustomerInquiry, "Customer Inquiry");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Customer Inquiry:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region Navigate to Login Screen Page
        /// <summary>
        /// Method to Navigate to Login Screen Page
        /// </summary>
        /// <param name="testCaseId"></param>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateLanPageLoginScreen(string url, string userName, string password)
        {
            //try
            //{
            //    NavigateToHome(url, userName, password);
            //    driver.ClickElement(btnCustomerInquiry, "Customer Inquiry");
            //}
            //catch (Exception ex)
            //{
            //    ReporterFactory.LogFailure("Failed to navigate to Customer Inquiry:" + url + "Error: <mark>" + ex.Message + "</mark>");
            //}
            driver.Navigate().GoToUrl(url);
            driver.WaitForPageLoad(TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));
            driver.sleepTime(2000);
            testReport.Pass("Navigated to url: <mark>" + url + "</mark> successfully");
        }
        #endregion

        #region  Navigate to Landing Page Utility Management
        /// <summary>
        /// Method to Navigate to Landing Page Utility Management
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateLanPageUtilityManagement(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.sleepTime(3000);
                driver.ClickElement(btnUtilityManagement, "Utility Management");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to User Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region  Navigate to Landing Page Notifications
        /// <summary>
        /// Method to Navigate to Landing Page Notifications
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateLanPageNotifications(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.WaitForElement(btnNotifications, TimeSpan.FromSeconds(20));
                driver.CheckElementExists(btnNotifications, "Notifications");
                driver.ClickElement(btnNotifications, "Notifications");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Notifications Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region  Navigate to Navigations Page 
        /// <summary>
        /// Method to Navigate to Landing Page Notifications
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateNavigationsPage(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                //driver.sleepTime(3000);
                //driver.CheckElementExists(btnNotifications, "Notifications");
                //driver.ClickElement(btnNotifications, "Notifications");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Navigations Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region  Navigate to Usage Plan Page 
        /// <summary>
        /// Method to Navigate to Usage Plan Page
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateUsagePlanPage(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.ClickElement(lftNavPlatformManagement, "Platform Management");
                driver.ClickElement(lftNavUsagePlan, "Usage Plan");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Navigations Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region  Navigate to Route Management Page 
        /// <summary>
        /// Method to Navigate to Route Management Page
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateRouteManagementPage(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                //driver.sleepTime(3000);
                //driver.ClickElement(btnRouteManagement, "Route Management");
                //UtilityManagementPage utilityManagement = new UtilityManagementPage();
                //utilityManagement.ValidateSearchUtilityNameOrId("95665");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Route Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region  Navigate to Role Management Page 
        /// <summary>
        /// Method to Navigate to Route Management Page
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateRoleManagementPage(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                driver.WaitForElement(lftNavPlatformManagement, TimeSpan.FromSeconds(20));
                driver.ClickElement(lftNavPlatformManagement, "Platform Management");
                driver.ClickElement(lftNavRoleManagement, "Role Management");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Route Management Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region  Navigate to Dashboard Page 
        /// <summary>
        /// Method to Navigate to Dashboard Page
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateDashboardPage(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                //driver.sleepTime(3000);
                //driver.sleepTime(2000); driver.ClickElement(lnkChooseUtilities, "Utilities Dropdown");
                //driver.SendKeysToElementAndPressEnter(utilitySearch, "Montgomery", "Utility");
                //driver.ClickElement(tblChooseUtilities, "Select");
                //driver.ClickElement(btnChooseUtilitiesOk, "OK");
                driver.WaitForElement(lftNavDashboard, TimeSpan.FromSeconds(45));
                driver.ClickElement(lftNavDashboard, "Dashboard");
                //driver.ClickElement(btnNotifications, "Notifications");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Dashboard Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        #region  Navigate to Handheld Management Page 
        /// <summary>
        /// Method to Navigate to Handheld Management Page
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void NavigateHandheldManagement(string url, string userName, string password)
        {
            try
            {
                NavigateToHome(url, userName, password);
                //driver.sleepTime(3000);
                driver.WaitForElement(lftNavHandheldManagement, TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));
                driver.ClickElement(lftNavHandheldManagement, "Handheld Management");
                //driver.ClickElement(lftNavHandhelds, "Handhelds");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to navigate to Dashboard Screen:" + url + "Error: <mark>" + ex.Message + "</mark>");
            }
        }
        #endregion

        /// <summary>
        /// Method to User LogOut
        /// </summary>
        public void UserLogOut()
        {
            if (Utilities.ReadConfigFile("IsLogout") == "Y")
            {
                try
                {
                    driver.sleepTime(5000);
                    //driver.WaitForElement(drpProfileLogOut, TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));
                    driver.ClickElement(drpProfileLogOut, "Select");
                    driver.ClickElement(btnLogOut, "LogOut");
                }
                catch (Exception ex)
                {
                    ReporterFactory.LogFailure("Failed to User LogOut: <mark>" + ex.Message + "</mark>");
                }
            }
        }

       

        /// <summary>
        /// Method to Validate Landing Page Displayed
        /// </summary>
        public void ValidateLandingPageDisplayed()
        {
            try
            {
                driver.CheckElementExists(lblLandingPageWel, "Landing Page Welcome");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Landing Page <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Search Accounts Option
        /// </summary>
        public void ValidateSearchAccountsOption()
        {
            try
            {
                driver.CheckElementExists(txtSearchAccounts, "Search Accounts Option");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Search Accounts Option <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Dashboard Widget
        /// </summary>
        public void ValidateDashboardWidgetValidateDashboardWidget()
        {
            try
            {
                driver.CheckElementExists(btnDashBoard, "Dashboard Widget");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Dashboard Widget <mark>" + ex.Message + "</mark>");
            }
        }

        public void ValidateDashboardWidget()
        {
            try
            {
                driver.CheckElementExists(btnDashBoard, "Dashboard Widget");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Dashboard Widget <mark>" + ex.Message + "</mark>");
            }
        }
        public void ValidateDashboardNotDisplayed()
        {
                driver.ClickElement(btnDashBoard, "Dashboard widget");

        }
        public void ValidateUtilityManagementNotDisplayed()
        {
            driver.CheckElementDoesnotExists(lftNavUserManagement, "UtilityManagement");
        }
        public void ValidateReportsNotDisplayed()
        {
            driver.CheckElementDoesnotExists(btnReports, "Reports");
        }

        public void ValidateAccManagementNotDisplayed()
        {
            driver.CheckElementDoesnotExists(lftNavUserManagement, "Management");
        }
        public void ValidateReviewReadsNotDisplayed()
        {
            driver.CheckElementDoesnotExists(lftNavUserManagement, "Review Reads");
        }

        /// <summary>
        /// Method to Validate Customer Inquiry Widget
        /// </summary>
        public void ValidateCustomerInquiryWidget()
        {
            try
            {
                driver.CheckElementExists(btnCustomerInquiry, "Customer Inquiry Widget");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Customer Inquiry Widget <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Billing Services Widget
        /// </summary>
        public void ValidateBillingServicesWidget()
        {
            try
            {
                driver.CheckElementExists(btnBillingServices, "Billing Services Widget");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Billing Services Widget <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Notifications Widget
        /// </summary>
        public void ValidateNotificationsWidget()
        {
            try
            {
                driver.CheckElementExists(btnNotifications, "Notifications Widget");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Notifications Widget <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Notifications Widget Does Not Exists
        /// </summary>
        public void ValidateNotificationsWidgetDoesNotExists()
        {
            try
            {
                driver.CheckElementDoesnotExists(btnNotifications, "Notifications Widget");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Notifications Widget <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate User Management Widget
        /// </summary>
        public void ValidateUserManagementWidget()
        {
            try
            {
                driver.CheckElementExists(btnUserManagemet, "User Management Widget");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display User Management Widget <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Utility Management Widget
        /// </summary>
        public void ValidateUtilityManagementWidget()
        {
            try
            {
                driver.CheckElementExists(btnUtilityManagement, "Utility Management Widget");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Utility Management Widget <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Left Navigation Pane Exists
        /// </summary>
        public void ValidateLftNavigationPaneExists()
        {
            try
            {
                driver.sleepTime(10000);
                driver.CheckElementExists(LeftNavigationPane, "Left Navigation Pane");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Left Navigation Pane <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Left Navigation Dashboard Exists
        /// </summary>
        public void ValidateLftNavDashboardExists()
        {
            try
            {
                driver.CheckElementExists(lftNavDashboard, "Dashboard");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Dashboard <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Left Navigation Customer Inquiry Exists
        /// </summary>
        public void ValidateLftNavCustomerInquiryExists()
        {
            try
            {
                driver.WaitForElement(lftNavCustomerInquiry, TimeSpan.FromMinutes(1));
                driver.CheckElementExists(lftNavCustomerInquiry, "Customer Inquiry");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Customer Inquiry <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Left Navigation Billing Services Exists
        /// </summary>
        public void ValidateLftNavBillingServicesExists()
        {
            try
            {
                driver.CheckElementExists(lftNavBillingServices, "Billing Services");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Billing Services <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Left Navigation Notification Exists
        /// </summary>
        public void ValidateLftNavNotificationsExists()
        {
            try
            {
                driver.ClickElement(lftNavPlatformManagement, "Platform Management");
                driver.CheckElementExists(lftNavEmailNotifications, "Notifications");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Notification <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Left Navigation Notification Does Not Exists
        /// </summary>
        public void ValidateLftNavNotificationsDoesNotExists()
        {
            try
            {
                driver.CheckElementDoesnotExists(lftNavPlatformManagement, "Notifications");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Notification <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Left Navigation Utility Management Exists
        /// </summary>
        public void ValidateLftNavUtilityManagementExists()
        {
            try
            {
                driver.CheckElementExists(lftNavUtilityManagement, "Utility Management");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Utility Management <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Left Navigation Platform Management Exists
        /// </summary>
        public void ValidateLftNavPlatformManagementExists()
        {
            try
            {
                driver.CheckElementExists(lftNavPlatformManagement, "Platform Management");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Platform Management <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Left Navigation Platform Management Does Not Exists
        /// </summary>
        public void ValidateLftNavPlatformManagementDoesNotExists()
        {
            try
            {
                driver.CheckElementDoesnotExists(lftNavPlatformManagement, "Platform Management");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Platform Management <mark>" + ex.Message + "</mark>");
            }
        }
        
        /// <summary>
        /// Method to Validate Left Navigation User Management Exists
        /// </summary>
        public void ValidateLftNavUserManagementExists()
        {
            try
            {
                driver.ClickElement(lftNavPlatformManagement, "Platform Management");
                driver.CheckElementExists(lftNavUserManagement, "User Managment");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display User Management <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Left Navigation User Management Does Not Exists
        /// </summary>
        public void ValidateLftNavUserManagementDoesNotExists()
        {
            try
            {
                driver.CheckElementDoesnotExists(lftNavPlatformManagement, "User Managment");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display User Management <mark>" + ex.Message + "</mark>");
            }
        }

        public void ValidateLftNavMobileMMRNotExists()
        {
            try
            {
                driver.CheckElementDoesnotExists(lftNavMobileMMR, "Mobile MMR");
            }
            catch (Exception )
            {
                ReporterFactory.LogFailure("Mobile MMR IS Displayed");
            }
        }
        // <summary>
        /// Method to Validate Left Navigation Roles and Permissions Exists
        /// </summary>
        public void ValidateLftNavRolesAndPermissionsExists()
        {
            try
            {
                driver.ClickElement(lftNavPlatformManagement, "Platform Management");
                driver.CheckElementExists(lftNavRolesAndPermissions, "Roles and Permissions");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Roles and Permissions <mark>" + ex.Message + "</mark>");
            }
        }


        // <summary>
        /// Method to Validate Left Navigation Roles and Permissions Exists
        /// </summary>
        public void ValidateLftNavRolesAndPermissionsDoesNotExists()
        {
            try
            {
                driver.CheckElementDoesnotExists(lftNavPlatformManagement, "Roles and Permissions");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Roles and Permissions <mark>" + ex.Message + "</mark>");
            }
        }

        // <summary>
        /// Method to Validate Top Navigation Pane Exists
        /// </summary>
        public void ValidateTopNavigationPaneExists()
        {
            try
            {
                driver.sleepTime(10000);
                driver.CheckElementExists(topNavigationPane, "Top Navigation Pane");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Top Navigation Pane <mark>" + ex.Message + "</mark>");
            }
        }

        // <summary>
        /// Method to Validate Home Option Exists and Displayss
        /// </summary>
        public void ValidateHomeOptionExists()
        {
            try
            {
                driver.sleepTime(10000);
                driver.CheckElementExists(btnHome, "Home");
                driver.ClickElement(btnHome, "Home");
                driver.CheckElementExists(lblLandingPageWel, "Home Screen Displays");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Home Screen <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Profile Option and Screen on Top Navigation
        /// </summary>
        public void ValidateProfileOptionTopNavigation()
        {
            try
            {                
                driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
                driver.ClickElement(btnProfile, "Profile");
                //driver.WaitForElement(profileScreen, TimeSpan.FromSeconds(10));
                //driver.CheckElementExists(profileScreen, "Profile Screen");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Profile Screen <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate LogOut Option Top Navigation
        /// </summary>
        public void ValidateLogOutOptionTopNavigation()
        {
            try
            {
                driver.CheckElementExists(drpProfileLogOut, "Profile Dropdown");
                driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
                driver.CheckElementExists(btnLogOut, "LogOut");
                driver.ClickElement(btnLogOut, "LogOut");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to Validate LogOut Option display: <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Choose Utilities Option and Screen on Top Navigation
        /// </summary>
        public void ValidateChooseUtilitiesTopNavigation()
        {
            try
            {
                driver.CheckElementExists(OptChooseUtilities, "Choose Utilities Otion");
                driver.ClickElement(OptChooseUtilities, "Choose Utilities Option");
                driver.CheckElementExists(chooseUtilitiesScreen, "Choose Utilities Screen");
                driver.ClickElement(btnChooseUtilitesCancel, "Cancel Choose Utilities Screen");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display Profile Screen <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate User Management Widget
        /// </summary>
        public void ValidateUserIdentityManagement()
        {
            try
            {
                driver.CheckElementExists(btnUserManagemet, "User Management Widget");
                driver.ClickElement(btnUserManagemet, "User Management Widget");
                driver.sleepTime(6000);
                //driver.CheckElementExists(headerTitle, "User Management Screen");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display User Management Widget <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate User Management Widget Does Not Exists
        /// </summary>
        public void ValidateUserIdentityManagementDoesNotExists()
        {
            try
            {
                driver.CheckElementExists(btnUserManagemet, "User Management Widget");
                driver.ClickElement(btnUserManagemet, "User Management Widget");
                driver.sleepTime(6000);
                driver.CheckElementDoesnotExists(headerTitle, "User Management Screen");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed to display User Management Widget <mark>" + ex.Message + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Landing Page Dashboard Screen Display
        /// </summary>
        public void ValidateLandingPageDashboardScreenDisplay()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.CheckElementExists(screenDashboard, "Dashboard Screen Displays");
        }

        /// <summary>
        /// Method to Validate Landing Page Customer Inquiry Screen Display
        /// </summary>
        public void ValidateLandingPageCustomerInquiryScreenDisplay()
        {
            driver.ClickElement(btnCustomerInquiry, "Customer Inquiry");
            driver.CheckElementExists(screenCustomerInquiry, "Customer Inquiry Screen Displays");
        }

        /// <summary>
        /// Method to Validate Landing Page Billing Services Screen Display
        /// </summary>
        public void ValidateLandingPageBillingServicesScreenDisplay()
        {
            driver.ClickElement(btnBillingServices, "Billing Services");
            driver.CheckElementExists(screenImport, "Import Screen Displays");
        }

        /// <summary>
        /// Method to Validate Landing Page Notifications Screen Display
        /// </summary>
        public void ValidateLandingPageNotificationsScreenDisplay()
        {
            driver.ClickElement(btnNotifications, "Notifications");
            driver.CheckElementExists(screenNotifications, "Notifications Screen Displays");
        }

        /// <summary>
        /// Method to Validate Landing Page User Management Screen Display
        /// </summary>
        public void ValidateLandingPageUserManagementScreenDisplay()
        {
            driver.ClickElement(btnUserManagemet, "User Management");
            driver.CheckElementExists(screenUserManagement, "User Management Screen Displays");
        }

        /// <summary>
        /// Method to Validate Landing Page Utility Management Screen Display
        /// </summary>
        public void ValidateLandingPageUtilityManagementScreenDisplay()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.CheckElementExists(screenUtilityManagement, "Utility Management Screen Displays");
        }

        /// <summary>
        /// Method to Validate Landing Page Route Management Screen Display
        /// </summary>
        public void ValidateLandingPageRouteManagementScreenDisplay()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.CheckElementExists(screenRouteAssignments, "Route Assignments Screen Displays");
        }
        #endregion
    }
}
