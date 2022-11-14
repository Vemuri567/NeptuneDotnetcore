using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public class DataAction
    {
        //public static string redShiftServer = "internal-datawarehouse.pre-prod.neptune360.com";
        public static string redShiftServer = "internal-datawarehouse.qa.neptune360.com";
        public static string redShiftPort = "5439";
        public static string redShiftUsername = "etladmin";
        public static string redShiftPassword = "Etladmin123";
        public static string redShiftDBName = "neptunedw";
        public static string auroraDBName = "qa-utilitydb";
        public static string auroraServer = "rds-db.qa.neptune360.com";
        public static string auroraUsername = "sqauser";
        public static string auroraPassword = "SQAuser12345$";

        public static DataTable QueryExecution(string DBType, string script)
        {
            try
            {
                DataSet dataSet = new DataSet();
                DataTable dataTable = new DataTable();
                OdbcConnection ODBC_Conn = null;
                MySqlConnection MySQL_conn = null;
                OdbcDataAdapter odbcDA = null;
                MySqlDataAdapter mySQLDA = null;
                if (DBType.ToUpper() == "RedShift".ToUpper())
                {
                    ODBC_Conn = DataBaseHelper.GetRedShiftConnection(redShiftServer, redShiftPort, redShiftUsername, redShiftPassword, redShiftDBName);
                    odbcDA = new OdbcDataAdapter(script, ODBC_Conn);
                    odbcDA.Fill(dataSet);
                }
                else
                {
                    MySQL_conn = DataBaseHelper.GetAuroraConnection(auroraServer, auroraUsername, auroraPassword, auroraDBName);

                    using (MySqlCommand cmd = new MySqlCommand(script, MySQL_conn))
                    {
                        mySQLDA = new MySqlDataAdapter(cmd);

                        mySQLDA.SelectCommand = cmd;
                        mySQLDA.Fill(dataSet);
                    }
                }

                if (dataSet != null)
                {
                    dataTable = dataSet.Tables[0];
                }

                if (ODBC_Conn != null)
                {
                    ODBC_Conn.Close();
                }

                if (MySQL_conn != null)
                {
                    MySQL_conn.Close();
                }

                //return DataTableToJson(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught while communicating with RedShift Database " + ex.Message);
                return null;
            }
        }

        public static string DataTableToJson(DataTable table)
        {
            string jsonString = string.Empty;
            jsonString = JsonConvert.SerializeObject(table);
            return jsonString;
        }
    }
}
