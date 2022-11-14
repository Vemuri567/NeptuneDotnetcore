using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;

namespace Neptune360UIAutomation
{
    public class R450Consumption : TestBaseTemplate
    {
        // <summary>
        /// Scenario 1 - Processing Type 3 with NO Type 5/6 packet from the prior day (yesterday)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_001_Process_Type_3_with_NO_Type_5_or_6_packet_from_yesterday()
        {

            testCaseId = "TC-R450-001";
            //qTestUniqueId = "53774863";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);

            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);

            }
        }

        // <summary>
        /// Scenario 2 - Processing Type 3 with Type 5/6 packet from the prior day (yesterday) & there has been a Type 1/2 for yesterday
        /// pkt 3(t) with pkt 5(y) & 1(y)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_002_Process_Type_3_with_Type_5_packet_from_yesterday_and_there_has_been_Type_1_for_yesterday()
        {

            testCaseId = "TC-R450-002";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type1query = testData["Type1ReadingsTableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type1query = type1query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);
                
                //pkt 3(t) with pkt 5(y) & 1(y)
                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "yesterday", testData);

                ReporterFactory.LogInfo(type1query);
                DataTable pkt1result = driver.ExecutePostgreSQL(type1query);
                r450consumption.ValidateR450Type1Data(pkt1result, "yesterday", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 2 - Processing Type 3 with Type 5/6 packet from the prior day (yesterday) & there has been a Type 1/2 for yesterday
        /// pkt 3(t) with pkt 5(y) & 2(y)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_003_Process_Type_3_with_Type_5_packet_from_yesterday_and_there_has_been_Type_2_for_yesterday()
        {

            testCaseId = "TC-R450-003";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type2query = testData["Type2ReadingsTableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type2query = type2query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 3(t) with pkt 5(y) & 2(y)
                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "yesterday", testData);

                ReporterFactory.LogInfo(type2query);
                DataTable pkt2result = driver.ExecutePostgreSQL(type2query);
                r450consumption.ValidateR450Type2Data(pkt2result, "yesterday", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        // <summary>
        /// Scenario 2 - Processing Type 3 with Type 5/6 packet from the prior day (yesterday) & there has been a Type 1/2 for yesterday
        /// pkt 3(t) with pkt 6(y) & 1(y)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_004_Process_Type_3_with_Type_6_packet_from_yesterday_and_there_has_been_Type_1_for_yesterday()
        {

            testCaseId = "TC-R450-004";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type1query = testData["Type1ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type1query = type1query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 3(t) with pkt 6(y) & 1(y)
                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "yesterday", testData);

                ReporterFactory.LogInfo(type1query);
                DataTable pkt1result = driver.ExecutePostgreSQL(type1query);
                r450consumption.ValidateR450Type1Data(pkt1result, "yesterday", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 2 - Processing Type 3 with Type 5/6 packet from the prior day (yesterday) & there has been a Type 1/2 for yesterday
        /// pkt 3(t) with pkt 6(y) & 2(y)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_005_Process_Type_3_with_Type_6_packet_from_yesterday_and_there_has_been_Type_2_for_yesterday()
        {

            testCaseId = "TC-R450-005";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type2query = testData["Type2ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type2query = type2query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 3(t) with pkt 6(y) & 2(y)
                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "yesterday", testData);

                ReporterFactory.LogInfo(type2query);
                DataTable pkt2result = driver.ExecutePostgreSQL(type2query);
                r450consumption.ValidateR450Type2Data(pkt2result, "yesterday", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        // <summary>
        /// Scenario 3 - Processing Type 3 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday, & there has been a Type 1/2 for Today
        /// pkt 3(t) with pkt 5(y) & 1(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_006_Process_Type_3_with_Type_5_packet_from_yesterday_NO_Type1_for_yesterday_and_there_has_been_Type1_for_Today()
        {

            testCaseId = "TC-R450-006";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type1query = testData["Type1ReadingsTableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type1query = type1query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 3(t) with pkt 5(y) & 1(t)
                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "yesterday", testData);

                ReporterFactory.LogInfo(type1query);
                DataTable pkt1result = driver.ExecutePostgreSQL(type1query);
                r450consumption.ValidateR450Type1Data(pkt1result, "", testData, "YES"); //today

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData);


                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        // <summary>
        /// Scenario 3 - Processing Type 3 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday, & there has been a Type 1/2 for Today
        /// pkt 3(t) with pkt 5(y) & 2(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_007_Process_Type_3_with_Type_5_packet_from_yesterday_NO_Type1_for_yesterday_and_there_has_been_Type2_for_Today()
        {

            testCaseId = "TC-R450-007";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type2query = testData["Type2ReadingsTableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type2query = type2query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 3(t) with pkt 5(y) & 2(t)
                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "yesterday", testData);

                ReporterFactory.LogInfo(type2query);
                DataTable pkt2result = driver.ExecutePostgreSQL(type2query);
                r450consumption.ValidateR450Type2Data(pkt2result, "", testData, "YES"); //today

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        // <summary>
        /// Scenario 3 - Processing Type 3 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday, & there has been a Type 1/2 for Today
        /// pkt 3(t) with pkt 6(y) & 1(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_008_Process_Type_3_with_Type_6_packet_from_yesterday_NO_Type1_for_yesterday_and_there_has_been_Type1_for_Today()
        {

            testCaseId = "TC-R450-008";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type1query = testData["Type1ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type1query = type1query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 3(t) with pkt 6(y) & 1(t)
                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "yesterday", testData);

                ReporterFactory.LogInfo(type1query);
                DataTable pkt1result = driver.ExecutePostgreSQL(type1query);
                r450consumption.ValidateR450Type1Data(pkt1result, "", testData, "YES");

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 3 - Processing Type 3 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday, & there has been a Type 1/2 for Today
        /// pkt 3(t) with pkt 6(y) & 2(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_009_Process_Type_3_with_Type_6_packet_from_yesterday_NO_Type1_for_yesterday_and_there_has_been_Type2_for_Today()
        {

            testCaseId = "TC-R450-009";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type2query = testData["Type2ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type2query = type2query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 3(t) with pkt 6(y) & 2(t)
                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "yesterday", testData);

                ReporterFactory.LogInfo(type2query);
                DataTable pkt2result = driver.ExecutePostgreSQL(type2query);
                r450consumption.ValidateR450Type2Data(pkt2result, "", testData, "YES");

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 4 - Processing Type 3 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday or Today, & there is a 5/6 for today
        /// pkt 3(t) with pkt 5(y) & 5(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_010_Process_Type_3_with_Type_5_packet_from_yesterday_NO_Type_1_for_yesterday_or_Today_and_there_is_a_Type5_for_today()
        {

            testCaseId = "TC-R450-010";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 3(t) with pkt 5(y) & 5(t)
                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                //r450consumption.ValidateR450Type5Data(pkt5result, "yesterday");

                r450consumption.ValidateR450Type5Data(pkt5result, "", testData, "YES");//today -edited

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData, "yesterday");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 4 - Processing Type 3 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday or Today, & there is a 5/6 for today
        /// pkt 3(t) with pkt 6(y) & 5(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_011_Process_Type_3_with_Type_6_packet_from_yesterday_NO_Type_1_for_yesterday_or_Today_and_there_is_a_Type5_for_today()
        {

            testCaseId = "TC-R450-011";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];

                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 3(t) with pkt 6(y) & 5(t)
                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(type6query);
                //DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                //r450consumption.ValidateR450Type6Data(pkt6result,"yesterday", testData);

                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "", testData);//today

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData, "yesterday");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 4 - Processing Type 3 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday or Today, & there is a 5/6 for today
        /// pkt 3(t) with pkt 5(y) & 6(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_012_Process_Type_3_with_Type_5_packet_from_yesterday_NO_Type_1_for_yesterday_or_Today_and_there_is_a_Type6_for_today()
        {

            testCaseId = "TC-R450-012";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];

                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 3(t) with pkt 5(y) & 6(t)
                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);
                
                ReporterFactory.LogInfo(type5query);
                //DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                //r450consumption.ValidateR450Type5Data(pkt5result, "yesterday");

                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData, "yesterday");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 4 - Processing Type 3 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday or Today, & there is a 5/6 for today
        /// pkt 3(t) with pkt 6(y) & 6(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_013_Process_Type_3_with_Type_6_packet_from_yesterday_NO_Type_1_for_yesterday_or_Today_and_there_is_a_Type6_for_today()
        {

            testCaseId = "TC-R450-013";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];

                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 3(t) with pkt 6(y) & 6(t)
                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                //r450consumption.ValidateR450Type6Data(pkt6result, "yesterday");

                r450consumption.ValidateR450Type6Data(pkt6result, "", testData, "YES"); //-edited

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData, "yesterday");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        // <summary>
        /// Scenario 5 - Processing Type 3 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday or Today & there is NO 5/6 for today
        /// pkt 3(t) with pkt 5(y)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_014_Process_Type_3_with_Type_5_packet_from_yesterday_NO_Type_1or2_for_yesterday_or_Today_and_there_is_NO_5or6_for_today()
        {

            testCaseId = "TC-R450-014";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];

                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 3(t) with pkt 5(y)
                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "yesterday", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData);


                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        // <summary>
        /// Scenario 5 - Processing Type 3 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday or Today & there is NO 5/6 for today
        /// pkt 3(t) with pkt 6(y)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_015_Process_Type_3_with_Type_6_packet_from_yesterday_NO_Type_1or2_for_yesterday_or_Today_and_there_is_NO_5or6_for_today()
        {

            testCaseId = "TC-R450-015";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];

                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 3(t) with pkt 6(y) 
                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "yesterday", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        // <summary>
        /// Scenario 6 - Processing Type 1/2 the system Calculate Consumption
        /// pkt 1(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_016_Process_Type_1_the_system_Calculate_Consumption()
        {

            testCaseId = "TC-R450-016";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type1query = testData["Type1ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type1query = type1query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 1(t)
                ReporterFactory.LogInfo(type3query);
                DataTable pkt1result = driver.ExecutePostgreSQL(type1query);
                r450consumption.ValidateR450Type1Data(pkt1result,"", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 6 - Processing Type 1/2 the system Calculate Consumption
        /// pkt 2(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_017_Process_Type_2_the_system_Calculate_Consumption()
        {

            testCaseId = "TC-R450-017";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type2query = testData["Type2ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type2query = type2query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 2(t)
                ReporterFactory.LogInfo(type2query);
                DataTable pkt2result = driver.ExecutePostgreSQL(type2query);
                r450consumption.ValidateR450Type2Data(pkt2result, "", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 7 -  Processing Type 5/6 with NO Type 5/6 packet from the prior day (yesterday)
        /// pkt 5(t) 
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_018_Process_Type_5_with_NO_Type_5or6_packet_from_yesterday()
        {

            testCaseId = "TC-R450-018";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type5query = testData["Type5ReadingsTableQuery"];

                consumptionQuery = testData["ConsumptionTableQuery"];

                type5query = type5query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 5(t)
                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "", testData, "YES");

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData,"","yes");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 7 -  Processing Type 5/6 with NO Type 5/6 packet from the prior day (yesterday)
        /// pkt 6(t) 
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_019_Process_Type_6_with_NO_Type_5or6_packet_from_yesterday()
        {

            testCaseId = "TC-R450-019";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type6query = testData["Type6ReadingsTableQuery"];

                consumptionQuery = testData["ConsumptionTableQuery"];

                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 6(t)
                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "", testData, "YES");

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData,"","yes");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        // <summary>
        /// Scenario 8 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) & there has been Type 1/2 for yesterday
        /// pkt 5(t) with pkt 5(y) & 1(y) 
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_020_Process_Type_5_with_Type_5_packet_from_yesterday_and_there_has_been_Type_1_for_yesterday()
        {

            testCaseId = "TC-R450-020";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type1query = testData["Type1ReadingsTableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type1query = type1query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 5(t) with pkt 5(y) & 1(y)            
                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "", testData);

                //r450consumption.ValidateR450Type5Data(pkt5result, "yesterday");

                ReporterFactory.LogInfo(type1query);
                DataTable pkt1result = driver.ExecutePostgreSQL(type1query);
                r450consumption.ValidateR450Type1Data(pkt1result, "yesterday", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        // <summary>
        /// Scenario 8 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) & there has been Type 1/2 for yesterday
        /// pkt 5(t) with pkt 5(y) & 2(y) 
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_021_Process_Type_5_with_Type_5_packet_from_yesterday_and_there_has_been_Type_2_for_yesterday()
        {

            testCaseId = "TC-R450-021";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type2query = testData["Type2ReadingsTableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type2query = type2query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 5(t) with pkt 5(y) & 2(y)
                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "", testData);

                //r450consumption.ValidateR450Type5Data(pkt5result, "yesterday");

                ReporterFactory.LogInfo(type2query);
                DataTable pkt2result = driver.ExecutePostgreSQL(type2query);
                r450consumption.ValidateR450Type2Data(pkt2result, "yesterday", testData); 


                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 8 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) & there has been Type 1/2 for yesterday
        /// pkt 5(t) with pkt 6(y) & 1(y)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_022_Process_Type_5_with_Type_6_packet_from_yesterday_and_there_has_been_Type_1_for_yesterday()
        {

            testCaseId = "TC-R450-022";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type1query = testData["Type1ReadingsTableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type1query = type1query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 5(t) with pkt 6(y) & 1(y)            
                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "", testData);

                ReporterFactory.LogInfo(type6query);
                //DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                //r450consumption.ValidateR450Type6Data(pkt6result, "yesterday", testData);

                ReporterFactory.LogInfo(type1query);
                DataTable pkt1result = driver.ExecutePostgreSQL(type1query);
                r450consumption.ValidateR450Type1Data(pkt1result, "yesterday", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        // <summary>
        /// Scenario 8 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) & there has been Type 1/2 for yesterday
        /// pkt 5(t) with pkt 6(y) & 2(y)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_023_Process_Type_5_with_Type_6_packet_from_yesterday_and_there_has_been_Type_2_for_yesterday()
        {

            testCaseId = "TC-R450-023";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type2query = testData["Type2ReadingsTableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type2query = type2query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 5(t) with pkt 6(y) & 2(y)            
                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "", testData);

                ReporterFactory.LogInfo(type6query);
                //DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                //r450consumption.ValidateR450Type6Data(pkt6result, "yesterday", testData);

                ReporterFactory.LogInfo(type2query);
                DataTable pkt2result = driver.ExecutePostgreSQL(type2query);
                r450consumption.ValidateR450Type2Data(pkt2result, "yesterday", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 8 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) & there has been Type 1/2 for yesterday
        /// pkt 6(t) with pkt 5(y) & 1(y)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_024_Process_Type_6_with_Type_5_packet_from_yesterday_and_there_has_been_Type_1_for_yesterday()
        {

            testCaseId = "TC-R450-024";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type1query = testData["Type1ReadingsTableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type1query = type1query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 6(t) with pkt 5(y) & 1(y)          
                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "", testData);

                ReporterFactory.LogInfo(type5query);
                //DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                //r450consumption.ValidateR450Type5Data(pkt5result, "yesterday", testData);

                ReporterFactory.LogInfo(type1query);
                DataTable pkt1result = driver.ExecutePostgreSQL(type1query);
                r450consumption.ValidateR450Type1Data(pkt1result, "yesterday", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        /// Scenario 8 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) & there has been Type 1/2 for yesterday
        /// pkt 6(t) with pkt 5(y) & 2(y)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_025_Process_Type_6_with_Type_5_packet_from_yesterday_and_there_has_been_Type_2_for_yesterday()
        {

            testCaseId = "TC-R450-025";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type2query = testData["Type2ReadingsTableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type2query = type2query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 6(t) with pkt 5(y) & 2(y)            
                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "", testData);
                
                ReporterFactory.LogInfo(type5query);
                //DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                //r450consumption.ValidateR450Type5Data(pkt5result, "yesterday", testData);

                ReporterFactory.LogInfo(type2query);
                DataTable pkt2result = driver.ExecutePostgreSQL(type2query);
                r450consumption.ValidateR450Type2Data(pkt2result, "yesterday", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 8 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) & there has been Type 1/2 for yesterday
        /// pkt 6(t) with pkt 6(y) & 1(y)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_026_Process_Type_6_with_Type_6_packet_from_yesterday_and_there_has_been_Type_1_for_yesterday()
        {

            testCaseId = "TC-R450-026";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type1query = testData["Type1ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type1query = type1query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //ppkt 6(t) with pkt 6(y) & 1(y)         
                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "", testData);

                //r450consumption.ValidateR450Type6Data(pkt6result, "yesterday");

                ReporterFactory.LogInfo(type1query);
                DataTable pkt1result = driver.ExecutePostgreSQL(type1query);
                r450consumption.ValidateR450Type1Data(pkt1result, "yesterday", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 8 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) & there has been Type 1/2 for yesterday
        /// pkt 6(t) with pkt 6(y) & 2(y)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_027_Process_Type_6_with_Type_6_packet_from_yesterday_and_there_has_been_Type_2_for_yesterday()
        {

            testCaseId = "TC-R450-027";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type2query = testData["Type2ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type2query = type2query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //ppkt 6(t) with pkt 6(y) & 2(y)         
                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "", testData);

                //r450consumption.ValidateR450Type6Data(pkt6result, "yesterday");

                ReporterFactory.LogInfo(type2query);
                DataTable pkt2result = driver.ExecutePostgreSQL(type2query);
                r450consumption.ValidateR450Type1Data(pkt2result, "yesterday", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        // <summary>
        /// Scenario 9 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) & there has been Type 1/2 for yesterday
        /// pkt 5(t) with pkt 5(y) & 1(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_028_Process_Type_5_with_Type_5_packet_from_yesterday_NO_Type_1or2_for_yesterday_and_there_has_been_Type_1_for_Today()
        {

            testCaseId = "TC-R450-028";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type1query = testData["Type1ReadingsTableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type1query = type1query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 5(t) with pkt 5(y) & 1(t)            
                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "", testData);

                //r450consumption.ValidateR450Type5Data(pkt5result, "yesterday");

                ReporterFactory.LogInfo(type1query);
                DataTable pkt1result = driver.ExecutePostgreSQL(type1query);
                r450consumption.ValidateR450Type1Data(pkt1result, "", testData,"YES");

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData,"yes");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 9 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) & there has been Type 1/2 for yesterday
        /// pkt 5(t) with pkt 5(y) & 2(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_029_Process_Type_5_with_Type_5_packet_from_yesterday_NO_Type_1or2_for_yesterday_and_there_has_been_Type_2_for_Today()
        {

            testCaseId = "TC-R450-029";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type2query = testData["Type2ReadingsTableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type2query = type2query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 5(t) with pkt 5(y) & 2(y)
                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "", testData);

                //r450consumption.ValidateR450Type5Data(pkt5result, "yesterday");

                ReporterFactory.LogInfo(type2query);
                DataTable pkt2result = driver.ExecutePostgreSQL(type2query);
                r450consumption.ValidateR450Type2Data(pkt2result, "", testData, "YES");

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData,"yes");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 9 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) & there has been Type 1/2 for yesterday
        /// pkt 5(t) with pkt 6(y) & 1(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_030_Process_Type_5_with_Type_6_packet_from_yesterday_NO_Type_1or2_for_yesterday_and_there_has_been_Type_1_for_Today()
        {

            testCaseId = "TC-R450-030";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type1query = testData["Type1ReadingsTableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type1query = type1query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 5(t) with pkt 6(y) & 1(t)            
                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "", testData);

                ReporterFactory.LogInfo(type6query);
                //DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                //r450consumption.ValidateR450Type6Data(pkt6result, "yesterday", testData);

                ReporterFactory.LogInfo(type1query);
                DataTable pkt1result = driver.ExecutePostgreSQL(type1query);
                r450consumption.ValidateR450Type1Data(pkt1result, "", testData, "YES");

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData,"yes");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        // <summary>
        /// Scenario 9 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) & there has been Type 1/2 for yesterday
        /// pkt 5(t) with pkt 6(y) & 2(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_031_Process_Type_5_with_Type_6_packet_from_yesterday_NO_Type_1or2_for_yesterday_and_there_has_been_Type_2_for_Today()
        {

            testCaseId = "TC-R450-031";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type2query = testData["Type2ReadingsTableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type2query = type2query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 5(t) with pkt 6(y) & 2(t)            
                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "", testData);

                ReporterFactory.LogInfo(type6query);
                //DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                //r450consumption.ValidateR450Type6Data(pkt6result, "yesterday",testData);

                ReporterFactory.LogInfo(type2query);
                DataTable pkt2result = driver.ExecutePostgreSQL(type2query);
                r450consumption.ValidateR450Type2Data(pkt2result, "", testData, "YES");

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData, "yes");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 9 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) & there has been Type 1/2 for yesterday
        /// pkt 6(t) with pkt 5(y) & 1(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_032_Process_Type_6_with_Type_5_packet_from_yesterday_NO_Type_1or2_for_yesterday_and_there_has_been_Type_1_for_Today()
        {

            testCaseId = "TC-R450-032";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type1query = testData["Type1ReadingsTableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type1query = type1query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 6(t) with pkt 5(y) & 1(t)          
                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "", testData);

                ReporterFactory.LogInfo(type5query);
                //DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                //r450consumption.ValidateR450Type5Data(pkt5result, "yesterday",testData);

                ReporterFactory.LogInfo(type1query);
                DataTable pkt1result = driver.ExecutePostgreSQL(type1query);
                r450consumption.ValidateR450Type1Data(pkt1result, "", testData, "YES");

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData, "yes");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 9 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) & there has been Type 1/2 for yesterday
        /// pkt 6(t) with pkt 5(y) & 2(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_033_Process_Type_6_with_Type_5_packet_from_yesterday_NO_Type_1or2_for_yesterday_and_there_has_been_Type_2_for_Today()
        {

            testCaseId = "TC-R450-033";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type2query = testData["Type2ReadingsTableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type2query = type2query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 6(t) with pkt 5(y) & 2(t)            
                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "", testData);

                ReporterFactory.LogInfo(type5query);
                //DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                //r450consumption.ValidateR450Type5Data(pkt5result, "yesterday", testData);

                ReporterFactory.LogInfo(type2query);
                DataTable pkt2result = driver.ExecutePostgreSQL(type2query);
                r450consumption.ValidateR450Type2Data(pkt2result, "", testData, "YES");

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData,"yes");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 9 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) & there has been Type 1/2 for yesterday
        /// pkt 6(t) with pkt 6(y) & 1(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_034_Process_Type_6_with_Type_6_packet_from_yesterday_NO_Type_1or2_for_yesterday_and_there_has_been_Type_1_for_Today()
        {

            testCaseId = "TC-R450-034";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type1query = testData["Type1ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type1query = type1query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //ppkt 6(t) with pkt 6(y) & 1(t)         
                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "", testData);

                //r450consumption.ValidateR450Type6Data(pkt6result, "yesterday");

                ReporterFactory.LogInfo(type1query);
                DataTable pkt1result = driver.ExecutePostgreSQL(type1query);
                r450consumption.ValidateR450Type1Data(pkt1result, "", testData, "YES");

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData,"yes");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        // <summary>
        /// Scenario 9 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) & there has been Type 1/2 for yesterday
        /// pkt 6(t) with pkt 6(y) & 2(t)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_035_Process_Type_6_with_Type_6_packet_from_yesterday_NO_Type_1or2_for_yesterday_and_there_has_been_Type_2_for_Today()
        {

            testCaseId = "TC-R450-035";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type2query = testData["Type2ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type2query = type2query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //ppkt 6(t) with pkt 6(y) & 2(t)         
                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "", testData);

                //r450consumption.ValidateR450Type6Data(pkt6result, "yesterday");

                ReporterFactory.LogInfo(type2query);
                DataTable pkt2result = driver.ExecutePostgreSQL(type2query);
                r450consumption.ValidateR450Type1Data(pkt2result, "", testData, "YES");

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData,"yes");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }


        // <summary>
        /// Scenario 10 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday or Today, & there is a Type 3 packet for today
        /// pkt 5(t) with pkt 5(y) & 3(t)	
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_036_Process_Type_5_with_Type_5_packet_from_yesterday_NO_Type_1or2_for_yesterday_or_Today_and_there_is_a_Type_3_packet_for_today()
        {

            testCaseId = "TC-R450-036";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 5(t) with pkt 5(y) & 3(t)	
                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "", testData);

                //r450consumption.ValidateR450Type5Data(pkt5result, "yesterday");

                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData, "yesterday");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 10 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday or Today, & there is a Type 3 packet for today
        /// pkt 6(t) with pkt 5(y) & 3(t)	
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_037_Process_Type_6_with_Type_5_packet_from_yesterday_NO_Type_1or2_for_yesterday_or_Today_and_there_is_a_Type_3_packet_for_today()
        {

            testCaseId = "TC-R450-037";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];

                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 6(t) with pkt 5(y) & 3(t)
                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "", testData);

                ReporterFactory.LogInfo(type5query);
                //DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                //r450consumption.ValidateR450Type5Data(pkt5result, "yesterday", testData);

                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData, "yesterday");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 10 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday or Today, & there is a Type 3 packet for today
        /// pkt 5(t) with pkt 6(y) & 3(t)	
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_038_Process_Type_5_with_Type_6_packet_from_yesterday_NO_Type_1or2_for_yesterday_or_Today_and_there_is_a_Type_3_packet_for_today()
        {

            testCaseId = "TC-R450-038";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type5query = testData["Type5ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];

                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type5query = type5query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 5(t) with pkt 6(y) & 3(t)
                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "", testData);

                ReporterFactory.LogInfo(type6query);
                //DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                //r450consumption.ValidateR450Type6Data(pkt6result, "yesterday", testData);

                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData, "yesterday");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 10 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday or Today, & there is a Type 3 packet for today
        /// pkt 6(t) with pkt 6(y) & 3(t)	
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_039_Process_Type_6_with_Type_6_packet_from_yesterday_NO_Type_1or2_for_yesterday_or_Today_and_there_is_a_Type_3_packet_for_today()
        {

            testCaseId = "TC-R450-039";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type3query = testData["Type3TableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];

                consumptionQuery = testData["ConsumptionTableQuery"];

                type3query = type3query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 6(t) with pkt 6(y) & 3(t)
                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "", testData);

                //r450consumption.ValidateR450Type6Data(pkt6result, "yesterday");

                ReporterFactory.LogInfo(type3query);
                DataTable pkt3result = driver.ExecutePostgreSQL(type3query);
                r450consumption.ValidateR450Type3Data(pkt3result, testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionFound(consumptionResult, testData, "yesterday");

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 11 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday or Today & there is NO Type 3 for today
        /// pkt 5(t) with pkt 5(y)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_040_Process_Type_5_with_Type_5_packet_from_yesterday_NO_Type_1or2_for_yesterday_or_Today_and_there_is_NO_Type_3_for_today()
        {

            testCaseId = "TC-R450-040";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type5query = testData["Type5ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type5query = type5query.Replace("@miuid", miuId);
                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 5(t) with pkt 5(y)            
                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "", testData);

                //r450consumption.ValidateR450Type5Data(pkt5result, "yesterday");

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 11 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday or Today & there is NO Type 3 for today
        /// pkt 5(t) with pkt 6(y)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_041_Process_Type_5_with_Type_6_packet_from_yesterday_NO_Type_1or2_for_yesterday_or_Today_and_there_is_NO_Type_3_for_today()
        {

            testCaseId = "TC-R450-041";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type5query = testData["Type5ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type5query = type5query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 5(t) with pkt 6(y)          
                ReporterFactory.LogInfo(type5query);
                DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                r450consumption.ValidateR450Type5Data(pkt5result, "", testData);

                ReporterFactory.LogInfo(type6query);
                //DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                //r450consumption.ValidateR450Type6Data(pkt6result, "yesterday", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 11 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday or Today & there is NO Type 3 for today
        /// pkt 6(t) with pkt 5(y)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_042_Process_Type_6_with_Type_5_packet_from_yesterday_NO_Type_1or2_for_yesterday_or_Today_and_there_is_NO_Type_3_for_today()
        {

            testCaseId = "TC-R450-042";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type5query = testData["Type5ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type5query = type5query.Replace("@miuid", miuId);
                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 6(t) with pkt 5(y)          
                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "", testData);

                ReporterFactory.LogInfo(type5query);
                //DataTable pkt5result = driver.ExecutePostgreSQL(type5query);
                //r450consumption.ValidateR450Type5Data(pkt5result, "yesterday", testData);

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }

        // <summary>
        /// Scenario 11 -  Processing Type 5/6 with Type 5/6 packet from the prior day (yesterday) , NO Type 1/2 for yesterday or Today & there is NO Type 3 for today
        /// pkt 6(t) with pkt 6(y)
        [Category("R450Consumption")]
        [Test]
        public void TC_R450_043_Process_Type_6_with_Type_6_packet_from_yesterday_NO_Type_1or2_for_yesterday_or_Today_and_there_is_NO_Type_3_for_today()
        {

            testCaseId = "TC-R450-043";
            //qTestUniqueId = "";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(@"TestData\R450TestData.xlsx", "TestData", testCaseId);
                miuId = testData["miuid"];
                type5query = testData["Type5ReadingsTableQuery"];
                type6query = testData["Type6ReadingsTableQuery"];
                consumptionQuery = testData["ConsumptionTableQuery"];

                type6query = type6query.Replace("@miuid", miuId);

                consumptionQuery = consumptionQuery.Replace("@miuid", miuId);

                //pkt 6(t) with pkt 6(y)          
                ReporterFactory.LogInfo(type6query);
                DataTable pkt6result = driver.ExecutePostgreSQL(type6query);
                r450consumption.ValidateR450Type6Data(pkt6result, "", testData);

                //r450consumption.ValidateR450Type6Data(pkt6result, "yesterday");

                ReporterFactory.LogInfo(consumptionQuery);
                DataTable consumptionResult = driver.ExecutePostgreSQL(consumptionQuery);
                r450consumption.ValidateR450ConsumptionNotFound(consumptionResult, testData);

                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error occurred: " + ex.ToString());
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
        }
    }
}
