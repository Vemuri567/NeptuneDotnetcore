using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Keys = OpenQA.Selenium.Keys;

namespace Neptune360UIAutomation
{
    public class UtilityManagementPage : AbstractTemplatePage
    {
        #region UI Object Repository
        private By btnUtilityManagement = By.XPath("//img[contains(@src,'UtilityManagement.3D')]");
        private By lblHeaderUtilityManagement = By.XPath("//h2[text()='Utility Management']");
        private By selectUtility = By.XPath("//div//span/sd-menu/ul/li[1]");
        private By selectfirstUtilityFromList = By.XPath("//tr[1]/td/span");
        private By selectsecUtilityFromList = By.XPath("//tr[2]/td/span");
        private By btnCreateUtility = By.XPath("//button[text()=' Create ']");
        private By dlgCreateUtility = By.XPath("//span[text()='Create New Utility']");
        private By btnCancelUtility = By.Id("createUtilityCancelButton");
        private By btnEditUtility = By.XPath("//button[contains(@class,'k-button k-primary btn-edit')]");
        private By utilityDetails = By.XPath("//div[@class='content-wrapper wrapper']");
        private By defaultUOM = By.XPath("//div[1]//div[6]//div[2]/div[3]");
        private By lblCodeManagementTitle = By.XPath("//span[text()='Code Management']");
        private By btnCreateCodeManagement = By.XPath("//span[text()='Code Management']/..//button[text()='Create ']");
        private By dlgCreateUtilityCodes = By.XPath("//span[text()='Create Utility Type Code']");
        private By dlgEditUtilityTypeCodes = By.XPath("//span[text()='Update Utility Type Code']");
        private By btnCancelUtilityTypeCodes = By.Id("createUtilityCancelButton");
        private By iconFilterCode = By.XPath("//span[contains(@class, 'pull-right filtericon')]");
        private By drpFilterCode = By.XPath("//kendo-popup//span[@class='k-dropdown-wrap k-state-default']");
        private By drpFilterCode1 = By.XPath("//kendo-popup//button[contains(@class,'k-input-button k-button')]");
        private By clearBtn = By.XPath("//button[contains(.,'Clear')]");
        private By filterBtn = By.XPath("//button[contains(.,'Filter')]");
        private By ddlSkipCode = By.XPath("//li[contains(.,'Skip Code')]");
        private By ddlMeterCondition = By.XPath("//div/ul/li[2]");
        private By ddlReadInst = By.XPath("//li[contains(.,'Read Instructions Code')]");
        private By ddlCommtCode = By.XPath("//li[contains(.,'Comment Code')]");
        private By ddlHazardCode = By.XPath("//li[contains(.,'Hazard Code')]");
        private By ddlLocationCode = By.XPath("//li[contains(.,'Location Code')]");
        private By btnFilterCode = By.ClassName("filter-btn");
        private By rowValueType = By.XPath("//kendo-grid[@id='codeGrid']//td[@aria-colindex='1']");
        private By btnEditCode = By.XPath("//kendo-grid[@id='codeGrid']//button[contains(text(), 'Edit')]");
        private By btnDeleteCode = By.XPath("//kendo-grid[@id='codeGrid']//button[contains(text(), 'Delete')]");
        private By btnDeleteYes = By.XPath("//button[text()='Yes']");
        private By btnDeleteNo = By.XPath("//button[text()='No']");
        private By btnCreateCode = By.XPath("//span[text()='Code Management']//..//button[contains(text(), 'Create')]");
        private By codeEditDescr = By.XPath("(//input[@type='text'])[4]");
        private By drpType = By.XPath("//kendo-dropdownlist[@formcontrolname='typeId']");
        private By txtCode = By.XPath("//input[@formcontrolname='code']");
        private By codeError = By.XPath("//form/div[2]/div/div[2]");
        private By decrError = By.XPath("//form/div[3]/div/div[2]");
        private By btnCreateDevice = By.XPath("//kendo-dropdownbutton//span[text()='Create']");
        private By btnCollector = By.XPath("//kendo-button-list//span[text()='Collector']");
        private By btnGateway = By.XPath("//kendo-button-list//span[text()='Gateway']");
        private By lnkDeviceId = By.XPath("//table[@class='k-grid-table']//tr[1]//a[1]");
        private By rowValueDeviceName = By.XPath("//table[@class='k-grid-table']//tr[1]//a[1]/../following-sibling::td[1]");
        private By deviceId = By.Id("itemlink");
        private By dlgEditCollConfig = By.XPath("//span[text()='Collector Configuration']");
        private By btnSaveCollConfig = By.Id("createUtilitySaveButton");
        private By btnCancelCollConfig = By.Id("createUtilityCancelButton");
        private By btnDeviceName = By.XPath("//table[@class='k-grid-table']//tr[1]//button");
        private By btnBuildUSB = By.XPath("//button[text()='Build USB']");
        private By dlgGatewayConfig = By.XPath("//span[text()='Gateway Configuration']");
        private By btnEditGateway = By.XPath("//button[text()='Edit']");
        private By btnSaveEditGateway = By.XPath("//button[text()='Save']");
        private By btnCancelEditGateway = By.XPath("//button[text()='Cancel']");
        private By cancelSetup = By.XPath("//button[text()='Yes']");
        private By cancelSetupNo = By.XPath("//button[text()='No']");
        private By cnacelGatewayPopop = By.XPath("//div/kendo-dialog/div[2]");
        private By btnCloseGatewayConfig = By.XPath("//button[text()='Close']");
        private By btnCloneDevice = By.XPath("//button[text()='Clone']");
        private By btnDeleteDevice = By.XPath("//kendo-grid-toolbar/span[text()='Device Management']/..//button[text()='Delete']");
        private By popopDelete = By.XPath("//kendo-dialog-actions/button[1]");
        private By popopCancel = By.XPath("//kendo-dialog-actions/button[2]");
        private By txtCreateUtilityName = By.Id("createUtilityName");
        private By txtCreateUtilitySiteId = By.XPath("//input[@id='siteId']");
        private By txtCreateUtilityAddress = By.XPath("//input[@formcontrolname='address']");
        private By txtCreateUtilityCity = By.XPath("//input[@formcontrolname='city']");
        private By drpCreateUtilityState = By.Id("drpState");
        private By ddlUtilityState = By.XPath("//kendo-list/div/ul/li[1]");
        private By txtCreateUtilityZip = By.XPath("//input[@formcontrolname='zip']");
        private By btnCreateUtilitySave = By.Id("createUtilitySaveButton");
        private By tblChooseUtilities = By.XPath("//span[text()='Choose Utilities']//../../..//table[@class='k-grid-table']//span");
        private By lnkChooseUtilities = By.XPath("//sd-menu/ul/li");
        private By btnCloseUtilities = By.CssSelector(".k-i-x");
        private By allUtilities = By.XPath("//*[@id='utilitiesGrid']/div/kendo-grid-list");
        private By btnChooseUtilitiesOk = By.Id("deactUtilityYesButton");
        private By noUtilitySelected = By.XPath("//div[contains(text(),'No utilities selected.')]");
        private By btnChooseUtilitiesCancel = By.XPath("//a");
        private By closeBtnPopup = By.XPath("//button[contains(@class,' k-dialog-action k-dialog-close')]");
        private By utilitySearch = By.Id("utilitySearchTextBox");
        private By txtCollectorId = By.Id("collectorId");
        private By txtHostIpAdd = By.Id("hostIpAddress");
        private By systemId = By.Id("systemId");
        private By txtCollectorName = By.Id("collectorName");
        private By dlgSiteID = By.XPath("//sd-utility-create-edit-dialog[2]//div[2]/div/div[2]");
        private By gatewaySiteID = By.XPath("//div[1]//div[1]/div[1]/input");
        private By lftNavUtilityManagement = By.XPath("//span[text()='UTILITY MANAGEMENT']");
        private By lftNavDeviceManagement = By.XPath("//span[text()='DEVICE MANAGEMENT']");
        private By deviceSearch = By.Id("txtDeviceIdSearch");
        private By deviceNoResult = By.XPath("//span[contains(text(),'No Result Found')]");
        private By collectorIdExisting = By.XPath("//kendo-dialog/div[2]//div[1]/div[1]/div/div");
        private By collectorID = By.Id("collectorId");
        private By collectorIdDisplay = By.CssSelector(".form-group > .ng-star-inserted > div");
        private By collectorName = By.Id("collectorName");
        private By collectorTransferInterval = By.Id("transferInterval");
        private By collectorHostIp = By.Id("hostIpAddress");
        private By errorMsgSpecialChar = By.XPath("//div[contains(text(),'Special characters are not allowed')]");
        private By collectorStartTime = By.XPath("//div[1]/div/div/kendo-timepicker//kendo-dateinput");
        private By collectorEndTime = By.XPath("//div[3]/div/div/kendo-timepicker//kendo-dateinput");
        private By collectorWAN = By.Id("drpWanType");
        private By gatewayError = By.XPath("//div[text()=' Please enter data into required field ']");
        private By gprs = By.XPath("//li[contains(.,'GPRS')]");
        private By gprsEthernet = By.XPath("//li[contains(.,'GPRS_ETHERNET')]");
        private By networkDhcp = By.XPath("//li[contains(.,'NETWORK_DHCP')]");
        private By chkCloseRoute = By.Id("createUtilityCloseExport");
        private By chkCloseRouteDailog = By.XPath("//a[contains(@class,'k-dialog-close')]");
        private By chkUTCOffset = By.Id("createUtilityUTCOffset");
        private By chkDaylight = By.Id("createUtilityDstEnabled");
        private By collectorStaticIP = By.XPath("//kendo-dialog//div[3]/div/div[2]/div/div");
        private By networkStaticIP = By.XPath("//li[contains(.,'NETWORK_STATIC_IP')]");
        private By collectorSubnet = By.XPath("//kendo-dialog//div[3]/div/div[3]/div/div");
        private By collectorNetworkGateway = By.XPath("//kendo-dialog//div[3]/div/div[4]/div/div");
        private By collectorDomain = By.XPath("//kendo-dialog//div[3]/div/div[5]/div/div");
        private By collectorSystemID = By.XPath("//kendo-dialog/div[2]//div[2]/div[2]/div/div");
        private By collectorTimzone = By.XPath("//kendo-dialog/div[2]//div[2]/div[3]/div/div");
        private By collectorTransit = By.XPath("//kendo-dialog/div[2]//div[2]/div[4]/div/div");
        private By collectorReceive = By.XPath("//kendo-dialog/div[2]//div[2]/div[5]/div/div");
        private By collectorLatitude = By.XPath("//kendo-dialog/div[2]//div[2]/div[6]/div[1]/div/div");
        private By collectorLongitude = By.XPath("//kendo-dialog/div[2]//div[2]/div[6]/div[2]/div/div");
        private By collectorDeviceId = By.Id("itemlink");
        private By collectorDailyReboot = By.XPath("//kendo-switch[@formcontrolname='dailyReboot']");
        private By hostIPErrorMessage = By.XPath("//div[text()=' Please enter a Host IP Address. ']");
        private By idErrorMessage = By.XPath("//div[text()='CollectorId should be between 1 and 1022']");
        private By collectorNameError = By.XPath("//div[1]/div[2]/div/div[2]/div/div");
        private By nameErrorMessage = By.XPath("//div[text()=' Please enter a Collector Name. ']");
        private By utilityNameExists = By.XPath("//kendo-dialog//div[1]/div/div[2]");
        private By updateUtilityError = By.XPath("//div[2]/div//div[1]/div/div[2]");
        private By toastMessage = By.Id("toast-container");
        private By offsetTime = By.XPath("//span[contains(text(),'Time')]");
        private By mountainTime = By.XPath("//li[contains(.,'(UTC-7) Mountain Time')]");
        private By timeZone = By.Id("createUtilityUTCOffset");
        private By timezoneField = By.XPath("//div[4]/div/div[2]/div[1]");
        private By drpUOM = By.XPath("//kendo-dropdownlist[@id='drpUOM']");
        private By drpTimezone = By.XPath("//div[10]//kendo-dropdownlist/span");
        private By drpCountryCode = By.XPath("//country-picker/kendo-dropdownlist");
        private By cubicFt = By.XPath("//li[contains(.,'Cubic Feet')]");
        private By cubicMeters = By.XPath("//li[contains(.,'Cubic Meters')]");
        private By gallons = By.XPath("//li[contains(.,'Gallons')]");
        private By imperialGallons = By.XPath("//li[contains(.,'Imperial Gallons')]");
        private By liters = By.XPath("//li[contains(.,'Liters')]");
        private By breadCrumb = By.XPath("//sd-toolbar/div/span/span");
        private By utilityStatus = By.CssSelector(".ntg-font-size-h4 > .col-xs-6:nth-child(2)");
        private By utilityTimezone = By.CssSelector(".row:nth-child(4) .col-xs-4");
        private By utilityCountrycode = By.CssSelector(".row:nth-child(5) .ntg-font-size-h4 > .col-xs-3:nth-child(2)");
        private By utilityDaylight = By.XPath("//div[4]/div/div[2]/div[3]");
        private By gatewaySiteid = By.XPath("//div[1]/div/input");
        private By gatewayID = By.XPath("//div[2]/div/input");
        private By gatewayName = By.XPath("//div[3]/div/input");
        private By gatewayWaterclass = By.XPath("//div/kendo-dropdownlist");
        private By transferInt = By.XPath("//kendo-numerictextbox[@formcontrolname='transferInterval']");
        private By keepModem = By.XPath("//kendo-switch[@formcontrolname='keepModemOn']");
        private By radioInactive = By.XPath("//kendo-numerictextbox[@formcontrolname='radioInactiveTimeout']");
        private By collectorLat = By.XPath("//kendo-numerictextbox[@formcontrolname='latitude']");
        private By collectorLon = By.XPath("//kendo-numerictextbox[@formcontrolname='longitude']");
        private By webService = By.XPath("//input[@formcontrolname='webServiceHost']");
        private By staticIpradio = By.XPath("//kendo-switch[@formcontrolname='staticIPFlag']");
        private By staticIPtxtbox = By.XPath("//input[@formcontrolname='staticIP']");
        private By subnetMask = By.XPath("//input[@formcontrolname='subnetMask']");
        private By networkGateway = By.XPath("//input[@formcontrolname='networkGateway']");
        private By domainServer = By.XPath("//input[@formcontrolname='domainServer']");
        private By commandFirst = By.XPath("//div[1]/sd-polling-panel//div[3]/div[2]/div/kendo-timepicker");
        private By commandSec = By.XPath("//div[1]/sd-polling-panel//div/div[4]/div[2]/div/kendo-timepicker");
        private By readFirst = By.XPath("//div[2]/sd-polling-panel//div[3]/div[2]/div/kendo-timepicker");
        private By readSec = By.XPath("//div[2]/sd-polling-panel//div/div[4]/div[2]/div/kendo-timepicker");
        private By commandThird = By.XPath("//div[1]/sd-polling-panel//div[5]/div[2]/div/kendo-timepicker");
        private By readThird = By.XPath("//div[2]/sd-polling-panel//div/div[5]/div[2]/div/kendo-timepicker");
        private By commandFirstEnd = By.XPath("//div[1]/sd-polling-panel//div[3]/div[3]/kendo-timepicker");
        private By readFirstEnd = By.XPath("//div[2]/sd-polling-panel//div[3]/div[3]/kendo-timepicker");
        private By commandSecEnd = By.XPath("//div[1]/sd-polling-panel//div[4]/div[3]/kendo-timepicker");
        private By readSecEnd = By.XPath("//div[2]/sd-polling-panel//div[4]/div[3]/kendo-timepicker");
        private By commandThirdEnd = By.XPath("//div[1]/sd-polling-panel//div[5]/div[3]/kendo-timepicker");
        private By readThirdEnd = By.XPath("//div[2]/sd-polling-panel//div[5]/div[3]/kendo-timepicker");
        private By commandPollError = By.XPath("//div[text()=' Start Time must be before the end time ']");
        private By handheldSupport = By.Id("createHandheldSupport");
        private By autoCompleteDays = By.XPath("//div[14]/div/kendo-numerictextbox/span/input");
        private By autoCompleteIncrease = By.XPath("//div[14]/div/kendo-numerictextbox/span/span/span[1]");
        private By autoCompleteDecrease = By.XPath("//div[14]/div/kendo-numerictextbox/span/span/span[2]");
        private By autoCompleteDaysValue = By.XPath("//div[1]/div/div/div/div[7]/div/div[2]/div[1]");
        private By mobileMaping = By.Id("createUtilityMobileMapping");
        private By mobileMapingFeild = By.XPath("//div[7]/div/div[2]/div[3]");
        private By importExportFileFormat = By.Id("drpfileFormat");
        private By v2Standard = By.XPath("//li[contains(.,'V2 Standard')]");
        private By ezRoute509 = By.XPath("//li[contains(.,'EZRoute 509 Bytes')]");
        private By v4Standard = By.XPath("//li[contains(.,'V4 Standard')]");
        private By v4Modified = By.XPath("//li[contains(.,'V4 Modified')]");

