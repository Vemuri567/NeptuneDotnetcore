using Newtonsoft.Json;
using RestSharp;
using Neptune360UIAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neptune360UIAutomation.APIUtilities.Models.Requests;
using static Neptune360UIAutomation.APIUtilities.Models.Requests.Class1;
using AventStack.ExtentReports;

namespace Neptune360UIAutomation
{
    public class Authorization
    {
        private Helper helper;

        public Authorization()
        {
            helper = new Helper();
        }
        public async Task<RestResponse> GetAuthorizationKey(string baseUrl,string endpoint,string xAPIKey, string apiClient, string clientSecret)
        {
            
            var client = helper.SetUrl(baseUrl, endpoint);
            var request = helper.CreateGetRequest_ForAuthorizationBearerKey(xAPIKey, apiClient, clientSecret);
            request.RequestFormat = DataFormat.Json;
            var response = await helper.GetResponseAsync(client, request);
            return response;
        }

        public async Task<RestResponse> GetAuthorization(string authorizationKey,string baseUrl, string endpoint, string xAPIKey)
        {

            var client = helper.SetUrl(baseUrl, endpoint);
            var request = helper.CreateGetRequest(authorizationKey, xAPIKey);
            request.RequestFormat = DataFormat.Json;
            var response = await helper.GetResponseAsync(client, request);
            return response;
        }
        public async Task<RestResponse> GetSwaggerAuthorization(string authorizationKey, string baseUrl, string endpoint,Dictionary<string,string> headers)
        {

            var client = helper.SetUrl(baseUrl, endpoint);
            var request = helper.CreateSwaggerGetRequest(authorizationKey,headers);
            request.RequestFormat = DataFormat.Json;
            var response = await helper.GetResponseAsync(client, request);
            return response;
        }

        public async Task<RestResponse> CreateNewRequest(string authorizationKey,string baseUrl, string endpoint,string xapikey, dynamic payload)
        {
            var client = helper.SetUrl(baseUrl, endpoint);
            var request = helper.CreatePostRequest<Root>(authorizationKey,xapikey, payload);
            var response = await helper.GetResponseAsync(client, request);
            return response;
        }

        public async Task<RestResponse> CreateNewPutRequest(string authorizationKey, string baseUrl, string endpoint, string xapikey, dynamic payload)
        {
            var client = helper.SetUrl(baseUrl, endpoint);
            var request = helper.CreatePutRequest<PutUtilityRequest>(authorizationKey, xapikey, payload);
            var response = await helper.GetResponseAsync(client, request);
            return response;
        }

        public  ExtentTest testReport
        {
            get { return ReporterFactory.TestReport; }
        }

    }
}
