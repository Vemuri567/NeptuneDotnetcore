using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation.APIUtilities.Models
{
    public class ConsumptionReadings
    {
      public string site_id { get; set; }
        public string miu_id { get; set; }
        public string meter_number { get; set; }
        public string meter_custom1 { get; set; }
        public string meter_custom2 { get; set; }
        public string continuous_consumption_status { get; set; }
        public int continuous_consumption_days { get; set; }
        public DateTime reading_datetime { get; set; }
        public string reading { get; set; }
    }

}
