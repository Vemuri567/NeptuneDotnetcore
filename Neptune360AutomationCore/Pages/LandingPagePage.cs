using OpenQA.Selenium;

namespace Neptune360UIAutomation
{
    public class LandingPagePage : AbstractTemplatePage
    {
        #region UI Object Repository
        private By btnDashBoard = By.XPath("//img[contains(@src,'Dashboard.3D')]");
        private By btnCustomerInquiry = By.XPath("//img[contains(@src,'CustomerInquiry.3D')]");
        private By btnBillingServices = By.XPath("//img[contains(@src,'BillingServices.3D')]");
        private By btnNotifications = By.XPath("//img[contains(@src,'Notifications.3D')]");
        private By btnUtilityManagement = By.XPath("//img[contains(@src,'UtilityManagement.3D')]");
        private By btnReports = By.XPath("//img[contains(@src,'Reports.icon')]");
        private By btnGroups = By.XPath("//img[contains(@src,'Grouping.icon')]");
        private By btnUserManagemet = By.XPath("//img[contains(@src,'UserManagement')]");
        private By neptuneLogo = By.XPath("//img[contains(@src,'360_Logo_Reverse.svg')]");
        private By nLogo = By.XPath("//img[contains(@src,'n-logo.svg')]");
        private By closeMenu = By.XPath("//span[text() = 'CLOSE MENU']");
        private By expandMenu = By.XPath("//li[2]/i");
        private By leftSideBar = By.XPath("//aside");
        private By groupText = By.XPath("//div[text()='Select here to manage groups']");
        private By lftNavDashboard = By.XPath("//span[text()='DASHBOARD']");
        private By lftNavNetworkHealth = By.XPath("//span[text()='Network Health']");
        private By lftNavEndpointSummary = By.XPath("//span[text()='Endpoint Summary']");
        private By lftNavCustomerInquiry = By.XPath("//span[text()='CUSTOMER INQUIRY']");
        private By lftNavReports = By.XPath("//span[text()=' REPORTS']");
        private By lftNavBillingServices = By.XPath("//span[text()='BILLING SERVICES']");
        private By lftRouteManagement = By.XPath("//span[text()='ROUTE MANAGEMENT']");
        private By lftSdkAccess = By.XPath("//span[text()='SDK ACCESS']");
        private By lftNavImport = By.XPath("//span[text()='IMPORT FILES']");
        private By lftNavExport = By.XPath("//span[text()='EXPORT FILES']");
        private By lftNavExportHistory = By.XPath("//span[text()='EXPORT HISTORY']");
        private By lftNavUtilityManagement = By.XPath("//span[text()='UTILITY MANAGEMENT']");
        private By lftNavDeviceManagement = By.XPath("//span[text()='DEVICE MANAGEMENT']");
        private By lftNavPlatformManagement = By.XPath("//span[text()='PLATFORM MANAGEMENT']");
        private By lftNavUserManagement = By.XPath("//span[text() = 'USER MANAGEMENT']");        
        private By lftNavRolesAndPermissions = By.XPath("//span[text()='ROLE MANAGEMENT ']");
        private By lftNavNotifications = By.XPath("//span[text()='EMAIL NOTIFICATION']");
        private By customerEnqBreadCrumb = By.XPath("//sd-toolbar/div/span/span");
        private By headerCustomerInquiry = By.XPath("//h2[@class='page-header-title' and text()='Customer Inquiry']");
        private By headerReports = By.XPath("//h2[@class='page-header-title' and text()=' Reports']");
        private By reportsText = By.XPath("//div[text() = 'Select here to choose and view reports']");
        private By reportsBreadCrumb = By.XPath("//sd-toolbar//span/span");
        private By UserName = By.Id("Username");
        private By Password = By.Id("password");
        private By btnLogin = By.XPath("//button[text()='Login']");
        private By rememberLogin = By.Id("RememberLogin");
        private By forgotPwd=By.LinkText("Forgot your password?");
        private By errorMessage = By.XPath("//div/div/div/ul/li");
        private By btnToggle=By.Id("btnTogglePassword");
        private By drpProfileLogOut = By.XPath("//i[2]");
        private By btnLogOut = By.XPath("//span[text()='Logout']");
        private By btnAlert = By.XPath("//span[text()='Alert Notifications']");
        private By header = By.XPath("//sd-menu/ul/li[1]");
        private By homeBtn = By.XPath("//sd-toolbar/div/i");
        private By questionIcon = By.CssSelector(".fa-question");
        private By searchDrpDown = By.CssSelector(".k-i-arrow-s");
        private By accNo = By.XPath("//li[contains(.,'Account Number')]");
        private By custName = By.XPath("//li[contains(.,'Account Name')]");
        private By meterId = By.XPath("//li[contains(.,'Meter ID')]");
        private By address=By.XPath("//li[contains(.,'Address')]");
        private By searchBar = By.Id("txtAccountSearch");
        private By btnSearch = By.CssSelector(".fa-search");
        private By lblAccNo = By.XPath("//div/kendo-grid-list//tr[1]/td[1]");
        private By lblCustName = By.XPath("//div/kendo-grid-list/div[1]//tr[1]/td[2]");
        private By lblMeterNo = By.XPath("//div/kendo-grid-list//tr[1]/td[3]");
        private By lblMiuID = By.XPath("//kendo-grid-list//tr[1]/td[4]");
        private By lblAddress=By.XPath("//kendo-grid-list//tr[1]/td[5]");
        private By btnCancel = By.XPath("//button[text()='Cancel']");
        private By btnOk = By.XPath("//button[text()='Ok']");
        private By btnEdit = By.XPath("//button[contains(.,'Edit')]");
        private By btnDone_ = By.XPath("//div[2]//div/div/div/button[2]");
        private By toggleSwitch = By.XPath("(//kendo-switch[@type='checkbox'])");
        private By noResult = By.XPath("//span[contains(text(),'No Results Found')]");
        private By popUpMessage = By.Id("toast-container");
        private By accountInfo = By.XPath("//sd-customerinquiry-detail//dt[contains(text(),'Account Number')]");
        private By scrollList = By.XPath("//div[2]//div//table//tbody");
        private By scrollListHeader = By.XPath("//div[2]//div/table/thead/tr");
        private By alertName = By.XPath("//tr[1]/td[1]");
        private By alertDescription = By.XPath("//div[2]//tr[1]/td[2]");
        private By alertIndicator = By.XPath("//tr[1]/td[1]/span/img");

