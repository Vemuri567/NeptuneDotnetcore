using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public class OnlineHelp : TestBaseTemplate
    {

        /// <summary>
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Landing Page
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10341_Online_Help_Access_Question_Mark_Menu_Arrow_Landing_Page()
        {
            testCaseId = "TC-16341";
            qTestUniqueId = "24887516";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.LandingPageQuestionMark();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Dashboard
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10342_Online_Help_Access_Question_Mark_Menu_Arrow_Dashboard()
        {
            testCaseId = "TC-16342";
            qTestUniqueId = "24887606";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkMenuArrowDashboard();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Dashboard Detail Report
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10407_Online_Help_Access_Question_Mark_Menu_Arrow_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10407";
            qTestUniqueId = "24895456";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionDashboardDetailReportArrow();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Dashboard - Top 10 Accounts Detail Report
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10408_Online_Help_Access_Question_Mark_Menu_Arrow_Dashboard_System_Consumption_Top10_Accounts_Detail_Report()
        {
            testCaseId = "TC-10408";
            qTestUniqueId = "24895459";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionDashboardTop10DetailReportArrow();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Customer Inquiry
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10343_Online_Help_Access_Question_Mark_Menu_Arrow_Customer_Inquiry()
        {
            testCaseId = "TC-10343";
            qTestUniqueId = "24887608";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionCustomerInquiryQuestionReportArrow();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Import
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10344_Online_Help_Access_Question_Mark_Menu_Arrow_Import()
        {
            testCaseId = "TC-10343";
            qTestUniqueId = "24887609";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.BillingServicesImportQuestiontArrow();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Export
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10345_Online_Help_Access_Question_Mark_Menu_Arrow_Export()
        {
            testCaseId = "TC-10345";
            qTestUniqueId = "24887728";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.BillingServicesExportFilesQuestiontArrow();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Export History
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10346_Online_Help_Access_Question_Mark_Menu_Arrow_Export_History()
        {
            testCaseId = "TC-10346";
            qTestUniqueId = "24887729";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportHistoryQuestiontArrow();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Device Management
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10347_Online_Help_Access_Question_Mark_Menu_Arrow_Device_Management()
        {
            testCaseId = "TC-10347";
            qTestUniqueId = "24887730";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DeviceManagementQuestiontArrow();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - User Management
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10348_Online_Help_Access_Question_Mark_Menu_Arrow_User_Management()
        {
            testCaseId = "TC-10348";
            qTestUniqueId = "24887731";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.userManagementQuestiontArrow();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Roles Permission
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10404_Online_Help_Access_Question_Mark_Menu_Arrow_Roles_Permission()
        {
            testCaseId = "TC-10404";
            qTestUniqueId = "24895422";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.RolesPermissionsQuestiontArrow();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Notification
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10405_Online_Help_Access_Question_Mark_Menu_Arrow_Notification()
        {
            testCaseId = "TC-10405";
            qTestUniqueId = "24895423";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.NotificationQuestiontArrow();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - User Management
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10406_Online_Help_Access_Question_Mark_Menu_Landing_Page_User_Management()
        {
            testCaseId = "TC-10406";
            qTestUniqueId = "24895424";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.LandingPageUserManagementQuestiontArrow();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Dashboard - Complete Readings Detail Report
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11752_Online_Help_Access_Question_Mark_Menu_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11752";
            qTestUniqueId = "25072231";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CompleteCountQuestiontArrow();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Dashboard - Incomplete Readings Detail Report
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11753_Online_Help_Access_Question_Mark_Menu_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11753";
            qTestUniqueId = "25072232";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IncompleteCountQuestiontArrow();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Dashboard - Continuous Usage Detail Reportt
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11754_Online_Help_Access_Question_Mark_Menu_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-11754";
            qTestUniqueId = "25072256";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.criticalConinousQuestiontArrow();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Dashboard - Intermittent Usage Detail Reportt
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11755_Online_Help_Access_Question_Mark_Menu_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11755";
            qTestUniqueId = "25072257";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IntermittentUsageQuestiontArrow();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Dashboard - Major Reverse Flow Usage Detail Reportt
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11756_Online_Help_Access_Question_Mark_Menu_Dashboard_Major_Reverse_Flow_Usage_Detail_Report()
        {
            testCaseId = "TC-11756";
            qTestUniqueId = "25072263";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.MajorReverseFlowQuestiontArrow();
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
        /// Test Method to Online Help Access - Question Mark Menu Arrow - Dashboard - Minor Reverse Flow Usage Detail Reportt
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11757_Online_Help_Access_Question_Mark_Menu_Dashboard_Minor_Reverse_Flow_Usage_Detail_Report()
        {
            testCaseId = "TC-11757";
            qTestUniqueId = "25072264";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.MinorReverseFlowQuestiontArrow();
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
        /// Test Method to Online Help Access - Help Contents Menu Item - User Management from Landing Page Icon
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10409_Online_Help_Access_Help_Contents_Menu_Item_User_Management_from_Landing_Page_Icon()
        {
            testCaseId = "TC-10409";
            qTestUniqueId = "24895570";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.LandingPageUserManagementQuestiontArrow();
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
        /// Test Method to Online Help Access - Help Contents Menu Item - Dashboard - System Consumption Detail Report
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10410_Online_Help_Access_Help_Contents_Menu_Item_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10410";
            qTestUniqueId = "24895571";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.LandingPageDashboardQuestiontArrow();
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
        /// Test Method to Online Help Access - Help Contents Menu Item - Dashboard - Top 10 Accounts Detail Report
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10411_Online_Help_Access_Help_Contents_Menu_Item_Dashboard_Top_10_Accounts_Detail_Report()
        {
            testCaseId = "TC-10411";
            qTestUniqueId = "24895572";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboardTop10DetailReportQuestiontArrow();
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
        /// Test Method to Online Help Access - Help Contents Menu Item - Dashboard - Complete Readings Detail Report
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11760_Online_Help_Access_Help_Contents_Menu_Item_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11760";
            qTestUniqueId = "25072377";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CompleteCountQuestiontArrow();
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
        /// Test Method to Online Help Access - Help Contents Menu Item - Dashboard - Incomplete Readings Detail Report
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11761_Online_Help_Access_Help_Contents_Menu_Item_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11761";
            qTestUniqueId = "25072378";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IncompleteCountQuestiontArrow();
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
        /// Test Method to Online Help Access - Help Contents Menu Item - Dashboard - Continuous Usage Detail Report
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11762_Online_Help_Access_Help_Contents_Menu_Item_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-11762";
            qTestUniqueId = "25072379";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.criticalConinousQuestiontArrow();
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
        /// Test Method to Online Help Access - Help Contents Menu Item - Dashboard - Major Reverse Flow Usage Detail Report
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11763_Online_Help_Access_Help_Contents_Menu_Item_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11763";
            qTestUniqueId = "25072380";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.MajorReverseFlowQuestiontArrow();
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
        /// Test Method to Online Help Access - Help Contents Menu Item - Dashboard -Intermittent Usage  Usage Detail Report
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11764_Online_Help_Access_Help_Contents_Menu_Item_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11764";
            qTestUniqueId = "25072381";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IntermittentUsageQuestiontArrow();
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
        /// Test Method to Online Help Access - Help Contents Menu Item - Dashboard -Minor Reverse FlowUsage Detail Report
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11765_Online_Help_Access_Help_Contents_Menu_Item_Dashboard_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11765";
            qTestUniqueId = "25072382";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.MinorReverseFlowQuestiontArrow();
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
        /// Test Method to Online Help Access - Help Contents Menu Item - Notification
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10412_Online_Help_Access_Help_Contents_Menu_Item_Notification()
        {
            testCaseId = "TC-10412";
            qTestUniqueId = "24895573";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.NotificationQuestiontArrow();
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
        /// Test Method to Online Help Access - Help Contents Menu Item - Roles and Permissions
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10413_Online_Help_Access_Help_Contents_Menu_Item_Roles_and_Permissions()
        {
            testCaseId = "TC-10413";
            qTestUniqueId = "24895574";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.RolesPermissionsQuestiontArrow();
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
        /// Test Method to Online Help Access - Help Contents Menu Item - Landing Page
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10414_Online_Help_Access_Help_Contents_Menu_Item_Landing_Page()
        {
            testCaseId = "TC-10414";
            qTestUniqueId = "24895575";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.LandingPageQuestionMark();
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
        /// Test Method to Online Help Access - Help Contents Menu Item - Dashboard
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10415_Online_Help_Access_Help_Contents_Menu_Item_Dashboard()
        {
            testCaseId = "TC-10415";
            qTestUniqueId = "24895576";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkMenuArrowDashboard();
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
        /// Test Method to Online Help Access - Help Contents Menu Item - Customer Inquiry
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10416_Online_Help_Access_Help_Contents_Menu_Item_Customer_Inquiry()
        {
            testCaseId = "TC-10416";
            qTestUniqueId = "24895577";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionCustomerInquiryHelpContent();
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
        /// Test Method to Online Help Access - Help Contents Menu Item - Import
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10417_Online_Help_Access_Help_Contents_Menu_Item_Import()
        {
            testCaseId = "TC-10417";
            qTestUniqueId = "24895578";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ImportHelpContentPage();
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
        /// Test Method to Online Help Access - Help Contents Menu Item - Export
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10418_Online_Help_Access_Help_Contents_Menu_Item_Export()
        {
            testCaseId = "TC-10418";
            qTestUniqueId = "24895579";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportFilesHelpContentPage();
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
        /// Test Method to Online Help Access - Help Contents Menu Export_History
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10419_Online_Help_Access_Help_Contents_Menu_Export_History()
        {
            testCaseId = "TC-10419";
            qTestUniqueId = "24895580";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportHistoryHelpContentPage();
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
        /// Test Method to Online Help Access - Help Contents Menu Device Management
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10420_Online_Help_Access_Help_Contents_Menu_Device_Management()
        {
            testCaseId = "TC-10420";
            qTestUniqueId = "24895581";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportDeviceManagementHelpContent();
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
        /// Test Method to Online Help Access - Help Contents Menu User Management
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10421_Online_Help_Access_Help_Contents_Menu_User_Management()
        {
            testCaseId = "TC-10421";
            qTestUniqueId = "24895582";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportUserManagementHelpContent();
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
        /// Test Method to Online Help - "?" Mark - Visible - Landing Page
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10422_Online_Help_Question_Mark_Visible_Landing_Page()
        {
            testCaseId = "TC-10422";
            qTestUniqueId = "24901412";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleLandingPage();
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
        /// Test Method to Online Help - "?" Mark - Visible - Dashboard
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10423_Online_Help_Question_Mark_Visible_Dashboard()
        {
            testCaseId = "TC-10423";
            qTestUniqueId = "24901413";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleDashboard();
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
        /// Test Method to Online Help - "?" Mark - Visible - Dashboard - System Consumption Detail Report
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10424_Online_Help_Question_Mark_Visible_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10424";
            qTestUniqueId = "24901414";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleDashboardSystemConsumptionDetailReport();
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
        /// Test Method to Online Help - "?" Mark - Visible - Dashboard - System Consumption Detail Report
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10425_Online_Help_Question_Mark_Visible_Dashboard_Top_10_Accounts_by_Consumption_Detail_Report()
        {
            testCaseId = "TC-10425";
            qTestUniqueId = "24901415";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleDashboardTop10AccDetailReport();
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
        /// Test Method to Online Help - "?" Mark - Visible - Customer Inquiry
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10426_Online_Help_Question_Mark_Visible_Customer_Inquiry()
        {
            testCaseId = "TC-10426";
            qTestUniqueId = "24901417";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleCustomerInquiry();
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
        /// Test Method to Online Help - "?" Mark - Visible - Import
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10427_Online_Help_Question_Mark_Visible_Import()
        {
            testCaseId = "TC-10427";
            qTestUniqueId = "24901418";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleImport();
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
        /// Test Method to Online Help - "?" Mark - Visible - Export
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10428_Online_Help_Question_Mark_Visible_Export()
        {
            testCaseId = "TC-10428";
            qTestUniqueId = "24901419";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleExport();
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
        /// Test Method to Online Help - "?" Mark - Visible - Export History
        /// </summary>
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10429_Online_Help_Question_Mark_Visible_Export_History()
        {
            testCaseId = "TC-10429";
            qTestUniqueId = "24901420";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleExportHistory();
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
        /// Test Method to Online Help - "?" Mark - Visible - Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10430_Online_Help_Question_Mark_Visible_Device_Management()
        {
            testCaseId = "TC-10430";
            qTestUniqueId = "24901421";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleDiviceManagement();
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
        /// Test Method to Online Help - "?" Mark - Visible - User  Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10431_Online_Help_Question_Mark_Visible_User_Management()
        {
            testCaseId = "TC-10431";
            qTestUniqueId = "24901422";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleUserManagement();
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
        /// Test Method to Online Help - "?" Mark - Visible - Roles and Permissions
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10432_Online_Help_Question_Mark_Visible_Roles_and_Permissions()
        {
            testCaseId = "TC-10432";
            qTestUniqueId = "24901423";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleRolesandPermissions();
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
        /// Test Method to Online Help - "?" Mark - Visible - Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10433_Online_Help_Question_Mark_Visible_Notification()
        {
            testCaseId = "TC-10433";
            qTestUniqueId = "24901424";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleNotifications();
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
        /// Test Method to Online Help - "?" Mark - Visible - User Management from Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10434_Online_Help_Question_Mark_Visible_User_Management_from_Landing_Page()
        {
            testCaseId = "TC-10434";
            qTestUniqueId = "24901425";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleUserManagement();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10436_Online_Help_Question_Mark_Accessible_Landing_Page()
        {
            testCaseId = "TC-10436";
            qTestUniqueId = "24901427";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleLandingPage();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10437_Online_Help_Question_Mark_Accessible_Dashboard()
        {
            testCaseId = "TC-10437";
            qTestUniqueId = "24901428";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleDashboard();
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
        /// Test Method to Online Help - "?" Mark - Accessible - System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10438_Online_Help_Question_Mark_Accessible_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10438";
            qTestUniqueId = "24901429";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleDashboardSystemConsumptionDetailReport();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Dashboard Top 10 Accounts by Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10439_Online_Help_Question_Mark_Accessible_Dashboard_Top_10_Accounts_by_Consumption_Detail_Report()
        {
            testCaseId = "TC-10439";
            qTestUniqueId = "24901431";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleDashboardTop10SystemConsumptionDetailReport();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10440_Online_Help_Question_Mark_Accessible_Customer_Inquiry()
        {
            testCaseId = "TC-10440";
            qTestUniqueId = "24901432";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleCustomerInquiry();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10441_Online_Help_Question_Mark_Accessible_Import()
        {
            testCaseId = "TC-10441";
            qTestUniqueId = "24901433";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleImport();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Export
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10442_Online_Help_Question_Mark_Accessible_Export()
        {
            testCaseId = "TC-10442";
            qTestUniqueId = "24901434";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleExport();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Export History
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10443_Online_Help_Question_Mark_Accessible_Export_History()
        {
            testCaseId = "TC-10443";
            qTestUniqueId = "24901435";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleExportHistory();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10444_Online_Help_Question_Mark_Accessible_Device_Management()
        {
            testCaseId = "TC-10444";
            qTestUniqueId = "24901436";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleDeviceManagement();
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
        /// Test Method to Online Help - "?" Mark - Accessible - User Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10445_Online_Help_Question_Mark_Accessible_User_Management()
        {
            testCaseId = "TC-10445";
            qTestUniqueId = "24901437";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleUserManagement();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Roles and Permissions
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10446_Online_Help_Question_Mark_Accessible_Roles_and_Permissions()
        {
            testCaseId = "TC-10446";
            qTestUniqueId = "24901438";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleRolesPermissions();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10447_Online_Help_Question_Mark_Accessible_Notification()
        {
            testCaseId = "TC-10447";
            qTestUniqueId = "24901439";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleNotification();
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
        /// Test Method to Online Help - "?" Mark - Accessible - User Management from Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10448_Online_Help_Question_Mark_Accessible_User_Management_from_Landing_Page()
        {
            testCaseId = "TC-10448";
            qTestUniqueId = "24901440";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleUserManagement();
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
        /// Test Method to Online Help - "?" Mark - Display Location - Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10450_Online_Help_Question_Mark_Display_Location_Landing_Page()
        {
            testCaseId = "TC-10450";
            qTestUniqueId = "24901442";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleLandingPage();
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
        /// Test Method to Online Help - "?" Mark - Display Location - Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10451_Online_Help_Question_Mark_Display_Location_Dashboard()
        {
            testCaseId = "TC-10451";
            qTestUniqueId = "24901443";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleDashboard();
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
        /// Test Method to Online Help - "?" Mark - Display Location - Dashboard System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10452_Online_Help_Question_Mark_Display_Location_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10452";
            qTestUniqueId = "24901444";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleDashboardSystemConsumptionDetailReport();
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
        /// Test Method to Online Help - "?" Mark - Display Location - Dashboard Top 10 Accounts by Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10453_Online_Help_Question_Mark_Display_Location_Dashboard_Top_10_Accounts_by_Consumption_Detail_Report()
        {
            testCaseId = "TC-10453";
            qTestUniqueId = "24901445";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleDashboardTop10AccDetailReport();
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
        /// Test Method to Online Help - "?" Mark - Display Location - Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10454_Online_Help_Question_Mark_Display_Location_Customer_Inquiry()
        {
            testCaseId = "TC-10454";
            qTestUniqueId = "24901446";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleCustomerInquiry();
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
        /// Test Method to Online Help - "?" Mark - Display Location -  Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10455_Online_Help_Question_Mark_Display_Location_Import()
        {
            testCaseId = "TC-10455";
            qTestUniqueId = "24901447";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleImport();
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
        /// Test Method to Online Help - "?" Mark - Display Location - Export
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10456_Online_Help_Question_Mark_Display_Location_Export()
        {
            testCaseId = "TC-10456";
            qTestUniqueId = "24901448";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleExport();
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
        /// Test Method to Online Help - "?" Mark - Display Location - Export History
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10457_Online_Help_Question_Mark_Display_Location_Export_History()
        {
            testCaseId = "TC-10457";
            qTestUniqueId = "24901449";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleExportHistory();
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
        /// Test Method to Online Help - "?" Mark - Display Location - Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10458_Online_Help_Question_Mark_Display_Location_Device_Management()
        {
            testCaseId = "TC-10458";
            qTestUniqueId = "24901450";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleDiviceManagement();
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
        /// Test Method to Online Help - "?" Mark - Display Location - User Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10459_Online_Help_Question_Mark_Display_Location_User_Management()
        {
            testCaseId = "TC-10459";
            qTestUniqueId = "24901451";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleUserManagement();
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
        /// Test Method to Online Help - "?" Mark - Display Location - Roles and Permissions
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10460_Online_Help_Question_Mark_Display_Location_Roles_and_Permissions()
        {
            testCaseId = "TC-10460";
            qTestUniqueId = "24901452";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleRolesandPermissions();
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
        /// Test Method to Online Help - "?" Mark - Display Location - Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10461_Online_Help_Question_Mark_Display_Location_Notification()
        {
            testCaseId = "TC-10461";
            qTestUniqueId = "24901453";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleNotifications();
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
        /// Test Method to Online Help - "?" Mark - Display Location - User Management from Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10462_Online_Help_Question_Mark_Display_Location_User_Management_from_Landing_Page()
        {
            testCaseId = "TC-10462";
            qTestUniqueId = "24901453";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleUserManagement();
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
        /// Test Method to Online Help - "?" Mark - Arrow landing page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10464_Online_Help_Question_Menu_Arrow_Landing_Page()
        {
            testCaseId = "TC-10464";
            qTestUniqueId = "24901456";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.LandingPageUserManagementMenuArrow();
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
        /// Test Method to Online Help - "?" Mark - Arrow - Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10465_Online_Help_Question_Arrow_Dashboard()
        {
            testCaseId = "TC-10465";
            qTestUniqueId = "24901457";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.LandingDashboardMenuArrow();
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
        /// Test Method to Online Help - "?" Mark - Arrow - Dashboard System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10466_Online_Help_Question_Arrow_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10466";
            qTestUniqueId = "24901458";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboarDetailReportMenuArrow();
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
        /// Test Method to Online Help - "?" Mark - Arrow - Dashboard System Consumption Top 10 Accounts Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10467_Online_Help_Question_Arrow_Dashboard_System_Consumption_Top_10_Accounts_Detail_Report()
        {
            testCaseId = "TC-10467";
            qTestUniqueId = "24901458";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboarTop10DetailReportMenuArrow();
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
        /// Test Method to Online Help - "?" Mark - Arrow - Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10468_Online_Help_Question_Arrow_Customer_Inquiry()
        {
            testCaseId = "TC-10468";
            qTestUniqueId = "24901458";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CustomerInquiryMenuArrow();
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
        /// Test Method to Online Help - "?" Mark - Arrow - Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10469_Online_Help_Question_Arrow_Import()
        {
            testCaseId = "TC-10469";
            qTestUniqueId = "24901461";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ImportMenuArrow();
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
        /// Test Method to Online Help - "?" Mark - Arrow - Export
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10470_Online_Help_Question_Arrow_Export()
        {
            testCaseId = "TC-10470";
            qTestUniqueId = "24901462";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportMenuArrow();
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
        /// Test Method to Online Help - "?" Mark - Arrow - Export History
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10471_Online_Help_Question_Arrow_Export_History()
        {
            testCaseId = "TC-10471";
            qTestUniqueId = "24901463";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportHistoryMenuArrow();
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
        /// Test Method to Online Help - "?" Mark - Arrow - Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10472_Online_Help_Question_Arrow_Device_Management()
        {
            testCaseId = "TC-10472";
            qTestUniqueId = "24901464";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DeviceManagementMenuArrow();
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
        /// Test Method to Online Help - "?" Mark - Arrow - User Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10473_Online_Help_Question_Arrow_User_Management()
        {
            testCaseId = "TC-10473";
            qTestUniqueId = "24901465";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.UserManagementMenuArrow();
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
        /// Test Method to Online Help - "?" Mark - Arrow - Roles and Permissions
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10474_Online_Help_Question_Arrow_Roles_Permissions()
        {
            testCaseId = "TC-10474";
            qTestUniqueId = "24901466";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.RolesPermissionsMenuArrow();
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
        /// Test Method to Online Help - "?" Mark - Arrow - Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10475_Online_Help_Question_Arrow_Notification()
        {
            testCaseId = "TC-10475";
            qTestUniqueId = "24901467";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.NotificationMenuArrow();
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
        /// Test Method to Online Help - "?" Mark - Arrow - User Management from Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10476_Online_Help_Question_Arrow_User_Management_from_Landing_Page()
        {
            testCaseId = "TC-10476";
            qTestUniqueId = "24901468";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.LandingPageUserManagementMenuArrow();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser - User Management from Landing Page Icon
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10478_Online_Help_Access_Help_Opens_in_Separate_Browser_User_Management_from_Landing_Page_Icon()
        {
            testCaseId = "TC-10478";
            qTestUniqueId = "24901963";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportUserManagementHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser - Dashboard - System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10479_Online_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10479";
            qTestUniqueId = "24901964";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboardDetailedReportHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser - Dashboard -Top_10 System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10480_Online_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Top_10_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10480";
            qTestUniqueId = "24901965";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboardTop10DetailedReportHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser - Dashboard Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_11817_Online_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11817";
            qTestUniqueId = "25114667";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CompleteReadingHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser - Dashboard Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_11818_Online_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11818";
            qTestUniqueId = "25114674";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IncompleteReadingHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser - Dashboard Major_Reverse_Flow_Detail_Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_11819_Online_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11819";
            qTestUniqueId = "25114676";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.MajorReverseFlowHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser - Dashboard Continuous Usage Detail_Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_11820_Online_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-11820";
            qTestUniqueId = "25114677";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ConitnousUsageHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser - Dashboard Intermittent Usage Detail_Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_11821_Online_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11821";
            qTestUniqueId = "25114684";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IntermittentUsageHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser - Dashboard Minor Reverse Flow Detail_Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_11822_Online_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11822";
            qTestUniqueId = "25114685";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.MinorReverseFlowHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10481_Online_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Notification()
        {
            testCaseId = "TC-10481";
            qTestUniqueId = "24901966";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.NotificationHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser Roles and Permissions
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10482_Online_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Roles_Permissions()
        {
            testCaseId = "TC-10482";
            qTestUniqueId = "24901967";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.RolesPermissionsHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10483_Online_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Landing_Page()
        {
            testCaseId = "TC-10483";
            qTestUniqueId = "24901968";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.LandingPageHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10484_Online_Help_Access_Help_Opens_in_Separate_Browser_Dashboard()
        {
            testCaseId = "TC-10484";
            qTestUniqueId = "24901969";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboardHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10485_Online_Help_Access_Help_Opens_in_Separate_Browser_Customer_Inquiry()
        {
            testCaseId = "TC-10485";
            qTestUniqueId = "24901970";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CustomerInquiryHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10486_Online_Help_Access_Help_Opens_in_Separate_Browser_Import()
        {
            testCaseId = "TC-10486";
            qTestUniqueId = "24901971";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ImportHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser Export
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10487_Online_Help_Access_Help_Opens_in_Separate_Browser_Export()
        {
            testCaseId = "TC-10487";
            qTestUniqueId = "24901972";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser Export History
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10488_Online_Help_Access_Help_Opens_in_Separate_Browser_Export_History()
        {
            testCaseId = "TC-10488";
            qTestUniqueId = "24901973";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportHistoryHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10489_Online_Help_Access_Help_Opens_in_Separate_Browser_Device_Management()
        {
            testCaseId = "TC-10489";
            qTestUniqueId = "24901974";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DeviceManagementHelpContent();
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
        /// Test Method to Online Help Access - Help Opens in Separate Browser User Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10490_Online_Help_Access_Help_Opens_in_Separate_Browser_User_Management()
        {
            testCaseId = "TC-10490";
            qTestUniqueId = "24901975";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.UserManagementHelpContent();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance - Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10491_Online_Help_Access_Help_Opens_Only_One_Instance_Dashboard()
        {
            testCaseId = "TC-10491";
            qTestUniqueId = "24902242";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboardHelpContentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance - User Management from Landing Page Icon
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10492_Online_Help_Access_Help_Opens_Only_One_Instance_User_Management_from_Landing_Page_Icon()
        {
            testCaseId = "TC-10492";
            qTestUniqueId = "24902243";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.UserManagementHelpContentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance - Dashboard - Top 10 Accounts Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10493_Online_Help_Access_Help_Opens_Only_One_Instance_Dashboard_Top_10_Accounts_Detail_Report()
        {
            testCaseId = "TC-10493";
            qTestUniqueId = "24902244";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.TopTenAccHelpContentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance - Dashboard - Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11825_Online_Help_Access_Help_Opens_Only_One_Instance_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11825";
            qTestUniqueId = "25114723";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CompleteReadingsHelpContentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance - Dashboard - Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11826_Online_Help_Access_Help_Opens_Only_One_Instance_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11826";
            qTestUniqueId = "25114728";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CompleteReadingsHelpIncompleteOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance - Dashboard - Continuous Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11827_Online_Help_Access_Help_Opens_Only_One_Instance_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-11827";
            qTestUniqueId = "25114743";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ContinuousUsageHelpIncontentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance - Dashboard - Intermittent Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11828_Online_Help_Access_Help_Opens_Only_One_Instance_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11828";
            qTestUniqueId = "25114744";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IntermittentUsageHelpIncontentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance - Dashboard - Major Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11829_Online_Help_Access_Help_Opens_Only_One_Instance_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11829";
            qTestUniqueId = "25114753";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.MajorReverseFlowHelpIncontentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance - Dashboard - Minor Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11830_Online_Help_Access_Help_Opens_Only_One_Instance_Dashboard_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11830";
            qTestUniqueId = "25114754";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.MinorReverseFlowHelpIncontentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance - Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10494_Online_Help_Access_Help_Opens_Only_One_Instance_Notification()
        {
            testCaseId = "TC-10494";
            qTestUniqueId = "24902245";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.NotificationHelpIncontentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance - Roles and Permissions
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10495_Online_Help_Access_Help_Opens_Only_One_Instance_Roles_and_Permissions()
        {
            testCaseId = "TC-10495";
            qTestUniqueId = "24902246";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.RolesPermissionsHelpIncontentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance -Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10496_Online_Help_Access_Help_Opens_Only_One_Instance_Landing_Page()
        {
            testCaseId = "TC-10496";
            qTestUniqueId = "24902247";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.LandingPageHelpIncontentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance -Dashboard - System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10497_Online_Help_Access_Help_Opens_Only_One_Instance_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10497";
            qTestUniqueId = "24902248";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DetailReportHelpIncontentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10498_Online_Help_Access_Help_Opens_Only_One_Instance_Customer_Inquiry()
        {
            testCaseId = "TC-10498";
            qTestUniqueId = "24902249";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CustomerInquiryHelpIncontentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10499_Online_Help_Access_Help_Opens_Only_One_Instance_Import()
        {
            testCaseId = "TC-10499";
            qTestUniqueId = "24902250";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ImportHelpIncontentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance Export
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10500_Online_Help_Access_Help_Opens_Only_One_Instance_Export()
        {
            testCaseId = "TC-10500";
            qTestUniqueId = "24902251";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportHelpIncontentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance Export History
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10501_Online_Help_Access_Help_Opens_Only_One_Instance_Export_History()
        {
            testCaseId = "TC-10501";
            qTestUniqueId = "24902252";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportHistoryHelpIncontentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10502_Online_Help_Access_Help_Opens_Only_One_Instance_Device_Management()
        {
            testCaseId = "TC-10502";
            qTestUniqueId = "24902253";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DeviceManagementHelpIncontentOneInstance();
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
        /// Test Method to Online Help Access - Help Opens Only One Instance User Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10503_Online_Help_Access_Help_Opens_Only_One_Instance_User_Management()
        {
            testCaseId = "TC-10503";
            qTestUniqueId = "24902254";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.UserManagementHelpIncontentOneInstance();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10546_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Landing_Page()
        {
            testCaseId = "TC-10546";
            qTestUniqueId = "24919098";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.LandingPageAboutNeptune360();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10547_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Dashboard()
        {
            testCaseId = "TC-10547";
            qTestUniqueId = "24919099";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboardAboutNeptune360();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Dashboard System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10548_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10548";
            qTestUniqueId = "24919100";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboardDetailReportAboutNeptune360();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Dashboard Top 10 Accounts System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10549_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Dashboard_Top_10_Accounts_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10549";
            qTestUniqueId = "24919101";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboardTopTenDetailReportAboutNeptune360();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10550_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Customer_Inquiry()
        {
            testCaseId = "TC-10550";
            qTestUniqueId = "24919102";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CustomerInquiryAboutNeptune360();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10551_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Import()
        {
            testCaseId = "TC-10551";
            qTestUniqueId = "24919103";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ImportAboutNeptune360();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Export
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10552_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Export()
        {
            testCaseId = "TC-10552";
            qTestUniqueId = "24919104";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportAboutNeptune360();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Export History
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10553_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Export_History()
        {
            testCaseId = "TC-10553";
            qTestUniqueId = "24919105";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportHistoryAboutNeptune360();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10554_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Device_Management()
        {
            testCaseId = "TC-10554";
            qTestUniqueId = "24919106";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DeviceManagementAboutNeptune360();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - User Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10555_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_User_Management()
        {
            testCaseId = "TC-10555";
            qTestUniqueId = "24919107";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.UserManagementAboutNeptune360();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Roles and Permissions
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10556_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Roles_Permissions()
        {
            testCaseId = "TC-10556";
            qTestUniqueId = "24919108";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.RoleManagementAboutNeptune360();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10557_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Notification()
        {
            testCaseId = "TC-10557";
            qTestUniqueId = "24919109";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.NotificationAboutNeptune360();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 -  User Management from Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10558_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_User_Management_from_Landing_Page()
        {
            testCaseId = "TC-10558";
            qTestUniqueId = "24919110";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.UserManagementLandingPageAboutNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10560_Online_Help_About_Neptune_360_Modal_Landing_Page()
        {
            testCaseId = "TC-10560";
            qTestUniqueId = "24919112";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalLandingPageNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10561_Online_Help_About_Neptune_360_Modal_Dashboard()
        {
            testCaseId = "TC-10561";
            qTestUniqueId = "24919113";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalDashboardPageNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Dashboard Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10562_Online_Help_About_Neptune_360_Modal_Dashboard_Detail_Report()
        {
            testCaseId = "TC-10562";
            qTestUniqueId = "24919114";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalDashboardDetailReportPageNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Dashboard Top_Ten_Accounts_ Detail Report 
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10563_Online_Help_About_Neptune_360_Modal_Dashboard_Top_Ten_Accounts_Detail_Report()
        {
            testCaseId = "TC-10563";
            qTestUniqueId = "24919115";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalDashboardTopTenDetailReportPageNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Customer Inquiry 
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10564_Online_Help_About_Neptune_360_Modal_Customer_Inquiry()
        {
            testCaseId = "TC-10564";
            qTestUniqueId = "24919116";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CustomerInquiryDetailReportPageNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Import 
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10565_Online_Help_About_Neptune_360_Modal_Import()
        {
            testCaseId = "TC-10565";
            qTestUniqueId = "24919117";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ImportDetailReportPageNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Export 
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10566_Online_Help_About_Modal_Title_Neptune_360_Modal_Export()
        {
            testCaseId = "TC-10566";
            qTestUniqueId = "24919118";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportDetailReportPageNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Export History
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10567_Online_Help_About_Modal_Title_Neptune_360_Modal_Export_History()
        {
            testCaseId = "TC-10567";
            qTestUniqueId = "24919119";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExporthistoryDetailReportPageNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal -  Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10568_Online_Help_About_Modal_Title_Neptune_360_Modal_Device_Management()
        {
            testCaseId = "TC-10568";
            qTestUniqueId = "24919120";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DeviceManagementModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal -  User Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10569_Online_Help_About_Modal_Title_Neptune_360_Modal_User_Management()
        {
            testCaseId = "TC-10569";
            qTestUniqueId = "24919121";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.UserManagementModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal -  Roles and Permissions
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10570_Online_Help_About_Modal_Title_Neptune_360_Modal_Roles_Permissions()
        {
            testCaseId = "TC-10570";
            qTestUniqueId = "24919122";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.RolesPermissionsModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal -  Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10571_Online_Help_About_Modal_Title_Neptune_360_Notification()
        {
            testCaseId = "TC-10571";
            qTestUniqueId = "24919123";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.NotificationModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - User Management from Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10572_Online_Help_About_Modal_Title_Neptune_360_User_Management_from_Landing_Page()
        {
            testCaseId = "TC-10572";
            qTestUniqueId = "24919124";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.UserManagementLandingPageModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10574_Online_Help_About_Modal_Title_Neptune_360_Landing_Page()
        {
            testCaseId = "TC-10574";
            qTestUniqueId = "24919126";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.LandingPageModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10575_Online_Help_About_Modal_Title_Neptune_360_Dashboard()
        {
            testCaseId = "TC-10575";
            qTestUniqueId = "24919127";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboardModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Dashboard System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10576_Online_Help_About_Modal_Title_Neptune_360_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10576";
            qTestUniqueId = "24919128";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboarDetailReportdModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Dashboard Top_10_Account System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10577_Online_Help_About_Modal_Title_Neptune_360_Dashboard_Top_10_Account_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10577";
            qTestUniqueId = "24919129";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboarTopTenDetailReportdModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10578_Online_Help_About_Modal_Title_Neptune_360_Customer_Inquiry()
        {
            testCaseId = "TC-10578";
            qTestUniqueId = "24919130";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CustomerInquiryModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10579_Online_Help_About_Modal_Title_Neptune_360_Import()
        {
            testCaseId = "TC-10579";
            qTestUniqueId = "24919131";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ImportModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Export
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10580_Online_Help_About_Modal_Title_Neptune_360_Export()
        {
            testCaseId = "TC-10580";
            qTestUniqueId = "24919132";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Export History
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10581_Online_Help_About_Modal_Title_Neptune_360_Export_History()
        {
            testCaseId = "TC-10581";
            qTestUniqueId = "24919133";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportHistoryModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal -User Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10582_Online_Help_About_Modal_Title_Neptune_360_User_Management()
        {
            testCaseId = "TC-10582";
            qTestUniqueId = "24919134";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.UserManagementModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal -Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10583_Online_Help_About_Modal_Title_Neptune_360_Device_Management()
        {
            testCaseId = "TC-10583";
            qTestUniqueId = "24919135";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DeviceManagementModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Roles Permission
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10584_Online_Help_About_Modal_Title_Neptune_360_Roles_Permission()
        {
            testCaseId = "TC-10584";
            qTestUniqueId = "24919136";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.RolesPermissionModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal - Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10585_Online_Help_About_Modal_Title_Neptune_360_Notification()
        {
            testCaseId = "TC-10585";
            qTestUniqueId = "24919137";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.NotificationModalNeptune360();
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
        /// Test Method to Online Help About Neptune 360 - Modal_Title - User Management from Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10586_Online_Help_About_Neptune_360_Modal_Title_User_Management_from_Landing_Page()
        {
            testCaseId = "TC-10586";
            qTestUniqueId = "24919138";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.UserManagementLandingPageModalNeptune360();
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
        /// Test Method to Online Help About Modal Copyright Statement - Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10588_Online_Help_About_Modal_Copyright_Statement_Landing_Page()
        {
            testCaseId = "TC-10588";
            qTestUniqueId = "24919140";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementLandingPage();
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
        /// Test Method to Online Help About Modal Copyright Statement - Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10589_Online_Help_About_Modal_Copyright_Statement_Dashboard()
        {
            testCaseId = "TC-10589";
            qTestUniqueId = "24919141";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementDashboard();
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
        /// Test Method to Online Help About Modal Copyright Statement - Dashboard System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10590_Online_Help_About_Modal_Copyright_Statement_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10590";
            qTestUniqueId = "24919142";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementDetailReport();
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
        /// Test Method to Online Help About Modal Copyright Statement - Dashboard Top 10 Accounts System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10591_Online_Help_About_Modal_Copyright_Statement_Dashboard_Top_10_Accounts_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10591";
            qTestUniqueId = "24919143";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementTopTenAccountsDetailReport();
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
        /// Test Method to Online Help About Modal Copyright Statement - Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10592_Online_Help_About_Modal_Copyright_Statement_Customer_Inquiry()
        {
            testCaseId = "TC-10592";
            qTestUniqueId = "24919144";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementCustomerInquiry();
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
        /// Test Method to Online Help About Modal Copyright Statement - Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10593_Online_Help_About_Modal_Copyright_Statement_Import()
        {
            testCaseId = "TC-10593";
            qTestUniqueId = "24919145";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementImport();
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
        /// Test Method to Online Help About Modal Copyright Statement - Export
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10594_Online_Help_About_Modal_Copyright_Statement_Export()
        {
            testCaseId = "TC-10594";
            qTestUniqueId = "24919146";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementExport();
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
        /// Test Method to Online Help About Modal Copyright Statement - Export _History
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10595_Online_Help_About_Modal_Copyright_Statement_Export_History()
        {
            testCaseId = "TC-10595";
            qTestUniqueId = "24919147";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementExportHistory();
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
        /// Test Method to Online Help About Modal Copyright Statement - Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10596_Online_Help_About_Modal_Copyright_Statement_Device_Management()
        {
            testCaseId = "TC-10596";
            qTestUniqueId = "24919148";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementDeviceManagement();
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
        /// Test Method to Online Help About Modal Copyright Statement - User Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10597_Online_Help_About_Modal_Copyright_Statement_User_Management()
        {
            testCaseId = "TC-10597";
            qTestUniqueId = "24919149";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementUserManagement();
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
        /// Test Method to Online Help About Modal Copyright Statement - Roles and Permissions
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10598_Online_Help_About_Modal_Copyright_Statement_Roles_Permissions()
        {
            testCaseId = "TC-10598";
            qTestUniqueId = "24919150";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementRolesPermissions();
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
        /// Test Method to Online Help About Modal Copyright Statement - Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10599_Online_Help_About_Modal_Copyright_Statement_Notification()
        {
            testCaseId = "TC-10599";
            qTestUniqueId = "24919151";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementNotification();
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
        /// Test Method to Online Help About Modal Copyright Statement - User Management from Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10600_Online_Help_About_Modal_Copyright_Statement_User_Management_Landing_Page()
        {
            testCaseId = "TC-10600";
            qTestUniqueId = "24919152";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementUserManagementLandingPage();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10602_Online_Help_About_Modal_X_Close_Display_Landing_Page()
        {
            testCaseId = "TC-10602";
            qTestUniqueId = "24919154";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseLandingPage();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10603_Online_Help_About_Modal_X_Close_Display_Dashboard()
        {
            testCaseId = "TC-10603";
            qTestUniqueId = "24919155";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseDashboard();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - Dashboard System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10604_Online_Help_About_Modal_X_Close_Display_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10604";
            qTestUniqueId = "24919156";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseDashboardDetailReport();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - Dashboard Top 10 System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10605_Online_Help_About_Modal_X_Close_Display_Dashboard_Top_Ten_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-10605";
            qTestUniqueId = "24919157";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseDashboardTopTenDetailReport();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10606_Online_Help_About_Modal_X_Close_Display_Customer_Inquiry()
        {
            testCaseId = "TC-10606";
            qTestUniqueId = "24919158";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseCustomerInquiry();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10607_Online_Help_About_Modal_X_Close_Display_Import()
        {
            testCaseId = "TC-10607";
            qTestUniqueId = "24919159";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseImport();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - Export
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10608_Online_Help_About_Modal_X_Close_Display_Export()
        {
            testCaseId = "TC-10608";
            qTestUniqueId = "24919160";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseExport();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - Export History
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_10609_Online_Help_About_Modal_X_Close_Display_Export_History()
        {
            testCaseId = "TC-10609";
            qTestUniqueId = "24919161";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseExportHistory();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10610_Online_Help_About_Modal_X_Close_Display_Device_Management()
        {
            testCaseId = "TC-10610";
            qTestUniqueId = "24919162";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseDeviceManagement();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - User  Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10611_Online_Help_About_Modal_X_Close_Display_User_Management()
        {
            testCaseId = "TC-10611";
            qTestUniqueId = "24919163";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseUserManagement();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - Roles and Permissions
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10612_Online_Help_About_Modal_X_Close_Display_Roles_Permissions()
        {
            testCaseId = "TC-10612";
            qTestUniqueId = "24919165";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseRolesPermissions();
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
        /// Test Method to Online Help - About Modal - X(Close) Display -Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10613_Online_Help_About_Modal_X_Close_Display_Notification()
        {
            testCaseId = "TC-10613";
            qTestUniqueId = "24919168";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseNotification();
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
        /// Test Method to Online Help - About Modal - X(Close) Display -User Management from Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10614_Online_Help_About_Modal_X_Close_Display_User_Management_Landing_Page()
        {
            testCaseId = "TC-10614";
            qTestUniqueId = "24919171";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseUserManagementLandingPage();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen - Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10616_OOnline_Help_About_Modal_Click_X_Icon_Return_Previous_Screen_Landing_Page()
        {
            testCaseId = "TC-10616";
            qTestUniqueId = "24919176";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseLandingPage();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen - Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10617_Online_Help_About_Modal_Click_X_Icon_Return_Previous_Screen_Dashboard()
        {
            testCaseId = "TC-10617";
            qTestUniqueId = "24919179";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseDashboard();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen - Dashboard System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        public void TC_10618_Online_Help_About_Modal_Click_X_Icon_Return_Previous_Screen_Dashboard_Detail_Report()
        {
            testCaseId = "TC-10618";
            qTestUniqueId = "24919182";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseDashboardDetailReport();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen - Dashboard Top 10 System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10619_Online_Help_About_Modal_Click_X_Icon_Return_Previous_Screen_Dashboard_Top_Ten_Detail_Report()
        {
            testCaseId = "TC-10619";
            qTestUniqueId = "24919185";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseDashboardTopTenDetailReport();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen -Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10620_Online_Help_About_Modal_Click_X_Icon_Return_Previous_Customer_Inquiry()
        {
            testCaseId = "TC-10620";
            qTestUniqueId = "24919188";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseCustomerInquiry();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10621_Online_Help_About_Modal_Click_X_Icon_Return_Previous_Import()
        {
            testCaseId = "TC-10621";
            qTestUniqueId = "24919191";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseImport();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10622_Online_Help_About_Modal_Click_X_Icon_Return_Previous_Export()
        {
            testCaseId = "TC-10622";
            qTestUniqueId = "24919193";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseExport();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen Export History
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10623_Online_Help_About_Modal_Click_X_Icon_Return_Previous_Export_History()
        {
            testCaseId = "TC-10623";
            qTestUniqueId = "24919196";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseExportHistory();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10624_Online_Help_About_Modal_Click_X_Icon_Return_Previous_Device_Management()
        {
            testCaseId = "TC-10624";
            qTestUniqueId = "24919199";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseDeviceManagement();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen User Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10625_Online_Help_About_Modal_Click_X_Icon_Return_Previous_User_Management()
        {
            testCaseId = "TC-10625";
            qTestUniqueId = "24919202";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseUserManagement();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen Roles and Permissions
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10626_Online_Help_About_Modal_Click_X_Icon_Return_Previous_Roles_Permissions()
        {
            testCaseId = "TC-10626";
            qTestUniqueId = "24919205";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseRolesPermissions();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10627_Online_Help_About_Modal_Click_X_Icon_Return_Previous_Notification()
        {
            testCaseId = "TC-10627";
            qTestUniqueId = "24919208";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseNotification();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen User Management from Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_10628_Online_Help_About_Modal_Click_X_Icon_Return_Previous_User_Management_Landing_Page()
        {
            testCaseId = "TC-10628";
            qTestUniqueId = "24919213";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCloseUserManagementLandingPage();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Dashboard - Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_11769_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11769";
            qTestUniqueId = "25078021";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CompleteCountQuestiontArrow();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Dashboard - Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11770_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11770";
            qTestUniqueId = "25078022";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IncompleteCountQuestiontArrow();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Dashboard - Continuous Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11771_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-11771";
            qTestUniqueId = "25078023";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ContinuousUsageNeptune360();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Dashboard - Intermittent Usage  Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11772_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11772";
            qTestUniqueId = "25078024";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IntermittentUsageNeptune360();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Dashboard - Major Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11773_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11773";
            qTestUniqueId = "25078025";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.MajorReverseFlowNeptune360();
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
        /// Test Method to Online Help - "?" Mark Menu Arrow - About Neptune 360 - Dashboard - Minor Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11774_Online_Help_Question_Mark_Menu_Arrow_About_Neptune_360_Dashboard_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11774";
            qTestUniqueId = "25078026";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.MinorReverseFlowNeptune360();
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
        /// Test Method to Online Help - About Neptune 360 - Modal - Dashboard - Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11777_Online_Help_About_Neptune360_Modal_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11777";
            qTestUniqueId = "25078033";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CompleteReadingAboutNeptune360();
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
        /// Test Method to Online Help - About Neptune 360 - Modal - Dashboard - Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11778_Online_Help_About_Neptune360_Modal_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11778";
            qTestUniqueId = "25078034";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IncompleteReadingAboutNeptune360();
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
        /// Test Method to Online Help - About Neptune 360 - Modal - Dashboard - Continuous Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11779_Online_Help_About_Neptune360_Modal_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-11779";
            qTestUniqueId = "25078035";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCompleteReadings();
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
        /// Test Method to Online Help - About Neptune 360 - Modal - Dashboard - Intermittent Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11780_Online_Help_About_Neptune360_Modal_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11780";
            qTestUniqueId = "25078037";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalIntermittentUsage();
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
        /// Test Method to Online Help - About Neptune 360 - Modal - Dashboard - Major Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11781_Online_Help_About_Neptune360_Modal_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11781";
            qTestUniqueId = "25078038";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalMajorReverseFlow();
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
        /// Test Method to Online Help - About Neptune 360 - Modal - Dashboard - Minor Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11782_Online_Help_About_Neptune360_Modal_Dashboard_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11782";
            qTestUniqueId = "25078039";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalMinorReverseFlow();
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
        /// Test Method to Online Help - About Neptune 360 - Modal - Dashboard - Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11785_Online_Help_About_Neptune360_Modal_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11785";
            qTestUniqueId = "25078043";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCompleteReadings();
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
        /// Test Method to Online Help - About Neptune 360 - Modal - Dashboard - Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11786_Online_Help_About_Neptune360_Modal_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11786";
            qTestUniqueId = "25078044";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalIncompleteReadings();
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
        /// Test Method to Online Help - About Neptune 360 - Modal - Continuous Usage Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11787_Online_Help_About_Neptune360_Modal_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-11787";
            qTestUniqueId = "25078045";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalContinuousUsage();
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
        /// Test Method to Online Help - About Neptune 360 - Modal - Intermittent Usage Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11788_Online_Help_About_Neptune360_Modal_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11788";
            qTestUniqueId = "25078046";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalIntermittentUsage();
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
        /// Test Method to Online Help - About Neptune 360 - Modal - Major Reverse Flow Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11789_Online_Help_About_Neptune360_Modal_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11789";
            qTestUniqueId = "25078048";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalMajorReverseFlow();
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
        /// Test Method to Online Help - About Neptune 360 - Modal - Minor Reverse Flow Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11790_Online_Help_About_Neptune360_Modal_Dashboard_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11790";
            qTestUniqueId = "25078049";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalMinorReverseFlow();
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
        /// Test Method to Online Help - About Modal - Copyright Statement - Dashboard - Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11793_Online_Help_About_Modal_Copyright_Statement_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11793";
            qTestUniqueId = "25078054";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementCompleteReadings();
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
        /// Test Method to Online Help - About Modal - Copyright Statement - Dashboard - Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11794_Online_Help_About_Modal_Copyright_Statement_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11794";
            qTestUniqueId = "25078055";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementIncompleteReading();
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
        /// Test Method to Online Help - About Modal - Copyright Statement - Dashboard - Continuous Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11795_Online_Help_About_Modal_Copyright_Statement_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-11795";
            qTestUniqueId = "25078056";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementContinuousUsage();
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
        /// Test Method to Online Help - About Modal - Copyright Statement - Dashboard - Intermittent Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11796_Online_Help_About_Modal_Copyright_Statement_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11796";
            qTestUniqueId = "25078057";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementIntermittentUsage();
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
        /// Test Method to Online Help - About Modal - Copyright Statement - Dashboard - Major Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11797_Online_Help_About_Modal_Copyright_Statement_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11797";
            qTestUniqueId = "25078061";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementMajorReverseFlow();
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
        /// Test Method to Online Help - About Modal - Copyright Statement - Dashboard - Minor Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11798_Online_Help_About_Modal_Copyright_Statement_Dashboard_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11798";
            qTestUniqueId = "25078063";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CopyrightStatementMinorReverseFlow();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - Dashboard - Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11801_Online_Help_About_Modal_X_Close_Display_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11801";
            qTestUniqueId = "25078072";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCompleteReadings();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - Dashboard - Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11802_Online_Help_About_Modal_X_Close_Display_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11802";
            qTestUniqueId = "25078074";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalIncompleteReadings();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - Dashboard -  Continuous Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11803_Online_Help_About_Modal_X_Close_Display_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-11803";
            qTestUniqueId = "25078076";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalContinuousUsage();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - Dashboard -  Intermittent Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11804_Online_Help_About_Modal_X_Close_Display_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11804";
            qTestUniqueId = "25078079";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalIntermittentUsage();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - Dashboard - Major Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11805_Online_Help_About_Modal_X_Close_Display_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11805";
            qTestUniqueId = "25078080";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalMajorReverseFlow();
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
        /// Test Method to Online Help - About Modal - X(Close) Display - Dashboard - Minor Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11806_Online_Help_About_Modal_X_Close_Display_Dashboard_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11806";
            qTestUniqueId = "25078083";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalMinorReverseFlow();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen - Dashboard - Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11809_Online_Help_About_Modal_Click_X_Icon_Return_Previous_Screen_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11809";
            qTestUniqueId = "25078090";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalCompleteReadings();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen - Dashboard - Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11810_Online_Help_About_Modal_Click_X_Icon_Return_Previous_Screen_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11810";
            qTestUniqueId = "25078092";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalIncompleteReadings();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen - Dashboard - Continuous Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11811_Online_Help_About_Modal_Click_X_Icon_Return_Previous_Screen_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-11811";
            qTestUniqueId = "25078095";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalContinuousUsage();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen - Dashboard - Intermittent Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11812_Online_Help_About_Modal_Click_X_Icon_Return_Previous_Screen_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11812";
            qTestUniqueId = "25078097";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalIntermittentUsage();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen - Dashboard - Major Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11813_Online_Help_About_Modal_Click_X_Icon_Return_Previous_Screen_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11813";
            qTestUniqueId = "25078101";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalMajorReverseFlow();
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
        /// Test Method to Online Help - About Modal - Click X Icon - Return Previous Screen - Dashboard - Minor Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11814_Online_Help_About_Modal_Click_X_Icon_Return_Previous_Screen_Dashboard_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11814";
            qTestUniqueId = "25078104";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ModalMinorReverseFlow();
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
        /// Test Method to Contextual Help Access - Question Mark - Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11833_Contextual_Help_Access_Question_Mark_Landing_Page()
        {
            testCaseId = "TC-11833";
            qTestUniqueId = "25125746";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleLandingPage();
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
        /// Test Method to Contextual Help Access - Question Mark - Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11834_Contextual_Help_Access_Question_Mark_Dashboard()
        {
            testCaseId = "TC-11834";
            qTestUniqueId = "25125747";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleDashboard();
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
        /// Test Method to Contextual Help Access - Question Mark - Dashboard System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11835_Contextual_Help_Access_Question_Mark_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-11835";
            qTestUniqueId = "25125748";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleDashboardSystemConsumptionDetailReport();
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
        /// Test Method to Contextual Help Access - Question Mark - Dashboard Top 10 Accounts Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11836_Contextual_Help_Access_Question_Mark_Dashboard_Top_Ten_Accounts_Detail_Report()
        {
            testCaseId = "TC-11836";
            qTestUniqueId = "25125749";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleDashboardTop10SystemConsumptionDetailReport();
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
        /// Test Method to Contextual Help Access - Question Mark - Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11837_Contextual_Help_Access_Question_Mark_Customer_Inquiry()
        {
            testCaseId = "TC-11837";
            qTestUniqueId = "25125750";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleCustomerInquiry();
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
        /// Test Method to Contextual Help Access - Question Mark - Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11838_Contextual_Help_Access_Question_Mark_Import()
        {
            testCaseId = "TC-11838";
            qTestUniqueId = "25125751";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleImport();
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
        /// Test Method to Contextual Help Access - Question Mark - Export
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11839_Contextual_Help_Access_Question_Mark_Export()
        {
            testCaseId = "TC-11839";
            qTestUniqueId = "25125752";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleExport();
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
        /// Test Method to Contextual Help Access - Question Mark - Export History
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11840_Contextual_Help_Access_Question_Mark_Export_History()
        {
            testCaseId = "TC-11840";
            qTestUniqueId = "25125753";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleExportHistory();
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
        /// Test Method to Contextual Help Access - Question Mark - Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11841_Contextual_Help_Access_Question_Mark_Device_Management()
        {
            testCaseId = "TC-11841";
            qTestUniqueId = "25125754";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleDeviceManagement();
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
        /// Test Method to Contextual Help Access - Question Mark - User Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11842_Contextual_Help_Access_Question_Mark_User_Management()
        {
            testCaseId = "TC-11842";
            qTestUniqueId = "25125755";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleUserManagement();
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
        /// Test Method to Contextual Help Access - Question Mark - Role Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11843_Contextual_Help_Access_Question_Mark_Role_Management()
        {
            testCaseId = "TC-11843";
            qTestUniqueId = "25125756";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleRolesPermissions();
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
        /// Test Method to Contextual Help Access - Question Mark - Email Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11844_Contextual_Help_Access_Question_Mark_Email_Notification()
        {
            testCaseId = "TC-11844";
            qTestUniqueId = "25125757";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleNotification();
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
        /// Test Method to Contextual Help Access - Question Mark - Email Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11845_Contextual_Help_Access_Question_Mark_Email_Notification()
        {
            testCaseId = "TC-11845";
            qTestUniqueId = "25125758";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkAccessibleUserManagementLandingPage();
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
        /// Test Method to Contextual Help Access - Question Mark Dashboard - Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11846_Contextual_Help_Access_Question_Mark_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11846";
            qTestUniqueId = "25125759";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMArkCompleteReading();
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
        /// Test Method to Contextual Help Access - Question Mark Dashboard - Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11847_Contextual_Help_Access_Question_Mark_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11847";
            qTestUniqueId = "25125760";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkIncompleteReading();
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
        /// Test Method to Contextual Help Access - Question Mark Dashboard - Critical Continuous Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11848_Contextual_Help_Access_Question_Mark_Dashboard_Critical_Continuous_Consumption_Detail_Report()
        {
            testCaseId = "TC-11848";
            qTestUniqueId = "25125761";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestiontMarkcriticalConsumption();
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
        /// Test Method to Contextual Help Access - Question Mark Dashboard - Critical Intermittent UsageDetail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11849_Contextual_Help_Access_Question_Mark_Dashboard_Critical_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11849";
            qTestUniqueId = "25125762";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkIntermittent();
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
        /// Test Method to Contextual Help Access - Question Mark Dashboard -Major Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11850_Contextual_Help_Access_Question_Mark_Major_Revers_Flow_Detail_Report()
        {
            testCaseId = "TC-11850";
            qTestUniqueId = "25125763";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkMajorReverseFlow();
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
        /// Test Method to Contextual Help Access - Question Mark Dashboard -Minor Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11851_Contextual_Help_Access_Question_Mark_Minor_Revers_Flow_Detail_Report()
        {
            testCaseId = "TC-11851";
            qTestUniqueId = "25125764";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkMinorReverseFlow();
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
        /// Test Method to Contextual Help Access - Question Mark Dashboard -Minor Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12156_Contextual_Help_Access_Question_Mark_Minor_Revers_Flow_Detail_Report()
        {
            testCaseId = "TC-12156";
            qTestUniqueId = "25966551";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                //url = testData["URL"];
                //userName = testData["UserName"];
                //password = testData["Password"];
                //home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.AuthenticationDeviceManagement();
                //home.UserLogOut();
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
        /// Test Method to Contextual Help Access - Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12148_Contextual_Help_Access_Landing_Page()
        {
            testCaseId = "TC-12148";
            qTestUniqueId = "25966543";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                //url = testData["URL"];
                //userName = testData["UserName"];
                //password = testData["Password"];
                //home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.AuthenticationDeviceManagement();
                //home.UserLogOut();
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
        /// Test Method to Contextual Help Access - Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12149_Contextual_Help_Access_Dashboard()
        {
            testCaseId = "TC-12149";
            qTestUniqueId = "25966544";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                //url = testData["URL"];
                //userName = testData["UserName"];
                //password = testData["Password"];
                //home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.AuthenticationDeviceManagement();
                //home.UserLogOut();
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
        /// Test Method to Contextual Help Access - Dashboard System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12150_Contextual_Help_Access_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-12150";
            qTestUniqueId = "25966545";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                //url = testData["URL"];
                //userName = testData["UserName"];
                //password = testData["Password"];
                //home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.AuthenticationDeviceManagement();
                //home.UserLogOut();
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
        /// Test Method to Contextual Help Access - Dashboard Top Ten System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12151_Contextual_Help_Access_Dashboard_Top_Ten_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-12151";
            qTestUniqueId = "25966546";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                //url = testData["URL"];
                //userName = testData["UserName"];
                //password = testData["Password"];
                //home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.AuthenticationDeviceManagement();
                //home.UserLogOut();
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
        /// Test Method to Contextual Help Access - Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12152_Contextual_Help_Access_Customer_Inquiry()
        {
            testCaseId = "TC-12152";
            qTestUniqueId = "25966547";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                //url = testData["URL"];
                //userName = testData["UserName"];
                //password = testData["Password"];
                //home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.AuthenticationDeviceManagement();
                //home.UserLogOut();
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
        /// Test Method to Contextual Help Access - Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12153_Contextual_Help_Access_Import()
        {
            testCaseId = "TC-12153";
            qTestUniqueId = "25966548";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                //url = testData["URL"];
                //userName = testData["UserName"];
                //password = testData["Password"];
                //home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.AuthenticationDeviceManagement();
                //home.UserLogOut();
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
        /// Test Method to Contextual Help Access - Export
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12154_Contextual_Help_Access_Export()
        {
            testCaseId = "TC-12154";
            qTestUniqueId = "25966549";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                //url = testData["URL"];
                //userName = testData["UserName"];
                //password = testData["Password"];
                //home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.AuthenticationDeviceManagement();
                //home.UserLogOut();
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
        /// Test Method to Contextual Help Access - Export History
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12155_Contextual_Help_Access_Export_History()
        {
            testCaseId = "TC-12155";
            qTestUniqueId = "25966550";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                //url = testData["URL"];
                //userName = testData["UserName"];
                //password = testData["Password"];
                //home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.AuthenticationDeviceManagement();
                //home.UserLogOut();
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
        /// Test Method to Contextual Help Access - User Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12157_Contextual_Help_Access_User_Management()
        {
            testCaseId = "TC-12157";
            qTestUniqueId = "25966552";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.AuthenticationDeviceManagement();
                //home.UserLogOut();
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
        /// Test Method to Contextual Help Access - Roles and Permissions
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12158_Contextual_Help_Access_Roles_Permissions()
        {
            testCaseId = "TC-12158";
            qTestUniqueId = "25966553";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                onlineHelp.AuthenticationDeviceManagement();
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
        /// Test Method to Contextual Help Access - Roles and Permissions
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12159_Contextual_Help_Access_Notification()
        {
            testCaseId = "TC-12159";
            qTestUniqueId = "25966554";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                onlineHelp.AuthenticationDeviceManagement();
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
        /// Test Method to Contextual Help Access - User Management from Landing Page Icon
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12160_Contextual_Help_Access_User_Management_from_Landing_Page_Icon()
        {
            testCaseId = "TC-12160";
            qTestUniqueId = "25966555";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                onlineHelp.AuthenticationDeviceManagement();
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
        /// Test Method to Contextual Help Access - Dashboard - Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12161_Contextual_Help_Access_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-12161";
            qTestUniqueId = "25966556";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                onlineHelp.AuthenticationDeviceManagement();
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
        /// Test Method to Contextual Help Access - Dashboard - Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12162_Contextual_Help_Access_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-12162";
            qTestUniqueId = "25966557";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                onlineHelp.AuthenticationDeviceManagement();
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
        /// Test Method to Contextual Help Access - Dashboard - Continuous Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12163_Contextual_Help_Access_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-12163";
            qTestUniqueId = "25966558";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                onlineHelp.AuthenticationDeviceManagement();
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
        /// Test Method to Contextual Help Access - Dashboard - Intermittent Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12164_Contextual_Help_Access_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-12164";
            qTestUniqueId = "25966559";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                onlineHelp.AuthenticationDeviceManagement();
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
        /// Test Method to Contextual Help Access - Dashboard -  Major Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12165_Contextual_Help_Access_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-12165";
            qTestUniqueId = "25966560";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                onlineHelp.AuthenticationDeviceManagement();
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
        /// Test Method to Contextual Help Access - Dashboard -  Minor Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12166_Contextual_Help_Access_Dashboard_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-12166";
            qTestUniqueId = "25966561";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                onlineHelp.AuthenticationDeviceManagement();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser - User Management from Landing Page Icon
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11854_Contextual_Help_Access_Help_Opens_in_Separate_Browser_User_Management_from_Landing_Page_Icon()
        {
            testCaseId = "TC-11854";
            qTestUniqueId = "25125767";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.UserManagementLandingPageContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser -Dashboard - System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11855_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-11855";
            qTestUniqueId = "25125768";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboardSystemConsumptionDetailReportContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser -Dashboard Dashboard_Top_Ten_Acc Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11856_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Top_Ten_Acc_Detail_Report()
        {
            testCaseId = "TC-11856";
            qTestUniqueId = "25125769";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboardTopTenDetailReportContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser -Dashboard Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11857_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11857";
            qTestUniqueId = "25125770";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CompleteReadingsContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser -Dashboard Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11858_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11858";
            qTestUniqueId = "25125771";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IncompleteReadingContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser -Dashboard Major Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11859_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11859";
            qTestUniqueId = "25125772";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.MajorReverseFlowContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser -Dashboard Continuous Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11860_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-11860";
            qTestUniqueId = "25125773";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ContinuousUsageHelpContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser -Dashboard Intermittent Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11861_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11861";
            qTestUniqueId = "25125774";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IntermittentUsageContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser -Dashboard Minor Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11862_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Dashboard_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11862";
            qTestUniqueId = "25125775";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.MinorReverseFlowContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11865_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Notification()
        {
            testCaseId = "TC-11865";
            qTestUniqueId = "25125778";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.NotificationHelpContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser Roles and Permissions
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11866_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Roles_Permissions()
        {
            testCaseId = "TC-11866";
            qTestUniqueId = "25125779";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.RolesPermissionsContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11867_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Landing_Page()
        {
            testCaseId = "TC-11867";
            qTestUniqueId = "25125780";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.LandingPageContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11868_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Dashboard()
        {
            testCaseId = "TC-11868";
            qTestUniqueId = "25125781";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboardContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11869_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Customer_Inquiry()
        {
            testCaseId = "TC-11869";
            qTestUniqueId = "25125782";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CustomerInquiryContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11870_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Import()
        {
            testCaseId = "TC-11870";
            qTestUniqueId = "25125783";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ImportContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser Export
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11871_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Export()
        {
            testCaseId = "TC-11871";
            qTestUniqueId = "25125784";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser Export History
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11872_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Export_History()
        {
            testCaseId = "TC-11872";
            qTestUniqueId = "25125785";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportHistoryContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11873_Contextual_Help_Access_Help_Opens_in_Separate_Browser_Device_Management()
        {
            testCaseId = "TC-11873";
            qTestUniqueId = "25125786";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DeviceManagementContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens in Separate Browser User Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11874_Contextual_Help_Access_Help_Opens_in_Separate_Browser_User_Management()
        {
            testCaseId = "TC-11874";
            qTestUniqueId = "25125787";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.UserManagementContextualHelp();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11875_Contextual_Help_Access_Help_Opens_Only_One_Instance_Dashboard()
        {
            testCaseId = "TC-11875";
            qTestUniqueId = "25125788";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboardContectualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - User Management from Landing Page Icon
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11876_Contextual_Help_Access_Help_Opens_Only_One_Instance_User_Management_Landing_Page()
        {
            testCaseId = "TC-11876";
            qTestUniqueId = "25125789";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.UserManagementLandingPageContectualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Top 10 Accounts Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11877_Contextual_Help_Access_Help_Opens_Only_One_Instance_Top_10_Accounts_Detail_Report()
        {
            testCaseId = "TC-11877";
            qTestUniqueId = "25125790";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboardTopTenDetailReportContectualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11878_Contextual_Help_Access_Help_Opens_Only_One_Instance_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11878";
            qTestUniqueId = "25125791";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CompleteReadingsContextualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11879_Contextual_Help_Access_Help_Opens_Only_One_Instance_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11879";
            qTestUniqueId = "25125792";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IncompleteReadingsContextualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Continuous Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11880_Contextual_Help_Access_Help_Opens_Only_One_Instance_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-11880";
            qTestUniqueId = "25125793";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ContinuousUsageContextualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Intermittent Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11881_Contextual_Help_Access_Help_Opens_Only_One_Instance_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11881";
            qTestUniqueId = "25125794";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IntermittentUsageContextualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Major Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11882_Contextual_Help_Access_Help_Opens_Only_One_Instance_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11882";
            qTestUniqueId = "25125795";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.MajorReverseFlowContextalHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Minor Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11883_Contextual_Help_Access_Help_Opens_Only_One_Instance_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11883";
            qTestUniqueId = "25125796";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.MinorReverseFlowContextualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11886_Contextual_Help_Access_Help_Opens_Only_One_Instance_Notification()
        {
            testCaseId = "TC-11886";
            qTestUniqueId = "25125799";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.NotificationContextualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Roles and Permissions
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11887_Contextual_Help_Access_Help_Opens_Only_One_Instance_Roles_Permissions()
        {
            testCaseId = "TC-11887";
            qTestUniqueId = "25125800";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.RolesPermissionsContextualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11888_Contextual_Help_Access_Help_Opens_Only_One_Instance_Landing_Page()
        {
            testCaseId = "TC-11888";
            qTestUniqueId = "25125801";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.LandingPageContextualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Dashboard - System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11889_Contextual_Help_Access_Help_Opens_Only_One_Instance_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-11889";
            qTestUniqueId = "25125802";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.SystemConsumptionDetailReportContextualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11890_Contextual_Help_Access_Help_Opens_Only_One_Instance_Customer_Inquiry()
        {
            testCaseId = "TC-11890";
            qTestUniqueId = "25125803";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CustomerInquiryContextualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11891_Contextual_Help_Access_Help_Opens_Only_One_Instance_Import()
        {
            testCaseId = "TC-11891";
            qTestUniqueId = "25125804";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ImportContextualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Export
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11892_Contextual_Help_Access_Help_Opens_Only_One_Instance_Export()
        {
            testCaseId = "TC-11892";
            qTestUniqueId = "25125805";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportContextualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Export History
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11893_Contextual_Help_Access_Help_Opens_Only_One_Instance_Export_History()
        {
            testCaseId = "TC-11893";
            qTestUniqueId = "25125806";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportHistoryContextualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11894_Contextual_Help_Access_Help_Opens_Only_One_Instance_Device_Management()
        {
            testCaseId = "TC-11894";
            qTestUniqueId = "25125807";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DeviceManagementContextualHelpOneInstance();
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
        /// Test Method to Contextual Help Access - Help Opens Only One Instance - User Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11895_Contextual_Help_Access_Help_Opens_Only_One_Instance_User_Management()
        {
            testCaseId = "TC-11895";
            qTestUniqueId = "25125808";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.UserManagementContextualHelpOneInstance();
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
        /// Test Method to Online Help - Search Function - Search Box
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11896_Online_Help_Search_Function_Search_Box()
        {
            testCaseId = "TC-11896";
            qTestUniqueId = "25156055";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.SearchBox();
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
        /// Test Method to Online Help - Search Function - Search Box Valid Topic
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11897_Online_Help_Search_Function_Search_Box_Valid_Topic()
        {
            testCaseId = "TC-11897";
            qTestUniqueId = "25156073";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.SearchBoxValidTopic();
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
        /// Test Method to Online Help - Search Function - Search Box Invalid Topic
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11898_Online_Help_Search_Function_Search_Box_Invalid_Topic()
        {
            testCaseId = "TC-11898";
            qTestUniqueId = "25156075";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.SearchBoxInvalidTopic();
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
        /// Test Method to Online Help - Quick Access Link - Welcome
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11899_Online_Help_Quick_Access_Link_Welcome()
        {
            testCaseId = "TC-11899";
            qTestUniqueId = "25156134";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuickAccessLinkWelcome();
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
        /// Test Method to Online Help - Quick Access Link - Welcome About Neptune 360
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11927_Online_Help_Quick_Access_Link_Welcome_About_Neptune_360()
        {
            testCaseId = "TC-11927";
            qTestUniqueId = "25218107";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuickAccessLinkWelcome();
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
        /// Test Method to Online Help - Quick Access Link - Welcome About the Help
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11928_Online_Help_Quick_Access_Link_Welcome_About_The_Help()
        {
            testCaseId = "TC-11928";
            qTestUniqueId = "25218108";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuickAccessLinkAboutTheHelp();
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
        /// Test Method to Online Help - Quick Access Link - Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11900_Online_Help_Quick_Access_Link_Dashboard()
        {
            testCaseId = "TC-11900";
            qTestUniqueId = "25156135";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuickAccessLinkDashboard();
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
        /// Test Method to Online Help - Quick Access Link - Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11901_Online_Help_Quick_Access_Link_Customer_Inquiry()
        {
            testCaseId = "TC-11901";
            qTestUniqueId = "25156136";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuickAccessLinkCustomerInquiry();
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
        /// Test Method to Online Help - Quick Access Link - Billing Services
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11902_Online_Help_Quick_Access_Link_Billing_Services()
        {
            testCaseId = "TC-11902";
            qTestUniqueId = "25156137";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuickAccessLinkBillingServices();
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
        /// Test Method to Online Help - Quick Access Link - Billing Services Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11931_Online_Help_Quick_Access_Link_Billing_Services_Import()
        {
            testCaseId = "TC-11931";
            qTestUniqueId = "25218751";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuickAccessLinkBillingServicesImport();
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
        /// Test Method to Online Help - Quick Access Link - Billing Services Export
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11932_Online_Help_Quick_Access_Link_Billing_Services_Export()
        {
            testCaseId = "TC-11932";
            qTestUniqueId = "25218752";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuickAccessLinkBillingServicesExport();
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
        /// Test Method to Online Help - Quick Access Link - Utility Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11903_Online_Help_Quick_Access_Link_Utility_Management()
        {
            testCaseId = "TC-11903";
            qTestUniqueId = "25156138";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuickAccessLinkUtilityManagement();
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
        /// Test Method to Online Help - Quick Access Link - Utility Management Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11933_Online_Help_Quick_Access_Link_Utility_Management_Device_Management()
        {
            testCaseId = "TC-11933";
            qTestUniqueId = "25218786";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                //onlineHelp.QuickAccessLinkUtilityManagementDeviceManagement();
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
        /// Test Method to Online Help - Splash Page Icon - Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11905_Online_Help_Splash_Page_Icon_Dashboard()
        {
            testCaseId = "TC-11905";
            qTestUniqueId = "25157196";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuickAccessLinkDashboard();
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
        /// Test Method to Online Help - Splash Page Icon - Billing Services
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11906_Online_Help_Splash_Page_Icon_Billing_Services()
        {
            testCaseId = "TC-11906";
            qTestUniqueId = "25157209";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuickAccessLinkBillingServices();
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
        /// Test Method to Online Help - Splash Page Icon - Notifications
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11907_Online_Help_Splash_Page_Icon_Notifications()
        {
            testCaseId = "TC-11907";
            qTestUniqueId = "25157219";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuickAccessLinkNotifications();
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
        /// Test Method to Online Help - Splash Page Icon - Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11924_Online_Help_Splash_Page_Icon_Customer_Inquiry()
        {
            testCaseId = "TC-11924";
            qTestUniqueId = "25215590";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.SplashPageIconCustInquiry();
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
        /// Test Method to Online Help - Splash Page Icon - User Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11925_Online_Help_Splash_Page_Icon_User_Management()
        {
            testCaseId = "TC-11925";
            qTestUniqueId = "25215591";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.SplashPageIconUserManagement();
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
        /// Test Method to Online Help - Splash Page Icon - Utility Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11926_Online_Help_Splash_Page_Icon_Utility_Management()
        {
            testCaseId = "TC-11926";
            qTestUniqueId = "25215592";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.SplashPageIconUtilityManagement();
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
        /// Test Method to Online Help - "?" Mark - Visible - Dashboard - Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11935_Online_Help_Question_Mark_Visible_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11935";
            qTestUniqueId = "25218960";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkCompleteReadingVisible();
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
        /// Test Method to Online Help - "?" Mark - Visible - Dashboard - Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11936_Online_Help_Question_Mark_Visible_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11936";
            qTestUniqueId = "25218961";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkIncompleteReadingVisible();
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
        /// Test Method to Online Help - "?" Mark - Visible - Dashboard - Continuous Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11937_Online_Help_Question_Mark_Visible_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-11937";
            qTestUniqueId = "25218962";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QusetionMarkContinuousUsageDetailReport();
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
        /// Test Method to Online Help - "?" Mark - Visible - Dashboard - Intermittent Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11938_Online_Help_Question_Mark_Visible_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11938";
            qTestUniqueId = "25218963";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleIntermittent();
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
        /// Test Method to Online Help - "?" Mark - Visible - Dashboard - Major Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11939_Online_Help_Question_Mark_Visible_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11939";
            qTestUniqueId = "25218964";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleMajorReverseFlow();
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
        /// Test Method to Online Help - "?" Mark - Visible - Dashboard - Minor Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11940_Online_Help_Question_Mark_Visible_Dashboard_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11940";
            qTestUniqueId = "25218965";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleMinorReverseFlow();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Dashboard - Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11943_Online_Help_Question_Mark_Accessible_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11943";
            qTestUniqueId = "25218968";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMArkCompleteReading();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Dashboard - Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11944_Online_Help_Question_Mark_Accessible_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11944";
            qTestUniqueId = "25218969";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkIncompleteReading();
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
        /// Test Method to Online Help - "?" Mark - Visible - Dashboard - Continuous Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11945_Online_Help_Question_Mark_Visible_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-11945";
            qTestUniqueId = "25218970";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QusetionMarkContinuousUsageDetailReport();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Dashboard - Intermittent Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11946_Online_Help_Question_Mark_Accessible_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11946";
            qTestUniqueId = "25218971";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkIntermittent();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Dashboard - Major Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11947_Online_Help_Question_Mark_Accessible_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11947";
            qTestUniqueId = "25218972";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkMajorReverseFlow();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Dashboard - Minor Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11948_Online_Help_Question_Mark_Accessible_Dashboard_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11948";
            qTestUniqueId = "25218973";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkMinorReverseFlow();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Dashboard Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11951_Online_Help_Question_Mark_Accessible_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11951";
            qTestUniqueId = "25218976";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMArkVisibleCompleteReading();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Dashboard Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11952_Online_Help_Question_Mark_Accessible_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11952";
            qTestUniqueId = "25218977";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleIncompleteReading();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Dashboard Continuous Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11953_Online_Help_Question_Mark_Accessible_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-11953";
            qTestUniqueId = "25218978";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QusetionMarkContinuousUsageDetailReport();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Dashboard Intermittent Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11954_Online_Help_Question_Mark_Accessible_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11954";
            qTestUniqueId = "25218979";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkIntermittent();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Dashboard Major Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11955_Online_Help_Question_Mark_Accessible_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11955";
            qTestUniqueId = "25218980";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleMajorReverseFlow();
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
        /// Test Method to Online Help - "?" Mark - Accessible - Dashboard Minor Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11956_Online_Help_Question_Mark_Accessible_Dashboard_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11956";
            qTestUniqueId = "25218981";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleMinorReverseFlow();
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
        /// Test Method to Online Help - "?" Mark - Accessible Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11959_Online_Help_Question_Mark_Accessible_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11959";
            qTestUniqueId = "25218984";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CompleteReadingRightArrow();
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
        /// Test Method to Online Help - "?" Mark - Menu Arrow - Dashboard - Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11959_Online_Help_Question_Mark_Menu_Arrow_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-11959";
            qTestUniqueId = "25218984";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CompleteReadingRightArrow();
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
        /// Test Method to Online Help - "?" Mark - Menu Arrow - Dashboard - Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11960_Online_Help_Question_Mark_Menu_Arrow_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-11960";
            qTestUniqueId = "25218985";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IncompleteCountRightArrow();
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
        /// Test Method to Online Help - "?" Mark - Menu Arrow - Dashboard - Continuous Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11961_Online_Help_Question_Mark_Menu_Arrow_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-11961";
            qTestUniqueId = "25218986";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ContinuousUsageRightArrow();
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
        /// Test Method to Online Help - "?" Mark - Menu Arrow - Dashboard - Intermittent  Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11962_Online_Help_Question_Mark_Menu_Arrow_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11962";
            qTestUniqueId = "25218987";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IntermittentRightArrow();
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
        /// Test Method to Online Help - "?" Mark - Menu Arrow - Major Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11963_Online_Help_Question_Mark_Menu_Arrow_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11963";
            qTestUniqueId = "25218988";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleMajorReverseFlow();
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
        /// Test Method to Online Help - "?" Mark - Menu Arrow - Minor Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_11964_Online_Help_Question_Mark_Menu_Arrow_Dashboard_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11964";
            qTestUniqueId = "25218989";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleMinorReverseFlow();
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
        /// Test Method to Contextual Help Access - Question Mark - Dashboard - Skipped Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15199_Contextual_Help_Access_Question_Mark_Dashboard_Skipped_Readings_Detail_Report()
        {
            testCaseId = "TC-15199";
            qTestUniqueId = "33529038";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.SkippedReadingQuestionMark();
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
        /// Test Method to Contextual Help Access - Question Mark - Dashboard - Normal Continuous Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15200_Contextual_Help_Access_Question_Mark_Dashboard_Normal_Continuous_Consumption_Detail_Report()
        {
            testCaseId = "TC-15200";
            qTestUniqueId = "33529079";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.NormalContinuousConsumptionHelpAccess();
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
        /// Test Method to Contextual Help Access - Question Mark - Dashboard - Warning Continuous Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15201_Contextual_Help_Access_Question_Mark_Dashboard_Warning_Continuous_Consumption_Detail_Report()
        {
            testCaseId = "TC-15201";
            qTestUniqueId = "33529160";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.WarningContinuousConsumptionHelpAccess();
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
        /// Test Method to Contextual Help Access - Question Mark - Dashboard -Critical Gateway Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15202_Contextual_Help_Access_Question_Mark_Dashboard_Critical_Gateway_Detail_Report()
        {
            testCaseId = "TC-15202";
            qTestUniqueId = "33529161";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CriticalGatewayHelpAccess();
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
        /// Test Method to Contextual Help Access - Question Mark - Dashboard -Warning Gateway Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15203_Contextual_Help_Access_Question_Mark_Dashboard_Warning_Gateway_Detail_Report()
        {
            testCaseId = "TC-15203";
            qTestUniqueId = "33529162";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.WarningGatewayHelpAccess();
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
        /// Test Method to Contextual Help Access - Question Mark - Dashboard -Normal  Gateway Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15204_Contextual_Help_Access_Question_Mark_Dashboard_Normal_Gateway_Detail_Report()
        {
            testCaseId = "TC-15204";
            qTestUniqueId = "33529164";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.NormalGatewayHelpAccess();
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
        /// Test Method to Contextual Help Access - Question Mark - Dashboard Route Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15205_Contextual_Help_Access_Question_Mark_Dashboard_Route_Management()
        {
            testCaseId = "TC-15205";
            qTestUniqueId = "33529165";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleRouteManagement();
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
        /// Test Method to Contextual Help Access - Question Mark -Alert Configuration
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15206_Contextual_Help_Access_Question_Mark_Alert_Configuration()
        {
            testCaseId = "TC-15206";
            qTestUniqueId = "33529167";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkVisibleAlertConfiguration();
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
        /// Test Method to Contextual Help Access Print Help Documents - Dashboard
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12194_Contextual_Help_Access_Print_Help_Documents_Dashboard()
        {
            testCaseId = "TC-12194";
            qTestUniqueId = "26058310";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.printHelpDocumentsDashboard();
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
        /// Test Method to Contextual Help Access Print Help Documents - User Management from Landing Page Icon
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12195_Contextual_Help_Access_Print_Help_Documents_User_Management_from_Landing_Page_Icon()
        {
            testCaseId = "TC-12195";
            qTestUniqueId = "26058311";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.printHelpDocumentsUserManagementLandingPage();
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
        /// Test Method to Contextual Help Access Print Help Documents - Dashboard - Top 10 Accounts Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12196_Contextual_Help_Access_Print_Help_Documents_Dashboard_Top_10_Accounts_Detail_Report()
        {
            testCaseId = "TC-12196";
            qTestUniqueId = "26058312";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.printHelpDocumentsTop10Accounts();
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
        /// Test Method to Contextual Help Access Print Help Documents - Dashboard - Complete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12197_Contextual_Help_Access_Print_Help_Documents_Dashboard_Complete_Readings_Detail_Report()
        {
            testCaseId = "TC-12197";
            qTestUniqueId = "26058313";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.printHelpDocumentsCompleteReadings();
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
        /// Test Method to Contextual Help Access Print Help Documents - Dashboard - Incomplete Readings Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12198_Contextual_Help_Access_Print_Help_Documents_Dashboard_Incomplete_Readings_Detail_Report()
        {
            testCaseId = "TC-12198";
            qTestUniqueId = "26058314";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IncompleteCountPrintHelp();
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
        /// Test Method to Contextual Help Access Print Help Documents - Dashboard - Continuous Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12199_Contextual_Help_Access_Print_Help_Documents_Dashboard_Continuous_Usage_Detail_Report()
        {
            testCaseId = "TC-12199";
            qTestUniqueId = "26058315";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ConitnousUsagePrintHelp();
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
        /// Test Method to Contextual Help Access Print Help Documents - Dashboard - Intermittent  Usage Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12200_Contextual_Help_Access_Print_Help_Documents_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-12200";
            qTestUniqueId = "26058316";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.IntermittentUsagePrintHelp();
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
        /// Test Method to Contextual Help Access Print Help Documents - Dashboard - Major Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12201_Contextual_Help_Access_Print_Help_Documents_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-12201";
            qTestUniqueId = "26058317";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.MajorReverseFlowPrintHelp();
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
        /// Test Method to Contextual Help Access Print Help Documents - Dashboard - Minor Reverse Flow Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12202_Contextual_Help_Access_Print_Help_Documents_Dashboard_Minor_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-12202";
            qTestUniqueId = "26058318";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.MinorReverseFlowPrintHelp();
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
        /// Test Method to Contextual Help Access Print Help Documents Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12205_Contextual_Help_Access_Print_Help_Documents_Notification()
        {
            testCaseId = "TC-12205";
            qTestUniqueId = "26058321";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.NotificationPrintHelp();
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
        /// Test Method to Contextual Help Access Print Help Documents Roles and Permissions
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_12206_Contextual_Help_Access_Print_Help_Documents_Roles_and_Permissions()
        {
            testCaseId = "TC-12206";
            qTestUniqueId = "26058322";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.RolesPermissionsPrintHelp();
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
        /// Test Method to Contextual Help Access Print Help Documents Landing Page
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12207_Contextual_Help_Access_Print_Help_Documents_Landing_Page()
        {
            testCaseId = "TC-12207";
            qTestUniqueId = "26058323";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.LandingPagePrintHelp();
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
        /// Test Method to Contextual Help Access Print Help Documents System Consumption Detail Report
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12208_Contextual_Help_Access_Print_Help_Documents_Dashboard_System_Consumption_Detail_Report()
        {
            testCaseId = "TC-12208";
            qTestUniqueId = "26058324";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DashboarDetailReportPrintHelp();
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
        /// Test Method to Contextual Help Access Print Help Documents Customer Inquiry
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12209_Contextual_Help_Access_Print_Help_Documents_Customer_Inquiry()
        {
            testCaseId = "TC-12209";
            qTestUniqueId = "26058325";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.CustomerInquiryPrintHelp();
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
        /// Test Method to Contextual Help Access Print Help Documents Import
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12210_Contextual_Help_Access_Print_Help_Documents_Import()
        {
            testCaseId = "TC-12210";
            qTestUniqueId = "26058326";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ImportPrintHelp();
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
        /// Test Method to Contextual Help Access Print Help Documents Export
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12211_Contextual_Help_Access_Print_Help_Documents_Export()
        {
            testCaseId = "TC-12211";
            qTestUniqueId = "26058327";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportPrintHelp();
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
        /// Test Method to Contextual Help Access Print Help Documents Export History
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12212_Contextual_Help_Access_Print_Help_Documents_Export_History()
        {
            testCaseId = "TC-12212";
            qTestUniqueId = "26058328";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.ExportHistoryPrintHelp();
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
        /// Test Method to Contextual Help Access Print Help Documents Device Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12213_Contextual_Help_Access_Print_Help_Documents_Device_Management()
        {
            testCaseId = "TC-12213";
            qTestUniqueId = "26058329";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.DeviceManagementPrintHelp();
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
        /// Test Method to Contextual Help Access Print Help Documents User  Management
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_12214_Contextual_Help_Access_Print_Help_Documents_User_Management()
        {
            testCaseId = "TC-12214";
            qTestUniqueId = "26058330";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.userManagementPrintHelp();
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
        /// Test Method to Contextual Help Access Question Mark - Reports
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15207_Contextual_Help_Access_Question_Mark_Reports()
        {
            testCaseId = "TC-15207";
            qTestUniqueId = "26058330";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.QuestionMarkReports();
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
        /// Test Method to Contextual Help Access Question Mark - Alert Notification
        /// </summary>
        /// 
        [Category("OnlineHelp")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15208_Contextual_Help_Access_Question_Mark_Alert_Notification()
        {
            testCaseId = "TC-15208";
            qTestUniqueId = "33529169";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToOnlineHelp(url, userName, password);
                onlineHelp.NotificationHelpAccess();
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
