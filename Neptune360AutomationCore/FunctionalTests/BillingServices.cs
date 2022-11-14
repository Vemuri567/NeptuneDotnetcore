using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Neptune360UIAutomation
{
    public class BillingServices : TestBaseTemplate
    {
        /// <summary>
        /// Test Method to Export Screen - Import Date - Correct Format
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_7963_Export_Screen_Import_Date_Correct_Format()
        {
            testCaseId = "TC-7963";
            qTestUniqueId = "20348770";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateImportDateCorrectFormat();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export - Import Date - Filter button - Not available
        /// </summary>
        [Category("BillingServices")]        
        [Category("RegressionTests")]
        [Test]
        public void TC_7964_Export_Import_Date_Filter_button_Not_available()
        {
            testCaseId = "TC-7964";
            qTestUniqueId = "20349167";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateImportDateFilterBtnUnavailable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export Screen - Select ALL button - Display
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]
        [Test]
        public void TC_7965_Export_Screen_Select_ALL_button_Display()
        {
            testCaseId = "TC-7965";
            qTestUniqueId = "20649858";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateSelectOneAllForExport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export Screen - Deselect ALL button - Display
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]
        [Test]
        public void TC_7966_Export_Screen_Deselect_ALL_button_Display()
        {
            testCaseId = "TC-7966";
            qTestUniqueId = "20649892";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateDeselectOneAllForExport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export Screen - Select - Multiple Routes using SHIFT key
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_7971_Export_Screen_Select_Multiple_Routes_using_SHIFT_key()
        {
            testCaseId = "TC-7971";
            qTestUniqueId = "20652587";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateSelectMultipeRoutesShiftKey();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export Screen - Import Date Filter - Calendar
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8060_Export_Screen_Import_Date_Filter_Calendar()
        {
            testCaseId = "TC-8060";
            qTestUniqueId = "20675498";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateImportDateFilterCalendar();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export Screen - Import Date Filter - Select Date - All Routes Display
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8061_Export_Screen_Import_Date_Filter_Select_Date_All_Routes_Display()
        {
            testCaseId = "TC-8061";
            qTestUniqueId = "20675673";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateImportDateSelectAllRoutesDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export Screen - Import Date Filter - Select Date - Exported Routes Display
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8062_Export_Screen_Import_Date_Filter_Select_Date_Exported_Routes_Display()
        {
            testCaseId = "TC-8062";
            qTestUniqueId = "20675682";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateImportDateSelectAllRoutesDisplay();
                billingServicesExport.ValidateViewOnlyExported();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export Screen - Import Date Filter - Select Date - Unexported Routes Display
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8063_Export_Screen_Import_Date_Filter_Select_Date_Unexported_Routes_Display()
        {
            testCaseId = "TC-8063";
            qTestUniqueId = "20675698";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateImportDateSelectAllRoutesDisplay();
                billingServicesExport.ValidateViewOnlyUnexported();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Option
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8496_Export_History_Option()
        {
            testCaseId = "TC-8496";
            qTestUniqueId = "22709670";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Screen Display
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8497_Export_History_Screen_Display()
        {
            testCaseId = "TC-8497";
            qTestUniqueId = "22709671";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Page Header
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8498_Export_History_Page_Header()
        {
            testCaseId = "TC-8498";
            qTestUniqueId = "22709672";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                billingServicesExport.ValidateExportHistoryPageHeader();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Columns Display
        /// </summary>
        [Category("BillingServices")]

        [Category("RegressionTests")]
        [Test]
        public void TC_8499_Export_History_Columns_Display()
        {
            testCaseId = "TC-8499";
            qTestUniqueId = "22709674";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                exportHistoryPage.ValidateExportHistoryColumnsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Results Per Page Display_Option
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8500_Export_History_Results_Per_Page_Display_Option()
        {
            testCaseId = "TC-8500";
            qTestUniqueId = "22709675";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                exportHistoryPage.ValidateResulsPerPageOptionDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Results Per Page Display_Default Value
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8501_Export_History_Results_Per_Page_Display_Default_Value()
        {
            testCaseId = "TC-8501";
            qTestUniqueId = "22709676";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                exportHistoryPage.ValidateResultsPerPageDefaultValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Export Files_Summary Details Table_Columns
        /// </summary>
        [Category("BillingServices")]

        [Category("RegressionTests")]
        [Test]
        public void TC_8504_Export_History_Export_Files_Summary_Details_Table_Columns()
        {
            testCaseId = "TC-8504";
            qTestUniqueId = "22709679";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                exportHistoryPage.ValidateExportFileSummaryDetailsTableColumnsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Pagination links_Display
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8505_Export_History_Pagination_links_Display()
        {
            testCaseId = "TC-8505";
            qTestUniqueId = "22709680";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                exportHistoryPage.ValidatePaginationLinksDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Pagination links_Less than 10 Records_Disabled
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_8506_Export_History_Pagination_links_Less_than_10_Records_Disabled()
        {
            testCaseId = "TC-8506";
            qTestUniqueId = "22709681";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                exportHistoryPage.ValidatePaginationLinksDisplay();
                exportHistoryPage.ValidatePaginationLinksDisabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Pagination links_Less than 10 Records_Enabled
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8507_Export_History_Pagination_links_Less_than_10_Records_Enabled()
        {
            testCaseId = "TC-8507";
            qTestUniqueId = "22709682";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                exportHistoryPage.ValidatePaginationLinksDisplay();
                exportHistoryPage.ValidatePaginationLinksEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Pagination links_Next
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8508_Export_History_Pagination_links_Next()
        {
            testCaseId = "TC-8508";
            qTestUniqueId = "22709683";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                exportHistoryPage.ValidatePaginationLinksDisplay();
                exportHistoryPage.ValidatePaginationLinksNext();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Pagination links_Last
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8509_Export_History_Pagination_links_Last()
        {
            testCaseId = "TC-8509";
            qTestUniqueId = "22709685";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                exportHistoryPage.ValidatePaginationLinksDisplay();
                exportHistoryPage.ValidatePaginationLinksLast();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Pagination links_First
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8510_Export_History_Pagination_links_First()
        {
            testCaseId = "TC-8510";
            qTestUniqueId = "22709686";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                exportHistoryPage.ValidatePaginationLinksDisplay();
                exportHistoryPage.ValidatePaginationLinksFirst();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Pagination links_Previous
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8511_Export_History_Pagination_links_Previous()
        {
            testCaseId = "TC-8511";
            qTestUniqueId = "22709687";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                exportHistoryPage.ValidatePaginationLinksDisplay();
                exportHistoryPage.ValidatePaginationLinksPrevious();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Filter By Route Name_Search Field_Display
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8514_Export_History_Filter_By_Route_Name_Search_Field_Display()
        {
            testCaseId = "TC-8514";
            qTestUniqueId = "22710655";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                exportHistoryPage.ValidateFilterByRouteNameSearchDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Filter By Route Name_Search Button_Display
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8515_Export_History_Filter_By_Route_Name_Search_Button_Display()
        {
            testCaseId = "TC-8515";
            qTestUniqueId = "22710656";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                exportHistoryPage.ValidateSearchButtonDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Filter By Route Name_Blank Search
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8516_Export_History_Filter_By_Route_Name_Blank_Search()
        {
            testCaseId = "TC-8516";
            qTestUniqueId = "22710658";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                exportHistoryPage.ValidateSearchButtonDisabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Filter By Route Name_Valid Route File Search
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_8517_Export_History_Filter_By_Route_Name_Valid_Route_File_Search()
        {
            testCaseId = "TC-8517";
            qTestUniqueId = "22710659";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                string fileName = testData["ExportFileName"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                exportHistoryPage.ValidateRouteFileSearch(fileName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Filter By Route Name_Invalid Route Name Search
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]
        [Test]
        public void TC_8518_Export_History_Filter_By_Route_Name_Invalid_Route_Name_Search()
        {
            testCaseId = "TC-8518";
            qTestUniqueId = "22710660";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                exportHistoryPage.ValidateInvalidRouteFileSearch();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Settings_Not Available
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8521_Export_Export_Settings_Not_Available()
        {
            testCaseId = "TC-8521";
            qTestUniqueId = "22733340";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportSettingsBtnNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Validate Export_Export_  Button_Dialog Display
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8522_Export_Export_Button_Dialog_Display()
        {
            testCaseId = "TC-8522";
            qTestUniqueId = "22733341";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportDialogDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Button_Dialog Contents
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8523_Export_Export_Button_Dialog_Contents()
        {
            testCaseId = "TC-8523";
            qTestUniqueId = "22733342";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportDialogContents();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Dialog_Back to Exports_Enabled
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8524_Export_Export_Dialog_Back_to_Exports_Enabled()
        {
            testCaseId = "TC-8524";
            qTestUniqueId = "22733343";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateBackToExportsEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Dialog_Export_Enabled
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8525_Export_Export_Dialog_Export_Enabled()
        {
            testCaseId = "TC-8525";
            qTestUniqueId = "22733344";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportDisabledByDefault();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Dialog_Back to Exports_Access
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8526_Export_Export_Dialog_Back_to_Exports_Access()
        {
            testCaseId = "TC-8526";
            qTestUniqueId = "22733345";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateBackToExportAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Dialog_Export Button_Access
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8527_Export_Export_Dialog_Export_Button_Access()
        {
            testCaseId = "TC-8527";
            qTestUniqueId = "22733346";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportButtonAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Process_Back to Exports_Display
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8528_Export_Export_Process_Back_to_Exports_Display()
        {
            testCaseId = "TC-8528";
            qTestUniqueId = "22733347";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportProcessBackToExportsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Process_Back to Exports_Enabled
        /// </summary>
        [Category("BillingServices")]

        [Category("RegressionTests")]
        [Test]
        public void TC_8529_Export_Export_Process_Back_to_Exports_Enabled()
        {
            testCaseId = "TC-8529";
            qTestUniqueId = "22733348";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateBackToExportEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Process_Back to Exports_Access
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8530_Export_Export_Process_Back_to_Exports_Access()
        {
            testCaseId = "TC-8530";
            qTestUniqueId = "22733349";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateBackToExportAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Process_Save File As_Contents
        /// </summary>
        [Category("BillingServices")]
        [Category("RegressionTests")]

        [Test]
        public void TC_8531_Export_Export_Process_Save_File_As_Contents()
        {
            testCaseId = "TC-8531";
            qTestUniqueId = "22733871";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateSaveFileAsContents();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Process_Save File As_File Name_Validation
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_8532_Export_Export_Process_Save_File_As_File_Name_Validation()
        {
            testCaseId = "TC-8532";
            qTestUniqueId = "22733872";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                string filePath = testData["ExportFileName"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateSaveAsFileNameValidation(filePath);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Process_Export Settings_Contents
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_8533_Export_Export_Process_Export_Settings_Contents()
        {
            testCaseId = "TC-8533";
            qTestUniqueId = "22733873";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportDialogContents();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Process_Export History_Available
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8536_Export_Export_Process_Export_History_Available()
        {
            testCaseId = "TC-8536";
            qTestUniqueId = "22736596";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportButtonAccess();
                billingServicesExport.ValidateExportHistoryButtonDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Process_Export History_Enabled
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8537_Export_Export_Process_Export_History_Enabled()
        {
            testCaseId = "TC-8537";
            qTestUniqueId = "22736602";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportButtonAccess();
                billingServicesExport.ValidateExportHistoryButtonEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Process_Export History_Access
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8538_Export_Export_Process_Export_History_Access()
        {
            testCaseId = "TC-8538";
            qTestUniqueId = "22736605";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportButtonAccess();
                billingServicesExport.ValidateExportHistoryButtonDisplayed();
                billingServicesExport.ValidateExportHistoryButtonAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Process_Download_Available
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8539_Export_Export_Process_Download_Available()
        {
            testCaseId = "TC-8539";
            qTestUniqueId = "22736609";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportButtonAccess();
                billingServicesExport.ValidateProcessDownloadAvailbale();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Process_Download_Disabled
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8540_Export_Export_Process_Download_Disabled()
        {
            testCaseId = "TC-8540";
            qTestUniqueId = "22736611";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportButtonAccess();
                billingServicesExport.ValidateProcessDownloadDisabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Process_Completed_Download_Enabled
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8541_Export_Export_Process_Completed_Download_Enabled()
        {
            testCaseId = "TC-8541";
            qTestUniqueId = "22736614";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportButtonAccess();
                billingServicesExport.ValidateProcessDownloadEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Process_Completed_Download_Access
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8542_Export_Export_Process_Completed_Download_Access()
        {
            testCaseId = "TC-8542";
            qTestUniqueId = "22736617";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportButtonAccess();
                billingServicesExport.ValidateProcessDownloadAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Process_Processing Details
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8543_Export_Export_Process_Processing_Details()
        {
            testCaseId = "TC-8543";
            qTestUniqueId = "22736627";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateProcessingDetails();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Process_Processing Details_Gathering Data_Percentage
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8544_Export_Export_Process_Processing_Details_Gathering_Data_Percentage()
        {
            testCaseId = "TC-8544";
            qTestUniqueId = "22736628";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateProcessingDetailsGathering();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export_  Process_Processing Details_Writing Data_Percentage
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8545_Export_Export_Process_Processing_Details_Writing_Data_Percentage()
        {
            testCaseId = "TC-8545";
            qTestUniqueId = "22737263";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateProcessingDetailsWriting();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Import_Import Summary_Status_Contents_Validation
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8730_Import_Import_Summary_Status_Contents_Validation()
        {
            testCaseId = "TC-8730";
            qTestUniqueId = "23984933";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateImportSummaryContentsValidation(importFile);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Import_Import Summary_Status_File Upload_Spinner Wheel_Less Than 35 Days
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8731_Import_Import_Summary_Status_File_Upload_Spinner_Wheel_Less_Than_35_Days()
        {
            testCaseId = "TC-8731";
            qTestUniqueId = "23984954";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateImportSummarySpinnerWheel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Import_Import Summary_Status_File Upload_Completed
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8732_Import_Import_Summary_Status_File_Upload_Completed()
        {
            testCaseId = "TC-8732";
            qTestUniqueId = "23984956";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateFileUploadComplete();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Import_Import Summary_Status_File Validation_In Progress
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_8733_Import_Import_Summary_Status_File_Validation_In_Progress()
        {
            testCaseId = "TC-8733";
            qTestUniqueId = "23984962";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateFileValidationInProgress("ImportFile");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Import_Import Summary_Status_File Validation_Completed
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8734_Import_Import_Summary_Status_File_Validation_Completed()
        {
            testCaseId = "TC-8734";
            qTestUniqueId = "23985022";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateFileValidationCompleted();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Import_Import Summary_Status_Loading Records_In Progress
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8735_Import_Import_Summary_Status_Loading_Records_In_Progress()
        {
            testCaseId = "TC-8735";
            qTestUniqueId = "23985023";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateLoadingRecordsInProgress();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Import_Import Summary_Status_Loading Records_Completed
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8736_Import_Import_Summary_Status_Loading_Records_Completed()
        {
            testCaseId = "TC-8736";
            qTestUniqueId = "23985024";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateLoadingRecordsCompleted();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Import_Import Summary_Status_Loading Reads_In Progress
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8739_Import_Import_Summary_Status_Loading_Reads_In_Progress()
        {
            testCaseId = "TC-8739";
            qTestUniqueId = "23985027";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateLoadingReadsInProgress();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Import_Import Summary_Status_Loading Reads_Completed
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8740_Import_Import_Summary_Status_Loading_Reads_Completed()
        {
            testCaseId = "TC-8740";
            qTestUniqueId = "23985087";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateLoadingReadsCompleted();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Import_Import Summary_Status_Completed_Field_Display
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8741_Import_Import_Summary_Status_Completed_Field_Display()
        {
            testCaseId = "TC-8741";
            qTestUniqueId = "23986033";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateFileValidationCompleted();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Import_Import Summary_Status_Completed_Checked
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8742_Import_Import_Summary_Status_Completed_Checked()
        {
            testCaseId = "TC-8742";
            qTestUniqueId = "23986144";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateFileValidationCompleted();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Import_Import Summary_Status_Failed
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8743_Import_Import_Summary_Status_Failed()
        {
            testCaseId = "TC-8743";
            qTestUniqueId = "23986151";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateFileValidationFailed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Import_Import Summary_Status_File Upload_Older Than 35 Days
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8768_Import_Import_Summary_Status_File_Upload_Older_Than_35_Days()
        {
            testCaseId = "TC-8768";
            qTestUniqueId = "24394011";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateImportSummarySpinnerWheel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export Screen - Import Date Filter - Select Date - Previous Month-Records
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_10338_Export_Screen_Import_Date_Filter_Select_Date_Previous_Month_Records()
        {
            testCaseId = "TC-10338";
            qTestUniqueId = "24882679";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateSelectDatePreviousMonth();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export Screen - Import Date Filter - Select Date - Future Month
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_10339_Export_Screen_Import_Date_Filter_Select_Date_Future_Month()
        {
            testCaseId = "TC-10339";
            qTestUniqueId = "24882695";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateSelectDateFutureMonth();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export Screen - Import Date Filter - Manually Enter Date
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_10340_Export_Screen_Import_Date_Filter_Manually_Enter_Date()
        {
            testCaseId = "TC-10340";
            qTestUniqueId = "24882699";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateSelectDateManually();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export Screen - Import Date Filter - Select Date - Previous Month - No Records
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_11969_Export_Screen_Import_Date_Filter_Select_Date_Previous_Month_No_Records()
        {
            testCaseId = "TC-11969";
            qTestUniqueId = "25248761";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateSelectDatePreviousNoRecords();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Create Import summary screen - Summary information
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_3895_UI_Create_Import_summary_screen_Summary_information()
        {
            testCaseId = "TC-3895";
            qTestUniqueId = "19323174";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateImportSummaryContentsValidation(importFile);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - User is alerted that import process is complete - User is on Import summary screen
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_3897_UI_User_is_alerted_that_import_process_is_complete_User_is_on_Import_summary_screen()
        {
            testCaseId = "TC-3897";
            qTestUniqueId = "19323176";
            startDate = DateTime.Now; try
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
        /// Test Method to UI - User is alerted that import process is complete - User is on different screen
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_3898_UI_User_is_alerted_that_import_process_is_complete_User_is_on_different_screen()
        {
            testCaseId = "TC-3898";
            qTestUniqueId = "19323177";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateImportSuccessful(importFile);
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
        /// Test Method to UI import process complete Display summary of routes and meters processed
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_3899_UI_import_process_complete_Display_summary_of_routes_and_meters_processed()
        {
            testCaseId = "TC-3899";
            qTestUniqueId = "19323178";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateImportSummaryContentsValidation(importFile);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI import process complete - Import file added to the import file list
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_3900_UI_import_process_complete_Import_file_added_to_the_import_file_list()
        {
            testCaseId = "TC-3900";
            qTestUniqueId = "19323179";
            startDate = DateTime.Now; try
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
        /// Test Method to UI - View import progress - View
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_3901_UI_View_import_progress_View()
        {
            testCaseId = "TC-3901";
            qTestUniqueId = "19323180";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateFileValidationInProgress("ImportFile");
                billingServicesImport.ValidateBackImportButtonExists();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Selecting a file to import - Import file selection
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_3903_UI_Selecting_a_file_to_import_Import_file_selection()
        {
            testCaseId = "TC-3903";
            qTestUniqueId = "19323182";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateImportFileSelection();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Selecting a file to import - CIS import file with CORRECT extension
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_3904_UI_Selecting_a_file_to_import_CIS_import_file_with_CORRECT_extension()
        {
            testCaseId = "TC-3904";
            qTestUniqueId = "19323183";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateFileValidationInProgress("ImportFile");
                billingServicesImport.ValidateBackImportButtonExists();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Selecting a file to import - CIS import file with INCORRECT extension
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_3905_UI_Selecting_a_file_to_import_CIS_import_file_with_INCORRECT_extension()
        {
            testCaseId = "TC-3905";
            qTestUniqueId = "19323184";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateFileValidationInProgress(importFile);
                //billingServicesImport.ValidateBackImportButtonExists();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI -Viewing errors from an import - Errors on the Summary Screen
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_3906_UI_Viewing_errors_from_an_import_Errors_on_the_Summary_Screen()
        {
            testCaseId = "TC-3906";
            qTestUniqueId = "19323185";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateImportErrorsonSummaryScreen(importFile);
                //billingServicesImport.ValidateBackImportButtonExists();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Viewing errors from an import - Errors on the List Screen
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_3907_UI_Viewing_errors_from_an_import_Errors_on_the_List_Screen()
        {
            testCaseId = "TC-3907";
            qTestUniqueId = "19323186";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateImportErrorsonSummaryScreen(importFile);
                billingServicesImport.ValidateBackImportButtonExists();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Create Import list screen - Import list columns
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_3908_UI_Create_Import_list_screen_Import_list_columns()
        {
            testCaseId = "TC-3908";
            qTestUniqueId = "19323187";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateImportListColumns();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Create Import list screen - File details
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_3909_UI_Create_Import_list_screen_File_details()
        {
            testCaseId = "TC-3909";
            qTestUniqueId = "19323188";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateImportFileListValueDetails();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Create Import list screen - File display order
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_3910_UI_Create_Import_list_screen_File_display_order()
        {
            testCaseId = "TC-3910";
            qTestUniqueId = "19323189";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];

                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateImportListScreen();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Exit import progress display import runs in the background 
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_3911_UI_Exit_import_progress_display_import_runs_in_the_background()
        {
            testCaseId = "TC-3911";
            qTestUniqueId = "19323190";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];

                home.NavigateToLftNavImportManagement(url, userName, password);
                //billingServicesImport.ValidateImportListColumns();
                billingServicesImport.ValidateDisplayImportRuns(importFile);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }



        /// <summary>
        /// Test Method to UI - Exit import progress display, import runs in the background, Click file from Import list
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_3912_UI_Exit_import_progress_display_import_runs_in_the_background_Click_file_from_Import_list()
        {
            testCaseId = "TC-3912";
            qTestUniqueId = "19323192";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];

                home.NavigateToLftNavImportManagement(url, userName, password);
                //billingServicesImport.ValidateImportListColumns();
                billingServicesImport.ValidateDisplayImportRuns(importFile);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to UI - Cancelling the  import - Confirmation prompt
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_3913_UI_Cancelling_the_import_Confirmation_prompt()
        {
            testCaseId = "TC-3913";
            qTestUniqueId = "19323193";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];

                home.NavigateToLftNavImportManagement(url, userName, password);
                //billingServicesImport.ValidateImportListColumns();
                billingServicesImport.ValidateCancellationPrompt(importFile);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to UI - Cancelling the  import - Confirm the Cancellation
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_3914_UI_Cancelling_the_import_Confirm_the_Cancellation()
        {
            testCaseId = "TC-3914";
            qTestUniqueId = "19323194";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];

                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateConfirmingCancellation(importFile);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Cancelling the  import - Canceling Confirmation
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_3915_UI_Cancelling_the_import_Canceling_Confirmation()
        {
            testCaseId = "TC-3915";
            qTestUniqueId = "19323195";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];

                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateCancellingConfirmation(importFile);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }



        /// <summary>
        /// Test Method to UI - Cancelling the  import - Once import is complete, Cancel button should not display
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_3916_UI_Cancelling_the_import_Once_import_is_complete_Cancel_button_should_not_display()
        {
            testCaseId = "TC-3916";
            qTestUniqueId = "19323196";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];

                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateCancelButtonNotDisplayed(importFile);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to UI - Cancelling the  import - Cancel button is displayed to the user that initiated the import
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_3917_UI_Cancelling_the_import_Cancel_button_is_displayed_to_the_user_that_initiated_the_import()
        {
            testCaseId = "TC-3917";
            qTestUniqueId = "19323197";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];

                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateCancelButtonDisplayed(importFile);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Cancelling the  import - Import process should be completed when import is not cancelled
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_3918_UI_Cancelling_the_import_Import_process_should_be_completed_when_import_is_not_cancelled()
        {
            testCaseId = "TC-3918";
            qTestUniqueId = "19323198";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];

                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateImportProcessCompleted(importFile);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI -Cancelling the  import - Once import is complete, Cancel button should not display, Click file from Import list
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_3961_UI_Cancelling_the_import_Once_import_is_complete_Cancel_button_should_not_display_Click_file_from_Import_list()
        {
            testCaseId = "TC-3961";
            qTestUniqueId = "19323374";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];

                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.ValidateImportProcessCompletedCancelBtnNotDisplay(importFile);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Cancelling the  import - Cancel button is displayed to the user that initiated the import, Click file from Import list
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_3962_UI_Cancelling_the_import_Cancel_button_is_displayed_to_the_user_that_initiated_the_import_Click_file_from_Import_list()
        {
            testCaseId = "TC-3962";
            qTestUniqueId = "19323375";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];

                home.NavigateToLftNavImportManagement(url, userName, password);
                billingServicesImport.CancelButtonisDiplayedToUser(importFile);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Export_Export_Export_Export Settings_All Options
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8096_Export_Export_Settings_All_Options()
        {
            testCaseId = "TC-8096";
            qTestUniqueId = "21054712";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportAllOptions();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export Settings_Complete
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8090_Export_Export_Settings_Complete()
        {
            testCaseId = "TC-8090";
            qTestUniqueId = "22737263";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportCompleteOptions();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export Settings_Incomplete
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8097_Export_Export_Settings_Incomplete()
        {
            testCaseId = "TC-8097";
            qTestUniqueId = "21054714";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportInCompleteOptions();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export Settings_Skipped
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8098_Export_Export_Settings_Skipped()
        {
            testCaseId = "TC-8098";
            qTestUniqueId = "21054715";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportSkippedOptions();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_Export Exclude Invalid
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8099_Export_Export_Exclude_Invalid()
        {
            testCaseId = "TC-8099";
            qTestUniqueId = "21054718";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportExcludeInvalid();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        [Category("BillingServices")]

        [Test]
        public void TC_8100_Export_Export_Multiple_Checked()
        {
            testCaseId = "TC-8100";
            qTestUniqueId = "21054719";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportMultipleChecked();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_View_View Exported
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8077_Export_View_View_Exported()
        {
            testCaseId = "TC-8077";
            qTestUniqueId = "20790758";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateViewOnlyExported();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_View_View Unexported
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8078_Export_View_View_Unexported()
        {
            testCaseId = "TC-8078";
            qTestUniqueId = "20790759";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateViewOnlyUnexported();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export_View_View All
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8079_Export_View_View_All()
        {
            testCaseId = "TC-8079";
            qTestUniqueId = "20790760";
            startDate = DateTime.Now; try
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
        /// Test Method to UI - Create Export list screen - Export list columns
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8298_UI_Create_Export_list_screen_Export_list_columns()
        {
            testCaseId = "TC-8298";
            qTestUniqueId = "22255782";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportListColumns();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to UI - Create Export list screen - File details
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8299_UI_Create_Export_list_screen_File_details()
        {
            testCaseId = "TC-8299";
            qTestUniqueId = "22255784";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportListColumns();
                billingServicesExport.ValidateFileDetails();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Create Export list screen - Number of Routes
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8300_UI_Create_Export_list_screen_Number_of_Routes()
        {
            testCaseId = "TC-8300";
            qTestUniqueId = "22255786";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportListDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_Export Files_Sort Order
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8502_Export_History_Export_Files_Sort_Order()
        {
            testCaseId = "TC-8502";
            qTestUniqueId = "22709677";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateExportFilesSortOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Export History_Export Files_Summary Details Display
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8503_Export_History_Export_Files_Summary_Details_Display()
        {
            testCaseId = "TC-8503";
            qTestUniqueId = "22709678";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                billingServicesExport.ValidateExportFilesSummary();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Export History_File Validation
        /// </summary>
        [Category("BillingServices")]

        [Test]
        public void TC_8512_Export_History_File_Validation()
        {
            testCaseId = "TC-8512";
            qTestUniqueId = "22710089";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportHistory(url, userName, password);
                billingServicesExport.ValidateExportFilesValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Export_Export_Process_Processing Details_Total Routes_Validation
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_8546_Export_Export_Process_Processing_Details_Total_Routes_Validation()
        {
            testCaseId = "TC-8546";
            qTestUniqueId = "22710089";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavExportManagement(url, userName, password);
                billingServicesExport.ValidateTotalRoutesValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size dialog_Neptune 360 Value_Left side_ 5/8''
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23356_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Neptune360_Value_Left_side_5_8()
        {
            testCaseId = "TC-23356";
            qTestUniqueId = "50364587";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsMeterSize5_8();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size dialog_Neptune 360 Value_Left side_ 3/4''
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23357_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Neptune360_Value_Left_side_3_4()
        {
            testCaseId = "TC-23357";
            qTestUniqueId = "50364747";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsMeterSize3_4();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size dialog_Neptune 360 Value_Left side_ 1''
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23358_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Neptune360_Value_Left_side_1()
        {
            testCaseId = "TC-23358";
            qTestUniqueId = "50364769";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsMeterSize1();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size dialog_Neptune 360 Value_Left side_ 1-1/2''
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23359_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Neptune360_Value_Left_side_1_1_2()
        {
            testCaseId = "TC-23359";
            qTestUniqueId = "50364770";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsMeterSize1_1_2();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size dialog_Neptune 360 Value_Left side_ 3''
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23360_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Neptune360_Value_Left_side_3()
        {
            testCaseId = "TC-23360";
            qTestUniqueId = "50364773";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsMeterSize3();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size dialog_Neptune 360 Value_Left side_ 2''
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23361_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Neptune360_Value_Left_side_2()
        {
            testCaseId = "TC-23361";
            qTestUniqueId = "50364774";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsMeterSize2();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size dialog_Neptune 360 Value_Left side_ 4''
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23362_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Neptune360_Value_Left_side_4()
        {
            testCaseId = "TC-23362";
            qTestUniqueId = "50364775";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsMeterSize4();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size dialog_Neptune 360 Value_Left side_ 6''
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23363_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Neptune360_Value_Left_side_6()
        {
            testCaseId = "TC-23363";
            qTestUniqueId = "50364776";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsMeterSize6();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size dialog_Neptune 360 Value_Left side_ 8''
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23364_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Neptune360_Value_Left_side_8()
        {
            testCaseId = "TC-23364";
            qTestUniqueId = "50364786";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsMeterSize8();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size dialog_Neptune 360 Value_Left side_ 10''
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23365_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Neptune360_Value_Left_side_10()
        {
            testCaseId = "TC-23365";
            qTestUniqueId = "50364787";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsMeterSize10();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size dialog_Neptune 360 Value_Left side_ 12''
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23366_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Neptune360_Value_Left_side_12()
        {
            testCaseId = "TC-23366";
            qTestUniqueId = "50364788";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsMeterSize12();
                home.UserLogOut();
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
        ///// Test Method to Billing Services Settings_Data Translations_Meter Size dialog_Neptune 360 Value_Left side_ 16''
        ///// </summary>
        //[Category("BillingServices")]
        //[Test]
        //public void TC_23367_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Neptune360_Value_Left_side_16()
        //{
        //    testCaseId = "TC-23367";
        //    qTestUniqueId = "50364789";
        //    startDate = DateTime.Now; try
        //    {
        //        Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
        //        url = testData["URL"];
        //        userName = testData["UserName"];
        //        password = testData["Password"];
        //        home.NavigateToLftNavBiiilingServicesSettings(url, userName, password);
        //        billingServicesSettings.ValidateDataTranslationsMeterSize16();
        //        home.UserLogOut();
        //        QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
        //    }
        //    catch (Exception)
        //    {
        //        QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
        //    }
        //}


        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size dialog_Neptune 360 Value_Left side_ 20''
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23368_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Neptune360_Value_Left_side_20()
        {
            testCaseId = "TC-23368";
            qTestUniqueId = "50364790";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsMeterSize20();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size Mapping dialog_Ok_Button_Displays
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23370_Billing_Services_Settings_Data_Translations_Meter_Size_Mapping_dialog_Ok_Button_Displays()
        {
            testCaseId = "TC-23370";
            qTestUniqueId = "50381700";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsOkButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size Mapping dialog_Save Success_Toast Message
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23372_Billing_Services_Settings_Data_Translations_Meter_Size_Mapping_dialog_Save_Success_Toast_Message()
        {
            testCaseId = "TC-23372";
            qTestUniqueId = "50382193";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsMappingSuccessToast();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size Mapping dialog_Ok_Button_Displays
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23391_Billing_Services_Settings_Data_Translations_Meter_Size_Mapping_dialog_Ok_Button_Displays()
        {
            testCaseId = "TC-23391";
            qTestUniqueId = "50397354";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsOkButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size_Existing Mapping dialog_Success_Toast Message
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23393_Billing_Services_Settings_Data_Translations_Meter_Size_Existing_Mapping_dialog_Success_Toast_Message()
        {
            testCaseId = "TC-23393";
            qTestUniqueId = "50397633";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsMappingSuccessToast();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size_Existing Mapping dialog_Cancel_Button_Displays
        /// </summary>
        [Category("BillingServices")]
        [Test]
        public void TC_23394_Billing_Services_Settings_Data_Translations_Meter_Size_Existing_Mapping_dialog_Cancel_Button_Displays()
        {
            testCaseId = "TC-23394";
            qTestUniqueId = "50397649";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsCancelButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Register UOM Mapping dialog_Neptune 360 value_Column_Display
        [Category("BillingServices")]
        [Test]
        public void TC_23398_Billing_Services_Settings_Data_Translations_Register_UOM_Mapping_dialog_Neptune360_value_Column_Display()
        {
            testCaseId = "TC-23398";
            qTestUniqueId = "50408184";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsNeptune360Values();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Register UOM Mapping dialog_Close(X)_Access
        [Category("BillingServices")]
        [Test]
        public void TC_23399_Billing_Services_Settings_Data_Translations_Register_UOM_Mapping_dialog_Close_Access()
        {
            testCaseId = "TC-23399";
            qTestUniqueId = "50408186";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateNeptune360ValuesCloseXAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Register UOM Mapping dialog_Cancel_Access
        [Category("BillingServices")]
        [Test]
        public void TC_23400_Billing_Services_Settings_Data_Translations_Register_UOM_Mapping_dialog_Cancel_Access()
        {
            testCaseId = "TC-23400";
            qTestUniqueId = "50408187";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegistertUOMCancelAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Register UOM_Title
        [Category("BillingServices")]
        [Test]
        public void TC_23401_Billing_Services_Settings_Data_Translations_Register_UOM_Title()
        {
            testCaseId = "TC-23401";
            qTestUniqueId = "50408188";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegistertUOMTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Register UOM_Access
        [Category("BillingServices")]
        [Test]
        public void TC_23402_Billing_Services_Settings_Data_Translations_Register_UOM_Access()
        {
            testCaseId = "TC-23402";
            qTestUniqueId = "50408189";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegistertUOMTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Register UOM_Displays
        [Category("BillingServices")]
        [Test]
        public void TC_23403_Billing_Services_Settings_Data_Translations_Register_UOM_Displays()
        {
            testCaseId = "TC-23403";
            qTestUniqueId = "50408191";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegistertUOMDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Register UOM Mapping dialog_Utility value_Column_Display
        [Category("BillingServices")]
        [Test]
        public void TC_23404_Billing_Services_Settings_Data_Translations_Register_UOM_Mapping_dialog_Utility_value_Column_Display()
        {
            testCaseId = "TC-23404";
            qTestUniqueId = "50408245";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsNeptune360Values();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Register UOM dialog_Utility value_Column_Combo Box_Display
        [Category("BillingServices")]
        [Test]
        public void TC_23405_Billing_Services_Settings_Data_Translations_Register_UOM_dialog_Utility_value_Column_Combo_Box_Display()
        {
            testCaseId = "TC-23405";
            qTestUniqueId = "50408346";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMUtilityValueComboBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Register UOM dialog_Utility value_Column_Combo Box_Placeholder Text
        [Category("BillingServices")]
        [Test]
        public void TC_23406_Billing_Services_Settings_Data_Translations_Register_UOM_dialog_Utility_value_Column_Combo_Box_Placeholder_Text()
        {
            testCaseId = "TC-23406";
            qTestUniqueId = "50408699";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMComboBoxPlaceholderText();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Register UOM dialog_Utility value_Column_Combo Box_Click
        [Category("BillingServices")]
        [Test]
        public void TC_23407_Billing_Services_Settings_Data_Translations_Register_UOM_dialog_Utility_value_Column_Combo_Box_Click()
        {
            testCaseId = "TC-23407";
            qTestUniqueId = "50408820";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMComboBoxPlaceholderText();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size dialog_Placeholder text
        [Category("BillingServices")]
        [Test]
        public void TC_23408_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Placeholder_text()
        {
            testCaseId = "TC-23408";
            qTestUniqueId = "50412915";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMComboBoxPlaceholderText();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Register UOM dialog_Utility value_Column_Combo Box_Click
        [Category("BillingServices")]
        [Test]
        public void TC_23409_Billing_Services_Settings_Data_Translations_Register_UOM_dialog_Utility_value_Column_Combo_Box_Click()
        {
            testCaseId = "TC-23409";
            qTestUniqueId = "50412916";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMComboBoxPlaceholderClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter Size dialog_modal_close
        [Category("BillingServices")]
        [Test]
        public void TC_23410_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_modal_close()
        {
            testCaseId = "TC-23410";
            qTestUniqueId = "50413831";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegistertUOMCancelAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Register UOM dialog_Neptune 360 value_Cubic Feet
        [Category("BillingServices")]
        [Test]
        public void TC_23421_Billing_Services_Settings_Data_Translations_Register_UOM_dialog_Neptune_360_value_Cubic_Feet()
        {
            testCaseId = "TC-23421";
            qTestUniqueId = "50466729";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegistertUOMCubicFeet();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Register UOM dialog_Neptune 360 value_Gallons
        [Category("BillingServices")]
        [Test]
        public void TC_23422_Billing_Services_Settings_Data_Translations_Register_UOM_dialog_Neptune_360_value_Gallons()
        {
            testCaseId = "TC-23422";
            qTestUniqueId = "50467304";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegistertUOMGallons();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Register UOM dialog_Neptune 360 value_Cubic Meters
        [Category("BillingServices")]
        [Test]
        public void TC_23423_Billing_Services_Settings_Data_Translations_Register_UOM_dialog_Neptune_360_value_Cubic_Meters()
        {
            testCaseId = "TC-23423";
            qTestUniqueId = "50467335";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegistertUOMCubicMeters();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Register UOM dialog_Neptune 360 value_Imperial Gallons
        [Category("BillingServices")]
        [Test]
        public void TC_23424_Billing_Services_Settings_Data_Translations_Register_UOM_dialog_Neptune_360_value_Imperial_Gallons()
        {
            testCaseId = "TC-23424";
            qTestUniqueId = "50467337";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegistertUOMImperialGallons();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Register UOM dialog_Neptune 360 value_Liters
        [Category("BillingServices")]
        [Test]
        public void TC_23425_Billing_Services_Settings_Data_Translations_Register_UOM_dialog_Neptune_360_value_Liters()
        {
            testCaseId = "TC-23425";
            qTestUniqueId = "50468007";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegistertUOMLitres();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Save_Meter size Mapping
        [Category("BillingServices")]
        [Test]
        public void TC_23643_Billing_Services_Settings_Data_Translations_Save_Meter_size_Mapping()
        {
            testCaseId = "TC-23643";
            qTestUniqueId = "50694440";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeSave();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Update_Meter size Mapping
        [Category("BillingServices")]
        [Test]
        public void TC_23644_Billing_Services_Settings_Data_Translations_Update_Meter_size_Mapping()
        {
            testCaseId = "TC-23644";
            qTestUniqueId = "50694694";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeSave();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Billing Services Settings_Data Translations_Meter size field_Length
        [Category("BillingServices")]
        [Test]
        public void TC_23645_Billing_Services_Settings_Data_Translations_Meter_size_field_Length()
        {
            testCaseId = "TC-23645";
            qTestUniqueId = "50694851";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeLength();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Billing Services Settings_Data Translations_Neptune 360 standard Meter Size value Mapping
        [Category("BillingServices")]
        [Test]
        public void TC_23646_Billing_Services_Settings_Data_Translations_Neptune360_standard_Meter_Size_value_Mapping()
        {
            testCaseId = "TC-23646";
            qTestUniqueId = "50694852";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Billing Services Settings_Data Translations_Update_Meter size_Success Toast 
        [Category("BillingServices")]
        [Test]
        public void TC_23647_Billing_Services_Settings_Data_Translations_Update_Meter_size_Success_Toast()
        {
            testCaseId = "TC-23647";
            qTestUniqueId = "50695114";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeSave();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Meter Size dialog_Update_Close without save 
        [Category("BillingServices")]
        [Test]
        public void TC_23648_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Update_Close_without_save()
        {
            testCaseId = "TC-23648";
            qTestUniqueId = "50695362";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsCancelUpdate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Meter size_Existing value 
        [Category("BillingServices")]
        [Test]
        public void TC_23649_Billing_Services_Settings_Data_Translations_Meter_size_Existing_value()
        {
            testCaseId = "TC-23649";
            qTestUniqueId = "50697349";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsEnterValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Fields 
        [Category("BillingServices")]
        [Test]
        public void TC_23650_Billing_Services_Settings_Data_Translations_Fields()
        {
            testCaseId = "TC-23650";
            qTestUniqueId = "50723833";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsFields();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Register UOM_Existing value
        [Category("BillingServices")]
        [Test]
        public void TC_23651_Billing_Services_Settings_Data_Translations_Register_UOM_Existing_value()
        {
            testCaseId = "TC-23651";
            qTestUniqueId = "50724200";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMEnterValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Register UOM dialog_Update_Close without save 
        [Category("BillingServices")]
        [Test]
        public void TC_23652_Billing_Services_Settings_Data_Translations_Register_UOM_dialog_Update_Close_without_save()
        {
            testCaseId = "TC-23652";
            qTestUniqueId = "50724201";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMEnterValueCancel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Update_Register UOM_Success Toast  
        [Category("BillingServices")]
        [Test]
        public void TC_23653_Billing_Services_Settings_Data_Translations_Update_Register_UOM_Success_Toast()
        {
            testCaseId = "TC-23653";
            qTestUniqueId = "50724202";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMUpdateValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Neptune 360 standard Register UOM values 
        [Category("BillingServices")]
        [Test]
        public void TC_23654_Billing_Services_Settings_Data_Translations_Neptune360_standard_Register_UOM_values()
        {
            testCaseId = "TC-23654";
            qTestUniqueId = "50724203";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMStandardValues();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_UOM Register field_Length 
        [Category("BillingServices")]
        [Test]
        public void TC_23655_Billing_Services_Settings_Data_Translations_UOM_Register_field_Length()
        {
            testCaseId = "TC-23655";
            qTestUniqueId = "50724204";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMFieldValues();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Update_Register UOM  Mapping
        [Category("BillingServices")]
        [Test]
        public void TC_23656_Billing_Services_Settings_Data_Translations_Update_Register_UOM_Mapping()
        {
            testCaseId = "TC-23656";
            qTestUniqueId = "50724205";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMEnterValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Left Navigation_Billing Automation_Display
        [Category("BillingServices")]
        [Test]
        public void TC_23660_Billing_Services_Left_Navigation_Billing_Automation_Display()
        {
            testCaseId = "TC-23660";
            qTestUniqueId = "50745304";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateBillingAutomation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Left Navigation_Billing Automation_Access_Existing Admin
        [Category("BillingServices")]
        [Test]
        public void TC_23661_Billing_Services_Left_Navigation_Billing_Automation_Access_Existing_Admin()
        {
            testCaseId = "TC-23661";
            qTestUniqueId = "50745570";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateBillingAutomationEdit();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Left Navigation_Billing Automation_Access_Non Admin
        [Category("BillingServices")]
        [Test]
        public void TC_23662_Billing_Services_Left_Navigation_Billing_Automation_Access_Non_Admin()
        {
            testCaseId = "TC-23662";
            qTestUniqueId = "50745987";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateBillingAutomationEdit();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Left Navigation_Billing Automation_Fields
        [Category("BillingServices")]
        [Test]
        public void TC_23663_Billing_Services_Left_Navigation_Billing_Automation_Fields()
        {
            testCaseId = "TC-23663";
            qTestUniqueId = "50746110";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateBillingAutomationFields();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Automation_Active Route Preference_hover text
        [Category("BillingServices")]
        [Test]
        public void TC_23664_Billing_Services_Billing_Automation_Active_Route_Preference_hover_text()
        {
            testCaseId = "TC-23664";
            qTestUniqueId = "50746224";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateBillingAutomationOpenRouteHover();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test method for Billing Services_Billing Automation_SFTP Configuration_hover text
        [Category("BillingServices")]
        [Test]
        public void TC_23665_Billing_Services_Billing_Automation_SFTP_Configuration_hover_text()
        {
            testCaseId = "TC-23665";
            qTestUniqueId = "50746252";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateBillingAutomationSftpConfigHover();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Automation_Copy Import Error Logs to SFTP_hover text
        [Category("BillingServices")]
        [Test]
        public void TC_23666_Billing_Services_Billing_Automation_Copy_Import_Error_Logs_to_SFTP_hover_text()
        {
            testCaseId = "TC-23666";
            qTestUniqueId = "50746253";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateBillingAutomationimportErrorHover();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test method for Billing Services_Billing Automation_Export to SFTP_hover text
        [Category("BillingServices")]
        [Test]
        public void TC_23667_Billing_Services_Billing_Automation_Export_to_SFTP_hover_text()
        {
            testCaseId = "TC-23667";
            qTestUniqueId = "50746254";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateBillingAutomationCopyExportHover();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Update_Register UOM 
        [Category("BillingServices")]
        [Test]
        public void TC_23674_Billing_Services_Settings_Data_Translations_Update_Register_UOM()
        {
            testCaseId = "TC-23674";
            qTestUniqueId = "50760474";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMEnterValueCancel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Register UOM dialog_Placeholder_dropdown
        [Category("BillingServices")]
        [Test]
        public void TC_23676_Billing_Services_Settings_Data_Translations_Register_UOM_dialog_Placeholder_dropdown()
        {
            testCaseId = "TC-23676";
            qTestUniqueId = "50760626";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMPlaceholderDropdown();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Register UOM dialog_Placeholder_Value from last import
        [Category("BillingServices")]
        [Test]
        public void TC_23677_Billing_Services_Settings_Data_Translations_Register_UOM_dialog_Placeholder_Value_from_last_import()
        {
            testCaseId = "TC-23677";
            qTestUniqueId = "50760712";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMPlaceholderValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Register UOM dialog_Placeholder_Select_drop down value
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23678_Billing_Services_Settings_Data_Translations_Register_UOM_dialog_Placeholder_Select_drop_down_value()
        {
            testCaseId = "TC-23678";
            qTestUniqueId = "50761492";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMComboBoxPlaceholderText();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Register UOM dialog_PlaceHolder_Enter values Manually
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23679_Billing_Services_Settings_Data_Translations_Register_UOM_dialog_PlaceHolder_Enter_values_Manually()
        {
            testCaseId = "TC-23679";
            qTestUniqueId = "50761493";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMComboBoxPlaceholderClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Register UOM dialog_PlaceHolder_Enter Multiple values Manually
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23680_Billing_Services_Settings_Data_Translations_Register_UOM_dialog_PlaceHolder_Enter_Multiple_values_Manually()
        {
            testCaseId = "TC-23680";
            qTestUniqueId = "50761676";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMComboBoxPlaceholderEnterValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Register UOM dialog_PlaceHolder_Delete Value
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23681_Billing_Services_Settings_Data_Translations_Register_UOM_dialog_PlaceHolder_Delete_Value()
        {
            testCaseId = "TC-23681";
            qTestUniqueId = "50761689";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateRegisterUOMComboBoxPlaceholderDeleteValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Meter_Size dialog_PlaceHolder_Delete Value
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23682_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_PlaceHolder_Delete_Value()
        {
            testCaseId = "TC-23682";
            qTestUniqueId = "50763198";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeDeleteValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Meter Size dialog_PlaceHolder_Enter Multiple values Manually
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23683_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_PlaceHolder_Enter_Multiple_values_Manually()
        {
            testCaseId = "TC-23683";
            qTestUniqueId = "50763199";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeEnterValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Meter Size dialog_PlaceHolder_Enter Multiple values Manually
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23684_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_PlaceHolder_Enter_Multiple_values_Manually()
        {
            testCaseId = "TC-23684";
            qTestUniqueId = "50763200";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeEnterValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Meter Size dialog_Placeholder_Select_drop down value
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23685_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Placeholder_Select_drop_down_value()
        {
            testCaseId = "TC-23685";
            qTestUniqueId = "50763201";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeSelectFromDropdown();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Meter Size dialog_Placeholder_Value from last import
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23686_Billing_Services_Settings_Data_Translations_Meter_Size_dialog_Placeholder_Value_from_last_import()
        {
            testCaseId = "TC-23686";
            qTestUniqueId = "50763202";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Update_Meter Size
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23687_Billing_Services_Settings_Data_Translations_Update_Meter_Size()
        {
            testCaseId = "TC-23687";
            qTestUniqueId = "50763203";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Meter size_Mapping Values 
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23853_Billing_Services_Settings_Data_Translations_Meter_size_Mapping_Values()
        {
            testCaseId = "TC-23853";
            qTestUniqueId = "50823168";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsNeptune360Values();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Mapping Values_Customer Inquiry_Validation
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23854_Billing_Services_Settings_Data_Translations_Mapping_Values_Customer_Inquiry_Validation()
        {
            testCaseId = "TC-23854";
            qTestUniqueId = "50823418";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsMeterSize1();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Edit Mappings
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23928_Billing_Services_Settings_Data_Translations_Edit_Mappings()
        {
            testCaseId = "TC-23928";
            qTestUniqueId = "50988846";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateEditMappingsLabel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Edit Mappings Label_font and Size
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23929_Billing_Services_Settings_Data_Translations_Edit_Mappings_Label_font_and_Size()
        {
            testCaseId = "TC-23929";
            qTestUniqueId = "50989042";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateEditMappingsLabel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Edit Mappings_info bubble icon
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23930_Billing_Services_Settings_Data_Translations_Edit_Mappings_info_bubble_icon()
        {
            testCaseId = "TC-23930";
            qTestUniqueId = "50989043";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateEditMappingsLabelInfo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Edit Mappings_Text of info bubble icon
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23931_Billing_Services_Settings_Data_Translations_Edit_Mappings_Text_of_info_bubble_icon()
        {
            testCaseId = "TC-23931";
            qTestUniqueId = "50989110";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateEditMappingsLabelInfo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Automation_SFTP configuration sub-header
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23947_Billing_Services_Billing_Automation_SFTP_configuration_sub_header()
        {
            testCaseId = "TC-23947";
            qTestUniqueId = "51086331";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateSftpConfigSubHeader();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Automation_Import Automation sub-header
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23948_Billing_Services_Billing_Automation_Import_Automation_sub_header()
        {
            testCaseId = "TC-23948";
            qTestUniqueId = "51086359";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateImportAutomation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Automation_Import Automation sub-header
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23949_Billing_Services_Billing_Automation_Import_Automation_sub_header()
        {
            testCaseId = "TC-23949";
            qTestUniqueId = "51086444";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateBillingAutomationEdit();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Automation_Enable_Edit
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23963_Billing_Services_Billing_Automation_Enable_Edit()
        {
            testCaseId = "TC-23963";
            qTestUniqueId = "51123818";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateBillingAutomationEdit();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Automation_Edit Functionality
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23950_Billing_Services_Billing_Automation_Edit_Functionality()
        {
            testCaseId = "TC-23950";
            qTestUniqueId = "51086449";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateBillingAutomationEditFunctionality();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Automation_Active Route Preference_default option
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23952_Billing_Services_Billing_Automation_Active_Route_Preference_default_Option()
        {
            testCaseId = "TC-23952";
            qTestUniqueId = "51087624";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateBillingAutomationEdit();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Automation_Options_Ignore open Routes
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23953_Billing_Services_Billing_Automation_Options_Ignore_open_Routes()
        {
            testCaseId = "TC-23953";
            qTestUniqueId = "51087723";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateIgnoreOpenRoutes();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Automation_SFTP Configuration_default option
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23955_Billing_Services_Billing_Automation_SFTP_Configuration_default_option()
        {
            testCaseId = "TC-23955";
            qTestUniqueId = "51087793";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateSftpDefaultOption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Automation_Skip on open Routes
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23967_Billing_Services_Billing_Automation_Skip_on_open_Routes()
        {
            testCaseId = "TC-23967";
            qTestUniqueId = "51130338";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateSftpDefaultOption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Automation_Use SFTP File Processing
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23968_Billing_Services_Billing_Automation_Use_SFTP_File_Processing()
        {
            testCaseId = "TC-23968";
            qTestUniqueId = "51130451";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateSftpDefaultOption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test method for Billing Services_Billing Automation_Copy Import Error Logs to SFTP
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23969_Billing_Services_Billing_Automation_Copy_Import_Error_Logs_to_SFTP()
        {
            testCaseId = "TC-23969";
            qTestUniqueId = "51130499";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateCopyImportError();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Automation_Copy Export to SFTP
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23970_Billing_Services_Billing_Automation_Copy_Export_to_SFTP()
        {
            testCaseId = "TC-23970";
            qTestUniqueId = "51130500";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateCopyExporttoSFTP();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Automation_Copy Export to SFTP_Default No
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23971_Billing_Services_Billing_Automation_Copy_Export_to_SFTP_Default_No()
        {
            testCaseId = "TC-23971";
            qTestUniqueId = "51130553";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateCopyExporttoSFTPDefaultOption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Automation_Copy Import Error Logs to SFTP_Default No
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23972_Billing_Services_Billing_Automation_Copy_Import_Error_Logs_to_SFTP_Default_No()
        {
            testCaseId = "TC-23972";
            qTestUniqueId = "51130554";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateCopyImportErrorDefaultOption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test method for Billing Services_Billing Automation_Triggered by the UI
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_24046_Billing_Services_Billing_Automation_Triggered_by_the_UI()
        {
            testCaseId = "TC-24046";
            qTestUniqueId = "51314143";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateSftpDefaultOption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Access_Hover
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23256_Billing_Services_Settings_Data_Translations_Access_Hover()
        {
            testCaseId = "TC-23256";
            qTestUniqueId = "50192038";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsEditMapingHover();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations Access_Title Displays
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23257_Billing_Services_Settings_Data_Translations_Access_Title_Displays()
        {
            testCaseId = "TC-23257";
            qTestUniqueId = "50192039";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsHeading();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Displays
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23258_Billing_Services_Settings_Data_Translations_Displays()
        {
            testCaseId = "TC-23258";
            qTestUniqueId = "50192040";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateDataTranslationsDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Meter Size_Displays
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23334_Billing_Services_Settings_Data_Translations_Meter_Size_Displays()
        {
            testCaseId = "TC-23334";
            qTestUniqueId = "50307668";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeOptionDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Meter Size_Access
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23335_Billing_Services_Settings_Data_Translations_Meter_Size_Access()
        {
            testCaseId = "TC-23335";
            qTestUniqueId = "50307702";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeOptionAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Meter Size_Title
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23336_Billing_Services_Settings_Data_Translations_Meter_Size_Title()
        {
            testCaseId = "TC-23336";
            qTestUniqueId = "50307705";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Meter Size Mapping dialog_Cancel_Access
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23337_Billing_Services_Settings_Data_Translations_Meter_Size_Mapping_dialog_Cancel_Access()
        {
            testCaseId = "TC-23337";
            qTestUniqueId = "50307729";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Meter Size Mapping dialog_Close(X)_Access
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23338_Billing_Services_Settings_Data_Translations_Meter_Size_Mapping_dialog_Close_Access()
        {
            testCaseId = "TC-23338";
            qTestUniqueId = "50307730";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeCloseAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Meter Size Mapping dialog_Neptune 360 value_Column_Display
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23339_Billing_Services_Settings_Data_Translations_Meter_Size_Mapping_dialog_Neptune360_value_Column_Display()
        {
            testCaseId = "TC-23339";
            qTestUniqueId = "50307784";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeNeptune360Value();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_Data Translations_Meter Size Mapping dialog_Utility values_Column_Display
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23340_Billing_Services_Settings_Data_Translations_Meter_Size_Mapping_dialog_Utility_values_Column_Display()
        {
            testCaseId = "TC-23340";
            qTestUniqueId = "50307785";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateMeterSizeUtilityDialogue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Import Rules_Edit_Cancel Button_Access
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23142_Billing_Services_Import_Rules_Edit_Cancel_Button_Access()
        {
            testCaseId = "TC-23142";
            qTestUniqueId = "49989683";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateImportRulesEditCancel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Left Navigation_Billing Services Settings_Display
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20994_Billing_Services_Left_Navigation_Billing_Services_Settings_Display()
        {
            testCaseId = "TC-20994";
            qTestUniqueId = "45898446";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);                
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Left Navigation_Billing Services Settings_Click
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20995_Billing_Services_Left_Navigation_Billing_Services_Settings_Click()
        {
            testCaseId = "TC-20995";
            qTestUniqueId = "45898454";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Services Settings_Export Rules_Access
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21105_Billing_Services_Billing_Services_Settings_Export_Rules_Access()
        {
            testCaseId = "TC-21105";
            qTestUniqueId = "46065000";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateExportRulesAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Services Settings_Export Rules_View Details
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21106_Billing_Services_Billing_Services_Settings_Export_Rules_View_Details()
        {
            testCaseId = "TC-21106";
            qTestUniqueId = "46065001";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateExportRulesAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test method for Billing Services_Billing Services Settings_Export Rules_Edit button_Display
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21107_Billing_Services_Billing_Services_Settings_Export_Rules_Edit_button_Display()
        {
            testCaseId = "TC-21107";
            qTestUniqueId = "46065002";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateExportRulesEditButtonDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Services Settings_Export Rules_Edit button_Access
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21108_Billing_Services_Billing_Services_Settings_Export_Rules_Edit_button_Access()
        {
            testCaseId = "TC-21108";
            qTestUniqueId = "46065003";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateExportRulesEditButtonAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Services Settings_Export Rules_Edit Save button_Access
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21109_Billing_Services_Billing_Services_Settings_Export_Rules_Edit_Save_button_Access()
        {
            testCaseId = "TC-21109";
            qTestUniqueId = "46065004";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateExportRulesEditButtonSave();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Services Settings_Export Rules_Edit Cancel button_Access
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21110_Billing_Services_Billing_Services_Settings_Export_Rules_Edit_Cancel_button_Access()
        {
            testCaseId = "TC-21110";
            qTestUniqueId = "46065005";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateExportRulesEditButtonCancel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Services Settings_General Rules_Edit_Cancel Button_Access
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21345_Billing_Services_Billing_Services_Settings_General_Rules_Edit_Cancel_Button_Access()
        {
            testCaseId = "TC-21345";
            qTestUniqueId = "46981543";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateExportRulesEditButtonCancel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Services Settings_General Rules_Edit_Save Button_Access
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21346_Billing_Services_Billing_Services_Settings_General_Rules_Edit_Save_Button_Access()
        {
            testCaseId = "TC-21346";
            qTestUniqueId = "46981544";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateGeneralRulesEditButtonSave();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Services Settings_General Rules_Edit button_Access
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21347_Billing_Services_Billing_Services_Settings_General_Rules_Edit_button_Access()
        {
            testCaseId = "TC-21347";
            qTestUniqueId = "46981545";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateGeneralRulesEditButtonAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Services Settings_General Rules_Edit button_Display
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21348_Billing_Services_Billing_Services_Settings_General_Rules_Edit_button_Display()
        {
            testCaseId = "TC-21348";
            qTestUniqueId = "46981546";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateGeneralRulesEditButtonDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Services Settings_General Rules_View Details
        [Category("BillingServices")]
        [Test]
        public void TC_21349_Billing_Services_Billing_Services_Settings_General_Rules_View_Details()
        {
            testCaseId = "TC-21349";
            qTestUniqueId = "46981547";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateGeneralRulesDetailsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_Billing Services Settings_General Rules_Access
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21350_Billing_Services_Billing_Services_Settings_General_Rules_Access()
        {
            testCaseId = "TC-21350";
            qTestUniqueId = "46981548";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateGeneralRulesDetailsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_General Rules_View Permission_Enabled
        [Category("BillingServices")]
        [Test]
        public void TC_21360_Billing_Services_Settings_General_Rules_View_Permission_Enabled()
        {
            testCaseId = "TC-21360";
            qTestUniqueId = "47026116";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateGeneralRulesDetailsDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_General Rules_Edit Permission_Enabled
        [Category("BillingServices")]
        [Test]
        public void TC_21361_Billing_Services_Settings_General_Rules_Edit_Permission_Enabled()
        {
            testCaseId = "TC-21361";
            qTestUniqueId = "47026117";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateGeneralRulesEditButtonAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_General Rules_Edit Permission_Disabled
        [Category("BillingServices")]
        [Test]
        public void TC_21362_Billing_Services_Settings_General_Rules_Edit_Permission_Disabled()
        {
            testCaseId = "TC-21362";
            qTestUniqueId = "47026214";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateGeneralRulesEditButtonNotDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services Settings_General Rules_Edit Permission_Disabled
        [Category("BillingServices")]
        [Test]
        public void TC_21363_Billing_Services_Settings_General_Rules_Edit_Permission_Disabled()
        {
            testCaseId = "TC-21363";
            qTestUniqueId = "47026214";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavBillingServicesSettings(url, userName, password);
                billingServicesSettings.ValidateGeneralRulesEditButtonNotDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test method for Billing Services_File Mapper_Click
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15407_Billing_Services_File_Mapper_Click()
        {
            testCaseId = "TC-15407";
            qTestUniqueId = "34021561";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Title
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15408_Billing_Services_File_Mapper_Title()
        {
            testCaseId = "TC-15408";
            qTestUniqueId = "34021609";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Breadcrumb menu
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15409_Billing_Services_File_Mapper_Breadcrumb_Menu()
        {
            testCaseId = "TC-15409";
            qTestUniqueId = "34021622";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperBreadcrumb();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Single Content Panel
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15410_Billing_Services_File_Mapper_Single_Content_Panel()
        {
            testCaseId = "TC-15410";
            qTestUniqueId = "34021664";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperBreadcrumb();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Back Button_Display
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15411_Billing_Services_File_Mapper_Back_Button_Display()
        {
            testCaseId = "TC-15411";
            qTestUniqueId = "34021800";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperBackbutton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Back Button_Disabled
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15412_Billing_Services_File_Mapper_Back_Button_Disabled()
        {
            testCaseId = "TC-15412";
            qTestUniqueId = "34021810";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperBackbuttonDisabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Next Button_Display
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15413_Billing_Services_File_Mapper_Next_Button_Display()
        {
            testCaseId = "TC-15413";
            qTestUniqueId = "34021846";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperNextbuttonDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Next Button_Disabled
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15414_Billing_Services_File_Mapper_Next_Button_Disabled()
        {
            testCaseId = "TC-15414";
            qTestUniqueId = "34021847";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperNextbuttonDisabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Text Label
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15415_Billing_Services_File_Mapper_Text_Label()
        {
            testCaseId = "TC-15415";
            qTestUniqueId = "34021852";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperSourceFileText();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Text Box_Display
        [Category("BillingServices")]
        [Test]
        public void TC_15416_Billing_Services_File_Mapper_Text_Box_Display()
        {
            testCaseId = "TC-15416";
            qTestUniqueId = "34021905";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperTextBoxDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Browse Button_Display
        [Category("BillingServices")]
        [Test]
        public void TC_15417_Billing_Services_File_Mapper_Browse_Button_Display()
        {
            testCaseId = "TC-15417";
            qTestUniqueId = "34021962";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperBrowseBtnDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Below Text Box_Text Label_Display
        [Category("BillingServices")]
        [Test]
        public void TC_15418_Billing_Services_File_Mapper_Below_Text_Box_Text_Label_Display()
        {
            testCaseId = "TC-15418";
            qTestUniqueId = "34022177";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperBrowseBtnDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Text Box_Default Content
        [Category("BillingServices")]
        [Test]
        public void TC_15419_Billing_Services_File_Mapper_Text_Box_Default_Content()
        {
            testCaseId = "TC-15419";
            qTestUniqueId = "34022259";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperTextBoxDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Text Box String _Default_Disabled
        [Category("BillingServices")]
        [Test]
        public void TC_15420_Billing_Services_File_Mapper_Text_Box_String_Default_Disabled()
        {
            testCaseId = "TC-15420";
            qTestUniqueId = "34022313";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperTextBoxDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_No Source File Selected_Default
        [Category("BillingServices")]
        [Test]
        public void TC_15440_Billing_Services_File_Mapper_No_Source_File_Selected_Default()
        {
            testCaseId = "TC-15440";
            qTestUniqueId = "34049465";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperTextBoxDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Select a Mapping Configuration_Text Label_Display
        [Category("BillingServices")]
        [Test]
        public void TC_15608_Billing_Services_File_Mapper_Select_a_Mapping_Configuration_Text_Label_Display()
        {
            testCaseId = "TC-15608";
            qTestUniqueId = "34173187";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperSelectMappingConfig();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Select a Mapping Configuration_List Selector Control_Display
        [Category("BillingServices")]
        [Test]
        public void TC_15609_Billing_Services_File_Mapper_Select_a_Mapping_Configuration_List_Selector_Control_Display()
        {
            testCaseId = "TC-15609";
            qTestUniqueId = "34173188";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperSelectMappingConfig();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Select a Mapping Configuration_List Selector Control_Minimum_One item
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15610_Billing_Services_File_Mapper_Select_a_Mapping_Configuration_List_Selector_Control_Minimum_One_item()
        {
            testCaseId = "TC-15610";
            qTestUniqueId = "34173189";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperSelectMappingConfigOneItem();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test method for Billing Services_File Mapper_Select a Mapping Configuration_List Selector Controls_Default Item Selected
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15611_Billing_Services_File_Mapper_Select_a_Mapping_Configuration_List_Selector_Controls_Default_Item_Selected()
        {
            testCaseId = "TC-15611";
            qTestUniqueId = "34173190";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperSelectMappingConfigOneItem();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test method for Billing Services_File Mapper_Select a Mapping Configuration_List Selector Controls_Next Button_State
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15612_Billing_Services_File_Mapper_Select_a_Mapping_Configuration_List_Selector_Controls_Next_Button_State()
        {
            testCaseId = "TC-15612";
            qTestUniqueId = "34173191";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperSelectMappingNextBtnDisable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Select a Mapping Configuration_List Selector Controls_More Items
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15613_Billing_Services_File_Mapper_Select_a_Mapping_Configuration_List_Selector_Controls_More_Items()
        {
            testCaseId = "TC-15613";
            qTestUniqueId = "34173192";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperSelectMappingConfigOneItem();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test method for Billing Services_File Mapper_Select a Mapping Configuration_List Selector Controls_Each Item_Selected
        [Category("BillingServices")]
        [Category("BillingServices - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15614_Billing_Services_File_Mapper_Select_a_Mapping_Configuration_List_Selector_Controls_Each_Item_Selected()
        {
            testCaseId = "TC-15614";
            qTestUniqueId = "34173193";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftNavFileMapper(url, userName, password);
                fileMapper.ValidateFileMapperSelectMappingSelectEachItem();
                home.UserLogOut();
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
