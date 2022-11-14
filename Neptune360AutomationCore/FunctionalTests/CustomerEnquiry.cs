using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;

namespace Neptune360UIAutomation
{
    public class CustomerEnquiry : TestBaseTemplate
    {


        /// <summary>
        /// Test Method to Search for an Account - Search by MU ID
        /// </summary>
        [Test]
        public void TC_TestingGraph()
        {
            testCaseId = "TC-3871";
            qTestUniqueId = "";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);

                customerInquiry.ValidateSearchAccountByMUIdConsumption(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Testing")]
        [Test]
        public void TC_Testing1()
        {
            testCaseId = "TC-3871";
            qTestUniqueId = "";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Testing")]
        [Test]
        public void TC_Testing2()
        {
            testCaseId = "TC-3871";
            qTestUniqueId = "";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        [Category("Testing")]
        [Test]
        public void TC_Testing3()
        {
            testCaseId = "TC-3871";
            qTestUniqueId = "";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for an Account - Search by MU ID
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3871_Search_for_an_Account_Search_by_MU_ID()
        {
            testCaseId = "TC-3871";
            qTestUniqueId = "19318974";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSearchAccountByMUId(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for an Account - Search by multiple criteria
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3872_Search_for_an_Account_Search_by_multiple_criteria()
        {
            testCaseId = "TC-3872";
            qTestUniqueId = "19318975";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSearchAccountByMultipleCriteria(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Search for an Account - Messaging - No Results Found
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3873_Search_for_an_Account_Messaging_No_Results_Found()
        {
            testCaseId = "TC-3873";
            qTestUniqueId = "19318976";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSearchAccountNoResultsFound(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for an Account - Partial search
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3875_Search_for_an_Account_Partial_search()
        {
            testCaseId = "TC-3875";
            qTestUniqueId = "19318978";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatePartialSearch(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        /// <summary>
        /// Test Method to Search for an Account - Selecting accounts from the search results
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3876_Search_for_an_Account_Selecting_accounts_from_the_search_results()
        {
            testCaseId = "TC-3876";
            qTestUniqueId = "19318979";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSelectingAccFromSearchResults(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for an Account - Searching with search field blank
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3877_Search_for_an_Account_Searching_with_search_field_blank()
        {
            testCaseId = "TC-3877";
            qTestUniqueId = "19318980";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSearchFieldBlank(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for an Account - Search for exact match
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3879_Search_for_an_Account_Search_for_exact_match()
        {
            testCaseId = "TC-3879";
            qTestUniqueId = "19318982";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateAccSearchExactMatch(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Meter ID
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3867_Customer_Inquiry_Account_Search_Search_By_Meter_ID()
        {
            testCaseId = "TC-3867";
            qTestUniqueId = "19318970";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateAccSearchByMeterId(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Account Number
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3868_Customer_Inquiry_Account_Search_Search_By_Account_Number()
        {
            testCaseId = "TC-3868";
            qTestUniqueId = "19318971";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateAccSearchByAccNo(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Customer Name
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3869_Customer_Inquiry_Account_Search_Search_By_Customer_Name()
        {
            testCaseId = "TC-3869";
            qTestUniqueId = "19318972";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateAccSearchByCustomerName(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Address
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3870_Customer_Inquiry_Account_Search_Search_By_Address()
        {
            testCaseId = "TC-3870";
            qTestUniqueId = "19318973";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                address = testData["Address"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateAccSearchByAddress(address);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Meter ID_No Results
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7800_Customer_Inquiry_Account_Search_Search_By_Meter_ID_No_Results()
        {
            testCaseId = "TC-7800";
            qTestUniqueId = "19318976";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateNoResultsFoundInvalidMID(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Account Number_No Results
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7801_Customer_Inquiry_Account_Search_Search_By_Account_Number_No_Results()
        {
            testCaseId = "TC-7801";
            qTestUniqueId = "19753077";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                accountNo = testData["AccountNumber"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateNoResultsFoundforInvalidAccNo(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Customer Name_No Results
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7802_Customer_Inquiry_Account_Search_Search_By_Customer_Name_No_Results()
        {
            testCaseId = "TC-7802";
            qTestUniqueId = "19753079";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateNoResultsFoundforCustName(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Address_No Results
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7803_Customer_Inquiry_Account_Search_Search_By_Address_No_Results()
        {
            testCaseId = "TC-7803";
            qTestUniqueId = "19753080";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateNoResultsFoundforInvalidAdd(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Meter ID_Blank
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7804_Customer_Inquiry_Account_Search_Search_By_Meter_ID_Blank()
        {
            testCaseId = "TC-7804";
            qTestUniqueId = "19754040";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSearchFieldBlank(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Customer Name_Blank
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7805_Customer_Inquiry_Account_Search_Search_By_Customer_Name_Blank()
        {
            testCaseId = "TC-7805";
            qTestUniqueId = "19754042";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSearchFieldBlankCustName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Address_Blank
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7806_Customer_Inquiry_Account_Search_Search_By_Address_Blank()
        {
            testCaseId = "TC-7806";
            qTestUniqueId = "19754044";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSearchFieldBlankAddress();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Account Number_Blank
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7807_Customer_Inquiry_Account_Search_Search_By_Account_Number_Blank()
        {
            testCaseId = "TC-7807";
            qTestUniqueId = "19754046";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSearchFieldBlankAccNo();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Meter ID_Partial Search
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7808_Customer_Inquiry_Account_Search_Search_By_Meter_ID_Partial_Search()
        {
            testCaseId = "TC-7808";
            qTestUniqueId = "19754311";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterIdPartialSearch(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Customer Name_Partial Search
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7809_Customer_Inquiry_Account_Search_Search_By_Customer_Name_Partial_Search()
        {
            testCaseId = "TC-7809";
            qTestUniqueId = "19754313";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateCustNamePartialSearch(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Address_Partial Search
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7810_Customer_Inquiry_Account_Search_Search_By_Address_Partial_Search()
        {
            testCaseId = "TC-7810";
            qTestUniqueId = "19754315";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                address = testData["Address"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateAddressPartialSearch(address);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Account Number_Partial Search
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7811_Customer_Inquiry_Account_Search_Search_By_Account_Number_Partial_Search()
        {
            testCaseId = "TC-7811";
            qTestUniqueId = "19754318";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateAccountPartialSearch(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Meter ID_Exact Match
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7812_Customer_Inquiry_Account_Search_Search_By_Meter_ID_Exact_Match()
        {
            testCaseId = "TC-7812";
            qTestUniqueId = "19754708";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateExactMeterIdSearch(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Customer Name_Exact Match
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7813_Customer_Inquiry_Account_Search_Search_By_Customer_Name_Exact_Match()
        {
            testCaseId = "TC-7813";
            qTestUniqueId = "19754711";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateExactCustNameSearch(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Address_Exact Match
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7814_Customer_Inquiry_Account_Search_Search_By_Address_Exact_Match()
        {
            testCaseId = "TC-7814";
            qTestUniqueId = "19754714";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                address = testData["Address"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateExactAddressSearch(address);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Account Number_Exact Match
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7815_Customer_Inquiry_Account_Search_Search_By_Account_Number_Exact_Match()
        {
            testCaseId = "TC-7815";
            qTestUniqueId = "19754718";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateExactAccountSearch(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Info_View_Customer Name
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7912_Customer_Inquiry_Account_Info_View_Customer_Name()
        {
            testCaseId = "TC-7912";
            qTestUniqueId = "20238380";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateCustomerName(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Info_View_Customer Address
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7913_Customer_Inquiry_Account_Info_View_Address()
        {
            testCaseId = "TC-7913";
            qTestUniqueId = "20238616";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateCustomerAddress(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry_Account Info_View_MeterId
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7914_Customer_Inquiry_Account_Info_View_MeterId()
        {
            testCaseId = "TC-7914";
            qTestUniqueId = "20238625";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateCustomerMeterID(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry_Account Info_View_Status
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7915_Customer_Inquiry_Account_Info_View_Status()
        {
            testCaseId = "TC-7915";
            qTestUniqueId = "20238635";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateCustomerStatus(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Info_View_Status
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7916_Customer_Inquiry_Account_Info_View_Status()
        {
            testCaseId = "TC-7916";
            qTestUniqueId = "20238659";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMIUId(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Info_View_MIU Install Date
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7917_Customer_Inquiry_Account_Info_View_MIU_Install_Date()
        {
            testCaseId = "TC-7917";
            qTestUniqueId = "20238694";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMIUInstallDate(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Info_View_Meter Size
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7919_Customer_Inquiry_Account_Info_View_Meter_Size()
        {
            testCaseId = "TC-7919";
            qTestUniqueId = "20238708";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSize(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Info_View_Latest Reading
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7920_Customer_Inquiry_Account_Info_View_Latest_Reading()
        {
            testCaseId = "TC-7920";
            qTestUniqueId = "20238720";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateLatestReading(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Info_View_Date&Time of Latest Reading
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7921_Customer_Inquiry_Account_Info_View_Date_Time_of_Latest_Reading()
        {
            testCaseId = "TC-7921";
            qTestUniqueId = "20238729";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateLatestReadingAndDate(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Info_View_Unit of Measure
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7922_Customer_Inquiry_Account_Info_View_Unit_of_Measure()
        {
            testCaseId = "TC-7922";
            qTestUniqueId = "20238738";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateUnitOfMeasure(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Info_View_List of Meters
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7948_Customer_Inquiry_Account_Info_View_List_of_Meters()
        {
            testCaseId = "TC-7948";
            qTestUniqueId = "20345829";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatMoreMeters(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Choose Account_Account Details
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7818_Customer_Inquiry_Account_Search_Choose_Account_Account_Details()
        {
            testCaseId = "TC-7818";
            qTestUniqueId = "19758169";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSearchAccountDetails(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Available
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8151_Customer_Inquiry_Meter_Information_Available()
        {
            testCaseId = "TC-8151";
            qTestUniqueId = "21681421";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterInfromation(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8152_Customer_Inquiry_Meter_Information_Edit()
        {
            testCaseId = "TC-8152";
            qTestUniqueId = "21681424";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterInfromationEdit(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Asset Configuration Dialog Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8153_Customer_Inquiry_Meter_Information_Edit_Asset_Configuration_Dialog_Display()
        {
            testCaseId = "TC-8153";
            qTestUniqueId = "21681427";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateAssetConfiguration(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit_Asset Configuration Dialog_MIU
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8154_Customer_Inquiry_Meter_Information_Edit_Asset_Configuration_Dialog_MIU()
        {
            testCaseId = "TC-8154";
            qTestUniqueId = "21681428";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMIUTab(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit_Asset Configuration Dialog_Meter
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8155_Customer_Inquiry_Meter_Information_Edit_Asset_Configuration_Dialog_Meter()
        {
            testCaseId = "TC-8155";
            qTestUniqueId = "21681429";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterTab(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit_Asset Configuration Dialog_Register
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8156_Customer_Inquiry_Meter_Information_Edit_Asset_Configuration_Dialog_Register()
        {
            testCaseId = "TC-8156";
            qTestUniqueId = "21681430";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateRegisterTab(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit_Asset Configuration Dialog_Meter_Contents
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8158_Customer_Inquiry_Meter_Information_Edit_Asset_Configuration_Dialog_Meter_Contents()
        {
            testCaseId = "TC-8158";
            qTestUniqueId = "21681432";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterContents(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit_Asset Configuration Dialog_Register_Contents
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8159_Customer_Inquiry_Meter_Information_Edit_Asset_Configuration_Dialog_Register_Contents()
        {
            testCaseId = "TC-8159";
            qTestUniqueId = "21681433";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateRegisterContents(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit_Asset Configuration Dialog_Cancel
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8161_Customer_Inquiry_Meter_Information_Edit_Asset_Configuration_Dialog_Cancel()
        {
            testCaseId = "TC-8161";
            qTestUniqueId = "21681435";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditCancel(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Asset Configuration Dialog_Edit MIU Information_MIU ID_Non Editable
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8162_Customer_Inquiry_Asset_Configuration_Dialog_Edit_MIU_Information_MIU_ID_Non_Editable()
        {
            testCaseId = "TC-8162";
            qTestUniqueId = "21681436";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMiuIdNonEditable(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Asset Configuration Dialog_Edit MIU Information_Editable Fields
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8163_Customer_Inquiry_Asset_Configuration_Dialog_Edit_MIU_Information_Editable_Fields()
        {
            testCaseId = "TC-8163";
            qTestUniqueId = "21682065";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMiuEditable(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Asset Configuration Dialog_Edit Register Information_Editable Fields
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8164_Customer_Inquiry_Asset_Configuration_Dialog_Edit_Register_Information_Editable_Fields()
        {
            testCaseId = "TC-8164";
            qTestUniqueId = "21682151";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateRegisterTabEditable(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Asset Configuration Dialog_Edit Meter Information_Meter With MIU_Editable Fields
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8165_Customer_Inquiry_Asset_Configuration_Dialog_Edit_Meter_Information_Meter_With_MIU_Editable_Fields()
        {
            testCaseId = "TC-8165";
            qTestUniqueId = "21682253";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                meterManufacturer = testData["MeterManufacturer"];
                meterInstallDate = testData["MeterInstallDate"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterInfoWithMIUEditableField(customerName, meterClass, meterSize, meterManufacturer, meterInstallDate);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Asset Configuration Dialog_Edit Meter Information_Meter Without MIU_Editable Fields
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8166_Customer_Inquiry_Asset_Configuration_Dialog_Edit_Meter_Information_Meter_Without_MIU_Editable_Fields()
        {
            testCaseId = "TC-8166";
            qTestUniqueId = "21682254";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                meterManufacturer = testData["MeterManufacturer"];
                meterInstallDate = testData["MeterInstallDate"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterInfoWithoutMIUEditableField(customerName, meterClass, meterSize, meterManufacturer, meterInstallDate);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Asset Configuration Dialog_Edit Meter Information_Meter Without MIU_Meter Number_Non Editable
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8167_Customer_Inquiry_Asset_Configuration_Dialog_Edit_Meter_Information_Meter_Without_MIU_Meter_Number_Non_Editable()
        {
            testCaseId = "TC-8167";
            qTestUniqueId = "21682256";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterNumNonEditable(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_MIU Status on Account
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8323_Customer_Inquiry_Meter_Information_MIU_Status_on_Account()
        {
            testCaseId = "TC-8323";
            qTestUniqueId = "22323802";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMIUStatusOnAccount(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_MIU Status on Account
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8324_Customer_Inquiry_Meter_Information_MIU_Status_on_Account()
        {
            testCaseId = "TC-8324";
            qTestUniqueId = "22323864";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterStatusOnAccount(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Meter Asset_HPT_5/8_Cubic Meter_Error Message
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        [Obsolete]
        public void TC_8465_Meter_Asset_HPT_5_8_Cubic_Meter_Error_Message()
        {
            testCaseId = "TC-8465";
            qTestUniqueId = "22690030";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorHPT_5_8_Meter(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Meter Asset_HPT_5/8_Cubic Feet_Error Message
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        [Obsolete]
        public void TC_8466_Meter_Asset_HPT_5_8_Cubic_Feet_Error_Message()
        {
            testCaseId = "TC-8466";
            qTestUniqueId = "22690031";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorHPT_5_8_Feet(miuId, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Meter Asset_HPT_5/8_Gallons_Error Message
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        [Obsolete]
        public void TC_8467_Meter_Asset_HPT_5_8_Gallons_Error_Message()
        {
            testCaseId = "TC-8467";
            qTestUniqueId = "22690032";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorHPT_5_8_Gallons(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Meter Asset_HPT_3/4_Cubic Meter_Error Message
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8468_Meter_Asset_HPT_3_4_Cubic_Meter_Error_Message()
        {
            testCaseId = "TC-8468";
            qTestUniqueId = "22690033";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorHPT_5_8_Gallons(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Meter Asset_HPT_3/4_Cubic Feet_Error Message
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8469_Meter_Asset_HPT_3_4_Cubic_Feet_Error_Message()
        {
            testCaseId = "TC-8469";
            qTestUniqueId = "22690034";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorHPT_3_4_CFT(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Meter Asset_HPT 3/4_Gallon_Error Message
       /* [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8470_Meter_Asset_HPT_3_4_Gallon_Error_Message()
        {
            testCaseId = "TC-8470";
            qTestUniqueId = "22690035";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorHPT_3_4_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
*/
        // <summary>
        /// Test Method to Meter Asset_HPT 1 Cubic Meter_Error Message
      /*  [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8471_Meter_Asset_HPT_1_CubicMeter_Error_Message()
        {
            testCaseId = "TC-8471";
            qTestUniqueId = "22690037";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorHPT_1_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_HPT 1 Cubic Feet_Error Message
      /*  [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8472_Meter_Asset_HPT_1_CubicFeet_Error_Message()
        {
            testCaseId = "TC-8472";
            qTestUniqueId = "22690038";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorHPT_1_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_HPT 1 Gallons_Error Message
       /* [Category("CustomerEnquiry-Obsolete")]
        [Test]
        [Obsolete]
        public void TC_8473_Meter_Asset_HPT_1_Gallons_Error_Message()
        {
            testCaseId = "TC-8473";
            qTestUniqueId = "22690040";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorHPT_1_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
*/
        // <summary>
        /// Test Method to Meter Asset_T-10_4_Cubic Meter_Error Message
       /* [Category("CustomerEnquiry-Obsolete")]
        [Test]
        [Obsolete]
        public void TC_8474_Meter_Asset_T10_4_Cubic_Meter_Error_Message()
        {
            testCaseId = "TC-8474";
            qTestUniqueId = "22690041";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_4_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T 10 _3 Cubic meter error message
      /*  [Category("CustomerEnquiry-Obsolete")]
        [Test]
        [Obsolete]
        public void TC_8475_Meter_Asset_T_10_3_Cubic_meter_Error_Message()
        {
            testCaseId = "TC-8475";
            qTestUniqueId = "22690042";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorTP10_3_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
*/
        // <summary>
        /// Test Method to Meter Asset_T 10 _3 Cubic Feet error message
       /* [Category("CustomerEnquiry-Obsolete")]
        [Test]
        [Obsolete]
        public void TC_8476_Meter_Asset_T_10_3_Cubic_Feet_Error_Message()
        {
            testCaseId = "TC-8476";
            qTestUniqueId = "22690043";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_3_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T 10 _3 Gallon error message
      /*  [Category("CustomerEnquiry-Obsolete")]
        [Test]
        [Obsolete]
        public void TC_8477_Meter_Asset_T_10_3_Gallon_Error_Message()
        {
            testCaseId = "TC-8477";
            qTestUniqueId = "22690044";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_3_Gallon(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T 10 _6 Cubic Meter error message
      /*  [Category("CustomerEnquiry-Obsolete")]
        [Test]
        [Obsolete]
        public void TC_8478_Meter_Asset_T_10_6_Cubic_Meter_Error_Message()
        {
            testCaseId = "TC-8478";
            qTestUniqueId = "22690045";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_6_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T 10 _6 Cubic Feet error message
       /* [Category("CustomerEnquiry-Obsolete")]
        [Test]
        [Obsolete]
        public void TC_8479_Meter_Asset_T10_6_Cubic_Feet_Error_Message()
        {
            testCaseId = "TC-8479";
            qTestUniqueId = "22690046";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_6_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T-10_6_Gallons_Error Message
        /*[Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8480_Meter_Asset_T10_6_Gallons_Error_Message()
        {
            testCaseId = "TC-8480";
            qTestUniqueId = "22690047";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_6_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T-10_8_Cubic Meter_Error Message
       /* [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8481_Meter_Asset_T_10_8_CubicMeter_Error_Message()
        {
            testCaseId = "TC-8481";
            qTestUniqueId = "22690048";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_8_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T-10_8_Cubic Feet_Error Message
       /* [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8482_Meter_Asset_T10_8_Cubic_Feet_Error_Message()
        {
            testCaseId = "TC-8482";
            qTestUniqueId = "22690049";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_8_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T-10_8_Gallons_Error Message
       /* [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8483_Meter_Asset_T10_8_Gallons_Error_Message()
        {
            testCaseId = "TC-8483";
            qTestUniqueId = "22690050";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_8_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_T-10_10_Cubic Meter_Error Message
       /* [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8484_Meter_Asset_T10_10_Cubic_Meter_Error_Message()
        {
            testCaseId = "TC-8484";
            qTestUniqueId = "22690051";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_10_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T-10_10_Cubic Feet_Error Message
       /* [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8485_Meter_Asset_T10_10_CubicFeet_ErrorMessage()
        {
            testCaseId = "TC-8485";
            qTestUniqueId = "22690052";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_10_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T-10_10_Gallons_Error Message
       /* [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8486_Meter_Asset_T10_10_Gallons_ErrorMessage()
        {
            testCaseId = "TC-8486";
            qTestUniqueId = "22690053";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_10_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_T-10_12_Cubic Meter_Error Message
        /*[Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8487_Meter_Asset_T10_12_Cubic_Meter_Error_Message()
        {
            testCaseId = "TC-8487";
            qTestUniqueId = "22690054";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_12_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T-10_12_Cubic Feet_Error Message
       /* [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8488_Meter_Asset_T10_12_Cubic_Feet_Error_Message()
        {
            testCaseId = "TC-8488";
            qTestUniqueId = "22690055";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_12_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T-10_12_Gallons_Error Message
       /* [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8489_Meter_Asset_T_10_12_Gallons_Error_Message()
        {
            testCaseId = "TC-8489";
            qTestUniqueId = "22690056";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_12_Gallons(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T-10_16_Cubic Meter_Error Message
       /* [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8490_Meter_Asset_T_10_16_Cubic_Meter_Error_Message()
        {
            testCaseId = "TC-8490";
            qTestUniqueId = "22690057";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_12_Cubic_Meter(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
*/
        // <summary>
        /// Test Method to Meter Asset_T-10_16_Cubic Feet_Error Message
       /* [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8491_Meter_Asset_T10_16_Cubic_Feet_Error_Message()
        {
            testCaseId = "TC-8491";
            qTestUniqueId = "22690058";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_12_Cubic_Feet(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T-10_16_Gallons_Error Message
       /* [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8492_Meter_Asset_T10_16_Gallons_Error_Message()
        {
            testCaseId = "TC-8492";
            qTestUniqueId = "22690059";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_16_Gallon(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_T-10_20_Cubic Meter_Error Message
      /*  [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8493_Meter_Asset_T10_20_Cubic_Meter_Error_Message()
        {
            testCaseId = "TC-8493";
            qTestUniqueId = "22690060";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_20_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_T-10_20_Cubic Feet_Error Message
      /*  [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8494_Meter_Asset_T10_20_Cubic_Feet_Error_Message()
        {
            testCaseId = "TC-8494";
            qTestUniqueId = "22690061";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_20_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T-10_20_Gallons_Error Message
      /*  [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_8495_Meter_Asset_T10_20_Gallons_Error_Message()
        {
            testCaseId = "TC-8495";
            qTestUniqueId = "22690062";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterErrorT10_20_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Customer Inquiry_Account Status_Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8549_Customer_Inquiry_Account_Status_Display()
        {
            testCaseId = "TC-8549";
            qTestUniqueId = "22709670";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatAccountStatus(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Status_Active_Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8550_Customer_Inquiry_Account_Status_Active_Display()
        {
            testCaseId = "TC-8550";
            qTestUniqueId = "22819309";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatAccountStatusActive(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Status_Inactive_Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8551_Customer_Inquiry_Account_Status_Inactive_Display()
        {
            testCaseId = "TC-8551";
            qTestUniqueId = "22819310";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatAccountStatusInactive(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_V4 Import File_Account Status_Active_Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8552_Customer_Inquiry_V4_Import_File_Account_Status_Active_Display()
        {
            testCaseId = "TC-8552";
            qTestUniqueId = "22819311";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatAccountStatusActive(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_V4 Import File_Account Status_Inactive_Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8553_Customer_Inquiry_V4_Import_File_Account_Status_Inactive_Display()
        {
            testCaseId = "TC-8553";
            qTestUniqueId = "22819313";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatAccountStatusInactive(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Meter Asset_HPT_1 1/2_Cubic Meter_Saved
       /* [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8418_Meter_Asset_HPT_1_1_2_Cubic_Meter_Saved()
        {
            testCaseId = "TC-8418";
            qTestUniqueId = "22689982";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_1_1_2_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
*/
        // <summary>
        /// Test Method to Meter Asset_HPT_1 1/2_Cubic Feet_Saved
       /* [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8419_Meter_Asset_HPT_1_1_2_Cubic_Feet_Saved()
        {
            testCaseId = "TC-8419";
            qTestUniqueId = "22689983";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_1_1_2_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
*/
        // <summary>
        /// Test Method to Meter Asset_HPT_1 1/2_Gallons_Saved
        /*[Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8420_Meter_Asset_HPT_1_1_2_Gallons_Saved()
        {
            testCaseId = "TC-8420";
            qTestUniqueId = "22689984";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_1_1_2_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_HPT_2 Cubic Meter Saved
       /* [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8421_Meter_Asset_HPT_2_CM3_Saved()
        {
            testCaseId = "TC-8421";
            qTestUniqueId = "22689985";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_2_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_HPT_2 Cubic Feet Saved
       /* [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8422_Meter_Asset_HPT_2_CF3_Saved()
        {
            testCaseId = "TC-8422";
            qTestUniqueId = "22689986";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_2_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
*/
        // <summary>
        /// Test Method to Meter Asset_HPT_2 GALLONS Saved
        /*[Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8423_Meter_Asset_HPT_2_GAL_Saved()
        {
            testCaseId = "TC-8423";
            qTestUniqueId = "22689987";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_2_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_HPT_3 Cubic Meter Saved
       /* [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8424_Meter_Asset_HPT_3_CM3_Saved()
        {
            testCaseId = "TC-8424";
            qTestUniqueId = "22689988";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_3_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/


        // <summary>
        /// Test Method to Meter Asset_HPT_3 Cubic Feet Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8425_Meter_Asset_HPT_3_CF3_Saved()
        {
            testCaseId = "TC-8425";
            qTestUniqueId = "22689989";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_3_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_HPT_3_Gallons_Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8426_Meter_Asset_HPT_3_GAL_Saved()
        {
            testCaseId = "TC-8426";
            qTestUniqueId = "22689990";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_3_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_HPT_4 Cubic Meter Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8427_Meter_Asset_HPT_4_CM3_Saved()
        {
            testCaseId = "TC-8427";
            qTestUniqueId = "22689991";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_4_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_HPT_4 Cubic Feet Saved
        /*[Category("CustomerEnquiry")]
        [Test]
        public void TC_8428_Meter_Asset_HPT_4_CF3_Saved()
        {
            testCaseId = "TC-8428";
            qTestUniqueId = "22689992";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_4_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_HPT_4 Gallon Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8429_Meter_Asset_HPT_4_GAL_Saved()
        {
            testCaseId = "TC-8429";
            qTestUniqueId = "22689993";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_4_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_HPT_6 Cubic meter Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8430_Meter_Asset_HPT_6_CM3_Saved()
        {
            testCaseId = "TC-8430";
            qTestUniqueId = "22689994";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_6_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_HPT_6 Cubic feet Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8431_Meter_Asset_HPT_6_CF3_Saved()
        {
            testCaseId = "TC-8431";
            qTestUniqueId = "22689995";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_6_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_HPT_6 Gallon Saved
        /*[Category("CustomerEnquiry")]
        [Test]
        public void TC_8432_Meter_Asset_HPT_6_GAL_Saved()
        {
            testCaseId = "TC-8432";
            qTestUniqueId = "22689996";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_6_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_HPT_8 Cubic meter Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8433_Meter_Asset_HPT_8_CM3_Saved()
        {
            testCaseId = "TC-8433";
            qTestUniqueId = "22689997";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_8_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_HPT_8 Cubic feet Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8434_Meter_Asset_HPT_8_CF3_Saved()
        {
            testCaseId = "TC-8434";
            qTestUniqueId = "22689998";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_8_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_HPT_8 Gallon Saved
        /*[Category("CustomerEnquiry")]
        [Test]
        public void TC_8435_Meter_Asset_HPT_8_GAL_Saved()
        {
            testCaseId = "TC-8435";
            qTestUniqueId = "22689999";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_8_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_HPT_10 Cubic MEter Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8436_Meter_Asset_HPT_10_CM3_Saved()
        {
            testCaseId = "TC-8436";
            qTestUniqueId = "22690000";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_10_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_HPT_10 Cubic feet Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8437_Meter_Asset_HPT_10_CF3_Saved()
        {
            testCaseId = "TC-8437";
            qTestUniqueId = "22690001";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_10_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_HPT_10 Gallon Saved
        /*[Category("CustomerEnquiry")]
        [Test]
        public void TC_8438_Meter_Asset_HPT_10_GAL_Saved()
        {
            testCaseId = "TC-8438";
            qTestUniqueId = "22690002";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_10_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_HPT_12 Cubic meter Saved
        /*[Category("CustomerEnquiry")]
        [Test]
        public void TC_8439_Meter_Asset_HPT_12_CM3_Saved()
        {
            testCaseId = "TC-8439";
            qTestUniqueId = "22690003";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_12_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_HPT_12 Cubic feet Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8440_Meter_Asset_HPT_12_CF3_Saved()
        {
            testCaseId = "TC-8440";
            qTestUniqueId = "22690004";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_12_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_HPT_12 Gallons Saved
        /*[Category("CustomerEnquiry")]
        [Test]
        public void TC_8441_Meter_Asset_HPT_12_GAL_Saved()
        {
            testCaseId = "TC-8441";
            qTestUniqueId = "22690005";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_12_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_HPT_16 Cubic meter Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8442_Meter_Asset_HPT_16_CM3_Saved()
        {
            testCaseId = "TC-8442";
            qTestUniqueId = "22690006";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_16_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_HPT_16 Cubic feet Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8443_Meter_Asset_HPT_16_CF3_Saved()
        {
            testCaseId = "TC-8443";
            qTestUniqueId = "22690007";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_16_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_HPT_16 Cubic feet Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8444_Meter_Asset_HPT_16_CF3_Saved()
        {
            testCaseId = "TC-8444";
            qTestUniqueId = "22690008";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_16_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_HPT_20 Cubic meter Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8445_Meter_Asset_HPT_20_CM3_Saved()
        {
            testCaseId = "TC-8445";
            qTestUniqueId = "22690009";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_20_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_HPT_20 Cubic feet Saved
        /*[Category("CustomerEnquiry")]
        [Test]
        public void TC_8446_Meter_Asset_HPT_20_CF3_Saved()
        {
            testCaseId = "TC-8446";
            qTestUniqueId = "22690010";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_20_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_HPT_20 Gallon Saved
        /*[Category("CustomerEnquiry")]
        [Test]
        public void TC_8447_Meter_Asset_HPT_20_GAL_Saved()
        {
            testCaseId = "TC-8447";
            qTestUniqueId = "22690011";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveHPT_20_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_T10_5/8 Cubic meter Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        [Obsolete]
        public void TC_8448_Meter_Asset_T10_5_8_CM3_Saved()
        {
            testCaseId = "TC-8448";
            qTestUniqueId = "22690012";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_5_10_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_T10_5/8 Cubic feet Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        [Obsolete]
        public void TC_8449_Meter_Asset_T10_5_8_CF3_Saved()
        {
            testCaseId = "TC-8449";
            qTestUniqueId = "22690013";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_5_10_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_T10_5/8 Gallon Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        [Obsolete]
        public void TC_8450_Meter_Asset_T10_5_8_GAL_Saved()
        {
            testCaseId = "TC-8450";
            qTestUniqueId = "22690014";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_5_10_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T10_3/4 cubic meter Saved
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8451_Meter_Asset_T10_3_4_CM3_Saved()
        {
            testCaseId = "TC-8451";
            qTestUniqueId = "22690015";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_3_4_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Meter Asset_T10_3/4 cubic feet Saved
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8452_Meter_Asset_T10_3_4_CF3_Saved()
        {
            testCaseId = "TC-8452";
            qTestUniqueId = "22690016";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_3_4_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Meter Asset_T10_3/4 gallon Saved
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        [Obsolete]
        public void TC_8453_Meter_Asset_T10_3_4_GAL_Saved()
        {
            testCaseId = "TC-8453";
            qTestUniqueId = "22690017";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_3_4_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Meter Asset_T10_1 Cubic meter Saved
        /*[Category("CustomerEnquiry")]
        [Test]
        [Obsolete]
        public void TC_8454_Meter_Asset_T10_1_CM3_Saved()
        {
            testCaseId = "TC-8454";
            qTestUniqueId = "22690018";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_1_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_T10_1 Cubic feet Saved
        [Category("CustomerEnquiry")]
        [Obsolete]
        [Test]
        public void TC_8455_Meter_Asset_T10_1_CF3_Saved()
        {
            testCaseId = "TC-8455";
            qTestUniqueId = "22690019";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_1_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Meter Asset_T10_1 Cubic feet Saved
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8456_Meter_Asset_T10_1_GAL_Saved()
        {
            testCaseId = "TC-8456";
            qTestUniqueId = "22690020";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_1_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Meter Asset_T10_1  1/2 Cubic meter Saved
        /*[Category("CustomerEnquiry")]
        [Test]
        public void TC_8457_Meter_Asset_T10_1_1_2_CM3_Saved()
        {
            testCaseId = "TC-8457";
            qTestUniqueId = "22690021";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_1_1_2_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_T10_1  1/2 Cubic feet Saved
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8458_Meter_Asset_T10_1_1_2_CF3_Saved()
        {
            testCaseId = "TC-8458";
            qTestUniqueId = "22690022";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_1_1_2_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Meter Asset_T10_1  1/2 Gallon Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8459_Meter_Asset_T10_1_1_2_GAL_Saved()
        {
            testCaseId = "TC-8459";
            qTestUniqueId = "22690023";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_1_1_2_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T10_2 cubic meter Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8460_Meter_Asset_T10_2_CM3_Saved()
        {
            testCaseId = "TC-8460";
            qTestUniqueId = "22690024";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_2_CM3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_T10_2 cubic feet Saved
        /*[Category("CustomerEnquiry")]
        [Test]
        public void TC_8461_Meter_Asset_T10_2_CF3_Saved()
        {
            testCaseId = "TC-8461";
            qTestUniqueId = "22690025";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_2_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_T10_2 gallon Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8462_Meter_Asset_T10_2_GAL_Saved()
        {
            testCaseId = "TC-8462";
            qTestUniqueId = "22690026";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_2_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Meter Asset_T10_4 cubic feet Saved
        /*[Category("CustomerEnquiry")]
        [Test]
        public void TC_8463_Meter_Asset_T10_4_CF3_Saved()
        {
            testCaseId = "TC-8463";
            qTestUniqueId = "22690027";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_4_CF3(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/
        // <summary>
        /// Test Method to Meter Asset_T10_4 gallon Saved
       /* [Category("CustomerEnquiry")]
        [Test]
        public void TC_8464_Meter_Asset_T10_4_GAL_Saved()
        {
            testCaseId = "TC-8464";
            qTestUniqueId = "22690029";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSaveT10_4_GAL(customerName, meterClass, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }*/

        // <summary>
        /// Test Method to Asset Configuration_Meter Class_Displays
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10069_Asset_Configuration_Meter_Class_Displays()
        {
            testCaseId = "TC-10069";
            qTestUniqueId = "24531343";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplays(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List_HP Turbine (HPT)
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10070_Asset_Configuration_Meter_Class_List_HP_Turbine_HPT()
        {
            testCaseId = "TC-10070";
            qTestUniqueId = "24531344";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysHPT(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List_HP Turbine T10
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10071_Asset_Configuration_Meter_Class_List_HP_Turbine_T10()
        {
            testCaseId = "TC-10071";
            qTestUniqueId = "24531345";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysT10(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List_HP Turbine Mach 10
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10072_Asset_Configuration_Meter_Class_List_HP_Turbine_Mach10()
        {
            testCaseId = "TC-10072";
            qTestUniqueId = "24531346";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysMach10(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List_HP Turbine True Flow
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10073_Asset_Configuration_Meter_Class_List_HP_Turbine_True_Flow()
        {
            testCaseId = "TC-10073";
            qTestUniqueId = "24531347";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysTFL(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List_HP Turbine True Flow
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10074_Asset_Configuration_Meter_Class_List_HP_Turbine_HPFST()
        {
            testCaseId = "TC-10074";
            qTestUniqueId = "24531348";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysHPFST(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List_HP P III
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10075_Asset_Configuration_Meter_Class_List_HP_Turbine_HPPIII()
        {
            testCaseId = "TC-10075";
            qTestUniqueId = "24531349";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysHPPIII(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Size_List_1 1/2
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10089_Asset_Configuration_Meter_Size_List_1_1_2()
        {
            testCaseId = "TC-10089";
            qTestUniqueId = "24531363";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSizeDisplaysList1_1_2(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Asset Configuration_Meter Size_List 2
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10090_Asset_Configuration_Meter_Size_List_2()
        {
            testCaseId = "TC-10090";
            qTestUniqueId = "24531364";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                //customerInquiry.ValidateMeterSizeDisplaysList_2(customerName, meterSize);
                customerInquiry.ValidateMeterSizeDisplaysList1_1_2(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Size_List 3
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10091_Asset_Configuration_Meter_Size_List_3()
        {
            testCaseId = "TC-10091";
            qTestUniqueId = "24531365";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                //customerInquiry.ValidateMeterSizeDisplaysList_3(customerName, meterSize);
                customerInquiry.ValidateMeterSizeDisplaysList1_1_2(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Size_List 4
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10092_Asset_Configuration_Meter_Size_List_4()
        {
            testCaseId = "TC-10092";
            qTestUniqueId = "24531366";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                //customerInquiry.ValidateMeterSizeDisplaysList_4(customerName, meterSize);
                customerInquiry.ValidateMeterSizeDisplaysList1_1_2(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Asset Configuration_Meter Size_List 6
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10093_Asset_Configuration_Meter_Size_List_6()
        {
            testCaseId = "TC-10093";
            qTestUniqueId = "24531367";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                //customerInquiry.ValidateMeterSizeDisplaysList_6(customerName, meterSize);
                customerInquiry.ValidateMeterSizeDisplaysList1_1_2(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Size_List 8
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10094_Asset_Configuration_Meter_Size_List_8()
        {
            testCaseId = "TC-10094";
            qTestUniqueId = "24531368";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                //customerInquiry.ValidateMeterSizeDisplaysList_8(customerName, meterSize);
                customerInquiry.ValidateMeterSizeDisplaysList1_1_2(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Size_List 10
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10095_Asset_Configuration_Meter_Size_List_10()
        {
            testCaseId = "TC-10095";
            qTestUniqueId = "24531369";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                //customerInquiry.ValidateMeterSizeDisplaysList_10(customerName, meterSize);
                customerInquiry.ValidateMeterSizeDisplaysList1_1_2(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Size_List 12
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10096_Asset_Configuration_Meter_Size_List_12()
        {
            testCaseId = "TC-10096";
            qTestUniqueId = "24531370";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterSize = testData["MeterSize"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                //customerInquiry.ValidateMeterSizeDisplaysList_12(customerName, meterSize);
                customerInquiry.ValidateMeterSizeDisplaysList1_1_2(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Size_List 16
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10097_Asset_Configuration_Meter_Size_List_16()
        {
            testCaseId = "TC-10097";
            qTestUniqueId = "24531371";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                //customerInquiry.ValidateMeterSizeDisplaysList_16(customerName, meterSize);
                customerInquiry.ValidateMeterSizeDisplaysList1_1_2(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Size_List 20
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10098_Asset_Configuration_Meter_Size_List_20()
        {
            testCaseId = "TC-10098";
            qTestUniqueId = "24531372";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterSize = testData["MeterSize"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                //customerInquiry.ValidateMeterSizeDisplaysList_20(customerName, meterSize);
                customerInquiry.ValidateMeterSizeDisplaysList1_1_2(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Size_List 5/8
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10099_Asset_Configuration_Meter_Size_List_5_8()
        {
            testCaseId = "TC-10099";
            qTestUniqueId = "24531373";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                //customerInquiry.ValidateMeterSizeDisplaysList_5_8(customerName, meterSize);
                customerInquiry.ValidateMeterSizeDisplaysList1_1_2(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Asset Configuration_Meter Size_List 3/4
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10100_Asset_Configuration_Meter_Size_List_3_4()
        {
            testCaseId = "TC-10100";
            qTestUniqueId = "24531374";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                //customerInquiry.ValidateMeterSizeDisplaysList_3_4(customerName, meterSize);
                customerInquiry.ValidateMeterSizeDisplaysList1_1_2(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Asset Configuration_Meter Size_List 1
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_10101_Asset_Configuration_Meter_Size_List_1()
        {
            testCaseId = "TC-10101";
            qTestUniqueId = "24531375";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                //customerInquiry.ValidateMeterSizeDisplaysList_1(customerName, meterSize);
                customerInquiry.ValidateMeterSizeDisplaysList1_1_2(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_UOM Not Assigned_Default_Gallons
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_10103_Asset_Configuration_UOM_Not_Assigned_Default_Gallons()
        {
            testCaseId = "TC-10103";
            qTestUniqueId = "24531377";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateDefaultUOMGallon(customerName, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Meter Class_Save_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11989_Customer_Inquiry_Meter_Information_Edit_Meter_Class_Save_Access()
        {
            testCaseId = "TC-11989";
            qTestUniqueId = "25614176";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditMeterClassSave(miuId, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Meter Size_Save_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11990_Customer_Inquiry_Meter_Information_Edit_Meter_Size_Save_Access()
        {
            testCaseId = "TC-11990";
            qTestUniqueId = "25614177";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditMeterSizeSave(miuId, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Meter Manufacturer_Save_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11991_Customer_Inquiry_Meter_Information_Edit_Meter_Manufacturer_Save_Access()
        {
            testCaseId = "TC-11991";
            qTestUniqueId = "25614178";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterManufacturer = testData["MeterManufacturer"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditMeterManufacturerSave(miuId, meterManufacturer);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Meter Manufacturer_Save_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]

        [Test]
        public void TC_11992_Customer_Inquiry_Meter_Information_Edit_Meter_Install_Date_Save_Access()
        {
            testCaseId = "TC-11992";
            qTestUniqueId = "25614179";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterInstallDate = testData["MeterInstallDate"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditMeterInstallDate(miuId, meterInstallDate);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Register Type_Save_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11993_Customer_Inquiry_Meter_Information_Edit_Register_Type_Save_Access()
        {
            testCaseId = "TC-11993";
            qTestUniqueId = "25614180";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                registerType = testData["RegisterType"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditMeterRegisterTypeSave(miuId, registerType);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Register Install Date_Save_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_11994_Customer_Inquiry_Meter_Information_Edit_Register_Install_Date_Save_Access()
        {
            testCaseId = "TC-11994";
            qTestUniqueId = "25614181";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                registerIntallDate = testData["RegisterIntallDate"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditRegisterInstallDate(miuId, registerIntallDate);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Register UOM_Save_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]


        [Test]
        public void TC_11995_Customer_Inquiry_Meter_Information_Edit_Register_UOM_Save_Access()
        {
            testCaseId = "TC-11995";
            qTestUniqueId = "25614182";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);

                customerInquiry.ValidateEditMeterUOMSave(miuId, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Number of Dials_Save_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]

        [Test]
        public void TC_11996_Customer_Inquiry_Meter_Information_Edit_Number_Of_Dials_Save_Access()
        {
            testCaseId = "TC-11996";
            qTestUniqueId = "25614183";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                noOfDials = testData["NoOfDials"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditMeterNoOfDials(miuId, noOfDials);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Meter Class/Register Type_Save_Access
        [Category("CustomerEnquiry")]
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_11997_Customer_Inquiry_Meter_Information_Edit_Meter_Class_Register_Type_Save_Access()
        {
            testCaseId = "TC-11997";
            qTestUniqueId = "25614184";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterClass = testData["MeterClass"];
                registerType = testData["RegisterType"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditMeterClassRegisterType(miuId, meterClass, registerType);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Meter Class/Register Type_Save_Access
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_11998_Customer_Inquiry_Meter_Information_Edit_Meter_Class_Register_Type_Save_Access()
        {
            testCaseId = "TC-11998";
            qTestUniqueId = "25614184";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterClass = testData["MeterClass"];
                registerType = testData["RegisterType"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditMeterClassRegisterType(miuId, meterClass, registerType);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Meter Size/Register UOM_Save_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_11999_Customer_Inquiry_Meter_Information_Edit_Meter_Size_Register_UOM_Save_Access()
        {
            testCaseId = "TC-11999";
            qTestUniqueId = "25614186";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterSize = testData["MeterSize"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditMeterSizeRegisterUOM(miuId, meterSize, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Meter Class/Number of Dials_Save_Access

        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_12000_Customer_Inquiry_Meter_Information_Edit_Meter_Class_Number_of_Dials_Save_Access()
        {
            testCaseId = "TC-12000";
            qTestUniqueId = "25614187";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterClass = testData["MeterClass"];
                noOfDials = testData["NoOfDials"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditMeterClassNoOfDials(miuId, meterClass, noOfDials);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Meter Manufacturer/Register Type_Save_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12005_Customer_Inquiry_Meter_Information_Edit_Meter_Manufacturer_Register_Type_Save_Access()
        {
            testCaseId = "TC-12005";
            qTestUniqueId = "25614192";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterManufacturer = testData["MeterManufacturer"];
                registerType = testData["RegisterType"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditMeterManufacturerRegisterType(miuId, meterManufacturer, registerType);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Meter Manufacturer/Register Install Date_Save_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12006_Customer_Inquiry_Meter_Information_Edit_Meter_Manufacturer_Register_Install_Date_Save_Access()
        {
            testCaseId = "TC-12006";
            qTestUniqueId = "25614193";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterManufacturer = testData["MeterManufacturer"];
                registerIntallDate = testData["RegisterIntallDate"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditMeterManufacturerRegisterInstallDate(miuId, meterManufacturer, registerIntallDate);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Meter Manufacturer/Register UOM_Save_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12007_Customer_Inquiry_Meter_Information_Edit_Meter_Manufacturer_Register_UOM_Save_Access()
        {
            testCaseId = "TC-12007";
            qTestUniqueId = "25614194";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterManufacturer = testData["MeterManufacturer"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditMeterManufacturerRegisterUOM(miuId, meterManufacturer, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Meter Manufacturer/Number of Dials_Save_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12008_CustomerInquiry_Meter_Information_Edit_Meter_Manufacturer_Number_of_Dials_Save_Access()
        {
            testCaseId = "TC-12008";
            qTestUniqueId = "25614195";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterManufacturer = testData["MeterManufacturer"];
                noOfDials = testData["NoOfDials"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditMeterManufacturerNoOfDials(miuId, meterManufacturer, noOfDials);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Unit of Measure_Cubic Feet_Import File
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12016_Customer_Inquiry_Meter_Information_Unit_of_Measure_Cubic_Feet_Import_File()
        {
            testCaseId = "TC-12016";
            qTestUniqueId = "25614204";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateUnitOfMeasureCF3(accountNo, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Unit of Measure_Cubic Meters_Import File
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12017_Customer_Inquiry_Meter_Information_Unit_of_Measure_Cubic_Meters_Import_File()
        {
            testCaseId = "TC-12017";
            qTestUniqueId = "25614205";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateUnitOfMeasureCM3(accountNo, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Unit of Measure_ gallons _Import File
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12018_Customer_Inquiry_Meter_Information_Unit_of_Measure_Cubic_Gallons_Import_File()
        {
            testCaseId = "TC-12018";
            qTestUniqueId = "25614206";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateUnitOfMeasureGAL(accountNo, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Unit of Measure_ Imperial gallons _Import File
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12019_Customer_Inquiry_Meter_Information_Unit_of_Measure_Imperial_Gallons_Import_File()
        {
            testCaseId = "TC-12019";
            qTestUniqueId = "25614207";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateUnitOfMeasureIPG(accountNo, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Unit of Measure_ Liters _Import File
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12020_Customer_Inquiry_Meter_Information_Unit_of_Measure_Liters_Import_File()
        {
            testCaseId = "TC-12020";
            qTestUniqueId = "25614208";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                accountNo = testData["AccountNumber"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateUnitOfMeasureLiters(accountNo, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Unit of Measure_Multiple UOM_Same Import File
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12021_Customer_Inquiry_Meter_Information_Unit_of_Measure_Multiple_UOM_Same_Import_File()
        {
            testCaseId = "TC-12021";
            qTestUniqueId = "25614209";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMultipleUnitOfMeasure(accountNo, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Unit of Measure_Default Utility UOM
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12022_Customer_Inquiry_Meter_Information_Unit_of_Measure_Default_Utility_UOM()
        {
            testCaseId = "TC-12022";
            qTestUniqueId = "25614210";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateDefaultUnitOfMeasure(accountNo, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List_Residential Fire Service (RFS)
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10076_Asset_Configuration_Meter_Class_List_Residential_Fire_ServiceRFS()
        {
            testCaseId = "TC-10076";
            qTestUniqueId = "24531350";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysRFS(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List_Residential Fire Service (RFS)
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10077_Asset_Configuration_Meter_Class_List_T_8()
        {
            testCaseId = "TC-10077";
            qTestUniqueId = "24531351";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysT8(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List_Residential Fire Service (RFS)
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10078_Asset_Configuration_Meter_Class_List_TT()
        {
            testCaseId = "TC-10078";
            qTestUniqueId = "24531352";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysTT(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List_Residential Fire Service (RFS)
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10079_Asset_Configuration_Meter_Class_List_PIII()
        {
            testCaseId = "TC-10079";
            qTestUniqueId = "24531353";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysPIII(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List_Residential Fire Service (RFS)
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10080_Asset_Configuration_Meter_Class_List_Smag()
        {
            testCaseId = "TC-10080";
            qTestUniqueId = "24531354";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysSmag(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List Sultra 
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10081_Asset_Configuration_Meter_Class_List_SUltra()
        {
            testCaseId = "TC-10081";
            qTestUniqueId = "24531355";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysSUltra(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List PD
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10082_Asset_Configuration_Meter_Class_List_PD()
        {
            testCaseId = "TC-10082";
            qTestUniqueId = "24531356";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysPD(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List Leak Spy
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10083_Asset_Configuration_Meter_Class_List_LeakSpy()
        {
            testCaseId = "TC-10083";
            qTestUniqueId = "24531357";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysLeakSpy(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List Permalog
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10084_Asset_Configuration_Meter_Class_List_Permalog()
        {
            testCaseId = "TC-10084";
            qTestUniqueId = "24531358";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysPermalog(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List Pressure
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10085_Asset_Configuration_Meter_Class_List_Pressure()
        {
            testCaseId = "TC-10085";
            qTestUniqueId = "24531359";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysPressure(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List S Fluidic
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10086_Asset_Configuration_Meter_Class_List_SFluidic()
        {
            testCaseId = "TC-10086";
            qTestUniqueId = "24531360";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysSFluidic(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List Sub T10 
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10087_Asset_Configuration_Meter_Class_List_Sub_t10()
        {
            testCaseId = "TC-10087";
            qTestUniqueId = "24531361";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysSubT10(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Asset Configuration_Meter Class_List Backflow
        [Category("CustomerEnquiry-Obsolete")]
        [Test]
        public void TC_10088_Asset_Configuration_Meter_Class_List_BackFlow()
        {
            testCaseId = "TC-10088";
            qTestUniqueId = "24531362";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                meterClass = testData["MeterClass"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterClassDisplaysBackflow(customerName, meterClass);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Info_View_Address_Line 1_Street Address
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8709_Customer_Inquiry_Account_Info_View_Address_Line_1_Street_Address()
        {
            testCaseId = "TC-8709";
            qTestUniqueId = "23568874";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateCustomerAddress(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Account Info_View_Address_Line 1_PO BOX
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8710_Customer_Inquiry_Account_Info_View_Address_Line_1_PO_BOX()
        {
            testCaseId = "TC-8710";
            qTestUniqueId = "23568919";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateCustomerAddress(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Account Info_View_Address_Line 2_City, State, Zip Code
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8711_Customer_Inquiry_Account_Info_View_Address_Line_2_City_State_Zip_Code()
        {
            testCaseId = "TC-8711";
            qTestUniqueId = "23568932";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateCustomerAddress(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to UI - Search/View Consumer Account Panel - Search field
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3883_UI_Search_View_Consumer_Account_Panel_Search_field()
        {
            testCaseId = "TC-3883";
            qTestUniqueId = "19318986";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSearchView();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to UI - Search/View Consumer Account Panel -  Consumer Account information
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_3884_UI_Search_View_Consumer_Account_Panel_Consumer_Account_information()
        {
            testCaseId = "TC-3884";
            qTestUniqueId = "19318987";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateCustAccInfo(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Account Info_Validate_MIU Install Date
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8769_Customer_Inquiry_Account_Info_Validate_MIU_Install_Date()
        {
            testCaseId = "TC-8769";
            qTestUniqueId = "24419843";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMiuInstallDate(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Info_Validate_Meter Install Date
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8770_Customer_Inquiry_Account_Info_Validate_Meter_Install_Date()
        {
            testCaseId = "TC-8770";
            qTestUniqueId = "24420010";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterInstallDate(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Info_No MIU Install Date
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8773_Customer_Inquiry_Account_Info_No_MIU_Install_Date()
        {
            testCaseId = "TC-8773";
            qTestUniqueId = "24420188";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMiuInstallDateNotSpecified(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Account Info_No Meter Install Date
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8776_Customer_Inquiry_Account_Info_No_Meter_Install_Date()
        {
            testCaseId = "TC-8776";
            qTestUniqueId = "24420859";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterInstallDateNotSpecified(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit_Asset Configuration Dialog_Save
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8160_Customer_Inquiry_Meter_Information_Edit_Asset_Configuration_Dialog_Save()
        {
            testCaseId = "TC-8160";
            qTestUniqueId = "21681434";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterClass = testData["MeterClass"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateEditAssetConfigurationDialogue(meterClass, customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Meter Information - MIU ID - Link Verbiage - More MIUs >
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_11923_Meter_Information_MiuID_Link_Verbiage_More_MIUs()
        {
            testCaseId = "TC-11923";
            qTestUniqueId = "25164381";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["CustomerName"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMoreMiusLink(customerName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Current Meter Information_Latest Reading_Colons
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12064_Customer_Inquiry_Current_Meter_Information_Latest_Reading_Colons()
        {
            testCaseId = "TC-12064";
            qTestUniqueId = "25836873";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateLatestReading(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Info_List of Meters_Order by_Status&Install Date
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7949_Customer_Inquiry_Account_Info_List_of_Meters_Order_by_Status_Install_Date()
        {
            testCaseId = "TC-7949";
            qTestUniqueId = "20345906";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateListOfMoreMeters(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Info_List of Meters_Select a Meter
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7950_Customer_Inquiry_Account_Info_List_Of_Meters_Select_a_Meter()
        {
            testCaseId = "TC-7950";
            qTestUniqueId = "20345945";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSelectMeterFromMoreMeters(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Choose Account_Account Number_Sort Order
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_7817_Customer_Inquiry_Account_Search_Choose_Account_Account_Number_Sort_Order()
        {
            testCaseId = "TC-7817";
            qTestUniqueId = "19757949";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateAccNoSortOrder(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Meter Install Date/Register Type_Save_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12009_Customer_Inquiry_Meter_Information_Edit_Meter_Install_Date_Register_Type_Save_Access()
        {
            testCaseId = "TC-12009";
            qTestUniqueId = "25614196";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterInstallDate = testData["MeterInstallDate"];
                registerType = testData["RegisterType"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterInstallDateRegisterType(miuId, meterInstallDate, registerType);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Meter Install Date/Register Install Date_Save_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12010_Customer_Inquiry_Meter_Information_Edit_Meter_Install_Date_Register_Install_Date_Save_Access()
        {
            testCaseId = "TC-12010";
            qTestUniqueId = "25614196";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterInstallDate = testData["MeterInstallDate"];
                registerIntallDate = testData["RegisterIntallDate"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterInstallDateRegisterIntallDate(miuId, meterInstallDate, registerIntallDate);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Meter Install Date/Register UOM_Save_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12011_Customer_Inquiry_Meter_Information_Edit_Meter_Install_Date_Register_UOM_Save_Access()
        {
            testCaseId = "TC-12011";
            qTestUniqueId = "25614198";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterInstallDate = testData["MeterInstallDate"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterInstallDateUOM(miuId, meterInstallDate, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit Meter Install Date/Number of Dials_Save_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12012_Customer_Inquiry_Meter_Information_Edit_Meter_Install_Date_Number_of_Dials_Save_Access()
        {
            testCaseId = "TC-12012";
            qTestUniqueId = "25614199";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterInstallDate = testData["MeterInstallDate"];
                noOfDials = testData["NoOfDials"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterInstallNoOfDials(miuId, meterInstallDate, noOfDials);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit _Meter_Multiple Edits_Save_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12013_Customer_Inquiry_Meter_Information_Edit_Meter_Multiple_Edits_Save_Access()
        {
            testCaseId = "TC-12013";
            qTestUniqueId = "25614200";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterInstallDate = testData["MeterInstallDate"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                meterManufacturer = testData["MeterManufacturer"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterInstallDateMultipleEdits(miuId, meterClass, meterSize, meterManufacturer, meterInstallDate);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit _Register_Multiple Edits_Save_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12014_Customer_Inquiry_Meter_Information_Edit_Register_Multiple_Edits_Save_Access()
        {
            testCaseId = "TC-12014";
            qTestUniqueId = "25614201";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                registerType = testData["RegisterType"];
                registerIntallDate = testData["RegisterIntallDate"];
                uom = testData["UOM"];
                noOfDials = testData["NoOfDials"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatRegisterMultipleEdits(miuId, registerType, registerIntallDate, uom, noOfDials);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit _Meter/Register_Multiple Edits_Save_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_12015_Customer_Inquiry_Meter_Information_Edit_Meter_Register_Multiple_Edits_Save_Access()
        {
            testCaseId = "TC-12015";
            qTestUniqueId = "25614202";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                meterClass = testData["MeterClass"];
                meterSize = testData["MeterSize"];
                meterManufacturer = testData["MeterManufacturer"];
                meterInstallDate = testData["MeterInstallDate"];
                registerType = testData["RegisterType"];
                registerIntallDate = testData["RegisterIntallDate"];
                uom = testData["UOM"];
                noOfDials = testData["NoOfDials"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatMeterInfoEditRegisterMultipleEdit(miuId, meterClass, meterSize, meterManufacturer, meterInstallDate, registerType, registerIntallDate, uom, noOfDials);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Search By_Meter ID_Alphanumeric
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8752_Customer_Inquiry_Account_Search_Search_By_Meter_ID_Alphanumeric()
        {
            testCaseId = "TC-8752";
            qTestUniqueId = "24357444";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateAccSearchAlphanumeric(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Choose Account_Meter Number_Alphanumeric Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8753_Customer_Inquiry_Account_Search_Choose_Account_Meter_Number_Alphanumeric_Display()
        {
            testCaseId = "TC-8753";
            qTestUniqueId = "24357454";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateAccSearchAlphanumericMiuId(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Choose A Meter_Meter Number_Alphanumeric Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8754_Customer_Inquiry_Choose_A_Meter_Meter_Number_Alphanumeric_Display()
        {
            testCaseId = "TC-8754";
            qTestUniqueId = "24357468";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMoreMetersAlphanumericMiuId(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Choose A Meter_Meter Number_Alphanumeric Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8755_Customer_Inquiry_Choose_A_Meter_Meter_Number_Alphanumeric_Display()
        {
            testCaseId = "TC-8755";
            qTestUniqueId = "24357468";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateAlphanumericMeterId(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Asset Configuration_Alphanumeric Meter ID_Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8756_Customer_Inquiry_Asset_Configuration_Alphanumeric_Meter_ID_Display()
        {
            testCaseId = "TC-8756";
            qTestUniqueId = "24357494";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateAlphanumericMeterNoFeild(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Import_Existing MIU Meter_Not Available_Deactivated Status Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8701_Customer_Inquiry_Import_Existing_MIU_Meter_Not_Available_Deactivated_Status_Display()
        {
            testCaseId = "TC-8701";
            qTestUniqueId = "23000068";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterNotAvailableDeactiveStatus(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Import_Existing MIU Meter_Not Available_Date Of Import_Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8702_Customer_Inquiry_Import_Existing_MIU_Meter_Not_Available_Date_Of_Import_Display()
        {
            testCaseId = "TC-8702";
            qTestUniqueId = "23000070";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterImportDateForDeactiveStatus(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Activation Date_New Account_New MIU Meter_Import Date Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8703_Customer_Inquiry_Activation_Date_New_Account_New_MIU_Meter_Import_Date_Display()
        {
            testCaseId = "TC-8703";
            qTestUniqueId = "23000073";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterImportDateForDeactiveStatus(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Activation Date_New Account_Existing MIU Meter_Initial Meter Date Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8704_Customer_Inquiry_Activation_Date_New_Account_Existing_MIU_Meter_Initial_Meter_Date_Display()
        {
            testCaseId = "TC-8704";
            qTestUniqueId = "23000083";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateInitialMeterImportDate(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Import_New MIU Meter_Existing Account_Start Date_ Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8698_Customer_Inquiry_Import_New_MIU_Meter_Existing_Account_Start_Date_Display()
        {
            testCaseId = "TC-8698";
            qTestUniqueId = "22974756";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateAccStartDate(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Import_Existing MIU Meter_Not Same Account_End Date_Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_8699_Customer_Inquiry_Import_Existing_MIU_Meter_Not_Same_Account_End_Date_Display()
        {
            testCaseId = "TC-8699";
            qTestUniqueId = "22974758";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateAccEndDate(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Consumption Chart_Accounts Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7910_Customer_Inquiry_Consumption_Chart_Accounts_Display()
        {
            testCaseId = "TC-7910";
            qTestUniqueId = "19753076";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateConsumptionChartAccountsDisplay(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Information_Edit_Asset Configuration Dialog_MIU_Contents
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8157_Customer_Inquiry_Meter_Information_Edit_Asset_Configuration_Dialog_MIU_Contents()
        {
            testCaseId = "TC-8157";
            qTestUniqueId = "21681431";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMIUContents(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry - Mini Map - Utility Lat/Long used if account has no coordinates
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8695_Customer_Inquiry_Mini_Map_Utility_Lat_Long_used_if_account_has_no_coordinates()
        {
            testCaseId = "TC-8695";
            qTestUniqueId = "22936445";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMiniMap(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Import_New MIU Meter_Existing Account_Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8696_Customer_Inquiry_Import_New_MIU_Meter_Existing_Account_Display()
        {
            testCaseId = "TC-8696";
            qTestUniqueId = "22974751";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMIUId(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Import_Existing MIU Meter_Not Same Account_Deactivated Status Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_8697_Customer_Inquiry_Import_Existing_MIU_Meter_Not_Same_Account_Deactivated_Status_Display()
        {
            testCaseId = "TC-8697";
            qTestUniqueId = "22974753";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMIUStatusOnAccount(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account_Add Comments_Displays
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20492_Customer_Inquiry_Account_Add_Comments_Displays()
        {
            testCaseId = "TC-20492";
            qTestUniqueId = "44051792";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatAddComments(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account_Add Comments_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20493_Customer_Inquiry_Account_Add_Comments_Access()
        {
            testCaseId = "TC-20493";
            qTestUniqueId = "44051833";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatAddCommentsAccess(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account_Add Comments_Cancel_Displays
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20494_Customer_Inquiry_Account_Add_Comments_Cancel_Displays()
        {
            testCaseId = "TC-20494";
            qTestUniqueId = "44051896";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatAddCommentsCancel(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account_Add Comments_Cancel_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20495_Customer_Inquiry_Account_Add_Comments_Cancel_Access()
        {
            testCaseId = "TC-20495";
            qTestUniqueId = "44051988";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatAddCommentsCancelAccess(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account_Add Comments_Save_Displays
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20496_Customer_Inquiry_Account_Add_Comments_Save_Displays()
        {
            testCaseId = "TC-20496";
            qTestUniqueId = "44052009";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatAddCommentsSaveDisplays(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account_Add Comments_Save_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20497_Customer_Inquiry_Account_Add_Comments_Save_Access()
        {
            testCaseId = "TC-20497";
            qTestUniqueId = "44052010";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatAddCommentsSaveDisplays(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account_Add Comments_Save_Access_Success_Toast_displays
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20498_Customer_Inquiry_Account_Add_Comments_Save_Access_Success_Toast_displays()
        {
            testCaseId = "TC-20498";
            qTestUniqueId = "44052177";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatAddCommentsSuccessToast(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Edit Comments_Icon Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20499_Customer_Inquiry_Edit_Comments_Icon_Display()
        {
            testCaseId = "TC-20499";
            qTestUniqueId = "44095108";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatEditCommentsIconDisplay(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Edit Comments_Icon Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20500_Customer_Inquiry_Edit_Comments_Icon_Access()
        {
            testCaseId = "TC-20500";
            qTestUniqueId = "44095641";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatEditCommentsIconAccess(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Edit Comments_Buttons Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20501_Customer_Inquiry_Edit_Comments_Buttons_Display()
        {
            testCaseId = "TC-20501";
            qTestUniqueId = "44095644";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatEditCommentsButtonDisplay(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Edit Comments_Cancel Button_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20502_Customer_Inquiry_Edit_Comments_Cancel_Button_Access()
        {
            testCaseId = "TC-20502";
            qTestUniqueId = "44095647";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatEditCommentsCancelButtonAccess(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Edit Comments_Save Button_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20503_Customer_Inquiry_Edit_Comments_Save_Button_Access()
        {
            testCaseId = "TC-20503";
            qTestUniqueId = "44095649";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatEditCommentsSaveButtonAccess(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Edit Comments_Details Saved
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20504_Customer_Inquiry_Edit_Comments_Details_Saved()
        {
            testCaseId = "TC-20504";
            qTestUniqueId = "44095652";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatEditCommentsDetailsSave(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Edit Comments_Success Toast
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20505_Customer_Inquiry_Edit_Comments_Success_Toast()
        {
            testCaseId = "TC-20505";
            qTestUniqueId = "44095655";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatEditCommentsDetailsSave(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Delete Own Comments_Delete Icon_Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20506_Customer_Inquiry_Delete_Own_Comments_Delete_Icon_Display()
        {
            testCaseId = "TC-20506";
            qTestUniqueId = "44096851";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatDeleteCommentsIconDisplay(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Delete Own Comments_Delete Icon_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20507_Customer_Inquiry_Delete_Own_Comments_Delete_Icon_Access()
        {
            testCaseId = "TC-20507";
            qTestUniqueId = "44096852";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatDeleteCommentsIconAccess(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Delete Own Comments_Confirmation Dialog_Buttons Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20508_Customer_Inquiry_Delete_Own_Comments_Confirmation_Dialog_Buttons_Display()
        {
            testCaseId = "TC-20508";
            qTestUniqueId = "44096853";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatDeleteCommentsConfirmation(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Delete Own Comments_Confirmation Dialog_No Button_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20509_Customer_Inquiry_Delete_Own_Comments_Confirmation_Dialog_No_Button_Access()
        {
            testCaseId = "TC-20509";
            qTestUniqueId = "44096854";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatDeleteCommentsConfirmation(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Delete Own Comments_Confirmation Dialog_Yes Button_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20510_Customer_Inquiry_Delete_Own_Comments_Confirmation_Dialog_Yes_Button_Access()
        {
            testCaseId = "TC-20510";
            qTestUniqueId = "44096854";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatDeleteCommentsConfirmationYes(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Delete Own Comments_Confirmation Dialog_Yes Button_Success Toast
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20511_Customer_Inquiry_Delete_Own_Comments_Confirmation_Dialog_Yes_Button_Success_Toast()
        {
            testCaseId = "TC-20511";
            qTestUniqueId = "44096854";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatDeleteCommentsConfirmationSuccessToast(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account_Delete Others Comments_Delete Icon_Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20512_Customer_Inquiry_Account_Delete_Others_Comments_Delete_Icon_Display()
        {
            testCaseId = "TC-20512";
            qTestUniqueId = "44096857";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatDeleteCommentsIconDisplay(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account_Delete Others Comments_Delete Icon_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20513_Customer_Inquiry_Account_Delete_Others_Comments_Delete_Icon_Access()
        {
            testCaseId = "TC-20513";
            qTestUniqueId = "44096858";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatDeleteCommentsIconAccess(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account_Delete Others Comments Confirmation Dialog_Buttons Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20514_Customer_Inquiry_Account_Delete_Others_Comments_Confirmation_Dialog_Buttons_Display()
        {
            testCaseId = "TC-20514";
            qTestUniqueId = "44096859";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatDeleteCommentsConfirmation(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry_Account_Delete Others Comments Confirmation Dialog_No Button_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20515_Customer_Inquiry_Account_Delete_Others_Comments_Confirmation_Dialog_No_Button_Access()
        {
            testCaseId = "TC-20515";
            qTestUniqueId = "44096860";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatDeleteCommentsConfirmation(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account_Delete Others Comments Confirmation Dialog_No Button_Access
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20516_Customer_Inquiry_Account_Delete_Others_Comments_Confirmation_Dialog_No_Button_Access()
        {
            testCaseId = "TC-20516";
            qTestUniqueId = "44096861";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatDeleteCommentsConfirmationYes(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account_Delete Others Comments Confirmation Dialog_Yes Button_Success Toast
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20517_Customer_Inquiry_Account_Delete_Others_Comments_Confirmation_Dialog_Yes_Button_Success_Toast()
        {
            testCaseId = "TC-20517";
            qTestUniqueId = "44096906";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatDeleteCommentsConfirmationSuccessToast(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account_Delete Others Comments_Delete Icon_Not Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20518_Customer_Inquiry_Account_Delete_Others_Comments_Delete_Icon_Not_Display()
        {
            testCaseId = "TC-20518";
            qTestUniqueId = "44096908";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatDeleteIconNotDisplayed(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Screen Title_Top
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20554_Customer_Inquiry_Screen_Title_Top()
        {
            testCaseId = "TC-20554";
            qTestUniqueId = "44096908";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password);
                customerInquiry.ValidatScreenTitleTop();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Search By Fields_Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20555_Customer_Inquiry_Search_By_Fields_Display()
        {
            testCaseId = "TC-20555";
            qTestUniqueId = "44241714";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatSearchByField();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account/MIU/Meter Data_Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20556_Customer_Inquiry_Account_MIU_Meter_Data_Display()
        {
            testCaseId = "TC-20556";
            qTestUniqueId = "44241715";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatAccDataDisplayed(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Consumption Data_Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20557_Customer_Inquiry_Consumption_Data_Display()
        {
            testCaseId = "TC-20557";
            qTestUniqueId = "44241716";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateConsumtionData(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Tabular Consumption Data_Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20558_Customer_Inquiry_Tabular_Consumption_Data_Display()
        {
            testCaseId = "TC-20558";
            qTestUniqueId = "44241717";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateConsumtionData(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Comments Section_Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20559_Customer_Inquiry_Comments_Section_Display()
        {
            testCaseId = "TC-20559";
            qTestUniqueId = "44241718";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatAddComments(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Map_Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20560_Customer_Inquiry_Map_Display()
        {
            testCaseId = "TC-20560";
            qTestUniqueId = "44241719";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMiniMap(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Comments Section_Scrollable_Map_Display
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20561_Customer_Inquiry_Comments_Section_Scrollable_Map_Display()
        {
            testCaseId = "TC-20561";
            qTestUniqueId = "44241720";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMiniMap(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Soft Disconnect_Icon Displayy
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20562_Customer_Inquiry_Soft_Disconnect_Icon_Display()
        {
            testCaseId = "TC-20562";
            qTestUniqueId = "44266840";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnect(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry_Soft Disconnect Icon_tool tip_Details displays
        /// </summary>
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20563_Customer_Inquiry_Soft_Disconnect_Icon_tool_tip_Details_displays()
        {
            testCaseId = "TC-20563";
            qTestUniqueId = "44266998";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnect(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_MIU ID_Soft Disconnect Turned On_System Comment Added
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20606_Customer_Inquiry_MIU_ID_Soft_Disconnect_Turned_On_System_Comment_Added()
        {
            testCaseId = "TC-20606";
            qTestUniqueId = "44286578";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectTurnOn(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry MIU ID_Soft Disconnect Turned On_With No End Date_System Comment Details
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20607_Customer_Inquiry_MIU_ID_Soft_Disconnect_Turned_On_With_No_End_Date_System_Comment_Details()
        {
            testCaseId = "TC-20607";
            qTestUniqueId = "44286579";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectTurnOnComment(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry MIU ID_Soft Disconnect Turned On_With No End Date_System Comment User Detail
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20608_Customer_Inquiry_MIU_ID_Soft_Disconnect_Turned_On_With_No_End_Date_System_Comment_User_Detail()
        {
            testCaseId = "TC-20608";
            qTestUniqueId = "44286580";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectTurnOnComment(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry MIU ID_Soft Disconnect Turned On_With No End Date_System Comment User Detail
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20609_Customer_Inquiry_MIU_ID_Soft_Disconnect_Turned_On_With_No_End_Date_System_Comment_User_Detail()
        {
            testCaseId = "TC-20609";
            qTestUniqueId = "44286581";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectTurnOnComment(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry MIU ID_Soft Disconnect Turned Off_System Comment User Details
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20610_Customer_Inquiry_MIU_ID_Soft_Disconnect_Turned_Off_System_Comment_User_Details()
        {
            testCaseId = "TC-20610";
            qTestUniqueId = "44286582";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectTurnOnComment(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry MIU ID_Soft Disconnect Turned Off_System Comment User Details
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20611_Customer_Inquiry_MIU_ID_Soft_Disconnect_Turned_Off_System_Comment_User_Details()
        {
            testCaseId = "TC-20611";
            qTestUniqueId = "44286583";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectTurnOnComment(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry MIU ID_Soft Disconnect Turned On_Edits Made_System Comment User Details
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20612_Customer_Inquiry_MIU_ID_Soft_Disconnect_Turned_On_Edits_Made_System_Comment_User_Details()
        {
            testCaseId = "TC-20612";
            qTestUniqueId = "44286584";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectTurnOnComment(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 0058 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21227_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_0058_Value_Imported()
        {
            testCaseId = "TC-21227";
            qTestUniqueId = "46339996";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 3/4"_Display_Alternate 0075 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21228_Customer_Inquiry_Meter_Size_Core_Value_3_4_Display_Alternate_0075_Value_Imported()
        {
            testCaseId = "TC-21228";
            qTestUniqueId = "46339997";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 1"_Display_Alternate 0100 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21229_Customer_Inquiry_Meter_Size_Core_Value_1_Display_Alternate_0100_Value_Imported()
        {
            testCaseId = "TC-21229";
            qTestUniqueId = "46339998";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 1 1/2"_Display_Alternate 0150 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21230_Customer_Inquiry_Meter_Size_Core_Value_1_1_2_Display_Alternate_0150_Value_Imported()
        {
            testCaseId = "TC-21230";
            qTestUniqueId = "46339999";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 2"_Display_Alternate 0200 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21231_Customer_Inquiry_Meter_Size_Core_Value__2_Display_Alternate_0200_Value_Imported()
        {
            testCaseId = "TC-21231";
            qTestUniqueId = "46340000";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 3"_Display_Alternate 0300 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21232_Customer_Inquiry_Meter_Size_Core_Value_3_Display_Alternate_0300_Value_Imported()
        {
            testCaseId = "TC-21232";
            qTestUniqueId = "46340001";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 4"_Display_Alternate 0400 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21233_Customer_Inquiry_Meter_Size_Core_Value_4_Display_Alternate_0400_Value_Imported()
        {
            testCaseId = "TC-21233";
            qTestUniqueId = "46340002";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 6"_Display_Alternate 0600 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21234_Customer_Inquiry_Meter_Size_Core_Value_6_Display_Alternate_0600_Value_Imported()
        {
            testCaseId = "TC-21234";
            qTestUniqueId = "46340003";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 5834 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21238_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_5834_Value_Imported()
        {
            testCaseId = "TC-21238";
            qTestUniqueId = "46340191";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 58x34 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21239_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_58x34_Value_Imported()
        {
            testCaseId = "TC-21239";
            qTestUniqueId = "46340192";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 58x12 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21240_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_58x12_Value_Imported()
        {
            testCaseId = "TC-21240";
            qTestUniqueId = "46340193";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 15mm Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21241_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_15mm_Value_Imported()
        {
            testCaseId = "TC-21241";
            qTestUniqueId = "46340194";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 15mm Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21242_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_15mm_Value_Imported()
        {
            testCaseId = "TC-21242";
            qTestUniqueId = "46340195";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 15mm Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21243_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_15mm_Value_Imported()
        {
            testCaseId = "TC-21243";
            qTestUniqueId = "46340196";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 15mm Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21244_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_15mm_Value_Imported()
        {
            testCaseId = "TC-21244";
            qTestUniqueId = "46340197";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 16mm Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21245_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_16mm_Value_Imported()
        {
            testCaseId = "TC-21245";
            qTestUniqueId = "46340198";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 16mm Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21246_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_16mm_Value_Imported()
        {
            testCaseId = "TC-21246";
            qTestUniqueId = "46340199";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 16mm Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21247_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_16mm_Value_Imported()
        {
            testCaseId = "TC-21247";
            qTestUniqueId = "46340249";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 16mm Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21248_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_16mm_Value_Imported()
        {
            testCaseId = "TC-21248";
            qTestUniqueId = "46340250";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 16mm Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21249_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_16mm_Value_Imported()
        {
            testCaseId = "TC-21249";
            qTestUniqueId = "46340260";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                meterID = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(meterID);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Choose Account_Contents Validation_Chrome
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7819_Customer_Inquiry_Account_Search_Choose_Account_Contents_Validation_Chrome()
        {
            testCaseId = "TC-7819";
            qTestUniqueId = "19871621";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateAccountContentValidation(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Choose Account_Contents Validation_IE
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7820_Customer_Inquiry_Account_Search_Choose_Account_Contents_Validation_IE()
        {
            testCaseId = "TC-7820";
            qTestUniqueId = "19871621";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateAccountContentValidation(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Choose Account_Contents Validation_Chrome_Without_Flash
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7821_Customer_Inquiry_Account_Search_Choose_Account_Contents_Validation_Chrome_Without_Flash()
        {
            testCaseId = "TC-7821";
            qTestUniqueId = "19871868";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateAccountContentValidation(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Choose Account_Contents Validation_IE_Without_Flash
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7822_Customer_Inquiry_Account_Search_Choose_Account_Contents_Validation_IE_Without_Flash()
        {
            testCaseId = "TC-7822";
            qTestUniqueId = "19871900";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateAccountContentValidation(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Account Search_Choose Account_Contents Validation_IE_Without_Flash
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7906_Customer_Inquiry_Account_Search_Choose_Account_Contents_Validation_IE_Without_Flash()
        {
            testCaseId = "TC-7906";
            qTestUniqueId = "20228004";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateConsumptionData(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Consumption Chart_Interval_Monthly
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7907_Customer_Inquiry_Consumption_Chart_Interval_Monthly()
        {
            testCaseId = "TC-7907";
            qTestUniqueId = "20228097";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateConsumptionData(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry Consumption Chart_Export_CSV
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7911_Customer_Inquiry_Consumption_Chart_Export_CSV()
        {
            testCaseId = "TC-7911";
            qTestUniqueId = "20228142";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateConsumptionExportToExcel(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Consumption Chart_Export_Excel
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7912_Customer_Inquiry_Consumption_Chart_Export_Excel()
        {
            testCaseId = "TC-7912";
            qTestUniqueId = "20238380";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateConsumptionExportToPDF(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry Account Info_View_Meter Type
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7918_Customer_Inquiry_Account_Info_View_Meter_Type()
        {
            testCaseId = "TC-7918";
            qTestUniqueId = "20238701";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterType(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Consumption Chart_Export_PDF
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_7940_Customer_Inquiry_Consumption_Chart_Export_PDF()
        {
            testCaseId = "TC-7940";
            qTestUniqueId = "21679793";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateConsumptionExportToPDF(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Selected Account_Refresh Read Icon
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13492_Customer_Inquiry_Selected_Account_Refresh_Read_Icon()
        {
            testCaseId = "TC-13492";
            qTestUniqueId = "29276683";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateRefreshReadsDisplayed(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Selected Account_Refresh Read Icon_Selected_Refresh Read Reenabled 
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13551_Customer_Inquiry_Selected_Account_Refresh_Read_Icon_Selected_Refresh_Read_Reenabled()
        {
            testCaseId = "TC-13551";
            qTestUniqueId = "29409047";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateRefreshReadsReEnabled(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry Selected Account_Refresh Read Icon_Selected_Reading Same/Newer
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13552_Customer_Inquiry_Selected_Account_Refresh_Read_Icon_Selected_Reading_Same_Newer()
        {
            testCaseId = "TC-13552";
            qTestUniqueId = "29409048";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateRefreshReadsSuccessToast(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry Selected Account_Refresh Read Icon_Selected_Toast Notification
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13553_Customer_Inquiry_Selected_Account_Refresh_Read_Icon_Selected_Toast_Notification()
        {
            testCaseId = "TC-13553";
            qTestUniqueId = "29409049";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["MeterId"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateRefreshReadsSuccessToast(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Asset Configuration_Meter Tab_UI Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17194_Customer_Inquiry_Asset_Configuration_Meter_Tab_UI_Display()
        {
            testCaseId = "TC-17194";
            qTestUniqueId = "37303421";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterTabUIDisplay(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry Current Meter Information_Unit Of Measure_Derived from Utility_Account with NO Meter UOM
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17197_Customer_Inquiry_Current_Meter_Information_Unit_Of_Measure_Derived_from_Utility_Account_with_NO_Meter_UOM()
        {
            testCaseId = "TC-17197";
            qTestUniqueId = "37304496";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateRegisterTabUOMDisplay(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Current_Meter_Information_Unit_Of_Measure_Derived_from_Utility_Meter_UOM_not_Supported_by_System
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17199_Customer_Inquiry_Current_Meter_Information_Unit_Of_Measure_Derived_from_Utility_Meter_UOM_not_Supported_by_System()
        {
            testCaseId = "TC-17199";
            qTestUniqueId = "37304499";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateDefaultUOMDisplay(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Current Meter Information_Unit Of Measure_Account with Meter UOM_Gallons_Value Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17200_Customer_Inquiry_Current_Meter_Information_Unit_Of_Measure_Account_with_Meter_UOM_Gallons_Value_Display()
        {
            testCaseId = "TC-17200";
            qTestUniqueId = "37304792";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateDefaultUOMDisplay(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Current Meter Information_Unit Of Measure_Account with Meter UOM_Cubic Feet_Value Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17201_Customer_Inquiry_Current_Meter_Information_Unit_Of_Measure_Account_with_Meter_UOM_Cubic_Feet_Value_Display()
        {
            testCaseId = "TC-17201";
            qTestUniqueId = "37304868";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateDefaultUOMDisplay(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Current Meter Information_Unit Of Measure_Account with Meter UOM_Cubic Meter_Value Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17202_Customer_Inquiry_Current_Meter_Information_Unit_Of_Measure_Account_with_Meter_UOM_Cubic_Meter_Value_Display()
        {
            testCaseId = "TC-17202";
            qTestUniqueId = "37304878";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateDefaultUOMDisplay(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Current Meter Information_Unit Of Measure_Account with Meter UOM_Imperial Gallons_Value Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17203_Customer_Inquiry_Current_Meter_Information_Unit_Of_Measure_Account_with_Meter_UOM_Imperial_Gallons_Value_Display()
        {
            testCaseId = "TC-17203";
            qTestUniqueId = "37304879";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateDefaultUOMDisplay(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Current Meter Information_Unit Of Measure_Account with Meter UOM_Liters_Value Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17204_Customer_Inquiry_Current_Meter_Information_Unit_Of_Measure_Account_with_Meter_UOM_Liters_Value_Display()
        {
            testCaseId = "TC-17204";
            qTestUniqueId = "37304883";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateDefaultUOMDisplay(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }



        // <summary>
        /// Test Method to Customer Inquiry Asset Configuration_Soft Disconnect_Tab Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20225_Customer_Asset_Configuration_Soft_Disconnect_Tab_Display()
        {
            testCaseId = "TC-20225";
            qTestUniqueId = "43506812";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectTab(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Asset Configuration_Soft Disconnect_Contents
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20226_Customer_Inquiry_Asset_Configuration_Soft_Disconnect_Contents()
        {
            testCaseId = "TC-20226";
            qTestUniqueId = "43506813";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectContents(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Asset Configuration_Soft Disconnect_Selected_Start Date Auto Populated
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20227_Customer_Inquiry_Asset_Configuration_Soft_Disconnect_Selected_Start_Date_Auto_Populated()
        {
            testCaseId = "TC-20227";
            qTestUniqueId = "43506814";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectStartDate(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Asset Configuration_Soft Disconnect_Selected_End Date_Optional
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20230_Customer_Inquiry_Asset_Configuration_Soft_Disconnect_Selected_End_Date_Optional()
        {
            testCaseId = "TC-20230";
            qTestUniqueId = "43506818";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectEndDate(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Asset Configuration_Soft Disconnect_Selected_Cancel Button_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20233_Customer_Inquiry_Asset_Configuration_Soft_Disconnect_Selected_Cancel_Button_Access()
        {
            testCaseId = "TC-20233";
            qTestUniqueId = "43526026";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectTab(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Asset Configuration_Soft Disconnect_Selected_Save Button_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20234_Customer_Inquiry_Asset_Configuration_Soft_Disconnect_Selected_SaveCancel_Button_Access()
        {
            testCaseId = "TC-20234";
            qTestUniqueId = "43526026";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectSaveButtonAccess(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Asset Configuration_Soft Disconnect_Unchecked_End Date_ Mandatory
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20235_Customer_Inquiry_Asset_Configuration_Soft_Disconnect_Unchecked_End_Date_Mandatory()
        {
            testCaseId = "TC-20235";
            qTestUniqueId = "43526029";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectEndDateMandatory(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Asset Configuration_Soft Disconnect_Unchecked_Cancel Button_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20248_Customer_Inquiry_Asset_Configuration_Soft_Disconnect_Unchecked_Cancel_Button_Access()
        {
            testCaseId = "TC-20248";
            qTestUniqueId = "43543143";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectUncheckedCancelBtn(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Asset Configuration_Soft Disconnect_Unchecked Save Button_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20249_Customer_Inquiry_Asset_Configuration_Soft_Disconnect_Unchecked_Save_Button_Access()
        {
            testCaseId = "TC-20249";
            qTestUniqueId = "43543144";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectUncheckedSaveBtn(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Asset Configuration_Soft Disconnect_Clear End Date_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20250_Customer_Inquiry_Asset_Configuration_Soft_Disconnect_Clear_End_Date_Access()
        {
            testCaseId = "TC-20250";
            qTestUniqueId = "43543145";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateSoftDisconnectClearBtn(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Create Comments_Premission Enabled_Add Comments
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20309_Customer_Inquiry_Create_Comments_Premission_Enabled_Add_Comments()
        {
            testCaseId = "TC-20309";
            qTestUniqueId = "43582211";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatAddComments(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Create Comments_Premission Disabled_Cannot Add Comments
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20310_Customer_Inquiry_Create_Comments_Premission_Disabled_Cannot_Add_Comments()
        {
            testCaseId = "TC-20310";
            qTestUniqueId = "43582212";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatCannotAddComments(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Create Comments_Premission Enabled_Edit existing Comments
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20311_Customer_Inquiry_Create_Comments_Premission_Enabled_Edit_existing_Comments()
        {
            testCaseId = "TC-20311";
            qTestUniqueId = "43582213";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatEditCommentsIconDisplay(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Create Comments_Premission Disabled_Cannot Edit Comments
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20312_Customer_Inquiry_Create_Comments_Premission_Disabled_Cannot_Edit_Comments()
        {
            testCaseId = "TC-20312";
            qTestUniqueId = "43582214";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatEditCommentsDisabled(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Delete Own Comments_Premission Enabled_Can Delete
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20313_Customer_Inquiry_Delete_Own_Comments_Premission_Enabled_Can_Delete()
        {
            testCaseId = "TC-20313";
            qTestUniqueId = "43582215";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatDeleteCommentsIconAccess(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Delete Own Comments_Premission Disabled_Cannot Delete
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20314_Customer_Inquiry_Delete_Own_Comments_Premission_Disabled_Cannot_Delete()
        {
            testCaseId = "TC-20314";
            qTestUniqueId = "43582216";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatDeleteCommentsDisabled(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Delete Others Comments_Permission Enabled_Can Delete
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20315_Customer_Inquiry_Delete_Others_Comments_Permission_Enabled_Can_Delete()
        {
            testCaseId = "TC-20315";
            qTestUniqueId = "43582218";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatDeleteCommentsConfirmation(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Delete Others Comments_Permission Disabled_Cannot Delete
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20316_Customer_Inquiry_Delete_Others_Comments_Permission_Disabled_Cannot_Delete()
        {
            testCaseId = "TC-20316";
            qTestUniqueId = "43582219";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatDeleteCommentsConfirmation(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry View Comments_Premission Enabled_View Existing Account Comments
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20318_Customer_Inquiry_View_Comments_Premission_Enabled_View_Existing_Account_Comments()
        {
            testCaseId = "TC-20318";
            qTestUniqueId = "43582221";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatViewComments(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Account_Prior Comments_Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20413_Customer_Inquiry_Account_Prior_Comments_Display()
        {
            testCaseId = "TC-20413";
            qTestUniqueId = "43732456";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatViewComments(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Account_View Comments_Details
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20414_Customer_Inquiry_Account_View_Comments_Details()
        {
            testCaseId = "TC-20414";
            qTestUniqueId = "43732463";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatViewComments(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Account_View Comments_Edit Details
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20415_Customer_Inquiry_Account_View_Comments_Edit_Details()
        {
            testCaseId = "TC-20415";
            qTestUniqueId = "43732466";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatEditCommentsIconAccess(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Account_View Comments_User Details
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20416_Customer_Inquiry_Account_View_Comments_User_Details()
        {
            testCaseId = "TC-20416";
            qTestUniqueId = "43732469";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatViewCommentDetails(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Account_View Comments_Date Time Format
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20417_Customer_Inquiry_Account_View_Comments_Date_Time_Format()
        {
            testCaseId = "TC-20417";
            qTestUniqueId = "43732472";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatViewCommentDetails(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Asset Configuration_Add Register Change Out Button/Screen Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21463_Customer_Inquiry_Asset_Configuration_Add_Register_Change_Out_Button_Screen_Display()
        {
            testCaseId = "TC-21463";
            qTestUniqueId = "47105748";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateAddRegister(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry Asset Configuration_Add Register Change Out Button/Screen_Fields Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21464_Customer_Inquiry_Asset_Configuration_Add_Register_Change_Out_Button_Screen_Fields_Display()
        {
            testCaseId = "TC-21464";
            qTestUniqueId = "47105793";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateAddRegisterDetails(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Asset Configuration_Add Register Change Out Button/Screen_Cancel Button_Displays
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21465_Customer_Inquiry_Asset_Configuration_Add_Register_Change_Out_Button_Screen_Cancel_Button_Displays()
        {
            testCaseId = "TC-21465";
            qTestUniqueId = "47105824";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateAddRegisterCancelBtnDisplays(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Asset Configuration_Add Register Change Out Button/Screen_Save Button_Displays
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21466_Customer_Inquiry_Asset_Configuration_Add_Register_Change_Out_Button_Screen_Save_Button_Displays()
        {
            testCaseId = "TC-21466";
            qTestUniqueId = "47105828";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateAddRegisterSaveBtnDisplays(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Add Register Change Out Button/Screen_Change Out Date_Default Date_Displays
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21467_Customer_Inquiry_Add_Register_Change_Out_Button_Screen_Change_Out_Date_Default_Date_Displays()
        {
            testCaseId = "TC-21467";
            qTestUniqueId = "47105856";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateAddRegisterDefaultDate(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Asset Configuration_Add Register Change Out Button/Screen_Field Populated_Save Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21468_Customer_Inquiry_Asset_Configuration_Add_Register_Change_Out_Button_Screen_Field_Populated_Save_Access()
        {
            testCaseId = "TC-21468";
            qTestUniqueId = "47105876";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateAddRegisterSaveBtnAccess(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Asset Configuration_Add Register Change Out Button/Screen_Field Blank_Save Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21469_Customer_Inquiry_Asset_Configuration_Add_Register_Change_Out_Button_Screen_Field_Blank_Save_Access()
        {
            testCaseId = "TC-21469";
            qTestUniqueId = "47105909";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateAddRegisterSaveBtnAccess(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Asset Configuration_Register Tab_Change Out History_Button Displays
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21778_Customer_Inquiry_Asset_Configuration_Register_Tab_Change_Out_History_Button_Displays()
        {
            testCaseId = "TC-21778";
            qTestUniqueId = "47562989";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutHistoryBtnDisplay(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Asset Configuration_Register Tab_Change Out Audit_Log_Button Displays
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21779_Customer_Inquiry_Asset_Configuration_Register_Tab_Change_Out_Audit_Log_Button_Displays()
        {
            testCaseId = "TC-21779";
            qTestUniqueId = "47563003";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutAuditLogBtnDisplay(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Add Button_Displays
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21780_Customer_Inquiry_Register_Tab_Change_Out_History_Add_Button_Displays()
        {
            testCaseId = "TC-21780";
            qTestUniqueId = "47563057";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutHistoryAddBtnDisplay(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Edit Button_Displays
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21781_Customer_Inquiry_Register_Tab_Change_Out_History_Edit_Button_Displays()
        {
            testCaseId = "TC-21781";
            qTestUniqueId = "47563071";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutHistoryEditBtnDisplay(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Delete Button_Displays
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21782_Customer_Inquiry_Register_Tab_Change_Out_History_Delete_Button_Displays()
        {
            testCaseId = "TC-21782";
            qTestUniqueId = "47563073";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutHistoryDeleteBtnDisplay(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out Audit Log_Audit Log table page_Displays
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21783_Customer_Inquiry_Register_Tab_Change_Out_Audit_Log_Audit_Log_table_page_Displays()
        {
            testCaseId = "TC-21783";
            qTestUniqueId = "47563075";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutAuditLogPageDisplay(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out History Screen_Column_Displays
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21784_Customer_Inquiry_Register_Tab_Change_Out_History_Screen_Column_Displays()
        {
            testCaseId = "TC-21784";
            qTestUniqueId = "47563090";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutAuditLogColumns(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out Audit Log Screen_Columns_Uneditable
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21785_Customer_Inquiry_Register_Tab_Change_Out_Audit_Log_Screen_Columns_Uneditable()
        {
            testCaseId = "TC-21785";
            qTestUniqueId = "47563141";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutAuditLogColumns(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Delete Button_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21797_Customer_Inquiry_Register_Tab_Change_Out_History_Delete_Button_Access()
        {
            testCaseId = "TC-21797";
            qTestUniqueId = "47586468";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutHistoryDeleteBtnAccess(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Delete Dialog_Confirm_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21798_Customer_Inquiry_Register_Tab_Change_Out_History_Delete_Dialog_Confirm_Access()
        {
            testCaseId = "TC-21798";
            qTestUniqueId = "47586470";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutHistoryDeleteBtnConfirmAccess(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Deleted_Register Install Date
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21799_Customer_Inquiry_Register_Tab_Change_Out_History_Deleted_Register_Install_Date()
        {
            testCaseId = "TC-21799";
            qTestUniqueId = "47586653";
            startDate = DateTime.Now;
            try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutHistoryDeleteConfirmDialog(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Delete Dialog_Cancel_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21800_Customer_Inquiry_Register_Tab_Change_Out_History_Delete_Dialog_Cancel_Access()
        {
            testCaseId = "TC-21800";
            qTestUniqueId = "47586750";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutHistoryDeleteConfirmDialog(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Delete_Register Install Date behavior
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21817_Customer_Inquiry_Register_Tab_Change_Out_History_Delete_Register_Install_Date_Behavior()
        {
            testCaseId = "TC-21817";
            qTestUniqueId = "47607510";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutHistoryDeleteConfirmation(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Edit Button_Enabled
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22182_Customer_Inquiry_Register_Tab_Change_Out_History_Edit_Button_Enabled()
        {
            testCaseId = "TC-22182";
            qTestUniqueId = "47713237";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutHistoryEditBtnEnabled(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Edit Button_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22183_Customer_Inquiry_Register_Tab_Change_Out_History_Edit_Button_Access()
        {
            testCaseId = "TC-22183";
            qTestUniqueId = "47713238";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutHistoryEditBtnAccess(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Edit_Record Added to Change Out Audit Log 
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22184_Customer_Inquiry_Register_Tab_Change_Out_History_Edit_Record_Added_to_Change_Out_Audit_Log()
        {
            testCaseId = "TC-22184";
            qTestUniqueId = "47713239";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutHistoryEditRegisterSave(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Edit_Multiple Change Outs_Register Install Date Behaviour
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22185_Customer_Inquiry_Register_Tab_Change_Out_History_Edit_Multiple_Change_Outs_Register_Install_Date_Behaviour()
        {
            testCaseId = "TC-22185";
            qTestUniqueId = "47713240";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutHistoryInstallDateBehavior(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Edit_Change Out Date_Existing Entry Date_Error Message Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22186_Customer_Inquiry_Register_Tab_Change_Out_History_Edit_Change_Out_Date_Existing_Entry_Date_Error_Message_Display()
        {
            testCaseId = "TC-22186";
            qTestUniqueId = "47713241";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutHistoryEditChangeOutDate(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Edit_Confirmation Screen Message
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22187_Customer_Inquiry_Register_Tab_Change_Out_History_Edit_Confirmation_Screen_Message()
        {
            testCaseId = "TC-22187";
            qTestUniqueId = "47713242";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutHistoryEditRegisterSave(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Add_Confirmation Screen Message
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22188_Customer_Inquiry_Register_Tab_Change_Out_History_Add_Confirmation_Screen_Message()
        {
            testCaseId = "TC-22188";
            qTestUniqueId = "47713243";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateChangeOutHistoryEditRegisterSave(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Search Criteria_Choose Account_Displays
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22252_Customer_Inquiry_Search_Criteria_Choose_Account_Displays()
        {
            testCaseId = "TC-22252";
            qTestUniqueId = "48112498";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatAccDataDisplayed(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Search Criteria_Choose Account_Install Date_Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22253_Customer_Inquiry_Search_Criteria_Choose_Account_Install_Date_Display()
        {
            testCaseId = "TC-22253";
            qTestUniqueId = "48112948";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateInstallDateColumn(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Search Criteria_Choose Account_Install Date_sorted_Descending oder
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22254_Customer_Inquiry_Search_Criteria_Choose_Account_Install_Date_sorted_Descending_oder()
        {
            testCaseId = "TC-22254";
            qTestUniqueId = "48113067";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateInstallDateColumnSortDescending(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Search Criteria_Choose Account_Install Date_sorted_Ascending oder
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22255_Customer_Inquiry_Search_Criteria_Choose_Account_Install_Date_sorted_Ascending_oder()
        {
            testCaseId = "TC-22255";
            qTestUniqueId = "48113071";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateInstallDateColumnSortAscending(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Search_Choose Account Modal_Fields Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22256_Customer_Inquiry_Search_Choose_Account_Modal_Fields_Display()
        {
            testCaseId = "TC-22256";
            qTestUniqueId = "48114685";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateModalFeildsDisplay(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Search_Choose Account Modal_Account Status
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22257_Customer_Inquiry_Search_Choose_Account_Modal_Account_Status()
        {
            testCaseId = "TC-22257";
            qTestUniqueId = "48114686";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidatAccountStatus(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Search_Choose Account Modal_MIU Status on Account
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22258_Customer_Inquiry_Search_Choose_Account_Modal_MIU_Status_on_Account()
        {
            testCaseId = "TC-22258";
            qTestUniqueId = "48114687";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMIUStatusOnAccount(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Search_Choose Account Modal_Install Date
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22259_Customer_Inquiry_Search_Choose_Account_Modal_Install_Date()
        {
            testCaseId = "TC-22259";
            qTestUniqueId = "48114689";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMIUInstallDate(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Search_Choose Account Modal_Deactivate Date
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22260_Customer_Inquiry_Search_Choose_Account_Modal_Deactivate_Date()
        {
            testCaseId = "TC-22260";
            qTestUniqueId = "48114690";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterImportDateForDeactiveStatus(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Search_More than 1000 rows_Message_Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22267_Customer_Inquiry_Search_More_than_1000_rows_Message_Display()
        {
            testCaseId = "TC-22267";
            qTestUniqueId = "48141700";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMoreThan1000Rows(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Same Premises_Same Meter Number_Unique Meter Key_Correct meter size and UOM_Displays
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22358_Customer_Inquiry_Same_Premises_Same_Meter_Number_Unique_Meter_Key_Correct_meter_size_and_UOM_Displays()
        {
            testCaseId = "TC-22358";
            qTestUniqueId = "48197349";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                home.NavigateToLftCustomerInquiry(url, userName, password); ;
                customerInquiry.ValidateMeterSize(accountNo);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 5/8 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17673_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_5_8_Value_Imported()
        {
            testCaseId = "TC-17673";
            qTestUniqueId = "37808837";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["MiuID"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSizeCoreValue5_8(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 5/8 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17674_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_5_8_Value_Imported()
        {
            testCaseId = "TC-17674";
            qTestUniqueId = "37809234";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["MiuID"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSizeCoreValue5_8(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 58 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17675_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_58_Value_Imported()
        {
            testCaseId = "TC-17675";
            qTestUniqueId = "37827538";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["MiuID"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSizeCoreValue5_8(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate .625 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17676_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_625_Value_Imported()
        {
            testCaseId = "TC-17676";
            qTestUniqueId = "37827539";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["MiuID"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSizeCoreValue5_8(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 0.625 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17677_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_0625_Value_Imported()
        {
            testCaseId = "TC-17677";
            qTestUniqueId = "37827546";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["MiuID"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSizeCoreValue5_8(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 5/8 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17678_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_5_8_Value_Imported()
        {
            testCaseId = "TC-17678";
            qTestUniqueId = "37827547";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["MiuID"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSizeCoreValue5_8(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 5/8 x 1/2 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17682_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_5_8_x_1_2_Value_Imported()
        {
            testCaseId = "TC-17682";
            qTestUniqueId = "37827566";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["MiuID"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSizeCoreValue5_8(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 5/8 x 1/2 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17683_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_5_8_x_1_2_Value_Imported()
        {
            testCaseId = "TC-17683";
            qTestUniqueId = "37827567";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["MiuID"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSizeCoreValue5_8(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 5/8 x 3/4 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17686_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_5_8_x_3_4_Value_Imported()
        {
            testCaseId = "TC-17686";
            qTestUniqueId = "37827570";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["MiuID"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSizeCoreValue5_8(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 5/8 x 3/4 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17687_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_5_8_x_3_4_Value_Imported()
        {
            testCaseId = "TC-17687";
            qTestUniqueId = "37827571";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["MiuID"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSizeCoreValue5_8(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 5/8 x 5/8 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17715_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_5_8_x_5_8_Value_Imported()
        {
            testCaseId = "TC-17715";
            qTestUniqueId = "37827730";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["MiuID"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSizeCoreValue5_8(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary>
        /// Test Method to Customer Inquiry_Meter Size_Core Value 5/8"_Display_Alternate 5/8 x 5/8 Value_Imported
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17716_Customer_Inquiry_Meter_Size_Core_Value_5_8_Display_Alternate_5_8_x_5_8_Value_Imported()
        {
            testCaseId = "TC-17716";
            qTestUniqueId = "37827731";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                customerName = testData["MiuID"];
                meterSize = testData["MeterSize"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMeterSizeCoreValue5_8(customerName, meterSize);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_UOM_Alternate GAL Value_Imported_Core UOM Value Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17829_Customer_Inquiry_UOM_Alternate_GAL_Value_Imported_Core_UOM_Value_Display()
        {
            testCaseId = "TC-17829";
            qTestUniqueId = "37841818";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateUnitOfMeasureGAL(accountNo, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_UOM_Alternate USG Value_Imported_Core UOM Value Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17830_Customer_Inquiry_UOM_Alternate_USG_Value_Imported_Core_UOM_Value_Display()
        {
            testCaseId = "TC-17830";
            qTestUniqueId = "37842303";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateUnitOfMeasureGAL(accountNo, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary
        /// Test Method to Customer Inquiry_UOM_Alternate G Value_Imported_Core UOM Value Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17832_Customer_Inquiry_UOM_Alternate_G_Value_Imported_Core_UOM_Value_Display()
        {
            testCaseId = "TC-17832";
            qTestUniqueId = "37842953";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateUnitOfMeasureGAL(accountNo, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_UOM_Alternate GL Value_Imported_Core UOM Value Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_17833_Customer_Inquiry_UOM_Alternate_GL_Value_Imported_Core_UOM_Value_Display()
        {
            testCaseId = "TC-17833";
            qTestUniqueId = "37843279";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                accountNo = testData["AccountNumber"];
                uom = testData["UOM"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateUnitOfMeasureGAL(accountNo, uom);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Edit Button_Access
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23689_Customer_Inquiry_Register_Tab_Change_Out_History_Edit_Button_Access()
        {
            testCaseId = "TC-23689";
            qTestUniqueId = "50773115";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateChangeOutHistoryEditBtnAccess(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Edit Dialog_Change Out Date_Disable
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23690_Customer_Inquiry_Register_Tab_Change_Out_History_Edit_Dialog_Change_Out_Date_Disable()
        {
            testCaseId = "TC-23690";
            qTestUniqueId = "50773119";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateChangeOutHistoryEditChangeOutDate(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Edit Dialog_Change Out Date_Edit values
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23691_Customer_Inquiry_Register_Tab_Change_Out_History_Edit_Dialog_Change_Out_Date_Edit_values()
        {
            testCaseId = "TC-23691";
            qTestUniqueId = "50773198";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateChangeOutHistoryEditFinalRead(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Edit Change Out Date_Change out History_Edited values displays
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23692_Customer_Inquiry_Register_Tab_Change_Out_History_Edit_Change_Out_Date_Change_out_History_Edited_values_displays()
        {
            testCaseId = "TC-23692";
            qTestUniqueId = "50773219";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateChangeOutHistoryEditConfirmation(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Edit Change out_History Audit Log_record displays
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_23693_Customer_Inquiry_Register_Tab_Change_Out_History_Edit_Change_out_History_Audit_Log_record_displays()
        {
            testCaseId = "TC-23693";
            qTestUniqueId = "50773354";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateChangeOutDateDisabled(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Search_More than 1000 rows_Choose Modal_Message_Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_22953_Customer_Inquiry_Search_More_than_1000_rows_Choose_Modal_Message_Display()
        {
            testCaseId = "TC-22953";
            qTestUniqueId = "49770196";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMoreThan1000Rows(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Edit_System Comment Added
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21826_Customer_Inquiry_Register_Tab_Change_Out_History_Edit_System_Comment_Added()
        {
            testCaseId = "TC-21826";
            qTestUniqueId = "47642208";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateCommentSection(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Delete_System Comment Added
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21827_Customer_Inquiry_Register_Tab_Change_Out_History_Delete_System_Comment_Added()
        {
            testCaseId = "TC-21827";
            qTestUniqueId = "47642225";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateCommentSection(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary
        /// Test Method to Customer Inquiry_Register Change Out_Delete_System Comment User Details
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21762_Customer_Inquiry_Register_Change_Out_Delete_System_Comment_User_Details()
        {
            testCaseId = "TC-21762";
            qTestUniqueId = "47469215";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatDeleteCommentsIconDisplay(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Register Tab_Change Out History_Existing multiple change outs_Date
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21818_Customer_Inquiry_Register_Tab_Change_Out_History_Existing_multiple_change_outs_Date()
        {
            testCaseId = "TC-21818";
            qTestUniqueId = "47607511";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateChangeOutDateInvalidDate(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Add Register Change Out Button/Screen_Read Only 
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21516_Customer_Inquiry_Add_Register_Change_Out_Button_Screen_Read_Only()
        {
            testCaseId = "TC-21516";
            qTestUniqueId = "47193523";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateChangeOutHistoryEditChangeOutDate(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Register Change Out_Edits_System Comment User Details
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_21720_Customer_Inquiry_Register_Change_Out_Edits_System_Comment_User_Details()
        {
            testCaseId = "TC-21720";
            qTestUniqueId = "47446903";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatEditCommentsIconAccess(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Consumption Grid_Daily_Actual_Reading Displayed
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_18124_Customer_Inquiry_Consumption_Grid_Daily_Actual_Reading_Displayed()
        {
            testCaseId = "TC-18124";
            qTestUniqueId = "38969569";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSearchAccountByMUId(miuId);
                //customerInquiry.DailyConsumption(query);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary
        /// Test Method to Customer Inquiry_Consumption Grid_Hourly_Actual_Reading Displayed
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_18125_Customer_Inquiry_Consumption_Grid_Hourly_Actual_Reading_Displayed()
        {
            testCaseId = "TC-18125";
            qTestUniqueId = "38969570";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateHourlyReadingActual(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Consumption Grid_Hourly_Estimated_Calculation
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_18126_Customer_Inquiry_Consumption_Grid_Hourly_Estimated_Calculation()
        {
            testCaseId = "TC-18126";
            qTestUniqueId = "38969571";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateHourlyReadingEstimated(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Consumption Grid_Hourly_Actual_Calculation
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_18127_Customer_Inquiry_Consumption_Grid_Hourly_Actual_Calculation()
        {
            testCaseId = "TC-18127";
            qTestUniqueId = "38969572";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                driver.Navigate().Refresh();
                customerInquiry.ValidateHourlyReadingActual(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Consumption Grid_Monthly_Estimated_Calculation
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_18128_Customer_Inquiry_Consumption_Grid_Monthly_Estimated_Calculation()
        {
            testCaseId = "TC-18128";
            qTestUniqueId = "38969573";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateHourlyReadingActual(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Consumption Grid_Monthly_Actual_Calculation
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_18129_Customer_Inquiry_Consumption_Grid_Monthly_Actual_Calculation()
        {
            testCaseId = "TC-18129";
            qTestUniqueId = "38969574";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateHourlyReadingActual(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Consumption Grid_Daily_Estimated_Calculation
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_18130_Customer_Inquiry_Consumption_Grid_Daily_Estimated_Calculation()
        {
            testCaseId = "TC-18130";
            qTestUniqueId = "38969575";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateHourlyReadingActual(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary
        /// Test Method to Customer Inquiry_Consumption Grid_Daily_Actual_Calculation
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_18131_Customer_Inquiry_Consumption_Grid_Daily_Actual_Calculation()
        {
            testCaseId = "TC-18131";
            qTestUniqueId = "38969576";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateHourlyReadingActual(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Consumption Grid_Monthly_Actual_Calculation
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_18132_Customer_Inquiry_Consumption_Grid_Monthly_Actual_Calculation()
        {
            testCaseId = "TC-18132";
            qTestUniqueId = "38969577";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMonthlyReadingActual(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Consumption Chart_Monthly_Estimated_Calculation
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_18133_Customer_Inquiry_Consumption_Chart_Monthly_Estimated_Calculation()
        {
            testCaseId = "TC-18133";
            qTestUniqueId = "38969578";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMonthlyReadingEstimated(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Consumption Chart_Hourly_Actual_Calculation
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_18134_Customer_Inquiry_Consumption_Chart_Hourly_Actual_Calculation()
        {
            testCaseId = "TC-18134";
            qTestUniqueId = "38969579";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateHourlyReadingActual(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Consumption Chart_Hourly_Estimated_Calculation
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_18135_Customer_Inquiry_Consumption_Chart_Hourly_Estimated_Calculation()
        {
            testCaseId = "TC-18135";
            qTestUniqueId = "38969580";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateHourlyReadingEstimated(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary
        /// Test Method to Customer Inquiry_Consumption Chart_Daily_Actual_Calculation
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_18136_Customer_Inquiry_Consumption_Chart_Daily_Actual_Calculation()
        {
            testCaseId = "TC-18136";
            qTestUniqueId = "38969581";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateHourlyReadingActual(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Consumption Chart_Daily_Estimated_Calculation
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_18137_Customer_Inquiry_Consumption_Chart_Daily_Estimated_Calculation()
        {
            testCaseId = "TC-18137";
            qTestUniqueId = "38969582";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                //customerInquiry.DailyConsumption(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary
        /// Test Method to Customer Inquiry_Account_Comments Section_Logical Delete_Not Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20421_Customer_Inquiry_Account_Comments_Section_Logical_Delete_Not_Display()
        {
            testCaseId = "TC-20421";
            qTestUniqueId = "43732476";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatLogicalDeleteComm(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Account_Comments Section_Logical Delete_Not Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20236_Customer_Inquiry_Account_Comments_Section_Logical_Delete_Not_Display()
        {
            testCaseId = "TC-20236";
            qTestUniqueId = "43526039";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateSoftDisconnectUncheckedEndDate(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_View Comments_Premission Disabled_Map Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_20308_Customer_Inquiry_View_Comments_Premission_Disabled_Map_Display()
        {
            testCaseId = "TC-20308";
            qTestUniqueId = "43582208";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidatViewMapCommentsDisabled(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary
        /// Test Method to Customer Inquiry_Consumption Chart_Interval_Monthly_Actual Button
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12303_Customer_Inquiry_Consumption_Chart_Interval_Monthly_Actual_Button()
        {
            testCaseId = "TC-12303";
            qTestUniqueId = "26716095";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMonthlyReadingActualBtn(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Consumption Chart_Interval_Monthly_Estimated Button
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12305_Customer_Inquiry_Consumption_Chart_Interval_Monthly_Estimated_Button()
        {
            testCaseId = "TC-12305";
            qTestUniqueId = "26716097";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMonthlyReadingEstimatedBtn(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


        // <summary
        /// Test Method to Customer Inquiry_Consumption Chart_Interval_Monthly_Consumption Bars
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12307_Customer_Inquiry_Consumption_Chart_Interval_Monthly_Consumption_Bars()
        {
            testCaseId = "TC-12307";
            qTestUniqueId = "26716099";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMonthlyReadingEstimatedBtn(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Consumption Chart_Interval_Hourly_Actual Button
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12308_Customer_Inquiry_Consumption_Chart_Interval_Hourly_Actual_Button()
        {
            testCaseId = "TC-12308";
            qTestUniqueId = "26716100";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateHourlyReadingActual(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Consumption Chart_Interval_Hourly_Estimated Button
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12310_Customer_Inquiry_Consumption_Chart_Interval_Hourly_Estimated_Button()
        {
            testCaseId = "TC-12310";
            qTestUniqueId = "26716103";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateHourlyReadingEstimated(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Consumption Chart_Interval_Hourly_Consumption Bars
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_12312_Customer_Inquiry_Consumption_Chart_Interval_Hourly_Consumption_Bars()
        {
            testCaseId = "TC-12312";
            qTestUniqueId = "26716105";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateHourlyReadingEstimated(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Monthly Consumption Graph_Zero Consumption_0 Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13145_Customer_Inquiry_Monthly_Consumption_Graph_Zero_Consumption_0_Display()
        {
            testCaseId = "TC-13145";
            qTestUniqueId = "28582845";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateHourlyReadingEstimated(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        // <summary
        /// Test Method to Customer Inquiry_Monthly Consumption Grid_Zero Consumption_0 Display
        [Category("CustomerEnquiry")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_13146_Customer_Inquiry_Monthly_Consumption_Grid_Zero_Consumption_0_Display()
        {
            testCaseId = "TC-13146";
            qTestUniqueId = "28582846";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                miuId = testData["MiuID"];
                home.NavigateLanPageCustomerInquiry(url, userName, password);
                customerInquiry.ValidateMonthlyReadingActual(miuId);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }





        // <summary>
        /// Test Method to Customer_Inquiry_Consumption_Grid_Daily_Consumption_Analysis
        [Category("TestingConsumption")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_24215_Customer_Inquiry_Consumption_Grid_Daily_Consumption_Analysis()
        {
            testCaseId = "TC-24215";
            qTestUniqueId = "52083992";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                query = testData["PostgreSQLQuery"];
                meterID = testData["MeterId"];
                home.NavigateToHome(url, userName, password);
                customerInquiry.ValidateSearchAccountByMUId(meterID);
                customerInquiry.DailyConsumption(query);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }

        // <summary>
        /// Test Method to Customer_Inquiry_Consumption_Grid_Daily_Consumption_Analysis L900
        [Category("TestingConsumption")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_25602_L900_Customer_Inquiry_Consumption_Grid_Daily_Consumption_Analysis()
        {
            testCaseId = "TC-25602";
            qTestUniqueId = "53774836";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                query = testData["PostgreSQLQuery"];
                meterID = testData["MeterId"];
                home.NavigateToHome(url, userName, password);
                customerInquiry.ValidateSearchAccountByMUId(meterID);
                customerInquiry.DailyConsumptionL900(query);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }

        // <summary>
        /// Test Method to Customer_Inquiry_Consumption_Grid_Daily_Consumption_Analysis R900
        [Category("TestingConsumption")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_25603_R900_Customer_Inquiry_Consumption_Grid_Daily_Consumption_Analysis()
        {
            testCaseId = "TC-25603";
            qTestUniqueId = "53774837";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                query = testData["PostgreSQLQuery"];
                meterID = testData["MeterId"];
                home.NavigateToHome(url, userName, password);
                customerInquiry.ValidateSearchAccountByMUId(meterID);
                customerInquiry.DailyConsumptionR900(query);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }

        // <summary>
        /// Test Method to Customer_Inquiry_Consumption_Grid_Daily_Consumption_Analysis R450
        [Category("TestingConsumption")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_25604_R450_Customer_Inquiry_Consumption_Grid_Daily_Consumption_Analysis()
        {
            testCaseId = "TC-25604";
            qTestUniqueId = "53774838";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                query = testData["PostgreSQLQuery"];
                meterID = testData["MeterId"];
                home.NavigateToHome(url, userName, password);
                customerInquiry.ValidateSearchAccountByMUId(meterID);
                customerInquiry.DailyConsumptionR450(query);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }


        // <summary>
        /// Test Method to Customer_Inquiry_Consumption_Grid_Daily_Consumption_Analysis CMIU-Type
        [Category("TestingConsumption")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_25605_CMIUType_Customer_Inquiry_Consumption_Grid_Daily_Consumption_Analysis()
        {
            testCaseId = "TC-25605";
            qTestUniqueId = "53774863";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                query = testData["PostgreSQLQuery"];
                meterID = testData["MeterId"];
                home.NavigateToHome(url, userName, password);
                customerInquiry.ValidateSearchAccountByMUId(meterID);
                customerInquiry.DailyConsumptionCMIUType(query);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }



    }

}