using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public class Groups : TestBaseTemplate
    {
        /// <summary>
        /// Test Method to GROUPS_Create Button_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests")]
        [Test]
        public void TC_18255_GROUPS_Create_Button_Display()
        {
            testCaseId = "TC-18255";
            qTestUniqueId = "39436883";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateCreateButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create Button_Click
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests")]
        [Test]
        public void TC_18256_GROUPS_Create_Button_Click()
        {
            testCaseId = "TC-18256";
            qTestUniqueId = "39436884";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateCreateButtonClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Group Name_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests")]
        [Test]
        public void TC_18257_GROUPS_Create_New_Group_Group_Name_Display()
        {
            testCaseId = "TC-18257";
            qTestUniqueId = "42377493";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateCreateButtonClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Group Name_Max Length
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18258_GROUPS_Create_New_Group_Group_Name_Max_Length()
        {
            testCaseId = "TC-18258";
            qTestUniqueId = "39436893";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupNameMaxLength(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Group Name_Not Unique_Error Message
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18259_GROUPS_Create_New_Group_Group_Name_Not_Unique_Error_Message()
        {
            testCaseId = "TC-18259";
            qTestUniqueId = "39437057";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupNameErrorMsg(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Group Name_Mandatory
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18260_GROUPS_Create_New_Group_Group_Name_Mandatory()
        {
            testCaseId = "TC-18260";
            qTestUniqueId = "39437058";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupNameMandatory(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Group Description_Optional Field
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18261_GROUPS_Create_New_Group_Group_Description_Optional_Field()
        {
            testCaseId = "TC-18261";
            qTestUniqueId = "39437545";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupDescOptional(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Group Description_Max Length
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18262_GROUPS_Create_New_Group_Group_Description_Max_Length()
        {
            testCaseId = "TC-18262";
            qTestUniqueId = "39437547";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                lastName = testData["LastName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupDescMaxLength(lastName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Cancel button_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18263_GROUPS_Create_New_Group_Cancel_button_Display()
        {
            testCaseId = "TC-18263";
            qTestUniqueId = "39437550";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateCancelButtonDislay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Add Endpoints button_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18264_GROUPS_Create_New_Group_Add_Endpoints_button_Display()
        {
            testCaseId = "TC-18264";
            qTestUniqueId = "39437553";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointButtonDislay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Finish button_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18265_GROUPS_Create_New_Group_Finish_button_Display()
        {
            testCaseId = "TC-18265";
            qTestUniqueId = "39437555";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateFinishButtonDislay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Cancel button_Access
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18266_GROUPS_Create_New_Group_Cancel_button_Access()
        {
            testCaseId = "TC-18266";
            qTestUniqueId = "39437558";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateCancelButtonAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Finish button_Success Toast
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18267_GROUPS_Create_New_Group_Finish_button_Success_Toast()
        {
            testCaseId = "TC-18267";
            qTestUniqueId = "39437559";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateCreateGroupSuccessToast(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Finish button_Screen Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18268_GROUPS_Create_New_Group_Finish_button_Screen_Display()
        {
            testCaseId = "TC-18268";
            qTestUniqueId = "39437563";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateCreateGroupSuccessToast(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Finish button_New Group_List
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18269_GROUPS_Create_New_Group_Finish_button_New_Group_List()
        {
            testCaseId = "TC-18269";
            qTestUniqueId = "39437564";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateNameinGroupList(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Finish button_Last Updated Date
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18270_GROUPS_Create_New_Group_Finish_button_Last_Updated_Date()
        {
            testCaseId = "TC-18270";
            qTestUniqueId = "39437565";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateLastUpdatedDateinGroupList(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Finish button_Access
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18271_GROUPS_Create_New_Group_Finish_button_Access()
        {
            testCaseId = "TC-18271";
            qTestUniqueId = "39437569";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateFinishButtonAccessinGroupList(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Add EndPoints Button_Group Name_Not Unique_Error Message
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18272_GROUPS_Create_New_Group_Add_EndPoints_Button_Group_Name_Not_Unique_Error_Message()
        {
            testCaseId = "TC-18272";
            qTestUniqueId = "39438567";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointButtonNotUniqueErrorMsg(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Add Endpoints Button_Group Name_Not Populated_Error Message
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18273_GROUPS_Create_New_Group_Add_Endpoints_Button_Group_Name_Not_Populated_Error_Message()
        {
            testCaseId = "TC-18273";
            qTestUniqueId = "39438568";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointButtonNoGrpName(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create New Group_Add Endpoints Button_Access
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18274_GROUPS_Create_New_Group_Add_Endpoints_Button_Access()
        {
            testCaseId = "TC-18274";
            qTestUniqueId = "39438601";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateAddEndpointButtonAccess(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Delete Button_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18275_GROUPS_Delete_Button_Display()
        {
            testCaseId = "TC-18275";
            qTestUniqueId = "39449263";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateDeleteButtonDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Groups_Delete Access_Warning Dialog_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18276_Groups_Delete_Access_Warning_Dialog_Display()
        {
            testCaseId = "TC-18276";
            qTestUniqueId = "39449264";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateDeleteWarning();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Groups_Delete Access_Warning Dialog_Contents
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18277_Groups_Delete_Access_Warning_Dialog_Contents()
        {
            testCaseId = "TC-18277";
            qTestUniqueId = "39449266";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateDeleteDialogContents();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Groups_Delete Group_Warning Prompt_Cancel Button_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18278_Groups_Delete_Group_Warning_Prompt_Cancel_Button_Display()
        {
            testCaseId = "TC-18278";
            qTestUniqueId = "39449268";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateDeleteDialogCancelButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Groups_Delete Group_Warning Prompt_Delete Button_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18279_Groups_Delete_Group_Warning_Prompt_Delete_Button_Display()
        {
            testCaseId = "TC-18279";
            qTestUniqueId = "39449269";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateDeleteDialogDeleteButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Groups_Delete Group_Warning Prompt_Cancel Button_Access
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18280_Groups_Delete_Group_Warning_Prompt_Cancel_Button_Access()
        {
            testCaseId = "TC-18280";
            qTestUniqueId = "39449272";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateDeleteDialogDeleteAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Groups_Delete Group_Delete Dialog_Delete Button_Access
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18281_Groups_Delete_Group_Delete_Dialog_Delete_Button_Access()
        {
            testCaseId = "TC-18281";
            qTestUniqueId = "39449272";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateDeleteDialogDeleteAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Groups_Delete Group_Warning Prompt_Delete Button_Toast Message
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18282_Groups_Delete_Group_Warning_Prompt_Delete_Button_Toast_Message()
        {
            testCaseId = "TC-18282";
            qTestUniqueId = "39449275";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateDeleteGroupToastMsg();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Groups_Delete Group_Screen Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18283_Groups_Delete_Group_Screen_Display()
        {
            testCaseId = "TC-18283";
            qTestUniqueId = "39449277";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateDeleteGroupToastMsg();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Groups_Delete Group_Associated Endpoints_No Effect
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18284_Groups_Delete_Group_Associated_Endpoints_No_Effect()
        {
            testCaseId = "TC-18284";
            qTestUniqueId = "39449278";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateDeleteGroupToastMsg();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Groups_Edit Group Button_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18285_Groups_Edit_Group_Button_Display()
        {
            testCaseId = "TC-18285";
            qTestUniqueId = "39449545";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditButtonDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Groups_Edit Group_Access
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18286_Groups_Edit_Group_Access()
        {
            testCaseId = "TC-18286";
            qTestUniqueId = "39449546";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditButtonAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Cancel button_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18287_GROUPS_Edit_Group_Cancel_button_Display()
        {
            testCaseId = "TC-18287";
            qTestUniqueId = "39449547";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditCancelDispay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Add Endpoints button_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18288_GROUPS_Edit_Group_Add_Endpoints_button_Display()
        {
            testCaseId = "TC-18288";
            qTestUniqueId = "39449548";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditAddEndpointDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Save button_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18289_GROUPS_Edit_Group_Save_button_Display()
        {
            testCaseId = "TC-18289";
            qTestUniqueId = "39449549";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditFinishDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Cancel button_Access
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18290_GROUPS_Edit_Group_Cancel_button_Access()
        {
            testCaseId = "TC-18290";
            qTestUniqueId = "39449550";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditCancelAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Group Description_Optional Field
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18291_GROUPS_Edit_Group_Group_Description_Optional_Field()
        {
            testCaseId = "TC-18291";
            qTestUniqueId = "39449552";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditDescription();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Group Description_Max Length
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18292_GROUPS_Edit_Group_Group_Description_Max_Length()
        {
            testCaseId = "TC-18292";
            qTestUniqueId = "39449553";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                lastName = testData["LastName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditGroupDescMaxLength(lastName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Group Description_Modified_Other Data Unchanged
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18293_GROUPS_Edit_Group_Group_Description_Modified_Other_Data_Unchanged()
        {
            testCaseId = "TC-18293";
            qTestUniqueId = "39449554";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                lastName = testData["LastName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditGroupUnchanged(lastName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Group Name_Not Unique_Error Message
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18294_GROUPS_Edit_Group_Group_Name_Not_Unique_Error_Message()
        {
            testCaseId = "TC-18294";
            qTestUniqueId = "39449555";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditGroupErrorMsg(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Group Name_Mandatory
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18295_GROUPS_Edit_Group_Group_Name_Mandatory()
        {
            testCaseId = "TC-18295";
            qTestUniqueId = "39449556";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditGroupNameMandatory(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Group Name_Max Length
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18296_GROUPS_Edit_Group_Group_Name_Max_Length()
        {
            testCaseId = "TC-18296";
            qTestUniqueId = "39449558";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditGroupNameMaxLength(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Group Name_Modified_Other Data Unchanged
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18297_GROUPS_Edit_Group_Group_Name_Modified_Other_Data_Unchanged()
        {
            testCaseId = "TC-18297";
            qTestUniqueId = "39449559";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditGroupUnchanged();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Group Name_Modified_No New Group Created
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18298_GROUPS_Edit_Group_Group_Name_Modified_No_New_Group_Created()
        {
            testCaseId = "TC-18298";
            qTestUniqueId = "39449563";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditGroupNameChanged(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Group Name_Editable
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18299_GROUPS_Edit_Group_Group_Name_Editable()
        {
            testCaseId = "TC-18299";
            qTestUniqueId = "39449565";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupNameEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Add Endpoints Button_Group Name_Not Unique_Error Message
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18324_GROUPS_Edit_Group_Add_Endpoints_Button_Group_Name_Not_Unique_Error_Message()
        {
            testCaseId = "TC-18324";
            qTestUniqueId = "39544247";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditGroupNameAddEndpoint(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Add Endpoints Button_Access
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18326_GROUPS_Edit_Group_Add_Endpoints_Button_Access()
        {
            testCaseId = "TC-18326";
            qTestUniqueId = "39544265";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditGroupNameAddEndpointAccess(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Add Endpoints Button_Success Toast
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18327_GROUPS_Edit_Group_Add_Endpoints_Button_Success_Toast()
        {
            testCaseId = "TC-18327";
            qTestUniqueId = "39544277";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditGroupNameAddEndpoint(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Edit Group_Save Button_Access
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18328_GROUPS_Edit_Group_Save_Button_Access()
        {
            testCaseId = "TC-18328";
            qTestUniqueId = "39544286";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditGroupNameChanged(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Save Button_Success Toast
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18329_GROUPS_Edit_Group_Save_Button_Success_Toast()
        {
            testCaseId = "TC-18329";
            qTestUniqueId = "39544293";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditGroupNameToastMessage(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Group Name_Updated Name_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18330_GROUPS_Edit_Group_Group_Name_Updated_Name_Display()
        {
            testCaseId = "TC-18330";
            qTestUniqueId = "39544303";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditGroupNameToastMessage(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Group Name_Previous Name_Not Displayed
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18331_GROUPS_Edit_Group_Group_Name_Previous_Name_Not_Displayed()
        {
            testCaseId = "TC-18331";
            qTestUniqueId = "39544311";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditGroupNameChanged(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Group Description_Updated Description_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18332_GROUPS_Edit_Group_Group_Description_Updated_Description_Display()
        {
            testCaseId = "TC-18332";
            qTestUniqueId = "39544319";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                lastName = testData["LastName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditDescription(lastName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Save button_Last Updated Date
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18333_GROUPS_Edit_Group_Save_button_Last_Updated_Date()
        {
            testCaseId = "TC-18333";
            qTestUniqueId = "39544326";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditGroupDateUpdated(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Group_Add Endpoints button_Last Updated Date
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18334_GROUPS_Edit_Group_Add_Endpoints_button_Last_Updated_Date()
        {
            testCaseId = "TC-18334";
            qTestUniqueId = "39544333";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditGroupAddEndpointLastDate(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Option_Access
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18425_GROUPS_Option_Access()
        {
            testCaseId = "TC-18425";
            qTestUniqueId = "39718296";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupsList();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Properties
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18426_GROUPS_View_Existing_List_Properties()
        {
            testCaseId = "TC-18426";
            qTestUniqueId = "39718366";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupsPorperties(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Sort Order
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18427_GROUPS_View_Existing_List_Sort_Order()
        {
            testCaseId = "TC-18427";
            qTestUniqueId = "39718368";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupsSortOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_View Existing List_Number of Endpoints_Sorting
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18428_GROUPS_View_Existing_List_Number_of_Endpoints_Sorting()
        {
            testCaseId = "TC-18428";
            qTestUniqueId = "39718370";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointsSortOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Last Updated Date_Sorting
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18429_GROUPS_View_Existing_List_Last_Updated_Date_Sorting()
        {
            testCaseId = "TC-18429";
            qTestUniqueId = "39718714";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateLastUpdatedSortOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Name_Sorting
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18430_GROUPS_View_Existing_List_Group_Name_Sorting()
        {
            testCaseId = "TC-18430";
            qTestUniqueId = "39718716";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupNameSorting();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Name_Search_Available
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18431_GROUPS_View_Existing_List_Group_Name_Search_Available()
        {
            testCaseId = "TC-18431";
            qTestUniqueId = "39718728";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupsSortOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Name_Search_Partial
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18432_GROUPS_View_Existing_List_Group_Name_Search_Partial()
        {
            testCaseId = "TC-18432";
            qTestUniqueId = "39718729";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupNamePartialSearch();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Name_Search_Exact
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18433_GROUPS_View_Existing_List_Group_Name_Search_Exact()
        {
            testCaseId = "TC-18433";
            qTestUniqueId = "39718730";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupNameExactSearch(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Name_Search_No Match
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18434_GROUPS_View_Existing_List_Group_Name_Search_No_Match()
        {
            testCaseId = "TC-18434";
            qTestUniqueId = "39718731";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupNameExactSearch(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_View Existing List_Scroll Bar_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18435_GROUPS_View_Existing_List_Scroll_Bar_Display()
        {
            testCaseId = "TC-18435";
            qTestUniqueId = "39718754";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupNameScrollBar();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group_Select
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18436_GROUPS_View_Existing_List_Group_Select()
        {
            testCaseId = "TC-18436";
            qTestUniqueId = "39718755";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateSelectGroup(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group_Select_Group Description_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18437_GROUPS_View_Existing_List_Group_Select_Group_Description_Display()
        {
            testCaseId = "TC-18437";
            qTestUniqueId = "39718756";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupDescription(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18438_GROUPS_View_Existing_List_Group_Select_List_of_Endpoints_Display()
        {
            testCaseId = "TC-18438";
            qTestUniqueId = "39718757";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointList();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group_Select_List of Endpoints_Properties
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18439_GROUPS_View_Existing_List_Group_Select_List_of_Endpoints_Properties()
        {
            testCaseId = "TC-18439";
            qTestUniqueId = "39718758";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointProperties();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group_Select_List of Endpoints_Sort Order
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18440_GROUPS_View_Existing_List_Group_Select_List_of_Endpoints_Sort_Order()
        {
            testCaseId = "TC-18440";
            qTestUniqueId = "39718759";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateDefaultEndpointSortorder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group_Select_List of Endpoints_Scroll Bar_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18441_GROUPS_View_Existing_List_Group_Select_List_of_Endpoints_Scroll_Bar_Display()
        {
            testCaseId = "TC-18441";
            qTestUniqueId = "39718760";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointPageThrough(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group_Select_Edit_Enabled
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18442_GROUPS_View_Existing_List_Group_Select_Edit_Enabled()
        {
            testCaseId = "TC-18442";
            qTestUniqueId = "39718761";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditButtonDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group_Select_Delete_Enabled
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18443_GROUPS_View_Existing_List_Group_Select_Delete_Enabled()
        {
            testCaseId = "TC-18443";
            qTestUniqueId = "39718765";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateDeleteButtonDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group_Select_Add Endpoints_Enabled
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18444_GROUPS_View_Existing_List_Group_Select_Add_Endpoints_Enabled()
        {
            testCaseId = "TC-18444";
            qTestUniqueId = "39718767";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGrpPageEndpointButtonDislay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Sort_Account Name
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18445_GROUPS_View_Existing_List_Group_Members_Sort_Account_Name()
        {
            testCaseId = "TC-18445";
            qTestUniqueId = "39737422";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateDefaultEndpointSortorder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Sort_Account Number
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18446_GROUPS_View_Existing_List_Group_Members_Sort_Account_Number()
        {
            testCaseId = "TC-18446";
            qTestUniqueId = "39737435";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointSortorderAccNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Sort_Address
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18447_GROUPS_View_Existing_List_Group_Members_Sort_Address()
        {
            testCaseId = "TC-18447";
            qTestUniqueId = "39737436";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointSortorderAddress();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Sort_MIU_ID
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18448_GROUPS_View_Existing_List_Group_Members_Sort_MIU_ID()
        {
            testCaseId = "TC-18448";
            qTestUniqueId = "39737437";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointSortorderMIUID();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Sort_Meter ID
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18449_GROUPS_View_Existing_List_Group_Members_Sort_Meter_ID()
        {
            testCaseId = "TC-18449";
            qTestUniqueId = "39737440";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointSortorderMeterID();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Sort_Meter Size
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18450_GROUPS_View_Existing_List_Group_Members_Sort_Meter_Size()
        {
            testCaseId = "TC-18450";
            qTestUniqueId = "39737441";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointSortorderMeterSize();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Sort_Meter Classification
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18451_GROUPS_View_Existing_List_Group_Members_Sort_Meter_Classification()
        {
            testCaseId = "TC-18451";
            qTestUniqueId = "39737442";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointSortorderClassification(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Sort_Support One Level
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18452_GROUPS_View_Existing_List_Group_Members_Sort_Support_One_Level()
        {
            testCaseId = "TC-18452";
            qTestUniqueId = "39737529";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointSortOneLevel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Select Option_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18453_GROUPS_View_Existing_List_Group_Members_Select_Option_Display()
        {
            testCaseId = "TC-18453";
            qTestUniqueId = "39737530";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupMembersSelectOption();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Select Option_Select Page
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18454_GROUPS_View_Existing_List_Group_Members_Select_Option_Select_Page()
        {
            testCaseId = "TC-18454";
            qTestUniqueId = "39737531";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupMembersSelectPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Select Option_Select All
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18455_GROUPS_View_Existing_List_Group_Members_Select_Option_Select_All()
        {
            testCaseId = "TC-18455";
            qTestUniqueId = "39737532";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupMembersSelectAll();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Deselect All Option_Access
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18456_GROUPS_View_Existing_List_Group_Members_Deselect_All_Option_Access()
        {
            testCaseId = "TC-18456";
            qTestUniqueId = "39737534";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupMembersDeselectAll();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Selected Count_Update
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18457_GROUPS_View_Existing_List_Group_Members_Selected_Count_Update()
        {
            testCaseId = "TC-18457";
            qTestUniqueId = "39737535";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateSelectCountUpdate(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Deselected Count_Update
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18458_GROUPS_View_Existing_List_Group_Members_Deselected_Count_Update()
        {
            testCaseId = "TC-18458";
            qTestUniqueId = "39737536";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateDeselectCountUpdate(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Selections Made_Retained_All Pages
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18459_GROUPS_View_Existing_List_Group_Members_Selections_Made_Retained_All_Pages()
        {
            testCaseId = "TC-18459";
            qTestUniqueId = "39737540";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateRetainedPage(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Selections Made_Retained_All Pages
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18460_GROUPS_View_Existing_List_Group_Members_Selections_Made_Retained_All_Pages()
        {
            testCaseId = "TC-18460";
            qTestUniqueId = "39737540";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateRetainedPage(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Groups_View_No Groups Available_Create Button Enabled_Message Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18500_Groups_View_No_Groups_Available_Create_Button_Enabled_Message_Display()
        {
            testCaseId = "TC-18500";
            qTestUniqueId = "39837042";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateNoEndpointExist(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Groups_View_No Groups Available_Create Button Enabled_Create Button_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18501_Groups_View_No_Groups_Available_Create_Button_Enabled_Create_Button_Display()
        {
            testCaseId = "TC-18501";
            qTestUniqueId = "39837043";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateNoEndpointExistCreateButtonEnabled(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Groups_View_No Groups Available_Create Button Enabled_Create Button_Access
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18502_Groups_View_No_Groups_Available_Create_Button_Enabled_Create_Button_Access()
        {
            testCaseId = "TC-18502";
            qTestUniqueId = "39837046";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateNoEndpointExistCreateButtonAccess(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Groups_View_No Groups Available_Create Button Not Enabled_Message Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18503_Groups_View_No_Groups_Available_Create_Button_Not_Enabled_Message_Display()
        {
            testCaseId = "TC-18503";
            qTestUniqueId = "39837048";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateNoGroupExist(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Not Available_Edit Permission Disabled_Message Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18687_GROUPS_View_Existing_List_Group_Members_Not_Available_Edit_Permission_Disabled_Message_Display()
        {
            testCaseId = "TC-18687";
            qTestUniqueId = "39877496";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateNoEndpointExist(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Not Available_Message Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18688_GROUPS_View_Existing_List_Group_Members_Not_Available_Message_Display()
        {
            testCaseId = "TC-18688";
            qTestUniqueId = "39877497";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateNoEndpointExist(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Not Available_Add Endpoints Button Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18689_GROUPS_View_Existing_List_Group_Members_Not_Available_Add_Endpoints_Button_Display()
        {
            testCaseId = "TC-18689";
            qTestUniqueId = "39877498";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateNoEndpointAddEndpoint(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Not Available_Add Endpoints Button_Accessible
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18690_GROUPS_View_Existing_List_Group_Members_Not_Available_Add_Endpoints_Button_Accessible()
        {
            testCaseId = "TC-18690";
            qTestUniqueId = "39877499";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateNoEndpointAddEndpointAccess(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18691_GROUPS_View_Existing_List_Group_Members_Display()
        {
            testCaseId = "TC-18691";
            qTestUniqueId = "39877500";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointList();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Remove Endpoints button_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18692_GROUPS_View_Existing_List_Group_Members_Remove_Endpoints_button_Display()
        {
            testCaseId = "TC-18692";
            qTestUniqueId = "39878813";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateRemoveEndpoint(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Remove Endpoints_Select One Endpoint
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18693_GROUPS_View_Existing_List_Group_Members_Remove_Endpoints_Select_One_Endpoint()
        {
            testCaseId = "TC-18693";
            qTestUniqueId = "39878816";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateRemoveEndpoint(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Remove Endpoints_Select Multiple Endpoints
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18694_GROUPS_View_Existing_List_Group_Members_Remove_Endpoints_Select_Multiple_Endpoints()
        {
            testCaseId = "TC-18694";
            qTestUniqueId = "39878820";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateMultipleEndpointRemove(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Remove Endpoints_Select All Endpoints
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18695_GROUPS_View_Existing_List_Group_Members_Remove_Endpoints_Select_All_Endpoints()
        {
            testCaseId = "TC-18695";
            qTestUniqueId = "39878821";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateAllEndpointRemove(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Remove Endpoints _Access_Confirmation dialog
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18696_GROUPS_View_Existing_List_Group_Members_Remove_Endpoints_Access_Confirmation_dialog()
        {
            testCaseId = "TC-18696";
            qTestUniqueId = "39878823";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateRemoveEndpointConfirmationDialog(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Remove Endpoints_Success Toast message
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18697_GROUPS_View_Existing_List_Group_Members_Remove_Endpoints_Success_Toast_message()
        {
            testCaseId = "TC-18697";
            qTestUniqueId = "39878824";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = "Automation";
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateRemoveEndpointSuccessToast(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Remove Endpoints_Last Update Date
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18698_GROUPS_View_Existing_List_Group_Members_Remove_Endpoints_Last_Update_Date()
        {
            testCaseId = "TC-18698";
            qTestUniqueId = "39878825";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = "Automation";
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateRemoveEndpointLastUpdatedDate(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Remove Endpoints_Not displayed
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18699_GROUPS_View_Existing_List_Group_Members_Remove_Endpoints_Not_displayed()
        {
            testCaseId = "TC-18699";
            qTestUniqueId = "39878826";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateRemoveEndpointLastUpdatedDate(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Remove Endpoints_Filtered View_Not Displayed
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18700_GROUPS_View_Existing_List_Group_Members_Remove_Endpoints_Filtered_View_Not_Displayed()
        {
            testCaseId = "TC-18700";
            qTestUniqueId = "39878827";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateRemoveEndpointLastUpdatedDate(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Classification_Default Value
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18775_GROUPS_View_Existing_List_Group_Members_Classification_Default_Value()
        {
            testCaseId = "TC-18775";
            qTestUniqueId = "40013792";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = "Automation";
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointDefaultValue(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Classification_Values
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18776_GROUPS_View_Existing_List_Group_Members_Classification_Values()
        {
            testCaseId = "TC-18776";
            qTestUniqueId = "40013796";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = "Automation";
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateClassificationValues(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Classification Mandatory
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18777_GROUPS_View_Existing_List_Group_Members_Classification_Mandatory()
        {
            testCaseId = "TC-18777";
            qTestUniqueId = "40013797";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = "Automation";
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointDefaultValue(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Classification Single Endpoint_Edit
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18778_GROUPS_View_Existing_List_Group_Members_Classification_Single_Endpoint_Edit()
        {
            testCaseId = "TC-18778";
            qTestUniqueId = "40013798";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = "Automation";
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditClassification(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Classification_Batch Edit
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18779_GROUPS_View_Existing_List_Group_Members_Classification_Batch_Edit()
        {
            testCaseId = "TC-18779";
            qTestUniqueId = "40013799";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = "Automation";
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateBatchEditClassification(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Classification_Button_Enabled
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18780_GROUPS_View_Existing_List_Group_Members_Classification_Button_Enabled()
        {
            testCaseId = "TC-18780";
            qTestUniqueId = "40013800";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateClassificationBtnEnable(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Classification_Button_Disabled
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18781_GROUPS_View_Existing_List_Group_Members_Classification_Button_Disabled()
        {
            testCaseId = "TC-18781";
            qTestUniqueId = "40013801";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateClassificationBtnDisable(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Same Endpoint_Different Groups_Classified Differently
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18782_GROUPS_View_Existing_List_Same_Endpoint_Different_Groups_Classified_Differently()
        {
            testCaseId = "TC-18782";
            qTestUniqueId = "40013802";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = "Automation";
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateBatchEditClassification(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18833_GROUPS_Search_Endpoints_Advanced_Search_Display()
        {
            testCaseId = "TC-18833";
            qTestUniqueId = "40054017";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateSearchEndpoints();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Account Advanced Search_Account Number_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18834_GROUPS_Search_Endpoints_Account_Advanced_Search_Account_Number_Display()
        {
            testCaseId = "TC-18834";
            qTestUniqueId = "40054019";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAccNoTextBoxDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Account Advanced Search_Account Name_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18835_GROUPS_Search_Endpoints_Account_Advanced_Search_Account_Name_Display()
        {
            testCaseId = "TC-18835";
            qTestUniqueId = "40054020";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAccNameTextBoxDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Address/Premises Advanced Search_Premises Key_displays
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18836_GROUPS_Search_Endpoints_Address_Premises_Advanced_Search_Premises_Key_displays()
        {
            testCaseId = "TC-18836";
            qTestUniqueId = "40054021";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddressTextBoxDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Address/Premises Advanced Search_Address_displays
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18837_GROUPS_Search_Endpoints_Address_Premises_Advanced_Search_Address_displays()
        {
            testCaseId = "TC-18837";
            qTestUniqueId = "40054022";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddressTextBoxDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Address/Premises Advanced Search_City_displays
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18838_GROUPS_Search_Endpoints_Address_Premises_Advanced_Search_City_displays()
        {
            testCaseId = "TC-18838";
            qTestUniqueId = "40054023";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateCityTextBoxDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Address/Premises Advanced Search_Zip_displays
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18839_GROUPS_Search_Endpoints_Address_Premises_Advanced_Search_Zip_displays()
        {
            testCaseId = "TC-18839";
            qTestUniqueId = "40054024";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateZipTextBoxDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Address/Premises Advanced Search_MIU ID_displays
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18840_GROUPS_Search_Endpoints_Address_Premises_Advanced_Search_MIU_ID_displays()
        {
            testCaseId = "TC-18840";
            qTestUniqueId = "40054025";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMIUIdTextBoxDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Address/Premises Advanced Search_MIU Status_displays
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18841_GROUPS_Search_Endpoints_Address_Premises_Advanced_Search_MIU_Status_displays()
        {
            testCaseId = "TC-18841";
            qTestUniqueId = "40054026";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMIUStatusDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Address/Premises Advanced Search_Meter ID_displays
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18842_GROUPS_Search_Endpoints_Address_Premises_Advanced_Search_Meter_ID_displays()
        {
            testCaseId = "TC-18842";
            qTestUniqueId = "40054027";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMeterIDDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Address/Premises Advanced Search_Meter Size_displays
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18843_GROUPS_Search_Endpoints_Address_Premises_Advanced_Search_Meter_Size_displays()
        {
            testCaseId = "TC-18843";
            qTestUniqueId = "40054028";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMeterSizeDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Meter Installation Date Advanced Search_Installation Date_displays
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18844_GROUPS_Search_Endpoints_Meter_Installation_Date_Advanced_Search_Installation_Date_displays()
        {
            testCaseId = "TC-18844";
            qTestUniqueId = "40054029";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMeterInstallDateDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Search Button_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18845_GROUPS_Search_Endpoints_Advanced_Search_Search_Button_Display()
        {
            testCaseId = "TC-18845";
            qTestUniqueId = "40054031";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAdvanceSearchButtonDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Search Button_Access
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18846_GROUPS_Search_Endpoints_Advanced_Search_Search_Button_Access()
        {
            testCaseId = "TC-18846";
            qTestUniqueId = "40054032";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAdvanceSearchButtonAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Search Results_Sort Order
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18847_GROUPS_Search_Endpoints_Advanced_Search_Search_Results_Sort_Order()
        {
            testCaseId = "TC-18847";
            qTestUniqueId = "40054321";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateDefaultSortOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_Account Number_Search Results
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18848_GROUPS_Search_Endpoint_Advanced_Search_Account_Number_Search_Results()
        {
            testCaseId = "TC-18848";
            qTestUniqueId = "40054321";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAdvanceSearchButtonAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_Account Name_Search Results
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18849_GROUPS_Search_Endpoint_Advanced_Search_Account_Name_Search_Results()
        {
            testCaseId = "TC-18849";
            qTestUniqueId = "40071589";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAccNameSortOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_Address_Search Results
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18850_GROUPS_Search_Endpoint_Advanced_Search_Address_Search_Results()
        {
            testCaseId = "TC-18850";
            qTestUniqueId = "40071590";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddressSortOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_MIU ID_Search Results
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18851_GROUPS_Search_Endpoint_Advanced_Search_MIU_ID_Search_Results()
        {
            testCaseId = "TC-18851";
            qTestUniqueId = "40071591";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMIUidSortOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_Meter ID_Search Results
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18852_GROUPS_Search_Endpoint_Advanced_Search_Meter_ID_Search_Results()
        {
            testCaseId = "TC-18852";
            qTestUniqueId = "40071592";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMeterIdSortOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_Meter Size_Search Results
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18853_GROUPS_Search_Endpoint_Advanced_Search_Meter_Size_Search_Results()
        {
            testCaseId = "TC-18853";
            qTestUniqueId = "40071594";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMeterSizeSortOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Pagination Option
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18896_GROUPS_View_Existing_List_Group_Members_Pagination_Option()
        {
            testCaseId = "TC-18896";
            qTestUniqueId = "40200299";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateSearchEndpointPageThrough();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Pagination Option Access
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18897_GROUPS_View_Existing_List_Group_Members_Pagination_Option_Access()
        {
            testCaseId = "TC-18897";
            qTestUniqueId = "40200301";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateSearchEndpointPageThroughAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_View Existing List_Group Members_Endpoints Count_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18898_GROUPS_View_Existing_List_Group_Members_Endpoints_Count_Display()
        {
            testCaseId = "TC-18898";
            qTestUniqueId = "40200302";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateSearchEndpointLastPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Search Results_Properties
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18943_GROUPS_Search_Endpoints_Advanced_Search_Search_Results_Properties()
        {
            testCaseId = "TC-18943";
            qTestUniqueId = "40249644";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateSearchEndpointProperties();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Meter Installation Date_Label Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18946_GROUPS_Search_Endpoints_Advanced_Search_Meter_Installation_Date_Label_Display()
        {
            testCaseId = "TC-18946";
            qTestUniqueId = "40275449";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateSearchEndpointMeterInstallDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Pagination option
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18948_GROUPS_Search_Endpoints_Search_Results_Pagination_option()
        {
            testCaseId = "TC-18948";
            qTestUniqueId = "40447181";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointSearchEndpointPageThrough();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Pagination option Access
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18948_GROUPS_Search_Endpoints_Search_Results_Pagination_option_Access()
        {
            testCaseId = "TC-18948";
            qTestUniqueId = "40447183";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointSearchEndpointPageThroughAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Count Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18950_GROUPS_Search_Endpoints_Search_Results_Count_Display()
        {
            testCaseId = "TC-18950";
            qTestUniqueId = "40447184";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointSearchEndpointLastPageAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_MIU Status_Search Results
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18974_GROUPS_Search_Endpoint_Advanced_Search_MIU_Status_Search_Results()
        {
            testCaseId = "TC-18974";
            qTestUniqueId = "40630291";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMiuStatusSearchResults();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_Meter Installation Date_Search Results
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18975_GROUPS_Search_Endpoint_Advanced_Search_Meter_Installation_Date_Search_Results()
        {
            testCaseId = "TC-18975";
            qTestUniqueId = "40630369";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateFromDateSearchResults();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_Account Number_Max Characters
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18976_GROUPS_Search_Endpoint_Advanced_Search_Account_Number_Max_Characters()
        {
            testCaseId = "TC-18976";
            qTestUniqueId = "40630582";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAccNameMaxCharacterSearchResults(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_Account Number_Alphanumeric
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18977_GROUPS_Search_Endpoint_Advanced_Search_Account_Number_Alphanumeric()
        {
            testCaseId = "TC-18977";
            qTestUniqueId = "40630583";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAccNameMaxCharacterSearchResults(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_Account Name_Max Characters
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18978_GROUPS_Search_Endpoint_Advanced_Search_Account_Name_Max_Characters()
        {
            testCaseId = "TC-18978";
            qTestUniqueId = "40630584";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAccNoMaxCharacterSearchResults(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_Account Name_ Alphanumeric
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18979_GROUPS_Search_Endpoint_Advanced_Search_Account_Name_Alphanumeric()
        {
            testCaseId = "TC-18979";
            qTestUniqueId = "40630586";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAccNoMaxCharacterSearchResults(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_Address_Max Characters
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18982_GROUPS_Search_Endpoint_Advanced_Search_Address_Max_Characters()
        {
            testCaseId = "TC-18982";
            qTestUniqueId = "40630589";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddressMaxCharacterSearchResults(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_Address_Alphanumeric
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18983_GROUPS_Search_Endpoint_Advanced_Search_Address_Alphanumeric()
        {
            testCaseId = "TC-18983";
            qTestUniqueId = "40630590";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddressMaxCharacterSearchResults(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_City_Max Characters
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18984_GROUPS_Search_Endpoint_Advanced_Search_City_Max_Characters()
        {
            testCaseId = "TC-18984";
            qTestUniqueId = "40630592";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateCityMaxCharacterSearchResults(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_City_Alphanumeric
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18985_GROUPS_Search_Endpoint_Advanced_Search_City_Alphanumeric()
        {
            testCaseId = "TC-18985";
            qTestUniqueId = "40630593";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateCityMaxCharacterSearchResults(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_Zip_Max Characters
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18986_GROUPS_Search_Endpoint_Advanced_Search_Zip_Max_Characters()
        {
            testCaseId = "TC-18986";
            qTestUniqueId = "40630594";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateZipCharacterSearchResults(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_Zip_Alphanumeric
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18987_GROUPS_Search_Endpoint_Advanced_Search_Zip_Alphanumeric()
        {
            testCaseId = "TC-18987";
            qTestUniqueId = "40630595";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateZipCharacterSearchResults(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_Zip_US Support
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18988_GROUPS_Search_Endpoint_Advanced_Search_Zip_US_Support()
        {
            testCaseId = "TC-18988";
            qTestUniqueId = "40630595";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateZipCharacterUSSupport(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        
        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_ Canada_Support
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18989_GROUPS_Search_Endpoint_Advanced_Search_Zip_Canada_Support()
        {
            testCaseId = "TC-18989";
            qTestUniqueId = "40630597";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateZipCharacterUSSupport(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_MIU ID_Max Characters
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18990_GROUPS_Search_Endpoint_Advanced_Search_MIU_ID_Max_Characters()
        {
            testCaseId = "TC-18990";
            qTestUniqueId = "40630598";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMIUIDMaxCharacterSearchResults(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_MIU ID Numeric
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18991_GROUPS_Search_Endpoint_Advanced_Search_MIU_ID_Numeric()
        {
            testCaseId = "TC-18991";
            qTestUniqueId = "40630599";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMIUIDMaxCharacterSearchResults(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search Meter ID_Max Characters
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18992_GROUPS_Search_Endpoint_Advanced_Search_Meter_ID_Max_Characters()
        {
            testCaseId = "TC-18992";
            qTestUniqueId = "40630600";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMeterIDMaxCharacterSearchResults(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search Meter ID_Alphanumeric
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18993_GROUPS_Search_Endpoint_Advanced_Search_Meter_ID_Alphanumeric()
        {
            testCaseId = "TC-18993";
            qTestUniqueId = "40630601";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMeterIDMaxCharacterSearchResults(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search MIU Status_Values
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18994_GROUPS_Search_Endpoint_Advanced_Search_MIU_Status_Values()
        {
            testCaseId = "TC-18994";
            qTestUniqueId = "40630602";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMIUStatusDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search Meter Size_Values
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18995_GROUPS_Search_Endpoint_Advanced_Search_Meter_Size_Values()
        {
            testCaseId = "TC-18995";
            qTestUniqueId = "40630603";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMeterSizeValues();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_Search Endpoint_Advanced Search_Meter Installation Date_Date Picker
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18996_GROUPS_Search_Endpoint_Advanced_Search_Meter_Installation_Date_Date_Picker()
        {
            testCaseId = "TC-18996";
            qTestUniqueId = "40630604";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMeterInstallDateDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add Endpoints to Group_Option Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18997_GROUPS_Search_Endpoints_Add_Endpoints_to_Group_Option_Display()
        {
            testCaseId = "TC-18997";
            qTestUniqueId = "40650533";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add to Group_Existing Groups Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18998_GROUPS_Search_Endpoints_Add_to_Group_Existing_Groups_Display()
        {
            testCaseId = "TC-18998";
            qTestUniqueId = "40650534";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add to Group_Select One Endpoint
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_18999_GROUPS_Search_Endpoints_Add_to_Group_Select_One_Endpoint()
        {
            testCaseId = "TC-18999";
            qTestUniqueId = "40650535";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add to Group_Select Multiple Endpoints
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19000_GROUPS_Search_Endpoints_Add_to_Group_Select_Multiple_Endpoints()
        {
            testCaseId = "TC-19000";
            qTestUniqueId = "40650536";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add to Group_Select All Endpoints
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19001_GROUPS_Search_Endpoints_Add_to_Group_Select_All_Endpoints()
        {
            testCaseId = "TC-19001";
            qTestUniqueId = "40650537";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateSelectAllAddToGroupEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add to Group _Access_Confirmation dialog
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19002_GROUPS_Search_Endpoints_Add_to_Group_Access_Confirmation_dialog()
        {
            testCaseId = "TC-19002";
            qTestUniqueId = "40650538";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupConfirmationMessage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add to Group _Confirmation dialog_Contents
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19003_GROUPS_Search_Endpoints_Add_to_Group_Confirmation_dialog_Contents()
        {
            testCaseId = "TC-19003";
            qTestUniqueId = "40650539";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupConfirmationMessage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add to Group _Success Toast message
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19004_GROUPS_Search_Endpoints_Add_to_Group_Success_Toast_message()
        {
            testCaseId = "TC-19004";
            qTestUniqueId = "40650540";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupConfirmationToastMessage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add to Group_Classification_Default Value
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19005_GROUPS_Search_Endpoints_Add_to_Group_Classification_Default_Value()
        {
            testCaseId = "TC-19005";
            qTestUniqueId = "40666960";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupDefaultValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add to Group_Group Member View_Endpoints Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19006_GROUPS_Search_Endpoints_Add_to_Group_Group_Member_View_Endpoints_Display()
        {
            testCaseId = "TC-19006";
            qTestUniqueId = "40666991";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupDefaultValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add to Group_Last Updated Property_Current Date
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19007_GROUPS_Search_Endpoints_Add_to_Group_Last_Updated_Property_Current_Date()
        {
            testCaseId = "TC-19007";
            qTestUniqueId = "40667062";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupDefaultValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add to Group_Same Endpoints Multiple Groups
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19008_GROUPS_Search_Endpoints_Add_t_Group_Same_Endpoints_Multiple_Groups()
        {
            testCaseId = "TC-19008";
            qTestUniqueId = "40667520";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupDefaultValueSelectAnotherGroup();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add to Group_Endpoint Selections_Retained
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19009_GROUPS_Search_Endpoints_Add_to_Group_Endpoint_Selections_Retained()
        {
            testCaseId = "TC-19009";
            qTestUniqueId = "40667527";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupConfirmationToastMessage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add to Group_Endpoint Selections_Cleared_Screen Navigation
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19010_GROUPS_Search_Endpoints_Add_to_Group_Endpoint_Selections_Cleared_Screen_Navigation()
        {
            testCaseId = "TC-19010";
            qTestUniqueId = "40667529";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupRetained();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search_Endpoints_Add_to_Group_Endpoint_Selections_Cleared_Reset
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19011_GROUPS_Search_Endpoints_Add_to_Group_Endpoint_Selections_Cleared_Reset()
        {
            testCaseId = "TC-19011";
            qTestUniqueId = "40667530";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupRetained();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add to Group_Endpoint Selections_Cleared_Search Criteria Updated
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19012_GROUPS_Search_Endpoints_Add_to_Group_Endpoint_Selections_Cleared_Search_Criteria_Updated()
        {
            testCaseId = "TC-19012";
            qTestUniqueId = "40667531";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupRetained();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add to Group_Endpoint Selections_Cleared_Deselect All Selected
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19013_GROUPS_Search_Endpoints_Add_to_Group_Endpoint_Selections_Cleared_Deselect_All_Selected()
        {
            testCaseId = "TC-19013";
            qTestUniqueId = "40667532";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupRetained();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Add to Group_Endpoints Display_Reporting View Filter
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19014_GROUPS_Search_Endpoints_Add_to_Group_Endpoints_Display_Reporting_View_Filter()
        {
            testCaseId = "TC-19014";
            qTestUniqueId = "40667533";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupDefaultValue();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_GROUP MANAGEMENT_Not Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19052_GROUPS_GROUP_MANAGEMENT_Not_Display()
        {
            testCaseId = "TC-19052";
            qTestUniqueId = "40930461";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                groupsPage.ValidateGroupManagementNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Delete Button_Not Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19053_GROUPS_Delete_Button_Not_Display()
        {
            testCaseId = "TC-19053";
            qTestUniqueId = "40930462";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateDeleteButtonNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Create Button_Not Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19054_GROUPS_Create_Button_Not_Display()
        {
            testCaseId = "TC-19054";
            qTestUniqueId = "40930463";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateCreateButtonNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Edit Button_Not Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19055_GROUPS_Edit_Button_Not_Display()
        {
            testCaseId = "TC-19055";
            qTestUniqueId = "40930464";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditButtonNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints Screen_Not Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19056_GROUPS_Search_Endpoints_Screen_Not_Display()
        {
            testCaseId = "TC-19056";
            qTestUniqueId = "40930465";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                groupsPage.ValidateSearchEndPointsNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Group Management_Add Endpoints Button_Not Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19057_GROUPS_Group_Management_Add_Endpoints_Button_Not_Display()
        {
            testCaseId = "TC-19057";
            qTestUniqueId = "40930466";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateAddEndpointNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Group Management_Remove Endpoints Button_Not Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19058_GROUPS_Group_Management_Remove_Endpoints_Button_Not_Display()
        {
            testCaseId = "TC-19058";
            qTestUniqueId = "40930467";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateRemoveEndpointNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_Group Management_Classification Button_Not Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19059_GROUPS_Group_Management_Classification_Button_Not_Display()
        {
            testCaseId = "TC-19059";
            qTestUniqueId = "40930468";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateClassificationNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Sort_Account Name
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19060_GROUPS_Search_Endpoints_Search_Results_Sort_Account_Name()
        {
            testCaseId = "TC-19060";
            qTestUniqueId = "40977711";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                //firstName = testData["firstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsSortbyAccName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Sort_Account Number
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19061_GROUPS_Search_Endpoints_Search_Results_Sort_Account_Number()
        {
            testCaseId = "TC-19061";
            qTestUniqueId = "40977712";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsSortbyAccNumber(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Sort_Address
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19062_GROUPS_Search_Endpoints_Search_Results_Sort_Address()
        {
            testCaseId = "TC-19062";
            qTestUniqueId = "40977713";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsSortbyAddress();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Sort MIU_ID
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19063_GROUPS_Search_Endpoints_Search_Results_Sort_MIU_ID()
        {
            testCaseId = "TC-19063";
            qTestUniqueId = "40977714";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsSortbyMiuId();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Sort Meter_ID
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19064_GROUPS_Search_Endpoints_Search_Results_Sort_Meter_ID()
        {
            testCaseId = "TC-19064";
            qTestUniqueId = "40977715";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsSortbyMeterId();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Sort Meter_Size
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19065_GROUPS_Search_Endpoints_Search_Results_Sort_Meter_Size()
        {
            testCaseId = "TC-19065";
            qTestUniqueId = "40977716";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsSortbyMeterSize();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Sort_Support One Level
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19067_GROUPS_Search_Endpoints_Search_Results_Sort_Support_One_Level()
        {
            testCaseId = "TC-19067";
            qTestUniqueId = "40977721";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsSortbyMeterSize();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Select Option_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19068_GROUPS_Search_Endpoints_Search_Results_Select_Option_Display()
        {
            testCaseId = "TC-19068";
            qTestUniqueId = "40977722";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsSelectOptionDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Select All Option
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19069_GROUPS_Search_Endpoints_Search_Results_Select_All_Option()
        {
            testCaseId = "TC-19069";
            qTestUniqueId = "40977723";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsSelectAll();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Deselect All Option
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19070_GROUPS_Search_Endpoints_Search_Results_Deselect_All_Option()
        {
            testCaseId = "TC-19070";
            qTestUniqueId = "40977724";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsDeselectAll();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Select Page Option
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19071_GROUPS_Search_Endpoints_Search_Results_Select_Page_Option()
        {
            testCaseId = "TC-19071";
            qTestUniqueId = "40977725";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsSelectPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Select Page Option
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19072_GROUPS_Search_Endpoints_Search_Results_Select_Page_Option()
        {
            testCaseId = "TC-19072";
            qTestUniqueId = "40978170";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsSelectPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Selections Made_Retained_All Pages
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19073_GROUPS_Search_Endpoints_Search_Results_Selections_Made_Retained_All_Pages()
        {
            testCaseId = "TC-19073";
            qTestUniqueId = "40978171";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsSelectionRetainedAllPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Selections Cleared_All Pages
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19074_GROUPS_Search_Endpoints_Search_Results_Selections_Cleared_All_Pages()
        {
            testCaseId = "TC-19074";
            qTestUniqueId = "40978172";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsSelectionRetainedAllPage();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Group Filter_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19075_GROUPS_Search_Endpoints_Advanced_Search_Group_Filter_Display()
        {
            testCaseId = "TC-19075";
            qTestUniqueId = "40978201";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Groups Drop down_Values
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19076_GROUPS_Search_Endpoints_Advanced_Search_Groups_Drop_Down_Values()
        {
            testCaseId = "TC-19076";
            qTestUniqueId = "40978202";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Groups Drop down_Group Name Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19077_GROUPS_Search_Endpoints_Advanced_Search_Groups_Drop_down_Group_Name_Display()
        {
            testCaseId = "TC-19077";
            qTestUniqueId = "40978203";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Group Filter_Single Selection
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19078_GROUPS_Search_Endpoints_Advanced_Search_Group_Filter_Single_Selection()
        {
            testCaseId = "TC-19078";
            qTestUniqueId = "40978205";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupSingleGroup();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Group Filter_Search Results
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19079_GROUPS_Search_Endpoints_Advanced_Search_Group_Filter_Search_Results()
        {
            testCaseId = "TC-19079";
            qTestUniqueId = "40978206";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddToGroupSingleGroup();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Group Filter_Other Criteria Selected_Search Results
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19080_GROUPS_Search_Endpoints_Advanced_Search_Group_Filter_Other_Criteria_Selected_Search_Results()
        {
            testCaseId = "TC-19080";
            qTestUniqueId = "40978206";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateMeterIdSortOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Endpoint Associated to One Group_Display Validation
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19540_GROUPS_Search_Endpoints_Search_Results_Endpoint_Associated_to_One_Group_Display_Validation()
        {
            testCaseId = "TC-19540";
            qTestUniqueId = "41683688";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsAssociatedOneGroup();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Endpoint Associated to Multiple Groups_Display Validation
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19541_GROUPS_Search_Endpoints_Search_Results_Endpoint_Associated_to_Multiple_Groups_Display_Validation()
        {
            testCaseId = "TC-19541";
            qTestUniqueId = "41683698";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsAssociatedOneGroup();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Routes Filter_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19542_GROUPS_Search_Endpoints_Advanced_Search_Routes_Filter_Display()
        {
            testCaseId = "TC-19542";
            qTestUniqueId = "41892414";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateRoutesDropdownDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Routes Drop down_Values
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19543_GROUPS_Search_Endpoints_Advanced_Search_Routes_Drop_down_Values()
        {
            testCaseId = "TC-19543";
            qTestUniqueId = "41892415";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateRoutesDropdownValues();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Routes Filter_Single Selection
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19544_GROUPS_Search_Endpoints_Advanced_Search_Routes_Filter_Single_Selection()
        {
            testCaseId = "TC-19544";
            qTestUniqueId = "41892416";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateRoutesDropdownSelected();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Routes Filter_Search Results
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19545_GROUPS_Search_Endpoints_Advanced_Search_Routes_Filter_Search_Results()
        {
            testCaseId = "TC-19545";
            qTestUniqueId = "41892417";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateRoutesDropdownSelectedSearchResults();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Advanced Search_Routes Filter_Other Criteria Selected_Search Results
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19546_GROUPS_Search_Endpoints_Advanced_Search_Routes_Filter_Other_Criteria_Selected_Search_Results()
        {
            testCaseId = "TC-19546";
            qTestUniqueId = "41892418";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateRoutesDropdownSelectedSearchResultsOtherCriteria();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Reset Button_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19556_GROUPS_Search_Endpoints_Reset_Button_Display()
        {
            testCaseId = "TC-19556";
            qTestUniqueId = "42181647";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateResetButtonDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Reset Button_Confirmation Dialog_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19557_GROUPS_Search_Endpoints_Reset_Button_Confirmation_Dialog_Display()
        {
            testCaseId = "TC-19557";
            qTestUniqueId = "42181650";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateResetButtonConfirmationDialog();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Reset Button_Search Fields_Cleared
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19558_GROUPS_Search_Endpoints_Reset_Button_Search_Fields_Cleared()
        {
            testCaseId = "TC-19558";
            qTestUniqueId = "42181651";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateResetButtonFieldsCleared();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Reset Button_Previous Search Results_Cleared
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19559_GROUPS_Search_Endpoints_Reset_Button_Previous_Search_Results_Cleared()
        {
            testCaseId = "TC-19559";
            qTestUniqueId = "42181655";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateResetButtonFieldsCleared();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Reset Button_Previous Search_Selections Cleared
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19560_GROUPS_Search_Endpoints_Reset_Button_Previous_Search_Results_Cleared()
        {
            testCaseId = "TC-19560";
            qTestUniqueId = "42181656";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateResetButtonSelectedFieldsCleared();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Group Management_Classification_Edit Icon_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19588_Group_Management_Classification_Edit_Icon_Display()
        {
            testCaseId = "TC-19588";
            qTestUniqueId = "42352098";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                //groupsPage.ValidateClassificationBtnEnable(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Group Management_Classification_Options Order
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19589_Group_Management_Classification_Options_Order()
        {
            testCaseId = "TC-19589";
            qTestUniqueId = "42352099";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateClassificationValues(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Group Management_Create Group_Buttons_Alignment
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19590_Group_Management_Create_Group_Buttons_Alignment()
        {
            testCaseId = "TC-19590";
            qTestUniqueId = "42352101";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateCreateButtonClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Group Management_Edit Group_Buttons_Alignment
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19591_Group_Management_Edit_Group_Buttons_Alignment()
        {
            testCaseId = "TC-19591";
            qTestUniqueId = "42352102";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEditButtonAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Group Management_View Groups_Endpoints List_Meter Number Label
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19592_Group_Management_View_Groups_Endpoints_List_Meter_Number_Label()
        {
            testCaseId = "TC-19592";
            qTestUniqueId = "42352103";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateMeterNumber(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Group Management_View Groups_Endpoints List_Account Number Label
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19593_Group_Management_View_Groups_Endpoints_List_Account_Number_Label()
        {
            testCaseId = "TC-19593";
            qTestUniqueId = "42352104";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateAccNumber(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Group Management_View Groups_Endpoints List_Account Number Label
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19594_Group_Management_View_Groups_Endpoints_List_Select_Drop_Down_Options()
        {
            testCaseId = "TC-19594";
            qTestUniqueId = "42352106";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateMulitSelectDropdown();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Group Management_View Groups_Sort By_Label Not Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19595_Group_Management_View_Groups_Sort_By_Label_Not_Display()
        {
            testCaseId = "TC-19595";
            qTestUniqueId = "42352107";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupsSortOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Group Management_Endpoints List_Sort By_Label Not Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19596_Group_Management_Endpoints_List_Sort_By_Label_Not_Display()
        {
            testCaseId = "TC-19596";
            qTestUniqueId = "42352108";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupsSortOrder();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Group Management_Endpoints List_Sorting_In Progress Symbol_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19597_Group_Management_Endpoints_List_Sorting_In_Progress_Symbol_Display()
        {
            testCaseId = "TC-19597";
            qTestUniqueId = "42352109";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateSortOrderInProcessing(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Group Management_View Groups_Sort Options_Naming Conventions
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19598_Group_Management_View_Groups_Sort_Options_Naming_Conventions()
        {
            testCaseId = "TC-19598";
            qTestUniqueId = "42352111";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupsSortOrderValues();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Group Management_Endpoints List_Sort Options_Naming Conventions
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19599_Group_Management_Endpoints_List_Sort_Options_Naming_Conventions()
        {
            testCaseId = "TC-19599";
            qTestUniqueId = "42352112";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointsSortbyAccName(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Group Management_Endpoints List_Sort Options_Naming Conventions
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19600_Group_Management_Endpoints_List_Search_Endpoints_Case_Insensitive()
        {
            testCaseId = "TC-19600";
            qTestUniqueId = "42352113";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupNameEndpointSearch(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Group Management_Endpoints List_Search Endpoints_Include Account Number
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19601_Group_Management_Endpoints_List_Search_Endpoints_Include_Account_Number()
        {
            testCaseId = "TC-19601";
            qTestUniqueId = "42352114";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateGroupNameEndpointSearch(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Sort Options_Naming Conventions
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19685_GROUPS_Search_Endpoints_Search_Results_Sort_Options_Naming_Conventions()
        {
            testCaseId = "TC-19685";
            qTestUniqueId = "42480585";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointsSortbyAccNumber(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Sort Options_Sort By Label Removed
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19686_GROUPS_Search_Endpoints_Search_Results_Sort_Options_Sort_By_Label_Removed()
        {
            testCaseId = "TC-19686";
            qTestUniqueId = "42480587";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateEndpointsSortbyAccNumber(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Select Drop Down_Multi Select_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19687_GROUPS_Search_Endpoints_Search_Results_Select_Drop_Down_Multi_Select_Display()
        {
            testCaseId = "TC-19687";
            qTestUniqueId = "42480591";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateEndpointsSortDropdowndisplays(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Endpoints Details_Meter Number_Label
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19688_GROUPS_Search_Endpoints_Search_Results_Endpoints_Details_Meter_Number_Label()
        {
            testCaseId = "TC-19688";
            qTestUniqueId = "42480593";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateMeterNumber(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Results_Endpoints Details_Account Number_Label
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19689_GROUPS_Search_Endpoints_Search_Results_Endpoints_Details_Account_Number_Label()
        {
            testCaseId = "TC-19689";
            qTestUniqueId = "42480596";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateAccNumber(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Criteria_Premise Key Removed
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19690_GROUPS_Search_Endpoints_Search_Criteria_Premise_Key_Removed()
        {
            testCaseId = "TC-19690";
            qTestUniqueId = "42480598";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidatePremiseIDNotDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_Search Criteria_Address Label Update
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19691_GROUPS_Search_Endpoints_Search_Criteria_Address_Label_Update()
        {
            testCaseId = "TC-19691";
            qTestUniqueId = "42480600";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAddressTextBoxDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to GROUPS_Search Endpoints_All Accounts Display_Default
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19692_GROUPS_Search_Endpoints_All_Accounts_Display_Default()
        {
            testCaseId = "TC-19692";
            qTestUniqueId = "42480635";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateAccountsList();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Groups_Search Endpoints_Sorting_In Progress Symbol_Display
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19693_Groups_Search_Endpoints_Sorting_In_Progress_Symbol_Display()
        {
            testCaseId = "TC-19693";
            qTestUniqueId = "42480645";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateSortOrderInProcessing(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Groups_Search Endpoints_Date Picker_Consistent
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19694_Groups_Search_Endpoints_Date_Picker_Consistent()
        {
            testCaseId = "TC-19694";
            qTestUniqueId = "42480648";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateFromDateSearchResults();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Groups_Search Endpoints_Group Name Drop down_Default Option
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19695_Groups_Search_Endpoints_Group_Name_Drop_down_Default_Option()
        {
            testCaseId = "TC-19695";
            qTestUniqueId = "42480653";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavSearchEndpoints(url, userName, password);
                groupsPage.ValidateSelectDropdownEnabled();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Groups_Search Endpoints_Group Name Drop down_Default Option_Navigated from Group Management
        /// </summary>
        [Category("Groups")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_19696_Groups_Search_Endpoints_Group_Name_Drop_down_Default_Option_Navigated_from_Group_Management()
        {
            testCaseId = "TC-19696";
            qTestUniqueId = "42480667";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftNavGroupManagement(url, userName, password);
                groupsPage.ValidateAddEndpointButtonAccess();
                home.UserLogOut();
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


