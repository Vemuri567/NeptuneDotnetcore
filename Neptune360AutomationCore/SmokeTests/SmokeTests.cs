using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Neptune360UIAutomation
{
    public class SmokeTests : TestBaseTemplate
    {
        /// <summary>
        /// Test Method to Create New User_Role_Neptune System Administrator
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_12314_Create_New_User_Role_Neptune_System_Administrator()
        {
            testCaseId = "TC-12314";
            qTestUniqueId = "26820499";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateNewUserRole(firstName, lastName, email, roleOption);
                userManagement.ValidateCreateUserConfirmationPopup();
                userManagement.ValidateSearchUserWithEmail(email);
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
        /// Test Method to Create New User_Role_Neptune Customer Service Rep
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_12315_Create_New_User_Role_Neptune_Customer_Service_Rep()
        {
            testCaseId = "TC-12315";
            qTestUniqueId = "26820500";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateNewUserRole(firstName, lastName, email, roleOption);
                userManagement.ValidateCreateUserConfirmationPopup();
                userManagement.ValidateSearchUserWithEmail(email);
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
        /// Test Method to Create New User_Role_Neptune Field Service PM
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_12316_Create_New_User_Role_Neptune_Field_Service_PM()
        {
            testCaseId = "TC-12316";
            qTestUniqueId = "26820502";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateNewUserRole(firstName, lastName, email, roleOption);
                userManagement.ValidateCreateUserConfirmationPopup();
                userManagement.ValidateSearchUserWithEmail(email);
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
        /// Test Method to Create New User_Role_Utility Administrator
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_12317_Create_New_User_Role_Utility_Administrator()
        {
            testCaseId = "TC-12317";
            qTestUniqueId = "26820504";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateNewUserRole(firstName, lastName, email, roleOption);
                userManagement.ValidateCreateUserConfirmationPopup();
                userManagement.ValidateSearchUserWithEmail(email);
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
        /// Test Method to Create New User_Role_Utility User
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_12318_Create_New_User_Role_Utility_User()
        {
            testCaseId = "TC-12318";
            qTestUniqueId = "26820506";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateNewUserRole(firstName, lastName, email, roleOption);
                userManagement.ValidateCreateUserConfirmationPopup();
                userManagement.ValidateSearchUserWithEmail(email);
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
        /// Test Method to Create New User_Role_Utility Read Only Access
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_12319_Create_New_User_Role_Utility_Read_Only_Access()
        {
            testCaseId = "TC-12319";
            qTestUniqueId = "26820509";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateNewUserRole(firstName, lastName, email, roleOption);
                userManagement.ValidateCreateUserConfirmationPopup();
                userManagement.ValidateSearchUserWithEmail(email);
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
        /// Test Method to Navigation_Landing Page_To_Dashboard
        /// </summary>
        
        [Test]
        public void TC_12320_Navigation_Landing_Page_To_Dashboard()
        {
            testCaseId = "TC-12320";
            qTestUniqueId = "26822131";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                home.NavigateToHome(url, userName, password);
                home.ValidateLandingPageDashboardScreenDisplay();
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
        /// Test Method to Navigation_Landing Page_To_Customer Inquiry
        /// </summary>
        
        [Test]
        public void TC_12321_Navigation_Landing_Page_To_Customer_Inquiry()
        {
            testCaseId = "TC-12321";
            qTestUniqueId = "26822135";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                home.NavigateToHome(url, userName, password);
                home.ValidateLandingPageCustomerInquiryScreenDisplay();
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
        /// Test Method to Navigation_Landing Page_To_Billing Services
        /// </summary>
        
        [Test]
        public void TC_12322_Navigation_Landing_Page_To_Billing_Services()
        {
            testCaseId = "TC-12322";
            qTestUniqueId = "26822137";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                home.NavigateToHome(url, userName, password);
                home.ValidateLandingPageBillingServicesScreenDisplay();
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
        /// Test Method to Navigation_Landing Page_To_Notifications
        /// </summary>
        
        [Test]
        public void TC_12323_Navigation_Landing_Page_To_Notifications()
        {
            testCaseId = "TC-12323";
            qTestUniqueId = "26822138";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                home.NavigateToHome(url, userName, password);
                home.ValidateLandingPageNotificationsScreenDisplay();
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
        /// Test Method to Navigation_Landing Page_To_User Management
        /// </summary>
        
        [Test]
        public void TC_12324_Navigation_Landing_Page_To_User_Management()
        {
            testCaseId = "TC-12324";
            qTestUniqueId = "26822139";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                home.NavigateToHome(url, userName, password);
                home.ValidateLandingPageUserManagementScreenDisplay();
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
        /// Test Method to Navigation_Landing Page_To_Utility Management
        /// </summary>
        
        [Test]
        public void TC_12325_Navigation_Landing_Page_To_Utility_Management()
        {
            testCaseId = "TC-12325";
            qTestUniqueId = "26822140";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                home.NavigateToHome(url, userName, password);
                home.ValidateLandingPageUtilityManagementScreenDisplay();
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
        /// Test Method to Navigation_Landing Page_To_Route Management
        /// </summary>
        
        [Test]
        public void TC_12326_Navigation_Landing_Page_To_Route_Management()
        {
            testCaseId = "TC-12326";
            qTestUniqueId = "26822141";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                home.NavigateToHome(url, userName, password);
                home.ValidateLandingPageRouteManagementScreenDisplay();
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
        /// Test Method to Login_App_Successful
        /// </summary>
        
        [Category("BatchExecution")]
        [Test]
        public void TC_12173_Login_App_Successful()
        {
            testCaseId = "TC-12173";
            qTestUniqueId = "26006775";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
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

        /// <summary>
        /// Test Method to Logout_App_Successful
        /// </summary>
        
        [Test]
        public void TC_3771_Logout_App_Successful()
        {
            testCaseId = "TC-3771";
            qTestUniqueId = "19238570";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
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

        /// <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Meter ID
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_3867_Customer_Inquiry_Account_Search_Search_By_Meter_ID()
        {
            testCaseId = "TC-3867";
            qTestUniqueId = "19318970";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                string meterId = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSearchAccountByMeterId(meterId);
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
        /// Test Method to Customer Inquiry_Account Search_Search By_Account Number
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_3868_Customer_Inquiry_Account_Search_Search_By_Account_Number()
        {
            testCaseId = "TC-3868";
            qTestUniqueId = "19318971";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                string accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSearchSelectAccountNo(accountNo);
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
        /// Test Method to Customer Inquiry_Account Search_Search By_Customer_Name
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_3869_Customer_Inquiry_Account_Search_Search_By_Customer_Name()
        {
            testCaseId = "TC-3869";
            qTestUniqueId = "19318972";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                string customerName = testData["CustomerName"];
                home.NavigateToLftCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSearchAccountByCustomerName(customerName);
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
        /// Test Method to Customer Inquiry_Account Search_Search By_Address
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_3870_Customer_Inquiry_Account_Search_Search_By_Address()
        {
            testCaseId = "TC-3870";
            qTestUniqueId = "19318973";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                string address = testData["Address"];
                home.NavigateToLftCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSearchAccountByAddress(address);
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
        /// Test Method to Customer Inquiry_Meter Information_Edit_Asset Configuration Dialog_Save
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_8160_Customer_Inquiry_Meter_Information_Edit_Asset_Configuration_Dialog_Save()
        {
            testCaseId = "TC-8160";
            qTestUniqueId = "21681434";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                string accountNo = testData["AccountNumber"];
                customerInquiry.ValidateSearchSelectAccountNo(accountNo);
                customerInquiry.ValidateEditAssertConfig();
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
        /// Test Method to Customer Inquiry_Consumption Chart_Display
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_12331_Customer_Inquiry_Consumption_Chart_Display()
        {
            testCaseId = "TC-12331";
            qTestUniqueId = "26847673";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                string accountNo = testData["AccountNumber"];
                customerInquiry.ValidateSearchSelectAccountNo(accountNo);
                customerInquiry.ValidateViewDashboard();
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
        /// Test Method to Customer Inquiry_Map_Display
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_12332_Customer_Inquiry_Map_Display()
        {
            testCaseId = "TC-12332";
            qTestUniqueId = "26847843";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                string accountNo = testData["AccountNumber"];
                customerInquiry.ValidateSearchSelectAccountNo(accountNo);
                customerInquiry.ValidateViewDashboard();
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
        /// Test Method to Utility_Ability to create a new Utility
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_3571_Utility_Ability_to_create_a_new_Utility()
        {
            testCaseId = "TC-3571";
            qTestUniqueId = "19238184";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                siteID = testData["SiteID"];
                address = testData["Address"];
                city = testData["SiteID"];
                zip = testData["ZipCode"];
                home.NavigateLanPageUtilityManagement(url, userName, password);
                utilityManagement.ValidateCreateNewUtility(customerName,siteID,address,city,zip);
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
        /// Test Method to Create a New User Account for Any Utility and Set Role - Ability to Create New User for Utility and set Role
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_3675_Create_a_New_User_Account_for_Any_Utility_and_Set_Role_Ability_to_Create_New_User_for_Utility_and_set_Role()
        {
            testCaseId = "TC-3675";
            qTestUniqueId = "19238419";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateSingleUtilityCreateUserFields();
                userManagement.CreateSingleUtilityUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateSearchUserWithEmail(email);
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
        /// Test Method to Edit User and Reset Password Button - Send Password Reset
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_3952_Edit_User_and_Reset_Password_Button_Send_Password_Reset()
        {
            testCaseId = "TC-3952";
            qTestUniqueId = "19323292";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateSearchUserAccount(firstName);
                userManagement.ValidatePasswordResetMessage();
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
        /// Test Method to Export Screen_Select_Single Route
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_7967_Export_Screen_Select_Single_Route()
        {
            testCaseId = "TC-7967";
            qTestUniqueId = "20649903";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateSelectSingleRoute();
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
        /// Test Method to Export Screen_Select_Multiple Routes using CTRL key
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_7968_Export_Screen_Select_Multiple_Routes_using_CTRL_key()
        {
            testCaseId = "TC-7968";
            qTestUniqueId = "20649934";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateSelectMultipleRoutesUsingCTRLKey();
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
        /// Test Method to Export Screen_Select All_Routes
        /// </summary>
        
        [Test]
        public void TC_7969_Export_Screen_Select_All_Routes()
        {
            testCaseId = "TC-7969";
            qTestUniqueId = "20649945";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateSelectAllRoutes();
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
        /// Test Method to Export Screen_Select All_Routes
        /// </summary>
        
        [Test]
        public void TC_7970_Export_Screen_Deselect_All_Routes()
        {
            testCaseId = "TC-7970";
            qTestUniqueId = "20649950";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateDeselectAllRoutes();
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
        /// Test Method to Export Screen_Export Route_Successful
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_12335_Export_Screen_Export_Route_Successful()
        {
            testCaseId = "TC-12335";
            qTestUniqueId = "26849942";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportRouteSuccessful();
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
        /// Test Method to Export Screen_Export Options_Display
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_12336_Export_Screen_Export_Options_Display()
        {
            testCaseId = "TC-12336";
            qTestUniqueId = "26850084";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportOptionsDisplay();
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
        /// Test Method to Export_Export Settings_All Options
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_8096_Export_Export_Settings_All_Options()
        {
            testCaseId = "TC-8096";
            qTestUniqueId = "21054712";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportRouteSuccessful();
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
        /// Test Method to Export_Export Settings_Multiple Checked
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_8100_Export_Export_Settings_Multiple_Checked()
        {
            testCaseId = "TC-8100";
            qTestUniqueId = "21054719";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportRouteSuccessful();
                billingServicesExport.ValidateExportSettingsMultipleChecked();
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
        /// Test Method to Set up a collector_Saving Collector Information
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_4002_Set_up_a_collector_Saving_Collector_Information()
        {
            testCaseId = "TC-4002";
            qTestUniqueId = "19323460";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorID = testData["CollectorId"];
                collectorName = testData["CollectorName"];
                hostIP = testData["HostIP"];
                home.NavigateLanPageUtilityManagement(url, userName, password);
                utilityManagement.ValidateSetupCollectorSavingCollectorInformation(collectorID, collectorName, hostIP);
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
        /// Test Method to Billing Services_Import_Successful
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_12333_Billing_Services_Import_Successful()
        {
            testCaseId = "TC-12333";
            qTestUniqueId = "26849039";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateImportSuccessful(importFile);
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
        /// Test Method to Billing Services_Reimport_Successful
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_12334_Billing_Services_Reimport_Successful()
        {
            testCaseId = "TC-12334";
            qTestUniqueId = "26849207";
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateImportSuccessful(importFile);
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
