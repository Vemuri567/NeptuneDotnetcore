using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Neptune360UIAutomation
{
    public class Dashboard : TestBaseTemplate
    {
        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10353_Dashboards_System_Consumption_Detailed_Report_Display()
        {
            testCaseId = "TC-10353";
            qTestUniqueId = "24893185";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateConsumptionDetaiedReport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Consumption Summary_Not Displayed
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10354_Dashboards_System_Consumption_Detailed_Report_Consumption_Summary_Not_Displayed()
        {
            testCaseId = "TC-10354";
            qTestUniqueId = "24893185";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateConsumptionDetaiedReportNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Trend Option_Not Displayed
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10355_Dashboards_System_Consumption_Detailed_Report_Trend_Option_Not_Displayed()
        {
            testCaseId = "TC-10355";
            qTestUniqueId = "24893187";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTrendOptionNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Meter Type Filter_Not Displayed
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10356_Dashboards_System_Consumption_Detailed_Report_Meter_Type_Filter_Not_Displayed()
        {
            testCaseId = "TC-10356";
            qTestUniqueId = "24893188";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMeterTypeFilterNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Grid View
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10358_Dashboards_System_Consumption_Detailed_Report_Grid_View()
        {
            testCaseId = "TC-10358";
            qTestUniqueId = "24893190";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateGridView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Map View
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10359_Dashboards_System_Consumption_Detailed_Report_Map_View()
        {
            testCaseId = "TC-10359";
            qTestUniqueId = "24893191";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMapView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Map View_Yellow Label
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10361_Dashboards_System_Consumption_Detailed_Report_Map_View_Yellow_Label()
        {
            testCaseId = "TC-10361";
            qTestUniqueId = "24893194";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTwentyConsumption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Map View_Light Green Label
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10362_Dashboards_System_Consumption_Detailed_Report_Map_View_Light_Green_Label()
        {
            testCaseId = "TC-10362";
            qTestUniqueId = "24893196";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMiddleSixtyConsumption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Map View_Orange Label
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10363_Dashboards_System_Consumption_Detailed_Report_Map_View_Orange_Label()
        {
            testCaseId = "TC-10363";
            qTestUniqueId = "24893291";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateBottomTwentyConsumption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Grid View_No Consumption Data
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10367_Dashboards_System_Consumption_Detailed_Report_Grid_View_No_Consumption_Data()
        {
            testCaseId = "TC-10367";
            qTestUniqueId = "24893295";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.SwitchToUtility(utilityName);
                dashBoard.ValidateGridViewNoCosnumptionData();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Widget_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10516_Dashboards_System_Consumption_Widget_Display()
        {
            testCaseId = "TC-10516";
            qTestUniqueId = "24914290";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSystemConsumptionWidget();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report 
        /// _Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10517_Dashboards_System_Consumption_Detailed_Report_Link_Display()
        {
            testCaseId = "TC-10517";
            qTestUniqueId = "24914292";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateDetailedReportLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_No Consumption Data_Message Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10518_Dashboards_System_Consumption_No_Consumption_Data_Message_Display()
        {
            testCaseId = "TC-10518";
            qTestUniqueId = "24914294";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.SwitchToUtility(utilityName);
                dashBoard.ValidateSystemConsNoData();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Map Widget_Search_Available
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10532_Dashboard_Map_Widget_Search_Available()
        {
            testCaseId = "TC-10532";
            qTestUniqueId = "24915181";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSearchInMap();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Map Widget_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10537_Dashboards_Map_Widget_Display()
        {
            testCaseId = "TC-10537";
            qTestUniqueId = "24915293";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMapWidget();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Map Widget_Styles Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10538_Dashboards_Map_Widget_Styles_Display()
        {
            testCaseId = "TC-10538";
            qTestUniqueId = "24915295";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMapStyles();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Map Widget_Expand
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10539_Dashboards_Map_Widget_Expand()
        {
            testCaseId = "TC-10539";
            qTestUniqueId = "24915295";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMapPlusWidget();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Map Widget_Expand
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10540_Dashboards_Map_Widget_Collapse()
        {
            testCaseId = "TC-10540";
            qTestUniqueId = "24915297";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMapMinusWidget();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Map Widget_No Data
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10543_Dashboards_Map_Widget_No_Data()
        {
            testCaseId = "TC-10543";
            qTestUniqueId = "24915301";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWidgetNoData();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters KPI_Found_Detailed Report_Back to KPI
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_11693_Dashboards_Meters_KPI_Found_Detailed_Report_Back_to_KPI()
        {
            testCaseId = "TC-11693";
            qTestUniqueId = "24930170";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateBackToKPIDashboard();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Title_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Category("SmokeTests")]
        [Test]
        public void TC_10232_Dashboard_Title_Display()
        {
            testCaseId = "TC-10232";
            qTestUniqueId = "24857271";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateDashboardTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Consumption Widget_Label Verbiage
        /// </summary>
        [Category("Dashboard")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10233_Dashboard_Consumption_Widget_Label_Verbiage()
        {
            testCaseId = "TC-10233";
            qTestUniqueId = "24857282";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSystemConsumption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Major Minor Reverse Widget_Label Verbiage
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Category("SmokeTests")]
        [Test]
        public void TC_10238_Dashboard_Major_Minor_Reverse_Widget_Label_Verbiage()
        {
            testCaseId = "TC-10238";
            qTestUniqueId = "24857318";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidatereverseFlowWidget();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_KPI Widgets_Location
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10240_Dashboards_KPI_Widgets_Location()
        {
            testCaseId = "TC-10240";
            qTestUniqueId = "24857334";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidatekpiWidget();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_KPI Widgets_Individual detail
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10241_Dashboards_KPI_Widgets_Individual_detail()
        {
            testCaseId = "TC-10241";
            qTestUniqueId = "24857337";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidatekpiIndividualWidgetDetails();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_KPI Widget_Subcatergory Switching
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10243_Dashboards_KPI_Widget_Subcatergory_Switching()
        {
            testCaseId = "TC-10243";
            qTestUniqueId = "24857355";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteReadingsKPIArrows();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Major Reverse Flow_Detailed Report_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10245_Dashboards_Reverse_Flow_KPI_Major_Reverse_Flow_Detailed_Report_Display()
        {
            testCaseId = "TC-10245";
            qTestUniqueId = "24857422";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMajorReverseFlowCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Major Reverse Flow_Detailed Report_Title
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10248_Dashboards_Reverse_Flow_KPI_Major_Reverse_Flow_Detailed_Report_Title()
        {
            testCaseId = "TC-10248";
            qTestUniqueId = "24857476";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMajorReverseFlowTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Major Reverse Flow_Details Report_Default Grid View
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10250_Dashboards_Reverse_Flow_KPI_Major_Reverse_Flow_Details_Report_Default_Grid_View()
        {
            testCaseId = "TC-10250";
            qTestUniqueId = "24857483";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateDefaultGridView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Major Reverse Flow_Details Report_Export PDF_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10252_Dashboards_Reverse_Flow_KPI_Major_Reverse_Flow_Details_Report_Export_PDF_Display()
        {
            testCaseId = "TC-10252";
            qTestUniqueId = "24857817";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateExportPDFMajor();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Major Reverse Flow_Details Report_Export Excel_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10253_Dashboards_Reverse_Flow_KPI_Major_Reverse_Flow_Details_Report_Export_Excel_Display()
        {
            testCaseId = "TC-10253";
            qTestUniqueId = "24857840";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateExportExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Major Reverse Flow_Detailed Report_Back to KPI
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10256_Dashboards_Reverse_Flow_KPI_Major_Reverse_Flow_Detailed_Report_Back_to_KPI()
        {
            testCaseId = "TC-10256";
            qTestUniqueId = "24857852";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Minor Reverse Flow_Detailed Report_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10257_Dashboards_Reverse_Flow_KPI_Minor_Reverse_Flow_Detailed_Report_Display()
        {
            testCaseId = "TC-10257";
            qTestUniqueId = "24857879";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReverseFlowCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Minor Reverse Flow_Detailed Report_Title
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10260_Dashboards_Reverse_Flow_KPI_Minor_Reverse_Flow_Detailed_Report_Title()
        {
            testCaseId = "TC-10260";
            qTestUniqueId = "24857899";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReverseFlowTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Minor Reverse Flow_Details Report_Default Grid View
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10262_Dashboards_Reverse_Flow_KPI_Minor_Reverse_Flow_Details_Report_Default_Grid_View()
        {
            testCaseId = "TC-10262";
            qTestUniqueId = "24857903";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMinorDefaultGridView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Minor Reverse Flow_Details Report_Map View
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10263_Dashboards_Reverse_Flow_KPI_Minor_Reverse_Flow_Details_Report_Map_View()
        {
            testCaseId = "TC-10263";
            qTestUniqueId = "24857912";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMinorMapView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Minor Reverse Flow_Details Report_Export PDF_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10264_Dashboards_Reverse_Flow_KPI_Minor_Reverse_Flow_Details_Report_Export_PDF_Display()
        {
            testCaseId = "TC-10264";
            qTestUniqueId = "24857913";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateExportPDFMinor();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Minor Reverse Flow_Details Report_Export Excel_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10265_Dashboards_Reverse_Flow_KPI_Minor_Reverse_Flow_Details_Report_Export_Excel_Display()
        {
            testCaseId = "TC-10265";
            qTestUniqueId = "24857917";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateExportExcelMinor();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Minor Reverse Flow_Detailed Report_Back to KPI
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10267_Dashboards_Reverse_Flow_KPI_Minor_Reverse_Flow_Detailed_Report_Back_to_KPI()
        {
            testCaseId = "TC-10267";
            qTestUniqueId = "24857928";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateBakToKPIMinor();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Complete_Detailed Report_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10281_Dashboards_Readings_KPI_Complete_Detailed_Report_Display()
        {
            testCaseId = "TC-10281";
            qTestUniqueId = "24869812";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Complete_Detailed Report_Date Range_Not Accessible
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10283_Dashboards_Readings_KPI_Complete_Detailed_Report_Date_Range_Not_Accessible()
        {
            testCaseId = "TC-10283";
            qTestUniqueId = "24869816";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteCountDateRange();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Complete_Detailed Report_Date Range_Not Accessible
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10284_Dashboards_Readings_KPI_Complete_Detailed_Report_Title()
        {
            testCaseId = "TC-10284";
            qTestUniqueId = "24869817";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Complete_Detailed Report_Map View
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10286_Dashboards_Readings_KPI_Complete_Detailed_Report_Map_View()
        {
            testCaseId = "TC-10286";
            qTestUniqueId = "24869819";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteCountMap();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Complete_Detailed Report_Default Grid View
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10287_Dashboards_Readings_KPI_Complete_Detailed_Report_Default_Grid_View()
        {
            testCaseId = "TC-10287";
            qTestUniqueId = "24869820";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteCountGridView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Complete_Detailed Report_Export PDF_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10288_Dashboards_Readings_KPI_Complete_Detailed_Report_Export_PDF_Display()
        {
            testCaseId = "TC-10288";
            qTestUniqueId = "24869821";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteCountExportPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Complete_Detailed Report_Export Excel_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10289_Dashboards_Readings_KPI_Complete_Detailed_Report_Export_Excel_Display()
        {
            testCaseId = "TC-10289";
            qTestUniqueId = "24869822";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteCountExportExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Complete_Detailed Report_Back to KPI
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10292_Dashboards_Readings_KPI_Complete_Detailed_Report_Back_to_KPI()
        {
            testCaseId = "TC-10292";
            qTestUniqueId = "24869965";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Incomplete_Detailed Report_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10293_Dashboards_Readings_KPI_Incomplete_Detailed_Report_Display()
        {
            testCaseId = "TC-10293";
            qTestUniqueId = "24869971";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteCountReading();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Incomplete_Detailed Report_Date Range_Not Accessible
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10295_Dashboards_Readings_KPI_Incomplete_Detailed_Report_Date_Range_Not_Accessible()
        {
            testCaseId = "TC-10295";
            qTestUniqueId = "24870352";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteCountReadingDateRange();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Incomplete_Detailed Report_Title
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10296_Dashboards_Readings_KPI_Incomplete_Detailed_Report_Title()
        {
            testCaseId = "TC-10296";
            qTestUniqueId = "24870353";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteCountReading();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Incomplete_Detailed Report_Default Grid View
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10298_Dashboards_Readings_KPI_Incomplete_Detailed_Report_Default_Grid_View()
        {
            testCaseId = "TC-10298";
            qTestUniqueId = "24870355";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteCountReadingGridView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Incomplete_Detailed Report_Export PDF_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10300_Dashboards_Readings_KPI_Incomplete_Detailed_Report_Export_PDF_Display()
        {
            testCaseId = "TC-10300";
            qTestUniqueId = "24872330";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteCountExportPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Incomplete_Detailed Report_Export Excel_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10301_Dashboards_Readings_KPI_Incomplete_Detailed_Report_Export_Excel_Display()
        {
            testCaseId = "TC-10301";
            qTestUniqueId = "24872332";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteCountExportExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Incomplete_Detailed Report_Back to KPI
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10304_Dashboards_Readings_KPI_Incomplete_Detailed_Report_Back_to_KPI()
        {
            testCaseId = "TC-10304";
            qTestUniqueId = "24872528";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteCountBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts By Consumption_Detailed Report_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10305_Dashboards_Top_10_Accounts_By_Consumption_Detailed_Report_Display()
        {
            testCaseId = "TC-10305";
            qTestUniqueId = "24872538";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenConsumtionDetailReport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts By Consumption_Detailed Report_Grid View
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10306_Dashboards_Top_10_Accounts_By_Consumption_Detailed_Report_Grid_View()
        {
            testCaseId = "TC-10306";
            qTestUniqueId = "24872539";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenConsumtionGridView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts By Consumption_Detailed Report_Consumption Options_Display
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10318_Dashboards_Top_10_Accounts_By_Consumption_Detailed_Report_Consumption_Options_Display()
        {
            testCaseId = "TC-10318";
            qTestUniqueId = "24873023";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenConsumtionRadioButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts By Consumption_Detailed Report_Actual Consumption Option_Display
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10319_Dashboards_Top_10_Accounts_By_Consumption_Detailed_Report_Actual_Consumption_Option_Display()
        {
            testCaseId = "TC-10319";
            qTestUniqueId = "24873024";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenConsumtionActualConsumption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts By Consumption_Detailed Report_Estimated Consumption Option_Display
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10320_Dashboards_Top_10_Accounts_By_Consumption_Detailed_Report_Estimated_Consumption_Option_Display()
        {
            testCaseId = "TC-10320";
            qTestUniqueId = "24873025";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenConsumtionEstimatedConsumption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts By Consumption_Detailed Report_Title_Actual Option Selected
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10321_Dashboards_Top_10_Accounts_By_Consumption_Detailed_Report_Title_Actual_Option_Selected()
        {
            testCaseId = "TC-10321";
            qTestUniqueId = "24873026";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenConsumtionActualDetail();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts By Consumption_Detailed Report_Title_Estimated Option Selected
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10322_Dashboards_Top_10_Accounts_By_Consumption_Detailed_Report_Title_Estimated_Option_Selected()
        {
            testCaseId = "TC-10322";
            qTestUniqueId = "24873027";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenConsumtionEstimatedDetail();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts By Consumption_Detailed Report_Back to KPI
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10325_Dashboards_Top_10_Accounts_By_Consumption_Detailed_Report_Back_to_KPI()
        {
            testCaseId = "TC-10325";
            qTestUniqueId = "24873208";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenConsumtionBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts By Consumption_Detailed Report_Export PDF_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10326_Dashboards_Top10_Accounts_By_Consumption_Detailed_Report_Export_PDF_Display()
        {
            testCaseId = "TC-10326";
            qTestUniqueId = "24873209";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenConsumtionPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts By Consumption_Detailed Report_Export Excel_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10327_Dashboards_Top10_Accounts_By_Consumption_Detailed_Report_Export_Excel_Display()
        {
            testCaseId = "TC-10327";
            qTestUniqueId = "24873210";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenConsumtionExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Consumption Options_Display
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10379_Dashboards_System_Consumption_Detailed_Report_Consumption_Options_Display()
        {
            testCaseId = "TC-10379";
            qTestUniqueId = "24893350";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateConsumtionHeaderRadioButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Actual Consumption Option_Display
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10380_Dashboards_System_Consumption_Detailed_Report_Actual_Consumption_Option_Display()
        {
            testCaseId = "TC-10380";
            qTestUniqueId = "24893353";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateConsumtionHeaderActualButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Estimated Consumption Option_Display
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10381_Dashboards_System_Consumption_Detailed_Report_Estimated_Consumption_Option_Display()
        {
            testCaseId = "TC-10381";
            qTestUniqueId = "24893354";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateConsumtionHeaderEstimatedButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Title_Actual Option Selected
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10382_Dashboards_System_Consumption_Detailed_Report_Title_Actual_Option_Selected()
        {
            testCaseId = "TC-10382";
            qTestUniqueId = "24893355";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateConsumtionDetailTitleActual();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Title_Estimated Option Selected
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10383_Dashboards_System_Consumption_Detailed_Report_Title_Estimated_Option_Selected()
        {
            testCaseId = "TC-10383";
            qTestUniqueId = "24893416";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateConsumtionDetailTitleEstimated();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Back to KPI
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10386_Dashboards_System_Consumption_Detailed_Report_Back_to_KPI()
        {
            testCaseId = "TC-10386";
            qTestUniqueId = "24893419";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateConsumtionDetailBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Actual_Export PDF_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10387_Dashboards_System_Consumption_Detailed_Report_Actual_Export_PDF_Display()
        {
            testCaseId = "TC-10387";
            qTestUniqueId = "24893421";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSystemConsumptionActualExportPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Actual_Export Excel_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10388_Dashboards_System_Consumption_Detailed_Report_Actual_Export_Excel_Display()
        {
            testCaseId = "TC-10388";
            qTestUniqueId = "24893423";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSystemConsumptionActualExportExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Estimated_Export PDF_Display
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10389_Dashboards_System_Consumption_Detailed_Report_Estimated_Export_PDF_Display()
        {
            testCaseId = "TC-10389";
            qTestUniqueId = "24893425";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSystemConsumptionEstimatedExportPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Estimated_Export Excel_Display
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10390_Dashboards_System_Consumption_Detailed_Report_Estimated_Export_Excel_Display()
        {
            testCaseId = "TC-10390";
            qTestUniqueId = "24893427";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSystemConsumptionEstimatedExportExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts by Consumption_Widget_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10508_Dashboards_Top_10_Accounts_by_Consumption_Widget_Display()
        {
            testCaseId = "TC-10508";
            qTestUniqueId = "24914121";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTop10ConsumptionWidget();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts by Consumption_Detailed Report Link_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10509_Dashboards_Top10_Accounts_by_Consumption_Detailed_Report_Link_Display()
        {
            testCaseId = "TC-10509";
            qTestUniqueId = "24914122";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTop10ConsumptionDetailReport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts by Consumption_No Consumption Data_Message Display
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10510_Dashboards_Top10_Accounts_by_Consumption_No_Consumption_Data_Message_Display()
        {
            testCaseId = "TC-10510";
            qTestUniqueId = "24914123";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTop10ConsumptionNoDataReturned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Continuous_Detailed Report_Back to KPI
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Category("BatchExecution")]
        [Test]
        public void TC_11723_Dashboards_Consumption_KPI_Continuous_Detailed_Report_Back_to_KPI()
        {
            testCaseId = "TC-11723";
            qTestUniqueId = "24974505";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinuousCountBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Intermittent_Detailed Report_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11726_Dashboards_Consumption_KPI_Intermittent_Detailed_Report_Display()
        {
            testCaseId = "TC-11726";
            qTestUniqueId = "24976238";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentDetailReport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Intermittent_Detailed Report_Title
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11728_Dashboards_Consumption_KPI_Intermittent_Detailed_Report_Title()
        {
            testCaseId = "TC-11728";
            qTestUniqueId = "24976324";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentDetailReport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Intermittent_Detailed Report_Title
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11730_Dashboards_Consumption_KPI_Intermittent_Details_Report_Default_Grid_View()
        {
            testCaseId = "TC-11730";
            qTestUniqueId = "24976327";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentDetailReportGridView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Intermittent_Details Report_Export PDF_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_11732_Dashboards_Consumption_KPI_Intermittent_Details_Report_Export_PDF_Display()
        {
            testCaseId = "TC-11732";
            qTestUniqueId = "24976334";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Intermittent_Details Report_Export Excel_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_11733_Dashboards_Consumption_KPI_Intermittent_Details_Report_Export_Excel_Display()
        {
            testCaseId = "TC-11733";
            qTestUniqueId = "24976339";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Intermittent_Detailed Report_Back to KPI
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Category("BatchExecution")]
        [Test]
        public void TC_11736_Dashboards_Consumption_KPI_Intermittent_Detailed_Report_Back_to_KPI()
        {
            testCaseId = "TC-11736";
            qTestUniqueId = "24976346";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Map Widget_Labels Verbiage
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10234_Dashboard_Map_Widget_Labels_Verbiage()
        {
            testCaseId = "TC-10234";
            qTestUniqueId = "24857292";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMapWidgetLabels();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Continous Intermittent Usage Widget_Label Verbiage
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10237_Dashboard_Continous_Intermittent_Usage_Widget_Label_Verbiage()
        {
            testCaseId = "TC-10237";
            qTestUniqueId = "24857313";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContineousIntermittentUsage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_KPI Widget_Arrow_State
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10242_Dashboards_KPI_Widget_Arrow_State()
        {
            testCaseId = "TC-10242";
            qTestUniqueId = "24857351";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWidgetArrowState();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_KPI Widget_Subcatergory Switching_Count Updated
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10244_Dashboards_KPI_Widget_Subcatergory_Switching_Count_Updated()
        {
            testCaseId = "TC-10244";
            qTestUniqueId = "24857385";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSwitchingCountUpdated();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Major Reverse Flow_Detailed Report_Date Range_Accessible
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10247_Dashboards_Reverse_Flow_KPI_Major_Reverse_Flow_Detailed_Report_Date_Range_Accessible()
        {
            testCaseId = "TC-10247";
            qTestUniqueId = "24857465";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMajorReverseFlowCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Major Reverse Flow_Detailed Report_Columns Display
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10249_Dashboards_Reverse_Flow_KPI_Major_Reverse_Flow_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-10249";
            qTestUniqueId = "24857480";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMajorReverseFlowColumnDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Major Reverse Flow_Details Report_Map View
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10251_Dashboards_Reverse_Flow_KPI_Major_Reverse_Flow_Details_Report_Map_View()
        {
            testCaseId = "TC-10251";
            qTestUniqueId = "24857608";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReverseFlowMapView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Minor Reverse Flow_Detailed Report_Date Range_Accessible
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10259_Dashboards_Reverse_Flow_KPI_Minor_Reverse_Flow_Detailed_Report_Date_Range_Accessible()
        {
            testCaseId = "TC-10259";
            qTestUniqueId = "24857608";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMinorReverseFlowMapView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Reverse Flow KPI_Minor Reverse Flow_Detailed Report_Columns Display
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10261_Dashboards_Reverse_Flow_KPI_Minor_Reverse_Flow_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-10261";
            qTestUniqueId = "24857902";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMinorReverseDetails();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Complete_Detailed Report_Columns Display
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10285_Dashboards_Readings_KPI_Complete_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-10285";
            qTestUniqueId = "24869818";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteReadingsColumnDetails();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Incomplete_Detailed Report_Columns Display
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10297_Dashboards_Readings_KPI_Incomplete_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-10297";
            qTestUniqueId = "24870354";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteReadingsDetails();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Incomplete_Detailed Report_Map View
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10299_Dashboards_Readings_KPI_Incomplete_Detailed_Report_Map_View()
        {
            testCaseId = "TC-10299";
            qTestUniqueId = "24872329";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteMapView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts By Consumption_Detailed Report_Map View
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10308_Dashboards_Top_10_Accounts_By_Consumption_Detailed_Report_Map_View()
        {
            testCaseId = "TC-10308";
            qTestUniqueId = "24872541";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenAccMapView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts By Consumption_Detailed Report_Columns Display
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10312_Dashboards_Top_10_Accounts_By_Consumption_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-10312";
            qTestUniqueId = "24873012";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenAccAccountDetails();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Default Date Range
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10378_Dashboards_System_Consumption_Detailed_Report_Default_Date_Range()
        {
            testCaseId = "TC-10378";
            qTestUniqueId = "24893349";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateDetailsReportDefaultDateRange();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts by Consumption_Consumption Values_UOM
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10511_Dashboards_Top_10_Accounts_by_Consumption_Consumption_Values_UOM()
        {
            testCaseId = "TC-10511";
            qTestUniqueId = "24914124";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopAccConsumptionValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts by Consumption_Consumption Value_Display Order
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_10514_Dashboards_Top_10_Accounts_by_Consumption_Consumption_Value_Display_Order()
        {
            testCaseId = "TC-10514";
            qTestUniqueId = "24914128";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopAccConsumptionValueDisplayOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Normal Continuous Consumption_Detailed Report_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11713_Dashboards_Consumption_KPI_Normal_Continuous_Consumption_Detailed_Report_Display()
        {
            testCaseId = "TC-11713";
            qTestUniqueId = "24974485";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalContinousCusumptionDetailedReport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Continuous_Detailed Report_Date Range_Accessible
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_11714_Dashboards_Consumption_KPI_Continuous_Detailed_Report_Date_Range_Accessible()
        {
            testCaseId = "TC-11714";
            qTestUniqueId = "24974488";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionDateRange();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Normal Continuous Consumption_Detailed Report_Title
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]        
        [Test]
        public void TC_11715_Dashboards_Consumption_KPI_Normal_Continuous_Consumption_Detailed_Report_Title()
        {
            testCaseId = "TC-11715";
            qTestUniqueId = "24974489";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionReportTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Normal Continuous Consumption_Detailed Report_Columns Display
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_11716_Dashboards_Consumption_KPI_Normal_Continuous_Consumption_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-11716";
            qTestUniqueId = "24974491";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionDetailReport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Normal Continuous Consumption_Details Report_Default Grid View
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]

        [Test]
        public void TC_11717_Dashboards_Consumption_KPI_Normal_Continuous_Consumption_Details_Report_Default_Grid_View()
        {
            testCaseId = "TC-11717";
            qTestUniqueId = "24974494";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionGridView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Normal Continuous Consumption_Details Report_Map View
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]

        [Test]
        public void TC_11718_Dashboards_Consumption_KPI_Normal_Continuous_Consumption_Details_Report_Map_View()
        {
            testCaseId = "TC-11718";
            qTestUniqueId = "24974496";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionGridView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Normal Continuous Consumption_Details Report_Export PDF_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]        
        [Category("RegressionTests1")]

        [Test]
        public void TC_11719_Dashboards_Consumption_KPI_Normal_Continuous_Consumption_Details_Report_Export_PDF_Display()
        {
            testCaseId = "TC-11719";
            qTestUniqueId = "24974498";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionExportPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Normal Continuous Consumption_Details Report_Export Excel_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]        
        [Category("RegressionTests1")]

        [Test]
        public void TC_11720_Dashboards_Consumption_KPI_Normal_Continuous_Consumption_Details_Report_Export_Excel_Display()
        {
            testCaseId = "TC-11720";
            qTestUniqueId = "24974500";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionExportExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Intermittent_Detailed Report_Date Range_Accessible
        /// </summary>
        [Category("Dashboard-Obsolete")]

        [Test]
        public void TC_11727_Dashboards_Consumption_KPI_Intermittent_Detailed_Report_Date_Range_Accessible()
        {
            testCaseId = "TC-11727";
            qTestUniqueId = "24976322";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentDetailReportDateRange();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Intermittent_Detailed Report_Columns Display
        /// </summary>
        [Category("Dashboard")]

        [Test]
        public void TC_11729_Dashboards_Consumption_KPI_Intermittent_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-11729";
            qTestUniqueId = "24976325";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentDetailReportColumns();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Intermittent_Details Report_Map View
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]        
        [Category("RegressionTests1")]

        [Test]
        public void TC_11731_Dashboards_Consumption_KPI_Intermittent_Details_Report_Map_View()
        {
            testCaseId = "TC-11731";
            qTestUniqueId = "24976329";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentDetailReportMapView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Meters KPI_Complete_Right Arrow
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]

        [Test]
        public void TC_14919_Dashboard_Meters_KPI_Complete_Right_Arrow()
        {
            testCaseId = "TC-14919";
            qTestUniqueId = "32670298";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateKPICompleteRightArrow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Meters KPI_Complete_Left Arrow
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]

        [Test]
        public void TC_14922_Dashboard_Meters_KPI_Complete_Left_Arrow()
        {
            testCaseId = "TC-14922";
            qTestUniqueId = "32670307";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateKPICompleteLeftArrow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Meters KPI_Incomplete_Right Arrow
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]

        [Test]
        public void TC_14920_Dashboard_Meters_KPI_Incomplete_Right_Arrow()
        {
            testCaseId = "TC-14920";
            qTestUniqueId = "32670299";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateKPIIncompleteRightArrow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Meters KPI_Incomplete_Left Arrow
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]

        [Test]
        public void TC_14921_Dashboard_Meters_KPI_Incomplete_Left_Arrow()
        {
            testCaseId = "TC-14921";
            qTestUniqueId = "32670306";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateKPIIncompleteLefttArrow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Meters KPI_Skipped_Right Arrow
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]

        [Test]
        public void TC_14923_Dashboard_Meters_KPI_Skipped_Right_Arrow()
        {
            testCaseId = "TC-14923";
            qTestUniqueId = "32672334";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedRighttArrow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Meters KPI_Skipped_Left Arrow
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]

        [Test]
        public void TC_14924_Dashboard_Meters_KPI_Skipped_Left_Arrow()
        {
            testCaseId = "TC-14924";
            qTestUniqueId = "32672337";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedLefttArrow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Dashboard Map_All Layers_ Default
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]

        [Test]
        public void TC_15303_Dashboard_Dashboard_Map_All_Layers_Default()
        {
            testCaseId = "TC-15303";
            qTestUniqueId = "33767435";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateAllDefaultLayers();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Dashboard Map_Top Ten Accounts_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]

        [Test]
        public void TC_15304_Dashboard_Dashboard_Map_Top_Ten_Accounts_Link()
        {
            testCaseId = "TC-15304";
            qTestUniqueId = "33767436";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenAccLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Dashboard Map_All Layers_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_15310_Dashboard_Dashboard_Map_All_Layers_Link()
        {
            testCaseId = "TC-15310";
            qTestUniqueId = "33767442";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateAllLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_KPI Detail Report_Display_Same Window_Chrome
        /// </summary>
       /* [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8138_Dashboards_KPI_Detail_Report_Display_Same_Window_Chrome()
        {
            testCaseId = "TC-8138";
            qTestUniqueId = "21679084";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateKPIDetailedReport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Normal Continuous Consumption_Details Report_Export PDF_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13117_Dashboards_Consumption_KPI_Normal_Continuous_Consumption_Details_Report_Export_PDF_Display()
        {
            testCaseId = "TC-13117";
            qTestUniqueId = "28577714";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteDetailReportDateRange();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Continuous Consumption KPI_Detailed Report_Report Date Label_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13119_Dashboards_Continuous_Consumption_KPI_Detailed_Report_Report_Date_Label_Display()
        {
            testCaseId = "TC-13119";
            qTestUniqueId = "28577716";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalContinousCusumptionReportDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Major Reverse Flow KPI_Detailed Report_Report Date Label_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13121_Dashboards_Major_Reverse_Flow_KPI_Detailed_Report_Report_Date_Label_Display()
        {
            testCaseId = "TC-13121";
            qTestUniqueId = "28577718";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMajorReverseFlowTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Warning_Click KPI Number
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13822_Dashboard_Gateway_Status_Detailed_Report_Warning_Click_KPI_Number()
        {
            testCaseId = "TC-13822";
            qTestUniqueId = "30004234";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningDetailedReport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Warning_Report Header Shows Date and Time
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13824_Dashboard_Gateway_Status_Detailed_Report_Warning_Report_Header_Shows_Date_and_Time()
        {
            testCaseId = "TC-13824";
            qTestUniqueId = "30004236";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateGatewayStatusDetailReport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Normal_Click KPI Number
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13834_Dashboard_Gateway_Status_Detailed_Report_Normal_Click_KPI_Number()
        {
            testCaseId = "TC-13834";
            qTestUniqueId = "30004252";
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
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Normal_Report Header Shows Date and Time
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13836_Dashboard_Gateway_Status_Detailed_Report_Normal_Report_Header_Shows_Date_and_Time()
        {
            testCaseId = "TC-13836";
            qTestUniqueId = "30004254";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionDetailReport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Complete Readings_Load Page
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13841_Dashboard_Detailed_Reports_HTML_Links_Complete_Readings_Load_Page()
        {
            testCaseId = "TC-13841";
            qTestUniqueId = "30010060";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteReadingLoadPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Complete Readings_Back to KPI_Load Dashboard
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13843_Dashboard_Detailed_Reports_HTML_Links_Complete_Readings_Back_to_KPI_Load_Dashboard()
        {
            testCaseId = "TC-13843";
            qTestUniqueId = "30010062";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Continuous Flow Critical_Load Page
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13845_Dashboard_Detailed_Reports_HTML_Links_Continuous_Flow_Critical_Load_Page()
        {
            testCaseId = "TC-13845";
            qTestUniqueId = "30010064";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateGatewayCriticalPageLoad();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Continuous Flow Critical_Back to KPI_Load Dashboard
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13847_Dashboard_Detailed_Reports_HTML_Links_Continuous_Flow_Critical_Back_to_KPI_Load_Dashboard()
        {
            testCaseId = "TC-13847";
            qTestUniqueId = "30010066";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalConsumptionBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Continuous Flow Normal_Load Page
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13849_Dashboard_Detailed_Reports_HTML_Links_Continuous_Flow_Normal_Load_Page()
        {
            testCaseId = "TC-13849";
            qTestUniqueId = "30010068";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionPageLoad();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Continuous Flow Normal_Back to KPI_Load Dashboard
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13851_Dashboard_Detailed_Reports_HTML_Links_Continuous_Flow_Normal_Back_to_KPI_Load_Dashboard()
        {
            testCaseId = "TC-13851";
            qTestUniqueId = "30010070";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionBacktoKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Continuous Flow Warning_Load Page
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13853_Dashboard_Detailed_Reports_HTML_Links_Continuous_Flow_Warning_Load_Page()
        {
            testCaseId = "TC-13853";
            qTestUniqueId = "30010070";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionPageLoad();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Continuous Flow Warning_Back to KPI_Load Dashboard
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13855_Dashboard_Detailed_Reports_HTML_Links_Continuous_Flow_Warning_Back_to_KPI_Load_Dashboard()
        {
            testCaseId = "TC-13855";
            qTestUniqueId = "30010074";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionBacktoKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Incomplete Readings_Load Page
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13857_Dashboard_Detailed_Reports_HTML_Links_Incomplete_Readings_Load_Page()
        {
            testCaseId = "TC-13857";
            qTestUniqueId = "30010076";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteCountPageLoad();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Incomplete Readings_Back to KPI_Load Dashboard
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13859_Dashboard_Detailed_Reports_HTML_Links_Incomplete_Readings_Back_to_KPI_Load_Dashboard()
        {
            testCaseId = "TC-13859";
            qTestUniqueId = "30010078";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteCountBacktoKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Intermittent Flow_Load Page
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13861_Dashboard_Detailed_Reports_HTML_Links_Intermittent_Flow_Load_Page()
        {
            testCaseId = "TC-13861";
            qTestUniqueId = "30010080";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentPageLoad();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Intermittent Flow_Back to KPI_Load Dashboard
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13863_Dashboard_Detailed_Reports_HTML_Links_Intermittent_Flow_Back_to_KPI_Load_Dashboard()
        {
            testCaseId = "TC-13863";
            qTestUniqueId = "30010082";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentPageBacktoKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Major Reverse Flow_Load Page
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13865_Dashboard_Detailed_Reports_HTML_Links_Major_Reverse_Flow_Load_Page()
        {
            testCaseId = "TC-13865";
            qTestUniqueId = "30010084";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMajorReverseFlowLoadPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Major Reverse Flow_Back to KPI_Load Dashboard
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13867_Dashboard_Detailed_Reports_HTML_Links_Major_Reverse_Flow_Back_to_KPI_Load_Dashboard()
        {
            testCaseId = "TC-13867";
            qTestUniqueId = "30010086";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMajorReverseFlowBacktoKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Minor Reverse Flow_Load Page
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13869_Dashboard_Detailed_Reports_HTML_Links_Minor_Reverse_Flow_Load_Page()
        {
            testCaseId = "TC-13869";
            qTestUniqueId = "30010088";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMinorReverseFlowPageLoad();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Minor Reverse Flow_Back to KPI_Load Dashboard
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13871_Dashboard_Detailed_Reports_HTML_Links_Minor_Reverse_Flow_Back_to_KPI_Load_Dashboard()
        {
            testCaseId = "TC-13871";
            qTestUniqueId = "30010090";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMinorReverseFlowBacktoKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Skipped Readings_Load Page
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13873_Dashboard_Detailed_Reports_HTML_Links_Skipped_Readings_Load_Page()
        {
            testCaseId = "TC-13873";
            qTestUniqueId = "30010092";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingLoadPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Skipped Readings_Back to KPI_Load Dashboard
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13875_Dashboard_Detailed_Reports_HTML_Links_Skipped_Readings_Back_to_KPI_Load_Dashboard()
        {
            testCaseId = "TC-13875";
            qTestUniqueId = "30010094";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingBacktoKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_System Consumption_Load Page
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13877_Dashboard_Detailed_Reports_HTML_Links_System_Consumption_Load_Page()
        {
            testCaseId = "TC-13877";
            qTestUniqueId = "30010096";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateDetailReportPageLoad();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Top 10 Accounts By Consumption_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13880_Dashboard_Detailed_Reports_HTML_Links_Top_10_Accounts_By_Consumption_Link()
        {
            testCaseId = "TC-13880";
            qTestUniqueId = "30010099";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTop10AccountsDetailReportHTMLLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Top 10 Accounts By Consumption_Back to KPI_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13882_Dashboard_Detailed_Reports_HTML_Links_Top_10_Accounts_By_Consumption_Back_to_KPI_Link()
        {
            testCaseId = "TC-13882";
            qTestUniqueId = "30010101";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTop10AccDetailReportBackToKPILink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Top 10 Accounts By Consumption_Back to KPI_Load Dashboard
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13883_Dashboard_Detailed_Reports_HTML_Links_Top_10_Accounts_By_Consumption_Back_to_KPI_Load_Dashboard()
        {
            testCaseId = "TC-13883";
            qTestUniqueId = "30010102";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTop10AccDetailReportBackToKPILink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Top 10 Accounts By Consumption_Load Page
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13881_Dashboard_Detailed_Reports_HTML_Links_Top_10_Accounts_By_Consumption_Load_Page()
        {
            testCaseId = "TC-13881";
            qTestUniqueId = "30010100";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTop10ConsumptionPageLoad();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Gateway_Critical_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13921_Dashboard_Detailed_Reports_HTML_Links_Gateway_Critical_Link()
        {
            testCaseId = "TC-13921";
            qTestUniqueId = "30053676";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateGatewayCriticalPageLoad();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Gateway_Critical_Load Page
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13922_Dashboard_Detailed_Reports_HTML_Links_Gateway_Critical_Load_Page()
        {
            testCaseId = "TC-13922";
            qTestUniqueId = "30053678";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateGatewayCriticalPageLoad();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Gateway_Critical_Back to KPI_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13923_Dashboard_Detailed_Reports_HTML_Links_Gateway_Critical_Back_to_KPI_Link()
        {
            testCaseId = "TC-13923";
            qTestUniqueId = "30053678";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalConsumptionBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Gateway_Critical_Back to KPI_Load Dashboard
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13924_Dashboard_Detailed_Reports_HTML_Links_Gateway_Critical_Back_to_KPI_Load_Dashboard()
        {
            testCaseId = "TC-13924";
            qTestUniqueId = "30053681";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalConsumptionBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Gateway_Warning_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13925_Dashboard_Detailed_Reports_HTML_Links_Gateway_Warning_Link()
        {
            testCaseId = "TC-13925";
            qTestUniqueId = "30053987";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionPageLoad();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Gateway_Warning_Load Page
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13926_Dashboard_Detailed_Reports_HTML_Links_Gateway_Warning_Load_Page()
        {
            testCaseId = "TC-13926";
            qTestUniqueId = "30053988";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionPageLoad();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Gateway_Warning_Back to KPI_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13927_Dashboard_Detailed_Reports_HTML_Links_Gateway_Warning_Back_to_KPI_Link()
        {
            testCaseId = "TC-13927";
            qTestUniqueId = "30053989";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionBacktoKPILink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Gateway_Warning_Back to KPI_Load Dashboard
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13928_Dashboard_Detailed_Reports_HTML_Links_Gateway_Warning_Back_to_KPI_Load_Dashboard()
        {
            testCaseId = "TC-13928";
            qTestUniqueId = "30053990";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionBacktoKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Gateway_Normal_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13929_Dashboard_Detailed_Reports_HTML_Links_Gateway_Normal_Link()
        {
            testCaseId = "TC-13929";
            qTestUniqueId = "30053993";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionPageLoad();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Gateway_Normal_Load Page
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13930_Dashboard_Detailed_Reports_HTML_Links_Gateway_Normal_Load_Page()
        {
            testCaseId = "TC-13930";
            qTestUniqueId = "30053994";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionPageLoad();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Gateway_Normal_Back to KPI_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13931_Dashboard_Detailed_Reports_HTML_Links_Gateway_Normal_Back_to_KPI_Link()
        {
            testCaseId = "TC-13931";
            qTestUniqueId = "30053995";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionBacktoKPILink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Gateway_Normal_Back to KPI_Load Dashboard
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13932_Dashboard_Detailed_Reports_HTML_Links_Gateway_Normal_Back_to_KPI_Load_Dashboard()
        {
            testCaseId = "TC-13932";
            qTestUniqueId = "30053996";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionBacktoKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Consumption KPI_Original Removed from Dashboard
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13893_Dashboard_Consumption_KPI_Original_Removed_from_Dashboard()
        {
            testCaseId = "TC-13893";
            qTestUniqueId = "30023562";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateOriginaKPIRemoved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Consumption KPI_Left Arrow
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13895_Dashboard_Consumption_KPI_Left_Arrow()
        {
            testCaseId = "TC-13895";
            qTestUniqueId = "30023564";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionleftArrow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Consumption KPI_Left Arrow_Disabled
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13897_Dashboard_Consumption_KPI_Left_Arrow_Disabled()
        {
            testCaseId = "TC-13897";
            qTestUniqueId = "30023566";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionleftArrowDisabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Title
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13936_Dashboard_Continuous_Consumption_Detailed_Report_Title()
        {
            testCaseId = "TC-13936";
            qTestUniqueId = "30131712";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to  Dashboard_Continuous Consumption_Detailed Report_Subtitle Text
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13938_Dashboard_Continuous_Consumption_Detailed_Report_Subtitle_Text()
        {
            testCaseId = "TC-13938";
            qTestUniqueId = "30131714";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionReportText();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Column Heading_Account #
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13940_Dashboard_Continuous_Consumption_Detailed_Report_Column_Heading_Account()
        {
            testCaseId = "TC-13940";
            qTestUniqueId = "30131716";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionAccNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Column Heading_Address
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13942_Dashboard_Continuous_Consumption_Detailed_Report_Column_Heading_Address()
        {
            testCaseId = "TC-13942";
            qTestUniqueId = "30131718";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionAddress();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Column Heading_State
        /// </summary>
        /*[Category("Dashboard")]
        [Test]
        public void TC_13944_Dashboard_Continuous_Consumption_Detailed_Report_Column_Heading_State()
        {
            testCaseId = "TC-13944";
            qTestUniqueId = "30131718";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionState();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Column Heading_Date
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13946_Dashboard_Continuous_Consumption_Detailed_Report_Column_Heading_Date()
        {
            testCaseId = "TC-13946";
            qTestUniqueId = "30131722";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /*/// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Column Heading_Threshold
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13948_Dashboard_Continuous_Consumption_Detailed_Report_Column_Heading_Threshold()
        {
            testCaseId = "TC-13948";
            qTestUniqueId = "30131724";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionThreshold();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Column Heading_Account Name
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13950_Dashboard_Continuous_Consumption_Detailed_Report_Column_Heading_Account_Name()
        {
            testCaseId = "TC-13950";
            qTestUniqueId = "30131726";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionAccName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Data Validation_MIU
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13952_Dashboard_Continuous_Consumption_Detailed_Report_Data_Validation_MIU()
        {
            testCaseId = "TC-13952";
            qTestUniqueId = "30131728";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionMIU();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

       /* /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Data Validation_City
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13954_Dashboard_Continuous_Consumption_Detailed_Report_Data_Validation_City()
        {
            testCaseId = "TC-13954";
            qTestUniqueId = "30131730";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionCity();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Data Validation_Zip
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13956_Dashboard_Continuous_Consumption_Detailed_Report_Data_Validation_Zip()
        {
            testCaseId = "TC-13956";
            qTestUniqueId = "30131732";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionZip();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Data Validation_Days
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13958_Dashboard_Continuous_Consumption_Detailed_Report_Data_Validation_Days()
        {
            testCaseId = "TC-13958";
            qTestUniqueId = "30131734";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionDays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Meters Received via AMI KPI_Detailed Report_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15252_Dashboard_Meters_Received_via_AMI_KPI_Detailed_Report_Display()
        {
            testCaseId = "TC-15252";
            qTestUniqueId = "33673163";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionDays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Meters Received via AMR KPI_Meter Count_Includes Meters not part of a Route
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15260_Dashboard_Meters_Received_via_AMR_KPI_Meter_Count_Includes_Meters_not_part_of_a_Route()
        {
            testCaseId = "TC-15260";
            qTestUniqueId = "33673163";
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
        /// Test Method to Dashboard_Meters Not Received KPI_Meter Count_Includes Meters with No Reading_Auto Complete Window
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15285_Dashboard_Meters_Not_Received_KPI_Meter_Count_Includes_Meters_with_No_Reading_Auto_Complete_Window()
        {
            testCaseId = "TC-15285";
            qTestUniqueId = "33753071";
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
        /// Test Method to Dashboards_Meters Received via AMI_Detailed Report_Columns Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15340_Dashboards_Meters_Received_via_AMI_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-15340";
            qTestUniqueId = "33868767";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedKPIviaAMIColoumnsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Received via AMI_Detailed Report_Export Excel_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15342_Dashboards_Meters_Received_via_AMI_Detailed_Report_Export_Excel_Display()
        {
            testCaseId = "TC-15342";
            qTestUniqueId = "33868769";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedKPIviaAMIExcelDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Received via AMI_Detailed Report_Back to KPI
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15346_Dashboards_Meters_Received_via_AMI_Detailed_Report_Back_to_KPI()
        {
            testCaseId = "TC-15346";
            qTestUniqueId = "33868775";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedKPIviaAMIBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Received via AMR_Detailed Report_Row Count Validation
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15348_Dashboards_Meters_Received_via_AMR_Detailed_Report_Row_Count_Validation()
        {
            testCaseId = "TC-15348";
            qTestUniqueId = "33871783";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedKPIviaAMIBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Received via AMR_Detailed Report_Columns Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15350_Dashboards_Meters_Received_via_AMR_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-15350";
            qTestUniqueId = "33871787";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedKPIviaAMRColoumnsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Received via AMR_Detailed Report_Export Excel_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15352_Dashboards_Meters_Received_via_AMR_Detailed_Report_Export_Excel_Display()
        {
            testCaseId = "TC-15352";
            qTestUniqueId = "33871790";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedKPIviaAMRExcelDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Received via AMR_Detailed Report_Back to KPI
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15356_Dashboards_Meters_Received_via_AMR_Detailed_Report_Back_to_KPI()
        {
            testCaseId = "TC-15356";
            qTestUniqueId = "33871796";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedKPIviaAMRBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        ///// <summary>
        ///// Test Method to Dashboards_Meters Not Received_Detailed Report_Row Count Validation
        ///// </summary>
        //[Category("Dashboard")]
        //[Test]
        //public void TC_15358_Dashboards_Meters_Not_Received_Detailed_Report_Row_Count_Validation()
        //{
        //    testCaseId = "TC-15358";
        //    qTestUniqueId = "33872298";
        //    startDate = DateTime.Now; try
        //    {
        //        Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
        //        url = testData["URL"];
        //        userName = testData["UserName"];
        //        password = testData["Password"];
        //        home.NavigateDashboardPage(url, userName, password);
        //        dashBoard.ValidateNotReceivedCount();
        //        home.UserLogOut();
        //        QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
        //    }
        //    catch (Exception)
        //    {
        //        QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
        //    }
        //}

        /// <summary>
        /// Test Method to Dashboards_Meters Not Received_Detailed Report_Export PDF_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15361_Dashboards_Meters_Not_Received_Detailed_Report_Export_PDF_Display()
        {
            testCaseId = "TC-15361";
            qTestUniqueId = "33872303";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNotReceivedPDFDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Not Received_Detailed Report_Back to KPI_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15365_Dashboards_Meters_Not_Received_Detailed_Report_Back_to_KPI_Display()
        {
            testCaseId = "TC-15365";
            qTestUniqueId = "33872303";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNotReceivedBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Not Received_Detailed Report_Header Consistent
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15367_Dashboards_Meters_Not_Received_Detailed_Report_Header_Consistent()
        {
            testCaseId = "TC-15367";
            qTestUniqueId = "33872311";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNotReceivedHeader();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Conv Column_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17595_Dashboards_System_Consumption_Detailed_Report_Conv_Column_Display()
        {
            testCaseId = "TC-17595";
            qTestUniqueId = "37782061";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateConvColumn();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Conv Column_Display Order
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17596_Dashboards_System_Consumption_Detailed_Report_Conv_Column_Display_Order()
        {
            testCaseId = "TC-17596";
            qTestUniqueId = "37782062";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateConvColumn();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Conv Column_Asterisks Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17598_Dashboards_System_Consumption_Detailed_Report_Conv_Column_Asterisks_Display()
        {
            testCaseId = "TC-17598";
            qTestUniqueId = "37782075";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateAsteriksDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption_Detailed Report_Conv Column_Asterisks_Indication Message
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17600_Dashboards_System_Consumption_Detailed_Report_Conv_Column_Asterisks_Indication_Message()
        {
            testCaseId = "TC-17600";
            qTestUniqueId = "37782100";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateAsteriksDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption Detail Table_New Column_Register UOM and Utility UOM_Different
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17601_Dashboards_System_Consumption_Detail_Table_New_Column_Register_UOM_and_Utility_UOM_Different()
        {
            testCaseId = "TC-17601";
            qTestUniqueId = "37782101";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateAsteriksDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption Detail Table_New Column_Meter with No Register UOM
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17602_Dashboards_System_Consumption_Detail_Table_New_Column_Meter_with_No_Register_UOM()
        {
            testCaseId = "TC-17602";
            qTestUniqueId = "37782102";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateAsteriksDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Dashboards_System Consumption Detail Table_New Column_Meter with No Register UOM
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_Dashboards_Data_Validation()
        {
            testCaseId = "TC-DahboardMinorCount";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMinorReverseFlowCountValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption Detail Table_New Column_Meter with No Register UOM
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_Dashboards_Data_Validation_VIA_AMR()
        {
            testCaseId = "TC-DahboardMinorCount";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedviaAMRCountValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard-KPICount")]
        [Test]
        public void TC_10282_Dashboards_Readings_KPI_Complete_Detailed_Report_Row_Count_Validation()
        {
            try
            {
                testCaseId = "TC-10282";
                qTestUniqueId = "24869814";
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteReadingsCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        [Category("Dashboard-KPICount")]
        [Test]
        public void TC_10294_Dashboards_Readings_KPI_Incomplete_Detailed_Report_Row_Count_Validation()
        {
            try
            {
                testCaseId = "TC-10294";
                qTestUniqueId = "24870351";
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteReadingsCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }

        }

        [Category("Dashboard-KPICount")]
        [Test]
        public void TC_13050_Dashboards_Readings_KPI_Skipped_Detailed_Report_Row_Count_Validation()
        {
            try
            {
                testCaseId = "TC-13050";
                qTestUniqueId = "27893288";
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingsCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }

        }

        [Category("Dashboard-KPICount")]
        [Test]
        public void TC_15348_Dashboard_Meters_Received_via_AMR_Detailed_Report_Row_Count_Validation()
        {
            try
            {
                testCaseId = "TC-15348";
                qTestUniqueId = "33871783";
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedAMRReadingsCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }

        }

        [Category("Dashboard-KPICount")]
        [Test]
        public void TC_15338_Dashboards_Meters_Received_via_AMI_Detailed_Report_Row_Count_Validation()
        {
            try
            {
                testCaseId = "TC-15338";
                qTestUniqueId = "33868765";
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedAMIReadingsCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        [Category("Dashboard-KPICount")]
        [Test]
        public void TC_15358_Dashboards_Meters_Not_Received_Detailed_Report_Row_Count_Validation()
        {
            try
            {
                testCaseId = "TC-15358";
                qTestUniqueId = "33872298";
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNotReceivedReadingsCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        [Category("Dashboard-KPICount")]
        [Test]
        public void TC_14153_Dashboards_Consumption_KPI_Critical_Continuous_Consumption_Detailed_Report_Row_Count_Validation()
        {
            try
            {
                testCaseId = "TC-14153";
                qTestUniqueId = "30514106";
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalReadingsCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        [Category("Dashboard-KPICount")]
        [Test]
        public void TC_14164_Dashboards_Consumption_KPI_Warning_Continous_Consumption_Detailed_Report_Row_Count_Validation()
        {
            try
            {
                testCaseId = "TC-14164";
                qTestUniqueId = "30514157";
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningReadingsCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        [Category("Dashboard-KPICount")]
        [Test]
        public void TC_11740_Dashboards_Consumption_KPI_Normal_Continuous_Consumption_Detailed_Report_Row_Count_Validation()
        {
            try
            {
                testCaseId = "TC-11740";
                qTestUniqueId = "24977566";
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalReadingsCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        [Category("Dashboard-KPICount")]
        [Test]
        public void TC_11738_Dashboards_Consumption_KPI_Intermittent_Detailed_Report_Row_Count_Validation()
        {
            try
            {
                testCaseId = "TC-11738";
                qTestUniqueId = "24976351";
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentReadingsCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        [Category("Dashboard-KPICount")]
        [Test]
        public void TC_10246_Dashboards_Reverse_Flow_KPI_Major_Reverse_Flow_Detailed_Report_Row_Count_Validation()
        {
            try
            {
                testCaseId = "TC-10246";
                qTestUniqueId = "24857455";
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMajorReverseReadingsCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        [Category("Dashboard-KPICount")]
        [Test]
        public void TC_10258_Dashboards_Reverse_Flow_KPI_Minor_Reverse_Flow_Detailed_Report_Row_Count_Validation()
        {
            try
            {
                testCaseId = "TC-10258";
                qTestUniqueId = "24857888";
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMinorReverseReadingsCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        [Category("Dashboard-KPICount")]
        [Test]
        public void TC_21517_Dashboards_Gateway_KPI_Critical_Detailed_Report_Row_Count_Validation()
        {
            try
            {
                testCaseId = "TC-21517";
                qTestUniqueId = "47193526";
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalGatewayReadingsCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        [Category("Dashboard-KPICount")]
        [Test]
        public void TC_21518_Dashboards_Gateway_KPI_Warning_Detailed_Report_Row_Count_Validation()
        {
            try
            {
                testCaseId = "TC-21518";
                qTestUniqueId = "47193557";
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningGatewayReadingsCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        [Category("Dashboard-KPICount")]

        [Test]
        public void TC_21519_Dashboards_Gateway_KPI_Normal_Detailed_Report_Row_Count_Validation()
        {
            try
            {
                testCaseId = "TC-21519";
                qTestUniqueId = "47193558";
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalGatewayReadingsCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Readings KPI_Skipped _Count
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12973_Dashboard_Readings_KPI_Skipped_Count()
        {
            testCaseId = "TC-12973";
            qTestUniqueId = "27767313";
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
        /// Test Method to Dashboards_Skipped_Detailed Report_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13049_Dashboards_Skipped_Detailed_Report_Display()
        {
            testCaseId = "TC-13049";
            qTestUniqueId = "27893284";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Skipped_Detailed Report_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13050_Dashboards_Skipped_Detailed_Report_Display()
        {
            testCaseId = "TC-13050";
            qTestUniqueId = "27893288";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Skipped_Detailed Report_Date Range_Not Accessible
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13051_Dashboards_Readings_KPI_Skipped_Detailed_Report_Date_Range_Not_Accessible()
        {
            testCaseId = "TC-13051";
            qTestUniqueId = "27893289";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingDateRange();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Skipped_Detailed Report_Title
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13052_Dashboards_Readings_KPI_Skipped_Detailed_Report_Title()
        {
            testCaseId = "TC-13052";
            qTestUniqueId = "27893290";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Skipped_Detailed Report_Columns Display
        /// </summary>
        [Category("Dashboard-Obsolete")]
        [Test]
        public void TC_13053_Dashboards_Readings_KPI_Skipped_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-13053";
            qTestUniqueId = "27893291";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingColumnDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Skipped_Detailed Report_Default Grid View
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13054_Dashboards_Readings_KPI_Skipped_Detailed_Report_Default_Grid_View()
        {
            testCaseId = "TC-13054";
            qTestUniqueId = "27893293";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingGridView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Skipped_Detailed Report_Map_ View
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13055_Dashboards_Readings_KPI_Skipped_Detailed_Report_Map_View()
        {
            testCaseId = "TC-13055";
            qTestUniqueId = "27893295";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingMapView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Skipped_Detailed Report_Export PDF_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13056_Dashboards_Readings_KPI_Skipped_Detailed_Report_Export_PDF_Display()
        {
            testCaseId = "TC-13056";
            qTestUniqueId = "27893296";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingExportPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Skipped_Detailed Report_Export PDF_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13057_Dashboards_Readings_KPI_Skipped_Detailed_Report_Export_Excel_Display()
        {
            testCaseId = "TC-13057";
            qTestUniqueId = "27893297";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingExportExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Skipped_Detailed Report_Back to KPI
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13061_Dashboards_Readings_KPI_Skipped_Detailed_Report_Back_to_KPI()
        {
            testCaseId = "TC-13061";
            qTestUniqueId = "27893363";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Skipped_Detailed Report_Current Date_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13062_Dashboards_Readings_KPI_Skipped_Detailed_Report_Current_Date_Display()
        {
            testCaseId = "TC-13062";
            qTestUniqueId = "27893363";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingCurrentDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System Consumption KPI_Detailed Report_Report Date Label_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13115_Dashboards_System_Consumption_KPI_Detailed_Report_Report_Date_Label_Display()
        {
            testCaseId = "TC-13115";
            qTestUniqueId = "28577712";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSystemConsumptionReportDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts by Consumption_Detailed Report_Report Date Label_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13116_Dashboards_Top_10_Accounts_by_Consumption_Detailed_Report_Report_Date_Label_Display()
        {
            testCaseId = "TC-13116";
            qTestUniqueId = "28577713";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTop10ConsumptionReportDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Incomplete Meters KPI_Detailed Report_Report Date Label_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13118_Dashboards_Incomplete_Meters_KPI_Detailed_Report_Report_Date_Label_Display()
        {
            testCaseId = "TC-13118";
            qTestUniqueId = "28577715";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteMetersReportDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Intermittent Consumption KPI_Detailed Report_Report Date Label_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13120_Dashboards_Intermittent_Consumption_KPI_Detailed_Report_Report_Date_Label_Display()
        {
            testCaseId = "TC-13120";
            qTestUniqueId = "28577717";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentKPIReportDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Minor Reverse Flow KPI_Detailed Report_Report Date Label_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13122_Dashboards_Minor_Reverse_Flow_KPI_Detailed_Report_Report_Date_Label_Display()
        {
            testCaseId = "TC-13122";
            qTestUniqueId = "28577719";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMinorReverseFlowKPIReportDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Critical_Click KPI Number
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13803_Dashboard_Gateway_Status_Detailed_Report_Critical_Click_KPI_Number()
        {
            testCaseId = "TC-13803";
            qTestUniqueId = "29960196";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalGatewayKPINumber();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Critical_Report Header
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13804_Dashboard_Gateway_Status_Detailed_Report_Critical_Report_Header()
        {
            testCaseId = "TC-13804";
            qTestUniqueId = "29960293";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalGatewayReportHeader();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report Header Shows Date and Time
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13808_Dashboard_Gateway_Status_Detailed_Report_Header_Shows_Date_and_Time()
        {
            testCaseId = "TC-13808";
            qTestUniqueId = "29962745";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalGatewayDateTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report Critical_Date/Time Stamp Shows Local Time
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13805_Dashboard_Gateway_Status_Detailed_Report_Critical_Date_Time_Stamp_Shows_Local_Time()
        {
            testCaseId = "TC-13805";
            qTestUniqueId = "29962704";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalGatewayDateTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report Critical_Export to CSV
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13806_Dashboard_Gateway_Status_Detailed_Report_Critical_Export_to_CSV()
        {
            testCaseId = "TC-13806";
            qTestUniqueId = "29962727";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalGatewayExporttoCSV();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report Critical_Export to PDF
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13807_Dashboard_Gateway_Status_Detailed_Report_Critical_Export_to_PDF()
        {
            testCaseId = "TC-13807";
            qTestUniqueId = "29962740";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalGatewayExporttoPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Critical_Report Column Headings
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13810_Dashboard_Gateway_Status_Detailed_Report_Critical_Report_Column_Headings()
        {
            testCaseId = "TC-13810";
            qTestUniqueId = "30004106";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalGatewayColumnHeading();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Critical_Report Column Data
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13811_Dashboard_Gateway_Status_Detailed_Report_Critical_Report_Column_Data()
        {
            testCaseId = "TC-13811";
            qTestUniqueId = "30004146";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalGatewayColumnHeading();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Critical_Report Data_Gateway Name
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13812_Dashboard_Gateway_Status_Detailed_Report_Critical_Report_Data_Gateway_Name()
        {
            testCaseId = "TC-13812";
            qTestUniqueId = "30004169";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalReportGatewayName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Critical_Report Last Sync Date/Time
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13813_Dashboard_Gateway_Status_Detailed_Report_Critical_Report_Last_Sync_Date_Time()
        {
            testCaseId = "TC-13813";
            qTestUniqueId = "30004173";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalReportLastSyncDateTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Critical_Report Data_# MIU's Received
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13814_Dashboard_Gateway_Status_Detailed_Report_Critical_Report_Data_MIUs_Received()
        {
            testCaseId = "TC-13814";
            qTestUniqueId = "30004174";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalReportMIUReceived();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Warning_Report Header
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13823_Dashboard_Gateway_Status_Detailed_Report_Warning_Report_Header()
        {
            testCaseId = "TC-13823";
            qTestUniqueId = "30004235";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningReportHeader();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Warning_Date/Time Stamp Shows Local Time
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13825_Dashboard_Gateway_Status_Detailed_Report_Warning_Date_Time_Stamp_Shows_Local_Time()
        {
            testCaseId = "TC-13825";
            qTestUniqueId = "30004237";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningGatewayDateTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report Report_Warning_Export to CSV
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13826_Dashboard_Gateway_Status_Detailed_Report_Report_Warning_Export_to_CSV()
        {
            testCaseId = "TC-13826";
            qTestUniqueId = "30004238";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningGatewayExportCSV();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report Report_Warning_Export to PDF
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13827_D7ashboard_Gateway_Status_Detailed_Report_Report_Warning_Export_to_PDF()
        {
            testCaseId = "TC-13827";
            qTestUniqueId = "30004239";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningGatewayExportPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report Report_Warning_Export to PDF
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13829_Dashboard_Gateway_Status_Detailed_Report_Warning_Report_Column_Headings()
        {
            testCaseId = "TC-13829";
            qTestUniqueId = "30004239";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningGatewayColumnHeading();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Warning_Report Column Data
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13830_Dashboard_Gateway_Status_Detailed_Report_Warning_Report_Column_Data()
        {
            testCaseId = "TC-13830";
            qTestUniqueId = "30004248";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningGatewayColumnHeading();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Warning_Report Data_Gateway Name
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13831_Dashboard_Gateway_Status_Detailed_Report_Warning_Report_Data_Gateway_Name()
        {
            testCaseId = "TC-13831";
            qTestUniqueId = "30004249";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningGatewayGatewayName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Warning_Report Data_Last Sync Date/Time
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13832_Dashboard_Gateway_Status_Detailed_Report_Warning_Report_Data_Last_Sync_Date_Time()
        {
            testCaseId = "TC-13832";
            qTestUniqueId = "30004250";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningGatewayGatewayDateTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Warning_Report Data MIU_Received
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13833_Dashboard_Gateway_Status_Detailed_Report_Warning_Report_Data_MIU_Received()
        {
            testCaseId = "TC-13833";
            qTestUniqueId = "30004251";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningGatewayGatewayMiuReceived();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Normal_Report Header
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13835_Dashboard_Gateway_Status_Detailed_Report_Normal_Report_Header()
        {
            testCaseId = "TC-13835";
            qTestUniqueId = "30004253";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalGatewayReportHeader();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Normal_Date/Time Stamp Shows Local Time
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13837_Dashboard_Gateway_Status_Detailed_Report_Normal_Date_Time_Stamp_Shows_Local_Time()
        {
            testCaseId = "TC-13837";
            qTestUniqueId = "30004255";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalGatewayDateTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Normal_Export to CSV
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13838_Dashboard_Gateway_Status_Detailed_Report_Normal_Export_to_CSV()
        {
            testCaseId = "TC-13838";
            qTestUniqueId = "30004256";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalGatewayExportCSV();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Normal_Export to PDF
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13839_Dashboard_Gateway_Status_Detailed_Report_Normal_Export_to_PDF()
        {
            testCaseId = "TC-13839";
            qTestUniqueId = "30004257";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalGatewayExportPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Normal_Report Column Headings
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13817_Dashboard_Gateway_Status_Detailed_Report_Normal_Report_Column_Headings()
        {
            testCaseId = "TC-13817";
            qTestUniqueId = "30004229";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalGatewayColumnHeading();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Normal_Report Column Data
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13818_Dashboard_Gateway_Status_Detailed_Report_Normal_Report_Column_Data()
        {
            testCaseId = "TC-13818";
            qTestUniqueId = "30004230";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalGatewayColumnHeading();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report Normal_Report Data_Gateway Name
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13819_Dashboard_Gateway_Status_Detailed_Report_Normal_Report_Data_Gateway_Name()
        {
            testCaseId = "TC-13819";
            qTestUniqueId = "30004231";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalGatewayGatewayName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report Normal_Report Data_Last Sync Date/Time
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13820_Dashboard_Gateway_Status_Detailed_Report_Normal_Report_Data_Last_Sync_Date_Time()
        {
            testCaseId = "TC-13820";
            qTestUniqueId = "30004232";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalGatewayGatewayDateTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report Normal_Report Data_MIU's Received
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13821_Dashboard_Gateway_Status_Detailed_Report_Normal_Report_Data_MIUs_Received()
        {
            testCaseId = "TC-13821";
            qTestUniqueId = "30004233";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalGatewayGatewayMiuReceived();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Critical_Click KPI Number_Zero
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13918_Dashboard_Gateway_Status_Detailed_Report_Critical_Click_KPI_Number_Zero()
        {
            testCaseId = "TC-13918";
            qTestUniqueId = "30052069";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalGatewayZeroKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Warning_Click KPI Number_Zero
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13919_Dashboard_Gateway_Status_Detailed_Report_Warning_Click_KPI_Number_Zero()
        {
            testCaseId = "TC-13919";
            qTestUniqueId = "30052070";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningGatewayZeroKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Gateway Status_Detailed Report_Normal_Click KPI Number_Zero
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13920_Dashboard_Gateway_Status_Detailed_Report_Normal_Click_KPI_Number_Zero()
        {
            testCaseId = "TC-13920";
            qTestUniqueId = "30052071";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalGatewayZeroKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Complete Readings_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13840_Dashboard_Detailed_Reports_HTML_Links_Complete_Readings_Link()
        {
            testCaseId = "TC-13840";
            qTestUniqueId = "30010059";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteReadingHTMLLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Complete Readings_Back to KPI_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13842_Dashboard_Detailed_Reports_HTML_Links_Complete_Readings_Back_to_KPI_Link()
        {
            testCaseId = "TC-13842";
            qTestUniqueId = "30010061";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Continuous Flow Critical_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13844_Dashboard_Detailed_Reports_HTML_Links_Continuous_Flow_Critical_Link()
        {
            testCaseId = "TC-13844";
            qTestUniqueId = "30010063";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalContinuousConsumptionHTMLLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Continuous Flow Critical_Back to KPI_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13846_Dashboard_Detailed_Reports_HTML_Links_Continuous_Flow_Critical_Back_to_KPI_Link()
        {
            testCaseId = "TC-13846";
            qTestUniqueId = "30010065";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalConsumptionBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Continuous Flow Normal_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13848_Dashboard_Detailed_Reports_HTML_Links_Continuous_Flow_Normal_Link()
        {
            testCaseId = "TC-13848";
            qTestUniqueId = "30010067";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionPageLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Continuous Flow Normal_Back to KPI_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13850_Dashboard_Detailed_Reports_HTML_Links_Continuous_Flow_Normal_Back_to_KPI_Link()
        {
            testCaseId = "TC-13850";
            qTestUniqueId = "30010069";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionBacktoKPILink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Continuous Flow Warning_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13852_Dashboard_Detailed_Reports_HTML_Links_Continuous_Flow_Warning_Link()
        {
            testCaseId = "TC-13852";
            qTestUniqueId = "30010071";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionHTMLLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Continuous Flow Warning_Back to KPI_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13854_Dashboard_Detailed_Reports_HTML_Links_Continuous_Flow_Warning_Back_to_KPI_Link()
        {
            testCaseId = "TC-13854";
            qTestUniqueId = "30010073";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionBacktoKPILink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Incomplete Readings_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13856_Dashboard_Detailed_Reports_HTML_Links_Incomplete_Readings_Link()
        {
            testCaseId = "TC-13856";
            qTestUniqueId = "30010075";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteCountHTMLLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Incomplete Readings_Back to KPI_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13858_Dashboard_Detailed_Reports_HTML_Links_Incomplete_Readings_Back_to_KPI_Link()
        {
            testCaseId = "TC-13858";
            qTestUniqueId = "30010077";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIncompleteCountBackToKPILink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Intermittent Flow_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13860_Dashboard_Detailed_Reports_HTML_Links_Intermittent_Flow_Link()
        {
            testCaseId = "TC-13860";
            qTestUniqueId = "30010079";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentCountLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Intermittent Flow_Back to KPI_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13862_Dashboard_Detailed_Reports_HTML_Links_Intermittent_Flow_Back_to_KPI_Link()
        {
            testCaseId = "TC-13862";
            qTestUniqueId = "30010081";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentBackToKPILink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Major Reverse Flow_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13864_Dashboard_Detailed_Reports_HTML_Links_Major_Reverse_Flow_Link()
        {
            testCaseId = "TC-13864";
            qTestUniqueId = "30010083";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMajorReverseFlowHTMLLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Major Reverse Flow_Back to KPI_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13866_Dashboard_Detailed_Reports_HTML_Links_Major_Reverse_Flow_Back_to_KPI_Link()
        {
            testCaseId = "TC-13866";
            qTestUniqueId = "30010085";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMajorReverseFlowBacktoKPILink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Minor Reverse Flow_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13868_Dashboard_Detailed_Reports_HTML_Links_Minor_Reverse_Flow_Link()
        {
            testCaseId = "TC-13868";
            qTestUniqueId = "30010087";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMinorHTMLLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Minor Reverse Flow_Back to KPI_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13870_Dashboard_Detailed_Reports_HTML_Links_Minor_Reverse_Flow_Back_to_KPI_Link()
        {
            testCaseId = "TC-13870";
            qTestUniqueId = "30010089";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateBakToKPIMinorLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Skipped Readings_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13872_Dashboard_Detailed_Reports_HTML_Links_Skipped_Readings_Link()
        {
            testCaseId = "TC-13872";
            qTestUniqueId = "30010091";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingHTMLLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_Skipped Readings_Back to KPI_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13874_Dashboard_Detailed_Reports_HTML_Links_Skipped_Readings_Back_to_KPI_Link()
        {
            testCaseId = "TC-13874";
            qTestUniqueId = "30010093";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSkippedReadingBackToKPILink(url);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_System Consumption_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13876_Dashboard_Detailed_Reports_HTML_Links_System_Consumption_Link()
        {
            testCaseId = "TC-13876";
            qTestUniqueId = "30010095";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSystemConsDetailReportHTMLLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_System Consumption_Back to KPI_Link
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13878_Dashboard_Detailed_Reports_HTML_Links_System_Consumption_Back_to_KPI_Link()
        {
            testCaseId = "TC-13878";
            qTestUniqueId = "30010097";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSystemConsDetailReportBackToKPILink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Detailed Reports_HTML Links_System Consumption_Back to KPI_Load Dashboard
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13879_Dashboard_Detailed_Reports_HTML_Links_System_Consumption_Back_to_KPI_Load_Dashboard()
        {
            testCaseId = "TC-13879";
            qTestUniqueId = "30010098";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSystemConsDetailReportBackToKPILink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Consumption Widget_Position on Dashboard
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13888_Dashboard_Consumption_Widget_Position_on_Dashboard()
        {
            testCaseId = "TC-13888";
            qTestUniqueId = "30023557";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalConsumptionWidget();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        [Category("Dashboard")]
        [Category("RegressionTests2")]
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
        /// Test Method to Dashboard_Consumption KPI_Right Arrow
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13894_Dashboard_Consumption_KPI_Right_Arrow()
        {
            testCaseId = "TC-13894";
            qTestUniqueId = "30023563";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateConsumptionKPIRightArrow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Consumption KPI_Right Arrow_Disabled
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13896_Dashboard_Consumption_KPI_Right_Arrow_Disabled()
        {
            testCaseId = "TC-13896";
            qTestUniqueId = "30023565";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateConsumptionRightArrowDisabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Consumption KPI_Critical_Counts
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13914_Dashboard_Consumption_KPI_Critical_Counts()
        {
            testCaseId = "TC-13914";
            qTestUniqueId = "30029495";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalConsumptionCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Consumption KPI_Warning_Counts
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13915_Dashboard_Consumption_KPI_Warning_Counts()
        {
            testCaseId = "TC-13915";
            qTestUniqueId = "30029496";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Consumption KPI_Normal_Counts
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13916_Dashboard_Consumption_KPI_Normal_Counts()
        {
            testCaseId = "TC-13916";
            qTestUniqueId = "30029497";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Consumption KPI_Intermittent_Counts
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13917_Dashboard_Consumption_KPI_Intermittent_Counts()
        {
            testCaseId = "TC-13917";
            qTestUniqueId = "30029498";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentConsumptionCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Subtitle Date
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13937_Dashboard_Continuous_Consumption_Detailed_Report_Subtitle_Date()
        {
            testCaseId = "TC-13937";
            qTestUniqueId = "30131713";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Column Heading_Account Name
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13939_Dashboard_Continuous_Consumption_Detailed_Report_Column_Heading_Account_Name()
        {
            testCaseId = "TC-13939";
            qTestUniqueId = "30131715";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionAccNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Column Heading_MIU
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13941_Dashboard_Continuous_Consumption_Detailed_Report_Column_Heading_MIU()
        {
            testCaseId = "TC-13941";
            qTestUniqueId = "30131717";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionMIU();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /*/// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Column Heading_City
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13943_Dashboard_Continuous_Consumption_Detailed_Report_Column_Heading_City()
        {
            testCaseId = "TC-13943";
            qTestUniqueId = "30131719";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionCity();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Column Heading_ZIP
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13945_Dashboard_Continuous_Consumption_Detailed_Report_Column_Heading_ZIP()
        {
            testCaseId = "TC-13945";
            qTestUniqueId = "30131721";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionZip();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
*/
        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Column Heading_Days
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13947_Dashboard_Continuous_Consumption_Detailed_Report_Column_Heading_Days()
        {
            testCaseId = "TC-13947";
            qTestUniqueId = "30131723";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionDays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Column Heading_Reading
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13949_Dashboard_Continuous_Consumption_Detailed_Report_Column_Heading_Reading()
        {
            testCaseId = "TC-13949";
            qTestUniqueId = "30131725";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionDays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Column Heading_Account No
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13951_Dashboard_Continuous_Consumption_Detailed_Report_Column_Heading_Account_No()
        {
            testCaseId = "TC-13951";
            qTestUniqueId = "30131727";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionAccNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Column Heading_Address
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13953_Dashboard_Continuous_Consumption_Detailed_Report_Column_Heading_Address()
        {
            testCaseId = "TC-13953";
            qTestUniqueId = "30131729";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionAddress();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboard_Continuous Consumption_Detailed Report_Column Heading_State
        /// </summary>
        /*[Category("Dashboard")]        
        [Test]
        public void TC_13955_Dashboard_Continuous_Consumption_Detailed_Report_Column_Heading_State()
        {
            testCaseId = "TC-13955";
            qTestUniqueId = "30131731";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionState();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Critical Continuous Consumption_Detailed Report_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_14144_Dashboards_Consumption_KPI_Critical_Continuous_Consumption_Detailed_Report_Display()
        {
            testCaseId = "TC-14144";
            qTestUniqueId = "30514097";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalGatewayReportHeader();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Critical Continuous Consumption_Detailed Report_Title
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_14145_Dashboards_Consumption_KPI_Critical_Continuous_Consumption_Detailed_Report_Title()
        {
            testCaseId = "TC-14145";
            qTestUniqueId = "30514098";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalConsumptionReportTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Critical Continuous Consumption_Detailed Report_Columns_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_14146_Dashboards_Consumption_KPI_Critical_Continuous_Consumption_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-14146";
            qTestUniqueId = "30514099";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalConsumptionColumnsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Critical Continuous Consumption_Detailed Report_Default Grid View
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_14147_Dashboards_Consumption_KPI_Critical_Continuous_Consumption_Detailed_Report_Default_Grid_View()
        {
            testCaseId = "TC-14147";
            qTestUniqueId = "30514100";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinousCusumptionGridView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Critical Continuous Consumption_Detailed Report_Default Map View
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_14148_Dashboards_Consumption_KPI_Critical_Continuous_Consumption_Detailed_Report_Default_Map_View()
        {
            testCaseId = "TC-14148";
            qTestUniqueId = "30514101";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalContinuousDetailReportMapView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Critical Continuous Consumption_Details Report_Export PDF_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_14149_Dashboards_Consumption_KPI_Critical_Continuous_Consumption_Details_Report_Export_PDF_Display()
        {
            testCaseId = "TC-14149";
            qTestUniqueId = "30514102";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCritialContinousCusumptionExportPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Critical Continuous Consumption_Details Report_Export Excel_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_14150_Dashboards_Consumption_KPI_Critical_Continuous_Consumption_Details_Report_Export_Excel_Display()
        {
            testCaseId = "TC-14150";
            qTestUniqueId = "30514103";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCritialContinousCusumptionExportExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Critical Continuous Consumption_Detailed Report_Report Date Label_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_14154_Dashboards_Consumption_KPI_Critical_Continuous_Consumption_Detailed_Report_Report_Date_Label_Display()
        {
            testCaseId = "TC-14154";
            qTestUniqueId = "30514107";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCritialContinousCusumptionReportDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Warning Continous Consumption_Detailed Report_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_14155_Dashboards_Consumption_KPI_Warning_Continous_Consumption_Detailed_Report_Display()
        {
            testCaseId = "TC-14155";
            qTestUniqueId = "30514148";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionDetailedReport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Warning Continous Consumption_Detailed Report_Title
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_14156_Dashboards_Consumption_KPI_Warning_Continous_Consumption_Detailed_Report_Title()
        {
            testCaseId = "TC-14156";
            qTestUniqueId = "30514149";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionDetailedReport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Warning Continous Consumption_Details Report_Default Grid View
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_14158_Dashboards_Consumption_KPI_Warning_Continous_Consumption_Details_Report_Default_Grid_View()
        {
            testCaseId = "TC-14158";
            qTestUniqueId = "30514151";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningCusumptionGridView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Warning Continous Consumption_Details Report Map View
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_14159_Dashboards_Consumption_KPI_Warning_Continous_Consumption_Details_Report_Map_View()
        {
            testCaseId = "TC-14159";
            qTestUniqueId = "30514152";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningCusumptionMapView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Warning Continous Consumption_Details Report_Export PDF_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_14160_Dashboards_Consumption_KPI_Warning_Continous_Consumption_Details_Report_Export_PDF_Display()
        {
            testCaseId = "TC-14160";
            qTestUniqueId = "30514153";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningCusumptionMapView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Warning Continuous Consumption_Details Report_Export PDF Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_14160_Dashboards_Consumption_KPI_Warning_Continuous_Consumption_Details_Report_Export_PDF_Display()
        {
            testCaseId = "TC-14160";
            qTestUniqueId = "30514153";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningContinousCusumptionExportPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Warning Continuous Consumption_Details Report_Export Excel Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_14161_Dashboards_Consumption_KPI_Warning_Continuous_Consumption_Details_Report_Export_Excel_Display()
        {
            testCaseId = "TC-14161";
            qTestUniqueId = "30514154";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningContinousCusumptionExportExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Consumption KPI_Warning Continous Consumption_Detailed Report_Report Date Label_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_14165_Dashboards_Consumption_KPI_Warning_Continous_Consumption_Detailed_Report_Report_Date_Label_Display()
        {
            testCaseId = "TC-14165";
            qTestUniqueId = "30514158";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningContinousCusumptionReportDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Received via AMI_Detailed Report_Title
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15339_Dashboards_Meters_Received_via_AMI_Detailed_Report_Title()
        {
            testCaseId = "TC-15339";
            qTestUniqueId = "33868766";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedKPIviaAMITitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Received via AMI_Detailed Report_Export PDF_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15341_Dashboards_Meters_Received_via_AMI_Detailed_Report_Export_PDF_Display()
        {
            testCaseId = "TC-15341";
            qTestUniqueId = "33868768";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedKPIviaAMIExportPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Received via AMI_Detailed Report_Export Excel_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15343_Dashboards_Meters_Received_via_AMI_Detailed_Report_Export_Excel_Display()
        {
            testCaseId = "TC-15343";
            qTestUniqueId = "33868770";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedKPIviaAMIExportExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Dashboards_Meters Received via AMI_Detailed Report_Back to KPI_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15345_Dashboards_Meters_Received_via_AMI_Detailed_Report_Back_to_KPI_Display()
        {
            testCaseId = "TC-15345";
            qTestUniqueId = "33868774";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedKPIviaAMIBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Received via AMI_Detailed Report_Header Consistent
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15347_Dashboards_Meters_Received_via_AMI_Detailed_Report_Header_Consistent()
        {
            testCaseId = "TC-15347";
            qTestUniqueId = "33868776";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedviaAMIHeader();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Received via AMR_Detailed Report_Title
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15349_Dashboards_Meters_Received_via_AMR_Detailed_Report_Title()
        {
            testCaseId = "TC-15349";
            qTestUniqueId = "33871784";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedviaAMRHeader();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Received via AMR_Detailed Report_Export PDF_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15351_Dashboards_Meters_Received_via_AMR_Detailed_Report_Export_PDF_Display()
        {
            testCaseId = "TC-15351";
            qTestUniqueId = "33871789";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedviaAMRPDFDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Received via AMR_Detailed Report_Back to KPI_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15355_Dashboards_Meters_Received_via_AMR_Detailed_Report_Back_to_KPI_Display()
        {
            testCaseId = "TC-15355";
            qTestUniqueId = "33871795";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedviaAMRBackToKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Dashboards_Meters Received via AMR_Detailed Report_Header Consistent
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15357_Dashboards_Meters_Received_via_AMR_Detailed_Report_Header_Consistent()
        {
            testCaseId = "TC-15357";
            qTestUniqueId = "33871812";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateReceivedviaAMRHeader();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Dashboards_Meters Not Received_Detailed Report_Columns Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15360_Dashboards_Meters_Not_Received_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-15360";
            qTestUniqueId = "33872300";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNotReceivedColumnDetails();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Not Received_Detailed Report_Export Excel_Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15362_Dashboards_Meters_Not_Received_Detailed_Report_Export_Excel_Display()
        {
            testCaseId = "TC-15362";
            qTestUniqueId = "33872304";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNotReceivedExportExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Meters Not Received_Detailed Report_Back to KPI
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15366_Dashboards_Meters_Not_Received_Detailed_Report_Back_to_KPI()
        {
            testCaseId = "TC-15366";
            qTestUniqueId = "33872310";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNotReceivedBackToKPIClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Dashboards_Readings KPI_Complete_Detailed Report_Columns Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_19082_Dashboards_Readings_KPI_Complete_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-19082";
            qTestUniqueId = "40998367";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCompleteReadingsColumnDetails();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts By Consumption_Detailed Report_Columns Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_19087_Dashboards_Top_10_Accounts_By_Consumption_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-19087";
            qTestUniqueId = "40998610";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTop10ConsumptionDetailReportColumnDetails();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System_Consumption_Detailed_Report_MeterTypeMetrics_NotDisplayed
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10399_Dashboards_System_Consumption_Detailed_Report_MeterTypeMetrics_NotDisplayed()
        {
            testCaseId = "TC-10399";
            qTestUniqueId = "24894655";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMeterTypeIsNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System_Consumption_Detailed_Report_MeterSizeMetrics_NotDisplayed
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10400_Dashboards_System_Consumption_Detailed_Report_MeterSizeMetrics_NotDisplayed()
        {
            testCaseId = "TC-10400";
            qTestUniqueId = "24894657";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMeterSizeIsNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_System_Consumption_Detailed_Report_TotalMeterCount_NotDisplayed
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10403_Dashboards_System_Consumption_Detailed_Report_TotalMeterCount_NotDisplayed()
        {
            testCaseId = "TC-10403";
            qTestUniqueId = "24894660";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTotalMeterCounIsNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Dashboards_Top 10 Accounts By Consumption_Detailed Report_Columns Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_19897_Dashboards_Top_10_Accounts_By_Consumption_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-19897";
            qTestUniqueId = "42908945";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSystemConsumptionWidget();
                dashBoard.ValidateDetailedReportLink();
                dashBoard.ValidateGridView();
                dashBoard.clickonbactokpi();
                dashBoard.ValidateTop10ConsumptionDetailReportColumnDetails();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10357_Dashboard_System_Consumption_Detailed_Report_Meter_Size_Filter_Not_Displayed()
        {
            testCaseId = "TC-10357";
            qTestUniqueId = "24893189";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMeterSizeFilterNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10360_Dashboard_SystemConsumption_DetailedReport_MapView_Accounts_Display()
        {
            testCaseId = "TC-10360";
            qTestUniqueId = "24893192";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateAccountsDisplayintheMapview();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Map - Accounts Display - Valid Latitude Longitude
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7823_Dashboard_MapAccountsDisplayValidLatitudeLongitude()
        {
            testCaseId = "TC-7823";
            qTestUniqueId = "19875195";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateAllAccountsDisplayInTheMapviewDashBoard();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Map Widget - High Consumption Outlier - Not Displayed
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10235_Dashboard_MapWidgetHighConsumptionOutlierNotDisplayed()
        {
            testCaseId = "TC-10235";
            qTestUniqueId = "24857305";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateHighConsumptionOutlierIsNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Map Widget - Low Consumption Outlier - Not Displayed
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10236_Dashboard_MapWidgetLowConsumptionOutlierNotDisplayed()
        {
            testCaseId = "TC-10236";
            qTestUniqueId = "24857311";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateLowConsumptionOutlierIsNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Major Reverse Flow KPI - Detailed Report - URL Validation
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16967_MajorReverseFlowKPI_DetailedReportURL_Validation()
        {
            testCaseId = "TC-16967";
            qTestUniqueId = "36175454";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMajorReverseFlowKPIURL(url);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Minor Reverse Flow KPI - Detailed Report - URL Validation
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16968_MinorReverseFlowKPI_DetailedReportURL_Validation()
        {
            testCaseId = "TC-16968";
            qTestUniqueId = "36175456";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMinorReverseFlowKPIURL(url);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Top 10 Accounts By Consumption - Detailed Report - Actual/Estimated Toggle Removed - Grid
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17168_Dashboard_Top10AccountsByConsumption_DetailedReport_ActualEstimated_ToggleRemovedGrid()
        {
            testCaseId = "TC-17168";
            qTestUniqueId = "36856878";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenAccDetailReportActualEstimatedToggleGridRemoved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Top 10 Accounts By Consumption - Detailed Report - Actual/Estimated Toggle Removed - Map
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17170_Dashboard_Top10AccountsByConsumption_DetailedReport_ActualEstimated_ToggleRemovedMap()
        {
            testCaseId = "TC-17170";
            qTestUniqueId = "36857142";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenAccDetailReportActualEstimatedToggleMapRemoved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - System Consumption - Detailed Report - Actual/Estimated Toggle Removed - Grid
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17169_Dashboard_SystemConsumption_DetailedReport_ActualEstimated_ToggleRemovedGrid()
        {
            testCaseId = "TC-17169";
            qTestUniqueId = "36856879";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSystemConsumptionDetailReportActualEstimatedToggleGridRemoved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - System Consumption - Detailed Report - Actual/Estimated Toggle Removed - Map
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17171_Dashboard_SystemConsumption_DetailedReport_ActualEstimated_ToggleRemovedMap()
        {
            testCaseId = "TC-17171";
            qTestUniqueId = "36857143";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSystemConsumptionDetailReportActualEstimatedToggleMapRemoved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - System Consumption - Detailed Report - Grid Consumption Format - Three decimal place values
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17388_Dashboard_SystemConsumption_DetailedReport_GridConsumptionFormat_ThreeDecimalPlaceValuesGrid()
        {
            testCaseId = "TC-17388";
            qTestUniqueId = "37665203";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSystemConsumptionDetailReportConsumptionValuesDecimalFormatGrid();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Critical Continuous Consumption KPI - Detailed Report - Columns Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_19095_Dashboard_CriticalContinuousConsumptionKPIDetailedReportColumnsDisplay()
        {
            testCaseId = "TC-19095";
            qTestUniqueId = "41025623";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateDashboardCriticalKPIDetailedReportColumnsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Warning Continuous Consumption KPI - Detailed Report - Columns Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_19100_Dashboard_WarningContinuousConsumptionKPIDetailedReportColumnsDisplay()
        {
            testCaseId = "TC-19100";
            qTestUniqueId = "41025710";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateDashboardWarningKPIDetailedReportColumnsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Normal Continuous Consumption KPI - Detailed Report - Columns Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_19105_Dashboard_NormalContinuousConsumptionKPIDetailedReportColumnsDisplay()
        {
            testCaseId = "TC-19105";
            qTestUniqueId = "41025733";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateDashboardNormalKPIDetailedReportColumnsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Skipped Readings KPI - Detailed Report - Columns Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20859_Dashboard_SkippedReadingsKPIDetailedReportColumnsDisplay()
        {
            testCaseId = "TC-20859";
            qTestUniqueId = "44940388";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateDashboardSkippedKPIDetailedReportColumnsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - InComplete Readings KPI - Detailed Report - Columns Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20866_Dashboard_InCompleteReadingsKPIDetailedReportColumnsDisplay()
        {
            testCaseId = "TC-20866";
            qTestUniqueId = "44958578";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateDashboardIncompleteKPIDetailedReportColumnsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Major - Reverse Flow - Detailed Report Grid - Kendo Grid - Display
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24234_Dashboard_MajorReverseFlow_DetailedReportGrid_KendoGrid_Display()
        {
            testCaseId = "TC-24234";
            qTestUniqueId = "52085840";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonReverseFlowKpicount("majorreverseflow");
                dashBoard.ValidateKendoGridDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Major - Reverse Flow - Detailed Report Grid - Google Maps - Display
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24235_Dashboard_MajorReverseFlow_DetailedReportGrid_GoogleMaps_Display()
        {
            testCaseId = "TC-24235";
            qTestUniqueId = "52085926";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonReverseFlowKpicount("majorreverseflow");
                dashBoard.ValidateGoogleMapsDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Minor - Reverse Flow - Detailed Report Grid - Google Maps - Display
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24236_Dashboard_MinorReverseFlow_DetailedReportGrid_GoogleMaps_Display()
        {
            testCaseId = "TC-24236";
            qTestUniqueId = "52086072";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonReverseFlowKpicount("minorreverseflow");
                dashBoard.ValidateGoogleMapsDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Minor - Reverse Flow - Detailed Report Grid - Kendo Grid - Display
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24237_Dashboard_MinorReverseFlow_DetailedReportGrid_KendoGrid_Display()
        {
            testCaseId = "TC-24237";
            qTestUniqueId = "52086073";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonReverseFlowKpicount("minorreverseflow");
                dashBoard.ValidateKendoGridDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Received via AMI - Kendo Detailed Report - Google Maps - Display
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24240_Dashboard_ReceivedViaAMI_KendoReportGrid_GoogleMaps_Display()
        {
            testCaseId = "TC-24240";
            qTestUniqueId = "52109848";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNavigateToReveivedViaAMIKPI();
                dashBoard.ValidateGoogleMapsDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Received via AMR - Kendo Detailed Report - Google Maps - Display
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24241_Dashboard_ReceivedViaAMR_KendoReportGrid_GoogleMaps_Display()
        {
            testCaseId = "TC-24241";
            qTestUniqueId = "52109849";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNavigateToReveivedViaAMRKPI();
                dashBoard.ValidateGoogleMapsDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Kendo Conversion - Dashboard  - Intermittent Consumption KPI - Detailed Report  - Map View - Clusters display
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_25462_KendoConversion_Dashboard_IntermittentConsumptionKPI_DetailedReport_MapView_Clustersdisplay()
        {
            testCaseId = "TC-25462";
            qTestUniqueId = "53727591"; 
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentKPIClusters();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - System Consumption - Detailed Report - Table Setting Button - Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24205_Dashboard_SystemConsumption_DetailedReport_TableSettingButton_Display()
        {
            testCaseId = "TC-24205";
            qTestUniqueId = "52065075";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateDetailReportPage();
                dashBoard.validate_TableSettingButton_Displayed_Report("System Consumption Detailed Report");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - System Consumption - Detailed Report - Column Rearrange
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24206_Dashboard_SystemConsumption_DetailedReport_ColumnRearrange()
        {
            testCaseId = "TC-24206";
            qTestUniqueId = "52065122";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateDetailReportPage();
                dashBoard.validate_ColumnRearrange_Dashboard_Report("System Consumption Detailed Report");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - System Consumption - Detailed Report - Show/Hide Columns
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24207_Dashboard_SystemConsumption_DetailedReport_ShowOrHideColumns()
        {
            testCaseId = "TC-24207";
            qTestUniqueId = "52065142";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateDetailReportPage();
                dashBoard.validate_ShowHideColumns_Dashboard_Report("System Consumption Detailed Report");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - System Consumption - Detailed Report - Changes - Current User
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24209_Dashboard_SystemConsumption_DetailedReport_Changes_CurrentUser()
        {
            testCaseId = "TC-24209";
            qTestUniqueId = "52065192";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateDetailReportPage();
                dashBoard.validate_ShowHideColumns_Dashboard_Report("System Consumption Detailed Report", false);
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateDetailReportPage();
                dashBoard.ValidateShowHideColumnsAfterNavigatingToOtherPage("System Consumption Detailed Report");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - System Consumption - Detailed Report - Slide column Border 
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24208_Dashboard_SystemConsumption_DetailedReport_SlideColumnBorder()
        {
            testCaseId = "TC-24208";
            qTestUniqueId = "52065181";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateDetailReportPage();
                dashBoard.validate_SlideColumnBorder_Dashboard_Report("System Consumption Detailed Report");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Top 10 Account by Consumption - Detailed Report - Column Rearrange
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24210_Dashboard_Top10AccountByConsumption_DetailedReport_ColumnRearrange()
        {
            testCaseId = "TC-24210";
            qTestUniqueId = "52067625";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTop10ConsumptionReportDate();
                dashBoard.validate_ColumnRearrange_Dashboard_Report("Top 10 Account by Consumption");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Top 10 Account by Consumption - Detailed Report - Column Rearrange
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24211_Dashboard_Top10AccountByConsumption_DetailedReport_TableSettingButton_Display()
        {
            testCaseId = "TC-24211";
            qTestUniqueId = "52067626";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTop10ConsumptionReportDate();
                dashBoard.validate_TableSettingButton_Displayed_Report("Top 10 Account by Consumption");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Top 10 Account by Consumption - Detailed Report - Changes - Current User
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24212_Dashboard_Top10AccountByConsumption_DetailedReport_Changes_CurrentUser()
        {
            testCaseId = "TC-24212";
            qTestUniqueId = "52067627";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTop10ConsumptionReportDate();
                dashBoard.validate_ShowHideColumns_Dashboard_Report("Top 10 Account by Consumption", false);
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateTop10ConsumptionReportDate();
                dashBoard.ValidateShowHideColumnsAfterNavigatingToOtherPage("Top 10 Account by Consumption");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Top 10 Account by Consumption - Detailed Report - Slide column Border 
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24213_Dashboard_Top10AccountByConsumption_DetailedReport_SlideColumnBorder()
        {
            testCaseId = "TC-24213";
            qTestUniqueId = "52067628";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTop10ConsumptionReportDate();
                dashBoard.validate_SlideColumnBorder_Dashboard_Report("Top 10 Account by Consumption");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Top 10 Account by Consumption - Detailed Report - Show/Hide Columns
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24214_Dashboard_Top10AccountByConsumption_DetailedReport_ShowOrHideColumns()
        {
            testCaseId = "TC-24214";
            qTestUniqueId = "52067629";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTop10ConsumptionReportDate();
                dashBoard.validate_ShowHideColumns_Dashboard_Report("Top 10 Account by Consumption");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Critical Continuous Consumption KPI - Detailed Report - Changes - Current User
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24216_Dashboard_CriticalContinuousConsumptionKPI_DetailedReport_Changes_CurrentUser()
        {
            testCaseId = "TC-24216";
            qTestUniqueId = "52085263";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalContinuousConsumptionHTMLLink();
                dashBoard.validate_ShowHideColumns_Dashboard_Report("Critical Continuous Consumption KPI", false);
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateCriticalContinuousConsumptionHTMLLink();
                dashBoard.ValidateShowHideColumnsAfterNavigatingToOtherPage("Critical Continuous Consumption KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Critical Continuous Consumption KPI - Detailed Report - Slide column Border 
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24217_Dashboard_CriticalContinuousConsumptionKPI_DetailedReport_SlideColumnBorder()
        {
            testCaseId = "TC-24217";
            qTestUniqueId = "52085264";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalContinuousConsumptionHTMLLink();
                dashBoard.validate_SlideColumnBorder_Dashboard_Report("Critical Continuous Consumption KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Critical Continuous Consumption KPI - Detailed Report - Table Setting Button - Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24220_Dashboard_CriticalContinuousConsumptionKPI_DetailedReport_TableSettingButton_Display()
        {
            testCaseId = "TC-24220";
            qTestUniqueId = "52085267";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalContinuousConsumptionHTMLLink();
                dashBoard.validate_TableSettingButton_Displayed_Report("Critical Continuous Consumption KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Dashboard - Critical Continuous Consumption KPI - Detailed Report - Show/Hide Columns
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24218_Dashboard_CriticalContinuousConsumptionKPI_DetailedReport_ShowOrHideColumns()
        {
            testCaseId = "TC-24218";
            qTestUniqueId = "52085265";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalContinuousConsumptionHTMLLink();
                dashBoard.validate_ShowHideColumns_Dashboard_Report("Critical Continuous Consumption KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Critical Continuous Consumption KPI - Detailed Report - Column Rearrange
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24219_Dashboard_CriticalContinuousConsumptionKPI_DetailedReport_ColumnRearrange()
        {
            testCaseId = "TC-24219";
            qTestUniqueId = "52085266";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalContinuousConsumptionHTMLLink();
                dashBoard.validate_ColumnRearrange_Dashboard_Report("Critical Continuous Consumption KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Warning Continuous Consumption KPI - Detailed Report - Table Setting Button - Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24221_Dashboard_WarningContinuousConsumptionKPI_DetailedReport_TableSettingButton_Display()
        {
            testCaseId = "TC-24221";
            qTestUniqueId = "52085299";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionPageLoad();
              dashBoard.validate_TableSettingButton_Displayed_Report("Warning Continuous Consumption KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Warning Continuous Consumption KPI - Detailed Report - Column Rearrange
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24222_Dashboard_WarningContinuousConsumptionKPI_DetailedReport_ColumnRearrange()
        {
            testCaseId = "TC-24222";
            qTestUniqueId = "52085300";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionPageLoad();
                dashBoard.validate_ColumnRearrange_Dashboard_Report("Warning Continuous Consumption KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Warning Continuous Consumption KPI - Detailed Report - Show/Hide Columns
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24223_Dashboard_WarningContinuousConsumptionKPI_DetailedReport_ShowOrHideColumns()
        {
            testCaseId = "TC-24223";
            qTestUniqueId = "52085301";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionPageLoad();
                dashBoard.validate_ShowHideColumns_Dashboard_Report("Warning Continuous Consumption KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Warning Continuous Consumption KPI - Detailed Report - Slide column Border 
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24224_Dashboard_WarningContinuousConsumptionKPI_DetailedReport_SlideColumnBorder()
        {
            testCaseId = "TC-24224";
            qTestUniqueId = "52085302";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionPageLoad();
                dashBoard.validate_SlideColumnBorder_Dashboard_Report("Warning Continuous Consumption KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Warning Continuous Consumption KPI - Detailed Report - Changes - Current User
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24225_Dashboard_WarningContinuousConsumptionKPI_DetailedReport_Changes_CurrentUser()
        {
            testCaseId = "TC-24225";
            qTestUniqueId = "52085303";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionPageLoad();
                dashBoard.validate_ShowHideColumns_Dashboard_Report("Warning Continuous Consumption KPI", false);
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateWarningConsumptionPageLoad();
                dashBoard.ValidateShowHideColumnsAfterNavigatingToOtherPage("Warning Continuous Consumption KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Normal Continuous Consumption KPI - Detailed Report - Changes - Current User
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24226_Dashboard_NormalContinuousConsumptionKPI_DetailedReport_Changes_CurrentUser()
        {
            testCaseId = "TC-24226";
            qTestUniqueId = "52085342";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionPageLoad();
                dashBoard.validate_ShowHideColumns_Dashboard_Report("Normal Continuous Consumption KPI", false);
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateNormalConsumptionPageLoad();
                dashBoard.ValidateShowHideColumnsAfterNavigatingToOtherPage("Normal Continuous Consumption KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Normal Continuous Consumption KPI - Detailed Report - Slide column Border 
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24227_Dashboard_NormalContinuousConsumptionKPI_DetailedReport_SlideColumnBorder()
        {
            testCaseId = "TC-24227";
            qTestUniqueId = "52085343";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionPageLoad();
                dashBoard.validate_SlideColumnBorder_Dashboard_Report("Normal Continuous Consumption KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Normal Continuous Consumption KPI - Detailed Report - Show/Hide Columns
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24228_Dashboard_NormalContinuousConsumptionKPI_DetailedReport_ShowOrHideColumns()
        {
            testCaseId = "TC-24228";
            qTestUniqueId = "52085344";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionPageLoad();
                dashBoard.validate_ShowHideColumns_Dashboard_Report("Normal Continuous Consumption KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Normal Continuous Consumption KPI - Detailed Report - Column Rearrange
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24229_Dashboard_NormalContinuousConsumptionKPI_DetailedReport_ColumnRearrange()
        {
            testCaseId = "TC-24229";
            qTestUniqueId = "52085345";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionPageLoad();
                dashBoard.validate_ColumnRearrange_Dashboard_Report("Normal Continuous Consumption KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Normal Continuous Consumption KPI - Detailed Report - Table Setting Button - Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24230_Dashboard_NormalContinuousConsumptionKPI_DetailedReport_TableSettingButton_Display()
        {
            testCaseId = "TC-24230";
            qTestUniqueId = "52085346";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionPageLoad();
                dashBoard.validate_TableSettingButton_Displayed_Report("Normal Continuous Consumption KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Meters Received Via AMI KPI - Detailed Report - Show/Hide Columns
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24242_Dashboard_MetersReceivedViaAMIKPI_DetailedReport_ShowOrHideColumns()
        {
            testCaseId = "TC-24242";
            qTestUniqueId = "52113209";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNavigateToReveivedViaAMIKPI();
                dashBoard.validate_ShowHideColumns_Dashboard_Report("Meters Received Via AMI KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Meters Received Via AMI KPI - Detailed Report - Slide column Border 
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24243_Dashboard_MetersReceivedViaAMIKPI_DetailedReport_SlideColumnBorder()
        {
            testCaseId = "TC-24243";
            qTestUniqueId = "52113210";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNavigateToReveivedViaAMIKPI();
                dashBoard.validate_SlideColumnBorder_Dashboard_Report("Meters Received Via AMI KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Meters Received Via AMI KPI - Detailed Report - Changes - Current User
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24244_Dashboard_MetersReceivedViaAMIKPI_DetailedReport_Changes_CurrentUser()
        {
            testCaseId = "TC-24244";
            qTestUniqueId = "52113211";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNavigateToReveivedViaAMIKPI();
                List<string> beforeArrangeColumnValues = dashBoard.validate_ColumnRearrange_Dashboard_Report("Meters Received Via AMI KPI", false);              
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateNavigateToReveivedViaAMIKPI();
                dashBoard.validate_ColumnRearrange_AfterNavigatingToOtherPage(beforeArrangeColumnValues, "Meters Received Via AMI KPI");

                dashBoard.validate_ShowHideColumns_Dashboard_Report("Meters Received Via AMI KPI", false);
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateNavigateToReveivedViaAMIKPI();
                dashBoard.ValidateShowHideColumnsAfterNavigatingToOtherPage("Meters Received Via AMI KPI", false);
  
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Meters Received Via AMI KPI - Detailed Report - Table Setting Button - Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24245_Dashboard_MetersReceivedViaAMIKPI_DetailedReport_TableSettingButton_Display()
        {
            testCaseId = "TC-24245";
            qTestUniqueId = "52113212";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
               dashBoard.ValidateNavigateToReveivedViaAMIKPI();
               dashBoard.validate_TableSettingButton_Displayed_Report("Meters Received Via AMI KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Meters Received Via AMI KPI - Detailed Report - Column Rearrange
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24246_Dashboard_MetersReceivedViaAMIKPI_DetailedReport_ColumnRearrange()
        {
            testCaseId = "TC-24246";
            qTestUniqueId = "52113213";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNavigateToReveivedViaAMIKPI();
                dashBoard.validate_ColumnRearrange_Dashboard_Report("Meters Received Via AMI KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Meters Received Via AMR KPI - Detailed Report - Table Setting Button - Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24260_Dashboard_MetersReceivedViaAMRKPI_DetailedReport_TableSettingButton_Display()
        {
            testCaseId = "TC-24260";
            qTestUniqueId = "52113212";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNavigateToReveivedViaAMRKPI();
                dashBoard.validate_TableSettingButton_Displayed_Report("Meters Received Via AMR KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Meters Received Via AMR KPI - Detailed Report - Changes - Current User
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24261_Dashboard_MetersReceivedViaAMRKPI_DetailedReport_Changes_CurrentUser()
        {
            testCaseId = "TC-24261";
            qTestUniqueId = "52113211";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNavigateToReveivedViaAMRKPI();
                List<string> beforeArrangeColumnValues = dashBoard.validate_ColumnRearrange_Dashboard_Report("Meters Received Via AMR KPI", false);
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateNavigateToReveivedViaAMRKPI();
                dashBoard.validate_ColumnRearrange_AfterNavigatingToOtherPage(beforeArrangeColumnValues, "Meters Received Via AMR KPI");

                dashBoard.validate_ShowHideColumns_Dashboard_Report("Meters Received Via AMR KPI", false);
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateNavigateToReveivedViaAMRKPI();
                dashBoard.ValidateShowHideColumnsAfterNavigatingToOtherPage("Meters Received Via AMR KPI", false);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Meters Received Via AMR KPI - Detailed Report - Column Rearrange
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24259_Dashboard_MetersReceivedViaAMR_KPI_DetailedReport_ColumnRearrange()
        {
            testCaseId = "TC-24259";
            qTestUniqueId = "52115211";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNavigateToReveivedViaAMRKPI();
                dashBoard.validate_ColumnRearrange_Dashboard_Report("Meters Received Via AMR KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Meters Received Via AMR KPI - Detailed Report - Slide column Border 
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24262_Dashboard_MetersReceivedViaAMRKPI_DetailedReport_SlideColumnBorder()
        {
            testCaseId = "TC-24262";
            qTestUniqueId = "52115214";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNavigateToReveivedViaAMRKPI();
                dashBoard.validate_SlideColumnBorder_Dashboard_Report("Meters Received Via AMR KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Meters Received Via AMR KPI - Detailed Report - Show/Hide Columns
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24263_Dashboard_MetersReceivedViaAMRKPI_DetailedReport_ShowOrHideColumns()
        {
            testCaseId = "TC-24263";
            qTestUniqueId = "52115215";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNavigateToReveivedViaAMRKPI();
                dashBoard.validate_ShowHideColumns_Dashboard_Report("Meters Received Via AMR KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Meters Not Received KPI - Detailed Report - Show/Hide Columns
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24264_Dashboard_MetersNotReceivedKPI_DetailedReport_ShowOrHideColumns()
        {
            testCaseId = "TC-24264";
            qTestUniqueId = "52115240";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNavigateToNotReceivedKPI();
                dashBoard.validate_ShowHideColumns_Dashboard_Report("MMeters Not Received KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Meters Not Received KPI - Detailed Report - Slide column Border 
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24265_Dashboard_MetersNotReceivedKPI_DetailedReport_SlideColumnBorder()
        {
            testCaseId = "TC-24265";
            qTestUniqueId = "52115241";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNavigateToNotReceivedKPI();
                dashBoard.validate_SlideColumnBorder_Dashboard_Report("Meters Not Received KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        /// <summary>
        /// Dashboard - Meters Not Received KPI - Detailed Report - Changes - Current User
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24266_Dashboard_MetersNotReceivedKPI_DetailedReport_Changes_CurrentUser()
        {
            testCaseId = "TC-24266";
            qTestUniqueId = "52115242";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNavigateToNotReceivedKPI();
                List<string> beforeArrangeColumnValues = dashBoard.validate_ColumnRearrange_Dashboard_Report("Meters Not Received KPI", false);
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateNavigateToNotReceivedKPI();
                dashBoard.validate_ColumnRearrange_AfterNavigatingToOtherPage(beforeArrangeColumnValues, "Meters Not Received KPI");

                dashBoard.validate_ShowHideColumns_Dashboard_Report("Meters Not Received KPI", false);
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateNavigateToNotReceivedKPI();
                dashBoard.ValidateShowHideColumnsAfterNavigatingToOtherPage("Meters Not Received KPI", false);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Meters Not Received KPI - Detailed Report - Changes - Table setting button
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24267_Dashboard_MetersNotReceivedKPI_DetailedReport_TableSettingButton_Display()
        {
            testCaseId = "TC-24267";
            qTestUniqueId = "52115243";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNavigateToNotReceivedKPI();
                dashBoard.validate_TableSettingButton_Displayed_Report("Meters Not Received KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Meters Not Received KPI - Detailed Report - Column Rearrange
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24268_Dashboard_MetersNotReceivedKPI_DetailedReport_ColumnRearrange()
        {
            testCaseId = "TC-24268";
            qTestUniqueId = "52115244";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNavigateToNotReceivedKPI();
                dashBoard.validate_ColumnRearrange_Dashboard_Report("Meters Not Received KPI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Critical Continuous Consumption KPI - Detailed Report - Changes - Current User
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24279_Dashboard_CriticalContinuousConsumptionKPI_DetailedReport_Changes_CurrentUser()
        {
            testCaseId = "TC-24279";
            qTestUniqueId = "52132719";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCriticalContinuousConsumptionHTMLLink();
                List<string> beforeArrangeColumnValues = dashBoard.validate_ColumnRearrange_Dashboard_Report("Critical Continuous Consumption KPI", false);
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateCriticalContinuousConsumptionHTMLLink();
                dashBoard.validate_ColumnRearrange_AfterNavigatingToOtherPage(beforeArrangeColumnValues, "Critical Continuous Consumption KPI");

                dashBoard.validate_ShowHideColumns_Dashboard_Report("Critical Continuous Consumption KPI", false);
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateNavigateToReveivedViaAMIKPI();
                dashBoard.ValidateShowHideColumnsAfterNavigatingToOtherPage("Critical Continuous Consumption KPI", false);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Warning Continuous Consumption KPI - Detailed Report - Changes - Current User
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24287_Dashboard_WarningContinuousConsumptionKPI_DetailedReport_Changes_CurrentUser()
        {
            testCaseId = "TC-24287";
            qTestUniqueId = "52132981";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateWarningConsumptionPageLoad();
                List<string> beforeArrangeColumnValues = dashBoard.validate_ColumnRearrange_Dashboard_Report("Warning Continuous Consumption KPI", false);
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateWarningConsumptionPageLoad();
                dashBoard.validate_ColumnRearrange_AfterNavigatingToOtherPage(beforeArrangeColumnValues, "Warning Continuous Consumption KPI");

                dashBoard.validate_ShowHideColumns_Dashboard_Report("Warning Continuous Consumption KPI", false);
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateWarningConsumptionPageLoad();               
                dashBoard.ValidateShowHideColumnsAfterNavigatingToOtherPage("Warning Continuous Consumption KPI", false);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Normal - Continuous Consumption Detailed Report KPI - Changes - Current User
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24290_Dashboard_NormalContinuousConsumptionKPI_DetailedReport_Changes_CurrentUser()
        {
            testCaseId = "TC-24290";
            qTestUniqueId = "52133015";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateNormalConsumptionPageLoad();
                List<string> beforeArrangeColumnValues = dashBoard.validate_ColumnRearrange_Dashboard_Report("Normal Continuous Consumption KPI", false);
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateNormalConsumptionPageLoad();
                dashBoard.validate_ColumnRearrange_AfterNavigatingToOtherPage(beforeArrangeColumnValues, "Normal Continuous Consumption KPI");

                dashBoard.validate_ShowHideColumns_Dashboard_Report("Normal Continuous Consumption KPI", false);
                landing.ValidateReportsNavigatedPage();
                dashBoard.ValidateDashBoardNavigatedPage();
                dashBoard.ValidateNormalConsumptionPageLoad();
                dashBoard.ValidateShowHideColumnsAfterNavigatingToOtherPage("Normal Continuous Consumption KPI", false);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Dashboard - Meters Not Received KPI - Detailed Report - Columns Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_19110_Dashboard_MetersNotReceivedKPIDetailedReportColumnsDisplay()
        {
            testCaseId = "TC-19110";
            qTestUniqueId = "41027949";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateDashboardMeterNotReceivedKPIDetailedReportColumnsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Meters Received via AMR KPI - Detailed Report - Columns Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_19116_Dashboard_MeterReceivedVia_AMRKPIDetailedReportColumnsDisplay()
        {
            testCaseId = "TC-19116";
            qTestUniqueId = "41028012";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateDashboardMeterReceivedKPIDetailedReportColumnsDisplay("Meters Received via AMR");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Meters Received via AMI KPI - Detailed Report - Columns Display
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_19117_Dashboard_MeterReceivedViaAMI_KPIDetailedReportColumnsDisplay()
        {
            testCaseId = "TC-19177";
            qTestUniqueId = "41055344";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateDashboardMeterReceivedKPIDetailedReportColumnsDisplay("Meters Received via AMI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - System Consumption - Detailed Report - Group Filter - Default Selection
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20464_Dashboard_SystemConsumption_DetailedReport_GroupFilterDefaultSelection()
        {
            testCaseId = "TC-20464";
            qTestUniqueId = "44011296";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateDashboardSystemConsumptionDetailedReportGroupFilterDefaultSelection();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10369_Dashboard_SystemConsumption_DetailedReport_MapView_AccountPin_Details_Display()
        {
            testCaseId = "TC-10369";
            qTestUniqueId = "24893299";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateAccountsDisplayintheMapview();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10370_Dashboard_SystemConsumption_DetailedReport_MapView_DateRange_Updated()
        {
            testCaseId = "TC-10370";
            qTestUniqueId = "24893300";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateAccountsDisplayintheMapviewAfterUpdatingDates();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10375_Dashboard_System_Consumption_Detailed_Report_Account_Display()
        {
            testCaseId = "TC-10375";
            qTestUniqueId = "24893346";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateAccountsintheGrid();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10402_Dashboard_SystemConsumption_DetailedReport_DateRangeUpdated()
        {
            testCaseId = "TC-10402";
            qTestUniqueId = "24894659";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateAccountsintheGridAfterUpdatingDateRange();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10519_Dashboard_SystemConsumption_Detailedreport_ConsumptionValues_UOM()
        {
            testCaseId = "TC-10519";
            qTestUniqueId = "24914296";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                string uom = (utilityManagement.verifyDefaultUOM()).Split(' ')[1];
                dashBoard.validateUOMUnitintheGrid("systemConsumption", uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        /// <summary>
        /// Dashboard - Top 10 Accounts By Consumption - Detailed Report - Grid View - No Consumption Data
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10310_Dashboard_Top10AccountsByConsumption_DetailedReport_GridView_NoConsumptionData()
        {
            testCaseId = "TC-10310";
            qTestUniqueId = "24873009";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.SwitchToUtility(utilityName);
                dashBoard.ValidateTopTenDetailReportNoData();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Dashboard - Top 10 Accounts By Consumption - Detailed Report - Grid View - Accounts Display
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10307_Dashboard_Top10AccountsByConsumption_DetailedReport_GridView_AccountsDisplay()
        {
            testCaseId = "TC-10307";
            qTestUniqueId = "24872540";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenDetailReportDataPresent();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Dashboard - Top 10 Accounts By Consumption - Detailed Report - Map View - Accounts Display
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10309_Dashboard_Top10AccountsByConsumption_DetailedReport_MapView_AccountsDisplay()
        {
            testCaseId = "TC-10309";
            qTestUniqueId = "24873008";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateTopTenDetailReportMapView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - System Consumption - Detailed Report - UoM Imperial Gallons
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13701_Dashboard_SystemConsumption_DetailedReport_UoM_ImperialGallons()
        {
            testCaseId = "TC-13701";
            qTestUniqueId = "29681706";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                uom = testData["UOM"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateSelectUOMUtility(uom);
                dashBoard.validateAllUOMUnitsInTheSystemConsumptionGrid(uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Top 10 Accounts by Consumption - Detailed Report - UoM Imperial Gallons
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13707_Dashboard_Top10AccountsByConsumption_DetailedReport_UoM_ImperialGallons()
        {
            testCaseId = "TC-13707";
            qTestUniqueId = "29681712";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                uom = testData["UOM"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateSelectUOMUtility(uom);
                dashBoard.validateAllUOMUnitsInTheTop10AccountsConsumptionGrid(uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - System Consumption - Detailed Report - UoM Liters
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13713_Dashboard_SystemConsumption_DetailedReport_UoM_Liters()
        {
            testCaseId = "TC-13713";
            qTestUniqueId = "29681718";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                uom = testData["UOM"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateSelectUOMUtility(uom);
                dashBoard.validateAllUOMUnitsInTheSystemConsumptionGrid(uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Top 10 Accounts by Consumption - Detailed Report - UoM Liters
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13719_Dashboard_Top10AccountsByConsumption_DetailedReport_UoM_Liters()
        {
            testCaseId = "TC-13719";
            qTestUniqueId = "29681724";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                uom = testData["UOM"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateSelectUOMUtility(uom);
                dashBoard.validateAllUOMUnitsInTheTop10AccountsConsumptionGrid(uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Top 10 Accounts By Consumption - Detailed Report - Consumption Column Validation
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10313_Dashboard_Top10AccountsByConsumption_ConsumptionColumnValidation()
        {
            testCaseId = "TC-10313";
            qTestUniqueId = "24873014";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateTop10ConsumptionData();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10525_Dashboard_SystemConsumption_ConsumptionBars_Display()
        {
            testCaseId = "TC-10525";
            qTestUniqueId = "24914307";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateSystemConsumptionbarchart(url);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12058_Dashboards_SystemConsumptionReport_UnitofMeasure_DefaultUOM()
        {
            testCaseId = "TC-12058";
            qTestUniqueId = "25810888";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                string uom = (utilityManagement.verifyDefaultUOM()).Split(' ')[1];
                dashBoard.validateUOMUnitintheGridafterUpdatingDates(uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Kendo Conversion - Dashboard - Intermittent Consumption KPI - Detailed Report - Table settings
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_25315_KendoConversion_Dashboard_IntermittentConsumptionKPI_DetailedReport_TableSettings()
        {
            testCaseId = "TC-25315";
            qTestUniqueId = "53720352";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentKPIReportDate();
                dashBoard.validate_ShowHideColumns_Dashboard_Report("Intermittent Consumption KPI Detailed Report");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Kendo Conversion - Dashboard - Intermittent Consumption KPI Detail report - Columns resizable
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_25320_KendoConversion_Dashboard_IntermittentConsumptionKPI_DetailedReport_ColumnsResizable()
        {
            testCaseId = "TC-25320";
            qTestUniqueId = "53720357";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentKPIReportDate();
                dashBoard.validate_SlideColumnBorder_Dashboard_Report("Intermittent Consumption KPI Detailed Report");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// <summary>
        /// Kendo Conversion - Dashboard - Complete Readings KPI - Detailed Report - Table settings
        /// </summary>
        [Category("Dashboard")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_25351_KendoConversion_Dashboard_CompleteReadingsKPI_DetailedReport_TableSettings()
        {
            testCaseId = "TC-25351";
            qTestUniqueId = "53725265";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonCompletedKpicount("complete");
                dashBoard.validate_TableSettingsScreen("Complete Readings KPI Detailed Report");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception e)
            {
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12059_Dashboards_SystemConsumption_DetailedReport_UOMDropdown_NotDisplayed()
        {
            testCaseId = "TC-12059";
            qTestUniqueId = "25810889";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateUOMFilterNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13665_Dashboard_SystemConsumption_DetailedReport_UoMCubicFeet()
        {

            testCaseId = "TC-13665";
            qTestUniqueId = "29681670";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                string uom = utilityManagement.verifyDefaultUOM();
                if (uom != "(FT3) Cubic Feet")
                {
                    uom = "Cubic Feet";
                    utilityManagement.changeDefaultUOM(uom);
                }
                else if (uom == "(FT3) Cubic Feet")
                {
                    var firstSpaceIndex = uom.IndexOf(" ");
                    uom = uom.Substring(firstSpaceIndex + 1);
                }
                dashBoard.validateAllUOMUnitsInTheSystemConsumptionGrid("SystemConsumption", uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13671_Dashboard_Top10AccountsbyConsumption_DetailedReport_UoMCubicFeet()
        {
            testCaseId = "TC-13671";
            qTestUniqueId = "29681676";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                string uom = utilityManagement.verifyDefaultUOM();
                if (uom != "(FT3) Cubic Feet")
                {
                    uom = "Cubic Feet";
                    utilityManagement.changeDefaultUOM(uom);
                }
                else if (uom == "(FT3) Cubic Feet")
                {
                    var firstSpaceIndex = uom.IndexOf(" ");
                    uom = uom.Substring(firstSpaceIndex + 1);
                }

                dashBoard.validateAllUOMUnitsInTheSystemConsumptionGrid("top10Accounts", uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13677_Dashboard_SystemConsumption_DetailedReport_UoMCubicMeters()
        {
            testCaseId = "TC-13677";
            qTestUniqueId = "29681682";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                string uom = utilityManagement.verifyDefaultUOM();
                if (uom != "(M3) Cubic Meters")
                {
                    uom = "Cubic Meters";
                    utilityManagement.changeDefaultUOM(uom);
                }
                else if (uom == "(M3) Cubic Meters")
                {
                    var firstSpaceIndex = uom.IndexOf(" ");
                    uom = uom.Substring(firstSpaceIndex + 1);
                }

                dashBoard.validateAllUOMUnitsInTheSystemConsumptionGrid("SystemConsumption", uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13683_Dashboard_Top10AccountsbyConsumption_DetailedReport_UoMCubicMeters()
        {
            testCaseId = "TC-13683";
            qTestUniqueId = "29681688";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                string uom = utilityManagement.verifyDefaultUOM();
                if (uom != "(M3) Cubic Meters")
                {
                    uom = "Cubic Meters";
                    utilityManagement.changeDefaultUOM(uom);
                }
                else if (uom == "(M3) Cubic Meters")
                {
                    var firstSpaceIndex = uom.IndexOf(" ");
                    uom = uom.Substring(firstSpaceIndex + 1);
                }
                dashBoard.validateAllUOMUnitsInTheSystemConsumptionGrid("top10Accounts", uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13689_Dashboard_SystemConsumption_DetailedReport_UoMGallons()
        {
            testCaseId = "TC-13689";
            qTestUniqueId = "29681694";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                string uom = utilityManagement.verifyDefaultUOM();
                if (uom != "(GAL) Gallons")
                {
                    uom = "Gallons";
                    utilityManagement.changeDefaultUOM(uom);
                }
                else if (uom == "(GAL) Gallons")
                {
                    var firstSpaceIndex = uom.IndexOf(" ");
                    uom = uom.Substring(firstSpaceIndex + 1);
                }
                dashBoard.validateAllUOMUnitsInTheSystemConsumptionGrid("SystemConsumption", uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13695_Dashboard_Top10AccountsbyConsumption_DetailedReport_UoMGallons()
        {
            testCaseId = "TC-13695";
            qTestUniqueId = "29681700";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                string uom = utilityManagement.verifyDefaultUOM();
                if (uom != "(GAL) Gallons")
                {
                    uom = "Gallons";
                    utilityManagement.changeDefaultUOM(uom);
                }
                else if (uom == "(GAL) Gallons")
                {
                    var firstSpaceIndex = uom.IndexOf(" ");
                    uom = uom.Substring(firstSpaceIndex + 1);
                }
                dashBoard.validateAllUOMUnitsInTheSystemConsumptionGrid("top10Accounts", uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15241_Dashboard_MetersReceivedviaAMIKPI_MeterCount_Include_LatestReadingFromCMIU_AutoCompleteWindow()
        {
            testCaseId = "TC-15241";
            qTestUniqueId = "33673150";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateReceiveKpi("ami");
                dashBoard.clickonReceiveKpicount("ami");
                dashBoard.validateMiuId(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15242_Dashboard_MetersReceivedvia_AMIKPIMeter_CountInclude_LatestReadingFromR900v4_AutoCompleteWindow()
        {
            testCaseId = "TC-15242";
            qTestUniqueId = "33673153";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateReceiveKpi("ami");
                dashBoard.clickonReceiveKpicount("ami");
                dashBoard.validateMiuId(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15243_Dashboard_MetersReceivedvia_AMIKPI_MeterCount_IncludeLatestReadingFromR900v5_AutoCompleteWindow()
        {
            testCaseId = "TC-15243";
            qTestUniqueId = "33673154";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateReceiveKpi("ami");
                dashBoard.clickonReceiveKpicount("ami");
                dashBoard.validateMiuId(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15244_Dashboard_MetersReceivedvia_AMIKPIMeterCount_IncludeLatestReadingFromR450_AutoCompleteWindow()
        {
            testCaseId = "TC-15244";
            qTestUniqueId = "33673155";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateReceiveKpi("ami");
                dashBoard.clickonReceiveKpicount("ami");
                dashBoard.validateMiuId(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15306_Dashboard_DashboardMap_MajorReverse_FlowLink()
        {
            testCaseId = "TC-15306";
            qTestUniqueId = "33767438";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.dashboardMapView("Major Reverse Flow");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15308_Dashboard_DashboardMap_CriticalContinuousConsumptionLink()
        {
            testCaseId = "TC-15308";
            qTestUniqueId = "33767440";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.dashboardMapView("Critical Continuous Consumption");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15359_Dashboard_MetersNotReceivedKPI_Detailed_ReportTitle()
        {
            testCaseId = "TC-15359";
            qTestUniqueId = "33872299";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonReceiveKpicount("notreceived");
                dashBoard.verifyMeterNotReceived();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Critical Continuous Consumption KPI - Upper Text Field
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13902_Dashboard_CriticalContinuousConsumption_UpperTextField()
        {
            testCaseId = "TC-13902";
            qTestUniqueId = "30023571";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinuousConsumptionKPIText(1);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Dashboard - Warning Continuous Consumption KPI - Upper Text Field
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13903_Dashboard_WarningContinuousConsumptionKPI_UpperTextField()
        {
            testCaseId = "TC-13903";
            qTestUniqueId = "30023572";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinuousConsumptionKPIText(2);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Normal Continuous Consumption KPI - Upper Text Field
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13904_Dashboard_NormalContinuousConsumption_UpperTextField()
        {
            testCaseId = "TC-13904";
            qTestUniqueId = "30023573";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinuousConsumptionKPIText(3);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard- Intermittent Continuous Consumption KPI - Upper Text Field
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13905_Dashboard_IntermittentContinuousConsumption_UpperTextField()
        {
            testCaseId = "TC-13905";
            qTestUniqueId = "30023574";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinuousConsumptionKPIText(4);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Dashboard - Continuous Consumption KPI - Widget - Lower Text Field
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13906_Dashboard_ContinuousConsumptionKPIWidget_LowerTextField()
        {
            testCaseId = "TC-13906";
            qTestUniqueId = "30023575";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinuousConsumptionKPI_ValidateFooter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard - Continuous Consumption KPI - Widget - Count Format
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13907_Dashboard_ContinuousConsumptionKPIWidget_CountForma()
        {
            testCaseId = "TC-13907";
            qTestUniqueId = "30023576";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinuousConsumptionKPI_ValidateFooter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Dashboard_Continuous Consumption_Detailed Report_Data Validation_Date
        /// </summary>
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13957_Dashboard_ContinuousConsumption_DetailedReport_DataValidation_Date()
        {
            testCaseId = "TC-13957";
            qTestUniqueId = "30131733";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinuousConsumptionReport_DateFormat();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }



        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15368_Dashboard_IncompleteReadingsKPI_DetailedReport_StatusColumn_AccountStatus_ACTI_Display()
        {
            testCaseId = "TC-15368";
            qTestUniqueId = "33902264";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonCompletedKpicount("incomplete");
                dashBoard.validateStatusforAllItems("ACTI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15369_Dashboard_IncompleteReadingsKPI_DetailedReport_StatusColumn_AccountStatus_INACDisplay()
        {
            testCaseId = "TC-15369";
            qTestUniqueId = "33902265";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonCompletedKpicount("incomplete");
                dashBoard.validateStatusforAllItems("INAC");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15372_Dashboard_IncompleteReadingsKPI_DetailedReport_StatusColumns_Displayorder()
        {
            testCaseId = "TC-15372";
            qTestUniqueId = "33902271";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonCompletedKpicount("incomplete");
                dashBoard.validateStatusColumnOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15373_Dashboard_IncompleteReadingsKPI_DetailedReport_SortOrder()
        {
            testCaseId = "TC-15373";
            qTestUniqueId = "33902293";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonCompletedKpicount("incomplete");
                dashBoard.validateAscendingOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15374_Dashboard_IncompleteReadingsKPI_DetailedReport_AccountStatus_Displayforeachrecord()
        {
            testCaseId = "TC-15374";
            qTestUniqueId = "33902296";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonCompletedKpicount("incomplete");
                dashBoard.ValidateStatus();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15378_Dashboard_CompleteReadingsKPI_DetailedReport_StatusColumn_AccountStatus_ACTI_Display()
        {
            testCaseId = "TC-15378";
            qTestUniqueId = "33986173";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonCompletedKpicount("complete");
                dashBoard.validateStatusforAllItems("ACTI");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15379_Dashboard_CompleteReadingsKPI_DetailedReport_StatusColumn_AccountStatus_INAC_Display()
        {
            testCaseId = "TC-15379";
            qTestUniqueId = "33986174";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonCompletedKpicount("complete");
                dashBoard.validateStatusforAllItems("INAC");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15380_Dashboard_CompleteReadingsKPI_DetailedReport_StatusColumn_AccountStatus_AWZDisplay()
        {
            testCaseId = "TC-15380";
            qTestUniqueId = "33986175";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonCompletedKpicount("complete");
                dashBoard.validateStatusforAllItems("AWZ");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15381_Dashboard_CompleteReadingsKPI_DetailedReport_StatusColumn_AccountStatus_IWU_Display()
        {
            testCaseId = "TC-15381";
            qTestUniqueId = "33986176";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonCompletedKpicount("complete");
                dashBoard.validateStatusforAllItems("IWU");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15382_Dashboard_CompleteReadingsKPI_DetailedReport_StatusColumns_Displayorder()
        {
            testCaseId = "TC-15382";
            qTestUniqueId = "33986177";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonCompletedKpicount("complete");
                dashBoard.validateStatusColumnOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15383_Dashboard_CompleteReadingsKPI_DetailedReport_SortOrder()
        {
            testCaseId = "TC-15383";
            qTestUniqueId = "33986178";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonCompletedKpicount("complete");
                dashBoard.validateAscendingOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15384_Dashboard_CompleteReadingsKPI_DetailedReport_SortOrder()
        {
            testCaseId = "TC-15384";
            qTestUniqueId = "33986179";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonCompletedKpicount("complete");
                dashBoard.validateAscendingOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15385_Dashboard_CompleteReadingsKPI_DetailedReport_SortOrder()
        {
            testCaseId = "TC-15385";
            qTestUniqueId = "33986180";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonCompletedKpicount("complete");
                dashBoard.validateAscendingOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10536_Dashboard_MapWidget_AccountPin_DetailsDisplay()
        {
            testCaseId = "TC-10536";
            qTestUniqueId = "24915185";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.dashboardMapView("Critical Continuous Consumption");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22840_Dashboard_MinorReverse_FlowKPI_DetailedReport_RemoveDatePicker()
        {
            testCaseId = "TC-22840";
            qTestUniqueId = "24915185";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                if (dashBoard.clickonReverseFlowKpicount("minorreverseflow"))
                {
                    dashBoard.ValidateDatePicker();
                }

                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22841_Neptune360_Dashboard_MajorReverseFlowKPI_DetailReport_DefaultDateRange()
        {
            testCaseId = "TC-22841";
            qTestUniqueId = "48873772";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickonReverseFlowKpicount("majorreverseflow");
                dashBoard.verifyDefaultReportdate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22843_Neptune360_Dashboard_MajorReverseFlowKPI_DetailReport_RemoveDatePicker()
        {
            testCaseId = "TC-22843";
            qTestUniqueId = "48873774";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                if (dashBoard.clickonReverseFlowKpicount("majorreverseflow"))
                {
                    dashBoard.ValidateDatePicker();
                }

                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23194_Dashboard_SystemConsumption_DetailedReport_Display()
        {
            testCaseId = "TC-23194";
            qTestUniqueId = "50092238";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateGridView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23195_Dashboard_SystemConsumption_DetailedReport_KendoGrid_Display()
        {
            testCaseId = "TC-23195";
            qTestUniqueId = "50092250";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateKendoGrid();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23211_Dashboard_SystemConsumption_KendoGraph_MaxDates()
        {
            testCaseId = "TC-23211";
            qTestUniqueId = "50092250";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateKendoGraphDates();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23212_Dashboard_SystemConsumption_ConsumptionBars_Display()
        {
            testCaseId = "TC-23212";
            qTestUniqueId = "50108507";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateSystemConsumptionbarchart(url);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23213_Dashboard_SystemConsumption_KendoGraph_YAxis()
        {
            testCaseId = "TC-23213";
            qTestUniqueId = "50108508";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateSystemConsumptionbarchart(url);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23214_Dashboard_SystemConsumption_KendoGraph_XAxis_DateOrder()
        {
            testCaseId = "TC-23214";
            qTestUniqueId = "50108509";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateKendoGraphDatesorder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23215_Dashboard_SystemConsumption_KendoGraph_XAxis_DateFormat()
        {
            testCaseId = "TC-23215";
            qTestUniqueId = "50108510";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateKendoGraphDatesFormat();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23216_Dashboard_SystemConsumption_KendoGraph_XAxis()
        {
            testCaseId = "TC-23216";
            qTestUniqueId = "50108511";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateKendoGraphDatesorder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23217_Dashboard_SystemConsumption_KendoGraph_Display()
        {
            testCaseId = "TC-23217";
            qTestUniqueId = "50108512";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.verifysystemConsumptionGraph();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23218_Dashboard_SystemConsumption_Widget_Display()
        {
            testCaseId = "TC-23218";
            qTestUniqueId = "50108513";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.verifysystemConsumptionGraphbeforeTop10Accounts();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23238_Dashboard_SystemConsumption_DetailedReport_GoogleMapView_Latitude_longitudedata_Display()
        {
            testCaseId = "TC-23238";
            qTestUniqueId = "50190911";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.dashboardMapView("Critical Continuous Consumption");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24088_Dashboard_Top10AccountsbyConsumption_DetailedReport_KendoGrid_Display()
        {
            testCaseId = "TC-24088";
            qTestUniqueId = "51451153";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.verifyTop10AccountsKendoGrid();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24092_Dashboard_CriticalContinuousConsumptionKPI_DetailedReport_KendoGrid_Display()
        {
            testCaseId = "TC-24092";
            qTestUniqueId = "51479408";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                if (dashBoard.clickonConsumptionKpicount("criticalconsumption"))
                {
                    dashBoard.ValidateKendoGrid();
                }
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24093_Dashboard_WarningContinuousConsumptionKPI_DetailedReport_KendoGrid_Display()
        {
            testCaseId = "TC-24093";
            qTestUniqueId = "51479442";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                if (dashBoard.clickonConsumptionKpicount("warningconsumption"))
                {
                    dashBoard.ValidateKendoGrid();
                }
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24094_Dashboard_NormalContinuousConsumptionKPI_DetailedReport_KendoGrid_Display()
        {
            testCaseId = "TC-24094";
            qTestUniqueId = "51479477";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                if (dashBoard.clickonConsumptionKpicount("normalconsumption"))
                {
                    dashBoard.ValidateKendoGrid();
                }
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24095_Dashboard_Top10AccountsbyConsumption_DetailedReport_GoogleMaps_Display()
        {
            testCaseId = "TC-24095";
            qTestUniqueId = "51479505";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateTop10AccountsintheMap();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_25341_KendoConversion_Dashboard_Top10AccountsbyConsumption_DetailedReport_Mapview_TooltipDetailsdisplay()
        {
            testCaseId = "TC-25341";
            qTestUniqueId = "53725250";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.validateTop10AccountsintheMap();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24096_Dashboard_NormalContinuousConsumptionKPI_DetailedReport_GoogleMaps_Display()
        {
            testCaseId = "TC-24096";
            qTestUniqueId = "51494535";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                if (dashBoard.clickonConsumptionKpicount("normalconsumption"))
                {
                    dashBoard.validateMapsDisplay();
                }
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24097_Dashboard_WarningContinuousConsumptionKPI_DetailedReport_GoogleMaps_Display()
        {
            testCaseId = "TC-24097";
            qTestUniqueId = "51494536";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                if (dashBoard.clickonConsumptionKpicount("warningconsumption"))
                {
                    dashBoard.validateMapsDisplay();
                }
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24098_Dashboard_CriticalContinuousConsumptionKPI_DetailedReport_KendoGoogleMaps_Display()
        {
            testCaseId = "TC-24098";
            qTestUniqueId = "51494537";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                if (dashBoard.clickonConsumptionKpicount("criticalconsumption"))
                {
                    dashBoard.validateMapsDisplay();
                }
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_19098_Dashboard_CriticalContinuousConsumption_DetailedReport_MapView_Tooltip_Details()
        {
            testCaseId = "TC-19098";
            qTestUniqueId = "41025626";
            startDate = DateTime.Now;
            try 
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                if (dashBoard.clickonConsumptionKpicount("criticalconsumption"))
                {
                    dashBoard.validateMapsDisplay();
                }
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24099_Dashboard_SystemConsumption_DetailedReport_KendoGoogleMaps_Display()
        {
            testCaseId = "TC-24099";
            qTestUniqueId = "51494537";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickOnDetailReportLink("SystemConsumption");
                dashBoard.validateMapsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24111_Dashboard_MetersReceived_viaAMIKPI_DetailedReport_KendoGrid_Display()
        {
            testCaseId = "TC-24111";
            qTestUniqueId = "51533273";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                if (dashBoard.clickonReceiveKpicount("ami"))
                {
                    dashBoard.ValidateKendoGrid();
                }
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24112_Dashboard_MetersReceived_viaAMRKPI_DetailedReport_KendoGrid_Display()
        {
            testCaseId = "TC-24112";
            qTestUniqueId = "51533274";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                if (dashBoard.clickonReceiveKpicount("amr"))
                {
                    dashBoard.ValidateKendoGrid();
                }
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_25354_KendoConversion_Dashboard_CompleteReadingsKPI_DetailedReport_Dateformat()
        {
            testCaseId = "TC-25354";
            qTestUniqueId = "53725268";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                if (dashBoard.clickonCompletedKpicount("complete"))
                {
                    dashBoard.verifyDefaultReportdate();
                }
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24124_Dashboard_NormalGatewayStatusKPI_DetailedReport_Countinthestatus()
        {
            testCaseId = "TC-24124";
            qTestUniqueId = "51742329";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCountInStatus(2);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24127_Dashboard_CriticalGatewayStatusKPI_DetailedReport_Countinthestatus()
        {
            testCaseId = "TC-24127";
            qTestUniqueId = "51744732";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCountInStatus(0);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24130_Dashboard_WarningGatewayStatusKPI_DetailedReport_Countinthestatus()
        {
            testCaseId = "TC-24130";
            qTestUniqueId = "51745099";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateCountInStatus(1);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24142_DashboardCriticalGatewayStatusKPI_DetailedReport_SeparateEntity()
        {
            testCaseId = "TC-24142";
            qTestUniqueId = "51778605";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSeprateEntity(0);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24144_DashboardWarningGatewayStatusKPI_DetailedReport_SeparateEntity()
        {
            testCaseId = "TC-24144";
            qTestUniqueId = "51745100";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSeprateEntity(1);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24163_DashboardNormalGatewayStatusKPI_DetailedReport_SeparateEntity()
        {
            testCaseId = "TC-24163";
            qTestUniqueId = "51927617";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateSeprateEntity(2);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24143_Dashboard_CriticalGatewayStatusKPI_DetailedReport_MIUIDcount()
        {
            testCaseId = "TC-24143";
            qTestUniqueId = "51778743";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMIUICount(0);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24146_Dashboard_WarningGatewayStatusKPI_DetailedReport_MIUIDcount()
        {
            testCaseId = "TC-24146";
            qTestUniqueId = "51782788";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMIUICount(1);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24161_Dashboard_WarningGatewayStatusKPI_DetailedReport_MIUIDcount()
        {
            testCaseId = "TC-24161";
            qTestUniqueId = "51926894";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateMIUICount(2);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24131_Dashboard_WarningGatewayKPI_DetailedReport_VerifythelogicinAlertconfiguration()
        {
            testCaseId = "TC-24131";
            qTestUniqueId = "51745100";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.VerifyAlertConfig(1);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24126_Dashboard_NormalGatewayKPI_DetailedReport_LogicthatdoesnotmeetinAlertconfiguration()
        {
            testCaseId = "TC-24126";
            qTestUniqueId = "51742935";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.VerifyAlertConfigNotMeet(2);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24129_Dashboard_CriticalGatewayKPI_DetailedReport_LogicthatdoesnotmeetinAlertconfiguration()
        {
            testCaseId = "TC-24129";
            qTestUniqueId = "51744739";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.VerifyAlertConfigNotMeet(0);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24132_Dashboard_WarningGatewayKPI_DetailedReport_LogicthatdoesnotmeetinAlertconfiguration()
        {
            testCaseId = "TC-24132";
            qTestUniqueId = "51745130";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.VerifyAlertConfigNotMeet(1);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        
        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13960_Dashboard_ContinuousConsumption_DetailedReport_DataValidation_Reading()
        {
            testCaseId = "TC-13960";
            qTestUniqueId = "30131736";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateContinuousConsumptionReport_ReadingFormat();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13967_Dashboard_IntermittentConsumptionKPI_DetailedReport_NumberofRowsEqualsSumofEndpointsinEachAlertCategory()
        {
            testCaseId = "TC-13967";
            qTestUniqueId = "30131743";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateIntermittentConsumptionReport_RecordCount();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13968_Dashboard_ContinuousConsumption_DetailedReport_ScrollBar()
        {
            testCaseId = "TC-13968";
            qTestUniqueId = "30131744";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.ValidateScrollBarPresentOnReport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_25336_KendoConversion_Dashboard_SystemConsumptionKPI_MapView_ClustersDisplay()
        {
            testCaseId = "TC-25336";
            qTestUniqueId = "53724890";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.CheckClusterPresenceOnReport(1);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_25340_KendoConversion_Dashboard_Top10Accountsbyconsumption_DetailedReport_Mapview_Clustersdisplay()
        {
            testCaseId = "TC-25340";
            qTestUniqueId = "53725246";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.CheckClusterPresenceOnReport(2);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Dashboard")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23238_Dashboard_SystemConsumption_DetailedReport_GoogleMapView_Latitude_longitude_data_Display()
        {
            testCaseId = "TC-23238";
            qTestUniqueId = "50190911";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                dashBoard.clickOnDetailReportLink("SystemConsumption");
                dashBoard.validateMapsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception)
            {

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }
    }
}