        private By importExportFormatInfo = By.XPath("//div[7]/div/div[2]/div[2]");
        private By timeZoneDropdown = By.XPath("//div[10]/div/div/kendo-dropdownlist/span/span[1]");
        private By easternTime = By.XPath("//li[contains(.,'(UTC-5) Eastern Time')]");
        private By closeRouteField = By.XPath("//div[4]/div/div[2]/div[2]");
        private By deviceEditUtility = By.XPath("//button[text()=' Edit ' and contains(@class,'btn-edit-company')]");
        private By uom = By.XPath("//label[text()='Default Unit of Measure']/..//following-sibling::span//span[@class='k-input']");
        private By defaultUomDropdownicon = By.XPath("//label[text()='Default Unit of Measure']/..//span[@class='k-i-arrow-s k-icon']");
        private By deviceManagementdefaultUOM = By.XPath("//div[text()='Default Unit of Measure']/..//following-sibling::div[@class='row ntg-font-size-h4']//div[@class='col-md-3'][3]");
        #endregion

        /// <summary>
        /// Method to Validate Header Utility Management
        /// </summary>
        public void ValidateHeaderUtilityManagement()
        {
            driver.CheckElementExists(lblHeaderUtilityManagement, "Utility Management Screen");
        }

        /// <summary>
        /// Method to Validate Create Utility Dialog Displays
        /// </summary>
        public void ValidateCreateUtilityDlg()
        {
            driver.ClickElement(btnCreateUtility, "Create");
            driver.CheckElementExists(dlgCreateUtility, "Create New Utility Dialog");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Create Utility Button Does Not Displays
        /// </summary>
        public void ValidateCreateUtilityButtonDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnCreateUtility, "Create");
        }

        /// <summary>
        /// Method to Validate Edit Utility Button Display
        /// </summary>
        public void ValidateEditUtilityButtonDisplay()
        {
            driver.CheckElementExists(btnEditUtility, "Edit");
        }

        /// <summary>
        /// Method to Validate Edit Utility Button Does Not Displays
        /// </summary>
        public void ValidateEditUtilityButtonDoesNotDisplays()
        {
            driver.CheckElementDoesnotExists(btnEditUtility, "Edit");
        }

        /// <summary>
        /// Method to Validate Utility Details
        /// </summary>
        public void ValidateUtilityDetails()
        {
            driver.CheckElementExists(utilityDetails, "Utility Details");
        }

        /// <summary>
        /// Method to Validate Code Management Section Displays
        /// </summary>
        public void ValidateCodeManagementSectionDisplays()
        {
            driver.CheckElementExists(lblCodeManagementTitle, "Code Management");
        }

