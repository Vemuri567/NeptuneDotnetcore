using Neptune360UIAutomation.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using Neptune360UIAutomation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Neptune360UIAutomation.APIUtilities.Models.Requests;
using RazorEngine.Configuration;
using System.IO;
using Microsoft.Extensions.Configuration;
using static Neptune360UIAutomation.APIUtilities.Models.Requests.Class1;
using Neptune360UIAutomation.APIUtilities.Models;

namespace Neptune360UIAutomation.FunctionalTests
{
   public  class APITest : TestBaseTemplate
    {

        [Category("APITests")]
        [Test]
        public async Task SDK_V2_GET_Readings_ResponseCode_200()
        {
            testCaseId = "TC-27579";
            qTestUniqueId = "55625362";
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
        public async Task SDK_V2GETReadings_ResponseCode403()
        {
            testCaseId = "TC-16041";
            qTestUniqueId = "34903178";
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
        public async Task SDK_V2_GET_Readings_Response_Code401()
        {
            testCaseId = "TC-16040";
            qTestUniqueId = "34903177";
            startDate = DateTime.Now;
            try            {
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
        public async Task SDK_V2_GET_Readings()
        {
            testCaseId = "TC-16038";
            qTestUniqueId = "34903175";
            startDate = DateTime.Now;
            try
            {
                SetAPIData(testCaseId);

                Helper helper = new Helper();
                var api = new Authorization();
                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                var elementValues = JsonConvert.DeserializeObject<LastPageReadingsDataObjects>(utilitycontent.ToString());

                //DB validations ---DataAction.QueryExecution("Aurora", DatabaseRepository.selectAllUtilities_Aurora);

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
        public async Task SDK_V2_GETReadings_InvalidSiteID_ResponseCode403()
        {
            testCaseId = "TC-16042";
            qTestUniqueId = "34903179";
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





        /***
         * 
         * 
                Old Code Below
        */

        [Category("APITests")]
        [Test]
        public async Task GetListOfUtilities()
        {
            testCaseId = "TC-25342";
            qTestUniqueId = "";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                BaseURL = testData["BaseURL"];
                XAPIKey = testData["XAPIKey"];
                APIClient = testData["APIClient"];
                ClientSecret = testData["ClientSecret"];
                endpointtokenUrl = testData["EndpointTokenURL"];
                endpointurl = testData["EndpointURL"];
                var api = new Authorization();
                //var respnse1 = await api.GetSwaggerAuthorization("swagger-ui", BaseURL, endpointurl);
                var response = await api.GetAuthorizationKey(BaseURL, endpointtokenUrl, XAPIKey,APIClient, ClientSecret);
                //*** Build Failure in jenkins ***
                //Dictionary<string, object> content = HandleContent.GetContent<Dictionary<string, object>>(response);
                //var utilityresponse = await api.GetAuthorization(content["AccessToken"].ToString(), BaseURL, endpointurl, XAPIKey);
                //var utilitycontent = utilityresponse.Content;

                //var elementValues = JsonConvert.DeserializeObject<UtilityDataObjects>(utilitycontent);

                ////string DBresult = DataAction.QueryExecution("Aurora", DatabaseRepository.selectAllUtilities_Aurora);

                //QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        public async Task GetContinuousConsumption()
        {
            testCaseId = "TC-25343";
            qTestUniqueId = "";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                BaseURL = testData["BaseURL"];
                XAPIKey = testData["XAPIKey"];
                APIClient = testData["APIClient"];
                ClientSecret = testData["ClientSecret"];
                endpointtokenUrl = testData["EndpointTokenURL"];
                endpointurl = testData["EndpointURL"];
                var api = new Authorization();
                var response = await api.GetAuthorizationKey(BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret);
                //*** Build Failure in jenkins ***
                //Dictionary<string, object> content = HandleContent.GetContent<Dictionary<string, object>>(response);
                //var utilityresponse = await api.GetAuthorization(content["AccessToken"].ToString(), BaseURL, endpointurl, XAPIKey);
                //var utilitycontent = utilityresponse.Content;

                //var elementValues = JsonConvert.DeserializeObject<ConsumptionEndpointDataObjects>(utilitycontent);

                //DataAction.QueryExecution("Aurora", DatabaseRepository.selectAllUtilities_Aurora);

                //QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
        public async Task GetLastReadings()
        {
            testCaseId = "TC-25344";
            qTestUniqueId = "";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                BaseURL = testData["BaseURL"];
                XAPIKey = testData["XAPIKey"];
                APIClient = testData["APIClient"];
                ClientSecret = testData["ClientSecret"];
                endpointtokenUrl = testData["EndpointTokenURL"];
                endpointurl = testData["EndpointURL"];
                var api = new Authorization();
                var response = await api.GetAuthorizationKey(BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret);
                //*** Build Failure in jenkins ***
                //Dictionary<string, object> content = HandleContent.GetContent<Dictionary<string, object>>(response);
                //var utilityresponse = await api.GetAuthorization(content["AccessToken"].ToString(), BaseURL, endpointurl, XAPIKey);
                //var utilitycontent = utilityresponse.Content;

                //var elementValues = JsonConvert.DeserializeObject<LastPageReadingsDataObjects>(utilitycontent);

                //DataAction.QueryExecution("Aurora", DatabaseRepository.selectAllUtilities_Aurora);

                //QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
         public async Task CreateNewUserTest()
        {
            testCaseId = "TC-25342";
            qTestUniqueId = "";
            startDate = DateTime.Now; 
            try
            {
                
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                //string jsonFilePath = Jsonfile("createPost.json");
                string jsonFilePath = Jsonfile("createPut.json");
                BaseURL = "https://p6j8bk93pc.execute-api.us-east-1.amazonaws.com";
                XAPIKey = "kvvU7Xbbjb8i4ZI8ZPQpf4Bb9JZSXcYp1CI0AT1D";
                APIClient = "api-client_244271246SWEBX";
                ClientSecret = "RHRGBZFG";
                endpointtokenUrl = testData["EndpointTokenURL"];
                string baseQaURL = "http://utility.qa.neptune360.com";
                //endpointurl = "/api/v2/readings";
                endpointurl="/api/v2/utilities/279";
                //var payload = HandleContent.ParseJson<Root>(jsonFilePath);
                var payload = HandleContent.ParseJson<PutUtilityRequest>(jsonFilePath);
                var api = new Authorization();
                var response = await api.GetAuthorizationKey(BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret);
                //*** Build Failure in jenkins ***
                //Dictionary<string, object> content = HandleContent.GetContent<Dictionary<string, object>>(response);
                ////var utilityresponse = await api.CreateNewRequest(content["AccessToken"].ToString(), BaseURL, endpointurl, XAPIKey, payload);
                //var utilityresponse = await api.CreateNewPutRequest(content["AccessToken"].ToString(), baseQaURL, endpointurl, XAPIKey, payload);
                //var utilitycontent = utilityresponse.Content;
                ////var userContent = HandleContent.GetContent<SdkReadings>(utilityresponse);
                //var userContent = HandleContent.GetContent<PutUtilityResponse>(utilityresponse);
                ////Assert.AreEqual(payload.name, userContent.name);
                //DataAction.QueryExecution("Aurora", DatabaseRepository.selectAllUtilities_Aurora);
                //QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
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
