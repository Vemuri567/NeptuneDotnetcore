using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation.Models
{
    public class UtilityDataObjects
    {
        public List<Utility> Utilities { get; set; }
    }

    public class Utility
    {
        public string site_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string address_2 { get; set; }
        public string city { get; set; }
        public string state { get; set; } 
        public string zip { get; set; }
        public string time_zone { get; set; }
        public string unit_of_measure { get; set; }
        public string office { get; set; }
        public bool is_dst_enabled { get; set; }


    }
}
