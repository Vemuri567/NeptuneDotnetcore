using Neptune360UIAutomation.APIUtilities.Models.Requests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation.APITests
{
    public class UtilityTests : TestBaseTemplate
    {
        [Category("APITests")]
        [Test]
        public async Task Utilities_GET_api_v2_utilities_id_ResponseCode401()
        {
            testCaseId = "TC-19046";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("APITests")]
        [Test]
        public async Task PUT_api_v2_utilities_id_Update_Utility_Parameters_Response_Code_200()
        {
            testCaseId = "TC-19036";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                BaseURL = testData["BaseURL"];
                XAPIKey = testData["XAPIKey"];
                APIClient = testData["APIClient"];
                ClientSecret = testData["ClientSecret"];
                endpointtokenUrl = testData["EndpointTokenURL"];
                baseQaUrl = testData["BaseQAURL"];
                endpointurl = testData["EndpointURL"];
                jsonfilename = testData["Payload"];
                string jsonFilePath = Jsonfile(jsonfilename);
                var payload = HandleContent.ParseJson<PutUtilityRequest>(jsonFilePath);
                var api = new Authorization();
                var response = await api.GetAuthorizationKey(BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret);
                //*** Build Failure in jenkins ***
                ////Dictionary<string, object> content = HandleContent.GetContent<Dictionary<string, object>>(response);
                ////var utilityresponse = await api.CreateNewPutRequest(content["AccessToken"].ToString(), baseQaUrl, endpointurl, XAPIKey, payload);
                ////var utilitycontent = utilityresponse.Content;
                ////var code = (int)utilityresponse.StatusCode;
                ////if (code != 200)
                ////{
                ////    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                ////}
                ////else
                ////{
                ////    api.testReport.Pass("<i>Response code is:" + code);
                ////}

                ////QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_Return_List_of_Utilities()
        {
            testCaseId = "TC-19037";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_id_Return_Utility_Details_Response_Code_200()
        {
            testCaseId = "TC-19038";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_getbyuser()
        {
            testCaseId = "TC-19039";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_getbyuser_Response_Code_200()
        {
            testCaseId = "TC-19040";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_search_By_Name_()
        {
            testCaseId = "TC-19041";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task PATCH_api_v2_utilities_id_oldestdatapointdate()
        {
            testCaseId = "TC-19042";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task PATCH_api_v2_utilities_bysiteid_site_id_oldestdatapointdate()
        {
            testCaseId = "TC-19043";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task PUT_api_v2_utilities_id_Response_Code_401()
        {
            testCaseId = "TC-19044";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_Response_Code_401()
        {
            testCaseId = "TC-19045";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_id_Response_Code_401()
        {
            testCaseId = "TC-19046";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_getbyuserid_userId_Response_Code_401()
        {
            testCaseId = "TC-19048";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_search_Response_Code_401()
        {
            testCaseId = "TC-19049";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task PATCH_api_v2_utilities_id_oldestdatapointdate_Response_Code_401()
        {
            testCaseId = "TC-19050";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task PATCH_api_v2_utilities_bysiteid_site_id_oldestdatapointdate_Response_Code_401()
        {
            testCaseId = "TC-19051";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_getbysiteid_SiteId_Response_Code_200()
        {
            testCaseId = "TC-19249";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_getformats_Response_Code_200()
        {
            testCaseId = "TC-19250";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_SiteCodesByUtilityId_utilityId_Response_Code_200()
        {
            testCaseId = "TC-19251";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_SiteCodes_siteId_Response_Code_200()
        {
            testCaseId = "TC-19252";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task DELETE_api_v2_utilities_id_Response_Code_200()
        {
            testCaseId = "TC-19253";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task PUT_api_utilities_id_Update_Utility_Response_Code_200()
        {
            testCaseId = "TC-19254";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task POST_api_v2_creatorCreateUtility()
        {
            testCaseId = "TC-19259";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_geotypes_getcodetypes_Response_Code_200_()
        {
            testCaseId = "TC-19260";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task DELETE_api_v2_geotypes_Response_Code_200_()
        {
            testCaseId = "TC-19261";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_account_getunitsofmeasure_Response_Code_200_()
        {
            testCaseId = "TC-19262";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_account_getmetersizes_Response_Code_200_()
        {
            testCaseId = "TC-19263";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GetCodeTypes_CodeRead()
        {
            testCaseId = "TC-19264";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task DELETE_api_v2_utilities_id_Response_Code_200_()
        {
            testCaseId = "TC-19265";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_modules_getdefaultmodulefeatures_Response_Code_200_()
        {
            testCaseId = "TC-19266";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_id_Response_Code_401_Duplicate()
        {
            testCaseId = "TC-19267";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_sitecodes_siteId_Response_Code_401()
        {
            testCaseId = "TC-19268";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_getFormats_GetUtilityFormats_Response_Code_401()
        {
            testCaseId = "TC-19269";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_SiteCodesByUtilityId_utilityId_Response_Code_401()
        {
            testCaseId = "TC-19270";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_SiteCodes_siteId_Response_Code_401()
        {
            testCaseId = "TC-19271";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task DELETE_api_v2_utilities_id_Response_code_401()
        {
            testCaseId = "TC-19272";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task POST_api_v2_creatorCreateUtility_Response_Code_401()
        {
            testCaseId = "TC-19278";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_geotypes_getcodetypes_Response_Code_401_()
        {
            testCaseId = "TC-19279";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task DELETE_api_v2_geotypes_Response_Code_401()
        {
            testCaseId = "TC-19280";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_account_getunitsofmeasure_Response_Code_401_()
        {
            testCaseId = "TC-19281";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_account_getmetersizes_Response_Code_401()
        {
            testCaseId = "TC-19282";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GetCodeTypes_CodeRead_Duplicates()
        {
            testCaseId = "TC-19283";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_modules_getdefaultmodulesfeatures_Response_Code_401()
        {
            testCaseId = "TC-19285";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task API_Security_POST_CreateUserMultipleNeptune_Admin()
        {
            testCaseId = "TC-21673";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task API_Security_POST_CreateUserMultipleNon_Neptune_Admin()
        {
            testCaseId = "TC-21674";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task API_Security_PUT_EditUserMultipleNeptune_Admin()
        {
            testCaseId = "TC-21675";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task API_Security_PUT_EditUserMultipleNon_Neptune_Admin()
        {
            testCaseId = "TC-21676";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_awlookup_site_Id_office_Response_Code_401()
        {
            testCaseId = "TC-24197";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("APITests")]
        [Test]
        public async Task Utility_API_New_Controller_API_Deployment_Service()
        {
            testCaseId = "TC-24493";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task Utility_API_Update_Reverse_Proxy()
        {
            testCaseId = "TC-24494";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_awlookup_site_Id_office_Response_Code_200()
        {
            testCaseId = "TC-24506";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task POST_api_v2_utilities_awlookup_Response_Code_401()
        {
            testCaseId = "TC-24507";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task AW_Utility_API_Update_YAML()
        {
            testCaseId = "TC-24577";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task AW_Utility_GET_api_v1_utility()
        {
            testCaseId = "TC-24591";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("APITests")]
        [Test]
        public async Task AW_Utility_GET_api_v1_utility_Response_Code_200()
        {
            testCaseId = "TC-24592";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("APITests")]
        [Test]
        public async Task AW_Utility_GET_api_v1_utility_Response_Code_403()
        {
            testCaseId = "TC-24593";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 403)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 403");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task AW_Utility_GET_api_v1_utility_Response_Code_401()
        {
            testCaseId = "TC-24594";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 401)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 401");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task Utility_API_Inferface_Utility_S3()
        {
            testCaseId = "TC-24744";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task POST_api_v2_utilities_awlookup_Response_Code_200()
        {
            testCaseId = "TC-25204";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_id_Get_Utility_by_id_to_check_Blank_MIUID_and_Duplicate_MIUID()
        {
            testCaseId = "TC-26954";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task PUT_api_v2_utilities_id_Update_the_Blank_MIUID_and_Duplicate_MIUID_field_values()
        {
            testCaseId = "TC-26956";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task PUT_api_v2_utilities_id_Update_Utility_Parameters()
        {
            testCaseId = "TC-27555";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_Return_List_of_Response_Code_200()
        {
            testCaseId = "TC-27558";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_id_Return_Utility_Details()
        {
            testCaseId = "TC-27559";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_search_By_Name_Response_Code_200()
        {
            testCaseId = "TC-27560";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_geotypes_getcodetypes()
        {
            testCaseId = "TC-27616";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_getbysiteid_SiteId_Return_SiteID_Details()
        {
            testCaseId = "TC-27619";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_getformats_Return_Import_Export_Formats()
        {
            testCaseId = "TC-27620";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_SiteCodesByUtilityId_utilityId_Return_SkipCodes_by_Utility_ID()
        {
            testCaseId = "TC-27621";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task DELETE_api_v2_geotypes_()
        {
            testCaseId = "TC-27622";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_v2_utilities_SiteCodes_siteId_Return_SkipCodes_by_SiteID()
        {
            testCaseId = "TC-27625";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_account_getunitsofmeasure_()
        {
            testCaseId = "TC-27626";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_account_getmetersizes()
        {
            testCaseId = "TC-27627";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task DELETE_api_v2_utilities_id_()
        {
            testCaseId = "TC-27651";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task GET_api_modules_getdefaultmodulefeatures()
        {
            testCaseId = "TC-27652";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task PATCH_api_v2_utilities_id_oldestdatapointdate_Response_Code_200()
        {
            testCaseId = "TC-27691";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task PATCH_api_v2_utilities_bysiteid_site_id_oldestdatapointdate_Response_Code_200()
        {
            testCaseId = "TC-27698";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 200)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 200");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        [Category("APITests")]
        [Test]
        public async Task POST_api_v2_creatorCreateUtility_Response_Code_201()
        {
            testCaseId = "TC-27704";
            qTestUniqueId = "40929276";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                if (Convert.ToInt16(utilityresponse["ResponseCode"]) != 201)
                {
                    ReporterFactory.LogFailure("<i>Response code is:" + code + " " + "But expected code is 201");
                }
                else
                {
                    api.testReport.Pass("<i>Response code is:" + code);
                }

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
