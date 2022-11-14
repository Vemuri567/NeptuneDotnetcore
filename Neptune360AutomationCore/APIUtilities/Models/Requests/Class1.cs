using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation.APIUtilities.Models.Requests
{
    public class Class1
    {
        public class Endpoint
        {
            public string site_id { get; set; }
            public string miu_id { get; set; }
            public string meter_number { get; set; }
        }

        public class Root
        {
            public string begin_date { get; set; }
            public string end_date { get; set; }
            public List<Endpoint> endpoints { get; set; }
        }
    }
}