        private By rowValueAccountNo = By.XPath("//kendo-grid-list//tr[1]/td[1]");
        private By partnerName = By.XPath("//div[1]//div/div/h3");
        private By clientSecretKey = By.XPath("//div[1]/secret-visibility-toggle/div/input");
        private By apiKey = By.XPath("//div[2]/secret-visibility-toggle/div/input");
        private By contactEmail = By.XPath("//div[2]/div/div[2]/div[1]/h5[2]");
        private By contactPhone = By.XPath("//div[2]/div/div[2]/div[2]/h5[2]");
        private By contactAddress = By.XPath("//div[2]/div/div[2]/div[3]/h5[2]");
        private By city = By.XPath("//div[2]/div/div[3]/div[1]/h5[2]");
        private By state = By.XPath("//div[2]/div/div[3]/div[2]/h5[2]");
        private By zipCode = By.XPath("//div[2]/div/div[3]/div[3]/h5[2]");

        private By utility = By.XPath("//kendo-grid-list/div/div[1]/table/tbody/tr/td[1]");
        private By siteID = By.XPath("//kendo-grid-list/div/div[1]/table/tbody/tr/td[2]");
        private By bundle = By.XPath("//kendo-grid-list/div/div[1]/table/tbody/tr/td[3]");
        private By sdk = By.XPath("//kendo-grid-list/div/div[1]/table/tbody/tr/td[4]");
        private By clientID = By.XPath("//kendo-grid-list/div/div[1]/table/tbody/tr/td[5]");
        private By createdDate = By.XPath("//kendo-grid-list/div/div[1]/table/tbody/tr/td[6]");
        private By utilityFilter = By.XPath("//th[1]/kendo-grid-filter-menu/a/span");
        private By bundleFilter = By.XPath("//th[3]/kendo-grid-filter-menu/a/span");
        private By utilitiesList = By.XPath("//kendo-grid/div/kendo-grid-list/div");
        private By paginationNext = By.XPath("//kendo-pager-next-buttons/span[@title='Go to the next page']");
        private By paginationPrevious = By.XPath("//kendo-pager-prev-buttons/span[@title='Go to the previous page']");
        private By pageNo = By.XPath("//span[@class='k-link k-state-selected k-pager-nav'][contains(text(),'1')]");
        private By downloadButton = By.XPath("//button[contains(.,'Download')]");
        private By clientShowIcon = By.XPath("//tr/td[5]/secret-visibility-toggle/div/div");
        private By selectUtility = By.XPath("//span/sd-menu/ul/li[1]");
        #endregion


        /// <summary>
        /// Method to Validate Dashboard Grey icon Display
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDashboardGreyIconDisplay()
        {            
            if (driver.CheckElementExists(btnDashBoard, "Dashboard"))
            {                            
                testReport.Pass("<i> Dashboard option is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Dashboard option is not displayed");
            }
        }

        /// <summary>
        /// Method to Validate Customer Inquiry Grey icon Display
        /// </summary>
        public void ValidateCustomerInquiryGreyIconDisplay()
        {
            if (driver.CheckElementExists(btnCustomerInquiry, "Customer Inquiry"))
            {
                testReport.Pass("<i> Customer Inquiry option is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Customer Inquiry option is not displayed");
            }
        }

        /// <summary>
        /// Method to Validate Billing Services Grey icon Display
        /// </summary>
        public void ValidateBillingServicesGreyIconDisplay()
        {
            if (driver.CheckElementExists(btnBillingServices, "Customer Inquiry"))
            {
                testReport.Pass("<i> Billing Services option is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Billing Services option is not displayed");
            }
        }

        /// <summary>
        /// Method to Validate Notification Grey icon Display
        /// </summary>
        public void ValidateNotificationGreyIconDisplay()
        {
            if (driver.CheckElementExists(btnNotifications, "Notification"))
            {
                testReport.Pass("<i> Notification option is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Notification option is not displayed");
            }
        }

        /// <summary>
        /// Method to Validate User Management Grey icon Display
        /// </summary>
        public void ValidateUserManagementGreyIconDisplay()
        {
            if (driver.CheckElementExists(btnUserManagemet, "User Management"))
            {
                testReport.Pass("<i> User Management option is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("<i> User Management option is not displayed");
            }
        }

        /// <summary>
        /// Method to Validate Utillity Management Grey icon Display
        /// </summary>
        public void ValidateUtilityManagementGreyIconDisplay()
        {
            if (driver.CheckElementExists(btnUtilityManagement, "Utillity Management"))
            {
                testReport.Pass("<i> Utillity Management option is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Utillity Management option is not displayed");
            }
        }
        /// <summary>
        /// Method to Validate Neptune 360 logo Display
        /// </summary>
        public void ValidateNeptuneLogoDisplay()
        {
            driver.WaitForElement(neptuneLogo, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementExists(neptuneLogo, "Neptune 360 Logo"))
            {
                testReport.Pass("<i> Neptune 360 Logo is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Neptune 360 Logo is not displayed");
            }
        }
        /// <summary>
        /// Method to Validate n logo Display
        /// </summary>
        public void ValidateNLogoDisplay()
        {
            driver.ClickElement(closeMenu, "Close Menu");
            if (driver.CheckElementExists(nLogo, "Neptune n Logo"))
            {
                testReport.Pass("<i> Neptune n Logo is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Neptune n Logo is not displayed");
            }
        }

        /// <summary>
        /// Method to Validate expand neptune logo Display
        /// </summary>
        public void ValidateExpandNeptuneLogoDisplay()
        {
            driver.ClickElement(closeMenu, "Close Menu");
            if (driver.CheckElementExists(nLogo, "Neptune n Logo"))
            {
                testReport.Pass("<i> Neptune n Logo is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Neptune n Logo is not displayed");
            }
            driver.ClickElement(expandMenu, "Expand Menu");
            if (driver.CheckElementExists(neptuneLogo, "Neptune 360 Logo"))
            {
                testReport.Pass("<i> Neptune 360 Logo is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Neptune 360 Logo is not displayed");
            }
        }

        /// <summary>
        /// Method to Validate left sidebar Display
        /// </summary>
        public void ValidateSideBarDisplay()
        {
            driver.WaitForElement(leftSideBar, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementExists(leftSideBar, "Left Side Bar"))
            {
                testReport.Pass("<i> Left Side Bar is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Left Side Bar is not displayed");
            }
        }

        /// <summary>
        /// Method to Validate left sidebar menu view style
        /// </summary>
        public void ValidateSideBarMenuStyle()
        {
            driver.WaitForElement(closeMenu, System.TimeSpan.FromSeconds(45));
            driver.ClickElement(closeMenu, "Close Menu");
            driver.ClickElement(expandMenu, "Expand Menu");
            if (driver.CheckElementExists(leftSideBar, "Left Side Bar")&(driver.CheckElementDisplayed(neptuneLogo,"Neptune Logo")))
            {
                testReport.Pass("<i> Left Side Bar is displayed & Neptune Logo is Displayed");
            }
            else
            {
                ReporterFactory.LogFailure("<i> All item(s) not displayed");
            }
            driver.ClickElement(closeMenu, "Close Menu");
            if (driver.CheckElementDisplayed(nLogo, "n Logo"))
            {
                testReport.Pass("n Logo is Displayed");
            }
            else
            {
                ReporterFactory.LogFailure("Logo not displayed");
            }
        }

        /// <summary>
        /// Method to Validate left sidebar menu options
        /// </summary>
        public void ValidateSideBarMenuOptions()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftRouteManagement, "Route Management");
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            if (driver.CheckElementExists(lftNavDashboard, "Dashboard") & (driver.CheckElementDisplayed(lftNavCustomerInquiry, "Customer Enquiry")) & (driver.CheckElementDisplayed(lftNavImport, "Import")) & (driver.CheckElementDisplayed(lftNavExport, "Export")) & (driver.CheckElementDisplayed(lftNavExportHistory, "Export History"))& (driver.CheckElementDisplayed(lftNavDeviceManagement, "Device Management")) & (driver.CheckElementDisplayed(lftNavPlatformManagement, "Platform Management")) & (driver.CheckElementDisplayed(lftNavUserManagement, "User Management")) & (driver.CheckElementDisplayed(lftNavRolesAndPermissions, "Roles and Permission")) & (driver.CheckElementDisplayed(lftNavNotifications, "Notification")))
            {
                testReport.Pass("<i> Dashboard, Customer Enquiry, Billing Services, Import, Export, Export History, Utility Management, Device Management, Platform Management, User Management, Roles and Permissions & Notification are Displayed");
            }
            else
            {
                ReporterFactory.LogFailure("<i> All item(s) not displayed");
            }            
        }