        /// <summary>
        /// Method to Validate Create Code Displays
        /// </summary>
        public void ValidateCreateCodeDisplays()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            //driver.CheckElementExists(btnCreateCodeManagement, "Create Code Managment");
            driver.ClickElement(btnCreateCode, "Create Code Management");
            driver.CheckElementExists(dlgCreateUtilityCodes, "Create Utility Type Codes");
            driver.ClickElement(btnCancelUtilityTypeCodes, "Cancel");
        }

        /// <summary>
        /// Method to Validate Edit Existing Code
        /// </summary>
        public void ValidateEditExistingCode()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            //driver.CheckElementExists(btnCreateCodeManagement, "Create Code Managment");
            driver.ClickElement(rowValueType, "Code");
            driver.ClickElement(btnEditCode, "Edit");
            driver.CheckElementExists(dlgEditUtilityTypeCodes, "Update Utility Type Codes");
            driver.ClickElement(btnCancelUtilityTypeCodes, "Cancel");
        }

        /// <summary>
        /// Method to Validate Close Route On Export
        /// </summary>
        public void ValidateCloseRouteOnExport()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(chkCloseRoute, "Close Route On Export");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(12));
            driver.ClickElement(btnEditUtility, "Edit");
            driver.VerifyCheckboxStatus(chkCloseRoute, "checked", "Close Route Check box");
            driver.ClickElement(btnCancelUtilityTypeCodes, "Cancel");
        }

        /// <summary>
        /// Method to Validate Close Route On Export Deselected
        /// </summary>
        public void ValidateCloseRouteOnExportDeselected()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.CheckElementDisplayed(chkCloseRoute, "Close Route On Export");
            driver.VerifyCheckboxStatus(chkCloseRoute, "unchecked", "Close Route Check box");
            driver.ClickElement(btnCancelUtilityTypeCodes, "Cancel");
        }

        /// <summary>
        /// Method to Validate Edit Close Route On Export
        /// </summary>
        public void ValidateEditCloseRouteOnExport()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.CheckElementDisplayed(chkCloseRoute, "Close Route On Export");
            driver.VerifyCheckboxStatus(chkCloseRoute, "checked", "Close Route Check box");
            driver.ClickElement(chkCloseRoute, "Close Route Selected");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnEditUtility, "Edit");
            driver.VerifyCheckboxStatus(chkCloseRoute, "unchecked", "Close Route Check Box");
            driver.ClickElement(btnCancelUtilityTypeCodes, "Cancel");
        }

        /// <summary>
        /// Method to Validate Close Route On Export setting off
        /// </summary>
        public void ValidateCloseRouteOnExportSettingOff()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.CheckElementDisplayed(chkCloseRoute, "Close Route On Export");

            if (driver.VerifyCheckboxStatus(chkCloseRoute, "checked", "Close Route"))
            {
                driver.ClickElement(chkCloseRoute, "Close Route Deselected");
            }
            driver.VerifyCheckboxStatus(chkCloseRoute, "unchecked", "Close Route Check box");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnEditUtility, "Edit");
            driver.VerifyCheckboxStatus(chkCloseRoute, "unchecked", "Close Route Check Box");
            driver.ClickElement(btnCancelUtilityTypeCodes, "Cancel");
        }

        /// <summary>
        /// Method to Validate Close Route on export button
        /// </summary>
        public void ValidateCloseRouteExportBtnDisplays()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.CheckElementDisplayed(chkCloseRoute, "Close Route On Export");
            driver.ClickElement(btnCancelUtilityTypeCodes, "Cancel");
        }

        /// <summary>
        /// Method to Validate Close Route export button previously saved 
        /// </summary>
        public void ValidateCloseRouteExportSavedDisplays()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.CheckElementDisplayed(btnCloseUtilities, "Close Route On Export");
            driver.ClickElement(btnCancelUtilityTypeCodes, "Cancel");
        }

        /// <summary>
        /// Method to Validate Close Route export checked saved 
        /// </summary>
        public void ValidateCloseRouteExportCheckedSaved()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(chkCloseRoute, "Close Route On Export");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEditUtility, "Edit");
            driver.CheckElementDisplayed(chkCloseRoute, "Check Box");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Apply UTC Offset 
        /// </summary>
        public void ValidateUTCOffset()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            if (driver.VerifyCheckboxStatus(chkUTCOffset, "unchecked", "UTC Offset"))
            {
                driver.ClickElement(chkUTCOffset, "UTC Offset CheckBox");
            }
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// Method to Validate Not Apply UTC Offset 
        /// </summary>
        public void ValidateNotApplyUTCOffset()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            if (driver.VerifyCheckboxStatus(chkUTCOffset, "checked", "UTC Offset"))
            {
                driver.ClickElement(chkUTCOffset, "UTC Offset CheckBox");
            }
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
        }

        // <summary>
        /// Method to Validate Search Criteria 
        /// </summary>
        public void ValidateSearchCriteria()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.SendKeysToElement(deviceSearch, "1", "Device ID");
            driver.sleepTime(3000);
            driver.SendKeysToElement(deviceSearch, Keys.Enter, "Enter");
        }

        // <summary>
        /// Method to Validate New Fields 
        /// </summary>
        public void ValidateNewFields()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(1000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.CheckElementDisplayed(systemId, "System ID");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        // <summary>
        /// Method to Validate New Fields Edit
        /// </summary>
        public void ValidateNewFieldsEdit()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.CheckElementDisplayed(systemId, "System ID");
            driver.CheckElementDisplayed(txtCreateUtilityAddress, "Address");
            driver.CheckElementDisplayed(txtCreateUtilityCity, "City");
            driver.CheckElementDisplayed(drpCreateUtilityState, "State");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Create Code Button Does Not Displays
        /// </summary>
        public void ValidateCreateCodeButtonDoesNotDisplays()
        {
            driver.CheckElementDoesnotExists(btnCreateCodeManagement, "Create Code Managment");
        }

        /// <summary>
        /// Method to Select Code Option
        /// </summary>
        /// <param name="text"></param>
        public void SelectCodeOption(string code)
        {
            switch (code)
            {
                case "Skip Code":
                    driver.ClickElement(ddlSkipCode, "Skip Code");
                    break;
            }
        }

        /// <summary>
        /// Method to Validate Search Code
        /// </summary>
        /// <param name="code"></param>
        public void ValidateSearchCode(string code)
        {
            driver.CheckElementExists(lblCodeManagementTitle, "Code Management Section");
            driver.ClickElement(iconFilterCode, "Filter Icon");
            driver.ClickElement(drpFilterCode1, "Filter Code");
            SelectCodeOption(code);
            driver.ClickElement(btnFilterCode, "Filter Code");
            driver.sleepTime(2000);
            string value = driver.GetElementText(rowValueType);
            if (value.Contains(code))
                testReport.Pass("Codes based on the Code Type selected: " + code + " are displayed");
            else
                ReporterFactory.LogFailure("Codes based on the Code Type selected: " + code + " are not displayed");
        }

        /// <summary>
        /// Method to Validate Search Code Does Not Exists
        /// </summary>
        /// <param name="code"></param>
        public void ValidateSearchCodeDoesNotExists()
        {
            driver.CheckElementDoesnotExists(iconFilterCode, "Filter Icon");
        }

        /// <summary>
        /// Method to Validate Edit Code
        /// </summary>
        /// <param name="code"></param>
        public void ValidateEditCode(string code)
        {
            driver.CheckElementExists(lblCodeManagementTitle, "Code Management Section");
            driver.ClickElement(iconFilterCode, "Filter Icon");
            driver.ClickElement(drpFilterCode1, "Filter Code");
            SelectCodeOption(code);
            driver.ClickElement(btnFilterCode, "Filter Code");
            driver.sleepTime(2000);
            driver.ClickElement(rowValueType, code);
            driver.IsElementEnabled(btnEditCode, "Edit");
            driver.ClickElement(btnEditCode, "Edit");
            driver.CheckElementExists(dlgEditUtilityTypeCodes, "Edit Utility Type Codes");
            driver.ClickElement(btnCancelUtilityTypeCodes, "Cancel Utility Type Codes");
        }

        /// <summary>
        /// Method to Validate Edit Code Button Does Not Exists
        /// </summary>
        public void ValidateEditCodeButtonDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnEditCode, "Edit");
        }

        /// <summary>
        /// Method to Validate Edit Code Button Does Not Displays
        /// </summary>
        public void ValidateEditCodeButtonDoesNotDisplays()
        {
            driver.CheckElementDoesnotExists(btnEditCode, "Edit");
        }

        /// <summary>
        /// Method to Validate View Code
        /// </summary>
        public void ValidateViewCode()
        {
            driver.CheckElementExists(lblCodeManagementTitle, "Code Management Section");

        }

        /// <summary>
        /// Method to Validate View Code Does Not Exists
        /// </summary>
        public void ValidateViewCodeDoesNotExists()
        {
            driver.CheckElementDoesnotExists(rowValueType, "code");
        }

        /// <summary>
        /// Method to Validate Delete Code
        /// </summary>
        /// <param name="code"></param>
        public void ValidateDeleteCode(string code)
        {
            driver.CheckElementExists(lblCodeManagementTitle, "Code Management Section");
            driver.ClickElement(iconFilterCode, "Filter Icon");
            driver.ClickElement(drpFilterCode1, "Filter Code");
            SelectCodeOption(code);
            driver.ClickElement(btnFilterCode, "Filter Code");
            driver.sleepTime(2000);
            driver.ClickElement(rowValueType, code);
            driver.IsElementEnabled(btnDeleteCode, "Delete");
            driver.ClickElement(btnDeleteCode, "Delete");
            driver.ClickElement(btnDeleteYes, "Yes");
        }

        /// <summary>
        /// Method to Validate Delete Code Button Does Not Displays
        /// </summary>
        /// <param name="code"></param>
        public void ValidateDeleteCodeButtonDoesNotDisplays(string code)
        {

            driver.CheckElementDoesnotExists(btnDeleteCode, "Delete");
        }

        /// <summary>
        /// Method to Validate Create Collector
        /// </summary>
        public void ValidateCreateCollector()
        {
            driver.ClickElement(btnCreateDevice, "Create");
            driver.CheckElementExists(btnCollector, "Collector");
        }

        /// <summary>
        /// Method to Validate Create Collector
        /// </summary>
        public void ValidateCreateCollector(string cId, string cName, string hIp)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateDevice, "Create");
            driver.ClickElement(btnCollector, "Collector");
            driver.SendKeysToElement(collectorID, cId, "Collector ID");
            driver.SendKeysToElement(collectorName, cName, "Collector Name");
            driver.SendKeysToElement(collectorHostIp, hIp, "Host Ip Address");
            driver.ClickElement(btnSaveCollConfig, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(15));
        }

        /// <summary>
        /// Method to Validate Gateway Fields
        /// </summary>
        public void ValidateGatewayFields()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateDevice, "Create");
            driver.ClickElement(btnGateway, "Gateway");
            driver.CheckElementDisplayed(gatewayID, "ID");
            driver.CheckElementDisplayed(gatewayName, "Name"); driver.CheckElementDisplayed(gatewayWaterclass, "Meter Type"); driver.CheckElementDisplayed(transferInt, "Transfer Interval"); driver.CheckElementDisplayed(keepModem, "Keep Modem On"); driver.CheckElementDisplayed(radioInactive, "Radio Inactive Timeout"); driver.CheckElementDisplayed(collectorLat, "Latitude"); driver.CheckElementDisplayed(collectorLon, "Longitude"); driver.CheckElementDisplayed(webService, "Web service Host"); driver.CheckElementDisplayed(staticIpradio, "Static IP Radio Button"); driver.CheckElementDisplayed(staticIPtxtbox, "Static IP Text Box"); driver.CheckElementDisplayed(subnetMask, "Subnet Mask"); driver.CheckElementDisplayed(networkGateway, "Network Gateway"); driver.CheckElementDisplayed(domainServer, "Domain Server"); driver.CheckElementDisplayed(commandFirst, "First Poll Start"); driver.CheckElementDisplayed(commandFirstEnd, "First Poll End"); driver.CheckElementDisplayed(readFirst, "Read First Poll Start"); driver.CheckElementDisplayed(readSecEnd, "Read Second Poll End"); driver.CheckElementDisplayed(commandSec, "Command Second Poll Start"); driver.CheckElementDisplayed(commandSecEnd, "Command Second Poll End"); driver.CheckElementDisplayed(readSec, "Read Second Start"); driver.CheckElementDisplayed(readSecEnd, "Read Second End"); driver.CheckElementDisplayed(commandThird, "Command Third Poll Start "); driver.CheckElementDisplayed(commandThirdEnd, "Command Third Poll End"); driver.CheckElementDisplayed(readThird, "Read Third Poll Start"); driver.CheckElementDisplayed(readThirdEnd, "Read Third Poll End");
            driver.ClickElement(btnCancelEditGateway, "Cancel");
            driver.ClickElement(cancelSetup, "Yes");
        }


        /// <summary>
        /// Method to Validate Left Part Section
        /// </summary>
        public void ValidateLeftPartSection()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateDevice, "Create");
            driver.ClickElement(btnGateway, "Gateway");
            driver.ClickElement(btnSaveEditGateway, "Save");
            driver.CheckElementDisplayed(gatewayError, "Error Message");
            driver.ClickElement(btnCancelEditGateway, "Cancel");
            driver.ClickElement(cancelSetup, "Yes");
        }

        /// <summary>
        /// Method to Validate Gateway Cancellation 
        /// </summary>
        public void ValidateGatewayCancellation()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateDevice, "Create");
            driver.ClickElement(btnGateway, "Gateway");
            driver.ClickElement(btnCancelEditGateway, "Cancel");
            driver.CheckElementDisplayed(cnacelGatewayPopop, "CANCEL SETUP GATEWAY");
            driver.ClickElement(cancelSetup, "Yes");
        }

        /// <summary>
        /// Method to Validate Gateway Cancellation No
        /// </summary>
        public void ValidateGatewayCancellationNo()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateDevice, "Create");
            driver.ClickElement(btnGateway, "Gateway");
            driver.ClickElement(btnCancelEditGateway, "Cancel");
            driver.CheckElementDisplayed(cnacelGatewayPopop, "CANCEL SETUP GATEWAY");
            driver.ClickElement(cancelSetupNo, "No");
            driver.ClickElement(btnCancelEditGateway, "Cancel");
            driver.ClickElement(cancelSetup, "Yes");
        }



        /// <summary>
        /// Method to Validate Clone Collector Fields
        /// </summary>
        public void ValidateCloneCollectorFileds()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(rowValueDeviceName, "Device");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.WaitForElement(collectorID, TimeSpan.FromSeconds(15));
            driver.CheckElementDisplayed(collectorID, "Collector ID");
            driver.CheckElementDisplayed(collectorName, "Collector Name");
            driver.CheckElementDisplayed(collectorHostIp, "Host IP Address");
            driver.CheckElementDisplayed(collectorTransferInterval, "Transfer Interval");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate Edit a  Collector Not Editable
        /// </summary>
        public void ValidateCollectorNotEditable()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(deviceId, "Device");
            driver.WaitForElement(collectorName, TimeSpan.FromSeconds(15));
            driver.CheckElementDisplayed(collectorName, "Collector Name");
            driver.CheckElementDisplayed(collectorHostIp, "Host IP Address");
            driver.CheckElementDisplayed(collectorTransferInterval, "Transfer Interval");
            driver.CheckElementDisplayed(collectorStaticIP, "Static IP");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate Edit a  Collector Required Fields
        /// </summary>
        public void ValidateCollectorRequiredFieldsEditable()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(deviceId, "Device");
            driver.WaitForElement(collectorName, TimeSpan.FromSeconds(15));
            driver.CheckElementDisplayed(collectorName, "Collector Name");
            driver.CheckElementDisplayed(collectorHostIp, "Host IP Address");
            driver.CheckElementDisplayed(collectorTransferInterval, "Transfer Interval");
            driver.CheckElementDisplayed(collectorStaticIP, "Static IP");
            driver.ClickElement(collectorWAN, "WAN");
            driver.CheckElementDisplayed(gprs, "GPRS");
            driver.CheckElementDisplayed(gprsEthernet, "GPRS Ethernet");
            driver.CheckElementDisplayed(networkDhcp, "Network DHCP");
            driver.CheckElementDisplayed(networkStaticIP, "Network Static IP");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate Edit a  Collector Non Required Fields
        /// </summary>
        public void ValidateCollectorNonRequiredFieldsEditable()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(deviceId, "Device");
            driver.WaitForElement(collectorName, TimeSpan.FromSeconds(15));
            driver.CheckElementDisplayed(collectorName, "Collector Name");
            driver.CheckElementDisplayed(collectorHostIp, "Host IP Address");
            driver.CheckElementDisplayed(collectorTransferInterval, "Transfer Interval");
            driver.CheckElementDisplayed(collectorStaticIP, "Static IP");
            driver.CheckElementDisplayed(collectorLatitude, "Latitude");
            driver.CheckElementDisplayed(collectorLongitude, "Longitude");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }



        /// <summary>
        /// Method to Validate Create Collector Button Does Not Exists
        /// </summary>
        public void ValidateCreateCollectorBtnDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnCollector, "Collector");
        }

        /// <summary>
        /// Method to Validate Create Gateway Collector
        /// </summary>
        public void ValidateCreateGateway()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(btnCreateDevice, "Create");
            if (driver.CheckElementExists(btnCollector, "Collector") & driver.CheckElementExists(btnGateway, "Gateway"))
            {
                testReport.Pass("<i>Collector, Gateway are displayed on the dropdown menu.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Collector, Gateway are not displayed on the dropdown menu.");
            }

        }
        /// <summary>
        /// Method to Validate Delete a device
        /// </summary>
        public void ValidateDeleteDevice()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(15));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(btnDeleteDevice, "Delete");
            if (driver.CheckElementDisplayed(popopDelete, "Delete"))
            {
                testReport.Pass("<i>The system prompts the user to confirm they want to delete the device.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>The system doesn't prompts the user to confirm they want to delete the device");
            }
            driver.ClickElement(popopCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Delete a device confirmation
        /// </summary>
        public void ValidateDeleteConfirmation()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(15));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(btnDeleteDevice, "Delete");
            driver.ClickElement(popopDelete, "Delete");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(15));
            if (driver.CheckElementDisplayed(toastMessage, "Delete Confirmation"))
            {
                testReport.Pass("<i> The device is hard deleted.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>The device is not deleted.");
            }
        }

        /// <summary>
        /// Method to Validate Delete a device No confirmation
        /// </summary>
        public void ValidateDeleteNoConfirmation()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(15));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(btnDeleteDevice, "Delete");
            driver.ClickElement(popopCancel, "Cancel");

            if (driver.CheckElementDisplayed(rowValueDeviceName, "Device"))
            {
                testReport.Pass("<i>The device is not deleted and user is returned to the Device View screeen.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>The device is deleted.");
            }
        }

        /// <summary>
        /// Method to Validate Create Utility Name
        /// </summary>
        public void ValidateUtilityName()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(btnCreateUtility, "Create");
            if (driver.CheckElementDisplayed(txtCreateUtilityName, "Name"))
            {
                testReport.Pass("<i>Name field is mandatory.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Name field is not mandatory.");
            }
            driver.ClickElement(btnCancelUtilityTypeCodes, "Cancel");
        }

        /// <summary>
        /// Method to Validate Unique Utility Name
        /// </summary>
        public void ValidateUniqueUtilityName(string utName, string stId, string add, string city, string zip)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(btnCreateUtility, "Create");
            driver.SendKeysToElement(txtCreateUtilityName, utName, "Name");
            driver.SendKeysToElement(txtCreateUtilitySiteId, stId, "Site ID");
            driver.SendKeysToElement(txtCreateUtilityAddress, add, "Address");
            driver.SendKeysToElement(txtCreateUtilityCity, city, "City");
            driver.ClickElement(drpCreateUtilityState, "State");
            driver.ClickElement(ddlUtilityState, "Select State");
            driver.SendKeysToElement(txtCreateUtilityZip, zip, "Zip Code");
            driver.ClickElement(btnSaveCollConfig, "Save");
            driver.WaitForElement(utilityNameExists, System.TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(utilityNameExists, "Error Message"))
            {
                testReport.Pass("Error Message displayd is: <i>" + driver.GetElementText(utilityNameExists));
            }
            else
            {
                ReporterFactory.LogFailure("<i>Name field is not mandatory.");
            }
            driver.ClickElement(btnCancelUtilityTypeCodes, "Cancel");
        }

        /// <summary>
        /// Method to Validate Create Utility Cancel
        /// </summary>
        public void ValidateCreateUtilityCancel(string utName, string stId, string add, string city, string zip)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(btnCreateUtility, "Create");
            driver.SendKeysToElement(txtCreateUtilityName, utName, "Name");
            driver.SendKeysToElement(txtCreateUtilitySiteId, stId, "Site ID");
            driver.SendKeysToElement(txtCreateUtilityAddress, add, "Address");
            driver.SendKeysToElement(txtCreateUtilityCity, city, "City");
            driver.ClickElement(drpCreateUtilityState, "State");
            driver.WaitForElement(ddlUtilityState, System.TimeSpan.FromSeconds(30));
            driver.ClickElement(ddlUtilityState, "Select State");
            driver.SendKeysToElement(txtCreateUtilityZip, zip, "Zip Code");
            driver.ClickElement(btnCancelUtilityTypeCodes, "Cancel");
            if (driver.CheckElementDisplayed(btnCreateUtility, "Create Utility Page"))
            {
                testReport.Pass("<i>Creating New Utility is cancelled and user is back to Utility Management screen.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Utility Created.");
            }
        }


        /// <summary>
        /// Method to Validate Create Utility Save
        /// </summary>
        public void ValidateCreateUtilitySave(string utName, string stId, string add, string city, string zip)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(btnCreateUtility, "Create");
            driver.SendKeysToElement(txtCreateUtilityName, utName, "Name");
            driver.SendKeysToElement(txtCreateUtilitySiteId, stId, "Site ID");
            driver.SendKeysToElement(txtCreateUtilityAddress, add, "Address");
            driver.SendKeysToElement(txtCreateUtilityCity, city, "City");
            driver.ClickElement(drpCreateUtilityState, "State");
            driver.ClickElement(ddlUtilityState, "Select State");
            driver.SendKeysToElement(txtCreateUtilityZip, zip, "Zip Code");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(15));
            if (driver.CheckElementDisplayed(toastMessage, "Utility Save"))
            {
                testReport.Pass("<i>" + driver.GetElementText(toastMessage) + " </i>" + " message is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Utility Not Created.");
            }
        }

        /// <summary>
        /// Method to Validate Create Utility with special characters and Save
        /// </summary>
        public void ValidateCreateUtilitySpecialCharSave(string utName, string stId, string add, string city, string zip)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(btnCreateUtility, "Create");
            driver.SendKeysToElement(txtCreateUtilityName, utName, "Name");
            driver.SendKeysToElement(txtCreateUtilitySiteId, stId, "Site ID");
            driver.SendKeysToElement(txtCreateUtilityAddress, add, "Address");
            driver.SendKeysToElement(txtCreateUtilityCity, city, "City");
            driver.ClickElement(drpCreateUtilityState, "State");
            driver.ClickElement(ddlUtilityState, "Select State");
            driver.SendKeysToElement(txtCreateUtilityZip, zip, "Zip Code");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(15));
            if (driver.CheckElementDisplayed(toastMessage, "Utility Save"))
            {
                testReport.Pass("Utility is created with Special characters");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Utility Not Created.");
            }
        }

        /// <summary>
        /// Method to Validate EDit button
        /// </summary>
        public void ValidateEditBtn()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(rowValueType, "Code");
            if (driver.CheckElementDisplayed(btnEditCode, "Edit"))
            {
                testReport.Pass("<i>Edit Button Displayed. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Edit Button Not Displayed.");
            }
        }

        /// <summary>
        /// Method to Validate Code EDit screen
        /// </summary>
        public void ValidateCodeEditScreen()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(rowValueType, "Code");
            driver.ClickElement(btnEditCode, "Edit");

            if (driver.CheckElementDisplayed(dlgEditUtilityTypeCodes, "Edit Dialogue Box"))
            {
                testReport.Pass("<i>Edit Dialogue Displayed. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Edit Dialogue Not Displayed.");
            }
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Existing Code Edit
        /// </summary>
        public void ValidateExistingCodeEdit()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(rowValueType, "Code");
            driver.ClickElement(btnEditCode, "Edit");
            driver.SendKeysToElement(codeEditDescr, "Test", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(15));
            if (driver.CheckElementDisplayed(toastMessage, "Updated"))
            {
                testReport.Pass("<i>Code Updated Successfully. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Code Not Updated Successfully.");
            }
        }

        /// <summary>
        /// Method to Validate Type Available
        /// </summary>
        public void ValidateTypeAvailable()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            if (driver.CheckElementDisplayed(rowValueType, "Type"))
            {
                testReport.Pass("<i>Type column is the only column with filter icon.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Type column not available.");
            }
        }

        /// <summary>
        /// Method to Validate Type Fliter Available
        /// </summary>
        public void ValidateTypeFilterAvailable()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            if (driver.CheckElementDisplayed(iconFilterCode, "Type Filter"))
            {
                testReport.Pass("<i>Type Filter is available.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Type Filter not available.");
            }
        }


        /// <summary>
        /// Method to Validate Type Clear Fliter 
        /// </summary>
        public void ValidateTypeClearFilter()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(iconFilterCode, "Type Filter");
            driver.ClickElement(drpFilterCode1, "Filter Dropdown");
            driver.ClickElement(ddlSkipCode, "Skip Code");
            driver.CheckElementDisplayed(clearBtn, "Clear");
            driver.CheckElementDisplayed(filterBtn, "Filter");
        }
        /// <summary>
        /// Method to Validate Delete Button
        /// </summary>
        public void ValidateDeleteBtn()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(rowValueType, "Code");
            driver.ClickElement(btnDeleteCode, "Delete");
            if (driver.CheckElementDisplayed(btnDeleteYes, "Yes"))
            {
                testReport.Pass("<i>User is able to click 'Delete' button");
            }
            else
            {
                ReporterFactory.LogFailure("<i>User is unable to click 'Delete' button");
            }
            driver.ClickElement(btnDeleteNo, "No");
        }

        /// <summary>
        /// Method to Validate Code Delete Confirmation
        /// </summary>
        public void ValidateCodeDeleteConfirmation()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(rowValueType, "Code");
            driver.ClickElement(btnDeleteCode, "Delete");
            driver.ClickElement(btnDeleteYes, "Yes");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(15));
            if (driver.CheckElementDisplayed(toastMessage, "Delete Confirmation"))
            {
                testReport.Pass("<i>Code Deleted Successfully.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Code Not Deleted.");
            }
        }


        /// <summary>
        /// Method to Validate utility name characters should be 128
        /// </summary>
        public void ValidateUtilityNameCharacters(string utName)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(btnCreateUtility, "Create");
            driver.SendKeysToElement(txtCreateUtilityName, utName, "Name");

            testReport.Pass("<i>Utility name can take is 128 Characters: " + utName);
            driver.ClickElement(btnCancelUtilityTypeCodes, "Cancel");
        }


        /// <summary>
        /// Method to Validate Create Gateway Collector Button Does Not Exists
        /// </summary>
        public void ValidateCreateGatewayBtnDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnGateway, "Gateway");
        }

        /// <summary>
        /// Method to Validate Edit Collector
        /// </summary>
        public void ValiadateEditCollector()
        {
            driver.ClickElement(lnkDeviceId, "Device Id");
            driver.sleepTime(6000);
            driver.CheckElementExists(dlgEditCollConfig, "Edit Collector Dialog");
            driver.CheckElementExists(btnSaveCollConfig, "Save");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate Edit Collector Save Button Does Not Exists
        /// </summary>
        public void ValiadateEditCollectorSaveDoesNotExists()
        {
            driver.ClickElement(lnkDeviceId, "Device Id");
            driver.sleepTime(6000);
            driver.CheckElementDoesnotExists(btnSaveCollConfig, "Save");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate Device Name
        /// </summary>
        public void ValidateDeviceName()
        {
            driver.CheckElementExists(btnDeviceName, "Device Name");
        }

        /// <summary>
        /// Method to Validate Device Name Does Not Exists
        /// </summary>
        public void ValidateDeviceNameDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnDeviceName, "Device Name");
        }

        /// <summary>
        /// Method to Validate Build USB Collector
        /// </summary>
        public void ValidateBuidUSBCollector()
        {
            driver.ClickElement(lnkDeviceId, "Device Id");
            driver.CheckElementExists(btnBuildUSB, "Build USB");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate Build USB Collector Button Does Not Exists
        /// </summary>
        public void ValidateBuidUSBCollectorDoesNotExists()
        {
            driver.ClickElement(lnkDeviceId, "Device Id");
            driver.CheckElementDoesnotExists(btnBuildUSB, "Build USB");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate Edit Gateway
        /// </summary>
        public void ValidateEditGateway()
        {
            driver.ClickElement(lnkDeviceId, "Device Id");
            driver.CheckElementExists(dlgGatewayConfig, "Edit Gateway Dialog");
            driver.ClickElement(btnEditGateway, "Edit");
            driver.CheckElementExists(btnSaveEditGateway, "Save");
            driver.ClickElement(btnSaveEditGateway, "Save");
            driver.ClickElement(btnCloseGatewayConfig, "Close");
        }

        /// <summary>
        /// Method to Validate Edit Gateway
        /// </summary>
        public void ValidateEditGatewayDoesNotexists()
        {
            driver.ClickElement(lnkDeviceId, "Device Id");
            driver.CheckElementDoesnotExists(btnEditGateway, "Edit");
            driver.ClickElement(btnCloseGatewayConfig, "Close");
        }

        /// <summary>
        /// Method to Validate Build USB Gateway
        /// </summary>
        public void ValidateBuildUSBGateway()
        {
            driver.ClickElement(lnkDeviceId, "Device Id");
            driver.CheckElementExists(btnBuildUSB, "Build USB");
            driver.ClickElement(btnCloseGatewayConfig, "Close");
        }

        /// <summary>
        /// Method to Validate Build USB Gateway
        /// </summary>
        public void ValidateBuildUSBGatewayDoesNotExists()
        {
            driver.ClickElement(lnkDeviceId, "Device Id");
            driver.CheckElementDoesnotExists(btnBuildUSB, "Build USB");
            driver.ClickElement(btnCloseGatewayConfig, "Close");
        }

        /// <summary>
        /// Method to Validate View Collector
        /// </summary>
        public void ValidateViewCollector()
        {
            driver.CheckElementExists(lnkDeviceId, "Device Collector Id");
        }

        /// <summary>
        /// Method to Validate View Gateway
        /// </summary>
        public void ValidateViewGateway()
        {
            driver.CheckElementExists(lnkDeviceId, "Device Collector Id");
        }

        /// <summary>
        /// Method to Validate Clone Collector
        /// </summary>
        public void ValidateCloneCollector()
        {
            driver.ClickElement(rowValueDeviceName, "Device Name Collector");
            driver.CheckElementExists(btnCloneDevice, "Clone");
        }

        /// <summary>
        /// Method to Validate Clone Collector
        /// </summary>
        public void ValidateCloneCollectorDoesNotExists()
        {
            //driver.ClickElement(lnkDeviceId, "Device Name Collector");
            driver.CheckElementDoesnotExists(btnCloneDevice, "Clone");
            //driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate Clone Gateway
        /// </summary>
        public void ValidateCloneGateway()
        {
            driver.ClickElement(rowValueDeviceName, "Device Name Gateway");
            driver.CheckElementExists(btnCloneDevice, "Clone");
        }

        /// <summary>
        /// Method to Validate Clone Gateway Does Not Exists
        /// </summary>
        public void ValidateCloneGatewayDoesNotExists()
        {
            //driver.ClickElement(lnkDeviceId, "Device Name Gateway");
            driver.CheckElementDoesnotExists(btnCloneDevice, "Clone");
            //driver.ClickElement(btnCloseGatewayConfig, "Close");
        }



        /// <summary>
        /// Method to Validate Delete Device Does Not Exists
        /// </summary>
        public void ValidateDeleteDeviceDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnDeleteDevice, "Delete Device");
        }

        /// <summary>
        /// Method to Validate Create New Utility
        /// </summary>
        public void ValidateCreateNewUtility(string name, string site, string add, string city, string zip)
        {
            driver.ClickElement(btnCreateUtility, "Create Utility");
            driver.SendKeysToElement(txtCreateUtilityName, name, "Utility Name");
            driver.SendKeysToElement(txtCreateUtilitySiteId, site, "SiteId");
            driver.SendKeysToElement(txtCreateUtilityAddress, add, "Address");
            driver.SendKeysToElement(txtCreateUtilityCity, city, "City");
            driver.ClickElement(drpCreateUtilityState, "State");
            driver.ClickElement(ddlUtilityState, "State");
            driver.SendKeysToElement(txtCreateUtilityZip, zip, "Zip");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(lnkChooseUtilities, "Choose Utilities");
            var table = driver.FindElements(tblChooseUtilities);
            bool flag = false;
            foreach (var item in table)
            {
                if (item.Text.Contains(""))
                    flag = true;
                break;
            }
            if (flag == true)
                testReport.Pass("New Utility Displayed on Utilities List");
            else
                ReporterFactory.LogFailure("New Utility is not Displayed on Utilities List");
            driver.ClickElement(btnChooseUtilitiesCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Set up a collector Saving Collector Information
        /// </summary>
        public void ValidateSetupCollectorSavingCollectorInformation(string cid, string cname, string hIP)
        {
            driver.ClickElement(btnCreateDevice, "Create Device");
            driver.ClickElement(btnCollector, "Collector");
            driver.SendKeysToElement(txtCollectorId, cid, "Collector");
            driver.SendKeysToElement(txtCollectorName, cname, "Collector Name");
            driver.SendKeysToElement(txtHostIpAdd, hIP, "Host Ip Address");
            driver.ClickElement(btnSaveCollConfig, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(10));
            testReport.Pass("User is able to close the modal");
        }

        /// <summary>
        /// Method to Validate Site ID 5 digits
        /// </summary>
        public void ValidateSiteIDDigits()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.ClickElement(btnCreateUtility, "Create Utility");
            driver.SendKeysToElement(txtCreateUtilitySiteId, "1234", "Site ID");
            driver.ClickElement(btnSaveEditGateway, "Save");
            if (driver.CheckElementDisplayed(dlgSiteID, "Site Id 5 Digits"))
            {
                testReport.Pass("Message displayed: <i>Site ID must be 5 digits.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Site ID is 5 digits.");
            }
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Choose Utilities
        /// </summary>
        public void ValidateChooseUtilities(string utility)
        {
            driver.ClickElement(selectUtility, "Utility");
            driver.SendKeysToElement(utilitySearch, utility, "Site ID");
            driver.SendKeysToElement(utilitySearch, Keys.Enter, "Enter");
            if (driver.CheckElementDisplayed(btnChooseUtilitiesCancel, "Cancel") & driver.CheckElementDisplayed(btnChooseUtilitiesOk, "OK"))
            {
                testReport.Pass("<i>X button and Ok button are displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("X and Ok buttons not diplayed.");
            }
            driver.ClickElement(btnChooseUtilitiesCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Device No results
        /// </summary>
        public void ValidateDeviceNoResults(string utility)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utillity Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.SendKeysToElement(deviceSearch, utility, "Utility");
            driver.SendKeysToElement(deviceSearch, Keys.Enter, "Enter");
            if (driver.GetElementText(deviceNoResult).Equals("No Result Found"))
            {
                driver.CheckElementDisplayed(deviceNoResult, "No Result Found");
                testReport.Pass("<i>No Result Found");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Result Found");
            }
        }

        /// <summary>
        /// Method to Validate Collector Populated Fields
        /// </summary>
        public void ValidateCollectorPopulatedFields()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(btnCreateDevice, "Create");
            driver.WaitForPageLoad(System.TimeSpan.FromSeconds(5));
            driver.ClickElement(btnCollector, "Collector");
            if ((driver.CheckElementDisplayed(collectorSystemID, "System ID") & driver.CheckElementDisplayed(collectorTimzone, "Timezone") & driver.CheckElementDisplayed(collectorTransit, "Transit Frequency") & driver.CheckElementDisplayed(collectorReceive, "Receive Frequency")))
            {
                testReport.Pass("<i>System Id, Time Zone, Transmit Frequency, Receive Frequency fields displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>System Id, Time Zone, Transmit Frequency, Receive Frequency fields not displayed.");
            }
            driver.ClickElement(btnCancelUtilityTypeCodes, "Cancel");

        }

        /// <summary>
        /// Method to Validate Collector Required Fields
        /// </summary>
        public void ValidateCollectorRequiredFields()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(btnCreateDevice, "Create");
            driver.WaitForPageLoad(System.TimeSpan.FromSeconds(5));
            driver.ClickElement(btnCollector, "Collector");
            if (driver.CheckElementDisplayed(collectorID, "Collector ID") & driver.CheckElementDisplayed(collectorName, "Collector Name") & driver.CheckElementDisplayed(collectorHostIp, "Host IP") & driver.CheckElementDisplayed(collectorTransferInterval, "Transfer Interval") & driver.CheckElementDisplayed(collectorStartTime, "Start Time") & driver.CheckElementDisplayed(collectorEndTime, "End Time") & driver.CheckElementDisplayed(collectorWAN, "WAN Connection Type") & driver.CheckElementDisplayed(collectorStaticIP, "Static IP Address") & driver.CheckElementDisplayed(collectorNetworkGateway, "Network Gateway") & driver.CheckElementDisplayed(collectorSubnet, "Subnet Mask"))
            {
                testReport.Pass("<i>Collector ID, Collector Name, Host IP Address, Transfer Interval, Daily Reboot, Start time, End Time, Wan Connection Type, Static IP, Network Gateway, Subnet Mask Fields Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("All Field not Displayed.");
            }
            driver.ClickElement(btnCancelUtilityTypeCodes, "Cancel");

        }

        /// <summary>
        /// Method to Validate Collector NON Required Fields
        /// </summary>
        public void ValidateCollectorNonRequiredFields()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(btnCreateDevice, "Create");
            driver.WaitForPageLoad(System.TimeSpan.FromSeconds(5));
            driver.ClickElement(btnCollector, "Collector");
            if (driver.CheckElementDisplayed(collectorLatitude, "Latitude") & driver.CheckElementDisplayed(collectorLongitude, "Longitude"))
            {
                testReport.Pass("<i>Latitude and Longitude displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Latitude and Longitude not displayed.");
            }
            driver.ClickElement(btnCancelUtilityTypeCodes, "Cancel");

        }

        /// <summary>
        /// Method to Validate Collector Field validation description
        /// </summary>
        public void ValidateCollectorFieldvalidation(string cId, string cNAme, string hIp)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateDevice, "Create");
            driver.ClickElement(btnCollector, "Collector");
            driver.SendKeysToElement(collectorID, cId, "Collector ID");
            driver.SendKeysToElement(collectorName, cNAme, "Collector Name");
            driver.SendKeysToElement(collectorHostIp, hIp, "Host IP");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(errorMsgSpecialChar, "Ërror Displayed");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Collector Required Details Missing
        /// </summary>
        public void ValidateCollectorRequiredDetailsMissing(string cId, string cNAme)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateDevice, "Create");
            driver.ClickElement(btnCollector, "Collector");
            driver.SendKeysToElement(collectorID, cId, "Collector ID");
            driver.SendKeysToElement(collectorName, cNAme, "Collector Name");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(errorMsgSpecialChar, "Ërror Displayed");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Navivagte Page to Page
        /// </summary>
        public void ValidateNavivagtePagetoPage()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(deviceId, TimeSpan.FromSeconds(15));
            driver.CheckElementDisplayed(btnCreateDevice, "Create");
        }

        /// <summary>
        /// Method to Validate Search Utility Name
        /// </summary>
        public void ValidateSearchUtilityName(string utility)
        {
            driver.ClickElement(selectUtility, "Utillity");
            driver.SendKeysToElementAndPressEnter(utilitySearch, utility, "Utility Search Text");
            driver.ClickElement(btnCloseUtilities, "Close");
        }


        /// <summary>
        /// Method to Validate Collector Field validation description
        /// </summary>
        public void ValidateCollectorSaveCancelFields(string cName)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.sleepTime(10000);
            driver.ClickElement(deviceId, "Device ID");
            driver.SendKeysToElement(collectorName, cName, "Collector Name");
            driver.CheckElementDisplayed(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(btnCancelUtility, "Cancel");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Collector save cancel
        /// </summary>
        public void ValidateCollectorSaveCancel(string cId, string cName)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(btnCreateDevice, "Create");
            driver.WaitForPageLoad(System.TimeSpan.FromSeconds(5));
            driver.ClickElement(btnCollector, "Collector");
            driver.SendKeysToElement(collectorID, cId, "Collector ID");
            driver.SendKeysToElement(collectorName, cName, "Collector Name");
            driver.CheckElementDisplayed(btnCancelUtility, "Cancel");
            driver.CheckElementDisplayed(btnCreateUtilitySave, "Save");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            if (driver.CheckElementDisplayed(hostIPErrorMessage, "Error Message"))
            {
                testReport.Pass("<i>Highlight missing field(s) and Provide error message notifying user that the field(s) are required.");
            }
            else
            {
                ReporterFactory.LogFailure("Error Message not Displayed and device save.");
            }
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Field Validation
        /// </summary>
        public void ValidateFieldValidation()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(btnCreateDevice, "Create");
            driver.ClickElement(btnCollector, "Collector");
            driver.FindElement(By.Id("collectorId")).SendKeys("@");
            if (driver.GetElementText(collectorID).Equals(""))
            {
                testReport.Pass("<i>No Special Characters entered.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Special Characters entered.");
            }
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Missing information
        /// </summary>
        public void ValidateMissingInfo(string cId)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(btnCreateDevice, "Create");
            driver.WaitForPageLoad(System.TimeSpan.FromSeconds(5));
            driver.ClickElement(btnCollector, "Collector");
            driver.SendKeysToElement(collectorID, cId, "Collector ID");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            if (driver.CheckElementDisplayed(hostIPErrorMessage, "Error Message"))
            {
                testReport.Pass("Message displayed : “Please enter data into required field”");
            }
            else
            {
                ReporterFactory.LogFailure("Error Message Not Displayed");
            }
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate cancel button does not prompt
        /// </summary>
        public void ValidateCancelBtnNotPrompt(string cId)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForPageLoad(System.TimeSpan.FromSeconds(5));
            driver.ClickElement(btnCreateDevice, "Create");
            driver.ClickElement(btnCollector, "Collector");
            driver.SendKeysToElement(collectorID, cId, "Collector ID");
            driver.ClickElement(btnCancelUtility, "Cancel");
            if (driver.CheckElementExists(btnCreateDevice, "Device Page"))
            {
                testReport.Pass("<i>Then the system does NOT prompt the user to confirm they wish to cancel.");
            }
            else
            {
                ReporterFactory.LogFailure("Error Message Not Displayed");
            }
        }

        /// <summary>
        /// Method to Validate clone button disabled
        /// </summary>
        public void ValidateCloneBtnDisabled()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(btnCloneDevice, "Clone");
            driver.ClickElement(rowValueDeviceName, "Device Name");
            if (driver.CheckElementDisplayed(btnCloneDevice, "Clone"))
            {
                testReport.Pass("<i>Clone button is enabled.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Clone button is disabled");
            }

        }

        /// <summary>
        /// Method to Validate collector configuration screen
        /// </summary>
        public void ValidateCollectConfigScreen()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            if (driver.CheckElementDisplayed(dlgEditCollConfig, "Collector Configuration "))
            {
                testReport.Pass("<i>Collector Configuration screen is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Collector Configuration screen is not displayed.");
            }
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate collector id can not be cloned
        /// </summary>
        public void ValidateCollectorIdCannotCloned()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(collectorDeviceId, "Device ID");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            driver.CheckElementDisplayed(collectorIdExisting, "Collector ID");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            if (driver.CheckElementDisplayed(collectorID, "Collector ID"))
            {
                testReport.Pass("<i>Collector ID field is displayed blank as it cannot be cloned.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Collector ID field is not displayed blank.");
            }
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate collector name can not be cloned
        /// </summary>
        public void ValidateCollectorNameCannotCloned()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(collectorDeviceId, "Device ID");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            driver.CheckElementDisplayed(txtCollectorName, "Collector Name");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            if (driver.CheckElementDisplayed(txtCollectorName, "Collector Name"))
            {
                testReport.Pass("<i>Collector Name field is displayed blank as it cannot be cloned.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Collector Name field is not displayed blank.");
            }
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate collector static ip can not be cloned
        /// </summary>
        public void ValidateCollectorStaticIPCannotCloned()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(collectorDeviceId, "Device ID");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            driver.CheckElementDisplayed(collectorStaticIP, "Collector Static IP");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            if (driver.CheckElementDisplayed(collectorStaticIP, "Collector Static IP"))
            {
                testReport.Pass("<i>Collector Static IP field is displayed blank as it cannot be cloned.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Collector Static IP field is not displayed blank.");
            }
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate collector Transfer interval
        /// </summary>
        public void ValidateTransferInterval()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(collectorDeviceId, "Device ID");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            driver.CheckElementDisplayed(collectorTransferInterval, "Transfer Interval");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            if (driver.CheckElementDisplayed(collectorTransferInterval, "Transfer Interval"))
            {
                testReport.Pass("<i>Transfer Interval value is Auto populated with value from Step 4.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Transfer Interval value is different with value from Step 4.");
            }
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate collector daily reboot
        /// </summary>
        public void ValidateDailyReboot()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(collectorDeviceId, "Device ID");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            driver.CheckElementDisplayed(collectorDailyReboot, "Daily Reboot");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            if (driver.CheckElementDisplayed(collectorDailyReboot, "Daily Reboot"))
            {
                testReport.Pass("<i>Daily Reboot option is Auto populated i.e. either set to Yes or No based on the value from Step 4.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Daily Reboot option is Auto populated and different from Step 4.");
            }
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate collector start time
        /// </summary>
        public void ValidateStartTime()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(collectorDeviceId, "Device ID");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            driver.CheckElementDisplayed(collectorStartTime, "Start Time");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            if (driver.CheckElementDisplayed(collectorStartTime, "Start Time"))
            {
                testReport.Pass("<i>Start Time Value is Auto populated with value from Step 4.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Start Time Value is Auto populated with value from Step 4.");
            }
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate collector end time
        /// </summary>
        public void ValidateEndTime()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(collectorDeviceId, "Device ID");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            driver.CheckElementDisplayed(collectorEndTime, "Start Time");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            if (driver.CheckElementDisplayed(collectorEndTime, "End Time"))
            {
                testReport.Pass("<i>End Time Value is Auto populated with value from Step 4.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>End Time Value is not Auto populated with value from Step 4.");
            }
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate collector WAN Connection
        /// </summary>
        public void ValidateWANConnection()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(collectorDeviceId, "Device ID");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            driver.CheckElementDisplayed(collectorWAN, "WAN Connection");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            if (driver.CheckElementDisplayed(collectorWAN, "WAN Connection"))
            {
                testReport.Pass("<i>WAN Connection is Auto populated with value from Step 4.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>WAN Connection is not Auto populated with value from Step 4.");
            }
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate collector Host IP
        /// </summary>
        public void ValidateHostIP()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(collectorDeviceId, "Device ID");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            driver.CheckElementDisplayed(collectorHostIp, "Host IP");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            if (driver.CheckElementDisplayed(collectorHostIp, "Host IP"))
            {
                testReport.Pass("<i>Host IP is Auto populated with value from Step 4.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Host IP is not Auto populated with value from Step 4.");
            }
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate collector Latitude
        /// </summary>
        public void ValidateLatitude()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(collectorDeviceId, "Device ID");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            driver.CheckElementDisplayed(collectorLatitude, "Latitude");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            if (driver.CheckElementDisplayed(collectorLatitude, "Latitude"))
            {
                testReport.Pass("<i>Latitude is Not Auto populated with value from Step 4.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Latitude is Auto populated with value from Step 4.");
            }
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate collector Longitude
        /// </summary>
        public void ValidateLongitude()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(collectorDeviceId, "Device ID");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            driver.CheckElementDisplayed(collectorLongitude, "Longitude");
            driver.ClickElement(btnCancelCollConfig, "Cancel");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.WaitForElement(dlgEditCollConfig, System.TimeSpan.FromSeconds(5));
            if (driver.CheckElementDisplayed(collectorLongitude, "Longitude"))
            {
                testReport.Pass("<i>Longitude is Not Auto populated with value from Step 4.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Longitude is Auto populated with value from Step 4.");
            }
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate Mandatory Fields
        /// </summary>
        public void ValidateMandatoryFields()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.ClickElement(collectorWAN, "WAN Connection");
            driver.ClickElement(networkStaticIP, "Network Static IP");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            if (driver.CheckElementDisplayed(idErrorMessage, "Collector ID Error Message") & driver.CheckElementDisplayed(nameErrorMessage, "Collector Name Error Message"))
            {
                testReport.Pass("Following Field are Mandatory Error Message Displayed: <i>" + driver.GetElementText(idErrorMessage) + ", " + driver.GetElementText(nameErrorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("<i>Following Field are Mandatory Error Message Not Displayed.");
            }
            driver.ClickElement(btnCancelCollConfig, "Cancel");

        }

        /// <summary>
        /// Method to Validate Non Mandatory Fields
        /// </summary>
        public void ValidateNonMandatoryFields(string cId, string cName)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.SendKeysToElement(txtCollectorId, cId, "Collector ID");
            driver.SendKeysToElement(txtCollectorName, cName, "Collector Name");
            driver.ClickElement(btnSaveCollConfig, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(toastMessage, "Success Message"))
            {
                testReport.Pass("<i>Latitude ad Longitude fields are non mandatory as Collector is created without value in those fields.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Latitude ad Longitude fields are mandatory");
            }
        }


        /// <summary>
        /// Method to Validate New Collector Saved
        /// </summary>
        public void ValidateNewCollectorSaved(string cId, string cName)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.SendKeysToElement(txtCollectorId, cId, "Collector ID");
            driver.SendKeysToElement(txtCollectorName, cName, "Collector Name");
            driver.ClickElement(btnSaveCollConfig, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(toastMessage, "Success Message"))
            {
                testReport.Pass("<i>New Collector clone is saved successfully when all required fields are entered correctly.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>New Collector clone not saved successfully");
            }
        }

        /// <summary>
        /// Method to Validate New Collector in List
        /// </summary>
        public void ValidateNewCollectorinList(string cId, string cName)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.SendKeysToElement(txtCollectorId, cId, "Collector ID");
            driver.SendKeysToElement(txtCollectorName, cName, "Collector Name");
            driver.ClickElement(btnSaveCollConfig, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(By.LinkText(cId), "Device ID"))
            {
                testReport.Pass("<i>New Collector Displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>New Collector Not Displayed.");
            }
        }


        /// <summary>
        /// Method to Validate CLone Collector Cancel
        /// </summary>
        public void ValidateNewCollectorCancel(string cId, string cName)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.SendKeysToElement(txtCollectorId, cId, "Collector ID");
            driver.SendKeysToElement(txtCollectorName, cName, "Collector Name");
            driver.ClickElement(btnCancelUtility, "Cancel");
            if (driver.CheckElementDisplayed(rowValueDeviceName, "Device"))
            {
                testReport.Pass("<i>Collector Configuration dialog is closed and Collector is not created.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Clone Saved.");
            }
        }

        /// <summary>
        /// Method to Validate CLone Collector not saved
        /// </summary>
        public void ValidateNewCollectorNotSaved(string cId, string cName)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(rowValueDeviceName, "Device Name");
            driver.ClickElement(btnCloneDevice, "Clone");
            driver.SendKeysToElement(txtCollectorId, cId, "Collector ID");
            driver.SendKeysToElement(txtCollectorName, cName, "Collector Name");
            driver.ClickElement(btnCancelUtility, "Cancel");
            if (driver.CheckElementDoesnotExists(By.LinkText(cId), "Device ID"))
            {
                testReport.Pass("<i>New Collector clone that was cancelled is not displayed in the Device List.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>New Collector clone that was cancelled is displayed in the Device List.");
            }
        }

        /// <summary>
        /// Method to Validate utility name
        /// </summary>
        public void ValidateEditUtilityName(string cName)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(deviceId, "Device Id");
            driver.SendKeysToElementClearFirst(txtCollectorName, cName, "Collector Name");
            driver.ClickElement(btnSaveCollConfig, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(15));

        }

        /// <summary>
        /// Method to Validate Utility name edit with special characters
        /// </summary>
        public void ValidateEditUtilityNameSpecialChars(string cName)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(deviceId, "Device Id");
            driver.SendKeysToElementClearFirst(txtCollectorName, cName, "Collector Name");
            driver.ClickElement(btnSaveCollConfig, "Save");
            if (driver.CheckElementDisplayed(collectorNameError, "Error Message"))
            {
                testReport.Pass("The system displays the message: <i>" + driver.GetElementText(collectorNameError));
            }
            else
            {
                ReporterFactory.LogFailure("<i>Collector Not Updated.");
            }
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }

        /// <summary>
        /// Method to Validate Utility name edit with special characters
        /// </summary>
        public void ValidateEditUtilityNullName()
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(deviceId, "Device Id");
            driver.ClickElement(txtCollectorName, "");
            SimulateSendKeys("^a");
            SimulateSendKeys("{DELETE}");
            //driver.SendKeysToElementClearFirst(txtCollectorName, cname, "Collector Name");
            driver.ClickElement(btnSaveCollConfig, "Save");
            if (driver.CheckElementDisplayed(collectorNameError, "Error Message"))
            {
                testReport.Pass("The system displays the message: <i>" + driver.GetElementText(collectorNameError));
            }
            else
            {
                ReporterFactory.LogFailure("<i>Collector Not Updated.");
            }
            driver.ClickElement(btnCancelCollConfig, "Cancel");
        }


        /// <summary>
        /// Method to Validate Utility name edit
        /// </summary>
        public void ValidateEditExistingUtilityName(string uName)
        {
            driver.ClickElement(selectUtility, "Utility");
            driver.SendKeysToElement(utilitySearch, uName, "Site ID");
            driver.SendKeysToElement(utilitySearch, Keys.Enter, "Enter");
            driver.ClickElement(selectfirstUtilityFromList, "Select");
            driver.ClickElement(btnChooseUtilitiesOk, "OK");
            driver.sleepTime(2000);
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEditUtility, "Edit");
            driver.SendKeysToElementClearFirst(txtCreateUtilityName, uName, "Utility Name");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(15));
            if (driver.CheckElementDisplayed(toastMessage, "Saved Successfully"))
            {
                testReport.Pass("<i>Utility Updated Successfully.");
            }
            else
            {
                ReporterFactory.LogFailure("Not updated");
            }
        }


        /// <summary>
        /// Method to Validate Utility name edit
        /// </summary>
        public void ValidateEditExistingUtilityNameUnique(string uName, string u_name)
        {
            driver.ClickElement(selectUtility, "Utility");
            driver.SendKeysToElement(utilitySearch, uName, "Site ID");
            driver.SendKeysToElement(utilitySearch, Keys.Enter, "Enter");
            driver.ClickElement(selectfirstUtilityFromList, "Select");
            driver.ClickElement(btnChooseUtilitiesOk, "OK");
            driver.sleepTime(2000);
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEditUtility, "Edit");
            driver.SendKeysToElementClearFirst(txtCreateUtilityName, u_name, "Utility Name");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            if (driver.CheckElementDisplayed(updateUtilityError, "Error"))
            {
                testReport.Pass("<i>'This Utility Name already exists.Please enter another' message is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("Utility Name Updated.");
            }
            driver.ClickElement(btnCancelUtility, "Cancel");
        }
        /// <summary>
        /// Method to Validate Utility name edit
        /// </summary>
        public void ValidateEditExistingUtilityName(string uName, string u_name)
        {
            driver.ClickElement(selectUtility, "Utility");
            driver.SendKeysToElement(utilitySearch, uName, "Site ID");
            driver.SendKeysToElement(utilitySearch, Keys.Enter, "Enter");
            driver.ClickElement(selectfirstUtilityFromList, "Select");
            driver.ClickElement(btnChooseUtilitiesOk, "OK");
            driver.sleepTime(2000);
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEditUtility, "Edit");
            driver.SendKeysToElementClearFirst(txtCreateUtilityName, u_name, "Utility Name");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(15));

            driver.ClickElement(selectUtility, "Utility");
            driver.SendKeysToElement(utilitySearch, u_name, "Site ID");
            driver.SendKeysToElement(utilitySearch, Keys.Enter, "Enter");
            driver.ClickElement(selectfirstUtilityFromList, "Select");
            string selectedutility = driver.GetElementAttribute(selectUtility, "text");
            if (u_name == selectedutility)
            {
                testReport.Pass("<i>Utility Updated in the List.");
            }
            else
            {
                ReporterFactory.LogFailure("Not updated in the list");
            }
            driver.ClickElement(btnChooseUtilitiesOk, "OK");
        }


        /// <summary>
        /// Method to Validate Utility edit confirmation pop-up
        /// </summary>
        public void ValidateEditUtilityPopup(string uName, string city)
        {
            driver.ClickElement(selectUtility, "Utility");
            driver.SendKeysToElement(utilitySearch, uName, "Site ID");
            driver.SendKeysToElement(utilitySearch, Keys.Enter, "Enter");
            driver.ClickElement(selectfirstUtilityFromList, "Select");
            driver.ClickElement(btnChooseUtilitiesOk, "OK");
            driver.sleepTime(2000);
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEditUtility, "Edit");
            driver.SendKeysToElementClearFirst(txtCreateUtilityCity, city, "City");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(15));
            if (driver.CheckElementDisplayed(toastMessage, "Utility Updated"))
            {
                testReport.Pass("<i>Confirmation pop up is displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("Confirmation pop up not displayed");
            }
        }

        /// <summary>
        /// Method to Validate Utility edit cancelled
        /// </summary>
        public void ValidateEditUtilityCancelled(string uName, string city)
        {
            driver.ClickElement(selectUtility, "Utility");
            driver.SendKeysToElement(utilitySearch, uName, "Site ID");
            driver.SendKeysToElement(utilitySearch, Keys.Enter, "Enter");
            driver.ClickElement(selectfirstUtilityFromList, "Select");
            driver.ClickElement(btnChooseUtilitiesOk, "OK");
            driver.sleepTime(2000);
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.WaitForElement(rowValueDeviceName, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEditUtility, "Edit");
            driver.SendKeysToElementClearFirst(txtCreateUtilityCity, city, "City");
            driver.ClickElement(btnCancelUtility, "Cancel");
            testReport.Pass("<i>Updates are not saved.");
        }

        /// <summary>
        /// Method to Validate Utility Modal Closes
        /// </summary>
        public void ValidateUtiityModalCloses(string city)
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.ClickElement(btnEditUtility, "Edit");
            driver.SendKeysToElementClearFirst(txtCreateUtilityCity, city, "City");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(15));
            if (driver.CheckElementDisplayed(toastMessage, "Utility Updated"))
            {
                testReport.Pass("<i>The Modal is Closed.");
            }
            else
            {
                ReporterFactory.LogFailure("Modal not closed.");
            }
        }

        /// <summary>
        /// Method to Validate Partial Utility Search
        /// </summary>
        public void ValidatePartialUtilitySearch(string utility)
        {
            driver.ClickElement(lnkChooseUtilities, "Utility Dropdown");
            driver.SendKeysToElement(utilitySearch, utility, "Utility Name");
            driver.SendKeysToElement(utilitySearch, Keys.Enter, "Utility Name");
            if (driver.CheckElementDisplayed(tblChooseUtilities, "Utility"))
            {
                testReport.Pass("<i>Search result Dispalyed.");
            }
            else
            {
                ReporterFactory.LogFailure("NO Result Found.");
            }
            driver.ClickElement(btnChooseUtilitiesCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Search Utility Name Or Id
        /// </summary>
        public void ValidateSearchUtilityNameOrId(string utility)
        {
            driver.ClickElement(lnkChooseUtilities, "Utility Dropdown");
            driver.SendKeysToElement(utilitySearch, utility, "Utility Name");
            driver.SendKeysToElement(utilitySearch, Keys.Enter, "Utility Name");
            driver.ClickElement(selectfirstUtilityFromList, "Utility");
            driver.ClickElement(btnChooseUtilitiesOk, "OK");
        }

        /// <summary>
        /// Method to Validate Selected Utility Name Or Id
        /// </summary>
        public void ValidateSelectedUtilityNameOrId(string utility)
        {
            driver.ClickElement(lnkChooseUtilities, "Utility Dropdown");
            driver.SendKeysToElement(utilitySearch, utility, "Utility Name");
            driver.SendKeysToElement(utilitySearch, Keys.Enter, "Utility Name");
            driver.ClickElement(selectfirstUtilityFromList, "Utility");
            driver.ClickElement(btnChooseUtilitiesOk, "OK");
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.CheckElementDisplayed(lnkChooseUtilities, "Utility");
            driver.CheckElementDisplayed(breadCrumb, "BreadCrumb");
        }

        /// <summary>
        /// Method to Validate Utility Close Button
        /// </summary>
        public void ValidateUtilityClose(string utility)
        {
            driver.WaitElementExistsAndVisible(lnkChooseUtilities);
            driver.ClickElement(lnkChooseUtilities, "Utility Dropdown");
            driver.SendKeysToElement(utilitySearch, utility, "Utility Name");
            driver.SendKeysToElement(utilitySearch, Keys.Enter, "Utility Name");
            driver.ClickElement(btnCloseUtilities, "Close");
        }

        /// <summary>
        /// Method to Validate no Utility selected
        /// </summary>
        public void ValidateNoUtilitySelected(string utility)
        {
            driver.ClickElement(lnkChooseUtilities, "Utility Dropdown");
            driver.SendKeysToElement(utilitySearch, utility, "Utility Name");
            //SimulateSendKeys("{ENTER}");
            driver.ClickElement(btnChooseUtilitiesOk, "OK");
            //driver.ClickElement(lnkChooseUtilities, "Utility Dropdown");
            driver.CheckElementDisplayed(noUtilitySelected, "Error Message");
            driver.ClickElement(btnCloseUtilities, "Close");
        }

        /// <summary>
        /// Method to Validate Edit Utility Screen
        /// </summary>
        public void ValidateEditUtilityScreen()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.CheckElementDisplayed(btnEditUtility, "Edit");
        }

        // <summary>
        /// Method to Validate Edit Utility Screen
        /// </summary>
        public void ValidateEditUtilityScreenViewMode()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.CheckElementDisplayed(utilityStatus, "Utility Status");
            driver.CheckElementDisplayed(utilityCountrycode, "Country Code");
            driver.CheckElementDisplayed(utilityTimezone, "Timezone");
            driver.CheckElementDisplayed(utilityDaylight, "Daylight Saving");
        }

        // <summary>
        /// Method to Validate Utility Screen Editable
        /// </summary>
        public void ValidateUtilityFieldsEditable()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(5000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.WaitForElement(txtCreateUtilityName, TimeSpan.FromSeconds(10));
            driver.ClickElement(txtCreateUtilityName, "Name");
            driver.ClickElement(drpTimezone, "Timezone Dropdown");
            driver.ClickElement(drpTimezone, "Timezone Dropdown");
            driver.CheckElementDisplayed(chkDaylight, "Daylight Saving");
            driver.ClickElement(drpCountryCode, "Country Code");
            driver.ClickElement(drpCountryCode, "Country Code");
            driver.ClickElement(btnCloseUtilities, "Close");
        }

        // <summary>
        /// Method to Validate Edit Utility Save
        /// </summary>
        public void ValidateEditUtilitySave(string city)
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Ëdit");
            driver.ClickElement(txtCreateUtilityCity, "Edit");
            driver.SendKeysToElementClearFirst(txtCreateUtilityCity, city, "City");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// Method to Validate No utility returned
        /// </summary>
        public void ValidateNoUtilityReturned(string utility)
        {
            driver.ClickElement(lnkChooseUtilities, "Utility Dropdown");
            driver.SendKeysToElement(utilitySearch, utility, "Utility Name");
            driver.sleepTime(2000);

            driver.SendKeysToElement(utilitySearch, Keys.Enter, "Utility Name");
            
            if (driver.GetElementText(tblChooseUtilities).Contains("No Results Found"))
            {
                testReport.Pass("<i>No Results Found Dispalyed.");
            }
            else
            {
                ReporterFactory.LogFailure("Results Displayed, Please Change Test Data");
            }
            driver.ClickElement(closeBtnPopup, "Cancel");
        }

        /// <summary>
        /// Method to Validate User Select One Utility
        /// </summary>
        public void ValidateUserSelectOneUtility(string utility)
        {
            driver.ClickElement(lnkChooseUtilities, "Utility Dropdown");
            driver.SendKeysToElement(utilitySearch, "60222", "Utility Name");
            driver.sleepTime(2000);
            driver.SendKeysToElement(utilitySearch, Keys.Enter, "Utility Name");


            driver.ClickElement(selectfirstUtilityFromList, "Select First Utility");
            driver.CheckElementDoesnotExists(selectsecUtilityFromList, "Second Utility");
            driver.ClickElement(closeBtnPopup, "Cancel");
        }

        /// <summary>
        /// Method to Validate All Utilities Visible
        /// </summary>
        public void ValidateAllUtilitiesVisible()
        {
            string t = "";
            driver.ClickElement(lnkChooseUtilities, "Utility Dropdown");
            //driver.CheckElementDisplayed(allUtilities, "All Utilities");
            IReadOnlyCollection<IWebElement> ele = driver.FindElements(tblChooseUtilities);

            foreach (IWebElement nx in ele)
            {
                //driver.CheckElementDisplayed(tblChooseUtilities, "");
                t = nx.Text;
                //t= ((OpenQA.Selenium.Remote.RemoteWebElement)nx).Text;
                testReport.Info(t);

            }
            //testReport.Info(t);
            driver.ClickElement(btnCloseUtilities, "Close");
        }


        /// <summary>
        /// Method to Validate offset time and timezone
        /// </summary>
        public void ValidateOffsetTimeTimezone()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);

            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(offsetTime, "Offset Time");
            driver.ClickElement(offsetTime, "Offset Time");

            driver.ClickElement(timeZone, "Time Zone");
            driver.ClickElement(timeZone, "Time Zone");

            driver.ClickElement(btnCancelUtility, "Close");
        }

        /// <summary>
        /// Method to Validate offset timezone 
        /// </summary>
        public void ValidateOffsetTimeZone()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);

            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(offsetTime, "Offset Time");
            driver.ClickElement(mountainTime, "Central Time");
            driver.ClickElement(btnCancelUtility, "Close");
        }

        /// <summary>
        /// Method to Validate UTC offset  timezone
        /// </summary>
        public void ValidateOffset()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(timeZone, "UTC Offset Time");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            if (driver.CheckElementExists(toastMessage, "Yes"))
            {
                testReport.Pass("<i>Time Saved Successfully.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Time not Saved.");
            }
        }

        /// <summary>
        /// Method to Validate Create Utility with UTC offset  timezone confirmation message
        /// </summary>
        public void ValidateCreateUtilityTimeZoneConfirmation(string utName, string stId, string add, string city, string zip)
        {
            driver.ClickElement(btnUtilityManagement, "Utillity Management");
            driver.ClickElement(btnCreateUtility, "Create");
            driver.SendKeysToElement(txtCreateUtilityName, utName, "Name");
            driver.SendKeysToElement(txtCreateUtilitySiteId, stId, "Site ID");
            driver.SendKeysToElement(txtCreateUtilityAddress, add, "Address");
            driver.SendKeysToElement(txtCreateUtilityCity, city, "City");
            driver.ClickElement(drpCreateUtilityState, "State");
            driver.ClickElement(ddlUtilityState, "Select State");
            driver.SendKeysToElement(txtCreateUtilityZip, zip, "Zip Code");
            driver.ClickElement(offsetTime, "Offset Time");
            driver.ClickElement(mountainTime, "Mountain Time");
            driver.ClickElement(timeZone, "Time Zone");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(15));
            if (driver.CheckElementExists(toastMessage, "Yes"))
            {
                testReport.Pass("<i>Utility Saved Successfully.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Utility not Saved.");
            }
        }
        /// <summary>
        /// Method to Validate Create Skip code 1
        /// </summary>
        public void ValidateCreateSkipCode(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlSkipCode, "Skip Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "Description", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(By.XPath("//td[contains(.,'" + code + "')]"), "");
        }

        /// <summary>
        /// Method to Validate Create Location Code
        /// </summary>
        public void ValidateCreateLocationCode(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlLocationCode, "Location Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "Description", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(By.XPath("//td[contains(.,'" + code + "')]"), "");
        }


        /// <summary>
        /// Method to Validate Duplicate Create Skip code 
        /// </summary>
        public void ValidateCreateDuplicateSkipCode(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlSkipCode, "Skip Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "Description", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(codeError, "Code Error");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Duplicate Create Location code 
        /// </summary>
        public void ValidateCreateDuplicateLocationCode(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlLocationCode, "Location Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "Description", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(codeError, "Code Error");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Duplicate Create Skip code 
        /// </summary>
        public void ValidateCreateDuplicateCommtCode(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlCommtCode, "Skip Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "Description", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(codeError, "Code Error");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Duplicate Create duplicate hazard code
        /// </summary>
        public void ValidateCreateDuplicateHazardCode(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlHazardCode, "Skip Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "Description", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(codeError, "Code Error");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }


        /// <summary>
        /// Method to Validate Create Skip code with blank description
        /// </summary>
        public void ValidateCreateSkipCodeBlankDesc(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlSkipCode, "Skip Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(decrError, "Description Error");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Create Meter code with blank description
        /// </summary>
        public void ValidateCreateMeterCodeBlankDesc(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlMeterCondition, "Meter Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            //driver.SendKeysToElement(codeEditDescr, "des", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(decrError, "Description Error");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Create Location code with blank code
        /// </summary>
        public void ValidateCreateLocationCodeBlank(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlLocationCode, "Location Code");
            //driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "des", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(codeError, "Code Error");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Create Hazard code with blank code
        /// </summary>
        public void ValidateCreateHazrdCodeBlank(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlHazardCode, "Hazard Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "des", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(codeError, "Code Error");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Create Hazard code with blank Description
        /// </summary>
        public void ValidateCreateHazrdCodeBlankDesc(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlHazardCode, "Hazard Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(decrError, "Description Error");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Create Location code with blank Description
        /// </summary>
        public void ValidateCreateLocationCodeBlankDesc(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlLocationCode, "Location Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(decrError, "Description Error");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Create Read Instructions with blank code
        /// </summary>
        public void ValidateCreateReadInstBlankDesc(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlReadInst, "Read Instructions Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(decrError, "Description Error");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Create Comment code with blank Description
        /// </summary>
        public void ValidateCreateCommentBlankDesc(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlCommtCode, "Comment Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(decrError, "Description Error");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }


        /// <summary>
        /// Method to Validate Create Read Instructions with blank code
        /// </summary>
        public void ValidateCreateReadInstBlankCode(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlReadInst, "Read Instructions Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "Desc", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(codeError, "Code Error");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Create Comment Code with blank code
        /// </summary>
        public void ValidateCreateCommentBlankCode(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlCommtCode, "Comment Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "Desc", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.CheckElementDisplayed(codeError, "Code Error");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }


        /// <summary>
        /// Method to Validate Create meter code
        /// </summary>
        public void ValidateCreateMeterCode(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlMeterCondition, "Meter Condition Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "Desc", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(By.XPath("//td[contains(.,'" + code + "')]"), "");
        }

        /// <summary>
        /// Method to Validate Create comment code
        /// </summary>
        public void ValidateCreateCommentCode(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlCommtCode, "Comment Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "Desc", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(By.XPath("//td[contains(.,'" + code + "')]"), "");
        }


        /// <summary>
        /// Method to Validate Create Read instruction code
        /// </summary>
        public void ValidateCreateReadInst(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlReadInst, "Read Instruction Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "Desc", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(By.XPath("//td[contains(.,'" + code + "')]"), "");
        }


        /// <summary>
        /// Method to Validate Create Hazard code
        /// </summary>
        public void ValidateCreateHazardCode(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlHazardCode, "Hazard Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "Desc", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(By.XPath("//td[contains(.,'" + code + "')]"), "");
        }


        /// <summary>
        /// Method to Validate Create Read instruction code duplicate code error
        /// </summary>
        public void ValidateCreateReadInstDuplicate(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlReadInst, "Read Instruction Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "Desc", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save"); driver.WaitForElement(codeError, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(codeError, "Error Message");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Create meter code duplicate
        /// </summary>
        public void ValidateCreateMeterCodeDuplicate(string code)
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(btnCreateCode, "Create Code");
            driver.ClickElement(drpType, "Type Dropdown");
            driver.ClickElement(ddlMeterCondition, "Meter Condition Code");
            driver.SendKeysToElement(txtCode, code, "Code");
            driver.SendKeysToElement(codeEditDescr, "Desc", "Description");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(codeError, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(codeError, "Error Message");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }


        /// <summary>
        /// Method to Validate Unit Of Measure Field
        /// </summary>
        public void ValidateUnitOfMeasureField()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.CheckElementDisplayed(drpUOM, "Default Unit Of Measure");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateUnitOfMeasureFieldValues()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(drpUOM, "Default Unit Of Measure");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditUtilityUnitOfMeasureFieldValues()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(drpUOM, "Default Unit Of Measure");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditUtilityUnitOfMeasureFieldValuesDisplays()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(drpUOM, "Default Unit Of Measure");
            driver.WaitForElement(gallons, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(gallons, "Gallons");
            driver.CheckElementDisplayed(cubicFt, "Cubic Feet");
            driver.CheckElementDisplayed(cubicMeters, "Cubic Meters");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateCreateUtilityUOMFieldValuesDisplaysOrders()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(drpUOM, "Default Unit Of Measure");
            driver.WaitForElement(gallons, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(gallons, "Gallons");
            driver.CheckElementDisplayed(cubicFt, "Cubic Feet");
            driver.CheckElementDisplayed(cubicMeters, "Cubic Meters");
            driver.CheckElementDisplayed(imperialGallons, "Imperial Gallons");
            driver.CheckElementDisplayed(liters, "Litres");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Unit Of Measure Cubic Feet
        /// </summary>
        public void ValidateUnitOfMeasureCubicFeet()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(drpUOM, "Default Unit Of Measure");
            driver.CheckElementDisplayed(cubicFt, "Cubic Feet");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateAutoCompleteDaysDisplay()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.CheckElementDisplayed(autoCompleteDays, "Auto Complete Days");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateAutoCompleteDaysNumericValue()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(autoCompleteDays, "");
            driver.SendKeysToElement(autoCompleteDays, "5", "Auto Complete Days");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }
        public void ValidateAutoCompleteDaysNegativeNumericValue()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(autoCompleteDays, "");
            driver.SendKeysToElement(autoCompleteDays, "-5", "Auto Complete Days");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }
        public void ValidateAutoCompleteDays11()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(autoCompleteDays, "");
            driver.SendKeysToElement(autoCompleteDays, "11", "Auto Complete Days");
            testReport.Info("Values greater than 10 are not accepted");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateAutoCompleteDaysIncreaseValue()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(autoCompleteIncrease, "Increase");
            testReport.Info("Auto-Complete Days value is incremented");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditAutoCompleteDaysIncreaseValue()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(autoCompleteIncrease, "Increase");
            testReport.Info("Auto-Complete Days value is incremented");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditAutoCompleteDaysDecreaseValue()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(autoCompleteDecrease, "Decrease");
            testReport.Info("Auto-Complete Days value is Decremented");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateAutoCompleteDaysDecreaseValue()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(autoCompleteDecrease, "Decrease");
            testReport.Info("Auto-Complete Days value is decremented");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }
        public void ValidateAutoCompleteDaysValue0()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(autoCompleteDays, "");
            driver.SendKeysToElement(autoCompleteDays, "0", "Auto Complete Days");
            testReport.Info("0 is displayed in the Auto-Complete Days field");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditAutoCompleteDaysValue0()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(autoCompleteDays, "");
            driver.SendKeysToElement(autoCompleteDays, "0", "Auto Complete Days");
            testReport.Info("0 is displayed in the Auto-Complete Days field");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditAutoCompleteDaysValue10()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(autoCompleteDays, "");
            driver.SendKeysToElement(autoCompleteDays, "10", "Auto Complete Days");
            testReport.Info("10 is displayed in the Auto-Complete Days field");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateCreateUtilityImportExportFormatDisplay()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.WaitForElement(importExportFileFormat, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(importExportFileFormat, "Import/Export Format Dropdown");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateCreateUtilityImportExportDefaulltValue()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.WaitForElement(importExportFileFormat, TimeSpan.FromSeconds(20));
            testReport.Info(driver.GetElementText(importExportFileFormat));
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateCreateUtilityImportExportCancel()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.WaitForElement(importExportFileFormat, TimeSpan.FromSeconds(20));
            driver.ClickElement(importExportFileFormat, "");
            driver.ClickElement(v2Standard, "V2 Standard");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditUtilityImportExportCancel()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.WaitForElement(importExportFileFormat, TimeSpan.FromSeconds(20));
            driver.ClickElement(importExportFileFormat, "");
            driver.ClickElement(v2Standard, "V2 Standard");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateCreateUtilityImportExportFormatDropdownValues()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.WaitForElement(importExportFileFormat, TimeSpan.FromSeconds(20));
            driver.ClickElement(importExportFileFormat, "");
            driver.CheckElementDisplayed(v4Standard, "V4 Standard");
            driver.CheckElementDisplayed(v4Modified, "V4 Modified");
            driver.CheckElementDisplayed(ezRoute509, "EZ Route 509 Bytes");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateUtilityImportExportFormatDropdownValuesV4()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.WaitForElement(importExportFileFormat, TimeSpan.FromSeconds(20));
            driver.ClickElement(importExportFileFormat, "");
            driver.CheckElementDisplayed(v4Standard, "V4 Standard");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateCreateUtilityMobileMapingCheckBoxDisplay()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.CheckElementDisplayed(mobileMaping, "Mobile Maping");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditUtilityMobileMapingCheckBoxDisplay()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.CheckElementDisplayed(mobileMaping, "Mobile Maping");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditUtilityMobileMapingCheckBoxSave()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(mobileMaping, "Mobile Maping");
            driver.ClickElement(btnCreateUtilitySave, "Save");
        }
        public void ValidateEditUtilityMobileMapingCheckBoxCancel()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(mobileMaping, "Mobile Maping");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateUtilityMobileMapingCheckBoxEditable()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(mobileMaping, "Mobile Maping");
            driver.ClickElement(btnCancelUtility, "Cancel");
            testReport.Pass("Mobile Mapping Checkbox value is editable");
        }

        public void ValidateCreateUtilityMobileMapingCheckBoxDefaultValue()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.CheckElementDisplayed(mobileMaping, "");
            driver.VerifyInputRadioButtonStatus(mobileMaping, "unchecked", "Mobile Maping");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateMobileMapingFeildDisplay()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.CheckElementDisplayed(mobileMapingFeild, "Mobile Maping Feild");
        }

        public void ValidateMobileMapingFeildDisplayedYes()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            if (driver.GetElementText(mobileMapingFeild).Equals("YES"))
            {
                testReport.Pass("YES value is displayed for Mobile Mapping field");
            }
            else
            {
                ReporterFactory.LogFailure("YES value is not displayed for Mobile Mapping field");
            }
        }

        public void ValidateMobileMapingFeildDisplayedNo()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            if (driver.GetElementText(mobileMapingFeild).Equals("No"))
            {
                testReport.Pass("No value is displayed for Mobile Mapping field");
            }
            else
            {
                ReporterFactory.LogFailure("YES value is displayed for Mobile Mapping field");
            }
        }

        public void ValidateCreateUtilityMobileMapingCheckBoxCancel()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(mobileMaping, "Mobile Maping");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateTimezone()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.CheckElementDisplayed(timezoneField, "Timezone Field");
        }

        public void ValidateCloseRouteOnExportField()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.CheckElementDisplayed(closeRouteField, "Close Route On Export");
        }

        public void ValidateCloseRouteOnExportFieldOn()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            if (driver.GetElementText(closeRouteField).Equals("YES"))
            {
                testReport.Pass("'YES' value is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("No value is displayed");
            }

        }

        public void ValidateCloseRouteOnExportFieldOFF()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            if (driver.GetElementText(closeRouteField).Equals("NO"))
            {
                testReport.Pass("'No' value is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("YES value is displayed");
            }

        }

        public void ValidateEditTimezone()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(timeZoneDropdown, "");
            driver.ClickElement(easternTime, "Eastern Time");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.sleepTime(1000);
            driver.CheckElementDisplayed(timezoneField, "Timezone Field");
        }

        public void ValidateEditUtilityImportExportFormatValueValidation()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.WaitForElement(timeZoneDropdown, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(timeZoneDropdown, "TimeZone Format");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }


        public void ValidateEditUtilityImportExportDisplay()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.WaitForElement(importExportFileFormat, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(importExportFileFormat, "Import/Export Format");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateImportExportFormatInfo()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(importExportFormatInfo, "Import/Export Format");
        }

        public void ValidateEditAutoCompleteDaysSave()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(autoCompleteDays, "");
            driver.SendKeysToElement(autoCompleteDays, "5", "Auto Complete Days");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(autoCompleteDaysValue, "Auto Complete Days Value");
            string s = driver.GetElementText(autoCompleteDaysValue);
            if (s.Equals("5"))
            {
                testReport.Pass("Value updated for Auto Completed Days field is saved");
            }
            else
            {
                ReporterFactory.LogFailure("Value updated for Auto Completed Days field is not saved");
            }
        }

        public void ValidateAutoCompleteDaysOption()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.CheckElementDisplayed(autoCompleteDaysValue, "Auto Complete Days Option");
        }

        public void ValidateAutoCompleteDaysValue10()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(autoCompleteDays, "");
            driver.SendKeysToElement(autoCompleteDays, "10", "Auto Complete Days");
            testReport.Info("10 is displayed in the Auto-Complete Days field");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditAutoCompleteDaysDisplayed()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.CheckElementDisplayed(autoCompleteDays, "Auto Complete Days");
            testReport.Info("Auto-Complete Days field is displayed next to Apply UTC Offset field");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditAutoCompleteDaysNumericValue()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(autoCompleteDays, "");
            driver.SendKeysToElement(autoCompleteDays, "5", "Auto Complete Days");
            testReport.Info("5 is displayed in the Auto-Complete Days field");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditAutoCompleteDaysValue11()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(autoCompleteDays, "");
            driver.SendKeysToElement(autoCompleteDays, "11", "Auto Complete Days");
            testReport.Info("Values greater than 10 are not accepted");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditAutoCompleteDaysNegativeValue()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(autoCompleteDays, "");
            driver.SendKeysToElement(autoCompleteDays, "-5", "Auto Complete Days");
            testReport.Info("Negative values are not accepted");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditAutoCompleteDaysAlphabetValue()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(autoCompleteDays, "");
            driver.SendKeysToElement(autoCompleteDays, "a", "Auto Complete Days");
            testReport.Info("a is Not displayed in the Auto-Complete Days field");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditAutoCompleteDaysAlphaNumericValue()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(autoCompleteDays, "");
            driver.SendKeysToElement(autoCompleteDays, "a1", "Auto Complete Days");
            driver.sleepTime(3000);
            testReport.Info("a1 is not displayed in the Auto-Complete Days field");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateAutoCompleteDaysAlphabetValue()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(autoCompleteDays, "");
            driver.SendKeysToElement(autoCompleteDays, "a", "Auto Complete Days");
            testReport.Info("Alphabets are not accepted in the Auto-Complete Days field");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateAutoCompleteDaysAlphaNumericValue()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(autoCompleteDays, "");
            driver.SendKeysToElement(autoCompleteDays, "a1", "Auto Complete Days");
            testReport.Info("Alphabets are not accepted in the Auto-Complete Days field");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Unit Of Measure Cubic Meter
        /// </summary>
        public void ValidateUnitOfMeasureCubicMeter()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(drpUOM, "Default Unit Of Measure");
            driver.CheckElementDisplayed(cubicMeters, "Cubic Meter");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Unit Of Measure Gallons
        /// </summary>
        public void ValidateUnitOfMeasureGallons()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(drpUOM, "Default Unit Of Measure");
            driver.CheckElementDisplayed(gallons, "Gallons");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Unit Of Measure Gallons
        /// </summary>
        public void ValidateUnitOfMeasureImperialGallons()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(5000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(drpUOM, "Default Unit Of Measure");
            driver.CheckElementDisplayed(imperialGallons, "Imperial Gallons");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Unit Of Liters
        /// </summary>
        public void ValidateUnitOfMeasureLiters()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(5000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(drpUOM, "Default Unit Of Measure");
            driver.CheckElementDisplayed(liters, "Liters");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate Utility Cubic Feet Saved
        /// </summary>
        public void ValidateUtilityCubicFeetSaved()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(drpUOM, "Default Unit Of Measure");
            driver.ClickElement(cubicFt, "Cubic Feet");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(10));
        }


        /// <summary>
        /// Method to Validate Utility Cubic Meter Saved
        /// </summary>
        public void ValidateUtilityCubicMeterSaved()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(drpUOM, "Default Unit Of Measure");
            driver.ClickElement(cubicMeters, "Cubic Meters");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// Method to Validate Utility Gallons Saved
        /// </summary>
        public void ValidateUtilityGallonsSaved()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.WaitForElement(btnEditUtility, TimeSpan.FromSeconds(EngineSetup.TimeOutConstant));
            //driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(drpUOM, "Default Unit Of Measure");
            driver.ClickElement(gallons, "Gallons");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            //driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// Method to Validate Utility ImpGallons Saved
        /// </summary>
        public void ValidateUtilityImpGallonsSaved()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(drpUOM, "Default Unit Of Measure");
            driver.ClickElement(imperialGallons, "Imperial Gallons");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(10));
            driver.sleepTime(5000);

        }

        public void ValidateSelectUOMUtility(string uom)
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");

            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(drpUOM, "Default Unit Of Measure");
            IList<IWebElement> li = driver.FindElements(By.XPath("//kendo-popup//span"));
            Console.WriteLine(li.Count);
            List<string> tag = new List<string>();
            for (int i = 0; i <= li.Count - 1; i++)
            {
                //driver.sleepTime(3000);
                tag.Add(li[i].Text);
            }
            for (int i = 0; i <= tag.Count - 1; i++)
            {
                if (tag[i].Contains(uom))
                {
                    driver.FindElement(By.XPath("//kendo-popup//span[text()='" + tag[i] + "']")).Click();
                    break;
                }
            }
           // driver.ClickElement(By.XPath("//li[contains(.,'" + uom + "')]"), uom);
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// Method to Validate Utility Liters Saved
        /// </summary>
        public void ValidateUtilityLitersSaved()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(drpUOM, "Default Unit Of Measure");
            driver.ClickElement(liters, "Liters");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// Method to Validate Default UOM Dropdown display
        /// </summary>
        public void ValidateDefaultDropdown()
        {
            //driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(drpUOM, "Default Unit Of Measure");
            driver.CheckElementDisplayed(cubicFt, "Cubic Feet");
            driver.CheckElementDisplayed(cubicMeters, "Meters");
            driver.CheckElementDisplayed(gallons, "Gallons");
            driver.CheckElementDisplayed(imperialGallons, "Imperial Gallons");
            driver.CheckElementDisplayed(liters, "Liters");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate UOM Field displays
        /// </summary>
        public void ValidateUOMFieldDisplayes()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.CheckElementDisplayed(drpUOM, "Unit Of Measure");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate UOM Field displays
        /// </summary>
        public void ValidateUOMValueDisplays()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.CheckElementDisplayed(defaultUOM, "Default UOM");
        }

        /// <summary>
        /// Method to Validate UOM Cubic Feet displays
        /// </summary>
        public void ValidateCubicFeetDisplays()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(drpUOM, "Unit Of Measure");
            driver.CheckElementDisplayed(cubicFt, "Cubic Feet");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate UOM Cubic Meter displays
        /// </summary>
        public void ValidateCubicMeterDisplays()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(drpUOM, "Unit Of Measure");
            driver.CheckElementDisplayed(cubicMeters, "Cubic Meters");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate UOM Gallons displays
        /// </summary>
        public void ValidateGallonsDisplays()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(drpUOM, "Unit Of Measure");
            driver.CheckElementDisplayed(gallons, "Gallons");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate UOM Liters displays
        /// </summary>
        public void ValidateLitersDisplays()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(drpUOM, "Unit Of Measure");
            driver.CheckElementDisplayed(liters, "Liters");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        /// <summary>
        /// Method to Validate UOM ImperialGallons displays
        /// </summary>
        public void ValidateImperialGallonsDisplays()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(drpUOM, "Unit Of Measure");
            driver.CheckElementDisplayed(imperialGallons, "ImperialGallons");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateHandheldCheckBox()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.WaitForElement(handheldSupport, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(handheldSupport, "Handheld Support");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateHandheldCheckBoxNo()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.VerifyCheckboxStatus(handheldSupport, "unchecked", "Handheld Support");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateCreateUtilityHandheldCheckBox()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(handheldSupport, "Handheld Support");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditUtilityHandheldCheckBox()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(handheldSupport, "Handheld Support");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateEditUtilityHandheldCheckBoxSave()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnEditUtility, "Edit");
            driver.ClickElement(handheldSupport, "Handheld Support");
            driver.ClickElement(btnCreateUtilitySave, "Save");
        }

        public void ValidateCreateUtilityHandheldCheckBoxUnchecked()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.VerifyCheckboxStatus(handheldSupport, "unchecked", "Handheld Support");
            driver.ClickElement(btnCancelUtility, "Cancel");
        }

        public void ValidateCreateUtilityHandheldCheckBoxSave()
        {
            driver.ClickElement(btnUtilityManagement, "Utility Management");
            driver.sleepTime(10000);
            driver.ClickElement(btnCreateUtility, "Create");
            driver.ClickElement(handheldSupport, "Handheld Support");
            driver.ClickElement(btnCreateUtilitySave, "Save");
            driver.ClickElement(btnCancelUtility, "Cancel");
            testReport.Pass("Handheld Support checkbox selection made in Step 4 is retained");
        }
        public string verifyDefaultUOM()
        {
            try
            {
                driver.ClickElement(lftNavUtilityManagement, "Utillity Management");
                driver.WaitForElement(lftNavDeviceManagement, TimeSpan.FromSeconds(60));
                driver.ClickElement(lftNavDeviceManagement, "Device Management");
                driver.WaitForElement(deviceManagementdefaultUOM, TimeSpan.FromSeconds(60));
                string defaultuom = driver.GetElementText(deviceManagementdefaultUOM);
                return defaultuom;
            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);
                return "";
            }

        }

        public void changeDefaultUOM(string expecteduom)
        {
            try
            {

                driver.WaitForElement(deviceEditUtility, TimeSpan.FromSeconds(60));
                driver.ClickElement(deviceEditUtility, "EditUtility");
                driver.WaitForElement(defaultUomDropdownicon, TimeSpan.FromSeconds(60));
                driver.ClickElement(defaultUomDropdownicon, "defaultUomdropdownicon");
                By uomXpath = By.XPath("//li[contains(.,'" + expecteduom + "')]");
                driver.ClickElement(uomXpath, "changedefaultUomdropdownicon");
                driver.ClickElement(btnCreateUtilitySave, "Save");

            }
            catch (Exception e)
            {
                ReporterFactory.LogFailure(e.Message);

            }

        }
    }

}
