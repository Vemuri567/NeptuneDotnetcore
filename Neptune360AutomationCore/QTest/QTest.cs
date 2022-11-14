using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Security;
using NUnit.Framework;

namespace Neptune360UIAutomation
{
    /// <summary>
    /// Libraries for qTest operations
    /// </summary>
    public class QTest
    {
        #region Read data from Config file
        public static string UserName = Utilities.ReadConfigFile("UserName");
        public static string Password = Utilities.ReadConfigFile("Password");
        public static string ProjectName = Utilities.ReadConfigFile("Project");
        public static string ReleaseName = Utilities.ReadConfigFile("Release");
        public static string TestCycleName = Utilities.ReadConfigFile("TestCycle");
        public static string TestSuiteName = Utilities.ReadConfigFile("TestSuite");
        public static string qTestFlag = Utilities.ReadConfigFile("qTestFlag");
        public static string testReportName = Utilities.ReadConfigFile("TestReportName");
        #endregion

        #region initialize all variables
        public static string URL = "", Content = "", AuthHeader = "", ContentType = "", Response = "", Token = "", attachment = "", detailreportfilename = "", json = "";
        public static string ProjectId = "", ReleaseID = "", TestCycleId = "", TestSuiteId = "", TestRunId = "", TestCaseName = "", LogPath = "", errorString = "";

        #endregion

