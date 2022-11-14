using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public class LandingPage : TestBaseTemplate
    {
        /// <summary>
        /// Test Method to Landing Page_Dashboard_Grey Icon_Display
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8566_Landing_Page_Dashboard_Grey_Icon_Display()
        {
            testCaseId = "TC-8566";
            qTestUniqueId = "22847313";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateDashboardGreyIconDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Landing Page_Customer Inquiry_Grey Icon_Display
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8567_Landing_Page_Customer_Inquiry_Grey_Icon_Display()
        {
            testCaseId = "TC-8567";
            qTestUniqueId = "22847316";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateCustomerInquiryGreyIconDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Landing Page Billing Services Grey Icon Display
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8568_Landing_Page_Billing_Services_Grey_Icon_Display()
        {
            testCaseId = "TC-8568";
            qTestUniqueId = "22847322";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateBillingServicesGreyIconDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Landing Page_Notifications_Grey Icon_Display
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8569_Landing_Page_Notifications_Grey_Icon_Display()
        {
            testCaseId = "TC-8569";
            qTestUniqueId = "22847323";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNotificationGreyIconDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Landing Page_User Management_Grey Icon_Display
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8570_Landing_Page_User_Management_Grey_Icon_Display()
        {
            testCaseId = "TC-8570";
            qTestUniqueId = "22847328";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateUserManagementGreyIconDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Landing Page_Utility Management_Grey Icon_Display
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8571_Landing_Page_Utility_Management_Grey_Icon_Display()
        {
            testCaseId = "TC-8571";
            qTestUniqueId = "22847331";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateUtilityManagementGreyIconDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Landing Page_Left Navigation_Neptune 360 Logo_Display
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8572_Landing_Page_Left_Navigation_Neptune360_Logo_Display()
        {
            testCaseId = "TC-8572";
            qTestUniqueId = "22849201";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNeptuneLogoDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Landing Page_Left Navigation_Collapsed_Neptune Logo_Display
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8573_Landing_Page_Left_Navigation_Collapsed_Neptune_Logo_Display()
        {
            testCaseId = "TC-8573";
            qTestUniqueId = "22849208";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                //landing.ValidateNLogoDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Landing Page_Left Navigation_Expand_Neptune Logo_Display
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8574_Landing_Page_Left_Navigation_Expand_Neptune_Logo_Display()
        {
            testCaseId = "TC-8574";
            qTestUniqueId = "22849213";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateExpandNeptuneLogoDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to System Template - Left Side Bar - Display
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3619_System_Template_Left_Side_Bar_Display()
        {
            testCaseId = "TC-3619";
            qTestUniqueId = "19238352";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSideBarDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to System Template - Left Side Bar - Menu View Style
        /// </summary>
        [Category("LandingPage")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3620_System_Template_Left_Side_Bar_Menu_View_Style()
        {
            testCaseId = "TC-3620";
            qTestUniqueId = "19238353";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSideBarMenuStyle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to System Template - Left Side Bar - Menu Options
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3621_System_Template_Left_Side_Bar_Menu_Options()
        {
            testCaseId = "TC-3621";
            qTestUniqueId = "19238354";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSideBarMenuOptions();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Submenu Removed - Left Navigation
        /// </summary>
        [Category("Dashboard")]
        [Test]
        public void TC_13732_Dashboard_Submenu_NetworkHealthAndEndpointSummary_Removed_Left_Navigation()
        {
            testCaseId = "TC-13732";
            qTestUniqueId = "29813358";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNetworkHealthAndEndpointSummaryDisplayedInSideBarMenu();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to System Template - Left Side Bar - Upon selection of an icon (Interim)
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3622_System_Template_Left_Side_Bar_Upon_selection_of_an_icon_Interim()
        {
            testCaseId = "TC-3622";
            qTestUniqueId = "19238355";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateCustomerEnquiryNavigatedPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Global Account Management: UI Login and Remember my login - Login Screen
        /// </summary>
        [Category("LandingPage-obsolete")]
        [Test]
        public void TC_3709_Global_Account_Management_UI_Login_and_Remember_my_login_Login_Screen()
        {
            testCaseId = "TC-3709";
            qTestUniqueId = "19238472";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                driver.Navigate().GoToUrl(url);
                landing.ValidateUILogin();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Global Account Management: UI Login and Remember my login - Login
        /// </summary>
        [Category("LandingPage-obsolete")]
        [Test]
        public void TC_3710_Global_Account_Managemen_UI_Login_and_Remember_my_login_Login()
        {
            testCaseId = "TC-3710";
            qTestUniqueId = "19238473";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Global Account Management: UI Login and Remember my login - Username Required
        /// </summary>
        [Category("LandingPage-obsolete")]
        [Test]
        public void TC_3711_Global_Account_Management_UI_Login_and_Remember_my_login_Username_Required()
        {
            testCaseId = "TC-3711";
            qTestUniqueId = "19238475";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                password = testData["Password"];
                driver.Navigate().GoToUrl(url);
                landing.ValidateUserNameRequired(password);
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Global Account Management: UI Login and Remember my login - Password Required
        /// </summary>
        [Category("LandingPage-obsolete")]
        [Test]
        public void TC_3712_Global_Account_Management_UI_Login_and_Remember_my_login_Password_Required()
        {
            testCaseId = "TC-3712";
            qTestUniqueId = "19238476";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                driver.Navigate().GoToUrl(url);
                landing.ValidatePasswordRequired(userName);
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Global Account Management: UI Login and Remember my login - Ability to select "Show"
        /// </summary>
        [Category("LandingPage-obsolete")]
        [Test]
        public void TC_3713_Global_Account_Management_UI_Login_and_Remember_my_login_Ability_to_select_Show()
        {
            testCaseId = "TC-3713";
            qTestUniqueId = "19238477";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                driver.Navigate().GoToUrl(url);
                landing.ValidateButton();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Global Account Management: UI Login and Remember my login - Wrong Username/Password
        /// </summary>
        [Category("LandingPage-obsolete")]
        [Test]
        public void TC_3714_Global_Account_Management_UI_Login_and_Remember_my_login_Wrong_Username_Password()
        {
            testCaseId = "TC-3714";
            qTestUniqueId = "19238478";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateInvalidUserNamePwd();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Global Account Management: UI Login and Remember my login - Remember My Username
        /// </summary>
        [Category("LandingPage-obsolete")]
        [Test]
        public void TC_3715_Global_Account_Management_UI_Login_and_Remember_my_login_Remember_My_Username()
        {
            testCaseId = "TC-3715";
            qTestUniqueId = "19238479";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                landing.ValidateRememberMyEmail(url, userName, password);
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Global Account Management: UI Login and Remember my login - Remember Login not selected
        /// </summary>
        [Category("LandingPage-obsolete")]
        [Test]
        public void TC_3716_Global_Account_Management_UI_Login_and_Remember_my_login_Remember_Login_not_selected()
        {
            testCaseId = "TC-3716";
            qTestUniqueId = "19238480";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                landing.ValidateDoNotRememberMyEmail(url, userName, password);
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to System Template - Header - Display
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3623_System_Template_Header_Display()
        {
            testCaseId = "TC-3623";
            qTestUniqueId = "19238356";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateHeader();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to System Template - Header - Home icon
        /// </summary>
        [Category("LandingPage")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3624_System_Template_Header_Home_icon()
        {
            testCaseId = "TC-3624";
            qTestUniqueId = "19238357";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateHomeButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to System Template - Header - Person icon
        /// </summary>
        [Category("LandingPage")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3626_System_Template_Header_Person_icon()
        {
            testCaseId = "TC-3626";
            qTestUniqueId = "19238359";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidatePersonIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Search Accounts_Search by Account Number_Exact Match
        /// </summary>
        [Category("LandingPage")]
        [Category("BatchExecution")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_8864_Landing_Page_Search_Accounts_Search_by_Account_Number_Exact_Match()
        {
            testCaseId = "TC-8864";
            qTestUniqueId = "24485224";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateAccSearch(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Search Accounts_Search by Customer Name_Exact Match
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_8865_Landing_Page_Search_Accounts_Search_by_Customer_Name_Exact_Match()
        {
            testCaseId = "TC-8865";
            qTestUniqueId = "24485265";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNameSearch(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Search Accounts_Search by Meter ID/MIU ID_Exact Match
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_8866_Landing_Page_Search_Accounts_Search_by_MeterID_MIU_ID_Exact_Match()
        {
            testCaseId = "TC-8866";
            qTestUniqueId = "24485299";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateMeterSearch(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Search Accounts_Search by Address_Exact Match
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_8867_Landing_Page_Search_Accounts_Search_by_Address_Exact_Match()
        {
            testCaseId = "TC-8867";
            qTestUniqueId = "24485300";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                address = testData["Address"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateAddressSearch(address);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Search Accounts_Search by Account Number_Partial Search
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8877_Landing_Page_Search_Accounts_Search_by_Account_Number_Partial_Search()
        {
            testCaseId = "TC-8877";
            qTestUniqueId = "24494653";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToHome(url, userName, password);
                landing.ValidatePatrialAccSearch(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Search Accounts_Search by Customer Name_Partial Search
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8878_Landing_Page_Search_Accounts_Search_by_Customer_Name_Partial_Search()
        {
            testCaseId = "TC-8878";
            qTestUniqueId = "24494654";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateToHome(url, userName, password);
                landing.ValidatePartialNameSearch(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Landing Page_Search Accounts_Search by Meter ID/MIU ID_Partial Search
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_8879_Landing_Page_Search_Accounts_Search_by_Meter_ID_MIU_ID_Partial_Search()
        {
            testCaseId = "TC-8879";
            qTestUniqueId = "24494655";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToHome(url, userName, password);
                landing.ValidatePartialMeterSearch(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Search Accounts_Search by Address_Partial Search
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8880_Landing_Page_Search_Accounts_Search_by_Address_Partial_Search()
        {
            testCaseId = "TC-8880";
            qTestUniqueId = "24494656";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                address = testData["Address"];
                home.NavigateToHome(url, userName, password);
                landing.ValidatePartialAddressSearch(address);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Search Accounts_Search by Account Number_No Results
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_8870_Landing_Page_Search_Accounts_Search_by_Account_Number_No_Results()
        {
            testCaseId = "TC-8870";
            qTestUniqueId = "24493486";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNoResultsFound(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Landing Page_Search Accounts_Search by Customer Name_Invalid Search
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8871_Landing_Page_Search_Accounts_Search_by_Customer_Name_Invalid_Search()
        {
            testCaseId = "TC-8871";
            qTestUniqueId = "24493487";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNoResultsFoundName(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Landing Page_Search Accounts_Search by Customer Name_No Results
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_8874_Landing_Page_Search_Accounts_Search_by_Customer_Name_No_Results()
        {
            testCaseId = "TC-8874";
            qTestUniqueId = "24493692";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNoResultsFoundName(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Landing Page_Search Accounts_Search by Meter ID/MIU ID_No Results
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_8875_Landing_Page_Search_Accounts_Search_by_Meter_ID_MIU_ID_No_Results()
        {
            testCaseId = "TC-8875";
            qTestUniqueId = "24493743";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToHome(url, userName, password);
                //landing.ValidateNoResultsFoundMiuID(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Landing Page_Search Accounts_Search by Address_No Results
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_8876_Landing_Page_Search_Accounts_Search_by_Address_No_Results()
        {
            testCaseId = "TC-8876";
            qTestUniqueId = "24493744";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                address = testData["Address"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNoResultsFoundAddress(address);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Search Accounts_Choose Account Window_Grid
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_8868_Landing_Page_Search_Accounts_Choose_Account_Window_Grid()
        {
            testCaseId = "TC-8868";
            qTestUniqueId = "24492951";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateWindowGrid(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Search Accounts_Search by Account Number_Search Field Blank
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8881_Landing_Page_Search_Accounts_Search_by_Account_Number_Search_Field_Blank()
        {
            testCaseId = "TC-8881";
            qTestUniqueId = "24494674";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToHome(url, userName, password);
                landing.ValidatePopupMessageAccNo(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Landing Page_Search Accounts_Search by Customer Name_Search Field Blank
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8885_Landing_Page_Search_Accounts_Search_by_Customer_Name_Search_Field_Blank()
        {
            testCaseId = "TC-8885";
            qTestUniqueId = "24494690";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateToHome(url, userName, password);
                landing.ValidatePopupMessageCustName(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Search Accounts_Search by Meter ID/MIU ID_Search Field Blank
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8886_Landing_Page_Search_Accounts_Search_by_Meter_ID_MIU_ID_Search_Field_Blank()
        {
            testCaseId = "TC-8886";
            qTestUniqueId = "24494691";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToHome(url, userName, password);
                landing.ValidatePopupMessageMeterId(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Search Accounts_Search by Address_Search Field Blank
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_8887_Landing_Page_Search_Accounts_Search_by_Address_Search_Field_Blank()
        {
            testCaseId = "TC-8887";
            qTestUniqueId = "24494692";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                address = testData["Address"];
                home.NavigateToHome(url, userName, password);
                landing.ValidatePopupMessageAddress(address);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Search Accounts_Choose Account Window_Select an Account
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8888_Landing_Page_Search_Accounts_Choose_Account_Window_Select_an_Account()
        {
            testCaseId = "TC-8888";
            qTestUniqueId = "24494720";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = "Acct:1";
                home.NavigateToHome(url, userName, password);
                landing.ValidateAccNoInformation(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Landing Page_Search Accounts_Choose Account Window_Cancel
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8889_Landing_Page_Search_Accounts_Choose_Account_Window_Cancel()
        {
            testCaseId = "TC-8889";
            qTestUniqueId = "24494726";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateCancelLandingPage(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Search Accounts_Choose Account Window_Search Results
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8891_Landing_Page_Search_Accounts_Choose_Account_Window_Search_Results()
        {
            testCaseId = "TC-8891";
            qTestUniqueId = "24495144";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = "Acct:1";
                home.NavigateToHome(url, userName, password);
                landing.ValidateSearchAccMatchingCriteria(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Location
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13166_Landing_Page_Profile_Menu_Alert_Notifications_Location()
        {
            testCaseId = "TC-13166";
            qTestUniqueId = "28840419";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNotificationLocation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selectable
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13167_Landing_Page_Profile_Menu_Alert_Notifications_Selectable()
        {
            testCaseId = "TC-13167";
            qTestUniqueId = "28840420";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNotificationSelectable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13168_Landing_Page_Profile_Menu_Alert_Notifications_Selected()
        {
            testCaseId = "TC-13168";
            qTestUniqueId = "28840421";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNotificationPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13356_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Page_Title()
        {
            testCaseId = "TC-13356";
            qTestUniqueId = "28909386";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNotificationPageTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Breadcrumb Bar
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13357_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Breadcrumb_Bar()
        {
            testCaseId = "TC-13357";
            qTestUniqueId = "28909387";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNotificationBreadCrumb();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Edit Button
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13358_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Edit_Button()
        {
            testCaseId = "TC-13358";
            qTestUniqueId = "28909388";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNotificationEditBtn();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Edit Button
        /// </summary>
        [Category("LandingPage_AlertNotifications")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13359_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Scrollable_List()
        {
            testCaseId = "TC-13359";
            qTestUniqueId = "28909389";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNotificationScrollList();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - List - All Current Alert Notifications
        /// </summary>
        [Category("LandingPage_AlertNotifications")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13360_Landing_Page_Profile_Menu_Alert_Notifications_Selected_List_All_Current_Alert_Notifications()
        {
            testCaseId = "TC-13360";
            qTestUniqueId = "28909390";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNotificationList();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - List - Header
        /// </summary>
        [Category("LandingPage_AlertNotifications")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13361_Landing_Page_Profile_Menu_Alert_Notifications_Selected_List_Header()
        {
            testCaseId = "TC-13361";
            qTestUniqueId = "28909391";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNotificationListColumnHeader();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - List - Each Alert - Name
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13362_Landing_Page_Profile_Menu_Alert_Notifications_Selected_List_Each_Alert_Name()
        {
            testCaseId = "TC-13362";
            qTestUniqueId = "28909392";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNotificationName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - List - Each Alert - Description
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13363_Landing_Page_Profile_Menu_Alert_Notifications_Selected_List_Each_Alert_Description()
        {
            testCaseId = "TC-13363";
            qTestUniqueId = "28909393";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNotificationDescription();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - List - Each Alert - Indicator
        /// </summary>
        [Category("LandingPage_AlertConfiguration")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13364_Landing_Page_Profile_Menu_Alert_Notifications_Selected_List_Each_Alert_Indicator()
        {
            testCaseId = "TC-13364";
            qTestUniqueId = "28909394";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateAlertIndicator();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - List - Each Alert - Indicator - Default
        /// </summary>
        [Category("LandingPage_AlertConfiguration")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13365_Landing_Page_Profile_Menu_Alert_Notifications_Selected_List_Each_Alert_Indicator_Default()
        {
            testCaseId = "TC-13365";
            qTestUniqueId = "28909395";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateAlertIndicatorDefault();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Edit Button - Selected - Disabled
        /// </summary>
        [Category("LandingPage_AlertNotifications")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13366_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Edit_Button_Selected_Disabled()
        {
            testCaseId = "TC-13366";
            qTestUniqueId = "28909445";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateEditButtonDisabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Edit Button - Selected - Cancel/Save Buttons
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13367_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Edit_Button_Selected_Cancel_Save_Buttons()
        {
            testCaseId = "TC-13367";
            qTestUniqueId = "28909446";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateCancelDoneButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Edit Button - Selected - Toggle Option
        /// </summary>
        [Category("LandingPage_AlertConfiguration")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13368_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Edit_Button_Selected_Toggle_Option()
        {
            testCaseId = "TC-13368";
            qTestUniqueId = "28909447";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateToggleSwitch();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Done Button - Changes Persisted by System
        /// </summary>
        [Category("LandingPage_AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13369_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Done_Button_Changes_Persisted_by_System()
        {
            testCaseId = "TC-13369";
            qTestUniqueId = "28909448";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateToggleSwitchEdit();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Done Button - Cancel/Done Buttons
        /// </summary>
        [Category("LandingPage_AlertConfiguration")]
        [Category("BatchExecution")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13370_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Done_Button_Cancel_Done_Buttons()
        {
            testCaseId = "TC-13370";
            qTestUniqueId = "28909449";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateCancelDoneBtnRemoved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Done Button - List View
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13371_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Done_Button_List_View()
        {
            testCaseId = "TC-13371";
            qTestUniqueId = "28909450";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNotificationViewState();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Done Button - List View - Current/Updated State
        /// </summary>
        [Category("LandingPage_AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13372_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Done_Button_List_View_Current_Updated_State()
        {
            testCaseId = "TC-13372";
            qTestUniqueId = "28909451";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateNotificationUpdated();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Done Button - Edit Button
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13373_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Done_Button_Edit_Button()
        {
            testCaseId = "TC-13373";
            qTestUniqueId = "28909452";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateEditButtonEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Done Button - Success Toast
        /// </summary>
        [Category("LandingPage_AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13374_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Done_Button_Success_Toast()
        {
            testCaseId = "TC-13374";
            qTestUniqueId = "28909453";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateToastMessage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Cancel Button - Selected - Changed Abandoned
        /// </summary>
        [Category("LandingPage_AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13375_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Cancel_Button_Selected_Changed_Abandoned()
        {
            testCaseId = "TC-13375";
            qTestUniqueId = "28909454";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateAbandonedNotification();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Cancel Button - Selected - Cancel/Done Buttons
        /// </summary>
        [Category("LandingPage_AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13376_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Cancel_Button_Selected_Cancel_Done_Buttons()
        {
            testCaseId = "TC-13376";
            qTestUniqueId = "28909455";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateCancelDoneBtnRemovedWhenCancelled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Cancel Button - List View
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13377_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Cancel_Button_List_View()
        {
            testCaseId = "TC-13377";
            qTestUniqueId = "28909456";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateListView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Cancel Button - List View - Revert Prior State
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13378_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Cancel_Button_List_View_Revert_Prior_State()
        {
            testCaseId = "TC-13378";
            qTestUniqueId = "28909457";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidatePriorListView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - Cancel Button - Edit Button Enabled
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13379_Landing_Page_Profile_Menu_Alert_Notifications_Selected_Cancel_Button_Edit_Button_Enabled()
        {
            testCaseId = "TC-13379";
            qTestUniqueId = "28909458";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateEditBtnEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Selected - No Red Toast Displayed
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13432_Landing_Page_Profile_Menu_Alert_Notifications_Selected_No_Red_Toast_Displayed()
        {
            testCaseId = "TC-13432";
            qTestUniqueId = "29026830";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateToastMessageNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to System Template - Header - Bell icon
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3625_System_Template_Header_Bell_icon()
        {
            testCaseId = "TC-3625";
            qTestUniqueId = "19238358";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSystemHeaderBellIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to System Template - Header - Upon selection of an icon (Interim)
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3627_System_Template_Header_Upon_selection_of_an_icon_Interim()
        {
            testCaseId = "TC-3627";
            qTestUniqueId = "19238360";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateHomeButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to System Template - Header - Question mark icon
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3629_System_Template_Header_Question_mark_icon()
        {
            testCaseId = "TC-3629";
            qTestUniqueId = "19238362";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateQuestionIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Define UI without Interaction/Links - Module Links
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3954_Landing_Page_Define_UI_without_Interaction_Links_Module_Links()
        {
            testCaseId = "TC-3954";
            qTestUniqueId = "19323362";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateInteractionLinks();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Logout - App - Successful
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8064_Logout_App_Successful()
        {
            testCaseId = "TC-8064";
            qTestUniqueId = "20679803";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Reports Widget_Icon Display
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_14850_Landing_Page_Reports_Widget_Icon_Display()
        {
            testCaseId = "TC-14850";
            qTestUniqueId = "32413220";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateReportsWidget();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Reports Widget_Location
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_14851_Landing_Page_Reports_Widget_Location()
        {
            testCaseId = "TC-14851";
            qTestUniqueId = "32413221";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateReportsWidget();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Reports Widget_Secondary Text_Display
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_14852_Landing_Page_Reports_Widget_Secondary_Text_Display()
        {
            testCaseId = "TC-14852";
            qTestUniqueId = "32413222";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateReportsWidgetText();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Reports Widget_Access
        /// </summary>
        [Category("LandingPage")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_14853_Landing_Page_Reports_Widget_Access()
        {
            testCaseId = "TC-14853";
            qTestUniqueId = "32413223";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateReportsLandingPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page_Neptune 360 Partner_SDK Access_Display
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15700_Landing_Page_Neptune_360_Partner_SDK_Access_Display()
        {
            testCaseId = "TC-15700";
            qTestUniqueId = "34515654";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKPageAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Breadcrumbs_Display
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_16786_SDK_Access_Breadcrumbs_Display()
        {
            testCaseId = "TC-16786";
            qTestUniqueId = "35810739";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKPageAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Partner Details_Display
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_16787_SDK_Access_Partner_Details_Display()
        {
            testCaseId = "TC-16787";
            qTestUniqueId = "35810740";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessPartnerDetails();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Partner Table Details_Display
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16788_SDK_Access_Partner_Table_Details_Display()
        {
            testCaseId = "TC-16788";
            qTestUniqueId = "35810741";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessPartnerTableDetails();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Partner Table Details_Utility Column_Filter Option_Display
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16789_SDK_Access_Partner_Table_Details_Utility_Column_Filter_Option_Display()
        {
            testCaseId = "TC-16789";
            qTestUniqueId = "35810742";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessUtilityFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Partner Table Details_Bundle Column_Filter Option_Display
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16790_SDK_Access_Partner_Table_Details_Bundle_Column_Filter_Option_Display()
        {
            testCaseId = "TC-16790";
            qTestUniqueId = "35810743";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessBundleFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Partner Table Details_Utility Column Filter
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16791_SDK_Access_Partner_Table_Details_Utility_Column_Filter()
        {
            testCaseId = "TC-16791";
            qTestUniqueId = "35810744";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessUtilityFilterClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Partner Table Details_Bundle Column Filter
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16792_SDK_Access_Partner_Table_Details_Bundle_Column_Filter()
        {
            testCaseId = "TC-16792";
            qTestUniqueId = "35810746";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessBundleFilterClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Table_Max 10 utilities_Display
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16793_SDK_Access_Table_Max_10_utilities_Display()
        {
            testCaseId = "TC-16793";
            qTestUniqueId = "35810747";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessMaxUtilities();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Table_More than 10 Utilities_Pagination_Next
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16794_SDK_Access_Table_More_than_10_Utilities_Pagination_Next()
        {
            testCaseId = "TC-16794";
            qTestUniqueId = "35810748";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessPaginationNext();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Table_More than 10 Utilities_Pagination_Previous
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16795_SDK_Access_Table_More_than_10_Utilities_Pagination_Previous()
        {
            testCaseId = "TC-16795";
            qTestUniqueId = "35810749";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessPaginationPrevious();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Table_More than 10 Utilities_Pagination_Details_Display
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16796_SDK_Access_Table_More_than_10_Utilities_Pagination_Details_Display()
        {
            testCaseId = "TC-16796";
            qTestUniqueId = "35810750";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessPaginationDetailsDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Table_SDK Column_Download Button_Display
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16797_SDK_Access_Table_SDK_Column_Download_Button_Display()
        {
            testCaseId = "TC-16797";
            qTestUniqueId = "35813075";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKDownloadButtonDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Table_SDK Column_Download Button_Click
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16798_SDK_Access_Table_SDK_Column_Download_Button_Click()
        {
            testCaseId = "TC-16798";
            qTestUniqueId = "35813076";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKDownloadButtonClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Neptune 360 Partner_Top Navigation_Partner Name_Display
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16801_Neptune_360_Partner_Top_Navigation_Partner_Name_Display()
        {
            testCaseId = "TC-16801";
            qTestUniqueId = "35813080";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessPartnerName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Neptune System Admin_Top Navigation_Utility Name_Display
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16802_Neptune_System_Admin_Top_Navigation_Utility_Name_Display()
        {
            testCaseId = "TC-16802";
            qTestUniqueId = "35813081";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessUtilityName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Utility Admin_Top Navigation_Utility Name_Display
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16803_Utility_Admin_Top_Navigation_Utility_Name_Display()
        {
            testCaseId = "TC-16803";
            qTestUniqueId = "35813084";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessUtilityName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Granted Bundles_Display_Neptune 360 Partner
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16804_SDK_Access_Granted_Bundles_Display_Neptune_360_Partner()
        {
            testCaseId = "TC-16804";
            qTestUniqueId = "35813086";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessBundle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to SDK Access_Granted Bundles_Display_Neptune System_Admin
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16805_SDK_Access_Granted_Bundles_Display_Neptune_System_Admin()
        {
            testCaseId = "TC-16805";
            qTestUniqueId = "35813088";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessBundle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Granted Bundles_Display_Utility_Admin
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16806_SDK_Access_Granted_Bundles_Display_Utility_Admin()
        {
            testCaseId = "TC-16806";
            qTestUniqueId = "35813089";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessBundle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Partner Table Details_Client ID_Show Icon_Display
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16914_SDK_Access_Partner_Table_Details_Client_ID_Show_Icon_Display()
        {
            testCaseId = "TC-16914";
            qTestUniqueId = "36027310";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessClientShowIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Partner Table Details_Client ID_Show Icon_Click
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16915_SDK_Access_Partner_Table_Details_Client_ID_Show_Icon_Click()
        {
            testCaseId = "TC-16915";
            qTestUniqueId = "36027711";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessClientShowIconClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Partner Details_API Key_Value Display
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16916_SDK_Access_Partner_Details_API_Key_Value_Display()
        {
            testCaseId = "TC-16916";
            qTestUniqueId = "36028959";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessClientShowIconClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to SDK Access_Partner Details_API Key_Value Display
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16964_SDK_Access_Partner_Details_API_Key_Value_Display()
        {
            testCaseId = "TC-16964";
            qTestUniqueId = "36175027";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessNoPartner();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to SDK Access_Utility Admin Role_Site with  Partner Management Set_Screen Display
        /// </summary>
        [Category("SDKAccess")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16965_SDK_Access_Utility_Admin_Role_Site_with_Partner_Management_Set_Screen_Display()
        {
            testCaseId = "TC-16965";
            qTestUniqueId = "36175035";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateSDKAccessPartnerName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Landing Page_Search Accounts_Choose Account Window_Sort Order
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8890_Landing_Page_Search_Accounts_Choose_Account_Window_Sort_Order()
        {
            testCaseId = "TC-8890";
            qTestUniqueId = "24495127";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateAccNoSortOrder(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing Page - Profile Menu - Alert Notifications - Displayed 
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13165_Landing_Page_Profile_Menu_Alert_Notifications_Displayed()
        {
            testCaseId = "TC-13165";
            qTestUniqueId = "28840418";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToHome(url, userName, password);
                rolesPermissons.ValidateAlertNotification();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Landing page_GROUPS Widget_Display
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_18166_Landing_page_GROUPS_Widget_Display()
        {
            testCaseId = "TC-18166";
            qTestUniqueId = "39083703";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateGroupsWidget();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing page_GROUPS Widget_Access
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_18167_Landing_page_GROUPS_Widget_Access()
        {
            testCaseId = "TC-18167";
            qTestUniqueId = "39083704";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateGroupsWidgetAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing page_GROUPS Widget_Icon Display
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_18168_Landing_page_GROUPS_Widget_Icon_Display()
        {
            testCaseId = "TC-18168";
            qTestUniqueId = "39083705";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateGroupsWidget();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing page_GROUPS Widget_Text Display
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_18169_Landing_page_GROUPS_Widget_Text_Display()
        {
            testCaseId = "TC-18169";
            qTestUniqueId = "39083706";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateGroupsWidgetTextDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Landing page_GROUPS Widget_Text Utility - Select a Utility  - All Utility Users
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3968_Utility_Select_a_Utility_All_Utility_Users()
        {
            testCaseId = "TC-3968";
            qTestUniqueId = "19323423";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateUtilityNameSiteID();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Utility - Select a Utility - All Neptune Users
        /// </summary>
        [Category("LandingPage")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_3969_Utility_Select_a_Utility_All_Neptune_Users()
        {
            testCaseId = "TC-3969";
            qTestUniqueId = "19323424";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateUtilityNameSiteID();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

    }
}