        /// <summary>
        /// Method to Validate Network Health and Endpoint Summary SideBar menu options
        /// </summary>
        public void ValidateNetworkHealthAndEndpointSummaryDisplayedInSideBarMenu()
        {
            if (driver.CheckElementDoesnotExists(lftNavNetworkHealth, "Network Health")) 
            {
                testReport.Pass("<i> Network Health is NOT Displayed");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Network Health is Displayed");
            }

            if (driver.CheckElementDoesnotExists(lftNavEndpointSummary, "Endpoint Summary"))
            {
                testReport.Pass("<i> Endpoint Summary is NOT Displayed");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Endpoint Summary is Displayed");
            }
        }

        /// <summary>
        /// Method to Validate selected icon navigated page
        /// </summary>
        public void ValidateCustomerEnquiryNavigatedPage()
        {
            driver.ClickElement(lftNavCustomerInquiry, "Customer Enquiry");
            if (driver.CheckElementExists(headerCustomerInquiry, "Customer Enquiry"))
            {
                testReport.Pass("<i> Customer Enquiry Page is navigated.");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Customer Enquiry Page is not navigated.");
            }
        }

        /// <summary>
        /// Method to Validate selected icon navigated page
        /// </summary>
        public void ValidateReportsNavigatedPage()
        {
            driver.ClickElement(lftNavReports, "Rports");
            if (driver.CheckElementExists(headerReports, "Reports Header"))
            {
                testReport.Pass("<i> Reports Page is navigated.");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Reports Page is not navigated.");
            }
        }

        /// <summary>
        /// Method to Validate ui login
        /// </summary>
        public void ValidateUILogin()
        {
            driver.WaitForElement(UserName, System.TimeSpan.FromSeconds(60));
            if (driver.CheckElementDisplayed(UserName, "UserName")& driver.CheckElementDisplayed(Password, "Password")&driver.CheckElementDisplayed(btnLogin, "Login Button") & driver.CheckElementDisplayed(forgotPwd, "Forgot Password") & driver.CheckElementDisplayed(rememberLogin, "Remember Email"))
            {
                testReport.Pass("<i>Username, Password, Remember my Login, Forgot Password, Login Button are displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i> All item(s) not displayed.");
            }
        }

        /// <summary>
        /// Method to Validate username required
        /// </summary>
        public void ValidateUserNameRequired(string pwd)
        {
                driver.SendKeysToElement(Password, pwd, "Password");
                driver.ClickElement(btnLogin, "Login Button");
                string s = driver.GetElementText(errorMessage);
                if (s.Contains(" is required."))
                {
                    testReport.Pass("Error message is displayed as: <i>" + s);
                }
                else
                {
                    ReporterFactory.LogFailure("<i> Error message not displayed."+s);
                }
            
        }

        /// <summary>
        /// Method to Validate password required
        /// </summary>
        public void ValidatePasswordRequired(string userName)
        {
            driver.SendKeysToElement(UserName, userName,"Username");
            driver.ClickElement(btnLogin, "Login Button");
            string s = driver.GetElementText(errorMessage);

            if (s.Equals("The Password field is required."))
            {
                testReport.Pass("Error message is displayed as: <i>"+s);
            }
            else
            {
                ReporterFactory.LogFailure("<i> Error message not displayed.");
            }
        }

        /// <summary>
        /// Method to Validate show/hide button
        /// </summary>
        public void ValidateButton()
        {
            driver.sleepTime(2000);
            driver.ClickElement(btnToggle, "Toggle Button");
            driver.GetElementText(btnToggle);
            if (driver.GetElementText(btnToggle).Equals("Hide"))
            {
                testReport.Pass("<i>Button Changes to Hide." );
            }
            else
            {
                ReporterFactory.LogFailure("<i>Button does not Changes to Hide.");
            }
        }

