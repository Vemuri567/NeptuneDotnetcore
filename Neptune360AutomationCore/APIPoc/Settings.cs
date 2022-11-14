using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation.APIPoc
{
    public class Settings
    {
        public string CorsPolicyOrigins { get; set; }
        public string IdentityServerAuthority { get; set; }
        public string My360ClientSecret { get; set; }
        public string My360ClientId { get; set; }
        public string ImpExpService { get; set; }
        public string My360Service { get; set; }
        public string NeptuneIdpAuthority { get; set; }
        public string NeptuneImpExpEndPoint { get; set; }
    }
}
