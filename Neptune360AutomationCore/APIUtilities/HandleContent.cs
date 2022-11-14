using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public static class HandleContent
    {
        public static T GetContent<T>(RestResponse response)
        {
            //*** Build Failure in jenkins ***
            ////try
            ////{
            ////    var content = response.Content;
            ////    return JsonConvert.DeserializeObject<T>(content);
            ////}
            ////catch(Exception e)
            ////{
            ////    string msg = e.Message;
            ////    var content = response.Content;
            ////    return JsonConvert.DeserializeObject<T>(content);
            ////}
            ///
            return default(T);
        }

        public static string SerializeJsonString(dynamic content)
        {
            return JsonConvert.SerializeObject(content, Formatting.Indented);
        }

        public static T ParseJson<T>(string file)
        {
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(file),settings);
        }

        public static T ParseJsonString<T>(string str)
        {
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            return JsonConvert.DeserializeObject<T>(str, settings);
        }
    }
}
