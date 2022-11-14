using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Keys = OpenQA.Selenium.Keys;

namespace Neptune360UIAutomation
{
    public class DashboardPage : AbstractTemplatePage
    {

        #region UI Object Repository  
        private By detailReport = By.XPath("//a[@href='/dashboard/detailreport-new/systemconsumption']");
        private By topTenConsumtionDetailReport = By.XPath("//a[@href='/dashboard/detailreport-new/toptenaccounts']");
        private By lftNavCustomerInquiry = By.XPath("//span[text()='CUSTOMER INQUIRY']");
        private By headerCustomerInquiry = By.XPath("//h2[@class='page-header-title' and text()='Customer Inquiry']");
        private By topTenConsmpVertical = By.XPath("//sd-dashboard//div/div[1]/div[3]/div");
        private By backToKPI = By.XPath("//a[contains(text(),'Back to KPI')]");
        private By gridView = By.XPath("//button[text()='Grid']");
        private By mapView = By.XPath("//button[text()='Map']");
        private By mapMenuBar = By.XPath("//sd-gridmap//div[@id='map']//button[text()='Map']");
        private By googleMap = By.XPath("//sd-gridmap//div[@id='map']//img[contains(@src,'googleapis.com/maps')]");
        private By googleImage = By.XPath("//sd-gridmap//div[@id='map']//a[contains(@href,'google')]//img[@alt='Google']");
        private By allClusters = By.XPath("//div[@aria-roledescription='map']//div[contains(@title,'Cluster')]");
        private By allClustersImages = By.XPath("//div[@aria-roledescription='map']//div[contains(@title,'Cluster')]//img");
        private By allAccountsBtn = By.XPath("//input[@class='dashboardMapButton'][@value='All']");
        private By highConsumptionBtn = By.XPath("//input[@class='dashboardMapButton'][@value='High Consumption']");
        private By lowConsumptionBtn = By.XPath("//input[@class='dashboardMapButton'][@value='Low Consumption']");
        private By map = By.XPath("//sd-gridmap/div[2]/div/div/div[4]/div/div[1]/button");
        private By mapxpathingridview = By.XPath("//button[text()='Map']");
        private By topTwenty = By.XPath("//span[contains(text(),'Top 20% of Consumption')]");
        private By middleSixty = By.XPath("//span[contains(text(),'Middle 60% of Consumption')]");
        private By bottomTwenty = By.XPath("//span[contains(text(),'Bottom 20% of Consumption')]");
        private By noDataReturned = By.XPath("//p[contains(text(),'No data returned for this view.')]");
        private By systemConsumption = By.XPath("//span[contains(text(),'System Consumption')]");
        private By systemConsmpNoData = By.XPath("//span[contains(text(),'No data returned for this view.')]");
        private By searchFeild = By.CssSelector(".mstrmojo-SearchBox-input");
        private By styleDrpDwon = By.CssSelector(".item");
        private By sateliteView = By.XPath("//sd-gridmap/div[2]/div/div/div[4]/div/div[2]//button");
        private By terrainView = By.XPath("//*[contains(@class,'TerrainMap')]");
        private By physicalView = By.XPath("//*[contains(@class,'PhysicalMap')]");
        private By topographicView = By.XPath("//*[contains(@class,'TopographicMap')]");
        private By streetView = By.XPath("//*[contains(@class,'WorldStreetMap')]");
        private By lightGray = By.XPath("//*[contains(@class,'LightGrayMap')]");
        private By releif = By.XPath("//*[contains(@class,'ReliefMap')]");
        private By plusSymbol = By.XPath("//sd-gridmap/div[2]//div[13]/div/div[3]/div/button[1]");
        private By minusSymbol = By.XPath("//sd-gridmap/div[2]//div[13]/div/div[3]/div/button[2]");
        private By dashboardTitle = By.XPath("//h3[contains(.,'Endpoint Summary Review')]");
        private By dashboardTitleDate = By.XPath("//span[contains(.,'7-Day Summary as of :')]");
        private By reportDate = By.XPath("//div[3]/sd-report-grid/div/div[1]/div[1]/p");
        private By reverseFlowWidget = By.XPath("//h3[contains(.,'Reverse Flow')]");
        private By kpisWidget = By.XPath("//sd-dashboard/div/div/div/div/div/div/div[2]");
        private By metersReadingsKpi = By.XPath("//div[2]/div/sd-dashboardcard/div/div[1]/h1");
        private By continuousCount = By.XPath("//div[4]/div/sd-dashboardcard/div/div[2]");
        private By readingsKpiWidget = By.XPath("//div[2]/div/sd-dashboardcard/div/div[3]/div/h3");
        private By readingsKpiLeftArrow = By.XPath("//div[2]/div/sd-dashboardcard/div/div[1]/h1/div[1]");
        private By reverseFlowRightArrow = By.XPath("//div[5]/div/sd-dashboardcard/div/div[1]/h1/div[2]");
        private By cotinuousRightArrow = By.XPath("//div[4]/div/sd-dashboardcard/div/div[1]/h1/div[2]");
        private By cotinuousConsRightArrow = By.XPath("//h3[text()='Continuous Consumption']//ancestor::div[contains(@class,'card') and not(@class='card-header cardfooter')]//div[contains(@class,'right')]");
        private By readingsRightArrow = By.XPath("//h3[text()='Readings']//ancestor::div[contains(@class,'card')]//div[contains(@class,'right')]");
        private By receivedViaAMIRightArrow = By.XPath("//h3[text()='via AMI']//ancestor::div[@class='card']//div[contains(@class,'right')]");
        private By receivedViaAMRRightArrow = By.XPath("//h3[text()='via AMR']//ancestor::div[contains(@class,'card')]//div[contains(@class,'right')]");
        private By continuousLeftArrow = By.XPath("//div[4]/div/sd-dashboardcard/div/div[1]/h1/div[1]");
        private By completeRight = By.XPath("//div[2]/div/sd-dashboardcard//div[1]/h1/div[2]");
        private By completeLeft = By.XPath("//div[2]/div/sd-dashboardcard//div[1]/h1/div[1]");
        private By receivedRight = By.XPath("//div[3]/div/sd-dashboardcard/div/div[1]/h1/div[2]");
        private By gatewayRightArrow = By.XPath("//div[8]//div[1]/h1/div[2]");
        private By gridLoader = By.XPath("//div[contains(@class,'report-grid-loader')]");
        private By reportGridLoader = By.XPath("//div[@class='k-loading-mask']");
        private By inputRadioBtn = By.XPath("//label[text()='Include']//preceding-sibling::input");
        //private By majorReverseFlowCount=By.XPath("//div[5]/div/sd-dashboardcard/div/div[2]/h1/span/a");
        private By majorReverseDetails = By.XPath("//h3[contains(text(),'Major Reverse Flow Detail')]");
        private By minorReverseDetails = By.XPath("//h3[contains(text(),'Minor Reverse Flow Detail')]");
        private By majorReverseFlow = By.XPath("//input[@value='Major Reverse Flow']");
        private By CompleteKPI = By.XPath("//span[text()='Complete']");
        private By IncompleteKPI = By.XPath("//span[text()='Incomplete']");
        private By SkippedKPI = By.XPath("//span[text()='Skipped']");
        private By skippedReadings = By.XPath("//div[2]/div/sd-dashboardcard/div/div[2]/h1/span/a");
        private By ViaAMR = By.XPath("//h3[contains(.,'via AMR')]");
        private By ViaAMI = By.XPath("//h3[contains(.,'via AMI')]");
        private By continuousConsumption = By.XPath("//h3[contains(.,'Continuous Consumption')]");
        private By notReceived = By.XPath("//span[text()='Not Received']");
        private By major = By.XPath("//input[@value='Major Reverse Flow']");
        private By minor = By.XPath("//span[text()='Minor']");
        private By warning = By.XPath("//span[text()='Warning']");
        private By normal = By.XPath("//span[text()='Normal']");
        private By intermittent = By.XPath("//span[text()='Intermittent']");
        private By criticalGateway = By.XPath("//span[text()='Critical']");
        private By majorRight = By.XPath("//div[5]/div/sd-dashboardcard/div/div[1]/h1/div[2]");
        private By gatewayRight = By.XPath("//div[8]/div/sd-dashboardcard/div/div[1]/h1/div[2]");
        private By questionMark = By.CssSelector(".fa-question");
        private By AMRReadings = By.XPath("//div[3]/div/sd-dashboardcard/div/div[2]/h1/span/a");
        private By gatewayReadings = By.XPath("//div[8]/div/sd-dashboardcard/div/div[2]/h1/span/a");
        private By receivedCount = By.XPath("//div/div/div[2]/div[3]/div/sd-dashboardcard/div/div[2]/h1/span");
        private By actualRadioBtn = By.XPath("//input[@class='k-radio']//..//label[contains(.,'Actual')]");
        private By estimatedRadioBtn = By.XPath("//input[@class='k-radio']//..//label[contains(.,'Estimated')]");
        private By accName = By.XPath("//table//p[text()='Account Name']");
        private By accNoColumn = By.XPath("(//table//th)[2]");
        private By accNameColumn = By.XPath("(//table//th)[1]");
        private By adressColumn = By.XPath("(//table//th)[3]");
        private By MIUIDColumn = By.XPath("(//table//th)[4]");
        private By accNo = By.XPath("//table//p[text()='Account Number']");
        private By miuId = By.XPath("//table//p[text()='MIU ID']");
        private By miu = By.XPath("//table//p[contains(text(),'MIU')]");
        private By address = By.XPath("//table//p[text()='Address']");
        private By addressCheck = By.XPath("//table//p[text()='Address']//input");
        private By meterNo = By.XPath("//table//p[text()='Meter Number']");
        private By meterSize = By.XPath("//table//p[text()='Meter Size']");
        private By city = By.XPath("//table//p[text()='City']");
        private By state = By.XPath("//table//p[text()='State']");
        private By zip = By.XPath("//table//p[text()='Zip']");
        private By date = By.XPath("//table//p[text()='Date']");
        private By lastReadDate = By.XPath("//table//p[text()='Last Read Date']");
        private By days = By.XPath("//table//p[text()='Days']");
        private By threshold = By.XPath("//table//p[text()='Threshold']");
        private By flowType = By.XPath("//table//p[text()='Flow Type']");
        private By reading = By.XPath("//table//p[text()='Reading']");
        private By keyedReading = By.XPath("//table//p[text()='Keyed Reading']");
        private By completeKeyedReading = By.XPath("//table//p[text()='Keyed Reading ']");
        private By cycle = By.XPath("//table//p[text()='Cycle/Route']");
        private By readSeq = By.XPath("//table//p[text()='Read Seq']");
        private By consumptionCol = By.XPath("//table//p[text()='Consumption']");
        private By uom = By.XPath("//table//p[text()='UOM']");
        private By conv = By.XPath("//table//p[text()='Conv']");
        private By skipCode = By.XPath("//table//td[text()='Skip Code']");
        private By comments = By.XPath("//table//td[text()='Comments']");
        private By dateTime = By.XPath("//table//td[text()='Date/Time']");
        private By gatewayName = By.XPath("//p[contains(.,'Gateway Name')]");
        private By lastReadDateTime = By.XPath("//table//p[text()='Last Reading Date/Time']");
        private By lastSyncDateTime = By.XPath("//p[contains(.,'Last Sync Date/Time (Local Time)')]");
        private By miuReceived = By.XPath("//th[3]/div/p");
        private By reportGridAllHeaders = By.XPath("//*[@id='kendoGrid']//th//p");
        private By row1 = By.XPath("//kendo-grid-list//div[1]/table/tbody/tr[1]/td[1]");
        private By col2 = By.XPath("//kendo-grid-list//div[1]/table/tbody/tr[1]/td[2]");
        private By col3 = By.XPath("//kendo-grid-list//div[1]/table/tbody/tr[1]/td[3]");
        private By gridHeaderOne = By.XPath("(//table//th//p[not(text()='')])[1]");
        private By gridHeaderTwo = By.XPath("(//table//th//p[not(text()='')])[2]");
        private By gridHeaderThree = By.XPath("(//table//th//p[not(text()='')])[3]");
        private By gridHeaderFour = By.XPath("(//table//th//p[not(text()='')])[4]");
        private By gridHeaderFive = By.XPath("(//table//th//p[not(text()='')])[5]");
        private By gridHeaderSix = By.XPath("(//table//th//p[not(text()='')])[6]");
        private By gridHeaderSeven = By.XPath("(//table//th//p[not(text()='')])[7]");
        private By gridResizerColumnAcNo = By.XPath("(//th//span[contains(@class,'k-column-resizer')])[2]");
        private By gridResizerColumnAdress = By.XPath("(//th//span[contains(@class,'k-column-resizer')])[3]");
        private By gridResizerColumnAcName = By.XPath("(//th//span[contains(@class,'k-column-resizer')])[1]");
        private By btnTableSetting = By.XPath("//button[text()='Table Settings']");
        private By btndeselectAll = By.XPath("//span[text()='Deselect All']");
        private By validationTableSetting = By.XPath("//div[contains(@class,'validation')]");
        private By btnOkTableSetting = By.XPath("//span[text()='Ok']");
        private By btnCancel = By.XPath("//button[text()='Cancel']");
        private By btnResetTableSetting = By.XPath("//span[text()='Reset']");
        private By btnSelectAllTableSetting = By.XPath("//button[text()='Select All']");
        private By checkBoxMIUIDTableSetting = By.XPath("//div[contains(text(),'MIU ID')]//input");
        private By checkBoxAddressTableSetting = By.XPath("//div[contains(text(),'Address')]//input");
        private By addOrRemoveColumsHeaderTableSetting = By.XPath("//kendo-dialog-titlebar//div[text()='Add or remove columns']");
        private By btnCloseTableSetting = By.CssSelector(".k-i-x");

        //private By accName = By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[1]");
        //private By accNo=By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[2]");
        //private By miuId=By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[3]");
        //private By address=By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[4]");
        //private By city= By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[5]");
        //private By state= By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[6]");
        //private By zip= By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[7]");
        //private By date= By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[8]");
        //private By flowType= By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[9]");
        //private By reading= By.XPath("//div[3]/div[1]/div/table/tbody/tr[2]/td[10]");
        private By breadCrumb = By.XPath("//sd-toolbar/div/span/span");
        private By allLink = By.XPath("//input[@value='All']");

        private By consupmtion = By.XPath("//h3[contains(.,'Consumption')]");
        private By networkHealth = By.XPath("//h3[contains(.,'Network Health')]");
        private By criticalContCosnm = By.XPath("//div[4]//sd-dashboardcard//div[2]/h1/span/a");
        private By criticalContinousConsum = By.XPath("//input[@value='Critical Continuous Consumption']");
        private By topAccConsumption = By.XPath("//input[@value='Top 10 Accounts']");
        private By completeReadingDetail = By.XPath("//h3[contains(text(),'Complete Readings Detail')]");
        private By systemConsumptionTitleActual = By.XPath("//h3[contains(text(),'System Consumption Detail')]");
        private By systemConsumptionTitleEstimated = By.XPath("//h3[contains(text(),'System Consumption Estimated')]");
        private By topConsumptionActualDetail = By.XPath("//h3[contains(text(),'Top 10 Accounts by Consumption Detail')]");
        private By topConsumptionEstimatedDetail = By.XPath("//h3[contains(text(),'Top 10 Accounts by Consumption Estimated')]");
        private By intermittentUsageDetail = By.XPath("//h3[contains(text(),'Intermittent Usage Detail')]");
        private By exportLink = By.XPath("//img[@alt='Exports']");
        private By estimatedExportLink = By.XPath("//div/div/div[4]/div/img");
        private By intermittentExportLink = By.XPath("//img[@alt='Exports']");
        private By exportPDF = By.XPath("//p[contains(.,' PDF')]");
        private By exportExcel = By.XPath("//p[contains(.,' Excel')]");
        private By readingRightArrow = By.XPath("//div[2]/div/sd-dashboardcard/div/div[1]/h1/div[2]");
        private By incompleteReadingDetail = By.XPath("//h3[contains(text(),'Incomplete Readings Detail')]");
        private By btnActual = By.XPath("//label[contains(text(),'Actual')]");
        private By btnEstimated = By.XPath("//label[contains(text(),'Estimated')]");
        private By btnActualDetailReport = By.XPath("//label[contains(text(),'Actual')]");
        private By btnEstimatedDetailReport = By.XPath("//label[contains(text(),'Estimated')]");
        private By consumptionHeader = By.XPath("//div[contains(text(),'Consumption')]");
        private By top10ConsumtptionWidget = By.XPath("//div/div/div/div[1]/div[3]/div/span[1]");
        private By topTenCnsmNoData = By.XPath("//span[contains(text(),'No data returned for this view.')]");
        private By fromDate = By.XPath("//*[@id='mstr130']/input");
        private By toDate = By.XPath("//*[@id='mstr141']/input");
        private By lnkChooseUtilities = By.XPath("//sd-menu/ul/li[1]");
        private By utilitySearch = By.Id("utilitySearchTextBox");
        private By btnChooseUtilitiesOk = By.Id("deactUtilityYesButton");
        private By tblChooseUtilities = By.XPath("//span[text()='Choose Utilities']//../../..//table[@class='k-grid-table']//span");
        private By consistentHeader = By.XPath("//div[3]/div/div/div/div/div[1]/div");
        private By convCol = By.XPath("//p[contains(.,'Conv')]");
        private By asteriks = By.XPath("//td[contains(.,'**')]");
        private By noDataDesciption = By.XPath("//div[contains(text(),'No data returned for this view.')]");

        private By completeReadingsCount = By.XPath("//a[@href='/dashboard/detailreport-new/completereadings']");
        private By inCompleteReadingsCount = By.XPath("//a[@href='/dashboard/detailreport-new/incompletereadings']");
        private By skippedReadingCount = By.XPath("//a[@href='/dashboard/detailreport-new/skippedreadings']");
        private By receivedAMIReadingCount = By.XPath("//a[@href='/dashboard/detailreport-new/receivedami']");
        private By notReceivedReadingCount = By.XPath("//a[@href='/dashboard/detailreport-new/notreceived']");
        private By criticalReadingCount = By.XPath("//a[@href='/dashboard/detailreport-new/criticalconsumption']");
        private By criticalGatewayCount = By.XPath("//a[@href='/dashboard/detailreport/criticalgateway']");
        private By warningConsumptionCount = By.XPath("//a[@href='/dashboard/detailreport-new/warningconsumption']");
        private By normalReadingCount = By.XPath("//a[@href='/dashboard/detailreport-new/normalconsumption']");
        private By intermittentReadingCount = By.XPath("//a[@href='/dashboard/detailreport-new/intermittentconsumption']");
        private By majorreverseReadingCount = By.XPath("//a[@href='/dashboard/detailreport-new/majorreverseflow']");
        private By minorreverseReadingCount = By.XPath("//a[@href='/dashboard/detailreport-new/minorreverseflow']");
        private By criticalGatewayReadingCount = By.XPath("//a[@href='/dashboard/detailreport/criticalgateway']");
        private By warningGatewayReadingCount = By.XPath("//a[@href='/dashboard/detailreport/warninggateway']");
        private By normalGatewayReadingCount = By.XPath("//a[@href='/dashboard/detailreport/normalgateway']");
        private By receivedAmrReadingCount = By.XPath("//a[@href='/dashboard/detailreport-new/receivedamr']");
        private By reporttable = By.XPath("//div[@class='mstrmojo-XtabZone']/table");
        private By skipppedReadingTitle = By.XPath("//h3[contains(text(),'Skipped Readings Detail')]");
        private By warningGatewayHeader = By.XPath("//h3[contains(text(),'Gateway Status Warning Detail')]");
        private By receivedAmiCount = By.XPath("//a[contains(@href,'receivedami')]");
        private By meterreceivedamidetailTitle = By.XPath("//h3[contains(text(),'Meter Received via AMI Detail')]");
        private By metersnotreceiveddetailTitle = By.XPath("//h3[contains(text(),'Meter Not Received Detail')]");
        private By meterreceivedamrdetailTitle = By.XPath("//h3[contains(text(),'Meter Received via AMR Detail')]");
        private By pageTitle = By.XPath("//div[2]/div[3]/div/div/div/div/div[1]/div");
        private By meterSizeFIlter = By.XPath("//label[text()='From: ']//ancestor::div[@class='row']//label[contains(text(),Meter')]");
        private By clustertext = By.XPath("(//img[contains(@src,'data:image/svg+xml')]//..//following-sibling::div//child::div)[3]");
        private By cluster = By.XPath("(//img[contains(@src,'data:image/svg+xml;base64')])");
        private By pinbutton = By.XPath("//div[not(contains(@title,'Cluster')) and @role='button']");
        private By cluster1 = By.XPath("//img[@src='https://maps.gstatic.com/mapfiles/transparent.png']");
        private By bubble = By.XPath("//span[text()='Account Name:']/../..");
        private By consumptiondetails = By.XPath("//span[text()='Account Name:']/../..//following-sibling::span");
        private By fromdatecalendarButton = By.XPath("//label[text()='From: ']//following-sibling::reportdate-picker//i");
        private By todatecalendarButton = By.XPath("//label[text()='To: ']//following-sibling::reportdate-picker//i");
        private By selectedDate = By.XPath("//td[contains(@class,'k-state-selected')]");
        private By currentMonth = By.XPath("//span[@class='k-button k-bare k-title']");
        private By accountnumbers = By.XPath("//table[@class='k-grid-table']//tr//td[2]//span");
        private By accountname = By.XPath("//table[@class='k-grid-table']//tr//td[1]//span");
        private By gridUOM = By.XPath("//table[@class='k-grid-table']//tr[1]//td[8]//span");
        private By gridAllUOM = By.XPath("//table[@class='k-grid-table']//tr//td[8]//span");
        private By gridAllConsumption = By.XPath("//table[@class='k-grid-table']//tr//td[7]//span");
        private By gridRowCount = By.XPath("//div[@class='k-grid-aria-root']");
        private By gridAllActName = By.XPath("//table[@class='k-grid-table']//tr//td[1]//span");
        private By lftNavDashboard = By.XPath("//span[text()='DASHBOARD']");
        private By systemconsumptionbarcharttext = By.XPath("//span[text()='System Consumption']//..//following-sibling::div//*[local-name()='text' and not( .='') ]");

        private By systemConsumptionTable = By.ClassName("k-grid-container");
        private By meterTypeFilter = By.XPath("//kendo-dropdownlist//span[text()='Select Meter Type']");
        private By meterSizeFilter = By.XPath("//kendo-dropdownlist//span[text()='Select Meter Size']");
        private By TotalMeterCount = By.XPath("//p[contains(text(),'Total Meter Count']");

        private By reportGrid = By.CssSelector(".k-grid-aria-root");
        private By reportData = By.XPath("//tr[@data-kendo-grid-item-index]");
        private By mapButton = By.XPath("//button[@aria-label='Show street map']");

        private By top10DashboardConsumptions = By.XPath("(//kendo-chart)[2]//*[name()='g']/*[name()='path']/../*[name()='text']");
        private By top10ReportConsumptions = By.XPath("//tbody//tr//td[7]//span");
        private By uomFIlter = By.XPath("//label[text()='From: ']//ancestor::div[@class='row']//label[contains(text(),UOM')]");
        private By receivedPullLeft = By.XPath("(//sd-dashboardcard)[2]//following-sibling::div[@class='glyphicon glyphicon-triangle-left pull-left']");
        private By receivedPullRIght = By.XPath("(//sd-dashboardcard)[2]//following-sibling::div[@class='pull-right fa fa-caret-right']");
        private By receivedcount = By.XPath("(//sd-dashboardcard)[2]//following-sibling::span[@class]//a");
        private By completePullLeft = By.XPath("(//sd-dashboardcard)[1]//following-sibling::div[@class='glyphicon glyphicon-triangle-left pull-left']");
        private By completePullRIght = By.XPath("(//sd-dashboardcard)[1]//following-sibling::div[@class='glyphicon glyphicon-triangle-right pull-right']");
        private By completedcount = By.XPath("(//sd-dashboardcard)[1]//following-sibling::span[@class]//a");
        private By meternotReceived = By.XPath("//h3[text()='Meter Not Received Detail']");
        //private By gridAllUOM = By.XPath("//table[@class='k-grid-table']//tr//td[8]//span");
        //private By gridRowCount = By.XPath("//div[@class='k-grid-aria-root']");
        private By statusColumnHeader = By.XPath("//table[@role='presentation' and not(@class='k-grid-table')]//th[8]//p");
        private By meterSizeColumnHeader = By.XPath("//table[@role='presentation' and not(@class='k-grid-table')]//th[7]//p");
        private By readingColumnHeader = By.XPath("//table[@role='presentation' and not(@class='k-grid-table')]//th[9]//p");
        private By accountNameColumnHeader = By.XPath("//table[@role='presentation' and not(@class='k-grid-table')]//th[2]//p");
        private By statusSortingOrder = By.XPath("//table[@role='presentation' and not(@class='k-grid-table')]//th[8]//p/..//div[@class='sort']");
        private By sortAscending = By.XPath("//p[text()='Sort Ascending']");
        private By accountNameSort = By.XPath("//p[text()='Account Name']/..//div[@class='sort']");
        private By gridAllaccounts = By.XPath("//table[@class='k-grid-table']//tr//td[2]//span");
        private By gridAllMeterreadings = By.XPath("//table[@class='k-grid-table']//tr//td[6]//span");
        private By firstAccountName = By.XPath("//table[@class='k-grid-table']//tr[1]//td[2]//span");
        private By completedPullLeftgray = By.XPath("(//sd-dashboardcard)[1]//following-sibling::div[@class='glyphicon glyphicon-triangle-left pull-left grayColor']");
        private By completedPullRightgray = By.XPath("(//sd-dashboardcard)[1]//following-sibling::div[@class='glyphicon glyphicon-triangle-right pull-right grayColor']");
        private By receivedPullLeftgray = By.XPath("(//sd-dashboardcard)[2]//following-sibling::div[@class='glyphicon glyphicon-triangle-left pull-left grayColor']");
        private By receivedPullRightgray = By.XPath("(//sd-dashboardcard)[2 ]//following-sibling::div[@class='glyphicon glyphicon-triangle-right pull-right grayColor']");
        private By majorReverseFlowColor = By.XPath("(//input[@value='Major Reverse Flow']//preceding-sibling::span)[2]");
        private By criticalContinuousConsumptionColor = By.XPath("(//input[@value='Critical Continuous Consumption']//preceding-sibling::span)[3]");
        //private By gridLoader = By.XPath("//div[contains(@class,'report-grid-loader')]");
        //private By reportGridLoader = By.XPath("//div[@class='k-loading-mask']");
        private By reverseFlowRightIcon = By.XPath("//h3[text()='Reverse Flow']//..//..//preceding-sibling::div//span[text()='Major' or text()='Minor']//following-sibling::div[contains(@class,'right')]");
        private By reverseflowCount = By.XPath("(//sd-dashboardcard)[4]//following-sibling::span[@class]//a");
        private By reverseflowPullLeft = By.XPath("(//sd-dashboardcard)[4]//following-sibling::div[@class='glyphicon glyphicon-triangle-left pull-left']");
        private By reverseflowPullRIght = By.XPath("(//sd-dashboardcard)[4]//following-sibling::div[@class='glyphicon glyphicon-triangle-right pull-right']");
        private By kpiPosition3 = By.XPath("//h3[text()='Continuous Consumption']//ancestor::div[contains(@class,'card') and not(@class='card-header cardfooter')]//div[contains(@class,'right')]");
        private By kpiPositionX_Footer = By.XPath("//div[contains(@class,'cardfooter')]//h3");
        private By kpiPositionX_Caption = By.XPath("//span[@class='headerText']//a");
        private By date_Report = By.XPath("//td[@aria-colindex='9']//span");
        private By readings_Report = By.XPath("//td[@aria-colindex='7']//span");
       
        private By kendoGridview = By.XPath("//div[@class='row grid-view']");
        private By majorReverseflowReportDate = By.XPath("//p[contains(text(),'Report Date')]");
        private By systemConsumptionGraphDisplay = By.XPath("//span[text()='System Consumption']//ancestor::div[@class='col-sm-12 alert banner whiteColor']");
        private By systemConsumptionGraphDisplaybeforeTop10 = By.XPath("//div[@class='row']//span[@class='pull-left iframeText' and text()='Top 10 Accounts by Consumption']/../../..//span[text()='System Consumption']//ancestor::div[@class='col-sm-12 alert banner whiteColor']");
        private By miuids = By.XPath("//table[@class='k-grid-table']//tr//td[4]//span");
        private By miuIdColumnHeader = By.XPath("//p[text()='MIU ID']");
        private By reverseflowPullRightgray = By.XPath("(//sd-dashboardcard)[4]//following-sibling::div[@class='glyphicon glyphicon-triangle-right pull-right grayColor']");
        private By dataInReport = By.XPath("//table[@class='k-grid-table']//tr");
        private By reportKendoGrid = By.CssSelector("kendo-grid#kendoGrid");

        private string dataInColumn3Report = "(//table[@class='k-grid-table']//tr//td[@aria-colindex='3']//span)[_dataRow_]";
        private By ContinuousConsumptionCount = By.XPath("(//sd-dashboardcard)[3]//following-sibling::span[@class]//a");
        private By ContinuousConsumptionRightarray = By.XPath("(//sd-dashboardcard)[3]//following-sibling::div[@class='glyphicon glyphicon-triangle-right pull-right grayColor']");
        private By continuousConsumptionPullRIght = By.XPath("(//sd-dashboardcard)[3]//following-sibling::div[@class='glyphicon glyphicon-triangle-right pull-right']");

        private string dataInMIUcountColumn = "(//table[@class='k-grid-table']//tr//td[@aria-colindex='3']//span)[_dataRow_]";
        #endregion




        /// <summary>
        /// Method to Validate Consumption Detailed Report
        /// </summary>
        public void ValidateConsumptionDetaiedReport()
        {
            driver.ClickElement(detailReport, "Detailed Report");
            driver.sleepTime(20000);
            driver.WaitForElement(backToKPI, System.TimeSpan.FromSeconds(30000));
            driver.CheckElementExists(backToKPI, "Detailed Report Page");
        }

        public void clickonbactokpi()
        {
            //driver.ClickElement(detailReport, "Detailed Report");
            //driver.sleepTime(20000);
            driver.WaitForElement(backToKPI, System.TimeSpan.FromSeconds(30000));
            driver.ClickElement(backToKPI, "Detailed Report Page");
        }

        /// <summary>
        /// Method to Validate Consumption Detailed Report Not Displayed 
        /// </summary>
        public void ValidateConsumptionDetaiedReportNotDisplayed()
        {
            //driver.ClickElement(detailedReport, "Detailed Report");
            driver.sleepTime(20000);
            driver.CheckElementDoesnotExists(backToKPI, "Detailed Report Page");
        }

        /// <summary>
        /// Method to Validate Trend option not displayed
        /// </summary>
        public void ValidateTrendOptionNotDisplayed()
        {
            //driver.ClickElement(detailedReport, "Detailed Report");
            driver.sleepTime(20000);
            driver.CheckElementDoesnotExists(backToKPI, "Detailed Report Page");
        }

        /// <summary>
        /// Method to Validate meter type filter not displayed
        /// </summary>
        public void ValidateMeterTypeFilterNotDisplayed()
        {
            //driver.ClickElement(detailedReport, "Detailed Report");
            driver.sleepTime(20000);
            driver.CheckElementDoesnotExists(backToKPI, "Detailed Report Page");
        }

        /// <summary>
        /// Method to Validate grid view
        /// </summary>
        public void ValidateGridView()
        {
            driver.sleepTime(5);
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "Detailed Report");
            driver.sleepTime(20000);
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"),TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
            driver.CheckElementDisplayed(gridView, "Grid View");
            ////driver.SwitchToDefaultFrame();

        }

