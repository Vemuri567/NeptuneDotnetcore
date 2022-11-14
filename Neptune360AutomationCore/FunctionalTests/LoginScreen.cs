using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
   public  class LoginScreen : TestBaseTemplate
    {

        /// <summary>
        /// Test Method to Login Screen_Neptune 360 Logo_Display
        /// </summary>
        [Category("LoginScreen")]
        [Category("RegressionTests")]
        [Test]
        public void TC_8556_Login_Screen_Neptune_360_Logo_Display()
        {
            testCaseId = "TC-8556";
            qTestUniqueId = "22846158";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageLoginScreen(url, userName, password);
                loginScreenPage.ValidateNeptune360Logo();
                //home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Password Reset screen_Neptune 360 Logo_Display
        /// </summary>
        [Category("LoginScreen")]
        [Category("RegressionTests")]
        [Test]
        public void TC_8557_Password_Reset_Screen_Neptune_360_Logo_Display()
        {
            testCaseId = "TC-8557";
            qTestUniqueId = "22846160";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageLoginScreen(url, userName, password);
                loginScreenPage.ValidatePasswordResetScreen();
                //home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Login Screen_Neptune Tech Logo_Display
        /// </summary>
        [Category("LoginScreen")]
        [Category("RegressionTests")]
        [Test]
        public void TC_8558_Login_Screen_Neptune_Tech_Logo_Display()
        {
            testCaseId = "TC-8558";
            qTestUniqueId = "22846163";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageLoginScreen(url, userName, password);
                loginScreenPage.ValidateNeptune360Logo();
                //home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Password Reset screen_Neptune Tech Logo_Display
        /// </summary>
        [Category("LoginScreen")]
        [Category("RegressionTests")]
        [Test]
        public void TC_8559_Password_Reset_Screen_Neptune_Tech_Logo_Display()
        {
            testCaseId = "TC-8559";
            qTestUniqueId = "22846165";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageLoginScreen(url, userName, password);
                loginScreenPage.ValidateNeptune360Logo();
                //home.UserLogOut();
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