        /// <summary>
        /// Publish Test Status to qTest
        /// </summary>
        /// <param name="TestCaseId">Test Case Id</param>
        /// <param name="Status">Execution Status</param>
        /// <param name="StartDate">Execution Start Time</param>
        /// <param name="EndDate">Execution End Time</param>
        public static void PublishQtestResults(string TestCaseId, string Status, DateTime StartDate, DateTime EndDate)
        {
            int tryTimes = 5;
            DateTime eta = DateTime.Now.AddMinutes(5);
        start:
            while (eta >DateTime.Now)
            {
                try
                {
                    ReporterFactory.FlushTest();
                    if (qTestFlag == "N")
                        return;

                    #region Common Variables
                    GetTestCycleId[] objTestCycleId = null;
                    GetTestSuites[] objTestSuite = null;
                    GetTestRuns[] objTestRuns = null;
                    List<int> queryTestSuiteId = new List<int>();
                    #endregion


                    #region Login to qTest
                    //URL=@"https://ntg.qtestnet.com/oauth/token?grant_type=password&username=pparmar&password=C0nsult!";
                    URL = @"https://ntg.qtestnet.com/oauth/token?grant_type=password&username=" + UserName + "&password=" + Password;
                    Content = @"{""Cache-Control"":""no-cache""}";
                    AuthHeader = string.Format("{0} {1}", "Basic", "bGluaC1sb2dpbjo=");
                    ContentType = "application/x-www-form-urlencoded";
                    Response = POST(URL, Content, AuthHeader, ContentType, tryTimes);
                    if (Response == "POST ERROR")
                    {
                        Console.WriteLine("An error occurred while getting the response.");
                        return;
                    }
                    else if (Response == "error")
                    {
                        tryTimes--;
                        goto start;
                    }
                    Token = Response.Substring(17, 36);
                    #endregion

                    #region Get Project Id
                    URL = @"https://ntg.qtestnet.com/api/v3/projects";
                    AuthHeader = "bearer " + Token;
                    Response = GET(URL, AuthHeader);

                    GetProjectId[] objProjectId = null;
                    objProjectId = JsonConvert.DeserializeObject<GetProjectId[]>(Response);

                    var queryProjectId = from GetProjectId id in objProjectId
                                         where id.name == ProjectName
                                         select id.id;
                    ProjectId = queryProjectId.Single().ToString();
                    #endregion

                    #region Get Release id
                    URL = "https://ntg.qtestnet.com/api/v3/projects/" + ProjectId + "/releases";
                    AuthHeader = "bearer " + Token;
                    Response = GET(URL, AuthHeader);

                    GetReleaseId[] objReleaseId = null;
                    objReleaseId = JsonConvert.DeserializeObject<GetReleaseId[]>(Response);

                    var queryReleaseId = from GetReleaseId id in objReleaseId
                                         where id.name == ReleaseName
                                         select id.id;
                    ReleaseID = queryReleaseId.Single().ToString();
                    #endregion

                    #region Status Id
                    //Get unique id of Status field
                    switch (Status)
                    {
                        case "Pass": Status = "601"; break;
                        case "Fail": Status = "602"; break;
                        case "Incomplete": Status = "603"; break;
                        case "Blocked": Status = "604"; break;
                        case "Unexecuted": Status = "605"; break;
                        case "Warning": Status = "601"; break;
                    }
                    #endregion

                    #region Get TestCase Name
                    //To get TestCaseName based on its Id
                    URL = "https://ntg.qtestnet.com/api/v3/projects/" + ProjectId + "/test-cases/" + TestCaseId;
                    AuthHeader = "bearer " + Token;
                    Response = GET(URL, AuthHeader);

                    GetTestCaseNameById objTestCaseNameById = null;
                    objTestCaseNameById = JsonConvert.DeserializeObject<GetTestCaseNameById>(Response);

                    TestCaseName = objTestCaseNameById.name;
                    TestCaseName = SecurityElement.Escape(TestCaseName);

                    #endregion

                    #region Read thru test suites under release and post the status to qTest

                    //To get TestCycleId
                    URL = "https://ntg.qtestnet.com/api/v3/projects/" + ProjectId + "/test-cycles?parentId=" + ReleaseID + "&parentType=release";
                    AuthHeader = "bearer " + Token;
                    Response = GET(URL, AuthHeader);

                    objTestCycleId = JsonConvert.DeserializeObject<GetTestCycleId[]>(Response);

                    var queryTestCycleId = (from GetTestCycleId id in objTestCycleId
                                            where id.name == TestCycleName
                                            select id.id).ToList();

                    //Create TestCycle, TestSuite and TestRun under Release if TestCycle, TestSuite and TestRun is not there
                    if (queryTestCycleId.Count == 0)
                    {
                        TestCycleId = CreateTestCycle();
                        if (TestCycleId == "ERROR")
                            return;

                        TestSuiteId = CreateTestSuite(TestCycleId);
                        if (TestSuiteId == "ERROR")
                            return;

                        TestRunId = CreateTestRun(TestSuiteId, TestCaseName, TestCaseId);
                        if (TestRunId == "ERROR")
                            return;

                    }
                    else
                    {
                        TestCycleId = queryTestCycleId.Single().ToString();

                        //To get TestSuiteId
                        URL = "https://ntg.qtestnet.com/api/v3/projects/" + ProjectId + "/test-suites?parentId=" + TestCycleId + "&parentType=test-cycle";
                        AuthHeader = "bearer " + Token;
                        Response = GET(URL, AuthHeader);

                        objTestSuite = JsonConvert.DeserializeObject<GetTestSuites[]>(Response);

                        queryTestSuiteId = (from GetTestSuites id in objTestSuite
                                            where id.name == TestSuiteName
                                            select id.id).ToList();

                        //Create TestSuite and TestRun under TestCycle if TestSuite and TestRun is not there
                        if (queryTestSuiteId.Count == 0)
                        {
                            TestSuiteId = CreateTestSuite(TestCycleId);
                            if (TestSuiteId == "ERROR")
                            {
                                return;
                            }
                            TestRunId = CreateTestRun(TestSuiteId, TestCaseName, TestCaseId);
                            if (TestRunId == "ERROR")
                            {
                                return;
                            }
                        }
                        else
                        {
                            TestSuiteId = queryTestSuiteId.Single().ToString();

                            //To get TestRunId
                            URL = "https://ntg.qtestnet.com/api/v3/projects/" + ProjectId + "/test-runs?parentId=" + TestSuiteId + "&parentType=test-suite&pageSize=999";
                            AuthHeader = "bearer " + Token;
                            Response = GET(URL, AuthHeader);

                            //objTestRuns = JsonConvert.DeserializeObject<GetTestRuns[]>(Response);
                            GetTestRunsItems objTestRunsItems = JsonConvert.DeserializeObject<GetTestRunsItems>(Response);
                            objTestRuns = objTestRunsItems.items.ToArray();

                            var queryTestRunId = (from GetTestRuns id in objTestRuns
                                                  where id.name == TestCaseName
                                                  select id.id).ToList();

                            //Create TestRun under TestSuite if TestRun is not there
                            if (queryTestRunId.Count == 0)
                            {
                                TestRunId = CreateTestRun(TestSuiteId, TestCaseName, TestCaseId);
                                if (TestRunId == "ERROR")
                                {
                                    return;
                                }
                            }
                            else
                            {
                                TestRunId = queryTestRunId.Single().ToString();
                            }
                        }
                    }

                    //Attachment
                    attachment = "";
                    //detailreportfilename = HtmlReports.detailreportfilename.Substring(HtmlReports.detailreportfilename.LastIndexOf('\\') + 1);
                    detailreportfilename = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "Results\\" + ReporterFactory.currentDateAndTime + "\\index.html";
                    if (File.Exists(detailreportfilename))
                    {
                        using (StreamReader sr = new StreamReader(detailreportfilename))
                        {
                            string line;
                            // Read and display lines from the file until the end of the file is reached.
                            while ((line = sr.ReadLine()) != null)
                            {
                                attachment = attachment + line;
                            }
                        }
                        attachment = Utilities.Base64Encode(attachment);
                    }

                    //Submit a TestRun
                    URL = @"https://ntg.qtestnet.com/api/v3/projects/" + ProjectId + "/test-runs/" + TestRunId + "/test-logs";
                    json = "{\"exe_start_date\": \"" + StartDate.ToString("yyyy-MM-ddTHH:mm:sszzz") + "\", " + "\"exe_end_date\": \"" + EndDate.ToString("yyyy-MM-ddTHH:mm:sszzz") + "\", " + "\"status\": { \"id\": " + Status + " }, \"attachments\":[{\"name\": \"" + testReportName + "\",\"content_type\":\"text/html\", \"data\":\"" + attachment + "\"}]  }";
                    Content = json;
                    AuthHeader = "bearer " + Token;
                    ContentType = "application/json";
                    Response = POST(URL, Content, AuthHeader, ContentType, tryTimes);
                    if (Response == "POST ERROR")
                    {
                        Console.WriteLine("An error occurred while getting the response.");
                        return;
                    }
                    else if (Response == "error")
                    {
                        tryTimes--;
                        goto start;
                    }
                    #endregion

                    #region logout
                    URL = @"https://ntg.qtestnet.com/oauth/revoke";
                    Content = @"{""Cache-Control"":""no-cache""}";
                    AuthHeader = string.Format("{0} {1}", "bearer", Token);
                    Response = POST(URL, Content, AuthHeader, "", tryTimes);// Response is blank for logout
                    if (Response == "POST ERROR")
                    {
                        Console.WriteLine("An error occurred while getting the response.");
                        return;
                    }
                    else if (Response == "error")
                    {
                        tryTimes--;
                        goto start;
                    }
                    break;
                    #endregion

                }
                catch (Exception ex)
                {
                    if (eta < DateTime.Now)
                    {
                        Console.WriteLine("Error occurred while publishing qTest Results.\nException Details:" + ex.Message);

                        #region logout
                        URL = @"https://ntg.qtestnet.com/oauth/revoke";
                        Content = @"{""Cache-Control"":""no-cache""}";
                        AuthHeader = string.Format("{0} {1}", "bearer", Token);
                        Response = POST(URL, Content, AuthHeader, "");// Response is blank for logout
                        #endregion
                        Assert.Fail(ex.Message);
                    }

                    tryTimes--;
                }
            }
        }