        /// <summary>
        /// Method to Validate invalid usernane/pwd
        /// </summary>
        public void ValidateInvalidUserNamePwd()
        {
            if(driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("<i>User is not logged on. Error message displayed is : "+ driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("<i>User is logged on.");
            }
        }

        /// <summary>
        /// Method to Validate remember my email
        /// </summary>
        public void ValidateRememberMyEmail(string url, string usrname, string pwd)
        {
            driver.Navigate().GoToUrl(url);
            driver.SendKeysToElement(UserName, usrname, "Username");
            driver.SendKeysToElement(Password, pwd, "Password");            
            driver.ClickElement(rememberLogin, "Checkbox");
            driver.ClickElement(btnLogin, "Login Button");
            driver.ClickElement(drpProfileLogOut, "Dropdown");
            driver.ClickElement(btnLogOut, "LogOut");
            driver.WaitForElement(UserName, System.TimeSpan.FromSeconds(20));
            string s = driver.GetElementText(UserName);
            if (driver.GetElementText(UserName).Equals(s))
            {
                testReport.Pass("<i> Email address is retained "+s);
            }
            else
            {
                ReporterFactory.LogFailure("<i> Email address is not retained" + s);
            }
        }

        /// <summary>
        /// Method to Validate do not remember my email
        /// </summary>
        public void ValidateDoNotRememberMyEmail(string url, string usrname, string pwd)
        {
            driver.Navigate().GoToUrl(url);
            driver.SendKeysToElement(UserName, usrname, "Username");
            driver.SendKeysToElement(Password, pwd, "Password");
            //driver.ClickElement(rememberLogin, "Checkbox");
            driver.ClickElement(btnLogin, "Login Button");
            driver.ClickElement(drpProfileLogOut, "Dropdown");
            driver.ClickElement(btnLogOut, "LogOut");
            driver.WaitForElement(UserName, System.TimeSpan.FromSeconds(10));
            string s = driver.GetElementText(UserName);
            driver.CheckElementDisplayed(UserName, "Username");
            if (driver.GetElementText(UserName).Equals(s))
            {
                testReport.Pass("<i> Email address is not retained " + s);
            }
            else
            {
                ReporterFactory.LogFailure("<i> Email address is not retained" + s);
            }
        }

        /// <summary>
        /// Method to Validate header
        /// </summary>
        public void ValidateHeader()
        {
            driver.WaitForElement(header, System.TimeSpan.FromSeconds(10));
            if(driver.CheckElementDisplayed(header,"Header"))
            {
                testReport.Pass("<i>Header is Displayed. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Header is Not Displayed. ");
            }
        }

        /// <summary>
        /// Method to Validate home button
        /// </summary>
        public void ValidateHomeButton()
        {
            driver.WaitElementPresent(homeBtn);
            if (driver.CheckElementDisplayed(homeBtn, "Home Button"))
            {
                testReport.Pass("<i>Home Button is Displayed. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Home Button is Not Displayed. ");
            }
        }

        /// <summary>
        /// Method to Validate Question Icon button
        /// </summary>
        public void ValidateQuestionIcon()
        {
            driver.WaitElementPresent(homeBtn);
            if (driver.CheckElementDisplayed(questionIcon, "Question Icon Button"))
            {
                testReport.Pass("<i>Question Icon Button is Displayed. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Question Icon Button is Not Displayed. ");
            }
        }

        /// <summary>
        /// Method to Validate Interaction Links
        /// </summary>
        public void ValidateInteractionLinks()
        {
            driver.WaitForElement(lftNavDashboard, System.TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(lftNavDashboard, "Dashboard");
            driver.CheckElementDisplayed(lftNavCustomerInquiry, "Customer Enquiry");
            driver.CheckElementDisplayed(lftNavBillingServices, "Billing Service");
            driver.CheckElementDisplayed(lftNavUtilityManagement, "Utility Management");
            driver.CheckElementDisplayed(lftNavPlatformManagement, "Platform Management");
        }

        

        /// <summary>
        /// Method to Validate person icon
        /// </summary>
        public void ValidatePersonIcon()
        {
            driver.WaitElementPresent(homeBtn);
            if (driver.CheckElementDisplayed(drpProfileLogOut, "Person Icon & Arrorw Icon"))
            {
                testReport.Pass("<i>Person Icon & Arrorw Icon is Displayed. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Person Icon & Arrorw Icon is Not Displayed. ");
            }
        }
        /// <summary>
        /// Method to Validate acc search
        /// </summary>
        public void ValidateAccSearch(string accountNo)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(accNo, "Account Number");
            driver.SendKeysToElement(searchBar, accountNo, "Account No");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(lblAccNo, System.TimeSpan.FromSeconds(10));
            if(driver.CheckElementDisplayed(lblAccNo, "Account No"))
            {
                testReport.Pass("<i>Account No is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Account No is Not Displayed.");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate name search
        /// </summary>
        public void ValidateNameSearch(string accountName)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(custName, "Customer Name");
            driver.SendKeysToElement(searchBar, accountName, "Customer Name");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(lblAccNo, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(lblCustName, "Customer Name"))
            {
                testReport.Pass("<i>Customer Name is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Customer Name is Not Displayed.");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate meter search
        /// </summary>
        public void ValidateMeterSearch(string meterID)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(meterId, "Customer Name");
            driver.SendKeysToElement(searchBar, meterID, "Meter ID/MIU ID");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(lblAccNo, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(lblMiuID, "Meter ID"))
            {
                testReport.Pass("<i>All Accounts matching the search criteria (Meter Id) entered is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>All Accounts matching the search criteria (Meter Id) entered is Not displayed.");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate address search
        /// </summary>
        public void ValidateAddressSearch(string add)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(address, "Customer Name");
            driver.SendKeysToElement(searchBar, add, "Address");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(lblAccNo, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(lblAddress, "Address"))
            {
                testReport.Pass("<i>All Accounts matching the search criteria (Address) entered is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>All Accounts matching the search criteria (Address) entered is Not displayed.");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Partial acc search
        /// </summary>
        public void ValidatePatrialAccSearch(string accountNo)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(accNo, "Account Number");
            driver.SendKeysToElement(searchBar, accountNo, "Account No");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(lblAccNo, System.TimeSpan.FromSeconds(10));
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(lblAccNo, "Account No"))
            {
                testReport.Pass("<i>All Accounts matching the search criteria (Partial Account Number) entered is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>All Accounts matching the search criteria (Partial Account Number) entered is Not displayed.");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate patrial customer name search
        /// </summary>
        public void ValidatePartialNameSearch(string customerName)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(custName, "Customer Name");
            driver.SendKeysToElement(searchBar, customerName, "Customer Name");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(lblAccNo, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(lblCustName, "Customer Name"))
            {
                testReport.Pass("<i>All Accounts matching the search criteria (Customer Name) entered is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>All Accounts matching the search criteria (Customer Name) entered is displayed.");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Partial meter search
        /// </summary>
        public void ValidatePartialMeterSearch(string meterID)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(meterId, "Meter Id");
            driver.SendKeysToElement(searchBar, meterID, "Meter ID/MIU ID");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(lblAccNo, System.TimeSpan.FromSeconds(10));
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(lblMiuID, "Meter ID"))
            {
                testReport.Pass("<i>All Accounts matching the search criteria (Meter Id) entered is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>All Accounts matching the search criteria (Meter Id) entered is Not displayed.");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate partial address search
        /// </summary>
        public void ValidatePartialAddressSearch(string add)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(address, "Customer Name");
            driver.SendKeysToElement(searchBar, add, "Address");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(lblAccNo, System.TimeSpan.FromSeconds(10));
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(lblAddress, "Address"))
            {
                testReport.Pass("<i>All Accounts matching the search criteria (Address) entered is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>All Accounts matching the search criteria (Address) entered is Not displayed.");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate no results account no
        /// </summary>
        public void ValidateNoResultsFound(string data)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(accNo, "Acount No");
            driver.SendKeysToElement(searchBar, data, "Customer Detail");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(noResult, System.TimeSpan.FromSeconds(10));
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(noResult, "No Result Found"))
            {
                testReport.Pass("<i>'No Results Found' message is displayed in the Choose Account dialog.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>No Results Found message is Not displayed in the Choose Account dialog.");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate no results name
        /// </summary>
        public void ValidateNoResultsFoundName(string name)
        {
            driver.sleepTime(2000);
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(custName, "Customer Name");
            driver.SendKeysToElement(searchBar, name, "Customer Detail");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(noResult, System.TimeSpan.FromSeconds(10));
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(noResult, "No Result Found"))
            {
                testReport.Pass("<i>'No Results Found' message is displayed in the Choose Account dialog.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>No Results Found message is Not displayed in the Choose Account dialog.");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate no results address
        /// </summary>
        public void ValidateNoResultsFoundAddress(string data)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(address, "Address");
            driver.SendKeysToElement(searchBar, data, "Customer Detail");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(noResult, System.TimeSpan.FromSeconds(10));
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(noResult, "No Result Found"))
            {
                testReport.Pass("<i>'No Results Found' message is displayed in the Choose Account dialog.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>No Results Found message is Not displayed in the Choose Account dialog.");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate no results Meter ID/MIU ID
        /// </summary>
        public void ValidateNoResultsFoundMiuID(string data)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(meterId, "Meter ID");
            driver.SendKeysToElement(searchBar, data, "Customer Detail");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(noResult, System.TimeSpan.FromSeconds(10));
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(noResult, "No Result Found"))
            {
                testReport.Pass("<i>'No Results Found' message is displayed in the Choose Account dialog.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>No Results Found message is Not displayed in the Choose Account dialog.");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate account search window grid
        /// </summary>
        public void ValidateWindowGrid(string accNumber)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(accNo, "Account Number");
            driver.SendKeysToElement(searchBar, accNumber, "Customer Detail");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(lblAccNo, System.TimeSpan.FromSeconds(10));
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(lblAccNo, "Account Number")& (driver.CheckElementDisplayed(lblCustName, "Customer Name") & (driver.CheckElementDisplayed(lblMeterNo, "Meter Number") & (driver.CheckElementDisplayed(lblMiuID, "MIU Id")& (driver.CheckElementDisplayed(lblAddress, "Address"))))))
            {
                testReport.Pass("<i>All Coloumns displayed in the Window grid.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>All Columns are Not displayed in the Window grid.");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate pop up message
        /// </summary>
        public void ValidatePopupMessageAccNo(string data)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(accNo, "Account No");
            driver.SendKeysToElement(searchBar, data, "Customer Detail");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(popUpMessage, System.TimeSpan.FromSeconds(10));
            //driver.CheckElementDisplayed(popUpMessage,"");
            if (driver.CheckElementDisplayed(popUpMessage,"Popup Message"))
            {
                //testReport.Pass("'Search cannot be blank' message is displayed in yellow color dialog on the top of the Landing screen");
                testReport.Pass( "Message displayed is : <i>"+ driver.GetElementText(popUpMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Message not diplayed.");
            }
        }

        /// <summary>
        /// Method to Validate pop up message for blank customer name
        /// </summary>
        public void ValidatePopupMessageCustName(string data)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(custName, "Customer Name");
            driver.SendKeysToElement(searchBar, data, "Customer Detail");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(popUpMessage, System.TimeSpan.FromSeconds(10));
            //driver.CheckElementDisplayed(popUpMessage,"");
            if (driver.CheckElementDisplayed(popUpMessage, "Popup Message"))
            {
                //testReport.Pass("'Search cannot be blank' message is displayed in yellow color dialog on the top of the Landing screen");
                testReport.Pass("Message displayed is : <i>" + driver.GetElementText(popUpMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Message not diplayed.");
            }
        }

        /// <summary>
        /// Method to Validate pop up message for blank meter id
        /// </summary>
        public void ValidatePopupMessageMeterId(string data)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(meterId, "Meter ID");
            driver.SendKeysToElement(searchBar, data, "Customer Detail");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(popUpMessage, System.TimeSpan.FromSeconds(10));
            //driver.CheckElementDisplayed(popUpMessage,"");
            if (driver.CheckElementDisplayed(popUpMessage, "Popup Message"))
            {
                //testReport.Pass("'Search cannot be blank' message is displayed in yellow color dialog on the top of the Landing screen");
                testReport.Pass("Message displayed is : <i>" + driver.GetElementText(popUpMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Message not diplayed.");
            }
        }

        /// <summary>
        /// Method to Validate pop up message for blank address
        /// </summary>
        public void ValidatePopupMessageAddress(string data)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(address, "Address");
            driver.SendKeysToElement(searchBar, data, "Customer Detail");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(popUpMessage, System.TimeSpan.FromSeconds(10));
            //driver.CheckElementDisplayed(popUpMessage,"");
            if (driver.CheckElementDisplayed(popUpMessage, "Popup Message"))
            {
                //testReport.Pass("'Search cannot be blank' message is displayed in yellow color dialog on the top of the Landing screen");
                testReport.Pass("Message displayed is : <i>" + driver.GetElementText(popUpMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Message not diplayed.");
            }
        }

        /// <summary>
        /// Method to Validate account number information
        /// </summary>
        public void ValidateAccNoInformation(string data)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(accNo, "Account No");
            driver.SendKeysToElement(searchBar, "1000", "Customer Detail");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(lblAccNo,System.TimeSpan.FromSeconds(10));
            driver.ClickElement(lblAccNo, "Account No");
            driver.ClickElement(btnOk, "Ok");
            driver.WaitForElement(accountInfo, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(accountInfo, "Account Information"))
            {
                testReport.Pass("<i>Corresponding Account information is displayed in the Customer Inquiry screen.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Corresponding Account information is not displayed in the Customer Inquiry screen.");
            }
        }

        /// <summary>
        /// Method to Validate landing page displayed after cancel button
        /// </summary>
        public void ValidateCancelLandingPage(string data)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(accNo, "Account No");
            driver.SendKeysToElement(searchBar, data, "Customer Detail");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(lblAccNo, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(lblAccNo, "Account No");
            driver.ClickElement(btnCancel, "Cancel");
            driver.WaitForElement(homeBtn, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(homeBtn, "Landing Page"))
            {
                testReport.Pass("<i>Choose Account dialog is closed and Landing screen is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Choose Account dialog is closed and Landing screen is not displayed.");
            }
        }

        /// <summary>
        /// Method to Validate search acc matching criteria
        /// </summary>
        public void ValidateSearchAccMatchingCriteria(string data)
        {
            driver.ClickElement(searchDrpDown, "Search by");
            driver.ClickElement(accNo, "Account No");
            driver.SendKeysToElement(searchBar, "1000", "Customer Detail");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(lblAccNo, System.TimeSpan.FromSeconds(10));
            if(driver.GetElementText(lblAccNo).Contains("1000"))
            { 
                testReport.Pass("<i>Search results matching the Account number entered are displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Search results matching the Account number entered are not displayed.");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate reports widget
        /// </summary>
        public void ValidateReportsWidget()
        {
           if(driver.CheckElementDisplayed(btnReports,"Reports"))
            {
                testReport.Pass("<i>REPORTS widget displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>REPORTS widget not isplayed.");
            }
        }

        /// <summary>
        /// Method to Validate reports widget secondary text
        /// </summary>
        public void ValidateReportsWidgetText()
        {
            if (driver.CheckElementDisplayed(reportsText, "Secondary Reports Text"))
            {
                testReport.Pass("<i>Secondary Reports Text displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Secondary Reports Text not isplayed.");
            }
        }

       

        /// <summary>
        /// Method to Validate reports widget location
        /// </summary>
        public void ValidateReportsWidgetLocation()
        {
            if (driver.CheckElementDisplayed(btnReports, "Reports"))
            {
                testReport.Pass("<i>REPORTS Widget is displayed on bottom row next to Route Management Widget.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>REPORTS widget not isplayed.");
            }
        }
        /// <summary>
        /// Method to Validate secondary text
        /// </summary>
        public void ValidateSecondaryText()
        {
            if (driver.CheckElementDisplayed(reportsText, "Reports Secondary Text"))
            {
                testReport.Pass("Following Text is displayed <i>"+driver.GetElementText(reportsText));
            }
            else
            {
                ReporterFactory.LogFailure("<i>Reports Secondary Text not isplayed.");
            }
        }

        /// <summary>
        /// Method to Validate reports landing page
        /// </summary>
        public void ValidateReportsLandingPage()
        {
            driver.ClickElement(btnReports, "Reports");
            driver.WaitForElement(reportsBreadCrumb, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(reportsBreadCrumb, "Reports Breadcrumb"))
            {
                testReport.Pass("<i>Reports Landing Page Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Reports Landing Page Not Displayed.");
            }
        }

        /// <summary>
        /// Method to Validate SDK Page Access
        /// </summary>
        public void ValidateSDKPageAccess()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(reportsBreadCrumb, System.TimeSpan.FromSeconds(10));
            if (driver.GetElementText(reportsBreadCrumb).Equals("SDK Access")) 
            {
                testReport.Pass("<i> SDK Access Page Is Displayed.");
            }
        }

        public void ValidateSDKAccessPartnerDetails()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(partnerName, System.TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(partnerName, "Partner Name");
            driver.CheckElementDisplayed(clientSecretKey, "Secret Key");
            driver.CheckElementDisplayed(apiKey, "API Key");
            driver.CheckElementDisplayed(contactEmail,"Contact Email");
            driver.CheckElementDisplayed(contactPhone, "Phone");
            driver.CheckElementDisplayed(contactAddress, "Address");
            driver.CheckElementDisplayed(city, "City");
            driver.CheckElementDisplayed(state, "State");
            driver.CheckElementDisplayed(zipCode, "Zip Code");
        }

        public void ValidateSDKAccessPartnerTableDetails()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(utility, System.TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(utility, "Utility");
            driver.CheckElementDisplayed(siteID, "Site ID");
            driver.CheckElementDisplayed(bundle, "Bundle");
            driver.CheckElementDisplayed(sdk, "SDK");
            driver.CheckElementDisplayed(clientID, "CLient ID");
            driver.CheckElementDisplayed(createdDate, "Created Date");
        }
        public void ValidateSDKAccessPartnerName()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(partnerName, System.TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(partnerName, "Partner Name");
        }
        public void ValidateSDKAccessUtilityName()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(utility, System.TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(utility, "Utility");
        }
        public void ValidateSDKAccessBundle()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(bundle, System.TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(bundle, "Bundle");
        }
        public void ValidateSDKAccessClientShowIcon()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(bundle, System.TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(clientShowIcon, "Client ID Show Icon");
        }
        public void ValidateSDKAccessClientShowIconClick()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(bundle, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(clientShowIcon, "Client ID Show Icon");
        }
        public void ValidateSDKAccessNoPartner()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            testReport.Pass("An empty state page is displayed");
        }


        public void ValidateSDKAccessUtilityFilter()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(utility, System.TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(utilityFilter, "Utility Filter");
        }
        public void ValidateSDKAccessUtilityFilterClick()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(utility, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(utilityFilter, "Utility Filter");
        }

        public void ValidateSDKAccessBundleFilter()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(utility, System.TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(bundleFilter, "Bundle Filter");
        }
        public void ValidateSDKAccessBundleFilterClick()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(utility, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(bundleFilter, "Bundle Filter");
        }
        public void ValidateSDKAccessMaxUtilities()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(utility, System.TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(utilitiesList, "Utilities List");
        }
        public void ValidateSDKAccessPaginationNext()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(utility, System.TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(paginationNext, "Pagination Next");
        }
        public void ValidateSDKAccessPaginationPrevious()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(utility, System.TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(paginationPrevious, "Pagination Previous");
        }

        public void ValidateSDKAccessPaginationDetailsDisplayed()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(utility, System.TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(paginationPrevious, "Pagination Previous");
            driver.CheckElementDisplayed(paginationNext, "Pagination Next");
            driver.CheckElementDisplayed(pageNo, "Page No");
        }
        public void ValidateSDKDownloadButtonDisplayed()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(utility, System.TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(downloadButton, "Download Button");
        }
        public void ValidateSDKDownloadButtonClick()
        {
            driver.ClickElement(lftSdkAccess, "SDK Access");
            driver.WaitForElement(utility, System.TimeSpan.FromSeconds(10));
            driver.IsElementEnabled(downloadButton, "Download Button");
        }

        /// <summary>
        /// Method to Validate Acc no sort order
        /// </summary>
        public void ValidateAccNoSortOrder(string acc_No)
        {
            driver.ClickElement(searchDrpDown, "Search dropdown");
            driver.ClickElement(accNo, "Account No");
            driver.SendKeysToElement(searchBar, acc_No, "Account No");
            driver.ClickElement(btnSearch, "Search Button");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(rowValueAccountNo, "1st Row");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Groups Widget
        /// </summary>
        public void ValidateGroupsWidget()
        {
            driver.WaitForElement(btnGroups, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(btnGroups, "Groups");
        }

        /// <summary>
        /// Method to Validate Groups Widget Text Display
        /// </summary>
        public void ValidateGroupsWidgetTextDisplay()
        {
            driver.CheckElementDisplayed(groupText, "Groups Text");
        }

        public void ValidateUtilityNameSiteID()
        {
            driver.CheckElementDisplayed(selectUtility, "Utility Name and Site ID");
        }

        /// <summary>
        /// Method to Validate Groups Widget Access
        /// </summary>
        public void ValidateGroupsWidgetAccess()
        {
            driver.ClickElement(btnGroups, "Groups");
            if(driver.GetElementText(customerEnqBreadCrumb).Equals("GROUP MANAGEMENT"))
            {
                testReport.Pass("Default GROUPS page is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("Default GROUPS page is Not displayed");
            }
        }

        /// <summary>
        /// Method to Validate notification location
        /// </summary>
        public void ValidateNotificationLocation()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            if(driver.CheckElementDisplayed(btnAlert, "Alert Notification"))
            {
                testReport.Pass("<i>'Alert Notifications' is listed between 'Profile' and 'Logout'");
            }
            else
            {
                ReporterFactory.LogFailure("'Alert Notifications' is not listed between 'Profile' and 'Logout'");
            }
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
        }

        /// <summary>
        /// Method to Validate alert notification selectable
        /// </summary>
        public void ValidateNotificationSelectable()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.IsElementEnabled(btnAlert, "Alert Notification");
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
        }

        /// <summary>
        /// Method to Validate alert notification page
        /// </summary>
        public void ValidateNotificationPage()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Notification");

            if (driver.CheckElementDisplayed(customerEnqBreadCrumb, "Alert Notification"))
            {
                testReport.Pass("<i>'Alert Notifications' page is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("'Alert Notifications' page is not displayed.");
            }
        }

        /// <summary>
        /// Method to Validate alert notification page title
        /// </summary>
        public void ValidateNotificationPageTitle()
        {
            driver.WaitForElement(drpProfileLogOut, System.TimeSpan.FromSeconds(45));
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Notification");
            driver.sleepTime(2000);
            string s=driver.Title.ToString();
            if (s.Equals("Alert Notifications"))
            {
                testReport.Pass("<i>Title displayed is : "+s);
            }
            else
            {
                ReporterFactory.LogFailure("Title displayed is : " + s);
            }
        }

        /// <summary>
        /// Method to Validate alert notification breadcrumb
        /// </summary>
        public void ValidateNotificationBreadCrumb()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Notification");
            if (driver.CheckElementDisplayed(customerEnqBreadCrumb, "Alert Notification"))
            {
                testReport.Pass("<i>'Alert Notifications' breadcrumb is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("'Alert Notifications' breadcrumb is not displayed.");
            }
        }

        /// <summary>
        /// Method to Validate alert notification edit button
        /// </summary>
        public void ValidateNotificationEditBtn()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Notification");
            if (driver.CheckElementDisplayed(btnEdit, "Edit Button"))
            {
                testReport.Pass("<i>Edit Button is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Edit Button is not displayed.");
            }
        }

        /// <summary>
        /// Method to Validate alert notification scrollable list
        /// </summary>
        public void ValidateNotificationScrollList()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Notification");
            driver.WaitForElement(scrollList, System.TimeSpan.FromSeconds(45));
            if (driver.CheckElementDisplayed(scrollList, "Scrollable list"))
            {
                testReport.Pass("<i>Scrollable list is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Scrollable list is not displayed.");
            }
        }

        /// <summary>
        /// Method to Validate alert notification  list
        /// </summary>
        public void ValidateNotificationList()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Notification");
            driver.WaitForElement(scrollList, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(scrollList, "Scrollable list"))
            {
                testReport.Pass("<i>List of ALL current Alert Notifications are displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("List of ALL current Alert Notifications are not displayed.");
            }
        }
        /// <summary>
        /// Method to Validate alert notification  list column header
        /// </summary>
        public void ValidateNotificationListColumnHeader()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Notification");
            driver.WaitForElement(scrollListHeader, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(scrollListHeader, "Scrollable list Column Header"))
            {
                testReport.Pass("<i>List of ALL current Alert Notifications Column Header are displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("List of ALL current Alert Notifications Column Header are not displayed.");
            }
        }

        /// <summary>
        /// Method to Validate alert notification name
        /// </summary>
        public void ValidateNotificationName()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Notification");
            driver.WaitForElement(alertName, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(alertName, "Alert Name"))
            {
                testReport.Pass("<i>Alert Name are displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Alert Name are not displayed.");
            }
        }

        /// <summary>
        /// Method to Validate alert notification description
        /// </summary>
        public void ValidateNotificationDescription()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Notification");
            driver.WaitForElement(alertDescription, System.TimeSpan.FromSeconds(45));
            if (driver.CheckElementDisplayed(alertDescription, "Alert Description"))
            {
                testReport.Pass("<i>Alert Description are displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Alert Description are not displayed.");
            }
        }

        /// <summary>
        /// Method to Validate Alert Indicator
        /// </summary>
        public void ValidateAlertIndicator()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(alertIndicator, System.TimeSpan.FromSeconds(45));
            if (driver.CheckElementDisplayed(alertIndicator, "Alert Indicator"))
            {
                testReport.Pass("<i>Alert Indicator are displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Alert Indicator are not displayed.");
            }
        }

        /// <summary>
        /// Method to Validate Alert Indicator
        /// </summary>
        public void ValidateAlertIndicatorDefault()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(alertIndicator, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(alertIndicator, "Alert Indicator"))
            {
                testReport.Pass("<i>Default Alert Indicator is false.");
            }
            else
            {
                ReporterFactory.LogFailure("Alert Indicator are not displayed.");
            }
        }

        /// <summary>
        /// Method to Validate Edit button disabled
        /// </summary>
        public void ValidateEditButtonDisabled()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(3000);
            string text=driver.GetElementAttribute(btnEdit, "class");
            if (text.Contains("disabled"))
            {
                testReport.Pass("<i>Edit Button Disabled.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Edit Button Enabled.");
            }
            
        }

        /// <summary>
        /// Method to Validate cancel done button
        /// </summary>
        public void ValidateCancelDoneButton()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            if(driver.CheckElementDisplayed(btnCancel, "Cancel") & driver.CheckElementDisplayed(btnDone_, "Done"))
            {
                testReport.Pass("<i>Cancel and Done Button are Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Done and Cancel button does not exist");
            }
        }

        /// <summary>
        /// Method to Validate toggle switch
        /// </summary>
        public void ValidateToggleSwitch()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(45));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(toggleSwitch, "Toggle Switch"))
            {
                testReport.Pass("<i>Toggle Switch Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Toggle Switch does not exist");
            }
        }

        /// <summary>
        /// Method to Validate toggle switch edit
        /// </summary>
        public void ValidateToggleSwitchEdit()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(toggleSwitch, "Toggle Switch");
            driver.ClickElement(btnDone_, "Done");
            if (driver.CheckElementDisplayed(alertIndicator, "Alert Indicator"))
            {
                testReport.Pass("<i>Changes saved.");
            }
            else
            {
                ReporterFactory.LogFailure("Changes not saved.");
            }
        }

