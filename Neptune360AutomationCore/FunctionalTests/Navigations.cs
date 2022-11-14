using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Neptune360UIAutomation
{
    public class Navigations : TestBaseTemplate
    {
        /// <summary>
        /// Test Method to Navigation from Dashboard to Landing Page
        /// </summary>
        [Category("Navigations")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7955_Navigation_from_Dashboard_to_Landing_Page()
        {
            testCaseId = "TC-7955";
            qTestUniqueId = "20348503";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateDashboardToHomepage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Navigation from Customer Inquiry to Landing Page
        /// </summary>
        [Category("Navigations")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7956_Navigation_from_Customer_Inquiry_to_Landing_Page()
        {
            testCaseId = "TC-7956";
            qTestUniqueId = "20348543";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateCustomerInquiryToHomepage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Navigation from Import to Landing Page
        /// </summary>
        [Category("Navigations")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7957_Navigation_from_Import_to_Landing_Page()
        {
            testCaseId = "TC-7957";
            qTestUniqueId = "20348562";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateImportToHomepage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Navigation from Export to Landing Page
        /// </summary>
        [Category("Navigations")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7958_Navigation_from_Export_to_Landing_Page()
        {
            testCaseId = "TC-7958";
            qTestUniqueId = "20348563";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateImportToHomepage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Navigation from Utility Management to Landing Page
        /// </summary>
        [Category("Navigations")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7959_Navigation_from_Utility_Management_to_Landing_Page()
        {
            testCaseId = "TC-7959";
            qTestUniqueId = "20348566";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateExportToHomepage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Navigation from User Management to Landing Page
        /// </summary>
        [Category("Navigations")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7960_Navigation_from_User_Management_to_Landing_Page()
        {
            testCaseId = "TC-7960";
            qTestUniqueId = "20348599";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateUserManagementToHomepage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Navigation from Roles and Permissions to Landing Page
        /// </summary>
        [Category("Navigations")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7961_Navigation_from_Roles_and_Permissions_to_Landing_Page()
        {
            testCaseId = "TC-7961";
            qTestUniqueId = "20348618";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateRolesNPermissionToHomepage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Navigation from Notification to Landing Page
        /// </summary>
        [Category("Navigations")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7962_Navigation_from_Notification_to_Landing_Page()
        {
            testCaseId = "TC-7962";
            qTestUniqueId = "20348619";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateNotificationsToHomepage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Navigation from Notification screen to Utility Management screen
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7388_Navigation_from_Notification_screen_to_Utility_Management_screen()
        {
            testCaseId = "TC-7388";
            qTestUniqueId = "19731387";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateNotificationsToUtility();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Navigation from Notification screen to User Management screen
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7389_Navigation_from_Notification_screen_to_User_Management_screen()
        {
            testCaseId = "TC-7389";
            qTestUniqueId = "19731434";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateNotificationsToUserManagement();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Navigation from Notification screen to Roles&Permission screen
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7390_Navigation_from_Notification_screen_to_RolesNPermission_screen()
        {
            testCaseId = "TC-7390";
            qTestUniqueId = "19731463";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateNotificationsToRoleManagement();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Navigation from Notification screen to Import screen
        /// </summary>
        [Category("Navigations")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7391_Navigation_from_Notification_screen_to_Import_screen()
        {
            testCaseId = "TC-7391";
            qTestUniqueId = "19731476";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateNotificationsToImportPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Navigation from Notification screen to Export screen
        /// </summary>
        [Category("Navigations")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7392_Navigation_from_Notification_screen_to_Export_screen()
        {
            testCaseId = "TC-7392";
            qTestUniqueId = "19731482";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateNotificationsToExportPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Navigation from Notification screen to Customer Inquiry screen
        /// </summary>
        [Category("Navigations")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7393_Navigation_from_Notification_screen_to_Customer_Inquiry_screen()
        {
            testCaseId = "TC-7393";
            qTestUniqueId = "19731494";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateNotificationsToCustEnq();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Navigation from Notification screen to Dashboard screen
        /// </summary>
        [Category("Navigations")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7394_Navigation_from_Notification_screen_to_Dashboard_screen()
        {
            testCaseId = "TC-7394";
            qTestUniqueId = "19731496";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateNotificationsToDashboard();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Billing Services - Verbiage - Import Files
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11908_Left_Navigation_Billing_Services_Verbiage_Import_Files()
        {
            testCaseId = "TC-11908";
            qTestUniqueId = "25164179";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateImportFilesMenu();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Import Files - Breadcrumb - Verbiage
        /// </summary>
        [Category("Navigations")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11909_Import_Files_Breadcrumb_Verbiage()
        {
            testCaseId = "TC-11909";
            qTestUniqueId = "25164180";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateBreadcrumbImportFileMenu();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Import Files - Page Title - Verbiage
        /// </summary>
        [Category("Navigations")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11910_Import_Files_Page_Title_Verbiage()
        {
            testCaseId = "TC-11910";
            qTestUniqueId = "25164181";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateVerbiageOfPageTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Billing Services - Verbiage - Export Files
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11911_Left_Navigation_Billing_Services_Verbiage_Export_Files()
        {
            testCaseId = "TC-11911";
            qTestUniqueId = "25164182";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateVerbiageExportFiles();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export Files - Breadcrumb - Verbiage
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11912_Export_Files_Breadcrumb_Verbiage()
        {
            testCaseId = "TC-11912";
            qTestUniqueId = "25164183";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateExportFilesBreadcrumb();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export Files - Page Title - Verbiage
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11913_Export_Files_Page_Title_Verbiage()
        {
            testCaseId = "TC-11913";
            qTestUniqueId = "25164184";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateExportFilesTitleVerbiage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Billing Services - Verbiage - Export History
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11914_Left_Navigation_Billing_Services_Verbiage_Export_History()
        {
            testCaseId = "TC-11914";
            qTestUniqueId = "25164185";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateExportHistoryVerbiage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History - Breadcrumb - Verbiage
        /// </summary>
        [Category("Navigations")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11915_Export_History_Breadcrumb_Verbiage()
        {
            testCaseId = "TC-11915";
            qTestUniqueId = "25164186";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateExportHistoryBreadcrumb();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History - Page Title - Verbiage
        /// </summary>
        [Category("Navigations")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11916_Export_History_PageTitle_Verbiage()
        {
            testCaseId = "TC-11916";
            qTestUniqueId = "25164187";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateExportHistoryPageTitleVerbiage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Platform Management - Verbiage - Role Management
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11917_Left_Navigation_Platform_Management_Verbiage_Role_Management()
        {
            testCaseId = "TC-11917";
            qTestUniqueId = "25164188";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateRoleManagementVerbiage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Role Management - Breadcrumb - Verbiage
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11918_Role_Management_Breadcrumb_Verbiage()
        {
            testCaseId = "TC-11918";
            qTestUniqueId = "25164189";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateRoleManagementBreadcrumbVerbiage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Role Management - Page Title - Verbiage
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11919_Role_Management_PageTitle_Verbiage()
        {
            testCaseId = "TC-11919";
            qTestUniqueId = "25164190";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateRoleManagementPageTitleVerbiage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Left Navigation - Platform Management - Verbiage - Email Notification
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11920_Left_Navigation_Platform_Management_Verbiage_Email_Notification()
        {
            testCaseId = "TC-11920";
            qTestUniqueId = "25164191";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateEmailNotificationVerbiage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Email Notification Editor - Breadcrumb - Verbiage
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11921_Email_Notification_Editor_Breadcrumb_Verbiage()
        {
            testCaseId = "TC-11921";
            qTestUniqueId = "25164192";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateEmailNotificationBreadcrumbVerbiage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Email Notification Editor - Page Title - Verbiage
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11922_Email_Notification_Editor_PageTitle_Verbiage()
        {
            testCaseId = "TC-11922";
            qTestUniqueId = "25164193";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateEmailNotificationPageTitleVerbiage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Top Navigation - Homepage Link - Display
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7954_Top_Navigation_Homepage_Link_Display()
        {
            testCaseId = "TC-7954";
            qTestUniqueId = "20348181";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateNavigationsPage(url, userName, password);
                navigations.ValidateHomePageLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Utility Management - Alert Configuration - Page Title
        /// </summary>
        //[Category("Navigations")]
        //[Category("SmokeTests")]
        //[Category("RegressionTests1")]
        [Category("AlertNotifications_Rework")]
        [Test]
        public void TC_13245_Left_Navigation_Utility_Management_Alert_Configuration_Page_Title()
        {
            testCaseId = "TC-13245";
            qTestUniqueId = "28873559";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateAlertConfigPageTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Utility Management - Alert Configuration - Bread Crumb
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13246_Left_Navigation_Utility_Management_Alert_Configuration_Bread_Crumb()
        {
            testCaseId = "TC-13246";
            qTestUniqueId = "28873560";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateAlertConfigBreadcrumb();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Utility Management - Alert Configuration - Done Button
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13247_Left_Navigation_Utility_Management_Alert_Configuration_Done_Button()
        {
            testCaseId = "TC-13247";
            qTestUniqueId = "28873561";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateAlertConfigDoneBtn();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Utility Management - Alert Configuration - Edit Button
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13248_Left_Navigation_Utility_Management_Alert_Configuration_Edit_Button()
        {
            testCaseId = "TC-13248";
            qTestUniqueId = "28873562";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateAlertConfigEditBtn();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Utility Management - Alert Configuration - Options Section
        /// </summary>
        [Category("Navigations_AlertConfiguration")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13250_Left_Navigation_Utility_Management_Alert_Configuration_Options_Section()
        {
            testCaseId = "TC-13250";
            qTestUniqueId = "28873563";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateOptionSection();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Utility Management - Alert Configuration - Events List - Unique Name 
        /// </summary>
        [Category("Navigations_AlertConfiguration")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13251_Left_Navigation_Utility_Management_Alert_Configuration_Events_List_Unique_Name()
        {
            testCaseId = "TC-13251";
            qTestUniqueId = "28873565";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateEventOptions();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Left Navigation - Utility Management - Alert Configuration - Events List - Unique Description 
        /// </summary>
        [Category("Navigations_AlertConfiguration")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13252_Left_Navigation_Utility_Management_Alert_Configuration_Events_List_Unique_Description()
        {
            testCaseId = "TC-13252";
            qTestUniqueId = "28873566";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateUniqueDescription();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Utility Management - Alert Configuration - Events List - Unique Description 
        /// </summary>
        [Category("Navigations_AlertConfiguration")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13253_Left_Navigation_Utility_Management_Alert_Configuration_Events_List_Unique_Description()
        {
            testCaseId = "TC-13253";
            qTestUniqueId = "28873567";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateUniqueDescription();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Utility Management - Alert Configuration - Events List - Only One Event 
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13254_Left_Navigation_Utility_Management_Alert_Configuration_Events_List_Only_One_Event()
        {
            testCaseId = "TC-13254";
            qTestUniqueId = "28873568";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateOnlyOneEvent();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Utility Management - Alert Configuration - Events List - Selected Within Arrow 
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13255_Left_Navigation_Utility_Management_Alert_Configuration_Events_List_Only_Selected_Within_Arrow()
        {
            testCaseId = "TC-13255";
            qTestUniqueId = "28873569";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateOnlyOneEvent();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Utility Management - Alert Configuration - Events List - Default Select
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13256_Left_Navigation_Utility_Management_Alert_Configuration_Events_List_Default_Select()
        {
            testCaseId = "TC-13256";
            qTestUniqueId = "28873570";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateOnlyOneEvent();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Utility Management - Alert Configuration - Events List - Event Selected - Options 
        /// </summary>
        [Category("Navigations_AlertConfiguration")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13257_Left_Navigation_Utility_Management_Alert_Configuration_Events_List_Event_Selected_Options()
        {
            testCaseId = "TC-13257";
            qTestUniqueId = "28873571";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateOptionSection();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Utility Management - Alert Configuration - Events List - Event Selected - Options - Alert Own Group Settings 
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13258_Left_Navigation_Utility_Management_Alert_Configuration_Events_List_Event_Selected_Options_Alert_Own_Group_Settings()
        {
            testCaseId = "TC-13258";
            qTestUniqueId = "28873572";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateOwnGroupSetting();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Utility Management - Alert Configuration - Events List - Event Selected - Options - Blank 
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13259_Left_Navigation_Utility_Management_Alert_Configuration_Events_List_Event_Selected_Options_Blank()
        {
            testCaseId = "TC-13259";
            qTestUniqueId = "28873573";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateOwnGroupSetting();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Utility Management - Alert Configuration - Events List - Done Button Selected 
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests_AlertNotifications")]
        [Category("AlertNotifications_Rework")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13260_Left_Navigation_Utility_Management_Alert_Configuration_Events_List_Done_Button_Selected()
        {
            testCaseId = "TC-13260";
            qTestUniqueId = "28873574";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateDoneButtonSeleted();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Reports - Display 
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13972_Left_Navigation_Reports_Display()
        {
            testCaseId = "TC-13972";
            qTestUniqueId = "30262064";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavReportsLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Reports - Operational Dashboard Report - Blank Screen - Display
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13973_Left_Navigation_Reports_Operational_Dashboard_Report_Blank_Screen_Display()
        {
            testCaseId = "TC-13973";
            qTestUniqueId = "30262117";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavReportsScreenDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_API Deployment_Display
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15324_Left_Navigation_API_Deployment_Display()
        {
            testCaseId = "TC-15324";
            qTestUniqueId = "33834538";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavAPIDeployment();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_API Deployment_Display Order
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15325_Left_Navigation_API_Deployment_Display_Order()
        {
            testCaseId = "TC-15325";
            qTestUniqueId = "33834539";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavAPIDeployment();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_API Deployment_No Associated Icon
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15326_Left_Navigation_API_Deployment_No_Associated_Icon()
        {
            testCaseId = "TC-15326";
            qTestUniqueId = "33834540";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavAPIDeployment();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_API Deployment_Access
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15327_Left_Navigation_API_Deployment_Access()
        {
            testCaseId = "TC-15327";
            qTestUniqueId = "33834541";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavAPIDeploymentAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left navigation_Partner Management_Display
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15328_Left_Navigation_Partner_Management_Display()
        {
            testCaseId = "TC-15328";
            qTestUniqueId = "33834683";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavPartnerManagementDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left navigation_Partner Management_Access
        /// </summary>
        [Category("Navigations")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15329_Left_Navigation_Partner_Management_Access()
        {
            testCaseId = "TC-15329";
            qTestUniqueId = "33834696";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavPartnerManagementAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left navigation_Partner Management_No Associated Icon
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15330_Left_Navigation_Partner_Management_No_Associated_Icon()
        {
            testCaseId = "TC-15330";
            qTestUniqueId = "33834701";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavPartnerManagementDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left navigation_Partner Management_Display Order
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15331_Left_Navigation_Partner_Management_Display_Order()
        {
            testCaseId = "TC-15331";
            qTestUniqueId = "33834702";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavPartnerManagementDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_File Mapper_Display
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15403_Left_Navigation_File_Mapper_Display()
        {
            testCaseId = "TC-15403";
            qTestUniqueId = "34021475";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavFileMapperDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_File Mapper_Display Order
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15404_Left_Navigation_File_Mapper_Display_Order()
        {
            testCaseId = "TC-15404";
            qTestUniqueId = "34021476";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavFileMapperDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_File Mapper_No Associated Icon
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15405_Left_Navigation_File_Mapper_No_Associated_Icon()
        {
            testCaseId = "TC-15405";
            qTestUniqueId = "34021477";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavFileMapperDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_File Mapper_Access
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15406_Left_Navigation_File_Mapper_Access()
        {
            testCaseId = "TC-15406";
            qTestUniqueId = "34021478";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavFileMapperAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_Usage Plans_Display
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15480_Left_Navigation_Usage_Plans_Display()
        {
            testCaseId = "TC-15480";
            qTestUniqueId = "34064867";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavUsagePlansDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_Usage Plans_Display Order
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15481_Left_Navigation_Usage_Plans_Display_Order()
        {
            testCaseId = "TC-15481";
            qTestUniqueId = "34064868";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavUsagePlansDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_Usage Plans_No Associated Icon
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15482_Left_Navigation_Usage_Plans_No_Associated_Icon()
        {
            testCaseId = "TC-15482";
            qTestUniqueId = "34064869";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavUsagePlansDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_Usage Plans Access
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15483_Left_Navigation_Usage_Plans_Access()
        {
            testCaseId = "TC-15483";
            qTestUniqueId = "34064870";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateLeftNavUsageAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_SDK Access_Display
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15677_Left_Navigation_SDK_Access_Display()
        {
            testCaseId = "TC-15677";
            qTestUniqueId = "34501970";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateSDKAccessDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_SDK Access_Display Order
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15678_Left_Navigation_SDK_Access_Display_Order()
        {
            testCaseId = "TC-15678";
            qTestUniqueId = "34501972";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateSDKAccessDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_SDK Access_Associated Icon
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15679_Left_Navigation_SDK_Access_Associated_Icon()
        {
            testCaseId = "TC-15679";
            qTestUniqueId = "34501980";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateSDKAccessDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_SDK Access_Option_Access
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15680_Left_Navigation_SDK_Access_Option_Access()
        {
            testCaseId = "TC-15680";
            qTestUniqueId = "34501986";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateSDKOptionAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_GROUPS_Menu Item_Display
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_18162_Left_Navigation_GROUPS_Menu_Item_Display()
        {
            testCaseId = "TC-18162";
            qTestUniqueId = "39083698";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateGroupsMenu();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_GROUPS_Display Order
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_18163_Left_Navigation_GROUPS_Display_Order()
        {
            testCaseId = "TC-18163";
            qTestUniqueId = "39083699";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateGroupsMenu();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_GROUPS_ Access
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_18164_Left_Navigation_GROUPS_Access()
        {
            testCaseId = "TC-18164";
            qTestUniqueId = "39083700";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateGroupsAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_GROUPS Icon Display
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_18165_Left_Navigation_Groups_Icon_Display()
        {
            testCaseId = "TC-18165";
            qTestUniqueId = "39083700";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateGroupsAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_GROUPS Icon Left Navigation_NSP DB Conversion_Menu Item_Display
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_18206_Left_Navigation_NSP_DB_Conversion_Menu_Item_Display()
        {
            testCaseId = "TC-18206";
            qTestUniqueId = "39336437";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateNSPDBConversion();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_GROUPS Icon Left Navigation_NSP DB Conversion Access
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_18207_Left_Navigation_NSP_DB_Conversion_Access()
        {
            testCaseId = "TC-18207";
            qTestUniqueId = "39336452";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateNSPDBConversionAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_GROUPS Icon Left Navigation_NSP DB Conversion Access Title Display
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_18208_Left_Navigation_NSP_DB_Conversion_Access_Title_Display()
        {
            testCaseId = "TC-18208";
            qTestUniqueId = "39336455";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateNSPDBConversionAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_GROUPS Icon Left Navigation_NSP DB Conversion Icon Display
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_18209_Left_Navigation_NSP_DB_Conversion_Icon_Display()
        {
            testCaseId = "TC-18209";
            qTestUniqueId = "39336457";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateNSPDBConversion();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Neptune 360 - Left Navigation - Utility Management - Alert Configuration - Settings
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_18300_Neptune_360_Left_Navigation_Utility_Management_Alert_Configuration_Settings()
        {
            testCaseId = "TC-18300";
            qTestUniqueId = "39462002";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateSettings();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_GROUPS_Display
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_18498_Left_Navigation_GROUPS_Display()
        {
            testCaseId = "TC-18498";
            qTestUniqueId = "39836908";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateGroupsMenu();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_GROUPS_Display
        /// </summary>
        [Category("Navigations")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_18499_Left_Navigation_GROUPS_Display()
        {
            testCaseId = "TC-18499";
            qTestUniqueId = "39836908";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                navigations.ValidateGroupsMenuExpand();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message + ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

    }
}