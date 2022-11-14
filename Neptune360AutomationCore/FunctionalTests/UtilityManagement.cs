using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public class UtilityManagement : TestBaseTemplate
    {
        /// <summary>
        /// Test Method to Add Site ID Numeric Only - Site ID
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3880_Add_Site_ID_Numeric_Only_Site_ID()
        {
            testCaseId = "TC-3880";
            qTestUniqueId = "19318983";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateSiteIDDigits();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Add the Choose Utilities Modal - "Choose Utilities" Modal
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3933_UI_Add_the_Choose_Utilities_Modal_Choose_Utilities_Modal()
        {
            testCaseId = "TC-3933";
            qTestUniqueId = "19323213";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateChooseUtilities(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for a device - Search criteria return NO results
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3957_Search_for_a_device_Search_criteria_return_NO_results()
        {
            testCaseId = "TC-3957";
            qTestUniqueId = "19323365";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateDeviceNoResults(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Set up a collector - Auto populated fields
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3997_Set_up_a_collector_Auto_populated_fields()
        {
            testCaseId = "TC-3997";
            qTestUniqueId = "19323455";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCollectorPopulatedFields();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Set up a collector - Required Fields
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3998_Set_up_a_collector_Required_Fields()
        {
            testCaseId = "TC-3998";
            qTestUniqueId = "19323456";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCollectorRequiredFields();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Set up a collector - Non Required fields
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3999_Set_up_a_collector_Non_Required_fields()
        {
            testCaseId = "TC-3999";
            qTestUniqueId = "19323457";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCollectorNonRequiredFields();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Set up a collector - Save/ Cancel
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_4000_Set_up_a_collector_Save_Cancel()
        {
            testCaseId = "TC-4000";
            qTestUniqueId = "19323458";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorID = testData["CollectorId"];
                collectorName = testData["CollectorName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCollectorSaveCancel(collectorID, collectorName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Set_up_a_collector_Field_Validation
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4003_Set_up_a_collector_Field_Validation()
        {
            testCaseId = "TC-4003";
            qTestUniqueId = "19323461";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorID = testData["CollectorId"];
                collectorName = testData["CollectorName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateFieldValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Set up a collector - Required Information is missing
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4004_Set_up_a_collector_Required_Information_is_missing()
        {
            testCaseId = "TC-4004";
            qTestUniqueId = "19323462";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorID = testData["CollectorId"];
                collectorName = testData["CollectorName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateMissingInfo(collectorID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Set up a collector - Cancel set up collector process
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4005_Set_up_a_collector_Cancel_set_up_collector_process()
        {
            testCaseId = "TC-4005";
            qTestUniqueId = "19323463";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorID = testData["CollectorId"];
                collectorName = testData["CollectorName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCancelBtnNotPrompt(collectorID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector - Clone button Disabled
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8113_Clone_configuration_of_collector_Clone_button_Disabled()
        {
            testCaseId = "TC-8113";
            qTestUniqueId = "21418904";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCloneBtnDisabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector - Clone button
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8114_Clone_configuration_of_collector_Clone_button()
        {
            testCaseId = "TC-8114";
            qTestUniqueId = "21418905";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCollectConfigScreen();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector - Collector ID cannot be cloned
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8115_Clone_configuration_of_collector_Collector_ID_cannot_be_cloned()
        {
            testCaseId = "TC-8115";
            qTestUniqueId = "21418906";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCollectorIdCannotCloned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector - Collector name cannot be cloned
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8116_Clone_configuration_of_collector_Name_cannot_be_cloned()
        {
            testCaseId = "TC-8116";
            qTestUniqueId = "21418907";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCollectorNameCannotCloned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector - static ip cannot be cloned
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8117_Clone_configuration_of_collector_staticIP_cannot_be_cloned()
        {
            testCaseId = "TC-8117";
            qTestUniqueId = "21418908";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCollectorStaticIPCannotCloned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector - Transfer Interval is Autopopulated
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8118_Clone_configuration_of_collector_Transfer_Interval_is_Autopopulated()
        {
            testCaseId = "TC-8118";
            qTestUniqueId = "21418909";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateTransferInterval();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector - Daily Reboot is Autopopulated
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8119_Clone_configuration_of_collector_Daily_Reboot_is_Autopopulated()
        {
            testCaseId = "TC-8119";
            qTestUniqueId = "21418910";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateDailyReboot();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector - Start Time is Autopopulated
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8120_Clone_configuration_of_collector_Start_Time_is_Autopopulated()
        {
            testCaseId = "TC-8120";
            qTestUniqueId = "21418911";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateStartTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector - End Time is Autopopulated
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8121_Clone_configuration_of_collector_End_Time_is_Autopopulated()
        {
            testCaseId = "TC-8121";
            qTestUniqueId = "21418912";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEndTime();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector - WAN Connection Type is Autopopulated
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8122_Clone_configuration_of_collector_WAN_Connection_Type_is_Autopopulated()
        {
            testCaseId = "TC-8122";
            qTestUniqueId = "21418913";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateWANConnection();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector -Host IP is Autopopulated
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8123_Clone_configuration_of_collector_Host_IP_is_Autopopulated()
        {
            testCaseId = "TC-8123";
            qTestUniqueId = "21418914";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateHostIP();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector -Latitude is NOT Autopopulated
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8124_Clone_configuration_of_collector_Latitude_is_NOT_Autopopulated()
        {
            testCaseId = "TC-8124";
            qTestUniqueId = "21418915";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateLatitude();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector -Longitude is NOT Autopopulated
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8125_Clone_configuration_of_collector_Longitude_is_NOT_Autopopulated()
        {
            testCaseId = "TC-8125";
            qTestUniqueId = "21418916";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateLongitude();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Clone configuration of collector - Required fields display correctly
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8126_Clone_configuration_of_collector_Required_fields_display_correctly()
        {
            testCaseId = "TC-8126";
            qTestUniqueId = "21418917";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateMandatoryFields();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector - Non-required fields display correctly
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8127_Clone_configuration_of_collector_Non_required_fields_display_correctly()
        {
            testCaseId = "TC-8127";
            qTestUniqueId = "21418918";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorID = testData["CollectorId"];
                collectorName = testData["CollectorName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateNonMandatoryFields(collectorID, collectorName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector - Non-required fields display correctly
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8129_Clone_configuration_of_collector_Non_required_fields_display_correctly()
        {
            testCaseId = "TC-8129";
            qTestUniqueId = "21418920";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorID = testData["CollectorId"];
                collectorName = testData["CollectorName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateNewCollectorSaved(collectorID, collectorName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector - The new collector clone is included in the Device list
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8130_Clone_configuration_of_collector_The_new_collector_clone_is_included_in_the_Device_list()
        {
            testCaseId = "TC-8130";
            qTestUniqueId = "21418921";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorID = testData["CollectorId"];
                collectorName = testData["CollectorName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateNewCollectorinList(collectorID, collectorName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector - Cancel cloning a collector
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8131_Clone_configuration_of_collector_Cancel_cloning_a_collector()
        {
            testCaseId = "TC-8131";
            qTestUniqueId = "21418922";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorID = testData["CollectorId"];
                collectorName = testData["CollectorName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateNewCollectorCancel(collectorID, collectorName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Clone configuration of collector - Cancel - New collector not included in the Device list if cancelled
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8132_Clone_configuration_of_collector_Cancel_New_collector_not_included_in_the_Device_list_if_cancelled()
        {
            testCaseId = "TC-8132";
            qTestUniqueId = "21418924";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorID = testData["CollectorId"];
                collectorName = testData["CollectorName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateNewCollectorNotSaved(collectorID, collectorName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - set-up a Gateway - Create Gateway
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4022_UI_set_up_a_Gateway_Create_Gateway()
        {
            testCaseId = "TC-4022";
            qTestUniqueId = "19323480";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateGateway();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Delete a device - Selects to Delete
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3978_Delete_a_device_Selects_to_Delete()
        {
            testCaseId = "TC-3978";
            qTestUniqueId = "19323436";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateDeleteDevice();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Delete a device - Confirm Deletion
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3979_Delete_a_device_Confirm_Deletion()
        {
            testCaseId = "TC-3979";
            qTestUniqueId = "19323437";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateDeleteConfirmation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Delete a device - Does NOT Confirm Deletion
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3980_Delete_a_device_Does_NOT_Confirm_Deletion()
        {
            testCaseId = "TC-3980";
            qTestUniqueId = "19323438";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateDeleteNoConfirmation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Create a new Utility - Utility Name required
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3567_Create_a_new_Utility_Utility_Name_required()
        {
            testCaseId = "TC-3567";
            qTestUniqueId = "19238180";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a new Utility - Utility name must be unique
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3569_Create_a_new_Utility_Utility_name_must_be_unique()
        {
            testCaseId = "TC-3569";
            qTestUniqueId = "19238182";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                siteID = testData["SiteID"];
                address = testData["Address"];
                city = testData["City"];
                zip = testData["ZipCode"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUniqueUtilityName(utilityName, siteID, address, city, zip);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Create a new Utility - Messaging - When Utility Name already exists
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3570_Create_a_new_Utility_Messaging_When_Utility_Name_already_exists()
        {
            testCaseId = "TC-3570";
            qTestUniqueId = "19238183";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                siteID = testData["SiteID"];
                address = testData["Address"];
                city = testData["City"];
                zip = testData["ZipCode"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUniqueUtilityName(utilityName, siteID, address, city, zip);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a new Utility - Creating a Utility can be cancelled
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3572_Create_a_new_Utility_Creating_a_Utility_can_be_cancelled()
        {
            testCaseId = "TC-3572";
            qTestUniqueId = "19238185";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                siteID = testData["SiteID"];
                address = testData["Address"];
                city = testData["City"];
                zip = testData["ZipCode"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilityCancel(utilityName, siteID, address, city, zip);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a new Utility - Creating a Utility can be cancelled
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3573_Create_a_new_Utility_Utility_Name_boundary_testing()
        {
            testCaseId = "TC-3573";
            qTestUniqueId = "19238186";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityNameCharacters(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a Utility - Verify confirmation pop-up and Verbiage
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3574_Create_a_Utility_Verify_confirmation_pop_up_and_Verbiage()
        {
            testCaseId = "TC-3574";
            qTestUniqueId = "19238187";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                siteID = testData["SiteID"];
                address = testData["Address"];
                city = testData["City"];
                zip = testData["ZipCode"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilitySave(utilityName, siteID, address, city, zip);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a new Utility - Utility Name Special characters
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3575_Create_a_new_Utility_Utility_Name_Special_characters()
        {
            testCaseId = "TC-3575";
            qTestUniqueId = "19238188";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                siteID = testData["SiteID"];
                address = testData["Address"];
                city = testData["City"];
                zip = testData["ZipCode"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilitySpecialCharSave(utilityName, siteID, address, city, zip);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management - UI - Edit Existing Code - Edit button and View
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3754_Code_Management_UI_Edit_Existing_Code_Edit_button_and_View()
        {
            testCaseId = "TC-3754";
            qTestUniqueId = "19238548";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditBtn();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management - UI - Edit Existing Code - Ability to update one or more data
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3755_Code_Management_UI_Edit_Existing_Code_Ability_to_update_one_or_more_data()
        {
            testCaseId = "TC-3755";
            qTestUniqueId = "19238549";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCodeEditScreen();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management - UI - Edit Existing Code - Done
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3757_Code_Management_UI_Edit_Existing_Code_Done()
        {
            testCaseId = "TC-3757";
            qTestUniqueId = "19238551";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateExistingCodeEdit();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management - UI - View and Filter Codes - Columns
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3759_Code_Management_UI_View_and_Filter_Codes_Columns()
        {
            testCaseId = "TC-3759";
            qTestUniqueId = "19238553";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateTypeAvailable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management - UI - View and Filter Codes - Type filter
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3760_Code_Management_UI_View_and_Filter_Codes_Type_filter()
        {
            testCaseId = "TC-3760";
            qTestUniqueId = "19238554";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateTypeFilterAvailable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management - UI - View and Filter Codes - Select a Type, Clear, and Filter
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3761_Code_Management_UI_View_and_Filter_Codes_Select_a_Type_Clear_and_Filter()
        {
            testCaseId = "TC-3761";
            qTestUniqueId = "19238555";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateTypeClearFilter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management: Delete Existing Code - Delete Button
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3780_Code_Management_Delete_Existing_Code_Delete_Button()
        {
            testCaseId = "TC-3780";
            qTestUniqueId = "19238602";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateDeleteBtn();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management: Delete Existing Code - Confirmation Message
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3781_Code_Management_Delete_Existing_Code_Confirmation_Message()
        {
            testCaseId = "TC-3781";
            qTestUniqueId = "19238603";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateDeleteBtn();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management: Delete Existing Code - Delete Successful
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3782_Code_Management_Delete_Existing_Code_Delete_Successful()
        {
            testCaseId = "TC-3782";
            qTestUniqueId = "19238604";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCodeDeleteConfirmation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Edit a collector - utility - Edit Name and Save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3991_UI_Edit_a_collector_utility_Edit_Name_and_Save()
        {
            testCaseId = "TC-3991";
            qTestUniqueId = "19323449";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorName = testData["CollectorName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityName(collectorName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Edit a collector - utility - Special character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3994_UI_Edit_a_collector_utility_Special_character()
        {
            testCaseId = "TC-3994";
            qTestUniqueId = "19323452";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorName = testData["CollectorName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityNameSpecialChars(collectorName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UI - Edit a collector - utility - Null name
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3995_UI_Edit_a_collector_utility_Null_name()
        {
            testCaseId = "TC-3995";
            qTestUniqueId = "19323453";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityNullName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to NextGen - 131 Update a Utility - Ability to update existing Utility Name
        /// </summary>
        [Test]
        public void TC_3584_NextGen_131_Update_a_Utility_Ability_to_update_existing_Utility_Name()
        {
            testCaseId = "TC-3584";
            qTestUniqueId = "19238197";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditExistingUtilityName(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to NextGen - 131 Update a Utility - Updating Utility Name still needs to be Unique
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3586_NextGen_131_Update_a_Utility_Updating_Utility_Name_still_needs_to_be_Unique()
        {
            testCaseId = "TC-3586";
            qTestUniqueId = "19238199";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                utility_Name = testData["SecondUtility"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditExistingUtilityNameUnique(utilityName, utility_Name);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to NextGen - 131 Update a Utility - Updating Utility Name still needs to be Unique
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3587_NextGen_131_Update_a_Utility_Updated_Utility_name_is_reflected_in_List_of_Utilities()
        {
            testCaseId = "TC-3587";
            qTestUniqueId = "19238200";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                utility_Name = testData["SecondUtility"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditExistingUtilityName(utilityName, utility_Name);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to NextGen - 131 ***Update a Utility - Verify Confirmation pop-up and verbiage***
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3588_NextGen_131_Update_a_Utility_Verify_Confirmation_pop_up_and_verbiage()
        {
            testCaseId = "TC-3588";
            qTestUniqueId = "19238201";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                city = testData["City"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityPopup(utilityName, city);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to NextGen - 131 Update a Utility - Updating a Utility can be cancelled
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3589_NextGen_131_Update_a_Utility_Updating_a_Utility_can_be_cancelled()
        {
            testCaseId = "TC-3589";
            qTestUniqueId = "19238202";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                city = testData["City"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityCancelled(utilityName, city);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to NextGen - 131 Edit Utility - Save - Modal 
        /// 
        /// 
        /// s
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_7839_NextGen_131_Edit_Utility_Save_Modal_Closes()
        {
            testCaseId = "TC-7839";
            qTestUniqueId = "20008473";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                city = testData["City"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtiityModalCloses(city);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to NextGen - 437 ***Search for Utility - Searching using multiple search criteria***
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3593_NextGen_437_Search_for_Utility_Searching_using_multiple_search_criteria()
        {
            testCaseId = "TC-3593";
            qTestUniqueId = "19238206";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidatePartialUtilitySearch(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to NextGen - 437 Search for Utility - Messaging - Search - No utilities returned
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3594_NextGen_437_Search_for_Utility_Messaging_Search_No_utilities_returned()
        {
            testCaseId = "TC-3594";
            qTestUniqueId = "19238207";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateNoUtilityReturned(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to NextGen - 133 View List of Utilities - View all Utilities available
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3599_NextGen_133_View_List_of_Utilities_View_all_Utilities_available()
        {
            testCaseId = "TC-3599";
            qTestUniqueId = "19238212";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateAllUtilitiesVisible();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Set a UTC offset/Time Zone for a Utility - Ability to choose utility to set UTC offset/time zone
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3637_Set_a_UTC_offset_Time_Zone_for_a_Utility_Ability_to_choose_utility_to_set_UTC_offset_time_zone()
        {
            testCaseId = "TC-3637";
            qTestUniqueId = "19238372";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateOffsetTimeTimezone();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Set a Set a UTC offset/Time Zone for a Utility - Ability to select Time Zones
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3639_Set_a_UTC_offset_Time_Zone_for_a_Utility_Ability_to_select_Time_Zones()
        {
            testCaseId = "TC-3639";
            qTestUniqueId = "19238374";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateOffsetTimeZone();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Set a UTC offset/Time Zone for a Utility - Ability to save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3641_Set_a_UTC_offset_Time_Zone_for_a_Utility_Ability_to_save()
        {
            testCaseId = "TC-3641";
            qTestUniqueId = "19238376";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateOffset();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Set a UTC offset/Time Zone for a Utility - Messaging - Confirmation message
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3643_Set_a_UTC_offset_Time_Zone_for_a_Utility_Messaging_Confirmation_message()
        {
            testCaseId = "TC-3643";
            qTestUniqueId = "19238378";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                siteID = testData["SiteID"];
                address = testData["Address"];
                city = testData["City"];
                zip = testData["ZipCode"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilityTimeZoneConfirmation(utilityName, siteID, address, city, zip);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Skip Code_1 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8780_Code_Management_Create_Skip_Code_1_numeric_character()
        {
            testCaseId = "TC-8780";
            qTestUniqueId = "24443130";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateSkipCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Skip Code_2 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8781_Code_Management_Create_Skip_Code_2_numeric_character()
        {
            testCaseId = "TC-8781";
            qTestUniqueId = "24443131";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateSkipCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Skip Code_3 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8782_Code_Management_Create_Skip_Code_3_numeric_character()
        {
            testCaseId = "TC-8782";
            qTestUniqueId = "24443132";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateSkipCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Skip Code_4 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8783_Code_Management_Create_Skip_Code_4_numeric_character()
        {
            testCaseId = "TC-8783";
            qTestUniqueId = "24443133";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateSkipCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Skip Code_1 alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8784_Code_Management_Create_Skip_Code_1_alpha_character()
        {
            testCaseId = "TC-8784";
            qTestUniqueId = "24443134";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateSkipCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Skip Code_2 alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8785_Code_Management_Create_Skip_Code_2_alpha_character()
        {
            testCaseId = "TC-8785";
            qTestUniqueId = "24443135";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateSkipCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Skip Code_3 alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8786_Code_Management_Create_Skip_Code_3_alpha_character()
        {
            testCaseId = "TC-8786";
            qTestUniqueId = "24443136";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateSkipCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Skip Code_4 alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8787_Code_Management_Create_Skip_Code_4_alpha_character()
        {
            testCaseId = "TC-8787";
            qTestUniqueId = "24443137";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateSkipCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Skip Code_2 alpha numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8788_Code_Management_Create_Skip_Code_2_alpha_numeric_character()
        {
            testCaseId = "TC-8788";
            qTestUniqueId = "24443138";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateSkipCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Skip Code_3 alpha numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8789_Code_Management_Create_Skip_Code_3_alpha_numeric_character()
        {
            testCaseId = "TC-8789";
            qTestUniqueId = "24443139";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateSkipCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Skip Code_4 alpha numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8790_Code_Management_Create_Skip_Code_4_alpha_numeric_character()
        {
            testCaseId = "TC-8790";
            qTestUniqueId = "24443140";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateSkipCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Skip Code_Duplicate Code
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8791_Code_Management_Create_Skip_Code_Duplicate_Code()
        {
            testCaseId = "TC-8791";
            qTestUniqueId = "24443141";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateDuplicateSkipCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Skip Code_Code Blank
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8792_Code_Management_Create_Skip_Code_Code_Blank()
        {
            testCaseId = "TC-8792";
            qTestUniqueId = "24443142";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateDuplicateSkipCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Skip Code_Description Blank
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8793_Code_Management_Create_Skip_Code_Description_Blank()
        {
            testCaseId = "TC-8793";
            qTestUniqueId = "24443143";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateSkipCodeBlankDesc(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Meter Condition Code_1 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8794_Code_Management_Create_Meter_Condition_Code_1_numeric_character()
        {
            testCaseId = "TC-8794";
            qTestUniqueId = "24443144";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateMeterCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Meter Condition Code_2 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8795_Code_Management_Create_Meter_Condition_Code_2_numeric_character()
        {
            testCaseId = "TC-8795";
            qTestUniqueId = "24443145";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateMeterCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Meter Condition Code_3 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8796_Code_Management_Create_Meter_Condition_Code_3_numeric_character()
        {
            testCaseId = "TC-8796";
            qTestUniqueId = "24443146";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateMeterCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Meter Condition Code_4 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8797_Code_Management_Create_Meter_Condition_Code_4_numeric_character()
        {
            testCaseId = "TC-8797";
            qTestUniqueId = "24443147";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateMeterCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Meter Condition Code_1 alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8798_Code_Management_Create_Meter_Condition_Code_1_alpha_character()
        {
            testCaseId = "TC-8798";
            qTestUniqueId = "24443148";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateMeterCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Meter Condition Code_2 alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8799_Code_Management_Create_Meter_Condition_Code_2_alpha_character()
        {
            testCaseId = "TC-8799";
            qTestUniqueId = "24443149";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateMeterCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Meter Condition Code_3 alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8800_Code_Management_Create_Meter_Condition_Code_3_alpha_character()
        {
            testCaseId = "TC-8800";
            qTestUniqueId = "24443150";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateMeterCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Meter Condition Code_4 alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8801_Code_Management_Create_Meter_Condition_Code_4_alpha_character()
        {
            testCaseId = "TC-8801";
            qTestUniqueId = "24443151";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateMeterCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Meter Condition Code_2 alpha/numeric characters
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8802_Code_Management_Create_Meter_Condition_Code_2_alpha_numeric_characters()
        {
            testCaseId = "TC-8802";
            qTestUniqueId = "24443152";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateMeterCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Meter Condition Code_3 alpha/numeric characters
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8803_Code_Management_Create_Meter_Condition_Code_3_alpha_numeric_characters()
        {
            testCaseId = "TC-8803";
            qTestUniqueId = "24443153";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateMeterCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Meter Condition Code_4 alpha/numeric characters
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8804_Code_Management_Create_Meter_Condition_Code_4_alpha_numeric_characters()
        {
            testCaseId = "TC-8804";
            qTestUniqueId = "24443154";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateMeterCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Meter Condition duplicate code
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8805_Code_Management_Create_Meter_Condition_Duplicate_Code()
        {
            testCaseId = "TC-8805";
            qTestUniqueId = "24443155";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateMeterCodeDuplicate(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Meter Condition blank code
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8806_Code_Management_Create_Meter_Condition_Blank_Code()
        {
            testCaseId = "TC-8806";
            qTestUniqueId = "24443156";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateMeterCodeDuplicate(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Meter Condition Description blank
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8807_Code_Management_Create_Meter_Condition_Description_Blank()
        {
            testCaseId = "TC-8807";
            qTestUniqueId = "24443157";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateMeterCodeBlankDesc(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Read Instruction Code_1 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8808_Code_Management_Create_Read_Instruction_Code_1_numeric_character()
        {
            testCaseId = "TC-8808";
            qTestUniqueId = "24443158";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateReadInst(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Read Instruction Code_2 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8809_Code_Management_Create_Read_Instruction_Code_2_numeric_character()
        {
            testCaseId = "TC-8809";
            qTestUniqueId = "24443159";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateReadInst(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Read Instruction Code_3 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8810_Code_Management_Create_Read_Instruction_Code_3_numeric_character()
        {
            testCaseId = "TC-8810";
            qTestUniqueId = "24443160";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateReadInst(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Read Instruction Code_4 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8811_Code_Management_Create_Read_Instruction_Code_4_numeric_character()
        {
            testCaseId = "TC-8811";
            qTestUniqueId = "24443161";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateReadInst(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Read Instruction Code_1_alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8812_Code_Management_Create_Read_Instruction_Code_1_alpha_character()
        {
            testCaseId = "TC-8812";
            qTestUniqueId = "24443162";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateReadInst(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Read Instruction Code_2_alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8813_Code_Management_Create_Read_Instruction_Code_2_alpha_character()
        {
            testCaseId = "TC-8813";
            qTestUniqueId = "24443163";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateReadInst(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Read Instruction Code_3_alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8814_Code_Management_Create_Read_Instruction_Code_3_alpha_character()
        {
            testCaseId = "TC-8814";
            qTestUniqueId = "24443164";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateReadInst(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Read Instruction Code_4_alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8815_Code_Management_Create_Read_Instruction_Code_4_alpha_character()
        {
            testCaseId = "TC-8815";
            qTestUniqueId = "24443165";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateReadInst(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Read Instruction Code_2_alpha numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8816_Code_Management_Create_Read_Instruction_Code_2_alpha_numeric_character()
        {
            testCaseId = "TC-8816";
            qTestUniqueId = "24443166";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateReadInst(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Read Instruction Code_3_alpha numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8817_Code_Management_Create_Read_Instruction_Code_3_alpha_numeric_character()
        {
            testCaseId = "TC-8817";
            qTestUniqueId = "24443167";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateReadInst(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Code Management_Create_Read Instruction Code_4_alpha numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8818_Code_Management_Create_Read_Instruction_Code_4_alpha_numeric_character()
        {
            testCaseId = "TC-8818";
            qTestUniqueId = "24443168";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateReadInst(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Read Instruction duplicate code
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8819_Code_Management_Create_Read_Instruction_Code_Duplicate_Code()
        {
            testCaseId = "TC-8819";
            qTestUniqueId = "24443169";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateReadInstDuplicate(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Read Instruction Blank code
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8820_Code_Management_Create_Read_Instruction_Code_Blank_Code()
        {
            testCaseId = "TC-8820";
            qTestUniqueId = "24443170";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateReadInstBlankCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Read Instruction Blank code
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8821_Code_Management_Create_Read_Instruction_Code_Description_Blank()
        {
            testCaseId = "TC-8821";
            qTestUniqueId = "24443171";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateReadInstBlankDesc(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Comment Code_1 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8822_Code_Management_Create_Comment_Code_1_Numeric_Character()
        {
            testCaseId = "TC-8822";
            qTestUniqueId = "24443172";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateCommentCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Code Management_Create_Comment Code_2 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8823_Code_Management_Create_Comment_Code_2_Numeric_Character()
        {
            testCaseId = "TC-8823";
            qTestUniqueId = "24443173";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateCommentCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Comment Code_3 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8824_Code_Management_Create_Comment_Code_3_Numeric_Character()
        {
            testCaseId = "TC-8824";
            qTestUniqueId = "24443174";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateCommentCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Comment Code_4 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8825_Code_Management_Create_Comment_Code_4_Numeric_Character()
        {
            testCaseId = "TC-8825";
            qTestUniqueId = "24443175";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateCommentCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Code Management_Create_Comment Code_1 alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8826_Code_Management_Create_Comment_Code_1_Alpha_Character()
        {
            testCaseId = "TC-8826";
            qTestUniqueId = "24443176";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateCommentCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Comment Code_2 alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8827_Code_Management_Create_Comment_Code_2_Alpha_Character()
        {
            testCaseId = "TC-8827";
            qTestUniqueId = "24443177";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateCommentCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Comment Code_3 alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8828_Code_Management_Create_Comment_Code_3_Alpha_Character()
        {
            testCaseId = "TC-8828";
            qTestUniqueId = "24443178";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateCommentCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Comment Code_4 alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8829_Code_Management_Create_Comment_Code_4_Alpha_Character()
        {
            testCaseId = "TC-8829";
            qTestUniqueId = "24443179";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateCommentCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Comment Code_2 alpha numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8830_Code_Management_Create_Comment_Code_2_Alpha_Numeric_Character()
        {
            testCaseId = "TC-8830";
            qTestUniqueId = "24443180";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateCommentCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Comment Code_3 alpha numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8831_Code_Management_Create_Comment_Code_3_Alpha_Numeric_Character()
        {
            testCaseId = "TC-8831";
            qTestUniqueId = "24443181";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateCommentCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Comment Code_4 alpha numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8832_Code_Management_Create_Comment_Code_4_Alpha_Numeric_Character()
        {
            testCaseId = "TC-8832";
            qTestUniqueId = "24443182";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateCommentCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Comment Code Duplicate
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8833_Code_Management_Create_Comment_Code_Duplicate()
        {
            testCaseId = "TC-8833";
            qTestUniqueId = "24443183";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateDuplicateCommtCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Comment Code Blank
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8834_Code_Management_Create_Comment_Code_Blank()
        {
            testCaseId = "TC-8834";
            qTestUniqueId = "24443184";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateCommentBlankCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Comment Description Blank
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8835_Code_Management_Create_Comment_Description_Blank()
        {
            testCaseId = "TC-8835";
            qTestUniqueId = "24443185";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateCommentBlankDesc(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Code Management_Create_Hazard Code_1 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8836_Code_Management_Create_Hazard_Code_1_numeric_character()
        {
            testCaseId = "TC-8836";
            qTestUniqueId = "24443186";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateHazardCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Hazard Code_2 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8837_Code_Management_Create_Hazard_Code_2_numeric_character()
        {
            testCaseId = "TC-8837";
            qTestUniqueId = "24443187";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateHazardCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Hazard Code_3 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8838_Code_Management_Create_Hazard_Code_3_numeric_character()
        {
            testCaseId = "TC-8838";
            qTestUniqueId = "24443188";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateHazardCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Hazard Code_4 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8839_Code_Management_Create_Hazard_Code_4_numeric_character()
        {
            testCaseId = "TC-8839";
            qTestUniqueId = "24443189";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateHazardCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Hazard Code_1 aplha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8840_Code_Management_Create_Hazard_Code_1_alpha_character()
        {
            testCaseId = "TC-8840";
            qTestUniqueId = "24443190";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateHazardCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Hazard Code_2 aplha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8841_Code_Management_Create_Hazard_Code_2_alpha_character()
        {
            testCaseId = "TC-8841";
            qTestUniqueId = "24443191";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateHazardCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Code Management_Create_Hazard Code_3 aplha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8842_Code_Management_Create_Hazard_Code_3_alpha_character()
        {
            testCaseId = "TC-8842";
            qTestUniqueId = "24443192";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateHazardCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Hazard Code_4 aplha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8843_Code_Management_Create_Hazard_Code_4_alpha_character()
        {
            testCaseId = "TC-8843";
            qTestUniqueId = "24443193";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateHazardCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Hazard Code_2 aplha numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8844_Code_Management_Create_Hazard_Code_2_alpha_Numeric_character()
        {
            testCaseId = "TC-8844";
            qTestUniqueId = "24443194";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateHazardCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Hazard Code_3 aplha numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8845_Code_Management_Create_Hazard_Code_3_alpha_Numeric_character()
        {
            testCaseId = "TC-8845";
            qTestUniqueId = "24443195";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateHazardCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Hazard Code_4 aplha numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8846_Code_Management_Create_Hazard_Code_4_alpha_Numeric_character()
        {
            testCaseId = "TC-8846";
            qTestUniqueId = "24443196";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateHazardCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Hazard Code_Duplicate
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8847_Code_Management_Create_Hazard_Code_Duplicate()
        {
            testCaseId = "TC-8847";
            qTestUniqueId = "24443197";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateDuplicateHazardCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Code Management_Create_Hazard Code_Blank
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8848_Code_Management_Create_Hazard_Code_Blank()
        {
            testCaseId = "TC-8848";
            qTestUniqueId = "24443198";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateHazrdCodeBlank(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Hazard Code_Blank Desription
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8849_Code_Management_Create_Hazard_Code_Blank_Desription()
        {
            testCaseId = "TC-8849";
            qTestUniqueId = "24443199";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateHazrdCodeBlankDesc(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Location Codes_1 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8850_Code_Management_Create_Location_Codes_1_numeric_character()
        {
            testCaseId = "TC-8850";
            qTestUniqueId = "24443200";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateLocationCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Location Codes_2 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8851_Code_Management_Create_Location_Codes_2_numeric_character()
        {
            testCaseId = "TC-8851";
            qTestUniqueId = "24443201";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateLocationCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Code Management_Create_Location Codes_3 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8852_Code_Management_Create_Location_Codes_3_numeric_character()
        {
            testCaseId = "TC-8852";
            qTestUniqueId = "24443202";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateLocationCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Location Codes_4 numeric character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8853_Code_Management_Create_Location_Codes_4_numeric_character()
        {
            testCaseId = "TC-8853";
            qTestUniqueId = "24443203";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateLocationCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Code Management_Create_Location Codes_1 alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8854_Code_Management_Create_Location_Codes_1_alpha_character()
        {
            testCaseId = "TC-8854";
            qTestUniqueId = "24443204";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateLocationCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Location Codes_2 alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8855_Code_Management_Create_Location_Codes_2_alpha_character()
        {
            testCaseId = "TC-8855";
            qTestUniqueId = "24443205";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateLocationCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Location Codes_3 alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8856_Code_Management_Create_Location_Codes_3_alpha_character()
        {
            testCaseId = "TC-8856";
            qTestUniqueId = "24443206";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateLocationCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Location Codes_4 alpha character
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8857_Code_Management_Create_Location_Codes_4_alpha_character()
        {
            testCaseId = "TC-8857";
            qTestUniqueId = "24443207";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateLocationCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Location Codes_2 alpha  Numericcharacter
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8858_Code_Management_Create_Location_Codes_2_alpha_Numeric_character()
        {
            testCaseId = "TC-8858";
            qTestUniqueId = "24443208";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateLocationCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Location Codes_3 alpha  Numericcharacter
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8859_Code_Management_Create_Location_Codes_3_alpha_Numeric_character()
        {
            testCaseId = "TC-8859";
            qTestUniqueId = "24443209";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateLocationCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Location Codes_4 alpha  Numericcharacter
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8860_Code_Management_Create_Location_Codes_4_alpha_Numeric_character()
        {
            testCaseId = "TC-8860";
            qTestUniqueId = "24443210";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateLocationCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Location Codes_duplicate 
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8861_Code_Management_Create_Location_Codes_Duplicate()
        {
            testCaseId = "TC-8861";
            qTestUniqueId = "24443211";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateDuplicateLocationCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Location Code BLANK 
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8862_Code_Management_Create_Location_Code_Blank()
        {
            testCaseId = "TC-8862";
            qTestUniqueId = "24443212";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateLocationCodeBlank(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Location Code BLANK Description
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8863_Code_Management_Create_Location_Code_Blank_Description()
        {
            testCaseId = "TC-8863";
            qTestUniqueId = "24443213";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateLocationCodeBlankDesc(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Auto Refresh
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10209_Code_Management_Create_Auto_Refresh()
        {
            testCaseId = "TC-10209";
            qTestUniqueId = "24846735";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                code = testData["Code"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateLocationCode(code);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Create Utility_Default Unit of Measure_Field Displays
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10210_Create_Utility_Default_Unit_of_Measure_Field_Displays()
        {
            testCaseId = "TC-10210";
            qTestUniqueId = "24846844";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUnitOfMeasureField();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Create Utility_Default UOM_Dropdown_Cubic Feet_Displays
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10211_Create_Utility_Default_UOM_Dropdown_Cubic_Feet_Displays()
        {
            testCaseId = "TC-10211";
            qTestUniqueId = "24846845";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUnitOfMeasureCubicFeet();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Create Utility_Default UOM_Dropdown_Cubic Meter_Displays
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10212_Create_Utility_Default_UOM_Dropdown_Cubic_Meter_Displays()
        {
            testCaseId = "TC-10212";
            qTestUniqueId = "24846846";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUnitOfMeasureCubicMeter();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Create Utility_Default UOM_Dropdown_Gallons_Displays
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10213_Create_Utility_Default_UOM_Dropdown_Gallons_Displays()
        {
            testCaseId = "TC-10213";
            qTestUniqueId = "24846847";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUnitOfMeasureGallons();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Create Utility_Default UOM_Dropdown_Imperial_Gallons_Displays
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10214_Create_Utility_Default_UOM_Dropdown_Imperial_Gallons_Displays()
        {
            testCaseId = "TC-10214";
            qTestUniqueId = "24846848";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUnitOfMeasureImperialGallons();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Create Utility_Default UOM_Dropdown_Liters_Displays
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_11709_Create_Utility_Default_UOM_Dropdown_Liters_Displays()
        {
            testCaseId = "TC-11709";
            qTestUniqueId = "24958909";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUnitOfMeasureLiters();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Create Utility_Default UOM_Dropdown_Cubic Feet_Save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10215_Create_Utility_Default_UOM_Dropdown_Cubic_Feet_Save()
        {
            testCaseId = "TC-10215";
            qTestUniqueId = "24958909";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityCubicFeetSaved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Create Utility_Default UOM_Dropdown_Cubic Meter_Save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10216_Create_Utility_Default_UOM_Dropdown_Cubic_Meter_Save()
        {
            testCaseId = "TC-10216";
            qTestUniqueId = "24846850";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityCubicMeterSaved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Create Utility_Default UOM_Dropdown_Gallons_Save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10217_Create_Utility_Default_UOM_Dropdown_Gallons_Save()
        {
            testCaseId = "TC-10217";
            qTestUniqueId = "24846851";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityGallonsSaved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Create Utility_Default UOM_Dropdown_Gallons_Save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10218_Create_Utility_Default_UOM_Dropdown_Imperial_Gallons_Save()
        {
            testCaseId = "TC-10218";
            qTestUniqueId = "24846852";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityImpGallonsSaved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Create Utility_Default UOM_Dropdown_Liters_Save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_11710_Create_Utility_Default_UOM_Dropdown_Liters_Save()
        {
            testCaseId = "TC-11710";
            qTestUniqueId = "24958910";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityLitersSaved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Create Utility_Default UOM_Dropdown_Display in Order
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10219_Create_Utility_Default_UOM_Dropdown_Display_in_Order()
        {
            testCaseId = "TC-10219";
            qTestUniqueId = "24846853";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUtilityDeviceManagement(url, userName, password);
                utilityManagement.ValidateDefaultDropdown();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Update Utility_Default Unit of Measure_Field Displays
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10220_Update_Utility_Default_Unit_of_Measure_Field_Displays()
        {
            testCaseId = "TC-10220";
            qTestUniqueId = "24846854";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUOMFieldDisplayes();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Update Utility_Default UOM_Dropdown_Cubic Feet_Displays
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10221_Update_Utility_Default_UOM_Dropdown_Cubic_Feet_Displays()
        {
            testCaseId = "TC-10221";
            qTestUniqueId = "24846855";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCubicFeetDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Update Utility_Default UOM_Dropdown_Cubic Meter_Displays
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10222_Update_Utility_Default_UOM_Dropdown_Cubic_Meter_Displays()
        {
            testCaseId = "TC-10222";
            qTestUniqueId = "24846856";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCubicMeterDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Update Utility_Default UOM_Dropdown_Gallons_Displays
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10223_Update_Utility_Default_UOM_Dropdown_Gallons_Displays()
        {
            testCaseId = "TC-10223";
            qTestUniqueId = "24846857";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateGallonsDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Update Utility_Default UOM_Dropdown_Imperial_Gallons_Displays
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10224_Update_Utility_Default_UOM_Dropdown_Imperial_Gallons_Displays()
        {
            testCaseId = "TC-10224";
            qTestUniqueId = "24846858";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateImperialGallonsDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Update Utility_Default UOM_Dropdown_Liters_Displays
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_11711_Update_Utility_Default_UOM_Dropdown_Liters_Displays()
        {
            testCaseId = "TC-11711";
            qTestUniqueId = "24958911";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateLitersDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Update Utility_Default UOM_Dropdown_Cubic Feet_Save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10225_Update_Utility_Default_UOM_Dropdown_Cubic_Feet_Save()
        {
            testCaseId = "TC-10225";
            qTestUniqueId = "24846859";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityCubicFeetSaved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Update Utility_Default UOM_Dropdown_Cubic Meters_Save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10226_Update_Utility_Default_UOM_Dropdown_Cubic_Meters_Save()
        {
            testCaseId = "TC-10226";
            qTestUniqueId = "24846860";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityCubicMeterSaved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Update Utility_Default UOM_Gallons Cubic Meters_Save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10227_Update_Utility_Default_UOM_Gallons_Meters_Save()
        {
            testCaseId = "TC-10227";
            qTestUniqueId = "24846861";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityGallonsSaved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Update Utility_Default UOM_Imperial_Gallons Cubic Meters_Save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10228_Update_Utility_Default_UOM_Imperial_Gallons_Meters_Save()
        {
            testCaseId = "TC-10228";
            qTestUniqueId = "24846862";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityImpGallonsSaved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Update Utility_Default UOM_Dropdown_Liters_Save
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_11712_Update_Utility_Default_UOM_Dropdown_Liters_Save()
        {
            testCaseId = "TC-11712";
            qTestUniqueId = "24958912";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityLitersSaved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Update Utility_Default UOM_Dropdown_Display in Order
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_10229_Update_Utility_Default_UOM_Dropdown_Display_in_Order()
        {
            testCaseId = "TC-10229";
            qTestUniqueId = "24846863";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateDefaultDropdown();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Utility Management_Default UOM_Field Display
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10230_Utility_Management_Default_UOM_Field_Display()
        {
            testCaseId = "TC-10230";
            qTestUniqueId = "24846864";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUOMFieldDisplayes();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management_Default UOM_Value Display
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10231_Utility_Management_Default_UOM_Value_Display()
        {
            testCaseId = "TC-10231";
            qTestUniqueId = "24846865";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUOMValueDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management_Create_Correct Header
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_11970_Code_Management_Create_Correct_Header()
        {
            testCaseId = "TC-11970";
            qTestUniqueId = "25262078";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateCodeDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Code Management -UI - Edit Existing Code_Correct Header
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_11971_Code_Management_UI_Edit_Existing_Code_Correct_Header()
        {
            testCaseId = "TC-11971";
            qTestUniqueId = "25262104";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditExistingCode();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management - Close Route on Export Setting On - Edit Utility - Save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_12910_Utility_Management_Close_Route_on_Export_Setting_On_Edit_Utility_Save()
        {
            testCaseId = "TC-12910";
            qTestUniqueId = "27667122";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCloseRouteOnExport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management - Close Route on Export Setting defaults to Off - Create Utility
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_12912_Utility_Management_Close_Route_on_Export_Setting_defaults_to_Off_Create_Utility()
        {
            testCaseId = "TC-12912";
            qTestUniqueId = "27667124";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCloseRouteOnExportDeselected();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management - Close Route on Export Setting Off - Edit Utility - Save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_12914_Utility_Management_Close_Route_on_Export_Setting_Off_Edit_Utility_Save()
        {
            testCaseId = "TC-12914";
            qTestUniqueId = "27667126";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditCloseRouteOnExport();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management - Close Route on Export Setting Off - Create Utility - Save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_12916_Utility_Management_Close_Route_on_Export_Setting_Off_Create_Utility_Save()
        {
            testCaseId = "TC-12916";
            qTestUniqueId = "27667128";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCloseRouteOnExportSettingOff();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management - Close Route on Export Setting - Create Utility
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_12917_Utility_Management_Close_Route_on_Export_Setting_Create_Utility()
        {
            testCaseId = "TC-12917";
            qTestUniqueId = "27667129";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCloseRouteExportBtnDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management - Close Route on Export Setting - Edit Utility
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12918_Utility_Management_Close_Route_on_Export_Setting_Edit_Utility()
        {
            testCaseId = "TC-12918";
            qTestUniqueId = "27667130";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCloseRouteExportSavedDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management - Close Route on Export Setting On - Create Utility - Save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_12919_Utility_Management_Close_Route_on_Export_Setting_On_Create_Utility_Save()
        {
            testCaseId = "TC-12919";
            qTestUniqueId = "27667131";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCloseRouteExportCheckedSaved();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Apply/Don't apply UTC offset for Utility - Select to apply UTC
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3940_Apply_Dont_apply_UTC_offset_for_Utility_Select_to_apply_UTC()
        {
            testCaseId = "TC-3940";
            qTestUniqueId = "19323233";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUTCOffset();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Apply/Don't apply UTC offset for Utility - Select to Not apply UTC
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3941_Apply_Dont_apply_UTC_offset_for_Utility_Select_to_Not_apply_UTC()
        {
            testCaseId = "TC-3941";
            qTestUniqueId = "19323234";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateNotApplyUTCOffset();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Search for a device - Search criteria return results
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3956_Search_for_a_device_Search_criteria_return_results()
        {
            testCaseId = "TC-3956";
            qTestUniqueId = "19323364";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateSearchCriteria();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Add New fields for address and collector config - Create Utility Process
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4071_Add_New_fields_for_address_and_collector_config_Create_Utility_Process()
        {
            testCaseId = "TC-4071";
            qTestUniqueId = "19323550";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateNewFields();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Add New fields for address and collector config - Edit Utility Process
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4072_Add_New_fields_for_address_and_collector_config_Edit_Utility_Process()
        {
            testCaseId = "TC-4072";
            qTestUniqueId = "19323551";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateNewFieldsEdit();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Set up a collector - Validation
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_4001_Set_up_a_collector_Validation()
        {
            testCaseId = "TC-4001";
            qTestUniqueId = "19323459";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorID = testData["CollectorId"];
                collectorName = testData["CollectorName"];
                hostIP = testData["HostIP"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateCollector(collectorID, collectorName, hostIP);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Set up a collector - Validation
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_8128_Clone_configuration_of_collector_All_fields_are_validated_correctly()
        {
            testCaseId = "TC-8128";
            qTestUniqueId = "21418919";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCloneCollectorFileds();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Set up a collector - Validation
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4009_Edit_a_collector_NOT_Editable()
        {
            testCaseId = "TC-4009";
            qTestUniqueId = "19323467";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCollectorNotEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Edit a collector - Required Fields
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4010_Edit_a_collector_Required_Fields()
        {
            testCaseId = "TC-4010";
            qTestUniqueId = "19323468";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCollectorRequiredFieldsEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Edit a Collector - Non-Required Fields
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4011_Edit_a_Collector_Non_Required_Fields()
        {
            testCaseId = "TC-4011";
            qTestUniqueId = "19323469";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCollectorNonRequiredFields();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Edit a Collector - Save/ Cancel
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4012_Edit_a_Collector_Save_Cancel()
        {
            testCaseId = "TC-4012";
            qTestUniqueId = "19323470";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorName = testData["CollectorName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCollectorSaveCancelFields(collectorID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Edit a Collector - Field validations - description
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4017_Edit_a_Collector_Field_validations_description()
        {
            testCaseId = "TC-4017";
            qTestUniqueId = "19323475";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorID = testData["CollectorId"];
                collectorName = testData["CollectorName"];
                hostIP = testData["HostIP"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCollectorFieldvalidation(collectorID, collectorName, hostIP);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Edit a Collector -  Required information is missing
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4018_Edit_a_Collector_Required_information_is_missing()
        {
            testCaseId = "TC-4018";
            qTestUniqueId = "19323476";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorID = testData["CollectorId"];
                collectorName = testData["CollectorName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCollectorRequiredDetailsMissing(collectorID, collectorName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to UI - Add Device Management List for a Utility  - Ability to navigate from page to page
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3976_UI_Add_Device_Management_List_for_a_Utility_Ability_to_navigate_from_page_to_page()
        {
            testCaseId = "TC-3976";
            qTestUniqueId = "19323434";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateNavivagtePagetoPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Add Search for Utility Name or ID - Ability to enter Utility Name or ID
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3885_Add_Search_for_Utility_Name_or_ID_Ability_to_enter_Utility_Name_or_ID()
        {
            testCaseId = "TC-3885";
            qTestUniqueId = "19323163";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateSearchUtilityName(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Add Search for Utility Name or ID - Ability to perform partial search
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3886_Add_Search_for_Utility_Name_or_ID_Ability_to_perform_partial_search()
        {
            testCaseId = "TC-3886";
            qTestUniqueId = "19323164";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateSearchUtilityName(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Add Search for Utility Name or ID - No Results
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3888_Add_Search_for_Utility_Name_or_ID_No_Results()
        {
            testCaseId = "TC-3888";
            qTestUniqueId = "19323166";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateNoUtilityReturned(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Add Search for Utility Name or ID - Ability to select only one utility
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3889_Add_Search_for_Utility_Name_or_ID_Ability_to_select_only_one_utility()
        {
            testCaseId = "TC-3889";
            qTestUniqueId = "19323167";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUserSelectOneUtility(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Add Search for Utility Name or ID - OK Button
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3890_Add_Search_for_Utility_Name_or_ID_OK_Button()
        {
            testCaseId = "TC-3890";
            qTestUniqueId = "19323168";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateSearchUtilityNameOrId(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Add Search for Utility Name or ID - Ability to display all data of the selected Utility
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3891_Add_Search_for_Utility_Name_or_ID_Ability_to_display_all_data_of_the_selected_Utility()
        {
            testCaseId = "TC-3891";
            qTestUniqueId = "19323169";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateSelectedUtilityNameOrId(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Add Search for Utility Name or ID - Close Button
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3892_Add_Search_for_Utility_Name_or_ID_Close_Button()
        {
            testCaseId = "TC-3892";
            qTestUniqueId = "19323170";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityClose(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Add Search for Utility Name or ID - Clicking Ok button without selecting a Utility
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3893_Add_Search_for_Utility_name_or_ID_Clicking_Ok_button_without_selecting_a_Utility()
        {
            testCaseId = "TC-3893";
            qTestUniqueId = "19323171";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateNoUtilitySelected(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to View/Edit the Create Utility from a Modal to the Utility Management Screen - Edit Utility Screen
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3859_View_Edit_the_Create_Utility_from_a_Modal_to_the_Utility_Management_Screen_Edit_Utility_Screen()
        {
            testCaseId = "TC-3859";
            qTestUniqueId = "19317454";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityScreen();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to View/Edit the Create Utility from a Modal to the Utility Management Screen - View Mode
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3860_View_Edit_the_Create_Utility_from_a_Modal_to_the_Utility_Management_Screen_View_Mode()
        {
            testCaseId = "TC-3860";
            qTestUniqueId = "19317455";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityScreenViewMode();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to View/Edit the Create Utility from a Modal to the Utility Management Screen - Edit Button
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3861_View_Edit_the_Create_Utility_from_a_Modal_to_the_Utility_Management_Screen_Edit_Button()
        {
            testCaseId = "TC-3861";
            qTestUniqueId = "19317456";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityFieldsEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to View/Edit the Create Utility from a Modal to the Utility Management Screen - Done Button
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3862_View_Edit_the_Create_Utility_from_a_Modal_to_the_Utility_Management_Screen_Done_Button()
        {
            testCaseId = "TC-3862";
            qTestUniqueId = "19317457";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                city = testData["City"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilitySave(city);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Message displays - Utility has been configured with collector settings
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_4064_Message_displays_Utility_has_been_configured_with_collector_settings()
        {
            testCaseId = "TC-4064";
            qTestUniqueId = "19323522";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                collectorID = testData["CollectorId"];
                collectorName = testData["CollectorName"];
                hostIP = testData["HostIP"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateCollector(collectorID, collectorName, hostIP);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to UI - set-up a Gateway - Fields
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4023_UI_set_up_a_Gateway_Fields()
        {
            testCaseId = "TC-4023";
            qTestUniqueId = "19323481";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateGatewayFields();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to UI - set-up a Gateway - Validations - Left part section
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4024_UI_set_up_a_Gateway_Validations_Left_part_section()
        {
            testCaseId = "TC-4024";
            qTestUniqueId = "19323482";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateLeftPartSection();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to UI - set-up a Gateway - Validations - Static IP section
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4025_UI_set_up_a_Gateway_Validations_Static_IP_section()
        {
            testCaseId = "TC-4025";
            qTestUniqueId = "19323483";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateLeftPartSection();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to UI - set-up a Gateway - Canceling the creation of Gateway
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4029_UI_set_up_a_Gateway_Canceling_the_creation_of_Gateway()
        {
            testCaseId = "TC-4029";
            qTestUniqueId = "19323487";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateGatewayCancellation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to UI - set-up a Gateway - Cancel Confirmation
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4030_UI_set_up_a_Gateway_Cancel_Confirmation()
        {
            testCaseId = "TC-4030";
            qTestUniqueId = "19323488";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateGatewayCancellation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to UI - set-up a Gateway - Does NOT confirm Cancel
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_4031_UI_set_up_a_Gateway_Does_NOT_confirm_Cancel()
        {
            testCaseId = "TC-4031";
            qTestUniqueId = "19323489";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateGatewayCancellationNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to NextGen - 133 View List of Utilities - Messaging - No Results Found
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_3603_NextGen_133_View_List_of_Utilities_Messaging_No_Results_Found()
        {
            testCaseId = "TC-3603";
            qTestUniqueId = "19238216";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateNoUtilitySelected(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management - Edit Utility - Handheld Support - Label and Checkbox Displayed
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15628_Utility_Management_Edit_Utility_Handheld_Support_Label_and_Checkbox_Displayed()
        {
            testCaseId = "TC-15628";
            qTestUniqueId = "34176205";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateHandheldCheckBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management - Create New Utility - Handheld Support - Select Checkbox - Cancel
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15629_Utility_Management_Create_New_Utility_Handheld_Support_Select_Checkbox_Cancel()
        {
            testCaseId = "TC-15629";
            qTestUniqueId = "34176206";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilityHandheldCheckBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management - Create New Utility - Handheld Support - Select Checkbox - Save
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15630_Utility_Management_Create_New_Utility_Handheld_Support_Select_Checkbox_Save()
        {
            testCaseId = "TC-15630";
            qTestUniqueId = "34176207";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilityHandheldCheckBoxSave();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management_Create Utility_Default Unit Of Measure_Values Display
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17161_Utility_Management_Create_Utility_Default_Unit_Of_Measure_Values_Display()
        {
            testCaseId = "TC-17161";
            qTestUniqueId = "36816963";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUnitOfMeasureFieldValues();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management_Edit Utility_Default Unit Of Measure_Values Display
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17162_Utility_Management_Edit_Utility_Default_Unit_Of_Measure_Values_Display()
        {
            testCaseId = "TC-17162";
            qTestUniqueId = "36816987";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityUnitOfMeasureFieldValues();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management_View Utility_Default Unit Of Measure_Values Display
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17164_Utility_Management_View_Utility_Default_Unit_Of_Measure_Values_Display()
        {
            testCaseId = "TC-17164";
            qTestUniqueId = "36817059";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityUnitOfMeasureFieldValuesDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management_Create Utility_Default Unit Of Measure_Values Display_Order
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17166_Utility_Management_Create_Utility_Default_Uni_Of_Measure_Values_Display_Order()
        {
            testCaseId = "TC-17166";
            qTestUniqueId = "36817633";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilityUOMFieldValuesDisplaysOrders();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management_Edit Utility_Default Unit Of Measure_Values Display_Order
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17167_Utility_Management_Edit_Utility_Default_Unit_Of_Measure_Values_Display_Order()
        {
            testCaseId = "TC-17167";
            qTestUniqueId = "36817661";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilityUOMFieldValuesDisplaysOrders();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management _Create Utility_Auto-Complete Days_Display
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement_Archived")]
        [Test]
        public void TC_14031_Utility_Management_Create_Utility_Auto_Complete_Days_Display()
        {
            testCaseId = "TC-14031";
            qTestUniqueId = "30349328";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateAutoCompleteDaysDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management _Create Utility_Auto-Complete Days_Default Value
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement_Archived")]
        [Test]
        public void TC_14032_Utility_Management_Create_Utility_Auto_Complete_Days_Default_Value()
        {
            testCaseId = "TC-14032";
            qTestUniqueId = "30349329";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateAutoCompleteDaysDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Utility Management - Handheld Support - Yes 
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15618_Utility_Management_Handheld_Support_Yes()
        {
            testCaseId = "TC-15618";
            qTestUniqueId = "34176191";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateHandheldCheckBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management - Handheld Support - No 
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15619_Utility_Management_Handheld_Support_No()
        {
            testCaseId = "TC-15619";
            qTestUniqueId = "34176193";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateHandheldCheckBoxNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management - Create New Utility - Handheld Support - Default Value Unchecked 
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15620_Utility_Management_Create_New_Utility_Handheld_Support_Default_Value_Unchecked()
        {
            testCaseId = "TC-15620";
            qTestUniqueId = "34176195";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilityHandheldCheckBoxUnchecked();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management - Create New Utility - Handheld Support - Select Checkbox 
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15621_Utility_Management_Create_New_Utility_Handheld_Support_Select_Checkbox()
        {
            testCaseId = "TC-15621";
            qTestUniqueId = "34176197";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilityHandheldCheckBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management - Edit Utility - Handheld Support - Value Persisted 
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15622_Utility_Management_Edit_Utility_Handheld_Support_Value_Persisted()
        {
            testCaseId = "TC-15622";
            qTestUniqueId = "34176199";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateHandheldCheckBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management - Edit Utility - Handheld Support - Change Checkbox Selection
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15623_Utility_Management_Edit_Utility_Handheld_Support_Change_Checkbox_Selection()
        {
            testCaseId = "TC-15623";
            qTestUniqueId = "34176200";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityHandheldCheckBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management - Edit Utility - Handheld Support - Cancel
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15624_Utility_Management_Edit_Utility_Handheld_Support_Cancel()
        {
            testCaseId = "TC-15624";
            qTestUniqueId = "34176201";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityHandheldCheckBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management - Handheld Support - Field Label Displayed
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15625_Utility_Management_Handheld_Support_Field_Label_Displayed()
        {
            testCaseId = "TC-15625";
            qTestUniqueId = "34176202";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityHandheldCheckBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management - Create New Utility - Handheld Support - Label and Checkbox Displayed
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15626_Utility_Management_Create_New_Utility_Handheld_Support_Label_and_Checkbox_Displayed()
        {
            testCaseId = "TC-15626";
            qTestUniqueId = "34176203";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilityHandheldCheckBox();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management - Edit Utility - Handheld Support - Save
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement - Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15627_Utility_Management_Edit_Utility_Handheld_Support_Save()
        {
            testCaseId = "TC-15627";
            qTestUniqueId = "34176204";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityHandheldCheckBoxSave();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Create Utility_Auto-Complete Days_Numeric Value
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement_Archived")]
        [Test]
        public void TC_14033_Utility_Management_Create_Utility_Auto_Complete_Days_Numeric_Value()
        {
            testCaseId = "TC-14033";
            qTestUniqueId = "30349364";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateAutoCompleteDaysNumericValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Create Utility_Auto-Complete Days_Alphabets
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement_Archived")]
        [Test]
        public void TC_14034_Utility_Management_Create_Utility_Auto_Complete_Days_Alphabets()
        {
            testCaseId = "TC-14034";
            qTestUniqueId = "30349365";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateAutoCompleteDaysAlphabetValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Create Utility_Auto-Complete Days_Alphanumeric
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement_Archived")]
        [Test]
        public void TC_14035_Utility_Management_Create_Utility_Auto_Complete_Days_Alphanumeric()
        {
            testCaseId = "TC-14035";
            qTestUniqueId = "30349368";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateAutoCompleteDaysAlphaNumericValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Create Utility_Auto-Complete Days_Vaild range
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14036_Utility_Management_Create_Utility_Auto_Complete_Days_Vaild_Range()
        {
            testCaseId = "TC-14036";
            qTestUniqueId = "30349369";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateAutoCompleteDaysNumericValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Create Utility_Auto-Complete Days_Input value_Negative 1
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14037_Utility_Management_Create_Utility_AutoComplete_Days_Input_value_Negative_1()
        {
            testCaseId = "TC-14037";
            qTestUniqueId = "30349370";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateAutoCompleteDaysNegativeNumericValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Create Utility_Auto-Complete Days_Input value_11
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14038_Utility_Management_Create_Utility_Auto_Complete_Days_Input_value_11()
        {
            testCaseId = "TC-14038";
            qTestUniqueId = "30349372";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateAutoCompleteDays11();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Create Utility_Auto-Complete Days_Increase Button
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14039_Utility_Management_Create_Utility_Auto_Complete_Days_Increase_Button()
        {
            testCaseId = "TC-14039";
            qTestUniqueId = "30349373";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateAutoCompleteDaysIncreaseValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Create Utility_Auto-Complete Days_Increase Button
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14040_Utility_Management_Create_Utility_Auto_Complete_Days_Increase_Button()
        {
            testCaseId = "TC-14040";
            qTestUniqueId = "30349374";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateAutoCompleteDaysDecreaseValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Create Utility_Auto-Complete Days_0
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14041_Utility_Management_Create_Utility_Auto_Complete_Days_0()
        {
            testCaseId = "TC-14041";
            qTestUniqueId = "30349375";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateAutoCompleteDaysValue0();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Create Utility_Auto-Complete Days_10
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14042_Utility_Management_Create_Utility_Auto_Complete_Days_10()
        {
            testCaseId = "TC-14042";
            qTestUniqueId = "30349377";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateAutoCompleteDaysValue10();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Edit Utility_Auto-Complete Days_Display
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14049_Utility_Management_Edit_Utility_Auto_Complete_Days_Display()
        {
            testCaseId = "TC-14049";
            qTestUniqueId = "30376545";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditAutoCompleteDaysDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Edit Utility_Auto-Complete Days_Previous Saved value
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14050_Utility_Management_Edit_Utility_Auto_Complete_Days_Previous_Saved_value()
        {
            testCaseId = "TC-14050";
            qTestUniqueId = "30376624";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditAutoCompleteDaysDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Edit Utility_Auto-Complete Days_Numeric Value
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14051_Utility_Management_Edit_Utility_Auto_Complete_Days_Numeric_Value()
        {
            testCaseId = "TC-14051";
            qTestUniqueId = "30376625";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditAutoCompleteDaysNumericValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Edit Utility_Auto-Complete Days_Alphabet Value
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14052_Utility_Management_Edit_Utility_Auto_Complete_Days_Alphabet_Value()
        {
            testCaseId = "TC-14052";
            qTestUniqueId = "30376625";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditAutoCompleteDaysAlphabetValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Edit Utility_Auto-Complete Days_Alphabet Value
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14053_Utility_Management_Edit_Utility_Auto_Complete_Days_Alphabet_Value()
        {
            testCaseId = "TC-14053";
            qTestUniqueId = "30376627";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditAutoCompleteDaysAlphaNumericValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Edit Utility_Auto-Complete Days_Vaild range
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14054_Utility_Management_Edit_Utility_Auto_Complete_Days_Vaild_range()
        {
            testCaseId = "TC-14054";
            qTestUniqueId = "30376628";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditAutoCompleteDaysNumericValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Edit Utility_Auto-Complete Days_Input value_Negative 1
        /// </summary>
        [Category("UtilityManagement")]
        [Category("UtilityManagement_Archived")]
        [Test]
        public void TC_14055_Utility_Management_Edit_Utility_Auto_Complete_Days_Input_value_Negative_1()
        {
            testCaseId = "TC-14055";
            qTestUniqueId = "30376629";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditAutoCompleteDaysNegativeValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Edit Utility_Auto-Complete Days_Input value 11
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14056_Utility_Management_Edit_Utility_Auto_Complete_Days_Input_value_11()
        {
            testCaseId = "TC-14056";
            qTestUniqueId = "30376630";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditAutoCompleteDaysValue11();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Edit Utility_Auto-Complete Days_Increase Button
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14057_Utility_Management_Edit_Utility_Auto_Complete_Days_Increase_Button()
        {
            testCaseId = "TC-14057";
            qTestUniqueId = "30376631";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditAutoCompleteDaysIncreaseValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Edit Utility_Auto-Complete Days_Decrease Button
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14058_Utility_Management_Edit_Utility_Auto_Complete_Days_Decrease_Button()
        {
            testCaseId = "TC-14058";
            qTestUniqueId = "30376632";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditAutoCompleteDaysDecreaseValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Edit Utility_Auto-Complete Days_0
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14059_Utility_Management_Edit_Utility_Auto_Complete_Days_0()
        {
            testCaseId = "TC-14059";
            qTestUniqueId = "30376633";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditAutoCompleteDaysValue0();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Edit Utility_Auto-Complete Days_10
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14060_Utility_Management_Edit_Utility_Auto_Complete_Days_10()
        {
            testCaseId = "TC-14060";
            qTestUniqueId = "30376634";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditAutoCompleteDaysValue10();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management _Edit Utility_Auto-Complete Days_Save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14061_Utility_Management_Edit_Utility_Auto_Complete_Days_Save()
        {
            testCaseId = "TC-14061";
            qTestUniqueId = "30376639";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditAutoCompleteDaysSave();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_View_Auto-Complete Days option_Display
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14062_Utility_Management_View_Auto_Complete_Days_Option_Display()
        {
            testCaseId = "TC-14062";
            qTestUniqueId = "30376640";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateAutoCompleteDaysOption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_View_Auto-Complete Days option_Location
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14063_Utility_Management_View_Auto_Complete_Days_Option_Location()
        {
            testCaseId = "TC-14063";
            qTestUniqueId = "30376641";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateAutoCompleteDaysOption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_View_Auto-Complete Days_Value_Set on Create Utility Screen
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14064_Utility_Management_View_Auto_Complete_Days_Value_Set_on_Create_Utility_Screen()
        {
            testCaseId = "TC-14064";
            qTestUniqueId = "30376642";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateAutoCompleteDaysOption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_View_Auto-Complete Days_Value_Set on Edit Utility Screen
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14065_Utility_Management_View_Auto_Complete_Days_Value_Set_on_Edit_Utility_Screen()
        {
            testCaseId = "TC-14065";
            qTestUniqueId = "30376643";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditAutoCompleteDaysSave();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Create Utility_Import/Export Format_Display
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14554_Utility_Management_Create_Utility_Import_Export_Format_Display()
        {
            testCaseId = "TC-14554";
            qTestUniqueId = "32013901";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilityImportExportFormatDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Create Utility_Import/Export Default Value
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14555_Utility_Management_Create_Utility_Import_Export_Default_Value()
        {
            testCaseId = "TC-14555";
            qTestUniqueId = "32013909";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilityImportExportDefaulltValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Create Utility_Import/Export Cancel
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14557_Utility_Management_Create_Utility_Import_Export_Cancel()
        {
            testCaseId = "TC-14557";
            qTestUniqueId = "32013914";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilityImportExportCancel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Edit Utility_Import/Export Format_Display
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14558_Utility_Management_Edit_Utility_Import_Export_Format_Display()
        {
            testCaseId = "TC-14558";
            qTestUniqueId = "32013915";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityImportExportDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_View Utility_Import/Export Format_Display
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14559_Utility_Management_View_Utility_Import_Export_Format_Display()
        {
            testCaseId = "TC-14559";
            qTestUniqueId = "32013916";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateImportExportFormatInfo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_View Utility_Import/Export Format_Value Validation
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14560_Utility_Management_View_Utility_Import_Export_Format_Value_Validation()
        {
            testCaseId = "TC-14560";
            qTestUniqueId = "32013918";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateImportExportFormatInfo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Edit Utility_Import/Export Format_Cancel
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14562_Utility_Management_Edit_Utility_Import_Export_Format_Cancel()
        {
            testCaseId = "TC-14562";
            qTestUniqueId = "32014331";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityImportExportCancel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Edit Utility_Import/Export Format_Editable
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14563_Utility_Management_Edit_Utility_Import_Export_Format_Editable()
        {
            testCaseId = "TC-14563";
            qTestUniqueId = "32014333";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityImportExportCancel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Edit Utility_Import/Export Format_Value Validation
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14564_Utility_Management_Edit_Utility_Import_Export_Format_Value_Validation()
        {
            testCaseId = "TC-14564";
            qTestUniqueId = "32014442";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityImportExportFormatValueValidation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Edit Utility_Import/Export Format_Drop Down Values
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14565_Utility_Management_Edit_Utility_Import_Export_Format_Drop_Down_Values()
        {
            testCaseId = "TC-14565";
            qTestUniqueId = "32014442";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilityImportExportFormatDropdownValues();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Existing Utilites_Import/Export Format_Value Display
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14566_Utility_Management_Existing_Utilites_Import_Export_Format_Value_Display()
        {
            testCaseId = "TC-14566";
            qTestUniqueId = "32014883";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityImportExportFormatDropdownValuesV4();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Existing Utilites_Import/Export Format_V4 File Support
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14567_Utility_Management_Existing_Utilites_Import_Export_Format_V4_File_Support()
        {
            testCaseId = "TC-14567";
            qTestUniqueId = "32017798";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityImportExportFormatDropdownValuesV4();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Create Utility_Mobile Mapping Checkbox_Display
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14979_Utility_Management_Create_Utility_Mobile_Mapping_Checkbox_Display()
        {
            testCaseId = "TC-14979";
            qTestUniqueId = "33140050";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilityMobileMapingCheckBoxDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Create Utility_Mobile Mapping Checkbox_Cancel
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14981_Utility_Management_Create_Utility_Mobile_Mapping_Checkbox_Cancel()
        {
            testCaseId = "TC-14981";
            qTestUniqueId = "33140083";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilityMobileMapingCheckBoxCancel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Edit Utility_Mobile Mapping Checkbox_Display
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14982_Utility_Management_Edit_Utility_Mobile_Mapping_Checkbox_Display()
        {
            testCaseId = "TC-14982";
            qTestUniqueId = "33140084";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityMobileMapingCheckBoxDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_View Utility_Mobile Mapping Checkbox_Display
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14983_Utility_Management_View_Utility_Mobile_Mapping_Checkbox_Display()
        {
            testCaseId = "TC-14983";
            qTestUniqueId = "33140085";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateMobileMapingFeildDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_View Utility_Mobile Mapping Checkbox_Value Validation_YES
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14984_Utility_Management_View_Utility_Mobile_Mapping_Checkbox_Value_Validation_YES()
        {
            testCaseId = "TC-14984";
            qTestUniqueId = "33140086";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateMobileMapingFeildDisplayedYes();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Edit Utility_Mobile Mapping Checkbox_Save
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14985_Utility_Management_Edit_Utility_Mobile_Mapping_Checkbox_Save()
        {
            testCaseId = "TC-14985";
            qTestUniqueId = "33140087";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditUtilityMobileMapingCheckBoxSave();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Edit Utility_Mobile Mapping Checkbox_Editable
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14987_Utility_Management_Edit_Utility_Mobile_Mapping_Checkbox_Editable()
        {
            testCaseId = "TC-14987";
            qTestUniqueId = "33140089";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUtilityMobileMapingCheckBoxEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_Create Utility_Mobile Mapping Checkbox_Default Value
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_14989_Utility_Management_Create_Utility_Mobile_Mapping_Checkbox_Default_Value()
        {
            testCaseId = "TC-14989";
            qTestUniqueId = "33142008";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCreateUtilityMobileMapingCheckBoxDefaultValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_View Utility_Mobile Mapping Checkbox_Value Validation_NO
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_15190_Utility_Management_View_Utility_Mobile_Mapping_Checkbox_Value_Validation_NO()
        {
            testCaseId = "TC-15190";
            qTestUniqueId = "33271232";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateMobileMapingFeildDisplayedNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to View Utility Management_Time Zone Value_Abbreviations Not Displayed
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_15264_View_Utility_Management_Time_Zone_Value_Abbreviations_Not_Displayed()
        {
            testCaseId = "TC-15264";
            qTestUniqueId = "33715726";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateTimezone();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to View Utility Management_Time Zone Value_Same as in Edit Utility
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_15266_View_Utility_Management_Time_Zone_Value_Same_as_in_Edit_Utility()
        {
            testCaseId = "TC-15266";
            qTestUniqueId = "33715728";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateEditTimezone();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_View Utility_Close Route on Export_Display
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_15320_Utility_Management_View_Utility_Close_Route_on_Export_Display()
        {
            testCaseId = "TC-15320";
            qTestUniqueId = "33805766";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCloseRouteOnExportField();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_View Utility_Close Route on Export_Flag Set to On
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_15321_Utility_Management_View_Utility_Close_Route_on_Export_Flag_Set_to_On()
        {
            testCaseId = "TC-15321";
            qTestUniqueId = "33805769";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCloseRouteOnExportFieldOn();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_View Utility_Close Route on Export_Flag Set to Off
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_15322_Utility_Management_View_Utility_Close_Route_on_Export_Flag_Set_to_Off()
        {
            testCaseId = "TC-15322";
            qTestUniqueId = "33805772";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateCloseRouteOnExportFieldOFF();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Utility Management_UOM Selected_Multiplier Value_Auto Select_Use By System Processes
        /// </summary>
        [Category("UtilityManagement")]
        [Test]
        public void TC_17459_Utility_Management_UOM_Selected_Multiplier_Value_Auto_Select_Use_By_System_Processes()
        {
            testCaseId = "TC-17459";
            qTestUniqueId = "37673084";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                utilityManagement.ValidateUOMFieldDisplayes();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }





















        //[Test]
        //public void TestFailureTest()
        //{
        //    ReporterFactory.TestReport.Pass("Pass");
        //    ReporterFactory.TestReport.Pass("Pass");
        //    ReporterFactory.LogFailure("Fail 1",EngineSetup.GetScreenShotPath());
        //    ReporterFactory.TestReport.Pass("Pass");

        //    ReporterFactory.TestReport.Pass("Pass");
        //    ReporterFactory.LogFailure("Fail 2", EngineSetup.GetScreenShotPath());
        //    ReporterFactory.TestReport.Pass("Pass");
        //}

    }
}