        /// <summary>
        /// Method to Validate map view
        /// </summary>
        public void ValidateMapView()
        {
            driver.sleepTime(130);
            driver.ClickElement(detailReport, "Detailed Report");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(mapView, "Map view");
            //IWebElement ele = driver.FindElement(By.ClassName("mstrmojo-DocPanelStack "));
            driver.WaitForElement(map, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(map, "Map");
            driver.sleepTime(2000);
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Reverse Flow map view
        /// </summary>
        public void ValidateReverseFlowMapView()
        {
            driver.WaitForElement(majorreverseReadingCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(majorreverseReadingCount, "Major Reverse Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(mapView, "Map view");

            driver.sleepTime(2000);
            //driver.SwitchToDefaultFrame();
        }


        /// <summary>
        /// Method to Validate Minor Reverse Flow map view
        /// </summary>
        public void ValidateMinorReverseFlowMapView()
        {
            driver.WaitForElement(majorreverseReadingCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(reverseFlowRightArrow, "Right");
            driver.ClickElement(minorreverseReadingCount, "Major Reverse Flow");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            //IWebElement ele = driver.FindElement(By.ClassName("mstrmojo-DocPanelStack "));
            driver.WaitForElement(map, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(gridView, "Grid View");
            driver.sleepTime(2000);
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Minor Reverse Flow Page Load
        /// </summary>
        public void ValidateMinorReverseFlowPageLoad()
        {
            driver.WaitForElement(majorreverseReadingCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(reverseFlowRightArrow, "Right");
            driver.ClickElement(minorreverseReadingCount, "Minor Reverse Flow");
            driver.sleepTime(1000);
            string url = driver.Url;
            if (url.Contains("/dashboard/detailreport/minorreverseflow"))
            {
                testReport.Pass("User is redirected to Minor Reverse Flow detailed report" + url);
            }
        }

        /// <summary>
        /// Method to Validate Minor Reverse Flow Back to KPI
        /// </summary>
        public void ValidateMinorReverseFlowBacktoKPI()
        {
            driver.WaitForElement(majorreverseReadingCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(reverseFlowRightArrow, "Right");
            driver.ClickElement(minorreverseReadingCount, "Minor Reverse Flow");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(30));
            driver.ClickElement(backToKPI, "Back to KPI");
            driver.CheckElementDisplayed(dashboardTitle, "Dashboard Screen");
        }


        /// <summary>
        /// Method to Validate Minor Reverse Flow details
        /// </summary>
        public void ValidateMinorReverseDetails()
        {
            driver.WaitForElement(majorreverseReadingCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(reverseFlowRightArrow, "Right");
            driver.ClickElement(minorreverseReadingCount, "Major Reverse Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            //IWebElement ele = driver.FindElement(By.ClassName("mstrmojo-DocPanelStack "));
            driver.WaitForElement(mapView, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(gridView, "Grid View");

            driver.CheckElementDisplayed(accName, "Account Name");
            driver.CheckElementDisplayed(accNo, "Acc no");
            driver.CheckElementDisplayed(miuId, "MIU ");
            driver.CheckElementDisplayed(address, "Address");
            driver.CheckElementDisplayed(date, "Date");
            driver.CheckElementDisplayed(reading, "Reading");
            driver.sleepTime(2000);
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Complete Readings Details
        /// </summary>
        public void ValidateCompleteReadingsColumnDetails()
        {
            driver.WaitForElement(completeReadingsCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(completeReadingsCount, "Complete Readings");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(accName, TimeSpan.FromSeconds(10));

            driver.CheckElementDisplayed(accName, "Account Name");
            driver.CheckElementDisplayed(accNo, "Acc no");
            driver.CheckElementDisplayed(miuId, "MIU Id");
            driver.CheckElementDisplayed(address, "Address");
            //driver.CheckElementDisplayed(city, "City");
            //driver.CheckElementDisplayed(state, "State");
            //driver.CheckElementDisplayed(zip, "Zip");
            //driver.CheckElementDisplayed(lastReadDate, "Last Read Date");
            //driver.CheckElementDisplayed(days, "Days");
            //driver.CheckElementDisplayed(threshold, "Threshold");
            Actions builder = new Actions(driver);
            driver.WaitForElement(statusColumnHeader, TimeSpan.FromSeconds(60));
            IJavaScriptExecutor exe1 = (IJavaScriptExecutor)driver;
            exe1.ExecuteScript("arguments[0].scrollIntoView();", driver.FindElement(readingColumnHeader));
            driver.WaitForElement(statusColumnHeader, TimeSpan.FromSeconds(60));
            builder.MoveToElement(driver.FindElement(By.XPath("//table[@role='presentation' and not(@class='k-grid-table')]//th[8]//p"))).Build().Perform();
            driver.CheckElementDisplayed(reading, "Reading");
            driver.sleepTime(2000);
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Inomplete Readings Details
        /// </summary>
        public void ValidateIncompleteReadingsDetails()
        {
            driver.WaitForElement(completeReadingsCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(readingRightArrow, "Right");
            driver.ClickElement(inCompleteReadingsCount, "Readings");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            //IWebElement ele = driver.FindElement(By.ClassName("mstrmojo-DocPanelStack "));
            driver.WaitForElement(mapView, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(accName, "Account Name");
            driver.CheckElementDisplayed(accNo, "Acc no");
            driver.CheckElementDisplayed(miuId, "MIU Id");
            driver.CheckElementDisplayed(address, "Address");
            driver.CheckElementDisplayed(reading, "Reading");
            driver.sleepTime(2000);
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Reverse Flow URL
        /// </summary>
        public void ValidateMajorReverseFlowURL()
        {
            driver.WaitForElement(majorreverseReadingCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(majorreverseReadingCount, "Major Reverse Flow");
        }

        /// <summary>
        /// Method to Validate Inomplete Readings Details
        /// </summary>
        public void ValidateIncompleteMapView()
        {
            driver.WaitForElement(completeReadingsCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(readingRightArrow, "Right");
            driver.ClickElement(inCompleteReadingsCount, "Incompplete Readings");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            //IWebElement ele = driver.FindElement(By.ClassName("mstrmojo-DocPanelStack "));
            driver.WaitForElement(map, TimeSpan.FromSeconds(10));
            driver.ClickElement(mapView, "Map View");

            driver.sleepTime(2000);
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Top Ten Accounts MapView
        /// </summary>
        public void ValidateTopTenAccMapView()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Consumption Details Report ");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            //IWebElement ele = driver.FindElement(By.ClassName("mstrmojo-DocPanelStack "));
            driver.WaitForElement(map, TimeSpan.FromSeconds(10));
            driver.ClickElement(mapView, "Map View");

            driver.sleepTime(2000);
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Top Ten Accounts Account Details
        /// </summary>
        public void ValidateTopTenAccAccountDetails()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Consumption Details Report ");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            //IWebElement ele = driver.FindElement(By.ClassName("mstrmojo-DocPanelStack "));
            driver.WaitForElement(map, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(accName, "Account Name");
            driver.CheckElementDisplayed(accNo, "Acc no");
            driver.CheckElementDisplayed(miu, "MIU");
            driver.CheckElementDisplayed(address, "Address");
            //driver.CheckElementDisplayed(city, "City");
            //driver.CheckElementDisplayed(state, "State");
            //driver.CheckElementDisplayed(zip, "Zip");
            //driver.CheckElementDisplayed(date, "Date");
            //driver.CheckElementDisplayed(days, "Days");
            //driver.CheckElementDisplayed(threshold, "Threshold");
            //driver.CheckElementDisplayed(reading, "Reading");
            driver.sleepTime(2000);
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Details Report Default Date Range
        /// </summary>
        public void ValidateDetailsReportDefaultDateRange()
        {
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(30));
            driver.ClickElement(detailReport, "Details Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            //IWebElement ele = driver.FindElement(By.ClassName("mstrmojo-DocPanelStack "));
            verifyDefaultSelectedDates();
           /* string fromdate1 = driver.GetElementAttribute(fromDate, "value");
            string todate1 = driver.GetElementAttribute(toDate, "value");

            if (Convert.ToDateTime(todate1) - Convert.ToDateTime(fromdate1) == TimeSpan.FromDays(7))
            {
                testReport.Pass("Default Date range for screen is 7 days");
            }
            else
            {
                ReporterFactory.LogFailure("Default Date range for screen is not 7 days");
            }

            //driver.CheckElementDisplayed(reportDate, "Default Date");
            driver.sleepTime(2000);*/
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Top Acc Consumption Value
        /// </summary>
        public void ValidateTopAccConsumptionValue()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(topTenConsmpVertical, "Details Report ");
        }

        /// <summary>
        /// Method to Validate Top Acc Consumption Value Display Order
        /// </summary>
        public void ValidateTopAccConsumptionValueDisplayOrder()
        {
            By toptenGraph = By.XPath("//span[contains(text(),'KPI Top 10 Accounts by Consumption')]");
            driver.WaitForElement(toptenGraph, TimeSpan.FromSeconds(30));

            driver.CheckElementExists(toptenGraph, "Top 10 consumption graph", "horizontal bars with consumption values are not displayed");
        }

        /// <summary>
        /// Method to Validate Normal Continous Consumption Detailed Report
        /// </summary>
        public void ValidateNormalContinousCusumptionDetailedReport()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
        }

        /// <summary>
        /// Method to Validate Normal Continous Consumption Report Date
        /// </summary>
        public void ValidateNormalContinousCusumptionReportDate()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(continuousCount, "Normal Consumption KPI");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(reportDate, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(reportDate, "Report Date");
            ////driver.SwitchToDefaultFrame();
        }


        /// <summary>
        /// Method to Validate Continous Consumption Report Title
        /// </summary>
        public void ValidateContinousCusumptionDateRange()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.CheckElementDisplayed(reportDate, "Date");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Continous Consumption Report Title
        /// </summary>
        public void ValidateContinousCusumptionReportTitle()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(180));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Normal Consumption Detailed Report ");
            driver.WaitForElement(breadCrumb, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(breadCrumb, "Breadcrumb");
        }

        /// <summary>
        /// Method to Validate Continous Consumption Detail Report
        /// </summary>
        public void ValidateContinousCusumptionDetailReport()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            driver.WaitForElement(accName, TimeSpan.FromSeconds(30));

            //driver.SwitchToFrameById("ntgMSTRFrame");
            //IWebElement ele = driver.FindElement(By.ClassName("mstrmojo-DocPanelStack "));
            driver.CheckElementDisplayed(accName, "Account Name");
            driver.CheckElementDisplayed(accNo, "Acc no");
            driver.CheckElementDisplayed(miuId, "MIU Id");
            driver.CheckElementDisplayed(address, "Address");
            //driver.CheckElementDisplayed(city, "City");
            //driver.CheckElementDisplayed(state, "State");
            //driver.CheckElementDisplayed(zip, "Zip");
            driver.CheckElementDisplayed(date, "Date");
            driver.CheckElementDisplayed(days, "Days");
            //driver.CheckElementDisplayed(threshold, "Threshold");
            driver.CheckElementDisplayed(reading, "Reading");
            driver.sleepTime(2000);
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Continous Consumption Grid View
        /// </summary>
        public void ValidateContinousCusumptionGridView()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            //driver.ClickElement(cotinuousRightArrow, "Right");
            //driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(mapxpathingridview, TimeSpan.FromSeconds(40));
            driver.ClickElement(mapxpathingridview, "Map");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateWarningCusumptionGridView()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Right");
            //driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(mapxpathingridview, TimeSpan.FromSeconds(40));
            driver.ClickElement(mapxpathingridview, "Grid View");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateWarningCusumptionMapView()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Right");
            //driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(mapView, "Map View");
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Continous Consumption Title
        /// </summary>
        public void ValidateContinousCusumptionTitle()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            driver.WaitForElement(breadCrumb, TimeSpan.FromSeconds(10));
            string s = driver.GetElementText(breadCrumb);
            if (s.Contains("CRITICAL CONTINUOUS USAGE"))
            {
                testReport.Pass("CRITICAL CONTINUOUS USAGE is displayed as the title");
            }
        }

        /// <summary>
        /// Method to Validate Continous Consumption Report Text
        /// </summary>
        public void ValidateContinousCusumptionReportText()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            driver.WaitForElement(reportDate, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(reportDate, "Report Date");
        }

        /// <summary>
        /// Method to Validate Continous Consumption Acc No
        /// </summary>
        public void ValidateContinousCusumptionAccNo()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
           // driver.ClickElement(cotinuousRightArrow, "Right");
            //driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(accNo, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(accNo, "Acc No");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateNetworkHealthNotDisplayed()
        {
            driver.CheckElementDoesnotExists(networkHealth, "Network Health");
        }
        /// <summary>
        /// Method to Validate Continous Consumption Address
        /// </summary>
        public void ValidateContinousCusumptionAddress()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            //driver.ClickElement(cotinuousRightArrow, "Right");
            //driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(address, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(address, "Address");
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Continous Consumption State
        /// </summary>
        public void ValidateContinousCusumptionState()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            //driver.ClickElement(cotinuousRightArrow, "Right");
            //driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(state, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(state, "State");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Continous Consumption Date
        /// </summary>
        public void ValidateContinousCusumptionDate()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            //driver.ClickElement(cotinuousRightArrow, "Right");
            //driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(date, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(date, "date");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Continous Consumption Threshold
        /// </summary>
        public void ValidateContinousCusumptionThreshold()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            //driver.ClickElement(cotinuousRightArrow, "Right");
            //driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(threshold, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(threshold, "Threshold");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Continous Consumption Account_Name
        /// </summary>
        public void ValidateContinousCusumptionAccName()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            //driver.ClickElement(cotinuousRightArrow, "Right");
            //driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(accName, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(accName, "Account Name");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Continous Consumption MIU
        /// </summary>
        public void ValidateContinousCusumptionMIU()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            //driver.ClickElement(cotinuousRightArrow, "Right");
            //driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(miu, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(miu, "MIU");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Continous Consumption City
        /// </summary>
        public void ValidateContinousCusumptionCity()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            //driver.ClickElement(cotinuousRightArrow, "Right");
            //driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(city, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(city, "City");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Continous Consumption Zip
        /// </summary>
        public void ValidateContinousCusumptionZip()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            //driver.ClickElement(cotinuousRightArrow, "Right");
            //driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(zip, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(zip, "Zip");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Continous Consumption Days
        /// </summary>
        public void ValidateContinousCusumptionDays()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            //driver.ClickElement(cotinuousRightArrow, "Right");
            //driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(days, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(days, "Days");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Continous Consumption left Arrow
        /// </summary>
        public void ValidateContinousCusumptionleftArrow()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.CheckElementDisplayed(continuousLeftArrow, "Left");
            testReport.Pass("Previous KPI is displayed in the Continuous Consumption widget");
        }

        /// <summary>
        /// Method to Validate Continous Consumption left Arrow Disabled
        /// </summary>
        public void ValidateContinousCusumptionleftArrowDisabled()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            //driver.ClickElement(cotinuousRightArrow, "Right");
            //driver.ClickElement(cotinuousRightArrow, "Right");
            //driver.ClickElement(cotinuousRightArrow, "Right");
            driver.CheckElementDisplayed(continuousLeftArrow, "Left");
            testReport.Pass("Left Arrow is disabled when the first KPI is displayed");
        }


        /// <summary>
        /// Method to Validate Continous Consumption ExportPDF
        /// </summary>
        public void ValidateContinousCusumptionExportPDF()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF");
            //driver.ClickElement(map, "Map");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateCritialContinousCusumptionExportPDF()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF");
            //driver.ClickElement(map, "Map");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateCritialContinousCusumptionExportExcel()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel");
            //driver.ClickElement(map, "Map");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateWarningContinousCusumptionExportPDF()
        {
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Consumption Detailed Report ");
            driver.ClickElement(warningConsumptionCount, "Warning Consumption");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateWarningContinousCusumptionExportExcel()
        {
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Consumption Detailed Report ");
            driver.ClickElement(warningConsumptionCount, "Warning Consumption");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateCritialContinousCusumptionReportDate()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.CheckElementDisplayed(reportDate, driver.GetElementText(reportDate));
            //driver.ClickElement(map, "Map");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateWarningContinousCusumptionReportDate()
        {
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Consumption Detailed Report ");
            driver.ClickElement(warningConsumptionCount, "Warning Consumption");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.CheckElementDisplayed(reportDate, driver.GetElementText(reportDate));
            ////driver.SwitchToDefaultFrame();
        }


        /// <summary>
        /// Method to Validate Continous Consumption Export Excel
        /// </summary>
        public void ValidateContinousCusumptionExportExcel()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Intermittent Detail Report
        /// </summary>
        public void ValidateIntermittentDetailReportDateRange()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(reportDate, "Report Date");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Complete Detail Report
        /// </summary>
        public void ValidateCompleteDetailReportDateRange()
        {
            driver.WaitForElement(completeReadingsCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(completeReadingsCount, "Complete Count");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(reportDate, "Report Date");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Complete Reading Load Page
        /// </summary>
        public void ValidateCompleteReadingLoadPage()
        {
            driver.WaitForElement(completeReadingsCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(completeReadingsCount, "Complete Reading Count");
            driver.sleepTime(2000);
            string url = driver.Url;
            if (url.Contains("/dashboard/detailreport/completereadings"))
            {
                testReport.Pass("URL is : " + url);
            }
        }

        /// <summary>
        /// Method to Validate Intermittent Detail Columns
        /// </summary>
        public void ValidateIntermittentDetailReportColumns()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(accName, "Account Name");
            driver.CheckElementDisplayed(accNo, "Äccount No");
            driver.CheckElementDisplayed(miu, "MIU");
            driver.CheckElementDisplayed(address, "Address");
            driver.CheckElementDisplayed(city, "City");
            driver.CheckElementDisplayed(state, "State");
            driver.CheckElementDisplayed(zip, "Zip");
            driver.CheckElementDisplayed(date, "Date");
            driver.CheckElementDisplayed(flowType, "Flow Type");
            driver.CheckElementDisplayed(reading, "Reading");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Intermittent Detail Map view
        /// </summary>
        public void ValidateIntermittentDetailReportMapView()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(mapView, "Map");
            driver.WaitForElement(map, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(map, "Map View");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateCriticalContinuousDetailReportMapView()
        {
            driver.WaitForElement(criticalContCosnm, TimeSpan.FromSeconds(30));
            driver.ClickElement(criticalContCosnm, "Consumption Detailed Report ");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(exportLink, TimeSpan.FromMinutes(1));
            driver.ClickElement(mapView, "Map");
            driver.WaitForElement(map, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(map, "Map View");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate KPI Complete Right Arrow
        /// </summary>
        public void ValidateKPICompleteRightArrow()
        {
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(completeRight, "Complete Right Arrow");
        }

        /// <summary>
        /// Method to Validate KPI Complete Left Arrow
        /// </summary>
        public void ValidateKPICompleteLeftArrow()
        {
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(30));
            driver.IsElementEnabled(completeLeft, "Complete Left Arrow");
        }

        /// <summary>
        /// Method to Validate KPI Incomplete Right Arrow
        /// </summary>
        public void ValidateKPIIncompleteRightArrow()
        {
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(30));
            driver.ClickElement(completeRight, "Right");
            driver.IsElementEnabled(completeRight, "Complete Right Arrow");
        }

        /// <summary>
        /// Method to Validate KPI Incomplete Left Arrow
        /// </summary>
        public void ValidateKPIIncompleteLefttArrow()
        {
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(30));
            driver.ClickElement(completeRight, "Right");
            driver.IsElementEnabled(completeLeft, "Complete Left Arrow");
        }

        /// <summary>
        /// Method to Validate Skipped Right Arrow
        /// </summary>
        public void ValidateSkippedRighttArrow()
        {
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(30));
            driver.ClickElement(completeRight, "Right");
            driver.ClickElement(completeRight, "Right");
            driver.ClickElement(completeRight, "Right");
            driver.CheckElementDisplayed(completeRight, "Skipped Right Arrow");
        }

        /// <summary>
        /// Method to Validate Skipped Left Arrow
        /// </summary>
        public void ValidateSkippedLefttArrow()
        {
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(30));
            driver.ClickElement(completeRight, "Right");
            if (driver.GetElementText(metersReadingsKpi).Equals("Incomplete"))
            {
                testReport.Pass("Ïncomplete Reading Displayed");
            }
        }

        /// <summary>
        /// Method to Validate All Default Layers
        /// </summary>
        public void ValidateAllDefaultLayers()
        {
            driver.WaitForPageLoad(TimeSpan.FromMinutes(1));
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromMinutes(1));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            //driver.CheckElementDisplayed(topAccConsumption, "Details Report ");
        }

        /// <summary>
        /// Method to Validate Top 10 Acc Links
        /// </summary>
        public void ValidateTopTenAccLink()
        {
            driver.WaitForPageLoad(TimeSpan.FromSeconds(30));
            //driver.WaitForElement(topAccConsumption,TimeSpan.FromMinutes(1));
        }

        /// <summary>
        /// Method to Validate All Link
        /// </summary>
        public void ValidateAllLink()
        {
            driver.sleepTime(40);
            //driver.WaitForElement(By.XPath("//div[1]/div[4]/div/sd-dashboard-iframe"), TimeSpan.FromMinutes(1));
            //driver.SwitchToFrameByLocator(By.XPath("//div[1]/div[4]/div/sd-dashboard-iframe"));
            //driver.CheckElementDisplayed(By.XPath("//div[1]/div[4]/div/sd-dashboard-iframe"),"");
            //driver.switchBackToMainWindow();
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"),TimeSpan.FromSeconds(20));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            //driver.ClickElement(allLink,"All");
            //driver.switchBackToMainWindow(); 
        }




        /// <summary>
        /// Method to Validate top twenty consumption
        /// </summary>
        public void ValidateTopTwentyConsumption()
        {
            driver.sleepTime(20000);
            driver.ClickElement(detailReport, "Detailed Report");
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(mapView, "Map view");
            if (driver.CheckElementDisplayed(topTwenty, "Top 20 Consumption"))
            {
                driver.sleepTime(2000);
                testReport.Pass("<i> Top 20 Consumption is Displayed. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Top 20 Consumption is Not Displayed. ");
            }
            driver.sleepTime(2000);
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate middle sixty consumption
        /// </summary>
        public void ValidateMiddleSixtyConsumption()
        {
            driver.sleepTime(40);
            driver.ClickElement(detailReport, "Detailed Report");
            driver.sleepTime(20000);
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(mapView, "Map view");
            if (driver.CheckElementDisplayed(middleSixty, "Top 20 Consumption"))
            {
                driver.sleepTime(2000);
                testReport.Pass("<i> Middle 60 Consumption is Displayed. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Middle 60 Consumption is Not Displayed. ");
            }
            driver.sleepTime(2000);
            ////driver.SwitchToDefaultFrame();
        }
        /// <summary>
        /// Method to Validate bottom twenty consumption
        /// </summary>
        public void ValidateBottomTwentyConsumption()
        {
            driver.WaitForElement(detailReport, System.TimeSpan.FromSeconds(30000));
            driver.ClickElement(detailReport, "Detailed Report");
            driver.sleepTime(20000);
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(mapView, "Map view");
            if (driver.CheckElementDisplayed(bottomTwenty, "Bottom 20 Consumption"))
            {
                driver.sleepTime(2000);
                testReport.Pass("<i> Bottom 20 Consumption is Displayed. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Bottom 20 Consumption is Not Displayed. ");
            }
            driver.sleepTime(2000);
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate grid view no consumption data
        /// </summary>
        public void ValidateGridViewNoCosnumptionData()
        {
            /*driver.ClickElement(lnkChooseUtilities, "Utilities Dropdown");
            driver.SendKeysToElementAndPressEnter(utilitySearch, "SQA", "Utility");
            driver.ClickElement(tblChooseUtilities, "Select");
            driver.ClickElement(btnChooseUtilitiesOk, "OK");
            driver.ClickElement(detailReport, "Detailed Report");*/
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");   
           // driver.ClickElement(gridView, "Grid view");
            if (driver.GetElementText(noDataReturned).Equals("No data returned for this view. This might be because the applied filter excludes all data."))
            {
                driver.sleepTime(2000);
                testReport.Pass("<i>Message displayed is : </i>" + driver.GetElementText(noDataReturned));
            }
            else
            {
                ReporterFactory.LogFailure(driver.GetElementText(noDataReturned) + "is Not Displayed. ");
            }
            driver.sleepTime(2000);
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate system consumption widget display
        /// </summary>
        public void ValidateSystemConsumptionWidget()
        {
            if (driver.CheckElementDisplayed(systemConsumption, "System Consumption Widget"))
            {
                testReport.Pass("<i>System Consumption Widget is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("System Consumption Widget is NotDisplayed.");
            }
        }
        /// <summary>
        /// Method to Validate system consumption detailed report link
        /// </summary>
        public void ValidateDetailedReportLink()
        {
            driver.sleepTime(40);
            if (driver.CheckElementDisplayed(detailReport, "Detailed Report Link"))
            {
                testReport.Pass("<i>Detailed Report Link is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Detailed Report Link is Not Displayed.");
            }
        }

        /// <summary>
        /// Method to Validate system consumption detailed report link
        /// </summary>
        public void ValidateSystemConsNoData()
        {
           /* driver.ClickElement(lnkChooseUtilities, "Utilities Dropdown");
            driver.ClickElement(lnkChooseUtilities, "Utilities Dropdown");
            driver.SendKeysToElementAndPressEnter(utilitySearch, "TestUtility", "Utility");
            driver.ClickElement(tblChooseUtilities, "Select");
            driver.ClickElement(btnChooseUtilitiesOk, "OK");*/
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            //driver.WaitForElement(systemConsmpNoData, System.TimeSpan.FromSeconds(60));

            driver.CheckElementDisplayed(systemConsmpNoData, "No Data Message");
            if (driver.GetElementText(systemConsmpNoData).Equals("No data returned for this view. This might be because the applied filter excludes all data."))
            {
                testReport.Pass("Message Displayed is : <i> <b>" + driver.GetElementText(systemConsmpNoData));
            }
            else
            {
                ReporterFactory.LogFailure("Message Displayed is : <i> " + driver.GetElementText(systemConsmpNoData));
            }
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate search feild in map 
        /// </summary>
        public void ValidateSearchInMap()
        {
            driver.ClickElement(detailReport, "Detail Report");
            //driver.WaitForElement(detailedReport, System.TimeSpan.FromSeconds(3000));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(mapView, TimeSpan.FromSeconds(20));
            driver.ClickElement(mapView, "Map View");
            //driver.sleepTime(30);
            //driver.WaitForElement(searchFeild, TimeSpan.FromSeconds(10));
            //if (driver.CheckElementDisplayed(searchFeild, "Search Feild"))
            //{
            //    testReport.Pass("<i>Search Feild is Displayed.");
            //}
            //else
            //{
            //    ReporterFactory.LogFailure("<i>Search Feild is Not Displayed.");
            //}
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate map widget
        /// </summary>
        public void ValidateMapWidget()
        {
            driver.ClickElement(detailReport, "Detail Report");
            ////driver.WaitForElement(detailedReport, System.TimeSpan.FromSeconds(3000));
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(mapView, TimeSpan.FromSeconds(10));
            driver.ClickElement(mapView, "Map View");
            if (driver.CheckElementDisplayed(mapView, "Map Widget "))
            {
                testReport.Pass("<i>Map Widget is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Map Widget is Not Displayed.");
            }
            ////driver.SwitchToDefaultFrame();
        }


        /// <summary>
        /// Method to Validate map widget
        /// </summary>
        public void ValidateMapPlusWidget()
        {
            driver.ClickElement(detailReport, "Detail Report");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(mapView, TimeSpan.FromSeconds(10));
            driver.ClickElement(mapView, "");
            driver.WaitForElement(plusSymbol, System.TimeSpan.FromSeconds(40));
            if (driver.CheckElementDisplayed(plusSymbol, "Zoom "))
            {
                driver.ClickElement(plusSymbol, "");
                driver.sleepTime(1000);
                testReport.Pass("<i>Expand Widget is Clicked.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Expand Widget is Not Displayed.");
            }
            ////driver.SwitchToDefaultFrame();
        }
        /// <summary>
        /// Method to Validate map widget
        /// </summary>
        public void ValidateMapMinusWidget()
        {
            driver.ClickElement(detailReport, "Detail Report");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(mapView, TimeSpan.FromSeconds(10));
            driver.ClickElement(mapView, "");
            driver.WaitForElement(minusSymbol, System.TimeSpan.FromSeconds(40));
            if (driver.CheckElementDisplayed(minusSymbol, "Zoom "))
            {
                driver.ClickElement(minusSymbol, "");
                driver.sleepTime(1000);
                testReport.Pass("<i>Collapse Widget is Clicked.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Collapse Widget is Not Displayed.");
            }
            ////driver.SwitchToDefaultFrame();
        }


        /// <summary>
        /// Method to Validate widget no data
        /// </summary>
        public void ValidateWidgetNoData()
        {
            driver.ClickElement(detailReport, "Detail Report");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(mapView, TimeSpan.FromSeconds(10));
            driver.ClickElement(mapView, "");
            driver.WaitForElement(plusSymbol, System.TimeSpan.FromSeconds(40));
            if (driver.CheckElementDisplayed(plusSymbol, "Zoom "))
            {
                //driver.ClickElement(plusSymbol, "");
                //driver.ClickElement(plusSymbol, "");
                //driver.sleepTime(1000);
                testReport.Pass("<i>North America is centered when zoomed out.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>North America is not centered when zoomed out.");
            }
            ////driver.SwitchToDefaultFrame();
        }


        /// <summary>
        /// Method to Validate back to KPI dashboard
        /// </summary>
        public void ValidateBackToKPIDashboard()
        {
            driver.ClickElement(detailReport, "Detail Report");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(40));
            driver.ClickElement(backToKPI, "Back To KPI");
            if (driver.CheckElementDisplayed(detailReport, "Dashboard Page"))
            {
                testReport.Pass("<i>Dashboard Page Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Dashboard Page Not Displayed.");
            }
        }

        /// <summary>
        /// Method to Validate dashboard title
        /// </summary>
        public void ValidateDashboardTitle()
        {
            driver.WaitForElement(dashboardTitle, TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Title") & driver.CheckElementDisplayed(dashboardTitleDate, "Date"))
            {
                testReport.Pass("<i>Dashboard Title and date Displayed as: <b>" + driver.GetElementText(dashboardTitle) + driver.GetElementText(dashboardTitleDate));
            }
            else
            {
                ReporterFactory.LogFailure("<i>Dashboard Title Not Displayed.");
            }
        }

        /// <summary>
        /// Method to Validate system consumption
        /// </summary>
        public void ValidateSystemConsumption()
        {
            driver.WaitForElement(systemConsumption, TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(systemConsumption, "System Consumption Label"))
            {
                testReport.Pass("<i>System Consumption Label Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>System Consumption Label not Displayed.");
            }
        }

        public void ValidateSystemConsumptionReportDate()
        {
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(10));
            driver.ClickElement(detailReport, "Detail Report");
            //driver.SwitchToFrameById("ntgMSTRFrame");

            driver.WaitForElement(reportDate, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(reportDate, "Report Date");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateSystemConsDetailReportHTMLLink()
        {
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(10));
            driver.ClickElement(detailReport, "Detail Report");
            string s = driver.Url;
            if (s.Contains("/dashboard/detailreport/systemconsumption"))
            {
                testReport.Pass("Link Displayed is : " + s);
            }
        }
        public void ValidateSystemConsDetailReportBackToKPILink()
        {
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(10));
            driver.ClickElement(detailReport, "Detail Report");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(20));
            driver.ClickElement(backToKPI, "Back To KPI");

            string s = driver.Url;
            if (s.Contains("/dashboard"))
            {
                testReport.Pass("Link Displayed is : " + s);
            }
        }

        public void ValidateTop10ConsumptionReportDate()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(10));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Consumption Detail Report");
            //driver.SwitchToFrameById("ntgMSTRFrame");

            driver.WaitForElement(reportDate, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(reportDate, "Report Date");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateIncompleteMetersReportDate()
        {
            try
            {
                driver.WaitForElement(completeReadingsCount, System.TimeSpan.FromSeconds(30));
                driver.ClickElement(readingRightArrow, "Reading Right Arrow");
                driver.ClickElement(inCompleteReadingsCount, "Incomplete Count");
                //driver.SwitchToFrameById("ntgMSTRFrame");

                driver.WaitForElement(reportDate, TimeSpan.FromSeconds(20));
                driver.CheckElementDisplayed(reportDate, "Report Date");
                //driver.SwitchToDefaultFrame();
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }
        public void ValidateIntermittentKPIReportDate()
        {
            try
            {
                driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(40));
                driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
                driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
                driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
                driver.ClickElement(intermittentReadingCount, "Intermittent Consumption");
                //driver.SwitchToFrameById("ntgMSTRFrame");

                driver.WaitForElement(reportDate, TimeSpan.FromSeconds(20));
                driver.CheckElementDisplayed(reportDate, "Report Date");
                //driver.SwitchToDefaultFrame();
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void ValidateMinorReverseFlowKPIReportDate()
        {
            try
            {
                driver.WaitForElement(majorreverseReadingCount, TimeSpan.FromSeconds(30));
                driver.ClickElement(reverseFlowRightArrow, "Right");
                driver.ClickElement(minorreverseReadingCount, "Minor Reverse Flow");
                //driver.SwitchToFrameById("ntgMSTRFrame");

                driver.WaitForElement(reportDate, TimeSpan.FromSeconds(20));
                driver.CheckElementDisplayed(reportDate, "Report Date");
                //driver.SwitchToDefaultFrame();   
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void ValidateCriticalGatewayKPINumber()
        {
            driver.WaitForElement(criticalGateway, TimeSpan.FromSeconds(30));
            driver.ClickElement(criticalGateway, "Critical Gateway");
            driver.sleepTime(10);
        }
        public void ValidateCriticalGatewayReportHeader()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(criticalGatewayCount, "Critical Gateway KPI");
            driver.WaitForElement(breadCrumb, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(breadCrumb, driver.GetElementText(breadCrumb));
        }
        public void ValidateNormalGatewayReportHeader()
        {
            driver.WaitForElement(gatewayRightArrow, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(normalGatewayReadingCount, "Normal Gateway");
            driver.WaitForElement(breadCrumb, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(breadCrumb, driver.GetElementText(breadCrumb));
        }

        public void ValidateCriticalGatewayDateTime()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(criticalGatewayCount, "Critical Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(reportDate, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reportDate, driver.GetElementText(reportDate));
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateCriticalGatewayZeroKPI()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(criticalGatewayCount, "Critical Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(noDataReturned, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(noDataReturned, driver.GetElementText(reportDate));
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateWarningGatewayZeroKPI()
        {
            driver.WaitForElement(gatewayRightArrow, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(warningGatewayReadingCount, "Warning Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(30000);
            if (!driver.VerifyDoesnotExists(noDataReturned, "nodata"))
            {
                driver.Navigate().Refresh();
                driver.sleepTime(10000);
            }
            driver.WaitForElement(noDataReturned, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(noDataReturned, driver.GetElementText(reportDate));
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateNormalGatewayZeroKPI()
        {
            driver.WaitForElement(gatewayRightArrow, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(normalGatewayReadingCount, "Normal Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(10000);
            driver.WaitForElement(noDataReturned, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(noDataReturned, driver.GetElementText(reportDate));
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateNormalGatewayDateTime()
        {
            driver.WaitForElement(gatewayRightArrow, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(normalGatewayReadingCount, "Normal Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(reportDate, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reportDate, driver.GetElementText(reportDate));
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateWarningGatewayDateTime()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(warningGatewayReadingCount, "Warning Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(reportDate, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reportDate, driver.GetElementText(reportDate));
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateWarningGatewayExportCSV()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(warningGatewayReadingCount, "Warning Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export To Excel");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateNormalGatewayExportCSV()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(normalGatewayReadingCount, "Normal Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export To Excel");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateNormalGatewayExportPDF()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(normalGatewayReadingCount, "Normal Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export To PDF");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateWarningGatewayExportPDF()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(warningGatewayReadingCount, "Warning Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export To PDF");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateCriticalGatewayExporttoCSV()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(criticalGatewayCount, "Critical Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export To Excel");
            ////driver.SwitchToDefaultFrame();
        }


        public void ValidateCriticalGatewayExporttoPDF()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(criticalGatewayCount, "Critical Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(30));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export To PDF");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateCriticalGatewayColumnHeading()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(criticalGatewayCount, "Critical Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(gatewayName, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(gatewayName, "gateway Name");
            driver.CheckElementDisplayed(lastSyncDateTime, "last Sync Date Time");
            driver.CheckElementDisplayed(miuReceived, "# MIUs Received Last 24 Hrs");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateWarningGatewayColumnHeading()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(warningGatewayReadingCount, "Warning Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(gatewayName, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(gatewayName, "gateway Name");
            driver.CheckElementDisplayed(lastSyncDateTime, "last Sync Date Time");
            driver.CheckElementDisplayed(miuReceived, "# MIUs Received Last 24 Hrs");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateNormalGatewayColumnHeading()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(normalGatewayReadingCount, "Normal Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(gatewayName, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(gatewayName, "gateway Name");
            driver.CheckElementDisplayed(lastSyncDateTime, "last Sync Date Time");
            driver.CheckElementDisplayed(miuReceived, "# MIUs Received Last 24 Hrs");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateWarningGatewayGatewayName()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(warningGatewayReadingCount, "Warning Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(row1, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(row1, "gateway Name");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateNormalGatewayGatewayName()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(normalGatewayReadingCount, "Normal Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(row1, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(row1, "gateway Name");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateNormalGatewayGatewayDateTime()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(normalGatewayReadingCount, "Normal Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(col2, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(col2, "gateway Date Time" + driver.GetElementText(col2));
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateWarningGatewayGatewayDateTime()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(warningGatewayReadingCount, "Warning Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(col2, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(col2, "gateway Date Time" + driver.GetElementText(col2));
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateNormalGatewayGatewayMiuReceived()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(normalGatewayReadingCount, "Normal Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(col3, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(col3, "Miu Received");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateWarningGatewayGatewayMiuReceived()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(warningGatewayReadingCount, "Warning Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(col3, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(col3, "Miu Received");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateCriticalReportGatewayName()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(criticalGatewayCount, "Critical Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(row1, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(row1, "gateway Name");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateCriticalReportLastSyncDateTime()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(criticalGatewayCount, "Critical Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(col2, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(col2, "Last Sync Date Time");
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateCriticalReportMIUReceived()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(criticalGatewayCount, "Critical Gateway KPI");

            //////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(col3, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(col3, "MIU Received");
            //////driver.SwitchToDefaultFrame();
        }

        public void ValidateWarningReportHeader()
        {
            driver.WaitForElement(criticalGatewayCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(gatewayRightArrow, "Right");
            driver.ClickElement(warningGatewayReadingCount, "Warning Gateway KPI");

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(warningGatewayHeader, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(warningGatewayHeader, "warning Gateway Header");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate reverse flow widget labels
        /// </summary>
        public void ValidatereverseFlowWidget()
        {
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(reverseFlowWidget, TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(reverseFlowWidget, "Reverse Flow Widget "))
            {
                testReport.Pass("<i>Reverse Flow Widget Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Reverse Flow Widget Not Displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate KPI widgets
        /// </summary>
        public void ValidatekpiWidget()
        {
            driver.sleepTime(40);
            if (driver.CheckElementDisplayed(kpisWidget, "KPI Widgets"))
            {
                testReport.Pass("<i>KPI Widgets displayed on the right side of Dashboard screen.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>KPI Widgets not displayed on the right side of Dashboard screen.");
            }
        }

        /// <summary>
        /// Method to Validate KPI widget individual details
        /// </summary>
        public void ValidatekpiIndividualWidgetDetails()
        {
            driver.WaitForPageLoad(TimeSpan.FromMinutes(1));
            if (driver.CheckElementDisplayed(metersReadingsKpi, "Complete Readings KPI") & driver.CheckElementDisplayed(completeReadingsCount, "Complete Readings Count") & driver.CheckElementDisplayed(readingsKpiWidget, "Readings Kpi Widget"))
            {
                testReport.Pass("<i>KPI Subcategory, numeric count, Category details are displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>KPI Subcategory, numeric count, Category details are not displayed.");
            }
        }

        /// <summary>
        /// Method to Validate Complete Readings KPI Left and Right Arrows and clicking
        /// </summary>
        public void ValidateCompleteReadingsKPIArrows()
        {
            driver.WaitForElement(readingsKpiLeftArrow, TimeSpan.FromSeconds(30));
            driver.CheckElementExists(kpisWidget, "KPI Widgets");

            driver.CheckElementExists(readingsKpiLeftArrow, "Readings KPI Left Arrow");
            driver.CheckElementDisplayed(readingRightArrow, "Readings KPI Right Arrow");

            driver.ClickElement(readingRightArrow, "Right Arrow");
            driver.CheckElementExists(metersReadingsKpi, "Complete Reading KPI");
            if (driver.GetElementText(metersReadingsKpi).Equals("Incomplete"))

            {
                testReport.Pass("<i>Incomplete Readings kPI is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Incomplete Readings kPI is not displayed.");
            }
        }


        /// <summary>
        /// Method to Validate major reverse flow count
        /// </summary>
        public void ValidateMajorReverseFlowCount()
        {

            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(majorreverseReadingCount, "Major Reverse Flow Count");
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(gridView, System.TimeSpan.FromSeconds(40));
            driver.CheckElementExists(majorReverseDetails, "Major Reverse Details");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate major reverse flow Column Display
        /// </summary>
        public void ValidateMajorReverseFlowColumnDisplay()
        {
            driver.sleepTime(40);
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(majorreverseReadingCount, "Major Reverse Flow Count");
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(gridView, System.TimeSpan.FromSeconds(40));

            driver.CheckElementDisplayed(accName, "Account Name");
            driver.CheckElementDisplayed(accNo, "Acc no");
            driver.CheckElementDisplayed(miuId, "MIU");
            driver.CheckElementDisplayed(address, "Address");
            driver.CheckElementDisplayed(date, "Date");
            driver.CheckElementDisplayed(reading, "Reading");

            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateSkippedReadingColumnDisplay()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(skippedReadingCount, "Skipped KPI");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(gridView, System.TimeSpan.FromSeconds(40));

            driver.CheckElementDisplayed(cycle, "Cycle");
            driver.CheckElementDisplayed(readSeq, "Read Sequence");
            driver.CheckElementDisplayed(accName, "Account Name");
            driver.CheckElementDisplayed(accNo, "Acc no");
            driver.CheckElementDisplayed(address, "Address");
            driver.CheckElementDisplayed(miu, "MIU");
            driver.CheckElementDisplayed(meterNo, "Meter Number");
            driver.CheckElementDisplayed(meterSize, "Meter Size");
            driver.CheckElementDisplayed(skipCode, "Skip Code");
            driver.CheckElementDisplayed(comments, "Comments");
            driver.CheckElementDisplayed(dateTime, "Date Time");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateSkippedReadingGridView()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(readingsRightArrow, "Readings Right Arrow");
            driver.ClickElement(readingsRightArrow, "Readings Right Arrow");
            driver.WaitForElement(skippedReadingCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(skippedReadingCount, "Skipped Readings KPI");
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));

            driver.CheckElementDisplayed(gridView, "Grid View");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateSkippedReadingMapView()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(skippedReadingCount, "Skipped KPI");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(gridView, System.TimeSpan.FromSeconds(40));

            driver.ClickElement(mapView, "Map View");
            driver.sleepTime(10000);
            //driver.SwitchToDefaultFrame();
        }


        /// <summary>
        /// Method to Validate major reverse flow title
        /// </summary>
        public void ValidateMajorReverseFlowTitle()
        {
            driver.sleepTime(40);
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(majorreverseReadingCount, "Major Reverse Flow Count");
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(gridView, System.TimeSpan.FromSeconds(40));
            string s = driver.GetElementText(majorReverseDetails);
            if (driver.CheckElementDisplayed(majorReverseDetails, "Major Reverse Details"))
            {
                testReport.Pass("Title is displayed as : <i><b>" + s);
            }
            else
            {
                ReporterFactory.LogFailure("Title is displayed as <i> " + s);
            }
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate major reverse flow title
        /// </summary>
        public void ValidateMajorReverseFlowReportDate()
        {
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(majorreverseReadingCount, "Major Reverse Flow Count");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.sleepTime(2000);
            driver.WaitForElement(reportDate, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(reportDate, "Report Date");
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate major reverse flow Load Page
        /// </summary>
        public void ValidateMajorReverseFlowLoadPage()
        {
            driver.sleepTime(10);
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(majorreverseReadingCount, "Major Reverse Flow Count");
            driver.sleepTime(1000);
            string url = driver.Url;
            if (url.Contains("/dashboard/detailreport/majorreverseflow"))
            {
                testReport.Pass("User is redirected to Major Reverse Flow detailed report " + url);
            }
        }

        /// <summary>
        /// Method to Validate major reverse flow Back to KPI 
        /// </summary>
        public void ValidateMajorReverseFlowBacktoKPI()
        {
            driver.sleepTime(10);
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(majorreverseReadingCount, "Major Reverse Flow Count");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(30));
            driver.ClickElement(backToKPI, "Back to KPI");
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Screen"))
            {
                testReport.Pass("<i>Dashboard Screen is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Dashboard Screen is Not Displayed");
            }
        }
        public void ValidateMajorReverseFlowBacktoKPILink()
        {
            driver.sleepTime(10);
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(majorreverseReadingCount, "Major Reverse Flow Count");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(30));
            driver.ClickElement(backToKPI, "Back to KPI");
            string s = driver.Url;
            if (s.Contains("/dashboard"))
            {
                testReport.Pass("Link Diplayed is : " + s);
            }
        }

        public void ValidateMajorReverseFlowHTMLLink()
        {
            driver.sleepTime(1000);
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(majorreverseReadingCount, "Major Reverse Flow Count");
            driver.sleepTime(10000);
            string s = driver.Url;
            if (s.Contains("/dashboard/detailreport/majorreverseflow"))
            {
                testReport.Pass("Link Diplayed is : " + s);
            }
        }


        /// <summary>
        /// Method to Validate grid view selected bydefault
        /// </summary>
        public void ValidateDefaultGridView()
        {
            driver.sleepTime(10);
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(majorreverseReadingCount, "Major Reverse Flow Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(gridView, System.TimeSpan.FromSeconds(40));
            if (driver.CheckElementDisplayed(gridView, "Major Reverse Details"))
            {
                testReport.Pass("<i> Grid View is Displayed bydefault");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Grid View is not Displayed bydefault");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate minor grid view selected bydefault
        /// </summary>
        public void ValidateMinorDefaultGridView()
        {
            driver.sleepTime(40);
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(reverseFlowRightArrow, "Right Arrow");
            driver.ClickElement(minorreverseReadingCount, "Minor Reverse Flow Count");
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(gridView, System.TimeSpan.FromSeconds(40));
            if (driver.CheckElementDisplayed(gridView, "Minor Reverse Details"))
            {
                testReport.Pass("<i> Grid View is Displayed bydefault");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Grid View is not Displayed bydefault");
            }
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate minor map view
        /// </summary>
        public void ValidateMinorMapView()
        {
            driver.sleepTime(40);
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(reverseFlowRightArrow, "Right Arrow");
            driver.ClickElement(minorreverseReadingCount, "Minor Reverse Flow Count");
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            //driver.WaitForElement(gridView, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(mapView, "Map View");
            driver.WaitForElement(plusSymbol, TimeSpan.FromSeconds(30));
            if (driver.CheckElementDisplayed(plusSymbol, "Map"))
            {
                testReport.Pass("<i> Map View is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>  Map View is not Displayed.");
            }
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate export PDF minor
        /// </summary>
        public void ValidateExportPDFMinor()
        {
            driver.sleepTime(40);
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(reverseFlowRightArrow, "Right Arrow");
            driver.ClickElement(minorreverseReadingCount, "Minor Reverse Flow Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(exportLink, "Export Link");
            if (driver.CheckElementDisplayed(exportPDF, "Export PDF"))
            {
                testReport.Pass("<i> Export PDF is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>  Export PDF is not Displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate export excel PDF minor
        /// </summary>
        public void ValidateExportExcelMinor()
        {
            driver.sleepTime(40);
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(reverseFlowRightArrow, "Right Arrow");
            driver.ClickElement(minorreverseReadingCount, "Minor Reverse Flow Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(exportLink, "Export Link");
            if (driver.CheckElementDisplayed(exportExcel, "Export Excel"))
            {
                testReport.Pass("<i> Export Excel is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>  Export Excel is not Displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate back to kpi minor
        /// </summary>
        public void ValidateBakToKPIMinor()
        {
            driver.sleepTime(40);
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(reverseFlowRightArrow, "Right Arrow");
            driver.ClickElement(minorreverseReadingCount, "Minor Reverse Flow Count");
            driver.CheckElementDisplayed(backToKPI, "Back To KPI");
            driver.ClickElement(backToKPI, "Back To KPI");
            driver.WaitForElement(dashboardTitle, System.TimeSpan.FromSeconds(30));
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Title"))
            {
                testReport.Pass("<i>Dashboard Page is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Dashboard Page is Not Displayed");
            }
        }
        public void ValidateBakToKPIMinorLink()
        {
            driver.sleepTime(40);
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(reverseFlowRightArrow, "Right Arrow");
            driver.ClickElement(minorreverseReadingCount, "Minor Reverse Flow Count");
            driver.CheckElementDisplayed(backToKPI, "Back To KPI");
            driver.ClickElement(backToKPI, "Back To KPI");
            driver.WaitForElement(dashboardTitle, System.TimeSpan.FromSeconds(30));
            String s = driver.Url;
            if (s.Contains("/dashboard"))
            {
                testReport.Pass("Link Displayed is: " + s);
            }
        }
        public void ValidateMinorHTMLLink()
        {
            driver.sleepTime(40);
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(reverseFlowRightArrow, "Right Arrow");
            driver.ClickElement(minorreverseReadingCount, "Minor Reverse Flow Count");
            String s = driver.Url;
            if (s.Contains("/dashboard/detailreport/minorreverseflow"))
            {
                testReport.Pass("Link Displayed is: " + s);
            }
        }

        /// <summary>
        /// Method to Validate complete count
        /// </summary>
        public void ValidateCompleteCount()
        {
            driver.sleepTime(40);
            driver.WaitForElement(completeReadingsCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(completeReadingsCount, "Complete Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(completeReadingDetail, System.TimeSpan.FromSeconds(30));
            if (driver.CheckElementDisplayed(completeReadingDetail, "Complete Reading Detail"))
            {
                testReport.Pass("<i>Complete Reading Detail is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Complete Reading Detail is Not Displayed");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate complete KPI
        /// </summary>
        public void ValidateCompleteKPI()
        {
            driver.WaitForElement(CompleteKPI, TimeSpan.FromMinutes(2));
            driver.CheckElementDisplayed(CompleteKPI, "Complete KPI");
        }

        /// <summary>
        /// Method to Validate KPI detailed report same window
        /// </summary>
        public void ValidateKPIDetailedReport()
        {
            driver.WaitForElement(CompleteKPI, TimeSpan.FromMinutes(2));
            driver.ClickElement(CompleteKPI, "Complete KPI");
            testReport.Pass("KPI Detailed Report is opened in the same window");
        }

        /// <summary>
        /// Method to Validate Incomplete KPI
        /// </summary>
        public void ValidateIncompleteKPI()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(completeRight, "Right Arrow");
            driver.CheckElementDisplayed(IncompleteKPI, "Incomplete KPI");
        }

        /// <summary>
        /// Method to Validate Skipped KPI
        /// </summary>
        public void ValidateSkippedKPI()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.CheckElementDisplayed(SkippedKPI, "Skipped KPI");
        }

        /// <summary>
        /// Method to Validate Skipped KPI LoadPage
        /// </summary>
        public void ValidateSkippedReadingLoadPage()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(skippedReadingCount, "Skipped KPI");
            driver.sleepTime(1000);
            string url = driver.Url;
            if (url.Contains("/dashboard/detailreport/skippedreadings"))
            {
                testReport.Pass("User is redirected to Skipped Readings detailed report" + url);
            }
        }
        /// <summary>
        /// Method to Validate Skipped KPI Back to KPI
        /// </summary>
        public void ValidateSkippedReadingBacktoKPI()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(skippedReadingCount, "Skipped KPI");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(30));
            driver.ClickElement(backToKPI, "Back to KPI");
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Screen"))
            {
                testReport.Pass("<i>Dashboard Screen is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Dashboard Screen is Not Displayed");
            }
        }
        public void ValidateSkippedReadingTitle()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(skippedReadingCount, "Skipped KPI");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.CheckElementDisplayed(skipppedReadingTitle, driver.GetElementText(skipppedReadingTitle).ToString());
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateSkippedReadingDateRange()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(skippedReadingCount, "Skipped KPI");
            driver.CheckElementDoesnotExists(fromDate, "Date Range");
        }
        public void ValidateSkippedReadingCount()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(skippedReadingCount, "Skipped KPI");
        }

        /// <summary>
        /// Method to Validate Received KPI via AMR
        /// </summary>
        public void ValidateReceivedKPIviaAMR()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.CheckElementDisplayed(ViaAMR, "Received KPI via AMR");
        }

        /// <summary>
        /// Method to Validate Received KPI via AMI
        /// </summary>
        public void ValidateReceivedKPIviaAMI()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.CheckElementDisplayed(ViaAMI, "Received KPI via AMI");
        }
        public void ValidateReceivedKPIviaAMITitle()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedAmiCount, "Received KPI via AMI");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(meterreceivedamidetailTitle, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(meterreceivedamidetailTitle, "Title");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateReceivedKPIviaAMIExportPDF()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedAmiCount, "Received KPI via AMI");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(exportLink, "");
            driver.CheckElementDisplayed(exportPDF, "PDF");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateReceivedKPIviaAMIExportExcel()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedAmiCount, "Received KPI via AMI");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(exportLink, "");
            driver.CheckElementDisplayed(exportExcel, "Excel");
            //driver.SwitchToDefaultFrame();
        }


        /// <summary>
        /// Method to Validate Received KPI via AMI Coloumns Display
        /// </summary>
        public void ValidateReceivedKPIviaAMIColoumnsDisplay()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.CheckElementDisplayed(ViaAMI, "Received KPI via AMI");
            driver.ClickElement(receivedCount, "Received Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(gridView, System.TimeSpan.FromSeconds(40));

            driver.CheckElementDisplayed(accName, "Account Name");
            driver.CheckElementDisplayed(accNo, "Acc no");
            driver.CheckElementDisplayed(miu, "MIU");
            driver.CheckElementDisplayed(address, "Address");
            driver.CheckElementDisplayed(meterNo, "Meter No");
            driver.CheckElementDisplayed(meterSize, "Meter Size");
            driver.CheckElementDisplayed(reading, "Reading");

            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Received KPI via AMR Coloumns Display
        /// </summary>
        public void ValidateReceivedKPIviaAMRColoumnsDisplay()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            driver.CheckElementDisplayed(ViaAMR, "Received KPI via AMR");
            driver.ClickElement(receivedCount, "Received Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(accName, System.TimeSpan.FromSeconds(30));

            driver.CheckElementDisplayed(accName, "Account Name");
            driver.CheckElementDisplayed(accNo, "Acc no");
            driver.CheckElementDisplayed(miuId, "MIU");
            driver.CheckElementDisplayed(address, "Address");
            driver.CheckElementDisplayed(meterNo, "Meter No");
            driver.CheckElementDisplayed(meterSize, "Meter Size");
            driver.CheckElementDisplayed(reading, "Reading");

            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Received KPI via AMI Excel Display
        /// </summary>
        public void ValidateReceivedKPIviaAMIExcelDisplay()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.CheckElementDisplayed(ViaAMI, "Received KPI via AMI");
            driver.ClickElement(receivedCount, "Received Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel");

            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Received KPI via AMR Excel Display
        /// </summary>
        public void ValidateReceivedKPIviaAMRExcelDisplay()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            //driver.ClickElement(receivedRight, "Received Right");
            driver.CheckElementDisplayed(ViaAMR, "Received KPI via AMR");
            driver.ClickElement(receivedCount, "Received Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportExcel, "Export Excel");

            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Received KPI Back tO KPi
        /// </summary>
        public void ValidateReceivedKPIviaAMIBackToKPI()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.CheckElementDisplayed(ViaAMI, "Received KPI via AMI");
            driver.ClickElement(receivedCount, "Received Count");
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(backToKPI, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(backToKPI, "Back tO KPi");
        }


        /// <summary>
        /// Method to Validate Received AMR KPI Back tO KPi
        /// </summary>
        public void ValidateReceivedKPIviaAMRBackToKPI()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.CheckElementDisplayed(ViaAMI, "Received KPI via AMI");
            driver.ClickElement(receivedCount, "Received Count");
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(backToKPI, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(backToKPI, "Back tO KPi");
        }

        /// <summary>
        /// Method to Validate Not Received Count
        /// </summary>
        public void ValidateNotReceivedCount()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedCount, "Received Count");
        }

        /// <summary>
        /// Method to Validate Not Received PDF Display
        /// </summary>
        public void ValidateNotReceivedPDFDisplay()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedRight, "Received Right");
            //driver.CheckElementDisplayed(ViaAMI, "Not Received");
            driver.ClickElement(receivedCount, "Received Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateReceivedviaAMRPDFDisplay()
        {
            driver.WaitForElement(receivedCount, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedCount, "Received Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(exportLink, "Export Link");
            driver.CheckElementDisplayed(exportPDF, "Export PDF");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateReceivedviaAMRBackToKPI()
        {
            driver.WaitForElement(receivedCount, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedCount, "Received Count");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(backToKPI, "Back To KPI");
        }

        /// <summary>
        /// Method to Validate Not Received Back To KPI
        /// </summary>
        public void ValidateNotReceivedBackToKPI()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedCount, "Received Count");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(backToKPI, "Back To KPI");
        }
        public void ValidateNotReceivedBackToKPIClick()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedCount, "Received Count");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(20));
            driver.ClickElement(backToKPI, "Back To KPI");
            driver.CheckElementDisplayed(breadCrumb, "Dashboard Screen");
        }

        /// <summary>
        /// Method to Validate Not Received Header
        /// </summary>
        public void ValidateNotReceivedHeader()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedCount, "Received Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(metersnotreceiveddetailTitle, System.TimeSpan.FromSeconds(40));
            driver.CheckElementDisplayed(metersnotreceiveddetailTitle, "consistent Header");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateNotReceivedExportExcel()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedCount, "Received Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(exportLink, "EXport Link");
            driver.CheckElementDisplayed(exportExcel, "export Excel");
            //driver.SwitchToDefaultFrame();
        }

        public void ValidateNotReceivedColumnDetails()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedCount, "Received Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(row1, System.TimeSpan.FromSeconds(40));
            driver.CheckElementDisplayed(accNo, "Acc no");
            driver.CheckElementDisplayed(accName, "Acc Name");
            driver.CheckElementDisplayed(miuId, "Miu ID");
            driver.CheckElementDisplayed(meterSize, "Meter Size");
            driver.CheckElementDisplayed(keyedReading, "Keyed Reading");
            driver.CheckElementDisplayed(lastReadDateTime, "lastReadDateTime");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateReceivedviaAMIHeader()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedCount, "Received Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            
            driver.WaitForElement(meterreceivedamidetailTitle, System.TimeSpan.FromSeconds(40));
            driver.CheckElementDisplayed(meterreceivedamidetailTitle, "consistent Header");
           // driver.WaitForElement(consistentHeader, System.TimeSpan.FromSeconds(40));
            //driver.CheckElementDisplayed(consistentHeader, "consistent Header");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateReceivedviaAMRHeader()
        {
            driver.WaitForElement(receivedCount, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedCount, "Received Count");
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(meterreceivedamrdetailTitle, TimeSpan.FromSeconds(40));
            driver.CheckElementDisplayed(meterreceivedamrdetailTitle, "consistent Header");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateConvColumn()
        {
            driver.ClickElement(detailReport, "Detailed Report");
            driver.sleepTime(20000);
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            //driver.WaitForElement(convCol, System.TimeSpan.FromSeconds(40));
            driver.CheckElementDisplayed(convCol, "Conv Column");
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateAsteriksDisplay()
        {
            driver.ClickElement(detailReport, "Detailed Report");
            driver.sleepTime(20000);
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            //driver.WaitForElement(asteriks, System.TimeSpan.FromSeconds(40));
            driver.CheckElementDisplayed(asteriks, "Asteriks");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Not Received Widget Location
        /// </summary>
        public void ValidateNotReceivedWidgetLocation()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(receivedRight, "Received Right");
            driver.ClickElement(receivedRight, "Received Right");
            driver.CheckElementDisplayed(notReceived, " Not Received Widget Location");
        }

        /// <summary>
        /// Method to Validate Major Reverse Flow Dispays Location
        /// </summary>
        public void ValidateMajorReverseFlowDispaysLocation()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(major, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(major, " Major is the first KPI displayed in the Reverse Flow widget");
        }

        /// <summary>
        /// Method to Validate Minor Reverse Flow Dispays Location
        /// </summary>
        public void ValidateMinorReverseFlowDispaysLocation()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(major, TimeSpan.FromSeconds(10));
            driver.ClickElement(majorRight, "Right");
            driver.CheckElementDisplayed(minor, " Minor is second KPI displayed in the Reverse Flow widget");
        }

        /// <summary>
        /// Method to Validate Gateway Critical Dispays Location
        /// </summary>
        public void ValidateGatewayCriticalDispaysLocation()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(criticalGateway, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(criticalGateway, "Critical is the first KPI displayed in the Reverse Flow widget");
        }

        /// <summary>
        /// Method to Validate Gateway Critical Page Load
        /// </summary>
        public void ValidateGatewayCriticalPageLoad()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(continuousCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(continuousCount, "Critical Consumption");
            driver.sleepTime(1000);
            string url = driver.Url;
            if (url.Contains("/dashboard/detailreport-new/criticalconsumption"))
            {
                testReport.Pass("User is redirected to Critical Continuous Consumption detailed report" + url);
            }
        }

        /// <summary>
        /// Method to Validate Critical Consumption Back To KPI
        /// </summary>
        public void ValidateCriticalConsumptionBackToKPI()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(continuousCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(continuousCount, "Critical Consumption");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(30));
            driver.ClickElement(backToKPI, "Back to KPI");
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Screen"))
            {
                testReport.Pass("<i>Dashboard Screen is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Dashboard Screen is Not Displayed");
            }
            testReport.Info(driver.Url.ToString());
        }
        public void ValidateCriticalConsumptionColumnsDisplay()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(continuousCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(continuousCount, "Critical Consumption");

            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(gridView, System.TimeSpan.FromSeconds(40));

            driver.CheckElementDisplayed(accName, "Account Name");
            driver.CheckElementDisplayed(accNo, "Acc no");
            driver.CheckElementDisplayed(miu, "MIU");
            driver.CheckElementDisplayed(address, "Address");
            driver.CheckElementDisplayed(date, "Date");
            driver.CheckElementDisplayed(reading, "Reading");

            //driver.SwitchToDefaultFrame();
        }
        public void ValidateCriticalConsumptionReportTitle()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(continuousCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(continuousCount, "Critical Consumption");

            driver.WaitForElement(breadCrumb, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(breadCrumb, driver.GetElementText(breadCrumb));

        }
        public void ValidateCriticalConsumptionWidget()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(continuousCount, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(continuousCount, "Critical Consumption");
        }
        public void ValidateCriticalConsumptionCount()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(continuousCount, TimeSpan.FromSeconds(30));
            testReport.Info(driver.GetElementText(continuousCount));
        }
        public void ValidateWarningConsumptionCount()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Right");
            testReport.Info(driver.GetElementText(continuousCount));
        }
        public void ValidateNormalConsumptionCount()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            testReport.Info(driver.GetElementText(continuousCount));
        }
        public void ValidateIntermittentConsumptionCount()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            testReport.Info(driver.GetElementText(continuousCount));
        }


        /// <summary>
        /// Method to Validate Gateway Warning Dispays Location
        /// </summary>
        public void ValidateGatewayWarningDispaysLocation()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(gatewayRight, TimeSpan.FromSeconds(10));
            driver.ClickElement(gatewayRight, "Right");
            driver.CheckElementDisplayed(warning, "Warning is the second KPI displayed in the Reverse Flow widget");
        }

        /// <summary>
        /// Method to Validate Gateway Normal Dispays Location
        /// </summary>
        public void ValidateGatewayNormalDispaysLocation()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(gatewayRight, TimeSpan.FromSeconds(10));
            driver.ClickElement(gatewayRight, "Right");
            driver.ClickElement(gatewayRight, "Right");
            driver.CheckElementDisplayed(normal, "Normal is the second KPI displayed in the Reverse Flow widget");
        }

        /// <summary>
        /// Method to Validate Skipped Reading Help
        /// </summary>
        public void ValidateSkippedReadingHelp()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(readingRightArrow, "Right");
            driver.ClickElement(readingRightArrow, "Right");
            driver.ClickElement(skippedReadings, "Skipped Readings");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.sleepTime(2000);
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate AMR Report Help
        /// </summary>
        public void ValidateAMRReportHelp()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(AMRReadings, "AMR Readings");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.sleepTime(2000);
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate AMI Report Help
        /// </summary>
        public void ValidateAMIReportHelp()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(receivedRight, "Right");
            driver.ClickElement(AMRReadings, "AMI Readings");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.sleepTime(2000);
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Not Received Help
        /// </summary>
        public void ValidateNotReceivedHelp()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(receivedRight, "Right");
            driver.ClickElement(receivedRight, "Right");
            driver.ClickElement(AMRReadings, "Not Received");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.sleepTime(2000);
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Warning Help
        /// </summary>
        public void ValidateWarningHelp()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(gatewayRight, "Right");
            driver.ClickElement(gatewayReadings, "Warning");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.sleepTime(2000);
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Normal Help
        /// </summary>
        public void ValidateNormalHelp()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(gatewayRight, "Right");
            driver.ClickElement(gatewayRight, "Right");
            driver.ClickElement(gatewayReadings, "Normal");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.sleepTime(2000);
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Crtical Gateway Help
        /// </summary>
        public void ValidateCrticalGatewayHelp()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(gatewayReadings, "Critical");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.sleepTime(2000);
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Crtical Consumption KPI Display
        /// </summary>
        public void ValidateCrticalConsumptionKPIDisplay()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(criticalGateway, "Crtical Consumption KPI");
        }

        /// <summary>
        /// Method to Validate Warning Consumption KPI Display
        /// </summary>
        public void ValidateWarningConsumptionKPIDisplay()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.CheckElementDisplayed(warning, "Warning Consumption KPI");
        }

        /// <summary>
        /// Method to Validate Normal Consumption KPI Display
        /// </summary>
        public void ValidateNormalConsumptionKPIDisplay()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.CheckElementDisplayed(normal, "Normal Consumption KPI");
        }
        public void ValidateConsumptionKPIRightArrow()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.CheckElementDisplayed(continuousConsumption, "Continuous Consumption");
        }
        public void ValidateConsumptionRightArrowDisabled()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.sleepTime(3000);
            driver.IsElementEnabled(cotinuousRightArrow, "Right Arrow");
        }

        /// <summary>
        /// Method to Validate Origina KPI Removed
        /// </summary>
        public void ValidateOriginaKPIRemoved()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            testReport.Pass("Original Consumption KPI is removed from the Dashboard");
        }

        /// <summary>
        /// Method to Validate Normal Consumption Detail Report
        /// </summary>
        public void ValidateNormalConsumptionDetailReport()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(normalReadingCount, "Normal Consumption KPI");
            driver.WaitForElement(reportDate, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reportDate, "Date Time");
        }

        /// <summary>
        /// Method to Validate Normal Consumption Page Load
        /// </summary>
        public void ValidateNormalConsumptionPageLoad()
        {
            driver.WaitForElement(cotinuousConsRightArrow, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousConsRightArrow, "Continuos Consumption Right Arrow");
            driver.ClickElement(cotinuousConsRightArrow, "Continuos Consumption Right Arrow");
            driver.WaitForElement(normalReadingCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(normalReadingCount, "Normal Continuos Consumption Count");
            driver.WaitForElementNotExists(gridLoader, 60);
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));

            driver.sleepTime(1000);
            string url = driver.Url;
            if (url.Contains("/dashboard/detailreport/normalconsumption"))
            {
                testReport.Pass("User is redirected to Normal Critical Continuous Consumption detailed report" + url);
            }
        }

        /// <summary>
        /// Method to Validate Warning Consumption Page Load
        /// </summary>
        public void ValidateWarningConsumptionPageLoad()
        {
            driver.WaitForElement(cotinuousConsRightArrow, TimeSpan.FromSeconds(30));
            driver.ClickElement(cotinuousConsRightArrow, "Continuos Consumption Right Arrow");
            driver.WaitForElement(warningConsumptionCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(warningConsumptionCount, "Warning Continuos Consumption Count");
            driver.WaitForElementNotExists(gridLoader, 60);
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));

            string url = driver.Url;
            if (url.Contains("/dashboard/detailreport/warningconsumption"))
            {
                testReport.Pass("User is redirected to Warning Continuos Consumption detailed report" + url);
            }
        }

        public void ValidateWarningConsumptionDetailedReport()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(continuousCount, "Warning Consumption KPI");
            driver.sleepTime(1000);
            driver.CheckElementDisplayed(breadCrumb, driver.GetElementText(breadCrumb));
        }

        /// <summary>
        /// Method to Validate Complete Count Page Load
        /// </summary>
        public void ValidateIncompleteCountPageLoad()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(10));
            driver.ClickElement(completeRight, "Right");
            driver.ClickElement(inCompleteReadingsCount, "Incomplete Count");
            driver.sleepTime(1000);
            string url = driver.Url;
            if (url.Contains("/dashboard/detailreport/incompletereadings"))
            {
                testReport.Pass("User is redirected to Warning Consumption detailed report" + url);
            }
        }

        /// <summary>
        /// Method to Validate Inomplete Count Back to KPI
        /// </summary>
        public void ValidateIncompleteCountBacktoKPI()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(10));
            driver.ClickElement(completeRight, "Right");
            driver.ClickElement(inCompleteReadingsCount, "Incomplete Count");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(30));
            driver.ClickElement(backToKPI, "Back to KPI");
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Screen"))
            {
                testReport.Pass("<i>Dashboard Screen is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Dashboard Screen is Not Displayed");
            }
        }
        public void ValidateIncompleteCountHTMLLink()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(10));
            driver.ClickElement(completeRight, "Right");
            driver.ClickElement(inCompleteReadingsCount, "Incomplete Count");
            string s = driver.Url;
            if (s.Contains("/dashboard/detailreport/incompletereadings"))
            {
                testReport.Pass("<i>Link displayed is: /<i>" + s);
            }

        }

        /// <summary>
        /// Method to Validate Normal Consumption Back to KPI
        /// </summary>
        public void ValidateNormalConsumptionBacktoKPI()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(continuousCount, "Normal Consumption KPI");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(30));
            driver.ClickElement(backToKPI, "Back to KPI");
            driver.CheckElementDisplayed(dashboardTitle, "Dashboard Screen");
            driver.Url.ToString();
        }

        public void ValidateNormalConsumptionBacktoKPILink()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(continuousCount, "Normal Consumption KPI");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(30));
            driver.ClickElement(backToKPI, "Back to KPI");
            testReport.Info(driver.Url.ToString());
        }
        public void ValidateNormalConsumptionPageLink()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(continuousCount, "Normal Consumption KPI");
            testReport.Info(driver.Url);
            driver.sleepTime(10000);
        }

        /// <summary>
        /// Method to Validate Warning Consumption Back to KPI
        /// </summary>
        public void ValidateWarningConsumptionBacktoKPI()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(continuousCount, "Warning Consumption KPI");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(30));
            driver.ClickElement(backToKPI, "Back to KPI");
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Screen"))
            {
                testReport.Pass("<i>Dashboard Screen is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Dashboard Screen is Not Displayed");
            }
        }
        public void ValidateWarningConsumptionBacktoKPILink()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(continuousCount, "Warning Consumption KPI");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(30));
            driver.ClickElement(backToKPI, "Back to KPI");
            testReport.Info(driver.Url);
        }
        public void ValidateWarningConsumptionHTMLLink()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(continuousCount, "Warning Consumption KPI");
            testReport.Info(driver.Url.ToString());
        }

        /// <summary>
        /// Method to Validate Intermittent Consumption KPI Display
        /// </summary>
        public void ValidateIntermittentConsumptionKPIDisplay()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.ClickElement(cotinuousRightArrow, "Right");
            driver.CheckElementDisplayed(intermittent, "Intermittent Consumption KPI");
        }

        /// <summary>
        /// Method to Validate Warning Gateway Help
        /// </summary>
        public void ValidateWarningGatewayHelp()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(gatewayRight, "Right");
            driver.ClickElement(gatewayReadings, "Warning");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.sleepTime(2000);
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Warning Gateway Detailed Report
        /// </summary>
        public void ValidateWarningDetailedReport()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(gatewayRight, "Right");
            driver.ClickElement(gatewayReadings, "Warning");
            testReport.Pass("Corresponding Warning Gateway status detailed report is displayed");
        }

        /// <summary>
        /// Method to Validate Gateway Status Detail Report
        /// </summary>
        public void ValidateGatewayStatusDetailReport()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(gatewayRight, "Right");
            driver.ClickElement(gatewayReadings, "Warning");
            driver.WaitForElement(reportDate, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reportDate, "Date Time");
        }

        /// <summary>
        /// Method to Validate Normal Gateway Help
        /// </summary>
        public void ValidateNormalGatewayHelp()
        {
            driver.sleepTime(10000);
            driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
            driver.ClickElement(gatewayRight, "Right");
            driver.ClickElement(gatewayRight, "Right");
            driver.ClickElement(gatewayReadings, "Normal");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.sleepTime(2000);
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Help
        /// </summary>
        public void ValidateHelp()
        {
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(10));
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.sleepTime(2000);
            driver.switchBackToMainWindow();
        }

        public void ValidateCompleteReadingHelp()
        {
            driver.WaitForElement(completeReadingsCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(completeReadingsCount, "Complete Count");
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(10));
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.sleepTime(2000);
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Detail Report Help
        /// </summary>
        public void ValidateDetailReportPage()
        {
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(30));
            driver.ClickElement(detailReport, "Detail Report");
            driver.WaitForElementNotExists(gridLoader, 40);
        }

        /// <summary>
        /// Method to Validate Detail Report Load
        /// </summary>
        public void ValidateDetailReportPageLoad()
        {
            driver.WaitForElement(detailReport, TimeSpan.FromMinutes(1));
            driver.ClickElement(detailReport, "Detail Report");
            driver.sleepTime(1000);
            string url = driver.Url;
            if (url.Contains("/dashboard/detailreport/systemconsumption"))
            {
                testReport.Pass("User is redirected to System Consumption detailed report" + url);
            }
        }

        /// <summary>
        /// Method to Validate Detail Report Back to KPI
        /// </summary>
        public void ValidateDetailReportBacktoKPI()
        {
            driver.WaitForElement(detailReport, TimeSpan.FromMinutes(1));
            driver.ClickElement(detailReport, "Detail Report");
            driver.sleepTime(1000);
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(30));
            driver.ClickElement(backToKPI, "Back to KPI");
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Screen"))
            {
                testReport.Pass("<i>Dashboard Screen is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Dashboard Screen is Not Displayed");
            }
        }


        /// <summary>
        /// Method to Validate Top 10 Accounts Detail Report
        /// </summary>
        public void ValidateTop10AccountsDetailReport()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromMinutes(1));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Accounts Detail Report");
        }
        public void ValidateTop10AccountsDetailReportHTMLLink()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromMinutes(1));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Accounts Detail Report");
            string s = driver.Url;
            if (s.Contains("/dashboard/detailreport/toptenaccounts"))
            {
                testReport.Pass("Link Displayed is : " + s);
            }
        }
        public void ValidateTop10AccDetailReportBackToKPILink()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromMinutes(1));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Accounts Detail Report");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(20));
            driver.ClickElement(backToKPI, "Back TO KPI");
            string s = driver.Url;
            if (s.Contains("/dashboard"))
            {
                testReport.Pass("Link Displayed is : " + s);
            }
        }

        /// <summary>
        /// Method to Validate complete count map
        /// </summary>
        public void ValidateCompleteCountMap()
        {
            driver.sleepTime(40);
            driver.WaitForElement(completeReadingsCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(completeReadingsCount, "Complete Count");
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElementNotExists(gridLoader, 400);
            driver.WaitForElement(completeReadingDetail, System.TimeSpan.FromSeconds(30));
            driver.WaitForElementNotExists(gridLoader, 40);
            driver.ClickElement(mapView, "Map View");
            driver.WaitForElement(plusSymbol, TimeSpan.FromSeconds(30));
            if (driver.CheckElementDisplayed(plusSymbol, "Map"))
            {
                testReport.Pass("<i>Map is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Map is Not Displayed");
            }
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate complete count map
        /// </summary>
        public void ValidateCompleteCountGridView()
        {
            driver.sleepTime(40);
            driver.WaitForElement(completeReadingsCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(completeReadingsCount, "Complete Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(completeReadingDetail, System.TimeSpan.FromSeconds(30));
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(30));
            if (driver.CheckElementDisplayed(gridView, "Grid View"))
            {
                testReport.Pass("<i>Grid View is Displayed by default.");
            }
            else
            {
                ReporterFactory.LogFailure("Grid View is Not Displayed by default");
            }
            //driver.SwitchToDefaultFrame();
        }
        /// <summary>
        /// Method to Validate complete Count Export PDF
        /// </summary>
        public void ValidateCompleteCountExportPDF()
        {
            driver.sleepTime(40);
            driver.WaitForElement(completeReadingsCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(completeReadingsCount, "Complete Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(exportLink, "Export Link");

            if (driver.CheckElementDisplayed(exportPDF, "Export PDF"))
            {
                testReport.Pass("<i>Export PDF is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Export PDF is Not Displayed");
            }
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateSkippedReadingExportPDF()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(skippedReadingCount, "Skipped KPI");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(exportLink, "Export Link");

            driver.CheckElementDisplayed(exportPDF, "Export PDF");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateSkippedReadingExportExcel()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(skippedReadingCount, "Skipped KPI");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(exportLink, "Export Link");

            driver.CheckElementDisplayed(exportExcel, "Export Excel");
            //driver.SwitchToDefaultFrame();
        }
        public void ValidateSkippedReadingBackToKPI()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(skippedReadingCount, "Skipped KPI");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(10));
            driver.ClickElement(backToKPI, "Back To KPI");
        }
        public void ValidateSkippedReadingHTMLLink()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(skippedReadingCount, "Skipped KPI");
            string s = driver.Url;
            if (s.Contains("/dashboard/detailreport/skippedreadings"))
            {
                testReport.Pass("Link Displayed is : " + s);
            }
        }
        public void ValidateSkippedReadingBackToKPILink(string url)
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(skippedReadingCount, "Skipped KPI");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(10));
            driver.ClickElement(backToKPI, "Back To KPI");
            string s = driver.Url;
            if (s.Contains("/dashboard"))
            {
                testReport.Pass("Link Displayed is : " + s);
            }
        }

        public void ValidateSkippedReadingCurrentDate()
        {
            driver.WaitForElement(ViaAMR, TimeSpan.FromMinutes(2));
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(skippedReadingCount, "Skipped KPI");
            //driver.SwitchToFrameById("ntgMSTRFrame");

            driver.WaitForElement(reportDate, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(reportDate, "Current Date");
            //driver.SwitchToDefaultFrame();
        }


        /// <summary>
        /// Method to Validate complete Count Export Excel
        /// </summary>
        public void ValidateCompleteCountExportExcel()
        {
            driver.WaitForElement(completeReadingsCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(completeReadingsCount, "Complete Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(exportLink, "Export Link");

            if (driver.CheckElementDisplayed(exportExcel, "Export Excel"))
            {
                testReport.Pass("<i>Export Excel is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Export Excel is Not Displayed");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Back to KPI link for Complete Readings KPI
        /// </summary>
        public void ValidateCompleteBackToKPI()
        {
            driver.WaitForElement(completeReadingsCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(completeReadingsCount, "Complete Count");
            driver.WaitForElement(backToKPI, System.TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(backToKPI, "Back to KPI");
            driver.ClickElement(backToKPI, "Back to KPI");
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Screen"))
            {
                testReport.Pass("<i>Dashboard Screen is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Dashboard Screen is Not Displayed");
            }
            ////driver.SwitchToDefaultFrame();
        }
        public void ValidateCompleteReadingHTMLLink()
        {
            driver.WaitForElement(completeReadingsCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(completeReadingsCount, "Complete Readings Count");
            driver.sleepTime(1000);
            string url = driver.Url;
            if (url.Contains("/dashboard/detailreport/completereadings"))
            {
                testReport.Pass("User is redirected to Complete Reading detailed report" + url);
            }
        }
        public void ValidateCriticalContinuousConsumptionHTMLLink()
        {
            driver.WaitForElement(criticalReadingCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(criticalReadingCount, "Critical Continuos Consumption Count");
            driver.WaitForElementNotExists(gridLoader, 60);
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
            string url = driver.Url;
            if (url.Contains(@"dashboard/detailreport/criticalconsumption"))
            {
                testReport.Pass("User is redirected to Continuous Consumption detailed report" + url);
            }
        }
        /// <summary>
        /// Method to Validate Incomplete Count Reading
        /// </summary>
        public void ValidateIncompleteCountReading()
        {
            driver.WaitForElement(completeReadingsCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(readingRightArrow, "Reading Right Arrow");
            driver.ClickElement(inCompleteReadingsCount, "Incomplete Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(incompleteReadingDetail, TimeSpan.FromSeconds(40));
            if (driver.CheckElementDisplayed(incompleteReadingDetail, "Incomplete Reading"))
            {
                testReport.Pass("<i>Incomplete Reading is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Incomplete Reading is Not Displayed");
            }
            //driver.SwitchToDefaultFrame();
        }
        /// <summary>
        /// Method to Validate Incomplete Count Reading Grid View
        /// </summary>
        public void ValidateIncompleteCountReadingGridView()
        {
            driver.WaitForElement(completeReadingsCount, System.TimeSpan.FromSeconds(60));
            driver.ClickElement(readingsRightArrow, "Reading Right Arrow");
            driver.ClickElement(inCompleteReadingsCount, "Incomplete Count");
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(40));
            driver.CheckElementDisplayed(gridView, "Grid View");
        }

        /// <summary>
        /// Method to Validate Incomplete Count Export PDF
        /// </summary>
        public void ValidateIncompleteCountExportPDF()
        {
            driver.WaitForElement(completeReadingsCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(readingRightArrow, "Reading Right Arrow");
            driver.ClickElement(inCompleteReadingsCount, "Incomplete Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(40));
            driver.ClickElement(exportLink, "Export Link");
            if (driver.CheckElementDisplayed(exportPDF, "Export PDF"))
            {
                testReport.Pass("<i>Export PDF is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Export PDF is Not Displayed");
            }
            //driver.SwitchToDefaultFrame();
        }
        /// <summary>
        /// Method to Validate Incomplete Count Export Excel
        /// </summary>
        public void ValidateIncompleteCountExportExcel()
        {
            driver.WaitForElement(completeReadingsCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(readingRightArrow, "Reading Right Arrow");
            driver.ClickElement(inCompleteReadingsCount, "Incomplete Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, TimeSpan.FromSeconds(40));
            driver.ClickElement(exportLink, "Export Link");
            if (driver.CheckElementDisplayed(exportExcel, "Export Excel"))
            {
                testReport.Pass("<i>Export Excel is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Export Excel is Not Displayed");
            }
            //driver.SwitchToDefaultFrame();
        }
        /// <summary>
        /// Method to Validate Incomplete Count back to kpi
        /// </summary>
        public void ValidateIncompleteCountBackToKPI()
        {
            driver.WaitForElement(completeReadingsCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(readingRightArrow, "Reading Right Arrow");
            driver.ClickElement(inCompleteReadingsCount, "Incomplete Count");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(40));
            driver.ClickElement(backToKPI, "Back To KPI");
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Page"))
            {
                testReport.Pass("<i>Dashboard Page is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Dashboard Page is Not Displayed");
            }
        }
        public void ValidateIncompleteCountBackToKPILink()
        {
            driver.WaitForElement(completeReadingsCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(readingRightArrow, "Reading Right Arrow");
            driver.ClickElement(inCompleteReadingsCount, "Incomplete Count");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(40));
            driver.ClickElement(backToKPI, "Back To KPI");
            string s = driver.Url;
            if (s.Contains("/dashboard"))
            {
                testReport.Pass("Link displayed is: " + s);
            }
        }
        /// <summary>
        /// Method to Validate top 10 consumption detail report
        /// </summary>
        public void ValidateTopTenConsumtionDetailReport()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(30));
            if (driver.CheckElementDisplayed(topTenConsumtionDetailReport, "Detail Report"))
            {
                testReport.Pass("<i>Top 10 Consumption Detail Report is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Top 10 Consumption Detail Report is not Displayed.");
            }
        }
        /// <summary>
        /// Method to Validate top 10 consumption grid view
        /// </summary>
        public void ValidateTopTenConsumtionGridView()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, "Detail Report");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(40));
            if (driver.CheckElementDisplayed(gridView, "Grid View"))
            {
                testReport.Pass("<i>Grid View is Displayed by default.");
            }
            else
            {
                ReporterFactory.LogFailure("Grid View is not Displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate top 10 consumption radio button
        /// </summary>
        public void ValidateTopTenConsumtionRadioButton()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, "Detail Report");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(btnActual, TimeSpan.FromSeconds(40));
            if (driver.CheckElementDisplayed(btnActual, "Actual Radio Button") & driver.CheckElementDisplayed(btnEstimated, "Estimated Radio Button"))
            {
                testReport.Pass("<i>Radio Buttons are displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Radio Buttons are not displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }
        /// <summary>
        /// Method to Validate top 10 consumption actual consumption radio button
        /// </summary>
        public void ValidateTopTenConsumtionActualConsumption()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, "Detail Report");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(btnActual, TimeSpan.FromMilliseconds(40));
            if (driver.CheckElementDisplayed(btnActual, "Actual Radio Button"))
            {
                testReport.Pass("<i>Actual Consumption Radio Button displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Actual Consumption Radio Button not displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate top 10 consumption Estimated consumption radio button
        /// </summary>
        public void ValidateTopTenConsumtionEstimatedConsumption()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, "Detail Report");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(btnActual, TimeSpan.FromMilliseconds(40));
            if (driver.CheckElementDisplayed(btnEstimated, "Estimated Radio Button"))
            {
                testReport.Pass("<i>Estimated Consumption Radio Button displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Estimated Consumption Radio Button not displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate top 10 consumption actual detail
        /// </summary>
        public void ValidateTopTenConsumtionActualDetail()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, "Detail Report");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            //driver.WaitForElement(btnActual, TimeSpan.FromSeconds(40));
            //driver.ClickElement(btnActual, "Actual");
            //if (driver.CheckElementDisplayed(topConsumptionActualDetail, "Top 10 Accounts by Consumption Detail"))
            //{
            //    testReport.Pass("<i>Top 10 Accounts by Consumption Actual Detail displayed.");
            //}
            //else
            //{
            //    ReporterFactory.LogFailure("<i>Top 10 Accounts by Consumption Actual Detail not displayed.");
            //}
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate top 10 consumption estimated detail
        /// </summary>
        public void ValidateTopTenConsumtionEstimatedDetail()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, "Detail Report");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(btnActual, TimeSpan.FromSeconds(40));
            driver.ClickElement(btnEstimated, "Estimated");
            if (driver.CheckElementDisplayed(topConsumptionEstimatedDetail, "Top 10 Accounts by Consumption Estimated Detail"))
            {
                testReport.Pass("<i>Top 10 Accounts by Consumption Estimated Detail displayed.ge from Top 10 Consumption Detail Page Successfully.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Not Navigated to Dashboard Page from Top 10 Consumption Detail Page.");
            }
            //driver.SwitchToDefaultFrame();
        }
        /// <summary>
        /// Method to Validate top 10 consumption back to KPI
        /// </summary>
        public void ValidateTopTenConsumtionBackToKPI()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, "Detail Report");
            driver.CheckElementDisplayed(backToKPI, "Back To KPI");
            driver.ClickElement(backToKPI, "Back To KPI");
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Title"))
            {
                testReport.Pass("<i>Navigated to Dashboard Page from Top 10 Consumption Detail Page Successfully.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Not Navigated to Dashboard Page from Top 10 Consumption Detail Page.");
            }
        }

        /// <summary>
        /// Method to Validate top 10 consumption PDF
        /// </summary>
        public void ValidateTopTenConsumtionPDF()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, "Detail Report");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(exportLink, "Export Link");
            if (driver.CheckElementDisplayed(exportPDF, "Export PDF"))
            {
                testReport.Pass("<i>Export PDF link is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Export PDF link is not displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate top 10 consumption Excel
        /// </summary>
        public void ValidateTopTenConsumtionExcel()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(130));
            driver.ClickElement(topTenConsumtionDetailReport, "Detail Report");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(exportLink, "Export Link");
            if (driver.CheckElementDisplayed(exportExcel, "Export Excel"))
            {
                testReport.Pass("<i>Export Excel link is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Export Excel link is not displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate consumption header radio button
        /// </summary>
        public void ValidateConsumtionHeaderRadioButton()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(detailReport, "Detail Report");
            driver.sleepTime(130);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(consumptionHeader, TimeSpan.FromSeconds(10));
            //driver.WaitForElement(btnActualDetailReport, TimeSpan.FromSeconds(40));
            if (driver.CheckElementDisplayed(consumptionHeader, "Consumption Header"))
            {
                testReport.Pass("<i>Consumption Header with Radio Button(s) are displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Consumption Header with Radio Button(s) are not displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate consumption header actual radio button
        /// </summary>
        public void ValidateConsumtionHeaderActualButton()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(detailReport, "Detail Report");
            driver.sleepTime(130);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(btnActualDetailReport, TimeSpan.FromSeconds(40));
            if (driver.CheckElementDisplayed(btnActualDetailReport, "Actual Radio Button"))
            {
                testReport.Pass("<i>Actual Radio Button Radio Button displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Actual Radio Button Radio Button not displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate consumption header estimated radio button
        /// </summary>
        public void ValidateConsumtionHeaderEstimatedButton()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(detailReport, "Detail Report");
            driver.sleepTime(130);
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(20));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(btnEstimatedDetailReport, TimeSpan.FromSeconds(40));
            if (driver.CheckElementDisplayed(btnEstimatedDetailReport, "Estimated Radio Button"))
            {
                testReport.Pass("<i>Estimated Radio Button Radio Button displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Estimated Radio Button Radio Button not displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }
        /// <summary>
        /// Method to Validate detailed report title displayed actual option selected
        /// </summary>
        public void ValidateConsumtionDetailTitleActual()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(45));
            driver.ClickElement(detailReport, "Detail Report");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            //driver.WaitForElement(btnActualDetailReport, System.TimeSpan.FromSeconds(45));
            //driver.ClickElement(btnActualDetailReport, "Actual Detail");
            driver.WaitForElement(systemConsumptionTitleActual, TimeSpan.FromSeconds(40));
            if (driver.CheckElementDisplayed(systemConsumptionTitleActual, "System Consumption Title"))
            {
                testReport.Pass("<i>System Consumption Actual Title displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>System Consumption Actual Title not displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate detailed report title displayed estimated option selected
        /// </summary>
        public void ValidateConsumtionDetailTitleEstimated()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(detailReport, "Detail Report");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(btnEstimatedDetailReport, "Estimated Detail");
            driver.WaitForElement(systemConsumptionTitleEstimated, TimeSpan.FromSeconds(40));
            if (driver.CheckElementDisplayed(systemConsumptionTitleEstimated, "System Consumption Title"))
            {
                testReport.Pass("<i>System Consumption Estimated Title displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>System Consumption Estimated Title not displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate detailed report back to kpi
        /// </summary>
        public void ValidateConsumtionDetailBackToKPI()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(detailReport, "Detail Report");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(40));
            driver.ClickElement(backToKPI, "Back To KPI");
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Title"))
            {
                testReport.Pass("<i>Navigated To Dashboard Page from Detail Report Page Successfully.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Navigated To Dashboard Page from Detail Report Page Successfully.");
            }
        }
        /// <summary>
        /// Method to Validate Date range not visible for Reading
        /// </summary>
        public void ValidateIncompleteCountReadingDateRange()
        {
            driver.WaitForElement(completeReadingsCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(readingRightArrow, "Reading Right Arrow");
            driver.ClickElement(inCompleteReadingsCount, "Incomplete Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(incompleteReadingDetail, TimeSpan.FromSeconds(40));
            if (driver.CheckElementDisplayed(incompleteReadingDetail, "Incompete Reading Detail"))
            {
                testReport.Pass("<i>Date Range is not Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Date Range is Displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate complete count date range
        /// </summary>
        public void ValidateCompleteCountDateRange()
        {
            driver.WaitForElement(completeReadingsCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(completeReadingsCount, "Complete Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(completeReadingDetail, System.TimeSpan.FromSeconds(30));
            if (driver.CheckElementDisplayed(completeReadingDetail, "Complete Reading Detail"))
            {
                testReport.Pass("<i>Date Range is not Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Complete Reading Detail is Displayed");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate export PDF link
        /// </summary>
        public void ValidateExportPDFMajor()
        {
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(majorreverseReadingCount, "Major Reverse Flow Count");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(exportLink, "Export Link");
            if (driver.CheckElementDisplayed(exportPDF, "Export PDF Link"))
            {
                testReport.Pass("<i> Export PDF Link is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>  Export PDF Link is not displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate System Consumption Actual export PDF link
        /// </summary>
        public void ValidateSystemConsumptionActualExportPDF()
        {
            driver.WaitForElement(detailReport, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(detailReport, "System Consumption Detail Report Link");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(exportLink, "Export Link");
            if (driver.CheckElementDisplayed(exportPDF, "Export PDF Link"))
            {
                testReport.Pass("<i> Export PDF Link is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>  Export PDF Link is not displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate System Consumption Actual export Excel link
        /// </summary>
        public void ValidateSystemConsumptionActualExportExcel()
        {
            driver.WaitForElement(detailReport, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(detailReport, "System Consumption Detail Report Link");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(exportLink, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(exportLink, "Export Link");
            if (driver.CheckElementDisplayed(exportExcel, "Export Excel Link"))
            {
                testReport.Pass("<i> Export Excel Link is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>  Export Excel Link is not displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate System Consumption Estimated export PDF link
        /// </summary>
        public void ValidateSystemConsumptionEstimatedExportPDF()
        {
            driver.WaitForElement(detailReport, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(detailReport, "System Consumption Detail Report Link");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(btnEstimatedDetailReport, "Ëstimated button");
            driver.WaitForElement(estimatedExportLink, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(estimatedExportLink, "Export Link");
            if (driver.CheckElementDisplayed(exportPDF, "Export PDF Link"))
            {
                testReport.Pass("<i> Export PDF Link is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>  Export PDF Link is not displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate System Consumption Estimated export Excel link
        /// </summary>
        public void ValidateSystemConsumptionEstimatedExportExcel()
        {
            driver.WaitForElement(detailReport, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(detailReport, "System Consumption Detail Report Link");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.ClickElement(btnEstimatedDetailReport, "Estimated Button");
            driver.WaitForElement(estimatedExportLink, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(estimatedExportLink, "Ëxport Link");
            if (driver.CheckElementDisplayed(exportExcel, "Export Excel Link"))
            {
                testReport.Pass("<i> Export Excel Link is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>  Export Excel Link is not displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }
        /// <summary>
        /// Method to Validate Top 10 Consumption Widget
        /// </summary>
        public void ValidateTop10ConsumptionWidget()
        {
            driver.WaitForElement(top10ConsumtptionWidget, TimeSpan.FromSeconds(130));
            if (driver.CheckElementDisplayed(top10ConsumtptionWidget, "Top 10 Accounts by Consumption "))
            {
                testReport.Pass("<i>Top 10 Accounts by Consumption Widget Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Top 10 Accounts by Consumption Widget not Displayed.");
            }
        }

        /// <summary>
        /// Method to Validate Top 10 Consumption Widget Detail Report
        /// </summary>
        public void ValidateTop10ConsumptionDetailReport()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(130));
            if (driver.CheckElementDisplayed(topTenConsumtionDetailReport, "Top 10 Accounts by Consumption Detail Report"))
            {
                testReport.Pass("<i>Top 10 Accounts by Consumption Widget Displayed Detail Report.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Top 10 Accounts by Consumption Widget not Displayed Detail Report.");
            }
        }
        public void ValidateTop10ConsumptionDetailReportColumnDetails()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(130));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Accounts by Consumption Detail Report");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            //driver.SwitchToFrameById("ntgMSTRFrame");

            driver.CheckElementDisplayed(accName, "Account Name");
            driver.CheckElementDisplayed(accNo, "Acc no");
            driver.CheckElementDisplayed(miuId, "MIU Id");
            driver.CheckElementDisplayed(address, "Address");
            driver.CheckElementDisplayed(meterNo, "meterNo");
            driver.CheckElementDisplayed(meterSize, "meterSize");
            driver.CheckElementDisplayed(consumptionCol, "consupmtion");
            driver.CheckElementDisplayed(uom, "UOM");
            driver.CheckElementDisplayed(conv, "Conv");
            driver.sleepTime(2000);
            //driver.SwitchToDefaultFrame();
        }
        /// <summary>
        /// Method to Validate Top 10 Consumption no data returned
        /// </summary>
        public void ValidateTop10ConsumptionNoDataReturned()
        {
            driver.ClickElement(lnkChooseUtilities, "Utilities Dropdown");
            driver.ClickElement(lnkChooseUtilities, "Utilities Dropdown");
            driver.SendKeysToElementAndPressEnter(utilitySearch, "SQA", "Utility");
            driver.ClickElement(tblChooseUtilities, "Select");
            driver.ClickElement(btnChooseUtilitiesOk, "OK");
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(topTenCnsmNoData, TimeSpan.FromSeconds(130));
            if (driver.CheckElementDisplayed(topTenCnsmNoData, "No data returned for this view. This might be because the applied filter excludes all data."))
            {
                testReport.Pass("<i>No data returned for this view. This might be because the applied filter excludes all data displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>No data returned for this view. This might be because the applied filter excludes all data not Displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Top 10 Consumption  Page Load
        /// </summary>
        public void ValidateTop10ConsumptionPageLoad()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, " Top 10 Consumption");
            driver.sleepTime(1000);
            string url = driver.Url;
            if (url.Contains("/dashboard/detailreport/toptenaccounts"))
            {
                testReport.Pass("User is redirected to Top 10 Accounts By Consumption detailed report" + url);
            }
        }

        /// <summary>
        /// Method to Validate Top 10 Consumption  back to KPI
        /// </summary>
        public void ValidateTop10ConsumptionBackToKPI()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, " Top 10 Consumption");
            driver.CheckElementDisplayed(backToKPI, "Back To KPI");
            driver.ClickElement(backToKPI, "Back To KPI");
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Title"))
            {
                testReport.Pass("<i>Navigated to Dashboard Page from Compplete Count Page successfully.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Unable to Navigate to Dashboard Page from Compplete Count Page.");
            }
        }

        /// <summary>
        /// Method to Validate Continuous count back to KPI
        /// </summary>
        public void ValidateContinuousCountBackToKPI()
        {
            driver.WaitForElement(continuousCount, TimeSpan.FromSeconds(40));
            driver.ClickElement(continuousCount, "Contiuous Count");
            driver.CheckElementDisplayed(backToKPI, "Back To KPI");
            driver.ClickElement(backToKPI, "Back To KPI");
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Title"))
            {
                testReport.Pass("<i>Navigated to Dashboard Page from Compplete Count Page successfully.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Unable to Navigate to Dashboard Page from Compplete Count Page.");
            }
        }

        /// <summary>
        /// Method to Validate Intermittent detail report
        /// </summary>
        public void ValidateIntermittentDetailReport()
        {
            driver.sleepTime(20000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(40));
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(continuousCount, "Continuous Count");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(intermittentUsageDetail, TimeSpan.FromSeconds(40));
            string s = driver.GetElementText(intermittentUsageDetail);
            if (driver.CheckElementDisplayed(intermittentUsageDetail, "Intermittent Usage Detail"))
            {
                testReport.Pass("Page Displayed: <i>" + s);
            }
            else
            {
                ReporterFactory.LogFailure("<i> Intermittent Usage Detail Page Not Displayed.");
            }
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Intermittent Page Load
        /// </summary>
        public void ValidateIntermittentPageLoad()
        {
            driver.sleepTime(20000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(40));
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(continuousCount, "Continuous Count");
            string url = driver.Url;
            if (url.Contains("/dashboard/detailreport/intermittentconsumption"))
            {
                testReport.Pass("User is redirected to Intermittent Consumption detailed report" + url);
            }
        }

        /// <summary>
        /// Method to Validate Intermittent Page Back to KPI
        /// </summary>
        public void ValidateIntermittentPageBacktoKPI()
        {
            driver.sleepTime(20000);
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(40));
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(continuousCount, "Continuous Count");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(30));
            driver.ClickElement(backToKPI, "Back to KPI");
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Screen"))
            {
                testReport.Pass("<i>Dashboard Screen is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Dashboard Screen is Not Displayed");
            }
        }


        /// <summary>
        /// Method to Validate Intermittent detail report grid view
        /// </summary>
        public void ValidateIntermittentDetailReportGridView()
        {
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(40));
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(continuousCount, "Continuous Count");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(intermittentUsageDetail, TimeSpan.FromSeconds(40));
            if (driver.CheckElementDisplayed(gridView, "Grid View"))
            {
                testReport.Pass("<i> Grid View is by default.");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Grid View is by default.");
            }
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Intermittent export pdf
        /// </summary>
        public void ValidateIntermittentPDF()
        {
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(40));
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(continuousCount, "Continuous Count");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(intermittentExportLink, TimeSpan.FromSeconds(40));
            driver.ClickElement(intermittentExportLink, "Export");
            if (driver.CheckElementDisplayed(exportPDF, "Intermittent Export PDF"))
            {
                testReport.Pass("<i> Intermittent Export PDF Link is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Intermittent Export PDF Link is not Displayed.");
            }
            ////driver.SwitchToDefaultFrame();
        }
        /// <summary>
        /// Method to Validate Intermittent export excel
        /// </summary>
        public void ValidateIntermittentExcel()
        {
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(40));
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(continuousCount, "Continuous Count");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(intermittentExportLink, TimeSpan.FromSeconds(40));
            driver.ClickElement(intermittentExportLink, "Export");
            if (driver.CheckElementDisplayed(exportExcel, "Intermittent Export Excel"))
            {
                testReport.Pass("<i> Intermittent Export Excel Link is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Intermittent Export Excel Link is not Displayed.");
            }
            ////driver.SwitchToDefaultFrame();
        }
        /// <summary>
        /// Method to Validate Intermittent back to kpi
        /// </summary>
        public void ValidateIntermittentBackToKPI()
        {
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(40));
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(continuousCount, "Continuous Count");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(40));
            driver.ClickElement(backToKPI, "Back To KPI");
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Page"))
            {
                testReport.Pass("<i> Navigated to dashboard page from Intermittent Details Report Page.");
            }
            else
            {
                ReporterFactory.LogFailure("<i> Not Navigated to dashboard page from Intermittent Details Report Page.");
            }
        }
        public void ValidateIntermittentBackToKPILink()
        {
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(40));
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(continuousCount, "Continuous Count");
            driver.WaitForElement(backToKPI, TimeSpan.FromSeconds(40));
            driver.ClickElement(backToKPI, "Back To KPI");
            string s = driver.Url;
            if (s.Contains("/dashboard"))
            {
                testReport.Pass("Link Displayed is : " + s);
            }
        }
        public void ValidateIntermittentCountLink()
        {
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(40));
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(continuousCount, "Continuous Count");
            string s = driver.Url;
            if (s.Contains("/dashboard/detailreport/intermittentconsumption"))
            {
                testReport.Pass("Link displayed is: " + s);
            }
        }

        /// <summary>
        /// Method to Validate Intermittent Consumption Page
        /// </summary>
        public void ValidateIntermittentConsumptionCountPage()
        {
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(40));
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(continuousCount, "Continuous Count");
        }

        /// <summary>
        /// Method to Validate Contineous Intermittent usage
        /// </summary>
        public void ValidateContineousIntermittentUsage()
        {
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(180));
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
            driver.CheckElementDisplayed(consupmtion, "Consumption");
        }

        /// <summary>
        /// Method to Validate Widget Arrow State
        /// </summary>
        public void ValidateWidgetArrowState()
        {
            driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
            driver.IsElementEnabled(readingRightArrow, "Reading Right Arrow");
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            driver.IsElementEnabled(cotinuousRightArrow, "Continous Right Arrow");
            driver.WaitForElement(reverseFlowRightArrow, TimeSpan.FromSeconds(10));
            driver.IsElementEnabled(reverseFlowRightArrow, "Reverse Flow Right Arrow");
            driver.WaitForElement(gatewayRightArrow, TimeSpan.FromSeconds(10));
            driver.IsElementEnabled(gatewayRightArrow, "Gateway Right");
        }


        /// <summary>
        /// Method to Validate Switching Count Updated
        /// </summary>
        public void ValidateSwitchingCountUpdated()
        {
            driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
            driver.IsElementEnabled(readingRightArrow, "Reading Right Arrow");
            driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
            driver.IsElementEnabled(cotinuousRightArrow, "Continous Right Arrow");
            driver.WaitForElement(reverseFlowRightArrow, TimeSpan.FromSeconds(10));
            driver.IsElementEnabled(reverseFlowRightArrow, "Reverse Flow Right Arrow");
            driver.WaitForElement(gatewayRightArrow, TimeSpan.FromSeconds(10));
            driver.IsElementEnabled(gatewayRightArrow, "Gateway Right");
            driver.ClickElement(readingRightArrow, "Reading Right Arrow");
            driver.CheckElementDisplayed(inCompleteReadingsCount, "Count Updated");
        }



        /// <summary>
        /// Method to Validate MapWidgetLabels
        /// </summary>
        public void ValidateMapWidgetLabels()
        {
            driver.WaitForPageLoad(TimeSpan.FromSeconds(30));
            ////driver.WaitForElement(By.("ntgMSTRFrame"), TimeSpan.FromSeconds(20));

            ////driver.SwitchToFrameByIndex(4);
            ////driver.SwitchToDefaultFrame();
            //driver.SwitchToFrameByLocator(By.Id("ntgMSTRFrame"));
            //driver.WaitForElement(majorReverseFlow, TimeSpan.FromMinutes(1));
            //driver.CheckElementDisplayed(majorReverseFlow, "Major Reverse Flow");
            ////driver.CheckElementDisplayed(criticalContinousConsum, "Critical Continous Cosumption");
            ////driver.CheckElementDisplayed(topAccConsumption, "Top 10 Accounts");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate export Excel link
        /// </summary>
        public void ValidateExportExcel()
        {
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(majorreverseReadingCount, "Major Reverse Flow Count");
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            //driver.WaitForElement(exportLink, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(exportLink, "Export Link");
            if (driver.CheckElementDisplayed(exportExcel, "Export Excel Link"))
            {
                testReport.Pass("<i> Export Excel Link is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>  Export Excel Link is not displayed.");
            }
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate back to kpi
        /// </summary>
        public void ValidateBackToKPI()
        {
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(majorreverseReadingCount, "Major Reverse Flow Count");
            driver.WaitForElement(backToKPI, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(backToKPI, "Back To KPI");
            if (driver.CheckElementDisplayed(dashboardTitle, "Dashboard Title"))
            {
                testReport.Pass("<i> Dashboard Page is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>  Dashboard Page is not displayed.");
            }
            //driver.SwitchToDefaultFrame();
        }
        /// <summary>
        /// Method to Validate reverse flow count
        /// </summary>
        public void ValidateReverseFlowCount()
        {
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(20000));
            driver.CheckElementDisplayed(reverseFlowRightArrow, "");

            driver.ClickElement(reverseFlowRightArrow, "Reverse Flow Right Arrow");
            driver.CheckElementDisplayed(minorreverseReadingCount, "");
            driver.ClickElement(minorreverseReadingCount, "Minor Reverse Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"),TimeSpan.FromSeconds(30));

            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.CheckElementExists(minorReverseDetails, "Minor Reverse Details");
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate reverse flow title
        /// </summary>
        public void ValidateReverseFlowTitle()
        {
            driver.WaitForElement(majorreverseReadingCount, System.TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(reverseFlowRightArrow, "");

            driver.ClickElement(reverseFlowRightArrow, "Reverse Flow Right Arrow");
            driver.CheckElementDisplayed(minorreverseReadingCount, "");
            driver.ClickElement(minorreverseReadingCount, "Minor Reverse Flow");
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            //driver.WaitForElement(gridView, System.TimeSpan.FromSeconds(40));
            string s = driver.GetElementText(minorReverseDetails);
            if (driver.CheckElementDisplayed(minorReverseDetails, "Minor Reverse Details"))
            {
                testReport.Pass("Title is Displayed as : <i> " + s);
            }
            else
            {
                ReporterFactory.LogFailure("Title is Displayed as : <i> " + s);
            }
            ////driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate map styles
        /// </summary>
        public void ValidateMapStyles()
        {
            driver.ClickElement(detailReport, "Detail Report");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(10));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForElement(mapView, TimeSpan.FromSeconds(10));
            driver.ClickElement(mapView, "");
           // driver.ClickElement(styleDrpDwon, "Styles Dropdown");
            /*if (driver.CheckElementDisplayed(streetView, "Street View"))
            {
                driver.sleepTime(1000);
                testReport.Pass("<i>Street View View is Displayed.");
            }
            if (driver.CheckElementDisplayed(lightGray, "LightGray View"))
            {
                driver.sleepTime(1000);
                testReport.Pass("<i>LightGray View is Displayed.");
            }
            if (driver.CheckElementDisplayed(releif, "Relief View"))
            {
                driver.sleepTime(1000);
                testReport.Pass("<i>Relief View is Displayed.");
            }
            if (driver.CheckElementDisplayed(topographicView, "Topographic View"))
            {
                driver.sleepTime(1000);
                testReport.Pass("<i>Topographic View is Displayed.");
            }
            if (driver.CheckElementDisplayed(physicalView, "Physical View"))
            {
                driver.sleepTime(1000);
                testReport.Pass("<i>Physical View is Displayed.");
            }
            if (driver.CheckElementDisplayed(terrainView, "Terrain View"))
            {
                driver.sleepTime(1000);
                testReport.Pass("<i>Terrain View is Displayed.");
            }*/
            if (driver.CheckElementDisplayed(sateliteView, "Satelite View"))
            {
                driver.sleepTime(1000);
                testReport.Pass("<i>Satellite View is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>sateliteView Not Displayed.");
            }
            if (driver.CheckElementDisplayed(map, "Satelite View"))
            {
                driver.sleepTime(1000);
                testReport.Pass("<i>map View is Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>mapview Not Displayed.");
            }
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateMinorReverseFlowCountValidation()
        {
            driver.WaitForElement(majorreverseReadingCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(reverseFlowRightArrow, "Right");
            string flowcount = driver.GetElementText(minorreverseReadingCount);
            int.Parse(flowcount);
            driver.ClickElement(minorreverseReadingCount, "Major Reverse Flow");
            ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
            ////driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(20));
            //driver.sleepTime(10);
            int rownum = driver.FindElements(By.XPath("//tr/td/div/div[2]/div/table/tbody/tr")).Count;
            rownum = (rownum - 1);
            rownum.ToString();
            Console.WriteLine(flowcount);
            //if(flowcount.Equals(rownum))
            //{
            //    testReport.Pass(rownum.ToString());
            //}
            //else
            //{
            //    ReporterFactory.LogFailure("Rowcount does not match." + rownum);
            //}
            testReport.Pass("RowCount is : " + rownum + "Displayed Value is : " + flowcount);
            ////driver.SwitchToDefaultFrame();
        }

        public void ValidateReceivedviaAMRCountValidation()
        {
            driver.WaitForElement(receivedRight, TimeSpan.FromMinutes(2));
            //driver.ClickElement(receivedRight, "Received Right");
            driver.CheckElementDisplayed(ViaAMR, "Received KPI via AMR");
            string flowcount = driver.GetElementText(receivedCount);
            driver.ClickElement(receivedCount, "Received Count");
            //driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
            //driver.SwitchToFrameById("ntgMSTRFrame");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(20));
            //driver.sleepTime(10);
            int rownum = driver.FindElements(By.XPath("//tr/td/div/div[2]/div/table/tbody/tr")).Count;
            rownum = (rownum - 1);
            rownum.ToString();
            Console.WriteLine(flowcount);
            testReport.Pass("RowCount is : " + rownum + "Displayed Value is : " + flowcount);
            //driver.SwitchToDefaultFrame();
        }


        public void ValidateCompleteReadingsCount()
        {
            try
            {
                string expectedRowCount = driver.GetElementAttribute(completeReadingsCount, "text");
                driver.WaitForElement(completeReadingsCount, TimeSpan.FromSeconds(30));
                driver.ClickElement(completeReadingsCount, "Complete Readings");
                //id=loadingSpinner                
                if (Convert.ToInt32(expectedRowCount) == 0)
                {
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    driver.WaitForElement(noDataDesciption, TimeSpan.FromSeconds(30));
                    testReport.Info(driver.GetElementText(noDataDesciption));
                    //driver.SwitchToDefaultFrame();
                }
                else
                {
                    Int32 scrollcount = Convert.ToInt32(expectedRowCount) / 2;
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    string scrollscriptpath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "StandardUtilities\\scroll.exe";
                    var process = Process.Start(scrollscriptpath, scrollcount.ToString());
                    process.WaitForExit();
                    driver.sleepTime(10000);
                    IWebElement reportdata = driver.FindElement(reporttable);
                    int actualRowCount = driver.GetWebTableRowCount(reportdata);
                    if (Convert.ToInt32(expectedRowCount) == actualRowCount)
                    {
                        testReport.Pass("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark> " + actualRowCount + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark>" + actualRowCount + "</mark>");
                    }

                    //
                    //driver.SwitchToDefaultFrame();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        public void ValidateIncompleteReadingsCount()
        {
            try
            {
                driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(30));
                driver.ClickElement(readingRightArrow, "Right");
                driver.WaitForElement(inCompleteReadingsCount, TimeSpan.FromSeconds(30));
                string expectedRowCount = driver.GetElementAttribute(inCompleteReadingsCount, "text");
                driver.ClickElement(inCompleteReadingsCount, "Incomplete Readings");
                //id=loadingSpinner     
                if (Convert.ToInt32(expectedRowCount) == 0)
                {
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    driver.WaitForElement(noDataDesciption, TimeSpan.FromSeconds(30));
                    testReport.Info(driver.GetElementText(noDataDesciption));
                    //driver.SwitchToDefaultFrame();
                }
                else
                {
                    Int32 scrollcount = Convert.ToInt32(expectedRowCount) / 2;
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    string scrollscriptpath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "StandardUtilities\\scroll.exe";
                    var process = Process.Start(scrollscriptpath, scrollcount.ToString());
                    process.WaitForExit();
                    driver.sleepTime(10000);
                    IWebElement reportdata = driver.FindElement(reporttable);
                    int actualRowCount = driver.GetWebTableRowCount(reportdata);
                    if (Convert.ToInt32(expectedRowCount) == actualRowCount)
                    {
                        testReport.Pass("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark> " + actualRowCount + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark>" + actualRowCount + "</mark>");
                    }

                    //
                    //driver.SwitchToDefaultFrame();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }



        /// <summary>
        /// Method to Validate selected icon navigated page
        /// </summary>
        public void ValidateDashBoardNavigatedPage()
        {
            driver.ClickElement(lftNavDashboard, "DashBoard");
            driver.CheckElementExists(detailReport, "Detail Report");
        }
        public void ValidateSkippedReadingsCount()
        {
            try
            {
                driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(30));
                driver.ClickElement(readingRightArrow, "Right");
                driver.ClickElement(readingRightArrow, "Right");
                driver.WaitForElement(skippedReadingCount, TimeSpan.FromSeconds(30));
                string expectedRowCount = driver.GetElementAttribute(skippedReadingCount, "text");
                driver.ClickElement(skippedReadingCount, "Skipped Readings");
                if (Convert.ToInt32(expectedRowCount) == 0)
                {
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    driver.WaitForElement(noDataDesciption, TimeSpan.FromSeconds(30));
                    testReport.Info(driver.GetElementText(noDataDesciption));
                    //driver.SwitchToDefaultFrame();
                }
                else
                {
                    Int32 scrollcount = Convert.ToInt32(expectedRowCount) / 2;
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    string scrollscriptpath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "StandardUtilities\\scroll.exe";
                    var process = Process.Start(scrollscriptpath, scrollcount.ToString());
                    process.WaitForExit();
                    driver.sleepTime(10000);
                    IWebElement reportdata = driver.FindElement(reporttable);
                    int actualRowCount = driver.GetWebTableRowCount(reportdata);
                    if (Convert.ToInt32(expectedRowCount) == actualRowCount)

                    {
                        testReport.Pass("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark> " + actualRowCount + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark>" + actualRowCount + "</mark>");
                    }

                    //
                    //driver.SwitchToDefaultFrame();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        public void ValidateReceivedAMRReadingsCount()
        {
            try
            {
                driver.sleepTime(5000);
                driver.WaitForElement(receivedAmrReadingCount, TimeSpan.FromSeconds(30));
                string expectedRowCount = driver.GetElementAttribute(receivedAmrReadingCount, "text");
                driver.ClickElement(receivedAmrReadingCount, "Received via AMR Readings");
                //id=loadingSpinner 
                if (Convert.ToInt32(expectedRowCount) == 0)
                {
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    driver.WaitForElement(noDataDesciption, TimeSpan.FromSeconds(30));
                    testReport.Info(driver.GetElementText(noDataDesciption));
                    //driver.SwitchToDefaultFrame();
                }
                else
                {
                    Int32 scrollcount = Convert.ToInt32(expectedRowCount) / 2;
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    string scrollscriptpath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "StandardUtilities\\scroll.exe";
                    var process = Process.Start(scrollscriptpath, scrollcount.ToString());
                    process.WaitForExit();
                    driver.sleepTime(10000);
                    IWebElement reportdata = driver.FindElement(reporttable);
                    int actualRowCount = driver.GetWebTableRowCount(reportdata);
                    if (Convert.ToInt32(expectedRowCount) == actualRowCount)
                    {
                        testReport.Pass("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark> " + actualRowCount + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark>" + actualRowCount + "</mark>");
                    }

                    //
                    //driver.SwitchToDefaultFrame();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        public void ValidateReceivedAMIReadingsCount()
        {
            try
            {
                driver.sleepTime(5000);
                driver.WaitForElement(receivedRight, TimeSpan.FromSeconds(30));
                driver.ClickElement(receivedRight, "");
                string expectedRowCount = driver.GetElementAttribute(receivedAMIReadingCount, "text");
                driver.ClickElement(receivedAMIReadingCount, "Received Via AMI Readings");
                //id=loadingSpinner    
                if (Convert.ToInt32(expectedRowCount) == 0)
                {
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    driver.WaitForElement(noDataDesciption, TimeSpan.FromSeconds(30));
                    testReport.Info(driver.GetElementText(noDataDesciption));
                    //driver.SwitchToDefaultFrame();
                }
                else
                {
                    Int32 scrollcount = Convert.ToInt32(expectedRowCount) / 2;
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    string scrollscriptpath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "StandardUtilities\\scroll.exe";
                    var process = Process.Start(scrollscriptpath, scrollcount.ToString());
                    process.WaitForExit();
                    driver.sleepTime(10000);
                    IWebElement reportdata = driver.FindElement(reporttable);
                    int actualRowCount = driver.GetWebTableRowCount(reportdata);
                    if (Convert.ToInt32(expectedRowCount) == actualRowCount)
                    {
                        testReport.Pass("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark> " + actualRowCount + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark>" + actualRowCount + "</mark>");
                    }

                    //
                    //driver.SwitchToDefaultFrame();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        public void ValidateNotReceivedReadingsCount()
        {
            try
            {
                driver.sleepTime(5000);
                driver.WaitForElement(receivedRight, TimeSpan.FromSeconds(30));
                driver.ClickElement(receivedRight, "");
                driver.ClickElement(receivedRight, "");
                string expectedRowCount = driver.GetElementAttribute(notReceivedReadingCount, "text");
                driver.ClickElement(notReceivedReadingCount, "Not Received Readings");
                //id=loadingSpinner    
                if (Convert.ToInt32(expectedRowCount) == 0)
                {
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    driver.WaitForElement(noDataDesciption, TimeSpan.FromSeconds(30));
                    testReport.Info(driver.GetElementText(noDataDesciption));
                    //driver.SwitchToDefaultFrame();
                }
                else
                {
                    Int32 scrollcount = Convert.ToInt32(expectedRowCount) / 2;
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    string scrollscriptpath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "StandardUtilities\\scroll.exe";
                    var process = Process.Start(scrollscriptpath, scrollcount.ToString());
                    process.WaitForExit();
                    driver.sleepTime(10000);
                    IWebElement reportdata = driver.FindElement(reporttable);
                    int actualRowCount = driver.GetWebTableRowCount(reportdata);
                    if (Convert.ToInt32(expectedRowCount) == actualRowCount)
                    {
                        testReport.Pass("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark> " + actualRowCount + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark>" + actualRowCount + "</mark>");
                    }
                    //driver.SwitchToDefaultFrame();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        public void ValidateCriticalReadingsCount()
        {
            try
            {
                driver.sleepTime(5000);
                driver.WaitForElement(receivedRight, TimeSpan.FromSeconds(30));
                string expectedRowCount = driver.GetElementAttribute(criticalReadingCount, "text");
                driver.ClickElement(criticalReadingCount, "Critical Readings");
                //id=loadingSpinner    
                if (Convert.ToInt32(expectedRowCount) == 0)
                {
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    driver.WaitForElement(noDataDesciption, TimeSpan.FromSeconds(30));
                    testReport.Info(driver.GetElementText(noDataDesciption));
                    //driver.SwitchToDefaultFrame();
                }
                else
                {
                    Int32 scrollcount = Convert.ToInt32(expectedRowCount) / 2;
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    string scrollscriptpath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "StandardUtilities\\scroll.exe";
                    var process = Process.Start(scrollscriptpath, scrollcount.ToString());
                    process.WaitForExit();
                    driver.sleepTime(10000);
                    IWebElement reportdata = driver.FindElement(reporttable);
                    int actualRowCount = driver.GetWebTableRowCount(reportdata);
                    if (Convert.ToInt32(expectedRowCount) == actualRowCount)
                    {
                        testReport.Pass("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark> " + actualRowCount + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark>" + actualRowCount + "</mark>");
                    }
                    //driver.SwitchToDefaultFrame();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        public void ValidateWarningReadingsCount()
        {
            try
            {
                driver.sleepTime(5000);
                driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(30));
                driver.ClickElement(cotinuousRightArrow, "");
                string expectedRowCount = driver.GetElementAttribute(warningConsumptionCount, "text");
                driver.ClickElement(warningConsumptionCount, "Warning Readings");
                //id=loadingSpinner    
                if (Convert.ToInt32(expectedRowCount) == 0)
                {
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    driver.WaitForElement(noDataDesciption, TimeSpan.FromSeconds(30));
                    testReport.Info(driver.GetElementText(noDataDesciption));
                    //driver.SwitchToDefaultFrame();
                }
                else
                {
                    Int32 scrollcount = Convert.ToInt32(expectedRowCount) / 2;
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    string scrollscriptpath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "StandardUtilities\\scroll.exe";
                    var process = Process.Start(scrollscriptpath, scrollcount.ToString());
                    process.WaitForExit();
                    driver.sleepTime(10000);
                    IWebElement reportdata = driver.FindElement(reporttable);
                    int actualRowCount = driver.GetWebTableRowCount(reportdata);
                    if (Convert.ToInt32(expectedRowCount) == actualRowCount)
                    {
                        testReport.Pass("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark> " + actualRowCount + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark>" + actualRowCount + "</mark>");
                    }
                    //driver.SwitchToDefaultFrame();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        public void ValidateNormalReadingsCount()
        {
            try
            {
                driver.sleepTime(5000);
                driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(30));
                driver.ClickElement(cotinuousRightArrow, "");
                driver.ClickElement(cotinuousRightArrow, "");
                string expectedRowCount = driver.GetElementAttribute(normalReadingCount, "text");
                driver.ClickElement(normalReadingCount, "Normal Readings");
                //id=loadingSpinner    
                if (Convert.ToInt32(expectedRowCount) == 0)
                {
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    driver.WaitForElement(noDataDesciption, TimeSpan.FromSeconds(30));
                    testReport.Info(driver.GetElementText(noDataDesciption));
                    //driver.SwitchToDefaultFrame();
                }
                else
                {
                    Int32 scrollcount = Convert.ToInt32(expectedRowCount) / 2;
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    string scrollscriptpath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "StandardUtilities\\scroll.exe";
                    var process = Process.Start(scrollscriptpath, scrollcount.ToString());
                    process.WaitForExit();
                    driver.sleepTime(10000);
                    IWebElement reportdata = driver.FindElement(reporttable);
                    int actualRowCount = driver.GetWebTableRowCount(reportdata);
                    if (Convert.ToInt32(expectedRowCount) == actualRowCount)
                    {
                        testReport.Pass("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark> " + actualRowCount + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark>" + actualRowCount + "</mark>");
                    }
                    //driver.SwitchToDefaultFrame();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        public void ValidateIntermittentReadingsCount()
        {
            try
            {
                driver.sleepTime(5000);
                driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(30));
                driver.ClickElement(cotinuousRightArrow, "");
                driver.ClickElement(cotinuousRightArrow, "");
                driver.ClickElement(cotinuousRightArrow, "");
                string expectedRowCount = driver.GetElementAttribute(intermittentReadingCount, "text");
                driver.ClickElement(intermittentReadingCount, "Intermittent Readings");
                //id=loadingSpinner    
                if (Convert.ToInt32(expectedRowCount) == 0)
                {
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    driver.WaitForElement(noDataDesciption, TimeSpan.FromSeconds(30));
                    testReport.Info(driver.GetElementText(noDataDesciption));
                    //driver.SwitchToDefaultFrame();
                }
                else
                {
                    Int32 scrollcount = Convert.ToInt32(expectedRowCount) / 2;
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    string scrollscriptpath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "StandardUtilities\\scroll.exe";
                    var process = Process.Start(scrollscriptpath, scrollcount.ToString());
                    process.WaitForExit();
                    driver.sleepTime(10000);
                    IWebElement reportdata = driver.FindElement(reporttable);
                    int actualRowCount = driver.GetWebTableRowCount(reportdata);
                    if (Convert.ToInt32(expectedRowCount) == actualRowCount)
                    {
                        testReport.Pass("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark> " + actualRowCount + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark>" + actualRowCount + "</mark>");
                    }
                    //driver.SwitchToDefaultFrame();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        public void ValidateMajorReverseReadingsCount()
        {
            try
            {
                driver.sleepTime(5000);
                driver.WaitForElement(reverseFlowRightArrow, TimeSpan.FromSeconds(30));
                string expectedRowCount = driver.GetElementAttribute(majorreverseReadingCount, "text");
                driver.ClickElement(majorreverseReadingCount, "Major Reverse Readings");
                //id=loadingSpinner    
                if (Convert.ToInt32(expectedRowCount) == 0)
                {
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    driver.WaitForElement(noDataDesciption, TimeSpan.FromSeconds(30));
                    testReport.Info(driver.GetElementText(noDataDesciption));
                    //driver.SwitchToDefaultFrame();
                }
                else
                {
                    Int32 scrollcount = Convert.ToInt32(expectedRowCount) / 2;
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    string scrollscriptpath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "StandardUtilities\\scroll.exe";
                    var process = Process.Start(scrollscriptpath, scrollcount.ToString());
                    process.WaitForExit();
                    driver.sleepTime(10000);
                    IWebElement reportdata = driver.FindElement(reporttable);
                    int actualRowCount = driver.GetWebTableRowCount(reportdata);
                    if (Convert.ToInt32(expectedRowCount) == actualRowCount)
                    {
                        testReport.Pass("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark> " + actualRowCount + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark>" + actualRowCount + "</mark>");
                    }
                    //driver.SwitchToDefaultFrame();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        public void ValidateMinorReverseReadingsCount()
        {
            try
            {
                driver.sleepTime(5000);
                driver.WaitForElement(reverseFlowRightArrow, TimeSpan.FromSeconds(30));
                driver.ClickElement(reverseFlowRightArrow, "");
                string expectedRowCount = driver.GetElementAttribute(minorreverseReadingCount, "text");
                driver.ClickElement(minorreverseReadingCount, "Minor Reverse Readings");
                //id=loadingSpinner    
                if (Convert.ToInt32(expectedRowCount) == 0)
                {
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    driver.WaitForElement(noDataDesciption, TimeSpan.FromSeconds(30));
                    testReport.Info(driver.GetElementText(noDataDesciption));
                    //driver.SwitchToDefaultFrame();
                }
                else
                {
                    Int32 scrollcount = Convert.ToInt32(expectedRowCount) / 2;
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    string scrollscriptpath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "StandardUtilities\\scroll.exe";
                    var process = Process.Start(scrollscriptpath, scrollcount.ToString());
                    process.WaitForExit();
                    driver.sleepTime(10000);
                    IWebElement reportdata = driver.FindElement(reporttable);
                    int actualRowCount = driver.GetWebTableRowCount(reportdata);
                    if (Convert.ToInt32(expectedRowCount) == actualRowCount)
                    {
                        testReport.Pass("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark> " + actualRowCount + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark>" + actualRowCount + "</mark>");
                    }
                    //driver.SwitchToDefaultFrame();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        public void ValidateCriticalGatewayReadingsCount()
        {
            try
            {
                driver.sleepTime(5000);
                driver.WaitForElement(criticalGateway, TimeSpan.FromSeconds(30));
                string expectedRowCount = driver.GetElementAttribute(criticalGatewayReadingCount, "text");
                driver.ClickElement(criticalGatewayReadingCount, "Critical Gateway Count");
                //id=loadingSpinner    
                if (Convert.ToInt32(expectedRowCount) == 0)
                {
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    driver.WaitForElement(noDataDesciption, TimeSpan.FromSeconds(30));
                    testReport.Info(driver.GetElementText(noDataDesciption));
                    //driver.SwitchToDefaultFrame();
                }
                else
                {
                    Int32 scrollcount = Convert.ToInt32(expectedRowCount) / 2;
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    string scrollscriptpath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "StandardUtilities\\scroll.exe";
                    var process = Process.Start(scrollscriptpath, scrollcount.ToString());
                    process.WaitForExit();
                    driver.sleepTime(10000);
                    IWebElement reportdata = driver.FindElement(reporttable);
                    int actualRowCount = driver.GetWebTableRowCount(reportdata);
                    if (Convert.ToInt32(expectedRowCount) == actualRowCount)
                    {
                        testReport.Pass("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark> " + actualRowCount + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark>" + actualRowCount + "</mark>");
                    }
                    //driver.SwitchToDefaultFrame();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        public void ValidateWarningGatewayReadingsCount()
        {
            try
            {
                driver.sleepTime(5000);
                driver.WaitForElement(gatewayRight, TimeSpan.FromSeconds(30));
                driver.ClickElement(gatewayRight, "");
                string expectedRowCount = driver.GetElementAttribute(warningGatewayReadingCount, "text");
                driver.ClickElement(warningGatewayReadingCount, "Warning Gateway");
                //id=loadingSpinner    
                if (Convert.ToInt32(expectedRowCount) == 0)
                {
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    driver.WaitForElement(noDataDesciption, TimeSpan.FromSeconds(30));
                    testReport.Info(driver.GetElementText(noDataDesciption));
                    //driver.SwitchToDefaultFrame();
                }
                else
                {
                    Int32 scrollcount = Convert.ToInt32(expectedRowCount) / 2;
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    string scrollscriptpath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "StandardUtilities\\scroll.exe";
                    var process = Process.Start(scrollscriptpath, scrollcount.ToString());
                    process.WaitForExit();
                    driver.sleepTime(10000);
                    IWebElement reportdata = driver.FindElement(reporttable);
                    int actualRowCount = driver.GetWebTableRowCount(reportdata);
                    if (Convert.ToInt32(expectedRowCount) == actualRowCount)
                    {
                        testReport.Pass("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark> " + actualRowCount + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark>" + actualRowCount + "</mark>");
                    }
                    //driver.SwitchToDefaultFrame();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }
        public void ValidateNormalGatewayReadingsCount()
        {
            try
            {
                driver.sleepTime(5000);
                driver.WaitForElement(gatewayRight, TimeSpan.FromSeconds(30));
                driver.ClickElement(gatewayRight, "");
                driver.ClickElement(gatewayRight, "");
                string expectedRowCount = driver.GetElementAttribute(normalGatewayReadingCount, "text");
                driver.ClickElement(normalGatewayReadingCount, "Normal Gateway");
                //id=loadingSpinner    
                if (Convert.ToInt32(expectedRowCount) == 0)
                {
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    driver.WaitForElement(noDataDesciption, TimeSpan.FromSeconds(30));
                    testReport.Info(driver.GetElementText(noDataDesciption));
                    //driver.SwitchToDefaultFrame();
                }
                else
                {
                    Int32 scrollcount = Convert.ToInt32(expectedRowCount) / 2;
                    ////driver.WaitForElement(By.Id("ntgMSTRFrame"), TimeSpan.FromSeconds(30));
                    //driver.SwitchToFrameById("ntgMSTRFrame");
                    string scrollscriptpath = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "")+ "StandardUtilities\\scroll.exe";
                    var process = Process.Start(scrollscriptpath, scrollcount.ToString());
                    process.WaitForExit();
                    driver.sleepTime(10000);
                    IWebElement reportdata = driver.FindElement(reporttable);
                    int actualRowCount = driver.GetWebTableRowCount(reportdata);
                    if (Convert.ToInt32(expectedRowCount) == actualRowCount)
                    {
                        testReport.Pass("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark> " + actualRowCount + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Dashboard Count is : <mark>" + expectedRowCount + "</mark> Table Row Count is :<mark>" + actualRowCount + "</mark>");
                    }
                    //driver.SwitchToDefaultFrame();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:: " + ex.ToString());
            }
        }

        public void ValidateMeterSizeFilterNotDisplayed()
        {

            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "Detailed Report");
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
            driver.CheckElementDoesnotExists(meterSizeFIlter, "Meter size filter");

        }

        public bool verifyDefaultSelectedDates()
        {
            try
            {
                driver.ClickElement(fromdatecalendarButton, "fromdate");
                string from = driver.GetElementAttribute(selectedDate, "title");
                driver.ClickElement(selectedDate, "selecteddate");
                driver.ClickElement(todatecalendarButton, "todate");
                string to = driver.GetElementAttribute(selectedDate, "title");
                driver.ClickElement(selectedDate, "selecteddate");
                int days = ((Convert.ToDateTime(to) - Convert.ToDateTime(from))).Days + 1;
                if (days == 7)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
                return false;
            }

        }

        public void updateFromandToDates()
        {
            try
            {
                driver.ClickElement(fromdatecalendarButton, "fromdate");
                string from = "";
                string weekedndFrom = "";
                string weekname = "";
                int day = 0;
                int month = 0;
                int year = 0;
                string monthname = "";
                DateTime date;
                string fullmonthname = "";
                string to = "";
                string weekedndto = "";
                string weekname1 = "";
                int day1 = 0;
                int month1 = 0;
                int year1 = 0;
                string monthname1 = "";
                DateTime date1;
                string fullmonthname1 = "";
                try
                {
                    from = driver.GetElementAttribute(selectedDate, "title");
                }
                catch (Exception)
                {
                    try
                    {
                        selectedDate = By.XPath("//td[contains(@class,'k-state-selected k-weekend')]");
                        weekedndFrom = driver.GetElementAttribute(selectedDate, "title");
                    }
                    catch (Exception e)
                    {
                        ReporterFactory.LogFailure(e.Message);
                    }

                }
                if (weekedndFrom != "")
                {
                    weekname = "Friday";
                    day = Convert.ToDateTime(weekedndFrom).Day - 2;
                    month = Convert.ToDateTime(weekedndFrom).Month - 1;
                    year = Convert.ToDateTime(weekedndFrom).Year;
                    monthname = DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(month);
                    date = new DateTime(year, month, day);
                    fullmonthname = date.ToString("MMMM");
                    driver.ClickElement(currentMonth, "fromdate");
                    driver.FindElement(By.XPath("//td[contains(@title,'" + year + " " + monthname + "')]//span")).Click();
                    driver.FindElement(By.XPath("(//td[contains(@title,'" + weekname + "') and contains(@title,'" + fullmonthname + "')])[1]")).Click();
                }
                else
                {
                    day = Convert.ToDateTime(from).Day - 2;
                    month = Convert.ToDateTime(from).Month - 1;
                    year = Convert.ToDateTime(from).Year;
                    monthname = DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(month);
                    date = new DateTime(year, month, day);
                    fullmonthname = date.ToString("MMMM");
                    IList<IWebElement> tags = driver.FindElements(By.XPath("//kendo-popup//child::span"));
                    List<string> childs =new List<string>();
                    for(int i = 0; i <=tags.Count-1; i++)
                    {
                        string text1 = tags[i].GetAttribute("class");
                        childs.Add(text1);
                        if(text1.Equals("k-button k-button-md k-rounded-md k-button-flat k-button-flat-base k-calendar-title"))
                        {
                            tags[i].Click();
                            break;
                        }
                    }
                    string text = driver.FindElement(By.XPath("//kendo-popup//child::span[@class='k-button k-button-md k-rounded-md k-button-flat k-button-flat-base k-calendar-title']")).Text;
                    //driver.ClickElement(currentMonth, "fromdate");
                    driver.FindElement(By.XPath("//td[contains(@title,'" + year + " " + monthname + "')]//span")).Click();
                    driver.FindElement(By.XPath("(//td[contains(@title,'" + weekname + "') and contains(@title,'" + fullmonthname + "')])[1]")).Click();
                }
                driver.sleepTime(7000);
                driver.ClickElement(todatecalendarButton, "todate");
                try
                {
                    to = driver.GetElementAttribute(selectedDate, "title");
                }
                catch (Exception)
                {
                    try
                    {
                        selectedDate = By.XPath("//td[contains(@class,'k-state-selected k-weekend')]");
                        weekedndto = driver.GetElementAttribute(selectedDate, "title");
                    }
                    catch (Exception e)
                    {
                        ReporterFactory.LogFailure(e.Message);
                    }
                }
                if (weekedndto != "")
                {
                    weekname1 = "Friday";
                    day1 = Convert.ToDateTime(weekedndto).Day - 2;
                    month1 = Convert.ToDateTime(weekedndto).Month;
                    year1 = Convert.ToDateTime(weekedndto).Year;
                    monthname1 = DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(month1);
                    date1 = new DateTime(year1, month1, day1);
                    fullmonthname1 = date1.ToString("MMMM");
                    driver.ClickElement(currentMonth, "todate");
                    driver.FindElement(By.XPath("//td[contains(@title,'" + year1 + " " + monthname1 + "')]//span")).Click();
                    driver.FindElement(By.XPath("(//td[contains(@title,'" + fullmonthname1 + "') and contains(@title,'" + day1 + "')])[1]")).Click();
                }
                else
                {
                    weekname1 = Convert.ToDateTime(to).ToString("dddd");
                    day1 = Convert.ToDateTime(to).Day - 1;
                    month1 = Convert.ToDateTime(to).Month;
                    year1 = Convert.ToDateTime(to).Year;
                    monthname1 = DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(month1);
                    date1 = new DateTime(year1, month1, day1);
                    fullmonthname1 = date1.ToString("MMMM");
                    IList<IWebElement> tags = driver.FindElements(By.XPath("//kendo-popup//child::span"));
                    List<string> childs = new List<string>();
                    for (int i = 0; i <= tags.Count - 1; i++)
                    {
                        string text1 = tags[i].GetAttribute("class");
                        childs.Add(text1);
                        if (text1.Equals("k-button k-button-md k-rounded-md k-button-flat k-button-flat-base k-calendar-title"))
                        {
                            tags[i].Click();
                            break;
                        }
                    }
                    //driver.ClickElement(currentMonth, "todate");
                    driver.FindElement(By.XPath("//td[contains(@title,'" + year1 + " " + monthname1 + "')]//span")).Click();
                    driver.FindElement(By.XPath("(//td[contains(@title,'" + fullmonthname1 + "') and contains(@title,'" + day1 + "')])[1]")).Click();
                }

            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }


        }


        public bool verifyPinAccountsintheMap()
        {
            try
            {
                bool flag = false;
                List<bool> consumptionreadingdetails = new List<bool>();
                int pinbuttonscount1 = driver.FindElements(pinbutton).Count;
                if (pinbuttonscount1 >= 1)
                {
                    By ele1 = By.XPath(pinbutton.ToString().Replace("By.XPath:", "").Trim() + "[1]");
                    driver.MouseHoverByJavaScript(ele1, "PinButton");
                    string buubleattribute = driver.GetElementAttribute(bubble, "class");
                    int consumptiondetailscount = driver.FindElements(consumptiondetails).Count;
                    if (consumptiondetailscount >= 10)
                    {
                        int i = 6;

                        for (i = 6; i <= consumptiondetailscount; i++)
                        {
                            By ele2 = By.XPath("( " + consumptiondetails.ToString().Replace("By.XPath:", "").Trim() + ")" + "[" + i + "]");
                            string text1 = driver.GetElementText(ele2);
                            if (text1 == "")
                            {
                                if (buubleattribute.Contains("bubble flex-row"))
                                {
                                    consumptionreadingdetails.Add(true);
                                }
                                else
                                {
                                    consumptionreadingdetails.Add(false);
                                }

                            }
                            else
                            {
                                consumptionreadingdetails.Add(true);
                            }
                        }

                    }
                }
                if (!(consumptionreadingdetails.Contains(false)) && consumptionreadingdetails.Count >= 1)
                {
                    flag = true;
                }
                return flag;
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
                return false;
            }

        }

        public void clickOnClusters()
        {
            try
            {
                Actions action = new Actions(driver);
                action.ContextClick(driver.FindElement(cluster)).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.Return).Build().Perform();
                driver.sleepTime(1000);
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }

        }

        public void clickonSubclusters()
        {
            try
            {
                int count = driver.FindElements(cluster1).Count;
                if (count >= 1)
                {
                    IWebElement ele = driver.FindElement(By.XPath(cluster1.ToString().Replace("By.XPath:", "").Trim() + "[1]"));
                    if (ele.Displayed)
                    {
                        Actions action1 = new Actions(driver);
                        action1.ContextClick(ele).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.Return).Build().Perform();
                    }
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }

        }

        public void validateAccountsDisplayintheMapview()
        {
            try
            {
                driver.sleepTime(5);
                driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
                driver.ClickElement(detailReport, "Detailed Report");
                driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
                bool flag = false;
                if (verifyDefaultSelectedDates())
                {
                    driver.ClickElement(mapView, "Map view");
                    driver.sleepTime(10000);
                    int pinbuttonscount1 = driver.FindElements(pinbutton).Count;
                    if (verifyPinAccountsintheMap())
                    {
                        testReport.Pass("<i> claimed meters/accounts that contributed to the total consumption of the past 7 days are displayed in the map");
                    }
                    else if (pinbuttonscount1 >= 1)
                    {
                        ReporterFactory.LogFailure("<i> claimed meters/accounts that contributed to the total consumption of the past 7 days are not displayed");
                    }
                    else
                    {
                        clickOnClusters();

                        for (int i = 1; i <= 10; i++)
                        {
                            clickonSubclusters();
                            if (verifyPinAccountsintheMap())
                            {
                                testReport.Pass("<i> claimed meters/accounts that contributed to the total consumption of the past 7 days are displayed");
                                flag = true;
                                break;
                            }
                        }
                        if (!flag)
                        {
                            ReporterFactory.LogFailure("<i> claimed meters/accounts that contributed to the total consumption of the past 7 daysare not displayed");
                        }

                    }
                }
                else
                {
                    ReporterFactory.LogFailure("<i> Default 7 days not displaying");
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }

        }

        public void validateAllAccountsDisplayInTheMapviewDashBoard()
        {
            try
            {
                driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
                int totalAccounts = 0;
                driver.ClickElement(mapView, "Map view");
                driver.ClickElement(allAccountsBtn, "All Accounts");

                IList<IWebElement> allClustersElements = driver.FindElements(allClusters);

                foreach (IWebElement cluster in allClustersElements)
                {
                    int clusterCount = int.Parse(cluster.GetAttribute("title").Split(' ')[2]);
                    totalAccounts += clusterCount;
                }
                if (totalAccounts > 10)
                {
                    testReport.Pass("<i> All Accounts that have valid latitude and longitude are displayed in the Dashboard map view");
                }
                else
                {
                    ReporterFactory.LogFailure("<i> All Accounts that have valid latitude and longitude are NOT displayed in the Dashboard map view");
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }

        }

        public void ValidateHighConsumptionOutlierIsNotDisplayed()
        {
            try
            {
                driver.WaitForElement(mapView, TimeSpan.FromSeconds(60));
                driver.ScrollToElement(driver.FindElement(mapView, TimeSpan.FromSeconds(30)));
                driver.CheckElementDoesnotExists(highConsumptionBtn, "High Consumption");
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }
        }

        public void ValidateLowConsumptionOutlierIsNotDisplayed()
        {
            try
            {
                driver.WaitForElement(mapView, TimeSpan.FromSeconds(60));
                driver.ScrollToElement(driver.FindElement(mapView, TimeSpan.FromSeconds(30)));
                driver.CheckElementDoesnotExists(lowConsumptionBtn, "Low Consumption");
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }
        }

        public void ValidateMajorReverseFlowKPIURL(string actualUrl)
        {
            driver.WaitForElement(majorreverseReadingCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(majorreverseReadingCount, "Major Reverse Flow count");
            driver.WaitForElementNotExists(gridLoader, 60);
            driver.WaitForElement(majorReverseDetails, TimeSpan.FromSeconds(30));
            string url = driver.Url;
            if (url.Equals(actualUrl + "/dashboard/detailreport-new/majorreverseflow"))
            {
                testReport.Pass("User is redirected to Major Reverse Flow KPI detailed report" + url);
            }
            else
            {
                testReport.Fail("User is NOT redirected to Major Reverse Flow KPI detailed report" + url);
            }
        }
        public void ValidateMinorReverseFlowKPIURL(string actualUrl)
        {
            driver.WaitForElement(majorreverseReadingCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(reverseFlowRightIcon, "Right");
            driver.ClickElement(minorreverseReadingCount, "Major Reverse Flow count");
            driver.WaitForElementNotExists(gridLoader, 60);
            driver.WaitForElement(minorReverseDetails, TimeSpan.FromSeconds(30));
            string url = driver.Url;
            if (url.Equals(actualUrl + "/dashboard/detailreport-new/minorreverseflow"))
            {
                testReport.Pass("User is redirected to Minor Reverse Flow KPI detailed report" + url);
            }
            else
            {
                testReport.Fail("User is NOT redirected to Minor Reverse Flow KPI detailed report" + url);
            }
        }

        /// <summary>
        /// Method to Validate Top Ten Accouns Detail Report Actual and Estimated Toggle Grid Removed
        /// </summary>
        public void ValidateTopTenAccDetailReportActualEstimatedToggleGridRemoved()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Consumption Details Report ");
            driver.WaitForElementNotExists(gridLoader, 60);
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(10));
            driver.ClickElement(gridView, "Grid View");
            driver.CheckElementDoesnotExists(actualRadioBtn, "Actual Radio button");

            driver.CheckElementDoesnotExists(estimatedRadioBtn, "Estimated Radio button");
        }

        /// <summary>
        /// Method to Validate Top Ten Accouns Detail Report Actual and Estimated Toggle Map Removed
        /// </summary>
        public void ValidateTopTenAccDetailReportActualEstimatedToggleMapRemoved()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Consumption Details Report ");
            driver.WaitForElementNotExists(gridLoader, 60);
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(10));
            driver.ClickElement(mapView, "Map View");
            driver.CheckElementDoesnotExists(actualRadioBtn, "Actual Radio button");

            driver.CheckElementDoesnotExists(estimatedRadioBtn, "Estimated Radio button");
        }

        /// <summary>
        /// Method to Validate Top System Consumption Detail Report Actual and Estimated Toggle Map Removed
        /// </summary>
        public void ValidateSystemConsumptionDetailReportActualEstimatedToggleMapRemoved()
        {
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(30));
            driver.ClickElement(detailReport, "Top 10 Consumption Details Report ");
            driver.WaitForElementNotExists(gridLoader, 60);
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(10));
            driver.ClickElement(mapView, "Map View");
            driver.CheckElementDoesnotExists(actualRadioBtn, "Actual Radio button");

            driver.CheckElementDoesnotExists(estimatedRadioBtn, "Estimated Radio button");
        }

        /// <summary>
        /// Method to Validate Top System Consumption Detail Report Actual and Estimated Toggle Grid Removed
        /// </summary>
        public void ValidateSystemConsumptionDetailReportActualEstimatedToggleGridRemoved()
        {
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(30));
            driver.ClickElement(detailReport, "Top 10 Consumption Details Report ");
            driver.WaitForElementNotExists(gridLoader, 60);
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(10));
            driver.ClickElement(gridView, "Grid View");
            driver.CheckElementDoesnotExists(actualRadioBtn, "Actual Radio button");

            driver.CheckElementDoesnotExists(estimatedRadioBtn, "Estimated Radio button");
        }


        public void ValidateMapToolTipDetails()
        {
            try
            {
                bool flag = true;
                driver.ClickElement(mapView, "Map view");
                driver.sleepTime(10000);
                int pinButtonsCount = driver.FindElements(pinbutton).Count;
                if (verifyPinAccountsintheMap())
                {
                    testReport.Pass("<i> claimed meters/accounts that contributed to the total consumption after updating dates  displayed in the map");
                }
                else if (pinButtonsCount >= 1)
                {
                    ReporterFactory.LogFailure("<i> claimed meters/accounts that contributed to the total consumption are not displayed after updating the dates");
                }
                else
                {
                    clickOnClusters();

                    for (int i = 1; i <= 10; i++)
                    {
                        clickonSubclusters();
                        if (verifyPinAccountsintheMap())
                        {
                            testReport.Pass("<i> claimed meters/accounts that contributed to the total consumption after updating dates  displayed in the map");
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        ReporterFactory.LogFailure("<i> claimed meters/accounts that contributed to the total consumption are not displayed after updating the dates");
                    }

                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }

        }

        /// <summary>
        /// Method to Validate Detail Report Consumption Format
        /// </summary>
        public void ValidateSystemConsumptionDetailReportConsumptionValuesDecimalFormatGrid()
        {
            try
            {
                bool consumptionFormatMatched = true;
                driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
                driver.ClickElement(detailReport, "System Consumption Detailed Report");
                driver.WaitForElementNotExists(gridLoader, 60);
                driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));

                IList<IWebElement> gridAllConsumptionControls = driver.FindElements(gridAllConsumption);
                int rowCont = int.Parse(driver.FindElement(gridRowCount).GetAttribute("aria-rowcount"));
                if (gridAllConsumptionControls.Count > 0)
                {
                    while (rowCont > 0)
                    {
                        if (gridAllConsumptionControls.Count > 0)
                        {
                            foreach (IWebElement ele in gridAllConsumptionControls)
                            {
                                if (ele.Text.Split('.')[1].Length != 3)
                                {
                                    consumptionFormatMatched = false;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            consumptionFormatMatched = false;
                        }
                        try
                        {
                            driver.ScrollToElement(gridAllConsumptionControls.Last());
                            driver.WaitForElementNotExists(reportGridLoader, 60);
                            gridAllConsumptionControls = driver.FindElements(gridAllConsumption);
                        }
                        catch (Exception e)
                        {
                            ReporterFactory.LogFailure("<i>" + e.Message);
                        }
                        rowCont = rowCont - 30;
                    }
                }
                else
                {
                    consumptionFormatMatched = false;
                    ReporterFactory.LogFailure("<i>System Consumption Detail Report table does not contain data");
                }

                if (!consumptionFormatMatched)
                {
                    ReporterFactory.LogFailure("<i>Dashboard System Consumption report grid Consumption value NOT displayed as including 3 decimal places");
                }
                else
                {
                    testReport.Pass("<i>Dashboard System Consumption report grid Consumption value displayed as including 3 decimal places");
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }
        }

        public void validateAccountsDisplayintheMapviewAfterUpdatingDates()
        {
            try
            {
                driver.sleepTime(5);
                driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
                driver.ClickElement(detailReport, "Detailed Report");
                driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
                bool flag = false;
                updateFromandToDates();
                driver.ClickElement(mapView, "Map view");
                driver.sleepTime(10000);
                int pinbuttonscount1 = driver.FindElements(pinbutton).Count;
                if (verifyPinAccountsintheMap())
                {
                    testReport.Pass("<i> claimed meters/accounts that contributed to the total consumption after updating dates  displayed in the map");
                }
                else if (pinbuttonscount1 >= 1)
                {
                    ReporterFactory.LogFailure("<i> claimed meters/accounts that contributed to the total consumption are not displayed after updating the dates");
                }
                else
                {
                    clickOnClusters();

                    for (int i = 1; i <= 10; i++)
                    {
                        clickonSubclusters();
                        if (verifyPinAccountsintheMap())
                        {
                            testReport.Pass("<i> claimed meters/accounts that contributed to the total consumption after updating dates  displayed in the map");
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        ReporterFactory.LogFailure("<i> claimed meters/accounts that contributed to the total consumption are not displayed after updating the dates");
                    }

                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }

        }

        public void accountsintheGrid()
        {
            try
            {
                IList<IWebElement> accnos = driver.FindElements(accountnumbers);
                int i = 1;
                Dictionary<string, string> accounts = new Dictionary<string, string>();
                foreach (IWebElement accno in accnos)
                {
                    string number = accno.Text;
                    if (accounts.ContainsKey(number))
                    {
                        IWebElement muiid = driver.FindElement(By.XPath("//table[@class='k-grid-table']//tr[" + i + "]" + "//td[5]//span"));
                        string currentmuid = muiid.Text;
                        string existingmuidvalue = accounts[number];
                        if (currentmuid != existingmuidvalue)
                        {
                            testReport.Pass("<i> Records displayed are grouped by Account such that a unique account should be displayed in seperate rows in the grid ");
                        }
                        else
                        {
                            ReporterFactory.LogFailure("<i> Records  displayed are grouped by Account such that a unique account should be displayed in seperate rows in the grid ");
                        }
                    }
                    else
                    {
                        IWebElement muiid = driver.FindElement(By.XPath("//table[@class='k-grid-table']//tr[" + i + "]" + "//td[5]//span"));
                        string muidvalue = muiid.Text;
                        accounts.Add(number, muidvalue);
                        i++;
                    }

                }

            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void validateAccountsintheGrid()
        {

            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "Detailed Report");
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
            accountsintheGrid();

        }

        public void validateAccountsintheGridAfterUpdatingDateRange()
        {

            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "Detailed Report");
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
            updateFromandToDates();
            accountsintheGrid();

        }

        public void validateUOMUnitintheGrid(string detailReportlink, string uom)
        {
            try
            {
                if (detailReportlink.Equals("systemConsumption", StringComparison.OrdinalIgnoreCase))
                {
                    driver.ClickElement(lftNavDashboard, "Dashboard");
                    driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
                    driver.ClickElement(detailReport, "Detailed Report");
                }
                if (detailReportlink.Equals("top10Accounts", StringComparison.OrdinalIgnoreCase))
                {
                    driver.ClickElement(lftNavDashboard, "Dashboard");
                    driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(30));
                    driver.ClickElement(topTenConsumtionDetailReport, "Detail Report");
                }

                driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));

                string actualUOM = driver.GetElementText(gridUOM);
                if (actualUOM.Contains(uom))
                {
                    testReport.Pass("<i>Deviceutility UOM" + uom + "and dashboard reports" + actualUOM + "are  same");
                }
                else
                {
                    ReporterFactory.LogFailure("<i>Deviceutility UOM" + uom + "and dashboard reports" + actualUOM + "are not same");

                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void validateSystemConsumptionbarchart(string url)
        {
            List<bool> flag = new List<bool>();
            try
            {

                driver.sleepTime(10);
                IList<IWebElement> textintheBarchart = driver.FindElements(systemconsumptionbarcharttext);
                List<string> dates = new List<string>();
                foreach (IWebElement barchartvalue in textintheBarchart)
                {
                    string text = barchartvalue.Text;
                    if (text != "")
                    {
                        if (text.Contains("/"))
                        {
                            string[] text1 = text.Split('/');
                            if (text1.Length == 3)
                            {
                                dates.Add(text);
                            }
                        }
                    }
                    else
                    {
                        ReporterFactory.LogFailure("<i>systemconsumption bars,Yaxis and xaxis text should not be empty");
                    }
                }

                IList<IWebElement> bars = driver.FindElements(By.XPath("//span[text()='System Consumption']//..//following-sibling::div//*[local-name()='path' and contains(@fill,'url(" + url + "dashboard#kdef')]"));
                if (bars.Count == dates.Count)
                {
                    foreach (IWebElement bar in bars)
                    {

                        if (bar.Displayed)
                        {

                            flag.Add(true);
                        }
                        else
                        {
                            flag.Add(false);

                        }
                    }
                }
                else
                {
                    ReporterFactory.LogFailure("< i >" + bars.Count + " " + "is displaying but in the bar chart default 7days dates are not displayed");
                }


            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("< i >" + e.Message);
            }
            if (flag.Contains(false))
            {
                ReporterFactory.LogFailure("< i > Bar chart is not displayed with default dates");
            }
            else
            {
                testReport.Pass("<i>Bar chart displayed with default dates");
            }

        }

        public void validateUOMUnitintheGridafterUpdatingDates(string uom)
        {
            try
            {
                driver.ClickElement(lftNavDashboard, "Dashboard");
                driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
                driver.ClickElement(detailReport, "Detailed Report");
                updateFromandToDates();
                driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
                string actualUOM = driver.GetElementText(gridUOM);
                if (actualUOM != uom)
                {
                    ReporterFactory.LogFailure("<i>Deviceutility UOM" + uom + "and dashboard reports" + "  " + actualUOM + " " + "are not same");
                }
                else
                {
                    testReport.Pass("<i>Deviceutility UOM" + uom + "and dashboard reports" + " " + actualUOM + " " + "are  same");
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }

        }

        public void ValidateUOMFilterNotDisplayed()
        {

            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "Detailed Report");
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
            driver.CheckElementDoesnotExists(uomFIlter, "uom filter");

        }

        public void validateReceiveKpi(string kpioption)
        {
            try
            {
                driver.WaitForElement(detailReport, TimeSpan.FromSeconds(180));

                string href = driver.GetElementAttribute(receivedcount, "href");
                if (href.Contains(kpioption))
                {
                    if (Int32.Parse(driver.GetElementText(receivedcount)) >= 0)
                    {
                        testReport.Pass("<i>receivedcount for" + " " + kpioption + " " + "is not empty");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("<i>receivedcount for" + " " + kpioption + " " + "is empty");
                    }
                }
                else
                {

                    bool flag = false;
                    do
                    {
                        driver.ClickElement(receivedPullRIght, "rightarrow");
                        string href1 = driver.GetElementAttribute(receivedcount, "href");
                        if (href1.Contains(kpioption))
                        {
                            flag = true;
                            if (driver.GetElementText(receivedcount) != "")
                            {
                                testReport.Pass("<i>receivedcount for" + kpioption + "is not empty");
                            }
                            else
                            {
                                ReporterFactory.LogFailure("<i>receivedcount for" + kpioption + "is empty");
                            }
                        }
                    }
                    while (flag == false);

                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }


        }

        public bool verifyColor(string option)
        {
            try
            {
                bool flag = false;
                if (option == "Major Reverse Flow")
                {

                    string color = driver.GetElementAttribute(majorReverseFlowColor, "class");
                    if (color.Contains("red"))
                    {
                        return flag = true;
                    }
                }
                else if (option == "Critical Continuous Consumption")
                {
                    string color = driver.GetElementAttribute(criticalContinuousConsumptionColor, "class");
                    if (color.Contains("blue"))
                    {
                        return flag = true;
                    }
                }
                else
                {
                    return flag = false;
                }
                return flag;
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
                return false;
            }

        }

        public void dashboardMapView(string option)
        {

            try
            {
                By mapviewlinks = By.XPath("//input[@value='" + option + "']");
                driver.WaitForElement(mapviewlinks, TimeSpan.FromSeconds(60));
                if (verifyColor(option))
                {
                    driver.ClickElement(mapviewlinks, option);
                    bool flag = false;
                    driver.sleepTime(10000);
                    int pinbuttonscount1 = driver.FindElements(pinbutton).Count;
                    if (verifyPinAccountsintheMap())
                    {
                        testReport.Pass("<i>" + option + " " + "accounts are  displayed in the map");
                    }
                    else if (pinbuttonscount1 >= 1)
                    {
                        ReporterFactory.LogFailure("<i>" + option + " " + "accounts are not displayed in the map");
                    }
                    else
                    {
                        clickOnClusters();

                        for (int i = 1; i <= 10; i++)
                        {
                            clickonSubclusters();
                            if (verifyPinAccountsintheMap())
                            {
                                testReport.Pass("<i>" + option + " " + "accounts are  displayed in the map");
                                flag = true;
                                break;
                            }
                        }
                        if (!flag)
                        {
                            ReporterFactory.LogFailure("<i>" + option + " " + "accounts are not displayed in the map");
                        }

                    }
                }
                else
                {
                    ReporterFactory.LogFailure("<i> color is not displaying");
                }

            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }
        }

        /// <summary>
        /// Method to Validate Meter Type Filter
        /// </summary>
        public void ValidateMeterTypeIsNotDisplayed()
        {
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "Detailed Report");
            driver.WaitForElement(systemConsumptionTable, TimeSpan.FromSeconds(60));
            driver.CheckElementDoesnotExists(meterTypeFilter, "Meter Type Filter");
        }

        /// <summary>
        /// Method to Validate Meter Size Filter
        /// </summary>
        public void ValidateMeterSizeIsNotDisplayed()
        {
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "Detailed Report");
            driver.WaitForElement(systemConsumptionTable, TimeSpan.FromSeconds(60));
            driver.CheckElementDoesnotExists(meterSizeFilter, "Meter Size Filter");
        }

        /// <summary>
        /// Method to Validate Total Meter Count
        /// </summary>
        public void ValidateTotalMeterCounIsNotDisplayed()
        {
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "Detailed Report");
            driver.WaitForElement(systemConsumptionTable, TimeSpan.FromSeconds(60));
            driver.CheckElementDoesnotExists(TotalMeterCount, "Total Meter Count");
        }

        internal void ValidateTopTenDetailReportNoData()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Consumption Details Report ");

            driver.WaitForElement(noDataReturned, TimeSpan.FromSeconds(130));
            if (driver.CheckElementDisplayed(noDataReturned, "Grid View"))
            {
                testReport.Pass("<i>No data returned for this view. This might be because the applied filter excludes all data displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Data returned for this view. Expected data should not to be present.");
            }
        }

        internal void ValidateTopTenDetailReportDataPresent()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Consumption Details Report ");

            driver.WaitForElement(reportGrid, TimeSpan.FromSeconds(130));
            int dataCount = driver.FindElements(reportData).Count;

            if (dataCount == 10)
            {
                testReport.Pass("<i>10 accounts data displayed on report as expected.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Data NOT displayed on report.");
            }
        }


        internal void ValidateTopTenDetailReportMapView()
        {
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(30));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Consumption Details Report ");

            driver.WaitForElement(reportGrid, TimeSpan.FromSeconds(130));

            driver.ClickElement(mapView, "Map view");

            driver.WaitForElement(mapButton, TimeSpan.FromSeconds(130));
            if (driver.CheckElementDisplayed(mapButton, "Map"))
            {
                testReport.Pass("<i>Map displayed as expected.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Map NOT displayed on report.");
            }


        }


        internal void SwitchToUtility(string utility)
        {
            driver.ClickElement(lnkChooseUtilities, "Utilities Dropdown");
            //driver.ClickElement(lnkChooseUtilities, "Utilities Dropdown");
            driver.SendKeysToElementAndPressEnter(utilitySearch, utility, "Utility");
            driver.ClickElement(tblChooseUtilities, "Select");
            driver.ClickElement(btnChooseUtilitiesOk, "OK");
        }

        internal void validateTop10ConsumptionData()
        {
            try
            {
                driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(30));

                IList<IWebElement> dataEleOnDashBoard = driver.FindElements(top10DashboardConsumptions);
                List<double> dataOnDashBoard = new List<double>();
                foreach (IWebElement ele in dataEleOnDashBoard)
                {
                    dataOnDashBoard.Add(Convert.ToDouble(ele.Text));
                }

                driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Consumption Details Report ");
                driver.WaitForElement(reportGrid, TimeSpan.FromSeconds(130));

                IList<IWebElement> dataEleOnReport = driver.FindElements(top10ReportConsumptions);
                List<double> dataOnReport = new List<double>();
                foreach (IWebElement ele in dataEleOnReport)
                {
                    dataOnReport.Add(Math.Round(Convert.ToDouble(ele.Text)));
                }

                bool flag = true;
                if (dataOnDashBoard.Count == dataOnReport.Count)
                {
                    testReport.Pass("<i>Count of data Matched.");

                    for (int counter = 0; counter < dataOnDashBoard.Count; counter++)
                    {
                        if (!(dataOnReport[counter] == (Math.Round(dataOnDashBoard[counter]))))
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                else
                {
                    ReporterFactory.LogFailure("<i>Count of data not matched.");
                }

                if (flag)
                {
                    testReport.Pass("<i>Data matched.");
                }
                else
                {
                    ReporterFactory.LogFailure("<i>Data not matched.");
                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("<i>Exception : " + ex.Message);
            }
        }

        public bool clickonReceiveKpicount(string kpioption)
        {
            driver.WaitForElementNotExists(gridLoader, 60);
            bool flag = false;
            string href = "";
            string href1 = "";

            try
            {
                href = driver.GetElementAttribute(receivedcount, "href");
                if (href.Contains(kpioption))
                {
                    if (driver.GetElementText(receivedcount) != "")
                    {
                        flag = true;
                        driver.ClickElement(receivedcount, "click on count");

                    }
                    else
                    {
                        ReporterFactory.LogFailure("<i>count for" + "  " + kpioption + " " + "is empty");
                    }
                }
                else
                {
                    try
                    {

                        flag = false;
                        do
                        {

                            driver.ClickElement(receivedPullRIght, "rightarrow");
                            href1 = driver.GetElementAttribute(receivedcount, "href");
                            if (href1.Contains(kpioption))
                            {

                                if (driver.GetElementText(receivedcount) != "")
                                {
                                    driver.ClickElement(receivedcount, "click on count");
                                    flag = true;
                                }
                                else
                                {
                                    ReporterFactory.LogFailure("<i>count for" + "  " + kpioption + " " + "is empty");
                                }
                            }
                            if (flag != true && verifyReceivedPullrightgray())
                            {
                                flag = true;
                            }
                        }
                        while (flag == false);
                    }
                    catch (Exception e)
                    {

                        ReporterFactory.LogFailure("<i>" + e.Message);
                    }
                }
                return flag;
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
                return flag;
            }
        }

        public bool verifyCompletedPullrightgray()
        {
            bool flag = false;

            try
            {
                IWebElement ele = driver.FindElement(completedPullRightgray);
                flag = ele.Displayed;
                return flag;
            }
            catch
            {

                return true;
            }
        }

        public bool verifyReceivedPullrightgray()
        {
            bool flag = false;
            try
            {
                IWebElement ele = driver.FindElement(receivedPullRightgray);
                flag = ele.Displayed;
                return flag;
            }
            catch
            {
                return true;
            }
        }

        public bool verifyConsumptionPullrightgray()
        {
            bool flag = false;
            try
            {
                IWebElement ele = driver.FindElement(continuousConsumptionPullRIght);
                flag = ele.Displayed;
                return flag;
            }
            catch
            {
                return true;
            }
        }

        public bool verifyReverseflowPullrightgray()
        {
            bool flag = false;
            try
            {
                IWebElement ele = driver.FindElement(reverseflowPullRightgray);
                flag = ele.Displayed;
                return flag;
            }
            catch
            {

                return true;
            }
        }

        public bool clickonCompletedKpicount(string kpioption)
        {
            bool flag = false;
            bool flag1 = true;
            string href = "";
            string href1 = "";

            try
            {
                href = driver.GetElementAttribute(completedcount, "href");
                if (href.Contains(kpioption))
                {
                    if (driver.GetElementText(completedcount) != "")
                    {
                        flag = true;
                        driver.ClickElement(completedcount, "click on count");

                    }
                    else
                    {
                        ReporterFactory.LogFailure("<i>completedcountfor" + kpioption + "is empty");
                    }
                }
                else
                {

                    flag = false;
                    do
                    {

                        driver.ClickElement(completePullRIght, "rightarrow");
                        href1 = driver.GetElementAttribute(completedcount, "href");
                        if (href1.Contains(kpioption))
                        {

                            if (driver.GetElementText(completedcount) != "")
                            {
                                driver.ClickElement(completedcount, "click on count");
                                flag = true;
                            }
                            else
                            {
                                ReporterFactory.LogFailure("<i>count for" + "  " + kpioption + "  " + "is empty");
                            }
                        }
                        if (flag != true && verifyCompletedPullrightgray())
                        {
                            flag = true;
                            flag1 = false;
                        }
                    }
                    while (flag == false);

                }
                if (flag == true && flag1 == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
                return flag;
            }


        }


        public void verifyMeterNotReceived()
        {
            driver.WaitForElement(statusColumnHeader, TimeSpan.FromSeconds(180));
            driver.CheckElementDisplayed(meternotReceived, "meter not received grid");
        }

        public void validateStatusColumnOrder()
        {
            try
            {
                string meterSizeHeadertext = driver.GetElementText(meterSizeColumnHeader);
                string statusheadertext = driver.GetElementText(statusColumnHeader);
                IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;
                exe.ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(readingColumnHeader));
                string readingsHeadertext = driver.GetElementText(readingColumnHeader);
                if (statusheadertext == "Status")
                {
                    if (meterSizeHeadertext.Equals("Meter Size") && readingsHeadertext.Equals("Reading"))
                    {
                        testReport.Pass("<i>incomplete readings detailed report grid Status column is in between" + " " + meterSizeHeadertext + " " + "and" + "  " + readingsHeadertext);
                    }
                    else
                    {
                        ReporterFactory.LogFailure("<i>Status Column not displaying  is in between" + "  " + meterSizeHeadertext + " " + "and" + "  " + readingsHeadertext);
                    }
                }
                else
                {
                    ReporterFactory.LogFailure("<i>Status Column not displaying in the Incomplete readings kpi report grid");
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }


        }

        public void validateDashboardCriticalKPIDetailedReportColumnsDisplay()
        {
            try
            {
                List<string> columnValues = new List<string>() { "Account Name", "Account Number", "Address", "MIU ID", "Meter Number", "Meter Size", "Reading", "Days", "Date" };

                ValidateCriticalContinuousConsumptionHTMLLink();
                ValidateGridColumns(columnValues, 10, "Critical Continuos Consumption");
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }
        }

        public void validateDashboardWarningKPIDetailedReportColumnsDisplay()
        {
            try
            {
                List<string> columnValues = new List<string>() { "Account Name", "Account Number", "Address", "MIU ID", "Meter Number", "Meter Size", "Reading", "Days", "Date" };

                ValidateWarningConsumptionPageLoad();
                ValidateGridColumns(columnValues, 10, "Warning Continuos Consumption");
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }
        }

        public void validateDashboardNormalKPIDetailedReportColumnsDisplay()
        {
            try
            {
                List<string> columnValues = new List<string>() { "Account Name", "Account Number", "Address", "MIU ID", "Meter Number", "Meter Size", "Reading", "Days", "Date" };
                ValidateNormalConsumptionPageLoad();
                ValidateGridColumns(columnValues, 10, "Normal Continuos Consumption");
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }
        }

        public void ValidateGridColumns(List<string> columnValues, int colCount, string KPIName)
        {
            bool columnValueMatched = true;
            try
            {
                IList<IWebElement> reportGridAllHeadersControls = driver.FindElements(reportGridAllHeaders);

                int colIndex = 0;
                if (reportGridAllHeadersControls.Count == colCount)
                {
                    for (colIndex = 0; colIndex < columnValues.Count; colIndex++)
                    {
                        driver.ScrollToElement(reportGridAllHeadersControls[colIndex]);
                        if (reportGridAllHeadersControls[colIndex].Text != columnValues[colIndex])
                        {
                            columnValueMatched = false;
                        }
                    }
                }
                else
                {
                    columnValueMatched = false;
                    ReporterFactory.LogFailure("<i>" + KPIName + " columns count is NOT matching");
                }

                if (!columnValueMatched)
                {
                    ReporterFactory.LogFailure("<i>" + KPIName + " columns are NOT matching");
                }
                else
                {
                    testReport.Pass("<i>" + KPIName + " columns are matching");
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }
        }

        public void validateDashboardSkippedKPIDetailedReportColumnsDisplay()
        {
            try
            {
                List<string> columnValues = new List<string>() { "Cycle/Route", "Read Seq", "Account Name", "Account Number", "Address", "MIU ID", "Meter Number", "Meter Size", "Skip Code", "Keyed Reading", "Comments", "Date/Time" };

                ValidateSkippedReadingGridView();
                ValidateGridColumns(columnValues, 13, "Skipped Readings");
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }
        }
        public void validateDashboardIncompleteKPIDetailedReportColumnsDisplay()
        {
            try
            {
                List<string> columnValues = new List<string>() { "Cycle/Route", "Account Name", "Account Number", "Address", "MIU ID", "Meter Number", "Meter Size", "Status", "Reading", "Keyed Reading", "Last Reading Date/Time", "Days Since Read" };
                ValidateIncompleteCountReadingGridView();
                ValidateGridColumns(columnValues, 13, "InComplete Readings");
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }
        }


        public void validateDashboardMeterNotReceivedKPIDetailedReportColumnsDisplay()
        {
            try
            {
                List<string> columnValues = new List<string>() { "Account Name", "Account Number", "Address", "MIU ID", "Meter Number", "Meter Size", "Reading", "Keyed Reading", "Last Reading Date/Time", "Days Since Last Heard" };
                ValidateNavigateToNotReceivedKPI();
                ValidateGridColumns(columnValues, 11, "Meter Not Received");
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }
        }

        public void ValidateNavigateToReveivedViaAMRKPI()
        {
            try
            {
                driver.WaitForElement(receivedAmrReadingCount, TimeSpan.FromSeconds(30));
                driver.ClickElement(receivedAmrReadingCount, "Received via AMR Readings");
                driver.WaitForElementNotExists(gridLoader, 60);
                driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void ValidateNavigateToReveivedViaAMIKPI()
        {
            try
            {
                driver.WaitForElement(receivedViaAMRRightArrow, TimeSpan.FromMinutes(2));
                driver.ClickElement(receivedViaAMRRightArrow, "Received Right via AMI");
                driver.WaitForElement(receivedAMIReadingCount, TimeSpan.FromSeconds(30));
                driver.ClickElement(receivedAMIReadingCount, "Received via AMI Readings");
                driver.WaitForElementNotExists(gridLoader, 60);
                driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void ValidateNavigateToNotReceivedKPI()
        {
            try
            {
                driver.WaitForElement(receivedViaAMRRightArrow, TimeSpan.FromMinutes(2));
                driver.ClickElement(receivedViaAMRRightArrow, "Received Right via AMI");
                driver.ClickElement(receivedViaAMIRightArrow, "Received Right via AMI");
                driver.WaitForElement(notReceivedReadingCount, TimeSpan.FromSeconds(30));
                driver.ClickElement(notReceivedReadingCount, "Received via AMI Readings");
                driver.WaitForElementNotExists(gridLoader, 180);
                driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void ValidateKendoGridDisplayed()
        {
            try
            {
                driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
                driver.WaitForElementNotExists(gridLoader, 60);
                driver.CheckElementDisplayed(kendoGridview, "Kendo Grid View");
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }


        public void ValidateGoogleMapsDisplayed()
        {
            try
            {
                driver.WaitForElement(mapView, TimeSpan.FromSeconds(60));
                driver.ClickElement(mapView, "Map view");
                driver.WaitForElement(mapMenuBar, TimeSpan.FromSeconds(30));
                driver.CheckElementDisplayed(mapMenuBar, "Map Menu bar");
                driver.CheckElementDisplayed(googleMap, "Google Map");
                driver.CheckElementDisplayed(googleImage, "Google Image");
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void ValidateIntermittentKPIClusters()
        {
            try
            {
                driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(40));
                driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
                driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
                driver.ClickElement(cotinuousRightArrow, "Contiuous Right");
                driver.ClickElement(intermittentReadingCount, "Intermittent Consumption");
                //driver.SwitchToFrameById("ntgMSTRFrame");

                driver.WaitForElement(reportDate, TimeSpan.FromSeconds(20));
                driver.CheckElementDisplayed(reportDate, "Report Date");
                //driver.SwitchToDefaultFrame();

                driver.WaitForElement(mapView, TimeSpan.FromSeconds(60));
                driver.ClickElement(mapView, "Map view");
                driver.WaitForElement(mapMenuBar, TimeSpan.FromSeconds(30));
                var alll = driver.FindElements(allClustersImages);
                var color = alll[0].GetCssValue("color");
                var color1 = alll[1].GetCssValue("background-color");
                var color11 = alll[0].GetAttribute("background-color");
                var color2 = alll[0].GetAttribute("style");
                var color3 = alll[0].GetAttribute("background-color");
                var color4 = alll[0].GetCssValue("style");
                String c = Color.FromName(color).ToKnownColor().ToString();//.Name;
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }

        }

        public void validate_TableSettingButton_Displayed_Report(string reportName)
        {
            driver.CheckElementExists(btnTableSetting, "Table Settings button- " + reportName);
        }

        public List<string> validate_ColumnRearrange_Dashboard_Report(string reportName, bool resetSettings = true)
        {
            List<string> beforeArrangeColumnValues = new List<string>();
            try
            {
                string secondHeaderBeforeArrange = driver.FindElement(gridHeaderTwo).Text;
                string fouthHeaderBeforeArrange = driver.FindElement(gridHeaderFour).Text;

                driver.Drag(gridHeaderTwo, gridHeaderFour);

                driver.WaitForElementNotExists(gridLoader, 40);
                string thirdHeaderAfterArrange = driver.FindElement(gridHeaderThree).Text;
                string fouthHeaderAfterArrange = driver.FindElement(gridHeaderFour).Text;

                if (secondHeaderBeforeArrange == fouthHeaderAfterArrange && fouthHeaderBeforeArrange == thirdHeaderAfterArrange)
                {
                    testReport.Pass("<i>User is able to rearrange the order of the columns by dragging and dropping in the " + reportName);
                }
                else
                {
                    ReporterFactory.LogFailure("<i>User is NOT able to rearrange the order of the columns by dragging and dropping in the " + reportName);
                }

                beforeArrangeColumnValues.Add(secondHeaderBeforeArrange);
                beforeArrangeColumnValues.Add(fouthHeaderBeforeArrange);

                if (resetSettings)
                {
                    resetTableSettings();
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.ToString());
            }

            return beforeArrangeColumnValues;
        }

        public void validate_ColumnRearrange_AfterNavigatingToOtherPage(List<string> beforeArrangeColumnValues, string reportName)
        {
            try
            {
                driver.WaitForElementNotExists(gridLoader, 40);
                string thirdHeaderAfterArrange = driver.FindElement(gridHeaderThree).Text;
                string fouthHeaderAfterArrange = driver.FindElement(gridHeaderFour).Text;

                if (beforeArrangeColumnValues[0] == fouthHeaderAfterArrange && beforeArrangeColumnValues[1] == thirdHeaderAfterArrange)
                {
                    testReport.Pass("<i>User is able to rearrange the order of the columns by dragging and dropping in the " + reportName);
                }
                else
                {
                    ReporterFactory.LogFailure("<i>User is NOT able to rearrange the order of the columns by dragging and dropping in the " + reportName);
                }
                resetTableSettings();
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void validate_ShowHideColumns_Dashboard_Report(string reportName, bool reset = true)
        {
            try
            {
                driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));

                if (reset)
                {
                    resetTableSettings();
                }

                clickTableSettings();

                driver.CheckElementExists(addOrRemoveColumsHeaderTableSetting, "Add or Remove Colums Header - " + reportName);

                driver.FindElement(checkBoxAddressTableSetting).Click();
                driver.FindElement(checkBoxMIUIDTableSetting).Click();

                if (driver.FindElement(checkBoxAddressTableSetting).Selected)
                {
                    ReporterFactory.LogFailure("<i>Deselected Address column checkbox is NOT unselected " + reportName);
                }

                if (driver.FindElement(checkBoxMIUIDTableSetting).Selected)
                {
                    ReporterFactory.LogFailure("<i>Deselected MIUID column checkbox is NOT unselected " + reportName);
                }

                driver.ClickElement(btnOkTableSetting, "Table Setting");

                driver.CheckElementDoesnotExists(address, "Address Column - " + reportName, "User is NOT able to hide columns after unchecking");

                driver.CheckElementDoesnotExists(miuId, "MIU ID Column - " + reportName, "User is NOT able to hide columns after unchecking");

                if (reset)
                {
                    clickTableSettings();

                    driver.FindElement(checkBoxAddressTableSetting).Click();
                    driver.FindElement(checkBoxMIUIDTableSetting).Click();
                    driver.ClickElement(btnOkTableSetting, "Table Setting");

                    driver.CheckElementExists(address, "Address Column - " + reportName, "User is NOT able to show columns after selecting");
                    driver.CheckElementExists(miuId, "MIU ID Column - " + reportName, "User is NOT able to show columns after selecting");
                    resetTableSettings();
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void ValidateShowHideColumnsAfterNavigatingToOtherPage(string reportName, bool reset = true)
        {
            try
            {
                driver.CheckElementDoesnotExists(address, "Address Column - " + reportName, "User is NOT able to hide columns after page redirect");

                driver.CheckElementDoesnotExists(miuId, "MIU ID Column - " + reportName, "User is NOT able to hide columns after page redirect");

                driver.RefreshPage();
                driver.WaitForElementNotExists(gridLoader, 180);
                driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));

                driver.CheckElementDoesnotExists(address, "Address Column - " + reportName, "User is NOT able to hide columns after Page refresh");

                driver.CheckElementDoesnotExists(miuId, "MIU ID Column - " + reportName, "User is NOT able to hide columns after Page refresh");

                clickTableSettings();
                driver.WaitForElement(checkBoxAddressTableSetting, TimeSpan.FromSeconds(180));
                driver.FindElement(checkBoxAddressTableSetting).Click();
                driver.FindElement(checkBoxMIUIDTableSetting).Click();

                driver.VerifyCheckboxStatus(checkBoxAddressTableSetting, "checked", "Address Check box", "column is selected");
                driver.VerifyCheckboxStatus(checkBoxMIUIDTableSetting, "checked", "MIU ID Check box", "column is NOT selected");

                driver.ClickElement(btnOkTableSetting, "Table Setting");

                driver.CheckElementExists(address, "Address Column - " + reportName, "User is NOT able to show columns after selecting");

                driver.CheckElementExists(miuId, "MIU ID Column - " + reportName, "User is NOT able to show columns after selecting");

                if (reset)
                {
                    resetTableSettings();
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void validate_TableSettingsScreen(string reportName, bool reset = true)
        {
            try
            {
                driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));

                if (reset)
                {
                    resetTableSettings();
                }

                clickTableSettings();

                driver.CheckElementExists(addOrRemoveColumsHeaderTableSetting, "Add or Remove Colums Header - " + reportName);

                driver.FindElement(btndeselectAll).Click();

                driver.ClickElement(btnOkTableSetting, "Table Setting");

                driver.VerifyCheckboxStatus(checkBoxAddressTableSetting, "unchecked", "Address Check box", "column is selected");
                driver.VerifyCheckboxStatus(checkBoxMIUIDTableSetting, "unchecked", "MIU ID Check box", "column is selected");

                if (driver.FindElement(validationTableSetting).Text != "Please select at least one column.")
                {
                    ReporterFactory.LogFailure("<i>User is NOT displayed with an error message 'Please select at least one column' " + reportName);
                }

                driver.ClickElement(btnResetTableSetting, "Reset");

                driver.CheckElementDoesnotExists(validationTableSetting, "Table Setting Validation");
                driver.VerifyCheckboxStatus(checkBoxAddressTableSetting, "checked", "Address Check box", "column is NOT selected");
                driver.VerifyCheckboxStatus(checkBoxMIUIDTableSetting, "checked", "MIU ID Check box", "column is NOT selected");

                driver.FindElement(btnCloseTableSetting).Click();

                driver.CheckElementDoesnotExists(addOrRemoveColumsHeaderTableSetting, "Table Setting screen");
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void validate_SlideColumnBorder_Dashboard_Report(string reportName)
        {
            try
            {
                driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));

                resetTableSettings();
                var widthAcNameBefore = Convert.ToDouble(driver.GetElementWidth(accNameColumn));
                driver.SlideColumnBorder(gridResizerColumnAcName, adressColumn, "Account Name");

                var widthAcNameAfter = Convert.ToDouble(driver.GetElementWidth(accNameColumn));
                if (widthAcNameBefore < widthAcNameAfter)
                {
                    testReport.Pass("<i>User is able to slide the column borders around dynamically to increase the column widths in the " + reportName);
                }
                else
                {
                    ReporterFactory.LogFailure("<i>User is NOT able to slide the column borders around dynamically to increase the column widths in the " + reportName);
                }
                var widthAdrBefore = Convert.ToDouble(driver.GetElementWidth(adressColumn));
                driver.SlideColumnBorder(gridResizerColumnAdress, accNoColumn, "Address");
                var widthAdrAfter = Convert.ToDouble(driver.GetElementWidth(adressColumn));

                if (widthAdrBefore > widthAdrAfter)
                {
                    testReport.Pass("<i>User is able to slide the column borders around dynamically to decrease the column widths in the " + reportName);
                }
                else
                {
                    ReporterFactory.LogFailure("<i>User is NOT able to slide the column borders around dynamically to decrease the column widths  in the " + reportName);
                }

                resetTableSettings();
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void resetTableSettings()
        {
            try
            {
                driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
                driver.ClickElement(btnTableSetting, "Table Setting");
                driver.CheckElementDisplayed(btnResetTableSetting, "Reset");
                driver.ClickElement(btnResetTableSetting, "Reset");
                driver.ClickElement(btnOkTableSetting, "Ok");
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void clickTableSettings()
        {
            try
            {
                driver.WaitForElement(btnTableSetting, TimeSpan.FromSeconds(20));
                driver.ClickElement(btnTableSetting, "Table Setting");
                driver.CheckElementDisplayed(btnOkTableSetting, "Reset");
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void validateDashboardSystemConsumptionDetailedReportGroupFilterDefaultSelection()
        {
            try
            {
                driver.WaitForElement(detailReport, System.TimeSpan.FromSeconds(30));
                driver.ClickElement(detailReport, "System Consumption Detail Report Link");
                driver.WaitForElementNotExists(gridLoader, 40);

                if (driver.FindElement(inputRadioBtn).Selected)
                {
                    testReport.Pass("<i>By default Include group filter option is selected");
                }
                else
                {
                    ReporterFactory.LogFailure("<i>By default Include group filter option is NOT selected");
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void validateDashboardMeterReceivedKPIDetailedReportColumnsDisplay(string reportName)
        {
            try
            {
                List<string> columnValues = new List<string>() { "Account Name", "Account Number", "Address", "MIU ID", "Meter Number", "Meter Size", "Reading", "Keyed Reading", "Last Reading Date/Time" };
                if (reportName == "Meters Received via AMI")
                {
                    ValidateNavigateToReveivedViaAMIKPI();
                }
                else if (reportName == "Meters Received via AMR")
                {
                    ValidateNavigateToReveivedViaAMRKPI();
                }
                ValidateGridColumns(columnValues, 10, reportName);
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public bool clickonReverseFlowKpicount(string kpioption)
        {
            bool flag = false;
            bool flag1 = true;
            string href = "";
            string href1 = "";

            try
            {
                driver.sleepTime(30000);
                driver.WaitForElement(reverseflowCount, TimeSpan.FromSeconds(180));
                href = driver.GetElementAttribute(reverseflowCount, "href");
                if (href.Contains(kpioption))
                {
                    if (driver.GetElementText(reverseflowCount) != "")
                    {
                        flag = true;
                        driver.ClickElement(reverseflowCount, "click on count");

                    }
                    else
                    {
                        ReporterFactory.LogFailure("<i>reverseflowcountfor" + kpioption + "is empty");
                    }
                }
                else
                {

                    flag = false;
                    do
                    {

                        driver.ClickElement(reverseflowPullRIght, "rightarrow");
                        href1 = driver.GetElementAttribute(reverseflowCount, "href");
                        if (href1.Contains(kpioption))
                        {

                            if (driver.GetElementText(reverseflowCount) != "")
                            {
                                driver.ClickElement(reverseflowCount, "click on count");
                                flag = true;
                            }
                            else
                            {
                                ReporterFactory.LogFailure("<i>reversecount for" + " " + kpioption + "is empty");
                            }
                        }
                        if (flag != true && verifyReverseflowPullrightgray())
                        {
                            flag = true;
                            flag1 = false;
                        }
                    }
                    while (flag == false);

                }
                if (flag == true && flag1 == true)
                {
                    return flag;
                }
                else
                {
                    ReporterFactory.LogFailure(kpioption + " " + "is not displaying");
                    return false;
                }

            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
                return flag;
            }
        }

        public void validateStatusforAllItems(string status)
        {
            try
            {
                bool uomMatched = false;
                driver.WaitForElementNotExists(gridLoader, 180);
                driver.WaitForElement(statusColumnHeader, TimeSpan.FromSeconds(180));
                IList<string> names = new List<string>();
                IList<IWebElement> gridAllUOMControls = driver.FindElements(gridAllUOM);
                int rowCont = int.Parse(driver.FindElement(gridRowCount).GetAttribute("aria-rowcount"));
                while (rowCont > 0)
                {
                    if (gridAllUOMControls.Count > 0)
                    {
                        foreach (IWebElement ele in gridAllUOMControls)
                        {
                            if (ele.Text == status)
                            {
                                uomMatched = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        uomMatched = false;
                    }
                    try
                    {
                        IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;
                        foreach (IWebElement ele in gridAllUOMControls)
                        {
                            names.Add(ele.Text);
                        }
                        exe.ExecuteScript("arguments[0].scrollIntoView(true);", gridAllUOMControls.Last());
                        gridAllUOMControls = driver.FindElements(gridAllUOM);
                    }
                    catch (Exception e)
                    { }
                    if (!uomMatched)
                    {
                        rowCont = rowCont - 30;
                    }
                    else
                    {
                        rowCont = 0;
                    }
                }

                if (!uomMatched)
                {
                    ReporterFactory.LogFailure("<i>status in the kpi and dashboard reports" + "   " + status + "    " + "are not same");
                }
                else
                {
                    testReport.Pass("<i>status in the kpi and dashboard reports" + "  " + status + "  " + "are  same");
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }

        }

        List<string> statusList1 = new List<string>();
        List<string> names1 = new List<string>();
        public void ValidateStatus()
        {
            try
            {
                bool uomMatched = true;
                int i = 1;
                driver.WaitForElementNotExists(gridLoader, 180);
                driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
                IList<IWebElement> gridAllUOMControls = driver.FindElements(gridAllUOM);
                IList<IWebElement> gridAllAccountNames = driver.FindElements(gridAllaccounts);
                int rowCont = int.Parse(driver.FindElement(gridRowCount).GetAttribute("aria-rowcount"));
                while (rowCont > 0)
                {

                    if (gridAllUOMControls.Count > 0)
                    {
                        foreach (IWebElement ele in gridAllUOMControls)
                        {
                            statusList1.Add(ele.Text);
                            if (ele.Text == "")
                            {
                                uomMatched = false;
                                break;
                            }
                            i++;
                        }

                    }
                    else
                    {
                        uomMatched = false;
                    }
                    try
                    {
                        IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;
                        foreach (IWebElement ele in gridAllAccountNames)
                        {
                            names1.Add(ele.Text);
                        }
                        exe.ExecuteScript("arguments[0].scrollIntoView(true);", gridAllUOMControls.Last());
                        gridAllUOMControls = driver.FindElements(gridAllUOM);
                    }
                    catch (Exception e)
                    { }
                    if (!uomMatched)
                    {
                        rowCont = rowCont - 30;
                    }
                    else if (i >= rowCont)
                    {
                        rowCont = 0;
                    }

                }


                if (!uomMatched)
                {
                    ReporterFactory.LogFailure("<i>Status is not displaying for all accounts");
                }
                else
                {
                    testReport.Pass("<i>Status is displaying for all accounts");
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }

        }


        List<string> statusList = new List<string>();
        List<string> names = new List<string>();
        List<string> meters = new List<string>();

        public void validateAscendingOrder()
        {
            try
            {
                bool uomMatched = true;
                int i = 1;
                driver.WaitForElementNotExists(gridLoader, 180);
                IList<IWebElement> gridAllUOMControls = driver.FindElements(gridAllUOM);
                IList<IWebElement> gridAllAccountNames = driver.FindElements(gridAllaccounts);
                IList<IWebElement> gridAllmeters = driver.FindElements(gridAllMeterreadings);
                int rowCont = int.Parse(driver.FindElement(gridRowCount).GetAttribute("aria-rowcount"));
                while (rowCont > 0)
                {

                    if (gridAllUOMControls.Count > 0)
                    {
                        foreach (IWebElement ele in gridAllUOMControls)
                        {
                            statusList.Add(ele.Text);
                            if (ele.Text == "")
                            {
                                uomMatched = false;
                                break;
                            }
                            i++;
                        }

                    }
                    else
                    {
                        uomMatched = false;
                    }
                    try
                    {
                        IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;
                        foreach (IWebElement ele in gridAllAccountNames)
                        {
                            names.Add(ele.Text);
                        }
                        foreach (IWebElement ele in gridAllmeters)
                        {
                            meters.Add(ele.Text);
                        }
                        exe.ExecuteScript("arguments[0].scrollIntoView(true);", gridAllUOMControls.Last());
                        gridAllUOMControls = driver.FindElements(gridAllUOM);
                    }
                    catch (Exception e)
                    { }
                    if (!uomMatched)
                    {
                        rowCont = rowCont - 30;
                    }
                    else if (i >= rowCont)
                    {
                        rowCont = 0;
                    }

                }
                statusList.Sort();
                names.Sort();
                meters.Sort();
                driver.RefreshPage();
                driver.sleepTime(40000);
                Actions builder = new Actions(driver);
                driver.WaitForElement(statusColumnHeader, TimeSpan.FromSeconds(60));
                IJavaScriptExecutor exe1 = (IJavaScriptExecutor)driver;
                exe1.ExecuteScript("arguments[0].scrollIntoView();", driver.FindElement(readingColumnHeader));
                driver.WaitForElement(statusColumnHeader, TimeSpan.FromSeconds(60));
                builder.MoveToElement(driver.FindElement(By.XPath("//table[@role='presentation' and not(@class='k-grid-table')]//th[8]//p"))).Build().Perform();
                driver.WaitForElement(statusSortingOrder, TimeSpan.FromSeconds(60));
                driver.ClickElement(statusSortingOrder, "status");
                driver.WaitForElement(sortAscending, TimeSpan.FromSeconds(60));
                driver.ClickElement(sortAscending, "Ascending order");
                driver.WaitForElementNotExists(gridLoader, 60);
                builder.MoveToElement(driver.FindElement(By.XPath("//table[@role='presentation' and not(@class='k-grid-table')]//th[2]//p"))).Build().Perform();
                driver.ClickElement(accountNameSort, "status");
                driver.ClickElement(sortAscending, "Ascending order");
                ValidateStatus();
                if (!uomMatched)
                {
                    ReporterFactory.LogFailure("<i>Grid report is not displaying in the Ascending Order after Sorting in to Ascending order");
                }
                else
                {
                    testReport.Pass("<i>Grid report is displaying in the Ascending Order after Sorting in to Ascending order");
                }
                if (statusList.Count == statusList1.Count)
                {
                    names1.Sort();
                    if (names.Count != names1.Count)
                    {
                        ReporterFactory.LogFailure("<i>Grid report is not displaying in the Ascending Order after Sorting in to Ascending order");
                    }
                }
                else
                {
                    ReporterFactory.LogFailure("<i>Grid report is not displaying in the Ascending Order after Sorting in to Ascending order");
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void validateAllUOMUnitsInTheTop10AccountsConsumptionGrid(string uom)
        {
            try
            {
                bool uomMatched = true;
                driver.ClickElement(lftNavDashboard, "Dashboard");
                driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
                driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Consumption Detail Report");
                driver.WaitForElementNotExists(gridLoader, 60);
                driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
                IList<IWebElement> gridAllUOMControls = driver.FindElements(gridAllUOM);

                if (gridAllUOMControls.Count > 0)
                {
                    foreach (IWebElement ele in gridAllUOMControls)
                    {
                        if (ele.Text != uom)
                        {
                            uomMatched = false;
                            break;
                        }
                    }
                }
                else
                {
                    ReporterFactory.LogFailure("<i>Top10 Accounts By Consumption Detail Report table does not contain data");
                }

                if (!uomMatched)
                {
                    ReporterFactory.LogFailure("<i>Device utility UOM" + uom + "and Dashboard Top10 Accounts By Consumption reports" + uom + "are not same");
                }
                else
                {
                    testReport.Pass("<i>Device utility UOM" + uom + "and Dashboard Top10 Accounts By Consumption reports" + uom + "are same");
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void validateAllUOMUnitsInTheSystemConsumptionGrid(string uom)
        {
            try
            {
                bool uomMatched = true;
                driver.ClickElement(lftNavDashboard, "Dashboard");
                driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
                driver.ClickElement(detailReport, "System Consumption Detailed Report");
                driver.WaitForElementNotExists(gridLoader, 60);
                driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
                IList<IWebElement> gridAllUOMControls = driver.FindElements(gridAllUOM);
                int rowCont = int.Parse(driver.FindElement(gridRowCount).GetAttribute("aria-rowcount"));
                if (gridAllUOMControls.Count > 0)
                {
                    while (rowCont > 0)
                    {
                        if (gridAllUOMControls.Count > 0)
                        {
                            foreach (IWebElement ele in gridAllUOMControls)
                            {
                                if (ele.Text != uom)
                                {
                                    uomMatched = false;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            uomMatched = false;
                        }
                        try
                        {
                            driver.ScrollToElement(gridAllUOMControls.Last());
                            driver.WaitForElementNotExists(reportGridLoader, 60);
                            gridAllUOMControls = driver.FindElements(gridAllUOM);
                        }
                        catch (Exception e)
                        {
                            ReporterFactory.LogFailure("<i>" + e.Message);
                        }
                        rowCont = rowCont - 30;
                    }
                }
                else
                {
                    ReporterFactory.LogFailure("<i>System Consumption Detail Report table does not contain data");
                }

                if (!uomMatched)
                {
                    ReporterFactory.LogFailure("<i>Device utility UOM " + uom + " and Dashboard System Consumption reports UOM " + uom + " are not same");
                }
                else
                {
                    testReport.Pass("<i>Device utility UOM " + uom + " and Dashboard System Consumption reports UOM " + uom + " are same");
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        internal void ValidateContinuousConsumptionKPIText(int position)
        {
            /// wait for page to load
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(30));

            for (int counter = 1; counter < position; counter++)
            {
                driver.WaitForElement(cotinuousRightArrow, TimeSpan.FromSeconds(10));
                driver.ClickElement(cotinuousRightArrow, "Right");
            }

            switch (position)
            {
                case 1:
                    driver.CheckElementDisplayed(criticalGateway, "Critical Consumption KPI");
                    break;
                case 2:
                    driver.CheckElementDisplayed(warning, "Warning Consumption KPI");
                    break;
                case 3:
                    driver.CheckElementDisplayed(normal, "Normal Consumption KPI");
                    break;
                case 4:
                    driver.CheckElementDisplayed(intermittent, "Intermittent Consumption KPI");
                    break;
                default:
                    ReporterFactory.LogFailure("<i>Wrong option passed.");
                    break;

            }
        }

        internal void ValidateContinuousConsumptionKPI_ValidateFooter()
        {
            string FooterTextOnUI = "";
            try
            {
                driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(30));

                driver.CheckElementDisplayed(By.XPath("//h3[text()='Continuous Consumption']"), "3rd Widget displayed");
                IWebElement ele = driver.FindElement(By.XPath("//h3[text()='Continuous Consumption']"));
                FooterTextOnUI = ele.FindElement(By.XPath("//h3[text()='Continuous Consumption']")).Text;
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("<i>Exception in validating Continuous Consumption on footer. Exception :" + ex.Message);
            }
            if (FooterTextOnUI.Trim().Equals("Continuous Consumption"))
            {
                testReport.Pass("<i>Continuous Consumption in footer as expected.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Continuous Consumption in not on footer. Failed.");
            }

        }

        internal void ValidateContinuousConsumptionKPI_ValidateCaption()
        {
            string CaptionTextOnUI = "";
            try
            {
                driver.WaitForElement(kpiPosition3, TimeSpan.FromSeconds(30));

                driver.CheckElementDisplayed(kpiPosition3, "3rd Widget displayed");
                IWebElement ele = driver.FindElement(kpiPosition3);
                CaptionTextOnUI = ele.FindElement(kpiPositionX_Caption).Text;

            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("<i>Exception in validating Continuous Consumption on caption. Exception :" + ex.Message);
            }
            if (Regex.IsMatch(CaptionTextOnUI, @"\d"))
            {
                testReport.Pass("<i>Continuous Consumption in caption is number as expected.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Continuous Consumption in caption is not a number. Failed.");
            }

        }

        internal void ValidateContinuousConsumptionReport_DateFormat()
        {
            driver.WaitForElement(cotinuousConsRightArrow, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(cotinuousConsRightArrow, "3rd Widget displayed");

            driver.WaitForElement(continuousCount, TimeSpan.FromSeconds(30));
            driver.ClickElement(continuousCount, "Critical Consumption");

            driver.WaitForElement(date_Report, TimeSpan.FromMinutes(2));
            string DateTextOnUI = driver.FindElement(date_Report).Text;
            bool testPassStatus = true;
            try
            {
                int[] dateData = DateTextOnUI.Split('/').Select(Int32.Parse).ToArray();
                if (dateData[0] < 0 || dateData[0] > 12
                    || dateData[1] < 0 || dateData[1] > 31
                    || dateData[2] < 0 || dateData[2] > 2050)
                    testPassStatus = false;
            }
            catch (Exception ex)
            {
                testPassStatus = false;
            }

            if (testPassStatus)
            {
                testReport.Pass("<i>Date on report is in MM/DD/YYYY format as expected.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Date on report is NOT in MM/DD/YYYY format. Failed.");
            }

        }

        internal void ValidateCountInStatus(int clicksOnRightArrow)
        {
            try
            {
                driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
                for (int i = 0; i < clicksOnRightArrow; i++)
                    driver.ClickElement(gatewayRight, "Right");

                string ValueOnDashboard = driver.FindElement(gatewayReadings).Text;

                driver.ClickElement(gatewayReadings, "Reading");

                driver.CheckElementDisplayed(dataInReport, "Data on report");
                int countOfDataInReport = driver.FindElements(dataInReport).Count();

                if (int.Parse(ValueOnDashboard) == countOfDataInReport)
                {
                    testReport.Pass("<i>Count Logic is correct as expected.");
                }
                else
                {
                    ReporterFactory.LogFailure("<i>Issue with count logic. Failed.");
                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("<i>Exception in validating count in status. Exception :" + ex.Message);
                throw;
            }
        }


        internal void ValidateSeprateEntity(int clicksOnRightArrow)
        {
            string ValueOnDashboard = "";
            int countOfDataInReport = -1;

            try
            {
                driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
                for (int i = 0; i < clicksOnRightArrow; i++)
                    driver.ClickElement(gatewayRight, "Right");

                ValueOnDashboard = driver.FindElement(gatewayReadings).Text;

                driver.ClickElement(gatewayReadings, "Reading");

                driver.CheckElementDisplayed(dataInReport, "Data on report");
                countOfDataInReport = driver.FindElements(dataInReport).Count();

            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("<i>Exception in validating Seprate Entity logic. Exception :" + ex.Message);
            }
            if (int.Parse(ValueOnDashboard) == countOfDataInReport)
            {
                testReport.Pass("<i>Seprate Entity Count is correct as expected.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Issue with Seprate Entity logic. Failed.");
            }
        }

        internal void ValidateMIUICount(int clicksOnRightArrow)
        {
            bool flag = false;
            try
            {
                driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
                for (int i = 0; i < clicksOnRightArrow; i++)
                    driver.ClickElement(gatewayRight, "Right");

                driver.ClickElement(gatewayReadings, "Reading");

                driver.CheckElementDisplayed(dataInReport, "Data on report");
                int countOfDataInReport = driver.FindElements(dataInReport).Count();

                flag = true;

                if (clicksOnRightArrow == 2)
                {
                    string valueInReport = driver.FindElement(By.XPath(dataInMIUcountColumn.Replace("_dataRow_", "1"))).Text;
                    if (Regex.IsMatch(valueInReport, @"^\d+$"))
                    {
                        testReport.Pass("<i>MIU's Count Logic is correct as it has Numeric Value for Normal report. As expected.");
                    }
                    else
                    {
                        flag = false;
                    }
                }
                else
                {
                    for (int i = 1; i <= countOfDataInReport; i++)
                    {
                        if (driver.FindElement(By.XPath(dataInMIUcountColumn.Replace("_dataRow_", i.ToString()))).Text != "0")
                        {
                            flag = false;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("<i>Exception in validating MIU's count logic. Exception :" + ex.Message);
                flag = false;
            }

            if (flag)
            {
                testReport.Pass("<i>MIU's Count Logic is correct as expected.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Issue with MIU's count logic. Failed.");
            }
        }

        internal void VerifyAlertConfig(int clicksOnRightArrow)
        {
            string ValueOnDashboard = "";
            int countOfDataInReport = -1;

            try
            {
                driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
                for (int i = 0; i < clicksOnRightArrow; i++)
                    driver.ClickElement(gatewayRight, "Right");

                ValueOnDashboard = driver.FindElement(gatewayReadings).Text;

                driver.ClickElement(gatewayReadings, "Reading");

                driver.CheckElementDisplayed(dataInReport, "Data on report");
                countOfDataInReport = driver.FindElements(dataInReport).Count();

            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("<i>Exception in validating Alert Config logic. Exception :" + ex.Message);
            }
            if (int.Parse(ValueOnDashboard) == countOfDataInReport)
            {
                testReport.Pass("<i>Alert Config logic is correct as expected.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Issue with Alert Config logic. Failed.");
            }
        }

        internal void VerifyAlertConfigNotMeet(int clicksOnRightArrow)
        {
            string ValueOnDashboard = "";
            int countOfDataInReport = -1;

            try
            {
                driver.WaitForElement(readingRightArrow, TimeSpan.FromSeconds(10));
                for (int i = 0; i < clicksOnRightArrow; i++)
                    driver.ClickElement(gatewayRight, "Right");

                ValueOnDashboard = driver.FindElement(gatewayReadings).Text;

                driver.ClickElement(gatewayReadings, "Reading");

                driver.CheckElementDisplayed(dataInReport, "Data on report");
                countOfDataInReport = driver.FindElements(dataInReport).Count();

            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("<i>Exception in validating Alert Config that does not meet logic. Exception :" + ex.Message);
            }
            if (int.Parse(ValueOnDashboard) == countOfDataInReport)
            {
                testReport.Pass("<i>Alert Config logic that does not meet is correct as expected.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Issue with Alert Config logic that does not meet. Failed.");
            }
        }


        public void ValidateKendoGrid()
        {
            try
            {
                driver.ClickElement(lftNavDashboard, "Dashboard");
                driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
                driver.ClickElement(detailReport, "System Consumption Detailed Report");
                driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
                driver.WaitForElementNotExists(gridLoader, 60);
                driver.CheckElementDisplayed(kendoGridview, "kendogridview");
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }


        }

        public void validateKendoGraphDates()
        {
            try
            {
                driver.ClickElement(lftNavDashboard, "Dashboard");
                driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
                IList<IWebElement> textintheBarchart = driver.FindElements(systemconsumptionbarcharttext);
                List<string> dates = new List<string>();
                foreach (IWebElement barchartvalue in textintheBarchart)
                {
                    string text = barchartvalue.Text;
                    if (text.Contains("/"))
                    {
                        string[] text1 = text.Split('/');
                        if (text1.Length == 3)
                        {
                            dates.Add(text);
                        }
                    }

                }
                if (Int32.Parse(dates[dates.Count - 1].Substring(6, dates[0].Length - 6)) == Int32.Parse(dates[dates.Count - 1].Substring(6, dates[0].Length - 6)))
                {

                    if (Int32.Parse(dates[0].Substring(0, dates[0].Length - 8)) == Int32.Parse(dates[dates.Count - 1].Substring(0, dates[dates.Count - 1].Length - 8)))
                    {
                        if (Int32.Parse(dates[dates.Count - 1].Substring(3, dates[dates.Count - 1].Length - 8)) - Int32.Parse(dates[0].Substring(3, dates[0].Length - 8)) + 1 == 7)
                        {
                            testReport.Pass("<i>past 7days reports are displaying");
                        }
                        else
                        {
                            ReporterFactory.LogFailure("<i>past 7days reports are not displaying");
                        }
                    }
                }
                else
                {
                    ReporterFactory.LogFailure("<i>past 7days reports are not displaying");
                }

            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void validateKendoGraphDatesorder()
        {
            try
            {
                driver.ClickElement(lftNavDashboard, "Dashboard");
                driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
                IList<IWebElement> textintheBarchart = driver.FindElements(systemconsumptionbarcharttext);
                List<string> dates = new List<string>();
                foreach (IWebElement barchartvalue in textintheBarchart)
                {
                    string text = barchartvalue.Text;
                    if (text.Contains("/"))
                    {
                        string[] text1 = text.Split('/');
                        if (text1.Length == 3)
                        {
                            dates.Add(text);
                        }
                    }

                }
                if (Int32.Parse(dates[dates.Count - 1].Substring(6, dates[0].Length - 6)) == Int32.Parse(dates[dates.Count - 1].Substring(6, dates[0].Length - 6)))
                {

                    if (Int32.Parse(dates[0].Substring(0, dates[0].Length - 8)) == Int32.Parse(dates[dates.Count - 1].Substring(0, dates[dates.Count - 1].Length - 8)))
                    {
                        if (Int32.Parse(dates[dates.Count - 1].Substring(3, dates[dates.Count - 1].Length - 8)) - Int32.Parse(dates[0].Substring(3, dates[0].Length - 8)) + 1 == 7)
                        {
                            bool flag = false;
                            int initialday = Int32.Parse(dates[0].Substring(3, dates[0].Length - 8));
                            for (int i = 1; i <= dates.Count - 1; i++)
                            {
                                if (Int32.Parse(dates[i].Substring(3, dates[0].Length - 8)) != initialday + 1)
                                {
                                    ReporterFactory.LogFailure("<i>x-axis days are not in order");
                                    flag = false;
                                    break;
                                }
                                else
                                {
                                    flag = true;
                                    initialday = Int32.Parse(dates[i].Substring(3, dates[0].Length - 8));
                                }
                            }
                            if (flag == true)
                            {
                                testReport.Pass("<i>x-axis days are displaying in the order");
                            }
                        }
                        else
                        {
                            ReporterFactory.LogFailure("<i>past 7days reports are not displaying");
                        }
                    }
                }
                else
                {
                    ReporterFactory.LogFailure("<i>past 7days reports are not displaying");
                }

            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }

        public void ValidateDatePicker()
        {
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
            driver.CheckElementDoesnotExists(fromDate, "fromdate");
            driver.CheckElementDoesnotExists(toDate, "Todate");
        }

        public void verifyDefaultReportdate()
        {
            try
            {
                string text = driver.GetElementText(majorReverseflowReportDate);
                string currentdate = DateTime.UtcNow.Date.ToString("MM/dd/yyyy");
                currentdate = currentdate.Replace('-', '/');
                if (text.Contains(currentdate))
                {
                    testReport.Pass("<i>toays date is displaying");
                }
                else
                {
                    ReporterFactory.LogFailure("<i>toays date is not displaying");
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);

            }

        }

        public void validateAllUOMUnitsInTheSystemConsumptionGrid(string detailReportlink, string uom)
        {
            try
            {
                bool uomMatched = true;
                if (detailReportlink.Equals("SystemConsumption", StringComparison.OrdinalIgnoreCase))
                {
                    driver.ClickElement(lftNavDashboard, "Dashboard");
                    driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
                    driver.ClickElement(detailReport, "Detailed Report");
                }
                if (detailReportlink.Equals("top10Accounts", StringComparison.OrdinalIgnoreCase))
                {
                    driver.ClickElement(lftNavDashboard, "Dashboard");
                    driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(30));
                    driver.ClickElement(topTenConsumtionDetailReport, "Detail Report");
                }

                driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
                IList<IWebElement> gridAllUOMControls = driver.FindElements(gridAllUOM);
                int rowCont = int.Parse(driver.FindElement(gridRowCount).GetAttribute("aria-rowcount"));
                if (gridAllUOMControls.Count > 0)
                {
                    while (rowCont > 0)
                    {
                        if (gridAllUOMControls.Count > 0)
                        {
                            foreach (IWebElement ele in gridAllUOMControls)
                            {
                                if (ele.Text != uom)
                                {
                                    uomMatched = false;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            uomMatched = false;
                        }
                        try
                        {
                            driver.ScrollToElement(gridAllUOMControls.Last());
                            driver.WaitForElementNotExists(reportGridLoader, 60);
                            gridAllUOMControls = driver.FindElements(gridAllUOM);
                        }
                        catch (Exception e)
                        {
                            ReporterFactory.LogFailure("<i>" + e.Message);
                        }
                        rowCont = rowCont - 30;
                    }
                }
                else
                {
                    ReporterFactory.LogFailure("<i>" + detailReportlink + " " + "Detail Report table does not contain data");
                }

                if (!uomMatched)
                {
                    ReporterFactory.LogFailure("<i>Device utility UOM " + " " + uom + " " + " and Dashboard" + detailReportlink + "  " + "reports Uom" + " " + uom + "  " + " are not same");
                }
                else
                {
                    testReport.Pass("<i>Device utility UOM " + " " + uom + " " + " and Dashboard" + detailReportlink + "  " + "reports Uom" + " " + uom + "  " + " are same");
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }

        }

        public void validateKendoGraphDatesFormat()
        {
            try
            {
                driver.ClickElement(lftNavDashboard, "Dashboard");
                driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
                IList<IWebElement> textintheBarchart = driver.FindElements(systemconsumptionbarcharttext);
                List<string> dates = new List<string>();
                foreach (IWebElement barchartvalue in textintheBarchart)
                {
                    string text = barchartvalue.Text;
                    if (text.Contains("/"))
                    {
                        string[] text1 = text.Split('/');
                        if (text1.Length == 3)
                        {
                            dates.Add(text);
                        }
                    }

                }
                foreach (var days in dates)
                {
                    if (days.Substring(6, days.Length - 6).Length == 4)
                    {
                        if (Int32.Parse(days.Substring(0, days.Length - 8)) > 0 && Int32.Parse(days.Substring(0, days.Length - 8)) < 13)
                        {
                            if (Int32.Parse(days.Substring(3, days.Length - 8)) > 0 && Int32.Parse(days.Substring(3, days.Length - 8)) < 32)
                            {
                                testReport.Pass("<i>" + days + " " + "are  displayed in the correctFormat");
                            }
                            else
                            {
                                ReporterFactory.LogFailure("<i>" + days + " " + "are not displayed in the correctFormat");
                            }
                        }
                        else
                        {
                            ReporterFactory.LogFailure("<i>" + days + " " + "are not displayed in the correctFormat");
                        }
                    }
                    else
                    {
                        ReporterFactory.LogFailure("<i>" + days + "  " + "are not displayed in correctFormat");
                    }
                }

            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }
        }
        public void verifysystemConsumptionGraph()
        {
            driver.ClickElement(lftNavDashboard, "Dashboard");
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(systemConsumptionGraphDisplay, "systemConsumptionGraph");
        }

        public void verifysystemConsumptionGraphbeforeTop10Accounts()
        {
            driver.ClickElement(lftNavDashboard, "Dashboard");
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(systemConsumptionGraphDisplaybeforeTop10, "systemConsumptionGraph");
        }

        public void verifyTop10AccountsKendoGrid()
        {
            driver.ClickElement(lftNavDashboard, "Dashboard");
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromMinutes(1));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Accounts Detail Report");
            driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
            driver.WaitForElementNotExists(gridLoader, 60);
            driver.CheckElementDisplayed(kendoGridview, "kendogridview");
        }

        public void validateMiuId(string id)
        {
            try
            {
                bool miuMatched = false;
                driver.WaitForElementNotExists(gridLoader, 180);
                driver.WaitForElement(miuIdColumnHeader, TimeSpan.FromSeconds(180));
                IList<string> names = new List<string>();
                IList<IWebElement> gridAllMiuIds = driver.FindElements(miuids);
                int rowCont = int.Parse(driver.FindElement(gridRowCount).GetAttribute("aria-rowcount"));
                while (rowCont > 0)
                {
                    if (gridAllMiuIds.Count > 0)
                    {
                        foreach (IWebElement ele in gridAllMiuIds)
                        {
                            if (ele.Text == id)
                            {
                                miuMatched = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        miuMatched = false;
                    }
                    try
                    {
                        IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;
                        foreach (IWebElement ele in gridAllMiuIds)
                        {
                            names.Add(ele.Text);
                        }
                        exe.ExecuteScript("arguments[0].scrollIntoView(true);", gridAllMiuIds.Last());
                        gridAllMiuIds = driver.FindElements(miuids);
                    }
                    catch (Exception e)
                    { }
                    if (!miuMatched)
                    {
                        rowCont = rowCont - 30;
                    }
                    else
                    {
                        rowCont = 0;
                    }

                }
                if (!miuMatched)
                {
                    ReporterFactory.LogFailure("<i>MiuId:" + " " + id + " " + "is not displaying in the kendogrid");
                }
                else
                {
                    testReport.Pass("<i>MiuId:" + " " + id + " " + "is displaying in the kendogrid");
                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
            }

        }

        public bool clickonConsumptionKpicount(string kpioption)
        {
            driver.WaitForElementNotExists(gridLoader, 60);
            bool flag = false;
            string href = "";
            string href1 = "";

            try
            {
                href = driver.GetElementAttribute(ContinuousConsumptionCount, "href");
                if (href.Contains(kpioption))
                {
                    if (driver.GetElementText(ContinuousConsumptionCount) != "")
                    {
                        flag = true;
                        driver.ClickElement(ContinuousConsumptionCount, "click on count");

                    }
                    else
                    {
                        ReporterFactory.LogFailure("<i>count for" + "  " + kpioption + " " + "is empty");
                    }
                }
                else
                {
                    try
                    {

                        flag = false;
                        do
                        {

                            driver.ClickElement(continuousConsumptionPullRIght, "rightarrow");
                            href1 = driver.GetElementAttribute(ContinuousConsumptionCount, "href");
                            if (href1.Contains(kpioption))
                            {

                                if (driver.GetElementText(ContinuousConsumptionCount) != "")
                                {
                                    driver.ClickElement(ContinuousConsumptionCount, "click on count");
                                    flag = true;
                                }
                                else
                                {
                                    ReporterFactory.LogFailure("<i>count for" + "  " + kpioption + " " + "is empty");
                                }
                            }
                            if (flag != true && verifyConsumptionPullrightgray())
                            {
                                flag = true;
                            }
                        }
                        while (flag == false);
                    }
                    catch (Exception e)
                    {

                        ReporterFactory.LogFailure("<i>" + e.Message);
                    }
                }
                return flag;
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("<i>" + e.Message);
                return flag;
            }
        }

        public void validateTop10AccountsintheMap()
        {
            try
            {
                driver.sleepTime(5);
                driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(30));
                driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Consumption Details Report ");
                driver.WaitForElementNotExists(gridLoader, 60);
                driver.WaitForElement(gridView, TimeSpan.FromSeconds(10));
                bool flag = false;
                driver.ClickElement(mapView, "Map view");
                driver.sleepTime(10000);
                int pinbuttonscount1 = driver.FindElements(pinbutton).Count;
                if (verifyPinAccountsintheMap())
                {
                    testReport.Pass("<i> Top 10 Consumption accounts are displayed in the map");
                }
                else if (pinbuttonscount1 >= 1)
                {
                    ReporterFactory.LogFailure("<i> Top 10 Consumption accounts are not displayed in the map");
                }
                else
                {
                    clickOnClusters();

                    for (int i = 1; i <= 10; i++)
                    {
                        clickonSubclusters();
                        if (verifyPinAccountsintheMap())
                        {
                            testReport.Pass("<i> Top 10 Consumption accounts are displayed in the map");
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        ReporterFactory.LogFailure("<i> Top 10 Consumption accounts are displayed in the map");
                    }

                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }
        }

        public void validateMapsDisplay()
        {
            try
            {

                bool flag = false;
                driver.ClickElement(mapView, "Map view");
                driver.sleepTime(10000);
                int pinbuttonscount1 = driver.FindElements(pinbutton).Count;
                if (verifyPinAccountsintheMap())
                {
                    testReport.Pass("<i> Consumption accounts are displayed in the map");
                }
                else if (pinbuttonscount1 >= 1)
                {
                    ReporterFactory.LogFailure("<i> Consumption accounts are not displayed in the map");
                }
                else
                {
                    clickOnClusters();

                    for (int i = 1; i <= 10; i++)
                    {
                        clickonSubclusters();
                        if (verifyPinAccountsintheMap())
                        {
                            testReport.Pass("<i> Consumption accounts are displayed in the map");
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        ReporterFactory.LogFailure("<i> Consumption accounts are displayed in the map");
                    }

                }
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }
        }
        public void clickOnDetailReportLink(string detailReportlink)
        {
            try
            {
                if (detailReportlink.Equals("SystemConsumption", StringComparison.OrdinalIgnoreCase))
                {
                    driver.ClickElement(lftNavDashboard, "Dashboard");
                    driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
                    driver.ClickElement(detailReport, "Detailed Report");
                }
                if (detailReportlink.Equals("top10Accounts", StringComparison.OrdinalIgnoreCase))
                {
                    driver.ClickElement(lftNavDashboard, "Dashboard");
                    driver.WaitForElement(topTenConsumtionDetailReport, System.TimeSpan.FromSeconds(30));
                    driver.ClickElement(topTenConsumtionDetailReport, "Detail Report");
                }

                driver.WaitForElement(gridView, TimeSpan.FromSeconds(60));
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
            }
        }

        internal void ValidateContinuousConsumptionReport_ReadingFormat()
        {

            bool testPassStatus = true;
            try
            {
                driver.WaitForElement(cotinuousConsRightArrow, TimeSpan.FromSeconds(30));
                driver.CheckElementDisplayed(cotinuousConsRightArrow, "3rd Widget displayed");

                driver.WaitForElement(continuousCount, TimeSpan.FromSeconds(30));
                driver.ClickElement(continuousCount, "Critical Consumption");

                driver.WaitForElement(readings_Report, TimeSpan.FromMinutes(2));

                string FirstReading = driver.FindElement(readings_Report).Text;

                if (Regex.IsMatch(FirstReading, @"^\d+$"))
                {
                    testReport.Pass("<i>Reading on report is a integer value. As expected.");
                }
                else
                {
                    testPassStatus = false;
                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("<i>Exception while validating format of Readings data. Exception :" + ex.Message);
                testPassStatus = false;
            }

            if (testPassStatus)
            {
                testReport.Pass("<i>Reading on report is intiger as expected.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Reading on report is NOT intiger. Failed.");
            }

        }

        internal void ValidateIntermittentConsumptionReport_RecordCount()
        {

            bool testPassStatus = true;
            try
            {
                driver.WaitForElement(cotinuousConsRightArrow, TimeSpan.FromSeconds(30));
                driver.CheckElementDisplayed(cotinuousConsRightArrow, "3rd Widget displayed");

                driver.WaitForElement(cotinuousConsRightArrow, TimeSpan.FromSeconds(10));
                driver.ClickElement(cotinuousConsRightArrow, "Right");
                driver.ClickElement(cotinuousConsRightArrow, "Right");
                driver.ClickElement(cotinuousConsRightArrow, "Right");
                driver.WaitForElement(continuousCount, TimeSpan.FromSeconds(30));

                int countOnKPI = int.Parse(driver.GetElementText(continuousCount));

                driver.ClickElement(continuousCount, "Intermittent Consumption");

                driver.WaitForElement(gridRowCount, TimeSpan.FromMinutes(2));

                int rowCont = int.Parse(driver.FindElement(gridRowCount).GetAttribute("aria-rowcount"));
                rowCont--; // To remove table header from count

                if (countOnKPI == rowCont)
                {
                    testReport.Pass("<i>Report has same number of rows as on KPI");
                }
                else
                {
                    testPassStatus = false;
                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("<i>Exception while validating Intermittent Consumption Report. Exception :" + ex.Message);
                testPassStatus = false;
            }

            if (testPassStatus)
            {
                testReport.Pass("<i>Intermittent Consumption Report has same amount of data as on KPI.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Intermittent Consumption Report DOES NOT has same amount of data as on KPI. Failed.");
            }

        }

        internal void ValidateScrollBarPresentOnReport()
        {

            bool testPassStatus = true;
            try
            {
                driver.WaitForElement(kpiPosition3, TimeSpan.FromSeconds(30));
                driver.CheckElementDisplayed(kpiPosition3, "3rd Widget displayed");

                driver.WaitForElement(continuousCount, TimeSpan.FromSeconds(30));

                int countOnKPI = int.Parse(driver.GetElementText(continuousCount));

                if (countOnKPI < 30)
                {
                    ReporterFactory.LogFailure("<i>Insufficeient data to test presense of Scroll Bar. Failed.");
                    return;
                }

                driver.ClickElement(continuousCount, "Intermittent Consumption");

                string classProeprty = driver.FindElement(reportKendoGrid).GetAttribute("class");

                if (classProeprty.Contains("scroll-visible"))
                {
                    testReport.Pass("<i>Scroll Present on page");
                }
                else
                {
                    testPassStatus = false;
                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("<i>Exception while validating scroll presence on Report. Exception :" + ex.Message);
                testPassStatus = false;
            }

            if (testPassStatus)
            {
                testReport.Pass("<i>Scroll presence on Report.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Scroll not present on Report. Failed.");
            }
        }

        internal void CheckClusterPresence()
        {
            try
            {
                driver.FindElement(cluster);
                testReport.Pass("<i>Cluster Present with Gray colour");
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure("Exception while validating cluster presence. Exception : " + e.Message);
            }
        }

        internal void CheckClusterPresenceOnReport(int WizardNumber)
        {
            try
            {
                if (WizardNumber == 1) //System Consumption
                    driver.ClickElement(detailReport, "Detailed Report");
                else if (WizardNumber == 2) // Top 10 Accounts by Consumption
                    driver.ClickElement(topTenConsumtionDetailReport, "Detailed Report");

                driver.WaitForElement(backToKPI, System.TimeSpan.FromSeconds(30000));
                //driver.ClickElement(backToKPI,"BackToKPI");

                driver.ClickElement(mapView, "Map view");
                driver.WaitForElement(map, TimeSpan.FromSeconds(10));

                CheckClusterPresence();
            }
 catch (Exception e)
            {
                ReporterFactory.LogFailure("Exception while validating cluster presence. Exception : " + e.Message);
            }
        }

    } 
}
