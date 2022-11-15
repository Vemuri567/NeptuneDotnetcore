using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using Neptune360UIAutomation.Pages;
using System.IO;
using Neptune360UIAutomation.APIPoc;
using System.Collections;
using System.IO.Compression;
using System.Threading;

namespace Neptune360UIAutomation
{
    public class TestBaseTemplate
    {
        #region Read Config variables
        public string testReportName = Utilities.ReadConfigFile("TestReportName");
        public string testDataFile = Utilities.ReadConfigFile("TestDataFile");
        public static string testDataFile1 = Utilities.ReadConfigFile("TestDataFile");
        public string testDataSheet = Utilities.ReadConfigFile("TestDataSheet");
        public static string testDataSheet1 = "API";
        public string qTestFlag = Utilities.ReadConfigFile("qTestFlag");
        public static string isAPI = Utilities.ReadConfigFile("IsAPI");
        public static string jsonfile = Utilities.ReadConfigFile("JSONPath");
        #endregion

        #region Initialize Global variables
        public static IWebDriver driver = null;
        public static bool initReport = false;
        public string currentExcelDirectoryPath = AppDomain.CurrentDomain.BaseDirectory.ToString();
        public string currentDirectoryPath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "");
        public static string currentDirectoryPath1 = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "");
        public DateTime startDate = DateTime.Now;
        public string testCaseId = "", qTestUniqueId = "", url = "", userName = "", password = "", firstName = "", lastName = "", email = "", roleOption = "", utilityName = "", utility_Name = "", siteID = "", code = "", importFile = "", zip = "", city = "", meterID = "", miuId = "", accountNo = "", customerName = "", address = "", meterClass = "", meterSize = "", meterManufacturer = "", meterInstallDate = "", uom = "", registerType = "", noOfDials = "", registerIntallDate = "", collectorID = "", collectorName = "", hostIP = "",
            bundleName = "", partnerName = "", type2query = "", type3query = "", type1query = "", type5query = "", type6query = "", consumptionQuery = "", query = "", BaseURL = "", XAPIKey = "", APIClient = "", ClientSecret = "", endpointtokenUrl = "", endpointurl = "", jsonfilename = "", baseQaUrl = "", payload = "";
        #endregion

        #region Page Objects
        public HomePage home = null;
        public UserManagementPage userManagement = null;
        public UtilityManagementPage utilityManagement = null;
        public RolesPermissonsPage rolesPermissons = null;
        public CustomerInquiryPage customerInquiry = null;
        public BillingServicesImportPage billingServicesImport = null;
        public BillingServicesExportPage billingServicesExport = null;
        public BillingServicesSettingsPage billingServicesSettings = null;
        public FileMapperPage fileMapper = null;
        public NotificationPage notification = null;
        public BillingServicesExportHistoryPage exportHistoryPage = null;
        public NavigationsPage navigations = null;
        public RouteManagementPage routeManagement = null;
        public DashboardPage dashBoard = null;
        public RolesAndPermissionsOnOffPage rolesAndPermissionsOnOff = null;
        public LandingPagePage landing = null;
        public GroupsPage groupsPage = null;
        public DeviceManagementPage deviceManagementPage = null;
        public HandheldManagementPage handheldManagementPage = null;
        public ReportsPage reportsPage = null;
        public AlertConfigurationPage alertConfigurationPage = null;
        public APIDeploymentPage apiDeploymentPage = null;
        public PartnerManagementPage partnerManagementPage = null;
        public LoginScreenPage loginScreenPage = null;
        public OnlineHelpPage onlineHelp = null;
        public UsagePlanPage usagePlan = null;
        public R450ConsumptionPage r450consumption = null;
        #endregion

        [OneTimeSetUp]
        protected void Setup()
        {
                if (qTestFlag.ToUpper() == "N" && initReport != true)
                {
                    ReporterFactory.AttachReport();
                    initReport = true;
                } 
            try
            {
                Console.WriteLine("testcase started");
                string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "") + "Results");
                foreach (string file in files)
                {
                    Console.WriteLine("testcase started");
                    if (file.Contains(".zip") || file.Contains(".html"))
                    {
                        File.Delete(file);
                    }
                }
            }
            catch (Exception ex)
            { }
        }

        [OneTimeTearDown]
        protected void TearDown()
        {
            try
            {
                if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "") + "Results\\" + ReporterFactory.currentDateAndTime))
                {
                    string reportPath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "") + "Results\\" + ReporterFactory.currentDateAndTime + "\\index.html";
                    string copiedReportPath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "") + "Results\\index.html";
                    string updatedReportPath = copiedReportPath.Replace("index", "TestReport" + ReporterFactory.currentDateAndTime.Replace("TestResults", ""));
                    // System.IO.File.Move(AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "Results\\" + ReporterFactory.currentDateAndTime+"\\index.html", AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "Results\\" + ReporterFactory.currentDateAndTime + "\\TestReport.html");
                    File.Copy(reportPath, copiedReportPath, true);

                    long reportSize = new FileInfo(reportPath).Length;
                    long copiedReportSize = 0;
                    long updatedReportSize = 0;
                    DateTime eta = DateTime.Now.AddSeconds(60);
                    while (eta > DateTime.Now)
                    {
                        try
                        {
                            copiedReportSize = new FileInfo(copiedReportPath).Length;
                            if (reportSize.Equals(copiedReportSize))
                            {
                                break;
                            }
                            else
                            {

                            }
                        }
                        catch (Exception ex)
                        { }
                    }

                    Thread.Sleep(1000);
                    File.Move(copiedReportPath, updatedReportPath);

                    eta = DateTime.Now.AddSeconds(60);
                    while (eta > DateTime.Now)
                    {
                        try
                        {
                            updatedReportSize = new FileInfo(updatedReportPath).Length;
                            if (reportSize.Equals(updatedReportSize))
                            {
                                break;
                            }
                            else
                            {

                            }
                        }
                        catch (Exception ex)
                        { }
                    }
                    //Thread.Sleep(3000);
                    //ZipFile.CreateFromDirectory(AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "Results\\" + ReporterFactory.currentDateAndTime, AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "Results\\" + ReporterFactory.currentDateAndTime + ".zip");
                }
            }
            catch (Exception ex)
            { }
        }

        [SetUp]
        public void BeforeTest()
        {
            if (qTestFlag.ToUpper() == "Y")
                ReporterFactory.AttachReport();
            ReporterFactory.InitTestCase(TestContext.CurrentContext.Test.Name);
            BeforeAllTestsExecution();
            home = new HomePage();
            userManagement = new UserManagementPage();
            utilityManagement = new UtilityManagementPage();
            rolesPermissons = new RolesPermissonsPage();
            customerInquiry = new CustomerInquiryPage();
            billingServicesImport = new BillingServicesImportPage();
            billingServicesExport = new BillingServicesExportPage();
            billingServicesSettings = new BillingServicesSettingsPage();
            fileMapper = new FileMapperPage();
            notification = new NotificationPage();
            exportHistoryPage = new BillingServicesExportHistoryPage();
            navigations = new NavigationsPage();
            routeManagement = new RouteManagementPage();
            dashBoard = new DashboardPage();
            rolesAndPermissionsOnOff = new RolesAndPermissionsOnOffPage();
            landing = new LandingPagePage();
            groupsPage = new GroupsPage();
            deviceManagementPage = new DeviceManagementPage();
            handheldManagementPage = new HandheldManagementPage();
            reportsPage = new ReportsPage();
            alertConfigurationPage = new AlertConfigurationPage();
            apiDeploymentPage = new APIDeploymentPage();
            partnerManagementPage = new PartnerManagementPage();
            loginScreenPage = new LoginScreenPage();
            onlineHelp = new OnlineHelpPage();
            usagePlan = new UsagePlanPage();
            r450consumption = new R450ConsumptionPage();

        }

        [TearDown]
        public void AfterTest()
        {
            AfterAllTestsExecution();
        }

        /// <summary>
        /// Get Webdriver Instance
        /// </summary>
        public static void BeforeAllTestsExecution()
        {
            //Console.WriteLine(String.Format("Current Directory - {0}", System.IO.Directory.GetCurrentDirectory()));
            if (isAPI.ToUpper() != "Y")
            {
                driver = WebDriverFactory.getWebDriver(EngineSetup.BROWSER);
            }
            //Console.WriteLine("title " + driver.Title);
        }

        public static void AfterAllTestsExecution()
        {
            if (Utilities.ReadConfigFile("R450DBTesting") == "YES")
            {
                return;
            }
            if (isAPI.ToUpper() != "Y")
            {
                //after execution, update extent report with gallop logo 
                /*driver can not be initialized in static method as driver is instance variable*/
                if (driver is InternetExplorerDriver)
                {
                    driver.Quit();
                }
                else
                {
                    driver.Close();
                    driver.Quit();
                }
            }
            WebDriverFactory.Free();
            //EngineSetup.TestReport.Close();
            //TestBaseTemplate.UpdateTestReport();
        }

        public string Jsonfile(string jsonfileName)
        {
            bool flag = false;
            var currentPath = currentDirectoryPath.IndexOf("bin");
            var path = currentDirectoryPath.Replace(currentDirectoryPath.Substring(currentPath - 1, (currentDirectoryPath.Length - currentPath)), "");
            string jsonpath = path + jsonfile;
            if (File.Exists(jsonpath + jsonfileName))
            {
                flag = true;
                jsonpath = jsonpath + jsonfileName;
            }
            return jsonpath;
        }

        public static IEnumerable DataSourcAPIData
        {
            get { return ExcelReader.ReadXlsxDataDriveFile(currentDirectoryPath1 + testDataFile1, "API", new[] { "TCId", "QTestId", "Execution" }, "APIValidation"); }
        }

        /// <summary>
        /// To get cell values from excel by passing row value 
        /// </summary>
        /// <param name="testCaseId"></param>
        /// <returns></returns>
        public Dictionary<string, string> TestDataFromExcel(string testCaseId)
        {
            string rowValue = "", colName = "";
            DataTable dt = new DataTable();
            var dictionary = new Dictionary<string, string>();

            dt = ExcelReader.ReadExcelUsingNPOI(Path.Combine(currentExcelDirectoryPath, testDataFile), testDataSheet);
            int indexVal = dt.AsEnumerable().Select(row => row.Field<string>("TCId") == testCaseId).ToList().FindIndex(col => col);

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (dt.Columns[i].ToString() == "")
                    continue;
                rowValue = dt.Rows[indexVal][i].ToString();
                colName = dt.Columns[i].ToString();
                dictionary.Add(colName, rowValue);
            }

            return dictionary;
        }

        /// <summary>
        /// To get cell values from excel by passing row value 
        /// </summary>
        /// <param name="testCaseId"></param>
        /// <returns></returns>
        public Dictionary<string, string> TestDataFromExcel(string testDataFile, string testDataSheet, string testCaseId)
        {
            string rowValue = "", colName = "";
            DataTable dt = new DataTable();
            var dictionary = new Dictionary<string, string>();

            dt = ExcelReader.ReadExcelUsingNPOI(currentDirectoryPath + testDataFile, testDataSheet);
            int indexVal = dt.AsEnumerable().Select(row => row.Field<string>("TCId") == testCaseId).ToList().FindIndex(col => col);

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (dt.Columns[i].ToString() == "")
                    continue;
                rowValue = dt.Rows[indexVal][i].ToString();
                colName = dt.Columns[i].ToString();
                dictionary.Add(colName, rowValue);
            }

            return dictionary;
        }

        public void SetAPIData(string testCaseId)
        {
            Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
            BaseURL = testData["BaseURL"];
            XAPIKey = testData["XAPIKey"];
            APIClient = testData["APIClient"];
            ClientSecret = testData["ClientSecret"];
            endpointtokenUrl = testData["EndpointTokenURL"];
            baseQaUrl = testData["BaseQAURL"];
            endpointurl = testData["EndpointURL"];
        }

        /// <summary>
        /// To get cell value from excel by passing row value and column name
        /// </summary>
        /// <param name="testCaseId"></param>
        /// <param name="ColumnName"></param>
        /// <returns></returns>
        public string CellValueFromExcel(string testCaseId, string columnName)
        {
            DataTable dt = new DataTable();
            dt = ExcelReader.ReadExcelFile(testDataFile, testDataSheet);

            int indexVal = dt.AsEnumerable().Select(row => row.Field<string>("TCId") == testCaseId).ToList().FindIndex(col => col);
            string value = dt.Rows[indexVal][columnName].ToString();

            return value;
        }


        /*public List<Datacollection> APITestData()
        {
            ExcelHelper.PopulateInCollection(currentDirectoryPath + testDataFile);
            List<Datacollection> ls =ExcelHelper._dataCol;
            return ls;
            
        }*/



    }
}
