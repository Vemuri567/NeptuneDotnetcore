using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Neptune360UIAutomation
{
    public class DataBaseHelper
    {
        public static OdbcConnection GetRedShiftConnection(string server, string port, string Username, string password, string DBName)
        {
            try
            {
                // Create the ODBC connection string.
                string connString = "Driver={Amazon Redshift (x86)};" +
                          String.Format("Server={0};Database={1};" +
                          "UID={2};PWD={3};Port={4};SSL=true;Sslmode=Require",
                          server, DBName, Username,
                          password, port);

                // Make a connection using the psqlODBC provider.
                OdbcConnection conn = new OdbcConnection(connString);
                conn.Open();

                return conn;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return null;
            }
        }

        public static MySqlConnection GetAuroraConnection(string server, string username, string password,string Database)
        {
            MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=" + server + "; uid=" + username + "; " +
                "pwd=" + password + "; Database=" + Database+"";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                return conn;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return null;
            }
        }
    }
}
