using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Neptune360UIAutomation
{
    public class Reports : TestBaseTemplate
    {
        /// <summary>
        /// Test Method to Reports_Mach 10 Battery Status_Header
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_14168_Reports_Mach_10_Battery_Status_Header()
        {
            testCaseId = "TC-14168";
            qTestUniqueId = "30516664";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
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
        /// Test Method to Reports_Mach 10 Battery Status_Report Date_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_14169_Reports_Mach_10_Battery_Status_Report_Date_Display()
        {
            testCaseId = "TC-14169";
            qTestUniqueId = "30516665";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10ReportDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Mach 10 Battery Status_Share Icon_PDF_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_14170_Reports_Mach_10_Battery_Status_Share_Icon_PDF_Display()
        {
            testCaseId = "TC-14170";
            qTestUniqueId = "30516666";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10PDFIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Mach 10 Battery Status_Share Icon_Excel_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_14171_Reports_Mach_10_Battery_Status_Share_Icon_Excel_Display()
        {
            testCaseId = "TC-14171";
            qTestUniqueId = "30516667";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10ExcelIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Reports_Mach 10 Battery Status_Columns Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_14174_Reports_Mach_10_Battery_Status_Columns_Display()
        {
            testCaseId = "TC-14174";
            qTestUniqueId = "30516670";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10ColumnDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Mach 10 Battery Status_Default Sort Order_Days Of Low Status_Descending
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_14175_Reports_Mach_10_Battery_Status_Default_Sort_Order_Days_Of_Low_Status_Descending()
        {
            testCaseId = "TC-14175";
            qTestUniqueId = "30516671";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10DaysOfLowPower();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Mach 10 Battery Status_Meters_Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_14176_Reports_Mach_10_Battery_Status_Meters_Validation()
        {
            testCaseId = "TC-14176";
            qTestUniqueId = "30516672";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10DaysOfLowPower();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Mach 10 Battery Status_Reordering_By Route_Ascending
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_14178_Reports_Mach_10_Battery_Status_Reordering_By_Route_Ascending()
        {
            testCaseId = "TC-14178";
            qTestUniqueId = "30516675";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10DaysOfLowPower();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Reports_Coded Notes_
        /// 
        /// 
        /// 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_14874_Reports_Coded_Notes_Title()
        {
            testCaseId = "TC-14874";
            qTestUniqueId = "32541831";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
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
        /// Test Method to Reports_Coded Notes_Back Button
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_14544_Reports_Coded_Notes_Back_Button()
        {
            testCaseId = "TC-14544";
            qTestUniqueId = "31997209";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesBacktoReports();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Coded Notes_Export as PDF
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_14545_Reports_Coded_Notes_Export_as_PDF()
        {
            testCaseId = "TC-14545";
            qTestUniqueId = "31997210";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesExportToPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Coded Notes_Export as Excel
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_14546_Reports_Coded_Notes_Export_as_Excel()
        {
            testCaseId = "TC-14546";
            qTestUniqueId = "31997211";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesExportToExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Comments_Title
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_14883_Reports_Comments_Title()
        {
            testCaseId = "TC-14883";
            qTestUniqueId = "32596247";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsPageTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Comments_Export as PDF_Separate Page for Each Route
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_14885_Reports_Comments_Export_as_PDF_Separate_Page_for_Each_Route()
        {
            testCaseId = "TC-14885";
            qTestUniqueId = "32596249";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsExportToPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Endpoints_Days of No Flow (AMR)_Display_Second Row
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15638_Reports_Endpoints_Days_of_No_Flow_AMR_Display_Second_Row()
        {
            testCaseId = "TC-15638";
            qTestUniqueId = "34389243";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowSecondRow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Endpoints_Days of Consumption (AMR)_Display_Second Row
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15639_Reports_Endpoints_Days_of_Consumption_AMR_Display_Second_Row()
        {
            testCaseId = "TC-15639";
            qTestUniqueId = "34389252";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumption2ndRow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Subtitle
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15644_Report_Days_of_No_Flow_AMR_Detailed_Report_Subtitle()
        {
            testCaseId = "TC-15644";
            qTestUniqueId = "34414523";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowReportSubtitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Report_Days of No Flow (AMR)_Share Icon_PDF_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15903_Report_Days_of_No_Flow_AMR_Share_Icon_PDF_Display()
        {
            testCaseId = "TC-15903";
            qTestUniqueId = "34771470";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowPDFIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Report_Days of No Flow (AMR)_Share Icon_Excel_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15904_Report_Days_of_No_Flow_AMR_Share_Icon_Excel_Display()
        {
            testCaseId = "TC-15904";
            qTestUniqueId = "34771471";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowExcelIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Report_Days of Consumption (AMR)_Share Icon_PDF_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15924_Report_Days_of_Consumption_AMR_Share_Icon_PDF_Display()
        {
            testCaseId = "TC-15924";
            qTestUniqueId = "34772496";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionPDFIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Report_Days of Consumption (AMR)_Share Icon_EXcel_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15925_Report_Days_of_Consumption_AMR_Share_Icon_Excel_Display()
        {
            testCaseId = "TC-15925";
            qTestUniqueId = "34772498";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionExcelIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method toReport_Found Meters_Detailed Report_Title
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_18228_Report_Found_Meters_Detailed_Report_Title()
        {
            testCaseId = "TC-18228";
            qTestUniqueId = "39379619";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Report_Found Meters_Breadcrumbs_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_18229_Report_Found_Meters_Breadcrumbs_Display()
        {
            testCaseId = "TC-18229";
            qTestUniqueId = "39379622";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Report_Found Meters_Detailed Report_Subtitle
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18230_Report_Found_Meters_Detailed_Report_Subtitle()
        {
            testCaseId = "TC-18230";
            qTestUniqueId = "39379623";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersReportSubtitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Report_Found Meters_Share Icon_PDF_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18240_Report_Found_Meters_Share_Icon_PDF_Display()
        {
            testCaseId = "TC-18240";
            qTestUniqueId = "39379655";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersPDFIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Report_Found Meters_Share Icon_Excel_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_18241_Report_Found_Meters_Share_Icon_Excel_Display()
        {
            testCaseId = "TC-18241";
            qTestUniqueId = "39379658";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersExcelIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Endpoints Container_Found Meters_Access
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_18417_Reports_Endpoints_Container_Found_Meters_Access()
        {
            testCaseId = "TC-18417";
            qTestUniqueId = "39718156";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Endpoints Container_Found Meters_Neptune System Admin_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_18418_Reports_Endpoints_Container_Found_Meters_Neptune_System_Admin_Display()
        {
            testCaseId = "TC-18418";
            qTestUniqueId = "39718157";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Endpoints Container_Found Meters_Neptune CSR_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_18419_Reports_Endpoints_Container_Found_Meters_Neptune_CSR_Display()
        {
            testCaseId = "TC-18419";
            qTestUniqueId = "39718158";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Reports_Endpoints Container_Found Meters_Utility Admin_Access
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_18420_Reports_Endpoints_Container_Found_Meters_Utility_Admin_Access()
        {
            testCaseId = "TC-18420";
            qTestUniqueId = "39718159";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summaryReport_Days of Consumption (AMR)_Detailed Report_Subtitle
        /// Test Method to Reports_Endpoints Container_Found Meters_Utility Admin_Access
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15847_Report_Days_of_Consumption_AMR_Detailed_Report_Subtitle()
        {
            testCaseId = "TC-15847";
            qTestUniqueId = "34544684";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionAMRSubtitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Columns_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15848_Report_Days_of_Consumption_AMR_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-15848";
            qTestUniqueId = "34544685";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionColumnDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Cycle/Route
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15849_Report_Days_of_Consumption_AMR_Detailed_Report_Cycle_Route()
        {
            testCaseId = "TC-15849";
            qTestUniqueId = "34544686";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionReportCycle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Cycle/Route
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15850_Report_Days_of_Consumption_AMR_Detailed_Report_Cycle_Route()
        {
            testCaseId = "TC-15850";
            qTestUniqueId = "34544687";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionReadSeq();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method toReport_Days of Consumption (AMR)_Detailed Report_MIU
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15851_Report_Days_of_Consumption_AMR_Detailed_Report_MIU()
        {
            testCaseId = "TC-15851";
            qTestUniqueId = "34544688";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionMIU();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method toReport_Days of Consumption (AMR)_Detailed Report_Account_Name
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15852_Report_Days_of_Consumption_AMR_Detailed_Report_Account_Name()
        {
            testCaseId = "TC-15852";
            qTestUniqueId = "34544689";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionAccName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method toReport_Days of Consumption (AMR)_Detailed Report_Account_Number
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15853_Report_Days_of_Consumption_AMR_Detailed_Report_Account_Number()
        {
            testCaseId = "TC-15853";
            qTestUniqueId = "34544690";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionAccNumber();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method toReport_Days of Consumption (AMR)_Detailed Report_Address
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15854_Report_Days_of_Consumption_AMR_Detailed_Report_Address()
        {
            testCaseId = "TC-15854";
            qTestUniqueId = "34544691";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionAddress();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method toReport_Days of Consumption (AMR)_Detailed Report_Days Range
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15855_Report_Days_of_Consumption_AMR_Detailed_Report_Days_Range()
        {
            testCaseId = "TC-15855";
            qTestUniqueId = "34544692";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionDaysRange();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Reading
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15856_Report_Days_of_Consumption_AMR_Detailed_Report_Reading()
        {
            testCaseId = "TC-15856";
            qTestUniqueId = "34544693";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionReading();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Date/Time
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15857_Report_Days_of_Consumption_AMR_Detailed_Report_Date_Time()
        {
            testCaseId = "TC-15857";
            qTestUniqueId = "34544694";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionDateTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Consumption Flag
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15858_Report_Days_of_Consumption_AMR_Detailed_Report_Consumption_Flag()
        {
            testCaseId = "TC-15858";
            qTestUniqueId = "34544857";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionDateTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of_Consumption_AMR_Detailed Report_Sort Order_First_Days Range
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15859_Report_Days_of_Consumption_AMR_Detailed_Report_Sort_Order_First_Days_Range()
        {
            testCaseId = "TC-15859";
            qTestUniqueId = "34544857";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionSortOrderDateRange();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Sort Order_Second_Cycle/Route
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15860_Report_Days_of_Consumption_AMR_Detailed_Report_Sort_Order_Second_Cycle_Route()
        {
            testCaseId = "TC-15860";
            qTestUniqueId = "34545767";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionSecondCycleRoute();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Sort Order_Last_Read Seq
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15861_Report_Days_of_Consumption_AMR_Detailed_Report_Sort_Order_Last_Read_Seq()
        {
            testCaseId = "TC-15861";
            qTestUniqueId = "34545769";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionReadSeq();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Back to Reports_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15862_Report_Days_of_Consumption_AMR_Detailed_Report_Back_to_Reports_Display()
        {
            testCaseId = "TC-15862";
            qTestUniqueId = "34545770";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionBacktoReportsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Back to Reports_Click
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15863_Report_Days_Of_Consumption_AMR_Detailed_Report_Back_to_Reports_Click()
        {
            testCaseId = "TC-15863";
            qTestUniqueId = "34545771";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionBacktoReportsClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_From Date_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15864_Report_Days_of_Consumption_AMR_Detailed_Report_From_Date_Display()
        {
            testCaseId = "TC-15864";
            qTestUniqueId = "34546053";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionFromDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_From to_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15865_Report_Days_of_Consumption_AMR_Detailed_Report_From_To_Display()
        {
            testCaseId = "TC-15865";
            qTestUniqueId = "34546054";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_From Date_Default Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15866_Report_Days_of_Consumption_AMR_Detailed_Report_From_Date_Default_Date()
        {
            testCaseId = "TC-15866";
            qTestUniqueId = "34546055";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionDefaultDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_From Date_Editable
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15868_Report_Days_of_Consumption_AMR_Detailed_Report_From_Date_Editable()
        {
            testCaseId = "TC-15866";
            qTestUniqueId = "34546057";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionDefaultDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_From To_Editable
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15869_Report_Days_of_Consumption_AMR_Detailed_Report_From_tO_Editable()
        {
            testCaseId = "TC-15869";
            qTestUniqueId = "34546058";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionDefaultToEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method toReport_Days of Consumption (AMR)_Detailed Report_Date Range Selected_Updated Data Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15870_Report_Days_of_Consumption_AMR_Detailed_Report_Date_Range_Selected_Updated_Data_Display()
        {
            testCaseId = "TC-15870";
            qTestUniqueId = "34546059";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReportDateUpdated();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_To Date_Future Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15871_Report_Days_of_Consumption_AMR_Detailed_Report_To_Date_Future_Date()
        {
            testCaseId = "TC-15871";
            qTestUniqueId = "34546060";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReportDateUpdated();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_From Date_Future Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15872_Report_Days_of_Consumption_AMR_Detailed_Report_From_Date_Future_Date()
        {
            testCaseId = "TC-15872";
            qTestUniqueId = "34546061";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReportDateUpdated();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_From Date_Equal To Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15873_Report_Days_of_Consumption_AMR_Detailed_Report_From_Date_Equal_To_Date()
        {
            testCaseId = "TC-15873";
            qTestUniqueId = "34546062";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReportDateUpdated();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method toReport_Days of Consumption (AMR)_Detailed Report_MIU ID/Meter_Leak Code Days_1_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15874_Report_Days_of_Consumption_AMR_Detailed_Report_MIU_ID_Meter_Leak_Code_Days_1_Display()
        {
            testCaseId = "TC-15874";
            qTestUniqueId = "34546197";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReportDateUpdated();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method toReport_Days of Consumption (AMR)_Detailed Report_MIU ID/Meter_Leak Code Days_2_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15875_Report_Days_of_Consumption_AMR_Detailed_Report_MIU_ID_Meter_Leak_Code_Days_2_Display()
        {
            testCaseId = "TC-15875";
            qTestUniqueId = "34546198";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReportDateUpdated();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method toReport_Days of Consumption (AMR)_Detailed Report_MIU ID/Meter_Leak Code Days_3_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15876_Report_Days_of_Consumption_AMR_Detailed_Report_MIU_ID_Meter_Leak_Code_Days_3_Display()
        {
            testCaseId = "TC-15876";
            qTestUniqueId = "34546199";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReportDateUpdated();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method toReport_Days of Consumption (AMR)_Detailed Report_MIU ID/Meter_Leak Code Days_4_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15877_Report_Days_of_Consumption_AMR_Detailed_Report_MIU_ID_Meter_Leak_Code_Days_4_Display()
        {
            testCaseId = "TC-15877";
            qTestUniqueId = "34546200";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReportDateUpdated();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }



        [Category("DataValidation")]
        [Test]
        public void TC_Mach10_Battery_Status_Report_Data_Validation()
        {
            testCaseId = "TCDBTestMach10";
            qTestUniqueId = "";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                query = testData["PostgreSQLQuery"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateReportsLandingPage();
                reportsPage.ValidateMach10BatteryStatusReport(query);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("DataValidation")]
        [Test]
        public void TC_Days_of_No_Flow_AMR_Report_Data_Validation()
        {
            testCaseId = "TCDBTestDONF";
            qTestUniqueId = "";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                query = testData["PostgreSQLQuery"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateReportsLandingPage();
                reportsPage.ValidateDaysOfNoFlowAMRReport(query);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("DataValidation")]
        [Test]
        public void TC_Invalid_Readings_Data_Validation()
        {
            testCaseId = "TCDBTestIR";
            qTestUniqueId = "";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                query = testData["PostgreSQLQuery"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateReportsLandingPage();
                reportsPage.ValidateInvalidReadings(query);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("DataValidation")]
        [Test]
        public void TC_Days_Of_Consumption_Data_Validation()
        {
            testCaseId = "TCDBTestDAC";
            qTestUniqueId = "";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                query = testData["PostgreSQLQuery"];
                home.NavigateToHome(url, userName, password);
                landing.ValidateReportsLandingPage();
                reportsPage.ValidateDaysOfConsumpAMR(query);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Found Meters_Detailed Report_From Date_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18215_Report_Found_Meters_Detailed_Report_From_Date_Display()
        {
            testCaseId = "TC-18215";
            qTestUniqueId = "39379576";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersFromDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Found Meters_Detailed Report_To Date_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18216_Report_Found_Meters_Detailed_Report_To_Date_Display()
        {
            testCaseId = "TC-18216";
            qTestUniqueId = "39379577";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Found Meters_Detailed Report_From Date_Default Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18217_Report_Found_Meters_Detailed_Report_From_Date_Default_Date()
        {
            testCaseId = "TC-18217";
            qTestUniqueId = "39379578";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersFromDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Found Meters_Detailed Report_To Date_Default Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18218_Report_Found_Meters_Detailed_Report_To_Date_Default_Date()
        {
            testCaseId = "TC-18218";
            qTestUniqueId = "39379579";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary
        /// Test Method to Report_Found Meters_Detailed Report_From Date_Editable
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18219_Report_Found_Meters_Detailed_Report_From_Date_Editable()
        {
            testCaseId = "TC-18219";
            qTestUniqueId = "39379609";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersFromDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Found Meters_Detailed Report_To Date_Editable
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18220_Report_Found_Meters_Detailed_Report_To_Date_Editable()
        {
            testCaseId = "TC-18220";
            qTestUniqueId = "39379610";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersToDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Found Meters_Detailed Report_Date Range Selected_Updated Data Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18221_Report_Found_Meters_Detailed_Report_Date_Range_Selected_Updated_Data_Display()
        {
            testCaseId = "TC-18221";
            qTestUniqueId = "39379611";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersToDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Found Meters_Detailed Report_To Date_Future Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18222_Report_Found_Meters_Detailed_Report_To_Date_Future_Date()
        {
            testCaseId = "TC-18222";
            qTestUniqueId = "39379612";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersToDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Found Meters_Detailed Report_From Date_Future Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18223_Report_Found_Meters_Detailed_Report_From_Date_Future_Date()
        {
            testCaseId = "TC-18223";
            qTestUniqueId = "39379614";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersFromDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Found Meters_Detailed Report_From Date_Equal To Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18224_Report_Found_Meters_Detailed_Report_From_Date_Equal_To_Date()
        {
            testCaseId = "TC-18224";
            qTestUniqueId = "39379615";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersFromDateToDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Found Meters_Detailed Report_MIU Included
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18225_Reports_Found_Meters_Detailed_Report_MIU_Included()
        {
            testCaseId = "TC-18225";
            qTestUniqueId = "39379616";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersFromDateToDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary
        /// Test Method to Reports_Endpoints Container_Found Meters_Utility User_Access
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18421_Reports_Endpoints_Container_Found_Meters_Utility_User_Access()
        {
            testCaseId = "TC-18421";
            qTestUniqueId = "39718160";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_Found Meters_Utility Read Only_Access
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18422_Reports_Endpoints_Container_Found_Meters_Utility_Read_Only_Access()
        {
            testCaseId = "TC-18422";
            qTestUniqueId = "39718161";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_Found Meters_Utility Meter Reader_Access
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18423_Reports_Endpoints_Container_Found_Meters_Utility_Meter_Reader_Access()
        {
            testCaseId = "TC-18423";
            qTestUniqueId = "39718163";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Groups Reporting Parameter_Groups drop-down Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19020_Report_Groups_Reporting_Parameter_Groups_drop_down_Display()
        {
            testCaseId = "TC-19020";
            qTestUniqueId = "40730284";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateGroupsdropdownDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Columns_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19121_Report_Days_of_No_Flow_AMR_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-19121";
            qTestUniqueId = "41037667";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowColumnDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Route Filter_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19126_Report_Days_of_No_Flow_AMR_Detailed_Report_Route_Filter_Display()
        {
            testCaseId = "TC-19126";
            qTestUniqueId = "41037725";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowRouteFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Group Filter_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19127_Report_Days_of_No_Flow_AMR_Detailed_Report_Group_Filter_Display()
        {
            testCaseId = "TC-19127";
            qTestUniqueId = "41037725";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowGroupFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Route Filter_One Route Select
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19128_Report_Days_of_No_Flow_AMR_Detailed_Report_Route_Filter_One_Route_Select()
        {
            testCaseId = "TC-19128";
            qTestUniqueId = "41037729";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowSelectroute();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Route Filter_One Route Select_Subtitle
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19129_Report_Days_of_No_Flow_AMR_Detailed_Report_Route_Filter_One_Route_Select_Subtitle()
        {
            testCaseId = "TC-19129";
            qTestUniqueId = "41037730";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowSelectrouteSubtitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Route Filter_No Route Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19130_Report_Days_of_No_Flow_AMR_Detailed_Report_Route_Filter_No_Route_Selected()
        {
            testCaseId = "TC-19130";
            qTestUniqueId = "41037732";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowSelectrouteSubtitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_AMI No Flow_Neptune System Admin_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19579_Reports_Endpoints_Container_AMI_No_Flow_Neptune_System_Admin_Display()
        {
            testCaseId = "TC-19579";
            qTestUniqueId = "42348384";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_AMI No Flow_Neptune System Admin_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19580_Reports_Endpoints_Container_AMI_No_Flow_Neptune_System_Admin_Display()
        {
            testCaseId = "TC-19580";
            qTestUniqueId = "42348410";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_AMI No Flow_Neptune System Admin_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19581_Reports_Endpoints_Container_AMI_No_Flow_Utility_Admin_Display()
        {
            testCaseId = "TC-19581";
            qTestUniqueId = "42348411";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_AMI No Flow_Utility_User_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19582_Reports_Endpoints_Container_AMI_No_Flow_Utility_User_Display()
        {
            testCaseId = "TC-19582";
            qTestUniqueId = "42348412";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_AMI No Flow_Utility Read Only_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19583_Reports_Endpoints_Container_AMI_No_Flow_Utility_Read_Only_Display()
        {
            testCaseId = "TC-19583";
            qTestUniqueId = "42348413";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_AMI No Flow_Utility Meter Reader_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19584_Reports_Endpoints_Container_AMI_No_Flow_Utility_Meter_Reader_Display()
        {
            testCaseId = "TC-19584";
            qTestUniqueId = "42348414";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_AMI No Flow_Neptune 360 Partner_Not Displayed
        /// </summary>
        [Category("Reports_Archived")]
        [Test]
        public void TC_19585_Reports_Endpoints_Container_AMI_No_Flow_Neptune_360_Partner_Not_Displayed()
        {
            testCaseId = "TC-19585";
            qTestUniqueId = "42348417";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.SelectUserRole("testneptuneauto1@gmail.com", "Neptune 360 partner");
                rolesPermissons.SetPermission("Neptune 360 Partner", "AMI No Flow Report", false);
                home.UserLogOut();
                home.NavigateToLftNavReports(url, "testneptuneauto1@gmail.com", "Naveen@12345");
                reportsPage.ValidateAMINoFlowNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_AMI No Flow_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19586_Reports_Endpoints_Container_AMI_No_Flow_Display()
        {
            testCaseId = "TC-19586";
            qTestUniqueId = "42348418";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_AMI No Flow_Access
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19587_Reports_Endpoints_Container_AMI_No_Flow_Access()
        {
            testCaseId = "TC-19587";
            qTestUniqueId = "42348419";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_Inactive Flow_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19611_Reports_Endpoints_Container_Inactive_Flow_Display()
        {
            testCaseId = "TC-19611";
            qTestUniqueId = "42377261";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_Inactive Flow_Access
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19612_Reports_Endpoints_Container_Inactive_Flow_Access()
        {
            testCaseId = "TC-19612";
            qTestUniqueId = "42377262";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_Inactive Flow_Neptune System Admin_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19613_Reports_Endpoints_Container_Inactive_Flow_Neptune_System_Admin_Display()
        {
            testCaseId = "TC-19613";
            qTestUniqueId = "42377263";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_Inactive Flow_Neptune CSR_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19614_Reports_Endpoints_Container_Inactive_Flow_Neptune_CSR_Display()
        {
            testCaseId = "TC-19614";
            qTestUniqueId = "42377264";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.SelectUserRole("testneptuneauto1@gmail.com", "Neptune Customer Service Rep");
                rolesPermissons.SetPermission("Neptune Customer Service Rep", "Inactive Flow Report", true);
                home.UserLogOut();
                home.NavigateToHome(url, "testneptuneauto1@gmail.com", "Automation#123", false);
                home.NavigateToLftNavReports();
                reportsPage.ValidateInactiveFlowDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_Inactive Flow_Utility Admin_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19615_Reports_Endpoints_Container_Inactive_Flow_Utility_Admin_Display()
        {
            testCaseId = "TC-19615";
            qTestUniqueId = "42377266";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_Inactive Flow_Utility User_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19616_Reports_Endpoints_Container_Inactive_Flow_Utility_User_Display()
        {
            testCaseId = "TC-19616";
            qTestUniqueId = "42377267";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_Inactive Flow_Utility Read Only_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19617_Reports_Endpoints_Container_Inactive_Flow_Utility_Read_Only_Display()
        {
            testCaseId = "TC-19617";
            qTestUniqueId = "42377268";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_Inactive Flow_Utility Meter Reader_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19618_Reports_Endpoints_Container_Inactive_Flow_Utility_Meter_Reader_Display()
        {
            testCaseId = "TC-19618";
            qTestUniqueId = "42377270";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_Inactive Neptune 360 Partner_Not Displayed
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19619_Reports_Endpoints_Container_Inactive_Flow_Neptune_360_Partner_Not_Displayed()
        {
            testCaseId = "TC-19619";
            qTestUniqueId = "42377301";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowNotDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_Inactive Flow_Detailed Report_Columns_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19622_Report_Inactive_Flow_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-19622";
            qTestUniqueId = "42377494";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowNotDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Title
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19698_Report_AMI_No_Flow_Detailed_Report_Title()
        {
            testCaseId = "TC-19698";
            qTestUniqueId = "42533673";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowSTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Subtitle
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19699_Report_AMI_No_Flow_Detailed_Report_Subtitle()
        {
            testCaseId = "TC-19699";
            qTestUniqueId = "42533681";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowReportSubtitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Columns_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19700_Report_AMI_No_Flow_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-19700";
            qTestUniqueId = "42533682";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowColumnDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Cycle/Route
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19701_Report_AMI_No_Flow_Detailed_Report_Cycle_Route()
        {
            testCaseId = "TC-19701";
            qTestUniqueId = "42533683";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowCycleRoute();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Account Name
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19702_Report_AMI_No_Flow_Detailed_Report_Account_Name()
        {
            testCaseId = "TC-19702";
            qTestUniqueId = "42533684";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowAccName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Account Number
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19703_Report_AMI_No_Flow_Detailed_Report_Account_Number()
        {
            testCaseId = "TC-19703";
            qTestUniqueId = "42533684";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowAccNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Address
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19704_Report_AMI_No_Flow_Detailed_Report_Address()
        {
            testCaseId = "TC-19704";
            qTestUniqueId = "42533687";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowAddress();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_MIU ID
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19705_Report_AMI_No_Flow_Detailed_Report_MI_UID()
        {
            testCaseId = "TC-19705";
            qTestUniqueId = "42533697";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowMiuId();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }/// <summary
         /// Test Method to Report_AMI No Flow_Detailed Report_Meter Number
         /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19706_Report_AMI_No_Flow_Detailed_Report_Meter_Number()
        {
            testCaseId = "TC-19706";
            qTestUniqueId = "42533698";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowMeterNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Meter Size
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19707_Report_AMI_No_Flow_Detailed_Report_Meter_Size()
        {
            testCaseId = "TC-19707";
            qTestUniqueId = "42533699";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowMeterSize();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Last_Changed
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19708_Report_AMI_No_Flow_Detailed_Report_Last_Changed()
        {
            testCaseId = "TC-19708";
            qTestUniqueId = "42533700";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowLastChanged();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Back to Reports_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19709_Report_AMI_No_Flow_Detailed_Report_Back_to_Reports_Display()
        {
            testCaseId = "TC-19709";
            qTestUniqueId = "42533701";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowBackToReportsDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Back to Reports_Click
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_197010_Report_AMI_No_Flow_Detailed_Report_Back_to_Reports_Click()
        {
            testCaseId = "TC-19710";
            qTestUniqueId = "42533702";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowBackToReportsClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_AMI No Flow_Detailed Report_Sort Order_First_Last Changed Column
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19711_Reports_AMI_No_Flow_Detailed_Report_Sort_Order_First_Last_Changed_Column()
        {
            testCaseId = "TC-19711";
            qTestUniqueId = "42533703";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowTable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_AMI No Flow_Detailed Report_Sort Order_Second_Cycle/Route
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19712_Reports_AMI_No_Flow_Detailed_Report_Sort_Order_Second_Cycle_Route()
        {
            testCaseId = "TC-19712";
            qTestUniqueId = "42533704";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowTable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Inactive Meters/MIUs with Consumption_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19713_Report_AMI_No_Flow_Detailed_Report_Inactive_Meters_MIUs_with_Consumption_Display()
        {
            testCaseId = "TC-19713";
            qTestUniqueId = "42533705";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowMiuId();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_From Date_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19714_Report_AMI_No_Flow_Detailed_Report_From_Date_Display()
        {
            testCaseId = "TC-19714";
            qTestUniqueId = "42533707";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFromDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_To Date_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19715_Report_AMI_No_Flow_Detailed_Report_To_Date_Display()
        {
            testCaseId = "TC-19715";
            qTestUniqueId = "42533708";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_From Date_Default Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19716_Report_AMI_No_Flow_Detailed_Report_From_Date_Default_Date()
        {
            testCaseId = "TC-19716";
            qTestUniqueId = "42533709";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFromDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_From Date_Editable
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19718_Report_AMI_No_Flow_Detailed_Report_From_Date_Editable()
        {
            testCaseId = "TC-19718";
            qTestUniqueId = "42533711";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFromDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_To Date_Editable
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19719_Report_AMI_No_Flow_Detailed_Report_To_Date_Editable()
        {
            testCaseId = "TC-19719";
            qTestUniqueId = "42533712";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoToDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Route Filter_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19724_Report_AMI_No_Flow_Detailed_Report_Route_Filter_Display()
        {
            testCaseId = "TC-19724";
            qTestUniqueId = "42533717";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoRouteFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Route Filter_No Route Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19726_Report_AMI_No_Flow_Detailed_Report_Route_Filter_No_Route_Selected()
        {
            testCaseId = "TC-19726";
            qTestUniqueId = "42533719";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowTable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Route Filter_No Group Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19727_Report_AMI_No_Flow_Detailed_Report_Route_Filter_No_Group_Selected()
        {
            testCaseId = "TC-19727";
            qTestUniqueId = "42533720";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowTable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Route Filter_Values
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19728_Report_AMI_No_Flow_Detailed_Report_Route_Filter_Values()
        {
            testCaseId = "TC-19728";
            qTestUniqueId = "42533927";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoRouteFilterSelect();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Detailed Report_Group Filter_Values
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19729_Report_AMI_No_Flow_Detailed_Report_Group_Filter_Values()
        {
            testCaseId = "TC-19729";
            qTestUniqueId = "42533929";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoGroupFilterSelect();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Share Icon_PDF_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19730_Report_AMI_No_Flow_Share_Icon_PDF_Display()
        {
            testCaseId = "TC-19730";
            qTestUniqueId = "42533948";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowPDFIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Report_AMI No Flow_Share Icon_Excel_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19731_Report_AMI_No_Flow_Share_Icon_Excel_Display()
        {
            testCaseId = "TC-19731";
            qTestUniqueId = "42533948";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowExcelIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_High Consumption_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19880_Reports_Endpoints_Container_High_Consumption_Display()
        {
            testCaseId = "TC-19880";
            qTestUniqueId = "42533948";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConumptionDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_High Consumption_Access
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19881_Reports_Endpoints_Container_High_Consumption_Access()
        {
            testCaseId = "TC-19881";
            qTestUniqueId = "42758452";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConumptionAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_High Consumption_Neptune System Admin_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19882_Reports_Endpoints_Container_High_Consumption_Neptune_System_Admin_Display()
        {
            testCaseId = "TC-19882";
            qTestUniqueId = "42758453";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConumptionDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_High Consumption_Neptune CSR_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19883_Reports_Endpoints_Container_High_Consumption_Neptune_CSR_Display()
        {
            testCaseId = "TC-19883";
            qTestUniqueId = "42758454";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConumptionDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary
        /// Test Method to Reports_Endpoints Container_High Consumption_Utility Admin_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19884_Reports_Endpoints_Container_High_Consumption_Utility_Admin_Display()
        {
            testCaseId = "TC-19884";
            qTestUniqueId = "42758455";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConumptionDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Endpoints Container_High Consumption_Utility User_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19885_Reports_Endpoints_Container_High_Consumption_Utility_User_Display()
        {
            testCaseId = "TC-19885";
            qTestUniqueId = "42758456";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConumptionDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Endpoints Container_High Consumption_Utility Read Only_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19886_Reports_Endpoints_Container_High_Consumption_Utility_Read_Only_Display()
        {
            testCaseId = "TC-19886";
            qTestUniqueId = "42758457";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConumptionDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Endpoints Container_High Consumption_Utility Meter Reader_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19887_Reports_Endpoints_Container_High_Consumption_Utility_Meter_Reader_Display()
        {
            testCaseId = "TC-19887";
            qTestUniqueId = "42758459";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConumptionDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Endpoints Container_High Consumption_Neptune 360 Partner_Not_Display
        /// </summary>
        [Category("Reports_Archived")]
        [Test]
        public void TC_19888_Reports_Endpoints_Container_High_Consumption_Neptune_360_Partner_Not_Display()
        {
            testCaseId = "TC-19888";
            qTestUniqueId = "42758460";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConumptionNotDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to RReports_Days of Consumption (AMR)_Date Picker_From Date_Max Range
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20007_Reports_Days_of_Consumption_AMR_Date_Picker_From_Date_Max_Range()
        {
            testCaseId = "TC-20007";
            qTestUniqueId = "43371887";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionDefaultDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to RReports_Days of Consumption (AMR)_Date Picker_To Date_Max Range
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20008_Reports_Days_of_Consumption_AMR_Date_Picker_To_Date_Max_Range()
        {
            testCaseId = "TC-20008";
            qTestUniqueId = "43371902";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionDefaultToEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to RReports_Days of Consumption (AMR)_Date Picker_Default_Dates
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20009_Reports_Days_of_Consumption_AMR_Date_Picker_Default_Dates()
        {
            testCaseId = "TC-20009";
            qTestUniqueId = "43371921";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReportDateUpdated();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Days of Consumption (AMR)_Date Picker_Dates Display_Utility Local TimeZone
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20010_Reports_Days_of_Consumption_AMR_Date_Picker_Dates_Display_Utility_Local_TimeZone()
        {
            testCaseId = "TC-20010";
            qTestUniqueId = "43371936";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionDefaultToEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Days of Consumption (AMR)_Date Picker From Date_Max Range
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20013_Reports_Days_of_Consumption_AMR_Date_Picker_From_Date_Max_Range()
        {
            testCaseId = "TC-20013";
            qTestUniqueId = "43373919";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionDefaultDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Days of Consumption (AMR)_Date Picker Default Dates
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20015_Reports_Days_of_Consumption_AMR_Date_Picker_Default_Dates()
        {
            testCaseId = "TC-20015";
            qTestUniqueId = "43373921";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReportDateUpdated();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Days of Consumption (AMR)_Date Picker Dates Display_Utility Local TimeZone
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20016_Reports_Days_of_Consumption_AMR_Date_Picker_Dates_Display_Utility_Local_TimeZone()
        {
            testCaseId = "TC-20016";
            qTestUniqueId = "43373922";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionDefaultToEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Date Picker_From Date_Max Range
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20019_Reports_Comments_Date_Picker_From_Date_Max_Range()
        {
            testCaseId = "TC-20019";
            qTestUniqueId = "43377949";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsFromDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Date Picker_To Date_Max Range
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20020_Reports_Comments_Date_Picker_To_Date_Max_Range()
        {
            testCaseId = "TC-20020";
            qTestUniqueId = "43377952";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Date Picker_Default Dates
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20021_Reports_Comments_Date_Picker_Default_Dates()
        {
            testCaseId = "TC-20021";
            qTestUniqueId = "43377953";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Date Picker_Dates Display_Utility Local TimeZone
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20022_Reports_Comments_Date_Picker_Dates_Display_Utility_Local_TimeZone()
        {
            testCaseId = "TC-20022";
            qTestUniqueId = "43377955";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Coded Notes_Date Picker_From Date_Max Range
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20025_Reports_Coded_Notes_Date_Picker_From_Date_Max_Range()
        {
            testCaseId = "TC-20025";
            qTestUniqueId = "43378615";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesFromDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Coded Notes_Date Picker_To Date_Max Range
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20026_Reports_Coded_Notes_Date_Picker_To_Date_Max_Range()
        {
            testCaseId = "TC-20026";
            qTestUniqueId = "43378616";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Coded Notes_Date Picker_Default Dates
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20027_Reports_Coded_Notes_Date_Picker_Default_Dates()
        {
            testCaseId = "TC-20027";
            qTestUniqueId = "43378617";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Coded Notes_Date Picker_Dates Display_Utility Local TimeZone
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20028_Reports_Coded_Notes_Date_Picker_Dates_Display_Utility_Local_TimeZone()
        {
            testCaseId = "TC-20028";
            qTestUniqueId = "43378618";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings_Date Picker_From Date_Max Range
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20031_Reports_Invalid_Readings_Date_Picker_From_Date_Max_Range()
        {
            testCaseId = "TC-20031";
            qTestUniqueId = "43380131";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingFromDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings_Date Picker_To Date_Max Range
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20032_Reports_Invalid_Readings_Date_Picker_To_Date_Max_Range()
        {
            testCaseId = "TC-20032";
            qTestUniqueId = "43380132";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings_Date Picker_Default Dates
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20033_Reports_Invalid_Readings_Date_Picker_Default_Dates()
        {
            testCaseId = "TC-20033";
            qTestUniqueId = "43380133";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings_Date Picker_Dates Display_Utility Local TimeZone
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20034_Reports_Invalid_Readings_Date_Picker_Dates_Display_Utility_Local_TimeZone()
        {
            testCaseId = "TC-20034";
            qTestUniqueId = "43380134";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Date Range_From Date_To Date_Same Date Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20037_Reports_Date_Range_From_Date_To_Date_Same_Date_Selected()
        {
            testCaseId = "TC-20037";
            qTestUniqueId = "43382480";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersReportSubtitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Date Range_From Date_To Date_Different Date Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20038_Reports_Date_Range_From_Date_To_Date_Different_Date_Selected()
        {
            testCaseId = "TC-20038";
            qTestUniqueId = "43382489";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reports_Days of No Flow (AMR)_Include/Exclude Groups filter_Display_View Groups Permissions_Enabled
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20073_Reports_Days_of_No_Flow_AMR_Include_Exclude_Groups_Filter_Display_View_Groups_Permissions_Enabled()
        {
            testCaseId = "TC-20073";
            qTestUniqueId = "43423845";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowIncludeExclude();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Days of_Consumption_Include/Exclude Groups filter_Display_View Groups Permissions_Enabled
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20074_Reports_Days_of_Consumption_Include_Exclude_Groups_Filter_Display_View_Groups_Permissions_Enabled()
        {
            testCaseId = "TC-20074";
            qTestUniqueId = "43423846";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfCosumptionIncludeExclude();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_AMI_NO_FLOW_Include/Exclude Groups filter_Display_View Groups Permissions_Enabled
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20075_Reports_AMI_NO_FLOW_Include_Exclude_Groups_Filter_Display_View_Groups_Permissions_Enabled()
        {
            testCaseId = "TC-20075";
            qTestUniqueId = "43423847";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAmiNOFlowIncludeExclude();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Inactive_FLOW_Include/Exclude Groups filter_Display_View Groups Permissions_Enabled
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20076_Reports_Inactive_Flow_Include_Exclude_Groups_Filter_Display_View_Groups_Permissions_Enabled()
        {
            testCaseId = "TC-20076";
            qTestUniqueId = "43423848";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowIncludeExclude();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_High Consumption_Include/Exclude Groups filter_Display_View Groups Permissions_Enabled
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20077_Reports_High_Consumption_Include_Exclude_Groups_Filter_Display_View_Groups_Permissions_Enabled()
        {
            testCaseId = "TC-20077";
            qTestUniqueId = "43423849";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConsumptionIncludeExclude();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Days of No Flow (AMR)_Include/Exclude Groups filter_Display_View Groups Permissions_Enabled
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20078_Reports_Days_of_No_Flow_AMR_Include_Exclude_Groups_Filter_Display_View_Groups_Permissions_Disabled()
        {
            testCaseId = "TC-20078";
            qTestUniqueId = "43423850";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];

                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.SelectUserRole("testneptuneauto1@gmail.com", "Neptune System Administrator");
                rolesPermissons.SetPermission("Neptune System Administrator", "View Groups", false);
                home.UserLogOut();
                home.NavigateToHome(url, "testneptuneauto1@gmail.com", "Naveen@12345",false);
                home.NavigateToLftNavReports();
                reportsPage.ValidateDaysOfNoFlowIncludeExcludeNotDisplayed();
                home.UserLogOut();

                // Reset changes
                home.NavigateToHome(url, userName, password, false);

                rolesPermissons.SetPermission("Neptune System Administrator", "View Groups", true);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Days of No Flow (AMR)_Include/Exclude Groups filter_Display_View Groups Permissions_Enabled
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20079_Reports_Days_of_No_Flow_AMR_Include_Exclude_Groups_Filter_Display_View_Groups_Permissions_Disabled()
        {
            testCaseId = "TC-20079";
            qTestUniqueId = "43423851";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.SelectUserRole("testneptuneauto1@gmail.com", "Neptune System Administrator");
                rolesPermissons.SetPermission("Neptune System Administrator", "View Groups", false);
                home.UserLogOut();
                home.NavigateToHome(url, "testneptuneauto1@gmail.com", "Naveen@12345", false);
                home.NavigateToLftNavReports();
                reportsPage.ValidateDaysOfCosumptionIncludeExcludeNotDisplayed();
                home.UserLogOut();

                // Reset changes
                home.NavigateToHome(url, userName, password, false);

                rolesPermissons.SetPermission("Neptune System Administrator", "View Groups", true);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_AMI No Flow_Include/Exclude Groups filter_Display_View Groups Permissions_disabled
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20080_Reports_AMI_No_Flow_Include_Exclude_Groups_Filter_Display_View_Groups_Permissions_disabled()
        {
            testCaseId = "TC-20080";
            qTestUniqueId = "43423852";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.SelectUserRole("testneptuneauto1@gmail.com", "Neptune System Administrator");
                rolesPermissons.SetPermission("Neptune System Administrator", "View Groups", false);
                home.UserLogOut();
                home.NavigateToHome(url, "testneptuneauto1@gmail.com", "Naveen@12345", false);
                home.NavigateToLftNavReports();
                reportsPage.ValidateAmiNOFlowIncludeExcludeDisabled();
                home.UserLogOut();
                // Reset changes
                home.NavigateToHome(url, userName, password, false);

                rolesPermissons.SetPermission("Neptune System Administrator", "View Groups", true);
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Inactive Flow_Include/Exclude Groups filter_Display_View Groups Permissions_disabled
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20081_Reports_Inactive_Flow_Include_Exclude_Groups_Filter_Display_View_Groups_Permissions_disabled()
        {
            testCaseId = "TC-20081";
            qTestUniqueId = "43423853";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.SelectUserRole("testneptuneauto1@gmail.com", "Neptune System Administrator");
                rolesPermissons.SetPermission("Neptune System Administrator", "View Groups", false);
                home.UserLogOut();
                home.NavigateToHome(url, "testneptuneauto1@gmail.com", "Naveen@12345", false);
                home.NavigateToLftNavReports();
                reportsPage.ValidateInactiveFlowIncludeExcludeDisabled();
                home.UserLogOut();
                // Reset changes
                home.NavigateToHome(url, userName, password, false);

                rolesPermissons.SetPermission("Neptune System Administrator", "View Groups", true);
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_High Consumption_Include/Exclude Groups filter_Display_View Groups Permissions_disabled
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20082_Reports_High_Consumption_Include_Exclude_Groups_Filter_Display_View_Groups_Permissions_disabled()
        {
            testCaseId = "TC-20082";
            qTestUniqueId = "43423855";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.SelectUserRole("testneptuneauto1@gmail.com", "Neptune System Administrator");
                rolesPermissons.SetPermission("Neptune System Administrator", "View Groups", false);
                home.UserLogOut();
                home.NavigateToHome(url, "testneptuneauto1@gmail.com", "Naveen@12345", false);
                home.NavigateToLftNavReports();
                reportsPage.ValidateHighConsumptionIncludeExcludeDisabled();
                home.UserLogOut();
                // Reset changes
                home.NavigateToHome(url, userName, password, false);

                rolesPermissons.SetPermission("Neptune System Administrator", "View Groups", true);
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_High Consumption_Days_Number Filed_Default Value
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20084_Reports_High_Consumption_Days_Number_Filed_Default_Value()
        {
            testCaseId = "TC-20084";
            qTestUniqueId = "43425393";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConsumptionDefaultDay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_High Consumption_Days_Number Field_Maximum Value
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20085_Reports_High_Consumption_Days_Number_Field_Maximum_Value()
        {
            testCaseId = "TC-20085";
            qTestUniqueId = "43425394";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConsumptionMaximumAllowedValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_High Consumption_Days_Number Field_Minimum Value
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20086_Reports_High_Consumption_Days_Number_Field_Minimum_Value()
        {
            testCaseId = "TC-20086";
            qTestUniqueId = "43425401";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConsumptionMinimumAllowedValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_High Consumption_Over Amount_Field Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20087_Report_High_Consumption_Over_Amount_Field_Display()
        {
            testCaseId = "TC-20087";
            qTestUniqueId = "43425403";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConsumpOverAmountFieldDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_High Consumption_Over Amount_Default Value
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20088_Report_High_Consumption_Over_Amount_Default_Value()
        {
            testCaseId = "TC-20088";
            qTestUniqueId = "43425408";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConsumpDefaultValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_High Consumption_Min Threshold_Field Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20089_Report_High_Consumption_Min_Threshold_Field_Display()
        {
            testCaseId = "TC-20089";
            qTestUniqueId = "43425409";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConsumpMinThreshold();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_High Consumption_Min Threshold_Default Value
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20090_Report_High_Consumption_Min_Threshold_Default_Value()
        {
            testCaseId = "TC-20090";
            qTestUniqueId = "43425410";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConsumpMinThreshold();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Endpoints Container_High Consumption_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20137_Reports_Endpoints_Container_High_Consumption_Display()
        {
            testCaseId = "TC-20137";
            qTestUniqueId = "43465888";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConumptionDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Endpoints Container_High Consumption_Access
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20138_Reports_Endpoints_Container_High_Consumption_Access()
        {
            testCaseId = "TC-20138";
            qTestUniqueId = "43465889";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConumptionAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_High Consumption_Detailed Report_Back to Reports_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20139_Report_High_Consumption_Detailed_Report_Back_to_Reports_Display()
        {
            testCaseId = "TC-20139";
            qTestUniqueId = "43465890";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConsumptionBacktoReportsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Mach 10 Battery Status_PDF Download_Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14172_Reports_Mach_10_Battery_Status_PDF_Download_Validation()
        {
            testCaseId = "TC-14172";
            qTestUniqueId = "30516668";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10PDFIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Mach 10 Battery Status_Excel Download_Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14173_Reports_Mach_10_Battery_Status_Excel_Download_Validation()
        {
            testCaseId = "TC-14173";
            qTestUniqueId = "30516669";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10ExcelIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Mach 10 Battery Status_Inactive Meters_Not Displayed
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14177_Reports_Mach_10_Battery_Status_Inactive_Meters_Not_Displayed()
        {
            testCaseId = "TC-14177";
            qTestUniqueId = "30516673";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10InactiveMeters();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Exception Meter Reading Reports_Report Layout_From Date Default
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14396_Reports_Exception_Meter_Reading_Reports_Report_Layout_From_Date_Default()
        {
            testCaseId = "TC-14396";
            qTestUniqueId = "31638823";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesFromDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Exception Meter Reading Reports_Report Layout_To Date Default
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14397_Reports_Exception_Meter_Reading_Reports_Report_Layout_To_Date_Default()
        {
            testCaseId = "TC-14397";
            qTestUniqueId = "31638853";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Exception Meter Reading Reports_Report Layout_From Date Not Later Than To Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14398_Reports_Exception_Meter_Reading_Reports_Report_Layout_From_Date_Not_Later_Than_To_Date()
        {
            testCaseId = "TC-14398";
            qTestUniqueId = "31639623";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesFromDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Exception Meter Reading Reports_Report Layout_To Date Cannot Be Later Than Today
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14399_Reports_Exception_Meter_Reading_Reports_Report_Layout_To_Date_Cannot_Be_Later_Than_Today()
        {
            testCaseId = "TC-14399";
            qTestUniqueId = "31639624";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Report Page_Invalid Readings_Location
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14418_Reports_Report_Page_Invalid_Readings_Location()
        {
            testCaseId = "TC-14418";
            qTestUniqueId = "31883608";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
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

        /// Test Method to Reports_Report Page_Invalid Readings_Begin Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14419_Reports_Report_Page_Invalid_Readings_Begin_Date()
        {
            testCaseId = "TC-14419";
            qTestUniqueId = "31883728";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingFromDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Report Page_Invalid Readings_End Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14420_Reports_Report_Page_Invalid_Readings_End_Date()
        {
            testCaseId = "TC-14420";
            qTestUniqueId = "31883752";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Report Page_Invalid Readings_Generate Report
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14421_Reports_Report_Page_Invalid_Readings_Generate_Report()
        {
            testCaseId = "TC-14421";
            qTestUniqueId = "31884136";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingReportDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Report Page_Invalid Readings_Report Columns
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14422_Reports_Report_Page_Invalid_Readings_Report_Columns()
        {
            testCaseId = "TC-14422";
            qTestUniqueId = "31884163";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsColumnDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings_Cycle/Route_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14423_Reports_Invalid_Readings_Cycle_Route_Data_Validation()
        {
            testCaseId = "TC-14423";
            qTestUniqueId = "31884224";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsRouteDataValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings_Read Seq_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14424_Reports_Invalid_Readings_Read_Seq_Data_Validation()
        {
            testCaseId = "TC-14424";
            qTestUniqueId = "31884264";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsReadSeqDataValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings_MIU ID_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14425_Reports_Invalid_Readings_MIU_ID_Data_Validation()
        {
            testCaseId = "TC-14425";
            qTestUniqueId = "31884266";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsMIuIDDataValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings_Name_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14426_Reports_Invalid_Readings_Name_Data_Validation()
        {
            testCaseId = "TC-14426";
            qTestUniqueId = "31884267";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsNameDataValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reports_Invalid Readings_Account_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14427_Reports_Invalid_Readings_Account_Data_Validation()
        {
            testCaseId = "TC-14427";
            qTestUniqueId = "31884273";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsAccountDataValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings_Address_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14428_Reports_Invalid_Readings_Address_Data_Validation()
        {
            testCaseId = "TC-14428";
            qTestUniqueId = "31884274";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsAddressDataValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings_Invalid Read_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14429_Reports_Invalid_Readings_Invalid_Read_Data_Validation()
        {
            testCaseId = "TC-14429";
            qTestUniqueId = "31884275";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsInvalidReadDataValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings_Invalid Read Date_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14430_Reports_Invalid_Readings_Invalid_Read_Date_Data_Validation()
        {
            testCaseId = "TC-14430";
            qTestUniqueId = "31884276";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsInvalidReadDateDataValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings_Comment Codes_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14431_Reports_Invalid_Readings_Comment_Codes_Data_Validation()
        {
            testCaseId = "TC-14431";
            qTestUniqueId = "31884278";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsCommCodeDataValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings_Last Read_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14432_Reports_Invalid_Readings_Last_Read_Data_Validation()
        {
            testCaseId = "TC-14432";
            qTestUniqueId = "31884279";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsLastReadDataValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings_Last Read Date_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14433_Reports_Invalid_Readings_Last_Read_Date_Data_Validation()
        {
            testCaseId = "TC-14433";
            qTestUniqueId = "31884280";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsLastReadDateDataValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings Back Button
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14435_Reports_Invalid_Readings_Back_Button()
        {
            testCaseId = "TC-14435";
            qTestUniqueId = "31884352";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsBackToReports();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings Export as PDF
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14436_Reports_Invalid_Readings_Export_as_PDF()
        {
            testCaseId = "TC-14436";
            qTestUniqueId = "31884353";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingPDFIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Invalid Readings Export as Excel
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14437_Reports_Invalid_Readings_Export_as_Excel()
        {
            testCaseId = "TC-14437";
            qTestUniqueId = "31884356";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingExcelIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Begin Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14511_Reports_Comments_Begin_Date()
        {
            testCaseId = "TC-14511";
            qTestUniqueId = "31997137";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsBeginDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_End Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14512_Reports_Comments_End_Date()
        {
            testCaseId = "TC-14512";
            qTestUniqueId = "31997138";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Generate Report
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14513_Reports_Comments_Generate_Report()
        {
            testCaseId = "TC-14513";
            qTestUniqueId = "31997139";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments Report Columns
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14514_Reports_Comments_Report_Columns()
        {
            testCaseId = "TC-14514";
            qTestUniqueId = "31997140";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments Report Columns
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14515_Reports_Comments_Report_Columns()
        {
            testCaseId = "TC-14515";
            qTestUniqueId = "31997141";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Read Seq_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14516_Reports_Comments_Read_Seq_Data_Validation()
        {
            testCaseId = "TC-14516";
            qTestUniqueId = "31997142";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Account_Name_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14518_Reports_Comments_Account_Name_Data_Validation()
        {
            testCaseId = "TC-14518";
            qTestUniqueId = "31997144";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Account_Number_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14519_Reports_Comments_Account_Number_Data_Validation()
        {
            testCaseId = "TC-14519";
            qTestUniqueId = "31997145";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Address_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14520_Reports_Comments_Address_Data_Validation()
        {
            testCaseId = "TC-14520";
            qTestUniqueId = "31997146";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_MIU ID_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14517_Reports_Comments_MIU_ID_Data_Validation()
        {
            testCaseId = "TC-14517";
            qTestUniqueId = "31997143";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Meter_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14522_Reports_Comments_Meter_Data_Validation()
        {
            testCaseId = "TC-14522";
            qTestUniqueId = "31997143";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Comments_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14523_Reports_Comments_Comments_Data_Validation()
        {
            testCaseId = "TC-14523";
            qTestUniqueId = "31997149";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reports_Comments_Date_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14525_Reports_Comments_Date_Data_Validation()
        {
            testCaseId = "TC-14525";
            qTestUniqueId = "31997151";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Back Button
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14526_Reports_Comments_Back_Button()
        {
            testCaseId = "TC-14526";
            qTestUniqueId = "31997152";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsBackToReports();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Export as PDF
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14527_Reports_Comments_Export_as_PDF()
        {
            testCaseId = "TC-14527";
            qTestUniqueId = "31997153";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsPDFIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Export as Excel
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14528_Reports_Comments_Export_as_Excel()
        {
            testCaseId = "TC-14528";
            qTestUniqueId = "31997154";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsExcelIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Results Ordered by Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14547_Reports_Comments_Results_Ordered_by_Date()
        {
            testCaseId = "TC-14547";
            qTestUniqueId = "31998052";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsResultsByDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Comments_Results Grouped by Read Sequence
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14548_Reports_Comments_Results_Grouped_by_Read_Sequence()
        {
            testCaseId = "TC-14548";
            qTestUniqueId = "31998053";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsResultsByDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reports_Coded Notes_Begin Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14529_Reports_Coded_Notes_Begin_Date()
        {
            testCaseId = "TC-14529";
            qTestUniqueId = "31997194";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesFromDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Coded Notes_End Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14530_Reports_Coded_Notes_End_Date()
        {
            testCaseId = "TC-14530";
            qTestUniqueId = "31997195";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Coded Notes_Generate Report
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14531_Reports_Coded_Notes_Generate_Report()
        {
            testCaseId = "TC-14531";
            qTestUniqueId = "31997196";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Coded Notes_Report Columns
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14532_Reports_Coded_Notes_Report_Columns()
        {
            testCaseId = "TC-14532";
            qTestUniqueId = "31997197";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Coded Notes_Report Columns
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14533_Reports_Coded_Notes_Report_Columns()
        {
            testCaseId = "TC-14533";
            qTestUniqueId = "31997198";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedNotesFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Columns_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15645_Report_Days_of_No_Flow_AMR_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-15645";
            qTestUniqueId = "34414559";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowColumnDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Cycle/Route
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15646_Report_Days_of_No_Flow_AMR_Detailed_Report_Cycle_Route()
        {
            testCaseId = "TC-15646";
            qTestUniqueId = "34414584";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowCycleRoute();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Read Seq
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15647_Report_Days_of_No_Flow_AMR_Detailed_Report_Read_Seq()
        {
            testCaseId = "TC-15647";
            qTestUniqueId = "34414610";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowReadSeq();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_MIU
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15648_Report_Days_of_No_Flow_AMR_Detailed_Report_MIU()
        {
            testCaseId = "TC-15648";
            qTestUniqueId = "34414630";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowMIU();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Account Name
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15649_Report_Days_of_No_Flow_AMR_Detailed_Report_Account_Name()
        {
            testCaseId = "TC-15649";
            qTestUniqueId = "34414647";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowAccName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Account Number
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15650_Report_Days_of_No_Flow_AMR_Detailed_Report_Account_Number()
        {
            testCaseId = "TC-15650";
            qTestUniqueId = "34414668";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowAccNumber();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Address
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15651_Report_Days_of_No_Flow_AMR_Detailed_Report_Address()
        {
            testCaseId = "TC-15651";
            qTestUniqueId = "34414709";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowAddress();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Consec Days
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15652_Report_Days_of_No_Flow_AMR_Detailed_Report_Consec_Days()
        {
            testCaseId = "TC-15652";
            qTestUniqueId = "34414729";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoConsecDays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Reading
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15653_Report_Days_of_No_Flow_AMR_Detailed_Report_Reading()
        {
            testCaseId = "TC-15653";
            qTestUniqueId = "34414747";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowReading();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Date/Time
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15654_Report_Days_of_No_Flow_AMR_Detailed_Report_Date_Time()
        {
            testCaseId = "TC-15654";
            qTestUniqueId = "34414753";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowDateTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Sort Order_First_Consec Days
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15655_Report_Days_of_No_Flow_AMR_Detailed_Report_Sort_Order_First_Consec_Days()
        {
            testCaseId = "TC-15655";
            qTestUniqueId = "34414771";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.validateConsecDaysOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Sort Order_Second_Cycle/Route
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15656_Report_Days_of_No_Flow_AMR_Detailed_Report_Sort_Order_Second_Cycle_Route()
        {
            testCaseId = "TC-15656";
            qTestUniqueId = "34414817";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCycleRouteOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Sort Order_Last_Read Seq
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15657_Report_Days_of_No_Flow_AMR_Detailed_Report_Sort_Order_Last_Read_Seq()
        {
            testCaseId = "TC-15657";
            qTestUniqueId = "34414839";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReadSeqOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Back to Reports_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15658_Report_Days_of_No_Flow_AMR_Detailed_Report_Back_to_Reports_Display()
        {
            testCaseId = "TC-15658";
            qTestUniqueId = "34414855";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysNoFlowBackToReportsDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_Back to Reports_Click
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15659_Report_Days_of_No_Flow_AMR_Detailed_Report_Back_to_Reports_Click()
        {
            testCaseId = "TC-15659";
            qTestUniqueId = "34414885";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofNoFlowBackToReportsClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_From Date_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15660_Report_Days_of_No_Flow_AMR_Detailed_Report_From_Date_Display()
        {
            testCaseId = "TC-15660";
            qTestUniqueId = "34414914";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFromDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_To Date_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15661_Report_Days_of_No_Flow_AMR_Detailed_Report_To_Date_Display()
        {
            testCaseId = "TC-15661";
            qTestUniqueId = "34429195";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_From Date_Default Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15662_Report_Days_of_No_Flow_AMR_Detailed_Report_From_Date_Default_Date()
        {
            testCaseId = "TC-15662";
            qTestUniqueId = "34429311";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFromDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_To Date_Default Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15663_Report_Days_of_No_Flow_AMR_Detailed_Report_To_Date_Default_Date()
        {
            testCaseId = "TC-15663";
            qTestUniqueId = "34429357";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_From Date_Editable
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15664_Report_Days_of_No_Flow_AMR_Detailed_Report_From_Date_Editable()
        {
            testCaseId = "TC-15664";
            qTestUniqueId = "34429387";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFromDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_To Date_Editable
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15665_Report_Days_of_No_Flow_AMR_Detailed_Report_To_Date_Editable()
        {
            testCaseId = "TC-15665";
            qTestUniqueId = "34429411";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoToDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report__Date Range Selected_Updated Data Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15666_Report_Days_of_No_Flow_AMR_Detailed_Report_Date_Range_Selected_Updated_Data_Display()
        {
            testCaseId = "TC-15666";
            qTestUniqueId = "34429456";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_To Date_Future Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15667_Report_Days_of_No_Flow_AMR_Detailed_Report_To_Date_Future_Date()
        {
            testCaseId = "TC-15667";
            qTestUniqueId = "34429475";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_From Date_Future Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15668_Report_Days_of_No_Flow_AMR_Detailed_Report_From_Date_Future_Date()
        {
            testCaseId = "TC-15668";
            qTestUniqueId = "34429496";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_From Date_Equal To Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15669_Report_Days_of_No_Flow_AMR_Detailed_Report_From_Date_Equal_To_Date()
        {
            testCaseId = "TC-15669";
            qTestUniqueId = "34429515";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report MIU ID/Meter_35 Day No Flow code value_1_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15775_Report_Days_of_No_Flow_AMR_Detailed_Report_MIU_ID_Meter_35_Day_No_Flow_code_value_1_Display()
        {
            testCaseId = "TC-15775";
            qTestUniqueId = "34518945";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowCodeValue1();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report MIU ID/Meter_35 Day No Flow code value_2_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15776_Report_Days_of_No_Flow_AMR_Detailed_Report_MIU_ID_Meter_35_Day_No_Flow_code_value_2_Display()
        {
            testCaseId = "TC-15776";
            qTestUniqueId = "34518945";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowCodeValue2();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report MIU ID/Meter_35 Day No Flow code value_3_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15777_Report_Days_of_No_Flow_AMR_Detailed_Report_MIU_ID_Meter_35_Day_No_Flow_code_value_3_Display()
        {
            testCaseId = "TC-15777";
            qTestUniqueId = "34518947";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowCodeValue3();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report MIU ID/Meter_35 Day No Flow code value_4_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15778_Report_Days_of_No_Flow_AMR_Detailed_Report_MIU_ID_Meter_35_Day_No_Flow_code_value_4_Display()
        {
            testCaseId = "TC-15778";
            qTestUniqueId = "34518950";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowCodeValue4();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report MIU ID/Meter_35 Day No Flow code value_5_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15779_Report_Days_of_No_Flow_AMR_Detailed_Report_MIU_ID_Meter_35_Day_No_Flow_code_value_5_Display()
        {
            testCaseId = "TC-15779";
            qTestUniqueId = "34518951";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowCodeValue5();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report MIU ID/Meter_35 Day No Flow code value_6_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15780_Report_Days_of_No_Flow_AMR_Detailed_Report_MIU_ID_Meter_35_Day_No_Flow_code_value_6_Display()
        {
            testCaseId = "TC-15780";
            qTestUniqueId = "34518952";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowCodeValue6();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report MIU ID/Meter_35 Day No Flow code value_0_Not_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15781_Report_Days_of_No_Flow_AMR_Detailed_Report_MIU_ID_Meter_35_Day_No_Flow_code_value_0_Not_Display()
        {
            testCaseId = "TC-15781";
            qTestUniqueId = "34518953";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowCodeValue0();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report MIU ID/Meter_35 Day No Flow code value_7_Not_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15782_Report_Days_of_No_Flow_AMR_Detailed_Report_MIU_ID_Meter_35_Day_No_Flow_code_value_7_Not_Display()
        {
            testCaseId = "TC-15782";
            qTestUniqueId = "34518953";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowCodeValue7();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report MIU ID/Meter_Display Once
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15783_Report_Days_of_No_Flow_AMR_Detailed_Report_MIU_ID_Meter_Display_Once()
        {
            testCaseId = "TC-15783";
            qTestUniqueId = "34519199";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_To Date_Default Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15867_Report_Days_of_Consumption_AMR_Detailed_Report_To_Date_Default_Date()
        {
            testCaseId = "TC-15867";
            qTestUniqueId = "34546056";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_MIU ID/Meter_Leak Code Days_5_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15878_Report_Days_of_Consumption_AMR_Detailed_Report_MIU_ID_Meter_Leak_Code_Days_5_Display()
        {
            testCaseId = "TC-15878";
            qTestUniqueId = "34546056";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionCodeValue5();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_MIU ID/Meter_Leak Code Days_6_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15879_Report_Days_of_Consumption_AMR_Detailed_Report_MIU_ID_Meter_Leak_Code_Days_6_Display()
        {
            testCaseId = "TC-15879";
            qTestUniqueId = "34546202";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionCodeValue6();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_MIU ID/Meter_Leak Code Days_0_Not_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15880_Report_Days_of_Consumption_AMR_Detailed_Report_MIU_ID_Meter_Leak_Code_Days_0_Not_Display()
        {
            testCaseId = "TC-15880";
            qTestUniqueId = "34546203";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionCodeValue0();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_MIU ID/Meter_Leak Code Days_7_Not_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15881_Report_Days_of_Consumption_AMR_Detailed_Report_MIU_ID_Meter_Leak_Code_Days_7_Not_Display()
        {
            testCaseId = "TC-15881";
            qTestUniqueId = "34546204";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionCodeValue7();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_MIU ID/Meter_Specified Date Range_Multiple Readings_Display MOre than Once
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15882_Report_Days_of_Consumption_AMR_Detailed_Report_MIU_ID_Meter_Specified_Date_Range_Multiple_Readings_Display_MOre_than_Once()
        {
            testCaseId = "TC-15882";
            qTestUniqueId = "34553142";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionMiuId();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Breadcrumb
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16780_Report_Days_of_No_Flow_AMR_Breadcrumb()
        {
            testCaseId = "TC-16780";
            qTestUniqueId = "34771472";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowBreadcrumb();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of No Flow (AMR)_Detailed Report_URL
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16781_Report_Days_of_No_Flow_AMR_Detailed_Report_URL()
        {
            testCaseId = "TC-16781";
            qTestUniqueId = "35809987";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfNoFlowURL();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Breadcrumb
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16782_Report_Days_of_Consumption_AMR_Detailed_Report_Breadcrumb()
        {
            testCaseId = "TC-16782";
            qTestUniqueId = "35809988";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionBreadcrumb();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_URL
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16783_Report_Days_of_Consumption_AMR_Detailed_Report_URL()
        {
            testCaseId = "TC-16783";
            qTestUniqueId = "35809989";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionURL();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Found Meters_Detailed Report_Claimed MIU_Not Included
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18226_Reports_Found_Meters_Detailed_Report_Claimed_MIU_Not_Included()
        {
            testCaseId = "TC-18226";
            qTestUniqueId = "39379617";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersMIU();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Found Meters_Detailed Report_Columns_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18231_Reports_Found_Meters_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-18231";
            qTestUniqueId = "39379624";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersColumns();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Found Meters_Detailed Report_MIU
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18232_Reports_Found_Meters_Detailed_Report_MIU()
        {
            testCaseId = "TC-18232";
            qTestUniqueId = "39379624";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersMIU();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Found Meters_Detailed Report_Reading
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18233_Reports_Found_Meters_Detailed_Report_Reading()
        {
            testCaseId = "TC-18233";
            qTestUniqueId = "39379626";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersReading();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Found Meters_Detailed Report_Date/Time
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18234_Reports_Found_Meters_Detailed_Report_Date_Time()
        {
            testCaseId = "TC-18234";
            qTestUniqueId = "39379628";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersDateTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Found Meters_Detailed Report_FirstRead
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18235_Reports_Found_Meters_Detailed_Report_First_Read()
        {
            testCaseId = "TC-18235";
            qTestUniqueId = "39379629";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersFirstRead();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Found Meters_Detailed Report_Sort Order_First_Date/Time
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18236_Reports_Found_Meters_Detailed_Report_Sort_Order_First_Date_Time()
        {
            testCaseId = "TC-18236";
            qTestUniqueId = "39379630";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersDateTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Found Meters_Detailed Report_Sort Order_First_Date/Time
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18237_Reports_Found_Meters_Detailed_Report_Sort_Order_First_Date_Time()
        {
            testCaseId = "TC-18237";
            qTestUniqueId = "39379631";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersDateTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Found Meters_Detailed Report_Back to Reports_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18238_Reports_Found_Meters_Detailed_Report_Back_to_Reports_Display()
        {
            testCaseId = "TC-18238";
            qTestUniqueId = "39379635";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersBackToReportsDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Found Meters_Detailed Report_Back to Reports_Click
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18239_Reports_Found_Meters_Detailed_Report_Back_to_Reports_Click()
        {
            testCaseId = "TC-18239";
            qTestUniqueId = "39379637";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateFoundMetersBackToReportsClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Columns_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19146_Report_Days_of_Consumption_AMR_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-19146";
            qTestUniqueId = "41037923";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionColumnDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Route Filter_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19151_Report_Days_of_Consumption_AMR_Detailed_Report_Route_Filter_Display()
        {
            testCaseId = "TC-19151";
            qTestUniqueId = "41037931";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionRouteFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Group Filter_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19152_Report_Days_of_Consumption_AMR_Detailed_Report_Group_Filter_Display()
        {
            testCaseId = "TC-19152";
            qTestUniqueId = "41037932";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionGroupFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Route Filter_One Route Select
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19153_Report_Days_of_Consumption_AMR_Detailed_Report_Route_Filter_One_Route_Select()
        {
            testCaseId = "TC-19153";
            qTestUniqueId = "41037933";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionRouteFilterSelect();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Route Filter_One Route Select Subtitle
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19154_Report_Days_of_Consumption_AMR_Detailed_Report_Route_Filter_One_Route_Select_Subtitle()
        {
            testCaseId = "TC-19154";
            qTestUniqueId = "41037934";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionRouteFilterSelectSubtitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consumption (AMR)_Detailed Report_Route Filter_No Route Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19155_Report_Days_of_Consumption_AMR_Detailed_Report_Route_Filter_No_Route_Selected()
        {
            testCaseId = "TC-19155";
            qTestUniqueId = "41037935";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionRouteFilterSelectAll();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Inactive Flow_Detailed Report_Title
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19620_Report_Inactive_Flow_Detailed_Report_Title()
        {
            testCaseId = "TC-19620";
            qTestUniqueId = "42377492";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report_Subitle
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19621_Report_Inactive_Flow_Detailed_Report_Subitle()
        {
            testCaseId = "TC-19621";
            qTestUniqueId = "42377493";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowReportSubtitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Coded Notes_Read Seq_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14534_Reports_Coded_Notes_Read_Seq_Data_Validation()
        {
            testCaseId = "TC-14534";
            qTestUniqueId = "31997199";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedReadSeq();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Coded Notes_Account Name_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14536_Reports_Coded_Notes_Account_Name_Data_Validation()
        {
            testCaseId = "TC-14536";
            qTestUniqueId = "31997199";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedReadSeq();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reports_Coded Notes_Account_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14537_Reports_Coded_Notes_Account_Data_Validation()
        {
            testCaseId = "TC-14537";
            qTestUniqueId = "31997202";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedReadSeq();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Coded Notes_Address_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14538_Reports_Coded_Notes_Address_Data_Validation()
        {
            testCaseId = "TC-14538";
            qTestUniqueId = "31997203";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedReadSeq();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Coded Notes_MIU_Data Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_14535_Reports_Coded_Notes_MIU_Data_Validation()
        {
            testCaseId = "TC-14535";
            qTestUniqueId = "31997200";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCodedReadSeq();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Soft Disconnect_Detailed Report_Columns_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20439_Report_Soft_Disconnect_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-20439";
            qTestUniqueId = "43929182";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateSoftDisconnetColumnDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Soft Disconnect_Detailed Report Account Name
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20440_Report_Soft_Disconnect_Detailed_Report_Account_Name()
        {
            testCaseId = "TC-20440";
            qTestUniqueId = "43929183";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateSoftDisconnetAccName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Soft Disconnect_Detailed Report Account Number
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20441_Report_Soft_Disconnect_Detailed_Report_Account_Number()
        {
            testCaseId = "TC-20441";
            qTestUniqueId = "43929184";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateSoftDisconnetAccNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Soft Disconnect_Detailed Report Address
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20442_Report_Soft_Disconnect_Detailed_Report_Address()
        {
            testCaseId = "TC-20442";
            qTestUniqueId = "43929185";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateSoftDisconnetAddress();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Soft Disconnect_Detailed Report Meter Number
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20443_Report_Soft_Disconnect_Detailed_Report_Meter_Number()
        {
            testCaseId = "TC-20443";
            qTestUniqueId = "43929186";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateSoftDisconnetMeterNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Soft Disconnect_Detailed Report MIU ID
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20444_Report_Soft_Disconnect_Detailed_Report_MIU_ID()
        {
            testCaseId = "TC-20444";
            qTestUniqueId = "43929187";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateSoftDisconnetMiuId();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Soft Disconnect_Detailed Report Meter Size
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20445_Report_Soft_Disconnect_Detailed_Report_Meter_Size()
        {
            testCaseId = "TC-20445";
            qTestUniqueId = "43929188";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateSoftDisconnetMeterSize();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Soft Disconnect_Detailed Report Start Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20446_Report_Soft_Disconnect_Detailed_Report_Start_Date()
        {
            testCaseId = "TC-20446";
            qTestUniqueId = "43929189";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateSoftDisconnetStartDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Soft Disconnect_Detailed Report End Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20447_Report_Soft_Disconnect_Detailed_Report_End_Date()
        {
            testCaseId = "TC-20447";
            qTestUniqueId = "43929190";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateSoftDisconnetEndDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Soft Disconnect_Detailed Report Consumption
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20448_Report_Soft_Disconnect_Detailed_Report_Consumption()
        {
            testCaseId = "TC-20448";
            qTestUniqueId = "43929191";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateSoftDisconnetConsumption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Soft Disconnect_Detailed Report UOM
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20449_Report_Soft_Disconnect_Detailed_Report_UOM()
        {
            testCaseId = "TC-20449";
            qTestUniqueId = "43929192";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateSoftDisconnetUOM();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Soft Disconnect_Detailed Report_Sort Order_Consumption
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20450_Soft_Disconnect_Detailed_Report_Sort_Order_Consumption()
        {
            testCaseId = "TC-20450";
            qTestUniqueId = "43929193";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateSoftDisconnetUOM();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Soft Disconnect_Detailed Report_Cycle/Route
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20451_Soft_Disconnect_Detailed_Report_Cycle_Route()
        {
            testCaseId = "TC-20451";
            qTestUniqueId = "43929663";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateSoftDisconnetCycleRoute();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Account Name
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21022_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Account_Name()
        {
            testCaseId = "TC-21022";
            qTestUniqueId = "45934600";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowAccName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Address
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21024_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Address()
        {
            testCaseId = "TC-21024";
            qTestUniqueId = "45934602";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowAddress();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Meter Number
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21025_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Meter_Number()
        {
            testCaseId = "TC-21025";
            qTestUniqueId = "45934603";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowMeterNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_MIU ID
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21026_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_MIU_ID()
        {
            testCaseId = "TC-21026";
            qTestUniqueId = "45934604";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowMiuId();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Meter_Size
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21027_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Meter_Size()
        {
            testCaseId = "TC-21027";
            qTestUniqueId = "45934605";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowMeterSize();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Flag Start Read Date 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21028_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Flag_Start_Read_Date()
        {
            testCaseId = "TC-21028";
            qTestUniqueId = "45934606";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowFlagStartDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Flag Stop Read Date 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21029_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Flag_Stop_Read_Date()
        {
            testCaseId = "TC-21029";
            qTestUniqueId = "45934607";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowFlagStopDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Last Read Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21030_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Last_Read_Date()
        {
            testCaseId = "TC-21030";
            qTestUniqueId = "45934608";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowLastReadDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_UOM
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21031_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_UOM()
        {
            testCaseId = "TC-21031";
            qTestUniqueId = "45934609";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowUOM();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Avg Daily Flow (Event) 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21032_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Avg_Daily_Flow_Even()
        {
            testCaseId = "TC-21032";
            qTestUniqueId = "45935703";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowAvgDailyFlow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Avg Daily Flow (Event) 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21033_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Avg_Daily_Flow_Prior()
        {
            testCaseId = "TC-21033";
            qTestUniqueId = "45935704";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowAvgDailyPrior();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Flow Type 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21034_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Flow_Type()
        {
            testCaseId = "TC-21034";
            qTestUniqueId = "45935705";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowFlowType();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Days 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21035_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Days()
        {
            testCaseId = "TC-21035";
            qTestUniqueId = "45935706";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowDays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report_Cycle/Route 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19623_Report_Inactive_Flow_Detailed_Report_Cycle_Route()
        {
            testCaseId = "TC-19623";
            qTestUniqueId = "42377495";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowCycleRoute();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report Account Name
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19624_Report_Inactive_Flow_Detailed_Report_Account_Name()
        {
            testCaseId = "TC-19624";
            qTestUniqueId = "42377496";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowAccName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report Account Number
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19625_Report_Inactive_Flow_Detailed_Report_Account_Number()
        {
            testCaseId = "TC-19625";
            qTestUniqueId = "42377497";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowAccNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Report_Inactive Flow_Detailed Report Address
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19626_Report_Inactive_Flow_Detailed_Report_Address()
        {
            testCaseId = "TC-19626";
            qTestUniqueId = "42377498";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowAddress();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report MIU ID
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19627_Report_Inactive_Flow_Detailed_Report_MIU_ID()
        {
            testCaseId = "TC-19627";
            qTestUniqueId = "42377499";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowMIuID();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report Meter_No
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19628_Report_Inactive_Flow_Detailed_Report_Meter_No()
        {
            testCaseId = "TC-19628";
            qTestUniqueId = "42377500";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowMeterNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report Meter Size
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19629_Report_Inactive_Flow_Detailed_Report_Meter_Size()
        {
            testCaseId = "TC-19629";
            qTestUniqueId = "42377501";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowMeterSize();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report Account Status
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19630_Report_Inactive_Flow_Detailed_Report_Account_Status()
        {
            testCaseId = "TC-19630";
            qTestUniqueId = "42377502";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowAccStatus();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report Inactive Since
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19631_Report_Inactive_Flow_Detailed_Report_Inactive_Since()
        {
            testCaseId = "TC-19631";
            qTestUniqueId = "42377503";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowAccStatus();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report Consumption
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19632_Report_Inactive_Flow_Detailed_Report_Consumption()
        {
            testCaseId = "TC-19632";
            qTestUniqueId = "42377504";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveConsumption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report UOM
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19633_Report_Inactive_Flow_Detailed_Report_UOM()
        {
            testCaseId = "TC-19633";
            qTestUniqueId = "42377505";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowUOM();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Report_Inactive Flow_Detailed Report Back to Reports_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19637_Report_Inactive_Flow_Detailed_Report_Back_to_Reports_Display()
        {
            testCaseId = "TC-19637";
            qTestUniqueId = "42387676";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowBacktoReportsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report Back to Reports_Click
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19638_Report_Inactive_Flow_Detailed_Report_Back_to_Reports_Click()
        {
            testCaseId = "TC-19638";
            qTestUniqueId = "42387677";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowBacktoReportsClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Report_Inactive Flow_Detailed Report Group Filter_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19640_Report_Inactive_Flow_Detailed_Report_Group_Filter_Display()
        {
            testCaseId = "TC-19640";
            qTestUniqueId = "42389176";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowBackGroupFilterDislay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Report_Inactive Flow_Detailed Report Group Filter Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19641_Report_Inactive_Flow_Detailed_Report_Group_Filter_Selected()
        {
            testCaseId = "TC-19641";
            qTestUniqueId = "42389193";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowBackGroupFilterSelected();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report Group Filter One Group Select
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19642_Report_Inactive_Flow_Detailed_Report_Group_Filter_One_Group_Select()
        {
            testCaseId = "TC-19642";
            qTestUniqueId = "42389202";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowBackGroupFilterOneSeleted();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report_Group Filter_Group with Include_Select
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19643_Report_Inactive_Flow_Detailed_Report_Group_Filter_Group_with_Include_Select()
        {
            testCaseId = "TC-19643";
            qTestUniqueId = "42389203";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowBackGroupFilterOneSeleted();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report_Group Filter_Group with Exclude_Select
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19644_Report_Inactive_Flow_Detailed_Report_Group_Filter_Group_with_Exclude_Select()
        {
            testCaseId = "TC-19644";
            qTestUniqueId = "42389204";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowBackGroupFilterOneSeleted();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report_Group Filter_Group Select _MIU Meters Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19645_Report_Inactive_Flow_Detailed_Report_Group_Filter_Group_Select_MIU_Meters_Display()
        {
            testCaseId = "TC-19645";
            qTestUniqueId = "42391593";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowBackGroupFilterOneSeletedMiuId();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report_Route Filter_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19646_Report_Inactive_Flow_Detailed_Report_Route_Filter_Display()
        {
            testCaseId = "TC-19646";
            qTestUniqueId = "42392207";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowBackRouteFilterDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report_Route Filter_No Route Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19647_Report_Inactive_Flow_Detailed_Report_Route_Filter_No_Route_Selected()
        {
            testCaseId = "TC-19647";
            qTestUniqueId = "42392208";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowBackNoRouteSelected();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Inactive Flow_Detailed Report_Route Filter_One Route Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19648_Report_Inactive_Flow_Detailed_Report_Route_Filter_One_Route_Selected()
        {
            testCaseId = "TC-19648";
            qTestUniqueId = "42392209";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowBacOneRouteSelected();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Inactive Flow_Detailed Report_Route Filter_Route Select _MIU Meters Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19649_Report_Inactive_Flow_Detailed_Report_Route_Filter_Route_Select_MIU_Meters_Display()
        {
            testCaseId = "TC-19649";
            qTestUniqueId = "42392210";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowBacOneRouteSelectedMiuId();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report_Route Active Meters/MIUs_Not Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19650_Report_Inactive_Flow_Detailed_Report_Route_Active_Meters_MIUs_Not_Display()
        {
            testCaseId = "TC-19650";
            qTestUniqueId = "42392886";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowActiveMeters();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Inactive Flow_Detailed Report_Inactive Meters/MIUs without Consumption_Not Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19651_Report_Inactive_Flow_Detailed_Report_Inactive_Meters_MIUs_without_Consumption_Not_Display()
        {
            testCaseId = "TC-19651";
            qTestUniqueId = "42392887";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowActiveMeters();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_AMI Endpoint Maintenance_Detailed Report_Route Filter_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20819_Report_AMI_Endpoint_Maintenance_Detailed_Report_Route_Filter_Display()
        {
            testCaseId = "TC-20819";
            qTestUniqueId = "44662040";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowBackRouteFilterDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_AMI Endpoint Maintenance_Detailed Report_Group Filter_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20820_Report_AMI_Endpoint_Maintenance_Detailed_Report_Group_Filter_Display()
        {
            testCaseId = "TC-20820";
            qTestUniqueId = "44662041";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowBackGroupFilterDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_AMI Endpoint Maintenance_Detailed Report_Group Route Filter_No Route Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20821_Report_AMI_Endpoint_Maintenance_Detailed_Report_Route_Filter_No_Route_Selected()
        {
            testCaseId = "TC-20821";
            qTestUniqueId = "44662042";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowNoRouteSelected();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_AMI Endpoint Maintenance_Detailed Report_Group Route Filter_No Group Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20822_Report_AMI_Endpoint_Maintenance_Detailed_Report_Route_Filter_No_Group_Selected()
        {
            testCaseId = "TC-20822";
            qTestUniqueId = "44662043";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowNoGroupSelected();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_AMI Endpoint Maintenance_Detailed Report_Group Route Filter_Values
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20823_Report_AMI_Endpoint_Maintenance_Detailed_Report_Route_Filter_Values()
        {
            testCaseId = "TC-20823";
            qTestUniqueId = "44662044";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoFlowNoGroupSelected();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_AMI Endpoint Maintenance_Detailed Report_Group Filter_Values
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20824_Report_AMI_Endpoint_Maintenance_Detailed_Report_Group_Filter_Values()
        {
            testCaseId = "TC-20824";
            qTestUniqueId = "44662045";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointMaintenanceGroupSelected();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_AMI Endpoint Maintenance_Detailed Report_Group Date Pickers
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20825_Report_AMI_Endpoint_Maintenance_Detailed_Report_Date_Pickers()
        {
            testCaseId = "TC-20825";
            qTestUniqueId = "44662173";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointMaintenanceDatePickers();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_AMI Endpoint Maintenance_Detailed Report_Past Due Date Selector_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20826_Report_AMI_Endpoint_Maintenance_Detailed_Report_Past_Due_Date_Selector_Display()
        {
            testCaseId = "TC-20826";
            qTestUniqueId = "44662482";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointMaintenanceDatePickers();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_AMI Endpoint Maintenance_Detailed Report_Past Due Date Selector_Default Value
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20827_Report_AMI_Endpoint_Maintenance_Detailed_Report_Past_Due_Date_Selector_Default_Value()
        {
            testCaseId = "TC-20827";
            qTestUniqueId = "44662487";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointMaintenanceDatePickers();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_AMI Endpoint Maintenance_Detailed Report_Past Due Date Selector_Value Selection
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20828_Report_AMI_Endpoint_Maintenance_Detailed_Report_Past_Due_Date_Selector_Value_Selection()
        {
            testCaseId = "TC-20828";
            qTestUniqueId = "44662491";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointMaintenanceDatePickers();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Endpoints Container_Endpoint Maintenance_Detailed Report_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20878_Report_Endpoints_Container_Endpoint_Maintenance_Detailed_Report_Display()
        {
            testCaseId = "TC-20878";
            qTestUniqueId = "45080105";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointMaintenanceDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Endpoints Container_Endpoint Maintenance_Detailed Report_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20879_Report_Endpoints_Container_Endpoint_Maintenance_Detailed_Report_Display()
        {
            testCaseId = "TC-20879";
            qTestUniqueId = "45080614";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointMaintenanceDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Endpoint Maintenance_Detailed Report_Title
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20880_Report_Endpoint_Maintenance_Detailed_Report_Title()
        {
            testCaseId = "TC-20880";
            qTestUniqueId = "45080618";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointMaintenanceDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Endpoint Maintenance_Detailed Report_Columns_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20881_Report_Endpoint_Maintenance_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-20881";
            qTestUniqueId = "45080715";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointMaintenanceColumnsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Endpoint Maintenance_Detailed Report_Never Received Rollup KPI_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20882_Report_Endpoint_Maintenance_Detailed_Report_Never_Received_Rollup_KPI_Display()
        {
            testCaseId = "TC-20882";
            qTestUniqueId = "45080759";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateNeverReceivedKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Endpoint Maintenance_Detailed Report_Invalid Reads Rollup KPI_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20883_Report_Endpoint_Maintenance_Detailed_Report_Invalid_Reads_Rollup_KPI_Display()
        {
            testCaseId = "TC-20883";
            qTestUniqueId = "45080782";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadsKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Endpoint Maintenance_Detailed Report_Past Due Rollup KPI_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20884_Report_Endpoint_Maintenance_Detailed_Report_Past_Due_Rollup_KPI_Display()
        {
            testCaseId = "TC-20884";
            qTestUniqueId = "45080789";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidatePastDueRollupKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Endpoint Maintenance_Detailed Report_Total MIUs Rollup KPI_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20885_Report_Endpoint_Maintenance_Detailed_Report_Total_MIUs_Rollup_KPI_Display()
        {
            testCaseId = "TC-20885";
            qTestUniqueId = "45080790";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateTotalMiuKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Endpoint Maintenance_Detailed Report_Never Received KPI_Map Icon_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20886_Report_Endpoint_Maintenance_Detailed_Report_Never_Received_KPI_Map_Icon_Display()
        {
            testCaseId = "TC-20886";
            qTestUniqueId = "45080813";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateNeverReceivedMap();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Endpoint Maintenance_Detailed Report_Invalid Reads KPI Map Icon_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20887_Report_Endpoint_Maintenance_Detailed_Report_Invalid_Reads_KPI_Map_Icon_Display()
        {
            testCaseId = "TC-20887";
            qTestUniqueId = "45080814";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadMap();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Endpoint Maintenance_Detailed Report_Past_Due KPI Map Icon_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20888_Report_Endpoint_Maintenance_Detailed_Report_Past_Due_KPI_Map_Icon_Display()
        {
            testCaseId = "TC-20888";
            qTestUniqueId = "45080816";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidatePastDueMap();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Endpoint Maintenance_Detailed Report_Total_Mius KPI Map Icon_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20889_Report_Endpoint_Maintenance_Detailed_Report_Total_Mius_KPI_Map_Icon_Display()
        {
            testCaseId = "TC-20889";
            qTestUniqueId = "45080817";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateTotalMIUsMap();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Endpoint Maintenance_Share Icon_PDF_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20890_Report_Endpoint_Maintenance_Share_Icon_PDF_Display()
        {
            testCaseId = "TC-20890";
            qTestUniqueId = "45099093";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointShareiconPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Endpoint Maintenance_Share Icon_Excel_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20891_Report_Endpoint_Maintenance_Share_Icon_Excel_Display()
        {
            testCaseId = "TC-20891";
            qTestUniqueId = "45099094";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointShareiconExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Report_Endpoint Maintenance_Share Icon_Excel_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20892_Report_Endpoint_Maintenance_Share_Icon_Excel_Display()
        {
            testCaseId = "TC-20892";
            qTestUniqueId = "45099095";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointShareiconExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Endpoint Maintenance_Active Endpoints_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20898_Report_Endpoint_Maintenance_Active_Endpoints_Display()
        {
            testCaseId = "TC-20898";
            qTestUniqueId = "45099357";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointShareiconExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Report_Invalid Report_Access
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21072_Report_Invalid_Report_Access()
        {
            testCaseId = "TC-21072";
            qTestUniqueId = "46046728";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Invalid Report_Share Icon_PDF_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21073_Report_Invalid_Report_Share_Icon_PDF_Display()
        {
            testCaseId = "TC-21073";
            qTestUniqueId = "46046729";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingShareiconPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Invalid Report_Share Icon_Excel_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21074_Report_Invalid_Report_Share_Icon_Excel_Display()
        {
            testCaseId = "TC-21074";
            qTestUniqueId = "46046730";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingShareiconExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Invalid Report_Detailed Report_Columns_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21075_Report_Invalid_Report_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-21075";
            qTestUniqueId = "46046731";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsColumnDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Invalid Report_Detailed Report_Detailed Report_Route Filter_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21076_Report_Invalid_Report_Detailed_Report_Route_Filter_Display()
        {
            testCaseId = "TC-21076";
            qTestUniqueId = "46046732";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingRouteFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Invalid Report_Detailed Report_Detailed Report_Group Filter_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21077_Report_Invalid_Report_Detailed_Report_Group_Filter_Display()
        {
            testCaseId = "TC-21077";
            qTestUniqueId = "46046733";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsGroupFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Invalid Report_Detailed Report_Detailed Report_Route Filter_Valuesy
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21080_Report_Invalid_Report_Detailed_Report_Route_Filter_Values()
        {
            testCaseId = "TC-21080";
            qTestUniqueId = "46046736";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsGroupFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Invalid Report_Detailed Report_Detailed Report_Group Filter_Valuesy
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21081_Report_Invalid_Report_Detailed_Report_Group_Filter_Values()
        {
            testCaseId = "TC-21081";
            qTestUniqueId = "46046737";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsGroupFilterValues();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Invalid Report_Detailed Report_Detailed Report_Group Filter_No Group Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21084_Report_Invalid_Report_Detailed_Report_Group_Filter_No_Group_Selected()
        {
            testCaseId = "TC-21084";
            qTestUniqueId = "46046803";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsGroupFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Invalid Report_Detailed Report_Detailed Report_Group Filter_One Group Select
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21085_Report_Invalid_Report_Detailed_Report_Group_Filter_One_Group_Select()
        {
            testCaseId = "TC-21085";
            qTestUniqueId = "46046804";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsOneGroupSelect();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Invalid Report_Detailed Report_Detailed Report_Group Filter_Group with Include_Select
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21086_Report_Invalid_Report_Detailed_Report_Group_Filter_Group_with_Include_Select()
        {
            testCaseId = "TC-21086";
            qTestUniqueId = "46046805";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsOneGroupSelect();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Invalid Report_Detailed Report_Detailed Report_Group Filter_Group with Exclude_Select
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21087_Report_Invalid_Report_Detailed_Report_Group_Filter_Group_with_Exclude_Select()
        {
            testCaseId = "TC-21087";
            qTestUniqueId = "46046806";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsExcludeGroup();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Invalid Report_Detailed Report_Detailed Report No Route Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21088_Report_Invalid_Report_Detailed_Report_No_Route_Selected()
        {
            testCaseId = "TC-21088";
            qTestUniqueId = "46046807";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReportTable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Invalid Report_Detailed Report_Route Filter_One Route Select
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21089_Report_Invalid_Report_Detailed_Report_Route_Filter_One_Route_Select()
        {
            testCaseId = "TC-21089";
            qTestUniqueId = "46046808";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsOneGroupSelect();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Neptune 360 - Reports - Endpoint Consumption
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22268_Reports_Endpoint_Consumption()
        {
            testCaseId = "TC-22268";
            qTestUniqueId = "48153938";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Neptune 360 - Reverse Flow Report - Account #
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23084_Reverse_Flow_Report_Account_No()
        {
            testCaseId = "TC-23084";
            qTestUniqueId = "49929742";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowAccNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Neptune 360 - Reverse Flow Report - Account Name
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23085_Reverse_Flow_Report_Account_Name()
        {
            testCaseId = "TC-23085";
            qTestUniqueId = "49929743";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowAccName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Neptune 360 - Reverse Flow Report - Account Address
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23086_Reverse_Flow_Report_Account_Address()
        {
            testCaseId = "TC-23086";
            qTestUniqueId = "49929744";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowAccAddress();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reverse Flow Report - Included MIUs - MIUs Can Be Represented Multiple Times
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23087_Reverse_Flow_Report_Included_MIUs_MIUs_Can_Be_Represented_Multiple_Times()
        {
            testCaseId = "TC-23087";
            qTestUniqueId = "49929745";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowMIU();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reverse Flow Report - AMR Logic
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23088_Reverse_Flow_Report_AMR_Logic()
        {
            testCaseId = "TC-23088";
            qTestUniqueId = "49929746";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowAMR();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Reverse Flow Report - Last Reading Date Time
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23089_Reverse_Flow_Report_Last_Reading_Date_Time()
        {
            testCaseId = "TC-23089";
            qTestUniqueId = "49929747";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateLastReadingDateTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reverse Flow Report - Default Begin Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23090_Reverse_Flow_Report_Default_Begin_Date()
        {
            testCaseId = "TC-23090";
            qTestUniqueId = "49929748";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseDefaultDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reverse Flow Report - Flag Start
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23091_Reverse_Flow_Report_Flag_Start()
        {
            testCaseId = "TC-23091";
            qTestUniqueId = "49929749";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlagStart();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reverse Flow Report - Reading
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23092_Reverse_Flow_Report_Reading()
        {
            testCaseId = "TC-23092";
            qTestUniqueId = "49929750";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseReading();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reverse Flow Report - Data Sort Last Read Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23093_Reverse_Flow_Report_Data_Sort_Last_Read_Date()
        {
            testCaseId = "TC-23093";
            qTestUniqueId = "49929751";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateLastReadingDateTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reverse Flow Report - Meter Size
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23095_Reverse_Flow_Report_Meter_Size()
        {
            testCaseId = "TC-23095";
            qTestUniqueId = "49929753";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseMeterSize();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reverse Flow Report - Default Report End Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23096_Reverse_Flow_Report_Default_Report_End_Date()
        {
            testCaseId = "TC-23096";
            qTestUniqueId = "49929754";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseDefaultEndDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reverse Flow Report - AMI Logic
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23097_Reverse_Flow_Report_AMI_Logic()
        {
            testCaseId = "TC-23097";
            qTestUniqueId = "49929755";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowAMR();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Reverse Flow Report - Route Filter
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23098_Reverse_Flow_Report_Route_Filter()
        {
            testCaseId = "TC-23098";
            qTestUniqueId = "49929756";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateAMINoRouteFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reverse Flow Report - Report Title
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23099_Reverse_Flow_Report_Report_Title()
        {
            testCaseId = "TC-23099";
            qTestUniqueId = "49929757";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowReportTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reverse Flow Report - MIU ID
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23100_Reverse_Flow_Report_MIU_ID()
        {
            testCaseId = "TC-23100";
            qTestUniqueId = "49929758";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowMIURow1();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reverse Flow Report -  Flag_Type
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23101_Reverse_Flow_Report_Flag_Type()
        {
            testCaseId = "TC-23101";
            qTestUniqueId = "49929759";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowFlagTypeRow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reverse Flow Report -  Cycle/Route
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23102_Reverse_Flow_Report_Cycle_Route()
        {
            testCaseId = "TC-23102";
            qTestUniqueId = "49929760";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowCycleRouteRow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reverse Flow Report -  Meter_No
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23103_Reverse_Flow_Report_Meter_No()
        {
            testCaseId = "TC-23103";
            qTestUniqueId = "49929761";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowMeterNoRow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Reverse Flow Report - Groups Filter
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23104_Reverse_Flow_Report_Groups_Filter()
        {
            testCaseId = "TC-23104";
            qTestUniqueId = "49929762";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowGroupFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Neptune 360 - Reverse Flow Report - Report Subtitle
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23105_Reverse_Flow_Report_Report_Subtitle()
        {
            testCaseId = "TC-23105";
            qTestUniqueId = "49929763";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowReportDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Neptune 360 - Reverse Flow Report - Adjust Begin Date and End Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23107_Reverse_Flow_Report_Adjust_Begin_Date_and_End_Date()
        {
            testCaseId = "TC-23107";
            qTestUniqueId = "49929763";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseAdjustStartDateEndDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Neptune 360 - Reverse Flow Report - Reverse Flow Filter
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23108_Reverse_Flow_Report_Reverse_Flow_Filter()
        {
            testCaseId = "TC-23108";
            qTestUniqueId = "49929766";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlagTypeFilterValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Neptune 360 - Reverse Flow Report - Reverse Flow Stop
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23109_Reverse_Flow_Report_Reverse_Flow_Stop()
        {
            testCaseId = "TC-23109";
            qTestUniqueId = "49929767";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlagStop();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reverse Flow Report - Date Picker - 24 Month Rolling Window Widget
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23110_Reverse_Flow_Report_Date_Picker_24_Month_Rolling_Window_Widget()
        {
            testCaseId = "TC-23110";
            qTestUniqueId = "49929768";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseDatePicker();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reverse Flow Report Included MIUs
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23111_Reverse_Flow_Report_Included_MIUs()
        {
            testCaseId = "TC-23111";
            qTestUniqueId = "49929769";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowMIURow1();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reverse Flow Report AMR/AMI
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23116_Reverse_Flow_Report_AMR_AMI()
        {
            testCaseId = "TC-23116";
            qTestUniqueId = "49946558";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowAMR();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report_Detailed Report_Account Name
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23289_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Account_Name()
        {
            testCaseId = "TC-23289";
            qTestUniqueId = "50252698";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsumAccName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report_Detailed Report_To Date_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23291_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_To_Date_Display()
        {
            testCaseId = "TC-23291";
            qTestUniqueId = "50252700";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsumToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report_Detailed Report_Avg Daily Flow (Event) 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23292_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Avg_Daily_Flow_Event()
        {
            testCaseId = "TC-23292";
            qTestUniqueId = "50252701";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowAvgDailyFlowEvent();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report_Date Range Selected_Updated Data Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23294_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Date_Range_Selected_Updated_Data_Display()
        {
            testCaseId = "TC-23294";
            qTestUniqueId = "50252703";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowDateRange();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report_UOM 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23295_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_UOM()
        {
            testCaseId = "TC-23295";
            qTestUniqueId = "50252704";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedUOM();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report_From Date_Display 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23296_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_From_Date_Display()
        {
            testCaseId = "TC-23296";
            qTestUniqueId = "50252705";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsumFromDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report_Group Filter_Values
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23297_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Group_Filter_Values()
        {
            testCaseId = "TC-23297";
            qTestUniqueId = "50252706";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsumGroupFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report_To Date_Editable
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23298_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_To_Date_Editable()
        {
            testCaseId = "TC-23298";
            qTestUniqueId = "50252707";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsumToDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report_Last Read Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23299_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Last_Read_Date()
        {
            testCaseId = "TC-23299";
            qTestUniqueId = "50252708";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsumLastReadDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report_Route Filter_Values
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23300_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Route_Filter_Values()
        {
            testCaseId = "TC-23300";
            qTestUniqueId = "50252709";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsumRouteFilterValues();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report_Columns_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23301_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Columns_Display()
        {
            testCaseId = "TC-23301";
            qTestUniqueId = "50252710";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsumColumnsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report_From Date_Editable
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23302_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_From_Date_Editable()
        {
            testCaseId = "TC-23302";
            qTestUniqueId = "50252711";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsumFromDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report_No Group Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23303_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_No_Group_Selected()
        {
            testCaseId = "TC-23303";
            qTestUniqueId = "50252712";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsumGroupFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report_Event Stop Read Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23304_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Event_Stop_Read_Date()
        {
            testCaseId = "TC-23304";
            qTestUniqueId = "50252713";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsumEventStopReadDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report_Route Filter_No Route Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23305_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Route_Filter_No_Route_Selected()
        {
            testCaseId = "TC-23305";
            qTestUniqueId = "50252714";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsumRouteFilterNoRoute();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report_To Date_Default Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23306_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_To_Date_Default_Date()
        {
            testCaseId = "TC-23306";
            qTestUniqueId = "50252715";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsumToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report_Event Start Read Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23307_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Event_Start_Read_Date()
        {
            testCaseId = "TC-23307";
            qTestUniqueId = "50252716";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedEventStartDateData();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report_Group Filter_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23308_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Group_Filter_Display()
        {
            testCaseId = "TC-23308";
            qTestUniqueId = "50252717";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsumGroupFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report From Date_Default Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23309_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_From_Date_Default_Date()
        {
            testCaseId = "TC-23309";
            qTestUniqueId = "50252718";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsumFromDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report Route Filter_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23310_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Route_Filter_Display()
        {
            testCaseId = "TC-23310";
            qTestUniqueId = "50252719";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsumRouteFilterNoRoute();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report Meter Size
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23311_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Meter_Size()
        {
            testCaseId = "TC-23311";
            qTestUniqueId = "50252720";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedMeterSizeData();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report From Date_Equal To Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23312_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_From_Date_Equal_To_Date()
        {
            testCaseId = "TC-23312";
            qTestUniqueId = "50252721";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report MIU ID
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23313_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_MIU_ID()
        {
            testCaseId = "TC-23313";
            qTestUniqueId = "50252722";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedMIUID();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report From Date_Future Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23314_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_From_Date_Future_Date()
        {
            testCaseId = "TC-23314";
            qTestUniqueId = "50252723";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedFromDateToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report Meter Number
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23315_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Meter_Number()
        {
            testCaseId = "TC-23315";
            qTestUniqueId = "50252724";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedMeterNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report Address
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23316_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Address()
        {
            testCaseId = "TC-23316";
            qTestUniqueId = "50252725";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedAddress();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report Cycle/Route
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23317_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Cycle_Route()
        {
            testCaseId = "TC-23317";
            qTestUniqueId = "50252818";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedCycle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report Sort Order_Event Stop Read Date column
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23318_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Sort_Order_Event_Stop_Read_Date_column()
        {
            testCaseId = "TC-23318";
            qTestUniqueId = "50252820";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedEventStopRead();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report Route Filter_One Route Select
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23319_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Route_Filter_One_Route_Select()
        {
            testCaseId = "TC-23319";
            qTestUniqueId = "50253625";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedSelectRoute();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report Group Filter_Group with Exclude_Select
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23320_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Group_Filter_Group_with_Exclude_Select()
        {
            testCaseId = "TC-23320";
            qTestUniqueId = "50253626";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedSelectGrpExclude();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report Group Filter_Group with Include_Select
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23321_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Group_Filter_Group_with_Include_Select()
        {
            testCaseId = "TC-23321";
            qTestUniqueId = "50253627";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedSelectGrpInclude();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report Group Filter_One Group Select
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23322_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Group_Filter_One_Group_Select()
        {
            testCaseId = "TC-23322";
            qTestUniqueId = "50253628";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedSelectOneGroup();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report Detailed Report Days Range
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23323_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Days_Range()
        {
            testCaseId = "TC-23323";
            qTestUniqueId = "50253659";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedLastReadDateData();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Export Button
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23376_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Export_Button()
        {
            testCaseId = "TC-23376";
            qTestUniqueId = "50388062";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedExport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Export PDF Button
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23379_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Export_PDF_Export()
        {
            testCaseId = "TC-23379";
            qTestUniqueId = "50389201";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedExportPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Export Excel Button
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23381_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Export_Excel_Export()
        {
            testCaseId = "TC-23381";
            qTestUniqueId = "50389328";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedExportExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page- Active SIM with No site - Table settings - 'Deselect ALL' checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23507_Reports_Page_Active_SIM_with_No_site_Table_settings_Deselect_ALL_checkbox()
        {
            testCaseId = "TC-23507";
            qTestUniqueId = "50625072";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateTableSettingDeSelectAll();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page- Active SIM with No site - Table settings -'X' checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23508_Reports_Page_Active_SIM_with_No_site_Table_settings_X_checkbox()
        {
            testCaseId = "TC-23508";
            qTestUniqueId = "50625075";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateTableSettingXCheckBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page- Active SIM with No site - Table settings -'OK' checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23509_Reports_Page_Active_SIM_with_No_site_Table_settings_OK_checkbox()
        {
            testCaseId = "TC-23509";
            qTestUniqueId = "50625076";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateTableSettingOKCheckBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        ///// Test Method to Reports Page- Active SIM with No site - Table settings -'Reset' checkbox
        ///// </summary>
        //[Category("Reports")]
        //[Test]
        //public void TC_23510_Reports_Page_Active_SIM_with_No_site_Table_settings_Reset_checkbox()
        //{
        //    testCaseId = "TC-23510";
        //    qTestUniqueId = "50625077";
        //    startDate = DateTime.Now; try
        //    {
        //        Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
        //        url = testData["URL"];
        //        userName = testData["UserName"];
        //        password = testData["Password"];
        //        home.NavigateToLftNavReports(url, userName, password);
        //        reportsPage.ValidateTableSettingResetCheckBox();
        //        home.UserLogOut();
        //        QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
        //    }
        //    catch (Exception)
        //    {
        //        QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
        //    }
        //}

        ///// Test Method to Reports Page- Active SIM with No site - Table settings -'Select ALL' checkbox
        ///// </summary>
        //[Category("Reports")]
        //[Test]
        //public void TC_23511_Reports_Page_Active_SIM_with_No_site_Table_settings_Select_ALL_checkbox()
        //{
        //    testCaseId = "TC-23511";
        //    qTestUniqueId = "50625078";
        //    startDate = DateTime.Now; try
        //    {
        //        Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
        //        url = testData["URL"];
        //        userName = testData["UserName"];
        //        password = testData["Password"];
        //        home.NavigateToLftNavReports(url, userName, password);
        //        reportsPage.ValidateTableSettingSelectAllCheckBox();
        //        home.UserLogOut();
        //        QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
        //    }
        //    catch (Exception)
        //    {
        //        QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
        //    }
        //}

        /// Test Method to Reports_Access to Report feature
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22559_Reports_Access_to_Report_feature()
        {
            testCaseId = "TC-22559";
            qTestUniqueId = "48466932";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReportsPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Access to Active SIM Undefined Site report.
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22561_Reports_Access_to_Active_SIM_Undefined_Site_report()
        {
            testCaseId = "TC-22561";
            qTestUniqueId = "48496370";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimUndefinedSiteAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Reports_Active SIM in Device Management container
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22562_Reports_Active_SIM_in_Device_Management_container()
        {
            testCaseId = "TC-22562";
            qTestUniqueId = "48496419";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimUndefinedSite();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Reports_Access to report feature
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22574_Reports_Access_to_report_feature()
        {
            testCaseId = "TC-22574";
            qTestUniqueId = "48524101";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReportsPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Access to report feature
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22575_Reports_Access_to_Active_SIM_with_No_Site_report()
        {
            testCaseId = "TC-22575";
            qTestUniqueId = "48524331";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSiteAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reports_Active SIM with no Site report in Device Management container
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22576_Reports_Active_SIM_with_no_Site_report_in_Device_Management_container()
        {
            testCaseId = "TC-22576";
            qTestUniqueId = "48524506";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSite();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Active SIM with no Site report
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22627_Reports_Active_SIM_with_no_Site_report()
        {
            testCaseId = "TC-22627";
            qTestUniqueId = "48581637";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSiteAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Active SIM with no Site report Header
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22628_Reports_Active_SIM_with_no_Site_report_Header()
        {
            testCaseId = "TC-22628";
            qTestUniqueId = "48599732";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSiteAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Active SIM with no Site report Report Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22629_Reports_Active_SIM_with_no_Site_report_Report_Date()
        {
            testCaseId = "TC-22629";
            qTestUniqueId = "48600023";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSiteReportDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Active SIM with no Site report Site ID Column
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22630_Reports_Active_SIM_with_no_Site_report_Site_ID_Column()
        {
            testCaseId = "TC-22630";
            qTestUniqueId = "48600320";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSiteMIUID();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Active SIM with no Site report MIU ID Column
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22631_Reports_Active_SIM_with_no_Site_report_MIU_ID_Column()
        {
            testCaseId = "TC-22631";
            qTestUniqueId = "48600321";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSiteMIUID();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Active SIM with no Site report ICCID Column
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22632_Reports_Active_SIM_with_no_Site_report_ICCID_Column()
        {
            testCaseId = "TC-22632";
            qTestUniqueId = "48600845";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSiteICCID();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Active SIM with no Site report ShippedUTC Column
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22633_Reports_Active_SIM_with_no_Site_report_ShippedUTC_Column()
        {
            testCaseId = "TC-22633";
            qTestUniqueId = "48600845";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSiteShippedUTC();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Active SIM with no Site report Activated Column
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22634_Reports_Active_SIM_with_no_Site_report_Activated_Column()
        {
            testCaseId = "TC-22634";
            qTestUniqueId = "48600849";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSiteActivatedUTC();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Active SIM with no Site report Last Heard Column
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22635_Reports_Active_SIM_with_no_Site_report_Last_Heard_Column()
        {
            testCaseId = "TC-22635";
            qTestUniqueId = "48600852";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSiteLastHeardUTC();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Active SIM with no Site report 1st Imported Column
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22636_Reports_Active_SIM_with_no_Site_report_1st_Imported_Column()
        {
            testCaseId = "TC-22636";
            qTestUniqueId = "48600855";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSite1siImportedUTC();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Active SIM with no Site report SIM State Column
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22637_Reports_Active_SIM_with_no_Site_report_SIM_State_Column()
        {
            testCaseId = "TC-22637";
            qTestUniqueId = "48600858";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSiteSimStateUTC();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Active SIM with no Site report Share Option
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22638_Reports_Active_SIM_with_no_Site_report_Share_Option()
        {
            testCaseId = "TC-22638";
            qTestUniqueId = "48600974";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSiteShareOption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Active SIM with no Site report Back button
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22674_Reports_Active_SIM_with_no_Site_report_Back_button()
        {
            testCaseId = "TC-22674";
            qTestUniqueId = "48653133";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSiteBackButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Active SIM with no Site report Share/Export
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22674_Reports_Active_SIM_with_no_Site_report_Share_Export()
        {
            testCaseId = "TC-22674";
            qTestUniqueId = "48653210";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSiteShareExport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Active SIM with no Site report Sort Order 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22682_Reports_Active_SIM_with_no_Site_report_Sort_Order()
        {
            testCaseId = "TC-22682";
            qTestUniqueId = "48656770";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimNoSiteSortOder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Endpoints Container_Days of Consecutive Flow (AMI)- Consumption Based_Access
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23180_Reports_Endpoints_Container_Days_of_Consecutive_Flow_AMI_Consumption_Based_Access()
        {
            testCaseId = "TC-23180";
            qTestUniqueId = "50068074";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Endpoints Container_Days of Consecutive Flow (AMI)- Consumption Based_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23181_Reports_Endpoints_Container_Days_of_Consecutive_Flow_AMI_Consumption_Based_Display()
        {
            testCaseId = "TC-23181";
            qTestUniqueId = "50068075";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Endpoints Container_Days of Consecutive Flow (AMI)- Consumption Based_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23182_Reports_Endpoints_Container_Days_of_Consecutive_Flow_AMI_Consumption_Based_Display()
        {
            testCaseId = "TC-23182";
            qTestUniqueId = "50068075";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Endpoints Container_Days of Consecutive Flow (AMI)- Consumption Based_Report_Shared Icon Export Excel_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23219_Reports_Endpoints_Container_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Shared_Icon_Export_Excel_Display()
        {
            testCaseId = "TC-23219";
            qTestUniqueId = "50109483";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedExportExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Endpoints Container_Days of Consecutive Flow (AMI)- Consumption Based_Report_Shared Icon Export PDF_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23220_Reports_Endpoints_Container_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Shared_Icon_Export_PDF_Display()
        {
            testCaseId = "TC-23220";
            qTestUniqueId = "50109484";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedExportPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Endpoints Container_Days of Consecutive Flow (AMI)- Consumption Based_Report Date format
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23221_Reports_Endpoints_Container_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Date_format()
        {
            testCaseId = "TC-23221";
            qTestUniqueId = "50109485";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedReportDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports_Endpoints Container_Days of Consecutive Flow (AMI)- Consumption Based_Report Share Icon
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23224_Reports_Endpoints_Container_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Share_Icon()
        {
            testCaseId = "TC-23224";
            qTestUniqueId = "50110962";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedExport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Reverse Flow - Table settings - 'Select ALL' checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23580_Reports_Page_Reverse_Flow_Table_settings_Select_ALL_checkbox()
        {
            testCaseId = "TC-23580";
            qTestUniqueId = "50642334";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowSelectAllCheckBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Reverse Flow - Table settings - MIU ID checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23581_Reports_Page_Reverse_Flow_Table_settings_MIU_ID_checkbox()
        {
            testCaseId = "TC-23581";
            qTestUniqueId = "50642335";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowMIUIDCheckBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reports Page - Reverse Flow - Table settings - Reset checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23582_Reports_Page_Reverse_Flow_Table_settings_Reset_checkbox()
        {
            testCaseId = "TC-23582";
            qTestUniqueId = "50642336";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowResetCheckBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Reverse Flow - Table settings - OK checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23583_Reports_Page_Reverse_Flow_Table_settings_OK_checkbox()
        {
            testCaseId = "TC-23583";
            qTestUniqueId = "50642337";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowOKCheckBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Reverse Flow - Table settings - X checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23584_Reports_Page_Reverse_Flow_Table_settings_X_checkbox()
        {
            testCaseId = "TC-23584";
            qTestUniqueId = "50642338";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowX();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Reverse Flow - Table settings - Deselect ALL checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23585_Reports_Page_Reverse_Flow_Table_settings_Deselect_ALL_checkbox()
        {
            testCaseId = "TC-23585";
            qTestUniqueId = "50642339";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowDeselectAllCheckBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page -  Endpoint Consumption - Table settings - MIU ID checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23586_Reports_Page_Endpoint_Consumption_Table_settings_MIU_ID_checkbox()
        {
            testCaseId = "TC-23586";
            qTestUniqueId = "50643330";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionMIUIdCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page -  Endpoint Consumption - Table settings - Select ALL checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23587_Reports_Page_Endpoint_Consumption_Table_settings_Select_ALL_checkbox()
        {
            testCaseId = "TC-23587";
            qTestUniqueId = "50643331";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionSelectAllCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page -  Endpoint Consumption - Table settings - Select ALL checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23588_Reports_Page_Endpoint_Consumption_Table_settings_Reset_checkbox()
        {
            testCaseId = "TC-23588";
            qTestUniqueId = "50643331";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionResetCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page -  Endpoint Consumption - Table settings - OK checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23589_Reports_Page_Endpoint_Consumption_Table_settings_OK_checkbox()
        {
            testCaseId = "TC-23589";
            qTestUniqueId = "50643333";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionOKCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page -  Endpoint Consumption - Table settings - OK checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23590_Reports_Page_Endpoint_Consumption_Table_settings_OK_checkbox()
        {
            testCaseId = "TC-23590";
            qTestUniqueId = "50643334";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionX();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page -  Endpoint Consumption - Table settings - Deselect ALL checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23591_Reports_Page_Endpoint_Consumption_Table_settings_Deselect_ALL_checkbox()
        {
            testCaseId = "TC-23591";
            qTestUniqueId = "50643335";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionDeselectAll();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Endpoint Consumption - Table settings - Reading checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23604_Reports_Page_Endpoint_Consumption_Table_settings_Reading_checkbox()
        {
            testCaseId = "TC-23604";
            qTestUniqueId = "50652373";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionReverseReadingCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Endpoint Consumption - Table settings - Address checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23605_Reports_Page_Endpoint_Consumption_Table_settings_Address_checkbox()
        {
            testCaseId = "TC-23605";
            qTestUniqueId = "50652374";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionAddressCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Endpoint Consumption - Table settings - Account Name checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23606_Reports_Page_Endpoint_Consumption_Table_settings_Account_Name_checkbox()
        {
            testCaseId = "TC-23606";
            qTestUniqueId = "50652375";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionAccNameCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Endpoint Consumption - Table settings - Meter_Size checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23607_Reports_Page_Endpoint_Consumption_Table_settings_Meter_Size_checkbox()
        {
            testCaseId = "TC-23607";
            qTestUniqueId = "50652376";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionMeterSizeCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Endpoint Consumption - Table settings - Meter_Number checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23608_Reports_Page_Endpoint_Consumption_Table_settings_Meter_Number_checkbox()
        {
            testCaseId = "TC-23608";
            qTestUniqueId = "50652377";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionMeterNoCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Endpoint Consumption - Table settings - Acc_Number checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23609_Reports_Page_Endpoint_Consumption_Table_settings_Acc_Number_checkbox()
        {
            testCaseId = "TC-23609";
            qTestUniqueId = "50652378";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionAccNoCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Endpoint Consumption - Table settings - Consumption checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23610_Reports_Page_Endpoint_Consumption_Table_settings_Consumption_checkbox()
        {
            testCaseId = "TC-23610";
            qTestUniqueId = "50652379";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionConsCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Endpoint Consumption - Table settings - Date checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23611_Reports_Page_Endpoint_Consumption_Table_settings_Date_checkbox()
        {
            testCaseId = "TC-23611";
            qTestUniqueId = "50652542";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionDateCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Endpoint Consumption - Table settings - UOM checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23612_Reports_Page_Endpoint_Consumption_Table_settings_UOM_checkbox()
        {
            testCaseId = "TC-23612";
            qTestUniqueId = "50652543";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionUOMCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Reverse Flow - Table settings - Cycle/Route checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23592_Reports_Page_Reverse_Flow_Table_settings_Cycle_Route_checkbox()
        {
            testCaseId = "TC-23592";
            qTestUniqueId = "50652543";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowCycleRouteCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Reverse Flow - Table settings - Account Number checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23593_Reports_Page_Reverse_Flow_Table_settings_Account_Number_checkbox()
        {
            testCaseId = "TC-23593";
            qTestUniqueId = "50643574";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowAccNoCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Reverse Flow - Table settings - Meter Number checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23594_Reports_Page_Reverse_Flow_Table_settings_Meter_Number_checkbox()
        {
            testCaseId = "TC-23594";
            qTestUniqueId = "50643575";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowMeterNoCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Reverse Flow - Table settings - Meter Size checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23595_Reports_Page_Reverse_Flow_Table_settings_Meter_Size_checkbox()
        {
            testCaseId = "TC-23595";
            qTestUniqueId = "50643629";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowMeterSizeCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Reverse Flow - Table settings - Account Name checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23596_Reports_Page_Reverse_Flow_Table_settings_Account_Name_checkbox()
        {
            testCaseId = "TC-23596";
            qTestUniqueId = "50643630";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowAccNameCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Reverse Flow - Table settings - Address checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23597_Reports_Page_Reverse_Flow_Table_settings_Address_checkbox()
        {
            testCaseId = "TC-23597";
            qTestUniqueId = "50643631";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowAddressCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Reverse Flow - Table settings - AMR/AMI checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23598_Reports_Page_Reverse_Flow_Table_settings_AMR_AMI_checkbox()
        {
            testCaseId = "TC-23598";
            qTestUniqueId = "50643632";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowAMRAMICheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reports Page - Reverse Flow - Table settings - Flag Start checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23599_Reports_Page_Reverse_Flow_Table_settings_Flag_Start_checkbox()
        {
            testCaseId = "TC-23599";
            qTestUniqueId = "50643673";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowFlagStartCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Reports Page - Reverse Flow - Table settings - Flag Stop checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23600_Reports_Page_Reverse_Flow_Table_settings_Flag_Stop_checkbox()
        {
            testCaseId = "TC-23600";
            qTestUniqueId = "50643674";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowFlagStopCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Reverse Flow - Table settings - Flag Type checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23601_Reports_Page_Reverse_Flow_Table_settings_Flag_Type_checkbox()
        {
            testCaseId = "TC-23601";
            qTestUniqueId = "50643675";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowFlagTypeCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports Page - Reverse Flow - Table settings - Reading checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23602_Reports_Page_Reverse_Flow_Table_settings_Reading_checkbox()
        {
            testCaseId = "TC-23602";
            qTestUniqueId = "50643676";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowReadingCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Reports Page - Reverse Flow - Table settings - Last Reading Date/Time checkbox
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23603_Reports_Page_Reverse_Flow_Table_settings_Last_Reading_Date_Time_checkbox()
        {
            testCaseId = "TC-23603";
            qTestUniqueId = "50643677";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowReadingDateTimeCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reporting - Changed read parameters under Field Feedback container.
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23849_Reporting_Changed_read_parameters_under_Field_Feedback_container()
        {
            testCaseId = "TC-23849";
            qTestUniqueId = "50811614";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateChangedReadParameters();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reports_Endpoints_Days of Consumption (AMR)_Report Name_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15641_Reports_Endpoints_Days_of_Consumption_AMR_Report_Name_Display()
        {
            testCaseId = "TC-15641";
            qTestUniqueId = "50811614";
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

        /// Test Method to Reports_Endpoints Container_Taller Than_Field FeedBack Container
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_15642_Reports_Endpoints_Container_Taller_Than_Field_FeedBack_Container()
        {
            testCaseId = "TC-15642";
            qTestUniqueId = "50811614";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointContainer();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reports - Changed Read Parameters - Default date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23871_Reports_Changed_Read_Parameters_Default_date()
        {
            testCaseId = "TC-23871";
            qTestUniqueId = "50811614";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateChangedReadParametersDefaultDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// Test Method to Reports - Changed Read Parameters - Subtitle
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23872_Reports_Changed_Read_Parameters_Subtitle()
        {
            testCaseId = "TC-23872";
            qTestUniqueId = "50811614";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateChangedReadParametersSubtitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports - Changed Read Parameters - No Route selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23898_Reports_Changed_Read_Parameters_No_Route_selected()
        {
            testCaseId = "TC-23898";
            qTestUniqueId = "50933973";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateChangedReadParametersNoRouteSelected();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Reports - Changed Read Parameters - No group selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23900_Reports_Changed_Read_Parameters_No_group_selected()
        {
            testCaseId = "TC-23900";
            qTestUniqueId = "50934392";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateChangedReadParametersNoGroupSelected();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports - Changed Read Parameters - No Route selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23896_Reports_Changed_Read_Parameters_No_Route_selected()
        {
            testCaseId = "TC-23896";
            qTestUniqueId = "50933737";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateChangedReadParametersNoRouteSelected();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports - Changed Read Parameters - Include option
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23901_Reports_Changed_Read_Parameters_Include_option()
        {
            testCaseId = "TC-23901";
            qTestUniqueId = "50934424";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateChangedReadParametersIncludeOption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports - Changed Read Parameters - Exclude option
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23903_Reports_Changed_Read_Parameters_Exclude_option()
        {
            testCaseId = "TC-23903";
            qTestUniqueId = "50934549";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateChangedReadParametersExcludeOption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Reports - Changed Read Parameters - Specific field chosen
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23904_Reports_Changed_Read_Parameters_Specific_field_chosen()
        {
            testCaseId = "TC-23904";
            qTestUniqueId = "50935598";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateChangedReadParametersSpecificField();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report - Endpoint Maintenance - Detailed Report - Active Endpoints - Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20898_Report_Endpoint_Maintenance_Detailed_Report_Active_Endpoints_Display()
        {
            testCaseId = "TC-20898";
            qTestUniqueId = "45099357";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateChangedReadParametersSpecificField();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Endpoint Maintenance_Detailed Report_Never Received KPI_Map Icon_Click
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20899_Report_Endpoint_Maintenance_Detailed_Report_Never_Received_KPI_Map_Icon_Click()
        {
            testCaseId = "TC-20899";
            qTestUniqueId = "45116593";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointMaintenanceMapIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Endpoint Maintenance_Detailed Report_Invalid Reads KPI_Map Icon_Click
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20900_Report_Endpoint_Maintenance_Detailed_Report_Invalid_Reads_KPI_Map_Icon_Click()
        {
            testCaseId = "TC-20900";
            qTestUniqueId = "45116594";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointMaintenanceInvalidReadsMapIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// Test Method to Report_Endpoint Maintenance_Detailed Report_Past Due KPI_Map Icon_Click
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20901_Report_Endpoint_Maintenance_Detailed_Report_Past_Due_KPI_Map_Icon_Click()
        {
            testCaseId = "TC-20901";
            qTestUniqueId = "45116595";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointMaintenancePastDueMapIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Endpoint Maintenance_Detailed Report_Total_MIUs KPi_Map Icon_Click
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20902_Report_Endpoint_Maintenance_Detailed_Report_Total_MIUs_KPI_Map_Icon_Click()
        {
            testCaseId = "TC-20902";
            qTestUniqueId = "45116596";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointMaintenanceTotalMIUMapIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// Test Method to Report_Endpoint Maintenance_Detailed Report_Total MIUs KPI_Overall Count
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20903_Report_Endpoint_Maintenance_Detailed_Report_Total_MIUs_KPI_Overall_Count()
        {
            testCaseId = "TC-20903";
            qTestUniqueId = "45116699";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateTotalMiuKPI();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_Endpoint Maintenance_Detailed Report_Data Grid columns_Sorting
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20904_Report_Endpoint_Maintenance_Detailed_Report_Data_Grid_columns_Sorting()
        {
            testCaseId = "TC-20904";
            qTestUniqueId = "45116729";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsUpdatePastDue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_AMI Endpoint Maintenance_Detailed Report_Data Grid Filter
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20906_Report_AMI_Endpoint_Maintenance_Detailed_Report_Data_Grid_Filter()
        {
            testCaseId = "TC-20906";
            qTestUniqueId = "45117106";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingsUpdatePastDue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports_Endpoints Container_Days of Consecutive Flow (AMI) - Flag Based_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20953_Reports_Endpoints_Container_Days_of_Consecutive_Flow_AMI_Flag_Based_Display()
        {
            testCaseId = "TC-20953";
            qTestUniqueId = "45815378";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagBased();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports_Endpoints Container_Days of Consecutive Flow (AMI) - Flag Based_Access
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20954_Reports_Endpoints_Container_Days_of_Consecutive_Flow_AMI_Flag_Based_Access()
        {
            testCaseId = "TC-20954";
            qTestUniqueId = "45815379";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagBasedAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports_Endpoints Container_Days of Consecutive Flow (AMI)- Flag Based_Flow Types Included_Dropdown Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20955_Reports_Endpoints_Container_Days_of_Consecutive_Flow_AMI_Flag_Based_Flow_Types_Included_Dropdown_Display()
        {
            testCaseId = "TC-20955";
            qTestUniqueId = "45815380";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumpAMIFlagFlowTypes();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports_Endpoints Container_Days of Consecutive Flow (AMI)- Flag Based_Flow Types Included_Dropdown Values
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20956_Reports_Endpoints_Container_Days_of_Consecutive_Flow_AMI_Flag_Based_Flow_Types_Included_Dropdown_Values()
        {
            testCaseId = "TC-20956";
            qTestUniqueId = "45815381";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumpAMIFlagFlowTypesDropdown();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports_Endpoints Container_Days of Consecutive Flow (AMI)- Flag Based_Flow Types Included_Dropdown Default Value
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20957_Reports_Endpoints_Container_Days_of_Consecutive_Flow_AMI_Flag_Based_Flow_Types_Included_Dropdown_Default_Value()
        {
            testCaseId = "TC-20957";
            qTestUniqueId = "45815382";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumpAMIFlagFlowTypesDefault();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)- Flag Based_Share Icon_PDF_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20973_Report_Days_of_Consecutive_Flow_AMI_Flag_Based_Share_Icon_PDF_Display()
        {
            testCaseId = "TC-20973";
            qTestUniqueId = "45866212";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumpAMIFlagShareIconPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)- Flag Based_Share Icon_Excel_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20974_Report_Days_of_Consecutive_Flow_AMI_Flag_Based_Share_Icon_Excel_Display()
        {
            testCaseId = "TC-20974";
            qTestUniqueId = "45866213";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumpAMIFlagShareIconExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Reports_Endpoints Container_Days of Consecutive Flow (AMI)- Flag Based_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20997_Reports_Endpoints_Container_Days_of_Consecutive_Flow_AMI_Flag_Based_Display()
        {
            testCaseId = "TC-20997";
            qTestUniqueId = "45928112";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagBased();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports_Endpoints Container_Days of Consecutive Flow (AMI)- Flag Based_Access
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_20998_Reports_Endpoints_Container_Days_of_Consecutive_Flow_AMI_Flag_Based_Access()
        {
            testCaseId = "TC-20998";
            qTestUniqueId = "45928113";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagBasedAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_From Date_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21003_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_From_Date_Display()
        {
            testCaseId = "TC-21003";
            qTestUniqueId = "45928204";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagFromDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_To Date_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21004_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_To_Date_Display()
        {
            testCaseId = "TC-21004";
            qTestUniqueId = "45928205";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagToDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_From Date_Default Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21005_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_From_Date_Default_Date()
        {
            testCaseId = "TC-21005";
            qTestUniqueId = "45928206";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagFromDateDefault();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_To Date_Default Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21006_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_To_Date_Default_Date()
        {
            testCaseId = "TC-21006";
            qTestUniqueId = "45928207";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagToDateDefault();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_From Date_Editable
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21007_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_From_Date_Editable()
        {
            testCaseId = "TC-21007";
            qTestUniqueId = "45928208";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagFromDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_To Date_Editable
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21008_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_To_Date_Editable()
        {
            testCaseId = "TC-21008";
            qTestUniqueId = "45928209";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagToDateEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Route Filter_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21013_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Route_Filter_Display()
        {
            testCaseId = "TC-21013";
            qTestUniqueId = "45928214";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagRouteFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Group Filter_Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21014_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Group_Filter_Display()
        {
            testCaseId = "TC-21014";
            qTestUniqueId = "45928215";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagGroupFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Route Filter_No Route Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21015_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Route_Filter_No_Route_Selected()
        {
            testCaseId = "TC-21015";
            qTestUniqueId = "45928216";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagRouteFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Route Filter_No Group Selected
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21016_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Route_Filter_No_Group_Selected()
        {
            testCaseId = "TC-21016";
            qTestUniqueId = "45928217";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagGroupFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Route Filter_Values
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21017_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Route_Filter_Values()
        {
            testCaseId = "TC-21017";
            qTestUniqueId = "45928218";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagRouteFilterValues();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Group Filter_Values
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21018_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Group_Filter_Values()
        {
            testCaseId = "TC-21018";
            qTestUniqueId = "45928219";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagGroupFilterValues();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Flow types selector_Default Both
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21019_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Flow_types_selector_Default_Both()
        {
            testCaseId = "TC-21019";
            qTestUniqueId = "45932677";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagFlowtypes();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Flow types_Intermittent
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21020_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Flow_types_Intermittent()
        {
            testCaseId = "TC-21020";
            qTestUniqueId = "45933000";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagFlowtypeIntermittent();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_Days of Consecutive Flow (AMI)_Detailed Report_Flow types_Continuous
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_21021_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Flow_types_Continuous()
        {
            testCaseId = "TC-21021";
            qTestUniqueId = "45934222";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionAMIFlagFlowtypeContinuous();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Active SIM Associated to Undefined Site Report.
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22592_Reports_Active_SIM_Associated_to_Undefined_Site_Report()
        {
            testCaseId = "TC-22592";
            qTestUniqueId = "48560387";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimAssociated();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Active SIM Associated to Undefined Site Report Header
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22596_Reports_Active_SIM_Associated_to_Undefined_Site_Report_Header()
        {
            testCaseId = "TC-22596";
            qTestUniqueId = "48569516";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimAssociated();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Reports - Active SIM Associated to Undefined Site Report date format
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22597_Reports_Active_SIM_Associated_to_Undefined_Site_Report_date_format()
        {
            testCaseId = "TC-22597";
            qTestUniqueId = "48569848";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimAssociatedDateFormat();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Active SIM Associated to Undefined Site Report Site ID Column 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22598_Reports_Active_SIM_Associated_to_Undefined_Site_Report_Site_ID_Column()
        {
            testCaseId = "TC-22598";
            qTestUniqueId = "48569898";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimAssociatedSiteID();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Active SIM Associated to Undefined Site Report - MIU ID Column  
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22599_Reports_Active_SIM_Associated_to_Undefined_Site_Report_MIU_ID_Column()
        {
            testCaseId = "TC-22599";
            qTestUniqueId = "48570029";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimAssociatedMIUID();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Active SIM Associated to Undefined Site Report - ICCID ID Column  
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22600_Reports_Active_SIM_Associated_to_Undefined_Site_Report_ICCID_ID_Column()
        {
            testCaseId = "TC-22600";
            qTestUniqueId = "48570038";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimAssociatedICCID();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Reports - Active SIM Associated to Undefined Site Report - Shipped (UTC) ID Column  
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22601_Reports_Active_SIM_Associated_to_Undefined_Site_Report_Shipped_UTC_Column()
        {
            testCaseId = "TC-22601";
            qTestUniqueId = "48570047";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateActiveSimShippedUTC();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report -MIU Selection Parameter - MIU is Found and Unique 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22752_Neptune_360_Endpoint_Consumption_Report_MIU_Selection_Parameter_MIU_is_Found_and_Unique()
        {
            testCaseId = "TC-22752";
            qTestUniqueId = "48747153";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionMIUSelection(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report -MIU Selection Parameter - MIU is Found and Not Unique 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22753_Neptune_360_Endpoint_Consumption_Report_MIU_Selection_Parameter_MIU_is_Found_and_Not_Unique()
        {
            testCaseId = "TC-22753";
            qTestUniqueId = "48747154";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionMIUSelected(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report -MIU Selection Parameter - MIU is Not Found 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22754_Neptune_360_Endpoint_Consumption_Report_MIU_Selection_Parameter_MIU_is_Not_Found()
        {
            testCaseId = "TC-22754";
            qTestUniqueId = "48747155";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionMIUNotFound(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report - Back Button
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22812_Neptune_360_Endpoint_Consumption_Report_Back_Button()
        {
            testCaseId = "TC-22812";
            qTestUniqueId = "48792126";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionBackButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report - Columns
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22813_Neptune_360_Endpoint_Consumption_Report_Columns()
        {
            testCaseId = "TC-22813";
            qTestUniqueId = "48792127";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionColumns(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report - Endpoint Consumption By MIU Hourly Interval - MIU Found and Unique - Analytical Breakdown
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22814_Neptune_360_Endpoint_Consumption_Report_Endpoint_Consumption_By_MIU_Hourly_Interval_MIU_Found_and_Unique_Analytical_Breakdown()
        {
            testCaseId = "TC-22814";
            qTestUniqueId = "48792128";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionColumns(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report - Endpoint Consumption By MIU Hourly Interval - MIU Found and Not Unique
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22815_Neptune_360_Endpoint_Consumption_Report_Endpoint_Consumption_By_MIU_Hourly_Interval_MIU_Found_and_Not_Unique()
        {
            testCaseId = "TC-22815";
            qTestUniqueId = "48792129";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionColumns(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report - MIU Daily Interval - MIU Found and Unique
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22817_Neptune_360_Endpoint_Consumption_Report_MIU_Daily_Interval_MIU_Found_and_Unique()
        {
            testCaseId = "TC-22817";
            qTestUniqueId = "48792131";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionColumns(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report - MIU Daily Interval -MIU Not Found
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22818_Neptune_360_Endpoint_Consumption_Report_MIU_Daily_Interval_MIU_Not_Found()
        {
            testCaseId = "TC-22818";
            qTestUniqueId = "48792132";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionMIUNotFound("1242552352");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report - MIU Daily Interval - MIU Found and Not Unique
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22819_Neptune_360_Endpoint_Consumption_Report_MIU_Daily_Interval_MIU_Found_and_Not_Unique()
        {
            testCaseId = "TC-22819";
            qTestUniqueId = "48792133";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionColumns(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report - Endpoint Consumption By MIU Hourly Interval - MIU Not Found
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22820_Neptune_360_Endpoint_Consumption_Report_Endpoint_Consumption_By_MIU_Hourly_Interval_MIU_Not_Found()
        {
            testCaseId = "TC-22820";
            qTestUniqueId = "48792134";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionMIUNotFound("1242552352");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report - Title
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22821_Neptune_360_Endpoint_Consumption_Report_Title()
        {
            testCaseId = "TC-22821";
            qTestUniqueId = "48792135";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report - Endpoint Consumption By MIU Hourly Interval - MIU Found and Unique
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22822_Neptune_360_Endpoint_Consumption_Report_Endpoint_Consumption_By_MIU_Hourly_Interval_MIU_Found_and_Unique()
        {
            testCaseId = "TC-22822";
            qTestUniqueId = "48792136";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Reverse Flow Report - Name
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22870_Reports_Reverse_Flow_Report_Name()
        {
            testCaseId = "TC-22870";
            qTestUniqueId = "48899377";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowReportTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Reverse Flow Reverse Flow Widget
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22909_Reports_Reverse_Flow_Reverse_Flow_Widget()
        {
            testCaseId = "TC-22909";
            qTestUniqueId = "49623578";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowFlagsIncluded();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Endpoint Consumption - Columns - Consumption - Decimal Positions
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_22921_Reports_Endpoint_Consumption_Columns_Consumption_Decimal_Positions()
        {
            testCaseId = "TC-22921";
            qTestUniqueId = "49645747";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateReverseFlowFlagsIncluded();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report_Days of  Consecutive Flow (AMI) - Consumption Based Report_Detailed Report_Avg Daily Flow (Prior)
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23288_Report_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Detailed_Report_Avg_Daily_Flow_Prior()
        {
            testCaseId = "TC-23288";
            qTestUniqueId = "50252697";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowConsBasedAvgFlowPrior();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report - MIU Vs Group Parameter Picker
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23641_Neptune_360_Endpoint_Consumption_Report_MIU_Vs_Group_Parameter_Picker()
        {
            testCaseId = "TC-23641";
            qTestUniqueId = "50683458";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionCheckbox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// </summary>
        /// Test Method to Reports - Changed Read Parameters - Title - Report Name
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23867_Reports_Changed_Read_Parameters_Title_Report_Name()
        {
            testCaseId = "TC-23867";
            qTestUniqueId = "50885391";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateChangedReadParametersSubtitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Changed Read Parameters - Subtitle - Report Date
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_23868_Reports_Changed_Read_Parameters_Subtitle_Report_Date()
        {
            testCaseId = "TC-23868";
            qTestUniqueId = "50885393";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateChangedReadParametersReportDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report - Back Button
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24065_Neptune_360_Endpoint_Consumption_Report_Back_Button()
        {
            testCaseId = "TC-24065";
            qTestUniqueId = "51373944";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumBackButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24066_Neptune_360_Endpoint_Consumption()
        {
            testCaseId = "TC-24066";
            qTestUniqueId = "51373945";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report - By Group Daily Interval
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24067_Neptune_360_Endpoint_Consumption_By_Group_Daily_Interval()
        {
            testCaseId = "TC-24067";
            qTestUniqueId = "51373946";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionDailyGroupInterval();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Endpoint Consumption Report - By Group Hourly Interval
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24068_Neptune_360_Endpoint_Consumption_By_Group_Hourly_Interval()
        {
            testCaseId = "TC-24068";
            qTestUniqueId = "51373947";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointConsumptionHourlyGroupInterval();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Report - Days of Consecutive Flow (AMI) - Detailed Report - Flag Based - Avg Daily Flow (Event) - Calculation 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24069_Report_Days_of_Consecutive_Flow_AMI_Detailed_Report_Flag_Based_Avg_Daily_Flow_Event_Calculation()
        {
            testCaseId = "TC-24069";
            qTestUniqueId = "51384683";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsFlowAvgDailyFlow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - High Low Limits Fail - Report Presence
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24071_Reports_High_Low_Limits_Fail_Report_Presence()
        {
            testCaseId = "TC-24071";
            qTestUniqueId = "51387245";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighLowLimitFall();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - High Low Limits Fail - Column - sorting order
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24074_Reports_High_Low_Limits_Fail_Column_sorting_order()
        {
            testCaseId = "TC-24074";
            qTestUniqueId = "51387596";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighLowLimitFallColumnOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - High Low Limits Fail - Back button
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24077_Reports_High_Low_Limits_Fail_Back_button()
        {
            testCaseId = "TC-24077";
            qTestUniqueId = "51387722";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighLowLimitFallBacktoReports();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - High Low Limits Fail - PDF/Excel button 
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24078_Reports_High_Low_Limits_Fail_PDF_Excel_button()
        {
            testCaseId = "TC-24078";
            qTestUniqueId = "51387994";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighLowLimitFallExportButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Table Settings - Modify Column Visibility - Changes Are Specific To Current User
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24518_Neptune_360_Productivity_Report_Table_Settings_Modify_Column_Visibility_Changes_Are_Specific_To_Current_User()
        {
            testCaseId = "TC-24518";
            qTestUniqueId = "52825625";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportColumns();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Table Settings - Modify Column Visibility -  Error Message
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24519_Neptune_360_Productivity_Report_Table_Settings_Modify_Column_Visibility_Changes_Are_Specific_Error_Message()
        {
            testCaseId = "TC-24519";
            qTestUniqueId = "52825626";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportModidyColumnError();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Table Settings - Modify Column Visibility
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24521_Neptune_360_Productivity_Report_Table_Settings_Modify_Column_Visibility()
        {
            testCaseId = "TC-24521";
            qTestUniqueId = "52825628";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportColumns();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Table Settings Button Displayed and Columns Visible By Default
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24522_Neptune_360_Productivity_Report_Table_Settings_Button_Displayed_and_Columns_Visible_By_Default()
        {
            testCaseId = "TC-24522";
            qTestUniqueId = "52825629";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportColumns();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Table Settings - Modify Column Visibility - Reset Button
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24523_Neptune_360_Productivity_Report_Table_Settings_Modify_Column_Visibility_Reset_Button()
        {
            testCaseId = "TC-24523";
            qTestUniqueId = "52825630";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportResetButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Table Settings - Modify Column Visibility - Select All and Deselect All Button
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24525_Neptune_360_Productivity_Report_Table_Settings_Modify_Column_Visibility_Select_All_and_Deselect_All_Button()
        {
            testCaseId = "TC-24525";
            qTestUniqueId = "52825632";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivitySelectAllDeselectAllButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - AMI (Meter Reader) Row
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24529_Neptune_360_Productivity_Report_AMI_Meter_Reader_Row()
        {
            testCaseId = "TC-24529";
            qTestUniqueId = "52839566";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityAMIRow();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Reports - Tamper Report - Endpoints Container - Tamper - Access
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24642_Reports_Tamper_Report_Endpoints_Container_Tamper_Access()
        {
            testCaseId = "TC-24642";
            qTestUniqueId = "52877845";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateTamperReportsAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Tamper - Verify the Look and Feel
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24643_Reports_Tamper_Verify_the_Look_and_Feel()
        {
            testCaseId = "TC-24643";
            qTestUniqueId = "52877846";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateTamperReportsContents();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// </summary>
        /// Test Method to Reports - Tamper - Grid Columns Names
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24644_Reports_Tamper_Grid_Columns_Names()
        {
            testCaseId = "TC-24644";
            qTestUniqueId = "52877847";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateTamperReportsGridColumns();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Reports - Tamper - Export - PDF
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24645_Reports_Tamper_Export_PDF()
        {
            testCaseId = "TC-24645";
            qTestUniqueId = "52877848";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateTamperReportExportPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Tamper - Export - Excel
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24646_Reports_Tamper_Export_Excel()
        {
            testCaseId = "TC-24646";
            qTestUniqueId = "52877849";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateTamperReportExportExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Tamper - Select Group Filter - Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24649_Reports_Tamper_Select_Group_Filter_Display()
        {
            testCaseId = "TC-24649";
            qTestUniqueId = "52877852";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateTamperReportsGroupFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Reports - Tamper - Select Group Filter - List
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24650_Reports_Tamper_Select_Group_Filter_List()
        {
            testCaseId = "TC-24650";
            qTestUniqueId = "52877853";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateTamperReportsGroupFilterList();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Tamper - Select Group Filter - No Group Selected by default
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24651_Reports_Tamper_Select_Group_Filter_No_Group_Selected_by_default()
        {
            testCaseId = "TC-24651";
            qTestUniqueId = "52877854";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateTamperReportsGroupFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Reports - Tamper - Select Group Filter - With Include Option
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24653_Reports_Tamper_Select_Group_Filter_With_Include_Option()
        {
            testCaseId = "TC-24653";
            qTestUniqueId = "52877856";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateTamperReportsIncludeOption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Route Drilldown - Summary Stats - Route Averages Section - Max Time per Read
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24681_Neptune_360_Productivity_Report_Route_Drilldown_Summary_Stats_Route_Averages_Section_Max_Time_per_Read()
        {
            testCaseId = "TC-24681";
            qTestUniqueId = "53142622";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportsMaxPerRead();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Reports - Tamper - Select Group Filter - With EXclude Option
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24654_Reports_Tamper_Select_Group_Filter_With_Exclude_Option()
        {
            testCaseId = "TC-24654";
            qTestUniqueId = "52877857";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateTamperReportsExcludeOption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Route Drilldown - Summary Stats - Quickest 3 Total Elapsed Times section
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24682_Neptune_360_Productivity_Report_Route_Drilldown_Summary_Stats_Quickest_3_Total_Elapsed_Times_section()
        {
            testCaseId = "TC-24682";
            qTestUniqueId = "53142623";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportsQuickestThreetime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Route Drilldown - Summary Stats - Quickest 3 Total Elapsed Times section
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24683_Neptune_360_Productivity_Report_Route_Drilldown_Summary_Stats_Minimum_Time_Per_Read()
        {
            testCaseId = "TC-24683";
            qTestUniqueId = "53142624";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportsMinPerRead();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Route Drilldown - Summary Stats - Time Per REad
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24684_Neptune_360_Productivity_Report_Route_Drilldown_Summary_Stats_Time_Per_Read()
        {
            testCaseId = "TC-24684";
            qTestUniqueId = "53142625";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportsTimePerRead();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Route Drilldown - Summary Stats - Skip Rate
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24685_Neptune_360_Productivity_Report_Route_Drilldown_Summary_Stats_Skip_Rate()
        {
            testCaseId = "TC-24685";
            qTestUniqueId = "53142626";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportsSkipRate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Route Drilldown - Summary Stats - Total Time
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24686_Neptune_360_Productivity_Report_Route_Drilldown_Summary_Stats_Total_Time()
        {
            testCaseId = "TC-24687";
            qTestUniqueId = "53142627";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportsTotalTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Route Drilldown - Summary Stats - Total Time
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24687_Neptune_360_Productivity_Report_Route_Drilldown_Summary_Stats_Total_Time()
        {
            testCaseId = "TC-24687";
            qTestUniqueId = "53142628";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportsSlowestThreetime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Route Status Widget - Active Selection
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24704_Neptune_360_Productivity_Report_Route_Status_Widget_Active_Selection()
        {
            testCaseId = "TC-24704";
            qTestUniqueId = "53157582";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityActiveRoutes();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Route Status Widget - All Selection
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24705_Neptune_360_Productivity_Report_Route_Status_Widget_All_Selection()
        {
            testCaseId = "TC-24705";
            qTestUniqueId = "53157583";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityAllRoutes();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Route Status Widget - Default  Selection
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24706_Neptune_360_Productivity_Report_Route_Status_Widget_Default_Selection()
        {
            testCaseId = "TC-24706";
            qTestUniqueId = "53157584";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityAllRoutes();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Route Status Widget - Closed Selection
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24707_Neptune_360_Productivity_Report_Route_Status_Widget_Closed_Selection()
        {
            testCaseId = "TC-24707";
            qTestUniqueId = "53157585";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityClosedRoutes();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Route Status Widget - List of Values
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24708_Neptune_360_Productivity_Report_Route_Status_Widget_List_of_Values()
        {
            testCaseId = "TC-24708";
            qTestUniqueId = "53157586";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityRoutesListOfValues();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Meter Reader Drilldown - Summary Stats - Meter Reader Averages - Time per Read
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24712_Neptune_360_Productivity_Report_Meter_Reader_Drilldown_Summary_Stats_Meter_Reader_Averages_Time_per_Read()
        {
            testCaseId = "TC-24712";
            qTestUniqueId = "53167667";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportsMeterReaderTimePerRead();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Meter Reader Drilldown - Summary Stats - Meter Reader Averages - SKip Rate
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24713_Neptune_360_Productivity_Report_Meter_Reader_Drilldown_Summary_Stats_Meter_Reader_Averages_Skip_Rate()
        {
            testCaseId = "TC-24713";
            qTestUniqueId = "53167668";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportsSkipRate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Meter Reader Drilldown - Summary Stats - Meter Reader Averages - Max Time per Read
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24714_Neptune_360_Productivity_Report_Meter_Reader_Drilldown_Summary_Stats_Meter_Reader_Averages_Max_Time_per_Read()
        {
            testCaseId = "TC-24714";
            qTestUniqueId = "53167669";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportsMaxPerRead();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// </summary>
        /// Test Method to Neptune 360 - Productivity Report - Meter Reader Drilldown - Summary Stats - Meter Reader Averages - Min Time per Read
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24715_Neptune_360_Productivity_Report_Meter_Reader_Drilldown_Summary_Stats_Meter_Reader_Averages_Min_Time_per_Read()
        {
            testCaseId = "TC-24715";
            qTestUniqueId = "53167670";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportsMinPerRead();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Productivity - Meter Reader Drilldown - Summary Stats - Running Totals
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24716_Reports_Productivity_Meter_Reader_Drilldown_Summary_Stats_Running_Totals()
        {
            testCaseId = "TC-24716";
            qTestUniqueId = "53167671";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportsRunningTotals();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Productivity - Meter Reader Drilldown - Summary Stats - Meter Reader Averages - Total Time
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24717_Reports_Productivity_Meter_Reader_Drilldown_Summary_Stats_Meter_Reader_Averages_Total_Time()
        {
            testCaseId = "TC-24717";
            qTestUniqueId = "53167672";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateProductivityReportsMeterReaderTotalTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Kendo Conversion - Mach 10 Battery Status Report - Title - Report Name
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24778_Kendo_Conversion_Mach_10_Battery_Status_Report_Title_Report_Name()
        {
            testCaseId = "TC-24778";
            qTestUniqueId = "53287718";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
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

        /// </summary>
        /// Test Method to Kendo Conversion - Mach 10 Battery Status Report - Table settings - Display
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24827_Kendo_Conversion_Mach_10_Battery_Status_Report_Table_settings_Display()
        {
            testCaseId = "TC-24827";
            qTestUniqueId = "53332274";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10TableSetting();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Kendo Conversion - Mach 10 Battery Status Report - PDF export
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24830_Kendo_Conversion_Mach_10_Battery_Status_Report_PDF_export()
        {
            testCaseId = "TC-24830";
            qTestUniqueId = "53333967";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10ExportPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Kendo Conversion - Mach 10 Battery Status Report - Excel export
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_24831_Kendo_Conversion_Mach_10_Battery_Status_Report_Excel_export()
        {
            testCaseId = "TC-24830";
            qTestUniqueId = "53333967";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10ExportExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Kendo Conversion - Mach 10 Battery Status Report  - UTC Offset - YES
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_25023_Kendo_Conversion_Mach_10_Battery_Status_Report_UTC_Offset_YES()
        {
            testCaseId = "TC-25023";
            qTestUniqueId = "53377244";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10UTCOffset();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to kendo Conversion - Mach 10 Battery Status Report - Date & Time Format - MM/DD/YYYY HH:MM: SS (24-hr)
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_25024_kendo_Conversion_Mach_10_Battery_Status_Report_Date_Time_Format()
        {
            testCaseId = "TC-25024";
            qTestUniqueId = "53377710";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateMach10UTCOffsetDatetime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Kendo Conversion - Comments Report - Table settings
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_25196_Kendo_Conversion_Comments_Report_Table_settings()
        {
            testCaseId = "TC-25196";
            qTestUniqueId = "53389672";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateCommentsTableSetting();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Days of Consecutive Flow (AMI) Consumption Based Report - Link Available
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_25252_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Link_Available()
        {
            testCaseId = "TC-25252";
            qTestUniqueId = "53556018";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionURL();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        ///// </summary>
        ///// Test Method to Days of Consecutive Flow (AMI) Consumption Based Report - Link Available
        ///// </summary>
        //[Category("Reports")]
        //[Test]
        //public void TC_25252_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Link_Available()
        //{
        //    testCaseId = "TC-25252";
        //    qTestUniqueId = "53556018";
        //    startDate = DateTime.Now; try
        //    {
        //        Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
        //        url = testData["URL"];
        //        userName = testData["UserName"];
        //        password = testData["Password"];
        //        miuId = testData["MiuID"];
        //        home.NavigateToLftNavReports(url, userName, password);
        //        reportsPage.ValidateDaysOfConsumptionURL();
        //        home.UserLogOut();
        //        QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
        //    }
        //    catch (Exception)
        //    {
        //        QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
        //    }
        //}

        /// </summary>
        /// Test Method to Days of Consecutive Flow (AMI) Consumption Based Report - Link to Customer Inquiry
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_25253_Days_of_Consecutive_Flow_AMI_Consumption_Based_Report_Link_to_Customer_Inquiry()
        {
            testCaseId = "TC-25253";
            qTestUniqueId = "53556107";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsumptionURL();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Kendo Conversion - Invalid Readings Report - Include Parameter - Export PDF
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_25371_Kendo_Conversion_Invalid_Readings_Report_Include_Parameter_Export_PDF()
        {
            testCaseId = "TC-25371";
            qTestUniqueId = "53725337";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingPDFIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Kendo Conversion - Invalid Readings Report - Include Parameter - Export PDF
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_25381_Kendo_Conversion_Invalid_Readings_Report_Include_Parameter_Export_Excel()
        {
            testCaseId = "TC-25381";
            qTestUniqueId = "53725906";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInvalidReadingExcelIcon();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Kendo Conversion - Days of No Flow (AMR) Report - Include Parameter - Export PDF
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_25382_Kendo_Conversion_Days_of_No_Flow_AMR_Report_Include_Parameter_Export_PDF()
        {
            testCaseId = "TC-25382";
            qTestUniqueId = "53725951";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionAMRExportPDF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Kendo Conversion - Days of No Flow (AMR) Report - Include Parameter - Export Excel
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_25383_Kendo_Conversion_Days_of_No_Flow_AMR_Report_Include_Parameter_Export_Excel()
        {
            testCaseId = "TC-25383";
            qTestUniqueId = "53725953";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysofConsumptionAMRExportExcel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Endpoint Maintenance - Customer Inquiry link - Validation
        /// </summary>
        [Category("Reports")]
        
        [Test]
        public void TC_25534_Reports_Endpoint_Maintenance_Customer_Inquiry_link_Validation()
        {
            testCaseId = "TC-25534";
            qTestUniqueId = "53762971";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateEndpointMaintenanceCustInqLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Days of Consecutive Flow (AMI) Flag based - Customer Inquiry link - Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_25535_Reports_Days_of_Consecutive_Flow_AMI_Flag_based_Customer_Inquiry_link_Validation()
        {
            testCaseId = "TC-25535";
            qTestUniqueId = "53762987";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsecFlowFlagBasedCustInqLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Soft Disconnect Report - Customer Inquiry link Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_25536_Reports_Soft_Disconnect_Report_Customer_Inquiry_link_Validation()
        {
            testCaseId = "TC-25536";
            qTestUniqueId = "53762989";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateSoftDisconnectCustInqLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Reports - Days of Consecutive Flow (AMI) Consumption Based - Customer Inquiry link - Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_25537_Reports_Days_of_Consecutive_Flow_AMI_Consumption_Based_Customer_Inquiry_link_Validation()
        {
            testCaseId = "TC-25537";
            qTestUniqueId = "53762991";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateDaysOfConsecFlowConsBasedCustInqLink();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// </summary>
        /// Test Method to Kendo Conversion - High Consumption Report - Cycle/Route - Column name Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_25592_Kendo_Conversion_High_Consumption_Report_Cycle_Route_Column_name_Validation()
        {
            testCaseId = "TC-25592";
            qTestUniqueId = "53772164";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateHighConsumptionCycleRoute();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// </summary>
        /// Test Method to Kendo Conversion - Inactive Flow Report - Cycle/Route - Column name Validation
        /// </summary>
        [Category("Reports")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_25593_Kendo_Conversion_Inactive_Flow_Report_Cycle_Route_Column_name_Validation()
        {
            testCaseId = "TC-25593";
            qTestUniqueId = "53772339";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateToLftNavReports(url, userName, password);
                reportsPage.ValidateInactiveFlowCycleRoute();
                home.UserLogOut();
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
