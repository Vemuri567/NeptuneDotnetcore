using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public class DatabaseRepository
    {
        public const string allTables = "select * from information_schema.tables;";
        public const string selectAllUtilities_Redshift = "SELECT * FROM dimensions.dim_utility where siteid='12345';";
        public const string selectAllUtilities_Aurora = "SELECT * FROM utility where siteid='60222';";
        public const string selectAddress2_Aurora = "SELECT Address2 FROM utility where siteid='60222';";

    }
}
