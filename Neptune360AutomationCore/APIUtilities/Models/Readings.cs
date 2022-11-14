using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation.APIUtilities.Models
{
    public class Endpoint
    {
        public string site_id { get; set; }
        public string miu_id { get; set; }
        public string meter_number { get; set; }
        public List<Reading> readings { get; set; }
    }

    public class Reading
    {
        public string reading { get; set; }
        public DateTime reading_datetime { get; set; }
        public int consumption_state { get; set; }
        public int consumption_35_days { get; set; }
        public int reverse_flow_state { get; set; }
        public int no_flow_35_days { get; set; }
        public int register_change_out { get; set; }
    }

    public class SdkReadings
    {
        public List<Endpoint> endpoints { get; set; }
    }

}
