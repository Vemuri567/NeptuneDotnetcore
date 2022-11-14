using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public class PartnerManagement : TestBaseTemplate
    {

        /// <summary>
        /// Test Method to Partner Management_Page Title_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16330_Partner_Management_Page_Title_Display()
        {
            testCaseId = "TC-16330";
            qTestUniqueId = "35431924";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateTitleDisplay();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Breadcrumbs_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16331_Partner_Management_Breadcrumbs_Display()
        {
            testCaseId = "TC-16331";
            qTestUniqueId = "35431927";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateBreadCrumbBarDisplay();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Button_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16332_Partner_Management_Create_Button_Display()
        {
            testCaseId = "TC-16332";
            qTestUniqueId = "35431929";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreateButton();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Button_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16333_Partner_Management_Delete_Button_Display()
        {
            testCaseId = "TC-16333";
            qTestUniqueId = "35431930";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateDeleteButton();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Button_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16334_Partner_Management_Edit_Button_Display()
        {
            testCaseId = "TC-16334";
            qTestUniqueId = "35431931";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditButton();
                home.UserLogOut();
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
        /// Test Method to Partner Management_List of Partners_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16335_Partner_Management_List_Of_Partners_Display()
        {
            testCaseId = "TC-16335";
            qTestUniqueId = "35431932";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidatePartnersList();
                home.UserLogOut();
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
        /// Test Method to Partner Management_List of Partners_Unique name
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16336_Partner_Management_List_Of_Partners_Unique_Name()
        {
            testCaseId = "TC-16336";
            qTestUniqueId = "35431933";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateUniquePartnerName();
                home.UserLogOut();
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
        /// Test Method to Partner Management_List of Partners_Selection
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16337_Partner_Management_List_of_Partners_Selection()
        {
            testCaseId = "TC-16337";
            qTestUniqueId = "35431934";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateListOfPartnersName();
                home.UserLogOut();
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
        /// Test Method to Partner Management_List of Partners_Default Selection
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16338_Partner_Management_List_of_Partners_Default_Selection()
        {
            testCaseId = "TC-16338";
            qTestUniqueId = "35431935";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateListOfPartnersName();
                home.UserLogOut();
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
        /// Test Method to Partner Management_List of Partners_Search Text box_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16339_Partner_Management_List_of_Partners_Search_Text_box_Display()
        {
            testCaseId = "TC-16339";
            qTestUniqueId = "35431936";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateSearchBox();
                home.UserLogOut();
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
        /// Test Method to Partner Management_List of Partners_Search_Full Term
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16340_Partner_Management_List_Of_Partners_Search_Full_Term()
        {
            testCaseId = "TC-16340";
            qTestUniqueId = "35431937";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateFullName(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_List of Partners_Partner Selected_Details Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16341_Partner_Management_List_Of_Partners_Partner_Selected_Details_Display()
        {
            testCaseId = "TC-16341";
            qTestUniqueId = "35431940";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName= testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidatePartnerDetails(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_List of Partners_Partner Selected_Table Details_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16342_Partner_Management_List_Of_Partners_Partner_Selected_Table_Details_Display()
        {
            testCaseId = "TC-16342";
            qTestUniqueId = "35431941";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidatePartnerTableDetails();
                home.UserLogOut();
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
        /// Test Method to Partner Management_List of Partners_Search_Partial Term
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16343_Partner_Management_List_Of_Partners_Search_Partial_Term()
        {
            testCaseId = "TC-16343";
            qTestUniqueId = "35431943";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateFullName(partnerName);
                home.UserLogOut();
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
        /// Test Method toPartner Management_List of Partners_Partner Selected_Table_Client ID_Show Icon
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16448_Partner_Management_List_of_Partners_Partner_Selected_Table_Client_ID_Show_Icon()
        {
            testCaseId = "TC-16448";
            qTestUniqueId = "35470350";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateSecretToggle();
                home.UserLogOut();
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
        /// Test Method to Partner Management_List of Partners_Partner Selected_Table_Client ID_Show Icon_Click
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16449_Partner_Management_List_of_Partners_Partner_Selected_Table_Client_ID_Show_Icon_Click()
        {
            testCaseId = "TC-16449";
            qTestUniqueId = "35470352";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateClientIDDisplayed();
                home.UserLogOut();
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
        /// Test Method to Partner Management_List of Partners_Partner Selected_Table_Max 10 utilities_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16450_Partner_Management_List_of_Partners_Partner_Selected_Table_Max_10_utilities_Display()
        {
            testCaseId = "TC-16450";
            qTestUniqueId = "35470354";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateUtilitiesList();
                home.UserLogOut();
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
        /// Test Method to Partner Management_List of Partners_Partner Selected_Table_More than 10 Utilities_Pagination_Next
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16451_Partner_Management_List_of_Partners_Partner_Selected_Table_More_than_10_Utilities_Pagination_Next()
        {
            testCaseId = "TC-16451";
            qTestUniqueId = "35470355";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidatePaginationNext(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_List of Partners_Partner Selected_Table_More than 10 Utilities_Pagination_Previous
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16452_Partner_Management_List_of_Partners_Partner_Selected_Table_More_than_10_Utilities_Pagination_Previous()
        {
            testCaseId = "TC-16452";
            qTestUniqueId = "35470356";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidatePaginationPrevios(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_List of Partners_Partner Selected_Table_More than 10 Utilities_Pagination Details_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16453_Partner_Management_List_of_Partners_Partner_Selected_Table_More_than_10_Utilities_Pagination_Details_Display()
        {
            testCaseId = "TC-16453";
            qTestUniqueId = "35470359";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = "AutomationTesting10";
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidatePaginationDetails(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Button_Click
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16464_Partner_Management_Create_Button_Click()
        {
            testCaseId = "TC-16464";
            qTestUniqueId = "35509554";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreatePartnerPage();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Contents behind Dialog_Grayed-out
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16465_Partner_Management_Create_New_Partner_Contents_behind_Dialog_Grayed_out()
        {
            testCaseId = "TC-16465";
            qTestUniqueId = "35509555";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreatePartnerPage();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_No site IDs_Display By Default
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16466_Partner_Management_Create_New_Partner_No_site_IDs_Display_By_Default()
        {
            testCaseId = "TC-16466";
            qTestUniqueId = "35509557";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateSiteIDNotPresent();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Partner Name_Editable
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16467_Partner_Management_Create_New_Partner_Partner_Name_Editable()
        {
            testCaseId = "TC-16467";
            qTestUniqueId = "35509576";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidatePartnerNameSearchBox();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Partner Name_Required Field
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16468_Partner_Management_Create_New_Partner_Partner_Name_Required_Field()
        {
            testCaseId = "TC-16468";
            qTestUniqueId = "35509626";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidatePartnerNameRequired();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Cancel Button_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16469_Partner_Management_Create_New_Partner_Cancel_Button_Display()
        {
            testCaseId = "TC-16469";
            qTestUniqueId = "35509627";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCancelPartner();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Partner_Dialog_Create_Button
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16470_Partner_Management_Create_Partner_Dialog_Create_Button()
        {
            testCaseId = "TC-16470";
            qTestUniqueId = "35509629";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreatePartnerCreateButton();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Partner_Dialog_X_Button
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16471_Partner_Management_Create_Partner_Dialog_X_Button()
        {
            testCaseId = "TC-16471";
            qTestUniqueId = "35509630";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreateXButton();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Contact Email_Editable
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16472_Partner_Management_Create_New_Partner_Contact_Email_Editable()
        {
            testCaseId = "TC-16472";
            qTestUniqueId = "35509632";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEmailEditable();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Contact Phone_Editable
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16473_Partner_Management_Create_New_Partner_Contact_Phone_Editable()
        {
            testCaseId = "TC-16473";
            qTestUniqueId = "35509633";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidatePhoneEditable();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Address_Editable
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16474_Partner_Management_Create_New_Partner_Address_Editable()
        {
            testCaseId = "TC-16474";
            qTestUniqueId = "35509634";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateAddressEditable();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_City_Editable
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16475_Partner_Management_Create_New_Partner_City_Editable()
        {
            testCaseId = "TC-16475";
            qTestUniqueId = "35509636";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCityEditable();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_State_Editable
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16476_Partner_Management_Create_New_Partner_State_Editable()
        {
            testCaseId = "TC-16476";
            qTestUniqueId = "35509637";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateStateEditable();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Zip Code_Editable
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16477_Partner_Management_Create_New_Partner_Zip_Code_Editable()
        {
            testCaseId = "TC-16477";
            qTestUniqueId = "35509639";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateZipEditable();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Search Utilities Field_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16478_Partner_Management_Create_New_Partner_Search_Utilities_Field_Display()
        {
            testCaseId = "TC-16478";
            qTestUniqueId = "35509640";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidatePartnerNameSearchBox();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Search Utilities Field_Utility Name_Search
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16479_Partner_Management_Create_New_Partner_Search_Utilities_Field_Utility_Name_Search()
        {
            testCaseId = "TC-16479";
            qTestUniqueId = "35509642";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateSearchPartnerName(utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Search Utilities Field_Utility Selection
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16481_Partner_Management_Create_New_Partner_Search_Utilities_Field_Utility_Selection()
        {
            testCaseId = "TC-16481";
            qTestUniqueId = "35509645";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateSearchPartnerUtilitySelection(utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Assigned Utilities_Close X Icon_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16482_Partner_Management_Create_New_Partner_Assigned_Utilities_Close_X_Icon_Display()
        {
            testCaseId = "TC-16482";
            qTestUniqueId = "35509647";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreatePartnerXIcon(utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Assigned Utilities_Close X Icon_Click
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16483_Partner_Management_Create_New_Partner_Assigned_Utilities_Close_X_Icon_Click()
        {
            testCaseId = "TC-16483";
            qTestUniqueId = "35509648";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreatePartnerXIconClick(utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Assigned Utilities Section_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16484_Partner_Management_Create_New_Partner_Assigned_Utilities_Section_Display()
        {
            testCaseId = "TC-16484";
            qTestUniqueId = "35509650";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreatePartnerUtilitySection(utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Assigned Utilities Section_Columns_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16485_Partner_Management_Create_New_Partner_Assigned_Utilities_Section_Columns_Display()
        {
            testCaseId = "TC-16485";
            qTestUniqueId = "35509652";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreatePartnerUtilityColumn(utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Assigned Utilities Section_Bundle_Update
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16486_Partner_Management_Create_New_Partner_Assigned_Utilities_Section_Bundle_Update()
        {
            testCaseId = "TC-16486";
            qTestUniqueId = "35509654";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreatePartnerBundleUpdate(utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Site ID Not Selected_Error Message Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16489_Partner_Management_Create_New_Partner_Site_ID_Not_Selected_Error_Message_Display()
        {
            testCaseId = "TC-16489";
            qTestUniqueId = "35510145";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreatePartnerSiteIdNotSelected(utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Cancel button_Click
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16490_Partner_Management_Create_New_Partner_Cancel_button_Click()
        {
            testCaseId = "TC-16490";
            qTestUniqueId = "35518104";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCancelPartner();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Close X button_Click
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16491_Partner_Management_Create_New_Partner_Close_X_button_Click()
        {
            testCaseId = "TC-16491";
            qTestUniqueId = "35518105";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreateXButton();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Create button_Click
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16492_Partner_Management_Create_New_Partner_Create_button_Click()
        {
            testCaseId = "TC-16492";
            qTestUniqueId = "35518107";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreateNewPartner(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Create Button_Confirmation Toast Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16493_Partner_Management_Create_New_Partner_Create_Button_Confirmation_Toast_Display()
        {
            testCaseId = "TC-16493";
            qTestUniqueId = "35518108";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreateNewPartner(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Create button_Screen Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16494_Partner_Management_Create_New_Partner_Create_Button_Screen_Display()
        {
            testCaseId = "TC-16494";
            qTestUniqueId = "35518111";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreateNewPartnerPartnerManagementPage(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Display Order
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16495_Partner_Management_Create_New_Partner_Display_Order()
        {
            testCaseId = "TC-16495";
            qTestUniqueId = "35518112";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = EngineSetup.GetRandomString();
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreateNewPartnerDisplayOrder(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Button_Click
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16496_Partner_Management_Edit_Button_Click()
        {
            testCaseId = "TC-16496";
            qTestUniqueId = "35518114";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartner(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Cancel Button_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16497_Partner_Management_Edit_Partner_Cancel_Button_Display()
        {
            testCaseId = "TC-16497";
            qTestUniqueId = "35518115";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerCancelButton(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Dialog_Save_Button
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16498_Partner_Management_Edit_Partner_Dialog_Save_Button()
        {
            testCaseId = "TC-16498";
            qTestUniqueId = "35518116";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerSaveButton(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Dialog_X_Button
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16499_Partner_Management_Edit_Partner_Dialog_X_Button()
        {
            testCaseId = "TC-16499";
            qTestUniqueId = "35518118";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerXButton(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Contact Email_Editable
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16501_Partner_Management_Edit_Partner_Contact_Email_Editable()
        {
            testCaseId = "TC-16501";
            qTestUniqueId = "35518123";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerEmail(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Contact Phone_Editable
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16502_Partner_Management_Edit_Partner_Contact_Phone_Editable()
        {
            testCaseId = "TC-16502";
            qTestUniqueId = "35518125";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerPhone(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Contact Address_Editable
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16503_Partner_Management_Edit_Partner_Contact_Address_Editable()
        {
            testCaseId = "TC-16503";
            qTestUniqueId = "35518128";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerAddress(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Contact City_Editable
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16504_Partner_Management_Edit_Partner_Contact_City_Editable()
        {
            testCaseId = "TC-16504";
            qTestUniqueId = "35518131";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerCity(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Contact State Editable
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16505_Partner_Management_Edit_Partner_Contact_State_Editable()
        {
            testCaseId = "TC-16505";
            qTestUniqueId = "35518132";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerState(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Contact Zip Editable
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16506_Partner_Management_Edit_Partner_Contact_Zip_Editable()
        {
            testCaseId = "TC-16506";
            qTestUniqueId = "35518134";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerZip(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Assigned Utilities_Close X Icon_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16507_Partner_Management_Edit_Partner_Assigned_Utilities_Close_X_Icon_Display()
        {
            testCaseId = "TC-16507";
            qTestUniqueId = "35518137";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerXIcon(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Assigned Utilities_Close X Icon_Click
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16508_Partner_Management_Edit_Partner_Assigned_Utilities_Close_X_Icon_Click()
        {
            testCaseId = "TC-16508";
            qTestUniqueId = "35518138";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerXIconClick(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Assigned Utilities Section_Bundle_Update
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16509_Partner_Management_Edit_Partner_Assigned_Utilities_Section_Bundle_Update()
        {
            testCaseId = "TC-16509";
            qTestUniqueId = "35518145";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerBundleUpdate(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Save button_Click
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16511_Partner_Management_Edit_Partner_Save_button_Click()
        {
            testCaseId = "TC-16511";
            qTestUniqueId = "35518147";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerSave(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Save Button_Confirmation Toast Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16512_Partner_Management_Edit_Partner_Save_Button_Confirmation_Toast_Display()
        {
            testCaseId = "TC-16512";
            qTestUniqueId = "35518148";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerSave(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Save button_Screen Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16513_Partner_Management_Edit_Partner_Save_button_Screen_Display()
        {
            testCaseId = "TC-16513";
            qTestUniqueId = "35518150";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerSavePartnerScreen(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Existing Partner Name_Error Message Validation
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16515_Partner_Management_Create_New_Partner_Existing_Partner_Name_Error_Message_Validation()
        {
            testCaseId = "TC-16515";
            qTestUniqueId = "35518603";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateExistingPartnerErrorMessage(partnerName,utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Delete Button_Click_Dialog Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16517_Partner_Management_Delete_Button_Click_Dialog_Display()
        {
            testCaseId = "TC-16517";
            qTestUniqueId = "35518985";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateDeletePartner(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Delete Button_Delete Partner Dialog_Contents
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16518_Partner_Management_Delete_Button_Delete_Partner_Dialog_Contents()
        {
            testCaseId = "TC-16518";
            qTestUniqueId = "35518986";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateDeletePartnerContents(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Delete Button_Delete Partner Dialog_Cancel Button_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16519_Partner_Management_Delete_Button_Delete_Partner_Dialog_Cancel_Button_Display()
        {
            testCaseId = "TC-16519";
            qTestUniqueId = "35518987";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateDeletePartnerCancel(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Delete Button_Delete Partner Dialog_Delete Button_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16520_Partner_Management_Delete_Button_Delete_Partner_Dialog_Delete_Button_Display()
        {
            testCaseId = "TC-16520";
            qTestUniqueId = "35518989";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateDeletePartnerDeleteButton(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Delete Button_Delete Partner Dialog_Close  Button_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16521_Partner_Management_Delete_Button_Delete_Partner_Dialog_Close_Button_Display()
        {
            testCaseId = "TC-16521";
            qTestUniqueId = "35518990";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateDeletePartnerXIcon(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Delete Button_Delete Partner Dialog_Cancel Button_Click
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16522_Partner_Management_Delete_Button_Delete_Partner_Dialog_Cancel_Button_Click()
        {
            testCaseId = "TC-16522";
            qTestUniqueId = "35518991";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateDeletePartnerCancel(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Delete Button_Delete Partner Dialog_Close Button_Click
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16523_Partner_Management_Delete_Button_Delete_Partner_Dialog_Close_Button_Click()
        {
            testCaseId = "TC-16523";
            qTestUniqueId = "35518992";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateDeletePartnerXIconClick(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Delete Button_Delete Partner Dialog_Delete Button_Click
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16524_Partner_Management_Delete_Button_Delete_Partner_Dialog_Delete_Button_Click()
        {
            testCaseId = "TC-16524";
            qTestUniqueId = "35518994";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateDeletePartnerDeleteButtonClick(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Delete Button_Delete Partner Dialog_Delete Button_Click_Screen Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16525_Partner_Management_Delete_Button_Delete_Partner_Dialog_Delete_Button_Click_Screen_Display()
        {
            testCaseId = "TC-16525";
            qTestUniqueId = "35518995";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateDeletePartnerDeleteButtonPartnerScreen(partnerName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_New Partner_Same Site ID_Multiple Links_Different Bundle
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16528_Partner_Management_New_Partner_Same_Site_ID_Multiple_Links_Different_Bundle()
        {
            testCaseId = "TC-16528";
            qTestUniqueId = "35555223";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreatePartnerDifferentBundle(partnerName,utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_New Partner_Same Site ID_Cannot Link_More than once
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16529_Partner_Management_New_Partner_Same_Site_ID_Cannot_Link_More_than_once()
        {
            testCaseId = "TC-16529";
            qTestUniqueId = "35555224";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreatePartnerSameBundle(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Same Site ID_Multiple Links_Different Bundle
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16530_Partner_Management_Edit_Partner_Same_Site_ID_Multiple_Links_Different_Bundle()
        {
            testCaseId = "TC-16530";
            qTestUniqueId = "35555249";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerSameSiteDifferentBundle(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Same Site ID_Cannot Link_More than once
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16531_Partner_Management_Edit_Partner_Same_Site_ID_Cannot_Link_More_than_once()
        {
            testCaseId = "TC-16531";
            qTestUniqueId = "35555250";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditPartnerSameSiteSameBundle(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_List of Partners_Partner Selected_Partner Details_API Key_Value Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16917_Partner_Management_List_of_Partners_Partner_Selected_Partner_Details_API_Key_Value_Display()
        {
            testCaseId = "TC-16917";
            qTestUniqueId = "36029136";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateAPIKeyDisplayed();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Pair Utility with More than One Bundle_Error Message Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16969_Partner_Management_Create_New_Partner_Pair_Utility_with_More_than_One_Bundle_Error_Message_Display()
        {
            testCaseId = "TC-16969";
            qTestUniqueId = "36231571";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreatePartnerMoreThanOneBundle(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Partner Type Drop down_Disabled
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16970_Partner_Management_Edit_Partner_Partner_Type_Drop_down_Disabled()
        {
            testCaseId = "TC-16970";
            qTestUniqueId = "36232621";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                //partnerName = testData["PartnerName"];
                //utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidatePartnerDropdownDisabled();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Partner_Partner Type_Utility_Address_Not Displayed
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16971_Partner_Management_Create_Partner_Partner_Type_Utility_Address_Not_Displayed()
        {
            testCaseId = "TC-16971";
            qTestUniqueId = "36232624";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                //partnerName = testData["PartnerName"];
                //utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateAddressBarDisabled();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Partner_Partner Type_Utility_City_Not Displayed
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16972_Partner_Management_Create_Partner_Partner_Type_Utility_City_Not_Displayed()
        {
            testCaseId = "TC-16972";
            qTestUniqueId = "36232627";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                //partnerName = testData["PartnerName"];
                //utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCityBarDisabled();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Partner_Partner Type_Utility_State_Not Displayed
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16973_Partner_Management_Create_Partner_Partner_Type_Utility_State_Not_Displayed()
        {
            testCaseId = "TC-16973";
            qTestUniqueId = "36232628";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                //partnerName = testData["PartnerName"];
                //utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateStateBarDisabled();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Partner_Partner Type_Utility_Zip_Not Displayed
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16974_Partner_Management_Create_Partner_Partner_Type_Utility_Zip_Not_Displayed()
        {
            testCaseId = "TC-16974";
            qTestUniqueId = "36232639";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                //partnerName = testData["PartnerName"];
                //utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateZipBarDisabled();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Partner_Partner Type_3rd Party Vendor_Address_Displayed
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16975_Partner_Management_Create_Partner_Partner_Type_3rd_Party_Vendor_Address_Displayed()
        {
            testCaseId = "TC-16975";
            qTestUniqueId = "36232641";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                //partnerName = testData["PartnerName"];
                //utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateAddressBarDisplayed();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Partner_Partner Type_3rd Party Vendor_City_Displayed
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16976_Partner_Management_Create_Partner_Partner_Type_3rd_Party_Vendor_City_Displayed()
        {
            testCaseId = "TC-16976";
            qTestUniqueId = "36232643";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                //partnerName = testData["PartnerName"];
                //utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCityBarDisplayed();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Partner_Partner Type_3rd Party Vendor_Zip_Displayed
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16977_Partner_Management_Create_Partner_Partner_Type_3rd_Party_Vendor_Zip_Displayed()
        {
            testCaseId = "TC-16977";
            qTestUniqueId = "36232644";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                //partnerName = testData["PartnerName"];
                //utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateZipDisplayed();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Partner_Partner Type_3rd Party Vendor_State_Displayed
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16978_Partner_Management_Create_Partner_Partner_Type_3rd_Party_Vendor_State_Displayed()
        {
            testCaseId = "TC-16978";
            qTestUniqueId = "36232645";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                //partnerName = testData["PartnerName"];
                //utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateStateDisplayed();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Partner_Partner Type_Drop Down_Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16979_Partner_Management_Create_Partner_Partner_Type_Drop_Down_Display()
        {
            testCaseId = "TC-16979";
            qTestUniqueId = "36232646";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                //partnerName = testData["PartnerName"];
                //utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidatePartnerTypeDisplayed();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Partner_Partner Type_Drop Down_Options
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16980_Partner_Management_Create_Partner_Partner_Type_Drop_Down_Options()
        {
            testCaseId = "TC-16980";
            qTestUniqueId = "36232648";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                //partnerName = testData["PartnerName"];
                //utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidatePartnerTypeDropdownsDisplayed();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Partner_Partner Type_Drop Down_Options
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16981_Partner_Management_Create_Partner_Partner_Type_Drop_Down_Options()
        {
            testCaseId = "TC-16981";
            qTestUniqueId = "36232652";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                //partnerName = testData["PartnerName"];
                //utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateDefaultPartnerType();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Partner_Partner Type_Drop Down_3rd Party Vendor_Select
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16982_Partner_Management_Create_Partner_Partner_Type_Drop_Down_3rd_Party_Vendor_Select()
        {
            testCaseId = "TC-16982";
            qTestUniqueId = "36232710";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                //partnerName = testData["PartnerName"];
                //utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateThirdPartyVendorPartnerType();
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Partner_Partner Type_Drop Down_Utility_Create
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16983_Partner_Management_Create_Partner_Partner_Type_Drop_Down_Utility_Create()
        {
            testCaseId = "TC-16983";
            qTestUniqueId = "36232730";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreateNewPartner(partnerName,utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create Partner_Partner Type_Drop Down_3rd Party Vendor_Create
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16984_Partner_Management_Create_Partner_Partner_Type_Drop_Down_3rd_Party_Vendor_Create()
        {
            testCaseId = "TC-16984";
            qTestUniqueId = "36232737";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreatePartnerThirdPartyVendor(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Pair Utility with More than One Bundle_Error Message Display
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests3")]
        [Test]
        public void TC_16985_Partner_Management_Edit_Partner_Pair_Utility_with_More_than_One_Bundle_Error_Message_Display()
        {
            testCaseId = "TC-16985";
            qTestUniqueId = "36232794";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreatePartnerMoreThanOneBundle(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Assigned Utilities Section_Usage Plan_Auto Select
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_17174_Partner_Management_Create_New_Partner_Assigned_Utilities_Section_Usage_Plan_Auto_Select()
        {
            testCaseId = "TC-17174";
            qTestUniqueId = "36862443";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateSelectBundle(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Assigned Utilities Section_Usage Plan_Auto Select
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_17175_Partner_Management_Edit_Partner_Assigned_Utilities_Section_Usage_Plan_Auto_Select()
        {
            testCaseId = "TC-17175";
            qTestUniqueId = "36862447";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateDefaultUsagePlan(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Assigned Utilities Section_Usage Plan_Auto Select
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_17176_Partner_Management_Create_New_Partner_Assigned_Utilities_Section_Bundle_Option_Select()
        {
            testCaseId = "TC-17176";
            qTestUniqueId = "36862448";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateDefaultUsagePlan(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Assigned Utilities Section_Bundle_Option Select
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_17177_Partner_Management_Edit_Partner_Assigned_Utilities_Section_Bundle_Option_Select()
        {
            testCaseId = "TC-17177";
            qTestUniqueId = "36862449";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateSelectBundle(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Assigned Utilities Section_Bundle_Existing Bundle_Selection
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_17178_Partner_Management_Create_New_Partner_Assigned_Utilities_Section_Bundle_Existing_Bundle_Selection()
        {
            testCaseId = "TC-17178";
            qTestUniqueId = "36862607";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateSelectBundleWithExistingBundle(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Assigned Utilities Section_Bundle_Existing Bundle_Selection
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_17179_Partner_Management_Edit_Partner_Assigned_Utilities_Section_Bundle_Existing_Bundle_Selection()
        {
            testCaseId = "TC-17179";
            qTestUniqueId = "36862609";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditBundleWithExistingBundle(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Create New Partner_Partner Type_3rd Party Vendor_Same Bundle_Different Utility
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_17180_Partner_Management_Create_New_Partner_Partner_Type_3rd_Party_Vendor_Same_Bundle_Different_Utility()
        {
            testCaseId = "TC-17180";
            qTestUniqueId = "36862683";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateEditBundleWithExistingBundle(partnerName, utilityName);
                home.UserLogOut();
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
        /// Test Method to Partner Management_Edit Partner_Partner Type_3rd Party Vendor_Same Bundle_Different Utility
        /// </summary>
        [Category("PartnerManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_17181_Partner_Management_Edit_Partner_Partner_Type_3rd_Party_Vendor_Same_Bundle_Different_Utility()
        {
            testCaseId = "TC-17181";
            qTestUniqueId = "36862684";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                partnerName = testData["PartnerName"];
                utilityName = testData["UtilityName"];
                home.NavigateToLftPartnerManagement(url, userName, password);
                partnerManagementPage.ValidateCreatePartnerThirdPartyVendorSameBundle(partnerName, utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

    }
}
