using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RazorEngine.Compilation.ImpromptuInterface.Optimization;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Neptune360UIAutomation
{
    public class ReportsPage : AbstractTemplatePage
    {
        #region UI Object Repository 
        private By invalidReadings = By.XPath("//h1[contains(.,' Invalid Readings ')]");
        private By breadcrumb = By.XPath("//sd-toolbar/div/span/span");
        private By mach10Battery = By.XPath("//h1[contains(.,' Mach 10 Battery ')]");
        private By softDisconnect = By.XPath("//h1[contains(.,' Soft Disconnect ')]");
        private By comments = By.XPath("//h1[contains(.,' Comments ')]");
        private By tamperReport = By.XPath("//h1[contains(.,' Tamper Report ')]");
        private By foundMeters = By.XPath("//h1[contains(.,' Found Meters ')]");
        private By codedNotes = By.XPath("//h1[contains(.,' Coded Notes ')]");
        private By inactiveFlow = By.XPath("//h1[contains(.,' Inactive Flow ')]");
        private By daysOfNoFlowAMR = By.XPath("//h1[contains(.,' Days of No Flow (AMR) ')]");
        private By sortAscending = By.XPath("//kendo-popup//p[text()='Sort Ascending']");
        private By daysOfConsumption = By.XPath("//h1[contains(.,' Days of Consumption (AMR) ')]");
        private By consecDaysSortIcon = By.XPath("//th//p[text()='Consec Days']//..//span[@class='fa fa-sort-down']");
        private By daysOfConsFlowFlagBased = By.XPath("//h1[contains(.,' Days of Consecutive Flow (AMI) - Flag Based ')]");
        private By daysOfConsFlowConsmBasedHeader = By.XPath("//h3[contains(text(),'Days of Consecutive Flow (AMI) - Consumption Based')]");
        private By activeSimAssociatedHeader = By.XPath("//h3[contains(text(),'Active SIM Associated to Undefined Site')]");
        private By amiNoFlow = By.XPath("//h1[contains(.,' AMI No Flow ')]");
        private By highLowLimitFall = By.XPath("//h1[contains(.,' High Low Limit Fail ')]");
        private By endpointMaintanence = By.XPath("//h1[contains(.,' Endpoint Maintenance ')]");
        private By endpointConsumption = By.XPath("//h1[contains(.,' Endpoint Consumption ')]");
        private By groupCheckbox = By.XPath("//label[contains(.,'Group')]");
        private By hourlyCheckbox = By.XPath("//label[contains(.,'Hourly')]");
        private By miuCheckbox = By.XPath("//label[contains(.,'MIU')]");
        private By productivityReport = By.XPath("//h1[contains(.,' Productivity Report ')]");
        private By endpointContainer = By.XPath("//h1[contains(.,' Endpoint ')]");
        private By reverseFlow = By.XPath("//h1[contains(.,' Reverse Flow ')]");
        private By changedReadParameters = By.XPath("//h1[contains(.,' Changed Read Parameters ')]");
        private By changedReadParaSubtitle = By.XPath("//h3[contains(.,'Changed Read Parameters')]");
        private By activeSimNoSite = By.XPath("//h1[contains(.,' Active SIM With No Site ')]");
        private By activeSimUndefinedSite = By.XPath("//h1[contains(.,' Active SIM Associated ')]");
        private By highCosumption = By.XPath("//h1[contains(.,' High Consumption ')]");
        private By mach10Batteryhdr = By.XPath("//span[text()='Reports / Mach 10 Battery']");
        private By commentsPage = By.XPath("//span[text()='Reports / COMMENTS']");
        private By foundMetersPage = By.XPath("//span[text()='Reports / Found Meters']");
        private By codedNotesPage = By.XPath("//span[text()='Reports / Coded Notes']");
        private By mach10BatteryPage = By.XPath("//span[text()='Reports / Mach 10 Battery']");
        private By invalidReadingsReport = By.XPath("//h1[contains(.,' Invalid Readings ')]");
        private By daysOfNoFlowPage = By.XPath("//span[text()='Reports / Days of No Flow (AMR)']");
        private By daysOfConsumptionPage = By.XPath("//span[text()='Reports / Days of Consumption (AMR)']");
        private By reportDate = By.XPath("//p[contains(text(),'Report Date:')]");
        private By exportPDF = By.XPath("//p[contains(text(),' PDF')]");
        private By exportExcel = By.XPath("//p[contains(text(),' Excel')]");
        private By neverReceivedKPI = By.XPath("//sd-report-grid/div/div[2]//span[contains(.,'Never Received')]");
        private By invalidReadsKPI = By.XPath("//sd-report-grid/div/div[2]//span[contains(.,'Invalid Reads')]");
        private By pastDueKPI = By.XPath("//sd-report-grid/div/div[2]//span[contains(.,'Past Due')]");
        private By totalMiuKPI = By.XPath("//sd-report-grid/div/div[2]//span[contains(.,'Total MIUs')]");
        private By exportLink = By.XPath("//img[@alt='Exports']");
        private By dateColumnValues = By.XPath("//table[@class='k-grid-table']//tr//td[10]//span");

        private By backToReports = By.XPath("//sd-operationaldashboardreport/div/div[1]/div/a");
        private By daysOfNoFlow2ndRow = By.XPath("//h3[contains(text(),'Days of No Flow (AMR)')]");
        private By daysOfCosumption2ndRow = By.XPath("//h3[contains(text(),'Days of Consumption (AMR)')]");
        private By fromDate = By.XPath("//label[contains(text(),'From')]//..//span[@id='searchLink']");
        private By toDate = By.XPath("//label[contains(text(),'To')]//..//span[@id='searchLink']");
        private By mapView = By.XPath("//h3[contains(.,'Map')]");
        private By flowTypesIncluded = By.XPath("//span[contains(.,'Flow Types Included: ')]");
        private By drpDownFlowTypeIncluded = By.XPath("//typesofflowdropdown-picker/div/kendo-dropdownlist/span/span[1]");
        private By flagTypeContinous = By.XPath("//li[contains(.,'Continuous')]");
        private By flagTypeIntermittent = By.XPath("//li[contains(.,'Intermittent')]");

        private By lftNavGroups = By.XPath("//span[text()='GROUPS']");
        private By lftNavGroupManagement = By.XPath("//span[text()='GROUP MANAGEMENT']");
        private By lftNavSearchEndpoints = By.XPath("//span[text()='SEARCH ENDPOINTS']");

        private By miuID = By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[1]");
        private By premises = By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[2]");
        private By accName = By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[3]");
        private By address = By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[4]");
        private By accNo = By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[5]");
        private By initialEventDateTime = By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[6]");
        private By daysOfLowPower = By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[7]");
        private By registerID = By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[8]");
        private By rowflowType = By.XPath("//div/div[1]/table/tbody/tr[4]/td[9]");

        private By Col1 = By.XPath("//table//tr/th[1]/div/p");
        private By Col2 = By.XPath("//table//tr/th[2]/div/p");
        private By Col3 = By.XPath("//table//tr/th[3]/div/p");
        private By Col4 = By.XPath("//table//tr/th[4]/div/p");
        private By Col5 = By.XPath("//table//tr/th[5]/div/p");
        private By Col6 = By.XPath("//table//tr/th[6]/div/p");
        private By Col7 = By.XPath("//table//tr/th[7]/div/p");
        private By Col8 = By.XPath("//table//tr/th[8]/div/p");
        private By Col9 = By.XPath("//table//tr/th[9]/div/p");
        private By Col10 = By.XPath("//table//tr/th[10]/div/p");
        private By Col11 = By.XPath("//table//tr/th[11]/div/p");
        private By Col12 = By.XPath("//table//tr/th[12]/div/p");
        private By Col13 = By.XPath("//table//tr/th[13]/div/p");
        private By Col14 = By.XPath("//table//tr/th[14]/div/p");
        private By Col15 = By.XPath("//table//tr/th[15]/div/p");
        private By Col16 = By.XPath("//table//tr/th[16]/div/p");
        private By Col17 = By.XPath("//table//tr/th[17]/div/p");
        private By Col18 = By.XPath("//table//tr/th[18]/div/p");
        private By Col19 = By.XPath("//table//tr/th[19]/div/p");
        private By Col20 = By.XPath("//table//tr/th[20]/div/p");
        private By Col21 = By.XPath("//table//tr/th[21]/div/p");
        private By Col22 = By.XPath("//table//tr/th[22]/div/p");
        private By lftNavReports = By.XPath("//span[text()=' REPORTS']");
        private By include = By.XPath("//label[contains(text(),'Include')]");
        private By exclude = By.XPath("//label[contains(text(),'Exclude')]");
        private By specificField = By.XPath("//label[contains(.,'Changed Field: ')]");

        private By routeFilter = By.XPath("//sd-operationaldashboardreport//routesdropdown-picker/kendo-dropdownlist/span/span[1]");
        private By groupFilter = By.XPath("//groupsdropdown-picker/div/div/div[2]/kendo-dropdownlist/span");
        private By tamperTypeFilter = By.XPath("//tampertypesdropdown-picker/kendo-dropdownlist/span");
        private By datePicker = By.XPath("//div[2]/div/span/kendo-numerictextbox/span");
        private By mach10BatteryTable = By.XPath("//div[@id='mstr98']/table");
        private By gridLoader = By.XPath("//div[contains(@class,'report-grid-loader')]");
        private By scrollLoader = By.XPath("//div[@class='k-loading-image']");
        private By consecDaysColumnValues = By.XPath("//table[@class='k-grid-table']//tr//td[11]//span");
        private By meterInactiveSinceColValues = By.XPath("//table[@class='k-grid-table']//tr//td[8]//span");
        private By cycleRouteColumnValues = By.XPath("//table[@class='k-grid-table']//tr//td[1]//span");
        private By readSeqColumnValues = By.XPath("//table[@class='k-grid-table']//tr//td[2]//span");
        private By gridRowCount = By.XPath("//div[@class='k-grid-aria-root']");
        private By daysOfConsumptionAMRtable = By.XPath("/html/body/div[1]/div[2]/div/div[2]/div/div/div[2]/div[3]/div/div/div/div/div[7]/div[3]/table/tbody/tr/td/div/div[2]/div/table");
        private By daysOfNoFlowTable = By.XPath("//div/div/table/tbody[1]");
        public DataTable reportTable = new DataTable();

        private By daysofNoFlowTitle = By.XPath("//h3[contains(text(),'Days of No Flow (AMR)')]");
        private By amiTable = By.XPath("//kendo-grid-list/div/div[1]/table/tbody");
        private By days = By.XPath("//div[2]/span/kendo-dropdownlist/span/span");
        private By overAmount = By.XPath("//div[1]/span/kendo-dropdownlist/span/span");
        private By minThreshold = By.XPath("//div[3]/span/kendo-numerictextbox//input");
        private By inactiveMeters = By.XPath("//span[text()=' Inactive Meters']");

        private By codeValue1 = By.XPath("//td[contains(.,'1-2 days')]");
        private By codeValue2 = By.XPath("//td[contains(.,'3-7 days')]");
        private By codeValue3 = By.XPath("//td[contains(.,'8-14 days')]");
        private By codeValue4 = By.XPath("//td[contains(.,'15-21 days')]");
        private By codeValue5 = By.XPath("//td[contains(.,'22-34 days')]");
        private By codeValue6 = By.XPath("//td[contains(.,'35 days')]");
        private By codeValue0 = By.XPath("//td[contains(.,'0 days')]");
        private By codeValue7 = By.XPath("//td[contains(.,'error condition')]");
        private By avgDailyFlowPrior = By.XPath("//p[contains(.,'Avg Daily Flow (Prior)')]");
        private By flagDrpdown = By.XPath("//span/kendo-dropdownlist/span/span[1]");
        private By firstCellValue = By.XPath("//kendo-grid//tr[1]//td[1]//span");
        private By routeList = By.XPath("//kendo-list/div/ul/li");
        private By routeOne = By.XPath("//kendo-list/div/ul/li[2]");
        private By routeTwo = By.XPath("//kendo-list/div/ul/li[3]");
        private By routeAll = By.XPath("//kendo-list/div/ul/li[1]");
        private By routeByIndex(string index) => By.XPath("//kendo-list/div/ul/li[" + index + "]");
        private By routeByName(string name) => By.XPath("//kendo-list/div/ul/li//span[contains(text(),'" + name + "')]");

        private By reverseAccNo = By.XPath("//th//p[contains(.,'Account Number')]");
        private By reverseAccName = By.XPath("//th//p[contains(.,'Account Name')]");
        private By reverseAddress = By.XPath("//th//p[contains(.,'Address')]");
        private By reverseMIU = By.XPath("//th//p[contains(.,'MIU ID')]");
        private By reverseCycleRoute = By.XPath("//p[contains(.,'Cycle/Route')]");
        private By reverseamiamr = By.XPath("//p[contains(.,'AMR/AMI')]");
        private By flagStart = By.XPath("//p[contains(.,'Flag Start')]");
        private By flagStop = By.XPath("//p[contains(.,'Flag Stop')]");
        private By flagType = By.XPath("//p[contains(.,'Flag Type')]");
        private By reading = By.XPath("//kendo-grid/div/div/div/table/thead/tr/th[10]/div/p");
        private By readingDateTime = By.XPath("//kendo-grid/div/div/div/table/thead/tr/th[11]/div/p");
        private By uom = By.XPath("//th//p[contains(.,'UOM')]");
        private By date = By.XPath("//th//p[contains(.,'Date')]");
        private By consumption = By.XPath("//th//p[contains(.,'Consumption')]");
        private By meterNo = By.XPath("//th//p[contains(.,'Meter Number')]");
        private By meterSize = By.XPath("//th//p[contains(.,'Meter Size')]");
        private By reverseMiuRow = By.XPath("//kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[2]");
        private By reverseFlowFlagTypeRow = By.XPath("//kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[11]");
        private By reverseFlowCycleRow = By.XPath("//kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[1]");
        private By reverseFlowMeterRow = By.XPath("//kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[3]");
        private By reverseAMR = By.XPath("//p[contains(.,'AMR/AMI')]");
        private By reverseLastReadDateTime = By.XPath("//kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[13]");
        private By reverseFlagStart = By.XPath("//kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[9]");
        private By reverseStartDate = By.XPath("//div[1]/span/reportdate-picker/div/div[1]/input");
        private By reverseEndDate = By.XPath("//div[2]/span/reportdate-picker/div/div[1]/input");
        private By reverseReading = By.XPath("//kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[12]");
        private By reverseMeterSize = By.XPath("//kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[5]");
        private By reverseReportDate = By.XPath("//p[contains(text(),'Report Date: ')]");
        private By reverseFlagTypeDropdown = By.XPath("//span/kendo-dropdownlist/span/span");
        private By reverseFlagMajor = By.XPath("//li[contains(.,'Major')]");
        private By reverseFlagMinor = By.XPath("//li[contains(.,'Minor')]");
        private By reverseFlagBoth = By.XPath("//li[contains(.,'Both')]");
        private By reverseFlagStop = By.XPath("//p[contains(.,'Flag Stop')]");

        private By daysOfConsFlowConsBased = By.XPath("//h1[contains(.,' Days of Consecutive Flow (AMI) - Consumption Based ')]");
        private By eventReadStopDateData = By.XPath("//table/tbody/tr[2]/td[8]");
        private By eventReadstartDateData = By.XPath("//table/tbody/tr[2]/td[7]");
        private By metersizeData = By.XPath("//table/tbody/tr[2]/td[6]");
        private By fromDateData = By.XPath("//div[1]/span/reportdate-picker/div/div[1]/input");
        private By toDateData = By.XPath("//div[2]//div[2]/span/reportdate-picker/div/div[1]/input");
        private By lastReaddateData = By.XPath("//table/tbody/tr[2]/td[13]");

        private By btnTableSetting = By.XPath("//button[text()='Table Settings']");
        private By btndeselectAll = By.XPath("//button//span[text()='Deselect All']");
        private By btnOkTableSetting = By.XPath("//button//span[text()='Ok']");
        private By btnOkChooseAccount= By.XPath("//button[text()='Ok']");
        private By btnResetTableSetting = By.XPath("//button//span[text()='Reset']");
        private By btnSelectAllTableSetting = By.XPath("//button//span[text()='Select All']");
        private By btnCloseTableSetting = By.CssSelector(".k-i-x");
        private By reportDateActiveSim = By.XPath("//p[contains(.,'Report Date:')]");
        private By activeSimMiuId = By.XPath("//p[contains(.,'MIU ID')]");
        private By siteID = By.XPath("//p[contains(.,'SITE ID')]");
        private By activeSimICCID = By.XPath("//p[contains(.,'ICCID')]");
        private By shippedUTC = By.XPath("//p[contains(.,'Shipped (UTC)')]");
        private By activatedUTC = By.XPath("//p[contains(.,'Activated (UTC)')]");
        private By firstImported = By.XPath("//p[contains(.,'1st Imported')]");
        private By lastHeard = By.XPath("//p[contains(.,'Last Heard')]");
        private By simState = By.XPath("//p[contains(.,'SIM State')]");
        private By commPlan = By.XPath("//p[contains(.,'Comm Plan')]");
        private By ratePlan = By.XPath("//p[contains(.,'Rate Plan')]");
        private By firstNet = By.XPath("//p[contains(.,'First Net')]");
        private By installDateCol = By.XPath("//span[text()='Install Date']");


        private By miuIdCheckbox = By.XPath("(//input[@type='checkbox'])[2]");
        private By miuCheckboxEndpoint = By.XPath("(//input[@type='checkbox'])[4]");
        private By readingCheckboxEndpoint = By.XPath("(//input[@type='checkbox'])[8]");
        private By addressCheckboxEndpoint = By.XPath("(//input[@type='checkbox'])[3]");
        private By accNameCheckboxEndpoint = By.XPath("(//input[@type='checkbox'])[1]");
        private By meterSizeCheckboxEndpoint = By.XPath("(//input[@type='checkbox'])[6]");
        private By meterNoCheckboxEndpoint = By.XPath("(//input[@type='checkbox'])[5]");
        private By accNoCheckboxEndpoint = By.XPath("(//input[@type='checkbox'])[2]");
        private By consumptionEndpoint = By.XPath("(//input[@type='checkbox'])[9]");
        private By dateCheckboxEndpoint = By.XPath("(//input[@type='checkbox'])[7]");
        private By uomCheckboxEndpoint = By.XPath("(//input[@type='checkbox'])[10]");
        private By miuIdTextbox = By.XPath("(//input[@type='text'])[3]");
        private By btnSubmit = By.XPath("//button[text()='Submit']");

        private By reverseFlowCycleCheckbox = By.XPath("(//input[@type='checkbox'])[1]");
        private By reverseFlowAccNoCheckbox = By.XPath("(//input[@type='checkbox'])[3]");
        private By reverseFlowMeterNoCheckbox = By.XPath("(//input[@type='checkbox'])[4]");
        private By reverseFlowMeterSizeCheckbox = By.XPath("(//input[@type='checkbox'])[5]");
        private By reverseFlowAccNameCheckbox = By.XPath("(//input[@type='checkbox'])[6]");
        private By reverseFlowAddressCheckbox = By.XPath("(//input[@type='checkbox'])[7]");
        private By reverseFlowAMRAMICheckbox = By.XPath("(//input[@type='checkbox'])[8]");
        private By reverseFlowFlagStartcheckbox = By.XPath("(//input[@type='checkbox'])[9]");
        private By reverseFlowFlagStopcheckbox = By.XPath("(//input[@type='checkbox'])[10]");
        private By reverseFlowFlagTypecheckbox = By.XPath("(//input[@type='checkbox'])[11]");
        private By reverseReadingcheckbox = By.XPath("(//input[@type='checkbox'])[12]");
        private By reverseReadingDateTimecheckbox = By.XPath("(//input[@type='checkbox'])[13]");
        private By pleaseSelectatleastOneCol = By.XPath("//kendo-dialog/div/div/div[contains(.,'Please select at least one column.')]");


        private By row1 = By.XPath("//kendo-grid-list//div[1]/table/tbody/tr[2]/td[1]");
        private By lastRowHeader = By.XPath("(//th[@role='columnheader']//p)[last()-1]");
        private By row1FirstCell = By.XPath("//kendo-grid-list//div[1]/table/tbody/tr[1]/td[1]");
        private By row1LastCell = By.XPath("(//kendo-grid-list//div[1]/table/tbody/tr[1]/td)[last()-1]");
        private By pastDueDecrease = By.CssSelector(".k-spinner-decrease > .k-icon");
        private By amiMeterRow = By.XPath("//kendo-grid-list//div[1]/table/tbody/tr[1]");
        private By amiLink = By.XPath("//kendo-grid-list//tbody/tr[1]/td[3]/div/span");
        private By meterReaderLink = By.XPath("//kendo-grid-list//tbody//span[@class='drilldown-link']");
        private By maxTimePerRead = By.XPath("//p[contains(.,'Max Time Per Read: ')]");
        private By minTimePerRead = By.XPath("//p[contains(.,'Min Time Per Read: ')]");
        private By timePerRead = By.XPath("//p[contains(.,' Time Per Read: ')]");
        private By skipRate = By.XPath("//p[contains(.,'Skip Rate: ')]");
        private By totalTime = By.XPath("//p[contains(.,'Total Time: ')]");
        private By quickest3Time = By.XPath("//sd-report-grid/div/div[2]/div/div/div[2]");
        private By slowest3Time = By.XPath("//sd-report-grid/div/div[2]/div/div/div[3]");
        private By closeRouteDrilldown = By.XPath("//sd-flyin-modal/div/div/div[1]/i");
        private By initialeventDateTime = By.XPath("//div[1]//tr/td[6]/div/span");
        private By custInqLink = By.XPath("(//span[contains(@class,'fa fa-external-link rpt-cust-inq-link')][@data-title='View Customer Inquiry Details'])[1]");
        private By groupDrpdown = By.XPath("//kendo-dropdownlist/span/span");
        private By miuNotFound = By.XPath("//div[contains(text(),'MIU was not found.')]");
        private By btnCancel = By.XPath("//button[text()='Cancel']");

        #endregion

        /// <summary>
        /// Method to Validate Invalid Reports PAge
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateInvalidReportsPage()
        {
            driver.ClickElement(invalidReadings, "Invalid Reports");
            driver.sleepTime(1000);
            driver.CheckElementDisplayed(breadcrumb, "Invalid Readings Page ");
        }

        /// <summary>
        /// Method to Validate Mach 10 Battery PAge
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateMach10BatteryPage()
        {
            driver.ClickElement(mach10Battery, "Mach 10 Battery");
            driver.sleepTime(1000);
            driver.CheckElementDisplayed(mach10Batteryhdr, "Mach 10 Battery");
        }

        // <summary>
        /// Method to Validate Comments
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateComments()
        {
            driver.CheckElementDisplayed(comments, "Mach 10 Battery");
        }

        // <summary>
        /// Method to Validate Comments Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateCommentsPage()
        {
            driver.ClickElement(comments, "Mach 10 Battery");
            driver.WaitForElement(commentsPage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(commentsPage, "Comments Report is displayed");
        }

        // <summary>
        /// Method to Validate Found Meters Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateFoundMetersPage()
        {
            driver.ClickElement(foundMeters, "Found Meters");
            driver.WaitForElement(foundMetersPage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(foundMetersPage, "Found Meters Page is displayed");
        }

        // <summary>
        /// Method to Validate Found Meters Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateFoundMetersIcon()
        {
            driver.CheckElementDisplayed(foundMeters, "Found Meters");
        }

        // <summary>
        /// Method to Validate Mach10 Report Date
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateMach10ReportDate()
        {
            driver.ClickElement(mach10Battery, "Mach 10 Battery");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            //driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(reportDate, "Report Date");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateReverseFlowReportDate()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElement(reverseReportDate, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(reverseReportDate, "Report Date");
        }

        // <summary>
        /// Method to Validate Days Of No Flow Report 
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysOfNoFlowReportSubtitle()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days Of No Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(reportDate, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(reportDate, "Report Date label with date of the data being reported in MM/DD/YYYY format is displayed");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateAMINoFlowReportSubtitle()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(reportDate, "Report Date label with date of the data being reported in MM/DD/YYYY format is displayed");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateInactiveFlowReportSubtitle()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(reportDate, "Report Date label with date of the data being reported in MM/DD/YYYY format is displayed");
            //driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Days Of Consumption Date Time
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysOfConsumptionDateTime()
        {
            driver.ClickElement(daysOfConsumption, "Days Of Consumption");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            //driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(reportDate, "Report Date label with date of the data being reported in MM/DD/YYYY format is displayed");
            //driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Found Meters Report Subtitle
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateFoundMetersReportSubtitle()
        {
            driver.ClickElement(foundMeters, "Days Of No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            //driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(reportDate, "Report Date label with date of the data being reported in MM/DD/YYYY format is displayed");
            //driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Days of Consumption AMR Subtitle
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionAMRSubtitle()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(reportDate, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reportDate, "Report Date label with date of the data being reported in MM/DD/YYYY format is displayed");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysofConsumptionAMRExportPDF()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(exportLink, "Exoprt Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF");
        }
        public void ValidateDaysofConsumptionAMRExportExcel()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(exportLink, "Exoprt Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel");
        }

        // <summary>
        /// Method to Validate Days of Consumption Column Display
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionColumnDisplay()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, "Cycle Route");
            driver.CheckElementDisplayed(Col2, "Read Seq");
            driver.CheckElementDisplayed(Col3, "MIU");
            driver.CheckElementDisplayed(Col4, "Acc Name");
            driver.CheckElementDisplayed(Col5, "Acc No");
            driver.CheckElementDisplayed(Col6, "Address");
            driver.CheckElementDisplayed(Col7, "Consumption Flag");
            driver.CheckElementDisplayed(Col8, "Days Range");
            driver.CheckElementDisplayed(Col9, "Reading");
            driver.CheckElementDisplayed(Col10, "Date/Time");
            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Days of No Flow Column Display
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofNoFlowColumnDisplay()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of Consumption AMR");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, "Cycle Route");
            driver.CheckElementDisplayed(Col2, "Read Seq");
            driver.CheckElementDisplayed(Col3, "MIU");
            driver.CheckElementDisplayed(Col4, "Acc Name");
            driver.CheckElementDisplayed(Col5, "Acc No");
            driver.CheckElementDisplayed(Col6, "Address");
            driver.CheckElementDisplayed(Col9, "Reading");
            driver.CheckElementDisplayed(Col10, "Date/Time");
            driver.CheckElementDisplayed(Col11, "Consec Days");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateAMINoFlowColumnDisplay()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, "Cycle Route");
            driver.CheckElementDisplayed(Col2, "Acc Name");
            driver.CheckElementDisplayed(Col3, "Acc No");
            driver.CheckElementDisplayed(Col4, "Address");
            driver.CheckElementDisplayed(Col5, "MIU");
            driver.CheckElementDisplayed(Col6, "Meter No");
            driver.CheckElementDisplayed(Col7, "Meter Size");
            driver.CheckElementDisplayed(Col8, "Last Changed");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateInvalidReadingsColumnDisplay()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, driver.GetElementText(Col1).ToString());
            driver.CheckElementDisplayed(Col2, driver.GetElementText(Col2).ToString());
            driver.CheckElementDisplayed(Col3, driver.GetElementText(Col3).ToString());
            driver.CheckElementDisplayed(Col4, driver.GetElementText(Col4).ToString());
            driver.CheckElementDisplayed(Col5, driver.GetElementText(Col5).ToString());
            driver.CheckElementDisplayed(Col6, driver.GetElementText(Col6).ToString());
            driver.CheckElementDisplayed(Col7, driver.GetElementText(Col7).ToString());
            driver.CheckElementDisplayed(Col8, driver.GetElementText(Col8).ToString());
            driver.CheckElementDisplayed(Col9, driver.GetElementText(Col9).ToString());
            driver.CheckElementDisplayed(Col10, driver.GetElementText(Col10).ToString());
            driver.CheckElementDisplayed(Col11, driver.GetElementText(Col11).ToString());
            driver.CheckElementDisplayed(Col12, driver.GetElementText(Col12).ToString());
            driver.ScrollToElement(driver.FindElement(Col13));
            driver.CheckElementDisplayed(Col13, driver.GetElementText(Col13).ToString());
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysOfConsumptionColumnDisplay()
        {
            driver.ClickElement(daysOfConsumption, "Days Of Consumption (AMR)");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, "Cycle Route");
            driver.CheckElementDisplayed(Col2, "Read Seq");
            driver.CheckElementDisplayed(Col3, "Acc Name");
            driver.CheckElementDisplayed(Col4, "Acc No");
            driver.CheckElementDisplayed(Col5, "Address");
            driver.CheckElementDisplayed(Col6, "MIU");
            driver.CheckElementDisplayed(Col7, "Meter No");
            driver.CheckElementDisplayed(Col8, "Meter Size");
            driver.CheckElementDisplayed(Col9, "Last Reading Date/Time");
            driver.CheckElementDisplayed(Col10, "Days Range");
            driver.CheckElementDisplayed(Col11, "Consumption Flag");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateAMINoFlowCycleRoute()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, "Cycle Route");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysofNoFlowCycleRoute()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, "Cycle Route");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysofNoFlowReadSeq()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col2, "Read Seq");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysofNoFlowMIU()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col6, "MIU");
            string s = driver.GetElementText(Col6);
            testReport.Info(s);
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysofNoFlowAccName()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col3, "Acc Name");
            string s = driver.GetElementText(Col3);
            testReport.Info(s);
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysofNoFlowAccNumber()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col4, "Acc Number");
            string s = driver.GetElementText(Col4);
            testReport.Info(s);
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysofNoFlowAddress()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col5, "Address");
            string s = driver.GetElementText(Col5);
            testReport.Info(s);
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysofNoConsecDays()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col11, "Consec Days");
            string s = driver.GetElementText(Col11);
            testReport.Info(s);
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysofNoFlowReading()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col9, "Reading");
            string s = driver.GetElementText(Col9);
            testReport.Info(s);
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysofNoFlowDateTime()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col10, "Date/Time");
            string s = driver.GetElementText(Col10);
            testReport.Info(s);
            //driver.SwitchToDefaultFrame();
        }



        public void ValidateAMINoFlowAccName()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col4, "Acc Name");
            //driver.SwitchToDefaultFrame();
        }


        public void ValidateAMINoFlowAccNo()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col3, "Acc No");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateAMINoFlowAddress()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col4, "Address");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateAMINoFlowMiuId()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col5, "Miu Id");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateAMINoFromDate()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(fromDate, "From Date");
        }

        public void ValidateDaysOfNoFromDate()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(fromDate, "From Date");
        }

        public void ValidateDaysOfNoToDate()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow");
            driver.sleepTime(2000);
            driver.WaitForElement(toDate, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(toDate, "To Date");
        }

        public void ValidateDaysOfNoFromDateEditable()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(fromDate, "From Date");
        }

        public void ValidateDaysOfNoToDateEditable()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow");
            driver.sleepTime(2000);
            driver.WaitForElement(toDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(toDate, "To Date");
        }


        public void ValidateAMINoFromDateEditable()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(fromDate, "From Date");
        }

        public void ValidateAMINoToDateEditable()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(toDate, "To Date");
        }

        public void ValidateAMINoRouteFilter()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.sleepTime(2000);
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(routeFilter, "Route Filter");
        }

        public void ValidateDaysOfConsumptionRouteFilter()
        {
            driver.ClickElement(daysOfConsumption, "Days Of Consumption (AMR)");
            driver.sleepTime(2000);
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(routeFilter, "Route Filter");
        }

        public void ValidateAMINoRouteFilterSelect()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.WaitForElementNotExists(gridLoader, 60);
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            driver.ClickElement(routeFilter, "Route Filter");

            if (driver.FindElements(routeList).Count > 0)
            {
                testReport.Pass("Route Filters are displayed");
            }
            else
            {
                ReporterFactory.LogFailure("Route Filters are not displayed");
            }
        }

        public void ValidateDaysOfConsumptionRouteFilterSelect()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.sleepTime(2000);
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            driver.ClickElement(routeFilter, "Route Filter");
            driver.ClickElement(routeOne, "Route One");
            testReport.Info("Only One Route Can be selected at once.");
        }

        public void ValidateDaysOfConsumptionRouteFilterSelectSubtitle()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.sleepTime(2000);
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            driver.ClickElement(routeFilter, "Route Filter");
            driver.ClickElement(routeTwo, "Route Two");
            driver.sleepTime(10000);
        }

        public void ValidateDaysOfConsumptionRouteFilterSelectAll()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.sleepTime(2000);
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            driver.ClickElement(routeFilter, "Route Filter");
            driver.ClickElement(routeAll, "Route All");
            driver.sleepTime(10000);
        }


        public void ValidateAMINoGroupFilterSelect()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.sleepTime(2000);
            driver.WaitForElement(groupFilter, TimeSpan.FromMinutes(1));
            driver.ClickElement(groupFilter, "Group Filter");
        }

        public void ValidateAMINoToDate()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.sleepTime(2000);
            driver.WaitForElement(toDate, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(toDate, "To Date");
        }

        public void ValidateAMINoFlowMeterNo()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col6, "MeterNo");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateAMINoFlowMeterSize()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col7, "MeterSize");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateAMINoFlowLastChanged()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col8, "Last Changed");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateAMINoFlowBackToReportsDisplayed()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.WaitForElement(backToReports, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(backToReports, "Back to Reports");
        }

        public void ValidateFoundMetersBackToReportsDisplayed()
        {
            driver.ClickElement(foundMeters, "Found Meters");
            driver.WaitForElement(backToReports, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(backToReports, "Back to Reports");
        }

        public void ValidateDaysNoFlowBackToReportsDisplayed()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow");
            driver.WaitForElement(backToReports, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(backToReports, "Back to Reports");
        }

        public void ValidateDaysofNoFlowBackToReportsClick()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow");
            driver.WaitForElement(backToReports, TimeSpan.FromMinutes(1));
            driver.ClickElement(backToReports, "Back to Reports");
            if (driver.Title.Contains("Reports"))
            {
                testReport.Pass("Reports page is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("Reports page is not displayed");
            }
        }

        public void ValidateAMINoFlowBackToReportsClick()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.WaitForElement(backToReports, TimeSpan.FromMinutes(1));
            driver.ClickElement(backToReports, "Back to Reports");
            if (driver.Title.Contains("Reports"))
            {
                testReport.Pass("Reports page is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("Reports page is not displayed");
            }
        }

        public void ValidateFoundMetersBackToReportsClick()
        {
            driver.ClickElement(foundMeters, "Found Meters");
            driver.WaitForElement(backToReports, TimeSpan.FromMinutes(1));
            driver.ClickElement(backToReports, "Back to Reports");
            if (driver.Title.Contains("Reports"))
            {
                testReport.Pass("Reports page is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("Reports page is not displayed");
            }
        }
        public void ValidateCommentsBackToReports()
        {
            driver.ClickElement(comments, "Comments");
            driver.WaitForElement(backToReports, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(backToReports, "Back to Reports");
        }
        public void ValidateTamperReportsAccess()
        {
            driver.ClickElement(tamperReport, "tamperReport");

            driver.WaitForElement(breadcrumb, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(breadcrumb, driver.GetElementText(breadcrumb));
        }
        public void ValidateTamperReportsGroupFilter()
        {
            driver.ClickElement(tamperReport, "tamperReport");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));

            driver.SelectCalenderDate(fromDate, "Jan", "1");


            driver.WaitForElement(groupFilter, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(groupFilter, "Group Filter");
        }
        public void ValidateTamperReportsGroupFilterList()
        {
            driver.ClickElement(tamperReport, "tamperReport");
            driver.WaitForElement(groupFilter, TimeSpan.FromSeconds(30));
            driver.ClickElement(groupFilter, "Group Filter");
            driver.CheckElementDisplayed(routeOne, "Filter");
        }
        public void ValidateTamperReportsIncludeOption()
        {
            driver.ClickElement(tamperReport, "tamperReport");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.ClickElement(include, "Include");
            driver.ClickElement(groupDrpdown, "Group Dropdown");
            driver.ClickElement(routeOne, "Select Group");
            driver.WaitForElement(Col1, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(Col1, "MIU");
        }
        public void ValidateTamperReportsExcludeOption()
        {
            driver.ClickElement(tamperReport, "tamperReport");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.ClickElement(exclude, "Exclude");
            driver.ClickElement(groupDrpdown, "Group Dropdown");
            driver.ClickElement(routeOne, "Select Group");
            driver.WaitForElement(Col1, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(Col1, "MIU");
        }
        public void ValidateProductivityReportsMaxPerRead()
        {
            driver.ClickElement(productivityReport, "productivityReport");
            driver.WaitForElement(amiLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(amiLink, "AMI Link");
            driver.WaitForElement(maxTimePerRead, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(maxTimePerRead, "Max Time Per Read");
            driver.ClickElement(closeRouteDrilldown, "Close");
        }
        public void ValidateProductivityReportsMinPerRead()
        {
            driver.ClickElement(productivityReport, "productivityReport");
            driver.WaitForElement(amiLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(amiLink, "AMI Link");
            driver.WaitForElement(minTimePerRead, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(minTimePerRead, "Min Time Per Read");
            driver.ClickElement(closeRouteDrilldown, "Close");
        }
        public void ValidateProductivityReportsRunningTotals()
        {
            driver.ClickElement(productivityReport, "productivityReport");
            driver.WaitForElement(meterReaderLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(meterReaderLink, "meter Reader Link");
            driver.WaitForElement(quickest3Time, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(quickest3Time, "Running Totals");
            driver.ClickElement(closeRouteDrilldown, "Close");
        }
        public void ValidateProductivityReportsTimePerRead()
        {
            driver.ClickElement(productivityReport, "productivityReport");
            driver.WaitForElement(amiLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(amiLink, "AMI Link");
            driver.WaitForElement(timePerRead, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(timePerRead, " Time Per Read");
            driver.ClickElement(closeRouteDrilldown, "Close");
        }
        public void ValidateProductivityReportsMeterReaderTimePerRead()
        {
            driver.ClickElement(productivityReport, "productivityReport");
            driver.WaitForElement(meterReaderLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(meterReaderLink, "meter Reader Link");
            driver.WaitForElement(timePerRead, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(timePerRead, " Time Per Read");
            driver.ClickElement(closeRouteDrilldown, "Close");
        }
        public void ValidateProductivityReportsSkipRate()
        {
            driver.ClickElement(productivityReport, "productivityReport");
            driver.WaitForElement(amiLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(amiLink, "AMI Link");
            driver.WaitForElement(skipRate, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(skipRate, " skip Rate");
            driver.ClickElement(closeRouteDrilldown, "Close");
        }
        public void ValidateProductivityReportsTotalTime()
        {
            driver.ClickElement(productivityReport, "productivityReport");
            driver.WaitForElement(amiLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(amiLink, "AMI Link");
            driver.WaitForElement(totalTime, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(totalTime, " total Time");
            driver.ClickElement(closeRouteDrilldown, "Close");
        }
        public void ValidateProductivityReportsMeterReaderTotalTime()
        {
            driver.ClickElement(productivityReport, "productivityReport");
            driver.WaitForElement(meterReaderLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(meterReaderLink, "meterReaderLink");
            driver.WaitForElement(totalTime, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(totalTime, " total Time");
            driver.ClickElement(closeRouteDrilldown, "Close");
        }

        public void ValidateProductivityReportsQuickestThreetime()
        {
            driver.ClickElement(productivityReport, "productivityReport");
            driver.WaitForElement(amiLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(amiLink, "AMI Link");
            driver.WaitForElement(quickest3Time, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(quickest3Time, "quickest 3 Total Time Elapses");
            driver.ClickElement(closeRouteDrilldown, "Close");
        }
        public void ValidateProductivityReportsSlowestThreetime()
        {
            driver.ClickElement(productivityReport, "productivityReport");
            driver.WaitForElement(amiLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(amiLink, "AMI Link");
            driver.WaitForElement(slowest3Time, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(slowest3Time, "Slowest 3 Total Time Elapses");
            driver.ClickElement(closeRouteDrilldown, "Close");
        }
        public void ValidateProductivityActiveRoutes()
        {
            driver.ClickElement(productivityReport, "productivityReport");
            driver.WaitForElement(groupDrpdown, TimeSpan.FromSeconds(30));
            driver.ClickElement(groupDrpdown, "Dropdown");
            driver.ClickElement(routeOne, "Active");
            driver.WaitForElement(Col1, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(Col1, "Active Routes Data");
        }
        public void ValidateProductivityClosedRoutes()
        {
            driver.ClickElement(productivityReport, "productivityReport");
            driver.WaitForElement(groupDrpdown, TimeSpan.FromSeconds(30));
            driver.ClickElement(groupDrpdown, "Dropdown");
            driver.ClickElement(routeTwo, "Active");
            driver.WaitForElement(Col1, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(Col1, "Active Routes Data");
        }
        public void ValidateProductivityRoutesListOfValues()
        {
            driver.ClickElement(productivityReport, "productivityReport");
            driver.WaitForElement(groupDrpdown, TimeSpan.FromSeconds(30));
            driver.ClickElement(groupDrpdown, "Dropdown");
            driver.CheckElementDisplayed(routeAll, "All");
            driver.CheckElementDisplayed(routeOne, "Active");
            driver.CheckElementDisplayed(routeTwo, "Closed");
        }
        public void ValidateProductivityAllRoutes()
        {
            driver.ClickElement(productivityReport, "productivityReport");
            driver.WaitForElement(groupDrpdown, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(groupDrpdown, "All Routes");
        }

        public void ValidateTamperReportsContents()
        {
            driver.ClickElement(tamperReport, "tamperReport");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(fromDate, "From Date");
            driver.CheckElementDisplayed(tamperTypeFilter, "Tamper Type Flag Filter");
            driver.CheckElementDisplayed(groupFilter, "Group Filter");
            driver.CheckElementDisplayed(include, "Include");
            driver.CheckElementDisplayed(backToReports, "Back to Reports Link");
            driver.Title.ToString();
        }
        public void ValidateTamperReportsGridColumns()
        {
            driver.ClickElement(tamperReport, "tamperReport");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(Col1, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(Col1, "MIU");
            driver.CheckElementDisplayed(Col2, "Route");
            driver.CheckElementDisplayed(Col3, "Account Name");
            driver.CheckElementDisplayed(Col4, "Premised");
            driver.CheckElementDisplayed(Col5, "Address");
            driver.CheckElementDisplayed(Col6, "Tamper Type");
        }
        public void ValidateTamperReportExportPDF()
        {
            driver.ClickElement(tamperReport, "tamperReport");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.sleepTime(2000);
            driver.ClickElement(exportLink, "Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF");
        }
        public void ValidateTamperReportExportExcel()
        {
            driver.ClickElement(tamperReport, "tamperReport");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.sleepTime(2000);
            driver.ClickElement(exportLink, "Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel");
        }

        public void ValidateAMINoFlowTable()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(amiTable, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(amiTable, "AMI Table");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateInvalidReportTable()
        {
            driver.ClickElement(invalidReadings, "Invalid Report");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(amiTable, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(amiTable, "AMI Table");
            //driver.SwitchToDefaultFrame();
        }


        public void ValidateDaysofNoFlowRouteFilter()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of Consumption AMR");
            driver.sleepTime(2000);
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(routeFilter, "Route Filter");
        }
        public void ValidateInvalidReadingRouteFilter()
        {
            driver.ClickElement(invalidReadings, "invalidReadings");
            driver.sleepTime(2000);
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(routeFilter, "Route Filter");
        }
        public void ValidateInvalidReadingsGroupFilter()
        {
            driver.ClickElement(invalidReadings, "invalidReadings");
            driver.sleepTime(2000);
            driver.WaitForElement(groupFilter, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(groupFilter, "Group Filter");
        }
        public void ValidateInvalidReadingsOneGroupSelect()
        {
            driver.ClickElement(invalidReadings, "invalidReadings");
            driver.sleepTime(2000);
            driver.WaitForElement(groupFilter, TimeSpan.FromMinutes(1));
            driver.ClickElement(groupFilter, "Group Filter");
            driver.ClickElement(routeOne, "");
        }
        public void ValidateInvalidReadingsExcludeGroup()
        {
            driver.ClickElement(invalidReadings, "invalidReadings");
            driver.sleepTime(2000);
            driver.WaitForElement(groupFilter, TimeSpan.FromMinutes(1));
            driver.ClickElement(exclude, "Exclude");
            driver.ClickElement(groupFilter, "Group Filter");
            driver.ClickElement(routeOne, "");
        }
        public void ValidateInvalidReadingsGroupFilterValues()
        {
            driver.ClickElement(invalidReadings, "invalidReadings");
            driver.sleepTime(2000);
            driver.WaitForElement(groupFilter, TimeSpan.FromMinutes(1));
            driver.ClickElement(groupFilter, "Group Filter Values");
        }

        public void ValidateDaysofNoFlowGroupFilter()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of Consumption AMR");
            driver.sleepTime(2000);
            driver.WaitForElement(groupFilter, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(groupFilter, "Group Filter");
        }
        public void ValidateReverseFlowGroupFilter()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.sleepTime(2000);
            driver.WaitForElement(groupFilter, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(groupFilter, "Group Filter");
        }

        public void ValidateDaysofConsumptionGroupFilter()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            driver.sleepTime(2000);
            driver.WaitForElement(groupFilter, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(groupFilter, "Group Filter");
        }

        public void ValidateDaysofNoFlowSelectroute()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of Consumption AMR");
            driver.sleepTime(2000);
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            driver.ClickElement(groupFilter, "Group Filter");
        }

        public void ValidateDaysofNoFlowSelectrouteSubtitle()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of Consumption AMR");
            driver.sleepTime(2000);
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(routeFilter, "Route Filter");
            //driver.SwitchToDefaultFrame()
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.CheckElementDisplayed(daysofNoFlowTitle, "Title");
            if (driver.Title.Contains("Days of No Flow (AMR)"))
            {
                testReport.Pass("Subtitle of the report includes Route underneath the Report Date Range");
            }
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateAMINoFlowSTitle()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.sleepTime(2000);
            //driver.SwitchToDefaultFrame()
            //driver.SwitchToFrameById("ntgMSTRFrame");
            if (driver.Title.Contains("AMI No Flow"))
            {
                testReport.Pass("AMI No Flow is displayed as Detailed Report title");
            }
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateEndpointConsumTitle()
        {
            driver.ClickElement(endpointConsumption, "endpoint Consumption");
            driver.WaitForElement(breadcrumb, TimeSpan.FromSeconds(10));
            driver.GetElementText(breadcrumb);
        }
        public void ValidateEndpointConsumBackButton()
        {
            driver.ClickElement(endpointConsumption, "endpoint Consumption");
            driver.WaitForElement(backToReports, TimeSpan.FromSeconds(10));
            driver.ClickElement(backToReports, "Back To Reports");
        }
        public void ValidateReverseFlowReportTitle()
        {
            driver.ClickElement(reverseFlow, "Reverse Flow");
            driver.sleepTime(2000);
            //driver.SwitchToFrameById("ntgMSTRFrame");
            if (driver.Title.Contains("Reverse Flow"))
            {
                testReport.Pass("Reverse Flow is displayed as Detailed Report title");
            }
        }

        public void ValidateInactiveFlowTitle()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            driver.sleepTime(2000);
            //driver.SwitchToDefaultFrame()
            //driver.SwitchToFrameById("ntgMSTRFrame");
            if (driver.Title.Contains("Inactive Flow"))
            {
                testReport.Pass("Inactive Flow is displayed as Detailed Report title");
            }
            //driver.SwitchToDefaultFrame();
        }

        // <summary> 
        /// Method to Validate Days of Consumption Sort Order Date Range
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionSortOrderDateRange()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            //driver.SwitchToDefaultFrame();
        }


        // <summary> 
        /// Method to Validate Days of Consumption Second Cycle Route
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionSecondCycleRoute()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, "Cycle/Route is in ascending Order");
            ////driver.SwitchToDefaultFrame();
        }



        // <summary>
        /// Method to Validate Days of Consumption report
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionReportCycle()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, "Cycle Route");

            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Days of Consumption Read Seq
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionReadSeq()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col2, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col2, "Read Seq");

            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Days of Consumption Back to Reports
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionBacktoReportsDisplay()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            driver.WaitForElement(backToReports, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(backToReports, "Back to Reports");
        }

        // <summary>
        /// Method to Validate Days of Consumption Back to Reports Click
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionBacktoReportsClick()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            driver.WaitForElement(backToReports, TimeSpan.FromMinutes(1));
            driver.ClickElement(backToReports, "Back to Reports");
        }

        public void ValidateHighConsumptionBacktoReportsDisplay()
        {
            driver.ClickElement(highCosumption, "High Consumption");
            driver.WaitForElement(backToReports, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(backToReports, "Back to Reports");
        }
        public void ValidateHighConsumptionCycleRoute()
        {
            driver.ClickElement(highCosumption, "High Consumption");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, "Cycle/Route");
        }

        // <summary>
        /// Method to Validate Days of Consumption From Date
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionFromDate()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(fromDate, "From Date");
        }

        // <summary>
        /// Method to Validate Found MetersFrom Date
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateFoundMetersFromDate()
        {
            driver.ClickElement(foundMeters, "Found Meters");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(fromDate, "From Date");
        }

        public void ValidateFoundMetersMIU()
        {
            driver.ClickElement(foundMeters, "Found Meters");
            driver.sleepTime(2000);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, "MIU");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateFoundMetersReading()
        {
            driver.ClickElement(foundMeters, "Found Meters");
            driver.sleepTime(2000);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col2, "Reading");
            //driver.SwitchToDefaultFrame();
        }

        private void updateBeginDateTemp()
        {
            (new WebDriverWait(driver, new TimeSpan(0, 5, 0))).Until(ExpectedConditions.InvisibilityOfElementLocated(By
                        .CssSelector(".report-grid-loader")));
            string BegDateUI = driver.FindElement(By.CssSelector("input.k-input")).GetAttribute("aria-valuetext");
            if (!BegDateUI.Equals("01-Oct-2021"))
            {
                driver.FindElement(By.CssSelector("#searchLink")).Click();
                driver.sleepTime(1000);

                driver.FindElement(By.XPath("//span[text()=' Mar ']//..")).Click();
                driver.sleepTime(1000);
                driver.FindElement(By.XPath("//span[text()=' Oct ']//..")).Click();
                driver.sleepTime(1000);
                /*driver.FindElement(By.XPath("//span[text()=' Mar ']//..")).Click();
                driver.sleepTime(1000);*/

                driver.FindElement(By.CssSelector("td[title='Friday, October 1, 2021']")).Click();

                (new WebDriverWait(driver, new TimeSpan(0, 5, 0))).Until(ExpectedConditions.InvisibilityOfElementLocated(By
                            .CssSelector(".report-grid-loader")));

            }
        }

        public void ValidateFoundMetersDateTime()
        {
            driver.ClickElement(foundMeters, "Found Meters");
            driver.sleepTime(2000);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col3, "Date/Time");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateFoundMetersFirstRead()
        {
            driver.ClickElement(foundMeters, "Found Meters");
            driver.sleepTime(2000);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col4, "First Read");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateFoundMetersColumns()
        {
            driver.ClickElement(foundMeters, "Found Meters");
            driver.sleepTime(2000);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, "MIU");
            driver.CheckElementDisplayed(Col2, "REading");
            driver.CheckElementDisplayed(Col3, "Date/Time");
            driver.CheckElementDisplayed(Col4, "First Read");
            //driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Found Meters To Date
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateFoundMetersToDate()
        {
            driver.ClickElement(foundMeters, "Found Meters");
            driver.sleepTime(2000);
            driver.WaitForElement(toDate, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(toDate, "To Date");
        }

        // <summary>
        /// Method to Validate Found Meters From Date Editable
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateFoundMetersFromDateEditable()
        {
            driver.ClickElement(foundMeters, "Found Meters");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(fromDate, "From Date");
        }
        // <summary>
        /// Method to Validate Found Meters From Date To Date Editable
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateFoundMetersFromDateToDateEditable()
        {
            driver.ClickElement(foundMeters, "Found Meters");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(1));
            driver.ClickElement(fromDate, "From Date");
            driver.ClickElement(toDate, "To Date");
        }


        public void ValidateFoundMetersToDateEditable()
        {
            driver.ClickElement(foundMeters, "Found Meters");
            driver.sleepTime(2000);
            driver.WaitForElement(toDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(toDate, "To Date");
        }

        public void ValidateGroupsdropdownDisplay()
        {
            driver.ClickElement(lftNavGroups, "Groups");
            driver.CheckElementDisplayed(lftNavGroupManagement, "Group Management");
            driver.CheckElementDisplayed(lftNavSearchEndpoints, "Search Endpoints");
        }

        // <summary>
        /// Method to Validate Days of Consumption To  Date
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionToDate()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            driver.sleepTime(2000);
            driver.WaitForElement(toDate, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(toDate, "To Date");
        }

        // <summary>
        /// Method to Validate Days of Consumption Default  Date
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionDefaultDate()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            string s = driver.GetElementText(fromDate);
            testReport.Info("Default From Date is 7 days prior to today's date: " + s);
        }


        // <summary>
        /// Method to Validate Days of Consumption Default  Date Editable
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionDefaultDateEditable()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(fromDate, "From Date");
        }

        // <summary>
        /// Method to Validate Days of Consumption Default  To  Editable
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionDefaultToEditable()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(toDate, "To Date");
            driver.ClickElement(fromDate, "From Date");
        }

        public void ValidateCommentsFromDate()
        {
            driver.ClickElement(comments, "Comments");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            //driver.ClickElement(toDate, "To Date");
            driver.ClickElement(fromDate, "From Date");
        }

        public void ValidateCommentsToDate()
        {
            driver.ClickElement(comments, "Comments");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(toDate, "To Date");
        }
        public void ValidateCommentsFromDateToDate()
        {
            driver.ClickElement(comments, "Comments");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(toDate, "To Date");
            driver.ClickElement(fromDate, "From Date");
        }

        public void ValidateCodedNotesFromDateEditable()
        {
            driver.ClickElement(codedNotes, "Coded Notes");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(fromDate, "From Date");
        }

        public void ValidateCodedNotesFromDate()
        {
            driver.ClickElement(codedNotes, "Coded Notes");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(fromDate, "From Date");
        }
        public void ValidateCodedReadSeq()
        {
            driver.ClickElement(codedNotes, "Coded Notes");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));

            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.sleepTime(2000);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, "REad Seq");
            //driver.SwitchToDefaultFrame();
        }



        public void ValidateCodedNotesToDate()
        {
            driver.ClickElement(codedNotes, "Coded Notes");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(toDate, "To Date");
            //driver.ClickElement(fromDate, "From Date");
        }
        public void ValidateDaysOfNoFlowFromDateToDate()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days Of No Flow AMR");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(toDate, "To Date");
            driver.ClickElement(fromDate, "From Date");
        }

        public void ValidateDaysOfNoFlowCodeValue1()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days Of No Flow AMR");

            driver.WaitForElementNotExists(gridLoader, 60);

            GetAllColumnValues(consecDaysColumnValues, out bool valueMatched, "1-2 days");

            if (valueMatched)
            {
                testReport.Pass("MIU ID/Meter having 35 Day No Flow code value 1(1-2 days) displays in the Days of No Flow (AMR) Detailed Report");
            }
            else
            {
                ReporterFactory.LogFailure("MIU ID/Meter having 35 Day No Flow code value 1(1-2 days) NOT displayed in the Days of No Flow (AMR) Detailed Report");
            }
        }

        public void ValidateDaysOfNoFlowCodeValue2()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days Of No Flow AMR");

            driver.WaitForElementNotExists(gridLoader, 60);

            GetAllColumnValues(consecDaysColumnValues, out bool valueMatched, "3-7 days");

            if (valueMatched)
            {
                testReport.Pass("MIU ID/Meter having 35 Day No Flow code value 2(3-7 days) displays in the Days of No Flow (AMR) Detailed Report");
            }
            else
            {
                ReporterFactory.LogFailure("MIU ID/Meter having 35 Day No Flow code value 2(3-7 days) NOT displayed in the Days of No Flow (AMR) Detailed Report");
            }
        }

        public void ValidateDaysOfNoFlowCodeValue3()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days Of No Flow AMR");

            driver.WaitForElementNotExists(gridLoader, 60);

            GetAllColumnValues(consecDaysColumnValues, out bool valueMatched, "8-14 days");

            if (valueMatched)
            {
                testReport.Pass("MIU ID/Meter having 35 Day No Flow code value 3(8-14 days) displays in the Days of No Flow (AMR) Detailed Report");
            }
            else
            {
                ReporterFactory.LogFailure("MIU ID/Meter having 35 Day No Flow code value 3(8-14 days) NOT displayed in the Days of No Flow (AMR) Detailed Report");
            }
        }

        public void ValidateDaysOfNoFlowCodeValue4()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days Of No Flow AMR");

            driver.WaitForElementNotExists(gridLoader, 60);

            GetAllColumnValues(consecDaysColumnValues, out bool valueMatched, "15-21 days");

            if (valueMatched)
            {
                testReport.Pass("MIU ID/Meter having 35 Day No Flow code value 4(15-21 days) displays in the Days of No Flow (AMR) Detailed Report");
            }
            else
            {
                ReporterFactory.LogFailure("MIU ID/Meter having 35 Day No Flow code value 4(15-21 days) NOT displayed in the Days of No Flow (AMR) Detailed Report");
            }
        }
        public void ValidateDaysOfNoFlowCodeValue5()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days Of No Flow AMR");

            driver.WaitForElementNotExists(gridLoader, 60);

            GetAllColumnValues(consecDaysColumnValues, out bool valueMatched, "22-34 days");

            if (valueMatched)
            {
                testReport.Pass("MIU ID/Meter having 35 Day No Flow code value 5(22-34 days) displays in the Days of No Flow (AMR) Detailed Report");
            }
            else
            {
                ReporterFactory.LogFailure("MIU ID/Meter having 35 Day No Flow code value 5(22-34 days) NOT displayed in the Days of No Flow (AMR) Detailed Report");
            }
        }

        public void ValidateDaysOfConsumptionCodeValue5()
        {
            driver.ClickElement(daysOfConsumption, "Days Of Consumption AMR");
            driver.sleepTime(2000);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(codeValue5, TimeSpan.FromSeconds(30));
            driver.WaitForElement(codeValue5, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(codeValue5, "Code Value 5");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysOfConsumptionCodeValue6()
        {
            driver.ClickElement(daysOfConsumption, "Days Of Consumption AMR");
            driver.sleepTime(2000);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(codeValue5, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(codeValue6, "Code Value 6");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysOfNoFlowCodeValue6()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days Of No Flow AMR");
            driver.sleepTime(2000);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(codeValue4, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(codeValue6, "Code Value 6");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysOfNoFlowCodeValue0()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days Of No Flow AMR");
            driver.sleepTime(2000);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(codeValue4, TimeSpan.FromMinutes(1));
            driver.CheckElementDoesnotExists(codeValue0, "Code Value 0");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfNoFlowCodeValue7()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days Of No Flow AMR");
            driver.sleepTime(2000);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(codeValue4, TimeSpan.FromMinutes(1));
            driver.CheckElementDoesnotExists(codeValue7, "Code Value 7");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsumptionCodeValue7()
        {
            driver.ClickElement(daysOfConsumption, "Days Of Consumption AMR");
            driver.sleepTime(2000);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(codeValue4, TimeSpan.FromMinutes(1));
            driver.CheckElementDoesnotExists(codeValue7, "Code Value 7");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysOfConsumptionMiuId()
        {
            driver.ClickElement(daysOfConsumption, "Days Of Consumption AMR");
            driver.sleepTime(2000);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col6, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col6, "MIu ID");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysOfConsumptionCodeValue0()
        {
            driver.ClickElement(daysOfConsumption, "Days Of Consumption AMR");
            driver.sleepTime(2000);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(codeValue4, TimeSpan.FromMinutes(1));
            driver.CheckElementDoesnotExists(codeValue0, "Code Value 0");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateCodedNotesFromDateToDate()
        {
            driver.ClickElement(codedNotes, "Coded Notes");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(toDate, "To Date");
            driver.ClickElement(fromDate, "From Date");
        }

        public void ValidateInvalidReadingFromDate()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            //driver.ClickElement(toDate, "To Date");
            driver.ClickElement(fromDate, "From Date");
        }

        public void ValidateInvalidReadingToDate()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(toDate, "To Date");
            //driver.ClickElement(fromDate, "From Date");
        }

        public void ValidateInvalidReadingReportDate()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            driver.sleepTime(2000);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); 
            driver.CheckElementDisplayed(reportDate, "Report Date");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateInvalidReadingsRouteDataValidation()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, "Cycle Route");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateInvalidReadingsReadSeqDataValidation()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col2, "Read Seq");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateInvalidReadingsMIuIDDataValidation()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col3, "MIU Id");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateInvalidReadingsUpdatePastDue()
        {
            driver.ClickElement(endpointMaintanence, "endpointMaintanence");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(pastDueDecrease, TimeSpan.FromMinutes(1));
            driver.ClickElement(pastDueDecrease, "pastDueDecrease");
            driver.WaitForElement(pastDueKPI, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(pastDueKPI, "Past Due Count");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateInvalidReadingsNameDataValidation()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col4, "Name");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateInvalidReadingsAccountDataValidation()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col5, "Account");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateInvalidReadingsAddressDataValidation()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col6, "Address");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateInvalidReadingsInvalidReadDataValidation()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col7, "Invalid Read");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateInvalidReadingsInvalidReadDateDataValidation()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col8, "Invalid Read Date");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateInvalidReadingsCommCodeDataValidation()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col9, "Comment Code");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateInvalidReadingsLastReadDataValidation()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col10, "Last Read");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateInvalidReadingsLastReadDateDataValidation()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col11, "Last Read Date");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateInvalidReadingsBackToReports()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            driver.WaitForElement(backToReports, TimeSpan.FromSeconds(10));
            driver.ClickElement(backToReports, "Back To Reports");
        }

        public void ValidateInvalidReadingFromDateToDate()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(toDate, "To Date");
            driver.ClickElement(fromDate, "From Date");
        }

        public void ValidateDaysOfNoFlowIncludeExclude()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow (AMR)");
            driver.sleepTime(2000);
            driver.WaitForElement(include, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(include, "Include");
            driver.CheckElementDisplayed(exclude, "Exclude");
        }

        public void ValidateDaysOfNoFlowIncludeExcludeNotDisplayed()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow (AMR)");

            driver.CheckElementDoesnotExists(include, "Include");
            driver.CheckElementDoesnotExists(exclude, "Exclude");
        }

        public void ValidateDaysOfCosumptionIncludeExclude()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption (AMR)");
            driver.WaitForElement(include, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(include, "Include");
            driver.CheckElementDisplayed(exclude, "Exclude");
        }

        public void ValidateDaysOfCosumptionIncludeExcludeNotDisplayed()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption (AMR)");
            driver.WaitForElement(include, TimeSpan.FromMinutes(1));
            driver.CheckElementDoesnotExists(include, "Include");
            driver.CheckElementDoesnotExists(exclude, "Exclude");
        }

        public void ValidateAmiNOFlowIncludeExclude()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.WaitForElement(include, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(include, "Include");
            driver.CheckElementDisplayed(exclude, "Exclude");
        }

        public void ValidateAmiNOFlowIncludeExcludeDisabled()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.WaitForElement(include, TimeSpan.FromMinutes(1));
            driver.CheckElementDoesnotExists(include, "Include");
            driver.CheckElementDoesnotExists(exclude, "Exclude");
        }

        public void ValidateInactiveFlowIncludeExclude()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            driver.sleepTime(2000);
            driver.WaitForElement(include, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(include, "Include");
            driver.CheckElementDisplayed(exclude, "Exclude");
        }

        public void ValidateInactiveFlowIncludeExcludeDisabled()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            driver.sleepTime(2000);
            driver.WaitForElement(include, TimeSpan.FromMinutes(1));
            driver.CheckElementDoesnotExists(include, "Include");
            driver.CheckElementDoesnotExists(exclude, "Exclude");
        }

        public void ValidateHighConsumptionIncludeExclude()
        {
            driver.ClickElement(highCosumption, "High Consumption");
            driver.sleepTime(2000);
            driver.WaitForElement(include, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(include, "Include");
            driver.CheckElementDisplayed(exclude, "Exclude");
        }

        public void ValidateHighConsumptionIncludeExcludeDisabled()
        {
            driver.ClickElement(highCosumption, "High Consumption");
            driver.sleepTime(2000);
            driver.WaitForElement(include, TimeSpan.FromMinutes(1));
            driver.CheckElementDoesnotExists(include, "Include");
            driver.CheckElementDoesnotExists(exclude, "Exclude");
        }

        public void ValidateHighConsumptionDefaultDay()
        {
            driver.ClickElement(highCosumption, "High Consumption");
            driver.sleepTime(2000);
            driver.WaitForElement(days, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(days, "Days");
            string s = driver.GetElementText(days);
            testReport.Info("Default Days : " + s);
        }

        public void ValidateHighConsumptionMaximumAllowedValue()
        {
            driver.ClickElement(highCosumption, "High Consumption");
            driver.sleepTime(2000);
            driver.WaitForElement(days, TimeSpan.FromMinutes(1));
            driver.ClickElement(days, "Days");
            if (driver.CheckElementDisplayed(By.XPath("//li[contains(.,'30')]"), "Value"))
            {
                testReport.Pass("30 Days is the maximum allowed value for the Days number field");
            }
            else
            {
                ReporterFactory.LogFailure("30 Days is not the maximum allowed value for the Days number field");
            }
        }

        public void ValidateHighConsumptionMinimumAllowedValue()
        {
            driver.ClickElement(highCosumption, "High Consumption");
            driver.sleepTime(2000);
            driver.WaitForElement(days, TimeSpan.FromMinutes(1));
            driver.ClickElement(days, "Days");
            if (driver.CheckElementDisplayed(By.XPath("//li[contains(.,'1')]"), "Value"))
            {
                testReport.Pass("1 Days is the minimum allowed value for the Days number field");
            }
            else
            {
                ReporterFactory.LogFailure("1 Days is not the minimum allowed value for the Days number field");
            }
        }

        public void ValidateHighConsumpOverAmountFieldDisplay()
        {
            driver.ClickElement(highCosumption, "High Consumption");
            driver.sleepTime(2000);
            driver.WaitForElement(overAmount, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(overAmount, "Over Amount");
        }

        public void ValidateHighConsumpDefaultValue()
        {
            driver.ClickElement(highCosumption, "High Consumption");
            driver.sleepTime(2000);
            driver.WaitForElement(overAmount, TimeSpan.FromMinutes(1));
            string s = driver.GetElementText(overAmount);
            testReport.Info("By default value displayed is: " + s);
        }

        public void ValidateHighConsumpMinThreshold()
        {
            driver.ClickElement(highCosumption, "High Consumption");
            driver.sleepTime(2000);
            driver.WaitForElement(minThreshold, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(minThreshold, "Minimum Threshold");
            string s = driver.GetElementText(minThreshold);
            testReport.Info("By default Minimum Threshold value displayed is: " + s);
        }


        // <summary>
        /// Method to Validate Report Date updated
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateReportDateUpdated()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(reportDate, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(reportDate, "Report Date");
            string s = driver.GetElementText(reportDate);
            testReport.Pass("Data on the detailed report is updated and displays to match the date range is : " + s);
            //driver.SwitchToDefaultFrame();

        }
        // <summary>
        /// Method to Validate Days of Consumption MIU
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionMIU()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col3, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col3, "MIU");
            ////driver.SwitchToDefaultFrame();
        }
        // <summary>
        /// Method to Validate Days of Consumption Acc Name
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionAccName()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col4, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col4, "Acc Name");

            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Days of Consumption Acc Number
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionAccNumber()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col5, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col5, "Acc Number");
            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Days of Consumption Address
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionAddress()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col6, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col6, "Address");

            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Days of Consumption Days Range
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionDaysRange()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col8, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col8, "Days Range");

            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Days of ConsumptionReading
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumptionReading()
        {
            driver.ClickElement(daysOfConsumption, "Days of Consumption AMR");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col9, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col9, "Reading");

            ////driver.SwitchToDefaultFrame();
        }


        // <summary>
        /// Method to Validate DaysOfNoFlow PDF Icon
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysOfNoFlowPDFIcon()
        {
            driver.ClickElement(daysOfNoFlowAMR, "DaysOfNoFlow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF Icon");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysOfNoFlowBreadcrumb()
        {
            driver.ClickElement(daysOfNoFlowAMR, "DaysOfNoFlow");
            driver.WaitForElement(breadcrumb, TimeSpan.FromSeconds(10));
            string s = driver.GetElementText(breadcrumb);
            if (s.Contains("DAYS OF NO FLOW"))
            {
                testReport.Pass("DAYS OF NO FLOW(AMR) is displayed in the breadcrumb link");
            }
        }

        public void ValidateDaysOfConsumptionBreadcrumb()
        {
            driver.ClickElement(daysOfConsumption, "daysOfConsumption AMR");
            driver.WaitForElement(breadcrumb, TimeSpan.FromSeconds(10));
            string s = driver.GetElementText(breadcrumb);
            if (s.Contains("DAYS OF CONSUMPTION"))
            {
                testReport.Pass("DAYS OF CONSUMPTION (AMR) is displayed in the breadcrumb link");
            }
        }

        public void ValidateDaysOfNoFlowURL()
        {
            driver.ClickElement(daysOfNoFlowAMR, "DaysOfNoFlow");
            if (driver.Url.Contains("daysofnoflow"))
            {
                testReport.Pass("daysofnoflow is displayed in the URL");
            }
        }

        public void ValidateDaysOfConsumptionURL()
        {
            driver.ClickElement(daysOfConsumption, "Days Of Consumption");
            if (driver.Url.Contains("daysofnoflow"))
            {
                testReport.Pass("DaysOfConsumption is displayed in the URL");
            }
        }


        public void ValidateInvalidReadingPDFIcon()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF Icon");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateInvalidReadingExcelIcon()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel Icon");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateCommentsBeginDate()
        {
            driver.ClickElement(comments, "Comments");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromMinutes(1));
            driver.ClickElement(fromDate, "From Date");
        }



        // <summary>
        /// Method to Validate Found Meters PDF Icon
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateFoundMetersPDFIcon()
        {
            driver.ClickElement(foundMeters, "DaysOfNoFlow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF Icon");
            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Found Meters Excel Icon
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateFoundMetersExcelIcon()
        {
            driver.ClickElement(foundMeters, "Found Meters");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));

            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel Icon");
            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate DaysOfConsumption PDF Icon
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysOfConsumptionPDFIcon()
        {
            driver.ClickElement(daysOfConsumption, "Days Of Consumption");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF Icon");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateAMINoFlowPDFIcon()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF Icon");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateCommentsPDFIcon()
        {
            driver.ClickElement(comments, "Comments");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));

            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF Icon");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateCommentsExcelIcon()
        {
            driver.WaitForElement(comments, TimeSpan.FromSeconds(30));
            driver.ClickElement(comments, "Comments");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel Icon");
        }

        public void ValidateCommentsResultsByDate()
        {
            IList<DateTime> datesOriginalOrder = new List<DateTime>();
            IList<DateTime> datesDescendingOrder = new List<DateTime>();

            driver.WaitForElement(comments, TimeSpan.FromSeconds(30));
            driver.ClickElement(comments, "Comments");
            CultureInfo provider = CultureInfo.GetCultureInfo("en-US");
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            var dateColumnElements = driver.FindElements(dateColumnValues);

            try
            {
                foreach (var element in dateColumnElements)
                {
                    datesOriginalOrder.Add(DateTime.ParseExact(element.Text, "MM/dd/yyyy", provider));
                    datesDescendingOrder.Add(DateTime.ParseExact(element.Text, "MM/dd/yyyy", provider));

                }
            }
            catch (Exception ex)
            { }

            datesDescendingOrder.OrderByDescending(c => c).ToList();

            if (datesOriginalOrder.SequenceEqual(datesDescendingOrder))
            {
                testReport.Pass("Data displayed in the Comments Reports are ordered by date.");
            }
            else
            {
                ReporterFactory.LogFailure("Data displayed in the Comments Reports are NOT ordered by date.");
            }
        }

        public void ValidateAMINoFlowExcelIcon()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel Icon");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateHighConumptionDisplay()
        {
            driver.WaitForElement(highCosumption, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(highCosumption, "High Consumption");
        }

        public void ValidateHighConumptionNotDisplay()
        {
            driver.CheckElementDoesnotExists(highCosumption, "High Consumption");
        }


        public void ValidateHighConumptionAccess()
        {
            driver.ClickElement(highCosumption, "High Consumption");
            driver.WaitForElement(breadcrumb, TimeSpan.FromSeconds(10));
            if (driver.GetElementText(breadcrumb).Contains("HIGH CONSUMPTION"))
            {
                testReport.Pass("High Consumption Detailed Report is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("High Consumption Detailed Report is displayed");
            }
        }

        // <summary>
        /// Method to Validate DaysOfConsumption Excel Icon
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysOfConsumptionExcelIcon()
        {
            driver.ClickElement(daysOfConsumption, "Days Of Consumption");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel Icon");
            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate DaysOfNoFlow Excel Icon
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysOfNoFlowExcelIcon()
        {
            driver.ClickElement(daysOfNoFlowAMR, "DaysOfNoFlow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel Icon");
            ////driver.SwitchToDefaultFrame();
        }


        // <summary>
        /// Method to Validate Mach10 PDF Icon
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateMach10PDFIcon()
        {
            driver.ClickElement(mach10Battery, "Mach 10 Battery");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF Icon");
            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Mach10 EXcel Icon
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateMach10ExcelIcon()
        {
            driver.ClickElement(mach10Battery, "Mach 10 Battery");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel Icon");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateMach10InactiveMeters()
        {
            driver.ClickElement(mach10Battery, "Mach 10 Battery");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(inactiveMeters, "Inactive Meters");
            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Mach10 Column Display
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateMach10ColumnDisplay()
        {
            driver.ClickElement(mach10Battery, "Mach 10 Battery");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, "MIU ID");
            driver.CheckElementDisplayed(Col2, "Premises");
            driver.CheckElementDisplayed(Col3, "Accout Name");
            driver.CheckElementDisplayed(Col4, "Address");
            driver.CheckElementDisplayed(Col5, "Account No");
            driver.CheckElementDisplayed(Col6, "Initial Event Date Time");
            driver.CheckElementDisplayed(Col7, "Days Of Low Power");
            driver.CheckElementDisplayed(Col8, "Register ID");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateSoftDisconnetColumnDisplay()
        {
            driver.ClickElement(softDisconnect, "Soft Disconnect");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, driver.GetElementText(Col1).ToString());
            driver.CheckElementDisplayed(Col2, driver.GetElementText(Col2).ToString());
            driver.CheckElementDisplayed(Col3, driver.GetElementText(Col3).ToString());
            driver.CheckElementDisplayed(Col4, driver.GetElementText(Col4).ToString());
            driver.CheckElementDisplayed(Col5, driver.GetElementText(Col5).ToString());
            driver.CheckElementDisplayed(Col6, driver.GetElementText(Col6).ToString());
            driver.CheckElementDisplayed(Col7, driver.GetElementText(Col7).ToString());
            driver.CheckElementDisplayed(Col8, driver.GetElementText(Col8).ToString());
            driver.CheckElementDisplayed(Col9, driver.GetElementText(Col9).ToString());
            driver.CheckElementDisplayed(Col11, driver.GetElementText(Col11).ToString());
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateSoftDisconnetAccName()
        {
            driver.ClickElement(softDisconnect, "Soft Disconnect");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col2, driver.GetElementText(Col2).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateSoftDisconnetCycleRoute()
        {
            driver.ClickElement(softDisconnect, "Soft Disconnect");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, driver.GetElementText(Col1).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowAccName()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "Days Of Consecutive Flow (AMI)");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, driver.GetElementText(Col1).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowConsumAccName()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col2, driver.GetElementText(Col2));
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowConsumLastReadDate()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col13, driver.GetElementText(Col13));
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowConsumColumnsDisplay()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));

            driver.CheckElementDisplayed(Col1, driver.GetElementText(Col1));
            driver.CheckElementDisplayed(Col2, driver.GetElementText(Col2));
            driver.CheckElementDisplayed(Col3, driver.GetElementText(Col3));
            driver.CheckElementDisplayed(Col4, driver.GetElementText(Col4));
            driver.CheckElementDisplayed(Col5, driver.GetElementText(Col5));
            driver.CheckElementDisplayed(Col6, driver.GetElementText(Col6));
            driver.CheckElementDisplayed(Col7, driver.GetElementText(Col7));
            driver.CheckElementDisplayed(Col8, driver.GetElementText(Col8));
            driver.CheckElementDisplayed(Col9, driver.GetElementText(Col9));
            driver.CheckElementDisplayed(Col10, driver.GetElementText(Col10));
            driver.CheckElementDisplayed(Col11, driver.GetElementText(Col11));
            driver.CheckElementDisplayed(Col12, driver.GetElementText(Col12));
            driver.CheckElementDisplayed(Col13, driver.GetElementText(Col13));
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowConsumEventStopReadDate()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));

            driver.CheckElementDisplayed(eventReadStopDateData, driver.GetElementText(eventReadStopDateData));
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowConsumRouteFilterValues()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            driver.WaitForElement(routeFilter, TimeSpan.FromSeconds(30));
            driver.ClickElement(routeFilter, "Route Filter");
            driver.CheckElementDisplayed(routeAll, "Values");
        }
        public void ValidateDaysOfConsFlowConsumRouteFilterNoRoute()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            driver.WaitForElement(routeFilter, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(routeFilter, "Route Filter");
        }

        public void ValidateDaysOfConsFlowConsumToDate()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            driver.WaitForElement(toDate, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(toDate, "To Date");
        }
        public void ValidateDaysOfConsFlowConsumToDateEditable()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            driver.WaitForElement(toDate, TimeSpan.FromSeconds(10));
            driver.ClickElement(toDate, "To Date");
        }

        public void ValidateDaysOfConsFlowConsumFromDate()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            driver.WaitForElement(toDate, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(fromDate, "From Date");
        }
        public void ValidateDaysOfConsFlowConsumFromDateEditable()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            driver.WaitForElement(toDate, TimeSpan.FromSeconds(10));
            driver.ClickElement(fromDate, "From Date");
        }
        public void ValidateDaysOfConsFlowConsumGroupFilter()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            driver.WaitForElement(groupFilter, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(groupFilter, "group Filter");
        }

        public void ValidateDaysOfConsFlowConsBasedEventStartDateData()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(eventReadstartDateData, driver.GetElementText(eventReadstartDateData));
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowConsBasedMeterSizeData()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(metersizeData, driver.GetElementText(metersizeData));
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysOfConsFlowConsBasedMIUID()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col4, driver.GetElementText(Col4));
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowConsBasedMeterNo()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col5, driver.GetElementText(Col5));
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowConsBasedAddress()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col3, driver.GetElementText(Col3));
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysOfConsFlowConsBasedCycle()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, driver.GetElementText(Col1));
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowConsBasedEventStopRead()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(eventReadStopDateData, driver.GetElementText(eventReadStopDateData));
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowConsBasedAccess()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(daysOfConsFlowConsmBasedHeader, driver.GetElementText(daysOfConsFlowConsmBasedHeader));
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysOfConsFlowConsBasedExportExcel()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export ");
            driver.CheckElementDisplayed(exportExcel, "Export Excel");
            //driver.SwitchToDefaultFrame();
        }


        public void ValidateDaysOfConsFlowConsBasedDisplay()
        {
            driver.CheckElementDisplayed(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
        }

        public void ValidateDaysOfConsFlowConsBasedSelectRoute()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            driver.WaitForElement(routeFilter, TimeSpan.FromSeconds(20));
            driver.ClickElement(routeFilter, "routeFilter");
            driver.ClickElement(routeOne, "Route");
        }
        public void ValidateDaysOfConsFlowConsBasedSelectGrpExclude()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            driver.WaitForElement(exclude, TimeSpan.FromSeconds(20));
            driver.ClickElement(exclude, "exclude");
            driver.ClickElement(groupFilter, "groupFilter");
            driver.ClickElement(routeOne, "Group 1");
            driver.sleepTime(5000);
        }
        public void ValidateDaysOfConsFlowConsBasedSelectGrpInclude()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            driver.WaitForElement(exclude, TimeSpan.FromSeconds(20));
            driver.ClickElement(include, "Include");
            driver.ClickElement(groupFilter, "groupFilter");
            driver.ClickElement(routeOne, "Group 1");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));

            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysOfConsFlowConsBasedSelectOneGroup()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            driver.WaitForElement(exclude, TimeSpan.FromSeconds(20));

            driver.ClickElement(groupFilter, "groupFilter");
            driver.ClickElement(routeTwo, "Group 1");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));

            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowConsBasedFromDateToDate()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(fromDateData, "From Date");
            driver.CheckElementDisplayed(toDateData, "To date");
        }
        public void ValidateDaysOfConsFlowConsBasedLastReadDateData()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            driver.WaitForElement(exclude, TimeSpan.FromSeconds(20));
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(lastReaddateData, driver.GetElementText(lastReaddateData));
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowConsBasedExport()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            driver.WaitForElement(exclude, TimeSpan.FromSeconds(20));
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(exportLink, "Export Link");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowConsBasedExportPDF()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            driver.WaitForElement(exclude, TimeSpan.FromSeconds(20));
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(180));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysOfConsFlowConsBasedReportDate()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(exclude, TimeSpan.FromSeconds(20));
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");           
            driver.CheckElementDisplayed(reportDate, driver.GetElementText(reportDate));
            //driver.SwitchToDefaultFrame();
        }


        public void ValidateDaysOfConsFlowAvgDailyFlowEvent()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col10, driver.GetElementText(Col10));
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowDateRange()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(reportDate, driver.GetElementText(reportDate));
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowConsBasedUOM()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col12, driver.GetElementText(Col12));
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysOfConsFlowAddress()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "Days Of Consecutive Flow (AMI)");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col3, driver.GetElementText(Col3).ToString());
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowMeterNo()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "Days Of Consecutive Flow (AMI)");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col5, driver.GetElementText(Col5).ToString());
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowMiuId()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "Days Of Consecutive Flow (AMI)");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col4, driver.GetElementText(Col4).ToString());
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowMeterSize()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "Days Of Consecutive Flow (AMI)");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col6, driver.GetElementText(Col6).ToString());
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowFlagStartDate()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "Days Of Consecutive Flow (AMI)");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(1));
            driver.CheckElementDisplayed(Col7, driver.GetElementText(Col7).ToString());
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowFlagStopDate()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "Days Of Consecutive Flow (AMI)");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col8, driver.GetElementText(Col8).ToString());
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowLastReadDate()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "Days Of Consecutive Flow (AMI)");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ScrollToElement(driver.FindElement(Col14));
            driver.CheckElementDisplayed(Col14, driver.GetElementText(Col14).ToString());
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowUOM()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "Days Of Consecutive Flow (AMI)");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col13, driver.GetElementText(Col13).ToString());
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowAvgDailyFlow()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "Days Of Consecutive Flow (AMI)");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col11, driver.GetElementText(Col11).ToString());
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowAvgDailyPrior()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "Days Of Consecutive Flow (AMI)");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col12, driver.GetElementText(Col12).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowFlowType()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "Days Of Consecutive Flow (AMI)");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col9, driver.GetElementText(Col9).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateDaysOfConsFlowDays()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "Days Of Consecutive Flow (AMI)");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col10, driver.GetElementText(Col10).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInactiveFlowCycleRoute()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, driver.GetElementText(Col1).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInactiveFlowAccName()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col2, driver.GetElementText(Col2).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInactiveFlowAccNo()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col3, driver.GetElementText(Col3).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInactiveFlowAddress()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col4, driver.GetElementText(Col4).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInactiveFlowMIuID()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col5, driver.GetElementText(Col5).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInactiveFlowMeterNo()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col6, driver.GetElementText(Col6).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInactiveFlowMeterSize()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col7, driver.GetElementText(Col7).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInactiveFlowAccStatus()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col8, driver.GetElementText(Col8).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInactiveConsumption()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col9, driver.GetElementText(Col9).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInactiveFlowUOM()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col10, driver.GetElementText(Col10).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInactiveFlowBacktoReportsDisplay()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            //driver.sleepTime(2000);
            driver.WaitForElement(backToReports, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(backToReports, "Back To Reports");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInactiveFlowBacktoReportsClick()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            driver.WaitForElement(backToReports, TimeSpan.FromMinutes(1));
            driver.ClickElement(backToReports, "Back To Reports");
        }
        public void ValidateInactiveFlowBackGroupFilterDislay()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            driver.WaitForElement(groupFilter, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(groupFilter, "Group Filter");
        }
        public void ValidateInactiveFlowBackGroupFilterSelected()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            driver.WaitForElement(groupFilter, TimeSpan.FromMinutes(1));
            driver.ClickElement(groupFilter, "Group Filter");
        }
        public void ValidateInactiveFlowBackGroupFilterOneSeleted()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            driver.WaitForElement(groupFilter, TimeSpan.FromMinutes(1));
            driver.ClickElement(groupFilter, "Group Filter");
            driver.ClickElement(routeOne, "");
        }
        public void ValidateInactiveFlowBackRouteFilterDisplay()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(routeFilter, "Route Filter");
        }
        public void ValidateAMINoFlowBackRouteFilterDisplay()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(routeFilter, "Route Filter");
        }
        public void ValidateAMINoFlowBackGroupFilterDisplay()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.WaitForElement(groupFilter, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(groupFilter, "Group Filter");
        }
        public void ValidateAMINoFlowNoRouteSelected()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            driver.ClickElement(routeFilter, "Route Filter");
            driver.ClickElement(routeOne, "");
        }
        public void ValidateAMINoFlowNoGroupSelected()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            driver.WaitForElement(groupFilter, TimeSpan.FromMinutes(1));
            driver.ClickElement(groupFilter, "Group Filter");
            driver.ClickElement(routeOne, "");
        }
        public void ValidateEndpointMaintenanceGroupSelected()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            driver.WaitForElement(groupFilter, TimeSpan.FromMinutes(1));
            driver.ClickElement(groupFilter, "Group Filter");
            //driver.ClickElement(routeOne, "");
        }
        public void ValidateEndpointMaintenanceMapIcon()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            driver.WaitForElement(neverReceivedKPI, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(neverReceivedKPI, "never Received Rollup");
            driver.ClickElement(mapView, "Map");
        }
        public void ValidateEndpointMaintenanceInvalidReadsMapIcon()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            driver.WaitForElement(invalidReadsKPI, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(invalidReadsKPI, "invalidReadsRollup");
            driver.ClickElement(mapView, "Map");
        }
        public void ValidateEndpointMaintenancePastDueMapIcon()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            driver.WaitForElement(pastDueKPI, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(pastDueKPI, "past Due Rollup");
            driver.ClickElement(mapView, "Map");
        }
        public void ValidateEndpointMaintenanceTotalMIUMapIcon()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            driver.WaitForElement(totalMiuKPI, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(totalMiuKPI, "totalMiuKPI");
            driver.ClickElement(mapView, "Map");
        }

        public void ValidateEndpointMaintenanceDatePickers()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            driver.WaitForElement(datePicker, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(datePicker, "Date Picker");
            //driver.ClickElement(routeOne, "");
        }
        public void ValidateEndpointMaintenanceCustInqLink()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            driver.WaitForElement(row1, TimeSpan.FromMinutes(1));
            driver.MoveToElement(row1, "");
            driver.MouseHoverByJavaScript(row1, "");
            driver.MoveToElement(row1,"Row 1");
            driver.sleepTime(5000);
            driver.WaitForElement(custInqLink, TimeSpan.FromMinutes(1));
            driver.MoveToElement(custInqLink, "Row 1");
            driver.ClickElementUsingAdvancedAction(custInqLink, "custInqLink");
            driver.switchToNewWindow();

            driver.navigateToMainWindow();
        }
        public void ValidateDaysOfConsecFlowFlagBasedCustInqLink()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "daysOfConsFlowFlagBased");
            driver.WaitForElement(row1, TimeSpan.FromMinutes(3));
            driver.ScrollToElement(driver.FindElement(lastRowHeader));
            driver.MoveToElement(row1LastCell, "");
            driver.MouseHoverByJavaScript(row1LastCell, "");
            driver.sleepTime(5000);
            driver.WaitForElement(custInqLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(custInqLink, "custInqLink");
            driver.switchToNewWindow();

            driver.navigateToMainWindow();
        }
        public void ValidateDaysOfConsecFlowConsBasedCustInqLink()
        {
            driver.ClickElement(daysOfConsFlowConsBased, "daysOfConsFlow Consumption Based");
            driver.WaitForElement(row1, TimeSpan.FromMinutes(3));
            driver.ScrollToElement(driver.FindElement(lastRowHeader));

            driver.MoveToElement(row1LastCell, "");
            driver.MouseHoverByJavaScript(row1LastCell, "");
            driver.sleepTime(5000);
            driver.WaitForElement(custInqLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(custInqLink, "custInqLink");
            driver.switchToNewWindow();

            driver.navigateToMainWindow();
        }
        public void ValidateSoftDisconnectCustInqLink()
        {
            driver.ClickElement(softDisconnect, "soft Disconnect");
            driver.sleepTime(5000);
            driver.WaitForElement(row1, TimeSpan.FromMinutes(3));
            driver.ScrollToElement(driver.FindElement(lastRowHeader));
            driver.MoveToElement(row1LastCell, "");

            //driver.MouseHoverByJavaScript(row1LastCell, "");
            driver.sleepTime(5000);
            //driver.MoveToElement(custInqLink, "");
            driver.MoveToElement(custInqLink, "");

            driver.WaitForElement(custInqLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(custInqLink, "custInqLink");
            driver.switchToNewWindow();
            driver.navigateToMainWindow();
        }
        public void ValidateEndpointMaintenanceDisplay()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            driver.WaitForElement(breadcrumb, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(breadcrumb, driver.GetElementText(breadcrumb));
            //driver.ClickElement(routeOne, "");
        }

        public void ValidateEndpointConsumptionDisplay()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(breadcrumb, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(breadcrumb, driver.GetElementText(breadcrumb));
        }

        public void ValidateEndpointConsumptionHourlyGroupInterval()

        {

            driver.ClickElement(endpointConsumption, "Endpoint Consumption");

            driver.WaitForElement(hourlyCheckbox, TimeSpan.FromMinutes(1));

            driver.ClickElement(hourlyCheckbox, "Hourly");

            driver.ClickElement(groupCheckbox, "Group");

            driver.ClickElement(groupDrpdown, "Groups Filter");

            driver.ClickElement(routeTwo, "Select");

            driver.ClickElement(btnSubmit, "Submit");

            driver.WaitForElement(reverseMeterSize, TimeSpan.FromSeconds(50));

            driver.CheckElementDisplayed(reverseMeterSize, "Reading");

        }
        public void ValidateEndpointConsumptionMIUIdCheckbox()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(hourlyCheckbox, TimeSpan.FromMinutes(1));
            driver.ClickElement(hourlyCheckbox, "Hourly");
            driver.ClickElement(groupCheckbox, "Group");
            driver.ClickElement(groupDrpdown, "Groups Filter");
            driver.ClickElement(routeTwo, "Select");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(reverseMeterSize, TimeSpan.FromSeconds(50));
            driver.CheckElementDisplayed(reverseMeterSize, "Reading");
        }
        public void ValidateEndpointConsumptionCheckbox()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuCheckbox, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(miuCheckbox, "MIU");
            driver.CheckElementDisplayed(groupCheckbox, "Groups");
        }
        public void ValidateEndpointConsumptionMIUIdCheckbox(string miuId)
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, "1", "");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(row1, TimeSpan.FromSeconds(20));
            driver.ClickElement(row1FirstCell, "Select");
            driver.ClickElement(btnOkChooseAccount, "OK");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(miuCheckboxEndpoint, "MIU ID Checkbox");
            driver.ClickElement(miuCheckboxEndpoint, "Miu Id Checkbox");
            driver.ClickElement(btnOkTableSetting, "Ok");
            driver.CheckElementDoesnotExists(reverseMIU, "MIU ID");
        }
        public void ValidateEndpointConsumptionReverseReadingCheckbox()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, "1", "");

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(installDateCol, TimeSpan.FromSeconds(30));

            driver.ClickElement(installDateCol, "installDate Column");
            driver.ClickElement(installDateCol, "installDate Column");
            driver.WaitForElement(row1, TimeSpan.FromSeconds(20));
            driver.ClickElement(row1FirstCell, "Select");
            driver.ClickElement(btnOkChooseAccount, "OK");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(readingCheckboxEndpoint, "reading Checkbox");
            driver.ClickElement(readingCheckboxEndpoint, "reading Checkbox");
            driver.ClickElement(btnOkTableSetting, "Ok");
            driver.CheckElementDoesnotExists(reverseReading, "Reading");
        }
        public void ValidateEndpointConsumptionAddressCheckbox()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, "1", "");

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(installDateCol, TimeSpan.FromSeconds(30));

            driver.ClickElement(installDateCol, "installDate Column");
            driver.ClickElement(installDateCol, "installDate Column");
            driver.WaitForElement(row1, TimeSpan.FromSeconds(20));
            driver.ClickElement(row1FirstCell, "Select");
            driver.ClickElement(btnOkChooseAccount, "OK");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(addressCheckboxEndpoint, "Address Checkbox");
            driver.ClickElement(addressCheckboxEndpoint, "Address Checkbox");
            driver.ClickElement(btnOkTableSetting, "Ok");
            driver.CheckElementDoesnotExists(reverseAddress, "Address");
        }
        public void ValidateEndpointConsumptionAccNameCheckbox()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, "1", "");

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(installDateCol, TimeSpan.FromSeconds(30));

            driver.ClickElement(installDateCol, "installDate Column");
            driver.ClickElement(installDateCol, "installDate Column");
            driver.WaitForElement(row1FirstCell, TimeSpan.FromSeconds(20));
            driver.ClickElement(row1FirstCell, "Select");
            driver.ClickElement(btnOkChooseAccount, "OK");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(accNameCheckboxEndpoint, "Acc Name Checkbox");
            driver.ClickElement(accNameCheckboxEndpoint, "Acc Name Checkbox");
            driver.ClickElement(btnOkTableSetting, "Ok");
            driver.CheckElementDoesnotExists(reverseAccName, "account Name");
        }
        public void ValidateEndpointConsumptionMIUSelection(string miuId)
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, miuId, "miu Id");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(row1, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(row1, "Account Details");
            driver.ClickElement(btnCancel, "Close");
        }
        public void ValidateEndpointConsumptionMIUSelected(string miuId)
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, miuId, "miu Id");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(row1, TimeSpan.FromSeconds(20));
            driver.ClickElement(row1, "Account Details");
            driver.ClickElement(btnOkChooseAccount, "OK");
            driver.WaitForElement(reportDate, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reportDate, "Report");
        }
        public void ValidateEndpointConsumptionMIUNotFound(string miuId)
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, miuId, "miu Id");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(miuNotFound, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(miuNotFound, driver.GetElementText(miuNotFound));

        }
        public void ValidateEndpointConsumptionColumns(string miuId)
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, miuId, "miu Id");
            driver.ClickElement(btnSubmit, "Submit");
            driver.ClickElement(btnCancel, "OK");
            driver.WaitForElement(reportDate, TimeSpan.FromSeconds(30));
        }
        public void ValidateEndpointConsumptionBackButton()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(backToReports, TimeSpan.FromSeconds(30));
            driver.ClickElement(backToReports, "Back button");
        }
        public void ValidateEndpointConsumptionMeterSizeCheckbox()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, "1", "");

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(installDateCol, TimeSpan.FromSeconds(30));

            driver.ClickElement(installDateCol, "installDate Column");
            driver.ClickElement(installDateCol, "installDate Column");
            driver.WaitForElement(row1FirstCell, TimeSpan.FromSeconds(20));
            driver.ClickElement(row1FirstCell, "Select");
            driver.ClickElement(btnOkChooseAccount, "OK");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(meterSizeCheckboxEndpoint, "meter Size Checkbox");
            driver.ClickElement(meterSizeCheckboxEndpoint, "meter Size Checkbox");
            driver.ClickElement(btnOkTableSetting, "Ok");
            driver.CheckElementDoesnotExists(meterSize, "Meter Size");
        }
        public void ValidateEndpointConsumptionMeterNoCheckbox()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, "1", "");

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(installDateCol, TimeSpan.FromSeconds(30));

            driver.ClickElement(installDateCol, "installDate Column");
            driver.ClickElement(installDateCol, "installDate Column");
            driver.WaitForElement(row1FirstCell, TimeSpan.FromSeconds(20));
            driver.ClickElement(row1FirstCell, "Select");
            driver.ClickElement(btnOkChooseAccount, "OK");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(meterNoCheckboxEndpoint, "meter No Checkbox");
            driver.ClickElement(meterNoCheckboxEndpoint, "meter No Checkbox");
            driver.ClickElement(btnOkTableSetting, "Ok");
            driver.CheckElementDoesnotExists(meterNo, "Meter No");
        }

        public void ValidateEndpointConsumptionAccNoCheckbox()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, "1", "");

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(installDateCol, TimeSpan.FromSeconds(30));

            driver.ClickElement(installDateCol, "installDate Column");
            driver.ClickElement(installDateCol, "installDate Column");
            driver.WaitForElement(row1FirstCell, TimeSpan.FromSeconds(20));
            driver.ClickElement(row1FirstCell, "Select");
            driver.ClickElement(btnOkChooseAccount, "OK");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(accNoCheckboxEndpoint, "Acc No Checkbox");
            driver.ClickElement(accNoCheckboxEndpoint, "Acc No Checkbox");
            driver.ClickElement(btnOkTableSetting, "Ok");
            driver.CheckElementDoesnotExists(reverseAccNo, "Acc No");
        }
        public void ValidateEndpointConsumptionConsCheckbox()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, "1", "");

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(installDateCol, TimeSpan.FromSeconds(30));

            driver.ClickElement(installDateCol, "installDate Column");
            driver.ClickElement(installDateCol, "installDate Column");
            driver.WaitForElement(row1FirstCell, TimeSpan.FromSeconds(20));
            driver.ClickElement(row1FirstCell, "Select");
            driver.ClickElement(btnOkChooseAccount, "OK");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(consumptionEndpoint, "consumption Checkbox");
            driver.ClickElement(consumptionEndpoint, "consumption Checkbox");
            driver.ClickElement(btnOkTableSetting, "Ok");
            driver.CheckElementDoesnotExists(consumption, "Consumption");
        }

        public void ValidateEndpointConsumptionDateCheckbox()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, "1", "");

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(installDateCol, TimeSpan.FromSeconds(30));

            driver.ClickElement(installDateCol, "installDate Column");
            driver.ClickElement(installDateCol, "installDate Column");
            driver.WaitForElement(row1FirstCell, TimeSpan.FromSeconds(20));
            driver.ClickElement(row1FirstCell, "Select");
            driver.ClickElement(btnOkChooseAccount, "OK");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(dateCheckboxEndpoint, "Date Checkbox");
            driver.ClickElement(dateCheckboxEndpoint, "Date Checkbox");
            driver.ClickElement(btnOkTableSetting, "Ok");
            driver.CheckElementDoesnotExists(date, "Date");
        }
        public void ValidateEndpointConsumptionUOMCheckbox()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, "1", "");

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(installDateCol, TimeSpan.FromSeconds(30));

            driver.ClickElement(installDateCol, "installDate Column");
            driver.ClickElement(installDateCol, "installDate Column");
            driver.WaitForElement(row1FirstCell, TimeSpan.FromSeconds(20));
            driver.ClickElement(row1FirstCell, "Select");
            driver.ClickElement(btnOkChooseAccount, "OK");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(uomCheckboxEndpoint, "UOM Checkbox");
            driver.ClickElement(uomCheckboxEndpoint, "UOM Checkbox");
            driver.ClickElement(btnOkTableSetting, "Ok");
            driver.CheckElementDoesnotExists(uom, "UOM");
        }

        public void ValidateReverseFlowCycleRouteCheckbox()
        {
            driver.ClickElement(reverseFlow, "Reverse Flow");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            if (driver.IsElementPresent(reverseCycleRoute))
            {
                driver.ClickElement(btnTableSetting, "Table Setting");
                driver.CheckElementDisplayed(reverseFlowCycleCheckbox, "Cycle/Route Checkbox");
                driver.ClickElement(reverseFlowCycleCheckbox, "Cycle/Route Checkbox");
                driver.ClickElement(btnOkTableSetting, "Ok");
            }
            else
            {
                driver.CheckElementDoesnotExists(reverseCycleRoute, "Cycle Route");
            }
        }

        public void ValidateReverseFlowAccNoCheckbox()
        {
            driver.ClickElement(reverseFlow, "Reverse Flow");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            if (driver.IsElementPresent(reverseAccNo))
            {
                driver.ClickElement(btnTableSetting, "Table Setting");
                driver.CheckElementDisplayed(reverseFlowAccNoCheckbox, "AccNo Checkbox");
                driver.ClickElement(reverseFlowAccNoCheckbox, "AccNo Checkbox");
                driver.ClickElement(btnOkTableSetting, "Ok");
            }
            else
            {
                driver.CheckElementDoesnotExists(reverseAccNo, "Acc No");
            }
        }

        public void ValidateReverseFlowMeterNoCheckbox()
        {
            driver.ClickElement(reverseFlow, "Reverse Flow");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));


            if (driver.ElementPresent(meterNo, "Meter No"))
            {
                driver.ClickElement(btnTableSetting, "Table Setting");
                driver.CheckElementDisplayed(reverseFlowMeterNoCheckbox, "Meter No Checkbox");
                driver.ClickElement(reverseFlowMeterNoCheckbox, "Meter No Checkbox");
                driver.ClickElement(btnOkTableSetting, "Ok");
                driver.CheckElementDoesnotExists(meterNo, "Meter No");
            }
            else
            {
                testReport.Info("Meter No is not displayed");
            }
        }
        public void ValidateReverseFlowMeterSizeCheckbox()
        {
            driver.ClickElement(reverseFlow, "Reverse Flow");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            if (driver.IsElementPresent(meterSize))
            {
                driver.ClickElement(btnTableSetting, "Table Setting");
                driver.CheckElementDisplayed(reverseFlowMeterSizeCheckbox, "Meter Size Checkbox");
                driver.ClickElement(reverseFlowMeterSizeCheckbox, "Meter Size Checkbox");
                driver.ClickElement(btnOkTableSetting, "Ok");
                driver.CheckElementDoesnotExists(meterSize, "Meter Size");
            }
            else
            {
                driver.CheckElementDoesnotExists(meterSize, "Meter Size");
            }
        }

        public void ValidateReverseFlowAccNameCheckbox()
        {
            driver.ClickElement(reverseFlow, "Reverse Flow");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            if (driver.IsElementPresent(reverseAccName))
            {
                driver.ClickElement(btnTableSetting, "Table Setting");
                driver.CheckElementDisplayed(reverseFlowAccNameCheckbox, "Acc Name Checkbox");
                driver.ClickElement(reverseFlowAccNameCheckbox, "Acc Name Checkbox");
                driver.ClickElement(btnOkTableSetting, "Ok");
                driver.CheckElementDoesnotExists(reverseAccName, "Acc Name");
            }
            else
            {
                driver.CheckElementDoesnotExists(reverseAccName, "Acc Name");
            }
        }
        public void ValidateReverseFlowAddressCheckbox()
        {
            driver.ClickElement(reverseFlow, "Reverse Flow");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));

            if (driver.IsElementPresent(reverseAddress))
            {
                driver.ClickElement(btnTableSetting, "Table Setting");
                driver.CheckElementDisplayed(reverseFlowAddressCheckbox, "Address Checkbox");
                driver.ClickElement(reverseFlowAddressCheckbox, "Address Checkbox");
                driver.ClickElement(btnOkTableSetting, "Ok");
                driver.CheckElementDoesnotExists(reverseAddress, "Address");
            }
            else
            {
                driver.CheckElementDoesnotExists(reverseAddress, "Address");
            }
        }

        public void ValidateReverseFlowAMRAMICheckbox()
        {
            driver.ClickElement(reverseFlow, "Reverse Flow");
            //driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            //driver.ClickElement(btnTableSetting, "Table Setting");            
            //IWebElement checkbox = driver.FindElement(reverseFlowAMRAMICheckbox);
            //if (checkbox.Selected == false)
            //{                
            //    driver.ClickElement(btnOkTableSetting, "Ok");
            //    driver.CheckElementDoesnotExists(reverseamiamr, "AMR/AMI");
            //}
            //else
            //{
            //    driver.CheckElementDisplayed(reverseFlowAMRAMICheckbox, "AMR/AMI Checkbox");
            //    driver.ClickElement(reverseFlowAMRAMICheckbox, "AMR/AMI Checkbox");
            //    driver.ClickElement(btnOkTableSetting, "Ok");
            //    driver.CheckElementDoesnotExists(reverseamiamr, "AMR/AMI");
            //}

            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            if (driver.IsElementPresent(reverseamiamr))
            {
                driver.ClickElement(btnTableSetting, "Table Setting");
                driver.ClickElement(reverseFlowAMRAMICheckbox, "AMR/AMI Checkbox");
                driver.ClickElement(btnOkTableSetting, "Ok");
                driver.CheckElementDoesnotExists(reverseamiamr, "AMR/AMI");
            }
            else
            {
                driver.CheckElementDoesnotExists(reverseamiamr, "AMR/AMI");
            }
        }
        public void ValidateReverseFlowFlagStartCheckbox()
        {
            driver.ClickElement(reverseFlow, "Reverse Flow");

            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            if (driver.IsElementPresent(flagStart))
            {
                driver.ClickElement(btnTableSetting, "Table Setting");
                driver.ClickElement(reverseFlowFlagStartcheckbox, "Flag Start Checkbox");
                driver.ClickElement(btnOkTableSetting, "Ok");
                driver.CheckElementDoesnotExists(flagStart, "flag Start");
            }
            else
            {
                driver.CheckElementDoesnotExists(flagStart, "flag Start");
            }
        }
        public void ValidateReverseFlowFlagStopCheckbox()
        {
            driver.ClickElement(reverseFlow, "Reverse Flow");

            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            if (driver.IsElementPresent(flagStop))
            {
                driver.ClickElement(btnTableSetting, "Table Setting");
                driver.ClickElement(reverseFlowFlagStopcheckbox, "Flag Stop Checkbox");
                driver.ClickElement(btnOkTableSetting, "Ok");
                driver.CheckElementDoesnotExists(flagStop, "flag Stop");
            }
            else
            {
                driver.CheckElementDoesnotExists(flagStop, "flag Stop");
            }
        }

        public void ValidateReverseFlowFlagTypeCheckbox()
        {
            driver.ClickElement(reverseFlow, "Reverse Flow");

            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            if (driver.IsElementPresent(flagType))
            {
                driver.ClickElement(btnTableSetting, "Table Setting");
                driver.ClickElement(reverseFlowFlagTypecheckbox, "Flag Type Checkbox");
                driver.ClickElement(btnOkTableSetting, "Ok");
                driver.CheckElementDoesnotExists(flagType, "flag Type");
            }
            else
            {
                driver.CheckElementDoesnotExists(flagType, "flag Type");
            }
        }
        public void ValidateReverseFlowReadingCheckbox()
        {
            driver.ClickElement(reverseFlow, "Reverse Flow");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            if (driver.IsElementPresent(reading))
            {
                driver.ClickElement(btnTableSetting, "Table Setting");
                driver.ClickElement(reverseReadingcheckbox, "Reading Checkbox");
                driver.ClickElement(btnOkTableSetting, "Ok");
                driver.CheckElementDoesnotExists(reading, "reading");
            }
            else
            {
                driver.CheckElementDoesnotExists(reading, "reading");
            }
        }
        public void ValidateReverseFlowReadingDateTimeCheckbox()
        {
            driver.ClickElement(reverseFlow, "Reverse Flow");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            if (driver.IsElementPresent(readingDateTime))
            {
                driver.ClickElement(btnTableSetting, "Table Setting");
                driver.ClickElement(reverseReadingDateTimecheckbox, "Reading Date Time Checkbox");
                driver.ClickElement(btnOkTableSetting, "Ok");
                driver.CheckElementDoesnotExists(readingDateTime, "reading Date Time");
            }
            else
            {
                driver.CheckElementDoesnotExists(readingDateTime, "reading Date Time");
            }
        }
        public void ValidateChangedReadParameters()
        {
            driver.CheckElementDisplayed(changedReadParameters, "Changed Read Parameters");
        }

        public void ValidateChangedReadParametersDefaultDate()
        {
            driver.ClickElement(changedReadParameters, "Changed Read Parameters");
            driver.WaitForElement(reportDateActiveSim, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(reportDateActiveSim, "Date");
        }
        public void ValidateChangedReadParametersSubtitle()
        {
            driver.ClickElement(changedReadParameters, "Changed Read Parameters");
            driver.WaitForElement(changedReadParaSubtitle, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(changedReadParaSubtitle, driver.GetElementText(changedReadParaSubtitle));
        }

        public void ValidateChangedReadParametersNoRouteSelected()
        {
            driver.ClickElement(changedReadParameters, "Changed Read Parameters");
            driver.WaitForElement(routeFilter, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(routeFilter, "No Route Selected");
        }

        public void ValidateChangedReadParametersIncludeOption()
        {
            driver.ClickElement(changedReadParameters, "Changed Read Parameters");
            driver.WaitForElement(include, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(include, "Include");
        }
        public void ValidateChangedReadParametersExcludeOption()
        {
            driver.ClickElement(changedReadParameters, "Changed Read Parameters");
            driver.WaitForElement(exclude, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(exclude, "exclude");
        }
        public void ValidateChangedReadParametersSpecificField()
        {
            driver.ClickElement(changedReadParameters, "Changed Read Parameters");
            driver.WaitForElement(specificField, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(specificField, "specific Field");
        }

        public void ValidateChangedReadParametersNoGroupSelected()
        {
            driver.ClickElement(changedReadParameters, "Changed Read Parameters");
            driver.WaitForElement(groupFilter, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(groupFilter, "No Group Selected");
        }

        public void ValidateEndpointConsumptionSelectAllCheckbox()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, "1", "");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(installDateCol, TimeSpan.FromSeconds(30));

            driver.ClickElement(installDateCol, "installDate Column");
            driver.ClickElement(installDateCol, "installDate Column");
            driver.WaitForElement(row1, TimeSpan.FromSeconds(20));
            driver.ClickElement(row1FirstCell, "Select");
           

            driver.ClickElement(btnOkChooseAccount, "OK");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(btnSelectAllTableSetting, "SelectAll");
            driver.ClickElement(btnOkTableSetting, "Ok");
        }

        public void ValidateEndpointConsumptionResetCheckbox()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, "1", "");

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(installDateCol, TimeSpan.FromSeconds(30));

            driver.ClickElement(installDateCol, "installDate Column");
            driver.ClickElement(installDateCol, "installDate Column");

            driver.ClickElement(row1FirstCell, "Select");
            driver.ClickElement(btnOkChooseAccount, "OK");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(btnResetTableSetting, "Reset");
            driver.ClickElement(btnOkTableSetting, "Ok");
        }

        public void ValidateEndpointConsumptionOKCheckbox()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, "1", "");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(installDateCol, TimeSpan.FromSeconds(30));

            driver.ClickElement(installDateCol, "installDate Column");
            driver.ClickElement(installDateCol, "installDate Column");

            driver.ClickElement(row1FirstCell, "Select");
            driver.ClickElement(btnOkChooseAccount, "OK");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(btnOkTableSetting, "OK");
            driver.ClickElement(btnOkTableSetting, "Ok");
        }
        public void ValidateEndpointConsumptionX()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, "1", "");

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(installDateCol, TimeSpan.FromSeconds(30));

            driver.ClickElement(installDateCol, "installDate Column");
            driver.ClickElement(installDateCol, "installDate Column");
            driver.WaitForElement(row1FirstCell, TimeSpan.FromSeconds(20));
            driver.ClickElement(row1FirstCell, "Select");
            driver.ClickElement(btnOkChooseAccount, "OK");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(btnCloseTableSetting, "X");
            driver.ClickElement(btnCloseTableSetting, "Ok");
        }
        public void ValidateEndpointConsumptionDeselectAll()
        {
            driver.ClickElement(endpointConsumption, "Endpoint Consumption");
            driver.WaitForElement(miuIdTextbox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementClearFirst(miuIdTextbox, "1", "");

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.ClickElement(btnSubmit, "Submit");
            driver.WaitForElement(installDateCol, TimeSpan.FromSeconds(30));

            driver.ClickElement(installDateCol, "installDate Column");
            driver.ClickElement(installDateCol, "installDate Column");
            driver.WaitForElement(row1FirstCell, TimeSpan.FromSeconds(20));
            driver.ClickElement(row1FirstCell, "Select");
            driver.ClickElement(btnOkChooseAccount, "OK");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(btndeselectAll, "deselect All");
            driver.ClickElement(btnCloseTableSetting, "Ok");
        }

        public void ValidateReverseFlowAccNo()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(reverseAccNo, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseAccNo, driver.GetElementText(reverseAccNo));
        }
        public void ValidateReverseFlowAccName()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(reverseAccName, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseAccName, driver.GetElementText(reverseAccName));
        }
        public void ValidateReverseFlowAccAddress()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");

            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");

            driver.WaitForElement(reverseAddress, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseAddress, driver.GetElementText(reverseAddress));
        }
        public void ValidateReverseFlowMIU()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(reverseMIU, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseMIU, driver.GetElementText(reverseMIU));
        }
        public void ValidateReverseFlowFlagTypeRow()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(reverseFlowFlagTypeRow, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseFlowFlagTypeRow, driver.GetElementText(reverseFlowFlagTypeRow));
        }
        public void ValidateReverseFlowCycleRouteRow()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(reverseFlowCycleRow, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseFlowCycleRow, driver.GetElementText(reverseFlowCycleRow));
        }

        public void ValidateReverseFlowSelectAllCheckBox()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(btnSelectAllTableSetting, "Select All");
            driver.ClickElement(btnCloseTableSetting, "Close");
        }
        public void ValidateReverseFlowMIUIDCheckBox()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(miuIdCheckbox, "Miu Id CheckBox");
            driver.ClickElement(btnCloseTableSetting, "Close");
        }
        public void ValidateReverseFlowResetCheckBox()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(btnResetTableSetting, "Reset CheckBox");
            driver.ClickElement(btnCloseTableSetting, "Close");
        }
        public void ValidateReverseFlowOKCheckBox()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(btnOkTableSetting, "OK CheckBox");
            driver.ClickElement(btnCloseTableSetting, "Close");
        }
        public void ValidateReverseFlowDeselectAllCheckBox()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(btndeselectAll, "DeselectAll CheckBox");
            driver.ClickElement(btnCloseTableSetting, "Close");
        }
        public void ValidateReverseFlowX()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(btnCloseTableSetting, "X");
            driver.ClickElement(btnCloseTableSetting, "Close");
        }

        public void ValidateReverseFlowMeterNoRow()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(reverseFlowMeterRow, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseFlowMeterRow, driver.GetElementText(reverseFlowMeterRow));
        }
        public void ValidateReverseFlowMIURow1()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(reverseMiuRow, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseMiuRow, driver.GetElementText(reverseMiuRow));
        }
        public void ValidateTableSettingDeSelectAll()
        {
            driver.ClickElement(activeSimNoSite, "Active Sim with No Site");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");

            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(btndeselectAll, "Deselect All");
            driver.ClickElement(btnCloseTableSetting, "Close");
        }
        public void ValidateTableSettingXCheckBox()
        {
            driver.ClickElement(activeSimNoSite, "Active Sim with No Site");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(btnCloseTableSetting, "X");
            driver.ClickElement(btnCloseTableSetting, "Close");
        }
        public void ValidateTableSettingOKCheckBox()
        {
            driver.ClickElement(activeSimNoSite, "Active Sim with No Site");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(btnOkTableSetting, "OK");
            driver.ClickElement(btnCloseTableSetting, "Close");
        }
        public void ValidateTableSettingResetCheckBox()
        {
            driver.ClickElement(activeSimNoSite, "Active Sim with No Site");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(btnResetTableSetting, "Reset");
            driver.ClickElement(btnCloseTableSetting, "Close");
        }
        public void ValidateTableSettingSelectAllCheckBox()
        {
            driver.ClickElement(activeSimNoSite, "Active Sim with No Site");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnTableSetting, "Table Setting");
            driver.CheckElementDisplayed(btnSelectAllTableSetting, "Select All");
            driver.ClickElement(btnCloseTableSetting, "Close");
        }
        public void ValidateReportsPage()
        {
            driver.WaitForElement(breadcrumb, TimeSpan.FromSeconds(20));
            driver.GetElementText(breadcrumb);
        }
        public void ValidateActiveSimUndefinedSite()
        {
            driver.CheckElementDisplayed(activeSimUndefinedSite, driver.GetElementText(activeSimUndefinedSite));
        }
        public void ValidateActiveSimUndefinedSiteAccess()
        {
            driver.ClickElement(activeSimUndefinedSite, driver.GetElementText(activeSimUndefinedSite));
            driver.WaitForElement(breadcrumb, TimeSpan.FromSeconds(10));
            if (driver.GetElementText(breadcrumb).Contains("ACTIVE SIM ASSOCIATED TO UNDEFINED SITE"))
            {
                testReport.Pass("Access Enabled for ACTIVE SIM ASSOCIATED TO UNDEFINED SITE");
            }

        }
        public void ValidateActiveSimNoSite()
        {
            driver.CheckElementDisplayed(activeSimNoSite, driver.GetElementText(activeSimNoSite));
        }
        public void ValidateActiveSimNoSiteAccess()
        {
            driver.ClickElement(activeSimNoSite, driver.GetElementText(activeSimNoSite));
            driver.WaitForElement(breadcrumb, TimeSpan.FromSeconds(10));
            if (driver.GetElementText(breadcrumb).Contains("ACTIVE SIM ASSOCIATED TO UNDEFINED SITE"))
            {
                testReport.Pass("Access Enabled for ACTIVE SIM WITH NO SITE");
            }
        }

        public void ValidateActiveSimNoSiteReportDate()
        {
            driver.ClickElement(activeSimNoSite, driver.GetElementText(activeSimNoSite));
            driver.WaitForElement(reportDateActiveSim, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(reportDateActiveSim, driver.GetElementText(reportDateActiveSim));
        }
        public void ValidateActiveSimNoSiteMIUID()
        {
            driver.ClickElement(activeSimNoSite, driver.GetElementText(activeSimNoSite));
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(activeSimMiuId, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(activeSimMiuId, driver.GetElementText(activeSimMiuId));
        }

        public void ValidateActiveSimNoSiteICCID()
        {
            driver.ClickElement(activeSimNoSite, driver.GetElementText(activeSimNoSite));
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(activeSimICCID, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(activeSimICCID, driver.GetElementText(activeSimICCID));
        }
        public void ValidateActiveSimNoSiteShippedUTC()
        {
            driver.ClickElement(activeSimNoSite, driver.GetElementText(activeSimNoSite));
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(shippedUTC, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(shippedUTC, driver.GetElementText(shippedUTC));
        }
        public void ValidateActiveSimNoSiteActivatedUTC()
        {
            driver.ClickElement(activeSimNoSite, driver.GetElementText(activeSimNoSite));
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(activatedUTC, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(activatedUTC, driver.GetElementText(activatedUTC));
        }
        public void ValidateActiveSimNoSiteLastHeardUTC()
        {
            driver.ClickElement(activeSimNoSite, driver.GetElementText(activeSimNoSite));
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(lastHeard, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(lastHeard, driver.GetElementText(lastHeard));
        }
        public void ValidateActiveSimNoSite1siImportedUTC()
        {
            driver.ClickElement(activeSimNoSite, driver.GetElementText(activeSimNoSite));
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(firstImported, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(firstImported, driver.GetElementText(firstImported));
        }
        public void ValidateActiveSimNoSiteSimStateUTC()
        {
            driver.ClickElement(activeSimNoSite, driver.GetElementText(activeSimNoSite));
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(simState, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(simState, driver.GetElementText(simState));
        }
        public void ValidateActiveSimNoSiteShareOption()
        {
            driver.ClickElement(activeSimNoSite, driver.GetElementText(activeSimNoSite));
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(exportLink, "Export Link");
        }
        public void ValidateActiveSimNoSiteShareExport()
        {
            driver.ClickElement(activeSimNoSite, driver.GetElementText(activeSimNoSite));
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));

            driver.SelectCalenderDate(fromDate, "Jan", "1");

            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(30));

            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export to PDF");
            driver.CheckElementDisplayed(exportExcel, "Export to Excel");
        }
        public void ValidateActiveSimNoSiteBackButton()
        {
            driver.ClickElement(activeSimNoSite, driver.GetElementText(activeSimNoSite));
            driver.WaitForElement(backToReports, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(backToReports, "Back Button");
        }

        public void ValidateReverseFlowAMR()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(reverseAMR, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseAMR, driver.GetElementText(reverseAMR));
        }
        public void ValidateLastReadingDateTime()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(reverseLastReadDateTime, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseLastReadDateTime, driver.GetElementText(reverseLastReadDateTime));
        }
        public void ValidateActiveSimNoSiteSortOder()
        {
            driver.ClickElement(activeSimNoSite, "active Sim No Site");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(reverseLastReadDateTime, TimeSpan.FromSeconds(30));
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.CheckElementDisplayed(activeSimMiuId, "MIU Id");
            driver.CheckElementDisplayed(activeSimICCID, "ICC Id");
            driver.CheckElementDisplayed(shippedUTC, "Shipped UTC");
            driver.CheckElementDisplayed(activatedUTC, "Activated UTC");
            driver.CheckElementDisplayed(firstImported, "1st Imported");
            driver.CheckElementDisplayed(lastHeard, "Last Heard");
            driver.CheckElementDisplayed(simState, "Sim State");
            driver.CheckElementDisplayed(commPlan, "Comm Plan");
            driver.CheckElementDisplayed(ratePlan, "Rate Plan");
            driver.CheckElementDisplayed(firstNet, "First Net");
        }
        public void ValidateReverseMeterSize()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(reverseMeterSize, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseMeterSize, driver.GetElementText(reverseMeterSize));
        }
        public void ValidateReverseFlagStart()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(reverseFlagStart, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseFlagStart, driver.GetElementText(reverseFlagStart));
        }

        public void ValidateReverseReading()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(reverseReading, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseReading, driver.GetElementText(reverseReading));
        }

        public void ValidateReverseDefaultDate()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElement(reverseStartDate, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseStartDate, driver.GetElementText(reverseStartDate));
        }
        public void ValidateReverseDefaultEndDate()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElement(reverseEndDate, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseEndDate, driver.GetElementText(reverseEndDate));
        }
        public void ValidateReverseAdjustStartDateEndDate()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElement(reverseEndDate, TimeSpan.FromSeconds(30));
            driver.ClickElement(By.XPath("//div[2]/div[1]/div[1]/span/reportdate-picker/div/div[1]/span/i"), "Start Date");
            driver.ClickElement(By.XPath("//div[1]/div[2]/span/reportdate-picker/div/div[1]/span/i"), "End Date");
        }
        public void ValidateReverseDatePicker()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElement(reverseEndDate, TimeSpan.FromSeconds(30));
            driver.ClickElement(By.XPath("//div[2]/div[1]/div[1]/span/reportdate-picker/div/div[1]/span/i"), "Start Date");
        }
        public void ValidateReverseFlagTypeFilterValue()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElement(reverseFlagTypeDropdown, TimeSpan.FromSeconds(30));
            driver.ClickElement(reverseFlagTypeDropdown, "Flag Type Dropdown");
            driver.CheckElementDisplayed(reverseFlagBoth, "Both");
            driver.CheckElementDisplayed(reverseFlagMajor, "Major");
            driver.CheckElementDisplayed(reverseFlagMinor, "Minor");
        }

        public void ValidateReverseFlagStop()
        {
            driver.ClickElement(reverseFlow, "reverse Flow");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(reverseFlagStop, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseFlagStop, "Flag Stop");
        }


        public void ValidateEndpointMaintenanceColumnsDisplay()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(Col1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col1, "Cycle Route");
            driver.CheckElementDisplayed(Col2, "Acc Name");
            driver.CheckElementDisplayed(Col3, "Address");
            driver.CheckElementDisplayed(Col4, "MIU ID");
            driver.CheckElementDisplayed(Col5, "Problem");
            driver.CheckElementDisplayed(Col6, "Reading");
            driver.CheckElementDisplayed(Col7, "Last Reading Date");
            driver.CheckElementDisplayed(Col8, "Days Since Read");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateNeverReceivedKPI()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(neverReceivedKPI, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(neverReceivedKPI, "Never Received KPI");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateNeverReceivedMap()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(neverReceivedKPI, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(neverReceivedKPI, "Never Received KPI");
            driver.CheckElementDisplayed(mapView, "Map");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInvalidReadMap()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(invalidReadsKPI, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(invalidReadsKPI, "Invalid Reads KPI");
            driver.CheckElementDisplayed(mapView, "Map");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidatePastDueMap()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(pastDueKPI, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(pastDueKPI, "Past Due KPI");
            driver.CheckElementDisplayed(mapView, "Map");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateTotalMIUsMap()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(totalMiuKPI, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(totalMiuKPI, "totalMiuKPI");
            driver.CheckElementDisplayed(mapView, "Map");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateEndpointShareiconPDF()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF Icon");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInvalidReadingAccess()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
        }
        public void ValidateInvalidReadingShareiconPDF()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF Icon");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInvalidReadingShareiconExcel()
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel Icon");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateEndpointShareiconExcel()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel Icon");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInvalidReadsKPI()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(invalidReadsKPI, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(invalidReadsKPI, "Invalid Reads KPI");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidatePastDueRollupKPI()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(pastDueKPI, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(pastDueKPI, "Past Due KPI");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateTotalMiuKPI()
        {
            driver.ClickElement(endpointMaintanence, "Endpoint Maintenance");
            driver.sleepTime(2000);
            driver.WaitForElement(totalMiuKPI, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(totalMiuKPI, "Total MIUs");
        }
        public void ValidateInactiveFlowBackNoRouteSelected()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(routeFilter, "Route Filter");
            driver.ClickElement(routeFilter, "");
        }
        public void ValidateInactiveFlowBacOneRouteSelected()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            driver.ClickElement(routeFilter, "Route Filter");
            driver.ClickElement(routeOne, "");
        }
        public void ValidateInactiveFlowBacOneRouteSelectedMiuId()
        {
            bool validate = true;

            driver.ClickElement(inactiveFlow, "Inactive Flow");
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            string routeName = driver.GetElementText(firstCellValue, 30);

            driver.ClickElement(routeFilter, "Group Filter");

            driver.ClickElement(routeByName(routeName), "");
            driver.WaitForElementNotExists(gridLoader);
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(120));

            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElementNotExists(gridLoader, 60);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            var meterInactiveSinceColumnValues = GetAllColumnValues(meterInactiveSinceColValues, out bool valueMatched);
            if (meterInactiveSinceColumnValues.Count == 0)
            {
                validate = false;
            }

            foreach (var meterInactiveSinceColumnValue in meterInactiveSinceColumnValues)
            {
                if (meterInactiveSinceColumnValue == "")
                {
                    validate = false;
                }
            }
            if (validate)
            {
                testReport.Pass("InActive meters displayed in Inactive Flow Detailed Report");
            }
            else
            {
                ReporterFactory.LogFailure("InActive meters are NOT displayed in Inactive Flow Detailed Report");
            }
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateInactiveFlowActiveMeters()
        {
            bool validate = true;
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            driver.WaitForElement(routeFilter, TimeSpan.FromMinutes(1));
            driver.WaitForElement(firstCellValue, TimeSpan.FromMinutes(2));
            string routeName = driver.GetElementText(firstCellValue, 30);

            driver.ClickElement(routeFilter, "Group Filter");

            driver.ClickElement(routeByName(routeName), "");
            driver.WaitForElementNotExists(gridLoader);
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(120));

            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElementNotExists(gridLoader, 60);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(2));
            var meterInactiveSinceColumnValues = GetAllColumnValues(meterInactiveSinceColValues, out bool valueMatched);
            if (meterInactiveSinceColumnValues.Count == 0)
            {
                validate = false;
            }

            foreach (var meterInactiveSinceColumnValue in meterInactiveSinceColumnValues)
            {
                if (meterInactiveSinceColumnValue == "")
                {
                    validate = false;
                }
            }
            if (validate)
            {
                testReport.Pass("Active meters not displayed in Inactive Flow Detailed Report");
            }
            else
            {
                ReporterFactory.LogFailure("Active meters are displayed in Inactive Flow Detailed Report");
            }
            ////driver.SwitchToDefaultFrame();

        }
        public void ValidateInactiveFlowBackGroupFilterOneSeletedMiuId()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            driver.WaitForElement(groupFilter, TimeSpan.FromMinutes(1));

            driver.ClickElement(groupFilter, "Group Filter");
            int count = driver.FindElements(routeList).Count;

            driver.ClickElement(routeOne, "");

            if (!driver.WaitForElement(exportLink, TimeSpan.FromSeconds(30)))
            {
                for (int i = 3; i < count - 1; i++)
                {
                    driver.ClickElement(groupFilter, "Group Filter");

                    driver.ClickElement(routeByIndex(i.ToString()), "");
                    if (driver.WaitForElement(exportLink, TimeSpan.FromSeconds(30)))
                    {
                        break;
                    }
                }
            }

            driver.CheckElementDisplayed(Col5, driver.GetElementText(Col5).ToString());

            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");

            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateSoftDisconnetAccNo()
        {
            driver.ClickElement(softDisconnect, "Soft Disconnect");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col3, driver.GetElementText(Col3).ToString());
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateSoftDisconnetAddress()
        {
            driver.ClickElement(softDisconnect, "Soft Disconnect");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col4, driver.GetElementText(Col4).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateSoftDisconnetMeterNo()
        {
            driver.ClickElement(softDisconnect, "Soft Disconnect");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col6, driver.GetElementText(Col6).ToString());
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateSoftDisconnetMiuId()
        {
            driver.ClickElement(softDisconnect, "Soft Disconnect");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col5, driver.GetElementText(Col5).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateSoftDisconnetMeterSize()
        {
            driver.ClickElement(softDisconnect, "Soft Disconnect");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col7, driver.GetElementText(Col7).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateSoftDisconnetStartDate()
        {
            driver.ClickElement(softDisconnect, "Soft Disconnect");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col8, driver.GetElementText(Col8).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateSoftDisconnetEndDate()
        {
            driver.ClickElement(softDisconnect, "Soft Disconnect");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col9, driver.GetElementText(Col9).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateSoftDisconnetConsumption()
        {
            driver.ClickElement(softDisconnect, "Soft Disconnect");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col10, driver.GetElementText(Col10).ToString());
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateSoftDisconnetUOM()
        {
            driver.ClickElement(softDisconnect, "Soft Disconnect");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col11, driver.GetElementText(Col11).ToString());
            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Mach10 Low Power
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateMach10DaysOfLowPower()
        {
            driver.ClickElement(mach10Battery, "Mach 10 Battery");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(Col7, driver.GetElementText(Col7));
            driver.CheckElementDisplayed(Col8, driver.GetElementText(Col8));
            ////driver.SwitchToDefaultFrame();
        }


        // <summary>
        /// Method to Validate Coded Notes Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateCodedNotesPage()
        {
            driver.ClickElement(codedNotes, "Coded Notes");
            driver.WaitForElement(codedNotesPage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(codedNotesPage, "Coded Notes Report is displayed");
        }

        // <summary>
        /// Method to Validate Coded Notes Back to Reports
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateCodedNotesBacktoReports()
        {
            driver.ClickElement(codedNotes, "Coded Notes");
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            //driver.sleepTime(2000);
            driver.WaitForElement(backToReports, TimeSpan.FromMinutes(1));
            driver.ClickElement(backToReports, "Back to Reports");
            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Coded Export To PDF
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateCodedNotesExportToPDF()
        {
            driver.ClickElement(codedNotes, "Coded Notes");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF Icon");
            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Comments Export To PDF
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateCommentsExportToPDF()
        {
            driver.ClickElement(comments, "Comments");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(60));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF Icon");
            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Days of No Flow Second Row
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofNoFlowSecondRow()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days of No Flow (AMR)");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(row1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(row1, "2nd Row");
            ////driver.SwitchToDefaultFrame();
        }

        // <summary>
        /// Method to Validate Days of Consumption 2nd row
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysofConsumption2ndRow()
        {
            driver.ClickElement(daysOfConsumption, "Days of No Flow (AMR)");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(row1, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(row1, "2nd Row");
            ////driver.SwitchToDefaultFrame();
        }



        // <summary>
        /// Method to Validate Coded Export To EXcel
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateCodedNotesExportToExcel()
        {
            driver.ClickElement(codedNotes, "Coded Notes");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel Icon");
            ////driver.SwitchToDefaultFrame();
        }


        // <summary>
        /// Method to Validate Mach 10 Battery Status Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateMach10BatteryStatusPage()
        {
            driver.ClickElement(mach10Battery, "Mach 10 Battery");
            driver.WaitForElement(mach10BatteryPage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(mach10BatteryPage, "Mach 10 Battery Status Page is displayed");
        }
        public void ValidateMach10TableSetting()
        {
            driver.ClickElement(mach10Battery, "Mach 10 Battery");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(btnTableSetting, "Table Setting");
        }
        public void ValidateMach10ExportPDF()
        {
            driver.ClickElement(mach10Battery, "Mach 10 Battery");
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(10));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "export PDF");
        }
        public void ValidateMach10ExportExcel()
        {
            driver.ClickElement(mach10Battery, "Mach 10 Battery");
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(10));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "export Excel");
        }
        public void ValidateMach10UTCOffset()
        {
            driver.ClickElement(mach10Battery, "Mach 10 Battery");
            driver.WaitForElement(Col6, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(Col6, "Initial Event Date Time");
        }
        public void ValidateMach10UTCOffsetDatetime()
        {
            driver.ClickElement(mach10Battery, "Mach 10 Battery");
            driver.WaitForElement(initialeventDateTime, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(initialeventDateTime, "Initial Event Date Time Format : " + driver.GetElementText(initialeventDateTime));
        }

        // <summary>
        /// Method to Validate Days Of No Flow Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysOfNoFlowPage()
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days Of No Flow");
            driver.WaitForElement(daysOfNoFlowPage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(daysOfNoFlowPage, "Days of No Flow(AMR) is displayed as Detailed Report title");
        }

        // <summary>
        /// Method to Validate Comments Page Title
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateCommentsPageTitle()
        {
            driver.ClickElement(comments, "Comments");
            driver.WaitForElement(commentsPage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(commentsPage, "Comments Page Title is Displayed");
        }
        public void ValidateCommentsTableSetting()
        {
            driver.ClickElement(comments, "Comments");
            driver.WaitForElement(groupFilter, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");

            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(btnTableSetting, "Table Setting");
        }

        // <summary>
        /// Method to Validate Days Of Cosnumption
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysOfConsumption()
        {
            driver.ClickElement(daysOfConsumption, "Days Of Cosnumption");
            driver.WaitForElement(daysOfConsumptionPage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(daysOfConsumptionPage, "Days of Cosnumption(AMR) is displayed as Detailed Report title");
        }

        public void ValidateDaysOfConsumptionColumns()
        {
            driver.ClickElement(daysOfConsumption, "Days Of Cosnumption");
            driver.WaitForElement(daysOfConsumptionPage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(daysOfConsumptionPage, "Days of Cosnumption(AMR) is displayed as Detailed Report title");
        }

        // <summary>
        /// Method to Validate Coded Notes
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateCodedNotes()
        {
            driver.CheckElementDisplayed(codedNotes, "Coded Notes Report is displayed within the Field Feedback container");
        }

        public void ValidateInactiveFlowDisplay()
        {
            driver.CheckElementDisplayed(inactiveFlow, "Inactive Flow Report is displayed under Endpoint Container");
        }

        public void ValidateInactiveFlowNotDisplay()
        {
            driver.CheckElementDisplayed(inactiveFlow, "Inactive Flow Report is displayed under Endpoint Container");
        }

        public void ValidateInactiveFlowAccess()
        {
            driver.ClickElement(inactiveFlow, "Inactive Flow");
            if (driver.GetElementText(breadcrumb).Contains("INACTIVE FLOW"))
            {
                testReport.Pass("INACTIVE FLOW Report is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("INACTIVE FLOW not displayed");
            }
        }

        // <summary>
        /// Method to Validate Days of No Flow (AMR)
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysOfNoFlowAMR()
        {
            driver.CheckElementDisplayed(daysOfNoFlowAMR, "'Days of No Flow (AMR)' Report is displayed under Endpoint Container");
        }

        // <summary>
        /// Method to Validate AMI No Flow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateAMINoFlow()
        {
            driver.CheckElementDisplayed(amiNoFlow, "AMI No Flow Report is displayed under Endpoint Container");
        }

        public void ValidateAMINoFlowNotDisplayed()
        {
            driver.CheckElementDoesnotExists(amiNoFlow, "AMI No Flow Report is displayed under Endpoint Container");
        }

        // <summary>
        /// Method to Validate AMI No Flow Click
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateAMINoFlowClick()
        {
            driver.ClickElement(amiNoFlow, "AMI No Flow");
            //driver.WaitForElement(breadcrumb, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(breadcrumb, "Breadcrumb");
            if (driver.GetElementText(breadcrumb).Contains("AMI NO FLOW"))
            {
                testReport.Pass("AMI No Flow Report is displayed");
            }
        }
        public void ValidateHighLowLimitFall()
        {
            driver.CheckElementDisplayed(highLowLimitFall, "highLowLimitFall");
        }
        public void ValidateHighLowLimitFallColumnOrder()
        {
            driver.ClickElement(highLowLimitFall, "highLowLimitFall");
            driver.WaitForElement(Col1, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(Col1, "Route/Cycle");
        }
        public void ValidateProductivityReportColumns()
        {
            driver.ClickElement(productivityReport, "Productivity Report");
            driver.WaitForElementNotExists(gridLoader, 180);
            driver.WaitForElement(Col1, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(Col1, driver.GetElementText(Col1));
            driver.CheckElementDisplayed(Col2, driver.GetElementText(Col2));
            driver.CheckElementDisplayed(Col3, driver.GetElementText(Col3));
            driver.CheckElementDisplayed(Col4, driver.GetElementText(Col4));
            driver.CheckElementDisplayed(Col5, driver.GetElementText(Col5));
            driver.CheckElementDisplayed(Col6, driver.GetElementText(Col6));
            driver.CheckElementDisplayed(Col7, driver.GetElementText(Col7));
            driver.CheckElementDisplayed(Col8, driver.GetElementText(Col8));
            driver.CheckElementDisplayed(Col9, driver.GetElementText(Col9));
            driver.CheckElementDisplayed(Col10, driver.GetElementText(Col10));
            driver.CheckElementDisplayed(Col11, driver.GetElementText(Col11));
            driver.CheckElementDisplayed(Col12, driver.GetElementText(Col12));
            driver.CheckElementDisplayed(Col13, driver.GetElementText(Col13));
            driver.CheckElementDisplayed(Col14, driver.GetElementText(Col14));
            driver.ScrollToElement(driver.FindElement(Col15));
            driver.CheckElementDisplayed(Col15, driver.GetElementText(Col15));
            driver.CheckElementDisplayed(Col16, driver.GetElementText(Col16));
            driver.CheckElementDisplayed(Col17, driver.GetElementText(Col17));
            driver.ScrollToElement(driver.FindElement(Col22));

            driver.CheckElementDisplayed(Col18, driver.GetElementText(Col18));

            driver.CheckElementDisplayed(Col19, driver.GetElementText(Col19));
            driver.CheckElementDisplayed(Col20, driver.GetElementText(Col20));
            driver.CheckElementDisplayed(Col21, driver.GetElementText(Col21));
            driver.CheckElementDisplayed(Col22, driver.GetElementText(Col22));
        }

        public void ValidateProductivityReportModidyColumnError()
        {
            driver.ClickElement(productivityReport, "Productivity Report");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table setting");
            driver.ClickElement(btndeselectAll, "de-select all");
            driver.ClickElement(btnOkTableSetting, "OK");
            driver.CheckElementDisplayed(pleaseSelectatleastOneCol, "Error Msg");
            driver.ClickElement(btnCloseTableSetting, "X");

        }
        public void ValidateProductivityReportResetButton()
        {
            driver.ClickElement(productivityReport, "Productivity Report");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnTableSetting, "Table setting");
            driver.ClickElement(btndeselectAll, "de-select all");
            driver.ClickElement(btnResetTableSetting, "Reset");
            driver.ClickElement(btnCloseTableSetting, "X");
        }
        public void ValidateProductivitySelectAllDeselectAllButton()
        {
            driver.ClickElement(productivityReport, "Productivity Report");
            driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(120));
            driver.ClickElement(btnTableSetting, "Table setting");
            driver.ClickElement(btndeselectAll, "de-select all");
            driver.ClickElement(btnSelectAllTableSetting, "Select all");
            driver.ClickElement(btnCloseTableSetting, "X");
        }
        public void ValidateProductivityAMIRow()
        {
            driver.ClickElement(productivityReport, "Productivity Report");
            driver.WaitForElement(amiMeterRow, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(amiMeterRow, "AMI Meter Row");
        }
        public void ValidateHighLowLimitFallBacktoReports()
        {
            driver.ClickElement(highLowLimitFall, "highLowLimitFall");
            driver.WaitForElement(backToReports, TimeSpan.FromSeconds(30));
            driver.ClickElement(backToReports, "backToReports");
        }
        public void ValidateHighLowLimitFallExportButton()
        {
            driver.ClickElement(highLowLimitFall, "highLowLimitFall");
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(exportLink, "exportLink");
        }

        // <summary>
        /// Method to Validate Reports option not available
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateNoReportsOption()
        {
            driver.sleepTime(3000);
            driver.CheckElementDoesnotExists(lftNavReports, "Reports option is not available");
        }


        // <summary>
        /// Method to Validate Days of Consumption (AMR)
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateDaysOfConsumptionAMR()
        {
            driver.CheckElementDisplayed(daysOfConsumption, "'Days of Consumption (AMR)' Report is displayed under Endpoint Container");
        }
        public void ValidateDaysOfConsumptionAMIFlagBased()
        {
            driver.CheckElementDisplayed(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
        }
        public void ValidateDaysOfConsumptionAMIFlagBasedAccess()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
        }
        public void ValidateDaysOfConsumptionAMIFlagFromDate()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.CheckElementDisplayed(fromDate, "From Date");
        }
        public void ValidateDaysOfConsumptionAMIFlagFromDateEditable()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.ClickElement(fromDate, "From Date");
        }
        public void ValidateDaysOfConsumptionAMIFlagToDate()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.CheckElementDisplayed(toDate, "to Date");
        }
        public void ValidateDaysOfConsumptionAMIFlagToDateEditable()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.ClickElement(toDate, "to Date");
        }

        public void ValidateDaysOfConsumptionAMIFlagRouteFilter()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.CheckElementDisplayed(routeFilter, "routeFilter");
        }
        public void ValidateDaysOfConsumptionAMIFlagRouteFilterValues()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.ClickElement(routeFilter, "routeFilter");
        }
        public void ValidateDaysOfConsumptionAMIFlagGroupFilterValues()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.ClickElement(groupFilter, "groupFilter");
        }
        public void ValidateDaysOfConsumptionAMIFlagFlowtypes()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.CheckElementDisplayed(drpDownFlowTypeIncluded, "Flow Type Included");
        }
        public void ValidateDaysOfConsumptionAMIFlagFlowtypeIntermittent()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.ClickElement(drpDownFlowTypeIncluded, "Flow Type Included");
            driver.ClickElement(flagTypeIntermittent, "Intermittent");
            driver.WaitForElement(rowflowType, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(rowflowType, driver.GetElementText(rowflowType));
        }
        public void ValidateDaysOfConsumptionAMIFlagFlowtypeContinuous()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.ClickElement(drpDownFlowTypeIncluded, "Flow Type Included");
            driver.ClickElement(flagTypeContinous, "Continuous");
            driver.WaitForElement(rowflowType, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(rowflowType, driver.GetElementText(rowflowType));
        }

        public void ValidateActiveSimAssociated()
        {
            driver.ClickElement(activeSimUndefinedSite, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.WaitForElement(activeSimAssociatedHeader, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(activeSimAssociatedHeader, driver.GetElementText(activeSimAssociatedHeader));
        }
        public void ValidateActiveSimAssociatedDateFormat()
        {
            driver.ClickElement(activeSimUndefinedSite, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.WaitForElement(fromDateData, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(fromDateData, "");
            string s = driver.GetElementText(fromDateData);
            testReport.Info(s);
        }
        public void ValidateActiveSimAssociatedSiteID()
        {
            driver.ClickElement(activeSimUndefinedSite, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(siteID, TimeSpan.FromSeconds(60));
            driver.CheckElementDisplayed(siteID, "siteID ");
        }
        public void ValidateDaysOfConsumptionAMIFlagGroupFilter()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.CheckElementDisplayed(groupFilter, "groupFilter");
        }

        public void ValidateDaysOfConsumptionAMIFlagFromDateDefault()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.CheckElementDisplayed(fromDateData, "from date");
            string s = driver.GetElementAttribute(fromDateData, "");
            testReport.Info(s);
        }
        public void ValidateDaysOfConsumptionAMIFlagToDateDefault()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.CheckElementDisplayed(toDateData, "To date");
            string s = driver.GetElementAttribute(toDateData, "");
            testReport.Info(s);
        }
        public void ValidateDaysOfConsumpAMIFlagFlowTypes()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.CheckElementDisplayed(flowTypesIncluded, "flowTypesIncluded");
        }
        public void ValidateDaysOfConsumpAMIFlagFlowTypesDropdown()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.ClickElement(drpDownFlowTypeIncluded, "flowTypesIncluded");
            driver.CheckElementDisplayed(flagTypeContinous, "flagTypeContinous");
            driver.CheckElementDisplayed(flagTypeIntermittent, "flagTypeIntermittent");
        }
        public void ValidateDaysOfConsumpAMIFlagFlowTypesDefault()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.CheckElementDisplayed(drpDownFlowTypeIncluded, "Default Value is " + driver.GetElementText(drpDownFlowTypeIncluded));

        }
        public void ValidateDaysOfConsumpAMIFlagShareIconPDF()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.ClickElement(exportLink, "");
            driver.CheckElementDisplayed(exportPDF, "Pdf");

        }
        public void ValidateDaysOfConsumpAMIFlagShareIconExcel()
        {
            driver.ClickElement(daysOfConsFlowFlagBased, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.ClickElement(exportLink, "");
            driver.CheckElementDisplayed(exportExcel, "Excel");
        }
        public void ValidateEndpointContainer()
        {
            driver.CheckElementDisplayed(endpointContainer, "Endpoint Container");
        }

        // <summary>
        /// Method to Validate Invalid Readings Report
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateInvalidReadingsReport()
        {
            driver.CheckElementDisplayed(invalidReadingsReport, "Invalid Readings Report is displayed within the Endpoints container");
        }

        public void ValidateMach10BatteryStatusReport(string query)
        {
            driver.ClickElement(mach10Battery, "Mach 10 Battery Status");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            IWebElement reportsWebTable = driver.FindElement(mach10BatteryTable);
            reportTable = driver.ExecutePostgreSQL(query);
            DataTable reportsData = new DataTable();
            reportsData = driver.ConvertWebTableToDataTable(reportsWebTable, 1);
            driver.CompareTwoDataTables(reportTable, reportsData);
            ////driver.SwitchToDefaultFrame();
        }

        public List<string> GetAllColumnValues(By colElementLocator, out bool found, string validateValue = "")
        {
            List<string> allColValues = new List<string>();
            found = false;
            try
            {
                int i = 1;
                driver.WaitForElementNotExists(gridLoader, 180);
                IList<IWebElement> colEleValues = driver.FindElements(colElementLocator);
                int rowCont = int.Parse(driver.FindElement(gridRowCount).GetAttribute("aria-rowcount"));
                while (rowCont > 0)
                {

                    if (colEleValues.Count > 0)
                    {
                        foreach (IWebElement ele in colEleValues)
                        {
                            if (validateValue != "")
                            {
                                if (ele.Text == validateValue)
                                {
                                    found = true;
                                    return allColValues;
                                }
                            }
                            allColValues.Add(ele.Text);
                        }

                    }

                    try
                    {
                        Thread.Sleep(3000);
                        IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;
                        exe.ExecuteScript("arguments[0].scrollIntoView(true);", colEleValues.Last());
                        driver.WaitForElementNotExists(scrollLoader, 180);
                        Thread.Sleep(3000);

                        colEleValues = driver.FindElements(colElementLocator);
                        rowCont = rowCont - 30;
                    }
                    catch (Exception e)
                    { }
                }
            }
            catch (Exception ex) { }

            return allColValues;
        }
        public void validateConsecDaysOrder()
        {
            driver.ClickElement(daysOfNoFlowAMR, "");
            List<string> consecDaysList = new List<string>();
            List<bool> cosecDaysOrderMatched = new List<bool>();
            List<string> consecDaysOrder = new List<string>() { "35 days", "22-34 days", "15-21 days", "8-14 days", "3-7 days", "1-2 days" };

            consecDaysList = GetAllColumnValues(consecDaysColumnValues, out bool validation);

            int order = 0;
            foreach (var cosecDay in consecDaysList)
            {
                if (cosecDay == consecDaysOrder[order])
                {
                    cosecDaysOrderMatched.Add(true);
                }
                else
                {
                    if (order < consecDaysOrder.Count)
                    {
                        order++;
                    }
                    if (cosecDay == consecDaysOrder[order])
                    {
                        cosecDaysOrderMatched.Add(true);
                    }
                    else
                    {
                        cosecDaysOrderMatched.Add(false);
                    }
                }
            }

            if (cosecDaysOrderMatched.Contains(false))
            {
                ReporterFactory.LogFailure("<i>Consec Days are NOT in Order");
            }
            else
            {
                testReport.Pass("<i>Consec Days are in Order");
            }
        }

        public void ValidateDaysOfNoFlowConsecDays()
        {
            driver.ClickElement(daysOfNoFlowAMR, "");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(20));
            driver.ClickElement(Col11, "Consec Days");
            driver.ClickElement(consecDaysSortIcon, "");
            driver.ClickElement(sortAscending, "");
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            IWebElement reportsWebTable = driver.FindElement(daysOfNoFlowTable);
            DataTable reportsData = new DataTable();
            reportsData = driver.ConvertWebTableToDataTable(reportsWebTable, 100);
            //    String verifyDays = "35 Days";
            //    bool contains = reportsData.AsEnumerable().Any(row => verifyDays == row.Field<String>("consec days"));

            //    if(contains)
            //    {
            //        testReport.Pass("");
            //    }
            //    else
            //    {
            //        ReporterFactory.LogFailure("");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("");
            //}
        }

        public void ValidateCycleRouteOrder()
        {
            List<string> CycleRouteList = new List<string>();
            List<string> CycleRouteListOrder = new List<string>();
            driver.ClickElement(daysOfNoFlowAMR, "");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(20));
            driver.ClickElement(Col11, "Consec Days");
            driver.ClickElement(consecDaysSortIcon, "");
            driver.ClickElement(sortAscending, "");

            try
            {
                bool uomMatched = true;
                int i = 1;
                driver.WaitForElementNotExists(gridLoader, 180);
                IList<IWebElement> CycleRouteColValues = driver.FindElements(cycleRouteColumnValues);
                int rowCont = int.Parse(driver.FindElement(gridRowCount).GetAttribute("aria-rowcount"));
                while (rowCont > 0)
                {

                    if (CycleRouteColValues.Count > 0)
                    {
                        foreach (IWebElement ele in CycleRouteColValues)
                        {
                            CycleRouteListOrder.Add(ele.Text);
                            CycleRouteList.Add(ele.Text);
                        }
                    }

                    try
                    {
                        Thread.Sleep(3000);
                        IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;
                        exe.ExecuteScript("arguments[0].scrollIntoView(true);", CycleRouteColValues.Last());
                        driver.WaitForElementNotExists(scrollLoader, 180);
                        Thread.Sleep(3000);

                        CycleRouteColValues = driver.FindElements(cycleRouteColumnValues);
                        rowCont = rowCont - 30;
                    }
                    catch (Exception e)
                    { }
                }
            }
            catch (Exception ex) { }
            CycleRouteList.Sort();

            if (CycleRouteList.SequenceEqual(CycleRouteListOrder))
            {
                //pending
            }

        }

        public void ValidateReadSeqOrder()
        {
            List<string> readSeqList = new List<string>();
            List<string> readSeqListOrder = new List<string>();
            driver.ClickElement(daysOfNoFlowAMR, "");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(20));
            driver.ClickElement(Col11, "Consec Days");
            driver.ClickElement(consecDaysSortIcon, "");
            driver.ClickElement(sortAscending, "");

            try
            {
                bool uomMatched = true;
                int i = 1;
                driver.WaitForElementNotExists(gridLoader, 180);
                IList<IWebElement> readSeqColValues = driver.FindElements(readSeqColumnValues);
                int rowCont = int.Parse(driver.FindElement(gridRowCount).GetAttribute("aria-rowcount"));
                while (rowCont > 0)
                {

                    if (readSeqColValues.Count > 0)
                    {
                        foreach (IWebElement ele in readSeqColValues)
                        {
                            readSeqListOrder.Add(ele.Text);
                            readSeqList.Add(ele.Text);
                        }
                    }

                    try
                    {
                        Thread.Sleep(3000);
                        IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;
                        exe.ExecuteScript("arguments[0].scrollIntoView(true);", readSeqColValues.Last());
                        driver.WaitForElementNotExists(scrollLoader, 180);
                        Thread.Sleep(3000);

                        readSeqColValues = driver.FindElements(readSeqColumnValues);
                        rowCont = rowCont - 30;
                    }
                    catch (Exception e)
                    { }
                }
            }
            catch (Exception ex) { }
            readSeqList.Sort();

            if (readSeqList.SequenceEqual(readSeqListOrder))
            {
                //pending
            }

        }
        public void ValidateDaysOfNoFlowAMRReport(string query)
        {
            driver.ClickElement(daysOfNoFlowAMR, "Days Of No Flow (AMR)");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(By.XPath("//div[4]/div[3]/div/div"), TimeSpan.FromSeconds(30));
            driver.MouseHoverByJavaScript(By.XPath("//div/table/tbody[1]/tr[1]/td[5]"), "");
            driver.ClickElement(By.XPath("//div[4]/div[3]/div/div"), "");
            driver.ClickElement(By.XPath("//a[contains(text(),'Sort Ascending')]"), "");
            driver.sleepTime(5000);
            IWebElement reportsWebTable = driver.FindElement(daysOfNoFlowTable);
            reportTable = driver.ExecutePostgreSQL(query);
            DataTable reportsData = new DataTable();
            reportsData = driver.ConvertWebTableToDataTable(reportsWebTable, 1);
            reportsData.Columns.Remove("meter number");
            reportsData.Columns.Remove("meter size");
            reportsData.Columns.Remove("consec days");
            reportsData.Columns.Remove("register id");
            driver.CompareTwoDataTables(reportTable, reportsData);
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateInvalidReadings(string query)
        {
            driver.ClickElement(invalidReadings, "Invalid Readings");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            IWebElement reportsWebTable = driver.FindElement(daysOfConsumptionAMRtable);
            reportTable = driver.ExecutePostgreSQL(query);
            DataTable reportsData = new DataTable();
            reportsData = driver.ConvertWebTableToDataTable(reportsWebTable, 1);
            driver.CompareTwoDataTables(reportTable, reportsData);
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateDaysOfConsumpAMR(string query)
        {
            driver.ClickElement(daysOfConsumption, "Days Of Consumption (AMR)");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            //driver.WaitForElement(By.XPath("//div[4]/div[3]/div/div"), TimeSpan.FromSeconds(30));            
            driver.MouseHoverByJavaScript(By.XPath("//div/table/tbody[1]/tr[1]/td[5]"), "");
            driver.ClickElement(By.XPath("//div[4]/div[3]/div/div"), "");
            driver.ClickElement(By.XPath("//a[contains(text(),'Sort Ascending')]"), "");
            driver.sleepTime(5000);
            IWebElement reportsWebTable = driver.FindElement(daysOfConsumptionAMRtable);
            reportTable = driver.ExecutePostgreSQL(query);
            DataTable reportsData = new DataTable();
            reportsData = driver.ConvertWebTableToDataTable(reportsWebTable, 1);
            reportsData.Columns.Remove("meter number");
            reportsData.Columns.Remove("meter size");
            reportsData.Columns.Remove("consumption flag");
            reportsData.Columns.Remove("days range");
            reportsData.Columns.Remove("last reading date/time");
            driver.CompareTwoDataTables(reportTable, reportsData);
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateEndpointConsumptionDailyGroupInterval()

        {

            driver.ClickElement(endpointConsumption, "Endpoint Consumption");

            driver.WaitForElement(groupCheckbox, TimeSpan.FromMinutes(1));

            driver.ClickElement(groupCheckbox, "Group");

            driver.ClickElement(groupDrpdown, "Groups Filter");

            driver.ClickElement(routeTwo, "Select");

            driver.ClickElement(btnSubmit, "Submit");

            driver.WaitForElement(reverseMeterSize, TimeSpan.FromSeconds(50));

            driver.CheckElementDisplayed(reverseMeterSize, "Reading");

        }

        public void ValidateChangedReadParametersReportDate()

        {

            driver.ClickElement(changedReadParameters, "Changed Read Parameters");

            driver.WaitForElement(reportDate, TimeSpan.FromSeconds(20));

            driver.CheckElementDisplayed(reportDate, driver.GetElementText(reportDate));

        }

        public void ValidateDaysOfConsFlowConsBasedAvgFlowPrior()

        {

            driver.ClickElement(daysOfConsFlowConsBased, "Days Of Consecutive Flow (AMI) - Consumption Based");

            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));

            //driver.SwitchToFrameById("ntgMSTRFrame"); driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));

            driver.CheckElementDisplayed(avgDailyFlowPrior, driver.GetElementText(avgDailyFlowPrior));

            //driver.SwitchToDefaultFrame();

        }

        public void ValidateReverseFlowFlagsIncluded()

        {

            driver.ClickElement(reverseFlow, "reverse Flow");

            driver.sleepTime(2000);

            driver.WaitForElement(flagDrpdown, TimeSpan.FromMinutes(1));

            driver.ClickElement(flagDrpdown, "flag Drpdown");

            driver.CheckElementDisplayed(routeOne, "Major");

            driver.CheckElementDisplayed(routeTwo, "Minor");

        }

        public void ValidateActiveSimShippedUTC()
        {
            driver.ClickElement(activeSimUndefinedSite, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(siteID, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(shippedUTC, "shipped UTC ");
        }

        public void ValidateActiveSimAssociatedICCID()
        {
            driver.ClickElement(activeSimUndefinedSite, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.WaitForElementNotExists(gridLoader, 60);

            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(siteID, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(activeSimICCID, "ICC ID ");
        }

        public void ValidateActiveSimAssociatedMIUID()
        {
            driver.ClickElement(activeSimUndefinedSite, "'Days of Consumption (AMI)' Flag Based Report is displayed under Endpoint Container");
            driver.WaitForElementNotExists(gridLoader, 60);
            driver.WaitForElement(fromDate, TimeSpan.FromSeconds(30));
            driver.SelectCalenderDate(fromDate, "Jan", "1");
            driver.WaitForElement(siteID, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(activeSimMiuId, "MIU ID ");
        }


    }
}
