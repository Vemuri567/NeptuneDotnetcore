using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Neptune360UIAutomation
{
    public class Notifications : TestBaseTemplate
    {
        /// <summary>
        /// Test Method to Notifications_Landing Screen_Access
        /// </summary>
        [Category("Notifications")]
        [Category("BatchExecution")]
        [Category("SmokeTests")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3964_Notifications_Landing_Screen_Access()
        {
            testCaseId = "TC-3964";
            qTestUniqueId = "19323411";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateEmailNotificationEditorScreenDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Notifications_Email Notification Editor_Templates Display
        /// </summary>
        [Category("Notifications")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3965_Notifications_Email_Notification_Editor_Templates_Display()
        {
            testCaseId = "TC-3965";
            qTestUniqueId = "19323412";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateViewNotification();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Notifications_Left Navigation Pane_Access
        /// </summary>
        [Category("Notifications")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_4083_Notifications_Left_Navigation_Pane_Access()
        {
            testCaseId = "TC-4083";
            qTestUniqueId = "19323562";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateEmailNotificationEditorScreen();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Notifications_Email Notification Editor_Template_Body Preview_Rich Text Editor_Details
        /// </summary>
        [Category("Notifications")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_4084_Notifications_Email_Notification_Editor_Template_Body_Preview_Rich_Text_Editor_Details()
        {
            testCaseId = "TC-4084";
            qTestUniqueId = "19323563";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateViewNotification();
                notification.ValidateEmailEditorTemplateBodyPreview();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Notifications_Email Notification Editor_Body Preview Edit_Format List_Display
        /// </summary>
        [Category("Notifications")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7834_Notifications_Email_Notification_Editor_Body_Preview_Edit_Format_List_Display()
        {
            testCaseId = "TC-7834";
            qTestUniqueId = "19925873";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateBodyPreviewEditFormat();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Notifications_Email Notification Editor_Body Preview Edit_Font List_Display
        /// </summary>
        [Category("Notifications")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7835_Notifications_Email_Notification_Editor_Body_Preview_Edit_Font_List_Display()
        {
            testCaseId = "TC-7835";
            qTestUniqueId = "19926087";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateBodyPreviewEditFontList();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Notifications_Email Notification Editor_Body Preview Edit_Font Size List_Display
        /// </summary>
        [Category("Notifications")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7836_Notifications_Email_Notification_Editor_Body_Preview_Edit_Font_Size_List_Display()
        {
            testCaseId = "TC-7836";
            qTestUniqueId = "19926112";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateBodyPreviewEditFontSize();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Notifications_Email Notification Editor_Contents Validation
        /// </summary>
        [Category("Notifications")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_4098_Notifications_Email_Notification_Editor_Contents_Validation()
        {
            testCaseId = "TC-4098";
            qTestUniqueId = "19323584";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateViewNotification();
                notification.ValidateEmailNotificationEditorScreenDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Notifications_Email Notification Editor_Template Edit_Get Link Display
        /// </summary>
        [Category("Notifications")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_4099_Notifications_Email_Notification_Editor_Template_Edit_Get_Link_Display()
        {
            testCaseId = "TC-4099";
            qTestUniqueId = "19323585";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateGetLinkBtnDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Notifications_Email Notification Editor_Template Edit_Cancel
        /// </summary>
        [Category("Notifications")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_4100_Notifications_Email_Notification_Editor_Template_Edit_Cancel()
        {
            testCaseId = "TC-4100";
            qTestUniqueId = "19323586";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateEditorEditCancel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Notifications_Email Notification Editor_Template Edit_Save
        /// </summary>
        [Category("Notifications")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_4101_Notifications_Email_Notification_Editor_Template_Edit_Save()
        {
            testCaseId = "TC-4101";
            qTestUniqueId = "19323587";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateEditorEditSave();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Notifications_Email Notification Editor_Template Selection
        /// </summary>
        [Category("Notifications")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12344_Notifications_Email_Notification_Editor_Template_Selection()
        {
            testCaseId = "TC-12344";
            qTestUniqueId = "26906247";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateTemplateSelectionDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Notifications_Email Notification Editor_Template Edit_Get Link_Add
        /// </summary>
        [Category("Notifications")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12345_Notifications_Email_Notification_Editor_Template_Edit_Get_Link_Add()
        {
            testCaseId = "TC-12345";
            qTestUniqueId = "26906692";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateGetLinkBtnDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Notifications_Email Notification Editor_Template_Email Subject_Editable
        /// </summary>
        [Category("Notifications")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12346_Notifications_Email_Notification_Editor_Template_Email_Subject_Editable()
        {
            testCaseId = "TC-12346";
            qTestUniqueId = "26906694";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateEmailBodyEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Notifications_Email Notification Editor_Template_Email Subject Edit_Text Only
        /// </summary>
        [Category("Notifications")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12347_Notifications_Email_Notification_Editor_Template_Email_Subject_Edit_Text_Only()
        {
            testCaseId = "TC-12347";
            qTestUniqueId = "26906695";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateEmailSubjectEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Notifications_Email Notification Editor_Template_Body Preview_Editable
        /// </summary>
        [Category("Notifications")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12348_Notifications_Email_Notification_Editor_Template_Body_Preview_Editable()
        {
            testCaseId = "TC-12348";
            qTestUniqueId = "26906696";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateEmailBodyEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to UntitledNotifications_Email Notification Editor_Template Not Selected_Default
        /// </summary>
        [Category("Notifications")]
        [Category("BatchExecution")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12343_UntitledNotifications_Email_Notification_Editor_Template_Not_Selected_Default()
        {
            testCaseId = "TC-12343";
            qTestUniqueId = "26905096";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageNotifications(url, userName, password);
                notification.ValidateNotificationSection();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Left Navigation - Utility Management - Alert Configuration - Events Section
        /// </summary>
        [Category("Notifications_AlertConfiguration")]
        [Category("BatchExecution")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_12349_Left_Navigation_Utility_Management_Alert_Configuration_Events_Section()
        {
            testCaseId = "TC-12349";
            qTestUniqueId = "28873563";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                notification.ValidateEventsHeader();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Alert Notification - Major Reverse Flow Event - Email - Sent/Received
        /// </summary>
        [Category("Notifications_AlertConfiguration")]
        [Category("BatchExecution")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_14600_Alert_Notification_Major_Reverse_Flow_Event_Email_Sent_Received()
        {
            testCaseId = "TC-14600";
            qTestUniqueId = "32251688";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                notification.ValidateMajorReverseFlowEvent();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Alert Notification - Major Reverse Flow Event - Email - Sent/Received - From Email Address
        /// </summary>
        [Category("Notifications_AlertConfiguration")]
        [Category("BatchExecution")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_14601_Alert_Notification_Major_Reverse_Flow_Event_Email_Sent_Received_From_Email_Address()
        {
            testCaseId = "TC-14601";
            qTestUniqueId = "32251688";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                notification.ValidateMajorReverseFlowEvent();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Alert Notification - Major Reverse Flow Event - Email - Sent/Received - Subject Text
        /// </summary>
        [Category("Notifications_AlertConfiguration")]
        [Category("BatchExecution")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_14602_Alert_Notification_Major_Reverse_Flow_Event_Email_Sent_Received_Subject_Text()
        {
            testCaseId = "TC-14602";
            qTestUniqueId = "32251690";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                notification.ValidateMajorReverseFlowEvent();
                home.UserLogOut();
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
