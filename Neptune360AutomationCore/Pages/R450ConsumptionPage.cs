using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;

namespace Neptune360UIAutomation
{
    public class R450ConsumptionPage : AbstractTemplatePage
    {
        /// <summary>
        /// To validate the R450 Type 3 data in the database
        /// </summary>
        /// <param name="result"></param>
        /// <param name="testData"></param>
        public void ValidateR450Type3Data(DataTable result, Dictionary<string, string> testData)
        {
            try
            {
                string miuid = testData["miuid"];
                string siteid = testData["siteid"];
                //string executionDate = testData["ExecutionDate"];

                if (result.Rows.Count > 0)
                {
                    DateTime resultTimestamp = Convert.ToDateTime(result.Rows[0]["radiotimestamp"]); //consolidatedtimestamp
                    string dbmiuid = result.Rows[0]["miuid"].ToString();
                    string dbsiteid = result.Rows[0]["siteid"].ToString();
                    DateTime currentdate = DateTime.Now.AddDays(-1);

                    if (resultTimestamp.Date.ToShortDateString() == currentdate.Date.ToShortDateString())
                    {
                        ReporterFactory.TestReport.Pass("R450 Type 3 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> found in the <mark>endpointsods.r450_type3</mark> table");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("R450 Type 3 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> not found in the <mark>endpointsods.r450_type3</mark> table");
                    }

                    if (dbmiuid == miuid)
                    {
                        ReporterFactory.TestReport.Pass("R450 Type 3 record for MIU ID: <mark>" + miuid + "</mark> found in the <mark>endpointsods.r450_type3</mark> table");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("R450 Type 3 record for MIU ID: <mark>" + miuid + "</mark> not found in the <mark>endpointsods.r450_type3</mark> table");
                    }

                    if (dbsiteid == siteid)
                    {
                        ReporterFactory.TestReport.Pass("R450 Type 3 record for Site Id: <mark>" + siteid + "</mark> found in the <mark>endpointsods.r450_type3</mark> table");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("R450 Type 3 record for Site Id: <mark>" + siteid + "</mark> not found in the <mark>endpointsods.r450_type3</mark> table");
                    }

                }
                else
                {
                    ReporterFactory.LogFailure("R450 Type 3 data not found in the database");
                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("R450 Type 3 data not found, Error:" + ex.ToString());
            }
        }

        /// <summary>
        /// To validate R450 consumption data is not found in the database
        /// </summary>
        /// <param name="result"></param>
        public void ValidateR450ConsumptionNotFound(DataTable result, Dictionary<string, string> testData, string altday = "")
        {
            try
            {
                //string executionDate = testData["ExecutionDate"];

                if (result.Rows.Count == 0)
                {
                    ReporterFactory.TestReport.Pass("R450 record <mark>NOT FOUND</mark> in the <mark>facts.fct_consumption</mark> table");
                }
                else
                {
                    DateTime resultTimestamp = Convert.ToDateTime(result.Rows[0]["reading_datetime"]);
                    DateTime currentdate = DateTime.Now;

                    if (resultTimestamp.Date.ToShortDateString() != currentdate.Date.ToShortDateString())
                    {
                        ReporterFactory.TestReport.Pass("R450 consumption data for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> NOT FOUND in the <mark>facts.fct_consumption</mark> table");
                    }
                    else
                    {
                        if (altday.ToUpper() == "YES")
                        {
                            currentdate = currentdate.AddDays(-1);
                            if (resultTimestamp.Date.ToShortDateString() != currentdate.Date.ToShortDateString())
                            {
                                ReporterFactory.TestReport.Pass("R450 consumption data for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> NOT FOUND in the <mark>facts.fct_consumption</mark> table");
                            }
                            else
                            {
                                ReporterFactory.LogFailure("R450 consumption data for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> FOUND in the <mark>facts.fct_consumption</mark> table");
                            }
                        }
                        else
                        {
                            ReporterFactory.LogFailure("R450 consumption data for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> NOT FOUND in the <mark>facts.fct_consumption</mark> table");
                        }
                        //ReporterFactory.LogFailure("R450 consumption data for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> FOUND in the <mark>facts.fct_consumption</mark> table");
                    }
                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred while validating R450 Consumption Data, Error:" + ex.ToString());
            }
        }

        /// <summary>
        /// To validate the R450 Consumption data is found in the database
        /// </summary>
        /// <param name="result"></param>
        public void ValidateR450ConsumptionFound(DataTable result, Dictionary<string, string> testData, string day = "", string altday = "")
        {
            try
            {
                DateTime currentdate = DateTime.Now;
                //string executionDate = testData["ExecutionDate"];

                if (result.Rows.Count != 0)
                {
                    DateTime resultTimestamp = Convert.ToDateTime(result.Rows[0]["readingdatetime"]);

                    if (resultTimestamp.Date.ToShortDateString() != DateTime.Now.ToShortDateString())
                    {
                        if (resultTimestamp.Date.ToShortDateString() != DateTime.Now.AddDays(-1).ToShortDateString())
                        {
                            if (day == "yesterday")
                            {
                                currentdate = DateTime.Now.AddDays(-1);

                            }
                        }
                    }

                    //if (executionDate != "")
                    //{
                    //    currentdate = Convert.ToDateTime(executionDate);
                    //}

                    if (day.ToLower() == "yesterday")
                    {
                        currentdate = currentdate.AddDays(-1);
                    }

                    if (resultTimestamp.Date.ToShortDateString() == currentdate.Date.ToShortDateString())
                    {
                        ReporterFactory.TestReport.Pass("R450 consumption data for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> FOUND in the <mark>facts.fct_consumption</mark> table");
                    }
                    else
                    {
                        if (altday.ToUpper() == "YES")
                        {
                            currentdate = currentdate.AddDays(-1);
                            if (resultTimestamp.Date.ToShortDateString() == currentdate.Date.ToShortDateString())
                            {
                                ReporterFactory.TestReport.Pass("R450 consumption data for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> FOUND in the <mark>facts.fct_consumption</mark> table");
                            }
                            else
                            {
                                ReporterFactory.LogFailure("R450 consumption data for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> NOT FOUND in the <mark>facts.fct_consumption</mark> table");
                            }
                        }
                        else
                        {
                            ReporterFactory.LogFailure("R450 consumption data for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> NOT FOUND in the <mark>facts.fct_consumption</mark> table");
                        }
                    }

                }
                else
                {
                    ReporterFactory.LogFailure("R450 record <mark>NOT FOUND</mark> in the <mark>facts.fct_consumption</mark> table");
                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred while validating R450 Consumption Data, Error:" + ex.ToString());
            }
        }

        /// <summary>
        /// To validate the R450 Type 1 data in the database
        /// </summary>
        /// <param name="result"></param>
        /// <param name="day"></param>
        public void ValidateR450Type1Data(DataTable result, string day, Dictionary<string, string> testData, string altday = "")
        {
            try
            {
                //string executionDate = testData["ExecutionDate"];

                DateTime resultTimestamp = new DateTime();
                if (result.Rows.Count > 0)
                {
                    resultTimestamp = Convert.ToDateTime(result.Rows[0]["readingdatetime"]);
                }
                DateTime currentdate = DateTime.Now;
                //if (executionDate != "")
                //{
                //    currentdate = Convert.ToDateTime(executionDate);
                //}

                if (day == "yesterday")
                {
                    currentdate = currentdate.AddDays(-1);
                }

                if (resultTimestamp.Date.ToShortDateString() == currentdate.Date.ToShortDateString())
                {
                    ReporterFactory.TestReport.Pass("R450 Type 1 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> FOUND in the <mark>facts.readings</mark> table");
                }
                else
                {
                    if (altday.ToUpper() == "YES")
                    {
                        currentdate = currentdate.AddDays(-1);
                        if (result.Rows.Count != 0 && resultTimestamp.Date.ToShortDateString() == currentdate.Date.ToShortDateString())
                        {
                            ReporterFactory.TestReport.Pass("R450 Type 1 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> FOUND in the <mark>facts.readings</mark> table");
                        }
                        else
                        {
                            ReporterFactory.LogFailure("R450 Type 1 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> NOT FOUND in the <mark>facts.readings</mark> table");
                        }
                    }
                    else
                    {
                        ReporterFactory.LogFailure("R450 Type 1 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> NOT FOUND in the <mark>facts.readings</mark> table");
                    }

                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred while validating R450 Type 1 readings Data, Error:" + ex.ToString());
            }
        }

        /// <summary>
        /// To validate the R450 Type 2 data in the database
        /// </summary>
        /// <param name="result"></param>
        /// <param name="day"></param>
        public void ValidateR450Type2Data(DataTable result, string day, Dictionary<string, string> testData, string altday = "")
        {
            try
            {
                // string executionDate = testData["ExecutionDate"];

                DateTime resultTimestamp = new DateTime();
                if (result.Rows.Count > 0)
                {
                    resultTimestamp = Convert.ToDateTime(result.Rows[0]["radiotimestamp"]);
                }
                DateTime currentdate = DateTime.Now;
                //if (executionDate != "")
                //{
                //    currentdate = Convert.ToDateTime(executionDate);
                //}

                if (day == "yesterday")
                {
                    currentdate = currentdate.AddDays(-1);
                }

                if (resultTimestamp.Date.ToShortDateString() == currentdate.Date.ToShortDateString())
                {
                    ReporterFactory.TestReport.Pass("R450 Type 2 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> FOUND in the <mark>facts.readings</mark> table");
                }
                else
                {
                    if (altday.ToUpper() == "YES")
                    {
                        currentdate = currentdate.AddDays(-1);
                        if (result.Rows.Count != 0 && resultTimestamp.Date.ToShortDateString() == currentdate.Date.ToShortDateString())
                        {
                            ReporterFactory.TestReport.Pass("R450 Type 2 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> FOUND in the <mark>facts.readings</mark> table");
                        }
                        else
                        {
                            ReporterFactory.LogFailure("R450 Type 2 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> NOT FOUND in the <mark>facts.readings</mark> table");
                        }
                    }
                    else
                    {
                        ReporterFactory.LogFailure("R450 Type 2 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> NOT FOUND in the <mark>facts.readings</mark> table");
                    }

                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred while validating R450 Type 2 readings Data, Error:" + ex.ToString());
            }
        }

        /// <summary>
        /// To validate the R450 Type 5 data in the database
        /// </summary>
        /// <param name="result"></param>
        /// <param name="day"></param>
        public void ValidateR450Type5Data(DataTable result, string day, Dictionary<string, string> testData, string altday = "")
        {
            try
            {

                //string executionDate = testData["ExecutionDate"];

                DateTime resultTimestamp = new DateTime();
                if (result.Rows.Count > 0)
                {
                    resultTimestamp = Convert.ToDateTime(result.Rows[0]["readingdatetime"].ToString());//readingdatetime//radiotimestamp
                }
                DateTime currentdate = DateTime.Now;
                //if (executionDate != "")
                //{
                //    currentdate = Convert.ToDateTime(executionDate);
                //}

                if (day == "yesterday")
                {
                    currentdate = currentdate.AddDays(-1);
                }

                if (resultTimestamp.Date.ToShortDateString() == currentdate.Date.ToShortDateString())
                {
                    ReporterFactory.TestReport.Pass("R450 Type 5 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> FOUND in the <mark>facts.readings</mark> table");
                }
                else
                {
                    if (altday.ToUpper() == "YES")
                    {
                        currentdate = currentdate.AddDays(-1);
                        if (result.Rows.Count != 0 && resultTimestamp.Date.ToShortDateString() == currentdate.Date.ToShortDateString())
                        {
                            ReporterFactory.TestReport.Pass("R450 Type 5 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> FOUND in the <mark>facts.readings</mark> table");
                        }
                        else
                        {
                            ReporterFactory.LogFailure("R450 Type 5 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> NOT FOUND in the <mark>facts.readings</mark> table");
                        }
                    }
                    else
                    {
                        ReporterFactory.LogFailure("R450 Type 5 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> NOT FOUND in the <mark>facts.readings</mark> table");
                    }

                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred while validating R450 Type 5 readings Data, Error:" + ex.ToString());
            }
        }

        /// <summary>
        /// To validate the R450 Type 6 data in the database
        /// </summary>
        /// <param name="result"></param>
        /// <param name="day"></param>
        public void ValidateR450Type6Data(DataTable result, string day, Dictionary<string, string> testData, string altday = "")
        {
            try
            {
                //string executionDate = testData["ExecutionDate"];

                DateTime resultTimestamp = new DateTime();
                if (result.Rows.Count > 0)
                {
                    resultTimestamp = Convert.ToDateTime(result.Rows[0]["radiotimestamp"]);
                }

                DateTime currentdate = DateTime.Now;
                //if (executionDate != "")
                //{
                //    currentdate = Convert.ToDateTime(executionDate);
                //}

                if (day == "yesterday")
                {
                    currentdate = currentdate.AddDays(-1);
                }

                if (resultTimestamp.Date.ToShortDateString() == currentdate.Date.ToShortDateString())
                {
                    ReporterFactory.TestReport.Pass("R450 Type 6 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> FOUND in the <mark>facts.readings</mark> table");
                }
                else
                {
                    if (altday.ToUpper() == "YES")
                    {
                        currentdate = currentdate.AddDays(-1);
                        if (result.Rows.Count != 0 && resultTimestamp.Date.ToShortDateString() == currentdate.Date.ToShortDateString())
                        {
                            ReporterFactory.TestReport.Pass("R450 Type 6 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> FOUND in the <mark>facts.readings</mark> table");
                        }
                        else
                        {
                            ReporterFactory.LogFailure("R450 Type 6 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> NOT FOUND in the <mark>facts.readings</mark> table");
                        }
                    }
                    else
                    {
                        ReporterFactory.LogFailure("R450 Type 6 record for date: <mark>" + currentdate.Date.ToShortDateString() + "</mark> NOT FOUND in the <mark>facts.readings</mark> table");
                    }

                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred while validating R450 Type 6 readings Data, Error:" + ex.ToString());
            }
        }

    }
}
