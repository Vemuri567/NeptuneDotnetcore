using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public class RolesAndPermissionsOnOff : TestBaseTemplate
    {
        /// <summary>
        /// Test Method to Permissions Validation_Utility Management_Create Utilities_Neptune Admin_On
        /// </summary>
        [Category("RolesAndPermissionsOnOff")]
        [Test]
        public void TC_4588_Permissions_Validation_Utility_Management_Create_Utilities_Neptune_Admin_On()
        {
            testCaseId = "TC-4588";
            qTestUniqueId = "19481556";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToHome(url, userName, password);
                home.ValidateLftNavRolesAndPermissionsExists();                
                home.UserLogOut();
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
