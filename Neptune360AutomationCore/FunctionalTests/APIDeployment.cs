using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public class APIDeployment : TestBaseTemplate
    {
        /// <summary>
        /// Test Method to API Deployment_Title_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
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
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateTitleDisplay();
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
        /// Test Method to API Deployment_Breadcrumbs_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15884_API_Deployment_Breadcrumbs_Display()
        {
            testCaseId = "TC-15884";
            qTestUniqueId = "34748454";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateBreadCrumbDisplay();
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
        /// Test Method to API Deployment_Create Bundles Permission_Enabled_Create Button_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15885_API_Deployment_Creat_Bundles_Permission_Enabled_Create_Button_Display()
        {
            testCaseId = "TC-15885";
            qTestUniqueId = "34748456";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateCreateButton();
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
        /// Test Method to API Deployment_Create Bundles Permission_Disabled_Create Button_Not Displayed
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15886_API_Deployment_Create_Bundles_Permission_Disabled_Create_Button_Not_Displayed()
        {
            testCaseId = "TC-15886";
            qTestUniqueId = "34748458";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateCreateButtonNotExist();
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
        /// Test Method to API Deployment_Edit Bundles Permission_Enabled_Edit Button_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15887_API_Deployment_Edit_Bundles_Permission_Enabled_Edit_Button_Display()
        {
            testCaseId = "TC-15887";
            qTestUniqueId = "34748459";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateEditButton();
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
        /// Test Method to API Deployment_Edit Bundles Permission_Disabled_Edit Button_Not Displayed
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_15888_API_Deployment_Edit_Bundles_Permission_Enabled_Edit_Button_Not_Display()
        {
            testCaseId = "TC-15888";
            qTestUniqueId = "34748460";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateEditButtonNotExist();
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
        /// Test Method to API Deployment_Done Button_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15889_API_Deployment_Done_Button_Display()
        {
            testCaseId = "TC-15889";
            qTestUniqueId = "34748461";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateDoneButton();
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
        /// Test Method to API Deployment_Left Section Title_Bundles_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15890_API_Deployment_Left_Section_Title_Bundles_Display()
        {
            testCaseId = "TC-15890";
            qTestUniqueId = "34748462";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateBundles();
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
        /// Test Method to API Deployment_Right Section Title_Platform API_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15891_API_Deployment_Right_Section_Title_Platform_API_Display()
        {
            testCaseId = "TC-15891";
            qTestUniqueId = "34748463";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidatePlatformAPI();
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
        /// Test Method to API Deployment_Bundles Section_Bundles List_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15892_API_Deployment_Bundles_Section_Bundles_List_Display()
        {
            testCaseId = "TC-15892";
            qTestUniqueId = "34748464";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateListOfBundles();
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
        /// Test Method to API Deployment_Bundles Section_Each Bundle Name_Unique
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15893_API_Deployment_Bundles_Section_Each_Bundle_Name_Unique()
        {
            testCaseId = "TC-15893";
            qTestUniqueId = "34748465";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateListOfBundles();
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
        /// Test Method to API Deployment_Bundles Section_One Bundle at Time_Select
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15894_API_Deployment_Bundles_Section_One_Bundle_At_Time_Select()
        {
            testCaseId = "TC-15894";
            qTestUniqueId = "34748467";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateUniqueBundles();
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
        /// Test Method to API Deployment_Bundles Section_Selected Bundle_Arrow Highlight
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15895_API_Deployment_Bundles_Section_Selected_Bundle_Arrow_Highlight()
        {
            testCaseId = "TC-15895";
            qTestUniqueId = "34748468";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateUniqueBundles();
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
        /// Test Method to API Deployment_Done Button_Click
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15896_API_Deployment_Done_Button_Click()
        {
            testCaseId = "TC-15896";
            qTestUniqueId = "34748469";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateDoneButtonClick();
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
        /// Test Method to API Deployment_Platform API Section_Selected Bundle Web Services_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15897_API_Deployment_Platform_API_Section_Selected_Bundle_Web_Services_Display()
        {
            testCaseId = "TC-15897";
            qTestUniqueId = "34748470";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateConsumption();
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
        /// Test Method to API Deployment_Platform API Section_Each API_Name
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15898_API_Deployment_Platform_API_Section_Each_API_Name()
        {
            testCaseId = "TC-15898";
            qTestUniqueId = "34748471";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateConsumption();
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
        /// Test Method to API Deployment_Platform API Section_Each API_Version
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15899_API_Deployment_Platform_API_Section_Each_API_Version()
        {
            testCaseId = "TC-15899";
            qTestUniqueId = "34748475";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateConsumptionEndpoint();
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
        /// Test Method to API Deployment_Platform API Section_Each API_Status
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15900_API_Deployment_Platform_API_Section_Each_API_Status()
        {
            testCaseId = "TC-15900";
            qTestUniqueId = "34748477";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateStatusActive();
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
        /// Test Method to API Deployment_Platform API Section_Each API_On/Off Status
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_15901_API_Deployment_Platform_API_Section_Each_API_On_Off_Status()
        {
            testCaseId = "TC-15901";
            qTestUniqueId = "34748478";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateEnabledColumn();
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
        /// Test Method to API Deployment_Create Button_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16185_API_Deployment_Create_Button_Display()
        {
            testCaseId = "TC-16185";
            qTestUniqueId = "35206800";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateCreateButton();
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
        /// Test Method to API Deployment_Create Bundles_Create Button_Grayed out
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16186_API_Deployment_Create_Bundles_Create_Button_Grayed_out()
        {
            testCaseId = "TC-16186";
            qTestUniqueId = "35206802";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateCreateButtonDisabled();
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
        /// Test Method to API Deployment_Create Bundles_Create Button_Grayed out
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16187_API_Deployment_Create_Bundles_Create_Button_Grayed_out()
        {
            testCaseId = "TC-16187";
            qTestUniqueId = "35206803";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateEditButtonDisabled();
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
        /// Test Method to API Deployment_Create Bundles_Done Button_Grayed out
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16188_API_Deployment_Create_Bundles_Done_Button_Grayed_out()
        {
            testCaseId = "TC-16188";
            qTestUniqueId = "35206803";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateDoneButtonDisabled();
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
        /// Test Method to API Deployment_Platform API Section_Create Button_Click
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16190_API_Deployment_Platform_API_Section_Create_Button_Click()
        {
            testCaseId = "TC-16190";
            qTestUniqueId = "35206875";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateAPITextBBox();
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
        /// Test Method to API Deployment_Create Bundles_Duplicate Bundle Name_Done Button Access_Message Validation
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16191_API_Deployment_Create_Bundles_Duplicate_Bundle_Name_Done_Button_Access_Message_Validation()
        {
            testCaseId = "TC-16191";
            qTestUniqueId = "35206877";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateCreateDuplicateBundle();
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
        /// Test Method to API Deployment_Create Bundles_Blank Bundle Name_Done Button Access_Message Validation
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16193_API_Deployment_Create_Bundles_Blank_Bundle_Name_Done_Button_Access_Message_Validation()
        {
            testCaseId = "TC-16193";
            qTestUniqueId = "35206881";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateBundleNameBlank();
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
        /// Test Method to API Deployment_Create Bundles_Cancel Button_Access
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16194_API_Deployment_Create_Bundles_Cancel_Button_Access()
        {
            testCaseId = "TC-16194";
            qTestUniqueId = "35206883";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateCreateCancel();
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
        /// Test Method to API Deployment_Create Bundles_Unique Bundle Name_Done Button Access_Message Validation
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16196_API_Deployment_Create_Bundles_Unique_Bundle_Name_Done_Button_Access_Message_Validation()
        {
            testCaseId = "TC-16196";
            qTestUniqueId = "35206888";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateCreateUniqueBundleName(bundleName);
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
        /// Test Method to API Deployment_Create Bundles_Bundle Names_Display Order
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16197_API_Deployment_Create_Bundles_Bundle_Names_Display_Order()
        {
            testCaseId = "TC-16197";
            qTestUniqueId = "35206890";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateUniqueBundleNameDisplay(bundleName);
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
        /// Test Method to API Deployment_Create Bundles_Unique Bundle Name_Done Button Access_Screen Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16198_API_Deployment_Create_Bundles_Unique_Bundle_Name_Done_Button_Access_Screen_Display()
        {
            testCaseId = "TC-16198";
            qTestUniqueId = "35206892";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateCreateUniqueBundleAPIDisplay(bundleName);
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
        /// Test Method to API Deployment_Edit Button_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16295_API_Deployment_Edit_Button_Display()
        {
            testCaseId = "TC-16295";
            qTestUniqueId = "35409349";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateEditButton();
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
        /// Test Method to API Deployment_Edit Bundles_Create Button_Grayed out
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16296_API_Deployment_Edit_Bundles_Create_Button_Grayed_Out()
        {
            testCaseId = "TC-16296";
            qTestUniqueId = "35409350";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateEditCreateButtonDisabled();
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
        /// Test Method to API Deployment_Edit Bundles_Edit Button_Grayed out
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16297_API_Deployment_Edit_Bundles_Edit_Button_Grayed_Out()
        {
            testCaseId = "TC-16296";
            qTestUniqueId = "35409350";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateEditButtonDisabled();
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
        /// Test Method to API Deployment_Edit Bundles_Done Button_Grayed out
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16298_API_Deployment_Edit_Bundles_Done_Button_Grayed_Out()
        {
            testCaseId = "TC-16298";
            qTestUniqueId = "35409352";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateEditDoneButtonDisabled();
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
        /// Test Method to API Deployment_Edit Bundles_Delete Bundle Button_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16300_API_Deployment_Edit_Bundles_Delete_Bundle_Button_Display()
        {
            testCaseId = "TC-16300";
            qTestUniqueId = "35409355";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateDeleteBundleButton();
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
        /// Test Method to API Deployment_Edit Bundles_Cancel Bundle Button_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16301_API_Deployment_Edit_Bundles_Cancel_Bundle_Button_Display()
        {
            testCaseId = "TC-16301";
            qTestUniqueId = "35409356";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateEditCancel();
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
        /// Test Method to API Deployment_Edit Bundles_Cancel Bundle Button_Access
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16302_API_Deployment_Edit_Bundles_Cancel_Bundle_Button_Access()
        {
            testCaseId = "TC-16302";
            qTestUniqueId = "35409357";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateEditCancelAPIPage();
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
        /// Test Method to API Deployment_Edit Bundles_Done Bundle Button_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16303_API_Deployment_Edit_Bundles_Done_Bundle_Button_Display()
        {
            testCaseId = "TC-16303";
            qTestUniqueId = "35409358";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateEditDoneButton();
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
        /// Test Method to API Deployment_Edit Bundles_Delete Bundle Button_Access_Confirmation Dialog_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16304_API_Deployment_Edit_Bundles_Delete_Bundle_Button_Access_Confirmation_Dialog_Display()
        {
            testCaseId = "TC-16304";
            qTestUniqueId = "35409359";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateDeleteBundleDialog();
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
        /// Test Method to API Deployment_Edit Bundles_Delete Bundle Button_Access_Confirmation Dialog_Contents
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16305_API_Deployment_Edit_Bundles_Delete_Bundle_Button_Access_Confirmation_Dialog_Contents()
        {
            testCaseId = "TC-16305";
            qTestUniqueId = "35409360";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateDeleteBundleDialogContents();
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
        /// Test Method to API Deployment_Edit Bundles_Delete Bundle Button_Confirmation Dialog_Cancel Access
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16306_API_Deployment_Edit_Bundles_Delete_Bundle_Button_Confirmation_Dialog_Cancel_Access()
        {
            testCaseId = "TC-16306";
            qTestUniqueId = "35409361";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateDeleteBundleDialogContents();
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
        /// Test Method to API Deployment_Edit Bundles_Delete Bundle Button_Confirmation Dialog_Delete Access
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16307_API_Deployment_Edit_Bundles_Delete_Bundle_Button_Confirmation_Dialog_Delete_Access()
        {
            testCaseId = "TC-16307";
            qTestUniqueId = "35409363";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateDeleteBundleConfirmation(bundleName);
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
        /// Test Method to API Deployment_Edit Bundles_Done Button_Access_Confirmation toast_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16308_API_Deployment_Edit_Bundles_Done_Button_Access_Confirmation_Toast_Display()
        {
            testCaseId = "TC-16308";
            qTestUniqueId = "35409364";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateEditBundleDoneConfirmation(bundleName);
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
        /// Test Method to API Deployment_Edit Bundles_Done Button_Access
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16309_API_Deployment_Edit_Bundles_Done_Button_Access()
        {
            testCaseId = "TC-16309";
            qTestUniqueId = "35409366";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateEditBundleDoneAPIPage(bundleName);
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
        /// Test Method to API Deployment_Edit Bundles_Done Button_Access_Updated Bundle Display_Left Section
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16310_API_Deployment_Edit_Bundles_Done_Button_Access_Updated_Bundle_Display_Left_Section()
        {
            testCaseId = "TC-16310";
            qTestUniqueId = "35409367";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateUpdatedBundleOnList(bundleName);
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
        /// Test Method to API Deployment_Edit Bundles_Delete Bundle Button_Access_Screen Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16532_API_Deployment_Edit_Bundles_Delete_Bundle_Button_Access_Screen_Display()
        {
            testCaseId = "TC-16532";
            qTestUniqueId = "35556577";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateDeleteBundleAPIPage(bundleName);
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
        /// Test Method to API Deployment_Create Bundle_Web Services_Display
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16566_API_Deployment_Create_Bundle_Web_Services_Display()
        {
            testCaseId = "TC-16566";
            qTestUniqueId = "35632031";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateCreateBundleWebServices();
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
        /// Test Method to API Deployment_Edit Bundle_Web Services_Enable
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16568_API_Deployment_Edit_Bundle_Web_Services_Enable()
        {
            testCaseId = "TC-16568";
            qTestUniqueId = "35632033";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateEditWebServicesEnabled();
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
        /// Test Method to API Deployment_Edit Bundle_Web Services_Disable
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16569_API_Deployment_Edit_Bundle_Web_Services_Disable()
        {
            testCaseId = "TC-16569";
            qTestUniqueId = "35642564";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateEditWebServicesEnabled();
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
        /// Test Method to API Deployment_Edit Bundle_Web Services_Max Number Editable
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16570_API_Deployment_Edit_Bundle_Web_Services_Max_Number_Editable()
        {
            testCaseId = "TC-16570";
            qTestUniqueId = "35642574";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateMultipleWebServicesEnabled();
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
        /// Test Method to API Deployment_Edit Bundle_Web Services_More than 5 Resources_Edit
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_16571_API_Deployment_Edit_Bundle_Web_Services_More_than_5_Resources_Edit()
        {
            testCaseId = "TC-16571";
            qTestUniqueId = "35642577";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateFiveWebServicesEnabled();
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
        /// Test Method to API Deployment_Create Bundles_Complimentary Usage Plan Created
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17182_API_Deployment_Create_Bundles_Complimentary_Usage_Plan_Created()
        {
            testCaseId = "TC-17182";
            qTestUniqueId = "36863439";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateCreateBundleComplementaryUsagePlans(bundleName);
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
        /// Test Method to API Deployment_Edit Bundles_Bundle Friendly Name_ Cannot Change
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests")]
        [Test]
        public void TC_17183_API_Deployment_Edit_Bundles_Bundle_Friendly_Name_Cannot_Change()
        {
            testCaseId = "TC-17183";
            qTestUniqueId = "36863462";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateBundleNameCannotChange();
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
        /// Test Method to API Deployment_Create Bundles_Bundle Friendly Name_ Cannot be Existing Bundle Name
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17184_API_Deployment_Create_Bundles_Bundle_Friendly_Name_Cannot_Be_Existing_Bundle_Name()
        {
            testCaseId = "TC-17184";
            qTestUniqueId = "36863827";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateCreateDuplicateBundle();
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
        /// Test Method to API Deployment_Delete Bundles_Complimentary Usage Plan Deleted
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17185_API_Deployment_Delete_Bundles_Complimentary_Usage_Plan_Deleted()
        {
            testCaseId = "TC-17185";
            qTestUniqueId = "36864313";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateUsagePlanDeleted(bundleName);
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
        /// Test Method to API Deployment_Create Bundles_AWS Bundle Name Convention
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17186_API_Deployment_Create_Bundles_AWS_Bundle_Name_Convention()
        {
            testCaseId = "TC-17186";
            qTestUniqueId = "36864645";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateCreateBundleComplementaryUsagePlans(bundleName);
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
        /// Test Method to API Deployment_Create Bundle _Successful_Usage Plan Friendly Name Same as Bundle
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17187_API_Deployment_Create_Bundle_Successful_Usage_Plan_Friendly_Name_Same_As_Bundle()
        {
            testCaseId = "TC-17187";
            qTestUniqueId = "36865010";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateCreateBundleComplementaryUsagePlans(bundleName);
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
        /// Test Method to API Deployment_Create Bundle _Successful_Usage Plan Friendly Name Same as Bundle
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17188_API_Deployment_Create_Bundle_Successful_Usage_Plan_Friendly_Name_Same_As_Bundle()
        {
            testCaseId = "TC-17188";
            qTestUniqueId = "36865015";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateCreateBundleComplementaryUsagePlans(bundleName);
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
        /// Test Method to API Deployment_Create Bundle_Successful_Default Usage Plan Created
        /// </summary>
        [Category("APIDeployment")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17189_API_Deployment_Create_Bundle_Successful_Default_Usage_Plan_Created()
        {
            testCaseId = "TC-17189";
            qTestUniqueId = "36865021";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                bundleName = testData["BundleName"];
                home.NavigateToLftAPIDeployment(url, userName, password);
                apiDeploymentPage.ValidateCreateBundleComplementaryUsagePlans(bundleName);
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
