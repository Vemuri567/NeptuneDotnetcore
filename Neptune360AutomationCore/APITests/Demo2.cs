using Neptune360UIAutomation.APIUtilities.Models.Requests;
using Neptune360UIAutomation.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation.APITests
{
    public class Demo2 : TestBaseTemplate
    {
        


        
        public void beforeTest()
        {
            BaseURL = "https://kqm8i1oav0.execute-api.us-east-1.amazonaws.com";
            XAPIKey = "sAJnYobq3C9SKsuPPPOXb1b0qyXrYnnv1vyJTZeS";
            APIClient = "api-client_241274249YMEZU";
            ClientSecret = "GJDNQDWK";
            endpointtokenUrl = "/api/v1/token";
            endpointurl = "/api/v1/utility"; 
            baseQaUrl = "https://kqm8i1oav0.execute-api.us-east-1.amazonaws.com";

        }

        [Category("Demo2")]
        [Test]
        public async Task SDK_V2_GET_Utilities_ResponseCode_200()
        {
            beforeTest();
            startDate = DateTime.Now;
            try
            {
                Helper helper = new Helper();

                var api = new Authorization();
                var apiResponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var content = apiResponse["ResponseContent"];

                Assert.AreEqual("200", apiResponse["ResponseCode"].ToString());

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }
        

        [Category("Demo2")]
        [Test]
        public async Task SDK_V2_GET_Utilities_ResponseCode_401()
        {
            beforeTest();
            startDate = DateTime.Now;
            try
            {
                endpointurl = "/api/v2/readings?site_id=279&begin_date=2022-01-01&end_date=2022-06-20&page=1";
                
                Helper helper = new Helper();
                var api = new Authorization();
                var apiResponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", false);

                Assert.AreEqual("401", apiResponse["ResponseCode"].ToString());

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        [Category("Demo2")]
        [Test]
        public async Task SDK_V2_GET_Utilities_Response_Contract()
        {
            beforeTest();
            startDate = DateTime.Now;
            IList<string> validationEvents = new List<string>();
            try
            {
                Helper helper = new Helper();

                var api = new Authorization();

                var utilityresponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);
                var utilitycontent = utilityresponse["ResponseContent"];
                
                string SchemaExpected = System.IO.File.ReadAllText(@"D:\API_Automation_1\netpune360uiautomation\Neptune360UIAutomation\APITests\JsonSchema\utility.json");
                JSchema schema = JSchema.Parse(SchemaExpected);
                
                JObject response = JObject.Parse(utilitycontent.ToString());

                bool valid = response.IsValid(schema, out validationEvents);                

                Assert.IsTrue(valid);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                string errors = "";
                foreach(string str in validationEvents)
                    errors=errors+str+"\n";
                Assert.Fail(errors);
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        [Category("Demo2")]
        [Test]
        public async Task SDK_V2_GET_Utilities_Response_DataBaseValidation()
        {
            beforeTest();
            startDate = DateTime.Now; 
            try
            {
                Helper helper = new Helper();
                var api = new Authorization();

                var apiResponse = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);

                var content = apiResponse["ResponseContent"];
                JObject contentJson = JObject.Parse(content.ToString());
                var elementValues = JsonConvert.DeserializeObject<UtilityDataObjects>(content.ToString());

                //get DB result
                DataTable DBresult = DataAction.QueryExecution("Aurora", DatabaseRepository.selectAllUtilities_Aurora);                
                             

                Assert.AreEqual(elementValues.Utilities[0].site_id, DBresult.Rows[0]["SiteID"]);
                Assert.AreEqual(elementValues.Utilities[0].name, DBresult.Rows[0]["UtilityName"]);
                Assert.AreEqual(elementValues.Utilities[0].unit_of_measure, DBresult.Rows[0]["UOM"]);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }
        
        
        [Category("Demo2")]
        [Test]
        public async Task SDK_V2_GET_Utilities_Response_Put_to_ResponseGetDB()
        {
            beforeTest();
            startDate = DateTime.Now;
            try
            {
                string dateTimeNow = startDate.ToString().Replace(" ", "");
                Helper helper = new Helper();
                var api = new Authorization();

                string payloadFile = System.IO.File.ReadAllText(@"D:\API_Automation_1\netpune360uiautomation\Neptune360UIAutomation\JsonFiles\UtilitiesPut.json");
                string payloadFileUpdated = payloadFile.Replace("<address2_placeholder>", dateTimeNow);

                var payload = HandleContent.ParseJsonString<PutUtilityRequest>(payloadFileUpdated);

                BaseURL = "https://kqm8i1oav0.execute-api.us-east-1.amazonaws.com";
                endpointurl = "/api/v2/utilities/277";
                XAPIKey = "sAJnYobq3C9SKsuPPPOXb1b0qyXrYnnv1vyJTZeS";
                APIClient = "api-client_241274249YMEZU";
                ClientSecret = "GJDNQDWK";
                endpointtokenUrl = "/api/v1/token";                
                baseQaUrl = "http://utility.qa.neptune360.com";
                                
                var apiResponse = await helper.PutAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, payload, true);

                var content = apiResponse["ResponseContent"];
                JObject contentJson = JObject.Parse(content.ToString());
                var elementValues = JsonConvert.DeserializeObject<PutUtilityRequest>(content.ToString());

                ////validation 1 - Response validation
                Assert.AreEqual(dateTimeNow, elementValues.address2);


                ////validation 2 - Get Response Validation
                endpointurl = "/api/v2/utilities/277";
                
                var apiResponseGet = await helper.GetAPI_Response(api, BaseURL, endpointtokenUrl, XAPIKey, APIClient, ClientSecret, baseQaUrl, endpointurl, "", true);

                content = apiResponseGet["ResponseContent"];
                contentJson = JObject.Parse(content.ToString());
                elementValues = JsonConvert.DeserializeObject<PutUtilityRequest>(content.ToString());

                Assert.AreEqual(dateTimeNow, elementValues.address2);


                ////Validation 3 - DB validation
                DataTable DBresult = DataAction.QueryExecution("Aurora", DatabaseRepository.selectAddress2_Aurora);
                Object cellValue = DBresult.Rows[0][0];

                Assert.AreEqual(dateTimeNow, cellValue);
                

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        /*void validateResponse(string expected, string actual)
        {
            if (expected.Equals(actual))
            {
                api.testReport.Pass("<i>Response code is:" + code);
            }
            else
            {
                ReporterFactory.LogFailure("<i>Response code is:" + actual + " " + "But expected code is " + expected);
            }
            Assert.AreEqual(expected, actual);  
        }*/
    }
}
