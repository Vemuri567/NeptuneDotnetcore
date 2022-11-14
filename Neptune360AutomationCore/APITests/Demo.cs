using Neptune360UIAutomation.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation.APITests
{
    public class Demo : TestBaseTemplate
    {
        public static Authorization api;
        public static Helper helper;
        public static Dictionary<string, object> utilityresponse;

        [OneTimeSetUp]
        public void beforeclass()
        {
            BaseURL = "";
            XAPIKey = "";
            APIClient = "";
            ClientSecret = "";
            endpointtokenUrl = "";
            endpointurl = "";

            api = new Authorization();
            helper = new Helper();


            //utilityresponse = helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);

        }


        [Category("APITestsDemo")]
        [Test]
        public async Task SDK_V2_GET_Readings_ResponseCode_200()
        {
            /****
             * 
             *   testCaseId = "TC-27579";
                 qTestUniqueId = "55625362";
            */
            startDate = DateTime.Now;
            try
            {
                //SetAPIData(testCaseId);

                //Helper helper = new Helper();
                //api = new Authorization();
                //var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                validateResponse("200", utilityresponse["ResponseCode"].ToString());

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("APITestsDemo")]
        [Test]
        public async Task SDK_V2_GET_Readings_ResponseCode_Contract()
        {
            /****
             * 
             *   testCaseId = "TC-27579";
                 qTestUniqueId = "55625362";
            */
            startDate = DateTime.Now;
            try
            {
                //SetAPIData(testCaseId);
                //Helper helper = new Helper();
                //api = new Authorization();

                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];

                

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        void validateResponse(string expected, string actual)
        {
            if (expected.Equals(actual))
            {
                api.testReport.Pass("<i>Response code is:" + code);
            }
            else
            {
                ReporterFactory.LogFailure("<i>Response code is:" + actual + " " + "But expected code is "+ expected); 
            }
        }

        /* Task<Dictionary<string, object>> GetAPI_Response(Authorization api, string baseUrl, string endpointToken, string xAPIKey, string apiClient, string clientSecret, string baseQaUrl, string endpointurl, string payload = "", bool validToken = true)
        {
            Dictionary<string, object> responseValues = new Dictionary<string, object>();

            if (validToken)
            {
                var response = api.GetAuthorizationKey(baseUrl, endpointToken, xAPIKey, apiClient, clientSecret);
                Dictionary<string, object> content = HandleContent.GetContent<Dictionary<string, object>>(response);
                var utilityresponse = api.GetAuthorization(content["AccessToken"].ToString(), baseQaUrl, endpointurl, xAPIKey);
                responseValues.Add("ResponseCode", ((int)utilityresponse.StatusCode));
                responseValues.Add("ResponseContent", utilityresponse.Content);
                return responseValues;
            }
            else
            {
                var utilityresponse = api.GetAuthorization("InvalidToken", baseQaUrl, endpointurl, xAPIKey);
                responseValues.Add("ResponseCode", ((int)utilityresponse.StatusCode).ToString());
                responseValues.Add("ResponseContent", utilityresponse.Content);
                return responseValues;
            }
        }*/

    }
}
