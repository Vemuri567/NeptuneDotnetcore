using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Globalization;

namespace Neptune360UIAutomation
{
    public class BillingServicesExportHistoryPage : AbstractTemplatePage
    {
        #region UI Object Repository
        private By colFileName = By.XPath("//table//th[2]");
        private By colExportDate = By.XPath("//table//th[3]");
        private By colExportSettings = By.XPath("//table//th[4]");
        private By iconDefaultDescending = By.XPath("//table//th[3]//span");
        private By drpResultsPerPage = By.XPath("//kendo-dropdownlist");
        private By iconExpandFile = By.XPath("//kendo-grid-list//table//tr[1]//a");
        private By colRouteName = By.XPath("//kendo-grid-list//th[text()='Route Name']");
        private By colTotalMeters = By.XPath("//kendo-grid-list//th[text()='Total Meters']");
        private By colTotalComplete = By.XPath("//kendo-grid-list//th[text()='Total Complete']");
        private By colTotalIncomplete = By.XPath("//kendo-grid-list//th[text()='Total Incomplete']");
        private By colTotalInvalid = By.XPath("//kendo-grid-list//th[text()='Total Invalid']");
        private By colTotalSkipped = By.XPath("//kendo-grid-list//th[text()='Total Skipped']");
        private By colTotalExported = By.XPath("//kendo-grid-list//th[text()='Total Exported']");
        private By lnkPaginationFirst = By.XPath("//span[@title='Go to the first page']");
        private By lnkPaginationPrevious = By.XPath("//span[@title='Go to the previous page']");
        private By lnkPaginationNext = By.XPath("//span[@title='Go to the next page']");
        private By lnkPaginationLast = By.XPath("//span[@title='Go to the last page']");
        private By txtRouteFilter = By.Id("txtRouteFilter");
        private By btnSearch = By.XPath("//button[text()='Search']");
        private By errorMsgNoRecords = By.XPath("//td[text()=' No records available. ']");
        
        #endregion

        /// <summary>
        /// Method to Validate ExportHistory Columns Display
        /// </summary>
        public void ValidateExportHistoryColumnsDisplay()
        {
            driver.CheckElementExists(colFileName, "File Name");
            driver.CheckElementExists(colExportDate, "Export Date");
            driver.CheckElementExists(iconDefaultDescending, "Default Descending");
            driver.CheckElementExists(colExportSettings, "Export Settings");
        }

        /// <summary>
        /// Method to Validate Results Per Page Option Display
        /// </summary>
        public void ValidateResulsPerPageOptionDisplay()
        {
            driver.CheckElementExists(drpResultsPerPage, "Results Per Page Option");
        }

        /// <summary>
        /// Method to Validate Results Per Page Default Value
        /// </summary>
        public void ValidateResultsPerPageDefaultValue()
        {
            string defaultValue = driver.GetElementText(drpResultsPerPage);
            if (defaultValue == "10")
                testReport.Pass("By Default: <mark>" + defaultValue + "</mark> is displayed");
            else
                ReporterFactory.LogFailure("Displayed: <mark>" + defaultValue + "</mark>, Expected Default value 10");
        }

        /// <summary>
        /// Method to Validate Export File Summary Details Table Columns Display
        /// </summary>
        public void ValidateExportFileSummaryDetailsTableColumnsDisplay()
        {
            driver.ClickElement(iconExpandFile, "Expand File");
            driver.CheckElementExists(colRouteName, "Route Name");
            driver.CheckElementExists(colTotalMeters, "Total Meters");
            driver.CheckElementExists(colTotalComplete, "Total Complete");
            driver.CheckElementExists(colTotalIncomplete, "Total Incomplete");
            driver.CheckElementExists(colTotalInvalid, "Total Invalid");
            driver.CheckElementExists(colTotalSkipped, "Total Skipped");
            driver.CheckElementExists(colTotalExported, "Total Exported");
        }

        /// <summary>
        /// Method to Validate Export History Pagination Links Display
        /// </summary>
        public void ValidatePaginationLinksDisplay()
        {
            driver.CheckElementExists(lnkPaginationFirst, "First");
            driver.CheckElementExists(lnkPaginationLast, "Last");
            driver.CheckElementExists(lnkPaginationNext, "Next");
            driver.CheckElementExists(lnkPaginationPrevious, "Previous");
        }

        /// <summary>
        /// Method to Validate Pagination Links Disabled
        /// </summary>
        public void ValidatePaginationLinksDisabled()
        {
            driver.IsElementDisabled(lnkPaginationFirst, "First");
            driver.IsElementDisabled(lnkPaginationLast, "Last");
            driver.IsElementDisabled(lnkPaginationNext, "Next");
            driver.IsElementDisabled(lnkPaginationPrevious, "Previous");
        }

        /// <summary>
        /// Method to Validate Pagination Links Enabled
        /// </summary>
        public void ValidatePaginationLinksEnabled()
        {
            driver.IsElementEnabled(lnkPaginationFirst, "First");
            driver.IsElementEnabled(lnkPaginationLast, "Last");
            driver.IsElementEnabled(lnkPaginationNext, "Next");
            driver.IsElementEnabled(lnkPaginationPrevious, "Previous");
        }

        /// <summary>
        /// Method to Validate Pagination Links Next
        /// </summary>
        public void ValidatePaginationLinksNext()
        {
            driver.ClickElement(lnkPaginationNext, "Next");
        }

        /// <summary>
        /// Method to Validate Pagination Links Last
        /// </summary>
        public void ValidatePaginationLinksLast()
        {
            driver.ClickElement(lnkPaginationLast, "Last");
        }

        /// <summary>
        /// Method to Validate Pagination Links First
        /// </summary>
        public void ValidatePaginationLinksFirst()
        {
            driver.ClickElement(lnkPaginationLast, "");
            driver.ClickElement(lnkPaginationFirst, "First");
        }

        /// <summary>
        /// Method to Validate Pagination Links Previous
        /// </summary>
        public void ValidatePaginationLinksPrevious()
        {
            driver.ClickElement(lnkPaginationNext, "Next");
            driver.ClickElement(lnkPaginationPrevious, "Previous");
        }

        /// <summary>
        /// Method to Validate Filter By Route Name Search Field Display
        /// </summary>
        public void ValidateFilterByRouteNameSearchDisplay()
        {
            driver.CheckElementDisplayed(txtRouteFilter, "Route Filter");
        }

        /// <summary>
        /// Method to Validate Filter By Route Name Search Field Button Displayed
        /// </summary>
        public void ValidateSearchButtonDisplay()
        {
            driver.CheckElementDisplayed(btnSearch, "Route Filter Search");
        }

        /// <summary>
        /// Method to Validate Search Button Disabled
        /// </summary>
        public void ValidateSearchButtonDisabled()
        {
            driver.IsElementDisabled(btnSearch, "Route Filter Search");
        }

        /// <summary>
        /// Method to Validate Route File Search
        /// </summary>
        public void ValidateRouteFileSearch(string exportFileName)
        {
            driver.SendKeysToElement(txtRouteFilter, exportFileName, "Route Filter Search");
            driver.ClickElement(btnSearch, "Search");
        }

        /// <summary>
        /// Method to Validate Invalid Route File Search
        /// </summary>
        public void ValidateInvalidRouteFileSearch()
        {
            driver.SendKeysToElement(txtRouteFilter, "axy23", "Route Filter Search");
            driver.ClickElement(btnSearch, "Search");
            driver.CheckElementDisplayed(errorMsgNoRecords, "Error Message No Records Availble");
        }
    }
}
