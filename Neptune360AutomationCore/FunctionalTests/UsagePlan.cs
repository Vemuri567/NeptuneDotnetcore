using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace Neptune360UIAutomation
{
    public class UsagePlan : TestBaseTemplate
    {
        /// <summary>
        /// Test Method to Usage Plans_Breadcrumbs_Display
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16534_Usage_Plans_Breadcrumbs_Display()
        {
            testCaseId = "TC-16534";
            qTestUniqueId = "35557795";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateUsageplanBreadbrumb();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Edit Button_Display
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
       
        [Test]
        public void TC_16536_Usage_Plans_Edit_Button_Display()
        {
            testCaseId = "TC-16536";
            qTestUniqueId = "35557823";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateEditButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Done Button_Display
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
       
        [Test]
        public void TC_16537_Usage_Plans_Done_Button_Display()
        {
            testCaseId = "TC-16537";
            qTestUniqueId = "35557842";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateDoneButton();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Left Section Title_Usage Plan_Display
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16538_Usage_Plans_Left_Section_Title_Usage_Plan_Display()
        {
            testCaseId = "TC-16538";
            qTestUniqueId = "35557866";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Right Section Title_Usage Plan Details_Display
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16539_Usage_Plans_Right_Section_Title_Usage_Plan_Details_Display()
        {
            testCaseId = "TC-16539";
            qTestUniqueId = "35557867";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateTitle();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Left Section_List_Display
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        
        [Test]
        public void TC_16540_Usage_Plans_Left_Section_List_Display()
        {
            testCaseId = "TC-16540";
            qTestUniqueId = "35557868";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateLeftListSection();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Left Section_List_Usage Plan Name_Unique
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
       
        [Test]
        public void TC_16541_Usage_Plans_Left_Section_List_Usage_Plan_Name_Unique()
        {
            testCaseId = "TC-16541";
            qTestUniqueId = "35557869";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateLeftListSection();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Left Section_List_Single Selection
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16542_Usage_Plans_Left_Section_List_Single_Selection()
        {
            testCaseId = "TC-16542";
            qTestUniqueId = "35557871";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateSingleSection();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Left Section_List_Selected Usage Plan_Highlight
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16543_Usage_Plans_Left_Section_List_Selected_Usage_Plan_Highlight()
        {
            testCaseId = "TC-16543";
            qTestUniqueId = "35557874";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateSingleSection();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Usage Plan Details_Display
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16544_Usage_Plans_Usage_Plan_Details_Display()
        {
            testCaseId = "TC-16544";
            qTestUniqueId = "35557875";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateDetailsSection();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Usage Plan Details_Fields Display
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16545_Usage_Plans_Usage_Plan_Details_Fields_Display()
        {
            testCaseId = "TC-16545";
            qTestUniqueId = "35557878";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateDetailsSectionFieldDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Done Button_Click
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16547_Usage_Plans_Done_Button_Click()
        {
            testCaseId = "TC-16547";
            qTestUniqueId = "35557881";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateDoneButtonClick();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Left Section_List_Default Selected
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16548_Usage_Plans_Left_Section_List_Default_Selected()
        {
            testCaseId = "TC-16548";
            qTestUniqueId = "35557882";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateTopItemSelected();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Edit_USAGE PLAN NAME
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16549_Usage_Plans_Edit_USAGE_PLAN_NAME()
        {
            testCaseId = "TC-16549";
            qTestUniqueId = "35557883";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateItemNameNotEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Edit_RATE
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16550_Usage_Plans_Edit_RATE()
        {
            testCaseId = "TC-16550";
            qTestUniqueId = "35557883";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateEditRate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Edit_BURST
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16551_Usage_Plans_Edit_BURST()
        {
            testCaseId = "TC-16551";
            qTestUniqueId = "35557891";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateEditBurst();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Edit_REQUEST
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16552_Usage_Plans_Edit_REQUEST()
        {
            testCaseId = "TC-16552";
            qTestUniqueId = "35557893";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateEditRequests();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Edit_Per
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16553_Usage_Plans_Edit_Per()
        {
            testCaseId = "TC-16553";
            qTestUniqueId = "35557894";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateEditPer();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Edit_CREATED DATE
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16554_Usage_Plans_Edit_CREATED_DATE()
        {
            testCaseId = "TC-16554";
            qTestUniqueId = "35557896";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateEditDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Edit_Edit Button_Grayed Out
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16556_Usage_Plans_Edit_Edit_Button_Grayed_Out()
        {
            testCaseId = "TC-16556";
            qTestUniqueId = "35557900";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateEditButtonGrayedOut();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Edit_Edit Button_Grayed Out
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16557_Usage_Plans_Edit_Edit_Button_Grayed_Out()
        {
            testCaseId = "TC-16557";
            qTestUniqueId = "35557903";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateDoneButtonGrayedOut();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Edit_Cancel Button_Display
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16558_Usage_Plans_Edit_Cancel_Button_Display()
        {
            testCaseId = "TC-16558";
            qTestUniqueId = "35557904";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateCancelButtonDisplays();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Edit_Cancel Button_Access
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16560_Usage_Plans_Edit_Cancel_Button_Access()
        {
            testCaseId = "TC-16560";
            qTestUniqueId = "35557909";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateCancelButtonAccess();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Edit Usage Plan_Done Button_Access_Confirmation Toast
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16620_Usage_Plans_Edit_Usage_Plan_Done_Button_Access_Confirmation_Toast()
        {
            testCaseId = "TC-16620";
            qTestUniqueId = "35673941";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateDoneButtonAccessConfirmation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Edit Usage Plan_Done Button_Access_Screen Display
        /// </summary>
        [Category("UsagePlan")]
        [Test]
        public void TC_16624_Usage_Plans_Edit_Usage_Plan_Done_Button_Access_Screen_Display()
        {
            testCaseId = "TC-16624";
            qTestUniqueId = "35673947";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateDoneButtonAccessConfirmation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Usage plan List_Sort Order_New Plan Created
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16625_Usage_Plans_Usage_plan_List_Sort_Order_New_Plan_Created()
        {
            testCaseId = "TC-16625";
            qTestUniqueId = "35673948";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateLeftListSection();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Usage plan List_Sort Order_ Plan Updated
        /// </summary>
        [Category("UsagePlan")]
        //[Category("RegressionTests")]
        [Test]
        public void TC_16626_Usag_Plans_Usage_plan_List_Sort_Order_Plan_Updated()
        {
            testCaseId = "TC-16626";
            qTestUniqueId = "35673949";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateDoneButtonAccessConfirmation();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Edit_USAGE PLAN NAME_Disabled
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16913_Usage_Plans_Edit_USAGE_PLAN_NAME_Disabled()
        {
            testCaseId = "TC-16913";
            qTestUniqueId = "35994936";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateItemNameNotEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Create Button_Not Available
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_17172_Usage_Plans_Create_Button_Not_Available()
        {
            testCaseId = "TC-17172";
            qTestUniqueId = "36862047";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateCreateButtonNotAvailable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Usage Plans_Delete Button_Not Available
        /// </summary>
        [Category("UsagePlan")]
        [Category("RegressionTests")]
        [Test]
        public void TC_17173_Usage_Plans_Delete_Button_Not_Available()
        {
            testCaseId = "TC-17173";
            qTestUniqueId = "36862069";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateUsagePlanPage(url, userName, password);
                usagePlan.ValidateDeleteButtonNotAvailable();
                home.UserLogOut();
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