        /// <summary>
        /// To Create Testcycle
        /// </summary>
        /// <returns></returns>
        public static string CreateTestCycle()
        {
            LogPath = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "/QTest-ErrorLog-" + DateTime.Now.ToString("MM-dd-yyyy") + ".txt";

            try
            {
                URL = "https://ntg.qtestnet.com/api/v3/projects/" + ProjectId + "/test-cycles?parentId=" + ReleaseID + "&parentType=release";
                AuthHeader = "bearer " + Token;
                Content = "{\"name\":\"";
                Content = Content + TestCycleName + "\"}";
                ContentType = "application/json";
                Response = POST(URL, Content, AuthHeader, ContentType);

                GetTestCycleId objTestCycleId = null;
                objTestCycleId = JsonConvert.DeserializeObject<GetTestCycleId>(Response);

                return objTestCycleId.id.ToString();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error while creating Testcycle\nException Details: " + ex.Message);
                errorString = "==========================" + System.DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss") + "=======" + Environment.NewLine;
                errorString = errorString + "Exception Message:" + ex.Message + Environment.NewLine;
                errorString = errorString + "=========================================================================" + Environment.NewLine;
                File.AppendAllText(LogPath, errorString);
                return "ERROR";
            }
        }

        /// <summary>
        /// To Create Testsuite
        /// </summary>
        /// <param name="TestCycleId"></param>
        /// <returns></returns>
        public static string CreateTestSuite(string TestCycleId)
        {
            LogPath = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "/QTest-ErrorLog-" + DateTime.Now.ToString("MM-dd-yyyy") + ".txt";

            try
            {
                URL = "https://ntg.qtestnet.com/api/v3/projects/" + ProjectId + "/test-suites?parentId=" + TestCycleId + "&parentType=test-cycle";
                AuthHeader = "bearer " + Token;
                Content = "{\"name\":\"";
                Content = Content + TestSuiteName + "\"}";
                ContentType = "application/json";
                Response = POST(URL, Content, AuthHeader, ContentType);

                GetTestSuites objTestSuiteId = null;
                objTestSuiteId = JsonConvert.DeserializeObject<GetTestSuites>(Response);

                return objTestSuiteId.id.ToString();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error while creating Testsuite\nException Details: " + ex.Message);
                errorString = "==========================" + System.DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss") + "=======" + Environment.NewLine;
                errorString = errorString + "Exception Message:" + ex.Message + Environment.NewLine;
                errorString = errorString + "=========================================================================" + Environment.NewLine;
                File.AppendAllText(LogPath, errorString);
                return "ERROR";
            }
        }

