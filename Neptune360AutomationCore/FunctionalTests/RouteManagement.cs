using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Neptune360UIAutomation
{
    public class RouteManagement : TestBaseTemplate
    {
        /// <summary>
        /// Test Method to Roles Management_Basic Permissions_Export Management_Route Management_Listed
        /// </summary>
        [Category("RouteManagement")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12174_Roles_Management_Basic_Permissions_Export_Management_Route_Management_Listed()
        {
            testCaseId = "TC-12174";
            qTestUniqueId = "26032838";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateDashboardPage(url, userName, password);
                routeManagement.ValidateExportManagementRouteManagement();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Roles Management_Route Management Permissions_Edit Assignments_ Feature Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12178_Roles_Management_Route_Management_Permissions_Edit_Assignments_Feature_Display()
        {
            testCaseId = "TC-12178";
            qTestUniqueId = "26032974";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateEditAssignmentFeature();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Roles Management_Basic Permissions_Route Management_Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12183_Roles_Management_Basic_Permissions_Route_Management_Display()
        {
            testCaseId = "TC-12183";
            qTestUniqueId = "26032974";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateBasicPermissions();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Roles Management_Route Management Permissions_View Route Management Dashboard_Feature_Editable
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12187_Roles_Management_Route_Management_Permissions_View_Route_Management_Dashboard_Feature_Editable()
        {
            testCaseId = "TC-12187";
            qTestUniqueId = "26036163";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateRouteManagementFeatureEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Roles Management_Route Management Permissions_Edit Assignments_ Feature_Editable
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12188_Roles_Management_Route_Management_Permissions_Edit_Assignments_Feature_Editable()
        {
            testCaseId = "TC-12188";
            qTestUniqueId = "26036164";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateEditAssignmentsEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_Route Management_Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Test]
        public void TC_12230_Left_Navigation_Route_Management_Display()
        {
            testCaseId = "TC-12230";
            qTestUniqueId = "26096153";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                routeManagement.ValidateRouteManagementDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_Route Management_Expand_Sub menu
        /// </summary>
        [Category("RouteManagement")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12231_Left_Navigation_Route_Management_Expand_Sub_menu()
        {
            testCaseId = "TC-12231";
            qTestUniqueId = "26096154";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateRouteManagementSubMenuDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_Route Management_Route Assignment_Click
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12232_Left_Navigation_Route_Management_Route_Assignment_Click()
        {
            testCaseId = "TC-12232";
            qTestUniqueId = "26096155";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateRouteAssignmentClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation_Route Management_Collapse
        /// </summary>
        [Category("RouteManagement")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12234_Left_Navigation_Route_Management_Collapse()
        {
            testCaseId = "TC-12234";
            qTestUniqueId = "26096160";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateRouteManagementCollapse();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Landing Page_Route Management_Widget_Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("BatchExecution")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12235_Landing_Page_Route_Management_Widget_Display()
        {
            testCaseId = "TC-12235";
            qTestUniqueId = "26096161";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateRouteManagementWidget();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Landing Page_Route Management_Click
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12236_Landing_Page_Route_Management_Click()
        {
            testCaseId = "TC-12236";
            qTestUniqueId = "26096162";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateRouteManagementClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management_Total Readings_Widget_Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("SmokeTests")]
        [Test]
        public void TC_12240_Route_Management_Total_Readings_Widget_Display()
        {
            testCaseId = "TC-12240";
            qTestUniqueId = "26160786";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateTotalReading();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Route Management_Total Readings_Widget_Display Location
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12241_Route_Management_Total_Readings_Widget_Display_Location()
        {
            testCaseId = "TC-12241";
            qTestUniqueId = "26160788";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateTotalReadingRight();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

       

        /// <summary>
        /// Test Method to Route Management_Total Readings_Assigned_Count Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12244_Route_Management_Total_Readings_Assigned_Count_Display()
        {
            testCaseId = "TC-12244";
            qTestUniqueId = "26160793";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateViewAssigned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management_Total Readings_Unassigned_Count Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12245_Route_Management_Total_Readings_Unassigned_Count_Display()
        {
            testCaseId = "TC-12245";
            qTestUniqueId = "26160795";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateViewUnassigned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Route Assignments_Edit Button_Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12247_Route_Assignments_Edit_Button_Display()
        {
            testCaseId = "TC-12247";
            qTestUniqueId = "26161027";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateEditButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Route Assignments_Edit Button_Click
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12250_Route_Assignments_Edit_Button_Click()
        {
            testCaseId = "TC-12250";
            qTestUniqueId = "26161035";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateEditButtonClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Route Assignments_User Editing_No_Action Button_Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12252_Route_Assignments_User_Editing_No_Action_Button_Display()
        {
            testCaseId = "TC-12252";
            qTestUniqueId = "26161037";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateEditButtonReplaced();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments_User Editing_No_Action Button_Enabled
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12253_Route_Assignments_User_Editing_No_Action_Button_Enabled()
        {
            testCaseId = "TC-12253";
            qTestUniqueId = "26161037";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateActionButtonEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments_User Editing_No_Cancel Button_Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12255_Route_Assignments_User_Editing_No_Cancel_Button_Display()
        {
            testCaseId = "TC-12255";
            qTestUniqueId = "26161107";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateCancelButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Route Assignments_User Editing_No_Cancel Button_enabled
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12257_Route_Assignments_User_Editing_No_Cancel_Button_enabled()
        {
            testCaseId = "TC-12257";
            qTestUniqueId = "26161117";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateCancelButtonEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Route Assignments_User Editing_No_Assign Routes_Option Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12258_Route_Assignments_User_Editing_No_Assign_Routes_Option_Display()
        {
            testCaseId = "TC-12258";
            qTestUniqueId = "26161118";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAssignRoutes();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Route Assignments_User Editing_No_Readers Object_Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12260_Route_Assignments_User_Editing_No_Readers_Object_Display()
        {
            testCaseId = "TC-12260";
            qTestUniqueId = "26161168";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateReaders();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments - Readers - Button Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12356_Route_Assignments_Readers_Button_Display()
        {
            testCaseId = "TC-12356";
            qTestUniqueId = "26991040";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateReadersButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Routes - No Routes Imported
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12357_Route_Management_View_Routes_No_Routes_Imported()
        {
            testCaseId = "TC-12357";
            qTestUniqueId = "26991086";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateViewAll();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Routes - Routes have been imported but NOT exported
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12358_Route_Management_View_Routes_Routes_have_been_imported_but_NOT_exported()
        {
            testCaseId = "TC-12358";
            qTestUniqueId = "26991087";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateViewExported();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Routes - Routes have been imported AND exported
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12359_Route_Management_View_Routes_Routes_have_been_imported_AND_exported()
        {
            testCaseId = "TC-12359";
            qTestUniqueId = "26991088";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateViewImportednExported();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Routes - Assigned Reader Names
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12360_Route_Management_View_Routes_Assigned_Reader_Names()
        {
            testCaseId = "TC-12360";
            qTestUniqueId = "26991089";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAssignedNames();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Routes - Route Name - Column Heading
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12361_Route_Management_View_Routes_Route_Name_Column_Heading()
        {
            testCaseId = "TC-12361";
            qTestUniqueId = "26991090";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateCoumumnHeading();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Routes - Route Name - Value
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12362_Route_Management_View_Routes_Route_Name_Value()
        {
            testCaseId = "TC-12362";
            qTestUniqueId = "26991091";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateRouteValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Routes - Total Meters - Column Heading
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12363_Route_Management_View_Routes_Total_Meters_Column_Heading()
        {
            testCaseId = "TC-12363";
            qTestUniqueId = "26991092";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateSecoundColumn();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Routes - Total Meters - Value
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12364_Route_Management_View_Routes_Total_Meters_Value()
        {
            testCaseId = "TC-12364";
            qTestUniqueId = "26991093";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateTotalRoutes();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Route Management -View Routes - Total Incomplete - Column Heading
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12365_Route_Management_View_Routes_Total_Incomplete_Column_Heading()
        {
            testCaseId = "TC-12365";
            qTestUniqueId = "26991094";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateTotalRoutesThirdCol();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Routes - Total Incomplete - Value
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12366_Route_Management_View_Routes_Total_Incomplete_Value()
        {
            testCaseId = "TC-12366";
            qTestUniqueId = "26991095";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateTotalIncompleteRoute();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Routes - Reader - Column Heading
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12367_Route_Management_View_Routes_Reader_Column_Heading()
        {
            testCaseId = "TC-12367";
            qTestUniqueId = "26991096";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateTotalRoutesForthCol();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Routes - Reader - Value
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12368_Route_Management_View_Routes_Reader_Value()
        {
            testCaseId = "TC-12368";
            qTestUniqueId = "26991097";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateReaderValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Routes - Status - Column Heading
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12369_Route_Management_View_Routes_Status_Column_Heading()
        {
            testCaseId = "TC-12369";
            qTestUniqueId = "26991098";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateFifthColumn();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Routes - Status - Value
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12370_Route_Management_View_Routes_Status_Value()
        {
            testCaseId = "TC-12370";
            qTestUniqueId = "26991099";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateStatusValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Routes - Default Filter
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12371_Route_Management_View_Routes_Default_Filter()
        {
            testCaseId = "TC-12371";
            qTestUniqueId = "26991100";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateUnassignedDefault();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Route Assignments - Readers button - Click - Readers Segment Displays
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12372_Route_Assignments_Readers_button_Click_Readers_Segment_Displays()
        {
            testCaseId = "TC-12372";
            qTestUniqueId = "26991202";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateReadersBtn();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments - Readers Segment - Name Displays
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12373_Route_Assignments_Readers_Segment_Name_Displays()
        {
            testCaseId = "TC-12373";
            qTestUniqueId = "26991275";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateReadersName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments - Readers Segment - Number of Routes Assigned Displays
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12374_Route_Assignments_Readers_Segment_Number_of_Routes_Assigned_Displays()
        {
            testCaseId = "TC-12374";
            qTestUniqueId = "26991313";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateReadersAssignedNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments - Readers button - Click - Readers Segment Hides
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12378_Route_Assignments_Readers_button_Click_Readers_Segment_Hides()
        {
            testCaseId = "TC-12378";
            qTestUniqueId = "26991568";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateReadersSegmentHides();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments - Readers Segment Displays - Readers button - Open state
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12379_Route_Assignments_Readers_Segment_Displays_Readers_button_Open_state()
        {
            testCaseId = "TC-12379";
            qTestUniqueId = "26991573";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateReadersButtonOpen();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Route Assignments - Readers Segment Displays - Readers button - Open state
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12380_Route_Assignments_Readers_Segment_Hidden_Readers_button_Closed_state()
        {
            testCaseId = "TC-12380";
            qTestUniqueId = "26991583";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateReadersButtonClosed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Roles Management_Route Management Permissions_View Route Management Dashboard_ Feature Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("SmokeTests")]
        [Test]
        public void TC_12177_Roles_Management_Route_Management_Permissions_View_Route_Management_Dashboard_Feature_Display()
        {
            testCaseId = "TC-12177";
            qTestUniqueId = "26032948";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateViewRouteManagementDashboard();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments_Edit Mode_No Data Changes_Cancel_View Mode Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12248_Route_Assignments_Edit_Mode_No_Data_Changes_Cancel_View_Mode_Display()
        {
            testCaseId = "TC-12248";
            qTestUniqueId = "26032948";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateEditRouteNotPresent();                
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments_Edit Mode_No Data Changes_Cancel_View Mode Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12249_Route_Assignments_Edit_Mode_No_Data_Changes_Cancel_View_Mode_Display()
        {
            testCaseId = "TC-12249";
            qTestUniqueId = "26161034";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateEditRouteNotPresent();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments_User Editing_No_Save Button_Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12254_Route_Assignments_User_Editing_No_Save_Button_Display()
        {
            testCaseId = "TC-12254";
            qTestUniqueId = "26161040";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateEditRouteSaveButtonDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments_User Editing_No_Save Button_Enabled
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12256_Route_Assignments_User_Editing_No_Save_Button_Enabled()
        {
            testCaseId = "TC-12254";
            qTestUniqueId = "26161040";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateEditRouteSaveButtonEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments - Readers Segment - Total Incomplete meter Displays
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12375_Route_Assignments_Readers_Segment_Total_Incomplete_meter_Displays()
        {
            testCaseId = "TC-12375";
            qTestUniqueId = "26161034";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateTotalIncompleteMeters();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments_Edit Mode_Data Changes_Cancel_Discard Changes Prompt_Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12385_Route_Assignments_Edit_Mode_Data_Changes_Cancel_Discard_Changes_Prompt_Display()
        {
            testCaseId = "TC-12385";
            qTestUniqueId = "26161034";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateDiscardAllChanges();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments_Edit Mode_Data Changes_Cancel_Discard Changes Prompt_Yes Button Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12386_Route_Assignments_Edit_Mode_Data_Changes_Cancel_Discard_Changes_Prompt_Yes_Button_Display()
        {
            testCaseId = "TC-12386";
            qTestUniqueId = "27106135";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateDiscardAllChanges();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments_Edit Mode_Data Changes_Cancel_Discard Changes Prompt_No Button Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12387_Route_Assignments_Edit_Mode_Data_Changes_Cancel_Discard_Changes_Prompt_No_Button_Display()
        {
            testCaseId = "TC-12387";
            qTestUniqueId = "27106135";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateDiscardAllChangesNoButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments_Edit Mode_Data Changes_Cancel_Discard Changes Prompt_No Button_Access
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12388_Route_Assignments_Edit_Mode_Data_Changes_Cancel_Discard_Changes_Prompt_No_Button_Access()
        {
            testCaseId = "TC-12388";
            qTestUniqueId = "27106137";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateDiscardAllChangesNoButtonAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments_Edit Mode_Data Changes_Cancel_Discard Changes Prompt_Yes Button Access
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12389_Route_Assignments_Edit_Mode_Data_Changes_Cancel_Discard_Changes_Prompt_Yes_Button_Access()
        {
            testCaseId = "TC-12389";
            qTestUniqueId = "27106138";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateDiscardAllChangesNoButtonAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Assignments_Edit Mode_Data Changes_Cancel_Discard Changes Prompt_Yes_View Mode Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12390_Route_Assignments_Edit_Mode_Data_Changes_Cancel_Discard_Changes_Prompt_Yes_View_Mode_Display()
        {
            testCaseId = "TC-12390";
            qTestUniqueId = "27106139";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateDiscardAllChangesNoButtonAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_Assign Route_Reader_Updated
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12678_Edit_Route_Assignments_Assign_Route_Reader_Updated()
        {
            testCaseId = "TC-12678";
            qTestUniqueId = "27362090";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAssignRouteReaderUpdated();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_Assign Route_Status Column_Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12680_Edit_Route_Assignments_Assign_Route_Status_Column_Display()
        {
            testCaseId = "TC-12680";
            qTestUniqueId = "27362695";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAssignRouteStatusDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_View Filter_Unassgined_Assigned Routes_Not Displayed
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12681_Edit_Route_Assignments_View_Filter_Unassgined_Assigned_Routes_Not_Displayed()
        {
            testCaseId = "TC-12681";
            qTestUniqueId = "27362706";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAssignRouteStatusDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_View Filter_All_Assigned Routes_Displayed
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12682_Edit_Route_Assignments_View_Filter_All_Assigned_Routes_Displayed()
        {
            testCaseId = "TC-12682";
            qTestUniqueId = "27362712";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAllRouteStatusDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_View Filter_Assigned_Assigned Routes_Displayed
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12683_Edit_Route_Assignments_View_Filter_Assigned_Assigned_Routes_Displayed()
        {
            testCaseId = "TC-12683";
            qTestUniqueId = "27362719";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAllRouteStatusDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_Assign Route_Total Routes Widget_Updated
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12684_Edit_Route_Assignments_Assign_Route_Total_Routes_Widget_Updated()
        {
            testCaseId = "TC-12684";
            qTestUniqueId = "27362728";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAllRouteStatusDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_Assign Route_Total Readers Widget_Updated
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12685_Edit_Route_Assignments_Assign_Route_Total_Readers_Widget_Updated()
        {
            testCaseId = "TC-12685";
            qTestUniqueId = "27362731";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAllRouteStatusDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_View Filter_Unassgined_Already Assigned Route_Reassign_Not Displayed
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12690_Edit_Route_Assignments_View_Filter_Unassgined_Already_Assigned_Route_Reassign_Not_Displayed()
        {
            testCaseId = "TC-12690";
            qTestUniqueId = "27362731";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAssignedRouteUnassignedNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_View Filter_All_Already Assigned Route_Reassign_Displayed
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12691_Edit_Route_Assignments_View_Filter_All_Already_Assigned_Route_Reassign_Displayed()
        {
            testCaseId = "TC-12691";
            qTestUniqueId = "27362859";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAssignedRouteUnassigned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_View Filter_Assigned_Already Assigned Route_Reassign_Displayed
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12692_Edit_Route_Assignments_View_Filter_Assigned_Already_Assigned_Route_Reassign_Displayed()
        {
            testCaseId = "TC-12692";
            qTestUniqueId = "27362860";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAssignedRouteReassigned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_Already Assigned Route_Reassign_Original Reader_Removed
        /// </summary>
        [Category("RouteManagement_Archived")]
        [Test]
        public void TC_12693_Edit_Route_Assignments_Already_Assigned_Route_Reassign_Original_Reader_Removed()
        {
            testCaseId = "TC-12693";
            qTestUniqueId = "27362861";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAssignedRouteReassigned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_Already Assigned Route_Reassign_New Reader Summary Totals_Updated
        /// </summary>
        [Category("RouteManagement_Archived")]
        [Test]
        public void TC_12694_Edit_Route_Assignments_Already_Assigned_Route_Reassign_New_Reader_Summary_Totals_Updated()
        {
            testCaseId = "TC-12694";
            qTestUniqueId = "27362862";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAssignedRouteReassigned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_Already Assigned Route_Loaded Status_Reassign_Reader_Updated
        /// </summary>
        [Category("RouteManagement_Archived")]
        [Test]
        public void TC_12695_Edit_Route_Assignments_Already_Assigned_Route_Loaded_Status_Reassign_Reader_Updated()
        {
            testCaseId = "TC-12695";
            qTestUniqueId = "27362863";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAssignedRouteReassigned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_Already Assigned Route_Loaded Status_Reassign_Reader Summary Totals_Updated
        /// </summary>
        [Category("RouteManagement_Archived")]
        [Test]
        public void TC_12695_Edit_Route_Assignments_Already_Assigned_Route_Loaded_Status_Reassign_Reader_Summary_Totals_Updated()
        {
            testCaseId = "TC-12695";
            qTestUniqueId = "27363427";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAssignedRouteReassignedMouseHover();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_Already Assigned Route_Loaded Status_Reassign_Reader Summary Totals_Updated
        /// </summary>
        [Category("RouteManagement_Archived")]
        [Test]
        public void TC_12696_Edit_Route_Assignments_Already_Assigned_Route_Loaded_Status_Reassign_Reader_Summary_Totals_Updated()
        {
            testCaseId = "TC-12696";
            qTestUniqueId = "27363427";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAssignedRouteReassignedMouseHover();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_Already Assigned Route_Loaded Status_Reassign_Status Column_Display
        /// </summary>
        [Category("RouteManagement_Archived")]
        [Test]
        public void TC_12697_Edit_Route_Assignments_Already_Assigned_Route_Loaded_Status_Reassign_Status_Column_Display()
        {
            testCaseId = "TC-12697";
            qTestUniqueId = "27363428";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAssignedRouteReassigned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_View Filter_Unassgined_Already Assigned Route_Loaded Status_Reassign_Not Displayed
        /// </summary>
        [Category("RouteManagement_Archived")]
        [Test]
        public void TC_12698_Edit_Route_Assignments_View_Filter_Unassgined_Already_Assigned_Route_Loaded_Status_Reassign_Not_Displayed()
        {
            testCaseId = "TC-12698";
            qTestUniqueId = "27363429";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAssignedRouteReassignedToUnassigned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_View Filter_All_Already Assigned Route_Loaded Status_Reassign_Displayed
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12699_Edit_Route_Assignments_View_Filter_All_Already_Assigned_Route_Loaded_Status_Reassign_Displayed()
        {
            testCaseId = "TC-12699";
            qTestUniqueId = "27363431";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateLoadedRouteUnassigned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_View Filter_Assigned_Already Assigned Route_Loaded Status_Reassign_Displayed
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12700_Edit_Route_Assignments_View_Filter_Assigned_Already_Assigned_Route_Loaded_Status_Reassign_Displayed()
        {
            testCaseId = "TC-12700";
            qTestUniqueId = "27363433";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateLoadedRouteUnassigned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_Already Assigned Route_Loaded Status_Reassign_Original Reader_Removed
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12701_Edit_Route_Assignments_Already_Assigned_Route_Loaded_Status_Reassign_Original_Reader_Removed()
        {
            testCaseId = "TC-12701";
            qTestUniqueId = "27363434";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateLoadedRouteUnassigned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_Already Assigned Route_Loaded Status_Reassign_New Reader Summary Totals_Updated
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12702_Edit_Route_Assignments_Already_Assigned_Route_Loaded_Status_Reassign_NewReader_Summary_Totals_Updated()
        {
            testCaseId = "TC-12702";
            qTestUniqueId = "27363435";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateLoadedRouteUnassignedHoverOver();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_Unloaded Status_Reader Assign_Reader Column_Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12703_Edit_Route_Assignments_Unloaded_Status_Reader_Assign_Reader_Column_Display()
        {
            testCaseId = "TC-12703";
            qTestUniqueId = "27363690";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateLoadedRouteSave();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Edit Route Assignments_Unloaded Status_Reader Assign_Reader Summary Totals_Updated
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12704_Edit_Route_Assignments_Unloaded_Status_Reader_Assign_Reader_Summary_Totals_Updated()
        {
            testCaseId = "TC-12704";
            qTestUniqueId = "27363691";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateLoadedRouteSaveHoverOver();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_Unloaded Status_Reader Assign_Status Column_Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12705_Edit_Route_Assignments_Unloaded_Status_Reader_Assign_Status_Column_Display()
        {
            testCaseId = "TC-12705";
            qTestUniqueId = "27363692";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateAssignedRouteReassignedViewAssigmnned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_View Filter_Unloaded_Assigned Unloaded Routes_Not Displayed
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12706_Edit_Route_Assignments_View_Filter_Unloaded_Assigned_Unloaded_Routes_Not_Displayed()
        {
            testCaseId = "TC-12706";
            qTestUniqueId = "27363693";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateUnloadedRouteReassigned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_View Filter_All_Assigned Unloaded Routes_Displayed
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12707_Edit_Route_Assignments_View_Filter_All_Assigned_Unloaded_Routes_Displayed()
        {
            testCaseId = "TC-12707";
            qTestUniqueId = "27363695";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateUnloadedRouteReassignedFilterAll();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit Route Assignments_View Filter_Assigned_Assigned Unloaded Routes_Displayed
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12708_Edit_Route_Assignments_View_Filter_Assigned_Assigned_Unloaded_Routes_Displayed()
        {
            testCaseId = "TC-12708";
            qTestUniqueId = "27363696";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateUnloadedRouteReassignedFilterAssigned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Filter - Unassigned
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12785_Route_Management_View_Filter_Unassigned()
        {
            testCaseId = "TC-12785";
            qTestUniqueId = "27430047";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateFilterUnassigned();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Filter - All
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12786_Route_Management_View_Filter_All()
        {
            testCaseId = "TC-12786";
            qTestUniqueId = "27430047";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateFilterAll();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Filter - Assigned
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12787_Route_Management_View_Filter_Assigned()
        {
            testCaseId = "TC-12787";
            qTestUniqueId = "27430049";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateFilterAll();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Filter - Assigned
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12788_Route_Management_View_Filter_Loaded()
        {
            testCaseId = "TC-12788";
            qTestUniqueId = "27430050";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateFilterLoaded();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -View Filter - Unloaded
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12789_Route_Management_View_Filter_Unloaded()
        {
            testCaseId = "TC-12789";
            qTestUniqueId = "27430051";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateFilterUnloaded();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -Filter by Reader - Valid Name
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12790_Route_Management_Filter_By_Reader_Valid_Name()
        {
            testCaseId = "TC-12790";
            qTestUniqueId = "27430052";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateValidName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -Filter by Reader - Invalid Name
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12791_Route_Management_Filter_By_Reader_Invalid_Name()
        {
            testCaseId = "TC-12791";
            qTestUniqueId = "27430053";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateInvalidName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -Filter by Reader - Blank Name
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12792_Route_Management_Filter_by_Reader_Blank_Name()
        {
            testCaseId = "TC-12792";
            qTestUniqueId = "27430054";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateBlankNameFilterDisabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -Filter by Reader - Clear
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12793_Route_Management_Filter_by_Reader_Clear()
        {
            testCaseId = "TC-12793";
            qTestUniqueId = "27430055";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateClearButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -Filter by Route - Valid Route Name
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12794_Route_Management_Filter_by_Route_Valid_Route_Name()
        {
            testCaseId = "TC-12794";
            qTestUniqueId = "27430056";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateFilterRoutePartial();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -Filter by Route - Invalid Route Name
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12795_Route_Management_Filter_by_Route_Invalid_Route_Name()
        {
            testCaseId = "TC-12795";
            qTestUniqueId = "27430057";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateFilterRouteInvalidName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -Filter by Route - Blank Route Name
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12796_Route_Management_Filter_by_Route_Blank_Route_Name()
        {
            testCaseId = "TC-12796";
            qTestUniqueId = "27430058";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateFilterRouteBlankName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Route Management -Filter by Route - Clear
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12797_Route_Management_Filter_by_Route_Clear()
        {
            testCaseId = "TC-12797";
            qTestUniqueId = "27430059";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateRouteManagementPage(url, userName, password);
                routeManagement.ValidateClearRouteName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Roles Management_Left Navigation Permissions_Route Management_Listed
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13418_Roles_Management_Left_Navigation_Permissions_Route_Management_Listed()
        {
            testCaseId = "TC-13418";
            qTestUniqueId = "28988533";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavRolesPermissions(url, userName, password);
                rolesPermissons.ValidateRouteManagementLeftNav();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Roles Management_Left Navigation Permissions_Route Management_ Widget Listed
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13419_Roles_Management_Left_Navigation_Permissions_Route_Management_WidgetListed()
        {
            testCaseId = "TC-13419";
            qTestUniqueId = "28988563";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavRolesPermissions(url, userName, password);
                rolesPermissons.ValidateRouteManagementWidgetDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Roles Management_Landing Page Permissions_Route Management Widget_ Feature_Editable
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13420_Roles_Management_Landing_Page_Permissions_Route_Management_Widget__Feature_Editable()
        {
            testCaseId = "TC-13420";
            qTestUniqueId = "28988810";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavRolesPermissions(url, userName, password);
                rolesPermissons.ValidateRouteManagementWidgetEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Roles Management_Left Navigation Permissions_Route Management_ Feature_Editable
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13421_Roles_Management_Left_Navigation_Permissions_Route_Management_Feature_Editable()
        {
            testCaseId = "TC-13421";
            qTestUniqueId = "28988833";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavRolesPermissions(url, userName, password);
                rolesPermissons.ValidateRouteManagementLeftNavEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Roles Management_Route Management Permissions_View Route Management Dashboard_ Feature Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13422_Roles_Management_Route_Management_Permissions_View_Route_Management_Dashboard_Feature_Display()
        {
            testCaseId = "TC-13422";
            qTestUniqueId = "28988978";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavRolesPermissions(url, userName, password);
                rolesPermissons.ValidateViewRouteManagementDashboard();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Roles Management_Route Management Permissions_View Route Management Dashboard_ Feature_Editable
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13423_Roles_Management_Route_Management_Permissions_View_Route_Management_Dashboard_Feature_Editable()
        {
            testCaseId = "TC-13423";
            qTestUniqueId = "28989013";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavRolesPermissions(url, userName, password);
                rolesPermissons.ValidateViewRouteManagementDashboardEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Roles Management_Left Navigation Permissions_Route Assignments_Listed
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13436_Roles_Management_Left_Navigation_Permissions_Route_Assignments_Listed()
        {
            testCaseId = "TC-13436";
            qTestUniqueId = "29045485";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavRolesPermissions(url, userName, password);
                rolesPermissons.ValidateViewRouteAssignmentLftNav();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Roles Management_Left Navigation Permissions_Route Assignments_ Feature_Editable
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13437_Roles_Management_Left_Navigation_Permissions_Route_Assignments__Feature_Editable()
        {
            testCaseId = "TC-13437";
            qTestUniqueId = "29045518";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavRolesPermissions(url, userName, password);
                rolesPermissons.ValidateViewRouteAssignmentLftNav();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Roles Management_Route Management Permissions_Route Assignment Screen_ Feature Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13451_Roles_Management_Route_Management_Permissions_Route_Assignment_Screen_Feature_Display()
        {
            testCaseId = "TC-13451";
            qTestUniqueId = "29210468";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavRolesPermissions(url, userName, password);
                rolesPermissons.ValidateViewRouteAssignmentScreen();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Roles Management_Route Management Permissions_Route Assignment Screen_ Feature_Editable
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13452_Roles_Management_Route_Management_Permissions_Route_Assignment_Screen_Feature_Editable()
        {
            testCaseId = "TC-13452";
            qTestUniqueId = "29210478";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavRolesPermissions(url, userName, password);
                rolesPermissons.ValidateViewRouteAssignmentScreenEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Roles Management_Route Management Permissions_Display As Reader_ Feature Display
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13453_Roles_Management_Route_Management_Permissions_Display_As_Reader_Feature_Display()
        {
            testCaseId = "TC-13453";
            qTestUniqueId = "29210674";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavRolesPermissions(url, userName, password);
                rolesPermissons.ValidateViewEditAssignmentPermission();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Roles Management_Route Management Permissions_Display As Reader_ Feature_Editable
        /// </summary>
        [Category("RouteManagement")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13455_Roles_Management_Route_Management_Permissions_Display_As_Reader_Feature_Editable()
        {
            testCaseId = "TC-13455";
            qTestUniqueId = "29210697";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavRolesPermissions(url, userName, password);
                rolesPermissons.ValidateDisplayAsReaderEditable();
                home.UserLogOut();
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