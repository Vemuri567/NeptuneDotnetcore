using Neptune360UIAutomation.APIPoc;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public class Helper
    {
        private  RestClient client;

        private RestRequest request;
        
        public RestClient SetUrl(string baseUrl, string endpoint)
        {
            var url = baseUrl + endpoint;
            client = new RestClient(url);
            
            return client;
        }

        public RestRequest CreateGetRequest_ForAuthorizationBearerKey(string xAPIKey, string apiClient, string clientSecret)
        {
            request = new RestRequest()
            {
                Method = Method.Get
            };

            request.AddHeaders(new Dictionary<string, string>
            {
                {"x-api-key", xAPIKey },
                { "client-id", apiClient },
                { "client-secret", clientSecret },
                { "Accept", "application/json" },


            });

            return request;
        }

        public RestRequest CreateGetRequest(string bearearKey, string xAPIKey)
        {
           // client.Authenticator = new HttpBasicAuthenticator("nvemuri@neptunetg.com", "Neptune@2023");
            request = new RestRequest()
            {
                Method = Method.Get
            };

            request.AddHeaders(new Dictionary<string, string>
            {
                {"x-api-key", xAPIKey },
                {"Authorization", "Bearer " + bearearKey },
                { "Accept", "application/json" },


            });

            return request;
        }
        public RestRequest CreateSwaggerGetRequest(string bearearKey, Dictionary<string, string> headers)
        {
            // client.Authenticator = new HttpBasicAuthenticator("nvemuri@neptunetg.com", "Neptune@2023");
            request = new RestRequest()
            {
                Method = Method.Get
            };

            request.AddHeaders(new Dictionary<string, string>
            {

                {"Authorization", "Bearer " + bearearKey },
                { "Accept", "application/json" },



            });
            if (headers.Count > 0)
            {
                List<string> keys = new List<string>(headers.Keys);
                for (int i = 0; i <= keys.Count - 1; i++)
                {
                    request.AddParameter(keys[i], headers[keys[i]]);

                }
            }


            return request;
        }
        public RestRequest CreateSwaggerpostRequest(List<string>scopes)
        {
            // client.Authenticator = new HttpBasicAuthenticator("nvemuri@neptunetg.com", "Neptune@2023");
            request = new RestRequest()
            {
                Method = Method.Post
            };

            request.AddParameter("client_id", "my360");
            request.AddParameter("client_secret", "secret");
            request.AddParameter("grant_type", "client_credentials");

            if (scopes.Count > 0)
            {
                List<string> keys = new List<string>(scopes);
                for (int i = 0; i <= keys.Count - 1; i++)
                {
                    request.AddParameter("scope", scopes[i]);

                }
            }
           
            
            return request;
        }
        public async Task<RestResponse> GetSwaggerAuthorization(List<string> scopes)
        {

            var client = SetUrl("http://idp.dev.neptune360.com", "/connect/token");
            var request = CreateSwaggerpostRequest(scopes);
            request.RequestFormat = DataFormat.Json;
            var response = await GetResponseAsync(client, request);
            return response;
        }
        public async Task<string> getSwaggerToken()
        {
            string clientServices = $"{"my360Service"} {"importExportService"}";
            var http = new HttpClient();
            
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, "http://idp.dev.neptune360.com/connect/token")
            {
                Content = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>() {
                    new KeyValuePair<string, string>("client_id","my360"),
                    new KeyValuePair<string, string>("client_secret","secret"),
                    new KeyValuePair<string, string>("grant_type","client_credentials"),
                    
                    //new KeyValuePair<string, string>("scope","routeManagementService"),
                    //new KeyValuePair<string, string>("scope","identityService"),
                    new KeyValuePair<string, string>("scope","utilityService"),
                    //new KeyValuePair<string, string>("scope","shadowService"),
                    //new KeyValuePair<string, string>("scope","importRulesService")


                })
            };
            
            
            var response = await http.SendAsync(requestMessage);
            var json = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                BearerTokenResponse obj= JsonConvert.DeserializeObject<BearerTokenResponse>(json);
                return obj.access_token;
            }
            else
            {
                return null;
            }
            
        }

        public RestRequest CreateGetSwaggerRequest(string bearearKey)
        {
            request = new RestRequest()
            {
                Method = Method.Get
            };

            request.AddHeaders(new Dictionary<string, string>
            {
                //{"x-api-key", xAPIKey },
                { "client-id", bearearKey },
               // {"Authorization", "Bearer " + bearearKey },
                { "Accept", "application/json" },


            });

            return request;
        }

        public RestRequest CreatePostRequest<T>(string authorizationKey, string xapikey, T payload) where T : class
        {
            request = new RestRequest()
            {
                Method = Method.Post
            };
            request.AddHeader("x-api-key", xapikey);
            request.AddHeader("Authorization", "Bearer " + authorizationKey);
            request.AddHeader("Accept", "application/json");
            request.AddBody(payload);
            request.RequestFormat = DataFormat.Json;
            return request;
        }

        public RestRequest CreatePutRequest<T>(string authorizationKey, string xapikey, T payload) where T : class
        {
            request = new RestRequest()
            {
                Method = Method.Put
            };
            request.AddHeader("x-api-key", xapikey);
            request.AddHeader("Authorization", "Bearer " + authorizationKey);
            request.AddHeader("Accept", "application/json");
            request.AddBody(payload);
            request.RequestFormat = DataFormat.Json;
            return request;
        }

        public RestRequest CreateDeleteRequest()
        {
            request = new RestRequest()
            {
                Method = Method.Delete
            };
            request.AddHeader("Accept", "application/json");
            return request;
        }

        public async Task<RestResponse> GetResponseAsync(RestClient restClient, RestRequest restRequest)
        {
            return await restClient.ExecuteAsync(restRequest);
        }

        public async Task<Dictionary<string, object>> GetAPI_Response(Authorization api, string baseUrl, string endpointToken, string xAPIKey, string apiClient, string clientSecret, string baseQaUrl, string endpointurl, string payload = "", bool validToken = true)
        {
            Dictionary<string, object> responseValues = new Dictionary<string, object>();
            
            if (validToken)
            {
                var response = await api.GetAuthorizationKey(baseUrl, endpointToken, xAPIKey, apiClient, clientSecret);
                Dictionary<string, object> content = HandleContent.GetContent<Dictionary<string, object>>(response);
                var utilityresponse = await api.GetAuthorization(content["AccessToken"].ToString(), baseQaUrl, endpointurl, xAPIKey);
                //*** Build Failure in jenkins ***
                ////responseValues.Add("ResponseCode", ((int)utilityresponse.StatusCode));
                ////responseValues.Add("ResponseContent", utilityresponse.Content);
                return responseValues;
            }
            else
            {
                var utilityresponse = await api.GetAuthorization("InvalidToken", baseQaUrl, endpointurl, xAPIKey);
                //*** Build Failure in jenkins ***
                ////responseValues.Add("ResponseCode", ((int)utilityresponse.StatusCode).ToString());
                ////responseValues.Add("ResponseContent", utilityresponse.Content);
                return responseValues;
            }
        }
        public async Task<Dictionary<string, object>> GetSwaggerAPI_Response(Authorization api, List<string> scopes,string baseQaUrl, string endpointurl,Dictionary<string,string> headers, string payload = "")
        {
            ReporterFactory.TestReport.Info("URL : " + baseQaUrl+ endpointurl);
            List<string> keys = new List<string>(headers.Keys);
            for (int i = 0; i <= keys.Count - 1; i++)
            {
                ReporterFactory.TestReport.Info("Parameter "+(i+1)+" - "+keys[i]+" : "+headers[keys[i].ToString()]);

            }
            
            Dictionary<string, object> responseValues = new Dictionary<string, object>();
            if (scopes.Count > 0)
            {
                var res = await GetSwaggerAuthorization(scopes);
                Dictionary<string, object> content = HandleContent.GetContent<Dictionary<string, object>>(res);
                //string token= await getSwaggerToken();
                var utilityresponse = await api.GetSwaggerAuthorization(content["access_token"].ToString(), baseQaUrl, endpointurl, headers);
                responseValues.Add("ResponseCode", ((int)utilityresponse.StatusCode));
                responseValues.Add("ResponseContent", utilityresponse.Content);
                return responseValues;
            }
            else
            {
                var utilityresponse = await api.GetSwaggerAuthorization("",baseQaUrl, endpointurl, headers);
                responseValues.Add("ResponseCode", ((int)utilityresponse.StatusCode));
                responseValues.Add("ResponseContent", utilityresponse.Content);
                return responseValues;
            }


        }
        //public async Task<Dictionary<string, object>> GetSwaggerAPI_Response(Authorization api, List<string> scopes,string baseQaUrl, string endpointurl,Dictionary<string,string> headers, string payload = "")
        //{
        //    ReporterFactory.TestReport.Info("URL : " + baseQaUrl+ endpointurl);
        //    List<string> keys = new List<string>(headers.Keys);
        //    for (int i = 0; i <= keys.Count - 1; i++)
        //    {
        //        ReporterFactory.TestReport.Info("Parameter "+(i+1)+" - "+keys[i]+" : "+headers[keys[i].ToString()]);

        //    }

        //    Dictionary<string, object> responseValues = new Dictionary<string, object>();
        //    if (scopes.Count > 0)
        //    {
        //        var res = await GetSwaggerAuthorization(scopes);
        //        Dictionary<string, object> content = HandleContent.GetContent<Dictionary<string, object>>(res);
        //        //string token= await getSwaggerToken();
        //        var utilityresponse = await api.GetSwaggerAuthorization(content["access_token"].ToString(), baseQaUrl, endpointurl, headers);
        //        responseValues.Add("ResponseCode", ((int)utilityresponse.StatusCode));
        //        responseValues.Add("ResponseContent", utilityresponse.Content);
        //        return responseValues;
        //    }
        //    else
        //    {
        //        var utilityresponse = await api.GetSwaggerAuthorization("",baseQaUrl, endpointurl, headers);
        //        responseValues.Add("ResponseCode", ((int)utilityresponse.StatusCode));
        //        responseValues.Add("ResponseContent", utilityresponse.Content);
        //        return responseValues;
        //    }


    

    public async Task<Dictionary<string, object>> PutAPI_Response(Authorization api, string baseUrl, string endpointToken, string xAPIKey, string apiClient, string clientSecret, string baseQaUrl, string endpointurl, dynamic payload , bool validToken = true)
        {
            Dictionary<string, object> responseValues = new Dictionary<string, object>();

            if (validToken)
            {
                var response = await api.GetAuthorizationKey(baseUrl, endpointToken, xAPIKey, apiClient, clientSecret);
                Dictionary<string, object> content = HandleContent.GetContent<Dictionary<string, object>>(response);
                try
                {
                    var utilityresponse = await api.CreateNewPutRequest(content["AccessToken"].ToString(), baseQaUrl, endpointurl, xAPIKey, payload);
                    responseValues.Add("ResponseCode", ((int)utilityresponse.StatusCode));
                    responseValues.Add("ResponseContent", utilityresponse.Content);
                }
                catch (Exception e)
                {
                    string msg = e.Message;
                }
                
                //responseValues.Add("ResponseCode", ((int)utilityresponse.StatusCode));
               // responseValues.Add("ResponseContent", utilityresponse.Content);
                return responseValues;
            }
            else
            {
               /* var utilityresponse = await api.GetAuthorization("InvalidToken", baseQaUrl, endpointurl, xAPIKey);
                responseValues.Add("ResponseCode", ((int)utilityresponse.StatusCode).ToString());
                responseValues.Add("ResponseContent", utilityresponse.Content);*/
                return responseValues;
            }
        }

    }
}
