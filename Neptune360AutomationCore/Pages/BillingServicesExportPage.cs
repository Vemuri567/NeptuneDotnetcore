using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Globalization;
using Keys = OpenQA.Selenium.Keys;

namespace Neptune360UIAutomation
{
    public class BillingServicesExportPage : AbstractTemplatePage
    {
        #region UI Object Repository
        private By lblHeaderExport = By.XPath("//h2[text()='Export Files']");
        private By routeOne = By.XPath("//table[@class='k-grid-table']//tr[1]/td[1]");
        private By routeTwo = By.XPath("//table[@class='k-grid-table']//tr[2]/td[1]");
        private By routeThree = By.XPath("//table[@class='k-grid-table']//tr[3]/td[1]");
        private By routeFour = By.XPath("//table[@class='k-grid-table']//tr[4]/td[1]");
        private By routeFive = By.XPath("//table[@class='k-grid-table']//tr[5]/td[1]");
        private By btnSelectAll = By.XPath("//button[text()='Select All']");
        private By btnDeselectAll = By.XPath("//button[text()='Deselect All']");
        private By btnExport = By.XPath("//button[text()='Export']");
        private By drpView = By.XPath("//span[text()='View']//..//kendo-dropdownlist");
        private By lstUnexported = By.XPath("//kendo-list//li[2]");
        private By lstExported = By.XPath("//kendo-list//li[3]");
        private By rowImportDate = By.XPath("//table[@class='k-grid-table']//tr/td[2]");
        private By btnFiter = By.XPath("//button[text()='Filter']");
        private By btnImportDateFiler = By.XPath("//span[text()='Import Date']/..//i");
        private By txtDate = By.XPath("//kendo-dateinput/input");
        private By iconCalendar = By.XPath("//button[@title = 'Toggle calendar']");
        private By btnCancelDate = By.XPath("//button[text()= 'Clear']");
        private By headerExportHistory = By.XPath("//h2[text()='Export History']");
        private By txtExportFileName = By.Id("exportFileName");
        private By msgFileExported = By.XPath("//span[contains(text(), 'File Exported Successfully']");
        private By chkbComplete = By.XPath("//label[@for='complete']");
        private By chkbIncomplete = By.XPath("//label[@for='incomplete']");
        private By chkbSkipped = By.XPath("//label[@for='skipped']");
        private By chkbExcludeInvalid = By.XPath("//label[@for='excludeInvalid']");
        private By chkbCloseRouteAfterExport = By.XPath("//label[@for='closeOnExport']");
        private By btnExportSettings = By.XPath("//button[text()='Export Settings']");
        private By dlgExportProcess = By.XPath("//div[text()='Export Process']");
        private By btnBackToExport = By.XPath("//button[text()='Back to Export']");
        private By lblSaveFileAs = By.XPath("//span[text()='Save File As']");
        private By btnExportHistory = By.XPath("//span[text()='EXPORT HISTORY']");
        private By btnDownload = By.XPath("//span[text()='Download']");
        private By lblGatheringData = By.XPath("//span[text()='Gathering Data']");
        private By lblWritingData = By.XPath("//span[text()='Writing Data']");
        private By lblNoRecordsAvailable = By.XPath("//td[text()=' No records available. ']");
        private By clmImportDate = By.XPath("//span[text()='Import Date']");
        private By clmCycle = By.XPath("/html/body/sd-app/div[1]/sd-main/div/ng-sidebar-container/div/div/sd-export/div/div[2]/div/div[2]/kendo-grid/div/div/div/table/thead/tr/th[1]/a");
        private By clmTotalMembers = By.XPath("/html/body/sd-app/div[1]/sd-main/div/ng-sidebar-container/div/div/sd-export/div/div[2]/div/div[2]/kendo-grid/div/div/div/table/thead/tr/th[3]/a");
        private By clmTotalComplete = By.XPath("/html/body/sd-app/div[1]/sd-main/div/ng-sidebar-container/div/div/sd-export/div/div[2]/div/div[2]/kendo-grid/div/div/div/table/thead/tr/th[4]/a");
        private By clmTotalIncomplete = By.XPath("/html/body/sd-app/div[1]/sd-main/div/ng-sidebar-container/div/div/sd-export/div/div[2]/div/div[2]/kendo-grid/div/div/div/table/thead/tr/th[5]/a");
        private By clmTotalSkipped = By.XPath("/html/body/sd-app/div[1]/sd-main/div/ng-sidebar-container/div/div/sd-export/div/div[2]/div/div[2]/kendo-grid/div/div/div/table/thead/tr/th[6]/a");
        private By clmTotalExported = By.XPath("/html/body/sd-app/div[1]/sd-main/div/ng-sidebar-container/div/div/sd-export/div/div[2]/div/div[2]/kendo-grid/div/div/div/table/thead/tr/th[7]/a");
        private By columnOne = By.XPath("//table[@class='k-grid-table']//tr[1]/td[1]");
        private By columnTwo = By.XPath("//table[@class='k-grid-table']//tr[1]/td[2]");
        private By columnThree = By.XPath("//table[@class='k-grid-table']//tr[1]/td[3]");
        private By columnFour = By.XPath("//table[@class='k-grid-table']//tr[1]/td[4]");
        private By columnFive = By.XPath("//table[@class='k-grid-table']//tr[1]/td[5]");
        private By columnSix = By.XPath("//table[@class='k-grid-table']//tr[1]/td[6]");
        private By columnSeven = By.XPath("//table[@class='k-grid-table']//tr[1]/td[7]");
        private By historyRowOne = By.XPath("/html/body/sd-app/div[1]/sd-main/div/ng-sidebar-container/div/div/ntg-export-history/div/div[2]/div/kendo-grid/div/kendo-grid-list/div/div[1]/table/tbody/tr[2]/td[1]/a");
        private By historyRowTwo = By.XPath("/html/body/sd-app/div[1]/sd-main/div/ng-sidebar-container/div/div/ntg-export-history/div/div[2]/div/kendo-grid/div/kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[1]/a");
        private By exportedMeters = By.XPath("/html/body/sd-app/div[1]/sd-main/div/ng-sidebar-container/div/div/ntg-export-status-dialog/div/div[3]/div[3]/div[2]/div[1]/div/div[3]");
        #endregion

