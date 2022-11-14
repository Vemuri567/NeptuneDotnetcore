using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    class SmokeTest : TestBaseTemplate
    {

        /// <summary>
        /// Test Method to Platform Management_Device Activations_Access
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18346_Platform_Management_Device_Activations_Access()
        {
            testCaseId = "TC-18346";
            qTestUniqueId = "39718755";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftDeviceActivations(url, userName, password);
                deviceManagementPage.ValidateDeviceActivation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Group_Management_Access
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18347_GROUPS_Group_Management_Access()
        {
            testCaseId = "TC-18347";
            qTestUniqueId = "39666572";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupSelect();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Settings_Access
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18348_Utility_Management_Settings_Access()
        {
            testCaseId = "TC-18348";
            qTestUniqueId = "39718758";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUtilitySettings(url, userName, password);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group_Select_List of Endpoints_Display
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18349_GROUPS_View_Existing_List_Group_Select_List_of_Endpoints_Display()
        {
            testCaseId = "TC-18349";
            qTestUniqueId = "39718758";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupSelect();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Handheld Management_Handheld Settings_Access
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_18350_Handheld_Management_Handheld_Settings_Access()
        {
            testCaseId = "TC-18350";
            qTestUniqueId = "39666575";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateHandheldManagement(url, userName, password);
                handheldManagementPage.ValidateHandheldManagementPageDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Readings Widget_Complete_First in Display Rotation
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18351_Dashboard_Readings_Widget_Complete_First_in_Display_Rotation()
        {
            testCaseId = "TC-18351";
            qTestUniqueId = "39666576";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Readings Widget_Incomplete_Second in Display Rotation
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18352_Dashboard_Readings_Widget_Incomplete_Second_in_Display_Rotation()
        {
            testCaseId = "TC-18352";
            qTestUniqueId = "39666577";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Readings Widget_Skipped_Last in Display Rotation
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18353_Dashboard_Readings_Widget_Skipped_Last_in_Display_Rotation()
        {
            testCaseId = "TC-18353";
            qTestUniqueId = "39666578";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Received via AMR Widget_First in Display Rotation
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18354_Dashboard_Received_via_AMR_Widget_First_in_Display_Rotation()
        {
            testCaseId = "TC-18354";
            qTestUniqueId = "39666580";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedKPIviaAMR();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Received via AMI Widget_Second in Display Rotation
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18355_Dashboard_Received_via_AMI_Widget_Second_in_Display_Rotation()
        {
            testCaseId = "TC-18355";
            qTestUniqueId = "39666580";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedKPIviaAMI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Not Received Widget_Last in Display Rotation
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18356_Dashboard_Not_Received_Widget_Last_in_Display_Rotation()
        {
            testCaseId = "TC-18356";
            qTestUniqueId = "39666582";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNotReceivedWidgetLocation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Reverse Flow Widget_Major_First in Display Rotation
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18357_Dashboard_Reverse_Flow_Widget_Major_First_in_Display_Rotation()
        {
            testCaseId = "TC-18357";
            qTestUniqueId = "39666583";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMajorReverseFlowDispaysLocation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Reverse Flow Widget_Minor_First in Display Rotation
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18358_Dashboard_Reverse_Flow_Widget_Minor_First_in_Display_Rotation()
        {
            testCaseId = "TC-18358";
            qTestUniqueId = "39666584";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMinorReverseFlowDispaysLocation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Widget_Critical_First in Display Rotation
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18359_Dashboard_Gateway_Widget_Critical_First_in_Display_Rotation()
        {
            testCaseId = "TC-18359";
            qTestUniqueId = "39666585";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateGatewayCriticalDispaysLocation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Widget_Warning_Second in Display Rotation
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18360_Dashboard_Gateway_Widget_Warning_Second_in_Display_Rotation()
        {
            testCaseId = "TC-18360";
            qTestUniqueId = "39666587";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateGatewayWarningDispaysLocation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Widget_Normal_Last in Display Rotation
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18361_Dashboard_Gateway_Widget_Normal_Last_in_Display_Rotation()
        {
            testCaseId = "TC-18361";
            qTestUniqueId = "39666588";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateGatewayNormalDispaysLocation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Invalid Readings_Report Loads
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18362_Reports_Invalid_Readings_Report_Loads()
        {
            testCaseId = "TC-18362";
            qTestUniqueId = "39670416";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReportsPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Report Landing Page_Mach 10 Battery
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18363_Reports_Landing_Page_Mach_10_Battery()
        {
            testCaseId = "TC-18363";
            qTestUniqueId = "39670417";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10BatteryPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        [Category("SmokeTests")]
        [Test]
        public void TC_18370_Contextual_Help_Access_Question_Mark_Dashboard_Skipped_Readings_Detail_Report()
        {
            testCaseId = "TC-18370";
            qTestUniqueId = "39699483";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Dashboard - Received via AMR Detail Report
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18371_Contextual_Help_Access_Question_Mark_Dashboard_Received_via_AMR_Detail_Report()
        {
            testCaseId = "TC-18371";
            qTestUniqueId = "39699485";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateAMRReportHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Dashboard - Received via AMI Detail Report
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18372_Contextual_Help_Access_Question_Mark_Dashboard_Received_via_AMI_Detail_Report()
        {
            testCaseId = "TC-18372";
            qTestUniqueId = "39699490";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateAMIReportHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Dashboard - Not Received Detail Report
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18373_Contextual_Help_Access_Question_Mark_Dashboard_Not_Received_Detail_Report()
        {
            testCaseId = "TC-18373";
            qTestUniqueId = "39699505";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNotReceivedHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        [Category("SmokeTests")]
        [Test]
        public void TC_18374_Contextual_Help_Access_Question_Mark_Dashboard_Warning_Continuous_Consumption_Detail_Report()
        {
            testCaseId = "TC-18374";
            qTestUniqueId = "39699507";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        [Category("SmokeTests")]
        [Test]
        public void TC_18375_Contextual_Help_Access_Question_Mark_Dashboard_Warning_Continuous_Consumption_Detail_Report()
        {
            testCaseId = "TC-18375";
            qTestUniqueId = "39699509";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Dashboard - Critical Gateway Detail Report
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18376_Contextual_Help_Access_Question_Mark_Dashboard_Critical_Gateway_Detail_Report()
        {
            testCaseId = "TC-18376";
            qTestUniqueId = "39699511";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCrticalGatewayHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Dashboard - Warning Gateway Detail Report
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18377_Contextual_Help_Access_Question_Mark_Dashboard_Warning_Gateway_Detail_Report()
        {
            testCaseId = "TC-18377";
            qTestUniqueId = "39699514";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningGatewayHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Dashboard - Normal Gateway Detail Report
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18378_Contextual_Help_Access_Question_Mark_Dashboard_Normal_Gateway_Detail_Report()
        {
            testCaseId = "TC-18378";
            qTestUniqueId = "39699516";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalGatewayHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Alert Notifications
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18379_Contextual_Help_Access_Question_Mark_Alert_Notifications()
        {
            testCaseId = "TC-18379";
            qTestUniqueId = "39701233";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertNotification(url, userName, password);
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - SDK Access
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18380_Contextual_Help_Access_Question_Mark_SDK_Access()
        {
            testCaseId = "TC-18380";
            qTestUniqueId = "39701252";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToSDKAccess(url, userName, password);
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Alert Configuration
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18385_Contextual_Help_Access_Question_Mark_Alert_Configuration()
        {
            testCaseId = "TC-18385";
            qTestUniqueId = "39701378";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Route Assignments
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_18386_Contextual_Help_Access_Question_Mark_Route_Assignments()
        {
            testCaseId = "TC-18386";
            qTestUniqueId = "39701379";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateRouteAssignmentsPage();
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Handhelds
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_18387_Contextual_Help_Access_Question_Mark_Handhelds()
        {
            testCaseId = "TC-18387";
            qTestUniqueId = "39701380";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateHandheldManagement(url, userName, password);
                handheldManagementPage.ValidateHandheldManagementPageDisplayed();
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Handhelds
        /// </summary>
        [Category("SmokeTests-Obsolete")]
        [Test]
        public void TC_18388_Contextual_Help_Access_Question_Mark_Handhelds()
        {
            testCaseId = "TC-18388";
            qTestUniqueId = "39701381";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateHandheldManagement(url, userName, password);
                handheldManagementPage.ValidateHandheldSettingsPageDisplayed();
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to SDK Access_Page Title
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_16785_SDK_Access_Page_Title()
        {
            testCaseId = "TC-16785";
            qTestUniqueId = "35810738";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToSDKAccess(url, userName, password);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to SDK Access_Page Title
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_16533_SDK_Access_Page_Title()
        {
            testCaseId = "TC-16533";
            qTestUniqueId = "35557779";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                rolesPermissons.ValidateUsagePlansLeftNav();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Partner Management_Page Title_Display
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_16330_Partner_Management_Page_Title_Display()
        {
            testCaseId = "TC-16330";
            qTestUniqueId = "35431924";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                rolesPermissons.ValidateViewPartnerManagementPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to API Deployment_Title_Display
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_15883_API_Deployment_Title_Display()
        {
            testCaseId = "TC-15883";
            qTestUniqueId = "34748450";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                rolesPermissons.ValidateAPIDeploymentPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Consumption Widget_Critical_First in Display Rotation
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_13889_Dashboard_Consumption_Widget_Critical_First_in_Display_Rotation()
        {
            testCaseId = "TC-13889";
            qTestUniqueId = "30023558";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCrticalConsumptionKPIDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Consumption Widget_Warning_Second in Display Rotation
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_13890_Dashboard_Consumption_Widget_Warning_Second_in_Display_Rotation()
        {
            testCaseId = "TC-13890";
            qTestUniqueId = "30023559";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionKPIDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Consumption Widget_Normal_Third in Display Rotation
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_13891_Dashboard_Consumption_Widget_Normal_Third_in_Display_Rotation()
        {
            testCaseId = "TC-13891";
            qTestUniqueId = "30023560";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionKPIDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Consumption Widget_Intermittent_Last in Display Rotation
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_13892_Dashboard_Consumption_Widget_Intermittent_Last_in_Display_Rotation()
        {
            testCaseId = "TC-13892";
            qTestUniqueId = "30023561";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentConsumptionKPIDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Report Landing Page_Comments
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_14276_Reports_Report_Landing_Page_Comments()
        {
            testCaseId = "TC-14276";
            qTestUniqueId = "31067116";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateComments();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Comments_Report Loads
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_14510_Reports_Comments_Report_Loads()
        {
            testCaseId = "TC-14510";
            qTestUniqueId = "31997101";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Report Landing Page_Coded Notes
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_14508_Reports_Report_Landing_Page_Coded_Notes()
        {
            testCaseId = "TC-14508";
            qTestUniqueId = "31997091";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotes();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Coded Notes_Report Loads
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_14509_Reports_Coded_Notes_Report_Loads()
        {
            testCaseId = "TC-14509";
            qTestUniqueId = "31997100";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Report Landing Page_Invalid Readings
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_14275_Reports_Report_Landing_Page_Invalid_Readings()
        {
            testCaseId = "TC-14275";
            qTestUniqueId = "31067115";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsReport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Reports_Mach 10 Battery Status_Report Details Display
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_14167_Reports_Mach_10_Battery_Status_Report_Details_Display()
        {
            testCaseId = "TC-14167";
            qTestUniqueId = "30516663";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10BatteryStatusPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Endpoints_Days of No Flow (AMR)_Display
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_15636_Reports_Endpoints_Days_of_No_Flow_AMR_Display()
        {
            testCaseId = "TC-15636";
            qTestUniqueId = "34389114";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowAMR();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Reports_Endpoints_Days of Consumption (AMR)_Display
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_15637_Reports_Endpoints_Days_of_Consumption_AMR_Display()
        {
            testCaseId = "TC-15637";
            qTestUniqueId = "34389116";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMR();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Title
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_15643_Report_Days_of_No_Flow_AMR_Detailed_Report_Title()
        {
            testCaseId = "TC-15643";
            qTestUniqueId = "34414424";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Title
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_15846_Report_Days_of_Consumption_AMR_Detailed_Report_Title()
        {
            testCaseId = "TC-15846";
            qTestUniqueId = "34544683";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        [Category("SmokeTests")]
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
                home.NavigateToHome(url, userName, password);
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Dashboard Page
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_11834_Contextual_Help_Access_Question_Mark_Dashboard_Page()
        {
            testCaseId = "TC-11834";
            qTestUniqueId = "25125746";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Dashboard - System Consumption Detail Report
        /// </summary>
        [Category("SmokeTests")]
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
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateDetailReportPage();
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Dashboard - Top 10 Accounts Detail Report
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_11836_Contextual_Help_Access_Question_Mark_Dashboard_Top_10_Accounts_Detail_Report()
        {
            testCaseId = "TC-11836";
            qTestUniqueId = "25125749";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTop10AccountsDetailReport();
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        [Category("SmokeTests")]
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
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        [Category("SmokeTests")]
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
                home.NavigateToLftNavImportManagement(url, userName, password);
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        [Category("SmokeTests")]
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
                home.NavigateToLftNavExportManagement(url, userName, password);
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        [Category("SmokeTests")]
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
                home.NavigateToLftNavExportHistory(url, userName, password);
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        [Category("SmokeTests")]
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
                home.NavigateToLftUtilityDeviceManagement(url, userName, password);
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        [Category("SmokeTests")]
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
                home.NavigateLanPageUserManagement(url, userName, password);
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        [Category("SmokeTests")]
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
                home.NavigateToLftNavRolesPermissions(url, userName, password);
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        [Category("SmokeTests")]
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
                home.NavigateToLftEmailNotifications(url, userName, password);
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - User Management from Landing Page Icon
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_11845_Contextual_Help_Access_Question_Mark_User_Management_from_Landing_Page_Icon()
        {
            testCaseId = "TC-11845";
            qTestUniqueId = "25125758";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Dashboard - Complete Readings Detail Report
        /// </summary>
        [Category("SmokeTests")]
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
                home.NavigateDashboardPage(url, userName, password);
                //dashBoard.ValidateCompleteCount();
                dashBoard.ValidateCompleteReadingHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Dashboard - Incomplete Readings Detail Report
        /// </summary>
        [Category("OnlineHelp")]
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
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteCountReading();
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Dashboard - Critical Continuous Consumption Detail Report
        /// </summary>
        [Category("SmokeTests")]
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
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCrticalGatewayHelp();
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Dashboard - Intermittent Usage Detail Report
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_11849_Contextual_Help_Access_Question_Mark_Dashboard_Intermittent_Usage_Detail_Report()
        {
            testCaseId = "TC-11849";
            qTestUniqueId = "25125762";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentConsumptionCountPage();
                dashBoard.ValidateHelp();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Contextual Help Access - Question Mark - Dashboard - Major Reverse Flow Detail Report
        /// </summary>
        [Category("SmokeTests")]
        [Test]
        public void TC_11850_Contextual_Help_Access_Question_Mark_Dashboard_Major_Reverse_Flow_Detail_Report()
        {
            testCaseId = "TC-11850";
            qTestUniqueId = "25125763";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMajorReverseFlowTitle();
                dashBoard.ValidateHelp();
                home.UserLogOut();
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
