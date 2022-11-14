
using Newtonsoft.Json;

namespace EAAutoFramework.Config
{
    [JsonObject("AppSettings")]
    public class AppSettings
    {
        [JsonProperty("CorsPolicyOrigins")]
        public static string CorsPolicyOrigins { get; set; }
        [JsonProperty("IdentityServerAuthority")]
        public string IdentityServerAuthority { get; set; }
        [JsonProperty("My360ClientSecret")]
        public string My360ClientSecret { get; set; }
        [JsonProperty("My360ClientId")]
        public string My360ClientId { get; set; }
        [JsonProperty("ImpExpService")]
        public string ImpExpService { get; set; }
        [JsonProperty("My360Service")]
        public string My360Service { get; set; }
        [JsonProperty("NeptuneIdpAuthority")]
        public string NeptuneIdpAuthority { get; set; }
        [JsonProperty("NeptuneImpExpEndPoint")]
        public string NeptuneImpExpEndPoint { get; set; }

        
    }
}