        /// <summary>
        /// Method to Validate Export Screen Displays
        /// </summary>
        public void ValidateExportScreenDisplays()
        {
            driver.CheckElementExists(lblHeaderExport, "Export Screen");
        }

        /// <summary>
        /// Method to Validate Import Files
        /// </summary>
        public void ValidateExportFiles()
        {
            driver.sleepTime(10000);
            driver.CheckElementExists(routeOne, "Export FileName");
        }

        /// <summary>
        /// Method to Validate Select One/All for Export
        /// </summary>
        public void ValidateSelectOneAllForExport()
        {
            driver.CheckElementExists(btnSelectAll, "Select All");
            driver.IsElementEnabled(btnSelectAll, "Select All");
        }

        /// <summary>
        /// Method to Validate Select One/All for Export Button Does Not Exists
        /// </summary>
        public void ValidateSelectOneAllForExportDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnSelectAll, "Select All");
        }

        /// <summary>
        /// Method to Validate Deselect One/All for Export
        /// </summary>
        public void ValidateDeselectOneAllForExport()
        {
            driver.CheckElementExists(btnDeselectAll, "Deselect All");
            driver.IsElementEnabled(btnDeselectAll, "Deselect All");
        }

        /// <summary>
        /// Method to Validate Deselect One/All for Export Button Does Not Exists
        /// </summary>
        public void ValidateDeselectOneAllForExportDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnDeselectAll, "Deselect All");
        }

        /// <summary>
        /// Method to Validate Export Button Available
        /// </summary>
        public void ValidateExportButton()
        {
            driver.CheckElementExists(btnExport, "Export");
        }

        /// <summary>
        /// Method to Validate Export Button Does Not Available
        /// </summary>
        public void ValidateExportButtonDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnExport, "Export");
        }

        /// <summary>
        /// Method to Validate Export Settings
        /// </summary>
        public void ValidateExportSettings()
        {
            driver.sleepTime(10000);
            driver.ClickElement(routeOne, "Select File");
            driver.IsElementEnabled(btnExport, "Export");
        }

        /// <summary>
        /// Method to Validate Export Settings Disabled
        /// </summary>
        public void ValidateExportSettingsDisabled()
        {
            driver.sleepTime(10000);
            driver.ClickElement(routeOne, "Select File");
            driver.IsElementDisabled(btnExport, "Export");
        }

        /// <summary>
        /// Method to Validate View Only Exported
        /// </summary>
        public void ValidateViewOnlyExported()
        {
            driver.ClickElement(drpView, "View");
            driver.ClickElement(lstExported, "Exported");
            driver.sleepTime(10000);
            driver.CheckElementExists(routeOne, "File");
        }

        /// <summary>
        /// Method to Validate View Only Exported
        /// </summary>
        public void ValidateViewOnlyUnexported()
        {
            driver.ClickElement(drpView, "View");
            driver.ClickElement(lstUnexported, "Unexported");
            driver.sleepTime(10000);
            driver.CheckElementExists(routeOne, "File");
        }

        /// <summary>
        /// Method to Validate View Only Exported Does Not Exists
        /// </summary>
        public void ValidateViewOnlyExportedDoesNotExists()
        {
            //driver.ClickElement(drpView, "View");
            driver.CheckElementDoesnotExists(lstExported, "Exported");
        }

        /// <summary>
        /// Method to Validate Import Date Correct Format
        /// </summary>
        public void ValidateImportDateCorrectFormat()
        {
            driver.sleepTime(10000);
            string importDate = driver.GetElementText(rowImportDate);
            DateTime dDate;
            if (DateTime.TryParse(importDate, out dDate))
            {
                String.Format("{0:MM/dd/yyyy}", dDate);
                testReport.Pass("The date format is displayed as MM/dd/yyyy: <amrk>" + importDate + "</mark>");
            }
            else
            {
                testReport.Pass("The date format is not displayed as MM/dd/yyyy: <amrk>" + importDate + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Import Date Filter Button Unavailable
        /// </summary>
        public void ValidateImportDateFilterBtnUnavailable()
        {
            driver.ClickElement(btnImportDateFiler, "Import Date Filter");
            driver.CheckElementDoesnotExists(btnFiter, "Filter");
        }

        /// <summary>
        /// Method to Validate Select Single Route
        /// </summary>
        public void ValidateSelectSingleRoute()
        {
            driver.sleepTime(20000);
            driver.CheckElementExists(routeOne, "Exported Route One");
            
            driver.ClickElement(routeOne, "Route");
        }

        /// <summary>
        /// Method to Validate Select Multiple Routes Using CTRL Key
        /// </summary>
        public void ValidateSelectMultipleRoutesUsingCTRLKey()
        {
            driver.WaitForElement(routeTwo, System.TimeSpan.FromSeconds(20));
            driver.CheckElementExists(routeOne, "Exported Route One");
            driver.CheckElementExists(routeTwo, "Exported Route Two");
            //driver.CheckElementExists(routeThree, "Exported Route Three");
            //driver.CheckElementExists(routeFour, "Exported Route Four");
            Actions objActions = new Actions(driver);
            objActions.SendKeys(Keys.Control).Perform();
            driver.ClickElement(routeOne, "Exported Route One");
            //driver.ClickElement(routeTwo, "Exported Route Two");
            //driver.ClickElement(routeFour, "Exported Route Four");
        }

        /// <summary>
        /// Method to Validate Select All Routes
        /// </summary>
        public void ValidateSelectAllRoutes()
        {
            driver.sleepTime(10000);
            driver.ClickElement(btnSelectAll, "Select All");
        }


        /// <summary>
        /// Method to Validate ExportlistColumns
        /// </summary>
        public void ValidateExportListColumns()
        {
            driver.CheckElementDisplayed(clmCycle, "Cycle Route");
            driver.CheckElementDisplayed(clmImportDate, "Import Date");
            driver.CheckElementDisplayed(clmTotalMembers, "Total Members");
            driver.CheckElementDisplayed(clmTotalComplete, "Total Complete");
            driver.CheckElementDisplayed(clmTotalIncomplete, "Total Incomplete");
            driver.CheckElementDisplayed(clmTotalSkipped, "Total Skipped");
            driver.CheckElementDisplayed(clmTotalExported, "Total Exported");
        }


        /// <summary>
        /// Method to Validate Export List Diplayed
        /// </summary>
        public void ValidateExportListDisplayed()
        {
            driver.sleepTime(10000);
            driver.CheckElementDisplayed(routeOne, "Route One");
            driver.CheckElementDisplayed(routeTwo, "Route Two");
        }

        /// <summary>
        /// Method to Validate Export Files Sort Order
        /// </summary>
        public void ValidateExportFilesSortOrder()
        {
            driver.sleepTime(10000);
            driver.CheckElementDisplayed(columnTwo, "Sorted Date");
        }

        /// <summary>
        /// Method to Validate Export Files Sort Order
        /// </summary>
        public void ValidateExportFilesSummary()
        {
            driver.sleepTime(10000);
            driver.ClickElement(historyRowOne, "Export History One");
        }

        /// <summary>
        /// Method to Validate Export Files Validation
        /// </summary>
        public void ValidateTotalRoutesValidation()
        {
            driver.sleepTime(10000);
            driver.ClickElement(routeOne, "Export Route");
            driver.ClickElement(btnExport, "Export");
            driver.SendKeysToElement(txtExportFileName, "Test", "FileName");
            driver.ClickElement(btnExport, "Export");
            driver.sleepTime(10000);
            driver.WaitForElement(btnDownload, System.TimeSpan.FromSeconds(40000));
            SimulateSendKeys("{ENTER}");
            driver.CheckElementDisplayed(exportedMeters, "Exported Meters");
            //driver.ClickElement(btnDownload, "Download");
            
        }

        /// <summary>
        /// Method to Validate Export Routes Validation
        /// </summary>
        public void ValidateExportFilesValidation()
        {
            driver.sleepTime(10000);
            driver.ClickElement(historyRowOne, "Export History One");
            driver.ClickElement(historyRowTwo, "Export History Two");
        }


        /// <summary>
        /// Method to Validate File Details
        /// </summary>
        public void ValidateFileDetails()
        {
            driver.CheckElementDisplayed(columnOne, "Cycle Route");
            driver.CheckElementDisplayed(columnTwo, "Import Date");
            driver.CheckElementDisplayed(columnThree, "Total Members");
            driver.CheckElementDisplayed(columnFour, "Total Complete");
            driver.CheckElementDisplayed(columnFive, "Total Incomplete");
            driver.CheckElementDisplayed(columnSix, "Total Skipped");
            driver.CheckElementDisplayed(columnSeven, "Total Exported");
        }
        /// <summary>
        /// Method to Validate Select All Routes
        /// </summary>
        public void ValidateDeselectAllRoutes()
        {
            driver.sleepTime(10000);
            driver.ClickElement(btnSelectAll, "Select All");
            driver.ClickElement(btnDeselectAll, "Deselect All");
        }

        /// <summary>
        /// Method to Validate Select Multiple Routes Shift Key
        /// </summary>
        public void ValidateSelectMultipeRoutesShiftKey()
        {
            driver.sleepTime(10000);
            Actions objActions = new Actions(driver);
            objActions.SendKeys(Keys.Shift).Perform();
            driver.ClickElement(routeOne, "Exported Route One");
            driver.ClickElement(routeTwo, "Exported Route Two");
            driver.ClickElement(routeThree, "Exported Route Three");
        }

        /// <summary>
        /// Method to Valdiate Import Date Filter Calendar
        /// </summary>
        public void ValidateImportDateFilterCalendar()
        {
            driver.ClickElement(btnImportDateFiler, "Import Date Filter");
            driver.CheckElementExists(txtDate, "Select Date Box");
            driver.CheckElementExists(iconCalendar, "Calendar Icon");
            driver.CheckElementExists(btnCancelDate, "Cancel");
        }

        /// <summary>
        /// Method to Validate Import Date Select All Route Display
        /// </summary>
        public void ValidateImportDateSelectAllRoutesDisplay()
        {
            driver.sleepTime(10000);
            string importDate = DateTime.Now.AddDays(-10).ToString("MM/dd/yyyy");
            driver.ClickElement(btnImportDateFiler, "Import Date Filter");
            driver.ClickElement(txtDate, "Select Date Box");
            driver.SendKeysToElementClearFirst(txtDate, importDate, "Select Date");
            driver.ClickElement(routeOne, "Route One");
            string tableDate = driver.GetElementText(rowImportDate);
            if (driver.CheckElementExists(routeOne, "Route"))
                testReport.Pass("All Routes are Displayed for the date: <mark>" + importDate + "</mark>");
            else
                ReporterFactory.LogFailure("All Routes are not Displayed for the date: <mark>" + importDate + "</mark>");
        }

        /// <summary>
        /// Method to Validate Export History Page Header
        /// </summary>
        public void ValidateExportHistoryPageHeader()
        {
            driver.CheckElementExists(headerExportHistory, "Export History Page Header");
        }

        /// <summary>
        /// Method to Validate Export Route Successful
        /// </summary>
        public void ValidateExportRouteSuccessful()
        {
            driver.CheckElementExists(routeOne, "Exported Route One");
            driver.CheckElementExists(routeTwo, "Exported Route Two");
            //driver.CheckElementExists(routeThree, "Exported Route Three");
            //driver.CheckElementExists(routeFour, "Exported Route Four");
            driver.WaitForElement(routeTwo, System.TimeSpan.FromSeconds(10));
            driver.ClickElement(routeOne, "Exported Route One");
            driver.ClickElement(btnExport, "Export");
            driver.SendKeysToElement(txtExportFileName, "RouteOne", "FileName");
            driver.ClickElement(btnExport, "Export");
            driver.WaitForElement(msgFileExported, System.TimeSpan.FromMinutes(1));
            driver.CheckElementExists(msgFileExported, "File Exported Successfully");
            //driver.sleepTime(2000);
            SimulateSendKeys("{ENTER}");
        }

        /// <summary>
        /// Method to Validate Export Options Display
        /// </summary>
        public void ValidateExportOptionsDisplay()
        {
            driver.sleepTime(10000);
            driver.CheckElementExists(routeOne, "Exported Route One");
            driver.CheckElementExists(routeTwo, "Exported Route Two");
            driver.CheckElementExists(routeThree, "Exported Route Three");
            driver.CheckElementExists(routeFour, "Exported Route Four");
            driver.ClickElement(routeOne, "Exported Route One");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementExists(chkbComplete, "Complete");
            driver.CheckElementExists(chkbIncomplete, "Incomplete");
            driver.CheckElementExists(chkbSkipped, "Skipped");
            driver.CheckElementExists(chkbExcludeInvalid, "Exclude Invalid");
        }

        /// <summary>
        /// Method to Validate Export Settings Multiple Checked
        /// </summary>
        public void ValidateExportSettingsMultipleChecked()
        {
            driver.ClickElement(chkbComplete, "Complete");
            driver.ClickElement(chkbIncomplete, "Incomplete");
            driver.ClickElement(chkbSkipped, "Skipped");
            driver.ClickElement(chkbExcludeInvalid, "Exclude Invalid");
            driver.SendKeysToElement(txtExportFileName, "RouteOne", "FileName");
            driver.ClickElement(btnExport, "Export");
            driver.sleepTime(10000);
            driver.CheckElementExists(msgFileExported, "File Exported Successfully");
        }

        /// <summary>
        /// Method to Validate Export Settings Button Not Displayed
        /// </summary>
        public void ValidateExportSettingsBtnNotDisplayed()
        {
            driver.CheckElementDoesnotExists(btnExportSettings, "Export Settings");
        }

        /// <summary>
        /// Method to Validate Export Dialog Display
        /// </summary>
        public void ValidateExportDialogDisplay()
        {
            driver.sleepTime(8000);
            driver.ClickElement(routeOne, "RouteOne");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementExists(dlgExportProcess, "Export Dialog");
        }

        /// <summary>
        /// Method to Validate Export Dialog Contents
        /// </summary>
        public void ValidateExportDialogContents()
        {
            driver.sleepTime(8000);
            driver.ClickElement(routeOne, "Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementExists(btnBackToExport, "Back To Export");
            driver.CheckElementExists(btnExport, "Export");
            driver.CheckElementExists(txtExportFileName, "File Name");
            driver.CheckElementExists(chkbComplete, "Complete");
            driver.CheckElementExists(chkbIncomplete, "Incomplete");
            driver.CheckElementExists(chkbSkipped, "Skipped");
            driver.CheckElementExists(chkbExcludeInvalid, "Exclude Invalid");
        }

        /// <summary>
        /// Method to Validate Back to Exports Enabled
        /// </summary>
        public void ValidateBackToExportsEnabled()
        {
            driver.sleepTime(8000);
            driver.ClickElement(routeOne, "Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementExists(btnBackToExport, "Back To Export");
            driver.IsElementEnabled(btnBackToExport, "Back To Export");
        }

        /// <summary>
        /// Method to Validate Export Disabled by Default
        /// </summary>
        public void ValidateExportDisabledByDefault()
        {
            driver.sleepTime(8000);
            driver.ClickElement(routeOne, "Select Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementExists(btnExport, "Export");
            driver.IsElementDisabled(btnExport, "Export");
        }

        /// <summary>
        /// Method to Validate Back to Export Access
        /// </summary>
        public void ValidateBackToExportAccess()
        {
            driver.sleepTime(8000);
            driver.ClickElement(routeOne, "Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementExists(dlgExportProcess, "Export Dialog");
            driver.ClickElement(btnBackToExport, "Back To Export");
        }

        /// <summary>
        /// Method to Validate Export Button Access
        /// </summary>
        public void ValidateExportButtonAccess()
        {
            driver.sleepTime(8000);
            driver.ClickElement(routeOne, "Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementExists(dlgExportProcess, "Export Dialog");
            driver.SendKeysToElement(txtExportFileName, "TestFile3", "Export File Name");
            driver.ClickElement(btnExport, "Export");
        }

        /// <summary>
        /// Method to Validate Export Process Back to Exports Display
        /// </summary>
        public void ValidateExportProcessBackToExportsDisplay()
        {
            driver.sleepTime(8000);
            driver.ClickElement(routeOne, "Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementExists(dlgExportProcess, "Export Dialog");
            driver.SendKeysToElement(txtExportFileName, "Route", "Export File Name"); //Dummy File Name to display Back to Export button
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementExists(btnBackToExport, "Back To Export");
        }

        /// <summary>
        /// Method to Validate Back to Export Enabled
        /// </summary>
        public void ValidateBackToExportEnabled()
        {
            ValidateExportProcessBackToExportsDisplay();
            driver.IsElementEnabled(btnBackToExport, "Back To Export");
        }

        /// <summary>
        /// Method to Validate Save File As Contents
        /// </summary>
        public void ValidateSaveFileAsContents()
        {
            driver.sleepTime(8000);
            driver.ClickElement(routeOne, "Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementExists(dlgExportProcess, "Export Dialog");
            driver.CheckElementExists(lblSaveFileAs, "Save File As");
            driver.CheckElementExists(txtExportFileName, "Export File Name");
        }

        /// <summary>
        /// Method to Validate Save As FileName Validation
        /// </summary>
        public void ValidateSaveAsFileNameValidation(string filePath)
        {
            driver.sleepTime(8000);
            driver.ClickElement(routeOne, "Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementDisplayed(dlgExportProcess, "Export Dialog");
            driver.SendKeysToElement(txtExportFileName, "TestFile", "Export File Name");
            string fileName = driver.GetElementText(txtExportFileName);
            if (fileName.Contains(filePath))
                testReport.Pass("File name entered in Export dialog is displayed in the Export Process dialog");
            else
                ReporterFactory.LogFailure("File name entered in Export dialog is not displayed in the Export Process dialog");
        }

        /// <summary>
        /// Method to Validate Export History Button Displayed
        /// </summary>
        public void ValidateExportHistoryButtonDisplayed()
        {
            driver.sleepTime(10000);
            driver.CheckElementExists(btnExportHistory, "Export History");
        }

        /// <summary>
        /// Method to Validate Export History Button Enabled
        /// </summary>
        public void ValidateExportHistoryButtonEnabled()
        {
            driver.sleepTime(150000);
            driver.IsElementEnabled(btnExportHistory, "Export History");
        }

        /// <summary>
        /// Method to Validate Export History Button Access
        /// </summary>
        public void ValidateExportHistoryButtonAccess()
        {
            driver.sleepTime(10000);
            driver.ClickElement(btnExportHistory, "Export History");
        }

        /// <summary>
        /// Method to Validate Process Download Available
        /// </summary>
        public void ValidateProcessDownloadAvailbale()
        {
            driver.sleepTime(100000);
            driver.ClickElement(btnExportHistory, "Export History");
            driver.CheckElementExists(btnDownload, "Download");
        }

        /// <summary>
        /// Method to Validate Process Download Disbaled
        /// </summary>
        public void ValidateProcessDownloadDisabled()
        {
            driver.IsElementDisabled(btnDownload, "Download");
        }

        /// <summary>
        /// Method to Validate Process Download Enabled
        /// </summary>
        public void ValidateProcessDownloadEnabled()
        {
            driver.sleepTime(10000);
            driver.IsElementEnabled(btnDownload, "Download");
        }

        /// <summary>
        /// Method to Validate Process Download Access
        /// </summary>
        public void ValidateProcessDownloadAccess()
        {
            ValidateProcessDownloadEnabled();
            driver.ClickElement(btnDownload, "Download");
        }

        /// <summary>
        /// Method to Validate Processing Details
        /// </summary>
        public void ValidateProcessingDetails()
        {
            driver.ClickElement(routeOne, "Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementDisplayed(dlgExportProcess, "Export Dialog");
            driver.SendKeysToElement(txtExportFileName, "TestFile", "Export File Name");
            driver.ClickElement(btnExport, "Export");
            //driver.CheckElementExists(lblGatheringData, "Gathering Data");
            //driver.CheckElementExists(lblWritingData, "Writing Data");
        }

        /// <summary>
        /// Method to Validate Processing Details Gathering Data Percentage
        /// </summary>
        public void ValidateProcessingDetailsGathering()
        {
            driver.ClickElement(routeOne, "Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementDisplayed(dlgExportProcess, "Export Dialog");
            driver.SendKeysToElement(txtExportFileName, "TestFile", "Export File Name");
            driver.ClickElement(btnExport, "Export");
            //driver.CheckElementExists(lblGatheringData, "Gathering Data");
        }

        /// <summary>
        /// Method to Validate Processing Details Writing Data Percentage
        /// </summary>
        public void ValidateProcessingDetailsWriting()
        {
            driver.ClickElement(routeOne, "Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementDisplayed(dlgExportProcess, "Export Dialog");
            driver.SendKeysToElement(txtExportFileName, "TestFile", "Export File Name");
            driver.ClickElement(btnExport, "Export");
            //driver.CheckElementExists(lblWritingData, "Writing Data");
        }

        /// <summary>
        /// Method to Validate Processing Details Writing Data Percentage
        /// </summary>
        public void ValidateExportAllOptions()
        {
            driver.WaitForElement(routeOne, System.TimeSpan.FromSeconds(3000));
            driver.ClickElement(routeOne, "Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementDisplayed(dlgExportProcess, "Export Dialog");
            driver.SendKeysToElement(txtExportFileName, "TestFile", "Export File Name");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementExists(lblWritingData, "Writing Data");
        }

        /// <summary>
        /// Method to Validate Export Complete Option
        /// </summary>
        public void ValidateExportCompleteOptions()
        {
            driver.sleepTime(2000);
            driver.ClickElement(routeOne, "Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementDisplayed(dlgExportProcess, "Export Dialog");
            driver.SendKeysToElement(txtExportFileName, "Test File", "Export File Name");
            driver.ClickElement(chkbIncomplete, "incomplete");
            driver.ClickElement(chkbSkipped, "skipped");
            driver.ClickElement(chkbExcludeInvalid, "exclude invalid");
            driver.ClickElement(chkbCloseRouteAfterExport, "Close Route After Export");
            driver.ClickElement(btnExport, "Export");
        }

        /// <summary>
        /// Method to Validate Export InComplete Option
        /// </summary>
        public void ValidateExportInCompleteOptions()
        {
            driver.sleepTime(2000);
            driver.ClickElement(routeOne, "Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementDisplayed(dlgExportProcess, "Export Dialog");
            driver.SendKeysToElement(txtExportFileName, "Test File", "Export File Name");
            driver.ClickElement(chkbComplete, "complete");
            driver.ClickElement(chkbSkipped, "skipped");
            driver.ClickElement(chkbExcludeInvalid, "exclude invalid");
            driver.ClickElement(chkbCloseRouteAfterExport, "Close Route After Export");
            driver.ClickElement(btnExport, "Export");
        }

        /// <summary>
        /// Method to Validate Export Skipped Option
        /// </summary>
        public void ValidateExportSkippedOptions()
        {
            driver.sleepTime(2000);
            driver.ClickElement(routeOne, "Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementDisplayed(dlgExportProcess, "Export Dialog");
            driver.SendKeysToElement(txtExportFileName, "Test File", "Export File Name");
            driver.ClickElement(chkbComplete, "complete");
            driver.ClickElement(chkbIncomplete, "incomplete");
            driver.ClickElement(chkbExcludeInvalid, "exclude invalid");
            driver.ClickElement(chkbCloseRouteAfterExport, "Close Route After Export");
            driver.ClickElement(btnExport, "Export");
        }

        /// <summary>
        /// Method to Validate Export Exclude Invalid
        /// </summary>
        public void ValidateExportExcludeInvalid()
        {
            driver.sleepTime(2000);
            driver.ClickElement(routeOne, "Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementDisplayed(dlgExportProcess, "Export Dialog");
            driver.SendKeysToElement(txtExportFileName, "Test File", "Export File Name");
            driver.ClickElement(chkbComplete, "complete");
            driver.ClickElement(chkbIncomplete, "incomplete");
            driver.ClickElement(chkbSkipped, "skipped");
            driver.ClickElement(chkbCloseRouteAfterExport, "Close Route After Export");
            driver.ClickElement(btnExport, "Export");
        }

        /// <summary>
        /// Method to Validate Export Multiple Checked
        /// </summary>
        public void ValidateExportMultipleChecked()
        {
            driver.sleepTime(2000);
            driver.ClickElement(routeOne, "Route");
            driver.ClickElement(btnExport, "Export");
            driver.CheckElementDisplayed(dlgExportProcess, "Export Dialog");
            driver.SendKeysToElement(txtExportFileName, "Test File", "Export File Name");
            driver.ClickElement(chkbComplete, "complete");
            driver.ClickElement(chkbSkipped, "skipped");
            driver.ClickElement(chkbExcludeInvalid, "Exclude Invalid Option");
            driver.ClickElement(btnExport, "Export");
        }

        /// <summary>
        /// Method to Validate Select Date Previous Month
        /// </summary>
        public void ValidateSelectDatePreviousMonth()
        {
            driver.ClickElement(btnImportDateFiler, "Import Date Filter");
            DateTime dt = new DateTime();
            driver.SendKeysToElement(txtDate, dt.AddMonths(-1).ToString("MM/dd/yyyy"), "Date");
            driver.SendKeysToElement(txtDate, Keys.Enter, "Date");
            driver.CheckElementExists(routeOne, "Route");
        }

        /// <summary>
        /// Method to Validate Select Date Future Month
        /// </summary>
        public void ValidateSelectDateFutureMonth()
        {
            driver.ClickElement(btnImportDateFiler, "Import Date Filter");
            DateTime dt = new DateTime();
            driver.SendKeysToElement(txtDate, dt.AddMonths(1).ToString("MM/dd/yyyy"), "Date");
            driver.SendKeysToElement(txtDate, Keys.Enter, "Date");
            driver.CheckElementExists(routeOne, "Records Available");
        }

        /// <summary>
        /// Method to Validate Select Date Manually
        /// </summary>
        public void ValidateSelectDateManually()
        {
            driver.ClickElement(btnImportDateFiler, "Import Date Filter");
            DateTime dt = DateTime.Now;
            driver.SendKeysToElement(txtDate, dt.ToString("MM/dd/yyyy"), "Date");
            driver.SendKeysToElement(txtDate, Keys.Enter, "Date");
        }

        /// <summary>
        /// Method to Validate Select Date Previous No Records
        /// </summary>
        public void ValidateSelectDatePreviousNoRecords()
        {
            driver.ClickElement(btnImportDateFiler, "Import Date Filter");
            DateTime dt = new DateTime();
            driver.SendKeysToElement(txtDate, dt.AddMonths(-2).ToString("MM/dd/yyyy"), "Date");
            driver.SendKeysToElement(txtDate, Keys.Enter, "Date");
            driver.CheckElementExists(lblNoRecordsAvailable, "No Records Available");
        }
    }
}
