using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Neptune360UIAutomation
{
    public class RolesPermissonsPage : AbstractTemplatePage
    {
        #region UI Object Repository
        private By btnCreate = By.XPath("//button[text()='Create']");
        private By btnCreateUtility = By.CssSelector(".float-top-right > .ng-star-inserted");
        private By btnSearch = By.XPath("//button[text()='Search']");
        private By createUtilityDialog = By.XPath("//span[text()='Create New Utility']");
        private By btnCancelcreateUtility = By.Id("createUtilityCancelButton");
        private By utilitySearchTextbox = By.Id("utilitySearchTextBox");
        private By roleOptionsScreen = By.ClassName("module-container");
        private By lstItemRoleNeptuneCustServRep = By.XPath("//span[text()='Neptune Customer Service Rep']");
        private By btnDelete = By.XPath("//button[text()='Delete']");
        private By btnCancel = By.XPath("//button[text()='Cancel']");
        private By sendPasswordReset = By.XPath("//kendo-dialog/div[2]/div/div[1]/div[6]/div/input");
        private By role = By.XPath("//div[@class='role-item arrow_box']//span");
        private By newrolename = By.XPath("//div[@class='ng-tns-c745-0']//input");

        private By btnCloseUtility = By.XPath("//kendo-dialog-titlebar/div[2]");
        private By btnDone = By.XPath("//button[text()='Done']");
        private By btnDone_EditPermission = By.XPath("//div[@class='content-wrapper content-align']//button[text()='Done']");
        private By permissionsSaveAlert = By.XPath("//div[@role='alertdialog']");
        private By permissionsSaveAlertCloseBtn = By.XPath("//button[contains(@class,'toast-close-button')]");
        private By btnEdit_RoleManagement = By.XPath("//div[@class='role-management-group-btn']//button[text()='Edit']");
        private By permissionsLoader = By.XPath("//div[contains(@class,'loading-overlay')]");
        private By btnBuildUSB = By.XPath("//button[text()='Build USB']");
        private By btnClose = By.XPath("//button[text()='Close']");
        private By btnDoneEdit = By.XPath("(//button[@type='button'])[6]");
        private By listofRoles = By.XPath("//div[3]/div[2]/div[1]");
        private By btnExport = By.XPath("//th[text()='Export Settings']");
        private By questionMark = By.CssSelector(".fa-question");
        private By drpEnabDisabIM = By.XPath("//span[text()='Identity Management']/..//span[@class='k-dropdown-wrap k-state-default']");
        private By drpEnabDisabUM = By.XPath("//span[text()='Utility Management']/..//span[@class='k-dropdown-wrap k-state-default']");
        private By drpEnabDisabLN = By.XPath("//span[text()='Left Navigation']/..//span[@class='k-dropdown-wrap k-state-default']");
        private By drpValueEnabled = By.XPath("//kendo-list//li[1]");
        private By drpValueDisabled = By.XPath("//kendo-list//li[2]");
        private By neptuneSystemAdmin = By.XPath("//span[text()='Neptune System Administrator']");
        private By custService = By.XPath("//span[text()='Neptune Customer Service Rep']");
        private By utilityUser = By.XPath("//span[text()='Utility User']");
        private By utilityReadOnly = By.XPath("//span[text()='Utility Read Only Access']");
        private By utilityMeterReader = By.XPath("//span[text()='Utility Meter Reader']");
        private By utilityAdmin = By.XPath("//span[text()='Utility Administrator']");
        private By utilityAdminBeta = By.XPath("//span[text()='Utility Administrator Beta']");
        private By breadCrumb = By.XPath("//ng-sidebar-container//sd-toolbar//span/span");
        private By createRoletxtbox = By.XPath("//input[@type='text']");
        private By btnHome = By.XPath("//sd-toolbar/div/i");
        private By txtAccountSearch = By.Id("txtAccountSearch");
        private By eventHeader = By.XPath("//div/div/sd-blank/div[2]/div[1]/div/div");
        private By routeOne = By.XPath("//table[@class='k-grid-table']//tr[1]/td[1]");
        private By btnDashBoard = By.XPath("//img[contains(@src,'Dashboard.3D')]");
        private By btnCustomerInquiry = By.XPath("//img[contains(@src,'CustomerInquiry.3D')]");
        private By btnBillingServices = By.XPath("//img[contains(@src,'BillingServices.3D')]");
        private By btnNotifications = By.XPath("//img[contains(@src,'Notifications.3D')]");
        private By btnUtilityManagement = By.XPath("//img[contains(@src,'UtilityManagement.3D')]");
        private By btnRouteManagement = By.XPath("//img[contains(@src,'RouteManagement.icon.svg')]");
        private By btnReports = By.XPath("//img[contains(@src,'Reports.icon.svg')]");
        private By lftNavUtilityManagement = By.XPath("//span[text()='UTILITY MANAGEMENT']");
        private By lftNavDeviceManagement = By.XPath("//span[text()='DEVICE MANAGEMENT']");
        private By lftNavAlertConfiguration = By.XPath("//span[text()='ALERT NOTIFICATIONS']");
        private By lftNavEmailNotifications = By.XPath("//span[text()='EMAIL NOTIFICATION']");
        private By lftNavRolesAndPermissions = By.XPath("//span[text()='ROLE MANAGEMENT ']");
        private By lftNavRouteManagement = By.XPath("//span[text()='ROUTE MANAGEMENT']");
        private By routeAssignmentLeftNav = By.XPath("//span[text()='Route Assignments Left Navigation']");
        private By lftNavRouteAssignment = By.XPath("//span[text()='ROUTE ASSIGNMENTS']");
        private By lftNavCustomerInquiry = By.XPath("//span[text()='CUSTOMER INQUIRY']");
        private By lftNavBillingServices = By.XPath("//span[text()='BILLING SERVICES']");
        private By lftNavImport = By.XPath("//span[text()='IMPORT FILES']");
        private By lftNavExport = By.XPath("//span[text()='EXPORT FILES']");
        private By accManagement = By.XPath("//span[text()='ACCOUNT MANAGEMENT']");
        private By createAcc = By.XPath("//span[text()='CREATE ACCOUNT']");
        private By manageAcc = By.XPath("//span[text()='MANAGE ACCOUNT']");
        private By endPointmanagmnt = By.XPath("//span[text()='ENDPOINT MANAGEMENT']");
        private By createMIU = By.XPath("//span[text()='CREATE MIU']");
        private By CMIUMode = By.XPath("//span[text()='CMIU MODE']");
        private By cmiuReporter = By.XPath("//span[text()=' CMIU Reporter']");
        private By defaultRole = By.XPath("//role//div[@class='role-item arrow_box']");
        private By updateFeaturesdropdown = By.XPath("//span[text()='Identity Management']//..//kendo-dropdownlist");
        private By lftNavPlatformManagement = By.XPath("//span[text()='PLATFORM MANAGEMENT']");
        private By lftNavRoleManagement = By.XPath("//span[text()='ROLE MANAGEMENT ']");
        private By lftNavPartnerManagement = By.XPath("//span[text()='PARTNER MANAGEMENT']");
        private By lftNavAPIDeploment = By.XPath("//span[text()='API DEPLOYMENT']");
        private By partnerManagementFeature = By.XPath("//span[text()='Partner Management']");
        private By viewPartnerManagement = By.XPath("//span[text()='View Partner Management']");
        private By lftNavsearchEndpoints = By.XPath("//span[text()='SEARCH ENDPOINTS']");
        private By createPartner = By.XPath("//span[text()='Create Partners']");
        private By editPartner = By.XPath("//span[text()='Edit Partners']");
        private By reportsWidget = By.XPath("//h3[text()='Reports']/..//following-sibling::div/img");
        private By lftDashboard = By.XPath("//span[text()='DASHBOARD']");
        private By lftNavUserManagement = By.XPath("//span[text() = 'USER MANAGEMENT']");
        private By lftNavrouteAssignment = By.XPath("//span[text() = 'ROUTE ASSIGNMENT']");
        private By topNavigation = By.XPath("//sd-home/div/div[2]/div/div");
        private By dashboardNetworkHealth = By.XPath("//span[text()='Dashboard Network Health Left Navigation']");
        private By dashboardNetworkHealthWidget = By.XPath("//span[text()='View All Network Health Dashboard Widgets']");
        private By billingServiceSetting = By.XPath("//span[text()='Billing Services Settings Left Navigation']");
        private By endpointMaintenanceReport = By.XPath("//span[text()='Endpoint Maintenance Report']");
        private By endpointConsumptionReport = By.XPath("//span[text()='Endpoint Consumption Report']");
        private By endpointMaintenanceLeftNav = By.XPath("//span[text()='Endpoint Management Left Navigation']");
        private By cmiuFotaLeftNav = By.XPath("//span[text()='Endpoint FOTA Left Navigation']/..//img");
        private By miuListLeftNav = By.XPath("//span[text()='MIU List Left Navigation']");
        private By lftnavReports = By.XPath("//span[text()=' REPORTS']");
        private By cmiuFotaFeatureBlk = By.XPath("//div[32]/span/sd-feature-panel/div/div[1]/h5");
        private By miuListFeatureGroup = By.XPath("//div[33]/span/sd-feature-panel/div/div[1]/h5");
        private By codedNotes = By.XPath("//h1[contains(.,'Coded Notes')]");
        private By comments = By.XPath("//h1[contains(.,'Comments')]");
        private By mach10 = By.XPath("//h1[contains(.,' Mach 10 Battery ')]");
        private By invalidReadings = By.XPath("//h1[contains(.,' Invalid Readings ')]");
        private By invalidReadingsReport = By.XPath("//span[text()='Invalid Readings Report']");
        private By invalidReadings_Reports = By.XPath("//h1[text()=' Invalid Readings ']");
        private By handheldManagement = By.XPath("//span[text()='HANDHELD MANAGEMENT']");
        private By handhelds = By.XPath("//span[text()='HANDHELDS']");
        private By neptune360Sync = By.XPath("//span[text()='NEPTUNE 360 SYNC']");
        private By handheldSettings = By.XPath("//span[text()='HANDHELD SETTINGS']");
        private By exportFiles = By.XPath("//span[text()='EXPORT FILES']");
        private By exportHistory = By.XPath("//span[text()='EXPORT HISTORY']");
        private By routeManagementLftNav = By.XPath("//span[text()='Route Management Left Navigation']");
        private By routeManagementWidget = By.XPath("//span[text()='Route Management Widget']");
        private By viewRouteManagementDashboard = By.XPath("//span[text()='View Route Management Dashboard']");
        private By routeAssignmentScreen = By.XPath("//span[text()='Route Assignment Screen']");
        private By editAssignmentPermission = By.XPath("//span[text()='Edit Assignments']");
        private By neptuneOnly = By.XPath("//label[text()='Neptune Only ']");
        private By toastMessage = By.Id("toast-container");
        private By neptuneOnlyOnOff = By.XPath("//label[contains(.,'Neptune Only')]//kendo-switch/span/span");
        private By sdkAccessFeatureGroup = By.XPath("//span[text()='SDK Access']");
        private By viewSDKAccess = By.XPath("//span[text()='View SDK Access']");
        private By featureEnabled = By.XPath("//li[contains(.,'Enabled')]");
        private By featureDisabled = By.XPath("//li[contains(.,'Disabled')]");
        private By Toastmessagerole = By.XPath("//div[text()='Role has been Updated']");


        private By drpProfileLogOut = By.XPath("//button[contains(@class,'k-button')]");
        private By drpProfile = By.XPath("//i[2]");
        private By btnProfile = By.XPath("//span[text()='Profile']");
        private By btnAlert = By.XPath("//span[text()='Alert Notifications']");
        private By btnLogOut = By.XPath("//span[text()='Logout']");
        private By btnQuestion = By.XPath("//li[3]/button");
        private By btnQuestionTopNavigation = By.XPath("//span[contains(@class,'fa-question')]");
        private By drpHelp = By.XPath("//li[4]/kendo-dropdownbutton/button");
        private By helpContent = By.XPath("//span[text()='Help Contents']");
        private By aboutNeptune360 = By.XPath("//span[text()='About Neptune 360']");
        private By selectUtility = By.XPath("//div//span/sd-menu/ul/li[1]");
        private By systemConsumption = By.XPath("//div/div/div[1]/div[2]/div//span[1]");
        private By topTenConsumtionDetailReport = By.XPath("//div[3]/div/span[2]/a");
        private By readingsKpiWidget = By.XPath("//div[2]/div/sd-dashboardcard/div/div[3]/div/h3");
        private By consupmtion = By.XPath("//h3[contains(.,'Consumption')]");
        private By reverseFlowWidget = By.XPath("//h3[contains(.,'Reverse Flow')]");
        private By metersReadingsKpi = By.XPath("//div[2]/div/sd-dashboardcard/div/div[1]/h1");
        private By screenUserManagement = By.XPath("//h3[text()='User Management']/..//following-sibling::div/img");
        private By lftTxtSearchUtility = By.XPath("//input[@placeholder='Search Utility Name or ID']");
        private By btnEdit = By.XPath("//button[text()='Edit']");
        private By btnFilter = By.XPath("//button[text()='Filter']");
        private By sendPwdReset = By.XPath("//button[text()='Send Password Reset']");
        private By pageHeader = By.XPath("//h2[contains(.,'Utility Management')]");
        private By codeManagement = By.XPath("//span[text()='Code Management']");
        private By neptuneOption = By.XPath("//span[text()='Neptune Option Only']");
        private By deviceManagementSection = By.XPath("//span[text()='Device Management']");
        private By readers = By.XPath("//span[contains(.,'Readers')]");
        private By readersList = By.XPath("//kendo-grid[@id='usersGrid']");
        private By fileMapperLftNav = By.XPath("//span[text()='File Mapper Left Navigation']");
        private By handheldslft = By.XPath("//span[text()='Handhelds Left Navigation']");
        private By usagePlansLftNav = By.XPath("//span[text()='Usage Plans Left Navigation']");
        private By usagePlaneFeatureGrp = By.XPath("//span[text()='Usage Plans']");
        private By viewUsagePlans = By.XPath("//span[text()='View Usage Plans']");
        private By editUsagePlans = By.XPath("//span[text()='Edit  Usage Plans']");
        private By groupsWidgetImg = By.XPath("//span[text()='Groups Widget']/..//img");
        private By manageGroupEndpointImg = By.XPath("//span[text()='Manage Group Endpoints']/..//img");
        private By deleteGroupsImg = By.XPath("//span[text()='Delete Groups']/..//img");
        private By viewGroupsImg = By.XPath("//span[text()='View Groups']/..//img");
        private By viewNSPDBConversionImg = By.XPath("//span[text()='View NSP DB Conversion']/..//img");
        private By editSettingsImg = By.XPath("//span[text()='Edit Settings']/..//img");
        private By viewSettingsImg = By.XPath("//span[text()='View Settings']/..//img");
        private By viewFTPCredentials = By.XPath("//span[text()='View FTP Credentials']/..//img");
        private By createEditGrpContainerImg = By.XPath("//span[text()='Create/Edit Group container']/..//img");
        private By endpointManagementLeftNavImg = By.XPath("//span[text()='Endpoint Management Left Navigation']/..//img");
        private By cmiuFotaLeftNavimg = By.XPath("//span[text()='CMIU FOTA Left Navigation']/..//img");
        private By miuListLeftNavImg = By.XPath("//span[text()='MIU List Left Navigation']/..//img");
        private By sendUpdateImg = By.XPath("//span[text()='Send Update']/..//img");
        private By viewMiuListImg = By.XPath("//span[text()='View MIU List']/..//img");
        private By loraPrivateNwtworkImg = By.XPath("//span[text()='Lora Private Network Settings']/..//img");
        private By loraPrivateNwtwork = By.XPath("//span[text()='Lora Private Network Settings']");

        private By neptune360essentials = By.XPath("//span[text()='Neptune 360 Essentials']");
        private By neptune360SyncLftnav = By.XPath("//span[text()='//span[text()='NEPTUNE 360 SYNC']']");
        private By neptune360syncpermission = By.XPath("//span[text()='Neptune 360 Sync Left Navigation']");
        private By viewneptune360syncscreen = By.XPath("//span[text()='View Neptune 360 Sync Screen']");
        private By downloadNeptune360Sync = By.XPath("//span[text()='Download Neptune 360 Sync']");
        private By neptune360SyncBlock = By.XPath("//span[text()='Neptune 360 Sync Left Navigation']");
        private By apiDeploymentLftNav = By.XPath("//span[text()='API Deployment Left Navigation']");
        private By viewApiDeployment = By.XPath("//span[text()='View API Deployment']");
        private By createBundles = By.XPath("//span[text()='Create Bundles']");
        private By amiNoFlow = By.XPath("//span[text()='AMI No Flow Report']");
        private By deleteOwnComm = By.XPath("//span[text()='Delete Own Comments']");
        private By deleteOthersComm = By.XPath("//span[text()='Delete Others Comments']");
        private By highConsumptionReport = By.XPath("//span[text()='High Consumption Report']");
        private By editComments = By.XPath("//span[text()='Edit Comments']");
        private By createComments = By.XPath("//span[text()='Create Comments']");
        private By softDisconnectReport = By.XPath("//span[text()='Soft Disconnect Report']");
        private By viewComments = By.XPath("//span[text()='View Comments']");
        private By createCommentsSwitch = By.XPath("//div[14]//ul/li[10]/sd-permission//span[2]/kendo-switch/span");
        private By createCommentsImg = By.XPath("//span[text()='Create Comments']/..//img");
        private By editCommentsImg = By.XPath("//span[text()='Edit Comments']/..//img");
        private By viewCommentsImg = By.XPath("//span[text()='View Comments']/..//img");
        private By deleteOwnCommentsImg = By.XPath("//span[text()='Delete Own Comments']/..//img");
        private By deleteOthersCommImg = By.XPath("//span[text()='Delete Others Comments']/..//img");
        private By highConsumptionReportImg = By.XPath("//span[text()='High Consumption Report']/..//img");
        private By editSoftDisconnectImg = By.XPath("//span[text()='Edit Soft Disconnect']/..//img");
        private By billingServSettingImg = By.XPath("//span[text()='Billing Services Settings Left Navigation']/..//img");
        private By endpointMaintenanceReportImg = By.XPath("//span[text()='Endpoint Maintenance Report']/..//img");
        private By softDisconnectReportImg = By.XPath("//span[text()='Soft Disconnect Report']/..//img");
        private By editSoftDisconnectSwitch = By.XPath("//div[14]/span/sd-feature-panel/div/div[2]/div/ul/li[8]//span[2]/kendo-switch/span");
        private By editCommentsSwitch = By.XPath("//div[14]//div[2]//li[11]/sd-permission/div/span[2]/kendo-switch/span");
        private By viewCommentsSwitch = By.XPath("//div[14]//sd-feature-panel//li[9]//span[2]/kendo-switch/span");
        private By daysOfconsFlowAMiConsmBased = By.XPath("//span[text()='Days of Consecutive Flow (AMI) - Flag Based']");
        private By editDataTranspaltions = By.XPath("//span[text()='Edit Data Translations']");
        private By reverseFlowReport = By.XPath("//span[text()='Reverse Flow Report']");

        private By highConsumptionReportSwitch = By.XPath("//div[18]/span/sd-feature-panel/div/div[2]/div/ul/li[11]/sd-permission/div/span[2]/kendo-switch/span");
        private By inactiveFlowReport = By.XPath("//span[text()='Inactive Flow Report']");
        private By inactiveFlowImg = By.XPath("//span[text()='Inactive Flow Report']/..//img");
        private By amiNoFlowImg = By.XPath("//span[text()='AMI No Flow Report']/..//img");
        private By editBundles = By.XPath("//span[text()='Edit Bundles']");
        private By foundMetersReport = By.XPath("//span[text()='Found Meters Report']");
        private By viewNSPDBConversion = By.XPath("//span[text()='View NSP DB Conversion']");
        private By foundMetersReportImg = By.XPath("//span[text()='Found Meters Report']/..//img");
        private By daysOfNoFlow = By.XPath("//span[text()='Days of No Flow (AMR)']");
        private By daysOfConsumption = By.XPath("//span[text()='Days of Consumption (AMR)']");
        private By daysOfConsecutiveFlow = By.XPath("//span[text()='Days of Consecutive Flow (AMI) - Flag Based']");
        private By neptune360lftnavPropertyImg = By.XPath("//span[text()='Neptune 360 Sync Left Navigation']/..//img");
        private By miuLoggingImg = By.XPath("//span[text()='MIU Logging']/..//img");
        private By advancedRFTestImg = By.XPath("//span[text()='Advanced RF Test']/..//img");
        private By lftNavGroupsImg = By.XPath("//span[text()='Groups Left Navigation']/..//img");
        private By mmrPressureImg = By.XPath("//span[text()='Pressure']/..//img");
        private By viewUsagePlanImg = By.XPath("//span[text()='View Usage Plans']/..//img");
        private By createUsagePlanImg = By.XPath("//span[text()='Create Usage Plans']/..//img");
        private By mmrMeterReadingIMg = By.XPath("//span[text()='Meter Reading']/..//img");
        private By mmrSyncUnasssignedRoutes = By.XPath("//span[text()='Sync Unassigned Routes']/..//img");
        private By neptune360Partner = By.XPath("//span[text()='Neptune 360 Partner']");
        private By neptuneFieldService = By.XPath("//span[text()='Neptune Field Service PM']");
        private By neptuneCustSupport = By.XPath("//span[text()='Neptune Customer Support']");
        private By neptuneUtilityAdminBeta = By.XPath("//span[text()='Utility Administrator Beta']");
        private By neptuneCSR = By.XPath("//span[text()='Neptune Customer Service Rep']");
        private By mobileAppUser = By.XPath("//span[text()='Mobile Application User']");
        private By handheldLftImg = By.XPath("//span[text()='Handhelds Left Navigation']/..//img");
        private By daysOfConsFlowImg = By.XPath("//span[text()='Days of Consecutive Flow (AMI) - Flag Based']/..//img");
        private By daysOfConsFlowConsmpBasedImg = By.XPath("//span[text()='Days of Consecutive Flow (AMI) - Consumption Based']/..//img");
        private By endPointConsumptionReportImg = By.XPath("//span[text()='Endpoint Consumption Report']/..//img");
        private By reverseFlowReportImg = By.XPath("//span[text()='Reverse Flow Report']/..//img");
        private By dashboardLeftImg = By.XPath("//span[text()='Dashboard Left Navigation']/..//img");
        private By custInqImg = By.XPath("//span[text()='Customer Inquiry Left Navigation']/..//img");
        private By utilityManagementImg = By.XPath("//span[text()='Utility Management Left Navigation']/..//img");
        private By billingServicesImg = By.XPath("//span[text()='Billing Services Left Navigation']/..//img");
        private By apiDeploymentLftNavImg = By.XPath("//span[text()='API Deployment Left Navigation']/..//img");
        private By editBundlesImg = By.XPath("//span[text()='Edit Bundles']/..//img");
        private By handheldsSettingImg = By.XPath("//span[text()='Handheld Settings Left Navigation']/..//img");
        private By handheldManagementImg = By.XPath("//span[text()='Handheld Management Left Navigation']/..//img");
        private By fileMapperLftNavImg = By.XPath("//span[text()='File Mapper Left Navigation']/..//img");
        private By fileMapperImg = By.XPath("//span[text()='File Mapper']/..//img");
        private By partnerManagementLftNavImg = By.XPath("//span[text()='Partner Management Left Navigation']/..//img");
        private By viewPartnerManagementImg = By.XPath("//span[text()='View Partner Management']/..//img");
        private By createPartnerImg = By.XPath("//span[text()='Create Partners']/..//img");
        private By editPartnersImg = By.XPath("//span[text()='Edit Partners']/..//img");
        private By viewAllNetworkImg = By.XPath("//span[text()='View All Network Health Dashboard Widgets']/..//img");
        private By usagePlansLftNavImg = By.XPath("//span[text()='View Usage Plans']/..//img");
        private By cancelUpdateImg = By.XPath("//span[text()='Cancel Update']/..//img");
        private By editDataTranslationsImg = By.XPath("//span[text()='Edit Data Translations']/..//img");
        private By viewImportRulesImg = By.XPath("//span[text()='View Import Rules']/..//img");
        private By editImportRulesImg = By.XPath("//span[text()='Edit Import Rules']/..//img");
        private By editUsagePlanImg = By.XPath("//span[text()='Edit  Usage Plans']/..//img");
        private By alertConfigScreenImg = By.XPath("//span[text()='Alert Configuration Screen']/..//img");
        private By viewalertNotificationImg = By.XPath("//span[text()='View Alert Notifications']/..//img");
        private By viewAPIdepImg = By.XPath("//span[text()='View API Deployment']/..//img");
        private By createBundlesImg = By.XPath("//span[text()='Create Bundles']/..//img");
        private By sdkAccessLftNavImg = By.XPath("//span[text()='SDK Access Left Navigation']/..//img");
        private By viewSdkAccessImg = By.XPath("//span[text()='View SDK Access']/..//img");
        private By logoutTopNavImg = By.XPath("//span[text()='Logout Top Navigation']/..//img");
        private By viewUsersImg = By.XPath("//span[text()='View Users']/..//img");
        private By createUserImg = By.XPath("//span[text()='Create Users']/..//img");
        private By searchUserImg = By.XPath("//span[text()='Search Users']/..//img");
        private By editUserImg = By.XPath("//span[text()='Edit Users']/..//img");
        private By deactivateUserImg = By.XPath("//span[text()='Deactivate Users']/..//img");
        private By sendPwdResetImg = By.XPath("//span[text()='Send Password Reset']/..//img");
        private By usersImg = By.XPath("//span[text()='Users']/..//img");
        private By userProfileImg = By.XPath("//span[text()='User Profile']/..//img");
        private By userManagementImg = By.XPath("//h3[text()='User Management']/..//img");
        private By reportsLeftNavImg = By.XPath("//span[text()='Reports Left Navigation']/..//img");
        private By routeManagementImg = By.XPath("//span[text()='Route Management Left Navigation']/..//img");
        private By routeAssignmentImg = By.XPath("//span[text()='Route Assignments Left Navigation']/..//img");
        private By dashboardNetworkImg = By.XPath("//span[text()='Dashboard Network Health Left Navigation']/..//img");
        private By alertConfigImg = By.XPath("//span[text()='Alert Configuration Left Navigation']/..//img");
        private By notificationImg = By.XPath("//span[text()='Notifications Left Navigation']/..//img");
        private By editalertConfigImg = By.XPath("//span[text()='Edit Alert Configurations']/..//img");
        private By rolePermImg = By.XPath("//span[text()='Roles and Permissions Left Navigation']/..//img");
        private By createUtilitiesImg = By.XPath("//span[text()='Create Utilities']/..//img");
        private By editUtilitiesImg = By.XPath("//span[text()='Edit Utilities']/..//img");
        private By viewUtilitiesImg = By.XPath("//span[text()='View Utilities']/..//img");
        private By utilitieManagementImg = By.XPath("//span[text()='Utilities Management']/..//img");
        private By platformManagementImg = By.XPath("//span[text()='Platform Management Left Navigation']/..//img");
        private By homeTopNavImg = By.XPath("//span[text()='Home Top Navigation']/..//img");
        private By profileTopNavImg = By.XPath("//span[text()='Profile Top Navigation']/..//img");
        private By chooseUtilitiesTopNavImg = By.XPath("//span[text()='Choose Utilities']/..//img");
        private By alertNotificationTopNavImg = By.XPath("//span[text()='Alert Notifications Top Navigation']/..//img");
        private By createCodesImg = By.XPath("//span[text()='Create Codes']/..//img");
        private By searchCodesImg = By.XPath("//span[text()='Search Codes']/..//img");
        private By editCodesImg = By.XPath("//span[text()='Edit Codes']/..//img");
        private By viewCodesImg = By.XPath("//span[text()='View Codes']/..//img");
        private By alertNotificationImg = By.XPath("//span[text()='Alert Notifications Screen']/..//img");
        private By selectanddeleteCodesImg = By.XPath("//span[text()='Select and Delete Codes']/..//img");
        private By EditrolesPage = By.XPath("//span[text()='View Users']/..//following-sibling::span/Kendo-switch");

        private By viewHandheldImg = By.XPath("//span[text()='View Handhelds']/..//img");
        private By createHandheldImg = By.XPath("//span[text()='Create Handhelds']/..//img");
        private By editHandheldImg = By.XPath("//span[text()='Edit Handhelds']/..//img");
        private By viewHandheldSettingImg = By.XPath("//span[text()='View Handheld Settings']/..//img");
        private By editHandheldSettingImg = By.XPath("//span[text()='Edit Handheld Settings']/..//img");
        private By viewNeptuneConnectImg = By.XPath("//span[text()='View Neptune 360 Sync Screen']/..//img");
        private By downloadNeptuneConnectImg = By.XPath("//span[text()='Download Neptune 360 Sync']/..//img");

        private By routeManagementWidgetEdit = By.XPath("//div[3]//sd-modules//div[13]/span/sd-feature-panel//div[2]//ul/li[8]/sd-permission/div/span[2]/kendo-switch/span");
        private By routeManagementLftNavEdit = By.XPath("//sd-modules/form//div[3]/span/sd-feature-panel//div/ul/li[13]/sd-permission/div/span[2]/kendo-switch/span");
        private By viewRouteManagementDashboardEdit = By.XPath("//sd-roles-management//sd-modules/form//div[11]/span/sd-feature-panel//div[2]//ul/li[1]/sd-permission/div/span[2]");
        private By routeAssignmentLftNavEdit = By.XPath("//sd-roles-management//sd-modules//div[2]/div[3]/span/sd-feature-panel//ul/li[12]/sd-permission/div/span[2]");
        private By routeAssignmentScreenEdit = By.XPath("//sd-roles-management//sd-modules//div[11]/span/sd-feature-panel//div/ul/li[4]/sd-permission//span[2]/kendo-switch/span");
        private By displayAsReaderEdit = By.XPath("//sd-roles-management//sd-modules//div[11]/span/sd-feature-panel//ul/li[3]/sd-permission/div/span[2]/kendo-switch/span");
        private By collector = By.XPath("//kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[1]/a");
        private By meterReadingSwitch = By.XPath("//div[15]/span/sd-feature-panel//ul/li[4]/sd-permission/div/span[2]/kendo-switch");
        private By invalidReadingsSwitch = By.XPath("//span[text()='Invalid Readings Report']/..//following-sibling::span/kendo-switch");
        private By advanceRFTestSwitch = By.XPath("//div[15]/span/sd-feature-panel//ul/li[1]/sd-permission/div/span[2]/kendo-switch");
        private By miuLoggingSwitch = By.XPath("//div[15]/span/sd-feature-panel//ul/li[2]/sd-permission/div/span[2]/kendo-switch");
        private By pressureSwitch = By.XPath("//div[15]/span/sd-feature-panel//ul/li[3]/sd-permission/div/span[2]/kendo-switch");
        private By amiNoFlowSwitch = By.XPath("//span[text()='AMI No Flow Report']/..//following-sibling::span/kendo-switch");
        private By inactiveFlowSwitch = By.XPath("//div[19]/span/sd-feature-panel//ul/li[10]/sd-permission/div/span[2]/kendo-switch");
        private By inactiveFlowSwitchLocator = By.XPath("//h5//span[text()='Reporting']/ancestor::sd-feature-panel//../..//span[text()='AMI No Flow Report']//following-sibling::span/kendo-switch");
        private By reportLeftNavigation = By.XPath("//div[3]/span/sd-feature-panel//ul/li[14]/sd-permission/div/span[2]/kendo-switch");
        private By fileMapperToggle = By.XPath("//span[text()='File Mapper Left Navigation']/..//kendo-switch");
        private By deleteOwnCommSwitch = By.XPath("//span[text()='Delete Own Comments']/..//kendo-switch");
        private By deleteOthersCommentSwitch = By.XPath("//span[text()='Delete Others Comments']/..//kendo-switch");
        private By daysOfConsecutiveFlowSwitch = By.XPath("//span[text()='Days of Consecutive Flow (AMI) - Flag Based']/..//kendo-switch");
        private By softDisconnectSwitch = By.XPath("//span[text()='Soft Disconnect Report']/..//kendo-switch");
        private By billingServicesSettingSwitch = By.XPath("//span[text()='Billing Services Left Navigation']/..//kendo-switch");
        private By endpointMaintenanceSwitch = By.XPath("//span[text()='Endpoint Maintenance Report']/..//kendo-switch");
        private By daysofConsFlowAMIBasedSwitch = By.XPath("//span[text()='Days of Consecutive Flow (AMI) - Flag Based']/..//kendo-switch");
        private By endpointConsumptionReportSwitch = By.XPath("//span[text()='Endpoint Consumption Report']/..//kendo-switch");
        private By reverseFlowSwitch = By.XPath("//span[text()='Reverse Flow Report']/..//kendo-switch");
        private By devicename = By.XPath("//th[text()='Device Name']");
        private By utilityUserSearch = By.XPath("//input[@id='txtAccountSearch']");
        private By utilityName = By.XPath("//div[@class='user-display-name']");
        private By statusDropdown = By.XPath("//div[5]/div/kendo-dropdownlist/span/span[1]");
        private By dropDownInactive = By.XPath("//li[contains(.,'Inactive')]");
         private By Notification = By.XPath("//i[@class='fa fa-bell-o']");
        private By NotificationClose = By.XPath("//i[@class='fa fa-times close-modal']");
        private By Editbutton = By.XPath("//button[text()='Edit']");
        private By Viewuser = By.XPath("//span[text()='View Users']");
        private By Viewuser1 = By.XPath("//span[@class='permission-name disabled']");
        private By Enabledcol = By.XPath("k-input-value-text");
        private By Gateway = By.XPath("//td[text()=' Gateway ']/..//following-sibling::td//a[@id='itemlink']");
        #endregion

        /// <summary>
        /// Method to Validate Create Role
        /// </summary>
        public void ValidateCreateRole()
        {
            driver.CheckElementExists(btnCreate, "Create");
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementExists(roleOptionsScreen, "Role Options Screen");
        }

        /// <summary>
        /// Method to Validate Create Role Button Does Not Exists
        /// </summary>
        public void ValidateCreateRoleButtonDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnCreate, "Create");
        }

        /// <summary>
        /// Method to Validate Edit Role
        /// </summary>
        public void ValidateEditRole()
        {
            driver.ClickElement(lftNavPlatformManagement, "Neptune Customer Service Rep");
            driver.ClickElement(lftNavRoleManagement, "Edit");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(neptune360essentials, "Neptune 360 Essentials");
            string value=driver.GetElementAttribute(Viewuser, "class");
            if (value.Contains("disabled"))
            {
                ReporterFactory.LogFailure("Permission is not enabled");
            }
            else
            {
                testReport.Pass("permssions are enabled");
            }
        }

        /// <summary>
        /// Method to Validate Edit Role Button Does Not Exists
        /// </summary>
        public void ValidateEditRoleButtonDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnEdit, "Edit");
        }

        /// <summary>
        /// Method to Validate Enable Disable Permissions
        /// </summary>
        public void ValidateEnableDisablePermissions()
        {
            driver.ClickElement(drpEnabDisabIM, "Identity Management");
            driver.ClickElement(drpValueDisabled, "Disabled");
            driver.ClickElement(lstItemRoleNeptuneCustServRep, "Neptune Customer Service Rep");
            driver.ClickElement(drpEnabDisabIM, "Identity Management");
            driver.ClickElement(drpValueEnabled, "Enabled");
            driver.ClickElement(drpEnabDisabUM, "Utility Management");
            driver.ClickElement(drpValueDisabled, "Disabled");
            driver.ClickElement(lstItemRoleNeptuneCustServRep, "Neptune Customer Service Rep");
            driver.ClickElement(drpEnabDisabUM, "Utility Management");
            driver.ClickElement(drpValueEnabled, "Enabled");
            driver.ClickElement(drpEnabDisabLN, "Left Navigation");
            driver.ClickElement(drpValueDisabled, "Disabled");
            driver.ClickElement(lstItemRoleNeptuneCustServRep, "Neptune Customer Service Rep");
            driver.ClickElement(drpEnabDisabLN, "Left Navigation");
            driver.ClickElement(drpValueEnabled, "Enabled");
        }

        /// <summary>
        /// Method to Validate Enable Disable Permissions Not Displayed
        /// </summary>
        public void ValidateEnableDisablePermissionsNotDisplayed()
        {
            driver.CheckElementDoesnotExists(drpValueDisabled, "Disabled");
            driver.CheckElementDoesnotExists(drpValueEnabled, "Enabled");
        }

        /// <summary>
        /// Method to Validate View Role
        /// </summary>
        public void ValidateViewRole()
        {
            driver.CheckElementExists(lstItemRoleNeptuneCustServRep, "Neptune Customer Service Rep");
            driver.CheckElementExists(roleOptionsScreen, "Role Options Screen");
        }

        /// <summary>
        /// Method to Validate View Role Does Not Exists
        /// </summary>
        public void ValidateViewRoleDoesNotExists()
        {
            driver.CheckElementDoesnotExists(lstItemRoleNeptuneCustServRep, "Neptune Customer Service Rep");
        }

        /// <summary>
        /// Method to Validate Delete Role
        /// </summary>
        public void ValidateDeleteRole()
        {
            driver.ClickElement(lstItemRoleNeptuneCustServRep, "Neptune Customer Service Rep");
            driver.CheckElementExists(btnDelete, "Delete");
            driver.ClickElement(btnDelete, "Delete");
            driver.CheckElementDoesnotExists(lstItemRoleNeptuneCustServRep, "Neptune Customer Service Rep");
        }

        /// <summary>
        /// Method to Validate Delete Role
        /// </summary>
        public void ValidateDeleteRoleButtonDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnDelete, "Delete");
        }

        /// <summary>
        /// Method to Validate LIst of Roles
        /// </summary>
        public void ValidateListOfRoles()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform MAnagement");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.CheckElementDisplayed(listofRoles, "List Of Roles");
        }

        /// <summary>
        /// Method to Validate Question Mark
        /// </summary>
        public void ValidateQuestionMark()
        {
            driver.ClickElement(questionMark, "Question Mark (?) ");
            driver.switchToNewWindow();
            driver.sleepTime(2000);
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Send Password Reset
        /// </summary>
        public void ValidateSendPasswordReset()
        {
            driver.ClickElement(screenUserManagement, "User Management");
            driver.ClickElement(btnEdit, "Edit");
            driver.CheckElementDisplayed(sendPwdReset, "Send Password Reset");
        }

        /// <summary>
        /// Method to Validate Create Utility
        /// </summary>
        public void ValidateCreateUtilityDialog()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.WaitForElement(btnCreateUtility, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreateUtility, "Create");
            driver.CheckElementDisplayed(createUtilityDialog, "Create Utility Dialog");
            driver.ClickElement(btnCancelcreateUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate CSR Notification Left Nav
        /// </summary>
        public void ValidateCSRNotificationLeftNav()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavEmailNotifications, "Email Notification");
            driver.WaitForElement(breadCrumb, TimeSpan.FromSeconds(5));
            if (driver.GetElementText(breadCrumb).Equals("EMAIL NOTIFICATION TEMPLATES"))
            {
                testReport.Pass("EMAIL NOTIFICATION TEMPLATES Page is Displayed");
            }
            else
            {
                ReporterFactory.LogFailure("EMAIL NOTIFICATION EDITOR is Not Displayed");
            }
        }

        /// <summary>
        /// Method to Validate Utility Admin Notification Left Nav
        /// </summary>
        public void ValidateUtilityAdminNotificationLeftNav()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavEmailNotifications, "Email Notification");
            driver.WaitForElement(breadCrumb, TimeSpan.FromSeconds(5));
            if (driver.GetElementText(breadCrumb).Equals("EMAIL NOTIFICATION TEMPLATES"))
            {
                testReport.Pass("Email Notification Templates Page is Displayed");
            }
            else
            {
                ReporterFactory.LogFailure("Email Notification Templates is Not Displayed");
            }
        }

        /// <summary>
        /// Method to Validate Utility Read Only Create Notification
        /// </summary>
        public void ValidateUtilityReadOnlyCreateNotificationNo()
        {
            driver.ClickElement(Notification, "Notifications");
            driver.sleepTime(6000);
            driver.ClickElement(NotificationClose, "Close");
            driver.CheckElementDoesnotExists(btnNotifications, "No Notifications displayed");
        }

        /// <summary>
        /// Method to Validate API deployment system admin ON
        /// </summary>
        public void ValidateAPIDeploymentSystemAdminON()
        {
            driver.CheckElementDoesnotExists(btnDelete, "Delete");
        }

        /// <summary>
        /// Method to Validate Roles n Perm Page Displayed
        /// </summary>
        public void ValidateRolesnPermPageDisplayed()
        {
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(breadCrumb, "ROLE MANAGEMENT");
        }

        /// <summary>
        /// Method to Validate Create Field
        /// </summary>
        public void ValidateCreateField()
        {
            driver.ClickElement(lftNavPlatformManagement, "platform management");
            driver.ClickElement(lftNavRoleManagement, "role management");
            driver.CheckElementDisplayed(btnCreate, "create");
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDisplayed(role, "role");
            driver.CheckElementDisplayed(createRoletxtbox, "Create Role Text Box");
        }

        /// <summary>
        /// Method to Validate Cancelling Create Role
        /// </summary>
        public void ValidateCancellingCreateRole()
        {
            driver.ClickElement(lftNavPlatformManagement, "platform management");
            driver.ClickElement(lftNavRoleManagement, "role management");
        string value = driver.GetElementText(role);
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDisplayed(createRoletxtbox, "Create Role Text Box");
            driver.SendKeysToElement(createRoletxtbox, "Test", "Create Role");
            string value1 = driver.GetElementText(role);
            driver.ClickElement(btnCancel, "Cancel");
            string value2 = driver.GetElementText(role);
            if (value.Equals(value2))
            {
                testReport.Pass("role is not displayed");
            }
            else
            {
                ReporterFactory.LogFailure("role should be displayed");
            }
        }

        /// <summary>
        /// Method to Validate Landing Page
        /// </summary>
        public void ValidateLandingPage()
        {
            driver.WaitForElement(btnHome, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(btnHome, "Home");
        }

        /// <summary>
        /// Method to Validate Search Acc option not available
        /// </summary>
        public void ValidateSearchAccNotAvail()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(txtAccountSearch, "Search");
        }

        /// <summary>
        /// Method to Validate Dashboard Widget
        /// </summary>
        public void ValidateDashboardWidget()
        {
            driver.CheckElementDisplayed(btnDashBoard, "Dashboard Button");
        }
        public void ValidateNeptuneOnly()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDisplayed(neptuneOnly, "Neptune Only ");
            driver.CheckElementDisplayed(createRoletxtbox, "Create Role Text Box");
            driver.SendKeysToElement(createRoletxtbox, "Test1879", "Create Role");
            driver.ClickElement(btnDone_EditPermission, "done");
            driver.CheckElementDisplayed(Toastmessagerole, "role has been updated");
            
        }
        public void ValidateNeptuneOnlyToON()
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(btnDoneEdit, "Done");
            //driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, "Toast Message");
        }
        public void ValidateNeptuneOnlyToOff()
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(btnDoneEdit, "Done");
            driver.ClickElement(neptuneOnlyOnOff, "");
            //driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            //driver.CheckElementDisplayed(toastMessage, "Toast Message");
        }
        /// <summary>
        /// Method to Validate Customer Inquiery Widget not displayed
        /// </summary>
        public void ValidateCustomerInquirydWidget()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(btnCustomerInquiry, "Customer Inquiry Button");
        }

        /// <summary>
        /// Method to Validate Customer Billing Services Widget not displayed
        /// </summary>
        public void ValidateBillingServicesWidget()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(btnBillingServices, "Billing Services Button");
        }

        /// <summary>
        /// Method to Validate Customer Notifications Widget not displayed
        /// </summary>
        public void ValidateNotificationsWidget()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(btnNotifications, "Notifications Button");
        }
        /// <summary>
        /// Method to Validate Customer User_Management Widget not displayed
        /// </summary>
        public void ValidateUserManagementWidget()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(lftNavUserManagement, "user Management");
        }

        /// <summary>
        /// Method to Validate Customer Utility Management Widget not displayed
        /// </summary>
        public void ValidateUtilityManagementWidget()
        {
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(btnUtilityManagement, "Utility Management");
        }

        /// <summary>
        /// Method to Validate Customer Route Management Widget not displayed
        /// </summary>
        public void ValidateRouteManagementWidget()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(btnRouteManagement, "Route Management");
        }

        /// <summary>
        /// Method to Validate Utility Management Left Navigation
        /// </summary>
        public void ValidateUtilityManagementLeftNavigation()
        {
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(lftNavUtilityManagement, "Utility Management Left Navigation");
        }

        /// <summary>
        /// Method to Validate Dashboard Access
        /// </summary>
        public void ValidateDashboardAccess()
        {
          
            if (driver.CheckElementDisplayed(By.XPath("//span[text()='DASHBOARD']"), "Dashboard"))
            {
                testReport.Pass(driver.CheckElementDisplayed(By.XPath("//span[text()='DASHBOARD']"), "Dashboard") + " Page is accessible.");
            }
        }
        /// <summary>
        /// Method to Validate Search Utility Access
        /// </summary>
        public void ValidateSearchUtility()
        {
            driver.sleepTime(2000);
            // driver.ClickElement(selectUtility, "Utility Dropdown");
            driver.ClickElement(selectUtility, "Utility Dropdown");
            driver.ClickElement(btnCloseUtility, "Close");
        }

        /// <summary>
        /// Method to Validate Search Utility Access
        /// </summary>
        public void ValidateSearchUtilityNotExists()
        {
            driver.ClickElement(selectUtility, "Utility Dropdown");
            driver.CheckElementDoesnotExists(utilitySearchTextbox, "Search Bar");
        }

        public void ValidateFilterUtilities()
        {
            driver.sleepTime(2000);
            // driver.ClickElement(selectUtility, "Utility Dropdown");
            driver.ClickElement(selectUtility, "Utility Dropdown");
            driver.CheckElementDisplayed(utilitySearchTextbox, "Search Bar");
            driver.ClickElement(btnCloseUtility, "Close");
        }

        /// <summary>
        /// Method to Validate Import Files Left Navigation
        /// </summary>
        public void ValidateImportFilesLftNav()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(lftNavImport, "Import Files Left Navigation");
        }

        /// <summary>
        /// Method to Validate Export Files Left Navigation
        /// </summary>
        public void ValidateExportFilesLftNav()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(lftNavExport, "Export Files Left Navigation");
        }

        /// <summary>
        /// Method to Validate Export History Left Navigation
        /// </summary>
        public void ValidateExportHistoryLftNav()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(lftNavExport, "Export History Left Navigation");
        }

        /// <summary>
        /// Method to Validate Account Management
        /// </summary>
        public void ValidateAccManagement()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(accManagement, "Account Management");
        }

        /// <summary>
        /// Method to Validate Create Account
        /// </summary>
        public void ValidateCreateAccount()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(createAcc, "Create Account");
        }

        /// <summary>
        /// Method to Validate Manage Account
        /// </summary>
        public void ValidateManageAccount()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(manageAcc, "Manage Account");
        }
        /// <summary>
        /// Method to Validate Customer Inquiry Left Nav
        /// </summary>
        public void ValidateCustomerInquiryLeftNav()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(lftNavCustomerInquiry, "Customer Inquiry");
        }

        /// <summary>
        /// Method to Validate Billing Services Left Nav
        /// </summary>
        public void ValidateBillingServicesLeftNav()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(lftNavBillingServices, "Billing Services");
        }

        /// <summary>
        /// Method to Validate Utility Management Left Nav
        /// </summary>
        public void ValidateUtilityManagementLeftNav()
        {
            driver.sleepTime(2000);
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.CheckElementDisplayed(lftNavDeviceManagement, "Device Management");
        }
        /// <summary>
        /// Method to Validate Alert Management Left Nav
        /// </summary>
        public void ValidateAlertManagementLeftNav()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(lftNavAlertConfiguration, "ALERT MANAGEMENT");
        }

        /// <summary>
        /// Method to Validate Endpoint Management Left Nav
        /// </summary>
        public void ValidateEndPointManagementLeftNav()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(endPointmanagmnt, "ENDPOINT MANAGEMENT");
        }

        /// <summary>
        /// Method to Validate Create MIU Left Nav
        /// </summary>
        public void ValidateCreateMIULeftNav()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(createMIU, "CREATE MIU");
        }

        /// <summary>
        /// Method to Validate CMIU Mode Management
        /// </summary>
        public void ValidateCMIUModeManagement()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(CMIUMode, "CMIU Mode Management");
        }

        /// <summary>
        /// Method to Validate Platform Management Left Nav
        /// </summary>
        public void ValidatePlatformManagementLeftNav()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(lftNavPlatformManagement, "Platform MANAGEMENT");
        }
        /// <summary>
        /// Method to Validate User Management Left Nav
        /// </summary>
        public void ValidateUserManagementLeftNav()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(lftNavUserManagement, "User MANAGEMENT");
        }
        /// <summary>
        /// Method to Validate Route Management Menu Item
        /// </summary>
        public void ValidateRouteManagementMenu()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(btnRouteManagement, "Route Management");
        }

        /// <summary>
        /// Method to Validate Route Assignement left Menu Item
        /// </summary>
        public void ValidateRouteAssignementMenu()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(lftNavrouteAssignment, "Route Assignment");
        }

        /// <summary>
        /// Method to Validate Notification left Menu Item
        /// </summary>
        public void ValidateNotificationMenu()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(lftNavEmailNotifications, "Left Notification");
        }

        /// <summary>
        /// Method to Validate Roles And Permissions Left Navigation
        /// </summary>
        public void ValidateRolesAndPermissionsLeft()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(lftNavRolesAndPermissions, "Roles And Permissions Left Navigation");
        }
        /// <summary>
        /// Method to Validate Top Navigation
        /// </summary>
        public void ValidateTopNavigation()
        {
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(topNavigation, "Top Navigation");
        }
        /// <summary>
        /// Method to Validate Home Top Navigation
        /// </summary>
        public void ValidateHomeTopNavigation()
        {
            driver.WaitForElement(drpProfileLogOut, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(drpProfileLogOut, "Home Top Navigation");
        }

        /// <summary>
        /// Method to Validate Profile Top Navigation
        /// </summary>
        public void ValidateProfileTopNavigation()
        {
            driver.sleepTime(2000);
            driver.ClickElement(drpProfileLogOut, "Home Top Navigation");
            driver.CheckElementDisplayed(btnProfile, "Profile");
            driver.ClickElement(drpProfileLogOut, "Home Top Navigation");
        }

        /// <summary>
        /// Method to Validate Alert Top Navigation
        /// </summary>
        public void ValidateAlertTopNavigationNoView()
        {
            driver.WaitForElement(drpProfileLogOut, TimeSpan.FromSeconds(10));
            driver.ClickElement(drpProfileLogOut, "Home Top Navigation");
            driver.CheckElementDoesnotExists(btnAlert, "Alert");
            driver.ClickElement(drpProfileLogOut, "Home Top Navigation");
        }

        /// <summary>
        /// Method to Validate Route MAnagement Left Nav
        /// </summary>
        public void ValidateRouteManagementLeftNav()
        {
            driver.CheckElementDisplayed(routeManagementLftNav, "Route Management Left Nav");
        }

        /// <summary>
        /// Method to Validate Route MAnagement Widget
        /// </summary>
        public void ValidateRouteManagementWidgetDisplayed()
        {
            driver.CheckElementDisplayed(routeManagementWidget, "Route Management Widget");
        }

        /// <summary>
        /// Method to Validate Route MAnagement Widget
        /// </summary>
        public void ValidateRouteManagementWidgetEditable()
        {
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(2000);
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(routeManagementWidgetEdit, "Route Management Widget");
            driver.sleepTime(2000);
            driver.ClickElement(btnCancel, "Cancel");
            testReport.Info("Route Management Widget permission under Landing Page section is editable");
        }

        /// <summary>
        /// Method to Validate Route Management Left Nav Editable
        /// </summary>
        public void ValidateRouteManagementLeftNavEditable()
        {
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(2000);
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(routeManagementLftNavEdit, "Route Management Left Nav Editable");
            driver.sleepTime(2000);
            driver.ClickElement(btnCancel, "Cancel");
            testReport.Info("Route Management Left Nav permission under Landing Page section is editable");
        }

        /// <summary>
        /// Method to Validate View Route Management Dashboard Editable
        /// </summary>
        public void ValidateViewRouteManagementDashboardEditable()
        {
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(2000);
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(viewRouteManagementDashboardEdit, "View Route Management Dashboard");
            driver.sleepTime(2000);
            driver.ClickElement(btnCancel, "Cancel");
            testReport.Info("View Route Management Dashboard permission under Route Management section is editable");
        }

        /// <summary>
        /// Method to Validate View Route Management Dashboard
        /// </summary>
        public void ValidateViewRouteManagementDashboard()
        {
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(viewRouteManagementDashboard, "View Route Management Dashboard");
            testReport.Info("View Route Management Dashboard permission is displayed under Route Management section");
        }

        /// <summary>
        /// Method to Validate View Route Assignment Screen
        /// </summary>
        public void ValidateViewRouteAssignmentScreen()
        {
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(routeAssignmentScreen, "Route Assignment Screen");
            testReport.Info("Edit Assignments permission is displayed under the Route Management section");
        }

        /// <summary>
        /// Method to Validate View Edit Assignment Permission
        /// </summary>
        public void ValidateViewEditAssignmentPermission()
        {
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(editAssignmentPermission, "Edit Assignment Permission");
            testReport.Info("Edit Assignments permission is displayed under the Route Management section");
        }

        /// <summary>
        /// Method to Validate View Route Assignment Screen Editable
        /// </summary>
        public void ValidateViewRouteAssignmentScreenEditable()
        {
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(2000);
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(routeAssignmentScreenEdit, "Route Assignment Screen Editable");
            driver.sleepTime(2000);
            driver.ClickElement(btnCancel, "Cancel");
            testReport.Info("Route Assignment Screen is editable");
        }

        /// <summary>
        /// Method to Validate Display As Reader Editable
        /// </summary>
        public void ValidateDisplayAsReaderEditable()
        {
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(2000);
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(displayAsReaderEdit, " Display As Reader");
            driver.sleepTime(2000);
            driver.ClickElement(btnCancel, "Cancel");
            testReport.Info(" Display As Reader is editable");
        }
        public void ValidateFoundMetersEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "platform management");
            driver.ClickElement(lftNavRoleManagement, "Role management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(2000);
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(foundMetersReport, " Found Meters");
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(EditrolesPage, "Found Meters Report"))
            {
                testReport.Pass("Found Meters report is editable");
            }
            else
            {
                ReporterFactory.LogFailure("Found Meters report is not editable");

            }
        }

        /// <summary>
        /// Method to Validate View Route Assignment Lft Nav
        /// </summary>
        public void ValidateViewRouteAssignmentLftNav()
        {
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(2000);
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(routeAssignmentLftNavEdit, "Route Assignment Lft Nav Toggle");
            driver.sleepTime(2000);
            driver.ClickElement(btnCancel, "Cancel");
            testReport.Info("Route Assignments Left Navigation permission under Left Navigation section is editable");
        }

        /// <summary>
        /// Method to Validate View Route Assignment Lft Nav editable
        /// </summary>
        public void ValidateViewRouteAssignmentLftNavEditable()
        {
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(routeAssignmentLeftNav, "Route Assignment Lft Nav");
            testReport.Info("Route Assignments Left Navigation permission is displayed under Left Navigation section");
        }

        /// <summary>
        /// Method to Validate Logout Top Navigation
        /// </summary>
        public void ValidateLogoutTopNavigation()
        {
            driver.ClickElement(drpProfileLogOut, "Home Top Navigation");
            driver.CheckElementDisplayed(btnLogOut, "Logout");
            driver.ClickElement(drpProfileLogOut, "Home Top Navigation");
        }

        /// <summary>
        /// Method to Validate Quistion Mark Top Navigation
        /// </summary>
        public void ValidateQuistionMarkTopNavigation()
        {
            driver.WaitForElement(btnQuestionTopNavigation, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(btnQuestionTopNavigation, "Quistion Mark");
        }

        /// <summary>
        /// Method to Validate Help Mark Top Navigation
        /// </summary>
        public void ValidateHelpMarkTopNavigation()
        {
            driver.ClickElement(drpHelp, "Dropdown");
            driver.CheckElementDisplayed(helpContent, "Help Content");
        }

        /// <summary>
        /// Method to Validate Neptune 360 Mark Top Navigation
        /// </summary>
        public void ValidateNeptune360MarkTopNavigation()
        {
            driver.ClickElement(drpHelp, "Dropdown");
            driver.CheckElementDisplayed(aboutNeptune360, "Neptune 360 Mark Top Navigation");
        }

        /// <summary>
        /// Method to Validate Choose Utility Top Navigation
        /// </summary>
        public void ValidateChooseUtilityTopNavigation()
        {
            driver.WaitForElement(selectUtility, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(selectUtility, "Choose Utility Top Navigation");
        }

        /// <summary>
        /// Method to Validate Dashboard Top Navigation
        /// </summary>
        public void ValidateDashboardNavigation()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.CheckElementDisplayed(breadCrumb, "Dashboard");
            driver.GetElementText(breadCrumb).Equals("DASHBOARD");
        }

        /// <summary>
        /// Method to Validate All Dashboard Widgets
        /// </summary>
        public void ValidateAllDashboardWidgets()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(systemConsumption, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(systemConsumption, "System Consumption");
            driver.CheckElementDisplayed(topTenConsumtionDetailReport, "Top 10 Consumption Detail");
            driver.CheckElementDisplayed(readingsKpiWidget, "Readings");
            driver.CheckElementDisplayed(consupmtion, "Consumption");
            driver.CheckElementDisplayed(reverseFlowWidget, "Reverse Flow");
            driver.CheckElementDisplayed(metersReadingsKpi, "Meters");

        }

        /// <summary>
        /// Method to Validate User Management Option
        /// </summary>
        public void ValidateUserManagementOption()
        {
            driver.CheckElementDoesnotExists(lftNavUserManagement, "User Management");
        }
        /// <summary>
        /// Method to Validate Create User 
        /// </summary>
        public void ValidateCreateUser()
        {
            driver.CheckElementDoesnotExists(btnCreate, "Create User");
        }

        /// <summary>
        /// Method to Validate Search User 
        /// </summary>
        public void ValidateSearchUserNotExist()
        {
            driver.CheckElementDoesnotExists(screenUserManagement, "Search User");
        }

        /// <summary>
        /// Method to Validate Edit User 
        /// </summary>
        public void ValidateEditUserNotExist()
        {
            driver.CheckElementDoesnotExists(userManagementImg, "user management widget");
          //  driver.ClickElement(userManagementImg, "user managemt widget");
          //  driver.CheckElementDisplayed(Editbutton, "Edit User");
        }
        public void ValidateEditUserExist()
        {
            driver.CheckElementExists(userManagementImg, "user management widget");
            driver.ClickElement(userManagementImg, "user managemt widget");
            driver.CheckElementDisplayed(Editbutton, "Edit User");
        }
        public void ValidateUserManagementWidgetExist()
        {
            driver.CheckElementExists(userManagementImg, "user management widget");
            driver.ClickElement(userManagementImg, "user managemt widget");
        }
        public void ValidateSearchUser(string user)
        {
            driver.CheckElementDisplayed(userManagementImg, "user management widget");
            driver.ClickElement(userManagementImg, "user managemt widget");
            driver.SendKeysToElementAndPressEnter(utilityUserSearch, user, "User Name");
            driver.WaitForElement(utilityName, TimeSpan.FromSeconds(40));
            driver.CheckElementDisplayed(utilityName, "User");
        }

        /// <summary>
        /// Method to Validate View User 
        /// </summary>
        public void ValidateViewUserNotExist()
        {
            driver.CheckElementDoesnotExists(screenUserManagement, "View User");
        }
        public void ValidateViewUser()
        {
            driver.CheckElementDisplayed(By.XPath("//h3[text()='User Management']/..//following-sibling::div/img"), "usermanagement widget");
            driver.ClickElement(By.XPath("//h3[text()='User Management']/..//following-sibling::div/img"), "user management widget");
            driver.CheckElementDisplayed(By.XPath("//div[@class='k-grid-table-wrap']"), "list of users");
            
        }

        /// <summary>
        /// Method to Validate Deactivate User 
        /// </summary>
        public void ValidateDeactivateUserDoesNotExist()
        {
            driver.CheckElementDoesnotExists(screenUserManagement, "Deactivate User");
        }

        /// <summary>
        /// Method to Validate Send Password Reset
        /// </summary>
        public void ValidateSendPasswordResetToOthers()
        {
            driver.CheckElementDoesnotExists(screenUserManagement, "Deactivate User");
        }

        /// <summary>
        /// Method to Validate Export Settings
        /// </summary>
        public void ValidateExportSettings()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(exportFiles, "Export Files");
            driver.sleepTime(1000);
            driver.ClickElement(routeOne, "Select File");
            driver.IsElementEnabled(btnExport, "Export");
        }

        public void ValidateExportSettingsDisabled()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(exportHistory, "Export History");
            driver.sleepTime(1000);
            driver.ClickElement(routeOne, "Select File");
            driver.ClickElement(btnExport, "Export");
            driver.IsElementDisabled(btnExport, "Export Setting");
        }

        /// <summary>
        /// Method to Validate Designate as neptune User
        /// </summary>
        public void ValidateDesignateNeptuneUser()
        {
            driver.CheckElementDoesnotExists(screenUserManagement, "Deactivate User");
        }

        /// <summary>
        /// Method to Validate Neptune Only
        /// </summary>
        public void ValidateNeptuneOnlyRoles()
        {
            driver.CheckElementDoesnotExists(screenUserManagement, "Deactivate User");
        }

        /// <summary>
        /// Method to Validate Utility Management Page
        /// </summary>
        public void ValidateUtilityManagementPage()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.GetElementText(pageHeader).Equals("Utility Management");
        }

        /// <summary>
        /// Method to Validate Create Utility
        /// </summary>
        public void ValidateCreateUtility()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.CheckElementDoesnotExists(btnCreate, "Create");
        }

        /// <summary>
        /// Method to Validate Edit Utility
        /// </summary>
        public void ValidateEditUtility()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.CheckElementDoesnotExists(btnEdit, "Edit");
        }

        /// <summary>
        /// Method to Validate Filter Utility
        /// </summary>
        public void ValidateFilterUtility()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.CheckElementDoesnotExists(btnFilter, "Filter");
        }

        /// <summary>
        /// Method to Validate View Utility
        /// </summary>
        public void ValidateViewUtility()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.CheckElementExists(breadCrumb, "Utility Page");
        }

        /// <summary>
        /// Method to Validate Deactivate Utility
        /// </summary>
        public void ValidateDeactivateUtility()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.CheckElementDoesnotExists(screenUserManagement, "Deactivate User");
        }

        /// <summary>
        /// Method to Validate Code Management Section
        /// </summary>
        public void ValidateCodeManagementSection()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.CheckElementDisplayed(codeManagement, "Code Management Section");
        }

        /// <summary>
        /// Method to Validate Create Code
        /// </summary>
        public void ValidateCreateCode()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.CheckElementDoesnotExists(btnCreate, "Create Code");
        }

        /// <summary>
        /// Method to Validate Edit Code
        /// </summary>
        public void ValidateEditCode()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.CheckElementDoesnotExists(btnEdit, "Edit Code");
        }

        /// <summary>
        /// Method to Validate View Code
        /// </summary>
        public void ValidateViewCode()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.CheckElementDisplayed(codeManagement, "View Code");
        }

        /// <summary>
        /// Method to Validate Delete Code
        /// </summary>
        public void ValidateDeleteCode()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.CheckElementDoesnotExists(btnDelete, "Delete Code");
        }

        /// <summary>
        /// Method to Validate Role Management
        /// </summary>
        public void ValidateRoleManagement()
        {
            driver.CheckElementDoesnotExists(btnRouteManagement, "Role Management");
        }

        /// <summary>
        /// Method to Validate Neptune Option ONly
        /// </summary>
        public void ValidateNeptuneOption()
        {
            driver.CheckElementDoesnotExists(neptuneOption, "Neptune Option ONly");
        }

        /// <summary>
        /// Method to Validate Create Role Meter Reader
        /// </summary>
        public void ValidateMeterReaderCreateRole()
        {
            driver.CheckElementDoesnotExists(lftNavUserManagement, "Create Role Meter Reader");
        }

        /// <summary>
        /// Method to Validate Enable/Disable Feature Group
        /// </summary>
        public void ValidateEnableDisableFeatureGroup()
        {
            driver.CheckElementDoesnotExists(lftNavUserManagement, "Enable/Disable Feature Group");
        }

        /// <summary>
        /// Method to Validate Meter Reader_Edit System-Level Role
        /// </summary>
        public void ValidateEditSystemLevelRole()
        {
            driver.CheckElementDoesnotExists(lftNavUserManagement, "Enable/Disable Feature Group");
        }

        /// <summary>
        /// Method to Validate Meter Reader Utility Meter Reader
        /// </summary>
        public void ValidateUtilityMeterReader()
        {
            driver.CheckElementDoesnotExists(btnCustomerInquiry, "Utililty Meter Reader");
        }

        /// <summary>
        /// Method to Validate Meter Reader View Consumption Matrix
        /// </summary>
        public void ValidateViewConsumptionMatrix()
        {
            driver.CheckElementDoesnotExists(btnCustomerInquiry, "View Consumption Matrix");
        }
        /// <summary>
        /// Method to Validate Meter Reader Customer Inquiry
        /// </summary>
        public void ValidateCustomerInquiry()
        {
            driver.CheckElementDoesnotExists(btnCustomerInquiry, "Customer Inquiry");
        }

        /// <summary>
        /// Method to Validate Meter Reader Dashboard
        /// </summary>
        public void ValidateDashboard()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            if (driver.GetElementText(breadCrumb).Equals("DASHBOARD"))
            {
                testReport.Pass("Dashboard Page Displayed");
            }
        }
        /// <summary>
        /// Method to Validate Meter Reader Import Management
        /// </summary>
        public void ValidateImportManagement()
        {
            driver.CheckElementDoesnotExists(btnBillingServices, "Import Management");
        }

        /// <summary>
        /// Method to Validate Meter Reader Device Management
        /// </summary>
        public void ValidateDeviceManagement()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.CheckElementDisplayed(breadCrumb, "Device Management");
        }

        /// <summary>
        /// Method to Validate Meter Reader Create Collector
        /// </summary>
        public void ValidateCollectorNotDisplayed()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.CheckElementDoesnotExists(collector, "Collector Name");
        }

        /// <summary>
        /// Method to Validate Meter Reader Build USB
        /// </summary>
        public void ValidateBuildUSB()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.CheckElementDoesnotExists(deviceManagementSection, "Device Management Section");
        }
        public void ValidateBuildUSBCollector()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.CheckElementExists(deviceManagementSection, "Device Management");
            driver.ClickElement(Gateway, "gateway");
             driver.CheckElementExists(Editbutton, "edit");
            driver.CheckElementDisplayed(btnBuildUSB, "buildUSB");
            driver.ClickElement(btnClose, "close");

        }
        public void ValidateDeviceNameDisplayed()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.CheckElementExists(deviceManagementSection, "Device Management");
            driver.CheckElementNotDisplayed(devicename, "devicename");
        }
        /// <summary>
        /// Method to Validate Meter Reader Export Tab
        /// </summary>
        public void ValidateExport()
        {
            driver.CheckElementDoesnotExists(lftNavBillingServices, "Billing Service");
        }

        /// <summary>
        /// Method to Validate Meter Reader Notification
        /// </summary>
        public void ValidateNotification()
        {
            driver.CheckElementDoesnotExists(btnNotifications, "Notification");
        }

        /// <summary>
        /// Method to Validate Alert Notification
        /// </summary>
        public void ValidateAlertNotification()
        {
            driver.sleepTime(5000);
            driver.ClickElement(drpProfileLogOut, "Dropdown");
            driver.CheckElementDisplayed(btnAlert, "Alert Notification");
            driver.ClickElement(drpProfileLogOut, "Dropdown");
        }

        /// <summary>
        /// Method to Validate Alert Notification View
        /// </summary>
        public void ValidateAlertNotificationView()
        {
            driver.ClickElement(drpProfileLogOut, "Dropdown");
            driver.ClickElement(btnAlert, "Alert Notification");
            if (driver.GetElementText(breadCrumb).Equals("ALERT NOTIFICATIONS"))
            {
                testReport.Pass("ALERT NOTIFICATIONS Page Displayed. ");
            }
        }

        /// <summary>
        /// Method to Validate Alert Notification No View
        /// </summary>
        public void ValidateTopAlertNotificationNoView()
        {
            driver.ClickElement(drpProfileLogOut, "Dropdown");
            driver.CheckElementDoesnotExists(btnAlert, "Alert Notification");
            driver.ClickElement(drpProfileLogOut, "Dropdown");
        }

        /// <summary>
        /// Method to Validate Alert Notification No Edit
        /// </summary>
        public void ValidateTopAlertNotificationNoEdit()
        {
            driver.ClickElement(drpProfileLogOut, "Dropdown");
            driver.ClickElement(btnAlert, "Alert Notification");
            driver.CheckElementDoesnotExists(btnEdit, "Edit");
        }

        /// <summary>
        /// Method to Validate Alert Configation Left Navigation No View
        /// </summary>
        public void ValidateAlertConfigationLeftNoView()
        {
            driver.ClickElement(lftNavUtilityManagement, "Uitillity Management");
            driver.CheckElementDoesnotExists(lftNavAlertConfiguration, "Alert Configation");
        }

        /// <summary>
        /// Method to Validate Alert Notification Edit
        /// </summary>
        public void ValidateAlertNotificationEdit()
        {
            driver.ClickElement(drpProfileLogOut, "Dropdown");
            driver.ClickElement(btnAlert, "Alert Notification");
            driver.ClickElement(btnEdit, "Edit");
            driver.CheckElementDisplayed(btnCancel, "Cancel");
            driver.CheckElementDisplayed(btnDoneEdit, "Done");
        }
        /// <summary>
        /// Method to Validate Alert Configuration
        /// </summary>
        public void ValidateAlertConfiguration()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.CheckElementDoesnotExists(lftNavAlertConfiguration, "Alert Configuration");
        }

        /// <summary>
        /// Method to Validate Alert Configuration View
        /// </summary>
        public void ValidateAlertConfigurationView()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavAlertConfiguration, "Alert Configuration");
            driver.CheckElementDisplayed(breadCrumb, driver.GetElementText(breadCrumb));
        }

        /// <summary>
        /// Method to Validate Alert Configuration No View
        /// </summary>
        public void ValidateAlertConfigurationNoView()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavAlertConfiguration, "Alert Configuration");
        }

        /// <summary>
        /// Method to Validate Alert Configuration Edit
        /// </summary>
        public void ValidateAlertConfigurationEdit()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavAlertConfiguration, "Alert Configuration");
            driver.ClickElement(btnEdit, "Edit");
            driver.CheckElementDisplayed(btnCancel, "Cancel");
            driver.CheckElementDisplayed(btnDoneEdit, "Done");
        }
        public void ValidateEndpointConsumptionReportEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(endpointConsumptionReportSwitch, "endpointConsumptionReport Switch");
        }

        public void ValidateReverseFlowReportEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(reverseFlowSwitch, "Reverse Flow Toggle Switch");
        }

        /// <summary>
        /// Method to Validate Alert Configuration No Edit
        /// </summary>
        public void ValidateAlertConfigurationNoEdit()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavAlertConfiguration, "Alert Configuration");
            driver.CheckElementDoesnotExists(btnEdit, "Edit");
        }

        /// <summary>
        /// Method to Validate Partner Management Left Navigation
        /// </summary>
        public void ValidatePartnerManagementLeftNavigation()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.CheckElementDisplayed(lftNavPartnerManagement, "Partner Management");
        }

        /// <summary>
        /// Method to Validate Partner Management Feature Group
        /// </summary>
        public void ValidatePartnerManagementFeatureGroup()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role MAnagement");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(partnerManagementFeature, "Partner Management Feature Group");
        }

        /// <summary>
        /// Method to Validate View Partner Management
        /// </summary>
        public void ValidateViewPartnerManagement()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role MAnagement");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(viewPartnerManagement, "View Partner Management");
        }
        public void ValidateDaysOfConsecutiveFlowAMI()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role MAnagement");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(daysOfConsecutiveFlow, "daysOfConsecutiveFlow");
        }
        public void ValidateLftNavSearchEndPOintsDoesNotExists()
        {
            try
            {
                driver.CheckElementDoesnotExists(lftNavsearchEndpoints, "Search EndPoints");
            }
            catch (Exception)
            {
                ReporterFactory.LogFailure("Search EndPoints Is Displayed");
            }
        }
        /// <summary>
        /// Method to Validate View Partner Management Page
        /// </summary>
        public void ValidateViewPartnerManagementPage()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavPartnerManagement, "Partner Management");
            driver.CheckElementDisplayed(breadCrumb, " Partner Management Page");
        }

        /// <summary>
        /// Method to Validate API Deployment Page
        /// </summary>
        public void ValidateAPIDeploymentPage()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavAPIDeploment, "API Deployment ");
            driver.CheckElementDisplayed(breadCrumb, "API Deployment Page");
        }



        /// <summary>
        /// Method to Validate Create Partner
        /// </summary>
        public void ValidateCreatePartner()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role MAnagement");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(createPartner, "Create Partner");
        }

        /// <summary>
        /// Method to Validate Edit Partner
        /// </summary>
        public void ValidateEditPartner()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role MAnagement");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(editPartner, "Edit Partner");
        }

        /// <summary>
        /// Method to Validate Reports Widget
        /// </summary>
        public void ValidateReportsWidget()
        {
            /*driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role MAnagement");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");*/
            driver.CheckElementDisplayed(reportsWidget, "Reports Widget");
          

        }

        /// <summary>
        /// Method to Validate Reports Widget Not Exist
        /// </summary>
        public void ValidateReportsWidgetNotExist()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role MAnagement");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDoesnotExists(reportsWidget, "Reports Widget");
        }

        /// <summary>
        /// Method to Validate Landing Page Reports Widget Not Exist
        /// </summary>
        public void ValidateLandingPageReportsWidgetNotExist()
        {
            driver.CheckElementDoesnotExists(btnReports, "Reports Widget");
        }

        /// <summary>
        /// Method to Validate Landing Page Reports Widget Exist
        /// </summary>
        public void ValidateLandingPageReportsWidgetOn()
        {
            driver.WaitForElement(btnReports, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(btnReports, "Reports Widget");
        }

        /// <summary>
        /// Method to Validate Left Nav Reports Widget Exist
        /// </summary>
        public void ValidateLftNavReportsWidgetOn()
        {
            driver.WaitForElement(lftnavReports, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(lftnavReports, "Reports");
        }

        /// <summary>
        /// Method to Validate Left Nav Reports Widget Not Exist
        /// </summary>
        public void ValidateLftNavReportsWidgetOff()
        {
            driver.CheckElementDoesnotExists(lftnavReports, "Reports");
        }



        /// <summary>
        /// Method to Validate Meter Reader Route Assignment Screen
        /// </summary>
        public void ValidateRouteAssignmentScreen()
        {
            driver.CheckElementDoesnotExists(btnRouteManagement, "Route Management");
        }

        /// <summary>
        /// Method to Validate Meter Reader Alert Configuration
        /// </summary>
        public void ValidateAlertConfigurationNotExist()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.CheckElementDoesnotExists(lftNavAlertConfiguration, "Alert Configuration");
        }

        /// <summary>
        /// Method to Validate Event Header
        /// </summary>
        public void ValidateEventHeader()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavAlertConfiguration, "Alert Configuration");
            driver.WaitForElement(eventHeader, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(eventHeader, "Event Header");
        }

        public void ValidateInactiveUserDoesNotExist()
        {
            driver.CheckElementDisplayed(By.XPath("//h3[text()='User Management']/..//following-sibling::div/img"), "usermanagement widget");
            driver.ClickElement(By.XPath("//h3[text()='User Management']/..//following-sibling::div/img"), "user management widget");
            driver.ClickElement(By.XPath("//button[text()='Edit']"), "edit");
            driver.ClickElement(statusDropdown, "Dropdown");
            driver.CheckElementDoesnotExists(dropDownInactive, "Inactive");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateSendPwdResetDoesNotExist()
        {
            driver.CheckElementDisplayed(By.XPath("//h3[text()='User Management']/..//following-sibling::div/img"),"usermanagement widget");
            driver.ClickElement(By.XPath("//h3[text()='User Management']/..//following-sibling::div/img"), "user management widget");
            driver.ClickElement(By.XPath("//button[text()='Edit']"),  "edit");
            driver.CheckElementDoesnotExists(By.XPath("//button[text()='Send Password Reset']"), "Send Password Reset");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Utilty Admin Meter Reader
        /// </summary>
        public void ValidateUtiltyAdminMeterReader()
        {
            driver.ClickElement(By.XPath("//h3[text()='Route Management']/..//img"), "Route Manmagement");
            driver.ClickElement(readers, "Readers");
            driver.CheckElementDisplayed(readersList, "Readers Name");
        }

        /// <summary>
        /// Method to Validate Neptune System Admin Dashboard Network Health
        /// </summary>
        public void ValidateDashboardNetworkHealth()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Manmagement");
            driver.ClickElement(lftNavRoleManagement, "Role Assignment");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(dashboardNetworkHealth, "Dashboard Network Health");
        }

        ///// <summary>
        ///// Method to Validate Neptune System Admin Dashboard Network Health
        ///// </summary>
        //public void ValidateSysAdminDashboardNetworkHealth()
        //{
        //    driver.ClickElement(lftDashboard, "Dashboard");
        //    driver.CheckElementDoesnotExists(dashboardNetworkHealth, "Dashboard Network Health");
        //}

        /// <summary>
        /// Method to Validate Neptune Customer Service Dashboard Network Health
        /// </summary>
        public void ValidateCustServDashboardNetworkHealth()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Manmagement");
            driver.ClickElement(lftNavRoleManagement, "Role Assignment");
            driver.ClickElement(custService, "Neptune Customer Service");
            driver.CheckElementDisplayed(dashboardNetworkHealth, "Dashboard Network Health");
        }
        public void ValidateBillingServicesSettings()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(billingServiceSetting, "Billing Services Setting");
        }
        public void ValidateEndpointMaintenanceLeftNavigation()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(endpointMaintenanceLeftNav, "Endpoint Maintenance Left Nav");
        }
        public void ValidateCMIUFOTALeftNavigation()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(cmiuFotaLeftNav, "CMIU FOTA Left Nav");
        }
        public void ValidateMIUListLeftNavigation()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(miuListLeftNav, "Miu List Left Nav");
        }
        public void ValidateCMIUFOTAFeatureBlock()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(cmiuFotaFeatureBlk, "CMIU FOTA Feature Block");
        }
        public void ValidateMIUListFeatureBlock()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(miuListFeatureGroup, "MIU List Feature Group");
        }

        public void ValidateEndpointMaintenanceReport()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(endpointMaintenanceReport, "Endpoint Maintenance Report");
        }
        public void ValidateEndpointConsumptionReport()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(endpointConsumptionReport, "Endpoint Consumption Report");
        }
        public void ValidateEndpointMaintenanceReportEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(endpointMaintenanceSwitch, "Endpoint Maintenance Report Swich");
        }

        /// <summary>
        /// Method to Validate Neptune Utility Admin Dashboard Network Health
        /// </summary>
        public void ValidateUtilityAdminDashboardNetworkHealth()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Manmagement");
            driver.ClickElement(lftNavRoleManagement, "Role Assignment");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.CheckElementDisplayed(dashboardNetworkHealth, "Dashboard Network Health");
        }

        /// <summary>
        /// Method to Validate Neptune Utility User Dashboard Network Health
        /// </summary>
        public void ValidateUtilityUserDashboardNetworkHealth()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Manmagement");
            driver.ClickElement(lftNavRoleManagement, "Role Assignment");
            driver.ClickElement(utilityUser, "Utility User");
            driver.CheckElementDisplayed(dashboardNetworkHealth, "Dashboard Network Health");
        }

        /// <summary>
        /// Method to Validate Neptune Utility Read Only Dashboard Network Health
        /// </summary>
        public void ValidateReadOnlyDashboardNetworkHealth()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Manmagement");
            driver.ClickElement(lftNavRoleManagement, "Role Assignment");
            driver.ClickElement(utilityReadOnly, "Utility User Read Only");
            driver.CheckElementDisplayed(dashboardNetworkHealth, "Dashboard Network Health");
        }

        /// <summary>
        /// Method to Validate Neptune Utility Meter Reader Dashboard Network Health
        /// </summary>
        public void ValidateMeterReaderDashboardNetworkHealth()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Manmagement");
            driver.ClickElement(lftNavRoleManagement, "Role Assignment");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            driver.CheckElementDisplayed(dashboardNetworkHealth, "Dashboard Network Health");
        }

        /// <summary>
        /// Method to Validate Coded Notes Default ON
        /// </summary>
        public void ValidateCodedNotes()
        {
            driver.ClickElement(lftnavReports, "Reports");
            driver.CheckElementDisplayed(codedNotes, "Coded Notes");
        }

        /// <summary>
        /// Method to Validate Coded Notes Default OFF
        /// </summary>
        public void ValidateCodedNotesOff()
        {
            driver.ClickElement(lftnavReports, "Reports");
            driver.CheckElementDoesnotExists(codedNotes, "Coded Notes");
        }

        /// <summary>
        /// Method to Validate Comments Default ON
        /// </summary>
        public void ValidateCommentsOn()
        {
            driver.ClickElement(lftnavReports, "Reports");
            driver.CheckElementDisplayed(comments, "Comments");
        }
        /// <summary>
        /// Method to Validate Comments Default OFF
        /// </summary>
        public void ValidateCommentsOff()
        {
            driver.ClickElement(lftnavReports, "Reports");
            driver.CheckElementDoesnotExists(comments, "Comments");
        }
        /// <summary>
        /// Method to Validate Mach 10 On
        /// </summary>
        public void ValidateMachTenOn()
        {
            driver.ClickElement(lftnavReports, "Reports");
            driver.CheckElementDisplayed(mach10, "Mach 10");
        }

        /// <summary>
        /// Method to Validate Mach 10 Off
        /// </summary>
        public void ValidateMachTenOff()
        {
            driver.ClickElement(lftnavReports, "Reports");
            driver.CheckElementDoesnotExists(mach10, "Mach 10");
        }

        /// <summary>
        /// Method to Validate Reporting Landing Page Blank
        /// </summary>
        public void ValidateReportLandingPageBlank()
        {
            driver.ClickElement(lftnavReports, "Reports");
            driver.CheckElementDoesnotExists(mach10, "Mach 10");
            driver.CheckElementDoesnotExists(codedNotes, "Coded Notes");
            driver.CheckElementDoesnotExists(comments, "Comments Report");
        }

        /// <summary>
        /// Method to Validate Permissions_Invalid Readings Report On
        /// </summary>
        public void ValidatePermissionsInvalidReadingsReportOn()
        {
            driver.ClickElement(lftnavReports, "Reports");
            driver.CheckElementDisplayed(invalidReadings_Reports, "Invalid Readings Report");
        }

        /// <summary>
        /// Method to Validate Permissions_Invalid Readings Off
        /// </summary>
        public void ValidatePermissionsInvalidReadingsReportOff()
        {
            driver.ClickElement(reportsWidget, "Reports");
            driver.CheckElementDoesnotExists(invalidReadings, "Invalid Readings Report");
        }

        /// <summary>
        /// Method to Validate File Mapper Left Nav
        /// </summary>
        public void ValidateFileMapperLeftNav()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.CheckElementDisplayed(fileMapperLftNav, "File Mapper Left Nav");
        }

        /// <summary>
        /// Method to Validate Handhelds Left Nav
        /// </summary>
        public void ValidateHandheldsLeftNav()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.CheckElementDisplayed(handheldslft, "Handhelds Left Nav");
        }

        /// <summary>
        /// Method to Validate Neptune360 Left Nav
        /// </summary>
        public void ValidateNeptune360LeftNav()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.CheckElementDisplayed(neptune360SyncBlock, "Neptune360sync Left Nav");
        }
        public void ValidateNeptune360Partner()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.CheckElementDisplayed(neptune360Partner, "Neptune360 Partner");
        }

        /// <summary>
        /// Method to Validate Neptune360 Sync Sreen
        /// </summary>
        public void ValidateNeptune360SyncSreen()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(neptune360syncpermission, "Neptune 360 sync permission");
            driver.CheckElementDisplayed(viewneptune360syncscreen, "view neptune 360 sync screen");
            driver.CheckElementDisplayed(downloadNeptune360Sync, "download neptune 360 sync");
            
        }
        /// <summary>
        /// Method to Validate Neptune360 Sync Block
        /// </summary>
        public void ValidateNeptune360SyncBlock()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(neptune360SyncBlock, "Neptune360 Sync Block");
        }

        /// <summary>
        /// Method to Validate Days Of No flow
        /// </summary>
        public void ValidateDaysOfNoFlow()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(daysOfNoFlow, "Days Of No flow (AMR)");
        }

        /// <summary>
        /// Method to Validate Days Of Consumption Off
        /// </summary>
        public void ValidateDaysOfonsumptionOff()
        {
            driver.ClickElement(lftnavReports, "Reports");
            driver.CheckElementDoesnotExists(daysOfConsumption, "Days Of Consumption Off(AMR)");
        }

        /// <summary>
        /// Method to Validate Days Of Consumption ON
        /// </summary>
        public void ValidateDaysOfonsumptionON()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(daysOfConsumption, "Days Of Consumption Off(AMR)");
        }
        /// <summary>
        /// Method to Validate Days Of No flow Off
        /// </summary>
        public void ValidateDaysOfNoFlowOff()
        {
            driver.ClickElement(lftnavReports, "Reports");
          driver.CheckElementDoesnotExists(daysOfNoFlow, "Days Of No flow (AMR)");
        }

        /// <summary>
        /// Method to Validate Neptune360 essential No
        /// </summary>
        public void ValidateNeptune360essentialNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360essentials, "Neptune 360 Essential");
            string defaultproperty = driver.GetElementProperty(neptune360lftnavPropertyImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Neptune360 essential Default is set to No");
            }
        }

        /// <summary>
        /// Method to Validate Neptune360 partner No
        /// </summary>
        public void ValidateNeptune360partnerNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 partner");
            string defaultproperty = driver.GetElementProperty(neptune360lftnavPropertyImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Neptune360 partner Default is set to No");
            }
        }

        /// <summary>
        /// Method to Validate Neptune360 Partner Handheld Management No
        /// </summary>
        public void ValidateNeptune360PartnerHandheldManagementNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 partner");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Neptune360 partner Default is set to No");
            }
        }

        /// <summary>
        /// Method to Validate Neptune360 Essentials Handheld Management Yes
        /// </summary>
        public void ValidateNeptune360EssentialsHandheldManagementYes()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360essentials, "Neptune 360 Essentials");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handheld Management Left Navigation permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Handheld Management Left Navigation permission is set by default to No");
            }
        }
        public void ValidateNeptuneSysAdminDaysOfConsFlowOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptune System Admin");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to No");
            }
        }
        public void ValidateNeptuneCSRDaysOfConsFlowOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "neptune CSR");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to No");
            }
        }
        public void ValidateUtilityAdminDaysOfConsFlowOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to No");
            }
        }
        public void ValidateUtilityUserDaysOfConsFlowOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to No");
            }
        }

        public void ValidateUtilityMeterReaderDaysOfConsFlowOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to No");
            }
        }
        public void ValidateUtilityReadOnlyDaysOfConsFlowOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to No");
            }
        }

        public void ValidateDaysOfConsFlowConsumptionNeptuneFeildServicePmON()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneFieldService, "neptuneFieldService");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowConsmpBasedImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to No");
            }
        }
        public void ValidateDaysOfConsFlowConsumptionNeptune360PartnerOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune360Partner");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowConsmpBasedImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("permission is set by default to No");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to Yes");
            }
        }
        public void ValidateDaysOfConsFlowConsumptionNeptuneSysAdminOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowConsmpBasedImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to No");
            }
        }
        public void ValidateDaysOfConsFlowConsumptionNeptune360EssentialsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360essentials, "neptune360essentials");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowConsmpBasedImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to No");
            }
        }
        public void ValidateDaysOfConsFlowConsumptionUtilityAdminBetaOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdminBeta, "utilityAdminBeta");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowConsmpBasedImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to No");
            }
        }

        public void ValidateDaysOfConsFlowConsumptionMobileAppUserOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(mobileAppUser, "mobileAppUser");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowConsmpBasedImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("permission is set by default to No");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to Yes");
            }
        }
        public void ValidateEndpointConsumptionReportMobileAppUserOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(mobileAppUser, "mobileAppUser");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(endPointConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("permission is set by default to No");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to Yes");
            }
        }
        public void ValidateDaysOfConsFlowConsumptionNeptuneCustSupportON()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "neptuneCustSupport");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowConsmpBasedImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to No");
            }
        }
        public void ValidateDaysOfConsFlowConsumptionNeptuneCustServiceON()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(lstItemRoleNeptuneCustServRep, "neptuneCust Service");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowConsmpBasedImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to No");
            }
        }
        public void ValidateDaysOfConsFlowConsumptionUtilityMeterReaderON()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utility Meter Reader");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowConsmpBasedImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to No");
            }
        }
        public void ValidateDaysOfConsFlowConsumptionUtilityReadOnlyON()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utilityReadOnly");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowConsmpBasedImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to No");
            }
        }
        public void ValidateDaysOfConsFlowConsumptionUtilityUserON()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utilityUser");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowConsmpBasedImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to No");
            }
        }

        public void ValidateNeptune360PartnerDaysOfConsFlowOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune360Partner");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(daysOfConsFlowImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("permission is set by default to No");
            }
            else
            {
                ReporterFactory.LogFailure("permission is set by default to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Cust Servs Handheld Setting Yes
        /// </summary>
        public void ValidateNeptuneCustServsHandheldSettingYes()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune 360 Essentials");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handheld Settings Left Navigation permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Handheld Settings Left Navigation permission is set by default to Yes");
            }
        }

        /// <summary>
        /// Method to Validate CustSupport Handheld Management Yes
        /// </summary>
        public void ValidateCustSupportHandheldManagementYes()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "Neptune Cust Support");
            driver.sleepTime(3000);
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handheld Management Left Navigation permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Handheld Management Left Navigation permission is set by default to No");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Field Service Yes
        /// </summary>
        public void ValidateNeptuneFieldServiceYes()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneFieldService, "Neptune Field Service");
            string defaultproperty = driver.GetElementProperty(neptune360lftnavPropertyImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Neptune Field Service Default is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Handheld Management Handheld Setting
        /// </summary>
        public void ValidateHandheldManagementHandheldSetting()
        {
            driver.ClickElement(handheldManagement, "Handheld Management");
            driver.ClickElement(handheldSettings, "Handheld Setting");
            string s = driver.GetElementText(breadCrumb);
            if (s.Equals("HANDHELD SETTINGS"))
            {
                testReport.Pass("Handheld Settings page is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("Handheld Settings page is Not displayed");
            }
        }

        /// <summary>
        /// Method to Validate Handheld Management Neptune 360 Sync - Enabled
        /// </summary>
        public void ValidateHandheldManagementNeptune360SyncEnabled()
        {
            driver.ClickElement(handheldManagement, "Handheld Management");
            driver.ClickElement(neptune360Sync, "Neptune 360 Sync");
            string s = driver.GetElementText(breadCrumb);
            if (s.Equals("NEPTUNE 360 SYNC"))
            {
                testReport.Pass("NEPTUNE 360 SYNC page is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("NEPTUNE 360 SYNC is Not displayed");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Field Service Handheld Management Yes
        /// </summary>
        public void ValidateNeptuneFieldServiceHandheldManagementYes()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneFieldService, "Neptune Field Service");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Neptune Field Service Default is set to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Neptune Field Service Default is set to No");
            }
        }

        /// <summary>
        /// Method to Validate Neptune 360 Essentials Handheld Setting
        /// </summary>
        public void ValidateNeptune360HandheldSetting()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360essentials, "Neptune 360 Essentials");
            string defaultproperty = driver.GetElementProperty(handheldsSettingImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Handheld Settings Left Navigation permissions is set by default to No");
            }
            else
            {
                ReporterFactory.LogFailure("Handheld Settings Left Navigation permissions is set by default to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Utility Meter Reader Handheld
        /// </summary>
        public void ValidateUtilityMeterReaderHandheld()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader ");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Handhelds Left Navigation permissions is set by default to No");
            }
            else
            {
                ReporterFactory.LogFailure("Handhelds Left Navigation permissions is set by default to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Utility User Handheld Management
        /// </summary>
        public void ValidateUtilityUserHandheldManagement()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            string defaultproperty = driver.GetElementProperty(handheldManagementImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handheld Settings Left Navigation permissions is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Handheld Settings Left Navigation permissions is set by default to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Utility User Handheld Left
        /// </summary>
        public void ValidateUtilityUserHandheldLft()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handheld Left Navigation permissions is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Handheld Left Navigation permissions is set by default to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune360 Partner Handheld Left
        /// </summary>
        public void ValidateNeptune360PartnerHandheldLft()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Utility User");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Handhelds Left Navigation permissions is set by default to No");
            }
            else
            {
                ReporterFactory.LogFailure("Handhelds Left Navigation permissions is set by default to Yes");
            }
        }
        /// <summary>
        /// Method to Validate Neptune Feild Service PM Handheld Left
        /// </summary>
        public void ValidateNeptuneFeildServicePMHandheldLft()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneFieldService, "Neptune Feild Service PM");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handhelds Left Navigation permissions is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Handhelds Left Navigation permissions is set by default to No");
            }
        }

        /// <summary>
        /// Method to Validate Utility Admin Beta Handheld Settings
        /// </summary>
        public void ValidateUtilityAdminBetaHandheldSettings()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdminBeta, "Utility Admin Beta");
            string defaultproperty = driver.GetElementProperty(handheldsSettingImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Handhelds Left Navigation permissions is set by default to No");
            }
            else
            {
                ReporterFactory.LogFailure("Handhelds Left Navigation permissions is set by default to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Feild Service PM Handheld Settings
        /// </summary>
        public void ValidateNeptuneFeildServicePMHandheldSettings()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneFieldService, "Neptune Feild Service PM");
            string defaultproperty = driver.GetElementProperty(handheldsSettingImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handhelds Left Navigation permissions is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Handhelds Left Navigation permissions is set by default to No");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Cust Sevice Handheld Lft
        /// </summary>
        public void ValidateNeptuneCustSeviceHandheldLft()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune Cust Sevice");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handhelds Left Navigation permissions is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Handhelds Left Navigation permissions is set by default to No");
            }
        }


        /// <summary>
        /// Method to Validate Neptune Admin File Mapper Feature On 
        /// </summary>
        public void ValidateNeptuneAdminFileMapperFeatureOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            string defaultproperty = driver.GetElementProperty(fileMapperImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("File Mapper Feature Group is Enabled");
            }
            else
            {
                ReporterFactory.LogFailure("File Mapper Feature Group is Disabled");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Cust Support Rep File Mapper Disabled
        /// </summary>
        public void ValidateNeptuneCSRFileMapperFeatureDisabled()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "Neptune Cust Support");
            driver.CheckElementDisplayed(fileMapperImg, "File Mapper Feature Group");
            string defaultproperty = driver.GetElementProperty(fileMapperImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("File Mapper Feature Group is Disabled");
            }
            else
            {
                ReporterFactory.LogFailure("File Mapper Feature Group is Enabled");
            }
        }

        /// <summary>
        /// Method to Validate Utility Admin File Mapper Feature Disabled
        /// </summary>
        public void ValidateUtilityAdminFileMapperFeatureDisabled()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.CheckElementDisplayed(fileMapperImg, "File Mapper Feature Group");
            string defaultproperty = driver.GetElementProperty(fileMapperImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("File Mapper Feature Group is Disabled");
            }
            else
            {
                ReporterFactory.LogFailure("File Mapper Feature Group is Enabled");
            }
        }

        /// <summary>
        /// Method to Validate Utility User File Mapper Feature Disabled
        /// </summary>
        public void ValidateUtilityUserFileMapperFeatureDisabled()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            driver.CheckElementDisplayed(fileMapperImg, "File Mapper Feature Group");
            string defaultproperty = driver.GetElementProperty(fileMapperImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("File Mapper Feature Group is Disabled");
            }
            else
            {
                ReporterFactory.LogFailure("File Mapper Feature Group is Enabled");
            }
        }

        /// <summary>
        /// Method to Validate Utility Meter Reader File Mapper Feature Disabled
        /// </summary>
        public void ValidateUtilityMeterReaderFileMapperFeatureDisabled()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility MeterReader");
            driver.CheckElementDisplayed(fileMapperImg, "File Mapper Feature Group");
            string defaultproperty = driver.GetElementProperty(fileMapperImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("File Mapper Feature Group is Disabled");
            }
            else
            {
                ReporterFactory.LogFailure("File Mapper Feature Group is Enabled");
            }
        }

        /// <summary>
        /// Method to Validate Utility Read Only File Mapper Feature Disabled
        /// </summary>
        public void ValidateUtilityReadOnlyFileMapperFeatureDisabled()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            driver.CheckElementDisplayed(fileMapperImg, "File Mapper Feature Group");
            string defaultproperty = driver.GetElementProperty(fileMapperImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("File Mapper Feature Group is Disabled");
            }
            else
            {
                ReporterFactory.LogFailure("File Mapper Feature Group is Enabled");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Cust Support File Mapper On 
        /// </summary>
        public void ValidateNeptuneCustSupportFileMapperFeatureOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "Neptune Cust Support");
            driver.CheckElementDisplayed(fileMapperImg, "File Mapper Feature Group");
            string defaultproperty = driver.GetElementProperty(fileMapperImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("File Mapper Feature Group is Enabled");
            }
            else
            {
                ReporterFactory.LogFailure("File Mapper Feature Group is Disabled");
            }
        }


        /// <summary>
        /// Method to Validate Neptune Customer Service File Mapper On 
        /// </summary>
        public void ValidateNeptuneCustSupportFileMapperOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "Neptune Customer Support");
            string defaultproperty = driver.GetElementProperty(fileMapperImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("By Default File Mapper Left Navigation Permission is Turned ON");
            }
            else
            {
                ReporterFactory.LogFailure("By Default File Mapper Left Navigation Permission is Turned Off");
            }
        }



        /// <summary>
        /// Method to Validate Customer Support File Mapper On 
        /// </summary>
        public void ValidateCustomerSupportFileMapperOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "Neptune Customer Support");
            string defaultproperty = driver.GetElementProperty(fileMapperImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("By Default File Mapper Left Navigation Permission is Turned ON");
            }
            else
            {
                ReporterFactory.LogFailure("By Default File Mapper Left Navigation Permission is Turned Off");
            }
        }

        /// <summary>
        /// Method to Validate Utility Admin File Mapper Off
        /// </summary>
        public void ValidateUtilityAdminFileMapperOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            string defaultproperty = driver.GetElementProperty(fileMapperImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("By Default File Mapper Left Navigation Permission is Turned Off");
            }
            else
            {
                ReporterFactory.LogFailure("By Default File Mapper Left Navigation Permission is Turned On");
            }
        }

        public void ValidateNeptuneCSRViewUsagePlansOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            string defaultproperty = driver.GetElementProperty(usagePlansLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("View Usage Plans permission is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("View Usage Plans permission is set to Yes");
            }
        }
        public void ValidateUtilityAdminViewUsagePlansOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            string defaultproperty = driver.GetElementProperty(usagePlansLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("View Usage Plans permission is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("View Usage Plans permission is set to Yes");
            }
        }
        public void ValidateUtilityUserViewUsagePlansOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            string defaultproperty = driver.GetElementProperty(usagePlansLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("View Usage Plans permission is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("View Usage Plans permission is set to Yes");
            }
        }
        public void ValidateUtilityReadOnlyViewUsagePlansOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read ONly");
            string defaultproperty = driver.GetElementProperty(usagePlansLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("View Usage Plans permission is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("View Usage Plans permission is set to Yes");
            }
        }
        public void ValidateUtilityMeterReaderViewUsagePlansOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            string defaultproperty = driver.GetElementProperty(usagePlansLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("View Usage Plans permission is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("View Usage Plans permission is set to Yes");
            }
        }
        public void ValidateNeptuneSystemAdminEditUsagePlanOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System admin");
            string defaultproperty = driver.GetElementProperty(editUsagePlanImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Edit  Usage Plans permission is set to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("View Usage Plans permission is set to No");
            }
        }
        public void ValidateNeptuneCSREditUsagePlanOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            string defaultproperty = driver.GetElementProperty(editUsagePlanImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit  Usage Plans permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("View Usage Plans permission is set to Yes");
            }
        }
        public void ValidateUtilityAdminEditUsagePlanOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            string defaultproperty = driver.GetElementProperty(editUsagePlanImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit  Usage Plans permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("View Usage Plans permission is set to Yes");
            }
        }
        public void ValidateUtilityUserEditUsagePlanOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            string defaultproperty = driver.GetElementProperty(editUsagePlanImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit  Usage Plans permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("View Usage Plans permission is set to Yes");
            }
        }
        public void ValidateUtilityReadOnlyEditUsagePlanOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility ReadOnly");
            string defaultproperty = driver.GetElementProperty(editUsagePlanImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit  Usage Plans permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("View Usage Plans permission is set to Yes");
            }
        }
        public void ValidateUtilityMeterReaderEditUsagePlanOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            string defaultproperty = driver.GetElementProperty(editUsagePlanImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit  Usage Plans permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("View Usage Plans permission is set to Yes");
            }
        }
        public void ValidateNeptuneSysAdminSDKAccessOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(sdkAccessLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("SDK Access permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("SDK Access permission is set to Off");
            }
        }
        public void ValidateUtilityAdminSDKAccessOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "UItility Admin");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(sdkAccessLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("SDK Access permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("SDK Access permission is set to Off");
            }
        }
        public void ValidateNeptuneCSRSDKAccessOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(sdkAccessLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Neptune CSR permission SDK is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Neptune CSR permission SDK is set to On");
            }
        }
        public void ValidateSDKAccessFeatureGroup()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(sdkAccessFeatureGroup, "SDK Access Feature Group");
        }
        public void ValidateViewSDKAccess()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(viewSDKAccess, "View SDK Access");
        }
        public void ValidateUtilityReadOnlySDKAccessOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utililty Read Only");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(sdkAccessLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Neptune CSR permission SDK is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Neptune CSR permission SDK is set to On");
            }
        }
        public void ValidateNeptuneSysAdminViewSDKAccessOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(viewSdkAccessImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Neptune Sys Admin permission view SDK is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Neptune Sys Admin permission view SDK is set to Off");
            }
        }
        public void ValidateUtilityAdminViewSDKAccessOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(viewSdkAccessImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass(" permission view SDK is set to On");
            }
            else
            {
                ReporterFactory.LogFailure(" permission view SDK is set to Off");
            }
        }
        public void ValidateNeptuneCSRViewSDKAccessOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(viewSdkAccessImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass(" Permission view SDK is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(" Permission view SDK is set to On");
            }
        }
        public void ValidateUtilityUserViewSDKAccessOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(viewSdkAccessImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass(" Permission view SDK is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(" Permission view SDK is set to On");
            }
        }
        public void ValidateUtilityReadOnlyViewSDKAccessOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(viewSdkAccessImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass(" Permission view SDK is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(" Permission view SDK is set to On");
            }
        }
        public void ValidateUtilityMeterReaderViewSDKAccessOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(viewSdkAccessImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass(" Permission view SDK is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(" Permission view SDK is set to On");
            }
        }
        public void ValidateNeptune360PartnerViewSDKAccessOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(viewSdkAccessImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass(" Permission view SDK is set to On");
            }
            else
            {
                ReporterFactory.LogFailure(" Permission view SDK is set to Off");
            }
        }
        public void ValidateNeptune360PartnerLogOutTopNavOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(logoutTopNavImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass(" Logout Top Navigation Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure(" Logout Top Navigation Permission is set to Off");
            }
        }
        public void ValidateNeptune360PartnerViewUsersNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(viewUsersImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass(" View User Navigation Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(" View User Navigation Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerCreateUsersNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(createUserImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass(" Create User Navigation Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(" Create User Navigation Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerSearchUsersNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(searchUserImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass(" Search User Navigation Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(" Search User Navigation Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerEditUsersNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(editUserImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass(" Edit User Navigation Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(" Edit User Navigation Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerDeactivateUsersNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(deactivateUserImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass(" Deactivate User Navigation Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(" Deactivate User Navigation Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerSendPasswordResetNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(sendPwdResetImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass(" Send Pwd Reset Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(" Send Pwd Reset Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerUsersResetNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(usersImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass(" Users Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(" Users Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerUsersProfileResetNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(userProfileImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass(" Users Profile Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(" Users Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerUsersManagementNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(userManagementImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass(" Users Management Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(" Users Management is set to On");
            }
        }
        public void ValidateNeptune360PartnerCreateUtilitiesNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(createUtilitiesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Create Utilities Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(" Create Utilities is set to On");
            }
        }
        public void ValidateNeptune360PartnerEditUtilitiesNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(editUtilitiesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit Utilities Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(" Edit Utilities is set to On");
            }
        }
        public void ValidateNeptune360PartnerViewUtilitiesNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewUtilitiesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("view Utilities Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(" view Utilities is set to On");
            }
        }
        public void ValidateNeptune360PartnerUtilitiesManagementNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(utilitieManagementImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Utilities Management is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Utilities Management is set to On");
            }
        }
        public void ValidateNeptune360PartnerHomeTopNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(homeTopNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Home Top Nav is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Home Top Nav is set to On");
            }
        }
        public void ValidateNeptune360PartnerProfileTopNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(profileTopNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Profile Top Nav is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Profile Top Nav is set to On");
            }
        }
        public void ValidateNeptune360PartnerChooseUtilitiesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(chooseUtilitiesTopNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Choose Utilities is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Choose Utilities is set to On");
            }
        }
        public void ValidateNeptune360PartnerAlertNotificationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(alertNotificationTopNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Alert Notification is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Alert Notification is set to On");
            }
        }
        public void ValidateNeptune360PartnerCreateCodesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(createCodesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Create Codes is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Create Codes is set to On");
            }
        }
        public void ValidateNeptune360PartnerSearchCodesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(searchCodesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Search Codes is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Search Codes is set to On");
            }
        }
        public void ValidateNeptune360PartnerEditCodesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editCodesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit Codes is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Edit Codes is set to On");
            }
        }
        public void ValidateNeptune360PartnerViewCodesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewCodesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("View Codes is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("View Codes is set to On");
            }
        }
        public void ValidateNeptune360PartnerselectanddeleteCodesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(selectanddeleteCodesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Select and Delete Codes is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Select and Delete Codes is set to On");
            }
        }
        public void ValidateNeptune360PartnerviewHandheldSettingOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewHandheldSettingImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerviewHandheldOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewHandheldImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnercreateHandheldOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(createHandheldImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnereditHandheldOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editHandheldImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerFileMapperOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(fileMapperImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerViewUsagePlanOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewUsagePlanImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerCreateUsagePlanOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(createUsagePlanImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerEditUsagePlanOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editUsagePlanImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneCSRCancelUpdateOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cancelUpdateImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityAdminCancelUpdateOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utilityAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cancelUpdateImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityUserCancelUpdateOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utility User");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cancelUpdateImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityReadOnlyCancelUpdateOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utility Read Only");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cancelUpdateImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateImportRulesNeptuneSysAdminOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateImportRulesNeptune360PartnerOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune360Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateImportRulesUtilityAdminOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utilityAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateImportRulesUtilityUserOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utility User");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateImportRulesUtilityReadOnlyOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utility ReadOnly");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateImportRulesUtilityMeterReaderOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utility MeterReader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateEditImportRulesUtilityMeterReaderOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utility MeterReader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateEditImportRulesUtilityReadOnlyOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utility Read Only");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateEditImportRulesUtilityUserOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utility User");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateEditImportRulesUtilityAdminOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utility Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateEditImportRulesNeptune360PartnerOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune360Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateEditImportRulesNeptuneSysAdminOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to ON");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateEditImportRulesNeptuneCustSupportOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "neptuneCSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateviewImportRulesNeptuneCustSupportOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "neptuneCustSupport");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateviewImportRulesMobileAppUserOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(mobileAppUser, "mobileAppUser");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateviewImportRulesUtilityAdminBetaOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdminBeta, "utilityAdminBeta");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateviewImportNeptune360EssentialsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360essentials, "neptune360essentials");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateviewImportNeptuneFieldServiceOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneFieldService, "neptuneFieldService");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateCancelUpdateOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cancelUpdateImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateEditDataTranslationsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editDataTranslationsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateEditDataTranslationsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneFieldService, "neptuneFieldService");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editDataTranslationsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateEditDataTranslationsOffNeptuneFeildService()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneFieldService, "neptuneFieldService");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editDataTranslationsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateEditDataTranslationsOffNeptune360Partner()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune360Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editDataTranslationsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }




        public void ValidateEditDataTranslationsOffNeptune360Essentials()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360essentials, "neptune360essentials");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editDataTranslationsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateEditDataTranslationsOffUtilityAdminBeta()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdminBeta, "utilityAdminBeta");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editDataTranslationsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateEditDataTranslationsOffMobileAppUser()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            //     driver.ClickElement(mobileAppUser, "mobileAppUser");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editDataTranslationsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateEditDataTranslationsOffNeptuneCustomerSupport()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "neptuneCustSupport");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editDataTranslationsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateEditDataTranslationsOffUtilityMeterReader()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utilityMeterReader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editDataTranslationsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateEditDataTranslationsOffUtilityReadOnly()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utilityReadOnly");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editDataTranslationsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateEndpointConsumptionReportUtilityReadOnlyOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utilityReadOnly");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endPointConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateEndpointConsumptionReportNeptuneCustSupportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "neptuneCustSupport");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endPointConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateEndpointConsumptionReportUtilityAdminOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utilityAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endPointConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateEndpointConsumptionReportNeptuneCustServiceOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(lstItemRoleNeptuneCustServRep, "lstItemRoleNeptuneCustServRep");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endPointConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateEndpointConsumptionReportUtilityAdminBetaOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdminBeta, "utilityAdminBeta");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endPointConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateEndpointConsumptionReportNeptune360EssentialsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360essentials, "neptune360essentials");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endPointConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateEndpointConsumptionReportUtilityUserOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utilityUser");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endPointConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateEndpointConsumptionReportUtilityMeterReaderOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utility MeterReader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endPointConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateEndpointConsumptionReportNeptune360PartnerOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune360Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endPointConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateEndpointConsumptionReportNeptuneFieldServicePMOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneFieldService, "neptuneFieldService");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endPointConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateEndpointConsumptionReportNeptuneSysAdminOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endPointConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateBlockReverseFlowReportMobileAppUserOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(mobileAppUser, "mobileAppUser");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(reverseFlowReportImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateBlockReverseFlowReportNeptuneFieldServicePMOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneFieldService, "neptuneFieldService");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(reverseFlowReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateBlockReverseFlowReportNeptuneCustServiceOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(lstItemRoleNeptuneCustServRep, "lstItemRoleNeptuneCustServRep");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(reverseFlowReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateBlockReverseFlowReportNeptuneCustSupportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "neptuneCustSupport");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(reverseFlowReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateBlockReverseFlowReportUtilityMeterReaderOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utilityMeterReader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(reverseFlowReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateBlockReverseFlowReportNeptune360EssentialsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360essentials, "neptune360essentials");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(reverseFlowReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateBlockReverseFlowReportUtilityAdminOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utilityAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(reverseFlowReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateBlockReverseFlowReportNeptuneSysAdminOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(reverseFlowReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateBlockReverseFlowReportUtilityReadOnlyOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utilityReadOnly"); ;
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(reverseFlowReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateBlockReverseFlowReportUtilityAdminBetaOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdminBeta, "utilityAdminBeta"); ;
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(reverseFlowReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateBlockReverseFlowReportUtilityUserOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utility User"); ;
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(reverseFlowReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateBlockReverseFlowReportNeptune360PartnerOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune 360 Partner"); ;
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(reverseFlowReportImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateEditDataTranslationsOffUtilityUser()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utilityUser");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editDataTranslationsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateEditDataTranslationsOffUtilityAdmin()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utilityAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editDataTranslationsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateEditDataTranslationsDisplays()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(5000);
            driver.WaitForElement(editDataTranspaltions, TimeSpan.FromSeconds(10000));
            driver.CheckElementDisplayed(editDataTranspaltions, "editDataTranspaltions");
        }
        public void ValidateReverseFlowReportDisplays()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(5000);
            driver.WaitForElement(reverseFlowReport, TimeSpan.FromSeconds(10000));
            driver.CheckElementDisplayed(reverseFlowReport, "reverseFlowReport");
        }

        public void ValidateConsecutiveFlowAMIConsBased()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(5000);
            driver.WaitForElement(daysOfconsFlowAMiConsmBased, TimeSpan.FromSeconds(10000));
            driver.CheckElementDisplayed(daysOfconsFlowAMiConsmBased, "daysOfconsFlowAMiConsmBased");
        }

        public void ValidateEditImportRulesMobileApplicationUserOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(mobileAppUser, "mobileAppUser");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateEditImportRulesNeptuneFieldServicePMOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneFieldService, "neptuneFieldService");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateEditImportRulesUtilityAdminBetaOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdminBeta, "utilityAdminBeta");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateEditImportRulesNeptune360EssentialsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360essentials, "neptune360essentials");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateEditImportRulesNeptuneCSROff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "neptuneCSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateviewImportRulesNeptuneCSROff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "neptuneCSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewImportRulesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerViewAPIDepOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewAPIdepImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerCreateBundlesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(createBundlesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerEditBundlesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editBundlesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerDashboardLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(dashboardLeftImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerCustInqLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(custInqImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerBillingServicesLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(billingServicesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerUtilityManagementLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(utilitieManagementImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerPlatformManagementLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(platformManagementImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerUserManagementLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(userManagementImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerRolesPermLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(rolePermImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerNotificationLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(notificationImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerAlertConfigLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(alertConfigImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerDashboardNetworkLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(dashboardNetworkImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerRouteAssignmentLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(routeAssignmentImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerRouteManagementLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(routeManagementImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerReportsLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(reportsLeftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerAPIDeplomentLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(apiDeploymentLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerPartnerManagementLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(partnerManagementLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerFileMapperLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(fileMapperLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerUsagePlanLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(usagePlansLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerHandheldManagementLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(handheldManagementImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerHandheldLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerNeptuneConnectLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewNeptuneConnectImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerHandheldSettingLeftNavigationOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(handheldsSettingImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerViewPartnerManagementOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewPartnerManagementImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerCreatePartnerManagementOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(createPartnerImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerEditPartnerManagementOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editPartnersImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerViewAllNetworkOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewAllNetworkImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360AlertConfigScreenOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(alertConfigScreenImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360AlertConfigOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(alertConfigImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateNeptuneFieldHandheldManagementLftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneFieldService, "Neptune Field Service PM");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneCSRLftNavGroupsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "Neptune CSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(lftNavGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateUtilityAdminLftNavGroupsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(lftNavGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityUserLftNavGroupsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(lftNavGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityREadOnlyLftNavGroupsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(lftNavGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityMeterReaderLftNavGroupsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter REader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(lftNavGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneCSRGroupsLandingPageOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(groupsWidgetImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneSysAdminGroupsLandingPageOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(groupsWidgetImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateUtilityAdminGroupsLandingPageOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(groupsWidgetImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityUserGroupsLandingPageOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(groupsWidgetImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateUtilityREadOnlyGroupsLandingPageOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(groupsWidgetImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateSystemAdminEditGroupContainerOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(createEditGrpContainerImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneCSREditGroupContainerOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(createEditGrpContainerImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityAdminEditGroupContainerOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(createEditGrpContainerImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateNeptuneSysAdminEndpointManagementLeftNavOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System  Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endpointManagementLeftNavImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityAdminEndpointManagementLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endpointManagementLeftNavImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneCSREndpointManagementLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endpointManagementLeftNavImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityUserEndpointManagementLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endpointManagementLeftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityReadOnlyEndpointManagementLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endpointManagementLeftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityMeterReaderEndpointManagementLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endpointManagementLeftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerEndpointManagementLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endpointManagementLeftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerCMIUFOTALeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cmiuFotaLeftNav, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityMeterReaderCMIUFOTALeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utility Meter Reader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cmiuFotaLeftNav, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityReadOnlyCMIUFOTALeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utility Read Only");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cmiuFotaLeftNav, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityUserCMIUFOTALeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utility User");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cmiuFotaLeftNav, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneCSRCMIUFOTALeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cmiuFotaLeftNav, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityAdminAdminCMIUFOTALeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cmiuFotaLeftNav, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateNeptuneSysAdminCMIUFOTALeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cmiuFotaLeftNav, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneSysAdminMIUListLeftNavOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(miuListLeftNavImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityAdminMIUListLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(miuListLeftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneCSRMIUListLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(miuListLeftNavImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityUserMIUListLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(miuListLeftNavImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityReadOnlyMIUListLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(miuListLeftNavImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityMeterReaderMIUListLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(miuListLeftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerMIUListLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(miuListLeftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityAdminCMIUFotaLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cmiuFotaLeftNav, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneCSRCMIUFotaLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "neptune CSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cmiuFotaLeftNav, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityUserCMIUFotaLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cmiuFotaLeftNav, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityReadOnlyCMIUFotaLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cmiuFotaLeftNav, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateUtilityMeterReaderCMIUFotaLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cmiuFotaLeftNav, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerCMIUFotaLeftNavOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cmiuFotaLeftNav, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneSysAdminCMIUFotaLeftNavOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(cmiuFotaLeftNav, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateNeptuneSysAdminSendUpdateOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptune system admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(sendUpdateImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptune360PartnerSendUpdateOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(sendUpdateImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateUtilityMeterReaderSendUpdateOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utilityMeterReader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(sendUpdateImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityReadOnlySendUpdateOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utility Read Only");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(sendUpdateImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityUserSendUpdateOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utility User");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(sendUpdateImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateNeptuneCSRSendUpdateOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "neptuneCSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(sendUpdateImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityAdminSendUpdateOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utilityAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(sendUpdateImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneSysAdminViewMIUListOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptune System Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewMiuListImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityAdminViewMIUListOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utilityAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewMiuListImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneCSRViewMIUListOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "neptuneCSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewMiuListImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityUserViewMIUListOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utilityUser");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewMiuListImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityReadOnlyViewMIUListOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utilityReadOnly");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewMiuListImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityMeterReaderViewMIUListOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utilityMeterReader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewMiuListImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerViewMIUListOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune360Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewMiuListImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneSysAdminLORAPrivateNetworkOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(loraPrivateNwtworkImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityAdminLORAPrivateNetworkOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utilityAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(loraPrivateNwtworkImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneCSRLORAPrivateNetworkOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "neptuneCSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(loraPrivateNwtworkImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityUserLORAPrivateNetworkOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utilityUser");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(loraPrivateNwtworkImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityReadOnlyLORAPrivateNetworkOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utilityReadOnly");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(loraPrivateNwtworkImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityMeterReaderLORAPrivateNetworkOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utilityMeterReader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(loraPrivateNwtworkImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerLORAPrivateNetworkOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune360Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(loraPrivateNwtworkImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateLORAPrivateNetworkSettingsDisplayed()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune360Partner");
            driver.sleepTime(10000);
            driver.CheckElementDisplayed(loraPrivateNwtwork, "LORA Private Network Settings");
        }

        public void ValidateUtilityUserEditGroupContainerOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(createEditGrpContainerImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateUtilityReadOnlyEditGroupContainerOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility REad Only");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(createEditGrpContainerImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityMeterReaderEditGroupContainerOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.WaitForElement(utilityMeterReader, TimeSpan.FromSeconds(30));

            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(createEditGrpContainerImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateNeptuneSystemAdminManageGroupEndpointOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(manageGroupEndpointImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneCSRManageGroupEndpointOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "Neptune CSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(manageGroupEndpointImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateUtilityAdminManageGroupEndpointOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utility Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(manageGroupEndpointImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityUserManageGroupEndpointOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utility User");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(manageGroupEndpointImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityReadOnlyManageGroupEndpointOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utility Read Only");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(manageGroupEndpointImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityMeterReaderManageGroupEndpointOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utility Meter Reader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(manageGroupEndpointImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneSysAdminDeleteGroupsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(deleteGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneCSRDeleteGroupsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "neptune CSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(deleteGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityAdminDeleteGroupsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utilityAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(deleteGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityUserDeleteGroupsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utilityUser");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(deleteGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityReadOnlyDeleteGroupsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utilityReadOnly");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(deleteGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityMeterReaderDeleteGroupsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utilityMeterReader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(deleteGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateNeptuneSysAdminViewGroupsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneCSRViewGroupsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "neptuneCSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityAdminViewGroupsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utilityAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityUserViewGroupsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utilityUser");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityReadOnlyViewGroupsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utilityReadOnly");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityMeterReaderViewGroupsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utilityMeterReader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewGroupsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneSysAdminViewNSPDBConversionOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewNSPDBConversionImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneFeildServicePMEditSettingsDefault()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneFieldService, "neptuneFieldService");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editSettingsImg, "src").ToString();
            testReport.Info(defaultproperty);
        }
        public void ValidateNeptuneFeildServicePMViewSettingsDefault()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneFieldService, "neptuneFieldService");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewSettingsImg, "src").ToString();
            testReport.Info(defaultproperty);
        }
        public void ValidateNeptuneSysAdminEditSettingsDefault()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editSettingsImg, "src").ToString();
            testReport.Info(defaultproperty);
        }
        public void ValidateUtilityAdminAdminEditSettingsDefault()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utilityAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editSettingsImg, "src").ToString();
            testReport.Info(defaultproperty);
        }
        public void ValidateUtilityAdminAdminViewSettingsDefault()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utilityAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewSettingsImg, "src").ToString();
            testReport.Info(defaultproperty);
        }
        public void ValidateUtilityAdminBetaAdminEditSettingsDefault()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdminBeta, "utilityAdminBeta");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editSettingsImg, "src").ToString();
            testReport.Info(defaultproperty);
        }
        public void ValidateUtilityAdminBetaAdminViewSettingsDefault()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdminBeta, "utilityAdminBeta");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewSettingsImg, "src").ToString();
            testReport.Info(defaultproperty);
        }
        public void ValidateUtilityMeterReaderAdminEditSettingsDefault()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utilityMeterReader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editSettingsImg, "src").ToString();
            testReport.Info(defaultproperty);
        }
        public void ValidateUtilityMeterReaderAdminViewSettingsDefault()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utilityMeterReader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewSettingsImg, "src").ToString();
            testReport.Info(defaultproperty);
        }
        public void ValidateUtilityReadOnlyAdminEditSettingsDefault()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utilityReadOnly");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editSettingsImg, "src").ToString();
            testReport.Info(defaultproperty);
        }
        public void ValidateUtilityReadOnlyAdminViewSettingsDefault()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utilityReadOnly");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewSettingsImg, "src").ToString();
            testReport.Info(defaultproperty);
        }
        public void ValidateUtilityUserEditSettingsDefault()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utilityUser");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editSettingsImg, "src").ToString();
            testReport.Info(defaultproperty);
        }
        public void ValidateNeptuneSysAdminViewSettingsDefault()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewSettingsImg, "src").ToString();
            testReport.Info(defaultproperty);
        }

        public void ValidateNeptune360PartnerEditSettingsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune360Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editSettingsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateNeptune360PartnerViewSettingsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune360Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewSettingsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityUserViewFTPCredentialsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(billingServiceSetting, "utilityUser");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewFTPCredentials, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneAdminViewFTPCredentialsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewFTPCredentials, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateRoleManagementScreenDisplay()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.CheckElementDisplayed(defaultRole, "Default Role");
            //driver.sleepTime(10000);

        }

        public void SetPermission(string roleName, string permissionName, bool swithOn = true)
        {
            if (!driver.WaitForElement(lftNavRoleManagement, TimeSpan.FromSeconds(5)))
            {
                driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            }
            driver.ClickElement(lftNavRoleManagement, "Role Management");

            driver.FindElement(By.XPath("//div//span[text()='" + roleName + "']")).Click();

            driver.WaitForElementNotExists(permissionsLoader, 30);

            driver.ClickElement(btnEdit_RoleManagement, "Edit");

            driver.ScrollToElement(driver.FindElement(By.XPath("//span[text()='" + permissionName + "']//..//kendo-switch//span")));

            IWebElement permissionEle = driver.FindElement(By.XPath("//span[text()='" + permissionName + "']//..//kendo-switch//span"));
            if (permissionEle.GetAttribute("aria-checked") == "true")
            {
                if (!swithOn)
                    permissionEle.Click();
            }
            else
            {
                if (swithOn)
                    permissionEle.Click();
            }
            driver.ScrollToElement(driver.FindElement(btnDone_EditPermission));
            driver.ClickElement(btnDone_EditPermission, "Done");

            driver.FindElement(By.XPath("//div//span[text()='" + roleName + "']")).Click();
            if (driver.WaitForElement(permissionsSaveAlert, TimeSpan.FromSeconds(45)))
            {
                driver.ClickElement(permissionsSaveAlertCloseBtn, "Close");
            }
            driver.WaitForElementNotExists(permissionsSaveAlert);
            Thread.Sleep(1500);
            driver.ScrollToElement(driver.FindElement(drpProfile));
        }

        public void SetPermission(string roleName, Dictionary<string, bool> permissionsAndStatus)
        {
            if (!driver.WaitForElement(lftNavRoleManagement, TimeSpan.FromSeconds(5)))
            {
                driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            }
            driver.ClickElement(lftNavRoleManagement, "Role Management");

            driver.FindElement(By.XPath("//div//span[text()='" + roleName + "']")).Click();

            driver.WaitForElementNotExists(permissionsLoader, 30);

            driver.ClickElement(btnEdit_RoleManagement, "Edit");

            foreach(var permissionAndStatus in permissionsAndStatus)
            {
                driver.ScrollToElement(driver.FindElement(By.XPath("//span[text()='" + permissionAndStatus.Key + "']//..//kendo-switch//span")));

                IWebElement permissionEle = driver.FindElement(By.XPath("//span[text()='" + permissionAndStatus.Key + "']//..//kendo-switch//span"));
                if (permissionEle.GetAttribute("aria-checked") == "true")
                {
                    if (!permissionAndStatus.Value)
                        permissionEle.Click();
                }
                else
                {
                    if (permissionAndStatus.Value)
                        permissionEle.Click();
                }
            }
           
            driver.ScrollToElement(driver.FindElement(btnDone_EditPermission));
            driver.ClickElement(btnDone_EditPermission, "Done");

            driver.FindElement(By.XPath("//div//span[text()='" + roleName + "']")).Click();
            if (driver.WaitForElement(permissionsSaveAlert, TimeSpan.FromSeconds(45)))
            {
                driver.ClickElement(permissionsSaveAlertCloseBtn, "Close");
            }
            driver.WaitForElementNotExists(permissionsSaveAlert);
            Thread.Sleep(1500);
            driver.ScrollToElement(driver.FindElement(drpProfile));
        }

        public void ValidateRoleManagementScreenEdit()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            //driver.CheckElementDisplayed(cmiuReporter, "CMIU Reporter");
            driver.ClickElement(btnEdit, "Edit");
            if (driver.CheckElementDisplayed(EditrolesPage, "view user"))
            {
                testReport.Pass("edit roles pages is displayed");
            }
            else
            {
                driver.CheckElementDisplayed(viewUsersImg, "viewuser");

            }
            //driver.sleepTime(10000);

        }
        public void ValidateUpdateFeatures()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            //driver.CheckElementDisplayed(cmiuReporter, "CMIU Reporter");
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(10000);
            driver.ClickElement(updateFeaturesdropdown, "Update Features");
            driver.ClickElement(featureEnabled, "Enabled");
            driver.ClickElement(updateFeaturesdropdown, "Update Features");
            driver.ClickElement(featureDisabled, "Disabled");
        }
        public void ValidateUpdateNeptuneOnlyFeild()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            //driver.CheckElementDisplayed(cmiuReporter, "CMIU Reporter");
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(10000);
            driver.ClickElement(neptuneOnlyOnOff, "Neptune Only Switch On");
            driver.ClickElement(neptuneOnlyOnOff, "Neptune Only Switch Off");
        }
        public void ValidateNSPDBConversionDisplay()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.sleepTime(10000);
            driver.CheckElementDisplayed(viewNSPDBConversion, "NSP DB Conversion");
        }
        public void ValidateReportingFoundMeters()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            driver.CheckElementDisplayed(foundMetersReport, "Found Meters");
        }
        public void ValidateNeptuneCSRReportingFoundMetersOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(foundMetersReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneUtilityAdminReportingFoundMetersOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(foundMetersReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneUtilityUserReportingFoundMetersOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(foundMetersReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneUtilityMeterReaderReportingFoundMetersOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(foundMetersReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneUtilityReadOnlyReportingFoundMetersOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(foundMetersReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptune360PartnerReportingFoundMetersOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(foundMetersReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneSysAdminAMINoFlowOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(amiNoFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneCSRAMINoFlowOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(amiNoFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityAdminAMINoFlowOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(amiNoFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityUserAMINoFlowOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(amiNoFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityMeterReaderAMINoFlowOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(amiNoFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityReadOnlyAMINoFlowOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(amiNoFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptune360PartnerAMINoFlowOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Utility 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(amiNoFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneSysAdminInactiveFlowReport()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(inactiveFlowReport, "Inactive Flow Report");
        }
        public void ValidateNeptuneSysAdminInactiveFlowReportEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(inactiveFlowSwitchLocator, "Inactive Flow Report Switch");
        }
        public void ValidateNeptuneSysAdminDaysOfConsecutiveFlowEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(daysOfConsecutiveFlowSwitch, "Days Of Consecutive Flow Switch");
        }
        public void ValidateNeptuneSysAdminInactiveFlowReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(inactiveFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneCSRInactiveFlowReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(inactiveFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityAdminInactiveFlowReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(inactiveFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityUserInactiveFlowReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(inactiveFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityMeterReaderInactiveFlowReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(inactiveFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityReadOnlyInactiveFlowReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(inactiveFlowImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptune360PartnerInactiveFlowReportOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(inactiveFlowImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneSysAdminHighConsumptionOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(highConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneCSRHighConsumptionOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(highConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityAdminHighConsumptionOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(highConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityUserHighConsumptionOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(highConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityMeterReaderConsumptionOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(highConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityReadOnlyConsumptionOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(highConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptune360PartnerConsumptionOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune360Partner");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(highConsumptionReportImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateNeptuneSysAdminBillingServSettingOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptune System Admin");
            driver.WaitForElement(billingServSettingImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(billingServSettingImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneCSRBillingServSettingOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "neptune CSR");
            driver.WaitForElement(billingServSettingImg, TimeSpan.FromSeconds(30));
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(billingServSettingImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityAdminBillingServSettingOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utility Admin");
            driver.WaitForElement(billingServSettingImg, TimeSpan.FromSeconds(30));
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(billingServSettingImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityUserBillingServSettingOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utility User");
            driver.WaitForElement(billingServSettingImg, TimeSpan.FromSeconds(30));
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(billingServSettingImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateUtilityMeterReaderBillingServSettingOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utility Meter Reader");
            driver.WaitForElement(billingServSettingImg, TimeSpan.FromSeconds(30));
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(billingServSettingImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateUtilityReadOnlyBillingServSettingOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utility Read Only");
            driver.WaitForElement(billingServSettingImg, TimeSpan.FromSeconds(30));
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(billingServSettingImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateNeptune360PartnetBillingServSettingOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune 360 Partner");
            driver.WaitForElement(billingServSettingImg, TimeSpan.FromSeconds(30));
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(billingServSettingImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateNeptuneSysAdminEndpointMainenanceReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.WaitForElement(endpointMaintenanceReportImg, TimeSpan.FromSeconds(30));
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endpointMaintenanceReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateNeptuneCSREndpointMainenanceReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "neptune CSR");
            driver.WaitForElement(endpointMaintenanceReportImg, TimeSpan.FromSeconds(30));
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endpointMaintenanceReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityAdminEndpointMainenanceReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utility Admin");
            driver.WaitForElement(endpointMaintenanceReportImg, TimeSpan.FromSeconds(30));
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endpointMaintenanceReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateUtilityUserEndpointMainenanceReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utility User");
            driver.WaitForElement(endpointMaintenanceReportImg, TimeSpan.FromSeconds(30));
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endpointMaintenanceReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateUtilityMeterReaderEndpointMainenanceReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utility Meter Reader");
            driver.WaitForElement(endpointMaintenanceReportImg, TimeSpan.FromSeconds(30));
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endpointMaintenanceReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityReadOnlyEndpointMainenanceReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utility Read Only");
            driver.WaitForElement(endpointMaintenanceReportImg, TimeSpan.FromSeconds(30));
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endpointMaintenanceReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateNeptune360PartnerEndpointMainenanceReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune 360 Partner");
            driver.WaitForElement(endpointMaintenanceReportImg, TimeSpan.FromSeconds(30));
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(endpointMaintenanceReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateNeptuneSysAdminEditSoftDisconnetOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(editSoftDisconnectImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneCSREditSoftDisconnetOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(editSoftDisconnectImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityAdminEditSoftDisconnectOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(editSoftDisconnectImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateSysAdminSoftDisconnectReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "System Admin");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(softDisconnectReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneCSRSoftDisconnectReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(softDisconnectReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateUtilityAdminSoftDisconnectReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utility Admin");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(softDisconnectReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateUtilityUserSoftDisconnectReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utility User");
            driver.WaitForElement(softDisconnectReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(softDisconnectReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityMeterReaderSoftDisconnectReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utility Meter Reader");
            driver.WaitForElement(softDisconnectReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(softDisconnectReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityReadOnlySoftDisconnectReportOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utility Read Only");
            driver.WaitForElement(softDisconnectReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(softDisconnectReportImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptune360PartnerSoftDisconnectReportOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune 360 Partner");
            driver.WaitForElement(softDisconnectReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(softDisconnectReportImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityUserEditSoftDisconnectOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility Admin");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(editSoftDisconnectImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityReadOnlySoftDisconnectOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(editSoftDisconnectImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptune360PartnerSoftDisconnectOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(editSoftDisconnectImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneSysAdmincreateCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(createCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateNeptuneCSRcreateCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(createCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateUtilityAdmincreateCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(createCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityMeterReadercreateCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(createCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateUtilityReadOnlycreateCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read ONly");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(createCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnercreateCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(createCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneSysAdminEditCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(editCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneCSREditCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(editCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityAdminEditCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(editCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityUserEditCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(editCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityMeterReaderEditCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(editCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityReadOnlyEditCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(editCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerEditCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(editCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneCustSupportEditCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "Neptune CustSupport");
            driver.WaitForElement(highConsumptionReportImg, TimeSpan.FromSeconds(30));
            string defaultproperty = driver.GetElementProperty(editCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneSysAdminViewComments()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune Sys Admin");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.CheckElementDisplayed(viewComments, "View Comments");
        }
        public void ValidateNeptuneCSRcreateCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(createCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityUsercreateCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(createCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneSysAdminViewCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune Sys Admin");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(viewCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateNeptuneCSRViewCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(viewCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityAdminViewCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(viewCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }

        public void ValidateUtilityUserViewCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(viewCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityMeterReaderViewCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(viewCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerViewCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune360Partner");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(viewCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneSysAdminCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(deleteOwnCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneCSRDeleteCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "NeptuneCSR");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(deleteOwnCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityAdminDeleteCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utilityAdmin");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(deleteOwnCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityUserDeleteCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utilityUser");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(deleteOwnCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityMeterReaderDeleteCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utilityMeterReader");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(deleteOwnCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityReadOnlyDeleteCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utilityReadOnly");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(deleteOwnCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateNeptune360PartnerDeleteCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune360Partner");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(deleteOwnCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneCustSupportDeleteCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "neptuneCustSupport");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(deleteOwnCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateDeleteOthersCommentsDisplayed()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.sleepTime(10000);
            driver.CheckElementDisplayed(deleteOthersComm, "Delete Others Comment");
        }

        public void ValidateDeleteOthersCommentsEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(deleteOthersCommentSwitch, "Switch");
        }

        public void ValidateNeptuneSysAdminDeleteOthersCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "neptuneSystemAdmin");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(deleteOthersCommImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateNeptuneCSRDeleteOthersCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "neptuneCSR");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(deleteOthersCommImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateUtilityAdminDeleteOthersCommentsOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "utilityAdmin");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(deleteOthersCommImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to Off");
            }
        }
        public void ValidateUtilityUserDeleteOthersCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "utility User");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(deleteOthersCommImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityMeterReaderDeleteOthersCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "utility MeterReader");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(deleteOthersCommImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityReadOnlyDeleteOthersCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "utility Read Only");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(deleteOthersCommImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerDeleteOthersCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "neptune360Partner");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(deleteOthersCommImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptuneCustSupportDeleteOthersCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "neptuneCustSupport");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(deleteOthersCommImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }

        public void ValidateUtilityReadOnlyViewCommentsOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            string defaultproperty = driver.GetElementProperty(viewCommentsImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateCreateCommentsEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.ClickElement(btnEdit, "");
            driver.ClickElement(createCommentsSwitch, "Switch");
        }
        public void ValidateBillingServicesSettingsEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.ClickElement(btnEdit, "");
            driver.ClickElement(billingServicesSettingSwitch, "Switch");
        }
        public void ValidateDaysOfConsFlowAmiEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.ClickElement(btnEdit, "");
            driver.ClickElement(daysofConsFlowAMIBasedSwitch, "Switch");
        }
        public void ValidateSoftDisconnectReportEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.ClickElement(btnEdit, "");
            driver.ClickElement(softDisconnectSwitch, "Switch");
        }
        public void ValidateNeptuneSysAdminCreateComments()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.CheckElementDisplayed(createComments, "Create Comments");
        }
        public void ValidateNeptuneSysAdminSoftDisconnectReport()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.CheckElementDisplayed(softDisconnectReport, "softDisconnectReport");
        }

        public void ValidateUtilityMeterReaderEditSoftDisconnectOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            driver.WaitForPageLoad(TimeSpan.FromSeconds(5));
            driver.sleepTime(20000);
            testReport.Info("Permission is set to : " + driver.GetElementProperty(editSoftDisconnectImg, "src").ToString());
        }
        public void ValidateNeptuneSysAdminEditSoftDisconnetEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(editSoftDisconnectSwitch, "Switch");
        }
        public void ValidatViewCommentsEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(viewCommentsSwitch, "Switch");
        }
        public void ValidateHighConsumptionReport()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(highConsumptionReport, driver.GetElementText(highConsumptionReport));
        }
        public void ValidateEditCommentsDisplay()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(editComments, driver.GetElementText(editComments));
        }
        public void ValidateEditCommentsEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(editCommentsSwitch, "Switch");
        }
        public void ValidateHighConsumptionReportEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(highConsumptionReportSwitch, "Switch");
        }
        public void ValidateNeptuneSystemAdminAmiNoFlow()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            driver.CheckElementDisplayed(amiNoFlow, "AMI No Flow Report");
        }
        public void ValidateNeptuneSystemAdminDeleteOwnComm()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            driver.CheckElementDisplayed(deleteOwnComm, "Delete Own Comments");
        }
        public void ValidateNeptuneSystemAdminDeleteOwnCommEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(deleteOwnCommSwitch, "Switch");
        }
        public void ValidateNeptuneSystemAdminAmiNoFlowEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(amiNoFlowSwitch, "Switch");
            driver.ClickElement(amiNoFlowSwitch, "Switch");
            if (driver.CheckElementDisplayed(EditrolesPage, "AMI No Flow Report"))
            {
                testReport.Pass("AMI No flow report is editable");
            }
            else
            {
                ReporterFactory.LogFailure("AMI No Flow report is not editable");

            }

        }
        public void ValidatePermission(string permission)
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string property = driver.GetElementProperty(By.XPath("//span[text()='" + permission + "']/..//img"), "src").ToString();
            if (property.Contains("Cancel"))
            {
                testReport.Pass(permission + " permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(permission + "permission is set to On");
            }
        }
        public void ValidateSystemAdminPermission(string permission)
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            string property = driver.GetElementProperty(By.XPath("//span[text()='" + permission + "']/..//img"), "src").ToString();
            if (property.Contains("Cancel"))
            {
                testReport.Pass(permission + " permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure(permission + "permission is set to On");
            }
        }
        public void ValidateSystemAdminPermissionOn(string permission)
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            string property = driver.GetElementProperty(By.XPath("//span[text()='" + permission + "']/..//img"), "src").ToString();
            if (property.Contains("Confirm"))
            {
                testReport.Pass(permission + " permission is set to On");
            }
            else
            {
                ReporterFactory.LogFailure(permission + "permission is set to Off");
            }
        }
        public void ValidateGroupWidgetPermssion()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.sleepTime(10000);
            driver.CheckElementDisplayed(groupsWidgetImg, "Groups Widget");
        }
        public void ValidateNeptune360PartnereditHandheldSettingOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(editHandheldSettingImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerviewNeptuneConnectOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(viewNeptuneConnectImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateNeptune360PartnerDownloadNeptuneConnectOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            driver.sleepTime(10000);
            string defaultproperty = driver.GetElementProperty(downloadNeptuneConnectImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Permission is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Permission is set to On");
            }
        }
        public void ValidateUtilityUserSDKAccessOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utililty User");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(sdkAccessLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Neptune CSR permission SDK is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Neptune CSR permission SDK is set to On");
            }
        }
        public void ValidateUtilityMeterReaderSDKAccessOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utililty Meter Reader");
            driver.sleepTime(5000);
            string defaultproperty = driver.GetElementProperty(sdkAccessLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Neptune CSR permission SDK is set to Off");
            }
            else
            {
                ReporterFactory.LogFailure("Neptune CSR permission SDK is set to On");
            }
        }
        public void ValidateNetworkHealthField()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            driver.WaitForElement(dashboardNetworkHealth, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(dashboardNetworkHealth, "Dashboard Network Health");
        }
        public void ValidateNetworkHealthFieldReadOnly()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            driver.WaitForElement(dashboardNetworkHealthWidget, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(dashboardNetworkHealthWidget, "Dashboard Network Health");
        }
        public void ValidateNetworkHealthFieldUtilityMeterReader()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            driver.WaitForElement(dashboardNetworkHealth, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(dashboardNetworkHealth, "Dashboard Network Health");
        }

        /// <summary>
        /// Method to Validate Utility User File Mapper Off
        /// </summary>
        public void ValidateUtillityUserFileMapperOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            string defaultproperty = driver.GetElementProperty(fileMapperImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("By Default File Mapper Left Navigation Permission is Turned Off");
            }
            else
            {
                ReporterFactory.LogFailure("By Default File Mapper Left Navigation Permission is Turned On");
            }
        }

        /// <summary>
        /// Method to Validate Utility MeterReader File Mapper Off
        /// </summary>
        public void ValidateUtillityMeterReaderFileMapperOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            string defaultproperty = driver.GetElementProperty(fileMapperImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("By Default File Mapper Left Navigation Permission is Turned Off");
            }
            else
            {
                ReporterFactory.LogFailure("By Default File Mapper Left Navigation Permission is Turned On");
            }
        }

        /// <summary>
        /// Method to Validate Utility Read Only File Mapper Off
        /// </summary>
        public void ValidateUtillityReadOnlyFileMapperOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            string defaultproperty = driver.GetElementProperty(fileMapperImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("By Default File Mapper Left Navigation Permission is Turned Off");
            }
            else
            {
                ReporterFactory.LogFailure("By Default File Mapper Left Navigation Permission is Turned On");
            }
        }

        /// <summary>
        /// Method to Validate Neptune CSR File Mapper Off
        /// </summary>
        public void ValidateNeptuneCSRFileMapperOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            string defaultproperty = driver.GetElementProperty(fileMapperImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("File Mapper Feature Group is Diabled");
            }
            else
            {
                ReporterFactory.LogFailure("File Mapper Feature Group is Enabled");
            }
        }



        /// <summary>
        /// Method to Validate Neptune User File Mapper Off
        /// </summary>
        public void ValidateUtilityUserFileMapperOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Neptune UtilityUser");
            string defaultproperty = driver.GetElementProperty(fileMapperLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("By Default File Mapper Left Navigation Permission is Turned Off");
            }
            else
            {
                ReporterFactory.LogFailure("By Default File Mapper Left Navigation Permission is Turned On");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Meter Reader File Mapper Off
        /// </summary>
        public void ValidateUtilityMeterReaderFileMapperOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Neptune Meter Reader");
            string defaultproperty = driver.GetElementProperty(fileMapperLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("By Default File Mapper Left Navigation Permission is Turned Off");
            }
            else
            {
                ReporterFactory.LogFailure("By Default File Mapper Left Navigation Permission is Turned On");
            }
        }

        /// <summary>
        /// Method to Validate Utility Read Only File Mapper Off
        /// </summary>
        public void ValidateUtilityReadOnlyFileMapperOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            string defaultproperty = driver.GetElementProperty(fileMapperLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("By Default File Mapper Left Navigation Permission is Turned Off");
            }
            else
            {
                ReporterFactory.LogFailure("By Default File Mapper Left Navigation Permission is Turned On");
            }
        }

        /// <summary>
        /// Method to Validate Utility Meter Reader Handheld Management
        /// </summary>
        public void ValidateUtilityMeterReaderHandheldManagement()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            string defaultproperty = driver.GetElementProperty(handheldManagementImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handheld Management Left Navigation permissions is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Handheld Management Left Navigation permissions is set by default to No");
            }
        }

        /// <summary>
        /// Method to Validate Neptune 360 Essential Handheld Lft
        /// </summary>
        public void ValidateNeptune360EssentialHandheldLft()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360essentials, "Neptune 360 Essential");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handhelds Left Navigation permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Handhelds Left Navigation permission is set by default to No");
            }
        }

        /// <summary>
        /// Method to Validate Utility Admin Handheld Lft
        /// </summary>
        public void ValidateUtilityAdminHandheldLft()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handhelds Left Navigation permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Handhelds Left Navigation permission is set by default to No");
            }
        }

        /// <summary>
        /// Method to Validate Utility Admin Beta Handheld Lft
        /// </summary>
        public void ValidateUtilityAdminBetaHandheldLft()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdminBeta, "Utility Admin Beta");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handhelds Left Navigation permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Handhelds Left Navigation permission is set by default to No");
            }
        }

        /// <summary>
        /// Method to Validate Neptune360 Partner Handhelds Setting
        /// </summary>
        public void ValidateNeptune360PartnerHandheldsSetting()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune360 Partner");
            string defaultproperty = driver.GetElementProperty(handheldsSettingImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Handheld Settings Left Navigation permission is set by default to No");
            }
            else
            {
                ReporterFactory.LogFailure("Handheld Settings Left Navigation permission is set by default to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Cust Support Handhelds Lft
        /// </summary>
        public void ValidateNeptuneCustSupportHandheldsLft()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, " Neptune Cust Support");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handhelds Left Navigation permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Handhelds Left Navigation permission is set by default to No ");
            }
        }

        /// <summary>
        /// Method to Validate API Deployment Left Navigation
        /// </summary>
        public void ValidateAPIDeploymentLeftNavigation()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, " Neptune System Admin");
            driver.CheckElementExists(apiDeploymentLftNav, "API Deployment Left Navigation");
        }

        /// <summary>
        /// Method to Validate API Deployment Feature Group
        /// </summary>
        public void ValidateAPIDeploymentFeatureGroup()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, " Neptune System Admin");
            driver.CheckElementDisplayed(viewApiDeployment, "API Deployment Feature Group");
        }

        /// <summary>
        /// Method to Validate API Deployment Create Bundles
        /// </summary>
        public void ValidateAPIDeploymentCreateBundles()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, " Neptune System Admin");
            driver.CheckElementDisplayed(createBundles, "Create Bundles Permission is displayed under API Deployment feature");
        }

        /// <summary>
        /// Method to Validate API Deployment Edit Bundles
        /// </summary>
        public void ValidateAPIDeploymentEditBundles()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, " Neptune System Admin");
            driver.CheckElementDisplayed(editBundles, "EDit Bundles Permission is displayed under API Deployment feature");
        }

        /// <summary>
        /// Method to Validate Neptune Sys Admin API Deployment Lft
        /// </summary>
        public void ValidateNeptuneSysAdminAPIDeploymentLftOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, " Neptune Sys Admin");
            string defaultproperty = driver.GetElementProperty(apiDeploymentLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("API Deployment Left Navigation is set to YES");
            }
            else
            {
                ReporterFactory.LogFailure("API Deployment Left Navigation is set to No ");
            }
        }

        /// <summary>
        /// Method to Validate Neptune CSR API Deployment Lft Off
        /// </summary>
        public void ValidateNeptuneCSRAPIDeploymentLftOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, " Neptune CSR");
            string defaultproperty = driver.GetElementProperty(apiDeploymentLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("API Deployment Left Navigation is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("API Deployment Left Navigation is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Utility Admin API Deployment Lft Off
        /// </summary>
        public void ValidateNeptuneUtilityAdminAPIDeploymentLftOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            string defaultproperty = driver.GetElementProperty(apiDeploymentLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("API Deployment Left Navigation is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("API Deployment Left Navigation is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Utility User API Deployment Lft Off
        /// </summary>
        public void ValidateNeptuneUtilityUserAPIDeploymentLftOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            string defaultproperty = driver.GetElementProperty(apiDeploymentLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("API Deployment Left Navigation is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("API Deployment Left Navigation is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Utility Read Only API Deployment Lft Off
        /// </summary>
        public void ValidateUtilityReadOnlyAPIDeploymentLftOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            string defaultproperty = driver.GetElementProperty(apiDeploymentLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("API Deployment Left Navigation is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("API Deployment Left Navigation is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Utility Meter Reader Only API Deployment Lft Off
        /// </summary>
        public void ValidateUtilityMeterReaderAPIDeploymentLftOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            string defaultproperty = driver.GetElementProperty(apiDeploymentLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("API Deployment Left Navigation is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("API Deployment Left Navigation is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Neptune System Admin API Deployment On
        /// </summary>
        public void ValidateNeptuneSystemAdminAPIDeploymentOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            string defaultproperty = driver.GetElementProperty(apiDeploymentLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("API Deployment Left Navigation is set to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("API Deployment Left Navigation is set to No ");
            }
        }

        /// <summary>
        /// Method to Validate Neptune CSR API Deployment Off
        /// </summary>
        public void ValidateNeptuneCSRAPIDeploymentOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            string defaultproperty = driver.GetElementProperty(apiDeploymentLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("API Deployment Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("API Deployment Left Navigation is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Utility Admin API Deployment Off
        /// </summary>
        public void ValidateUtilityAdminAPIDeploymentOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            string defaultproperty = driver.GetElementProperty(apiDeploymentLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("API Deployment Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("API Deployment Left Navigation is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Utility User API Deployment Off
        /// </summary>
        public void ValidateUtilityUserAPIDeploymentOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility User");
            string defaultproperty = driver.GetElementProperty(apiDeploymentLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("API Deployment Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("API Deployment Left Navigation is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Utility Read Only API Deployment Off
        /// </summary>
        public void ValidateUtilityReadOnlyAPIDeploymentOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            string defaultproperty = driver.GetElementProperty(apiDeploymentLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("API Deployment Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("API Deployment Left Navigation is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Utility Meter Reader Only API Deployment Off
        /// </summary>
        public void ValidateUtilityMeterReaderAPIDeploymentOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            string defaultproperty = driver.GetElementProperty(apiDeploymentLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("API Deployment Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("API Deployment Left Navigation is set to Yes ");
            }
        }


        /// <summary>
        /// Method to Validate Utility System Admin Create Bundles On()
        /// </summary>
        public void ValidateUtilitySystemAdminCreateBundlesOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Utility System Admin");
            string defaultproperty = driver.GetElementProperty(createBundlesImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Create Bundles permission is set to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Create Bundles permission is set to NO");
            }
        }

        /// <summary>
        /// Method to Validate Neptune CSR Create Bundles Off()
        /// </summary>
        public void ValidateNeptuneCSRCreateBundlesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "NeptuneCSR");
            string defaultproperty = driver.GetElementProperty(createBundlesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Create Bundles permission is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("Create Bundles permission is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Utility Admin Create Bundles Off()
        /// </summary>
        public void ValidateUtilityAdminCreateBundlesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            string defaultproperty = driver.GetElementProperty(createBundlesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Create Bundles permission is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("Create Bundles permission is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Utility User Create Bundles Off()
        /// </summary>
        public void ValidateUtilityUserCreateBundlesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            string defaultproperty = driver.GetElementProperty(createBundlesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Create Bundles permission is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("Create Bundles permission is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Utility Read Only Create Bundles Off()
        /// </summary>
        public void ValidateUtilityReadOnlyCreateBundlesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            string defaultproperty = driver.GetElementProperty(createBundlesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Create Bundles permission is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("Create Bundles permission is set to Yes ");
            }
        }
        /// <summary>
        /// Method to Validate Utility Meter Reader Create Bundles Off()
        /// </summary>
        public void ValidateUtilityMeterReaderCreateBundlesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            string defaultproperty = driver.GetElementProperty(createBundlesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Create Bundles permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Create Bundles permission is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune System Admin Edit Bundles On()
        /// </summary>
        public void ValidateNeptuneSystemAdminEditBundlesOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            string defaultproperty = driver.GetElementProperty(editBundlesImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Edit Bundles permission is set to YES");
            }
            else
            {
                ReporterFactory.LogFailure("Edit Bundles permission is set to No ");
            }
        }

        /// <summary>
        /// Method to Validate Neptune CSR Edit Bundles Off()
        /// </summary>
        public void ValidateNeptuneCSRAdminEditBundlesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            string defaultproperty = driver.GetElementProperty(editBundlesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit Bundles permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Edit Bundles permission is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Utility Admin Edit Bundles Off()
        /// </summary>
        public void ValidateUtilityAdminEditBundlesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            string defaultproperty = driver.GetElementProperty(editBundlesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit Bundles permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Edit Bundles permission is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Utility User Edit Bundles Off()
        /// </summary>
        public void ValidateUtilityUserEditBundlesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            string defaultproperty = driver.GetElementProperty(editBundlesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit Bundles permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Edit Bundles permission is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Utility Read Only Edit Bundles Off()
        /// </summary>
        public void ValidateUtilityReadOnlyEditBundlesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            string defaultproperty = driver.GetElementProperty(editBundlesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit Bundles permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Edit Bundles permission is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Utility Meter Reader Edit Bundles Off()
        /// </summary>
        public void ValidateUtilityMeterReaderEditBundlesOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            string defaultproperty = driver.GetElementProperty(editBundlesImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit Bundles permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Edit Bundles permission is set to Yes ");
            }
        }

        /// <summary>
        /// Method to Validate Neptune System Admin Partner Management ON()
        /// </summary>
        public void ValidateNeptuneSystemAdminPartnerManagementON()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            string defaultproperty = driver.GetElementProperty(partnerManagementLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Partner Management Left Navigation is set to YES");
            }
            else
            {
                ReporterFactory.LogFailure("Partner Management Left Navigation is set to No");
            }
        }

        /// <summary>
        /// Method to Validate Neptune CSR Partner Management Off
        /// </summary>
        public void ValidateNeptuneCSRPartnerManagementOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            string defaultproperty = driver.GetElementProperty(partnerManagementLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Partner Management Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Partner Management Left Navigation is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Utiliy Admin Partner Management Off
        /// </summary>
        public void ValidateUtilityAdminPartnerManagementOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utiliy Admin");
            string defaultproperty = driver.GetElementProperty(partnerManagementLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Partner Management Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Partner Management Left Navigation is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Utiliy User Partner Management Off
        /// </summary>
        public void ValidateUtilityUserPartnerManagementOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utiliy User");
            string defaultproperty = driver.GetElementProperty(partnerManagementLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Partner Management Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Partner Management Left Navigation is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Utiliy User View Partner Management Off
        /// </summary>
        public void ValidateUtilityUserViewPartnerManagementOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utiliy User");
            string defaultproperty = driver.GetElementProperty(viewPartnerManagementImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Partner Management Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Partner Management Left Navigation is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Utiliy Meter REader View Partner Management Off
        /// </summary>
        public void ValidateUtilityMeterReaderViewPartnerManagementOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utiliy Meter Reader");
            string defaultproperty = driver.GetElementProperty(viewPartnerManagementImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Partner Management Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Partner Management Left Navigation is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune System Admin Create Partner On
        /// </summary>
        public void ValidateNeptuneSystemAdminCreatePartnerOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            string defaultproperty = driver.GetElementProperty(createPartnerImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Create Partners permission is set to YES");
            }
            else
            {
                ReporterFactory.LogFailure("Create Partners permission is set to No");
            }
        }

        /// <summary>
        /// Method to Validate Neptune CSR Create Partner Off
        /// </summary>
        public void ValidateNeptuneCSRCreatePartnerOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            string defaultproperty = driver.GetElementProperty(createPartnerImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Create Partners permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Create Partners permission is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Utility Admin Create Partner Off
        /// </summary>
        public void ValidateUtilityAdminCreatePartnerOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            string defaultproperty = driver.GetElementProperty(createPartnerImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Create Partners permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Create Partners permission is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Utility User Create Partner Off
        /// </summary>
        public void ValidateUtilityUserCreatePartnerOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            string defaultproperty = driver.GetElementProperty(createPartnerImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Create Partners permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Create Partners permission is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Utility REad only Create Partner Off
        /// </summary>
        public void ValidateUtilityReadOnlyCreatePartnerOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility ReadOnly");
            string defaultproperty = driver.GetElementProperty(createPartnerImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Create Partners permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Create Partners permission is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Utility MeterReader Create Partner Off
        /// </summary>
        public void ValidateUtilityMeterReaderCreatePartnerOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility MeterReader");
            string defaultproperty = driver.GetElementProperty(createPartnerImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Create Partners permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Create Partners permission is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune System Admin Edit Partners On
        /// </summary>
        public void ValidateNeptuneSystemAdminEditPartnersOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            string defaultproperty = driver.GetElementProperty(editPartnersImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Edit Partners permission is set to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Edit Partners permission is set to No");
            }
        }


        /// <summary>
        /// Method to Validate Neptune CSR Edit Partners Off
        /// </summary>
        public void ValidateNeptuneCSREditPartnersOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            string defaultproperty = driver.GetElementProperty(editPartnersImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit Partners permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Edit Partners permission is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Utility Admin Edit Partners Off
        /// </summary>
        public void ValidateUtilityAdminEditPartnersOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            string defaultproperty = driver.GetElementProperty(editPartnersImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit Partners permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Edit Partners permission is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Utility User Edit Partners Off
        /// </summary>
        public void ValidateUtilityUserEditPartnersOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            string defaultproperty = driver.GetElementProperty(editPartnersImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit Partners permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Edit Partners permission is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Utility ReadOnly Edit Partners Off
        /// </summary>
        public void ValidateUtilityUserReadOnlyPartnersOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility ReadOnly");
            string defaultproperty = driver.GetElementProperty(editPartnersImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit Partners permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Edit Partners permission is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Utility MeterReader Edit Partners Off
        /// </summary>
        public void ValidateUtilityUserMeterReaderPartnersOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            string defaultproperty = driver.GetElementProperty(editPartnersImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Edit Partners permission is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Edit Partners permission is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Usage Plans Left Nav
        /// </summary>
        public void ValidateUsagePlansLeftNav()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(usagePlansLftNav, "Usage Plans Left Navigation");
        }

        /// <summary>
        /// Method to Validate Usage Plans Feature Group
        /// </summary>
        public void ValidateUsagePlansFeatureGroup()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(usagePlaneFeatureGrp, "Usage Plans Feature Group");
        }

        /// <summary>
        /// Method to Validate View Usage Plans 
        /// </summary>
        public void ValidateViewUsagePlans()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(viewUsagePlans, "View Usage Plans");
        }

        /// <summary>
        /// Method to Validate Edit  Usage Plans 
        /// </summary>
        public void ValidateEditUsagePlans()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.CheckElementDisplayed(editUsagePlans, "Edit  Usage Plans");
        }

        /// <summary>
        /// Method to Validate Utiliy ReadOnly Partner Management Off
        /// </summary>
        public void ValidateUtilityReadOnlyPartnerManagementOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utiliy ReadOnly");
            string defaultproperty = driver.GetElementProperty(viewPartnerManagementImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Partner Management Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Partner Management Left Navigation is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Usage Plans Lft Nav On System Admin
        /// </summary>
        public void ValidateUsagePlansLftNavOnSystemAdmin()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "System Admin");
            string defaultproperty = driver.GetElementProperty(usagePlansLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Usage Plans Left Navigation is set to YES");
            }
            else
            {
                ReporterFactory.LogFailure("Usage Plans Left Navigation is set to No");
            }
        }

        /// <summary>
        /// Method to Validate Usage Plans Lft Nav CSR Off
        /// </summary>
        public void ValidateUsagePlansLftNavCSROff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune CSR");
            string defaultproperty = driver.GetElementProperty(usagePlansLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Usage Plans Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Usage Plans Left Navigation is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Usage Plans Lft Nav Utility Admin Off
        /// </summary>
        public void ValidateUsagePlansLftNavUtilityAdminOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            string defaultproperty = driver.GetElementProperty(usagePlansLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Usage Plans Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Usage Plans Left Navigation is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Usage Plans Lft Nav Utility User Off
        /// </summary>
        public void ValidateUsagePlansLftNavUtilityUserOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            string defaultproperty = driver.GetElementProperty(usagePlansLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Usage Plans Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Usage Plans Left Navigation is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Usage Plans Lft Nav Utility Read Only Off
        /// </summary>
        public void ValidateUsagePlansLftNavUtilityReadOnlyOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            string defaultproperty = driver.GetElementProperty(usagePlansLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Usage Plans Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Usage Plans Left Navigation is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Usage Plans Lft Nav Utility Meter Reader Off
        /// </summary>
        public void ValidateUsagePlansLftNavUtilityMeterReaderOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            string defaultproperty = driver.GetElementProperty(usagePlansLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Usage Plans Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Usage Plans Left Navigation is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Usage Plans Lft Nav Neptune System Admin On
        /// </summary>
        public void ValidateUsagePlansLftNavNeptuneSystemAdminOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            string defaultproperty = driver.GetElementProperty(usagePlansLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Usage Plans Left Navigation is set to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Usage Plans Left Navigation is set to No");
            }
        }

        /// <summary>
        /// Method to Validate Utiliy Meter Reader Partner Management Off
        /// </summary>
        public void ValidateUtilityMeterReaderPartnerManagementOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utiliy Meter Reader");
            string defaultproperty = driver.GetElementProperty(partnerManagementLftNavImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Partner Management Left Navigation is set to No");
            }
            else
            {
                ReporterFactory.LogFailure("Partner Management Left Navigation is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune System Admin Partner Management On
        /// </summary>
        public void ValidateNeptuneSystemAdminPartnerManagementOn()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            string defaultproperty = driver.GetElementProperty(viewPartnerManagementImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Partner Management Left Navigation is set to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Partner Management Left Navigation is set to No");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Sys Admin Handhelds Lft
        /// </summary>
        public void ValidateNeptuneSysAdminHandheldsLft()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, " Neptune Sys Admin");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handhelds Left Navigation permission is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Handhelds Left Navigation permission is set by default to No ");
            }
        }

        /// <summary>
        /// Method to Validate Utility Meter Reader Handhelds Settings
        /// </summary>
        public void ValidateUtilityMeterReaderHandheldsSettings()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, " Utility Meter Reader");
            string defaultproperty = driver.GetElementProperty(handheldsSettingImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Handheld Settings Left Navigation permission is set by default to No");
            }
            else
            {
                ReporterFactory.LogFailure("Handheld Settings Left Navigation permission is set by default to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Handhelds Settings Left Navigation
        /// </summary>
        public void ValidateHandheldsSettingsLeftNav()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, " Utility Meter Reader");
            driver.CheckElementDisplayed(handheldslft, "Handhelds Settings");
        }

        /// <summary>
        /// Method to Validate Utility Read Only Handheld Lft
        /// </summary>
        public void ValidateUtilityReadOnlyHandheldLft()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handhelds Left Navigation permissions is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Handhelds Left Navigation permissions is set by default to No");
            }
        }

        /// <summary>
        /// Method to Validate Sys Admin Handheld Settings
        /// </summary>
        public void ValidateSysAdminHandheldSettings()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Sys Admin");
            string defaultproperty = driver.GetElementProperty(handheldsSettingImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handhelds Left Navigation permissions is set by default to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Handhelds Left Navigation permissions is set by default to No");
            }
        }


        /// <summary>
        /// Method to Validate Neptune Utility Admin Beta Handheld Management Yes
        /// </summary>
        public void ValidateNeptuneUtilityAdminBetaHandheldManagementYes()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Neptune Field Service Default is set to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Neptune Field Service Default is set to No");
            }
        }

        /// <summary>
        /// Method to Validate Handheld Settings Left Navigation Utility Read Only No
        /// </summary>
        public void ValidateHandheldSettingsLeftNavigationUtilityReadOnlyNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Utility Read Only");
            string defaultproperty = driver.GetElementProperty(handheldsSettingImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Handheld Settings Left Navigation permissions is set by default to No");
            }
            else
            {
                ReporterFactory.LogFailure("Handheld Settings Left Navigation permissions is set by default to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Cust Support Handheld Management Yes
        /// </summary>
        public void ValidateNeptuneCustSupportHandheldManagementYes()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "Neptune Cust Support");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Neptune Field Service Default is set to Yes");
            }
            else
            {
                ReporterFactory.LogFailure("Neptune Field Service Default is set to No");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Customer Support Yes
        /// </summary>
        public void ValidateNeptuneCustomerSupportYes()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCustSupport, "Neptune Customer Support");
            string defaultproperty = driver.GetElementProperty(neptune360lftnavPropertyImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Neptune Field Service Default is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Customer Service Yes
        /// </summary>
        public void ValidateNeptuneCustomerServiceYes()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune Customer Service");
            string defaultproperty = driver.GetElementProperty(neptune360lftnavPropertyImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Neptune Field Service Default is set to Yes");
            }
        }
        /// <summary>
        /// Method to Validate Neptune System Admin
        /// </summary>
        public void ValidateNeptuneSystemAdmin()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            string defaultproperty = driver.GetElementProperty(neptune360lftnavPropertyImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Neptune Field Service Default is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Utility Admin
        /// </summary>
        public void ValidateNeptuneUtilityAdmin()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Neptune Utility Admin");
            string defaultproperty = driver.GetElementProperty(neptune360lftnavPropertyImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Neptune Field Service Default is set to Yes");
            }
        }
        /// <summary>
        /// Method to Validate Neptune Utility Admin Beta
        /// </summary>
        public void ValidateNeptuneUtilityAdminBeta()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdminBeta, "Neptune Utility Admin");
            string defaultproperty = driver.GetElementProperty(neptune360lftnavPropertyImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Neptune Field Service Default is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Utility Read Only
        /// </summary>
        public void ValidateNeptuneUtilityReadOnly()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityReadOnly, "Read Only");
            string defaultproperty = driver.GetElementProperty(neptune360lftnavPropertyImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Neptune Field Service Default is set to Yes");
            }
        }
        /// <summary>
        /// Method to Validate Neptune Utility Meter Reader
        /// </summary>
        public void ValidateNeptuneUtilityMeterReader()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityMeterReader, "Utility Meter Reader");
            string defaultproperty = driver.GetElementProperty(neptune360lftnavPropertyImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Neptune Field Service Default is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Utility User Reader
        /// </summary>
        public void ValidateNeptuneUtilityUserReader()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityUser, "Utility User");
            string defaultproperty = driver.GetElementProperty(neptune360lftnavPropertyImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Neptune Field Service Default is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Partner Advanced RF Test
        /// </summary>
        public void ValidateNeptunePartnerAdvancedRFTest()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            string defaultproperty = driver.GetElementProperty(advancedRFTestImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Advanced RF Test permission is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("Advanced RF Test permission is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Partner Pressure
        /// </summary>
        public void ValidateNeptunePartnerPressure()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            string defaultproperty = driver.GetElementProperty(mmrPressureImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Pressure permission is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("Pressure permission is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Partner Meter Reading
        /// </summary>
        public void ValidateNeptunePartnerMeterReading()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            string defaultproperty = driver.GetElementProperty(mmrMeterReadingIMg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Meter Reading permission is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("Meter Reading permission is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune Partner Sync Unassigned Routes
        /// </summary>
        public void ValidateNeptunePartnerSyncUnassignedRoutes()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            string defaultproperty = driver.GetElementProperty(mmrSyncUnasssignedRoutes, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Sync Unassigned Routes is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("Sync Unassigned Routes is set to Yes");
            }
        }


        /// </summary>
        /// Method to Validate Neptune Partner MMR MIU Logging
        /// </summary>
        public void ValidateNeptuneMobileAdvanceRFTest()
        {
            //driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            //driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptune360Partner, "Neptune 360 Partner");
            string defaultproperty = driver.GetElementProperty(advancedRFTestImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Advance RF Test permission is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("Advance RF Test permission is set to YES");
            }
        }
        public void ValidateSendPasswordResetToSelf(string utility)
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavUserManagement, "User Management");
            driver.sleepTime(10000);
            driver.SendKeysToElementAndPressEnter(utilityUserSearch, utility, "Utility User");
            driver.ClickElement(utilityName, "Utility Name");
            driver.ClickElement(btnCancel, "");
        }
        public void ValidateNeptuneFieldServiceMobileMMRMIULogging()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneFieldService, "Neptune Field Service PM");
            string defaultproperty = driver.GetElementProperty(miuLoggingImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("MIU Logging Test permission is set to ON");
            }
            else
            {
                ReporterFactory.LogFailure("MIU Logging Test permission is set to YES");
            }
        }

        public void ValidateNeptuneFieldServiceMobileMMRPressure()
        {
            //driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            //driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneFieldService, "Neptune Field Service PM");
            string defaultproperty = driver.GetElementProperty(mmrPressureImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Pressure permission is set to NO");
            }
            else
            {
                ReporterFactory.LogFailure("Pressure permission is set to YES");
            }
        }
        public void ValidateNeptuneFieldServiceMobileMMRMeterReading()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(30));

            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(neptuneFieldService, "Neptune Field Service PM");
            driver.WaitForElement(meterReadingSwitch, TimeSpan.FromSeconds(30));
            driver.ClickElement(meterReadingSwitch, "Meter Reading");
        }
        public void ValidateReportLeftNavigationToggle()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnEdit, "Edit");
            driver.WaitForElement(reportLeftNavigation, TimeSpan.FromSeconds(30));
            driver.ClickElement(reportLeftNavigation, "Report Left Navigation Toggle");
        }
        public void ValidateFileMapperToggle()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.WaitForElement(fileMapperToggle, TimeSpan.FromSeconds(30));
            driver.ClickElement(fileMapperToggle, "File Mapper Left Nav Toggle");
        }
        public void ValidateInvalidReadingEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            driver.WaitForElement(invalidReadingsSwitch, TimeSpan.FromSeconds(30));
            driver.ClickElement(invalidReadingsSwitch, "Meter Reading");
            testReport.Info("Enabled");
            driver.ClickElement(invalidReadingsSwitch, "Meter Reading");
            testReport.Info("Disabled");
        }
        public void ValidateNeptuneFieldServiceMobileAdvanceRfTestOff()
        {
            string defaultproperty = driver.GetElementProperty(advancedRFTestImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                driver.ClickElement(btnEdit, "Edit");
                driver.ClickElement(neptuneFieldService, "Neptune Field Service PM");
                driver.WaitForElement(meterReadingSwitch, TimeSpan.FromSeconds(30));
                driver.ClickElement(advanceRFTestSwitch, "Advance RF Test Switch");
            }
            else
            {
                ReporterFactory.LogFailure("Advance RF Test permission is set to YES");
            }
        }
        public void ValidateNeptuneFieldServiceMIULoggingOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            string defaultproperty = driver.GetElementProperty(advancedRFTestImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                driver.ClickElement(btnEdit, "Edit");
                driver.ClickElement(neptuneFieldService, "Neptune Field Service PM");
                driver.WaitForElement(miuLoggingSwitch, TimeSpan.FromSeconds(30));
                driver.ClickElement(miuLoggingSwitch, " MIU Logging");
            }
            else
            {
                ReporterFactory.LogFailure("Advance RF Test permission is set to YES");
            }
        }
        public void ValidateNeptuneFieldServicePressureOff()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            string defaultproperty = driver.GetElementProperty(mmrPressureImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                driver.ClickElement(btnEdit, "Edit");
                driver.ClickElement(neptuneFieldService, "Neptune Field Service PM");
                driver.WaitForElement(pressureSwitch, TimeSpan.FromSeconds(30));
                driver.ClickElement(pressureSwitch, "Pressure Switch");
            }
            else
            {
                ReporterFactory.LogFailure("Pressure permission is set to YES");
            }
        }


        /// <summary>
        /// Method to Validate Handheld Management
        /// </summary>
        public void ValidateHandheldManagement()
        {
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(handheldManagement, "Handheld Management");
        }
        /// <summary>
        /// Method to Validate Handheld Management Click
        /// </summary>
        public void ValidateHandheldManagementClick()
        {
            driver.sleepTime(2000);
            driver.ClickElement(handheldManagement, "Handheld Management");
            driver.CheckElementDisplayed(handhelds, "Handhelds");
            driver.CheckElementDisplayed(handheldSettings, "Handhelds Setting");
        }

        /// <summary>
        /// Method to Validate Handheld Management Default YEs
        /// </summary>
        public void ValidateHandheldManagementDefaultYes()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneCSR, "Neptune Customer Service");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handheld Management Left Navigation permission is set by default to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Handheld Management Disabled
        /// </summary>
        public void ValidateHandheldManagementDisabled()
        {
            driver.CheckElementDoesnotExists(handheldManagement, "Handheld Management");
        }

        /// <summary>
        /// Method to Validate Handheld Setting Enabled
        /// </summary>
        public void ValidateHandheldSettingEnabled()
        {
            driver.sleepTime(2000);
            driver.ClickElement(handheldManagement, "Handheld Management");
            driver.CheckElementDisplayed(handhelds, "Handhelds");
        }
        /// <summary>
        /// Method to Validate Handheld Setting Disabled
        /// </summary>
        public void ValidateHandheldSettingDisabled()
        {
            driver.sleepTime(2000);
            driver.CheckElementDoesnotExists(handheldManagement, "Handheld Management");
           
        }

        /// <summary>
        /// Method to Validate Neptune System Admin Handheld Management Yes
        /// </summary>
        public void ValidateNeptuneSysAdminHandheldManagementYes()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(neptuneSystemAdmin, "Neptune System Admin");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Neptune Field Service Default is set to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Utility Admin Handheld Lft Nav No
        /// </summary>
        public void ValidateUtilityAdminHandheldLftNavNo()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Cancel"))
            {
                testReport.Pass("Handheld Settings Left Navigation permission is set by default to No");
            }
        }
        /// <summary>
        /// Method to Validate Utility Admin Handheld Lft Nav Yes
        /// </summary>
        public void ValidateUtilityAdminHandheldLftNavYes()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(utilityAdmin, "Utility Admin");
            string defaultproperty = driver.GetElementProperty(handheldLftImg, "src").ToString();
            if (defaultproperty.Contains("Confirm"))
            {
                testReport.Pass("Handheld Management Left Navigation permission is set by default to Yes");
            }
        }

        /// <summary>
        /// Method to Validate Neptune 360 Sync No Icon
        /// </summary>
        public void ValidateNeptune360SyncNoIcon()
        {
            driver.ClickElement(handheldManagement, "Handheld Management");
            driver.CheckElementDoesnotExists(neptune360SyncLftnav, "Neptune 360 Sync");
           
        }

        /// <summary>
        /// Method to Validate Handhelds Enabled
        /// </summary>
        public void ValidateHandheldsEnabled()
        {
            driver.ClickElement(handheldManagement, "Handheld Management");
            driver.CheckElementDisplayed(handhelds, "Handhelds");
        }

        /// <summary>
        /// Method to Validate Handhelds Disabled
        /// </summary>
        public void ValidateHandheldsDisabled()
        {
            driver.ClickElement(handheldManagement, "Handheld Management");
            driver.CheckElementDoesnotExists(handhelds, "Handhelds");
        }
        /// <summary>
        /// Method to Validate Handhelds Page
        /// </summary>
        public void ValidateHandheldsPage()
        {
            driver.ClickElement(handheldManagement, "Handheld Management");
            driver.ClickElement(handhelds, "Handhelds");
            string page = driver.GetElementText(breadCrumb);
            if (page.Contains("HANDHELDS"))
            {
                testReport.Pass("Handhelds Page Displayed");
            }
            else
            {
                ReporterFactory.LogFailure(page + " is displayed");
            }
        }

        /// <summary>
        /// Method to Validate Neptune 360 Sync Disabled
        /// </summary>
        public void ValidateNeptune360SyncDisabled()
        {
            driver.ClickElement(handheldManagement, "Handheld Management");
            driver.CheckElementDoesnotExists(neptune360Sync, "Neptune 360 Sync");
        }

        public void setPermissionsforRoles(string role, string module, string submodule, string permissions)
        {
            switch (role)
            {
                case "Neptune System Administrator":
                    driver.ClickElement(By.XPath("//span[text()='Neptune System Administrator']"), "Neptunesystemadministrator");
                    break;


                    if (role.Equals("Neptune System Administrator"))
                    {
                        IWebElement ele = driver.FindElement(By.XPath("//span[text()='module']/../../..//following-sibling::div//ul//li//span[text()='submodule']/../..//img"));
                        string text = ele.GetAttribute("class");
                        if (!text.Contains(permissions))
                        {
                            driver.ClickElement(By.XPath("//button[text()='Edit']"), "editbutton");
                            ele.Click();
                            driver.ClickElement(By.XPath("//button[text()='Done']"), "Done button");
                        }
                    }
            }
        }
        public void SetPermissions(string roleName)
        {
            SelectRole(roleName);

            switch (roleName)
            {
                case "Utility Administrator":
                    //driver.ClickElement(By.XPath("//span[text()='Utility Administrator']"), "Neptunesystemadministrator");
                    //driver.ClickElement(By.XPath("//button[text()='Edit']"), "editbutton");
                    SetPermissionsForUtilityAdmin();

                    SaveChanges(roleName);
                    break;

                case "Utility Meter Reader":
                    //driver.ClickElement(By.XPath("//span[text()='Utility Meter Reader']"), "Neptunesystemadministrator");
                    //driver.ClickElement(By.XPath("//button[text()='Edit']"), "editbutton");
                    SetPermissionsForUtilityMeterReader();

                    SaveChanges(roleName);
                    break;
                case "Utility Read Only Access":
                    //driver.ClickElement(By.XPath("//span[text()='Utility Read Only Access']"), "Neptunesystemadministrator");
                    //driver.ClickElement(By.XPath("//button[text()='Edit']"), "editbutton");
                    SetPermissionsForUtilityReadOnlyAccess();

                    SaveChanges(roleName);
                    break;
                case "Utility User":
                    //driver.ClickElement(By.XPath("//span[text()='Utility User']"), "Neptunesystemadministrator");
                    //driver.ClickElement(By.XPath("//button[text()='Edit']"), "editbutton");
                    SetPermissionsForUtilityUser();

                    SaveChanges(roleName);
                    break;
                case "Neptune System Administrator":
                    //driver.ClickElement(By.XPath("//span[text()='Neptune System Administrator']"), "Neptunesystemadministrator");
                    //driver.ClickElement(By.XPath("//button[text()='Edit']"), "editbutton");
                    SetPermissionsForNeptuneSystemAdministrator();

                    SaveChanges(roleName);
                    break;
                case "Neptune Field Service PM":
                    //driver.ClickElement(By.XPath("//span[text()='Neptune Field Service PM']"), "Neptunesystemadministrator");
                    //driver.ClickElement(By.XPath("//button[text()='Edit']"), "editbutton");
                    SetPermissionsForNeptuneFieldServicePM();

                    SaveChanges(roleName);
                    break;
                case "Neptune Customer Support":
                    //driver.ClickElement(By.XPath("//span[text()='Neptune Customer Support]"), "Neptunesystemadministrator");
                    //driver.ClickElement(By.XPath("//button[text()='Edit']"), "editbutton");
                    SetPermissionsForNeptuneCustomerSupport();

                    SaveChanges(roleName);
                    break;
                case "Neptune Customer Service Rep":
                    //driver.ClickElement(By.XPath("//span[text()='Neptune Customer Service Rep']"), "Neptunesystemadministrator");
                    //driver.ClickElement(By.XPath("//button[text()='Edit']"), "editbutton");
                    SetPermissionsForNeptuneCustomerServiceRep();

                    SaveChanges(roleName);
                    break;
                case "Neptune 360 Essentials":
                    //driver.ClickElement(By.XPath("//span[text()='Neptune 360 Essentials']"), "Neptunesystemadministrator");
                    //driver.ClickElement(By.XPath("//button[text()='Edit']"), "editbutton");
                    SetPermissionsForNeptune360Essentials();

                    SaveChanges(roleName);
                    break;
               

            }

        }

        public void SelectRole(string roleName)
        {
            if (!driver.WaitForElement(lftNavRoleManagement, TimeSpan.FromSeconds(5)))
            {
                driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            }
            driver.ClickElement(lftNavRoleManagement, "Role Management");

            driver.FindElement(By.XPath("//div//span[text()='" + roleName + "']")).Click();

            driver.WaitForElementNotExists(permissionsLoader, 30);

            driver.ClickElement(btnEdit_RoleManagement, "Edit");
        }

        public void SetPermission(string permissionName, bool swithOn)
        {
            driver.ScrollToElement(driver.FindElement(By.XPath("//span[text()='" + permissionName + "']//..//kendo-switch//span")));

            IWebElement permissionEle = driver.FindElement(By.XPath("//span[text()='" + permissionName + "']//..//kendo-switch//span"));
            if (permissionEle.GetAttribute("aria-checked") == "true")
            {
                if (!swithOn)
                    permissionEle.Click();
            }
            else
            {
                if (swithOn)
                    permissionEle.Click();
            }
        }

        public void SaveChanges(string roleName)
        {
            driver.ScrollToElement(driver.FindElement(btnDone_EditPermission));
            driver.ClickElement(btnDone_EditPermission, "Done");

            driver.FindElement(By.XPath("//div//span[text()='" + roleName + "']")).Click();
            if (driver.WaitForElement(permissionsSaveAlert, TimeSpan.FromSeconds(60)))
            {
                driver.ClickElement(permissionsSaveAlertCloseBtn, "Close");
            }
            driver.WaitForElementNotExists(permissionsSaveAlert);
            Thread.Sleep(3000);
            driver.ScrollToElement(driver.FindElement(drpProfile));
        }

        public void SetPermissionsForUtilityAdmin()
        {
            try
            {
                //identity Management
                SetPermission("View Users", true);
                SetPermission("Create Users", true);
                SetPermission("Search Users", true);
                SetPermission("Edit Users", true);
                SetPermission("Deactivate Users", true);
                SetPermission("Send Password Reset", true);
                SetPermission("Users", false);
                SetPermission("User Profile", true);
                SetPermission("Users Management", true);
                // SetPermission("Multifactor Authentication", true);

                //Utility Management
                SetPermission("Create Utilities", false);
                SetPermission("Edit Utilities", false);
                SetPermission("View Utilities", true);
                SetPermission("Utilities Management", true);

                //Left Navigation
                SetPermission("Create Utilities", true);
                SetPermission("Edit Utilities", true);
                SetPermission("View Utilities", true);
                SetPermission("Utilities Management", true);
                SetPermission("Dashboard Left Navigation", true);
                SetPermission("Customer Inquiry Left Navigation", true);
                SetPermission("Data Log Left Navigation", true);
                SetPermission("Billing Services Left Navigation", true);
                SetPermission("Utility Management Left Navigation", true);
                SetPermission("Platform Management Left Navigation", false);
                SetPermission("User Management Left Navigation", false);
                SetPermission("Roles and Permissions Left Navigation", false);
                SetPermission("Notifications Left Navigation", false);
                SetPermission("Alert Configuration Left Navigation", true);
                SetPermission("Dashboard Network Health Left Navigation", false);
                SetPermission("Route Assignments Left Navigation", true);
                SetPermission("Route Management Left Navigation", true);
                SetPermission("Reports Left Navigation", true);
                SetPermission("API Deployment Left Navigation", false);
                SetPermission("Partner Management Left Navigation", false);
                SetPermission("File Mapper Left Navigation", false);
                SetPermission("Usage Plans Left Navigation", false);
                SetPermission("SDK Access Left Navigation", true);
                SetPermission("Handheld Management Left Navigation", true);
                SetPermission("Handhelds Left Navigation", true);
                SetPermission("Neptune 360 Sync Left Navigation", true);
                SetPermission("Handheld Settings Left Navigation", true);
                SetPermission("Device Activations Left Navigation", false);
                SetPermission("Groups Left Navigation", true);
                SetPermission("Settings Left Navigation", true);
                SetPermission("NSP DB Conversion Left Navigation", false);
                SetPermission("Billing Services Settings Left Navigation", true);
                SetPermission("Endpoint Management Left Navigation", false);
                SetPermission("Endpoint FOTA Left Navigation", false);
                SetPermission("MIU List Left Navigation", false);
                SetPermission("SIM Management Left Navigation", false);
                SetPermission("Geocoding Services Left Navigation", false);
                SetPermission("Configurable Communication Devices Left Navigation", false);
                SetPermission("Endpoint Commands Left Navigation", false);
                SetPermission("My Dashboard Left Navigation", false);


                //Top Navigation

                SetPermission("Home Top Navigation", true);
                SetPermission("Profile Top Navigation", true);
                SetPermission("Logout Top Navigation", true);
                SetPermission("Choose Utilities", true);


                //Code Maintenance

                SetPermission("Create Codes", true);
                SetPermission("Search Codes", true);
                SetPermission("Edit Codes", true);
                SetPermission("View Codes", true);
                SetPermission("Select and Delete Codes", true);


                //Role Management

                SetPermission("Neptune Only Option", false);
                SetPermission("Create Role", false);
                SetPermission("Edit Role", false);
                SetPermission("Toggle Permissions", true);
                SetPermission("View Role", true);
                SetPermission("Delete Role", false);
                SetPermission("Role Management", false);

                //Import Management

                SetPermission("Import", true);
                SetPermission("View Import Files", true);
                SetPermission("Import Files", true);
                SetPermission("Import Summary", true);

                //Device Management

                SetPermission("Create Collector", false);
                SetPermission("Create Gateway", false);
                SetPermission("Edit Collector", true);
                SetPermission("Edit Collector Description", true);
                SetPermission("Build USB for Collector", true);
                SetPermission("Edit Gateway", true);
                SetPermission("Edit Gateway Description", true);
                SetPermission("Build USB for Gateway", true);
                SetPermission("Show Devices", true);
                SetPermission("View Collector", true);
                SetPermission("View Gateway", true);
                SetPermission("Clone Collector", false);
                SetPermission("Clone Gateway", false);
                SetPermission("Delete Device", true);
                SetPermission("Device Management", true);

                //Export Management

                SetPermission("View Exports", true);
                SetPermission("Select One or All File for Export", true);
                SetPermission("Deselect One or All File for Export", true);
                SetPermission("ReExport", true);
                SetPermission("Export Settings", true);
                SetPermission("View Only Exported", true);
                SetPermission("Export", true);
                SetPermission("Export History", true);

                //Route Management

                SetPermission("View Route Management Dashboard", true);
                SetPermission("Edit Assignments", true);
                SetPermission("Display as Reader", true);
                SetPermission("Route Assignment Screen", true);

                //Notification Management

                SetPermission("Create Notification", false);
                SetPermission("Edit Notification", false);
                SetPermission("View Notification", false);
                SetPermission("Notification", false);

                //Landing Page

                SetPermission("Search Account", true);
                SetPermission("Dashboard Widget", true);
                SetPermission("Customer Inquiry Widget", true);
                SetPermission("Billing Service Widget", true);
                SetPermission("Notifications Widget", false);
                SetPermission("User Management Widget", true);
                SetPermission("Utility Management Widget", true);
                SetPermission("Route Management Widget", true);
                SetPermission("Reports Widget", true);
                SetPermission("Groups Widget", true);
                SetPermission("Data Log Widget", true);

                //Customer Inquiry

                SetPermission("Search and Select Account", true);
                SetPermission("Edit Asset Configuration", true);
                SetPermission("Select a Meter", true);
                SetPermission("Consumption Metrics", true);
                SetPermission("Customer Inquiry", true);
                SetPermission("Dashboard", true);
                SetPermission("Initiate Refresh Reads", true);
                SetPermission("Edit Soft Disconnect", true);
                SetPermission("View Comments", true);
                SetPermission("Create Comments", true);
                SetPermission("Edit Comments", true);
                SetPermission("Delete Others Comments", true);
                SetPermission("Delete Own Comments", true);
                SetPermission("Edit Reading", true);

                //Mobile MMR

                SetPermission("Advanced RF Test", true);
                SetPermission("MIU Logging", true);
                SetPermission("Pressure", true);
                SetPermission("Meter Reading", true);
                SetPermission("Sync Unassigned Routes", true);

                //Alert Configuration

                SetPermission("Alert Configuration Screen", true);
                SetPermission("View Alert Configurations", true);
                SetPermission("Create, Edit & Delete Alert Configurations", true);

                //Dashboard
                SetPermission("View All Network Health Dashboard Widgets", false);

                //Reporting
                SetPermission("Coded Notes Report", true);
                SetPermission("Comments Report", true);
                SetPermission("Mach 10 Battery Status", true);
                SetPermission("Invalid Readings Report", true);
                SetPermission("Reports Landing Page Access", true);
                SetPermission("Days of Consumption (AMR)", true);
                SetPermission("Days of No Flow (AMR)", true);
                SetPermission("Found Meters Report", true);
                SetPermission("AMI No Flow Report", true);
                SetPermission("Inactive Flow Report", true);
                SetPermission("High Consumption Report", true);
                SetPermission("Soft Disconnect Report", true);
                SetPermission("Endpoint Maintenance Report", true);
                SetPermission("Days of Consecutive Flow (AMI) - Flag Based", true);
                SetPermission("Endpoint Consumption Report", true);
                SetPermission("Active SIM With No Site Report", false);
                SetPermission("Active SIM Associated to Undefined Site Report", false);
                SetPermission("Days of Consecutive Flow (AMI) - Consumption Based", true);
                SetPermission("Reverse Flow Report", true);
                SetPermission("Changed Read Parameters Report", true);
                SetPermission("High Low Limit Fail Report", true);
                SetPermission("Meter Readings Report", true);
                SetPermission("Productivity Report", true);
                SetPermission("Tamper Report", true);
                SetPermission("Geocoding Summary Report", true);

                //Partner Management

                SetPermission("View Partner Management", false);
                SetPermission("Create Partners", false);
                SetPermission("Edit Partners", false);

                //Api Deployment

                SetPermission("View API Deployment", false);
                SetPermission("Create Bundles", false);
                SetPermission("Edit Bundles", false);

                //Usage Plans
                SetPermission("View Usage Plans", false);
                SetPermission("Edit  Usage Plans", false);

                //File Mapper
                ////SetPermission("File Mapper", true);


                //SDK Access

                SetPermission("View SDK Access", true);

                //HandHelds
                SetPermission("View Handhelds", true);
                SetPermission("Create Handhelds", true);
                SetPermission("Edit Handhelds", true);

                //Neptune 360 Sync

                SetPermission("View Neptune 360 Sync Screen", true);
                SetPermission("Download Neptune 360 Sync", true);

                //Handheld Settings

                SetPermission("View Handheld Settings", true);
                SetPermission("Edit Handheld Settings", true);

                //Groups

                SetPermission("View Groups", true);
                SetPermission("Create/Edit Group container", true);
                SetPermission("Manage Group Endpoints", true);
                SetPermission("Delete Groups", true);

                //Settings

                SetPermission("View Settings", true);
                SetPermission("Edit Settings", true);
                SetPermission("Meter Reading Batch File Settings", false);
                SetPermission("Lora Private Network Settings", false);

                //NSP DB Conversion

                SetPermission("View NSP DB Conversion", false);

                //Billing Services Settings

                SetPermission("View Export Rules", false);
                SetPermission("Edit Export Rules", false);
                SetPermission("View General Settings", true);
                SetPermission("Edit General Settings", false);
                SetPermission("View Import Rules", false);
                SetPermission("Edit Import Rules", false);
                SetPermission("Edit Data Translations", false);
                SetPermission("View Billing Automation", false);
                SetPermission("Edit Billing Automation", false);
                SetPermission("View FTP Credentials", false);

                //Endpoint FOTA

                SetPermission("View Endpoint FOTA", false);
                SetPermission("Send Update", false);
                SetPermission("Cancel Update", false);

                //MIU List
                SetPermission("View MIU List", false);

                //SIM Management

                SetPermission("View SIM Management", false);
                SetPermission("Edit SIM Management", false);

                //PDT Management

                SetPermission("Packet Dump Tool ", false);

                //Mobile Field Management
                SetPermission("Endpoint Manager", true);

                //Endpoint Commands

                SetPermission("View Endpoint Commands", false);
                SetPermission("Utilize Change RSV Status", false);
            }
            catch(Exception e)
            {

            }


        }
        public void SetPermissionsForUtilityMeterReader()
        {
            //identity Management
            SetPermission("View Users", false);
            SetPermission("Create Users", false);
            SetPermission("Search Users", false);
            SetPermission("Edit Users", false);
            SetPermission("Deactivate Users", false);
            SetPermission("Send Password Reset", false);
            SetPermission("Users", false);
            SetPermission("User Profile", true);
            SetPermission("Users Management", false);
            // SetPermission("Multifactor Authentication", true);

            //Utility Management
            SetPermission("Create Utilities", false);
            SetPermission("Edit Utilities", false);
            SetPermission("View Utilities", true);
            SetPermission("Utilities Management", true);

            //Left Navigation
            SetPermission("Create Utilities", true);
            SetPermission("Edit Utilities", true);
            SetPermission("View Utilities", true);
            SetPermission("Utilities Management", true);
            SetPermission("Dashboard Left Navigation", true);
            SetPermission("Customer Inquiry Left Navigation", false);
            SetPermission("Data Log Left Navigation", true);
            SetPermission("Billing Services Left Navigation", false);
            SetPermission("Utility Management Left Navigation", true);
            SetPermission("Platform Management Left Navigation", false);
            SetPermission("User Management Left Navigation", false);
            SetPermission("Roles and Permissions Left Navigation", false);
            SetPermission("Notifications Left Navigation", false);
            SetPermission("Alert Configuration Left Navigation", false);
            SetPermission("Dashboard Network Health Left Navigation", false);
            SetPermission("Route Assignments Left Navigation", false);
            SetPermission("Route Management Left Navigation", false);
            SetPermission("Reports Left Navigation", true);
            SetPermission("API Deployment Left Navigation", false);
            SetPermission("Partner Management Left Navigation", false);
            SetPermission("File Mapper Left Navigation", false);
            SetPermission("Usage Plans Left Navigation", false);
            SetPermission("SDK Access Left Navigation", false);
            SetPermission("Handheld Management Left Navigation", true);
            SetPermission("Handhelds Left Navigation", true);
            SetPermission("Neptune 360 Sync Left Navigation", false);
            SetPermission("Handheld Settings Left Navigation", false);
            SetPermission("Device Activations Left Navigation", false);
            SetPermission("Groups Left Navigation", false);
            SetPermission("Settings Left Navigation", true);
            SetPermission("NSP DB Conversion Left Navigation", false);
            SetPermission("Billing Services Settings Left Navigation", true);
            SetPermission("Endpoint Management Left Navigation", false);
            SetPermission("Endpoint FOTA Left Navigation", false);
            SetPermission("MIU List Left Navigation", false);
            SetPermission("SIM Management Left Navigation", false);
            SetPermission("Geocoding Services Left Navigation", false);
            SetPermission("Configurable Communication Devices Left Navigation", false);
            SetPermission("Endpoint Commands Left Navigation", false);
            SetPermission("My Dashboard Left Navigation", false);


            //Top Navigation

            SetPermission("Home Top Navigation", true);
            SetPermission("Profile Top Navigation", true);
            SetPermission("Logout Top Navigation", true);
            SetPermission("Choose Utilities", false);


            //Code Maintenance

            SetPermission("Create Codes", false);
            SetPermission("Search Codes", true);
            SetPermission("Edit Codes", false);
            SetPermission("View Codes", true);
            SetPermission("Select and Delete Codes", false);


            //Role Management

            SetPermission("Neptune Only Option", false);
            SetPermission("Create Role", false);
            SetPermission("Edit Role", false);
            SetPermission("Toggle Permissions", false);
            SetPermission("View Role", false);
            SetPermission("Delete Role", false);
            SetPermission("Role Management", false);

            //Import Management

            SetPermission("Import", false);
            SetPermission("View Import Files", false);
            SetPermission("Import Files", false);
            SetPermission("Import Summary", false);

            //Device Management

            SetPermission("Create Collector", false);
            SetPermission("Create Gateway", false);
            SetPermission("Edit Collector", false);
            SetPermission("Edit Collector Description", false);
            SetPermission("Build USB for Collector", false);
            SetPermission("Edit Gateway", false);
            SetPermission("Edit Gateway Description", false);
            SetPermission("Build USB for Gateway", false);
            SetPermission("Show Devices", false);
            SetPermission("View Collector", false);
            SetPermission("View Gateway", false);
            SetPermission("Clone Collector", false);
            SetPermission("Clone Gateway", false);
            SetPermission("Delete Device", false);
            SetPermission("Device Management", true);

            //Export Management

            SetPermission("View Exports", false);
            SetPermission("Select One or All File for Export", false);
            SetPermission("Deselect One or All File for Export", false);
            SetPermission("ReExport", false);
            SetPermission("Export Settings", false);
            SetPermission("View Only Exported", false);
            SetPermission("Export", false);
            SetPermission("Export History", false);

            //Route Management

            SetPermission("View Route Management Dashboard", false);
            SetPermission("Edit Assignments", false);
            SetPermission("Display as Reader", true);
            SetPermission("Route Assignment Screen", true);

            //Notification Management

            SetPermission("Create Notification", false);
            SetPermission("Edit Notification", false);
            SetPermission("View Notification", false);
            SetPermission("Notification", false);

            //Landing Page

            SetPermission("Search Account", false);
            SetPermission("Dashboard Widget", true);
            SetPermission("Customer Inquiry Widget", false);
            SetPermission("Billing Service Widget", false);
            SetPermission("Notifications Widget", false);
            SetPermission("User Management Widget", false);
            SetPermission("Utility Management Widget", true);
            SetPermission("Route Management Widget", false);
            SetPermission("Reports Widget", true);
            SetPermission("Groups Widget", true);
            SetPermission("Data Log Widget", true);

            //Customer Inquiry

            SetPermission("Search and Select Account", false);
            SetPermission("Edit Asset Configuration", false);
            SetPermission("Select a Meter", false);
            SetPermission("Consumption Metrics", false);
            SetPermission("Customer Inquiry", true);
            SetPermission("Dashboard", false);
            SetPermission("Initiate Refresh Reads", false);
            SetPermission("Edit Soft Disconnect", false);
            SetPermission("View Comments", false);
            SetPermission("Create Comments", false);
            SetPermission("Edit Comments", false);
            SetPermission("Delete Others Comments", false);
            SetPermission("Delete Own Comments", false);
            SetPermission("Edit Reading", false);

            //Mobile MMR

            SetPermission("Advanced RF Test", true);
            SetPermission("MIU Logging", true);
            SetPermission("Pressure", true);
            SetPermission("Meter Reading", true);
            SetPermission("Sync Unassigned Routes", true);

            //Alert Configuration

            SetPermission("Alert Configuration Screen", false);
            SetPermission("View Alert Configurations", false);
            SetPermission("Create, Edit & Delete Alert Configurations", false);

            //Dashboard
            SetPermission("View All Network Health Dashboard Widgets", false);

            //Reporting
            SetPermission("Coded Notes Report", true);
            SetPermission("Comments Report", true);
            SetPermission("Mach 10 Battery Status", false);
            SetPermission("Invalid Readings Report", false);
            SetPermission("Reports Landing Page Access", true);
            SetPermission("Days of Consumption (AMR)", false);
            SetPermission("Days of No Flow (AMR)", false);
            SetPermission("Found Meters Report", true);
            SetPermission("AMI No Flow Report", true);
            SetPermission("Inactive Flow Report", true);
            SetPermission("High Consumption Report", true);
            SetPermission("Soft Disconnect Report", true);
            SetPermission("Endpoint Maintenance Report", true);
            SetPermission("Days of Consecutive Flow (AMI) - Flag Based", true);
            SetPermission("Endpoint Consumption Report", true);
            SetPermission("Active SIM With No Site Report", false);
            SetPermission("Active SIM Associated to Undefined Site Report", false);
            SetPermission("Days of Consecutive Flow (AMI) - Consumption Based", true);
            SetPermission("Reverse Flow Report", true);
            SetPermission("Changed Read Parameters Report", true);
            SetPermission("High Low Limit Fail Report", true);
            SetPermission("Meter Readings Report", true);
            SetPermission("Productivity Report", true);
            SetPermission("Tamper Report", true);
            SetPermission("Geocoding Summary Report", true);

            //Partner Management

            SetPermission("View Partner Management", false);
            SetPermission("Create Partners", false);
            SetPermission("Edit Partners", false);

            //Api Deployment

            SetPermission("View API Deployment", false);
            SetPermission("Create Bundles", false);
            SetPermission("Edit Bundles", false);

            //Usage Plans
            SetPermission("View Usage Plans", false);
            SetPermission("Edit  Usage Plans", false);

            //File Mapper
            //SetPermission("File Mapper", false);
            

            //SDK Access

            SetPermission("View SDK Access", false);

            //HandHelds
            SetPermission("View Handhelds", true);
            SetPermission("Create Handhelds", false);
            SetPermission("Edit Handhelds", false);

            //Neptune 360 Sync

            SetPermission("View Neptune 360 Sync Screen", false);
            SetPermission("Download Neptune 360 Sync", false);

            //Handheld Settings

            SetPermission("View Handheld Settings", false);
            SetPermission("Edit Handheld Settings", false);

            //Groups

            SetPermission("View Groups", true);
            SetPermission("Create/Edit Group container", false);
            SetPermission("Manage Group Endpoints", false);
            SetPermission("Delete Groups", false);

            //Settings

            SetPermission("View Settings", true);
            SetPermission("Edit Settings", false);
            SetPermission("Meter Reading Batch File Settings", false);
            SetPermission("Lora Private Network Settings", false);

            //NSP DB Conversion

            SetPermission("View NSP DB Conversion", false);

            //Billing Services Settings

            SetPermission("View Export Rules", false);
            SetPermission("Edit Export Rules", false);
            SetPermission("View General Settings", true);
            SetPermission("Edit General Settings", false);
            SetPermission("View Import Rules", false);
            SetPermission("Edit Import Rules", false);
            SetPermission("Edit Data Translations", false);
            SetPermission("View Billing Automation", false);
            SetPermission("Edit Billing Automation", false);
            SetPermission("View FTP Credentials", false);

            //Endpoint FOTA

            SetPermission("View Endpoint FOTA", false);
            SetPermission("Send Update", false);
            SetPermission("Cancel Update", false);

            //MIU List
            SetPermission("View MIU List", false);

            //SIM Management

            SetPermission("View SIM Management", false);
            SetPermission("Edit SIM Management", false);

            //PDT Management

            SetPermission("Packet Dump Tool ", false);

            //Mobile Field Management
            SetPermission("Endpoint Manager", true);

            //Endpoint Commands

            SetPermission("View Endpoint Commands", false);
            SetPermission("Utilize Change RSV Status", false);

        }

        public void SetPermissionsForUtilityUser()
        {
            //identity Management
            SetPermission("View Users", true);
            SetPermission("Create Users", false);
            SetPermission("Search Users", true);
            SetPermission("Edit Users", false);
            SetPermission("Deactivate Users", true);
            SetPermission("Send Password Reset", true);
            SetPermission("Users", false);
            SetPermission("User Profile", true);
            SetPermission("Users Management", true);
            // SetPermission("Multifactor Authentication", true);

            //Utility Management
            SetPermission("Create Utilities", false);
            SetPermission("Edit Utilities", false);
            SetPermission("View Utilities", true);
            SetPermission("Utilities Management", true);

            //Left Navigation
            SetPermission("Create Utilities", true);
            SetPermission("Edit Utilities", true);
            SetPermission("View Utilities", true);
            SetPermission("Utilities Management", true);
            SetPermission("Dashboard Left Navigation", true);
            SetPermission("Customer Inquiry Left Navigation", true);
            SetPermission("Data Log Left Navigation", true);
            SetPermission("Billing Services Left Navigation", true);
            SetPermission("Utility Management Left Navigation", true);
            SetPermission("Platform Management Left Navigation", false);
            SetPermission("User Management Left Navigation", false);
            SetPermission("Roles and Permissions Left Navigation", false);
            SetPermission("Notifications Left Navigation", false);
            SetPermission("Alert Configuration Left Navigation", false);
            SetPermission("Dashboard Network Health Left Navigation", false);
            SetPermission("Route Assignments Left Navigation", false);
            SetPermission("Route Management Left Navigation", false);
            SetPermission("Reports Left Navigation", true);
            SetPermission("API Deployment Left Navigation", false);
            SetPermission("Partner Management Left Navigation", false);
            SetPermission("File Mapper Left Navigation", false);
            SetPermission("Usage Plans Left Navigation", false);
            SetPermission("SDK Access Left Navigation", false);
            SetPermission("Handheld Management Left Navigation", true);
            SetPermission("Handhelds Left Navigation", true);
            SetPermission("Neptune 360 Sync Left Navigation", false);
            SetPermission("Handheld Settings Left Navigation", false);
            SetPermission("Device Activations Left Navigation", false);
            SetPermission("Groups Left Navigation", false);
            SetPermission("Settings Left Navigation", true);
            SetPermission("NSP DB Conversion Left Navigation", false);
            SetPermission("Billing Services Settings Left Navigation", true);
            SetPermission("Endpoint Management Left Navigation", false);
            SetPermission("Endpoint FOTA Left Navigation", false);
            SetPermission("MIU List Left Navigation", false);
            SetPermission("SIM Management Left Navigation", false);
            SetPermission("Geocoding Services Left Navigation", false);
            SetPermission("Configurable Communication Devices Left Navigation", false);
            SetPermission("Endpoint Commands Left Navigation", false);
            SetPermission("My Dashboard Left Navigation", false);


            //Top Navigation

            SetPermission("Home Top Navigation", true);
            SetPermission("Profile Top Navigation", true);
            SetPermission("Logout Top Navigation", true);
            SetPermission("Choose Utilities", true);


            //Code Maintenance

            SetPermission("Create Codes", true);
            SetPermission("Search Codes", true);
            SetPermission("Edit Codes", true);
            SetPermission("View Codes", true);
            SetPermission("Select and Delete Codes", true);


            //Role Management

            SetPermission("Neptune Only Option", false);
            SetPermission("Create Role", false);
            SetPermission("Edit Role", false);
            SetPermission("Toggle Permissions", false);
            SetPermission("View Role", false);
            SetPermission("Delete Role", false);
            SetPermission("Role Management", false);

            //Import Management

            SetPermission("Import", true);
            SetPermission("View Import Files", true);
            SetPermission("Import Files", true);
            SetPermission("Import Summary", true);

            //Device Management

            SetPermission("Create Collector", false);
            SetPermission("Create Gateway", false);
            SetPermission("Edit Collector", true);
            SetPermission("Edit Collector Description", false);
            SetPermission("Build USB for Collector", true);
            SetPermission("Edit Gateway", true);
            SetPermission("Edit Gateway Description", false);
            SetPermission("Build USB for Gateway", true);
            SetPermission("Show Devices", true);
            SetPermission("View Collector", true);
            SetPermission("View Gateway", true);
            SetPermission("Clone Collector", false);
            SetPermission("Clone Gateway", false);
            SetPermission("Delete Device", true);
            SetPermission("Device Management", true);

            //Export Management

            SetPermission("View Exports", true);
            SetPermission("Select One or All File for Export", true);
            SetPermission("Deselect One or All File for Export", true);
            SetPermission("ReExport", true);
            SetPermission("Export Settings", true);
            SetPermission("View Only Exported", true);
            SetPermission("Export", true);
            SetPermission("Export History", true);

            //Route Management

            SetPermission("View Route Management Dashboard", false);
            SetPermission("Edit Assignments", false);
            SetPermission("Display as Reader", true);
            SetPermission("Route Assignment Screen", false);

            //Notification Management

            SetPermission("Create Notification", false);
            SetPermission("Edit Notification", false);
            SetPermission("View Notification", false);
            SetPermission("Notification", false);

            //Landing Page

            SetPermission("Search Account", true);
            SetPermission("Dashboard Widget", true);
            SetPermission("Customer Inquiry Widget", true);
            SetPermission("Billing Service Widget", true);
            SetPermission("Notifications Widget", false);
            SetPermission("User Management Widget", true);
            SetPermission("Utility Management Widget", true);
            SetPermission("Route Management Widget", false);
            SetPermission("Reports Widget", true);
            SetPermission("Groups Widget", true);
            SetPermission("Data Log Widget", true);

            //Customer Inquiry

            SetPermission("Search and Select Account", true);
            SetPermission("Edit Asset Configuration", true);
            SetPermission("Select a Meter", true);
            SetPermission("Consumption Metrics", true);
            SetPermission("Customer Inquiry", true);
            SetPermission("Dashboard", true);
            SetPermission("Initiate Refresh Reads", true);
            SetPermission("Edit Soft Disconnect", true);
            SetPermission("View Comments", true);
            SetPermission("Create Comments", true);
            SetPermission("Edit Comments", true);
            SetPermission("Delete Others Comments", false);
            SetPermission("Delete Own Comments", true);
            SetPermission("Edit Reading", false);

            //Mobile MMR

            SetPermission("Advanced RF Test", true);
            SetPermission("MIU Logging", true);
            SetPermission("Pressure", true);
            SetPermission("Meter Reading", true);
            SetPermission("Sync Unassigned Routes", true);

            //Alert Configuration

            SetPermission("Alert Configuration Screen", false);
            SetPermission("View Alert Configurations", false);
            SetPermission("Create, Edit & Delete Alert Configurations", false);

            //Dashboard
            SetPermission("View All Network Health Dashboard Widgets", false);

            //Reporting
            SetPermission("Coded Notes Report", true);
            SetPermission("Comments Report", true);
            SetPermission("Mach 10 Battery Status", true);
            SetPermission("Invalid Readings Report", true);
            SetPermission("Reports Landing Page Access", true);
            SetPermission("Days of Consumption (AMR)", true);
            SetPermission("Days of No Flow (AMR)", true);
            SetPermission("Found Meters Report", true);
            SetPermission("AMI No Flow Report", true);
            SetPermission("Inactive Flow Report", true);
            SetPermission("High Consumption Report", true);
            SetPermission("Soft Disconnect Report", true);
            SetPermission("Endpoint Maintenance Report", true);
            SetPermission("Days of Consecutive Flow (AMI) - Flag Based", true);
            SetPermission("Endpoint Consumption Report", true);
            SetPermission("Active SIM With No Site Report", false);
            SetPermission("Active SIM Associated to Undefined Site Report", false);
            SetPermission("Days of Consecutive Flow (AMI) - Consumption Based", true);
            SetPermission("Reverse Flow Report", true);
            SetPermission("Changed Read Parameters Report", true);
            SetPermission("High Low Limit Fail Report", true);
            SetPermission("Meter Readings Report", true);
            SetPermission("Productivity Report", true);
            SetPermission("Tamper Report", true);
            SetPermission("Geocoding Summary Report", true);

            //Partner Management

            SetPermission("View Partner Management", false);
            SetPermission("Create Partners", false);
            SetPermission("Edit Partners", false);

            //Api Deployment

            SetPermission("View API Deployment", false);
            SetPermission("Create Bundles", false);
            SetPermission("Edit Bundles", false);

            //Usage Plans
            SetPermission("View Usage Plans", false);
            SetPermission("Edit  Usage Plans", false);

            //File Mapper
            //SetPermission("File Mapper", true);
            

            //SDK Access

            SetPermission("View SDK Access", false);

            //HandHelds
            SetPermission("View Handhelds", true);
            SetPermission("Create Handhelds", false);
            SetPermission("Edit Handhelds", false);

            //Neptune 360 Sync

            SetPermission("View Neptune 360 Sync Screen", false);
            SetPermission("Download Neptune 360 Sync", false);

            //Handheld Settings

            SetPermission("View Handheld Settings", true);
            SetPermission("Edit Handheld Settings", false);

            //Groups

            SetPermission("View Groups", true);
            SetPermission("Create/Edit Group container", false);
            SetPermission("Manage Group Endpoints", false);
            SetPermission("Delete Groups", false);

            //Settings

            SetPermission("View Settings", true);
            SetPermission("Edit Settings", true);
            SetPermission("Meter Reading Batch File Settings", false);
            SetPermission("Lora Private Network Settings", false);

            //NSP DB Conversion

            SetPermission("View NSP DB Conversion", false);

            //Billing Services Settings

            SetPermission("View Export Rules", false);
            SetPermission("Edit Export Rules", false);
            SetPermission("View General Settings", true);
            SetPermission("Edit General Settings", false);
            SetPermission("View Import Rules", false);
            SetPermission("Edit Import Rules", false);
            SetPermission("Edit Data Translations", false);
            SetPermission("View Billing Automation", false);
            SetPermission("Edit Billing Automation", false);
            SetPermission("View FTP Credentials", false);

            //Endpoint FOTA

            SetPermission("View Endpoint FOTA", false);
            SetPermission("Send Update", false);
            SetPermission("Cancel Update", false);

            //MIU List
            SetPermission("View MIU List", false);

            //SIM Management

            SetPermission("View SIM Management", false);
            SetPermission("Edit SIM Management", false);

            //PDT Management

            SetPermission("Packet Dump Tool ", false);

            //Mobile Field Management
            SetPermission("Endpoint Manager", true);

            //Endpoint Commands

            SetPermission("View Endpoint Commands", false);
            SetPermission("Utilize Change RSV Status", false);

        }
               
        public void SetPermissionsForNeptuneCustomerSupport()
        {
            //identity Management
            SetPermission("View Users", true);
            SetPermission("Create Users", true);
            SetPermission("Search Users", true);
            SetPermission("Edit Users", true);
            SetPermission("Deactivate Users", false);
            SetPermission("Send Password Reset", true);
            SetPermission("Users", true);
            SetPermission("User Profile", true);
            SetPermission("Users Management", true);
            // SetPermission("Multifactor Authentication", true);

            //Utility Management
            SetPermission("Create Utilities", false);
            SetPermission("Edit Utilities", false);
            SetPermission("View Utilities", true);
            SetPermission("Utilities Management", true);

            //Left Navigation
            SetPermission("Create Utilities", true);
            SetPermission("Edit Utilities", true);
            SetPermission("View Utilities", true);
            SetPermission("Utilities Management", true);
            SetPermission("Dashboard Left Navigation", true);
            SetPermission("Customer Inquiry Left Navigation", true);
            SetPermission("Data Log Left Navigation", true);
            SetPermission("Billing Services Left Navigation", true);
            SetPermission("Utility Management Left Navigation", true);
            SetPermission("Platform Management Left Navigation", false);
            SetPermission("User Management Left Navigation", false);
            SetPermission("Roles and Permissions Left Navigation", false);
            SetPermission("Notifications Left Navigation", false);
            SetPermission("Alert Configuration Left Navigation", true);
            SetPermission("Dashboard Network Health Left Navigation", false);
            SetPermission("Route Assignments Left Navigation", true);
            SetPermission("Route Management Left Navigation", true);
            SetPermission("Reports Left Navigation", true);
            SetPermission("API Deployment Left Navigation", false);
            SetPermission("Partner Management Left Navigation", false);
            SetPermission("File Mapper Left Navigation", false);
            SetPermission("Usage Plans Left Navigation", false);
            SetPermission("SDK Access Left Navigation", true);
            SetPermission("Handheld Management Left Navigation", true);
            SetPermission("Handhelds Left Navigation", true);
            SetPermission("Neptune 360 Sync Left Navigation", true);
            SetPermission("Handheld Settings Left Navigation", true);
            SetPermission("Device Activations Left Navigation", false);
            SetPermission("Groups Left Navigation", true);
            SetPermission("Settings Left Navigation", true);
            SetPermission("NSP DB Conversion Left Navigation", false);
            SetPermission("Billing Services Settings Left Navigation", true);
            SetPermission("Endpoint Management Left Navigation", false);
            SetPermission("Endpoint FOTA Left Navigation", false);
            SetPermission("MIU List Left Navigation", false);
            SetPermission("SIM Management Left Navigation", false);
            SetPermission("Geocoding Services Left Navigation", false);
            SetPermission("Configurable Communication Devices Left Navigation", false);
            SetPermission("Endpoint Commands Left Navigation", false);
            SetPermission("My Dashboard Left Navigation", false);


            //Top Navigation

            SetPermission("Home Top Navigation", true);
            SetPermission("Profile Top Navigation", true);
            SetPermission("Logout Top Navigation", true);
            SetPermission("Choose Utilities", true);


            //Code Maintenance

            SetPermission("Create Codes", false);
            SetPermission("Search Codes", true);
            SetPermission("Edit Codes", false);
            SetPermission("View Codes", true);
            SetPermission("Select and Delete Codes", false);


            //Role Management

            SetPermission("Neptune Only Option", false);
            SetPermission("Create Role", false);
            SetPermission("Edit Role", false);
            SetPermission("Toggle Permissions", false);
            SetPermission("View Role", true);
            SetPermission("Delete Role", false);
            SetPermission("Role Management", true);

            //Import Management

            SetPermission("Import", true);
            SetPermission("View Import Files", true);
            SetPermission("Import Files", true);
            SetPermission("Import Summary", true);

            //Device Management

            SetPermission("Create Collector", false);
            SetPermission("Create Gateway", false);
            SetPermission("Edit Collector", false);
            SetPermission("Edit Collector Description", false);
            SetPermission("Build USB for Collector", true);
            SetPermission("Edit Gateway", false);
            SetPermission("Edit Gateway Description", false);
            SetPermission("Build USB for Gateway", true);
            SetPermission("Show Devices", true);
            SetPermission("View Collector", true);
            SetPermission("View Gateway", true);
            SetPermission("Clone Collector", false);
            SetPermission("Clone Gateway", false);
            SetPermission("Delete Device", false);
            SetPermission("Device Management", true);

            //Export Management

            SetPermission("View Exports", true);
            SetPermission("Select One or All File for Export", true);
            SetPermission("Deselect One or All File for Export", true);
            SetPermission("ReExport", true);
            SetPermission("Export Settings", true);
            SetPermission("View Only Exported", true);
            SetPermission("Export", true);
            SetPermission("Export History", true);

            //Route Management

            SetPermission("View Route Management Dashboard", false);
            SetPermission("Edit Assignments", false);
            SetPermission("Display as Reader", false);
            SetPermission("Route Assignment Screen", false);

            //Notification Management

            SetPermission("Create Notification", false);
            SetPermission("Edit Notification", false);
            SetPermission("View Notification", true);
            SetPermission("Notification", false);

            //Landing Page

            SetPermission("Search Account", true);
            SetPermission("Dashboard Widget", true);
            SetPermission("Customer Inquiry Widget", true);
            SetPermission("Billing Service Widget", true);
            SetPermission("Notifications Widget", true);
            SetPermission("User Management Widget", true);
            SetPermission("Utility Management Widget", true);
            SetPermission("Route Management Widget", true);
            SetPermission("Reports Widget", true);
            SetPermission("Groups Widget", true);
            SetPermission("Data Log Widget", true);

            //Customer Inquiry

            SetPermission("Search and Select Account", true);
            SetPermission("Edit Asset Configuration", false);
            SetPermission("Select a Meter", true);
            SetPermission("Consumption Metrics", true);
            SetPermission("Customer Inquiry", true);
            SetPermission("Dashboard", true);
            SetPermission("Initiate Refresh Reads", true);
            SetPermission("Edit Soft Disconnect", false);
            SetPermission("View Comments", true);
            SetPermission("Create Comments", false);
            SetPermission("Edit Comments", false);
            SetPermission("Delete Others Comments", false);
            SetPermission("Delete Own Comments", false);
            SetPermission("Edit Reading", false);

            //Mobile MMR

            SetPermission("Advanced RF Test", true);
            SetPermission("MIU Logging", true);
            SetPermission("Pressure", true);
            SetPermission("Meter Reading", true);
            SetPermission("Sync Unassigned Routes", true);

            //Alert Configuration

            SetPermission("Alert Configuration Screen", true);
            SetPermission("View Alert Configurations", true);
            SetPermission("Create, Edit & Delete Alert Configurations", true);

            //Dashboard
            SetPermission("View All Network Health Dashboard Widgets", false);

            //Reporting
            SetPermission("Coded Notes Report", true);
            SetPermission("Comments Report", true);
            SetPermission("Mach 10 Battery Status", true);
            SetPermission("Invalid Readings Report", true);
            SetPermission("Reports Landing Page Access", true);
            SetPermission("Days of Consumption (AMR)", true);
            SetPermission("Days of No Flow (AMR)", true);
            SetPermission("Found Meters Report", true);
            SetPermission("AMI No Flow Report", true);
            SetPermission("Inactive Flow Report", true);
            SetPermission("High Consumption Report", true);
            SetPermission("Soft Disconnect Report", true);
            SetPermission("Endpoint Maintenance Report", true);
            SetPermission("Days of Consecutive Flow (AMI) - Flag Based", true);
            SetPermission("Endpoint Consumption Report", true);
            SetPermission("Active SIM With No Site Report", false);
            SetPermission("Active SIM Associated to Undefined Site Report", false);
            SetPermission("Days of Consecutive Flow (AMI) - Consumption Based", true);
            SetPermission("Reverse Flow Report", true);
            SetPermission("Changed Read Parameters Report", true);
            SetPermission("High Low Limit Fail Report", true);
            SetPermission("Meter Readings Report", true);
            SetPermission("Productivity Report", true);
            SetPermission("Tamper Report", true);
            SetPermission("Geocoding Summary Report", true);

            //Partner Management

            SetPermission("View Partner Management", false);
            SetPermission("Create Partners", false);
            SetPermission("Edit Partners", false);

            //Api Deployment

            SetPermission("View API Deployment", false);
            SetPermission("Create Bundles", false);
            SetPermission("Edit Bundles", false);

            //Usage Plans
            SetPermission("View Usage Plans", false);
            SetPermission("Edit  Usage Plans", false);

            //File Mapper
            SetPermission("File Mapper", true);

            //SDK Access
            SetPermission("View SDK Access", true);

            //HandHelds
            SetPermission("View Handhelds", true);
            SetPermission("Create Handhelds", true);
            SetPermission("Edit Handhelds", true);

            //Neptune 360 Sync

            SetPermission("View Neptune 360 Sync Screen", true);
            SetPermission("Download Neptune 360 Sync", true);

            //Handheld Settings

            SetPermission("View Handheld Settings", true);
            SetPermission("Edit Handheld Settings", true);

            //Groups

            SetPermission("View Groups", true);
            SetPermission("Create/Edit Group container", true);
            SetPermission("Manage Group Endpoints", true);
            SetPermission("Delete Groups", true);

            //Settings

            SetPermission("View Settings", true);
            SetPermission("Edit Settings", true);
            SetPermission("Meter Reading Batch File Settings", false);
            SetPermission("Lora Private Network Settings", false);

            //NSP DB Conversion

            SetPermission("View NSP DB Conversion", false);

            //Billing Services Settings

            SetPermission("View Export Rules", true);
            SetPermission("Edit Export Rules", false);
            SetPermission("View General Settings", true);
            SetPermission("Edit General Settings", false);
            SetPermission("View Import Rules", true);
            SetPermission("Edit Import Rules", false);
            SetPermission("Edit Data Translations", false);
            SetPermission("View Billing Automation", true);
            SetPermission("Edit Billing Automation", false);
            SetPermission("View FTP Credentials", true);

            //Endpoint FOTA

            SetPermission("View Endpoint FOTA", false);
            SetPermission("Send Update", false);
            SetPermission("Cancel Update", false);

            //MIU List
            SetPermission("View MIU List", false);

            //SIM Management

            SetPermission("View SIM Management", false);
            SetPermission("Edit SIM Management", false);

            //PDT Management

            SetPermission("Packet Dump Tool ", false);

            //Mobile Field Management
            SetPermission("Endpoint Manager", true);

            //Endpoint Commands

            SetPermission("View Endpoint Commands", false);
            SetPermission("Utilize Change RSV Status", false);



        }

        public void SetPermissionsForNeptune360Essentials()
        {
            //identity Management
            SetPermission("View Users", false);
            SetPermission("Create Users", false);
            SetPermission("Search Users", false);
            SetPermission("Edit Users", false);
            SetPermission("Deactivate Users", false);
            SetPermission("Send Password Reset", false);
            SetPermission("Users", false);
            SetPermission("User Profile", true);
            SetPermission("Users Management", false);
            // SetPermission("Multifactor Authentication", true);

            //Utility Management
            SetPermission("Create Utilities", false);
            SetPermission("Edit Utilities", false);
            SetPermission("View Utilities", true);
            SetPermission("Utilities Management", true);

            //Left Navigation
            SetPermission("Create Utilities", true);
            SetPermission("Edit Utilities", true);
            SetPermission("View Utilities", true);
            SetPermission("Utilities Management", true);
            SetPermission("Dashboard Left Navigation", true);
            SetPermission("Customer Inquiry Left Navigation", false);
            SetPermission("Data Log Left Navigation", false);
            SetPermission("Billing Services Left Navigation", false);
            SetPermission("Utility Management Left Navigation", false);
            SetPermission("Platform Management Left Navigation", false);
            SetPermission("User Management Left Navigation", false);
            SetPermission("Roles and Permissions Left Navigation", false);
            SetPermission("Notifications Left Navigation", false);
            SetPermission("Alert Configuration Left Navigation", true);
            SetPermission("Dashboard Network Health Left Navigation", true);
            SetPermission("Route Assignments Left Navigation", false);
            SetPermission("Route Management Left Navigation", false);
            SetPermission("Reports Left Navigation", false);
            SetPermission("API Deployment Left Navigation", false);
            SetPermission("Partner Management Left Navigation", false);
            SetPermission("File Mapper Left Navigation", false);
            SetPermission("Usage Plans Left Navigation", false);
            SetPermission("SDK Access Left Navigation", false);
            SetPermission("Handheld Management Left Navigation", false);
            SetPermission("Handhelds Left Navigation", false);
            SetPermission("Neptune 360 Sync Left Navigation", false);
            SetPermission("Handheld Settings Left Navigation", false);
            SetPermission("Device Activations Left Navigation", false);
            SetPermission("Groups Left Navigation", false);
            SetPermission("Settings Left Navigation", true);
            SetPermission("NSP DB Conversion Left Navigation", false);
            SetPermission("Billing Services Settings Left Navigation", true);
            SetPermission("Endpoint Management Left Navigation", false);
            SetPermission("Endpoint FOTA Left Navigation", false);
            SetPermission("MIU List Left Navigation", false);
            SetPermission("SIM Management Left Navigation", false);
            SetPermission("Geocoding Services Left Navigation", false);
            SetPermission("Configurable Communication Devices Left Navigation", false);
            SetPermission("Endpoint Commands Left Navigation", false);
            SetPermission("My Dashboard Left Navigation", false);


            //Top Navigation

            SetPermission("Home Top Navigation", true);
            SetPermission("Profile Top Navigation", true);
            SetPermission("Logout Top Navigation", true);
            SetPermission("Choose Utilities", true);


            //Code Maintenance

            SetPermission("Create Codes", true);
            SetPermission("Search Codes", true);
            SetPermission("Edit Codes", true);
            SetPermission("View Codes", true);
            SetPermission("Select and Delete Codes", true);


            //Role Management

            SetPermission("Neptune Only Option", false);
            SetPermission("Create Role", false);
            SetPermission("Edit Role", false);
            SetPermission("Toggle Permissions", false);
            SetPermission("View Role", false);
            SetPermission("Delete Role", false);
            SetPermission("Role Management", false);

            //Import Management

            SetPermission("Import", true);
            SetPermission("View Import Files", true);
            SetPermission("Import Files", true);
            SetPermission("Import Summary", true);

            //Device Management

            SetPermission("Create Collector", false);
            SetPermission("Create Gateway", false);
            SetPermission("Edit Collector", false);
            SetPermission("Edit Collector Description", false);
            SetPermission("Build USB for Collector", false);
            SetPermission("Edit Gateway", false);
            SetPermission("Edit Gateway Description", false);
            SetPermission("Build USB for Gateway", false);
            SetPermission("Show Devices", true);
            SetPermission("View Collector", false);
            SetPermission("View Gateway", false);
            SetPermission("Clone Collector", false);
            SetPermission("Clone Gateway", false);
            SetPermission("Delete Device", false);
            SetPermission("Device Management", true);

            //Export Management

            SetPermission("View Exports", true);
            SetPermission("Select One or All File for Export", true);
            SetPermission("Deselect One or All File for Export", true);
            SetPermission("ReExport", true);
            SetPermission("Export Settings", true);
            SetPermission("View Only Exported", true);
            SetPermission("Export", true);
            SetPermission("Export History", true);

            //Route Management

            SetPermission("View Route Management Dashboard", false);
            SetPermission("Edit Assignments", false);
            SetPermission("Display as Reader", true);
            SetPermission("Route Assignment Screen", false);

            //Notification Management

            SetPermission("Create Notification", false);
            SetPermission("Edit Notification", false);
            SetPermission("View Notification", false);
            SetPermission("Notification", false);

            //Landing Page

            SetPermission("Search Account", true);
            SetPermission("Dashboard Widget", true);
            SetPermission("Customer Inquiry Widget", true);
            SetPermission("Billing Service Widget", true);
            SetPermission("Notifications Widget", false);
            SetPermission("User Management Widget", false);
            SetPermission("Utility Management Widget", true);
            SetPermission("Route Management Widget", false);
            SetPermission("Reports Widget", true);
            SetPermission("Groups Widget", false);
            SetPermission("Data Log Widget", true);

            //Customer Inquiry

            SetPermission("Search and Select Account", true);
            SetPermission("Edit Asset Configuration", true);
            SetPermission("Select a Meter", true);
            SetPermission("Consumption Metrics", true);
            SetPermission("Customer Inquiry", true);
            SetPermission("Dashboard", true);
            SetPermission("Initiate Refresh Reads", false);
            SetPermission("Edit Soft Disconnect", false);
            SetPermission("View Comments", false);
            SetPermission("Create Comments", false);
            SetPermission("Edit Comments", false);
            SetPermission("Delete Others Comments", false);
            SetPermission("Delete Own Comments", false);
            SetPermission("Edit Reading", false);

            //Mobile MMR

            SetPermission("Advanced RF Test", true);
            SetPermission("MIU Logging", true);
            SetPermission("Pressure", true);
            SetPermission("Meter Reading", true);
            SetPermission("Sync Unassigned Routes", true);

            //Alert Configuration

            SetPermission("Alert Configuration Screen", false);
            SetPermission("View Alert Configurations", false);
            SetPermission("Create, Edit & Delete Alert Configurations", false);

            //Dashboard
            SetPermission("View All Network Health Dashboard Widgets", false);

            //Reporting
            SetPermission("Coded Notes Report", true);
            SetPermission("Comments Report", true);
            SetPermission("Mach 10 Battery Status", true);
            SetPermission("Invalid Readings Report", true);
            SetPermission("Reports Landing Page Access", true);
            SetPermission("Days of Consumption (AMR)", true);
            SetPermission("Days of No Flow (AMR)", true);
            SetPermission("Found Meters Report", true);
            SetPermission("AMI No Flow Report", true);
            SetPermission("Inactive Flow Report", true);
            SetPermission("High Consumption Report", true);
            SetPermission("Soft Disconnect Report", false);
            SetPermission("Endpoint Maintenance Report", true);
            SetPermission("Days of Consecutive Flow (AMI) - Flag Based", true);
            SetPermission("Endpoint Consumption Report", true);
            SetPermission("Active SIM With No Site Report", false);
            SetPermission("Active SIM Associated to Undefined Site Report", false);
            SetPermission("Days of Consecutive Flow (AMI) - Consumption Based", true);
            SetPermission("Reverse Flow Report", true);
            SetPermission("Changed Read Parameters Report", true);
            SetPermission("High Low Limit Fail Report", true);
            SetPermission("Meter Readings Report", true);
            SetPermission("Productivity Report", true);
            SetPermission("Tamper Report", true);
            SetPermission("Geocoding Summary Report", true);

            //Partner Management

            SetPermission("View Partner Management", false);
            SetPermission("Create Partners", false);
            SetPermission("Edit Partners", false);

            //Api Deployment

            SetPermission("View API Deployment", false);
            SetPermission("Create Bundles", false);
            SetPermission("Edit Bundles", false);

            //Usage Plans
            SetPermission("View Usage Plans", false);
            SetPermission("Edit  Usage Plans", false);

            //File Mapper
            SetPermission("File Mapper", true);            

            //SDK Access
            SetPermission("View SDK Access", false);

            //HandHelds
            SetPermission("View Handhelds", false);
            SetPermission("Create Handhelds", false);
            SetPermission("Edit Handhelds", false);

            //Neptune 360 Sync

            SetPermission("View Neptune 360 Sync Screen", false);
            SetPermission("Download Neptune 360 Sync", false);

            //Handheld Settings

            SetPermission("View Handheld Settings", false);
            SetPermission("Edit Handheld Settings", false);

            //Groups

            SetPermission("View Groups", false);
            SetPermission("Create/Edit Group container", false);
            SetPermission("Manage Group Endpoints", false);
            SetPermission("Delete Groups", false);

            //Settings

            SetPermission("View Settings", true);
            SetPermission("Edit Settings", true);
            SetPermission("Meter Reading Batch File Settings", false);
            SetPermission("Lora Private Network Settings", false);

            //NSP DB Conversion

            SetPermission("View NSP DB Conversion", false);

            //Billing Services Settings

            SetPermission("View Export Rules", false);
            SetPermission("Edit Export Rules", false);
            SetPermission("View General Settings", true);
            SetPermission("Edit General Settings", false);
            SetPermission("View Import Rules", false);
            SetPermission("Edit Import Rules", false);
            SetPermission("Edit Data Translations", false);
            SetPermission("View Billing Automation", false);
            SetPermission("Edit Billing Automation", false);
            SetPermission("View FTP Credentials", false);

            //Endpoint FOTA

            SetPermission("View Endpoint FOTA", false);
            SetPermission("Send Update", false);
            SetPermission("Cancel Update", false);

            //MIU List
            SetPermission("View MIU List", false);

            //SIM Management

            SetPermission("View SIM Management", false);
            SetPermission("Edit SIM Management", false);

            //PDT Management

            SetPermission("Packet Dump Tool ", false);

            //Mobile Field Management
            SetPermission("Endpoint Manager", false);

            //Endpoint Commands

            SetPermission("View Endpoint Commands", false);
            SetPermission("Utilize Change RSV Status", false);
        }

        public void SetPermissionsForNeptuneSystemAdministrator()
        {
            //identity Management
            SetPermission("View Users", true);
            SetPermission("Create Users", true);
            SetPermission("Search Users", true);
            SetPermission("Edit Users", true);
            SetPermission("Deactivate Users", true);
            SetPermission("Send Password Reset", true);
            SetPermission("Users", true);
            SetPermission("User Profile", true);
            SetPermission("Users Management", true);
            // SetPermission("Multifactor Authentication", true);

            //Utility Management
            SetPermission("Create Utilities", true);
            SetPermission("Edit Utilities", true);
            SetPermission("View Utilities", true);
            SetPermission("Utilities Management", true);

            //Left Navigation
            SetPermission("Create Utilities", true);
            SetPermission("Edit Utilities", true);
            SetPermission("View Utilities", true);
            SetPermission("Utilities Management", true);
            SetPermission("Dashboard Left Navigation", true);
            SetPermission("Customer Inquiry Left Navigation", true);
            SetPermission("Data Log Left Navigation", true);
            SetPermission("Billing Services Left Navigation", true);
            SetPermission("Utility Management Left Navigation", true);
            SetPermission("Platform Management Left Navigation", true);
            SetPermission("User Management Left Navigation", true);
            SetPermission("Roles and Permissions Left Navigation", true);
            SetPermission("Notifications Left Navigation", true);
            SetPermission("Alert Configuration Left Navigation", true);
            SetPermission("Dashboard Network Health Left Navigation", false);
            SetPermission("Route Assignments Left Navigation", true);
            SetPermission("Route Management Left Navigation", true);
            SetPermission("Reports Left Navigation", true);
            SetPermission("API Deployment Left Navigation", true);
            SetPermission("Partner Management Left Navigation", true);
            SetPermission("File Mapper Left Navigation", true);
            SetPermission("Usage Plans Left Navigation", true);
            SetPermission("SDK Access Left Navigation", true);
            SetPermission("Handheld Management Left Navigation", true);
            SetPermission("Handhelds Left Navigation", true);
            SetPermission("Neptune 360 Sync Left Navigation", true);
            SetPermission("Handheld Settings Left Navigation", true);
            SetPermission("Device Activations Left Navigation", true);
            SetPermission("Groups Left Navigation", true);
            SetPermission("Settings Left Navigation", true);
            SetPermission("NSP DB Conversion Left Navigation", true);
            SetPermission("Billing Services Settings Left Navigation", true);
            SetPermission("Endpoint Management Left Navigation", true);
            SetPermission("Endpoint FOTA Left Navigation", true);
            SetPermission("MIU List Left Navigation", false);
            SetPermission("SIM Management Left Navigation", true);
            SetPermission("Geocoding Services Left Navigation", true);
            SetPermission("Configurable Communication Devices Left Navigation", true);
            SetPermission("Endpoint Commands Left Navigation", true);
            SetPermission("My Dashboard Left Navigation", true);


            //Top Navigation

            SetPermission("Home Top Navigation", true);
            SetPermission("Profile Top Navigation", true);
            SetPermission("Logout Top Navigation", true);
            SetPermission("Choose Utilities", true);


            //Code Maintenance

            SetPermission("Create Codes", true);
            SetPermission("Search Codes", true);
            SetPermission("Edit Codes", true);
            SetPermission("View Codes", true);
            SetPermission("Select and Delete Codes", true);


            //Role Management

            SetPermission("Neptune Only Option", true);
            SetPermission("Create Role", true);
            SetPermission("Edit Role", true);
            SetPermission("Toggle Permissions", true);
            SetPermission("View Role", true);
            SetPermission("Delete Role", true);
            SetPermission("Role Management", true);

            //Import Management

            SetPermission("Import", true);
            SetPermission("View Import Files", true);
            SetPermission("Import Files", true);
            SetPermission("Import Summary", true);

            //Device Management

            SetPermission("Create Collector", true);
            SetPermission("Create Gateway", true);
            SetPermission("Edit Collector", true);
            SetPermission("Edit Collector Description", true);
            SetPermission("Build USB for Collector", true);
            SetPermission("Edit Gateway", true);
            SetPermission("Edit Gateway Description", true);
            SetPermission("Build USB for Gateway", true);
            SetPermission("Show Devices", true);
            SetPermission("View Collector", true);
            SetPermission("View Gateway", true);
            SetPermission("Clone Collector", true);
            SetPermission("Clone Gateway", true);
            SetPermission("Delete Device", true);
            SetPermission("Device Management", true);

            //Export Management

            SetPermission("View Exports", true);
            SetPermission("Select One or All File for Export", true);
            SetPermission("Deselect One or All File for Export", true);
            SetPermission("ReExport", true);
            SetPermission("Export Settings", true);
            SetPermission("View Only Exported", true);
            SetPermission("Export", true);
            SetPermission("Export History", true);

            //Route Management

            SetPermission("View Route Management Dashboard", true);
            SetPermission("Edit Assignments", true);
            SetPermission("Display as Reader", true);
            SetPermission("Route Assignment Screen", true);

            //Notification Management

            SetPermission("Create Notification", true);
            SetPermission("Edit Notification", true);
            SetPermission("View Notification", true);
            SetPermission("Notification", true);

            //Landing Page

            SetPermission("Search Account", true);
            SetPermission("Dashboard Widget", true);
            SetPermission("Customer Inquiry Widget", true);
            SetPermission("Billing Service Widget", true);
            SetPermission("Notifications Widget", true);
            SetPermission("User Management Widget", true);
            SetPermission("Utility Management Widget", true);
            SetPermission("Route Management Widget", true);
            SetPermission("Reports Widget", true);
            SetPermission("Groups Widget", true);
            SetPermission("Data Log Widget", true);

            //Customer Inquiry

            SetPermission("Search and Select Account", true);
            SetPermission("Edit Asset Configuration", true);
            SetPermission("Select a Meter", true);
            SetPermission("Consumption Metrics", true);
            SetPermission("Customer Inquiry", true);
            SetPermission("Dashboard", true);
            SetPermission("Initiate Refresh Reads", true);
            SetPermission("Edit Soft Disconnect", true);
            SetPermission("View Comments", true);
            SetPermission("Create Comments", true);
            SetPermission("Edit Comments", true);
            SetPermission("Delete Others Comments", true);
            SetPermission("Delete Own Comments", true);
            SetPermission("Edit Reading", true);

            //Mobile MMR

            SetPermission("Advanced RF Test", true);
            SetPermission("MIU Logging", true);
            SetPermission("Pressure", true);
            SetPermission("Meter Reading", true);
            SetPermission("Sync Unassigned Routes", true);

            //Alert Configuration

            SetPermission("Alert Configuration Screen", true);
            SetPermission("View Alert Configurations", true);
            SetPermission("Create, Edit & Delete Alert Configurations", true);

            //Dashboard
            SetPermission("View All Network Health Dashboard Widgets", false);

            //Reporting
            SetPermission("Coded Notes Report", true);
            SetPermission("Comments Report", true);
            SetPermission("Mach 10 Battery Status", true);
            SetPermission("Invalid Readings Report", true);
            SetPermission("Reports Landing Page Access", true);
            SetPermission("Days of Consumption (AMR)", true);
            SetPermission("Days of No Flow (AMR)", true);
            SetPermission("Found Meters Report", true);
            SetPermission("AMI No Flow Report", true);
            SetPermission("Inactive Flow Report", true);
            SetPermission("High Consumption Report", true);
            SetPermission("Soft Disconnect Report", true);
            SetPermission("Endpoint Maintenance Report", true);
            SetPermission("Days of Consecutive Flow (AMI) - Flag Based", true);
            SetPermission("Endpoint Consumption Report", true);
            SetPermission("Active SIM With No Site Report", true);
            SetPermission("Active SIM Associated to Undefined Site Report", true);
            SetPermission("Days of Consecutive Flow (AMI) - Consumption Based", true);
            SetPermission("Reverse Flow Report", true);
            SetPermission("Changed Read Parameters Report", true);
            SetPermission("High Low Limit Fail Report", true);
            SetPermission("Meter Readings Report", true);
            SetPermission("Productivity Report", true);
            SetPermission("Tamper Report", true);
            SetPermission("Geocoding Summary Report", true);

            //Partner Management

            SetPermission("View Partner Management", true);
            SetPermission("Create Partners", true);
            SetPermission("Edit Partners", true);

            //Api Deployment

            SetPermission("View API Deployment", true);
            SetPermission("Create Bundles", true);
            SetPermission("Edit Bundles", true);

            //Usage Plans
            SetPermission("View Usage Plans", true);
            SetPermission("Edit  Usage Plans", true);

            //File Mapper
            SetPermission("File Mapper", true);
            //SetPermission("", true);

            //SDK Access

            SetPermission("View SDK Access", true);

            //HandHelds
            SetPermission("View Handhelds", true);
            SetPermission("Create Handhelds", true);
            SetPermission("Edit Handhelds", true);

            //Neptune 360 Sync

            SetPermission("View Neptune 360 Sync Screen", true);
            SetPermission("Download Neptune 360 Sync", true);

            //Handheld Settings

            SetPermission("View Handheld Settings", true);
            SetPermission("Edit Handheld Settings", true);

            //Groups

            SetPermission("View Groups", true);
            SetPermission("Create/Edit Group container", true);
            SetPermission("Manage Group Endpoints", true);
            SetPermission("Delete Groups", true);

            //Settings

            SetPermission("View Settings", true);
            SetPermission("Edit Settings", true);
            SetPermission("Meter Reading Batch File Settings", true);
            SetPermission("Lora Private Network Settings", true);

            //NSP DB Conversion

            SetPermission("View NSP DB Conversion", true);

            //Billing Services Settings

            SetPermission("View Export Rules", true);
            SetPermission("Edit Export Rules", true);
            SetPermission("View General Settings", true);
            SetPermission("Edit General Settings", true);
            SetPermission("View Import Rules", true);
            SetPermission("Edit Import Rules", true);
            SetPermission("Edit Data Translations", true);
            SetPermission("View Billing Automation", true);
            SetPermission("Edit Billing Automation", true);
            SetPermission("View FTP Credentials", true);

            //Endpoint FOTA

            SetPermission("View Endpoint FOTA", true);
            SetPermission("Send Update", true);
            SetPermission("Cancel Update", true);

            //MIU List
            SetPermission("View MIU List", false);

            //SIM Management

            SetPermission("View SIM Management", true);
            SetPermission("Edit SIM Management", true);

            //PDT Management

            SetPermission("Packet Dump Tool ", true);

            //Mobile Field Management
            SetPermission("Endpoint Manager", true);

            //Endpoint Commands

            SetPermission("View Endpoint Commands", true);
            SetPermission("Utilize Change RSV Status", true);

        }
        public void SetPermissionsForNeptuneCustomerServiceRep()
        {
            //identity Management
            SetPermission("View Users", true);
            SetPermission("Create Users", false);
            SetPermission("Search Users", true);
            SetPermission("Edit Users", false);
            SetPermission("Deactivate Users", false);
            SetPermission("Send Password Reset", false);
            SetPermission("Users", false);
            SetPermission("User Profile", true);
            SetPermission("Users Management", true);
            // SetPermission("Multifactor Authentication", true);

            //Utility Management
            SetPermission("Create Utilities", false);
            SetPermission("Edit Utilities", false);
            SetPermission("View Utilities", true);
            SetPermission("Utilities Management", true);

            //Left Navigation
            SetPermission("Create Utilities", true);
            SetPermission("Edit Utilities", true);
            SetPermission("View Utilities", true);
            SetPermission("Utilities Management", true);
            SetPermission("Dashboard Left Navigation", true);
            SetPermission("Customer Inquiry Left Navigation", true);
            SetPermission("Data Log Left Navigation", true);
            SetPermission("Billing Services Left Navigation", true);
            SetPermission("Utility Management Left Navigation", true);
            SetPermission("Platform Management Left Navigation", false);
            SetPermission("User Management Left Navigation", false);
            SetPermission("Roles and Permissions Left Navigation", false);
            SetPermission("Notifications Left Navigation", true);
            SetPermission("Alert Configuration Left Navigation", false);
            SetPermission("Dashboard Network Health Left Navigation", false);
            SetPermission("Route Assignments Left Navigation", true);
            SetPermission("Route Management Left Navigation", true);
            SetPermission("Reports Left Navigation", true);
            SetPermission("API Deployment Left Navigation", false);
            SetPermission("Partner Management Left Navigation", false);
            SetPermission("File Mapper Left Navigation", false);
            SetPermission("Usage Plans Left Navigation", false);
            SetPermission("SDK Access Left Navigation", true);
            SetPermission("Handheld Management Left Navigation", true);
            SetPermission("Handhelds Left Navigation", true);
            SetPermission("Neptune 360 Sync Left Navigation", true);
            SetPermission("Handheld Settings Left Navigation", true);
            SetPermission("Device Activations Left Navigation", false);
            SetPermission("Groups Left Navigation", true);
            SetPermission("Settings Left Navigation", true);
            SetPermission("NSP DB Conversion Left Navigation", false);
            SetPermission("Billing Services Settings Left Navigation", true);
            SetPermission("Endpoint Management Left Navigation", false);
            SetPermission("Endpoint FOTA Left Navigation", false);
            SetPermission("MIU List Left Navigation", false);
            SetPermission("SIM Management Left Navigation", false);
            SetPermission("Geocoding Services Left Navigation", true);
            SetPermission("Configurable Communication Devices Left Navigation", false);
            SetPermission("Endpoint Commands Left Navigation", false);
            SetPermission("My Dashboard Left Navigation", true);


            //Top Navigation

            SetPermission("Home Top Navigation", true);
            SetPermission("Profile Top Navigation", true);
            SetPermission("Logout Top Navigation", true);
            SetPermission("Choose Utilities", true);


            //Code Maintenance

            SetPermission("Create Codes", false);
            SetPermission("Search Codes", true);
            SetPermission("Edit Codes", false);
            SetPermission("View Codes", true);
            SetPermission("Select and Delete Codes", false);


            //Role Management

            SetPermission("Neptune Only Option", false);
            SetPermission("Create Role", false);
            SetPermission("Edit Role", false);
            SetPermission("Toggle Permissions", true);
            SetPermission("View Role", false);
            SetPermission("Delete Role", false);
            SetPermission("Role Management", false);

            //Import Management

            SetPermission("Import", false);
            SetPermission("View Import Files", true);
            SetPermission("Import Files", true);
            SetPermission("Import Summary", true);

            //Device Management

            SetPermission("Create Collector", false);
            SetPermission("Create Gateway", false);
            SetPermission("Edit Collector", false);
            SetPermission("Edit Collector Description", false);
            SetPermission("Build USB for Collector", false);
            SetPermission("Edit Gateway", false);
            SetPermission("Edit Gateway Description", false);
            SetPermission("Build USB for Gateway", false);
            SetPermission("Show Devices", true);
            SetPermission("View Collector", true);
            SetPermission("View Gateway", true);
            SetPermission("Clone Collector", false);
            SetPermission("Clone Gateway", false);
            SetPermission("Delete Device", false);
            SetPermission("Device Management", true);

            //Export Management

            SetPermission("View Exports", true);
            SetPermission("Select One or All File for Export", false);
            SetPermission("Deselect One or All File for Export", false);
            SetPermission("ReExport", false);
            SetPermission("Export Settings", false);
            SetPermission("View Only Exported", true);
            SetPermission("Export", true);
            SetPermission("Export History", true);

            //Route Management

            SetPermission("View Route Management Dashboard", false);
            SetPermission("Edit Assignments", false);
            SetPermission("Display as Reader", false);
            SetPermission("Route Assignment Screen", false);

            //Notification Management

            SetPermission("Create Notification", false);
            SetPermission("Edit Notification", false);
            SetPermission("View Notification", true);
            SetPermission("Notification", true);

            //Landing Page

            SetPermission("Search Account", true);
            SetPermission("Dashboard Widget", true);
            SetPermission("Customer Inquiry Widget", true);
            SetPermission("Billing Service Widget", true);
            SetPermission("Notifications Widget", true);
            SetPermission("User Management Widget", true);
            SetPermission("Utility Management Widget", true);
            SetPermission("Route Management Widget", true);
            SetPermission("Reports Widget", true);
            SetPermission("Groups Widget", true);
            SetPermission("Data Log Widget", true);

            //Customer Inquiry

            SetPermission("Search and Select Account", true);
            SetPermission("Edit Asset Configuration", true);
            SetPermission("Select a Meter", true);
            SetPermission("Consumption Metrics", true);
            SetPermission("Customer Inquiry", true);
            SetPermission("Dashboard", true);
            SetPermission("Initiate Refresh Reads", true);
            SetPermission("Edit Soft Disconnect", true);
            SetPermission("View Comments", true);
            SetPermission("Create Comments", true);
            SetPermission("Edit Comments", true);
            SetPermission("Delete Others Comments", false);
            SetPermission("Delete Own Comments", false);
            SetPermission("Edit Reading", false);

            //Mobile MMR

            SetPermission("Advanced RF Test", true);
            SetPermission("MIU Logging", true);
            SetPermission("Pressure", true);
            SetPermission("Meter Reading", true);
            SetPermission("Sync Unassigned Routes", true);

            //Alert Configuration

            SetPermission("Alert Configuration Screen", true);
            SetPermission("View Alert Configurations", true);
            SetPermission("Create, Edit & Delete Alert Configurations", true);

            //Dashboard
            SetPermission("View All Network Health Dashboard Widgets", false);

            //Reporting
            SetPermission("Coded Notes Report", true);
            SetPermission("Comments Report", true);
            SetPermission("Mach 10 Battery Status", true);
            SetPermission("Invalid Readings Report", true);
            SetPermission("Reports Landing Page Access", true);
            SetPermission("Days of Consumption (AMR)", true);
            SetPermission("Days of No Flow (AMR)", true);
            SetPermission("Found Meters Report", true);
            SetPermission("AMI No Flow Report", true);
            SetPermission("Inactive Flow Report", true);
            SetPermission("High Consumption Report", true);
            SetPermission("Soft Disconnect Report", true);
            SetPermission("Endpoint Maintenance Report", true);
            SetPermission("Days of Consecutive Flow (AMI) - Flag Based", true);
            SetPermission("Endpoint Consumption Report", true);
            SetPermission("Active SIM With No Site Report", false);
            SetPermission("Active SIM Associated to Undefined Site Report", false);
            SetPermission("Days of Consecutive Flow (AMI) - Consumption Based", true);
            SetPermission("Reverse Flow Report", true);
            SetPermission("Changed Read Parameters Report", true);
            SetPermission("High Low Limit Fail Report", true);
            SetPermission("Meter Readings Report", true);
            SetPermission("Productivity Report", true);
            SetPermission("Tamper Report", true);
            SetPermission("Geocoding Summary Report", true);

            //Partner Management

            SetPermission("View Partner Management", false);
            SetPermission("Create Partners", false);
            SetPermission("Edit Partners", false);

            //Api Deployment

            SetPermission("View API Deployment", false);
            SetPermission("Create Bundles", false);
            SetPermission("Edit Bundles", false);

            //Usage Plans
            SetPermission("View Usage Plans", false);
            SetPermission("Edit  Usage Plans", false);

            //File Mapper
            SetPermission("File Mapper", false);
            

            //SDK Access

            SetPermission("View SDK Access", true);

            //HandHelds
            SetPermission("View Handhelds", true);
            SetPermission("Create Handhelds", true);
            SetPermission("Edit Handhelds", true);

            //Neptune 360 Sync

            SetPermission("View Neptune 360 Sync Screen", true);
            SetPermission("Download Neptune 360 Sync", true);

            //Handheld Settings

            SetPermission("View Handheld Settings", true);
            SetPermission("Edit Handheld Settings", true);

            //Groups

            SetPermission("View Groups", true);
            SetPermission("Create/Edit Group container", true);
            SetPermission("Manage Group Endpoints", true);
            SetPermission("Delete Groups", true);

            //Settings

            SetPermission("View Settings", true);
            SetPermission("Edit Settings", true);
            SetPermission("Meter Reading Batch File Settings", false);
            SetPermission("Lora Private Network Settings", false);

            //NSP DB Conversion

            SetPermission("View NSP DB Conversion", false);

            //Billing Services Settings

            SetPermission("View Export Rules", true);
            SetPermission("Edit Export Rules", false);
            SetPermission("View General Settings", true);
            SetPermission("Edit General Settings", false);
            SetPermission("View Import Rules", true);
            SetPermission("Edit Import Rules", false);
            SetPermission("Edit Data Translations", false);
            SetPermission("View Billing Automation", true);
            SetPermission("Edit Billing Automation", false);
            SetPermission("View FTP Credentials", false);

            //Endpoint FOTA

            SetPermission("View Endpoint FOTA", false);
            SetPermission("Send Update", false);
            SetPermission("Cancel Update", false);

            //MIU List
            SetPermission("View MIU List", false);

            //SIM Management

            SetPermission("View SIM Management", false);
            SetPermission("Edit SIM Management", false);

            //PDT Management

            SetPermission("Packet Dump Tool ", false);

            //Mobile Field Management
            SetPermission("Endpoint Manager", true);

            //Endpoint Commands

            SetPermission("View Endpoint Commands", false);
            SetPermission("Utilize Change RSV Status", false);

        }

        public void SetPermissionsForNeptuneFieldServicePM()
        {
            //identity Management
            SetPermission("View Users", true);
            SetPermission("Create Users", true);
            SetPermission("Search Users", true);
            SetPermission("Edit Users", true);
            SetPermission("Deactivate Users", false);
            SetPermission("Send Password Reset", true);
            SetPermission("Users", true);
            SetPermission("User Profile", true);
            SetPermission("Users Management", true);
            // SetPermission("Multifactor Authentication", true);

            //Utility Management
            SetPermission("Create Utilities", false);
            SetPermission("Edit Utilities", true);
            SetPermission("View Utilities", true);
            SetPermission("Utilities Management", true);

            //Left Navigation
            SetPermission("Create Utilities", true);
            SetPermission("Edit Utilities", true);
            SetPermission("View Utilities", true);
            SetPermission("Utilities Management", true);
            SetPermission("Dashboard Left Navigation", true);
            SetPermission("Customer Inquiry Left Navigation", true);
            SetPermission("Data Log Left Navigation", true);
            SetPermission("Billing Services Left Navigation", true);
            SetPermission("Utility Management Left Navigation", true);
            SetPermission("Platform Management Left Navigation", false);
            SetPermission("User Management Left Navigation", true);
            SetPermission("Roles and Permissions Left Navigation", false);
            SetPermission("Notifications Left Navigation", false);
            SetPermission("Alert Configuration Left Navigation", true);
            SetPermission("Dashboard Network Health Left Navigation", false);
            SetPermission("Route Assignments Left Navigation", true);
            SetPermission("Route Management Left Navigation", true);
            SetPermission("Reports Left Navigation", true);
            SetPermission("API Deployment Left Navigation", false);
            SetPermission("Partner Management Left Navigation", false);
            SetPermission("File Mapper Left Navigation", false);
            SetPermission("Usage Plans Left Navigation", false);
            SetPermission("SDK Access Left Navigation", true);
            SetPermission("Handheld Management Left Navigation", true);
            SetPermission("Handhelds Left Navigation", true);
            SetPermission("Neptune 360 Sync Left Navigation", true);
            SetPermission("Handheld Settings Left Navigation", true);
            SetPermission("Device Activations Left Navigation", false);
            SetPermission("Groups Left Navigation", true);
            SetPermission("Settings Left Navigation", true);
            SetPermission("NSP DB Conversion Left Navigation", false);
            SetPermission("Billing Services Settings Left Navigation", true);
            SetPermission("Endpoint Management Left Navigation", false);
            SetPermission("Endpoint FOTA Left Navigation", false);
            SetPermission("MIU List Left Navigation", false);
            SetPermission("SIM Management Left Navigation", false);
            SetPermission("Geocoding Services Left Navigation", true);
            SetPermission("Configurable Communication Devices Left Navigation", true);
            SetPermission("Endpoint Commands Left Navigation", false);
            SetPermission("My Dashboard Left Navigation", true);


            //Top Navigation

            SetPermission("Home Top Navigation", true);
            SetPermission("Profile Top Navigation", true);
            SetPermission("Logout Top Navigation", true);
            SetPermission("Choose Utilities", true);


            //Code Maintenance

            SetPermission("Create Codes", false);
            SetPermission("Search Codes", true);
            SetPermission("Edit Codes", false);
            SetPermission("View Codes", true);
            SetPermission("Select and Delete Codes", false);


            //Role Management
            //disabled
            //SetPermission("Neptune Only Option", false);
            //SetPermission("Create Role", false);
            //SetPermission("Edit Role", false);
            //SetPermission("Toggle Permissions", false);
            //SetPermission("View Role", false);
            //SetPermission("Delete Role", false);
            //SetPermission("Role Management", false);

            //Import Management

            SetPermission("Import", true);
            SetPermission("View Import Files", true);
            SetPermission("Import Files", true);
            SetPermission("Import Summary", true);

            //Device Management

            SetPermission("Create Collector", true);
            SetPermission("Create Gateway", true);
            SetPermission("Edit Collector", true);
            SetPermission("Edit Collector Description", true);
            SetPermission("Build USB for Collector", true);
            SetPermission("Edit Gateway", true);
            SetPermission("Edit Gateway Description", true);
            SetPermission("Build USB for Gateway", true);
            SetPermission("Show Devices", true);
            SetPermission("View Collector", true);
            SetPermission("View Gateway", true);
            SetPermission("Clone Collector", true);
            SetPermission("Clone Gateway", true);
            SetPermission("Delete Device", true);
            SetPermission("Device Management", true);

            //Export Management

            SetPermission("View Exports", true);
            SetPermission("Select One or All File for Export", true);
            SetPermission("Deselect One or All File for Export", true);
            SetPermission("ReExport", true);
            SetPermission("Export Settings", true);
            SetPermission("View Only Exported", true);
            SetPermission("Export", true);
            SetPermission("Export History", true);

            //Route Management

            SetPermission("View Route Management Dashboard", true);
            SetPermission("Edit Assignments", false);
            SetPermission("Display as Reader", true);
            SetPermission("Route Assignment Screen", true);

            //Notification Management

            SetPermission("Create Notification", false);
            SetPermission("Edit Notification", false);
            SetPermission("View Notification", true);
            SetPermission("Notification", true);

            //Landing Page

            SetPermission("Search Account", true);
            SetPermission("Dashboard Widget", true);
            SetPermission("Customer Inquiry Widget", true);
            SetPermission("Billing Service Widget", true);
            SetPermission("Notifications Widget", false);
            SetPermission("User Management Widget", true);
            SetPermission("Utility Management Widget", true);
            SetPermission("Route Management Widget", true);
            SetPermission("Reports Widget", true);
            SetPermission("Groups Widget", true);
            SetPermission("Data Log Widget", true);

            //Customer Inquiry

            SetPermission("Search and Select Account", true);
            SetPermission("Edit Asset Configuration", true);
            SetPermission("Select a Meter", true);
            SetPermission("Consumption Metrics", true);
            SetPermission("Customer Inquiry", true);
            SetPermission("Dashboard", true);
            SetPermission("Initiate Refresh Reads", true);
            SetPermission("Edit Soft Disconnect", true);
            SetPermission("View Comments", true);
            SetPermission("Create Comments", false);
            SetPermission("Edit Comments", false);
            SetPermission("Delete Others Comments", false);
            SetPermission("Delete Own Comments", false);
            SetPermission("Edit Reading", false);

            //Mobile MMR

            SetPermission("Advanced RF Test", true);
            SetPermission("MIU Logging", true);
            SetPermission("Pressure", true);
            SetPermission("Meter Reading", true);
            SetPermission("Sync Unassigned Routes", true);

            //Alert Configuration

            SetPermission("Alert Configuration Screen", true);
            SetPermission("View Alert Configurations", true);
            SetPermission("Create, Edit & Delete Alert Configurations", true);

            //Dashboard
            SetPermission("View All Network Health Dashboard Widgets", false);

            //Reporting
            SetPermission("Coded Notes Report", true);
            SetPermission("Comments Report", true);
            SetPermission("Mach 10 Battery Status", true);
            SetPermission("Invalid Readings Report", true);
            SetPermission("Reports Landing Page Access", true);
            SetPermission("Days of Consumption (AMR)", true);
            SetPermission("Days of No Flow (AMR)", true);
            SetPermission("Found Meters Report", true);
            SetPermission("AMI No Flow Report", true);
            SetPermission("Inactive Flow Report", true);
            SetPermission("High Consumption Report", true);
            SetPermission("Soft Disconnect Report", true);
            SetPermission("Endpoint Maintenance Report", true);
            SetPermission("Days of Consecutive Flow (AMI) - Flag Based", true);
            SetPermission("Endpoint Consumption Report", true);
            SetPermission("Active SIM With No Site Report", false);
            SetPermission("Active SIM Associated to Undefined Site Report", false);
            SetPermission("Days of Consecutive Flow (AMI) - Consumption Based", true);
            SetPermission("Reverse Flow Report", true);
            SetPermission("Changed Read Parameters Report", true);
            SetPermission("High Low Limit Fail Report", true);
            SetPermission("Meter Readings Report", true);
            SetPermission("Productivity Report", true);
            SetPermission("Tamper Report", true);
            SetPermission("Geocoding Summary Report", true);

            //Partner Management

            SetPermission("View Partner Management", false);
            SetPermission("Create Partners", false);
            SetPermission("Edit Partners", false);

            //Api Deployment

            SetPermission("View API Deployment", false);
            SetPermission("Create Bundles", false);
            SetPermission("Edit Bundles", false);

            //Usage Plans
            SetPermission("View Usage Plans", false);
            SetPermission("Edit  Usage Plans", false);

            //File Mapper
            //SetPermission("File Mapper", true);
            //SetPermission("", true);

            //SDK Access

            SetPermission("View SDK Access", true);

            //HandHelds
            SetPermission("View Handhelds", true);
            SetPermission("Create Handhelds", true);
            SetPermission("Edit Handhelds", true);

            //Neptune 360 Sync

            SetPermission("View Neptune 360 Sync Screen", true);
            SetPermission("Download Neptune 360 Sync", true);

            //Handheld Settings

            SetPermission("View Handheld Settings", true);
            SetPermission("Edit Handheld Settings", true);

            //Groups

            SetPermission("View Groups", true);
            SetPermission("Create/Edit Group container", true);
            SetPermission("Manage Group Endpoints", true);
            SetPermission("Delete Groups", true);

            //Settings

            SetPermission("View Settings", true);
            SetPermission("Edit Settings", true);
            SetPermission("Meter Reading Batch File Settings", false);
            SetPermission("Lora Private Network Settings", false);

            //NSP DB Conversion

            SetPermission("View NSP DB Conversion", false);

            //Billing Services Settings

            SetPermission("View Export Rules", true);
            SetPermission("Edit Export Rules", true);
            SetPermission("View General Settings", true);
            SetPermission("Edit General Settings", true);
            SetPermission("View Import Rules", true);
            SetPermission("Edit Import Rules", true);
            SetPermission("Edit Data Translations", true);
            SetPermission("View Billing Automation", true);
            SetPermission("Edit Billing Automation", false);
            SetPermission("View FTP Credentials", false);

            //Endpoint FOTA

            SetPermission("View Endpoint FOTA", false);
            SetPermission("Send Update", false);
            SetPermission("Cancel Update", false);

            //MIU List
            SetPermission("View MIU List", false);

            //SIM Management

            SetPermission("View SIM Management", false);
            SetPermission("Edit SIM Management", false);

            //PDT Management

            SetPermission("Packet Dump Tool ", false);

            //Mobile Field Management
            SetPermission("Endpoint Manager", true);

            //Endpoint Commands

            SetPermission("View Endpoint Commands", false);
            SetPermission("Utilize Change RSV Status", false);

        }

        public void SetPermissionsForUtilityReadOnlyAccess()
        {
            //identity Management
            SetPermission("View Users", false);
            SetPermission("Create Users", false);
            SetPermission("Search Users", false);
            SetPermission("Edit Users", false);
            SetPermission("Deactivate Users", false);
            SetPermission("Send Password Reset", false);
            SetPermission("Users", false);
            SetPermission("User Profile", false);
            SetPermission("Users Management", false);
            // SetPermission("Multifactor Authentication", true);

            //Utility Management
            SetPermission("Create Utilities", false);
            SetPermission("Edit Utilities", false);
            SetPermission("View Utilities", true);
            SetPermission("Utilities Management", true);

            //Left Navigation
            SetPermission("Create Utilities", true);
            SetPermission("Edit Utilities", true);
            SetPermission("View Utilities", true);
            SetPermission("Utilities Management", true);
            SetPermission("Dashboard Left Navigation", true);
            SetPermission("Customer Inquiry Left Navigation", true);
            SetPermission("Data Log Left Navigation", true);
            SetPermission("Billing Services Left Navigation", true);
            SetPermission("Utility Management Left Navigation", true);
            SetPermission("Platform Management Left Navigation", false);
            SetPermission("User Management Left Navigation", false);
            SetPermission("Roles and Permissions Left Navigation", false);
            SetPermission("Notifications Left Navigation", false);
            SetPermission("Alert Configuration Left Navigation", false);
            SetPermission("Dashboard Network Health Left Navigation", false);
            SetPermission("Route Assignments Left Navigation", false);
            SetPermission("Route Management Left Navigation", false);
            SetPermission("Reports Left Navigation", true);
            SetPermission("API Deployment Left Navigation", false);
            SetPermission("Partner Management Left Navigation", false);
            SetPermission("File Mapper Left Navigation", false);
            SetPermission("Usage Plans Left Navigation", false);
            SetPermission("SDK Access Left Navigation", false);
            SetPermission("Handheld Management Left Navigation", true);
            SetPermission("Handhelds Left Navigation", true);
            SetPermission("Neptune 360 Sync Left Navigation", false);
            SetPermission("Handheld Settings Left Navigation", false);
            SetPermission("Device Activations Left Navigation", false);
            SetPermission("Groups Left Navigation", false);
            SetPermission("Settings Left Navigation", true);
            SetPermission("NSP DB Conversion Left Navigation", false);
            SetPermission("Billing Services Settings Left Navigation", true);
            SetPermission("Endpoint Management Left Navigation", false);
            SetPermission("Endpoint FOTA Left Navigation", false);
            SetPermission("MIU List Left Navigation", false);
            SetPermission("SIM Management Left Navigation", false);
            SetPermission("Geocoding Services Left Navigation", true);
            SetPermission("Configurable Communication Devices Left Navigation", true);
            SetPermission("Endpoint Commands Left Navigation", false);
            SetPermission("My Dashboard Left Navigation", true);


            //Top Navigation

            SetPermission("Home Top Navigation", true);
            SetPermission("Profile Top Navigation", true);
            SetPermission("Logout Top Navigation", true);
            SetPermission("Choose Utilities", true);


            //Code Maintenance

            SetPermission("Create Codes", false);
            SetPermission("Search Codes", true);
            SetPermission("Edit Codes", false);
            SetPermission("View Codes", true);
            SetPermission("Select and Delete Codes", false);


            //Role Management

            SetPermission("Neptune Only Option", false);
            SetPermission("Create Role", false);
            SetPermission("Edit Role", false);
            SetPermission("Toggle Permissions", false);
            SetPermission("View Role", false);
            SetPermission("Delete Role", false);
            SetPermission("Role Management", false);

            //Import Management

            SetPermission("Import", false);
            SetPermission("View Import Files", false);
            SetPermission("Import Files", false);
            SetPermission("Import Summary", false);

            //Device Management

            SetPermission("Create Collector", false);
            SetPermission("Create Gateway", false);
            SetPermission("Edit Collector", false);
            SetPermission("Edit Collector Description", false);
            SetPermission("Build USB for Collector", false);
            SetPermission("Edit Gateway", false);
            SetPermission("Edit Gateway Description", false);
            SetPermission("Build USB for Gateway", false);
            SetPermission("Show Devices", false);
            SetPermission("View Collector", true);
            SetPermission("View Gateway", true);
            SetPermission("Clone Collector", false);
            SetPermission("Clone Gateway", false);
            SetPermission("Delete Device", false);
            SetPermission("Device Management", true);

            //Export Management

            SetPermission("View Exports", true);
            SetPermission("Select One or All File for Export", false);
            SetPermission("Deselect One or All File for Export", false);
            SetPermission("ReExport", false);
            SetPermission("Export Settings", false);
            SetPermission("View Only Exported", false);
            SetPermission("Export", false);
            SetPermission("Export History", true);

            //Route Management

            SetPermission("View Route Management Dashboard", false);
            SetPermission("Edit Assignments", false);
            SetPermission("Display as Reader", false);
            SetPermission("Route Assignment Screen", false);

            //Notification Management

            SetPermission("Create Notification", false);
            SetPermission("Edit Notification", false);
            SetPermission("View Notification", false);
            SetPermission("Notification", false);

            //Landing Page

            SetPermission("Search Account", true);
            SetPermission("Dashboard Widget", true);
            SetPermission("Customer Inquiry Widget", true);
            SetPermission("Billing Service Widget", true);
            SetPermission("Notifications Widget", false);
            SetPermission("User Management Widget", true);
            SetPermission("Utility Management Widget", true);
            SetPermission("Route Management Widget", false);
            SetPermission("Reports Widget", true);
            SetPermission("Groups Widget", true);
            SetPermission("Data Log Widget", true);

            //Customer Inquiry

            SetPermission("Search and Select Account", true);
            SetPermission("Edit Asset Configuration", false);
            SetPermission("Select a Meter", true);
            SetPermission("Consumption Metrics", true);
            SetPermission("Customer Inquiry", true);
            SetPermission("Dashboard", true);
            SetPermission("Initiate Refresh Reads", false);
            SetPermission("Edit Soft Disconnect", false);
            SetPermission("View Comments", true);
            SetPermission("Create Comments", false);
            SetPermission("Edit Comments", false);
            SetPermission("Delete Others Comments", false);
            SetPermission("Delete Own Comments", false);
            SetPermission("Edit Reading", false);

            //Mobile MMR

            SetPermission("Advanced RF Test", false);
            SetPermission("MIU Logging", false);
            SetPermission("Pressure", false);
            SetPermission("Meter Reading", false);
            SetPermission("Sync Unassigned Routes", false);

            //Alert Configuration

            SetPermission("Alert Configuration Screen", false);
            SetPermission("View Alert Configurations", false);
            SetPermission("Create, Edit & Delete Alert Configurations", false);

            //Dashboard
            SetPermission("View All Network Health Dashboard Widgets", false);

            //Reporting
            SetPermission("Coded Notes Report", true);
            SetPermission("Comments Report", true);
            SetPermission("Mach 10 Battery Status", true);
            SetPermission("Invalid Readings Report", true);
            SetPermission("Reports Landing Page Access", true);
            SetPermission("Days of Consumption (AMR)", true);
            SetPermission("Days of No Flow (AMR)", true);
            SetPermission("Found Meters Report", true);
            SetPermission("AMI No Flow Report", true);
            SetPermission("Inactive Flow Report", true);
            SetPermission("High Consumption Report", true);
            SetPermission("Soft Disconnect Report", true);
            SetPermission("Endpoint Maintenance Report", true);
            SetPermission("Days of Consecutive Flow (AMI) - Flag Based", true);
            SetPermission("Endpoint Consumption Report", true);
            SetPermission("Active SIM With No Site Report", false);
            SetPermission("Active SIM Associated to Undefined Site Report", false);
            SetPermission("Days of Consecutive Flow (AMI) - Consumption Based", true);
            SetPermission("Reverse Flow Report", true);
            SetPermission("Changed Read Parameters Report", true);
            SetPermission("High Low Limit Fail Report", true);
            SetPermission("Meter Readings Report", true);
            SetPermission("Productivity Report", true);
            SetPermission("Tamper Report", true);
            SetPermission("Geocoding Summary Report", true);

            //Partner Management

            SetPermission("View Partner Management", false);
            SetPermission("Create Partners", false);
            SetPermission("Edit Partners", false);

            //Api Deployment

            SetPermission("View API Deployment", false);
            SetPermission("Create Bundles", false);
            SetPermission("Edit Bundles", false);

            //Usage Plans
            SetPermission("View Usage Plans", false);
            SetPermission("Edit  Usage Plans", false);

            //File Mapper
            SetPermission("File Mapper", false);
            

            //SDK Access

            SetPermission("View SDK Access", false);

            //HandHelds
            SetPermission("View Handhelds", true);
            SetPermission("Create Handhelds", true);
            SetPermission("Edit Handhelds", true);

            //Neptune 360 Sync

            SetPermission("View Neptune 360 Sync Screen", true);
            SetPermission("Download Neptune 360 Sync", true);

            //Handheld Settings

            SetPermission("View Handheld Settings", false);
            SetPermission("Edit Handheld Settings", false);

            //Groups

            SetPermission("View Groups", true);
            SetPermission("Create/Edit Group container", false);
            SetPermission("Manage Group Endpoints", false);
            SetPermission("Delete Groups", false);

            //Settings

            SetPermission("View Settings", true);
            SetPermission("Edit Settings", false);
            SetPermission("Meter Reading Batch File Settings", false);
            SetPermission("Lora Private Network Settings", false);

            //NSP DB Conversion

            SetPermission("View NSP DB Conversion", false);

            //Billing Services Settings

            SetPermission("View Export Rules", false);
            SetPermission("Edit Export Rules", false);
            SetPermission("View General Settings", true);
            SetPermission("Edit General Settings", false);
            SetPermission("View Import Rules", false);
            SetPermission("Edit Import Rules", false);
            SetPermission("Edit Data Translations", false);
            SetPermission("View Billing Automation", false);
            SetPermission("Edit Billing Automation", false);
            SetPermission("View FTP Credentials", false);

            //Endpoint FOTA

            SetPermission("View Endpoint FOTA", false);
            SetPermission("Send Update", false);
            SetPermission("Cancel Update", false);

            //MIU List
            SetPermission("View MIU List", false);

            //SIM Management

            SetPermission("View SIM Management", false);
            SetPermission("Edit SIM Management", false);

            //PDT Management

            SetPermission("Packet Dump Tool ", false);

            //Mobile Field Management
            SetPermission("Endpoint Manager", true);

            //Endpoint Commands

            SetPermission("View Endpoint Commands", false);
            SetPermission("Utilize Change RSV Status", false);

        }

    }
}
   