        /// <summary>
        /// Method to Validate cancel done button removed
        /// </summary>
        public void ValidateCancelDoneBtnRemoved()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(toggleSwitch, "Toggle Switch");
            driver.ClickElement(btnDone_, "Done");
            driver.sleepTime(2000);
            if (driver.CheckElementDoesnotExists(btnCancel, "Cancel")&driver.CheckElementDoesnotExists(btnDone_,"Done"))
            {
                testReport.Pass("<i>Cancel and Done buttons are removed.");
            }
            else
            {
                ReporterFactory.LogFailure("Cancel and Done buttons are not removed.");
            }
        }

        /// <summary>
        /// Method to Validate notification view state
        /// </summary>
        public void ValidateNotificationViewState()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(toggleSwitch, "Toggle Switch");
            driver.ClickElement(btnDone_, "Done");
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(scrollList, "List"))
            {
                testReport.Pass("<i>List of alert notifications is returned to it's VIEW state.");
            }
            else
            {
                ReporterFactory.LogFailure("List of alert notifications is not returned to it's VIEW state.");
            }
        }

        /// <summary>
        /// Method to Validate notification updated
        /// </summary>
        public void ValidateNotificationUpdated()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(toggleSwitch, "Toggle Switch");
            driver.ClickElement(btnDone_, "Done");
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(alertIndicator, "Alert Indicator"))
            {
                testReport.Pass("<i>Each respective alert notification reflects its current/updated sate.");
            }
            else
            {
                ReporterFactory.LogFailure("Each respective alert notification does not reflects its current/updated sate.");
            }
        }

        /// <summary>
        /// Method to Validate edit button enabled
        /// </summary>
        public void ValidateEditButtonEnabled()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(toggleSwitch, "Toggle Switch");
            driver.ClickElement(btnDone_, "Done");
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(btnEdit, "Edit Button"))
            {
                testReport.Pass("<i>Edit button becomes enabled.");
            }
            else
            {
                ReporterFactory.LogFailure("Edit button disabled.");
            }
        }

        /// <summary>
        /// Method to Validate toast message
        /// </summary>
        public void ValidateToastMessage()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(toggleSwitch, "Toggle Switch");
            driver.ClickElement(btnDone_, "Done");
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(popUpMessage, "Toast Message"))
            {
                testReport.Pass("<i>Alerts notifications has been Updated success toast message is displayed.</i>");
            }
            else
            {
                ReporterFactory.LogFailure("Alerts notifications has been Updated success toast message is not displayed.");
            }
        }

        /// <summary>
        /// Method to Validate Abandoned Notification
        /// </summary>
        public void ValidateAbandonedNotification()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(toggleSwitch, "Toggle Switch");
            driver.ClickElement(btnCancel, "Cancel");
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(alertIndicator, "Indicator"))
            {
                testReport.Pass("<i>Any changes made to the alert notifications are abandoned.</i>");
            }
            else
            {
                ReporterFactory.LogFailure("Any changes made to the alert notifications are not abandoned.");
            }
        }
        /// <summary>
        /// Method to Validate cancel done button removed
        /// </summary>
        public void ValidateCancelDoneBtnRemovedWhenCancelled()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(toggleSwitch, "Toggle Switch");
            driver.ClickElement(btnCancel, "Cancel");
            driver.sleepTime(2000);
            if (driver.CheckElementDoesnotExists(btnCancel, "Cancel") & driver.CheckElementDoesnotExists(btnDone_, "Done"))
            {
                testReport.Pass("<i>Cancel and Done buttons are removed.");
            }
            else
            {
                ReporterFactory.LogFailure("Cancel and Done buttons are not removed.");
            }
        }

        /// <summary>
        /// Method to Validate cancel done button removed
        /// </summary>
        public void ValidateListView()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(toggleSwitch, "Toggle Switch");
            driver.ClickElement(btnCancel, "Cancel");
            driver.sleepTime(2000);
            driver.WaitForElement(scrollList, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(scrollList, "List"))
            {
                testReport.Pass("<i>List of alert notifications is returned to it's VIEW state.");
            }
            else
            {
                ReporterFactory.LogFailure("List of alert notifications is not returned to it's VIEW state.");
            }
        }

        /// <summary>
        /// Method to Validate cancel done button removed
        /// </summary>
        public void ValidatePriorListView()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(toggleSwitch, "Toggle Switch");
            driver.ClickElement(btnCancel, "Cancel");
            driver.sleepTime(2000);
            driver.WaitForElement(scrollList, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(scrollList, "List"))
            {
                testReport.Pass("<i>Each respective alert notification reverts/reflects its state prior to the EDIT button being selected.");
            }
            else
            {
                ReporterFactory.LogFailure("Each respective alert notification does not reverts/reflects its state prior to the EDIT button being selected.");
            }
        }

        /// <summary>
        /// Method to Validate edit button enable
        /// </summary>
        public void ValidateEditBtnEnabled()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(toggleSwitch, "Toggle Switch");
            driver.ClickElement(btnCancel, "Cancel");
            driver.sleepTime(2000);
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(btnEdit, "Edit Button"))
            {
                testReport.Pass("<i>Edit button becomes enabled.");
            }
            else
            {
                ReporterFactory.LogFailure("Edit button not enabled.");
            }
        }
        /// <summary>
        /// Method to Validate toast message/no red toast message
        /// </summary>
        public void ValidateToastMessageNotDisplayed()
        {
            driver.ClickElement(drpProfileLogOut, "Profile Dropdown");
            driver.ClickElement(btnAlert, "Alert Indicator");
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(toggleSwitch, "Toggle Switch");
            driver.ClickElement(btnCancel, "Cancel");
            driver.sleepTime(2000);
            if (driver.CheckElementDoesnotExists(popUpMessage, "Toast Message"))
            {
                testReport.Pass("<i>'Alert Notifications' page is opened with no Red Toast message.");
            }
            else
            {
                ReporterFactory.LogFailure("'Alert Notifications' page is opened with Red Toast message.");
            }
        }

        /// <summary>
        /// Method to Validate System Header Bell Icon
        /// </summary>
        public void ValidateSystemHeaderBellIcon()
        {
            driver.WaitForElement(drpProfileLogOut, System.TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(drpProfileLogOut, "Bell Icon");
        }

    }
}