        /// <summary>
        /// To Create Testrun
        /// </summary>
        /// <param name="TestSuiteId"></param>
        /// <param name="TestCaseName"></param>
        /// <param name="TestCaseId"></param>
        /// <returns></returns>
        public static string CreateTestRun(string TestSuiteId, string TestCaseName, string TestCaseId)
        {
            LogPath = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "QTest-ErrorLog-" + DateTime.Now.ToString("MM-dd-yyyy") + ".txt";

            try
            {
                URL = "https://ntg.qtestnet.com/api/v3/projects/" + ProjectId + "/test-runs?parentId=" + TestSuiteId + "&parentType=test-suite";
                AuthHeader = "bearer " + Token;
                Content = "{\"name\":\"";
                Content = Content + TestCaseName + "\",\"test_case\":{\"id\":";
                Content = Content + TestCaseId + "}}";
                ContentType = "application/json";
                Response = POST(URL, Content, AuthHeader, ContentType);

                GetTestRuns objTestRuns = null;
                objTestRuns = JsonConvert.DeserializeObject<GetTestRuns>(Response);

                return objTestRuns.id.ToString();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error while creating Testrun\nException Details: " + ex.Message);
                errorString = "==========================" + System.DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss") + "=======" + Environment.NewLine;
                errorString = errorString + "Exception Message:" + ex.Message + Environment.NewLine;
                errorString = errorString + "=========================================================================" + Environment.NewLine;
                File.AppendAllText(LogPath, errorString);
                return "ERROR";
            }
        }


