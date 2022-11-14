using ExcelDataReader;
using Neptune360UIAutomation.APIUtilities.Models;
using Neptune360UIAutomation.APIUtilities.Models.Requests;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Neptune360UIAutomation.APIPoc
{
    public class Qtest : TestBaseTemplate
    {

        public static List<Datacollection> _dataCol = new List<Datacollection>();

        /// <summary>
        /// This test script validate ALL API Response codes
        /// </summary>
        [Category("APIPOC")]
        [TestCaseSource(typeof(TestBaseTemplate), "DataSourcAPIData")]
        public async Task ValidateAPI_Responses(Dictionary<string, string> keys)
        {
            try
            {


                //DataTable table =PopulateInCollection("D:\\master\\Neptune360UIAutomation\\TestData\\TestData.xlsx");
                //Getting data from API Test datasheet
                //for (int row = 1; row <= table.Rows.Count; row++)
                //{
                string execution = keys["Execution"];
                if (execution == "Y")
                {
                    testCaseId = keys["TCId"];
                    ReporterFactory.TestReport.Info("Test Case Id : " + testCaseId);
                    qTestUniqueId = keys["QTestId"];
                    startDate = DateTime.Now;

                    //Getting test steps from Qtest for given TestCaseId
                    GetTestSteps[] steps = QTest.getTestSteps(qTestUniqueId);
                    var obj = stepDetails(steps);
                    List<string> stringitems = obj.Item1;
                    List<List<string>> scopes = obj.Item2;
                    List<Dictionary<string, string>> parameters = obj.Item3;
                    Helper helper = new Helper();
                    int status = 0;
                    int expectedresult = 0;
                    string code = "";

                    var api = new Authorization();

                    switch (stringitems[2])
                    {
                        case "GET":
                            ReporterFactory.TestReport.Info("Method : " + stringitems[2]);
                            var utilityresponse = await helper.GetSwaggerAPI_Response(api, scopes[0], stringitems[3], stringitems[0], parameters[0]);
                            code = stringitems[4];
                            int indexpos = code.IndexOf(':') + 1;
                            string expectedcode = code.Substring((indexpos), (code.Length - indexpos));
                            if (expectedcode.Contains("Error"))
                            {
                                expectedresult = Int16.Parse(expectedcode.Substring(0, 3));
                            }
                            else
                            {
                                expectedresult = Int16.Parse(expectedcode);
                            }

                            ReporterFactory.TestReport.Info("Expected Response Code : " + expectedcode);
                            status = Convert.ToInt16(utilityresponse["ResponseCode"]);
                            ReporterFactory.TestReport.Info("Actual Response Code : " + status);
                            var utilitycontent = utilityresponse["ResponseContent"];

                            break;
                        case "PUT":
                            //var utilityresponse1 = await helper.PutAPI_Response(api, stepsDescription[0].Split(" ".ToCharArray())[1], stepsDescription[1].Split(" ".ToCharArray())[1], stepsDescription[2].Split(" ".ToCharArray())[1], stepsDescription[3].Split(" ".ToCharArray())[1], stepsDescription[4].Split(" ".ToCharArray())[1], stepsDescription[5].Split(" ".ToCharArray())[1], stepsDescription[6].Split(" ".ToCharArray())[1], payload1, true);
                            //status = Convert.ToInt16(utilityresponse1["ResponseCode"]);
                            break;

                    }

                    if (status == expectedresult)
                    {

                        ReporterFactory.TestReport.Pass("<i>Response code Matches with Expected : " + status);
                    }
                    else
                    {
                        ReporterFactory.LogFailure("<i>Response code is not matched with expected : " + code + " But Actual Response code is : " + status);
                    }
                    QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);

                }
                //   }

                //List<Datacollection> apiData = APITestData();
                /*for (int i = 1; i <= ((apiData.Count) / 3); i++)
                {
                    string execution = ExcelHelper.ReadData(i, "Execution");
                    //if Execution value is Y, then those test cases will execute
                    if (execution == "Y")
                    {
                        testCaseId = ExcelHelper.ReadData(i, "TCId");
                        ReporterFactory.TestReport.Info("Test Case Id : " + testCaseId);
                        qTestUniqueId = ExcelHelper.ReadData(i, "QTestId");
                        startDate = DateTime.Now;

                    //Getting test steps from Qtest for given TestCaseId
                    GetTestSteps[] steps = QTest.getTestSteps(qTestUniqueId);
                    var obj = stepDetails(steps);
                    List<string> stringitems = obj.Item1;
                    List<List<string>> scopes = obj.Item2;
                    List<Dictionary<string, string>> parameters = obj.Item3;
                    Helper helper = new Helper();
                    int status = 0;
                    int expectedresult = 0;


                    var api = new Authorization();

                        switch (stringitems[2])
                        {
                            case "GET":
                                ReporterFactory.TestReport.Info("Method : " + stringitems[2]);
                                var utilityresponse = await helper.GetSwaggerAPI_Response(api, scopes[0], stringitems[3], stringitems[0], parameters[0]);
                                string code = stringitems[4];
                                int indexpos = code.IndexOf(':') + 1;
                                string expectedcode = code.Substring((indexpos), (code.Length - indexpos));
                                if (expectedcode.Contains("Error"))
                                {
                                    expectedresult = Int16.Parse(expectedcode.Substring(0, 3));
                                }
                                else
                                {
                                    expectedresult = Int16.Parse(expectedcode);
                                }

                                ReporterFactory.TestReport.Info("Expected Response Code : " + expectedcode);
                                status = Convert.ToInt16(utilityresponse["ResponseCode"]);
                                ReporterFactory.TestReport.Info("Actual Response Code : " + status);
                                var utilitycontent = utilityresponse["ResponseContent"];

                            break;
                        case "PUT":
                            //var utilityresponse1 = await helper.PutAPI_Response(api, stepsDescription[0].Split(" ".ToCharArray())[1], stepsDescription[1].Split(" ".ToCharArray())[1], stepsDescription[2].Split(" ".ToCharArray())[1], stepsDescription[3].Split(" ".ToCharArray())[1], stepsDescription[4].Split(" ".ToCharArray())[1], stepsDescription[5].Split(" ".ToCharArray())[1], stepsDescription[6].Split(" ".ToCharArray())[1], payload1, true);
                            //status = Convert.ToInt16(utilityresponse1["ResponseCode"]);
                            break;

                    }

                    if (status == expectedresult)
                    {

                            ReporterFactory.TestReport.Pass("<i>Response code Matches with Expected : " + status);
                        }
                        else
                        {
                            ReporterFactory.LogFailure("<i>Response code is not matched with expected : " + code + " But Actual Response code is : " + status);
                        }
                        QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);

                    }
                }

                */
            }
            catch (Exception e)
            {
                //ReporterFactory.LogFailure(e.Message);
                Console.WriteLine(e.Message);
            }
        }

        public Tuple<List<string>, List<List<string>>, List<Dictionary<string, string>>> stepDetails(GetTestSteps[] steps)
        {
            List<List<string>> items = new List<List<string>>();
            List<string> items2 = new List<string>();
            List<Dictionary<string, string>> items3 = new List<Dictionary<string, string>>();
            try
            {


                bool flag = false;
                Dictionary<String, String> stepids = new Dictionary<string, string>();
                for (int i = 0; i < steps.Length; i++)
                {
                    string key = "";
                    string value = "";
                    string description = steps[i].description;
                    string expected = steps[i].expected;
                    Regex regex = new Regex("(<.*?>\\s*)+", RegexOptions.Singleline);
                    string resultText = regex.Replace(description, " ").Trim();
                    Regex regex1 = new Regex("(<.*?>\\s*)+", RegexOptions.Singleline);
                    string resultText1 = regex.Replace(expected, " ").Trim();
                    if (!resultText.Equals("Button") && !resultText.Equals("Controller"))
                    {
                        stepids.Add(resultText, resultText1);
                    }


                }
                string[] scope = stepids["Scopes"].Trim().Split(',');
                List<string> scopes = new List<string>();
                string[] splitted = scope[0].Split(' ');
                for (int i = 0; i <= scope.Length - 1; i++)
                {
                    if (scope[i] != "")
                    {
                        scopes.Add(scope[i]);
                    }

                }
                int index = stepids["URL"].IndexOf("swagger");
                string url = stepids["URL"].Substring(0, index - 1);
                Dictionary<string, string> headers = new Dictionary<string, string>();
                string[] requestparams = stepids["Request parameters"].Trim().Split(',');
                for (int t = 0; t <= requestparams.Length - 1; t++)
                {
                    if (requestparams[t] != "")
                    {
                        /*char[] ch = requestparams[t].ToCharArray();
                        int no = 0;
                        bool flag1 = false;
                        for (int i = 0; i <= ch.Length - 1; i++)
                        {
                            if (i > 0 && flag1 == true)
                            {
                                no = i;
                                flag1 = false;
                            }
                            if (ch[i] == ' ')
                            {

                                for (int j = i + 1; j <= ch.Length - 1; j++)
                                {
                                    if (ch[j] == ':')
                                    {
                                        for (int k = j; k >= i; k--)
                                        {
                                            if (ch[k] == ' ')
                                            {
                                                string d = requestparams[t].Substring(no, (i - no)).Trim();
                                                string[] split = d.Split(':');
                                                headers.Add(split[t].Trim(), split[1].Trim());
                                                flag1 = true;
                                            }
                                        }
                                    }
                                    if (flag1 == true)
                                    {
                                        break;
                                    }

                                }
                            }
                            if (i == ch.Length - 1)
                        
                            {*/
                        //string e = requestparams[t].Substring(no, ((ch.Length) - no)).Trim();
                        string e = requestparams[t].Trim();
                        string[] f = e.Split(':');
                        headers.Add(f[0].Trim(), f[1].Trim());
                        //}
                        //}
                    }
                }


                items.Add(scopes);
                try
                {
                    items3.Add(headers);
                    items2.Add(stepids["Endpoint URL"]);
                    try
                    {
                        items2.Add(stepids["Response Payload"]);
                    }
                    catch (Exception ex)
                    {
                        ReporterFactory.LogInfo(ex.Message);
                    }
                    items2.Add(stepids["Method"]);
                    items2.Add(url);
                    items2.Add(stepids["Validate the response"]);
                }
                catch (Exception ex)
                {
                    ReporterFactory.LogInfo(ex.Message);
                }
                return Tuple.Create(items2, items, items3);
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
                return Tuple.Create(items2, items, items3);
            }

        }

        public static DataTable PopulateInCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);

            //Iterate through the rows and columns of the Table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    //Add all the details for each row
                    _dataCol.Add(dtTable);
                }
            }
            return table;
        }

        public static DataTable ExcelToDataTable(string fileName)
        {
            using (var stream = File.Open(fileName, FileMode.Open, FileAccess.ReadWrite))
            {

                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    //Get all the Tables
                    DataTableCollection table = result.Tables;
                    //Store it in DataTable
                    DataTable resultTable = table["API"];
                    //return
                    return resultTable;
                }
            }
        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                //Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in _dataCol
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();

                //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }



    }

    public class Datacollection
    {
        public int rowNumber { get; set; }
        public string colName { get; set; }
        public string colValue { get; set; }
    }



}
