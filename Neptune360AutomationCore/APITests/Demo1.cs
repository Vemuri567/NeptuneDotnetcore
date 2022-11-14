using Neptune360UIAutomation.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation.APITests
{
    public class Demo1 : TestBaseTemplate
    {
        public static Authorization api;
        

        [OneTimeSetUp]
        public void beforeclass()
        {
            BaseURL = "https://kqm8i1oav0.execute-api.us-east-1.amazonaws.com";
            XAPIKey = "uZu5mzYM7S8s5zm9jHox717u7m3tdqfD248Y5isl";
            APIClient = "api-client_246274249SPCQO";
            ClientSecret = "KJESEOPF";
            endpointtokenUrl = "/api/v1/token";
            endpointurl = "/api/v2/readings?site_id=50222&begin_date=2022-03-01&end_date=2022-03-6";
            baseQaUrl = "https://kqm8i1oav0.execute-api.us-east-1.amazonaws.com";

        }


        [Category("Demo1")]
        [Test]
        public async Task SDK_V2_GET_Readings_ResponseCode_200()
        {            
            startDate = DateTime.Now;
            try
            {
                Helper helper = new Helper();
                
                api = new Authorization();
                var apiResponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var content = apiResponse["ResponseContent"];

                validateResponse("200", apiResponse["ResponseCode"].ToString());

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        [Category("Demo1")]
        [Test]
        public async Task SDK_V2_GETReadings_ResponseCode403()
        {
            /*testCaseId = "TC-16041";
            qTestUniqueId = "34903178";*/
            startDate = DateTime.Now;
            try
            {
                XAPIKey = "kvvU7Xbbjb8i4ZI8ZPQpf4Bb9JZSXcYp1CI0AT1D";
                APIClient = "api-client_244271246SWEBX";
                ClientSecret = "RHRGBZFG";

                
                Helper helper = new Helper();
                var api = new Authorization();
                var apiResponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var content = apiResponse["ResponseContent"];

                validateResponse("403", apiResponse["ResponseCode"].ToString());

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Demo1")]
        [Test]
        public async Task SDK_V2_GET_Readings_Response_Code401()
        {            
            startDate = DateTime.Now;
            try
            {
                endpointurl = "/api/v2/readings?site_id=279&begin_date=2022-01-01&end_date=2022-06-20&page=1";

                Helper helper = new Helper();
                var api = new Authorization();
                var apiResponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                validateResponse("401", apiResponse["ResponseCode"].ToString());

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }




        [Category("Demo1")]
        [Test]
        public async Task SDK_V2_GET_Readings_ResponseCode_Contract()
        {
            /*testCaseId = "TC-27579";
            qTestUniqueId = "55625362";
            */
            startDate = DateTime.Now;
            try
            {
                // SetAPIData(testCaseId);
                Helper helper = new Helper();
                //var api = new Authorization();
                api = new Authorization();

                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];



                var elementValues = JsonConvert.DeserializeObject<LastPageReadingsDataObjects>(utilityresponse["ResponseContent"].ToString());


                string SchemaExpected = System.IO.File.ReadAllText(@"D:\API_Automation_1\netpune360uiautomation\Neptune360UIAutomation\APITests\JsonSchema\readings.json");
                JSchema schema = JSchema.Parse(SchemaExpected);


                //var schema = JsonSchema.Parse(myschemaJson);

                IList<string> validationEvents = new List<string>();
                JObject response = JObject.Parse(utilitycontent.ToString());
                                
                bool valid = response.IsValid(schema, out validationEvents);

                Console.WriteLine(validationEvents);

                Assert.IsTrue(valid);

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
    }
}