        /// <summary>
        /// To perform a HTTP POST Request
        /// </summary>
        /// <param name="url">Url</param>
        /// <param name="jsonContent">JSON Content</param>
        /// <param name="authorizationHeader">Authorization Header</param>
        /// <param name="contentType">Content Type</param>
        /// <returns>Response</returns>
        public static string POST(string url, string jsonContent, string authorizationHeader, string contentType, int retryTimes = 0)
        {
            LogPath = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "QTest-ErrorLog-" + DateTime.Now.ToString("MM-dd-yyyy") + ".txt";

            try
            {
                ServicePointManager.SecurityProtocol = ServicePointManager.SecurityProtocol | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                Byte[] byteArray = encoding.GetBytes(jsonContent);
                request.ContentType = contentType;
                request.ContentLength = byteArray.Length;
                request.Headers[HttpRequestHeader.Authorization] = authorizationHeader;
                request.Accept = "application/json";

                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                        string responseString = reader.ReadToEnd();
                        return responseString;
                    }
                }
            }
            catch (Exception ex)
            {
                if (retryTimes == 0)
                {
                    Console.WriteLine("Error while performing POST operation\nException Details: " + ex.Message);
                    errorString = "==============Error in http POST request=======" + System.DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss") + "=======" + Environment.NewLine;
                    errorString = errorString + "URL:" + url + Environment.NewLine;
                    errorString = errorString + "Auth Header:" + authorizationHeader + Environment.NewLine;
                    errorString = errorString + "Json Content:" + jsonContent + Environment.NewLine;
                    errorString = errorString + "Content Type:" + contentType + Environment.NewLine;
                    errorString = errorString + "Exception Message:" + ex.Message + Environment.NewLine;
                    errorString = errorString + "=========================================================================" + Environment.NewLine;
                    File.AppendAllText(LogPath, errorString);
                    return "POST ERROR";
                }
                else
                {
                    return "error";
                }
            }
        }

        /// <summary>
        /// To perform a HTTP GET Request
        /// </summary>
        /// <param name="url">Url</param>
        /// <param name="authorizationHeader">Authorization Header</param>
        /// <returns>Response</returns>
        public static string GET(string url, string authorizationHeader)
        {
            LogPath = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "QTest-ErrorLog-" + DateTime.Now.ToString("MM-dd-yyyy") + ".txt";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers[HttpRequestHeader.Authorization] = authorizationHeader;
            request.Accept = "application/json";
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string responseString = reader.ReadToEnd();
                    return responseString;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while performing GET operation\nException Details: " + ex.Message);
                errorString = "==============Error in http GET request=======" + System.DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss") + "========" + Environment.NewLine;
                errorString = errorString + "URL:" + url + Environment.NewLine;
                errorString = errorString + "Auth Header:" + authorizationHeader + Environment.NewLine;
                errorString = errorString + "Exception Message:" + ex.Message + Environment.NewLine;
                errorString = errorString + "=========================================================================" + Environment.NewLine;
                File.AppendAllText(LogPath, errorString);
                return "GET ERROR";
            }
        }

       
        public static GetTestSteps[] getTestSteps(string TestCaseId)
        {

            GetTestSteps[] objTestStepId = null;
            
                try
                {
                    #region Login to qTest
                    //URL=@"https://ntg.qtestnet.com/oauth/token?grant_type=password&username=pparmar&password=C0nsult!";
                    URL = @"https://ntg.qtestnet.com/oauth/token?grant_type=password&username=" + UserName + "&password=" + Password;
                    Content = @"{""Cache-Control"":""no-cache""}";
                    AuthHeader = string.Format("{0} {1}", "Basic", "bGluaC1sb2dpbjo=");
                    ContentType = "application/x-www-form-urlencoded";
                    Response = POST(URL, Content, AuthHeader, ContentType);
                    if (Response == "POST ERROR")
                    {
                        Console.WriteLine("An error occurred while getting the response.");
                        
                    }
                    Token = Response.Substring(17, 36);
                    #endregion

                    #region Get Project Id
                    URL = @"https://ntg.qtestnet.com/api/v3/projects";
                    AuthHeader = "bearer " + Token;
                    Response = GET(URL, AuthHeader);

                    GetProjectId[] objProjectId = null;
                    objProjectId = JsonConvert.DeserializeObject<GetProjectId[]>(Response);

                    var queryProjectId = from GetProjectId id in objProjectId
                                         where id.name == ProjectName
                                         select id.id;
                    ProjectId = queryProjectId.Single().ToString();
                    #endregion

                   
                    #region Get TestSteps 
                    //To get TestCaseName based on its qtestId
                    URL = "https://ntg.qtestnet.com/api/v3/projects/" + ProjectId + "/test-cases/" + TestCaseId+ "/test-steps";
                    AuthHeader = "bearer " + Token;
                    Response = GET(URL, AuthHeader);

                    
                    objTestStepId = JsonConvert.DeserializeObject<GetTestSteps[]>(Response);

                    /*GetTestCaseNameById objTestCaseNameById = null;
                    objTestCaseNameById = JsonConvert.DeserializeObject<GetTestCaseNameById>(Response);

                    TestCaseName = objTestCaseNameById.name;
                    TestCaseName = SecurityElement.Escape(TestCaseName);*/

                    #endregion

                    

                    #region logout
                    URL = @"https://ntg.qtestnet.com/oauth/revoke";
                    Content = @"{""Cache-Control"":""no-cache""}";
                    AuthHeader = string.Format("{0} {1}", "bearer", Token);
                    Response = POST(URL, Content, AuthHeader, "");// Response is blank for logout
                    
                    #endregion
                    return objTestStepId;
                }
                catch (Exception ex)
                {
                    
                        Console.WriteLine("Error occurred while publishing qTest Results.\nException Details:" + ex.Message);

                        #region logout
                        URL = @"https://ntg.qtestnet.com/oauth/revoke";
                        Content = @"{""Cache-Control"":""no-cache""}";
                        AuthHeader = string.Format("{0} {1}", "bearer", Token);
                        Response = POST(URL, Content, AuthHeader, "");// Response is blank for logout
                        #endregion
                        Assert.Fail(ex.Message);

                    return objTestStepId;
                }
            
        }

        public static object getattachements(string attachment)
        {
            object obj1 = null;
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            GetAttachments obj=JsonConvert.DeserializeObject<GetAttachments>(attachment, settings);
            string href = obj.links[0].href;
            try
            {
                #region Login to qTest
                //URL=@"https://ntg.qtestnet.com/oauth/token?grant_type=password&username=pparmar&password=C0nsult!";
                URL = @"https://ntg.qtestnet.com/oauth/token?grant_type=password&username=" + UserName + "&password=" + Password;
                Content = @"{""Cache-Control"":""no-cache""}";
                AuthHeader = string.Format("{0} {1}", "Basic", "bGluaC1sb2dpbjo=");
                ContentType = "application/x-www-form-urlencoded";
                Response = POST(URL, Content, AuthHeader, ContentType);
                if (Response == "POST ERROR")
                {
                    Console.WriteLine("An error occurred while getting the response.");

                }
                Token = Response.Substring(17, 36);
                #endregion

                #region Get Project Id
                URL =href;
                AuthHeader = "bearer " + Token;
                string acccept = "application/json";
                Response = GET(URL, AuthHeader);
                obj1=JsonConvert.DeserializeObject(Response);
                
                #endregion


                


                #region logout
                URL = @"https://ntg.qtestnet.com/oauth/revoke";
                Content = @"{""Cache-Control"":""no-cache""}";
                AuthHeader = string.Format("{0} {1}", "bearer", Token);
                Response = POST(URL, Content, AuthHeader, "");// Response is blank for logout

                #endregion
                return obj1;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error occurred while publishing qTest Results.\nException Details:" + ex.Message);

                #region logout
                URL = @"https://ntg.qtestnet.com/oauth/revoke";
                Content = @"{""Cache-Control"":""no-cache""}";
                AuthHeader = string.Format("{0} {1}", "bearer", Token);
                Response = POST(URL, Content, AuthHeader, "");// Response is blank for logout
                #endregion
                Assert.Fail(ex.Message);

                return obj1;
            }

        }
    }
}

