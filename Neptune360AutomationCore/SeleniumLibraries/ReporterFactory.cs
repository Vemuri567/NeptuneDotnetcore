using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System.IO;
using System.Net;
using System.Data;
using NUnit.Framework;

namespace Neptune360UIAutomation
{
    /// <summary>
    /// @Author - Pavan Parmar
    /// </summary>
    public class ReporterFactory
    {
        public static ExtentTest uniqueReportDriver = null;
        public static ExtentReports objExtentReport = null;
        public static string failureReason = "";

        private static string currentDirectoryPath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "");
        private static string testReportName = Utilities.ReadConfigFile("TestReportName");
        private static IWebDriver driver = WebDriverFactory.getWebDriver();
        private static string filePath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "");
        public static DataTable resultSummary = new DataTable();
        public static string testCaseName = "";
        public static string currentDateAndTime = "TestResults-" + DateTime.Now.ToString().Replace(":", "").Replace(" ", "").Replace("/", "-");

        /// <summary>
        /// To Create TestReport Directory
        /// </summary>
        public ReporterFactory()
        {
            //Directory.CreateDirectory(currentDirectoryPath + "\\Results\\");
        }

        /// <summary>
        /// To Get Report Driver
        /// </summary>
        /// <param name="testName"></param>
        /// <returns></returns>
        //public static ExtentTest getReportDriver(string testName)
        //{
        //    uniqueReportDriver = objExtentReport.CreateTest(testName);

        //    return uniqueReportDriver;
        //}

        /// <summary>
        /// To Attach Report
        /// </summary>
        public static void AttachReport()
        {
            Directory.CreateDirectory(currentDirectoryPath + "\\Results\\" + currentDateAndTime + "\\");
            var htmlReporter = new ExtentHtmlReporter(currentDirectoryPath + "Results\\" + currentDateAndTime + "\\" + testReportName);
            htmlReporter.LoadConfig(currentDirectoryPath + "extent-config.xml");
            objExtentReport = new ExtentReports();
            objExtentReport.AddSystemInfo("Host Name", Dns.GetHostName());
            objExtentReport.AddSystemInfo("User Name", Utilities.ReadConfigFile("UserName"));
            objExtentReport.AddSystemInfo("Project", Utilities.ReadConfigFile("Project"));
            objExtentReport.AddSystemInfo("Release", Utilities.ReadConfigFile("Release"));
            objExtentReport.AddSystemInfo("Test Cycle", Utilities.ReadConfigFile("TestCycle"));
            objExtentReport.AddSystemInfo("Test Suite", Utilities.ReadConfigFile("TestSuite"));
            objExtentReport.AttachReporter(htmlReporter);
            if (Utilities.ReadConfigFile("qTestFlag") != "Y")
            {
                resultSummary.Columns.Add("Test Name");
                resultSummary.Columns.Add("Status");
                resultSummary.Columns.Add("Failure Reason");
                //resultSummary.Columns.Add("Execution Date");
            }
        }

        /// <summary>
        /// To Intialize Test Case
        /// </summary>
        /// <param name="testcaseName"></param>
        public static void InitTestCase(string testcaseName)
        {
            uniqueReportDriver = objExtentReport.CreateTest(testcaseName);
            testCaseName = testcaseName;
        }

        /// <summary>
        /// Gets Unique Report Driver
        /// </summary>
        public static ExtentTest TestReport
        {
            get
            {
                return uniqueReportDriver;
            }
        }

        public static string FailureReason
        {
            get
            {
                return failureReason;
            }
        }

        /// <summary>
        /// To Flush Test
        /// </summary>
        public static void FlushTest()
        {
            //resultSummary.Rows.Add(testCaseName, TestReport.Status.ToString(), DateTime.Now.ToString());
            if (TestReport.Status.ToString() == "Fail" && Utilities.ReadConfigFile("qTestFlag") != "Y")
                resultSummary.Rows.Add(testCaseName, TestReport.Status.ToString(), failureReason);
            failureReason = "";
            objExtentReport.Flush();
            if (Utilities.ReadConfigFile("qTestFlag") != "Y")
                CreateHtmlSummaryReport();
        }

        /// <summary>
        /// Takes the screen shot.
        /// </summary>
        /// <param name="screenShotPath">The screen shot path.</param>
        public static void TakeScreenShot(string screenShotPath)
        {
            //if(screenShotPath== null)
            //{
            //    screenShotPath= String.Format("{0}{1}ScreenShot" + ".jpeg", EngineSetup.TestScreenShotFolder, Path.DirectorySeparatorChar);
            //}
            //try
            //{
            //    FileInfo myPngImage = new FileInfo(screenShotPath);
            //    if (!myPngImage.Directory.Exists)
            //    {
            //        myPngImage.Directory.Create();
            //    }
            //    if (myPngImage.Exists)
            //    {
            //        string tempFileName = null;
            //        tempFileName = screenShotPath.Substring(0, screenShotPath.IndexOf(".jpeg"));

            //        screenShotPath = tempFileName;
            //        screenShotPath = String.Format("{0}_{1}.jpeg", screenShotPath, EngineSetup.lastScreenShotCount++);
            //    }
            //}
            //catch (Exception)
            //{
            //    //EngineSetup.TestReport.LogException(ex, EngineSetup.GetScreenShotPath());
            //}

            try
            {
                driver = WebDriverFactory.getWebDriver();
                //if (screenShotPath != null)
                //{
                if (driver == null)
                {
                    FileUtilities.TakeScreenShot(screenShotPath);
                }
                else
                {
                    //ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                    //Screenshot screenshot = screenshotDriver.GetScreenshot();
                    //screenshot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);

                    var screenshot1 = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
                    var media = MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot1, TestContext.CurrentContext.Test.Name.Substring(0, 5)).Build();
                    TestReport.Log(TestReport.Status, "Snapshot : ", media);
                }
                //string relativePath = FileUtilities.MakeRelativePath(filePath + "Results\\"+currentDateAndTime + "\\", screenShotPath);
                //MediaEntityModelProvider mediaModel = MediaEntityBuilder.CreateScreenCaptureFromPath(relativePath).Build();

                //TestReport.Log(TestReport.Status, "Snapshot Below : ", mediaModel);
                //  TestReport.AddScreenCaptureFromPath(screenShotPath);
                //TestReport.Log(TestReport.Status, "Snapshot Below : " + TestReport.AddScreenCaptureFromPath(@relativePath));
                //}
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Logs the failure.
        /// </summary>
        /// <param name="stepName">Name of the step.</param>
        /// <param name="stepDescription">The step description.</param>
        /// <param name="screenShotPath">The screen shot path.</param>
        public static void LogFailure(string description, string screenShotPath = null, bool throwException = true)
        {
            failureReason = description;
            TestReport.Fail(description);
            TakeScreenShot(screenShotPath);
            objExtentReport.Flush();

            if (throwException)
                Assert.Fail(description);
        }


        public static void LogInfo(string description)
        {
            TestReport.Info(description);
            objExtentReport.Flush();
        }

        public static void CreateHtmlSummaryReport()
        {

            string header = "<html><body><table style = \"width:50%\" border = \"1\" align = \"center\">" +
                    "<tr><th>Test Name</th><th>Status </th><th> Failure Reason </th></tr> ";
            string statusColorCode = "#A5FF33";
            string testDetails = header;
            foreach (DataRow row in resultSummary.Rows)
            {
                if (row["Status"].ToString() == "Fail")
                    statusColorCode = "#ffffff";//#fa4141
                testDetails = testDetails + "<tr><td>" + row["Test Name"].ToString() + "</td><td bgcolor='" + statusColorCode + "' align='center'>";
                testDetails = testDetails + row["Status"].ToString() + "</td><td>";
                testDetails = testDetails + row["Failure Reason"].ToString() + "</td></tr>";
                //testDetails = testDetails + row["Execution Date"].ToString() + "</td></tr>";
                statusColorCode = "#A5FF33";
            }

            testDetails = testDetails + "</table></body></html>";
            string reportFile = new FileInfo(filePath).Directory.FullName + "\\HtmlSummaryReport.html";
            File.WriteAllText(reportFile, testDetails);
        }
    }
}
